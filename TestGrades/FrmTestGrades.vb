Imports Microsoft.SqlServer

Public Class FrmTestGrades

    Private Const NARROW_WIDTH As Long = 425
    Private Const WIDE_WIDTH As Long = 777

    Private Sub LoadCourses()

        With CboCourse.Items
            .Add("ASP.NET")
            .Add("C#")
            .Add("C++")
            .Add("MS Access")
            .Add("MS Excel")
            .Add("MS Outlook")
            .Add("MS PowerPoint")
            .Add("MS Word")
            .Add("Sql Server")
            .Add("VB.NET")
        End With

    End Sub

    Private Sub BtnExpand_Click(sender As Object, e As EventArgs) Handles BtnExpand.Click

        If BtnExpand.Text = ">>>" Then
            Width = WIDE_WIDTH
            BtnExpand.Text = "<<<"
        Else
            Width = NARROW_WIDTH
            BtnExpand.Text = ">>>"
        End If

    End Sub

    Private Sub FrmTestGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Width = NARROW_WIDTH

        LoadCourses()
        CboCourse.SelectedItem = "VB.NET"

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Const NUM_TESTS As Integer = 3
        Const MAX_SCORE As Double = 300
        Dim TotalScore As Double = Val(TxtFoundation.Text) + Val(TxtIntermediale.Text) + Val(TxtAdvanced.Text)
        Dim AverageScore As Double = Math.Round(TotalScore / NUM_TESTS, 1)
        Dim LetterGrade As String, GradeColor As Color


        Select Case AverageScore
            Case >= 90
                LetterGrade = "A"
                GradeColor = Color.Green
            Case >= 80
                LetterGrade = "B"
                GradeColor = Color.LightBlue
            Case >= 70
                LetterGrade = "C"
                GradeColor = Color.White
            Case >= 65
                LetterGrade = "D"
                GradeColor = Color.DarkGray
            Case Else
                LetterGrade = "F"
                GradeColor = Color.Red
        End Select

        TxtTotalScore.Text = TotalScore
        TxtAverage.Text = FormatPercent(TotalScore / MAX_SCORE, 2)
        TxtLetterGrade.Text = LetterGrade
        TxtLetterGrade.BackColor = GradeColor

    End Sub
End Class
