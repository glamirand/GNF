Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading
Imports System.IO
Imports System.Net.Sockets
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.ComponentModel


Public Class frmMain

    'Public Shared ComPort As SerialPort
    Private WithEvents m_ComPort As New SerialPort

    Private m_ZeroData() As Byte = {0, 0, 0, 0, 0, 0, 0, 0}
    Private m_OnData() As Byte = {255, 255, 255, 255, 255, 255, 255, 255}
    Private m_EmptyData() As Byte = {}

    Private m_ACkEvent As New AutoResetEvent(False)
    Private Const NUM_CHANNELS As Integer = 6

    Private m_LogToAdd As New List(Of String)

    Private m_LastE131Frame As Date

    Private ProtocolReplies(255) As AwaitedReply

    Public m_UniverseNumber As Integer = 4
    Public m_EnableLiveDisplay As Boolean = True
    Public m_ChannelsPerUniverse() As Integer = {480, 480, 480, 480}
    Private Datas((512 * m_UniverseNumber) - 1) As Byte
    Public m_LiveDisplayColumns As Integer = 16
    Private Const m_StripLengthCount As Integer = 683





    Private Class AwaitedReply
        Public Command As Byte
        Public ID As Byte
        Public Datas As New List(Of Byte())
    End Class

    Private Enum CONFIG_IDs
        PLAY_PULSEWIDTH = 0
        FORCEON_PULSEWIDTH = 1
        STOP_PULSEWIDTH = 2
    End Enum
    ' 38 bytes
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Class RootLayer
        Public PreambleSize As Short
        Public PostambleSize As Short
        <VBFixedArray(12)> Public ACNID() As Byte
        Public Flags As Short
        Public Vector As Integer
        <VBFixedArray(16)> Public CID() As Byte
    End Class
    ' 77 bytes
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Class FramingLayer
        Public Flags As Short
        Public Vector As Integer
        <VBFixedArray(64)> Public SrcName() As Byte
        Public Priority As Byte
        Public Reserved As Short
        Public SequenceNumber As Byte
        Public Options As Byte
        Public Universe As Short
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Class DMPLayer
        Public Flags As Short
        Public Vector As Byte
        Public AddressType As Byte
        Public FirstPropAddress As Short
        Public AddressIncrement As Short
        Public PropertyValueCount As Short
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Class E131Frame
        Public RootLayer As RootLayer
        Public FramingLayer As FramingLayer
        Public DmpLayer As DMPLayer
    End Class


    Private WithEvents m_LSPClient As UdpClient
    Private WithEvents m_UDPWorker As New BackgroundWorker
    Private m_UDPWorkerOn As Boolean = True
    Private WithEvents m_DisplayWorker As New BackgroundWorker
    Private m_DisplayWorkerOn As Boolean = True
    Private WithEvents m_USBWorker As New BackgroundWorker
    Private m_USBWorkerOn As Boolean = True
    Private WithEvents m_SerialWorker As New BackgroundWorker
    Private m_SerialWorkerOn As Boolean = False
    Private Event ComPortStateChanged()
    Private Event OnComPortLog(ByVal Text As String)
    Private Event OnCommandReplied(ByVal Reply As AwaitedReply)
    Private Event OnChipConnection(ByVal Connected As Boolean)

