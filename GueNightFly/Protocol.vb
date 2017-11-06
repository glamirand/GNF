Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
Public Class RootLayer
    Public PreambleSize As Short
    Public PostambleSize As Short
    <VBFixedArray(12)> Public ACNID() As Byte
    Public Flags As Short
    Public Vector As Integer
    <VBFixedArray(16)> Public CID() As Byte
End Class

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
