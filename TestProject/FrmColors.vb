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
End Class