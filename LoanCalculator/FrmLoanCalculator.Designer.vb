<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoanCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoanCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLoanAmount = New System.Windows.Forms.TextBox()
        Me.TxtDownPayment = New System.Windows.Forms.TextBox()
        Me.LblDownPayment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboTypeOfLoan = New System.Windows.Forms.ComboBox()
        Me.TxtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTerms = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTerms = New System.Windows.Forms.TextBox()
        Me.LblTerms = New System.Windows.Forms.Label()
        Me.BtnCalculatePayment = New System.Windows.Forms.Button()
        Me.TxtPayments = New System.Windows.Forms.TextBox()
        Me.LblPayments = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTotalInterest = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTotalPayable = New System.Windows.Forms.TextBox()
        Me.CboPaymentFrequancy = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnExitApplication = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 110)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kev's Loan Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(763, 110)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount of Loan"
        '
        'TxtLoanAmount
        '
        Me.TxtLoanAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoanAmount.Location = New System.Drawing.Point(20, 256)
        Me.TxtLoanAmount.Name = "TxtLoanAmount"
        Me.TxtLoanAmount.Size = New System.Drawing.Size(231, 29)
        Me.TxtLoanAmount.TabIndex = 0
        '
        'TxtDownPayment
        '
        Me.TxtDownPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDownPayment.Location = New System.Drawing.Point(257, 256)
        Me.TxtDownPayment.Name = "TxtDownPayment"
        Me.TxtDownPayment.Size = New System.Drawing.Size(231, 29)
        Me.TxtDownPayment.TabIndex = 1
        Me.TxtDownPayment.Text = "0"
        '
        'LblDownPayment
        '
        Me.LblDownPayment.AutoSize = True
        Me.LblDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDownPayment.Location = New System.Drawing.Point(253, 229)
        Me.LblDownPayment.Name = "LblDownPayment"
        Me.LblDownPayment.Size = New System.Drawing.Size(149, 24)
        Me.LblDownPayment.TabIndex = 4
        Me.LblDownPayment.Text = "Down Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Type of Loan"
        '
        'CboTypeOfLoan
        '
        Me.CboTypeOfLoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTypeOfLoan.FormattingEnabled = True
        Me.CboTypeOfLoan.Items.AddRange(New Object() {"Standard Loan", "Mortgage", "Hire Purchase"})
        Me.CboTypeOfLoan.Location = New System.Drawing.Point(20, 183)
        Me.CboTypeOfLoan.Name = "CboTypeOfLoan"
        Me.CboTypeOfLoan.Size = New System.Drawing.Size(231, 32)
        Me.CboTypeOfLoan.TabIndex = 4
        '
        'TxtInterestRate
        '
        Me.TxtInterestRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInterestRate.Location = New System.Drawing.Point(494, 256)
        Me.TxtInterestRate.Name = "TxtInterestRate"
        Me.TxtInterestRate.Size = New System.Drawing.Size(122, 29)
        Me.TxtInterestRate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Interest Rate"
        '
        'CboTerms
        '
        Me.CboTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTerms.FormattingEnabled = True
        Me.CboTerms.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "25", "30"})
        Me.CboTerms.Location = New System.Drawing.Point(622, 183)
        Me.CboTerms.Name = "CboTerms"
        Me.CboTerms.Size = New System.Drawing.Size(153, 32)
        Me.CboTerms.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(618, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Terms (Years)"
        '
        'TxtTerms
        '
        Me.TxtTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTerms.Location = New System.Drawing.Point(622, 256)
        Me.TxtTerms.Name = "TxtTerms"
        Me.TxtTerms.ReadOnly = True
        Me.TxtTerms.Size = New System.Drawing.Size(153, 29)
        Me.TxtTerms.TabIndex = 13
        '
        'LblTerms
        '
        Me.LblTerms.AutoSize = True
        Me.LblTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTerms.Location = New System.Drawing.Point(618, 229)
        Me.LblTerms.Name = "LblTerms"
        Me.LblTerms.Size = New System.Drawing.Size(157, 24)
        Me.LblTerms.TabIndex = 12
        Me.LblTerms.Text = "Terms (Months)"
        '
        'BtnCalculatePayment
        '
        Me.BtnCalculatePayment.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCalculatePayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalculatePayment.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCalculatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalculatePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculatePayment.Location = New System.Drawing.Point(242, 322)
        Me.BtnCalculatePayment.Name = "BtnCalculatePayment"
        Me.BtnCalculatePayment.Size = New System.Drawing.Size(316, 65)
        Me.BtnCalculatePayment.TabIndex = 6
        Me.BtnCalculatePayment.Text = "Calculate Monthly Payment"
        Me.BtnCalculatePayment.UseVisualStyleBackColor = False
        '
        'TxtPayments
        '
        Me.TxtPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPayments.Location = New System.Drawing.Point(20, 451)
        Me.TxtPayments.Name = "TxtPayments"
        Me.TxtPayments.ReadOnly = True
        Me.TxtPayments.Size = New System.Drawing.Size(231, 29)
        Me.TxtPayments.TabIndex = 16
        '
        'LblPayments
        '
        Me.LblPayments.AutoSize = True
        Me.LblPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayments.Location = New System.Drawing.Point(16, 424)
        Me.LblPayments.Name = "LblPayments"
        Me.LblPayments.Size = New System.Drawing.Size(169, 24)
        Me.LblPayments.TabIndex = 15
        Me.LblPayments.Text = "Monthly Payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(540, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total Interest"
        '
        'TxtTotalInterest
        '
        Me.TxtTotalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalInterest.Location = New System.Drawing.Point(544, 451)
        Me.TxtTotalInterest.Name = "TxtTotalInterest"
        Me.TxtTotalInterest.ReadOnly = True
        Me.TxtTotalInterest.Size = New System.Drawing.Size(231, 29)
        Me.TxtTotalInterest.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(278, 424)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 24)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total Payable"
        '
        'TxtTotalPayable
        '
        Me.TxtTotalPayable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPayable.Location = New System.Drawing.Point(282, 451)
        Me.TxtTotalPayable.Name = "TxtTotalPayable"
        Me.TxtTotalPayable.ReadOnly = True
        Me.TxtTotalPayable.Size = New System.Drawing.Size(231, 29)
        Me.TxtTotalPayable.TabIndex = 22
        '
        'CboPaymentFrequancy
        '
        Me.CboPaymentFrequancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPaymentFrequancy.FormattingEnabled = True
        Me.CboPaymentFrequancy.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Quarterly", "Annually"})
        Me.CboPaymentFrequancy.Location = New System.Drawing.Point(257, 183)
        Me.CboPaymentFrequancy.Name = "CboPaymentFrequancy"
        Me.CboPaymentFrequancy.Size = New System.Drawing.Size(231, 32)
        Me.CboPaymentFrequancy.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Payment Frequancy"
        '
        'BtnExitApplication
        '
        Me.BtnExitApplication.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExitApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExitApplication.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExitApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExitApplication.ForeColor = System.Drawing.Color.Maroon
        Me.BtnExitApplication.Location = New System.Drawing.Point(242, 514)
        Me.BtnExitApplication.Name = "BtnExitApplication"
        Me.BtnExitApplication.Size = New System.Drawing.Size(316, 65)
        Me.BtnExitApplication.TabIndex = 7
        Me.BtnExitApplication.Text = "Exit Application"
        Me.BtnExitApplication.UseVisualStyleBackColor = False
        '
        'FrmLoanCalculator
        '
        Me.AcceptButton = Me.BtnCalculatePayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.BtnExitApplication
        Me.ClientSize = New System.Drawing.Size(796, 594)
        Me.Controls.Add(Me.BtnExitApplication)
        Me.Controls.Add(Me.CboPaymentFrequancy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTotalPayable)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTotalInterest)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPayments)
        Me.Controls.Add(Me.LblPayments)
        Me.Controls.Add(Me.BtnCalculatePayment)
        Me.Controls.Add(Me.TxtTerms)
        Me.Controls.Add(Me.LblTerms)
        Me.Controls.Add(Me.CboTerms)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtInterestRate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboTypeOfLoan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDownPayment)
        Me.Controls.Add(Me.LblDownPayment)
        Me.Controls.Add(Me.TxtLoanAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoanCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtLoanAmount As TextBox
    Friend WithEvents TxtDownPayment As TextBox
    Friend WithEvents LblDownPayment As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboTypeOfLoan As ComboBox
    Friend WithEvents TxtInterestRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CboTerms As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTerms As TextBox
    Friend WithEvents LblTerms As Label
    Friend WithEvents BtnCalculatePayment As Button
    Friend WithEvents TxtPayments As TextBox
    Friend WithEvents LblPayments As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTotalInterest As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTotalPayable As TextBox
    Friend WithEvents CboPaymentFrequancy As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnExitApplication As Button
End Class
