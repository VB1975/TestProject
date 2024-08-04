Imports System.Runtime.InteropServices

Module ModGlobal
    Public Function GetCurrentSelectionAlignment() As Integer

        Const EM_GETPARAFORMAT As Integer = &H43D
        Dim paraFormat As New PARAFORMAT2()
        paraFormat.cbSize = CUInt(Marshal.SizeOf(paraFormat))
        Dim lParam As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(paraFormat))
        Marshal.StructureToPtr(paraFormat, lParam, False)
        SendMessage(FrmWordProcessor.RtfDocument.Handle, EM_GETPARAFORMAT, IntPtr.Zero, lParam)
        paraFormat = Marshal.PtrToStructure(Of PARAFORMAT2)(lParam)
        Marshal.FreeHGlobal(lParam)
        Return paraFormat.wAlignment

    End Function

    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    ' Define the PARAFORMAT2 structure
    <StructLayout(LayoutKind.Sequential)>
    Private Structure PARAFORMAT2
        Public cbSize As UInteger
        Public dwMask As UInteger
        Public wNumbering As UShort
        Public wReserved As UShort
        Public dxStartIndent As Integer
        Public dxRightIndent As Integer
        Public dxOffset As Integer
        Public wAlignment As UShort
        Public cTabCount As Short
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)>
        Public rgxTabs() As Integer
        Public dySpaceBefore As Integer
        Public dySpaceAfter As Integer
        Public dyLineSpacing As Integer
        Public sStyle As Short
        Public bLineSpacingRule As Byte
        Public bOutlineLevel As Byte
        Public wShadingWeight As Short
        Public wShadingStyle As Short
        Public wNumberingStart As Short
        Public wNumberingStyle As Short
        Public wNumberingTab As Short
        Public wBorderSpace As Short
        Public wBorderWidth As Short
        Public wBorders As Short
    End Structure
End Module
