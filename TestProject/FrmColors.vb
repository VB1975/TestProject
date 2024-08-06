Imports System.Windows.Forms.AxHost

Public Class FrmColors

    Private IsProgrammaticChange As Boolean = False

    Private Sub PopulateStandardColors()

        CboStandardColors.Items.Clear()

        For Each knownColorName In [Enum].GetNames(GetType(KnownColor))
            Dim color As Color = Color.FromKnownColor([Enum].Parse(GetType(KnownColor), knownColorName))
            If Not color.IsSystemColor Then
                CboStandardColors.Items.Add(color.Name)
            End If
        Next

    End Sub

    Private Sub PopulateSystemColors()

        CboSystemColors.Items.Clear()

        For Each knownColorName In [Enum].GetNames(GetType(KnownColor))
            Dim color As Color = Color.FromKnownColor([Enum].Parse(GetType(KnownColor), knownColorName))
            If color.IsSystemColor Then
                CboSystemColors.Items.Add(color.Name)
            End If
        Next

    End Sub

    Private Sub FrmColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateStandardColors()
        PopulateSystemColors()

    End Sub

    Private Sub CboStandardColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboStandardColors.SelectedIndexChanged

        If Not IsProgrammaticChange Then
            IsProgrammaticChange = True
            CboSystemColors.SelectedIndex = -1
            If CboStandardColors.SelectedIndex <> -1 Then
                Dim StandardColor As String = CboStandardColors.SelectedItem.ToString
                PnlColorDisplay.BackColor = Color.FromName(StandardColor)
            End If
            IsProgrammaticChange = False
        End If

    End Sub

    Private Sub CboSystemColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSystemColors.SelectedIndexChanged

        If Not IsProgrammaticChange Then
            IsProgrammaticChange = True
            CboStandardColors.SelectedIndex = -1
            If CboSystemColors.SelectedIndex <> -1 Then
                Dim SystemColor As String = CboSystemColors.SelectedItem.ToString
                PnlColorDisplay.BackColor = Color.FromName(SystemColor)
            End If
            IsProgrammaticChange = False
        End If

    End Sub

    Private Sub ScrollChange() Handles TrackRed.Scroll, TrackGreen.Scroll, TrackBlue.Scroll

        Dim R As Integer = TrackRed.Value, G As Integer = TrackGreen.Value, B As Integer = TrackBlue.Value

        TxtRedValue.Text = R : TxtGreenValue.Text = G : TxtBlueValue.Text = B
        PnlRGBColorDisplay.BackColor = Color.FromArgb(R, G, B)

    End Sub

    Private Sub ValueChange() Handles TxtRedValue.TextChanged, TxtGreenValue.TextChanged, TxtBlueValue.TextChanged

        Dim R As Integer = Val(TxtRedValue.Text), G As Integer = Val(TxtGreenValue.Text), B As Integer = Val(TxtBlueValue.Text)

        If R < 0 Then R = 0 : TxtRedValue.Text = 0
        If G < 0 Then G = 0 : TxtGreenValue.Text = 0
        If B < 0 Then B = 0 : TxtBlueValue.Text = 0

        If R > 255 Then R = 255 : TxtRedValue.Text = 255
        If G > 255 Then G = 255 : TxtGreenValue.Text = 255
        If B > 255 Then B = 255 : TxtBlueValue.Text = 255

        If TxtRedValue.Text.Contains(".") Then TxtRedValue.Text = Int(R)
        If TxtGreenValue.Text.Contains(".") Then TxtGreenValue.Text = Int(G)
        If TxtBlueValue.Text.Contains(".") Then TxtBlueValue.Text = Int(B)

        TrackRed.Value = R : TrackGreen.Value = G : TrackBlue.Value = B

        If Not IsNumeric(TxtRedValue.Text) Then TxtRedValue.Undo() : R = Val(TxtRedValue.Text) : TrackRed.Value = R
        If Not IsNumeric(TxtGreenValue.Text) Then TxtGreenValue.Undo() : G = Val(TxtGreenValue.Text) : TrackGreen.Value = G
        If Not IsNumeric(TxtBlueValue.Text) Then TxtBlueValue.Undo() : B = Val(TxtBlueValue.Text) : TrackBlue.Value = B

        PnlRGBColorDisplay.BackColor = Color.FromArgb(R, G, B)

    End Sub
End Class