#Region "Form events"

    Private Sub Comport_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim sPortName As String

        CloseComPort()

        sPortName = CType(sender, ToolStripMenuItem).Text

        If CType(sender, ToolStripMenuItem).Checked Then

            AddSerialLog("Port " & sPortName & " Openned.")
            My.Settings.Item("ComPort") = sPortName
            My.Settings.Save()
            OpenComPort()
        Else
            AddSerialLog("Port " & sPortName & " Closed.")
        End If
    End Sub

    Private Sub frmMain_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        USBRegister.RegisterDeviceNotifications(Me.Handle)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        FillComPortList()


        ' Open the UDP Client
        m_LSPClient = New UdpClient(5568)

        m_UDPWorker.WorkerSupportsCancellation = True
        m_UDPWorker.RunWorkerAsync()
        m_DisplayWorker.WorkerSupportsCancellation = True
        m_DisplayWorker.RunWorkerAsync()
        m_USBWorker.WorkerSupportsCancellation = True
        m_USBWorker.RunWorkerAsync()
        ' Open the com port
        If OpenComPort() Then
            'if we openned the comport, then clear log and Get Chip information
            lstSerialLog.Items.Clear()
            SendCommandToChip(Asc("I"), m_EmptyData)
        End If

        Dim V As Version = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version
        lblVersion.Text = "Version " & V.Major & "." & V.Minor

        If My.Settings.PosWidth > 0 And My.Settings.PosHeight > 0 And My.Settings.PosLeft > 0 And My.Settings.PosTop > 0 Then
            Me.Left = My.Settings.PosLeft
            Me.Top = My.Settings.PosTop
            Me.Width = My.Settings.PosWidth
            Me.Height = My.Settings.PosHeight
        End If

        tmrUpdateLog.Enabled = True

        SetStatus("Ready.")
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        m_UDPWorkerOn = False
        m_SerialWorkerOn = False
        m_DisplayWorkerOn = False
        m_USBWorkerOn = False


        'm_UDPWorker.CancelAsync()
        'm_SerialWorker.CancelAsync()

        CloseComPort()

        My.Settings.PosLeft = Me.Left
        My.Settings.PosTop = Me.Top
        My.Settings.PosWidth = Me.Width
        My.Settings.PosHeight = Me.Height
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub FillComPortList()
        tscComPort.ComboBox.Items.Clear()

        For Each sPort In SerialPort.GetPortNames()
            tscComPort.ComboBox.Items.Add(sPort)

            If sPort = My.Settings.Item("ComPort") Then
                If Not m_ComPort Is Nothing Then
                    If m_ComPort.IsOpen Then
                        tscComPort.ComboBox.SelectedItem = sPort
                    End If
                End If
            End If
        Next
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Dim DeviceKey As String
        Dim Keys() As String
        Dim DevInfo As New DEV_BROADCAST_DEVICEINTERFACE
        Dim PortName As String
       

        MyBase.WndProc(m)

        Select Case m.WParam
            Case DBT_DEVICEARRIVAL, DBT_DEVICEREMOVECOMPLETE

                Marshal.PtrToStructure(m.LParam, DevInfo)
                DeviceKey = System.Text.Encoding.Unicode.GetString(DevInfo.dbcc_name, 0, DevInfo.dbcc_size - 28)
                'DeviceKey = System.Text.Encoding.Unicode.GetString(DevInfo.dbcc_name, 0, DevInfo.dbcc_size)
                Keys = DeviceKey.Split("#")

                Try
                    Dim USBKey = My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Enum").OpenSubKey("USB")
                    Dim PortKey = USBKey.OpenSubKey(Keys(1)).OpenSubKey(Keys(2))
                    PortName = PortKey.OpenSubKey("Device Parameters").GetValue("PortName")

                    'if we have a matching new comport, then try to open it
                    If m.WParam = DBT_DEVICEARRIVAL Then
                        If PortName = My.Settings.ComPort Then
                            Thread.Sleep(500)
                            If OpenComPort() Then
                                RaiseEvent OnChipConnection(True)
                                'if we openned the comport, then clear log and Get Chip information
                                lstSerialLog.Items.Clear()
                                SendCommandToChip(Asc("I"), m_EmptyData)
                            End If

                        End If
                    End If

                    'if we have removed the comport, then close it
                    If m.WParam = DBT_DEVICEREMOVECOMPLETE Then
                        RaiseEvent OnChipConnection(False)
                        If PortName = My.Settings.ComPort Then
                            CloseComPort()
                        End If
                    End If

                Catch ex As Exception

                End Try
        End Select



    End Sub

    Private Sub SetStatus(ByVal Text As String, Optional ByVal Progress As Integer = 0)
        tslProgressText.Text = Text
        tlsProgressValue.Value = Progress
    End Sub

    Private Sub tmrUpdateLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdateLog.Tick
        While m_LogToAdd.Count > 0
            lstSerialLog.Items.Add(m_LogToAdd(0))
            lstSerialLog.SetSelected(lstSerialLog.Items.Count - 1, True)
            m_LogToAdd.RemoveAt(0)
        End While
    End Sub

    Private Sub OnChipConnectionChanged(ByVal Connected As Boolean) Handles Me.OnChipConnection
        tsbUpload.Enabled = Connected
        tsbInfo.Enabled = Connected
        tsbDebugLog.Enabled = Connected
        tsbResetChip.Enabled = Connected
    End Sub

#End Region

