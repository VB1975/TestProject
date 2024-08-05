<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComboBoxesAndListBoxes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstHardware = New System.Windows.Forms.ListBox()
        Me.LstHardwareSelected = New System.Windows.Forms.ListBox()
        Me.BtnCopyItem = New System.Windows.Forms.Button()
        Me.BtnMoveItem = New System.Windows.Forms.Button()
        Me.BtnResetSingleSelectListBoxes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnResetMultiSelectListBoxes = New System.Windows.Forms.Button()
        Me.BtnMoveItems = New System.Windows.Forms.Button()
        Me.BtnCopyItems = New System.Windows.Forms.Button()
        Me.LstSoftwareSelected = New System.Windows.Forms.ListBox()
        Me.LstSoftware = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnResetCheckedListboxes = New System.Windows.Forms.Button()
        Me.BtnRemoveChecked = New System.Windows.Forms.Button()
        Me.BtnAddChecked = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LstMagazines = New System.Windows.Forms.CheckedListBox()
        Me.LstMagazinesSelected = New System.Windows.Forms.CheckedListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboState = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnDisplayMessage = New System.Windows.Forms.Button()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.BtnAddCharacter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboBuffyCharacters = New System.Windows.Forms.ComboBox()
        Me.BtnRemoveCharacter = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnResetSingleSelectListBoxes)
        Me.Panel1.Controls.Add(Me.BtnMoveItem)
        Me.Panel1.Controls.Add(Me.BtnCopyItem)
        Me.Panel1.Controls.Add(Me.LstHardwareSelected)
        Me.Panel1.Controls.Add(Me.LstHardware)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 313)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Single Select List Boxes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstHardware
        '
        Me.LstHardware.FormattingEnabled = True
        Me.LstHardware.ItemHeight = 24
        Me.LstHardware.Location = New System.Drawing.Point(3, 53)
        Me.LstHardware.Name = "LstHardware"
        Me.LstHardware.Size = New System.Drawing.Size(165, 244)
        Me.LstHardware.Sorted = True
        Me.LstHardware.TabIndex = 1
        '
        'LstHardwareSelected
        '
        Me.LstHardwareSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstHardwareSelected.FormattingEnabled = True
        Me.LstHardwareSelected.ItemHeight = 24
        Me.LstHardwareSelected.Location = New System.Drawing.Point(348, 53)
        Me.LstHardwareSelected.Name = "LstHardwareSelected"
        Me.LstHardwareSelected.Size = New System.Drawing.Size(165, 244)
        Me.LstHardwareSelected.Sorted = True
        Me.LstHardwareSelected.TabIndex = 2
        '
        'BtnCopyItem
        '
        Me.BtnCopyItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyItem.ForeColor = System.Drawing.Color.Teal
        Me.BtnCopyItem.Location = New System.Drawing.Point(192, 102)
        Me.BtnCopyItem.Name = "BtnCopyItem"
        Me.BtnCopyItem.Size = New System.Drawing.Size(131, 44)
        Me.BtnCopyItem.TabIndex = 3
        Me.BtnCopyItem.Text = "Copy >"
        Me.BtnCopyItem.UseVisualStyleBackColor = True
        '
        'BtnMoveItem
        '
        Me.BtnMoveItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMoveItem.Location = New System.Drawing.Point(192, 152)
        Me.BtnMoveItem.Name = "BtnMoveItem"
        Me.BtnMoveItem.Size = New System.Drawing.Size(131, 44)
        Me.BtnMoveItem.TabIndex = 4
        Me.BtnMoveItem.Text = "Move >>"
        Me.BtnMoveItem.UseVisualStyleBackColor = True
        '
        'BtnResetSingleSelectListBoxes
        '
        Me.BtnResetSingleSelectListBoxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResetSingleSelectListBoxes.ForeColor = System.Drawing.Color.Blue
        Me.BtnResetSingleSelectListBoxes.Location = New System.Drawing.Point(192, 202)
        Me.BtnResetSingleSelectListBoxes.Name = "BtnResetSingleSelectListBoxes"
        Me.BtnResetSingleSelectListBoxes.Size = New System.Drawing.Size(131, 44)
        Me.BtnResetSingleSelectListBoxes.TabIndex = 5
        Me.BtnResetSingleSelectListBoxes.Text = "Reset <>"
        Me.BtnResetSingleSelectListBoxes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnResetMultiSelectListBoxes)
        Me.Panel2.Controls.Add(Me.BtnMoveItems)
        Me.Panel2.Controls.Add(Me.BtnCopyItems)
        Me.Panel2.Controls.Add(Me.LstSoftwareSelected)
        Me.Panel2.Controls.Add(Me.LstSoftware)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(536, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 313)
        Me.Panel2.TabIndex = 1
        '
        'BtnResetMultiSelectListBoxes
        '
        Me.BtnResetMultiSelectListBoxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResetMultiSelectListBoxes.ForeColor = System.Drawing.Color.Blue
        Me.BtnResetMultiSelectListBoxes.Location = New System.Drawing.Point(192, 202)
        Me.BtnResetMultiSelectListBoxes.Name = "BtnResetMultiSelectListBoxes"
        Me.BtnResetMultiSelectListBoxes.Size = New System.Drawing.Size(131, 44)
        Me.BtnResetMultiSelectListBoxes.TabIndex = 5
        Me.BtnResetMultiSelectListBoxes.Text = "Reset <>"
        Me.BtnResetMultiSelectListBoxes.UseVisualStyleBackColor = True
        '
        'BtnMoveItems
        '
        Me.BtnMoveItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMoveItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMoveItems.Location = New System.Drawing.Point(192, 152)
        Me.BtnMoveItems.Name = "BtnMoveItems"
        Me.BtnMoveItems.Size = New System.Drawing.Size(131, 44)
        Me.BtnMoveItems.TabIndex = 4
        Me.BtnMoveItems.Text = "Move >>"
        Me.BtnMoveItems.UseVisualStyleBackColor = True
        '
        'BtnCopyItems
        '
        Me.BtnCopyItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyItems.ForeColor = System.Drawing.Color.Teal
        Me.BtnCopyItems.Location = New System.Drawing.Point(192, 102)
        Me.BtnCopyItems.Name = "BtnCopyItems"
        Me.BtnCopyItems.Size = New System.Drawing.Size(131, 44)
        Me.BtnCopyItems.TabIndex = 3
        Me.BtnCopyItems.Text = "Copy >"
        Me.BtnCopyItems.UseVisualStyleBackColor = True
        '
        'LstSoftwareSelected
        '
        Me.LstSoftwareSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstSoftwareSelected.FormattingEnabled = True
        Me.LstSoftwareSelected.ItemHeight = 24
        Me.LstSoftwareSelected.Location = New System.Drawing.Point(348, 53)
        Me.LstSoftwareSelected.Name = "LstSoftwareSelected"
        Me.LstSoftwareSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LstSoftwareSelected.Size = New System.Drawing.Size(165, 244)
        Me.LstSoftwareSelected.Sorted = True
        Me.LstSoftwareSelected.TabIndex = 2
        '
        'LstSoftware
        '
        Me.LstSoftware.FormattingEnabled = True
        Me.LstSoftware.ItemHeight = 24
        Me.LstSoftware.Location = New System.Drawing.Point(3, 53)
        Me.LstSoftware.Name = "LstSoftware"
        Me.LstSoftware.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LstSoftware.Size = New System.Drawing.Size(165, 244)
        Me.LstSoftware.Sorted = True
        Me.LstSoftware.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Multi Select List Boxes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LstMagazinesSelected)
        Me.Panel3.Controls.Add(Me.LstMagazines)
        Me.Panel3.Controls.Add(Me.BtnResetCheckedListboxes)
        Me.Panel3.Controls.Add(Me.BtnRemoveChecked)
        Me.Panel3.Controls.Add(Me.BtnAddChecked)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 331)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 313)
        Me.Panel3.TabIndex = 2
        '
        'BtnResetCheckedListboxes
        '
        Me.BtnResetCheckedListboxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResetCheckedListboxes.ForeColor = System.Drawing.Color.Blue
        Me.BtnResetCheckedListboxes.Location = New System.Drawing.Point(192, 194)
        Me.BtnResetCheckedListboxes.Name = "BtnResetCheckedListboxes"
        Me.BtnResetCheckedListboxes.Size = New System.Drawing.Size(131, 44)
        Me.BtnResetCheckedListboxes.TabIndex = 5
        Me.BtnResetCheckedListboxes.Text = "Reset <>"
        Me.BtnResetCheckedListboxes.UseVisualStyleBackColor = True
        '
        'BtnRemoveChecked
        '
        Me.BtnRemoveChecked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemoveChecked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemoveChecked.Location = New System.Drawing.Point(192, 144)
        Me.BtnRemoveChecked.Name = "BtnRemoveChecked"
        Me.BtnRemoveChecked.Size = New System.Drawing.Size(131, 44)
        Me.BtnRemoveChecked.TabIndex = 4
        Me.BtnRemoveChecked.Text = "< Remove"
        Me.BtnRemoveChecked.UseVisualStyleBackColor = True
        '
        'BtnAddChecked
        '
        Me.BtnAddChecked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddChecked.ForeColor = System.Drawing.Color.Teal
        Me.BtnAddChecked.Location = New System.Drawing.Point(192, 94)
        Me.BtnAddChecked.Name = "BtnAddChecked"
        Me.BtnAddChecked.Size = New System.Drawing.Size(131, 44)
        Me.BtnAddChecked.TabIndex = 3
        Me.BtnAddChecked.Text = "Add >"
        Me.BtnAddChecked.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(510, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Checked List Boxes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstMagazines
        '
        Me.LstMagazines.FormattingEnabled = True
        Me.LstMagazines.Location = New System.Drawing.Point(3, 53)
        Me.LstMagazines.Name = "LstMagazines"
        Me.LstMagazines.Size = New System.Drawing.Size(165, 244)
        Me.LstMagazines.TabIndex = 6
        '
        'LstMagazinesSelected
        '
        Me.LstMagazinesSelected.FormattingEnabled = True
        Me.LstMagazinesSelected.Location = New System.Drawing.Point(348, 53)
        Me.LstMagazinesSelected.Name = "LstMagazinesSelected"
        Me.LstMagazinesSelected.Size = New System.Drawing.Size(165, 244)
        Me.LstMagazinesSelected.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnRemoveCharacter)
        Me.Panel4.Controls.Add(Me.BtnAddCharacter)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.CboBuffyCharacters)
        Me.Panel4.Controls.Add(Me.LblSystemMessage)
        Me.Panel4.Controls.Add(Me.BtnDisplayMessage)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.CboState)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(536, 331)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(518, 313)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(510, 38)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Combo Boxes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboState
        '
        Me.CboState.FormattingEnabled = True
        Me.CboState.Items.AddRange(New Object() {"CA", "FL", "MD", "NY", "PA", "TX"})
        Me.CboState.Location = New System.Drawing.Point(65, 50)
        Me.CboState.Name = "CboState"
        Me.CboState.Size = New System.Drawing.Size(165, 32)
        Me.CboState.Sorted = True
        Me.CboState.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "State"
        '
        'BtnDisplayMessage
        '
        Me.BtnDisplayMessage.Location = New System.Drawing.Point(236, 50)
        Me.BtnDisplayMessage.Name = "BtnDisplayMessage"
        Me.BtnDisplayMessage.Size = New System.Drawing.Size(277, 32)
        Me.BtnDisplayMessage.TabIndex = 3
        Me.BtnDisplayMessage.Text = "Display Message"
        Me.BtnDisplayMessage.UseVisualStyleBackColor = True
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.Location = New System.Drawing.Point(61, 104)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(452, 84)
        Me.LblSystemMessage.TabIndex = 4
        Me.LblSystemMessage.Text = "System Message"
        Me.LblSystemMessage.Visible = False
        '
        'BtnAddCharacter
        '
        Me.BtnAddCharacter.ForeColor = System.Drawing.Color.Green
        Me.BtnAddCharacter.Location = New System.Drawing.Point(174, 232)
        Me.BtnAddCharacter.Name = "BtnAddCharacter"
        Me.BtnAddCharacter.Size = New System.Drawing.Size(339, 32)
        Me.BtnAddCharacter.TabIndex = 7
        Me.BtnAddCharacter.Text = "Add Character"
        Me.BtnAddCharacter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Buffy Characters"
        '
        'CboBuffyCharacters
        '
        Me.CboBuffyCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBuffyCharacters.FormattingEnabled = True
        Me.CboBuffyCharacters.Items.AddRange(New Object() {"CA", "FL", "MD", "NY", "PA", "TX"})
        Me.CboBuffyCharacters.Location = New System.Drawing.Point(174, 194)
        Me.CboBuffyCharacters.Name = "CboBuffyCharacters"
        Me.CboBuffyCharacters.Size = New System.Drawing.Size(339, 32)
        Me.CboBuffyCharacters.Sorted = True
        Me.CboBuffyCharacters.TabIndex = 5
        '
        'BtnRemoveCharacter
        '
        Me.BtnRemoveCharacter.ForeColor = System.Drawing.Color.Maroon
        Me.BtnRemoveCharacter.Location = New System.Drawing.Point(174, 270)
        Me.BtnRemoveCharacter.Name = "BtnRemoveCharacter"
        Me.BtnRemoveCharacter.Size = New System.Drawing.Size(339, 32)
        Me.BtnRemoveCharacter.TabIndex = 8
        Me.BtnRemoveCharacter.Text = "Remove Character"
        Me.BtnRemoveCharacter.UseVisualStyleBackColor = True
        '
        'FrmComboBoxesAndListBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 654)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FrmComboBoxesAndListBoxes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Boxes And List Boxes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCopyItem As Button
    Friend WithEvents LstHardwareSelected As ListBox
    Friend WithEvents LstHardware As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnResetSingleSelectListBoxes As Button
    Friend WithEvents BtnMoveItem As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnResetMultiSelectListBoxes As Button
    Friend WithEvents BtnMoveItems As Button
    Friend WithEvents BtnCopyItems As Button
    Friend WithEvents LstSoftwareSelected As ListBox
    Friend WithEvents LstSoftware As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LstMagazines As CheckedListBox
    Friend WithEvents BtnResetCheckedListboxes As Button
    Friend WithEvents BtnRemoveChecked As Button
    Friend WithEvents BtnAddChecked As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LstMagazinesSelected As CheckedListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboState As ComboBox
    Friend WithEvents BtnAddCharacter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CboBuffyCharacters As ComboBox
    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents BtnDisplayMessage As Button
    Friend WithEvents BtnRemoveCharacter As Button
End Class
