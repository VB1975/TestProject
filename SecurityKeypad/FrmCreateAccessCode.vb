Public Class FrmCreateAccessCode

    Private isValidated As Boolean, Msg As String

    Private Sub TimCancel_Tick(sender As Object, e As EventArgs) Handles TimCancel.Tick

        Static Counter As Long
        Counter += 1

        If Counter >= 3 Then
            Application.Exit()
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        LblSystemMessage.Text = "Closing Application..."
        LblSystemMessage.Visible = True
        TimCancel.Enabled = True

    End Sub

    Private Sub ValidateAccessCode()

        LblSystemMessage.Visible = False
        isValidated = True

        If TxtAccessCode.Text = "" Then
            Msg = "Enter Access Code"
            TxtAccessCode.Focus()
            isValidated = False
            Exit Sub
        End If

        If TxtConfirmAccessCode.Text = "" Then
            Msg = "Enter Access Code Confirmation"
            TxtConfirmAccessCode.Focus()
            isValidated = False
            Exit Sub
        End If

        If TxtConfirmAccessCode.Text.ToUpper <> TxtAccessCode.Text.ToUpper Then
            Msg = "Access Codes Do Not Match"
            TxtAccessCode.Clear()
            TxtConfirmAccessCode.Clear()
            TxtAccessCode.Focus()
            isValidated = False
            Exit Sub
        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        ValidateAccessCode()

        If Not isValidated Then
            LblSystemMessage.Text = Msg
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        Dim objFile As New IO.StreamWriter(Filename)
        objFile.WriteLine(TxtAccessCode.Text.ToUpper)
        objFile.Close()
        objFile.Dispose()

        FrmKeypad.Activate()
        FrmKeypad.Show()
        Close()

    End Sub

    Private Sub FrmCreateAccessCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmKeypad.TopMost = False

    End Sub
End Class