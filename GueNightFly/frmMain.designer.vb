
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpComLog = New System.Windows.Forms.GroupBox()
        Me.lstSerialLog = New System.Windows.Forms.ListBox()
        Me.ctxLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlaySequenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopSequenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfSerialPort = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlayLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceONLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstMain = New System.Windows.Forms.StatusStrip()
        Me.tslProgressText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsProgressValue = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsE131 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslComPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.tmrUpdateLog = New System.Windows.Forms.Timer(Me.components)
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabSerial = New System.Windows.Forms.TabPage()
        Me.TabTest = New System.Windows.Forms.TabPage()
        Me.NUD_Chenillard = New System.Windows.Forms.NumericUpDown()
        Me.CB_Chenillard = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblCH8 = New System.Windows.Forms.Label()
        Me.tcbCH8 = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblCH7 = New System.Windows.Forms.Label()
        Me.tcbCH7 = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblCH6 = New System.Windows.Forms.Label()
        Me.tcbCH6 = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblCH5 = New System.Windows.Forms.Label()
        Me.tcbCH5 = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCH4 = New System.Windows.Forms.Label()
        Me.tcbCH4 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCH3 = New System.Windows.Forms.Label()
        Me.tcbCH3 = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCH2 = New System.Windows.Forms.Label()
        Me.tcbCH2 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCH1 = New System.Windows.Forms.Label()
        Me.tcbCH1 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabRX = New System.Windows.Forms.TabPage()
        Me.pnlRX_Channel10 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value10 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value10 = New System.Windows.Forms.Label()
        Me.lblRX_Name10 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel9 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value9 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value9 = New System.Windows.Forms.Label()
        Me.lblRX_Name9 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel8 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value8 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value8 = New System.Windows.Forms.Label()
        Me.lblRX_Name8 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel7 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value7 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value7 = New System.Windows.Forms.Label()
        Me.lblRX_Name7 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel6 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value6 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value6 = New System.Windows.Forms.Label()
        Me.lblRX_Name6 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel5 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value5 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value5 = New System.Windows.Forms.Label()
        Me.lblRX_Name5 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel4 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value4 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value4 = New System.Windows.Forms.Label()
        Me.lblRX_Name4 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel3 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value3 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value3 = New System.Windows.Forms.Label()
        Me.lblRX_Name3 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel2 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value2 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value2 = New System.Windows.Forms.Label()
        Me.lblRX_Name2 = New System.Windows.Forms.Label()
        Me.pnlRX_Channel1 = New System.Windows.Forms.Panel()
        Me.tcbRX_Value1 = New System.Windows.Forms.TrackBar()
        Me.lblRX_Value1 = New System.Windows.Forms.Label()
        Me.lblRX_Name1 = New System.Windows.Forms.Label()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.cboStatusLedColor = New System.Windows.Forms.ComboBox()
        Me.cmdApplyConfiguration = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboRXType = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NUD_Columns = New System.Windows.Forms.NumericUpDown()
        Me.CB_LiveDisplay = New System.Windows.Forms.CheckBox()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbQuit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbConvert = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ConvertSEQIntoDATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertCSVIntoDATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbUpload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbInfo = New System.Windows.Forms.ToolStripButton()
        Me.tsbDebugLog = New System.Windows.Forms.ToolStripButton()
        Me.tsbClearLog = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbResetChip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tscComPort = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tmr_CheckE131 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRX = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_LiveDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.grpComLog.SuspendLayout()
        Me.ctxLog.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.sstMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMain.SuspendLayout()
        Me.TabSerial.SuspendLayout()
        Me.TabTest.SuspendLayout()
        CType(Me.NUD_Chenillard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.tcbCH8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.tcbCH7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.tcbCH6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.tcbCH5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.tcbCH4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.tcbCH3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tcbCH2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tcbCH1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRX.SuspendLayout()
        Me.pnlRX_Channel10.SuspendLayout()
        CType(Me.tcbRX_Value10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel9.SuspendLayout()
        CType(Me.tcbRX_Value9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel8.SuspendLayout()
        CType(Me.tcbRX_Value8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel7.SuspendLayout()
        CType(Me.tcbRX_Value7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel6.SuspendLayout()
        CType(Me.tcbRX_Value6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel5.SuspendLayout()
        CType(Me.tcbRX_Value5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel4.SuspendLayout()
        CType(Me.tcbRX_Value4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel3.SuspendLayout()
        CType(Me.tcbRX_Value3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel2.SuspendLayout()
        CType(Me.tcbRX_Value2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRX_Channel1.SuspendLayout()
        CType(Me.tcbRX_Value1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NUD_Columns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpComLog
        '
        Me.grpComLog.Controls.Add(Me.lstSerialLog)
        Me.grpComLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpComLog.Location = New System.Drawing.Point(3, 3)
        Me.grpComLog.Name = "grpComLog"
        Me.grpComLog.Size = New System.Drawing.Size(647, 439)
        Me.grpComLog.TabIndex = 1
        Me.grpComLog.TabStop = False
        Me.grpComLog.Text = "Serial Communication Log"
        '
        'lstSerialLog
        '
        Me.lstSerialLog.ContextMenuStrip = Me.ctxLog
        Me.lstSerialLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSerialLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSerialLog.FormattingEnabled = True
        Me.lstSerialLog.ItemHeight = 14
        Me.lstSerialLog.Location = New System.Drawing.Point(3, 16)
        Me.lstSerialLog.Name = "lstSerialLog"
        Me.lstSerialLog.Size = New System.Drawing.Size(641, 420)
        Me.lstSerialLog.TabIndex = 0
        '
        'ctxLog
        '
        Me.ctxLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearLogToolStripMenuItem})
        Me.ctxLog.Name = "ctxLog"
        Me.ctxLog.Size = New System.Drawing.Size(172, 26)
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClearLogToolStripMenuItem.Text = "Empty Log"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ConfigurationToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadFileToolStripMenuItem, Me.ToolStripSeparator1, Me.PlaySequenceToolStripMenuItem, Me.StopSequenceToolStripMenuItem, Me.ForceONToolStripMenuItem, Me.ToolStripSeparator3, Me.ResetToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripSeparator4, Me.QuitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Remote"
        '
        'UploadFileToolStripMenuItem
        '
        Me.UploadFileToolStripMenuItem.Image = CType(resources.GetObject("UploadFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem"
        Me.UploadFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UploadFileToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.UploadFileToolStripMenuItem.Text = "&Upload Sequence from CSV"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(258, 6)
        '
        'PlaySequenceToolStripMenuItem
        '
        Me.PlaySequenceToolStripMenuItem.Image = CType(resources.GetObject("PlaySequenceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlaySequenceToolStripMenuItem.Name = "PlaySequenceToolStripMenuItem"
        Me.PlaySequenceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.PlaySequenceToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.PlaySequenceToolStripMenuItem.Text = "&Play Sequence"
        '
        'StopSequenceToolStripMenuItem
        '
        Me.StopSequenceToolStripMenuItem.Image = CType(resources.GetObject("StopSequenceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopSequenceToolStripMenuItem.Name = "StopSequenceToolStripMenuItem"
        Me.StopSequenceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.StopSequenceToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.StopSequenceToolStripMenuItem.Text = "&Stop Sequence"
        '
        'ForceONToolStripMenuItem
        '
        Me.ForceONToolStripMenuItem.Image = CType(resources.GetObject("ForceONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ForceONToolStripMenuItem.Name = "ForceONToolStripMenuItem"
        Me.ForceONToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ForceONToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ForceONToolStripMenuItem.Text = "&Force ON"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(258, 6)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = CType(resources.GetObject("ResetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ResetToolStripMenuItem.Text = "Reset Chip"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(261, 22)
        Me.ToolStripMenuItem3.Text = "Test Values"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(258, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConfSerialPort, Me.ToolStripSeparator2, Me.PlayLevelToolStripMenuItem, Me.StopLevelToolStripMenuItem, Me.ForceONLevelToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'mnuConfSerialPort
        '
        Me.mnuConfSerialPort.Image = CType(resources.GetObject("mnuConfSerialPort.Image"), System.Drawing.Image)
        Me.mnuConfSerialPort.Name = "mnuConfSerialPort"
        Me.mnuConfSerialPort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConfSerialPort.Size = New System.Drawing.Size(173, 22)
        Me.mnuConfSerialPort.Text = "Serial &Port"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'PlayLevelToolStripMenuItem
        '
        Me.PlayLevelToolStripMenuItem.Image = CType(resources.GetObject("PlayLevelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlayLevelToolStripMenuItem.Name = "PlayLevelToolStripMenuItem"
        Me.PlayLevelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.PlayLevelToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PlayLevelToolStripMenuItem.Text = "Play Level"
        '
        'StopLevelToolStripMenuItem
        '
        Me.StopLevelToolStripMenuItem.Image = CType(resources.GetObject("StopLevelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopLevelToolStripMenuItem.Name = "StopLevelToolStripMenuItem"
        Me.StopLevelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.StopLevelToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.StopLevelToolStripMenuItem.Text = "Stop Level"
        '
        'ForceONLevelToolStripMenuItem
        '
        Me.ForceONLevelToolStripMenuItem.Image = CType(resources.GetObject("ForceONLevelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ForceONLevelToolStripMenuItem.Name = "ForceONLevelToolStripMenuItem"
        Me.ForceONLevelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ForceONLevelToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ForceONLevelToolStripMenuItem.Text = "Force ON Level"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.GueNightFly.My.Resources.Resources.info
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "About ..."
        '
        'sstMain
        '
        Me.sstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslProgressText, Me.tlsProgressValue, Me.ToolStripStatusLabel1, Me.tlsE131, Me.tslComPort})
        Me.sstMain.Location = New System.Drawing.Point(0, 555)
        Me.sstMain.Name = "sstMain"
        Me.sstMain.Size = New System.Drawing.Size(661, 22)
        Me.sstMain.TabIndex = 4
        Me.sstMain.Text = "StatusStrip1"
        '
        'tslProgressText
        '
        Me.tslProgressText.Name = "tslProgressText"
        Me.tslProgressText.Size = New System.Drawing.Size(39, 17)
        Me.tslProgressText.Text = "Status"
        '
        'tlsProgressValue
        '
        Me.tlsProgressValue.Name = "tlsProgressValue"
        Me.tlsProgressValue.Size = New System.Drawing.Size(180, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(265, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'tlsE131
        '
        Me.tlsE131.AutoSize = False
        Me.tlsE131.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tlsE131.Name = "tlsE131"
        Me.tlsE131.Size = New System.Drawing.Size(40, 17)
        Me.tlsE131.Text = "E1.31"
        '
        'tslComPort
        '
        Me.tslComPort.AutoSize = False
        Me.tslComPort.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tslComPort.Name = "tslComPort"
        Me.tslComPort.Size = New System.Drawing.Size(120, 17)
        Me.tslComPort.Text = "COM"
        Me.tslComPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblVersion)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.PictureBox2)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 25)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(661, 58)
        Me.pnlHeader.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "by LongChair 2012"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(214, 32)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(130, 23)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = " Version 1.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(597, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(661, 58)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'ofdFile
        '
        Me.ofdFile.DefaultExt = "*.csv"
        '
        'tmrUpdateLog
        '
        Me.tmrUpdateLog.Interval = 50
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabSerial)
        Me.TabMain.Controls.Add(Me.TabTest)
        Me.TabMain.Controls.Add(Me.TabRX)
        Me.TabMain.Controls.Add(Me.TabSettings)
        Me.TabMain.Controls.Add(Me.TabPage1)
        Me.TabMain.Controls.Add(Me.TabPage2)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.ImageList = Me.imlTab
        Me.TabMain.Location = New System.Drawing.Point(0, 83)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(661, 472)
        Me.TabMain.TabIndex = 1
        '
        'TabSerial
        '
        Me.TabSerial.Controls.Add(Me.grpComLog)
        Me.TabSerial.ImageKey = "document.png"
        Me.TabSerial.Location = New System.Drawing.Point(4, 23)
        Me.TabSerial.Name = "TabSerial"
        Me.TabSerial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSerial.Size = New System.Drawing.Size(653, 445)
        Me.TabSerial.TabIndex = 0
        Me.TabSerial.Text = "Serial Communication Log"
        Me.TabSerial.UseVisualStyleBackColor = True
        '
        'TabTest
        '
        Me.TabTest.Controls.Add(Me.NUD_Chenillard)
        Me.TabTest.Controls.Add(Me.CB_Chenillard)
        Me.TabTest.Controls.Add(Me.Button2)
        Me.TabTest.Controls.Add(Me.Button1)
        Me.TabTest.Controls.Add(Me.NumericUpDown1)
        Me.TabTest.Controls.Add(Me.Panel8)
        Me.TabTest.Controls.Add(Me.Panel7)
        Me.TabTest.Controls.Add(Me.Panel6)
        Me.TabTest.Controls.Add(Me.Panel5)
        Me.TabTest.Controls.Add(Me.Panel4)
        Me.TabTest.Controls.Add(Me.Panel3)
        Me.TabTest.Controls.Add(Me.Panel2)
        Me.TabTest.Controls.Add(Me.Panel1)
        Me.TabTest.ImageIndex = 1
        Me.TabTest.Location = New System.Drawing.Point(4, 23)
        Me.TabTest.Name = "TabTest"
        Me.TabTest.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTest.Size = New System.Drawing.Size(653, 445)
        Me.TabTest.TabIndex = 1
        Me.TabTest.Text = "Online Manual Testing"
        Me.TabTest.UseVisualStyleBackColor = True
        '
        'NUD_Chenillard
        '
        Me.NUD_Chenillard.Location = New System.Drawing.Point(3, 339)
        Me.NUD_Chenillard.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Chenillard.Name = "NUD_Chenillard"
        Me.NUD_Chenillard.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Chenillard.TabIndex = 23
        Me.NUD_Chenillard.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'CB_Chenillard
        '
        Me.CB_Chenillard.AutoSize = True
        Me.CB_Chenillard.Location = New System.Drawing.Point(132, 342)
        Me.CB_Chenillard.Name = "CB_Chenillard"
        Me.CB_Chenillard.Size = New System.Drawing.Size(72, 17)
        Me.CB_Chenillard.TabIndex = 22
        Me.CB_Chenillard.Text = "Chenillard"
        Me.CB_Chenillard.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "ON"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "OFF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 313)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 18
        Me.NumericUpDown1.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblCH8)
        Me.Panel8.Controls.Add(Me.tcbCH8)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 269)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(647, 38)
        Me.Panel8.TabIndex = 16
        '
        'lblCH8
        '
        Me.lblCH8.ForeColor = System.Drawing.Color.Red
        Me.lblCH8.Location = New System.Drawing.Point(15, 15)
        Me.lblCH8.Name = "lblCH8"
        Me.lblCH8.Size = New System.Drawing.Size(52, 16)
        Me.lblCH8.TabIndex = 2
        Me.lblCH8.Text = "0"
        Me.lblCH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH8
        '
        Me.tcbCH8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH8.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH8.Maximum = 255
        Me.tcbCH8.Name = "tcbCH8"
        Me.tcbCH8.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH8.TabIndex = 1
        Me.tcbCH8.TickFrequency = 5
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 36)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Channel 8"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lblCH7)
        Me.Panel7.Controls.Add(Me.tcbCH7)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 231)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(647, 38)
        Me.Panel7.TabIndex = 15
        '
        'lblCH7
        '
        Me.lblCH7.ForeColor = System.Drawing.Color.Red
        Me.lblCH7.Location = New System.Drawing.Point(15, 18)
        Me.lblCH7.Name = "lblCH7"
        Me.lblCH7.Size = New System.Drawing.Size(52, 16)
        Me.lblCH7.TabIndex = 2
        Me.lblCH7.Text = "0"
        Me.lblCH7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH7
        '
        Me.tcbCH7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH7.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH7.Maximum = 255
        Me.tcbCH7.Name = "tcbCH7"
        Me.tcbCH7.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH7.TabIndex = 1
        Me.tcbCH7.TickFrequency = 5
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 36)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Channel 7"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblCH6)
        Me.Panel6.Controls.Add(Me.tcbCH6)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 193)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(647, 38)
        Me.Panel6.TabIndex = 14
        '
        'lblCH6
        '
        Me.lblCH6.ForeColor = System.Drawing.Color.Red
        Me.lblCH6.Location = New System.Drawing.Point(15, 18)
        Me.lblCH6.Name = "lblCH6"
        Me.lblCH6.Size = New System.Drawing.Size(52, 16)
        Me.lblCH6.TabIndex = 2
        Me.lblCH6.Text = "0"
        Me.lblCH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH6
        '
        Me.tcbCH6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH6.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH6.Maximum = 255
        Me.tcbCH6.Name = "tcbCH6"
        Me.tcbCH6.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH6.TabIndex = 1
        Me.tcbCH6.TickFrequency = 5
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 36)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Channel 6"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblCH5)
        Me.Panel5.Controls.Add(Me.tcbCH5)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 155)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(647, 38)
        Me.Panel5.TabIndex = 13
        '
        'lblCH5
        '
        Me.lblCH5.ForeColor = System.Drawing.Color.Red
        Me.lblCH5.Location = New System.Drawing.Point(15, 18)
        Me.lblCH5.Name = "lblCH5"
        Me.lblCH5.Size = New System.Drawing.Size(52, 16)
        Me.lblCH5.TabIndex = 2
        Me.lblCH5.Text = "0"
        Me.lblCH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH5
        '
        Me.tcbCH5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH5.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH5.Maximum = 255
        Me.tcbCH5.Name = "tcbCH5"
        Me.tcbCH5.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH5.TabIndex = 1
        Me.tcbCH5.TickFrequency = 5
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 36)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Channel 5"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblCH4)
        Me.Panel4.Controls.Add(Me.tcbCH4)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(647, 38)
        Me.Panel4.TabIndex = 12
        '
        'lblCH4
        '
        Me.lblCH4.ForeColor = System.Drawing.Color.Red
        Me.lblCH4.Location = New System.Drawing.Point(15, 18)
        Me.lblCH4.Name = "lblCH4"
        Me.lblCH4.Size = New System.Drawing.Size(52, 16)
        Me.lblCH4.TabIndex = 2
        Me.lblCH4.Text = "0"
        Me.lblCH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH4
        '
        Me.tcbCH4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH4.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH4.Maximum = 255
        Me.tcbCH4.Name = "tcbCH4"
        Me.tcbCH4.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH4.TabIndex = 1
        Me.tcbCH4.TickFrequency = 5
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Channel 4"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCH3)
        Me.Panel3.Controls.Add(Me.tcbCH3)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(647, 38)
        Me.Panel3.TabIndex = 11
        '
        'lblCH3
        '
        Me.lblCH3.ForeColor = System.Drawing.Color.Red
        Me.lblCH3.Location = New System.Drawing.Point(15, 20)
        Me.lblCH3.Name = "lblCH3"
        Me.lblCH3.Size = New System.Drawing.Size(52, 16)
        Me.lblCH3.TabIndex = 2
        Me.lblCH3.Text = "0"
        Me.lblCH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH3
        '
        Me.tcbCH3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH3.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH3.Maximum = 255
        Me.tcbCH3.Name = "tcbCH3"
        Me.tcbCH3.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH3.TabIndex = 1
        Me.tcbCH3.TickFrequency = 5
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 36)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Channel 3"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblCH2)
        Me.Panel2.Controls.Add(Me.tcbCH2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 38)
        Me.Panel2.TabIndex = 10
        '
        'lblCH2
        '
        Me.lblCH2.ForeColor = System.Drawing.Color.Red
        Me.lblCH2.Location = New System.Drawing.Point(15, 20)
        Me.lblCH2.Name = "lblCH2"
        Me.lblCH2.Size = New System.Drawing.Size(52, 16)
        Me.lblCH2.TabIndex = 2
        Me.lblCH2.Text = "0"
        Me.lblCH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH2
        '
        Me.tcbCH2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH2.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH2.Maximum = 255
        Me.tcbCH2.Name = "tcbCH2"
        Me.tcbCH2.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH2.TabIndex = 1
        Me.tcbCH2.TickFrequency = 5
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Channel 2"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCH1)
        Me.Panel1.Controls.Add(Me.tcbCH1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 38)
        Me.Panel1.TabIndex = 9
        '
        'lblCH1
        '
        Me.lblCH1.ForeColor = System.Drawing.Color.Red
        Me.lblCH1.Location = New System.Drawing.Point(15, 18)
        Me.lblCH1.Name = "lblCH1"
        Me.lblCH1.Size = New System.Drawing.Size(52, 16)
        Me.lblCH1.TabIndex = 2
        Me.lblCH1.Text = "0"
        Me.lblCH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcbCH1
        '
        Me.tcbCH1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbCH1.Location = New System.Drawing.Point(84, 0)
        Me.tcbCH1.Maximum = 255
        Me.tcbCH1.Name = "tcbCH1"
        Me.tcbCH1.Size = New System.Drawing.Size(561, 36)
        Me.tcbCH1.TabIndex = 1
        Me.tcbCH1.TickFrequency = 5
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Channel 1"
        '
        'TabRX
        '
        Me.TabRX.Controls.Add(Me.pnlRX_Channel10)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel9)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel8)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel7)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel6)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel5)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel4)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel3)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel2)
        Me.TabRX.Controls.Add(Me.pnlRX_Channel1)
        Me.TabRX.ImageKey = "wifi.png"
        Me.TabRX.Location = New System.Drawing.Point(4, 23)
        Me.TabRX.Name = "TabRX"
        Me.TabRX.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRX.Size = New System.Drawing.Size(653, 445)
        Me.TabRX.TabIndex = 2
        Me.TabRX.Text = "RX Monitor"
        Me.TabRX.UseVisualStyleBackColor = True
        '
        'pnlRX_Channel10
        '
        Me.pnlRX_Channel10.Controls.Add(Me.tcbRX_Value10)
        Me.pnlRX_Channel10.Controls.Add(Me.lblRX_Value10)
        Me.pnlRX_Channel10.Controls.Add(Me.lblRX_Name10)
        Me.pnlRX_Channel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel10.Location = New System.Drawing.Point(372, 3)
        Me.pnlRX_Channel10.Name = "pnlRX_Channel10"
        Me.pnlRX_Channel10.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel10.TabIndex = 9
        '
        'tcbRX_Value10
        '
        Me.tcbRX_Value10.AutoSize = False
        Me.tcbRX_Value10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value10.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value10.Maximum = 100
        Me.tcbRX_Value10.Minimum = -100
        Me.tcbRX_Value10.Name = "tcbRX_Value10"
        Me.tcbRX_Value10.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value10.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value10.TabIndex = 2
        Me.tcbRX_Value10.TickFrequency = 10
        Me.tcbRX_Value10.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value10
        '
        Me.lblRX_Value10.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value10.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value10.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value10.Name = "lblRX_Value10"
        Me.lblRX_Value10.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value10.TabIndex = 3
        Me.lblRX_Value10.Text = "0"
        Me.lblRX_Value10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name10
        '
        Me.lblRX_Name10.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name10.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name10.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name10.Name = "lblRX_Name10"
        Me.lblRX_Name10.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name10.TabIndex = 4
        Me.lblRX_Name10.Text = "10"
        Me.lblRX_Name10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel9
        '
        Me.pnlRX_Channel9.Controls.Add(Me.tcbRX_Value9)
        Me.pnlRX_Channel9.Controls.Add(Me.lblRX_Value9)
        Me.pnlRX_Channel9.Controls.Add(Me.lblRX_Name9)
        Me.pnlRX_Channel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel9.Location = New System.Drawing.Point(331, 3)
        Me.pnlRX_Channel9.Name = "pnlRX_Channel9"
        Me.pnlRX_Channel9.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel9.TabIndex = 8
        '
        'tcbRX_Value9
        '
        Me.tcbRX_Value9.AutoSize = False
        Me.tcbRX_Value9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value9.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value9.Maximum = 100
        Me.tcbRX_Value9.Minimum = -100
        Me.tcbRX_Value9.Name = "tcbRX_Value9"
        Me.tcbRX_Value9.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value9.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value9.TabIndex = 2
        Me.tcbRX_Value9.TickFrequency = 10
        Me.tcbRX_Value9.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value9
        '
        Me.lblRX_Value9.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value9.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value9.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value9.Name = "lblRX_Value9"
        Me.lblRX_Value9.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value9.TabIndex = 3
        Me.lblRX_Value9.Text = "0"
        Me.lblRX_Value9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name9
        '
        Me.lblRX_Name9.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name9.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name9.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name9.Name = "lblRX_Name9"
        Me.lblRX_Name9.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name9.TabIndex = 4
        Me.lblRX_Name9.Text = "9"
        Me.lblRX_Name9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel8
        '
        Me.pnlRX_Channel8.Controls.Add(Me.tcbRX_Value8)
        Me.pnlRX_Channel8.Controls.Add(Me.lblRX_Value8)
        Me.pnlRX_Channel8.Controls.Add(Me.lblRX_Name8)
        Me.pnlRX_Channel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel8.Location = New System.Drawing.Point(290, 3)
        Me.pnlRX_Channel8.Name = "pnlRX_Channel8"
        Me.pnlRX_Channel8.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel8.TabIndex = 7
        '
        'tcbRX_Value8
        '
        Me.tcbRX_Value8.AutoSize = False
        Me.tcbRX_Value8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value8.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value8.Maximum = 100
        Me.tcbRX_Value8.Minimum = -100
        Me.tcbRX_Value8.Name = "tcbRX_Value8"
        Me.tcbRX_Value8.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value8.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value8.TabIndex = 2
        Me.tcbRX_Value8.TickFrequency = 10
        Me.tcbRX_Value8.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value8
        '
        Me.lblRX_Value8.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value8.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value8.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value8.Name = "lblRX_Value8"
        Me.lblRX_Value8.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value8.TabIndex = 3
        Me.lblRX_Value8.Text = "0"
        Me.lblRX_Value8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name8
        '
        Me.lblRX_Name8.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name8.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name8.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name8.Name = "lblRX_Name8"
        Me.lblRX_Name8.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name8.TabIndex = 4
        Me.lblRX_Name8.Text = "8"
        Me.lblRX_Name8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel7
        '
        Me.pnlRX_Channel7.Controls.Add(Me.tcbRX_Value7)
        Me.pnlRX_Channel7.Controls.Add(Me.lblRX_Value7)
        Me.pnlRX_Channel7.Controls.Add(Me.lblRX_Name7)
        Me.pnlRX_Channel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel7.Location = New System.Drawing.Point(249, 3)
        Me.pnlRX_Channel7.Name = "pnlRX_Channel7"
        Me.pnlRX_Channel7.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel7.TabIndex = 6
        '
        'tcbRX_Value7
        '
        Me.tcbRX_Value7.AutoSize = False
        Me.tcbRX_Value7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value7.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value7.Maximum = 100
        Me.tcbRX_Value7.Minimum = -100
        Me.tcbRX_Value7.Name = "tcbRX_Value7"
        Me.tcbRX_Value7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value7.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value7.TabIndex = 2
        Me.tcbRX_Value7.TickFrequency = 10
        Me.tcbRX_Value7.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value7
        '
        Me.lblRX_Value7.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value7.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value7.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value7.Name = "lblRX_Value7"
        Me.lblRX_Value7.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value7.TabIndex = 3
        Me.lblRX_Value7.Text = "0"
        Me.lblRX_Value7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name7
        '
        Me.lblRX_Name7.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name7.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name7.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name7.Name = "lblRX_Name7"
        Me.lblRX_Name7.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name7.TabIndex = 4
        Me.lblRX_Name7.Text = "7"
        Me.lblRX_Name7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel6
        '
        Me.pnlRX_Channel6.Controls.Add(Me.tcbRX_Value6)
        Me.pnlRX_Channel6.Controls.Add(Me.lblRX_Value6)
        Me.pnlRX_Channel6.Controls.Add(Me.lblRX_Name6)
        Me.pnlRX_Channel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel6.Location = New System.Drawing.Point(208, 3)
        Me.pnlRX_Channel6.Name = "pnlRX_Channel6"
        Me.pnlRX_Channel6.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel6.TabIndex = 5
        '
        'tcbRX_Value6
        '
        Me.tcbRX_Value6.AutoSize = False
        Me.tcbRX_Value6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value6.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value6.Maximum = 100
        Me.tcbRX_Value6.Minimum = -100
        Me.tcbRX_Value6.Name = "tcbRX_Value6"
        Me.tcbRX_Value6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value6.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value6.TabIndex = 2
        Me.tcbRX_Value6.TickFrequency = 10
        Me.tcbRX_Value6.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value6
        '
        Me.lblRX_Value6.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value6.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value6.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value6.Name = "lblRX_Value6"
        Me.lblRX_Value6.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value6.TabIndex = 3
        Me.lblRX_Value6.Text = "0"
        Me.lblRX_Value6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name6
        '
        Me.lblRX_Name6.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name6.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name6.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name6.Name = "lblRX_Name6"
        Me.lblRX_Name6.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name6.TabIndex = 4
        Me.lblRX_Name6.Text = "6"
        Me.lblRX_Name6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel5
        '
        Me.pnlRX_Channel5.Controls.Add(Me.tcbRX_Value5)
        Me.pnlRX_Channel5.Controls.Add(Me.lblRX_Value5)
        Me.pnlRX_Channel5.Controls.Add(Me.lblRX_Name5)
        Me.pnlRX_Channel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel5.Location = New System.Drawing.Point(167, 3)
        Me.pnlRX_Channel5.Name = "pnlRX_Channel5"
        Me.pnlRX_Channel5.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel5.TabIndex = 4
        '
        'tcbRX_Value5
        '
        Me.tcbRX_Value5.AutoSize = False
        Me.tcbRX_Value5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value5.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value5.Maximum = 100
        Me.tcbRX_Value5.Minimum = -100
        Me.tcbRX_Value5.Name = "tcbRX_Value5"
        Me.tcbRX_Value5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value5.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value5.TabIndex = 2
        Me.tcbRX_Value5.TickFrequency = 10
        Me.tcbRX_Value5.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value5
        '
        Me.lblRX_Value5.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value5.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value5.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value5.Name = "lblRX_Value5"
        Me.lblRX_Value5.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value5.TabIndex = 3
        Me.lblRX_Value5.Text = "0"
        Me.lblRX_Value5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name5
        '
        Me.lblRX_Name5.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name5.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name5.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name5.Name = "lblRX_Name5"
        Me.lblRX_Name5.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name5.TabIndex = 4
        Me.lblRX_Name5.Text = "5"
        Me.lblRX_Name5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel4
        '
        Me.pnlRX_Channel4.Controls.Add(Me.tcbRX_Value4)
        Me.pnlRX_Channel4.Controls.Add(Me.lblRX_Value4)
        Me.pnlRX_Channel4.Controls.Add(Me.lblRX_Name4)
        Me.pnlRX_Channel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel4.Location = New System.Drawing.Point(126, 3)
        Me.pnlRX_Channel4.Name = "pnlRX_Channel4"
        Me.pnlRX_Channel4.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel4.TabIndex = 3
        '
        'tcbRX_Value4
        '
        Me.tcbRX_Value4.AutoSize = False
        Me.tcbRX_Value4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value4.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value4.Maximum = 100
        Me.tcbRX_Value4.Minimum = -100
        Me.tcbRX_Value4.Name = "tcbRX_Value4"
        Me.tcbRX_Value4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value4.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value4.TabIndex = 2
        Me.tcbRX_Value4.TickFrequency = 10
        Me.tcbRX_Value4.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value4
        '
        Me.lblRX_Value4.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value4.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value4.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value4.Name = "lblRX_Value4"
        Me.lblRX_Value4.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value4.TabIndex = 3
        Me.lblRX_Value4.Text = "0"
        Me.lblRX_Value4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name4
        '
        Me.lblRX_Name4.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name4.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name4.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name4.Name = "lblRX_Name4"
        Me.lblRX_Name4.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name4.TabIndex = 4
        Me.lblRX_Name4.Text = "4"
        Me.lblRX_Name4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel3
        '
        Me.pnlRX_Channel3.Controls.Add(Me.tcbRX_Value3)
        Me.pnlRX_Channel3.Controls.Add(Me.lblRX_Value3)
        Me.pnlRX_Channel3.Controls.Add(Me.lblRX_Name3)
        Me.pnlRX_Channel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel3.Location = New System.Drawing.Point(85, 3)
        Me.pnlRX_Channel3.Name = "pnlRX_Channel3"
        Me.pnlRX_Channel3.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel3.TabIndex = 2
        '
        'tcbRX_Value3
        '
        Me.tcbRX_Value3.AutoSize = False
        Me.tcbRX_Value3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value3.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value3.Maximum = 100
        Me.tcbRX_Value3.Minimum = -100
        Me.tcbRX_Value3.Name = "tcbRX_Value3"
        Me.tcbRX_Value3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value3.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value3.TabIndex = 2
        Me.tcbRX_Value3.TickFrequency = 10
        Me.tcbRX_Value3.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value3
        '
        Me.lblRX_Value3.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value3.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value3.Name = "lblRX_Value3"
        Me.lblRX_Value3.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value3.TabIndex = 3
        Me.lblRX_Value3.Text = "0"
        Me.lblRX_Value3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name3
        '
        Me.lblRX_Name3.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name3.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name3.Name = "lblRX_Name3"
        Me.lblRX_Name3.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name3.TabIndex = 4
        Me.lblRX_Name3.Text = "3"
        Me.lblRX_Name3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel2
        '
        Me.pnlRX_Channel2.Controls.Add(Me.tcbRX_Value2)
        Me.pnlRX_Channel2.Controls.Add(Me.lblRX_Value2)
        Me.pnlRX_Channel2.Controls.Add(Me.lblRX_Name2)
        Me.pnlRX_Channel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel2.Location = New System.Drawing.Point(44, 3)
        Me.pnlRX_Channel2.Name = "pnlRX_Channel2"
        Me.pnlRX_Channel2.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel2.TabIndex = 1
        '
        'tcbRX_Value2
        '
        Me.tcbRX_Value2.AutoSize = False
        Me.tcbRX_Value2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value2.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value2.Maximum = 100
        Me.tcbRX_Value2.Minimum = -100
        Me.tcbRX_Value2.Name = "tcbRX_Value2"
        Me.tcbRX_Value2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value2.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value2.TabIndex = 2
        Me.tcbRX_Value2.TickFrequency = 10
        Me.tcbRX_Value2.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value2
        '
        Me.lblRX_Value2.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value2.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value2.Name = "lblRX_Value2"
        Me.lblRX_Value2.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value2.TabIndex = 5
        Me.lblRX_Value2.Text = "0"
        Me.lblRX_Value2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name2
        '
        Me.lblRX_Name2.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name2.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name2.Name = "lblRX_Name2"
        Me.lblRX_Name2.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name2.TabIndex = 4
        Me.lblRX_Name2.Text = "2"
        Me.lblRX_Name2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRX_Channel1
        '
        Me.pnlRX_Channel1.Controls.Add(Me.tcbRX_Value1)
        Me.pnlRX_Channel1.Controls.Add(Me.lblRX_Value1)
        Me.pnlRX_Channel1.Controls.Add(Me.lblRX_Name1)
        Me.pnlRX_Channel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRX_Channel1.Location = New System.Drawing.Point(3, 3)
        Me.pnlRX_Channel1.Name = "pnlRX_Channel1"
        Me.pnlRX_Channel1.Size = New System.Drawing.Size(41, 439)
        Me.pnlRX_Channel1.TabIndex = 0
        '
        'tcbRX_Value1
        '
        Me.tcbRX_Value1.AutoSize = False
        Me.tcbRX_Value1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcbRX_Value1.Location = New System.Drawing.Point(0, 44)
        Me.tcbRX_Value1.Maximum = 100
        Me.tcbRX_Value1.Minimum = -100
        Me.tcbRX_Value1.Name = "tcbRX_Value1"
        Me.tcbRX_Value1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcbRX_Value1.Size = New System.Drawing.Size(41, 395)
        Me.tcbRX_Value1.TabIndex = 2
        Me.tcbRX_Value1.TickFrequency = 10
        Me.tcbRX_Value1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblRX_Value1
        '
        Me.lblRX_Value1.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Value1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Value1.Location = New System.Drawing.Point(0, 22)
        Me.lblRX_Value1.Name = "lblRX_Value1"
        Me.lblRX_Value1.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Value1.TabIndex = 3
        Me.lblRX_Value1.Text = "0"
        Me.lblRX_Value1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRX_Name1
        '
        Me.lblRX_Name1.BackColor = System.Drawing.SystemColors.Control
        Me.lblRX_Name1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRX_Name1.Location = New System.Drawing.Point(0, 0)
        Me.lblRX_Name1.Name = "lblRX_Name1"
        Me.lblRX_Name1.Size = New System.Drawing.Size(41, 22)
        Me.lblRX_Name1.TabIndex = 4
        Me.lblRX_Name1.Text = "1"
        Me.lblRX_Name1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.cboStatusLedColor)
        Me.TabSettings.Controls.Add(Me.cmdApplyConfiguration)
        Me.TabSettings.Controls.Add(Me.Label10)
        Me.TabSettings.Controls.Add(Me.Label11)
        Me.TabSettings.Controls.Add(Me.cboRXType)
        Me.TabSettings.ImageKey = "settings.png"
        Me.TabSettings.Location = New System.Drawing.Point(4, 23)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Size = New System.Drawing.Size(653, 445)
        Me.TabSettings.TabIndex = 3
        Me.TabSettings.Text = "Settings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'cboStatusLedColor
        '
        Me.cboStatusLedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusLedColor.FormattingEnabled = True
        Me.cboStatusLedColor.Items.AddRange(New Object() {"Red", "Green", "Blue", "White", "Purple", "Yellow", "Cyan"})
        Me.cboStatusLedColor.Location = New System.Drawing.Point(146, 69)
        Me.cboStatusLedColor.Name = "cboStatusLedColor"
        Me.cboStatusLedColor.Size = New System.Drawing.Size(151, 21)
        Me.cboStatusLedColor.TabIndex = 3
        '
        'cmdApplyConfiguration
        '
        Me.cmdApplyConfiguration.Location = New System.Drawing.Point(146, 111)
        Me.cmdApplyConfiguration.Name = "cmdApplyConfiguration"
        Me.cmdApplyConfiguration.Size = New System.Drawing.Size(144, 34)
        Me.cmdApplyConfiguration.TabIndex = 2
        Me.cmdApplyConfiguration.Text = "Apply Configuration"
        Me.cmdApplyConfiguration.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(-4, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Radio Modulation / Bus  : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(18, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "RX Status Led Color : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboRXType
        '
        Me.cboRXType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRXType.FormattingEnabled = True
        Me.cboRXType.Items.AddRange(New Object() {"PPM Modulation", "SBUS (Futaba)", "DSM (Spektrum)", "DMSS (JR)"})
        Me.cboRXType.Location = New System.Drawing.Point(146, 32)
        Me.cboRXType.Name = "cboRXType"
        Me.cboRXType.Size = New System.Drawing.Size(151, 21)
        Me.cboRXType.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(653, 445)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(647, 439)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NUD_Columns)
        Me.TabPage2.Controls.Add(Me.CB_LiveDisplay)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(653, 445)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NUD_Columns
        '
        Me.NUD_Columns.Location = New System.Drawing.Point(17, 46)
        Me.NUD_Columns.Name = "NUD_Columns"
        Me.NUD_Columns.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Columns.TabIndex = 1
        '
        'CB_LiveDisplay
        '
        Me.CB_LiveDisplay.AutoSize = True
        Me.CB_LiveDisplay.Location = New System.Drawing.Point(17, 22)
        Me.CB_LiveDisplay.Name = "CB_LiveDisplay"
        Me.CB_LiveDisplay.Size = New System.Drawing.Size(90, 17)
        Me.CB_LiveDisplay.TabIndex = 0
        Me.CB_LiveDisplay.Text = "OnlineDisplay"
        Me.CB_LiveDisplay.UseVisualStyleBackColor = True
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "log.png")
        Me.imlTab.Images.SetKeyName(1, "slider.png")
        Me.imlTab.Images.SetKeyName(2, "settings.png")
        Me.imlTab.Images.SetKeyName(3, "wifi.png")
        Me.imlTab.Images.SetKeyName(4, "document.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQuit, Me.ToolStripSeparator6, Me.tsbConvert, Me.tsbUpload, Me.ToolStripSeparator9, Me.tsbInfo, Me.tsbDebugLog, Me.tsbClearLog, Me.ToolStripSeparator5, Me.tsbResetChip, Me.ToolStripSeparator7, Me.ToolStripLabel1, Me.tscComPort, Me.ToolStripSeparator8, Me.tsbAbout, Me.ToolStripLabel2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(661, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbQuit
        '
        Me.tsbQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQuit.Image = Global.GueNightFly.My.Resources.Resources.quit
        Me.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuit.Name = "tsbQuit"
        Me.tsbQuit.Size = New System.Drawing.Size(23, 22)
        Me.tsbQuit.Text = "ToolStripButton6"
        Me.tsbQuit.ToolTipText = "Exit Application"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbConvert
        '
        Me.tsbConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConvert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertSEQIntoDATToolStripMenuItem, Me.ConvertCSVIntoDATToolStripMenuItem})
        Me.tsbConvert.Image = Global.GueNightFly.My.Resources.Resources.reload
        Me.tsbConvert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConvert.Name = "tsbConvert"
        Me.tsbConvert.Size = New System.Drawing.Size(29, 22)
        Me.tsbConvert.Text = "ToolStripButton1"
        Me.tsbConvert.ToolTipText = "Convert files"
        '
        'ConvertSEQIntoDATToolStripMenuItem
        '
        Me.ConvertSEQIntoDATToolStripMenuItem.Image = Global.GueNightFly.My.Resources.Resources.seq_File
        Me.ConvertSEQIntoDATToolStripMenuItem.Name = "ConvertSEQIntoDATToolStripMenuItem"
        Me.ConvertSEQIntoDATToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConvertSEQIntoDATToolStripMenuItem.Text = "Convert .SEQ into .DAT"
        '
        'ConvertCSVIntoDATToolStripMenuItem
        '
        Me.ConvertCSVIntoDATToolStripMenuItem.Image = Global.GueNightFly.My.Resources.Resources.excel
        Me.ConvertCSVIntoDATToolStripMenuItem.Name = "ConvertCSVIntoDATToolStripMenuItem"
        Me.ConvertCSVIntoDATToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConvertCSVIntoDATToolStripMenuItem.Text = "Convert .CSV into .DAT"
        '
        'tsbUpload
        '
        Me.tsbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUpload.Image = Global.GueNightFly.My.Resources.Resources.Upload
        Me.tsbUpload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpload.Name = "tsbUpload"
        Me.tsbUpload.Size = New System.Drawing.Size(23, 22)
        Me.tsbUpload.Text = "ToolStripButton1"
        Me.tsbUpload.ToolTipText = "Upload File to GueNightFly Chip"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tsbInfo
        '
        Me.tsbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbInfo.Image = Global.GueNightFly.My.Resources.Resources.information
        Me.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInfo.Name = "tsbInfo"
        Me.tsbInfo.Size = New System.Drawing.Size(23, 22)
        Me.tsbInfo.Text = "ToolStripButton2"
        Me.tsbInfo.ToolTipText = "Retrieve Onboard Information*"
        '
        'tsbDebugLog
        '
        Me.tsbDebugLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDebugLog.Image = Global.GueNightFly.My.Resources.Resources.bug
        Me.tsbDebugLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDebugLog.Name = "tsbDebugLog"
        Me.tsbDebugLog.Size = New System.Drawing.Size(23, 22)
        Me.tsbDebugLog.Text = "ToolStripButton1"
        Me.tsbDebugLog.ToolTipText = "Retrieve chip debug Log"
        '
        'tsbClearLog
        '
        Me.tsbClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClearLog.Image = Global.GueNightFly.My.Resources.Resources.edit_clear
        Me.tsbClearLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClearLog.Name = "tsbClearLog"
        Me.tsbClearLog.Size = New System.Drawing.Size(23, 22)
        Me.tsbClearLog.Text = "ToolStripButton4"
        Me.tsbClearLog.ToolTipText = "Clear the Application Log"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbResetChip
        '
        Me.tsbResetChip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbResetChip.Image = Global.GueNightFly.My.Resources.Resources.reset
        Me.tsbResetChip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbResetChip.Name = "tsbResetChip"
        Me.tsbResetChip.Size = New System.Drawing.Size(23, 22)
        Me.tsbResetChip.Text = "ToolStripButton5"
        Me.tsbResetChip.ToolTipText = "Reset The chip"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel1.Text = "Com. Port :"
        '
        'tscComPort
        '
        Me.tscComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscComPort.Name = "tscComPort"
        Me.tscComPort.Size = New System.Drawing.Size(80, 25)
        Me.tscComPort.ToolTipText = "Defines the COM port for communication"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAbout
        '
        Me.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAbout.Image = Global.GueNightFly.My.Resources.Resources.info
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(72, 22)
        Me.tsbAbout.Text = "About ..."
        Me.tsbAbout.ToolTipText = "About GueNightFly ..."
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "TSB_SnagIt"
        '
        'tmr_CheckE131
        '
        Me.tmr_CheckE131.Enabled = True
        '
        'tmrRX
        '
        '
        'tmr_LiveDisplay
        '
        Me.tmr_LiveDisplay.Interval = 20
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 577)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.sstMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GueNightFly - Control Panel"
        Me.grpComLog.ResumeLayout(False)
        Me.ctxLog.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sstMain.ResumeLayout(False)
        Me.sstMain.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMain.ResumeLayout(False)
        Me.TabSerial.ResumeLayout(False)
        Me.TabTest.ResumeLayout(False)
        Me.TabTest.PerformLayout()
        CType(Me.NUD_Chenillard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.tcbCH8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.tcbCH7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tcbCH6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.tcbCH5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.tcbCH4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.tcbCH3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tcbCH2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tcbCH1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRX.ResumeLayout(False)
        Me.pnlRX_Channel10.ResumeLayout(False)
        CType(Me.tcbRX_Value10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel9.ResumeLayout(False)
        CType(Me.tcbRX_Value9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel8.ResumeLayout(False)
        CType(Me.tcbRX_Value8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel7.ResumeLayout(False)
        CType(Me.tcbRX_Value7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel6.ResumeLayout(False)
        CType(Me.tcbRX_Value6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel5.ResumeLayout(False)
        CType(Me.tcbRX_Value5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel4.ResumeLayout(False)
        CType(Me.tcbRX_Value4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel3.ResumeLayout(False)
        CType(Me.tcbRX_Value3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel2.ResumeLayout(False)
        CType(Me.tcbRX_Value2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRX_Channel1.ResumeLayout(False)
        CType(Me.tcbRX_Value1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NUD_Columns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpComLog As System.Windows.Forms.GroupBox
    Friend WithEvents lstSerialLog As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlaySequenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopSequenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceONLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents mnuConfSerialPort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ctxLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsProgressValue As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tslProgressText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslComPort As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tmrUpdateLog As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabMain As System.Windows.Forms.TabControl
    Friend WithEvents TabSerial As System.Windows.Forms.TabPage
    Friend WithEvents TabTest As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH8 As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH7 As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH6 As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH5 As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tcbCH1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tcbCH2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tcbCH4 As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbQuit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbUpload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbInfo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClearLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbResetChip As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tscComPort As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCH8 As System.Windows.Forms.Label
    Friend WithEvents lblCH7 As System.Windows.Forms.Label
    Friend WithEvents lblCH6 As System.Windows.Forms.Label
    Friend WithEvents lblCH5 As System.Windows.Forms.Label
    Friend WithEvents lblCH4 As System.Windows.Forms.Label
    Friend WithEvents lblCH3 As System.Windows.Forms.Label
    Friend WithEvents lblCH2 As System.Windows.Forms.Label
    Friend WithEvents lblCH1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents imlTab As System.Windows.Forms.ImageList
    Friend WithEvents tlsE131 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmr_CheckE131 As System.Windows.Forms.Timer
    Friend WithEvents tsbConvert As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ConvertSEQIntoDATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertCSVIntoDATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabRX As System.Windows.Forms.TabPage
    Friend WithEvents pnlRX_Channel1 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value1 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value1 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name1 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel10 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value10 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value10 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name10 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel9 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value9 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value9 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name9 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel8 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value8 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value8 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name8 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel7 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value7 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value7 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name7 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel6 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value6 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value6 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name6 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel5 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value5 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value5 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name5 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel4 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value4 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value4 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name4 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel3 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value3 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value3 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name3 As System.Windows.Forms.Label
    Friend WithEvents pnlRX_Channel2 As System.Windows.Forms.Panel
    Friend WithEvents tcbRX_Value2 As System.Windows.Forms.TrackBar
    Friend WithEvents lblRX_Value2 As System.Windows.Forms.Label
    Friend WithEvents lblRX_Name2 As System.Windows.Forms.Label
    Friend WithEvents tmrRX As System.Windows.Forms.Timer
    Friend WithEvents tsbDebugLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents cboRXType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdApplyConfiguration As System.Windows.Forms.Button
    Friend WithEvents cboStatusLedColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tmr_LiveDisplay As System.Windows.Forms.Timer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CB_LiveDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents NUD_Columns As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Chenillard As System.Windows.Forms.NumericUpDown
    Friend WithEvents CB_Chenillard As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdFile As System.Windows.Forms.SaveFileDialog
End Class
