<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColors
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboStandardColors = New System.Windows.Forms.ComboBox()
        Me.CboSystemColors = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlColorDisplay = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PnlColorDisplay)
        Me.Panel1.Controls.Add(Me.CboSystemColors)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CboStandardColors)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 227)
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
        Me.Label1.Size = New System.Drawing.Size(395, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Combo Box Color Pickers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Standard Colors"
        '
        'CboStandardColors
        '
        Me.CboStandardColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboStandardColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStandardColors.FormattingEnabled = True
        Me.CboStandardColors.Location = New System.Drawing.Point(7, 98)
        Me.CboStandardColors.Name = "CboStandardColors"
        Me.CboStandardColors.Size = New System.Drawing.Size(274, 32)
        Me.CboStandardColors.TabIndex = 2
        '
        'CboSystemColors
        '
        Me.CboSystemColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboSystemColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSystemColors.FormattingEnabled = True
        Me.CboSystemColors.Location = New System.Drawing.Point(7, 174)
        Me.CboSystemColors.Name = "CboSystemColors"
        Me.CboSystemColors.Size = New System.Drawing.Size(274, 32)
        Me.CboSystemColors.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "System Colors"
        '
        'PnlColorDisplay
        '
        Me.PnlColorDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColorDisplay.Location = New System.Drawing.Point(287, 98)
        Me.PnlColorDisplay.Name = "PnlColorDisplay"
        Me.PnlColorDisplay.Size = New System.Drawing.Size(108, 108)
        Me.PnlColorDisplay.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.HScrollBar3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.HScrollBar2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.HScrollBar1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(421, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 227)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(367, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 101)
        Me.Panel3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "R"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(470, 43)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "RGB Color Picker"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(54, 74)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(253, 17)
        Me.HScrollBar1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "255"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(313, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "255"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "0"
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar2.Location = New System.Drawing.Point(54, 113)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(253, 17)
        Me.HScrollBar2.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "G"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(313, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "255"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "0"
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar3.Location = New System.Drawing.Point(54, 154)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(253, 17)
        Me.HScrollBar3.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 24)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "B"
        '
        'FrmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 779)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FrmColors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Colors"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlColorDisplay As Panel
    Friend WithEvents CboSystemColors As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CboStandardColors As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
End Class
