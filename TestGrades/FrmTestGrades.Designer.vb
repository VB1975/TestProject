<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTestGrades
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExpand = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFoundation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAdvanced = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIntermediale = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.TxtAverage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLetterGrade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCourse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTotalScore = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Test Grades"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExpand
        '
        Me.BtnExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExpand.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExpand.Location = New System.Drawing.Point(637, 443)
        Me.BtnExpand.Name = "BtnExpand"
        Me.BtnExpand.Size = New System.Drawing.Size(86, 56)
        Me.BtnExpand.TabIndex = 1
        Me.BtnExpand.Text = ">>>"
        Me.BtnExpand.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(161, 131)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(210, 29)
        Me.TxtFirstName.TabIndex = 3
        Me.TxtFirstName.Text = "Buffy"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(161, 168)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(210, 29)
        Me.TxtLastName.TabIndex = 5
        Me.TxtLastName.Text = "Summers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'TxtFoundation
        '
        Me.TxtFoundation.Location = New System.Drawing.Point(584, 131)
        Me.TxtFoundation.Name = "TxtFoundation"
        Me.TxtFoundation.Size = New System.Drawing.Size(139, 29)
        Me.TxtFoundation.TabIndex = 7
        Me.TxtFoundation.Text = "90"
        Me.TxtFoundation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(453, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Foundation"
        '
        'TxtAdvanced
        '
        Me.TxtAdvanced.Location = New System.Drawing.Point(584, 201)
        Me.TxtAdvanced.Name = "TxtAdvanced"
        Me.TxtAdvanced.Size = New System.Drawing.Size(139, 29)
        Me.TxtAdvanced.TabIndex = 9
        Me.TxtAdvanced.Text = "89"
        Me.TxtAdvanced.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Advanced"
        '
        'TxtIntermediale
        '
        Me.TxtIntermediale.Location = New System.Drawing.Point(584, 166)
        Me.TxtIntermediale.Name = "TxtIntermediale"
        Me.TxtIntermediale.Size = New System.Drawing.Size(139, 29)
        Me.TxtIntermediale.TabIndex = 11
        Me.TxtIntermediale.Text = "92"
        Me.TxtIntermediale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Intermediate"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(584, 251)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(139, 47)
        Me.BtnCalculate.TabIndex = 12
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'TxtAverage
        '
        Me.TxtAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAverage.Location = New System.Drawing.Point(584, 352)
        Me.TxtAverage.Name = "TxtAverage"
        Me.TxtAverage.ReadOnly = True
        Me.TxtAverage.Size = New System.Drawing.Size(139, 29)
        Me.TxtAverage.TabIndex = 16
        Me.TxtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(453, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Average (%)"
        '
        'TxtLetterGrade
        '
        Me.TxtLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLetterGrade.Location = New System.Drawing.Point(584, 387)
        Me.TxtLetterGrade.Name = "TxtLetterGrade"
        Me.TxtLetterGrade.ReadOnly = True
        Me.TxtLetterGrade.Size = New System.Drawing.Size(139, 29)
        Me.TxtLetterGrade.TabIndex = 14
        Me.TxtLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(453, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Letter Grade"
        '
        'CboCourse
        '
        Me.CboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCourse.FormattingEnabled = True
        Me.CboCourse.Location = New System.Drawing.Point(161, 204)
        Me.CboCourse.Name = "CboCourse"
        Me.CboCourse.Size = New System.Drawing.Size(210, 32)
        Me.CboCourse.Sorted = True
        Me.CboCourse.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Course"
        '
        'TxtTotalScore
        '
        Me.TxtTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalScore.Location = New System.Drawing.Point(584, 317)
        Me.TxtTotalScore.Name = "TxtTotalScore"
        Me.TxtTotalScore.ReadOnly = True
        Me.TxtTotalScore.Size = New System.Drawing.Size(139, 29)
        Me.TxtTotalScore.TabIndex = 20
        Me.TxtTotalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(453, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total Score"
        '
        'FrmTestGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 511)
        Me.Controls.Add(Me.TxtTotalScore)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboCourse)
        Me.Controls.Add(Me.TxtAverage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtLetterGrade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.TxtIntermediale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtAdvanced)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtFoundation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExpand)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmTestGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExpand As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFoundation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAdvanced As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIntermediale As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtAverage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLetterGrade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CboCourse As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTotalScore As TextBox
    Friend WithEvents Label10 As Label
End Class
