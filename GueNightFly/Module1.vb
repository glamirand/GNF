Imports System.Runtime.InteropServices

Module USBRegister
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function RegisterDeviceNotification( _
  ByVal IntPtr As IntPtr, ByVal NotificationFilter As IntPtr, _
  ByVal Flags As Int32) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function UnregisterDeviceNotification( _
   ByVal hHandle As IntPtr) As UInteger
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Public Class DEV_BROADCAST_DEVICEINTERFACE
        Public dbcc_size As Integer
        Public dbcc_devicetype As Integer
        Public dbcc_reserved As Integer

        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.U1, SizeConst:=16)> _
        Public dbcc_classguid() As Byte

        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> _
        Public dbcc_name() As Byte
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Public Class DEV_BROADCAST_PORT
        Public dbcp_size As Integer
        Public dbcp_devicetype As Integer
        Public dbcp_reserved As Integer

        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=255)> _
        Public dbcp_name() As Byte
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Public Class DEV_BROADCAST_HDR
        Public dbch_size As Integer
        Public dbch_devicetype As Integer
        Public dbch_reserved As Integer
    End Class


    Private Const DEVICE_NOTIFY_ALL_INTERFACE_CLASSES As Integer = &H4
    Private Const DEVICE_NOTIFY_WINDOW_HANDLE As Short = 0

    Private Const WM_POWERBROADCAST As Integer = &H218
    Private Const PBT_APMSUSPEND As Integer = &H4

    Public Const WM_DEVICECHANGE As Integer = &H219
    Public Const DBT_DEVICEARRIVAL As Integer = &H8000
    Public Const DBT_DEVICEQUERYREMOVE As Integer = &H8001
    Public Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004

    Private Const DBT_DEVTYP_VOLUME As Integer = &H2
    Private Const DBT_DEVTYP_DEVICEINTERFACE As Integer = &H5
    Private Const DBT_DEVTYP_HANDLE As Integer = &H6
    Private Const DBT_DEVTYP_OEM As Integer = &H0
    Public Const DBT_DEVTYP_PORT As Integer = &H3

    Public Sub RegisterDeviceNotifications(ByVal Handle As IntPtr)
        'Registers the system to notify us about interfaces when they are plugged in and unplugged.
        'http://msdn.microsoft.com/en-us/library/aa363431(VS.85).aspx
        Dim deviceInterface As New DEV_BROADCAST_DEVICEINTERFACE()
        'Dim devicePort As New DEV_BROADCAST_PORT()
        Dim size As Integer = Marshal.SizeOf(deviceInterface)
        deviceInterface.dbcc_size = size
        deviceInterface.dbcc_devicetype = DBT_DEVTYP_DEVICEINTERFACE

        Dim buffer As IntPtr = Nothing
        buffer = Marshal.AllocHGlobal(size)
        Marshal.StructureToPtr(deviceInterface, buffer, True)
        Dim r As IntPtr = Nothing
        r = RegisterDeviceNotification(Handle, buffer, DEVICE_NOTIFY_WINDOW_HANDLE Or DEVICE_NOTIFY_ALL_INTERFACE_CLASSES)
        'r = RegisterDeviceNotification(Handle, buffer, DEVICE_NOTIFY_WINDOW_HANDLE)
    End Sub

End Module
