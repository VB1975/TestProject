Public Class FrmMainMenu
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click

        FrmKeypad.Show()
        Close()

    End Sub

    Private Sub BtnChangeAccessCode_Click(sender As Object, e As EventArgs) Handles BtnChangeAccessCode.Click

        FrmChangeAccessCode.Show()
        Close()

    End Sub
End Class