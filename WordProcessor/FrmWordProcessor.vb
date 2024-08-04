Imports WordProcessor.ClsRichTextBoxJustify

Public Class FrmWordProcessor

    Private ButtonStates As New Dictionary(Of ToolStripButton, Boolean)
    Private ButtonColor As Color = Color.PaleGoldenrod

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Populate CboFont with available fonts
        For Each f As FontFamily In FontFamily.Families
            CboFont.Items.Add(f.Name)
        Next

        ' Populate CboFontSize with common font sizes
        Dim fontSizes() As Integer = {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}
        For Each size As Integer In fontSizes
            CboFontSize.Items.Add(size.ToString())
        Next

        ' Set default selected items
        CboFont.SelectedItem = "Calibri"
        CboFontSize.SelectedItem = "12"

        ' Add buttons to the dictionary with initial state as False (not selected)
        ButtonStates.Add(BtnFontBold, False)
        ButtonStates.Add(BtnFontItalic, False)
        ButtonStates.Add(BtnFontUnderline, False)
        ButtonStates.Add(BtnFontStrikeThrough, False)

        ' Attach event handlers
        AddHandler BtnFontBold.Click, AddressOf ToggleBold
        AddHandler BtnFontItalic.Click, AddressOf ToggleItalic
        AddHandler BtnFontUnderline.Click, AddressOf ToggleUnderline
        AddHandler BtnFontStrikeThrough.Click, AddressOf ToggleStrikeThrough

        AddHandler CboFont.SelectedIndexChanged, AddressOf ChangeFont
        AddHandler CboFontSize.SelectedIndexChanged, AddressOf ChangeFont

    End Sub

    Private Sub ChangeFont(sender As Object, e As EventArgs)

        ' Ensure both font and font size are selected
        If Not String.IsNullOrEmpty(CboFont.Text) AndAlso Not String.IsNullOrEmpty(CboFontSize.Text) Then
            Try
                Dim currentFont As Font = RtfDocument.SelectionFont
                Dim newFontStyle As FontStyle = currentFont.Style
                Dim newFont As New Font(CboFont.Text, Convert.ToSingle(CboFontSize.Text), newFontStyle)
                RtfDocument.SelectionFont = newFont
                RtfDocument.Focus()
            Catch ex As Exception
                'MessageBox.Show("Error setting font: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ToggleButtonColor(sender As Object)

        Dim FontStylebtn As ToolStripButton = CType(sender, ToolStripButton)

        ' Toggle the button's state
        If ButtonStates(FontStylebtn) Then
            FontStylebtn.BackColor = SystemColors.Control
            ButtonStates(FontStylebtn) = False
        Else
            'FontStylebtn.Checked = False
            FontStylebtn.BackColor = ButtonColor
            ButtonStates(FontStylebtn) = True
        End If

        MsgBox(FontStylebtn.Name & " : " & ButtonStates(FontStylebtn).ToString)

    End Sub

    Private Sub ToggleBold(sender As Object, e As EventArgs)
        ChangeFontStyle(BtnFontBold, FontStyle.Bold)
        ToggleButtonColor(sender)
    End Sub

    Private Sub ToggleItalic(sender As Object, e As EventArgs)
        ChangeFontStyle(BtnFontItalic, FontStyle.Italic)
        ToggleButtonColor(sender)
    End Sub

    Private Sub ToggleUnderline(sender As Object, e As EventArgs)
        ChangeFontStyle(BtnFontUnderline, FontStyle.Underline)
        ToggleButtonColor(sender)
    End Sub

    Private Sub ToggleStrikeThrough(sender As Object, e As EventArgs)
        ChangeFontStyle(BtnFontStrikeThrough, FontStyle.Strikeout)
        ToggleButtonColor(sender)
    End Sub

    Private Sub ChangeFontStyle(sender As Object, style As FontStyle)
        Try
            Dim currentFont As Font = RtfDocument.SelectionFont
            Dim newFontStyle As FontStyle

            Dim FontStyleBtn As ToolStripButton = CType(sender, ToolStripButton)

            If currentFont IsNot Nothing Then
                If currentFont.Style.HasFlag(style) Then
                    newFontStyle = currentFont.Style And Not style
                Else
                    newFontStyle = currentFont.Style Or style
                End If
                Dim newFont As New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
                RtfDocument.SelectionFont = newFont
                RtfDocument.Focus()
            End If
        Catch ex As Exception
            'MessageBox.Show("Error setting font style: " & ex.Message)
        End Try

    End Sub

    Private Sub SetDefaultButtonState(Length As Integer, NumChar As Integer, Substring As String)

        For Each Ctrl As ToolStripItem In TspStandard.Items
            If TypeOf Ctrl Is ToolStripButton Then
                Dim btn As ToolStripButton = CType(Ctrl, ToolStripButton)
                If btn.Name.Length >= Length AndAlso btn.Name.Substring(3, NumChar) = Substring Then
                    btn.Checked = False
                    btn.BackColor = SystemColors.Control
                End If
            End If
        Next

    End Sub

    Private Sub AlignSelection(sender As Object, e As EventArgs) _
        Handles BtnAlignLeft.Click, BtnAlignCenter.Click, BtnAlignRight.Click, BtnAlignJustify.Click

        Dim AlignBtn As ToolStripButton = CType(sender, ToolStripButton)

        SetDefaultButtonState(9, 5, "Align")

        Select Case AlignBtn.Name
            Case "BtnAlignLeft"
                RtfDocument.SelectionAlignment = HorizontalAlignment.Left
            Case "BtnAlignCenter"
                RtfDocument.SelectionAlignment = HorizontalAlignment.Center
            Case "BtnAlignRight"
                RtfDocument.SelectionAlignment = HorizontalAlignment.Right
            Case "BtnAlignJustify"
                JustifyRichTextBoxText(RtfDocument)
        End Select

        AlignBtn.BackColor = ButtonColor

    End Sub

    Private Sub EnableButtons() Handles RtfDocument.SelectionChanged

        If RtfDocument.SelectedText.Length > 0 Then
            BtnCut.Enabled = True
            BtnCopy.Enabled = True
        Else
            BtnCut.Enabled = False
            BtnCopy.Enabled = False
        End If

        If Clipboard.ContainsText() Then
            BtnPaste.Enabled = True
        Else
            BtnPaste.Enabled = False
        End If

    End Sub

    Private Sub SetAlignmentButtons() Handles RtfDocument.SelectionChanged, MyBase.Load

        SetDefaultButtonState(9, 5, "Align")

        Select Case GetCurrentSelectionAlignment()
            Case 1  ' Align Left
                BtnAlignLeft.BackColor = ButtonColor
            Case 2 ' Align Right
                BtnAlignRight.BackColor = ButtonColor
            Case 3  ' Align Center
                BtnAlignCenter.BackColor = ButtonColor
            Case 4  ' Align Justify
                BtnAlignJustify.BackColor = ButtonColor
        End Select

    End Sub

    Private Sub CenterForm() Handles Me.Resize, Me.ResizeEnd

        If WindowState = FormWindowState.Normal Then
            CenterToScreen()
        End If

    End Sub

    Private Sub CboFont_DropDown(sender As Object, e As EventArgs) Handles CboFont.DropDown

        RtfDocument.Focus()

    End Sub

    Private Sub CboFontSize_DropDown(sender As Object, e As EventArgs) Handles CboFontSize.DropDown

        RtfDocument.Focus()

    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click

        Clipboard.SetText(RtfDocument.SelectedText)
        RtfDocument.SelectedText = ""

    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click

        Clipboard.SetText(RtfDocument.SelectedText)
        EnableButtons()

    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click

        If Clipboard.ContainsText() Then RtfDocument.Paste()
        EnableButtons()

    End Sub

    Private Sub MnuEditClearClipboard_Click(sender As Object, e As EventArgs) Handles MnuEditClearClipboard.Click

        Clipboard.Clear()
        EnableButtons()

    End Sub

    Private Sub MnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles MnuEditSelectAll.Click

        RtfDocument.SelectAll()

    End Sub
End Class
