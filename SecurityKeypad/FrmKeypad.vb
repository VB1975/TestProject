Public Class FrmKeypad

    Private EnteredCode As String, CodeArray(8) As String
    Private SystemMessageColor As Color

    Private Const MAX_CHAR As Integer = 8

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub TimTimer_Tick(sender As Object, e As EventArgs) Handles TimTimer.Tick

        Static Counter As Long

        Counter += 1

        If LblSystemMessage.Visible Then
            If Counter Mod 2 = 0 Then
                LblSystemMessage.ForeColor = SystemMessageColor
            Else
                LblSystemMessage.ForeColor = BackColor
            End If
        Else
            Counter = 0
        End If

    End Sub

    Private Sub FrmKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IO.File.Exists(Filename) Then
            FrmCreateAccessCode.Activate()
            FrmCreateAccessCode.Show()
            Close()
            Exit Sub
        End If

        GetAccessCode()

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Button Then
                If Strings.Left(ctrl.Name, 6) = "BtnNum" Or Strings.Left(ctrl.Name, 7) = "BtnChar" Then
                    AddHandler Controls(ctrl.Name).Click, AddressOf AccessCodeChar_Click
                End If
            End If
        Next

    End Sub

    Private Sub AccessCodeChar_Click(sender As Object, e As EventArgs)

        Dim X As Integer

        LblSystemMessage.Visible = False

        For X = 1 To MAX_CHAR
            If Controls("LblCode" & X).Text = "" Or Controls("LblCode" & X).Text = "_" Then
                For Each ctrl As Control In Controls
                    If TypeOf ctrl Is Button Then
                        If Strings.Left(ctrl.Name, 6) = "BtnNum" Or Strings.Left(ctrl.Name, 7) = "BtnChar" Then
                            If Controls(ctrl.Name).Name = CType(sender, Button).Name Then
                                Controls("LblCode" & X).Text = Controls(ctrl.Name).Text
                                EnteredCode &= Controls("LblCode" & X).Text
                                CodeArray(X) = Controls("LblCode" & X).Text
                            End If
                        End If
                    End If
                Next
                If X < MAX_CHAR Then
                    Controls("LblCode" & X + 1).Focus()
                    Controls("LblCode" & X + 1).Text = "_"
                    Exit For
                End If
            End If
        Next

        ShowAccessCode()

    End Sub

    Private Sub ShowAccessCode()

        Dim X As Integer

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Label Then
                If Strings.Left(ctrl.Name, 7) = "LblCode" Then
                    If ctrl.Text <> "" And ctrl.Text <> "_" Then
                        If BtnShowAccessCode.Text = "Show" Then
                            ctrl.Text = "*"
                        End If
                    End If
                End If
            End If
        Next

        If BtnShowAccessCode.Text = "Hide" Then
            For X = 1 To MAX_CHAR
                If Controls("LblCode" & X).Text <> "" And Controls("LblCode" & X).Text <> "_" Then
                    Controls("LblCode" & X).Text = CodeArray(X)
                End If
            Next
        End If

    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click

        Dim GrantedStr As String = "Access Granted - Please Wait..."
        Dim DeniedStr As String = "Access Denied"

        LblSystemMessage.Text = ""
        LblSystemMessage.Visible = False

        If EnteredCode <> AccessCode Then
            LblSystemMessage.Text = DeniedStr
            SystemMessageColor = Color.FromArgb(192, 0, 0)
        Else
            LblSystemMessage.Text = GrantedStr
            SystemMessageColor = Color.FromArgb(0, 200, 0)
            TimLoadMenu.Enabled = True
        End If

        LblSystemMessage.ForeColor = SystemMessageColor
        If LblSystemMessage.Text <> "" Then LblSystemMessage.Visible = True

    End Sub

    Private Sub BtnShowAccessCode_Click(sender As Object, e As EventArgs) Handles BtnShowAccessCode.Click

        If BtnShowAccessCode.Text = "Show" Then
            BtnShowAccessCode.Text = "Hide"
        Else
            BtnShowAccessCode.Text = "Show"
        End If

        ShowAccessCode()

    End Sub

    Private Sub TimLoadMenu_Tick(sender As Object, e As EventArgs) Handles TimLoadMenu.Tick

        Static Counter As Long
        Counter += 1

        If Counter >= 5 Then
            FrmMainMenu.Activate()
            FrmMainMenu.Show()
            Close()
        End If

    End Sub

    Private Sub ChkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAlwaysOnTop.CheckedChanged

        If ChkAlwaysOnTop.Checked Then
            TopMost = True
        Else
            TopMost = False
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Label Then
                If Strings.Left(ctrl.Name, 7) = "LblCode" Then
                    ctrl.Text = ""
                    EnteredCode = ""
                    LblSystemMessage.Visible = False
                End If
            End If
        Next

        LblCode1.Text = "_"

    End Sub
End Class
