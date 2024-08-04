<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLooping
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
        Me.PnlForNext = New System.Windows.Forms.Panel()
        Me.BtnRunForNextLoop = New System.Windows.Forms.Button()
        Me.TxtStep = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtUpper = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLower = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LstForNext = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlForEach = New System.Windows.Forms.Panel()
        Me.BtnStartPOS = New System.Windows.Forms.Button()
        Me.BtnViewVehicles = New System.Windows.Forms.Button()
        Me.BtnBrowseOrders = New System.Windows.Forms.Button()
        Me.LstForEachText = New System.Windows.Forms.ListBox()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnRunForEachLoop = New System.Windows.Forms.Button()
        Me.LstForEachName = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkAbort = New System.Windows.Forms.CheckBox()
        Me.TxtTarget = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnRunWhileLoop = New System.Windows.Forms.Button()
        Me.LstWhile = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ChkDoUntilAbort = New System.Windows.Forms.CheckBox()
        Me.TxtDoUntilTarget = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnRunDoUntilLoop = New System.Windows.Forms.Button()
        Me.LstDoUntil = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtBreak = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkDoWhileAbort = New System.Windows.Forms.CheckBox()
        Me.TxtDoWhileTarget = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnRunDoWhileLoop = New System.Windows.Forms.Button()
        Me.LstDoWhile = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlForNext.SuspendLayout()
        Me.PnlForEach.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlForNext
        '
        Me.PnlForNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlForNext.Controls.Add(Me.BtnRunForNextLoop)
        Me.PnlForNext.Controls.Add(Me.TxtStep)
        Me.PnlForNext.Controls.Add(Me.Label9)
        Me.PnlForNext.Controls.Add(Me.TxtUpper)
        Me.PnlForNext.Controls.Add(Me.Label8)
        Me.PnlForNext.Controls.Add(Me.TxtLower)
        Me.PnlForNext.Controls.Add(Me.Label7)
        Me.PnlForNext.Controls.Add(Me.LstForNext)
        Me.PnlForNext.Controls.Add(Me.Label1)
        Me.PnlForNext.Location = New System.Drawing.Point(12, 12)
        Me.PnlForNext.Name = "PnlForNext"
        Me.PnlForNext.Size = New System.Drawing.Size(317, 373)
        Me.PnlForNext.TabIndex = 0
        '
        'BtnRunForNextLoop
        '
        Me.BtnRunForNextLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunForNextLoop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRunForNextLoop.Location = New System.Drawing.Point(133, 313)
        Me.BtnRunForNextLoop.Name = "BtnRunForNextLoop"
        Me.BtnRunForNextLoop.Size = New System.Drawing.Size(169, 53)
        Me.BtnRunForNextLoop.TabIndex = 8
        Me.BtnRunForNextLoop.Text = "Run Loop"
        Me.BtnRunForNextLoop.UseVisualStyleBackColor = True
        '
        'TxtStep
        '
        Me.TxtStep.Location = New System.Drawing.Point(202, 117)
        Me.TxtStep.Name = "TxtStep"
        Me.TxtStep.Size = New System.Drawing.Size(100, 29)
        Me.TxtStep.TabIndex = 7
        Me.TxtStep.Text = "1"
        Me.TxtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(129, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Step"
        '
        'TxtUpper
        '
        Me.TxtUpper.Location = New System.Drawing.Point(202, 82)
        Me.TxtUpper.Name = "TxtUpper"
        Me.TxtUpper.Size = New System.Drawing.Size(100, 29)
        Me.TxtUpper.TabIndex = 5
        Me.TxtUpper.Text = "10"
        Me.TxtUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Upper"
        '
        'TxtLower
        '
        Me.TxtLower.Location = New System.Drawing.Point(202, 47)
        Me.TxtLower.Name = "TxtLower"
        Me.TxtLower.Size = New System.Drawing.Size(100, 29)
        Me.TxtLower.TabIndex = 3
        Me.TxtLower.Text = "0"
        Me.TxtLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Lower"
        '
        'LstForNext
        '
        Me.LstForNext.FormattingEnabled = True
        Me.LstForNext.ItemHeight = 24
        Me.LstForNext.Location = New System.Drawing.Point(3, 50)
        Me.LstForNext.Name = "LstForNext"
        Me.LstForNext.Size = New System.Drawing.Size(120, 316)
        Me.LstForNext.TabIndex = 1
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
        Me.Label1.Size = New System.Drawing.Size(309, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "For Next Loop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlForEach
        '
        Me.PnlForEach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlForEach.Controls.Add(Me.BtnStartPOS)
        Me.PnlForEach.Controls.Add(Me.BtnViewVehicles)
        Me.PnlForEach.Controls.Add(Me.BtnBrowseOrders)
        Me.PnlForEach.Controls.Add(Me.LstForEachText)
        Me.PnlForEach.Controls.Add(Me.BtnCustomers)
        Me.PnlForEach.Controls.Add(Me.BtnRunForEachLoop)
        Me.PnlForEach.Controls.Add(Me.LstForEachName)
        Me.PnlForEach.Controls.Add(Me.Label2)
        Me.PnlForEach.Location = New System.Drawing.Point(335, 12)
        Me.PnlForEach.Name = "PnlForEach"
        Me.PnlForEach.Size = New System.Drawing.Size(436, 373)
        Me.PnlForEach.TabIndex = 1
        '
        'BtnStartPOS
        '
        Me.BtnStartPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartPOS.ForeColor = System.Drawing.Color.Black
        Me.BtnStartPOS.Location = New System.Drawing.Point(181, 227)
        Me.BtnStartPOS.Name = "BtnStartPOS"
        Me.BtnStartPOS.Size = New System.Drawing.Size(121, 53)
        Me.BtnStartPOS.TabIndex = 15
        Me.BtnStartPOS.Text = "POS"
        Me.BtnStartPOS.UseVisualStyleBackColor = True
        '
        'BtnViewVehicles
        '
        Me.BtnViewVehicles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewVehicles.ForeColor = System.Drawing.Color.Black
        Me.BtnViewVehicles.Location = New System.Drawing.Point(181, 168)
        Me.BtnViewVehicles.Name = "BtnViewVehicles"
        Me.BtnViewVehicles.Size = New System.Drawing.Size(121, 53)
        Me.BtnViewVehicles.TabIndex = 14
        Me.BtnViewVehicles.Text = "Vehicles"
        Me.BtnViewVehicles.UseVisualStyleBackColor = True
        '
        'BtnBrowseOrders
        '
        Me.BtnBrowseOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowseOrders.ForeColor = System.Drawing.Color.Black
        Me.BtnBrowseOrders.Location = New System.Drawing.Point(181, 109)
        Me.BtnBrowseOrders.Name = "BtnBrowseOrders"
        Me.BtnBrowseOrders.Size = New System.Drawing.Size(121, 53)
        Me.BtnBrowseOrders.TabIndex = 13
        Me.BtnBrowseOrders.Text = "Orders"
        Me.BtnBrowseOrders.UseVisualStyleBackColor = True
        '
        'LstForEachText
        '
        Me.LstForEachText.FormattingEnabled = True
        Me.LstForEachText.ItemHeight = 24
        Me.LstForEachText.Location = New System.Drawing.Point(308, 50)
        Me.LstForEachText.Name = "LstForEachText"
        Me.LstForEachText.Size = New System.Drawing.Size(120, 316)
        Me.LstForEachText.TabIndex = 12
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.ForeColor = System.Drawing.Color.Black
        Me.BtnCustomers.Location = New System.Drawing.Point(181, 50)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(121, 53)
        Me.BtnCustomers.TabIndex = 11
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnRunForEachLoop
        '
        Me.BtnRunForEachLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunForEachLoop.ForeColor = System.Drawing.Color.Blue
        Me.BtnRunForEachLoop.Location = New System.Drawing.Point(181, 313)
        Me.BtnRunForEachLoop.Name = "BtnRunForEachLoop"
        Me.BtnRunForEachLoop.Size = New System.Drawing.Size(121, 53)
        Me.BtnRunForEachLoop.TabIndex = 10
        Me.BtnRunForEachLoop.Text = "Run Loop"
        Me.BtnRunForEachLoop.UseVisualStyleBackColor = True
        '
        'LstForEachName
        '
        Me.LstForEachName.FormattingEnabled = True
        Me.LstForEachName.ItemHeight = 24
        Me.LstForEachName.Location = New System.Drawing.Point(3, 50)
        Me.LstForEachName.Name = "LstForEachName"
        Me.LstForEachName.Size = New System.Drawing.Size(172, 316)
        Me.LstForEachName.TabIndex = 9
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
        Me.Label2.Size = New System.Drawing.Size(428, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "For Each Loop"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ChkAbort)
        Me.Panel3.Controls.Add(Me.TxtTarget)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.BtnRunWhileLoop)
        Me.Panel3.Controls.Add(Me.LstWhile)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(777, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 373)
        Me.Panel3.TabIndex = 2
        '
        'ChkAbort
        '
        Me.ChkAbort.AutoSize = True
        Me.ChkAbort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAbort.Location = New System.Drawing.Point(228, 87)
        Me.ChkAbort.Name = "ChkAbort"
        Me.ChkAbort.Size = New System.Drawing.Size(74, 28)
        Me.ChkAbort.TabIndex = 13
        Me.ChkAbort.Text = "Abort"
        Me.ChkAbort.UseVisualStyleBackColor = True
        '
        'TxtTarget
        '
        Me.TxtTarget.Location = New System.Drawing.Point(202, 52)
        Me.TxtTarget.Name = "TxtTarget"
        Me.TxtTarget.Size = New System.Drawing.Size(100, 29)
        Me.TxtTarget.TabIndex = 12
        Me.TxtTarget.Text = "100000"
        Me.TxtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(129, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Target"
        '
        'BtnRunWhileLoop
        '
        Me.BtnRunWhileLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunWhileLoop.ForeColor = System.Drawing.Color.Teal
        Me.BtnRunWhileLoop.Location = New System.Drawing.Point(133, 315)
        Me.BtnRunWhileLoop.Name = "BtnRunWhileLoop"
        Me.BtnRunWhileLoop.Size = New System.Drawing.Size(169, 53)
        Me.BtnRunWhileLoop.TabIndex = 10
        Me.BtnRunWhileLoop.Text = "Run Loop"
        Me.BtnRunWhileLoop.UseVisualStyleBackColor = True
        '
        'LstWhile
        '
        Me.LstWhile.FormattingEnabled = True
        Me.LstWhile.ItemHeight = 24
        Me.LstWhile.Location = New System.Drawing.Point(3, 52)
        Me.LstWhile.Name = "LstWhile"
        Me.LstWhile.Size = New System.Drawing.Size(120, 316)
        Me.LstWhile.TabIndex = 9
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
        Me.Label3.Size = New System.Drawing.Size(302, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "While Loop"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ChkDoUntilAbort)
        Me.Panel4.Controls.Add(Me.TxtDoUntilTarget)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.BtnRunDoUntilLoop)
        Me.Panel4.Controls.Add(Me.LstDoUntil)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(552, 395)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 373)
        Me.Panel4.TabIndex = 5
        '
        'ChkDoUntilAbort
        '
        Me.ChkDoUntilAbort.AutoSize = True
        Me.ChkDoUntilAbort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkDoUntilAbort.Location = New System.Drawing.Point(228, 87)
        Me.ChkDoUntilAbort.Name = "ChkDoUntilAbort"
        Me.ChkDoUntilAbort.Size = New System.Drawing.Size(74, 28)
        Me.ChkDoUntilAbort.TabIndex = 18
        Me.ChkDoUntilAbort.Text = "Abort"
        Me.ChkDoUntilAbort.UseVisualStyleBackColor = True
        '
        'TxtDoUntilTarget
        '
        Me.TxtDoUntilTarget.Location = New System.Drawing.Point(202, 52)
        Me.TxtDoUntilTarget.Name = "TxtDoUntilTarget"
        Me.TxtDoUntilTarget.Size = New System.Drawing.Size(100, 29)
        Me.TxtDoUntilTarget.TabIndex = 17
        Me.TxtDoUntilTarget.Text = "100000"
        Me.TxtDoUntilTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(129, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Target"
        '
        'BtnRunDoUntilLoop
        '
        Me.BtnRunDoUntilLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunDoUntilLoop.ForeColor = System.Drawing.Color.Olive
        Me.BtnRunDoUntilLoop.Location = New System.Drawing.Point(133, 315)
        Me.BtnRunDoUntilLoop.Name = "BtnRunDoUntilLoop"
        Me.BtnRunDoUntilLoop.Size = New System.Drawing.Size(169, 53)
        Me.BtnRunDoUntilLoop.TabIndex = 15
        Me.BtnRunDoUntilLoop.Text = "Run Loop"
        Me.BtnRunDoUntilLoop.UseVisualStyleBackColor = True
        '
        'LstDoUntil
        '
        Me.LstDoUntil.FormattingEnabled = True
        Me.LstDoUntil.ItemHeight = 24
        Me.LstDoUntil.Location = New System.Drawing.Point(3, 52)
        Me.LstDoUntil.Name = "LstDoUntil"
        Me.LstDoUntil.Size = New System.Drawing.Size(120, 316)
        Me.LstDoUntil.TabIndex = 14
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
        Me.Label4.Size = New System.Drawing.Size(302, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Do Until Loop"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxtBreak)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.ChkDoWhileAbort)
        Me.Panel5.Controls.Add(Me.TxtDoWhileTarget)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.BtnRunDoWhileLoop)
        Me.Panel5.Controls.Add(Me.LstDoWhile)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(236, 395)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(310, 373)
        Me.Panel5.TabIndex = 4
        '
        'TxtBreak
        '
        Me.TxtBreak.Location = New System.Drawing.Point(202, 87)
        Me.TxtBreak.Name = "TxtBreak"
        Me.TxtBreak.Size = New System.Drawing.Size(100, 29)
        Me.TxtBreak.TabIndex = 20
        Me.TxtBreak.Text = "1000"
        Me.TxtBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(129, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 24)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Break"
        '
        'ChkDoWhileAbort
        '
        Me.ChkDoWhileAbort.AutoSize = True
        Me.ChkDoWhileAbort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkDoWhileAbort.Location = New System.Drawing.Point(228, 122)
        Me.ChkDoWhileAbort.Name = "ChkDoWhileAbort"
        Me.ChkDoWhileAbort.Size = New System.Drawing.Size(74, 28)
        Me.ChkDoWhileAbort.TabIndex = 18
        Me.ChkDoWhileAbort.Text = "Abort"
        Me.ChkDoWhileAbort.UseVisualStyleBackColor = True
        '
        'TxtDoWhileTarget
        '
        Me.TxtDoWhileTarget.Location = New System.Drawing.Point(202, 52)
        Me.TxtDoWhileTarget.Name = "TxtDoWhileTarget"
        Me.TxtDoWhileTarget.Size = New System.Drawing.Size(100, 29)
        Me.TxtDoWhileTarget.TabIndex = 17
        Me.TxtDoWhileTarget.Text = "100000"
        Me.TxtDoWhileTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(129, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Target"
        '
        'BtnRunDoWhileLoop
        '
        Me.BtnRunDoWhileLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunDoWhileLoop.ForeColor = System.Drawing.Color.Green
        Me.BtnRunDoWhileLoop.Location = New System.Drawing.Point(133, 315)
        Me.BtnRunDoWhileLoop.Name = "BtnRunDoWhileLoop"
        Me.BtnRunDoWhileLoop.Size = New System.Drawing.Size(169, 53)
        Me.BtnRunDoWhileLoop.TabIndex = 15
        Me.BtnRunDoWhileLoop.Text = "Run Loop"
        Me.BtnRunDoWhileLoop.UseVisualStyleBackColor = True
        '
        'LstDoWhile
        '
        Me.LstDoWhile.FormattingEnabled = True
        Me.LstDoWhile.ItemHeight = 24
        Me.LstDoWhile.Location = New System.Drawing.Point(3, 52)
        Me.LstDoWhile.Name = "LstDoWhile"
        Me.LstDoWhile.Size = New System.Drawing.Size(120, 316)
        Me.LstDoWhile.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Do While Loop"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmLooping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 780)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlForEach)
        Me.Controls.Add(Me.PnlForNext)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLooping"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Loops"
        Me.PnlForNext.ResumeLayout(False)
        Me.PnlForNext.PerformLayout()
        Me.PnlForEach.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlForNext As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlForEach As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUpper As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLower As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LstForNext As ListBox
    Friend WithEvents TxtStep As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnRunForNextLoop As Button
    Friend WithEvents BtnRunForEachLoop As Button
    Friend WithEvents LstForEachName As ListBox
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents LstForEachText As ListBox
    Friend WithEvents BtnStartPOS As Button
    Friend WithEvents BtnViewVehicles As Button
    Friend WithEvents BtnBrowseOrders As Button
    Friend WithEvents TxtTarget As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnRunWhileLoop As Button
    Friend WithEvents LstWhile As ListBox
    Friend WithEvents ChkAbort As CheckBox
    Friend WithEvents ChkDoUntilAbort As CheckBox
    Friend WithEvents TxtDoUntilTarget As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnRunDoUntilLoop As Button
    Friend WithEvents LstDoUntil As ListBox
    Friend WithEvents ChkDoWhileAbort As CheckBox
    Friend WithEvents TxtDoWhileTarget As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnRunDoWhileLoop As Button
    Friend WithEvents LstDoWhile As ListBox
    Friend WithEvents TxtBreak As TextBox
    Friend WithEvents Label12 As Label
End Class
