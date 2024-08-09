Imports System.Drawing.Graphics

Public Class FrmGraphics

    Private DashStyle As Integer = Drawing2D.DashStyle.Solid

    Private Sub FrmGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CboDashStyle.SelectedIndex = 0
        CboPenWidth.SelectedItem = "3"

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

    Private Sub LblTransparantFill_Click(sender As Object, e As EventArgs) Handles LblTransparantFill.Click

        PnlFillColor.BackColor = Color.Transparent

    End Sub

    Private Sub SetGraphicsObject(sender As Object, e As EventArgs) Handles BtnLine.Click, BtnRectangle.Click, BtnElipse.Click

        Dim PenColor = PnlPenColor.BackColor
        Dim PenWidth = CboPenWidth.SelectedItem
        Dim objPen As New Pen(PenColor, PenWidth)
        objPen.DashStyle = DashStyle
        Dim X1 As Integer = Val(TxtX1.Text), X2 As Integer = Val(TxtX2.Text)
        Dim Y1 As Integer = Val(TxtY1.Text), Y2 As Integer = Val(TxtY2.Text)

        If sender Is BtnLine Then
            PicCanvas.CreateGraphics.DrawLine(objPen, X1, Y1, X2, Y2)
        ElseIf sender Is BtnRectangle Then
            PicCanvas.CreateGraphics.DrawRectangle(objPen, X1, Y1, X2, Y2)
        ElseIf sender Is BtnElipse Then
            PicCanvas.CreateGraphics.DrawEllipse(objPen, X1, Y1, X2, Y2)
        End If

    End Sub

End Class