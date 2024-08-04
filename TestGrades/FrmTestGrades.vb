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
End Class
