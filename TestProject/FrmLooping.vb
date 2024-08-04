Public Class FrmLooping
    Private Sub BtnRunForNextLoop_Click(sender As Object, e As EventArgs) Handles BtnRunForNextLoop.Click

        Dim lBound As Double = Val(TxtLower.Text)
        Dim UBound As Double = Val(TxtUpper.Text)
        Dim stepValue As Double = Val(TxtStep.Text)
        Dim X As Long

        LstForNext.Items.Clear()

        For X = lBound To UBound Step stepValue
            LstForNext.Items.Add(X)
        Next

    End Sub

    Private Sub BtnRunForEachLoop_Click(sender As Object, e As EventArgs) Handles BtnRunForEachLoop.Click

        LstForEachName.Items.Clear()
        LstForEachText.Items.Clear()

        For Each ctrl As Control In PnlForEach.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name IsNot "BtnRunForEachLoop" Then
                    LstForEachName.Items.Add(ctrl.Name)
                    LstForEachText.Items.Add(ctrl.Text)
                End If
            End If
        Next

    End Sub

    Private Sub BtnRunWhileLoop_Click(sender As Object, e As EventArgs) Handles BtnRunWhileLoop.Click

        Dim X As Long
        Dim Target As Long = Val(TxtTarget.Text)

        LstWhile.Items.Clear()
        ChkAbort.Checked = False
        ChkAbort.Focus()
        X = 0

        While X <= Target And Not ChkAbort.Checked
            LstWhile.Items.Add(X)
            X += 1
            LstWhile.TopIndex = LstWhile.Items.Count - 1
            Application.DoEvents()
        End While

    End Sub

    Private Sub BtnRunDoWhileLoop_Click(sender As Object, e As EventArgs) Handles BtnRunDoWhileLoop.Click

        Dim X As Long
        Dim Target As Long = Val(TxtDoWhileTarget.Text)
        Dim Break As Long = Val(TxtBreak.Text)

        LstDoWhile.Items.Clear()
        ChkDoWhileAbort.Checked = False
        ChkDoWhileAbort.Focus()
        X = 0

        Do While X <= Target And Not ChkDoWhileAbort.Checked
            LstDoWhile.Items.Add(X)
            X += 1
            LstDoWhile.TopIndex = LstDoWhile.Items.Count - 1
            If X > Break Then Exit Do
            Application.DoEvents()
        Loop

    End Sub

    Private Sub BtnRunDoUntilLoop_Click(sender As Object, e As EventArgs) Handles BtnRunDoUntilLoop.Click

        Dim X As Long
        Dim Target As Long = Val(TxtDoUntilTarget.Text)

        LstDoUntil.Items.Clear()
        ChkDoUntilAbort.Checked = False
        ChkDoUntilAbort.Focus()
        X = 0

        Do
            LstDoUntil.Items.Add(X)
            X += 1
            LstDoUntil.TopIndex = LstDoUntil.Items.Count - 1
            Application.DoEvents()
        Loop Until X > Target Or ChkDoUntilAbort.Checked

    End Sub
End Class