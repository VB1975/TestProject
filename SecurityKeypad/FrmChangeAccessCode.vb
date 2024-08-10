Public Class FrmChangeAccessCode

    Private isValidated As Boolean, Msg As String

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Close()

    End Sub

    Private Sub ValidateAccessCode()

        GetAccessCode()

        LblSystemMessage.Visible = False
        isValidated = True

        If TxtCurrentAccessCode.Text = "" Then
            Msg = "Enter Current Access Code"
            TxtCurrentAccessCode.Focus()
            isValidated = False
            Exit Sub
        End If

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

        If TxtCurrentAccessCode.Text.ToUpper <> AccessCode.ToUpper Then
            Msg = "Invalid Access Code"
            TxtCurrentAccessCode.Clear()
            TxtAccessCode.Clear()
            TxtConfirmAccessCode.Clear()
            TxtCurrentAccessCode.Focus()
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

        FrmKeypad.Show()
        Close()

    End Sub

    Private Sub FrmCreateAccessCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmKeypad.TopMost = False

    End Sub
End Class