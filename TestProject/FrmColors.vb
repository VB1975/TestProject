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

        If R > 255 Then R = 255 : TxtRedValue.Text = 255
        If G > 255 Then G = 255 : TxtGreenValue.Text = 255
        If B > 255 Then B = 255 : TxtBlueValue.Text = 255

        TrackRed.Value = R : TrackGreen.Value = G : TrackBlue.Value = B

        If TxtRedValue.Text.Contains(".") Then TxtRedValue.Undo() : R = Val(TxtRedValue.Text) : TrackRed.Value = R
        If TxtGreenValue.Text.Contains(".") Then TxtGreenValue.Undo() : G = Val(TxtGreenValue.Text) : TrackGreen.Value = G
        If TxtBlueValue.Text.Contains(".") Then TxtBlueValue.Undo() : B = Val(TxtBlueValue.Text) : TrackBlue.Value = B

        If Not IsNumeric(TxtRedValue.Text) Then TxtRedValue.Undo() : R = Val(TxtRedValue.Text) : TrackRed.Value = R
        If Not IsNumeric(TxtGreenValue.Text) Then TxtGreenValue.Undo() : G = Val(TxtGreenValue.Text) : TrackGreen.Value = G
        If Not IsNumeric(TxtBlueValue.Text) Then TxtBlueValue.Undo() : B = Val(TxtBlueValue.Text) : TrackBlue.Value = B

        PnlRGBColorDisplay.BackColor = Color.FromArgb(R, G, B)

    End Sub

    Private Sub BtnSelectBackColor_Click(sender As Object, e As EventArgs) Handles BtnSelectBackColor.Click

        Dim CD As New ColorDialog

        If CD.ShowDialog <> DialogResult.Cancel Then
            PnlColorDialogDisplay.BackColor = CD.Color
        End If

    End Sub

    Private Sub SelectColor(Panel As Panel, Textbox As TextBox)

        Dim CD As New ColorDialog

        If CD.ShowDialog <> DialogResult.Cancel Then
            Panel.BackColor = CD.Color
            Textbox.Text = ColorToHex(CD.Color)
        End If

    End Sub

    Private Function ColorToHex(color As Color) As String

        Return String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)

    End Function

    Private Sub BtnSelectColor1_Click(sender As Object, e As EventArgs) Handles BtnSelectColor1.Click

        SelectColor(PnlColor1, TxtColor1Hex)

    End Sub

    Private Sub BtnSelectColor2_Click(sender As Object, e As EventArgs) Handles BtnSelectColor2.Click

        SelectColor(PnlColor2, TxtColor2Hex)

    End Sub

    Private Sub BtnFlash_Click(sender As Object, e As EventArgs) Handles BtnFlash.Click

        If TxtColor1Hex.Text.Equals(TxtColor2Hex.Text) Then
            MessageBox.Show("Color 1 and Color 2 should be different." & Environment.NewLine &
                            "The event will NOT run.", "Colors Match", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If BtnFlash.Text = "Flash" Then
            TimFlash.Enabled = True
            BtnFlash.Text = "Regular"
            BtnSelectColor1.Enabled = False
            BtnSelectColor2.Enabled = False
        Else
            TimFlash.Enabled = False
            BtnFlash.Text = "Flash"
            PnlFlashingDisplay.BackColor = SystemColors.Control
            BtnSelectColor1.Enabled = True
            BtnSelectColor2.Enabled = True
        End If

    End Sub

    Private Sub TimFlash_Tick(sender As Object, e As EventArgs) Handles TimFlash.Tick

        Static Counter As Long
        Counter += 1

        If Counter Mod 2 = 0 Then
            PnlFlashingDisplay.BackColor = PnlColor1.BackColor
        Else
            PnlFlashingDisplay.BackColor = PnlColor2.BackColor
        End If

    End Sub
End Class