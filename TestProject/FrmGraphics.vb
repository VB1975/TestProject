Imports System.Drawing.Graphics

Public Class FrmGraphics

    Private DashStyle As Integer = Drawing2D.DashStyle.Solid

    Private Sub FrmGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CboDashStyle.SelectedIndex = 0

    End Sub

    Private Sub SetColor(Panel As Panel)

        Dim CD As New ColorDialog

        If CD.ShowDialog <> DialogResult.Cancel Then
            Panel.BackColor = CD.Color
        End If

    End Sub

    Private Sub PnlPenColor_Click(sender As Object, e As EventArgs) Handles PnlPenColor.Click

        SetColor(PnlPenColor)

    End Sub

    Private Sub PnlFillColor_Click(sender As Object, e As EventArgs) Handles PnlFillColor.Click

        SetColor(PnlFillColor)

    End Sub

    Private Sub CboDashStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDashStyle.SelectedIndexChanged

        Select Case CboDashStyle.SelectedIndex
            Case 0 : DashStyle = Drawing2D.DashStyle.Solid
            Case 1 : DashStyle = Drawing2D.DashStyle.Dot
            Case 2 : DashStyle = Drawing2D.DashStyle.Dash
        End Select

    End Sub
End Class