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
        Me.PnlColorDisplay = New System.Windows.Forms.Panel()
        Me.CboSystemColors = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboStandardColors = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TrackBlue = New System.Windows.Forms.TrackBar()
        Me.TrackGreen = New System.Windows.Forms.TrackBar()
        Me.TrackRed = New System.Windows.Forms.TrackBar()
        Me.TxtBlueValue = New System.Windows.Forms.TextBox()
        Me.TxtGreenValue = New System.Windows.Forms.TextBox()
        Me.TxtRedValue = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlRGBColorDisplay = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlColorDialogDisplay = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnSelectBackColor = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnSelectColor1 = New System.Windows.Forms.Button()
        Me.BtnSelectColor2 = New System.Windows.Forms.Button()
        Me.PnlColor1 = New System.Windows.Forms.Panel()
        Me.PnlColor2 = New System.Windows.Forms.Panel()
        Me.TxtColor1Hex = New System.Windows.Forms.TextBox()
        Me.BtnColor2Hex = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TrackBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(410, 219)
        Me.Panel1.TabIndex = 0
        '
        'PnlColorDisplay
        '
        Me.PnlColorDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColorDisplay.Location = New System.Drawing.Point(294, 98)
        Me.PnlColorDisplay.Name = "PnlColorDisplay"
        Me.PnlColorDisplay.Size = New System.Drawing.Size(108, 108)
        Me.PnlColorDisplay.TabIndex = 5
        '
        'CboSystemColors
        '
        Me.CboSystemColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboSystemColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSystemColors.FormattingEnabled = True
        Me.CboSystemColors.Location = New System.Drawing.Point(7, 173)
        Me.CboSystemColors.Name = "CboSystemColors"
        Me.CboSystemColors.Size = New System.Drawing.Size(281, 32)
        Me.CboSystemColors.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "System Colors"
        '
        'CboStandardColors
        '
        Me.CboStandardColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboStandardColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStandardColors.FormattingEnabled = True
        Me.CboStandardColors.Location = New System.Drawing.Point(7, 98)
        Me.CboStandardColors.Name = "CboStandardColors"
        Me.CboStandardColors.Size = New System.Drawing.Size(281, 32)
        Me.CboStandardColors.TabIndex = 2
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
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Combo Box Color Pickers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TrackBlue)
        Me.Panel2.Controls.Add(Me.TrackGreen)
        Me.Panel2.Controls.Add(Me.TrackRed)
        Me.Panel2.Controls.Add(Me.TxtBlueValue)
        Me.Panel2.Controls.Add(Me.TxtGreenValue)
        Me.Panel2.Controls.Add(Me.TxtRedValue)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PnlRGBColorDisplay)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(428, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 219)
        Me.Panel2.TabIndex = 6
        '
        'TrackBlue
        '
        Me.TrackBlue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBlue.AutoSize = False
        Me.TrackBlue.Location = New System.Drawing.Point(57, 180)
        Me.TrackBlue.Maximum = 255
        Me.TrackBlue.Name = "TrackBlue"
        Me.TrackBlue.Size = New System.Drawing.Size(198, 21)
        Me.TrackBlue.TabIndex = 20
        Me.TrackBlue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TrackGreen
        '
        Me.TrackGreen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackGreen.AutoSize = False
        Me.TrackGreen.Location = New System.Drawing.Point(57, 126)
        Me.TrackGreen.Maximum = 255
        Me.TrackGreen.Name = "TrackGreen"
        Me.TrackGreen.Size = New System.Drawing.Size(198, 21)
        Me.TrackGreen.TabIndex = 19
        Me.TrackGreen.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TrackRed
        '
        Me.TrackRed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackRed.AutoSize = False
        Me.TrackRed.Location = New System.Drawing.Point(57, 71)
        Me.TrackRed.Maximum = 255
        Me.TrackRed.Name = "TrackRed"
        Me.TrackRed.Size = New System.Drawing.Size(198, 21)
        Me.TrackRed.TabIndex = 6
        Me.TrackRed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TxtBlueValue
        '
        Me.TxtBlueValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBlueValue.ForeColor = System.Drawing.Color.Blue
        Me.TxtBlueValue.Location = New System.Drawing.Point(324, 174)
        Me.TxtBlueValue.Name = "TxtBlueValue"
        Me.TxtBlueValue.Size = New System.Drawing.Size(81, 29)
        Me.TxtBlueValue.TabIndex = 18
        Me.TxtBlueValue.Text = "0"
        Me.TxtBlueValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGreenValue
        '
        Me.TxtGreenValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGreenValue.ForeColor = System.Drawing.Color.Green
        Me.TxtGreenValue.Location = New System.Drawing.Point(324, 121)
        Me.TxtGreenValue.Name = "TxtGreenValue"
        Me.TxtGreenValue.Size = New System.Drawing.Size(81, 29)
        Me.TxtGreenValue.TabIndex = 17
        Me.TxtGreenValue.Text = "0"
        Me.TxtGreenValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRedValue
        '
        Me.TxtRedValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRedValue.ForeColor = System.Drawing.Color.Red
        Me.TxtRedValue.Location = New System.Drawing.Point(324, 66)
        Me.TxtRedValue.Name = "TxtRedValue"
        Me.TxtRedValue.Size = New System.Drawing.Size(81, 29)
        Me.TxtRedValue.TabIndex = 7
        Me.TxtRedValue.Text = "0"
        Me.TxtRedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "255"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 24)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "B"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "255"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "G"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "255"
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
        'PnlRGBColorDisplay
        '
        Me.PnlRGBColorDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlRGBColorDisplay.BackColor = System.Drawing.Color.Black
        Me.PnlRGBColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlRGBColorDisplay.Location = New System.Drawing.Point(431, 65)
        Me.PnlRGBColorDisplay.Name = "PnlRGBColorDisplay"
        Me.PnlRGBColorDisplay.Size = New System.Drawing.Size(141, 141)
        Me.PnlRGBColorDisplay.TabIndex = 5
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
        Me.Label6.Size = New System.Drawing.Size(569, 43)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "RGB Color Picker"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnSelectBackColor)
        Me.Panel3.Controls.Add(Me.PnlColorDialogDisplay)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(12, 237)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 202)
        Me.Panel3.TabIndex = 7
        '
        'PnlColorDialogDisplay
        '
        Me.PnlColorDialogDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlColorDialogDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColorDialogDisplay.Location = New System.Drawing.Point(294, 77)
        Me.PnlColorDialogDisplay.Name = "PnlColorDialogDisplay"
        Me.PnlColorDialogDisplay.Size = New System.Drawing.Size(108, 108)
        Me.PnlColorDialogDisplay.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(402, 43)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = " Color Dialog"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelectBackColor
        '
        Me.BtnSelectBackColor.Location = New System.Drawing.Point(3, 77)
        Me.BtnSelectBackColor.Name = "BtnSelectBackColor"
        Me.BtnSelectBackColor.Size = New System.Drawing.Size(285, 39)
        Me.BtnSelectBackColor.TabIndex = 6
        Me.BtnSelectBackColor.Text = "Select Back Color"
        Me.BtnSelectBackColor.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnColor2Hex)
        Me.Panel4.Controls.Add(Me.TxtColor1Hex)
        Me.Panel4.Controls.Add(Me.PnlColor2)
        Me.Panel4.Controls.Add(Me.PnlColor1)
        Me.Panel4.Controls.Add(Me.BtnSelectColor2)
        Me.Panel4.Controls.Add(Me.BtnSelectColor1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Location = New System.Drawing.Point(428, 237)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(577, 202)
        Me.Panel4.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(569, 43)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "RGB Color Picker"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(464, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(108, 108)
        Me.Panel5.TabIndex = 6
        '
        'BtnSelectColor1
        '
        Me.BtnSelectColor1.Location = New System.Drawing.Point(3, 77)
        Me.BtnSelectColor1.Name = "BtnSelectColor1"
        Me.BtnSelectColor1.Size = New System.Drawing.Size(175, 39)
        Me.BtnSelectColor1.TabIndex = 7
        Me.BtnSelectColor1.Text = "Select Color 1"
        Me.BtnSelectColor1.UseVisualStyleBackColor = True
        '
        'BtnSelectColor2
        '
        Me.BtnSelectColor2.Location = New System.Drawing.Point(3, 146)
        Me.BtnSelectColor2.Name = "BtnSelectColor2"
        Me.BtnSelectColor2.Size = New System.Drawing.Size(175, 39)
        Me.BtnSelectColor2.TabIndex = 8
        Me.BtnSelectColor2.Text = "Select Color 2"
        Me.BtnSelectColor2.UseVisualStyleBackColor = True
        '
        'PnlColor1
        '
        Me.PnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColor1.Location = New System.Drawing.Point(184, 77)
        Me.PnlColor1.Name = "PnlColor1"
        Me.PnlColor1.Size = New System.Drawing.Size(39, 39)
        Me.PnlColor1.TabIndex = 9
        '
        'PnlColor2
        '
        Me.PnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColor2.Location = New System.Drawing.Point(184, 146)
        Me.PnlColor2.Name = "PnlColor2"
        Me.PnlColor2.Size = New System.Drawing.Size(39, 39)
        Me.PnlColor2.TabIndex = 10
        '
        'TxtColor1Hex
        '
        Me.TxtColor1Hex.Location = New System.Drawing.Point(229, 81)
        Me.TxtColor1Hex.Name = "TxtColor1Hex"
        Me.TxtColor1Hex.Size = New System.Drawing.Size(176, 29)
        Me.TxtColor1Hex.TabIndex = 11
        '
        'BtnColor2Hex
        '
        Me.BtnColor2Hex.Location = New System.Drawing.Point(229, 150)
        Me.BtnColor2Hex.Name = "BtnColor2Hex"
        Me.BtnColor2Hex.Size = New System.Drawing.Size(176, 29)
        Me.BtnColor2Hex.TabIndex = 12
        '
        'FrmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 459)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmColors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Colors"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TrackBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents PnlRGBColorDisplay As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBlueValue As TextBox
    Friend WithEvents TxtGreenValue As TextBox
    Friend WithEvents TxtRedValue As TextBox
    Friend WithEvents TrackBlue As TrackBar
    Friend WithEvents TrackGreen As TrackBar
    Friend WithEvents TrackRed As TrackBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnSelectBackColor As Button
    Friend WithEvents PnlColorDialogDisplay As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnSelectColor1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents BtnColor2Hex As TextBox
    Friend WithEvents TxtColor1Hex As TextBox
    Friend WithEvents PnlColor2 As Panel
    Friend WithEvents PnlColor1 As Panel
    Friend WithEvents BtnSelectColor2 As Button
End Class
