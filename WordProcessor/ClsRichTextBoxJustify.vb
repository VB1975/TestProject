Imports System.Runtime.InteropServices

Public Class ClsRichTextBoxJustify
    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    ' Constants for the messages and parameters
    Private Const EM_SETTYPOGRAPHYOPTIONS As Integer = &H4CA
    Private Const TO_ADVANCEDTYPOGRAPHY As Integer = &H1

    Private Const PFM_ALIGNMENT As Integer = &H8
    Private Const PFA_JUSTIFY As Integer = &H4
    Private Const EM_SETPARAFORMAT As Integer = &H447

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

    Public Shared Sub JustifyRichTextBoxText(richTextBox As RichTextBox)

        ' Enable advanced typography
        SendMessage(richTextBox.Handle, EM_SETTYPOGRAPHYOPTIONS, CType(TO_ADVANCEDTYPOGRAPHY, IntPtr), CType(TO_ADVANCEDTYPOGRAPHY, IntPtr))

        ' Set the paragraph formatting to justify
        Dim paraFormat As New PARAFORMAT2()
        paraFormat.cbSize = CUInt(Marshal.SizeOf(paraFormat))
        paraFormat.dwMask = PFM_ALIGNMENT
        paraFormat.wAlignment = PFA_JUSTIFY

        Dim lParam As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(paraFormat))
        Marshal.StructureToPtr(paraFormat, lParam, False)
        SendMessage(richTextBox.Handle, EM_SETPARAFORMAT, IntPtr.Zero, lParam)
        Marshal.FreeHGlobal(lParam)

    End Sub
End Class

