Public Class FrmComboBoxesAndListBoxes

    Private Sub LoadHardware() Handles MyBase.Load, BtnResetSingleSelectListBoxes.Click

        LstHardware.Items.Clear()
        LstHardwareSelected.Items.Clear()

        With LstHardware.Items
            .Add("32"" Monitor")
            .Add("Epson A3 Printer")
            .Add("Windows Keyboard")
            .Add("Rollerball Mouse")
            .Add("Sheet Feed Scanner")
        End With

    End Sub

    Private Sub LoadSoftware() Handles MyBase.Load, BtnResetMultiSelectListBoxes.Click

        LstSoftware.Items.Clear()
        LstSoftwareSelected.Items.Clear()

        With LstSoftware.Items
            .Add("Visual Studio 2022")
            .Add("MS Office 365")
            .Add("Adobe Creative Cloud")
            .Add("VS Code")
            .Add("SQL Server")
            .Add("SSMS")
        End With

    End Sub

    Private Sub LoadMagazines() Handles MyBase.Load, BtnResetCheckedListboxes.Click

        LstMagazines.Items.Clear()
        LstMagazinesSelected.Items.Clear()

        With LstMagazines.Items
            .Add("Back Street Heroes")
            .Add("Live To Ride")
            .Add("Motorcycle World")
            .Add("2 Wheels")
            .Add("Motorcycle Monthly")
        End With

    End Sub

    Private Sub BtnCopyItem_Click(sender As Object, e As EventArgs) Handles BtnCopyItem.Click

        If LstHardware.SelectedIndex >= 0 Then
            LstHardwareSelected.Items.Add(LstHardware.SelectedItem)
        End If

    End Sub

    Private Sub BtnMoveItem_Click(sender As Object, e As EventArgs) Handles BtnMoveItem.Click

        If LstHardware.SelectedIndex >= 0 Then
            LstHardwareSelected.Items.Add(LstHardware.SelectedItem)
            LstHardware.Items.RemoveAt(LstHardware.SelectedIndex)
        End If

    End Sub

    Private Sub BtnCopyItems_Click(sender As Object, e As EventArgs) Handles BtnCopyItems.Click

        Dim X As Integer

        If LstSoftware.SelectedItems.Count > 0 Then
            For X = 0 To LstSoftware.SelectedItems.Count - 1
                LstSoftwareSelected.Items.Add(LstSoftware.SelectedItems.Item(X))
            Next
        End If

    End Sub

    Private Sub BtnMoveItems_Click(sender As Object, e As EventArgs) Handles BtnMoveItems.Click

        Dim X As Integer

        If LstSoftware.SelectedItems.Count > 0 Then
            For X = LstSoftware.SelectedItems.Count - 1 To 0 Step -1
                LstSoftwareSelected.Items.Add(LstSoftware.SelectedItems.Item(X))
                LstSoftware.Items.Remove(LstSoftware.SelectedItems.Item(X))
            Next
        End If

    End Sub

    Private Sub BtnAddChecked_Click(sender As Object, e As EventArgs) Handles BtnAddChecked.Click

        Dim X As Integer

        If LstMagazines.CheckedItems.Count > 0 Then
            For X = 0 To LstMagazines.CheckedItems.Count - 1
                LstMagazinesSelected.Items.Add(LstMagazines.CheckedItems.Item(X))
            Next
        End If

    End Sub

    Private Sub BtnRemoveChecked_Click(sender As Object, e As EventArgs) Handles BtnRemoveChecked.Click

        Dim X As Integer

        If LstMagazinesSelected.CheckedItems.Count > 0 Then
            For X = LstMagazinesSelected.CheckedItems.Count - 1 To 0 Step -1
                LstMagazinesSelected.Items.Remove(LstMagazinesSelected.CheckedItems.Item(X))
            Next
        End If

    End Sub

    Private Sub DisplayMessage()

        Dim State As String = CboState.Text
        Dim SystemMessage As String

        LblSystemMessage.Text = ""
        LblSystemMessage.Visible = False

        If State <> "" Then
            SystemMessage = "You have selected '" & State & "' as your chosen State."
            LblSystemMessage.Text = SystemMessage
            LblSystemMessage.Visible = True
        End If

    End Sub

    Private Sub BtnDisplayMessage_Click(sender As Object, e As EventArgs) Handles BtnDisplayMessage.Click

        DisplayMessage()

    End Sub

    Private Sub CboState_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CboState.Validating

        Dim State As String = CboState.Text

        If Not String.IsNullOrEmpty(State) AndAlso CboState.FindStringExact(State) = -1 Then
            If MessageBox.Show(State & " is not in the list. Add it?", "Unknown State",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CboState.Items.Add(State)
                CboState.SelectedItem = State
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub BtnAddCharacter_Click(sender As Object, e As EventArgs) Handles BtnAddCharacter.Click

        Dim S As String = InputBox("Enter charcter name", "Buffy Character")
        'characters should be added to a text file or database
        If Not String.IsNullOrEmpty(S) Then CboBuffyCharacters.Items.Add(S)

    End Sub

    Private Sub BtnRemoveCharacter_Click(sender As Object, e As EventArgs) Handles BtnRemoveCharacter.Click

        If Not String.IsNullOrEmpty(CboBuffyCharacters.Text) Then
            'characters should be removed from a text file or database
            CboBuffyCharacters.Items.Remove(CboBuffyCharacters.SelectedItem)
        End If

    End Sub
End Class