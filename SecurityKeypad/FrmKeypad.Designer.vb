<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKeypad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ChkAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.LblCode6 = New System.Windows.Forms.Label()
        Me.LblCode7 = New System.Windows.Forms.Label()
        Me.LblCode8 = New System.Windows.Forms.Label()
        Me.LblCode5 = New System.Windows.Forms.Label()
        Me.LblCode2 = New System.Windows.Forms.Label()
        Me.LblCode3 = New System.Windows.Forms.Label()
        Me.LblCode4 = New System.Windows.Forms.Label()
        Me.LblCode1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnShowAccessCode = New System.Windows.Forms.Button()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnCharD = New System.Windows.Forms.Button()
        Me.BtnCharB = New System.Windows.Forms.Button()
        Me.BtnCharA = New System.Windows.Forms.Button()
        Me.BtnCharC = New System.Windows.Forms.Button()
        Me.BtnNum0 = New System.Windows.Forms.Button()
        Me.BtnNum5 = New System.Windows.Forms.Button()
        Me.BtnNum6 = New System.Windows.Forms.Button()
        Me.BtnNum4 = New System.Windows.Forms.Button()
        Me.BtnNum8 = New System.Windows.Forms.Button()
        Me.BtnNum9 = New System.Windows.Forms.Button()
        Me.BtnNum7 = New System.Windows.Forms.Button()
        Me.BtnNum2 = New System.Windows.Forms.Button()
        Me.BtnNum3 = New System.Windows.Forms.Button()
        Me.BtnNum1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimLoadMenu = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ChkAlwaysOnTop
        '
        Me.ChkAlwaysOnTop.AutoSize = True
        Me.ChkAlwaysOnTop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAlwaysOnTop.Checked = True
        Me.ChkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAlwaysOnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAlwaysOnTop.Location = New System.Drawing.Point(258, 14)
        Me.ChkAlwaysOnTop.Name = "ChkAlwaysOnTop"
        Me.ChkAlwaysOnTop.Size = New System.Drawing.Size(117, 20)
        Me.ChkAlwaysOnTop.TabIndex = 66
        Me.ChkAlwaysOnTop.Text = "Always On Top"
        Me.ChkAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'LblCode6
        '
        Me.LblCode6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode6.Location = New System.Drawing.Point(242, 42)
        Me.LblCode6.Name = "LblCode6"
        Me.LblCode6.Size = New System.Drawing.Size(40, 40)
        Me.LblCode6.TabIndex = 65
        Me.LblCode6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode7
        '
        Me.LblCode7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode7.Location = New System.Drawing.Point(288, 42)
        Me.LblCode7.Name = "LblCode7"
        Me.LblCode7.Size = New System.Drawing.Size(40, 40)
        Me.LblCode7.TabIndex = 64
        Me.LblCode7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode8
        '
        Me.LblCode8.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode8.Location = New System.Drawing.Point(334, 42)
        Me.LblCode8.Name = "LblCode8"
        Me.LblCode8.Size = New System.Drawing.Size(40, 40)
        Me.LblCode8.TabIndex = 63
        Me.LblCode8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode5
        '
        Me.LblCode5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode5.Location = New System.Drawing.Point(196, 42)
        Me.LblCode5.Name = "LblCode5"
        Me.LblCode5.Size = New System.Drawing.Size(40, 40)
        Me.LblCode5.TabIndex = 62
        Me.LblCode5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode2
        '
        Me.LblCode2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode2.Location = New System.Drawing.Point(58, 42)
        Me.LblCode2.Name = "LblCode2"
        Me.LblCode2.Size = New System.Drawing.Size(40, 40)
        Me.LblCode2.TabIndex = 61
        Me.LblCode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode3
        '
        Me.LblCode3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode3.Location = New System.Drawing.Point(104, 42)
        Me.LblCode3.Name = "LblCode3"
        Me.LblCode3.Size = New System.Drawing.Size(40, 40)
        Me.LblCode3.TabIndex = 60
        Me.LblCode3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode4
        '
        Me.LblCode4.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode4.Location = New System.Drawing.Point(150, 42)
        Me.LblCode4.Name = "LblCode4"
        Me.LblCode4.Size = New System.Drawing.Size(40, 40)
        Me.LblCode4.TabIndex = 59
        Me.LblCode4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode1
        '
        Me.LblCode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode1.Location = New System.Drawing.Point(12, 42)
        Me.LblCode1.Name = "LblCode1"
        Me.LblCode1.Size = New System.Drawing.Size(40, 40)
        Me.LblCode1.TabIndex = 58
        Me.LblCode1.Text = "_"
        Me.LblCode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnExit.Location = New System.Drawing.Point(12, 399)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(361, 60)
        Me.BtnExit.TabIndex = 57
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSystemMessage.Location = New System.Drawing.Point(12, 94)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(361, 24)
        Me.LblSystemMessage.TabIndex = 56
        Me.LblSystemMessage.Text = "System Message"
        Me.LblSystemMessage.Visible = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Wingdings 2", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(314, 135)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 55
        Me.BtnClear.TabStop = False
        Me.BtnClear.Text = "S"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnShowAccessCode
        '
        Me.BtnShowAccessCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowAccessCode.ForeColor = System.Drawing.Color.Blue
        Me.BtnShowAccessCode.Location = New System.Drawing.Point(248, 333)
        Me.BtnShowAccessCode.Name = "BtnShowAccessCode"
        Me.BtnShowAccessCode.Size = New System.Drawing.Size(125, 60)
        Me.BtnShowAccessCode.TabIndex = 54
        Me.BtnShowAccessCode.TabStop = False
        Me.BtnShowAccessCode.Text = "Show"
        Me.BtnShowAccessCode.UseVisualStyleBackColor = True
        '
        'BtnEnter
        '
        Me.BtnEnter.Font = New System.Drawing.Font("Wingdings 3", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnEnter.ForeColor = System.Drawing.Color.Green
        Me.BtnEnter.Location = New System.Drawing.Point(314, 201)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(60, 126)
        Me.BtnEnter.TabIndex = 53
        Me.BtnEnter.TabStop = False
        Me.BtnEnter.Text = "<"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnCharD
        '
        Me.BtnCharD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCharD.ForeColor = System.Drawing.Color.Teal
        Me.BtnCharD.Location = New System.Drawing.Point(12, 333)
        Me.BtnCharD.Name = "BtnCharD"
        Me.BtnCharD.Size = New System.Drawing.Size(98, 60)
        Me.BtnCharD.TabIndex = 52
        Me.BtnCharD.TabStop = False
        Me.BtnCharD.Text = "D"
        Me.BtnCharD.UseVisualStyleBackColor = True
        '
        'BtnCharB
        '
        Me.BtnCharB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCharB.ForeColor = System.Drawing.Color.Teal
        Me.BtnCharB.Location = New System.Drawing.Point(12, 201)
        Me.BtnCharB.Name = "BtnCharB"
        Me.BtnCharB.Size = New System.Drawing.Size(98, 60)
        Me.BtnCharB.TabIndex = 51
        Me.BtnCharB.TabStop = False
        Me.BtnCharB.Text = "B"
        Me.BtnCharB.UseVisualStyleBackColor = True
        '
        'BtnCharA
        '
        Me.BtnCharA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCharA.ForeColor = System.Drawing.Color.Teal
        Me.BtnCharA.Location = New System.Drawing.Point(12, 135)
        Me.BtnCharA.Name = "BtnCharA"
        Me.BtnCharA.Size = New System.Drawing.Size(98, 60)
        Me.BtnCharA.TabIndex = 50
        Me.BtnCharA.TabStop = False
        Me.BtnCharA.Text = "A"
        Me.BtnCharA.UseVisualStyleBackColor = True
        '
        'BtnCharC
        '
        Me.BtnCharC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCharC.ForeColor = System.Drawing.Color.Teal
        Me.BtnCharC.Location = New System.Drawing.Point(12, 267)
        Me.BtnCharC.Name = "BtnCharC"
        Me.BtnCharC.Size = New System.Drawing.Size(98, 60)
        Me.BtnCharC.TabIndex = 49
        Me.BtnCharC.TabStop = False
        Me.BtnCharC.Text = "C"
        Me.BtnCharC.UseVisualStyleBackColor = True
        '
        'BtnNum0
        '
        Me.BtnNum0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum0.Location = New System.Drawing.Point(116, 333)
        Me.BtnNum0.Name = "BtnNum0"
        Me.BtnNum0.Size = New System.Drawing.Size(126, 60)
        Me.BtnNum0.TabIndex = 48
        Me.BtnNum0.TabStop = False
        Me.BtnNum0.Text = "0"
        Me.BtnNum0.UseVisualStyleBackColor = True
        '
        'BtnNum5
        '
        Me.BtnNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum5.Location = New System.Drawing.Point(182, 201)
        Me.BtnNum5.Name = "BtnNum5"
        Me.BtnNum5.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum5.TabIndex = 47
        Me.BtnNum5.TabStop = False
        Me.BtnNum5.Text = "5"
        Me.BtnNum5.UseVisualStyleBackColor = True
        '
        'BtnNum6
        '
        Me.BtnNum6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum6.Location = New System.Drawing.Point(248, 201)
        Me.BtnNum6.Name = "BtnNum6"
        Me.BtnNum6.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum6.TabIndex = 46
        Me.BtnNum6.TabStop = False
        Me.BtnNum6.Text = "6"
        Me.BtnNum6.UseVisualStyleBackColor = True
        '
        'BtnNum4
        '
        Me.BtnNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum4.Location = New System.Drawing.Point(116, 201)
        Me.BtnNum4.Name = "BtnNum4"
        Me.BtnNum4.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum4.TabIndex = 45
        Me.BtnNum4.TabStop = False
        Me.BtnNum4.Text = "4"
        Me.BtnNum4.UseVisualStyleBackColor = True
        '
        'BtnNum8
        '
        Me.BtnNum8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum8.Location = New System.Drawing.Point(182, 135)
        Me.BtnNum8.Name = "BtnNum8"
        Me.BtnNum8.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum8.TabIndex = 44
        Me.BtnNum8.TabStop = False
        Me.BtnNum8.Text = "8"
        Me.BtnNum8.UseVisualStyleBackColor = True
        '
        'BtnNum9
        '
        Me.BtnNum9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum9.Location = New System.Drawing.Point(248, 135)
        Me.BtnNum9.Name = "BtnNum9"
        Me.BtnNum9.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum9.TabIndex = 43
        Me.BtnNum9.TabStop = False
        Me.BtnNum9.Text = "9"
        Me.BtnNum9.UseVisualStyleBackColor = True
        '
        'BtnNum7
        '
        Me.BtnNum7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum7.Location = New System.Drawing.Point(116, 135)
        Me.BtnNum7.Name = "BtnNum7"
        Me.BtnNum7.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum7.TabIndex = 42
        Me.BtnNum7.TabStop = False
        Me.BtnNum7.Text = "7"
        Me.BtnNum7.UseVisualStyleBackColor = True
        '
        'BtnNum2
        '
        Me.BtnNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum2.Location = New System.Drawing.Point(182, 267)
        Me.BtnNum2.Name = "BtnNum2"
        Me.BtnNum2.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum2.TabIndex = 41
        Me.BtnNum2.TabStop = False
        Me.BtnNum2.Text = "2"
        Me.BtnNum2.UseVisualStyleBackColor = True
        '
        'BtnNum3
        '
        Me.BtnNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum3.Location = New System.Drawing.Point(248, 267)
        Me.BtnNum3.Name = "BtnNum3"
        Me.BtnNum3.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum3.TabIndex = 40
        Me.BtnNum3.TabStop = False
        Me.BtnNum3.Text = "3"
        Me.BtnNum3.UseVisualStyleBackColor = True
        '
        'BtnNum1
        '
        Me.BtnNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNum1.Location = New System.Drawing.Point(116, 267)
        Me.BtnNum1.Name = "BtnNum1"
        Me.BtnNum1.Size = New System.Drawing.Size(60, 60)
        Me.BtnNum1.TabIndex = 39
        Me.BtnNum1.TabStop = False
        Me.BtnNum1.Text = "1"
        Me.BtnNum1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Enter Access Code"
        '
        'TimTimer
        '
        Me.TimTimer.Interval = 1000
        '
        'TimLoadMenu
        '
        Me.TimLoadMenu.Interval = 1000
        '
        'FrmKeypad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 470)
        Me.Controls.Add(Me.ChkAlwaysOnTop)
        Me.Controls.Add(Me.LblCode6)
        Me.Controls.Add(Me.LblCode7)
        Me.Controls.Add(Me.LblCode8)
        Me.Controls.Add(Me.LblCode5)
        Me.Controls.Add(Me.LblCode2)
        Me.Controls.Add(Me.LblCode3)
        Me.Controls.Add(Me.LblCode4)
        Me.Controls.Add(Me.LblCode1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblSystemMessage)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnShowAccessCode)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.BtnCharD)
        Me.Controls.Add(Me.BtnCharB)
        Me.Controls.Add(Me.BtnCharA)
        Me.Controls.Add(Me.BtnCharC)
        Me.Controls.Add(Me.BtnNum0)
        Me.Controls.Add(Me.BtnNum5)
        Me.Controls.Add(Me.BtnNum6)
        Me.Controls.Add(Me.BtnNum4)
        Me.Controls.Add(Me.BtnNum8)
        Me.Controls.Add(Me.BtnNum9)
        Me.Controls.Add(Me.BtnNum7)
        Me.Controls.Add(Me.BtnNum2)
        Me.Controls.Add(Me.BtnNum3)
        Me.Controls.Add(Me.BtnNum1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmKeypad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkAlwaysOnTop As CheckBox
    Friend WithEvents LblCode6 As Label
    Friend WithEvents LblCode7 As Label
    Friend WithEvents LblCode8 As Label
    Friend WithEvents LblCode5 As Label
    Friend WithEvents LblCode2 As Label
    Friend WithEvents LblCode3 As Label
    Friend WithEvents LblCode4 As Label
    Friend WithEvents LblCode1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnShowAccessCode As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnCharD As Button
    Friend WithEvents BtnCharB As Button
    Friend WithEvents BtnCharA As Button
    Friend WithEvents BtnCharC As Button
    Friend WithEvents BtnNum0 As Button
    Friend WithEvents BtnNum5 As Button
    Friend WithEvents BtnNum6 As Button
    Friend WithEvents BtnNum4 As Button
    Friend WithEvents BtnNum8 As Button
    Friend WithEvents BtnNum9 As Button
    Friend WithEvents BtnNum7 As Button
    Friend WithEvents BtnNum2 As Button
    Friend WithEvents BtnNum3 As Button
    Friend WithEvents BtnNum1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TimTimer As Timer
    Friend WithEvents TimLoadMenu As Timer
End Class