#Region "Serial Port management"

    Friend Function OpenComPort() As Boolean

        Static bAlreadyIn As Boolean

        If bAlreadyIn Then Return True
        bAlreadyIn = True

        CloseComPort()

        If My.Settings.ComPort <> "" Then
            With m_ComPort
                .PortName = My.Settings.ComPort
                .BaudRate = 115200 * 4
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = 1
                .Handshake = Handshake.None
                .ReadBufferSize = 128
                '.WriteBufferSize = 16
                .ReadTimeout = 1000
                .WriteTimeout = 100
            End With

            Try
                m_ComPort.Open()
                Me.Invoke(New Action(AddressOf UpdateComPortStatus))

                If Not m_SerialWorker.IsBusy Then
                    m_SerialWorker.WorkerSupportsCancellation = True
                    m_SerialWorkerOn = True
                    m_SerialWorker.RunWorkerAsync()

                End If

                bAlreadyIn = False
                Return True

            Catch ex As Exception
                CloseComPort()
            End Try
        End If

        bAlreadyIn = False
        Return False
    End Function

    Public Sub CloseComPort()
        Try
            m_ComPort.Close()
        Catch ex As Exception

        End Try

        Me.Invoke(New Action(AddressOf UpdateComPortStatus))
    End Sub

    Public Sub AddSerialLog(ByVal Log As String)
        m_LogToAdd.Add(Log)
    End Sub

    Public Function SendCommandToChip(ByVal Command As Byte, Optional ByVal Data() As Byte = Nothing) As Byte

        Dim CommandBytes(128) As Byte
        Dim DataLen As Integer

        If Not m_ComPort.IsOpen Then
            AddSerialLog("Unable to Send Command '" & Command & "', Port is closed.")
            Return 0
        Else
            ' Create the reply structure
            Dim CommandID As Byte = 0
            While Not ProtocolReplies(CommandID) Is Nothing
                If (CommandID = 255) Then
                    AddSerialLog("Unable to Send Command '" & Command & "', Too many unanswered requests.")
                    Return 0
                End If
                CommandID += 1
            End While

            'Dim Rep = New AwaitedReply() With {.Command = Command, .ID = CommandID}
            Dim Rep = New AwaitedReply()
            Rep.Command = Command
            Rep.ID = CommandID
            ProtocolReplies(CommandID) = Rep

            ' send command and ID
            CommandBytes(0) = Command
            CommandBytes(1) = CommandID
            If Not Data Is Nothing Then
                DataLen = Data.Length
                CommandBytes(2) = DataLen
                'BitConverter.GetBytes(DataLen).CopyTo(CommandBytes, 2)
                Data.CopyTo(CommandBytes, 3)
            End If

            Try
                m_ComPort.Write(CommandBytes, 0, DataLen + 3)
            Catch ex As Exception

            End Try


            Return CommandID
        End If

    End Function

    Public Function WaitCommandReply(ByVal CmdID As Byte) As Boolean
        Dim Counter As Integer = 0

        While Not ProtocolReplies(CmdID) Is Nothing
            Thread.Sleep(5)
            Counter += 1

            '500 ms timeout max
            If Counter > 100 Then
                Return False
            End If
        End While

        Return True
    End Function

    Private Sub m_SerialWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m_SerialWorker.DoWork
        Dim Message As String
        Dim Data(128) As Byte
        Dim CommandData() As Byte
        Dim Command As Byte
        Dim ID As Byte
        Dim DataLenBytes(3) As Byte
        Dim DataLen As Integer

        While m_SerialWorkerOn
            ' port should be openned here
            If m_ComPort.IsOpen Then
                If m_ComPort.BytesToRead >= 6 Then
                    Try
                        Command = m_ComPort.ReadByte
                        ID = m_ComPort.ReadByte
                        m_ComPort.Read(DataLenBytes, 0, 4)
                        DataLen = BitConverter.ToInt32(DataLenBytes, 0)

                        m_ComPort.Read(Data, 0, DataLen)
                        Data(DataLen) = 0

                        'Is it a log Line
                        If (Command = Asc("L")) And (ID = 0) Then
                            Me.Invoke(New Action(Of String)(AddressOf AddSerialLog), System.Text.Encoding.ASCII.GetString(Data))
                        Else
                            ' check if we have a matchign awaited reply
                            If Not ProtocolReplies(ID) Is Nothing Then
                                If ProtocolReplies(ID).Command = Command Then
                                    ReDim CommandData(DataLen - 1)
                                    Array.Copy(Data, CommandData, DataLen)
                                    ProtocolReplies(ID).Datas.Add(CommandData)
                                    Dim Reply As AwaitedReply = ProtocolReplies(ID)
                                    ProtocolReplies(ID) = Nothing

                                    Dim Result = Me.BeginInvoke(New Func(Of AwaitedReply, Boolean)(AddressOf OnProtocolReply), Reply)

                                    ' Command has been completed, release the reply slot
                                    'If Result Then
                                    '    ProtocolReplies(ID) = Nothing
                                    'End If

                                Else
                                    AddSerialLog("Command '" & Command & "' has has an invalid reply ID.")
                                End If
                            Else
                                AddSerialLog("Command '" & Command & "' has been ignored.")
                            End If
                        End If

                    Catch ex As Exception
                        Message = ex.Message

                    End Try
                End If
            End If
        End While

    End Sub

    Private Function OnProtocolReply(ByVal Reply As AwaitedReply) As Boolean
        Select Case Reply.Command

            Case Asc("R")
                AddSerialLog("Reseting Chip ...")
                ' clsoe the serial worker
                m_SerialWorkerOn = False

            Case Asc("D")
                'AddSerialLog("Define Command Acknowledged (ID = ." & Reply.ID & ")")

            Case Asc("L")
                AddSerialLog("--- End of Log")

            Case Asc("X")
                'AddSerialLog("Retrieve RX Values Completed. (ID = ." & Reply.ID & ")")

                Dim fValues(19) As Single
                Dim Bytes(fValues.Length * 4 - 1) As Byte

                For i As Integer = 0 To (Reply.Datas(0).Length / 4) - 1
                    fValues(i) = BitConverter.ToSingle(Reply.Datas(0), i * 4)
                Next

                Dim P As Panel
                For i = 1 To 10
                    P = CType(TabRX.Controls("pnlRX_Channel" & i), Panel)

                    If fValues(i - 1) > 100 Then fValues(i - 1) = 100
                    If fValues(i - 1) < -100 Then fValues(i - 1) = -100

                    CType(P.Controls("tcbRX_Value" & i), TrackBar).Value = CInt(fValues(i - 1))
                    CType(P.Controls("lblRX_Value" & i), Label).Text = fValues(i - 1).ToString("N1")
                Next

            Case Asc("F")
                AddSerialLog("Upload File Command Completed. (ID = ." & Reply.ID & ")")

            Case Asc("C")
                AddSerialLog("Chip configuration retrieved. (ID = ." & Reply.ID & ")")

                ' now retrieve the configuration data to update tab
                cboRXType.SelectedIndex = Reply.Datas(0)(1)
                cboStatusLedColor.SelectedIndex = Reply.Datas(0)(2)
        End Select
        Return True
    End Function

    Private Sub UpdateComPortStatus()
        If Not m_ComPort Is Nothing Then
            If m_ComPort.IsOpen Then
                tslComPort.Text = " Online on " & m_ComPort.PortName
                tslComPort.BackColor = Drawing.Color.LightGreen
                tscComPort.ComboBox.SelectedItem = My.Settings.ComPort
            Else
                tslComPort.Text = " Offline on " & m_ComPort.PortName
                tslComPort.BackColor = Drawing.Color.Red
            End If
        Else
            tslComPort.Text = " Offline."
            tslComPort.BackColor = Drawing.Color.Red
        End If
    End Sub
