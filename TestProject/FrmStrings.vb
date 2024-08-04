Imports System.Globalization

Public Class FrmStrings

    Private TextColor As Color = Color.FromArgb(0, 0, 0)

    Private Sub TxtString1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtString1.KeyPress

        If ChkWriteString2.Checked Then
            TxtString2.Text &= e.KeyChar
        End If

    End Sub

    Private Sub ChkWriteString2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkWriteString2.CheckedChanged

        TxtString1.Focus()
        TxtString1.SelectionStart = TxtString1.Text.Length

    End Sub

    Private Sub BtnReverseString_Click(sender As Object, e As EventArgs) Handles BtnReverseString.Click

        TxtString2.Text = StrReverse(TxtString1.Text)

    End Sub

    Private Sub BtnLowerCase_Click(sender As Object, e As EventArgs) Handles BtnLowerCase.Click

        TxtString2.Text = TxtString1.Text.ToLower

    End Sub

    Private Sub BtnUpperCase_Click(sender As Object, e As EventArgs) Handles BtnUpperCase.Click

        TxtString2.Text = TxtString1.Text.ToUpper

    End Sub

    Private Sub BtnProperCase_Click(sender As Object, e As EventArgs) Handles BtnProperCase.Click

        Dim InputString As String = TxtString1.Text
        TxtString2.Text = ToProperCase(InputString)

        '----------------------------------------------------------------------------------------------------------------------------------------
        '3 ALTERNATIVE SOLUTIONS FOR PROPER CASE
        '----------------------------------------------------------------------------------------------------------------------------------------
        'TxtString2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(InputString.ToLower())
        'TxtString2.Text = String.Join(" ", InputString.Split(" "c).Select(Function(word) Char.ToUpper(word(0)) & word.Substring(1).ToLower()))
        'TxtString2.Text = Strings.StrConv(InputString, VbStrConv.ProperCase)
        '----------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub BtnInvertCase_Click(sender As Object, e As EventArgs) Handles BtnInvertCase.Click

        Dim X As Integer, S As String = ""

        For X = 0 To TxtString1.Text.Length - 1
            If Char.IsUpper(TxtString1.Text.Chars(X)) Then
                S &= TxtString1.Text.Chars(X).ToString().ToLower()
            Else
                S &= TxtString1.Text.Chars(X).ToString().ToUpper()
            End If
        Next

        TxtString2.Text = S

    End Sub

    Private Sub BtnFlashingText_Click(sender As Object, e As EventArgs) Handles BtnFlashingText.Click

        If BtnFlashingText.Text = "Flashing Text" Then
            TimFlash.Enabled = True
            BtnFlashingText.Text = "Regular Text"
        Else
            TimFlash.Enabled = False
            BtnFlashingText.Text = "Flashing Text"
            TxtString1.ForeColor = TextColor
        End If

    End Sub

    Private Sub TimFlash_Tick(sender As Object, e As EventArgs) Handles TimFlash.Tick

        Static Counter As Long
        Counter += 1

        If Counter Mod 2 = 0 Then
            TxtString1.ForeColor = TxtString1.BackColor
        Else
            TxtString1.ForeColor = TextColor
        End If

    End Sub

    Private Sub BtnSeparateNames_Click(sender As Object, e As EventArgs) Handles BtnSeparateNames.Click

        Dim FullName As String = TxtFullName.Text.Trim
        Dim FirstSpace = InStr(FullName, " ")
        Dim LastSpace = InStrRev(FullName, " ")
        Dim TwoSpaces As Boolean = FirstSpace.CompareTo(LastSpace)

        TxtFirstName.Clear()
        TxtMiddleName.Clear()
        TxtLastName.Clear()

        If FirstSpace = 0 Then
            TxtFirstName.Text = FullName
        Else
            TxtFirstName.Text = Strings.Left(FullName, FirstSpace).Trim
        End If

        If TwoSpaces Then TxtMiddleName.Text = Mid(FullName, FirstSpace, LastSpace - FirstSpace).Trim
        If FirstSpace > 0 Then TxtLastName.Text = Strings.Right(FullName, FullName.Length - LastSpace).Trim

    End Sub

    Private Sub BtnConcatenation_Click(sender As Object, e As EventArgs) Handles BtnConcatenation.Click

        Dim S As String = TxtStr1.Text & " " & TxtStr2.Text & " " & TxtStr3.Text & " " & TxtStr4.Text & " " & TxtStr5.Text
        MessageBox.Show(S, "Concatenation")

    End Sub

    Private Sub BtnConcat_Click(sender As Object, e As EventArgs) Handles BtnConcat.Click

        Dim S As String = String.Concat(TxtStr1.Text, " ", TxtStr2.Text, " ", TxtStr3.Text, " ", TxtStr4.Text, " ", TxtStr5.Text)
        MessageBox.Show(S, "Concat")

    End Sub

    Private Sub BtnJoin_Click(sender As Object, e As EventArgs) Handles BtnJoin.Click

        Dim S As String = String.Join(" ", TxtStr1.Text, TxtStr2.Text, TxtStr3.Text, TxtStr4.Text, TxtStr5.Text)
        MessageBox.Show(S, "Join")

    End Sub

    Private Sub BtnInterpolation_Click(sender As Object, e As EventArgs) Handles BtnInterpolation.Click

        Dim S As String = $"{TxtStr1.Text} {TxtStr2.Text} {TxtStr3.Text} {TxtStr4.Text} {TxtStr5.Text}"
        MessageBox.Show(S, "Interpolation")

    End Sub

    Private Sub BtnFormat_Click(sender As Object, e As EventArgs) Handles BtnFormat.Click

        Dim S As String = String.Format("{0} {1} {2} {3} {4}", TxtStr1.Text, TxtStr2.Text, TxtStr3.Text, TxtStr4.Text, TxtStr5.Text)
        MessageBox.Show(S, "Format")

    End Sub

    Private Sub BtnStringBuilder_Click(sender As Object, e As EventArgs) Handles BtnStringBuilder.Click

        Dim sb As New System.Text.StringBuilder()
        sb.Append(TxtStr1.Text).Append(" ").Append(TxtStr2.Text).Append(" ").Append(TxtStr3.Text) _
            .Append(" ").Append(TxtStr4.Text).Append(" ").Append(TxtStr5.Text)
        Dim s As String = sb.ToString
        MessageBox.Show(s, "String Builder")

    End Sub

    Private Sub BtnArray_Click(sender As Object, e As EventArgs) Handles BtnArray.Click

        Dim Strings As String() = {TxtStr1.Text, TxtStr2.Text, TxtStr3.Text, TxtStr4.Text, TxtStr5.Text}
        Dim S As String = String.Join(" ", Strings)
        MessageBox.Show(S, "Array")

    End Sub

    Private Sub BtnIEnumerable_Click(sender As Object, e As EventArgs) Handles BtnIEnumerable.Click

        Dim list As New List(Of String) From {TxtStr1.Text, TxtStr2.Text, TxtStr3.Text, TxtStr4.Text, TxtStr5.Text}
        Dim S As String = String.Join(" ", list)
        MessageBox.Show(S, "IEnumerable")

    End Sub
End Class