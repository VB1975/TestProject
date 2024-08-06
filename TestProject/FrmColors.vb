Imports System.Windows.Forms.AxHost

Public Class FrmColors

    Private IsProgrammaticChange As Boolean = False

    Private Sub PopulateStandardColors()

        ' Clear any existing items in the ComboBox
        CboStandardColors.Items.Clear()

        ' Iterate through all known colors
        For Each knownColorName In [Enum].GetNames(GetType(KnownColor))
            ' Convert the known color name to a Color object
            Dim color As Color = Color.FromKnownColor([Enum].Parse(GetType(KnownColor), knownColorName))

            ' Check if the color is a system color
            If Not color.IsSystemColor Then
                ' Add the color name to the ComboBox if it's not a system color
                CboStandardColors.Items.Add(color.Name)
            End If
        Next

    End Sub

    Private Sub PopulateSystemColors()

        ' Clear any existing items in the ComboBox
        CboSystemColors.Items.Clear()

        ' Iterate through all known colors
        For Each knownColorName In [Enum].GetNames(GetType(KnownColor))
            ' Convert the known color name to a Color object
            Dim color As Color = Color.FromKnownColor([Enum].Parse(GetType(KnownColor), knownColorName))

            ' Check if the color is a system color
            If color.IsSystemColor Then
                ' Add the color name to the ComboBox if it's not a system color
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
End Class