#End Region

#Region "Menus Management"

    Private Sub ClearLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogToolStripMenuItem.Click, tsbClearLog.Click
        lstSerialLog.Items.Clear()
    End Sub

    Private Sub ConvertSEQIntoDATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertSEQIntoDATToolStripMenuItem.Click
        With ofdFile
            .Title = "Convert SEQ File"
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            .Filter = "SEQ File|*.seq"

            If .ShowDialog() = DialogResult.OK Then

                Dim iTotalCount As Integer = 0


                '********************************************
                ' first count the lines
                '********************************************
                Dim Reader As FileStream = Nothing
                Dim Writer As FileStream = Nothing

                ' Open the source file
                Try
                    Reader = File.Open(ofdFile.FileName, FileMode.Open, FileAccess.Read)
                Catch ex As Exception
                    MsgBox("Unable to open File '" & ofdFile.FileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                ' Open the destination file
                Dim FileInfo As New FileInfo(ofdFile.FileName)
                Dim DestFileName As String = FileInfo.Directory.FullName & "\" & FileInfo.Name
                DestFileName = DestFileName.Substring(0, DestFileName.Length - FileInfo.Extension.Length)
                DestFileName = DestFileName & ".dat"


                Try
                    Writer = File.Open(DestFileName, FileMode.Create, FileAccess.Write)
                Catch ex As Exception
                    MsgBox("Unable to create File '" & DestFileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                Dim SrcBytes(16384 - 1) As Byte
                Dim DstBytesCount As Integer = m_StripLengthCount * 3
                Dim DstBytes(DstBytesCount - 1) As Byte
                Dim SampleCount As Integer = 0

                AddSerialLog("Converting file '" & IO.Path.GetFileName(ofdFile.FileName) & "' into  '" & New FileInfo(DestFileName).Name & "'...")
                While Reader.Read(SrcBytes, 0, SrcBytes.Length) > 0
                    'Offset += 4096

                    'Grab the desired lines
                    For i As Integer = 0 To DstBytesCount - 1
                        DstBytes(i) = SrcBytes(i * 4)
                    Next

                    'write the bytes in the file
                    Writer.Write(DstBytes, 0, DstBytesCount)

                    SampleCount += 1
                End While

                Writer.Close()
                Reader.Close()

                Dim Duration As New TimeSpan(0, 0, 0, 0, 50 * SampleCount)

                AddSerialLog("Conversion complete - " & SampleCount & " samples - " & Duration.Minutes & " min " & Duration.Seconds & " sec " & Duration.Milliseconds & " msec.")

            End If

        End With
    End Sub

    Private Sub ConvertCSVIntoDATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertCSVIntoDATToolStripMenuItem.Click

    End Sub

    Private Sub tsbDebugLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDebugLog.Click
        ClearLogToolStripMenuItem_Click(Nothing, Nothing)
        AddSerialLog("--- Retrieving Chip full Log :")
        SendCommandToChip(Asc("L"), m_EmptyData)
    End Sub

    Private Sub UploadFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadFileToolStripMenuItem.Click, tsbUpload.Click
        With ofdFile
            .Title = "Select File to upload"
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            .Filter = "File|*.*"

            If .ShowDialog() = DialogResult.OK Then

                Dim Reader As FileStream = Nothing
                ' Open teh source file
                Try
                    Reader = File.Open(ofdFile.FileName, FileMode.Open, FileAccess.Read)
                Catch ex As Exception
                    MsgBox("Unable to open File '" & ofdFile.FileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                ' Send the file command
                Dim DataFileName(32 - 1) As Byte
                Dim DataFileSize(4 - 1) As Byte
                Dim FI As New FileInfo(ofdFile.FileName)

                For i = 0 To FI.Name.Length - 1
                    DataFileName(i) = AscW(FI.Name(i))
                Next

                ' send the file header packet
                DataFileSize = BitConverter.GetBytes(CInt(FI.Length))

                Dim FullData(DataFileName.Length + DataFileSize.Length - 1) As Byte
                DataFileName.CopyTo(FullData, 0)
                DataFileSize.CopyTo(FullData, DataFileName.Length)

                SendCommandToChip(Asc("F"), FullData)

                'then send the data packet
                Dim DataBytes(48) As Byte
                AddSerialLog("Sending file '" & IO.Path.GetFileName(ofdFile.FileName) & "'...")
                Dim BytesRead As Integer
                Dim BytesSent As Integer = 0
                Do
                    'read the data
                    BytesRead = Reader.Read(DataBytes, 1, 48)
                    DataBytes(0) = BytesRead

                    If BytesRead > 0 Then
                        WaitCommandReply(SendCommandToChip(Asc("B"), DataBytes))
                    End If

                    BytesSent += BytesRead
                    tlsProgressValue.Value = BytesSent * 100 / FI.Length
                Loop Until BytesRead = 0

                Reader.Close()
                SetStatus("Upload completed.", 0)
            End If

        End With

    End Sub

    Private Sub tsbInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInfo.Click
        SendCommandToChip(Asc("I"), m_EmptyData)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click, tsbResetChip.Click
           SendCommandToChip(Asc("R"), m_EmptyData)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click, tsbQuit.Click
        Me.Close()
    End Sub

    Private Sub mnuConfSerialPort_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuConfSerialPort.DropDownOpening
        mnuConfSerialPort.DropDownItems.Clear()

        For Each sPort In SerialPort.GetPortNames()
            Dim it As ToolStripMenuItem
            it = mnuConfSerialPort.DropDownItems.Add(sPort)
            it.CheckOnClick = True
            AddHandler it.CheckedChanged, AddressOf Comport_CheckedChanged

            If sPort = My.Settings.Item("ComPort") Then
                If Not m_ComPort Is Nothing Then
                    If m_ComPort.IsOpen Then
                        it.Checked = True
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click, tsbAbout.Click
        frmSplash.ShowDialog()
    End Sub

    Private Sub tscComPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tscComPort.SelectedIndexChanged
        If tscComPort.ComboBox.SelectedItem <> My.Settings.ComPort Then
            My.Settings.Item("ComPort") = tscComPort.ComboBox.SelectedItem
            My.Settings.Save()
            OpenComPort()
        End If
    End Sub

#End Region

#Region "Manual Testing"
    Private Sub tcbCHX_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcbCH1.Scroll, tcbCH2.Scroll, tcbCH3.Scroll, tcbCH4.Scroll, tcbCH5.Scroll, tcbCH6.Scroll, tcbCH7.Scroll, tcbCH8.Scroll
        Dim Values(2 + 1 + 8 - 1) As Byte

        ' Channel Start
        Values(0) = 0
        Values(1) = 0

        ' Channel Count
        Values(2) = 8


        Values(3 + 0) = tcbCH1.Value
        Values(3 + 1) = tcbCH2.Value
        Values(3 + 2) = tcbCH3.Value
        Values(3 + 3) = tcbCH4.Value
        Values(3 + 4) = tcbCH5.Value
        Values(3 + 5) = tcbCH6.Value
        Values(3 + 6) = tcbCH7.Value
        Values(3 + 7) = tcbCH8.Value

        lblCH1.Text = Values(3 + 0)
        lblCH2.Text = Values(3 + 1)
        lblCH3.Text = Values(3 + 2)
        lblCH4.Text = Values(3 + 3)
        lblCH5.Text = Values(3 + 4)
        lblCH6.Text = Values(3 + 5)
        lblCH7.Text = Values(3 + 6)
        lblCH8.Text = Values(3 + 7)

        SendCommandToChip(Asc("D"), Values)
        
    End Sub
#End Region

#Region "LSP Network Management"

    Private Sub m_UDPWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m_UDPWorker.DoWork
        Dim ep As New IPEndPoint(IPAddress.Any, 0)
        Dim Data() As Byte
        Dim ValuesperPacket As Integer = 16 * 3
        Dim Values(2 + 1 + ValuesperPacket - 1) As Byte
        Dim DMXPacketStart As Integer = 126
        m_LSPClient.JoinMulticastGroup(IPAddress.Parse("239.255.0.1"))
        While m_UDPWorkerOn

            Data = m_LSPClient.Receive(ep)

            For id = 0 To Data.Length - DMXPacketStart - 1
                Datas(id + (Data(114) - 1) * (Data.Length - DMXPacketStart)) = Data(DMXPacketStart + id)
            Next
            m_LastE131Frame = Now
           
        End While
    End Sub

    Private Sub tmr_CheckE131_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_CheckE131.Tick
        If Now.Subtract(m_LastE131Frame).TotalMilliseconds >= 100 Then
            tlsE131.BackColor = Color.Red
        Else
            tlsE131.BackColor = Color.LightGreen
        End If
    End Sub

#End Region

    Private Sub TabMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabMain.SelectedIndexChanged
        tmrRX.Enabled = TabMain.SelectedTab Is TabRX

        If TabMain.SelectedTab Is TabSettings Then
            ' we are entering the tab settings, grab the configuration
            If Not WaitCommandReply(SendCommandToChip(Asc("C"), m_EmptyData)) Then
                MsgBox("Unable to retrieve configuration from chip : Timeout", MsgBoxStyle.Exclamation, "Timeout for request")
            End If

        End If
    End Sub

    Private Sub tmrRX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRX.Tick
        Static bAlreadyIn As Boolean = False

        If bAlreadyIn Then Return
        bAlreadyIn = True
        SendCommandToChip(Asc("X"), m_EmptyData)
        bAlreadyIn = False

    End Sub

    Private Sub cmdApplyConfiguration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyConfiguration.Click
        Dim ConfigData(2) As Byte

        ' Configuration version
        ConfigData(0) = 3

        ' Radio modulation type
        ConfigData(1) = cboRXType.SelectedIndex

        ' RX StatusLed Color
        ConfigData(2) = cboStatusLedColor.SelectedIndex

        If Not WaitCommandReply(SendCommandToChip(Asc("C"), ConfigData)) Then
            MsgBox("Unable to define configuration from chip : Timeout", MsgBoxStyle.Exclamation, "Timeout for request")
        End If
    End Sub

    Private Sub DefineGlobalStatus(ByVal value As Integer)
        For i = 0 To Datas.Length - 1
            Datas(i) = value
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DefineGlobalStatus(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, NumericUpDown1.ValueChanged
        DefineGlobalStatus(NumericUpDown1.Value)
    End Sub

    Private Sub m_DisplayWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m_DisplayWorker.DoWork
        'Live Show Grid Creation
        Dim NbColumns As Integer = 32
        Dim CellsSize As Integer = 35
        Dim ChannelGroup As Integer = 3
        Dim chColor As Color

        For j = 0 To m_LiveDisplayColumns - 1
            DataGridView1.Columns.Add(j, j + 1)
            DataGridView1.Columns(j).Width = CellsSize
        Next
        For i = 0 To (((m_UniverseNumber * 512) \ m_LiveDisplayColumns) \ ChannelGroup) - 0
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Height = CellsSize
        Next
        While m_DisplayWorkerOn
            If CB_LiveDisplay.Checked Then
                Try
                    For i = 0 To ((Datas.Length - 1) \ ChannelGroup) - 1
                        Select Case ChannelGroup
                            Case 1
                                If Datas(i * ChannelGroup + 0) = 0 Then
                                    chColor = Color.White
                                ElseIf Datas(i * ChannelGroup + 0) = 255 Then
                                    chColor = Color.Black
                                Else
                                    chColor = Color.Gray
                                End If

                            Case 3
                                chColor = Color.FromArgb(Datas(i * ChannelGroup + 0), Datas(i * ChannelGroup + 1), Datas(i * ChannelGroup + 2))
                        End Select

                        DataGridView1.Rows(i \ m_LiveDisplayColumns).Cells(i - ((i \ m_LiveDisplayColumns) * m_LiveDisplayColumns)).Style.BackColor = chColor
                    Next
                Catch ex As Exception
                    AddSerialLog(ex.Message)
                End Try
            End If
        End While
    End Sub

    Private Sub NUD_Columns_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUD_Columns.ValueChanged

        m_DisplayWorkerOn = False
        m_DisplayWorker.CancelAsync()
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        m_LiveDisplayColumns = NUD_Columns.Value
        m_DisplayWorkerOn = True
        m_DisplayWorker.RunWorkerAsync()
    End Sub


    Private Sub m_USBWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m_USBWorker.DoWork

        Dim ValuesperPacket As Integer = 16 * 3
        Dim Values(2 + 1 + ValuesperPacket - 1) As Byte
        Dim ValuesIndex As Integer
        Dim ValuesToSend As Integer

        While m_USBWorkerOn

            'Sending
            ValuesToSend = (Datas.Length)
            ValuesIndex = 0

            ' AddSerialLog("LSP : Uni_" & Universe & " - " & Hex(Data(126)) & " - " & Hex(Data(127)) & " - " & Hex(Data(128)) & " - " & Hex(Data(129)) & " - " & Hex(Data(130)) & " - " & Hex(Data(131)) & " - " & Hex(Data(132)) & " - " & Hex(Data(133)))

            While ValuesToSend > 0
                ' Compute start index for the packet
                Values(0) = ValuesIndex Mod 256
                Values(1) = ValuesIndex \ 256

                If ValuesToSend >= ValuesperPacket Then
                    'define the values count in the packer
                    Values(2) = ValuesperPacket

                    ' We have a full packet
                    For j = 0 To ValuesperPacket - 1
                        Values(3 + j) = Datas(ValuesIndex + j)
                    Next

                    ValuesToSend = ValuesToSend - ValuesperPacket
                Else
                    ' we have an incomplete packet
                    'define the values count in the packer
                    Values(2) = ValuesToSend

                    ' We have a full packet
                    For j = 0 To ValuesToSend - 1
                        Values(3 + j) = Datas(ValuesIndex + j)
                    Next

                    ValuesToSend = 0
                End If

                'Send the packet
                ' If ((Values(0) + (Values(1) * 256)) < 1800 - 48) Then
                If m_ComPort.IsOpen Then
                    SendCommandToChip(Asc("D"), Values)
                End If
                'End If
                ValuesIndex += ValuesperPacket

            End While
        End While
    End Sub
    Public cpt As Integer = 0
    Private Sub tmr_LiveDisplay_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr_LiveDisplay.Tick
        For i = 0 To Datas.Length - 4 Step 3
            If i = cpt Then
                Datas(i) = 255
                Datas(i + 1) = 0
                Datas(i + 2) = 0
            Else
                Datas(i) = 0
                Datas(i + 1) = 0
                Datas(i + 2) = 0
            End If
        Next
        If cpt >= Datas.Length Then
            cpt = 0
        Else
            cpt += 3
        End If
    End Sub

    Private Sub CB_Chenillard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Chenillard.CheckedChanged, NUD_Chenillard.ValueChanged
        If CB_Chenillard.Checked Then
            tmr_LiveDisplay.Enabled = True
            tmr_LiveDisplay.Interval = NUD_Chenillard.Value
        Else
            tmr_LiveDisplay.Enabled = False
            DefineGlobalStatus(0)
            cpt = 0
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        With sfdFile
            .Title = "Snag in DAT File"
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            .Filter = "DAT File|*.dat"

            If .ShowDialog() = DialogResult.OK Then
                Dim Writer As FileStream = Nothing
                Dim DestFileName As String = .FileName
                Dim DstBytesCount As Integer = m_StripLengthCount * 3
                Dim DstBytes(DstBytesCount - 2) As Byte
                Try
                    Writer = File.Open(DestFileName, FileMode.Create, FileAccess.Write)
                Catch ex As Exception
                    MsgBox("Unable to create File '" & DestFileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                For i As Integer = 0 To DstBytes.Length - 1
                    DstBytes(i) = Datas(i)
                Next
                    Writer.Write(DstBytes, 0, DstBytesCount - 1)
                Writer.Close()


                '    Dim iTotalCount As Integer = 0


                '    '********************************************
                '    ' first count the lines
                '    '********************************************
                '    Dim Reader As FileStream = Nothing


                '    ' Open the source file
                '    Try
                '        Reader = File.Open(ofdFile.FileName, FileMode.Open, FileAccess.Read)
                '    Catch ex As Exception
                '        MsgBox("Unable to open File '" & ofdFile.FileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                '        Exit Sub
                '    End Try

                '    ' Open the destination file
                '    Dim FileInfo As New FileInfo(ofdFile.FileName)
                '    Dim DestFileName As String = .FileName
                '    DestFileName = DestFileName.Substring(0, DestFileName.Length - FileInfo.Extension.Length)
                '    DestFileName = DestFileName & ".dat"


                '    Try
                '        Writer = File.Open(DestFileName, FileMode.Create, FileAccess.Write)
                '    Catch ex As Exception
                '        MsgBox("Unable to create File '" & DestFileName & "' for conversion : " & ex.Message, MsgBoxStyle.Critical)
                '        Exit Sub
                '    End Try

                '    Dim SrcBytes(16384 - 1) As Byte
                '    Dim DstBytesCount As Integer = m_StripLengthCount * 3
                '    Dim DstBytes(DstBytesCount - 1) As Byte
                '    Dim SampleCount As Integer = 0

                '    AddSerialLog("Converting file '" & IO.Path.GetFileName(ofdFile.FileName) & "' into  '" & New FileInfo(DestFileName).Name & "'...")
                '    While Reader.Read(SrcBytes, 0, SrcBytes.Length) > 0
                '        'Offset += 4096

                '        'Grab the desired lines
                '        For i As Integer = 0 To DstBytesCount - 1
                '            DstBytes(i) = SrcBytes(i * 4)
                '        Next

                '        'write the bytes in the file
                '        Writer.Write(DstBytes, 0, DstBytesCount)

                '        SampleCount += 1
                '    End While

                '    Writer.Close()
                '    Reader.Close()

                '    Dim Duration As New TimeSpan(0, 0, 0, 0, 50 * SampleCount)

                '    AddSerialLog("Conversion complete - " & SampleCount & " samples - " & Duration.Minutes & " min " & Duration.Seconds & " sec " & Duration.Milliseconds & " msec.")

            End If

        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class