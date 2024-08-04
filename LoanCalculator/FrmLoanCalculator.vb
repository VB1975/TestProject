Public Class FrmLoanCalculator

    Private FrequancyMultiplier As Integer
    Private IsValidated As Boolean = False
    Private Msg As String = ""

    Private Sub FrmLoanCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CboTypeOfLoan.SelectedItem = "Mortgage"
        CboPaymentFrequancy.SelectedItem = "Monthly"
        CboTerms.SelectedItem = "30"
        AddFormatting()

    End Sub

    Private Sub CboTypeOfLoan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTypeOfLoan.SelectedIndexChanged

        If CboTypeOfLoan.SelectedItem = "Mortgage" Then
            TxtDownPayment.Enabled = True
            LblDownPayment.ForeColor = Color.FromArgb(0, 0, 0)
        Else
            TxtDownPayment.Enabled = False
            LblDownPayment.ForeColor = Color.FromArgb(175, 175, 175)
        End If

    End Sub

    Private Sub CboTerms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTerms.SelectedIndexChanged

        TxtTerms.Text = Val(CboTerms.SelectedItem) * FrequancyMultiplier

    End Sub

    Private Sub AddFormatting()

        RemoveFormatting()

        TxtLoanAmount.Text = FormatCurrency(Val(TxtLoanAmount.Text), 2)
        TxtDownPayment.Text = FormatCurrency(TxtDownPayment.Text, 2)
        If Val(TxtInterestRate.Text) >= 1 Then TxtInterestRate.Text = Val(TxtInterestRate.Text) / 100
        TxtInterestRate.Text = FormatPercent(Val(TxtInterestRate.Text))

    End Sub

    Private Sub RemoveFormatting()

        Try
            TxtLoanAmount.Text = FormatNumber(TxtLoanAmount.Text, 2)
            TxtDownPayment.Text = FormatNumber(TxtDownPayment.Text, 2)
        Catch ex As Exception

        End Try

        TxtLoanAmount.Text = Replace(TxtLoanAmount.Text, ",", "")
        TxtDownPayment.Text = Replace(TxtDownPayment.Text, ",", "")

        If Strings.Right(TxtInterestRate.Text, 1) = "%" Then
            TxtInterestRate.Text = Strings.Left(TxtInterestRate.Text, TxtInterestRate.Text.Length - 1)
        End If

    End Sub

    Private Sub ValidateData()

        If Not IsNumeric(TxtLoanAmount.Text) Or Val(TxtLoanAmount.Text) < 1000 Then
            Msg = "The loan amount must be a numeric value greater than " & FormatCurrency(1000) & "."
            TxtLoanAmount.Focus()
            TxtLoanAmount.SelectionStart = 0
            TxtLoanAmount.SelectionLength = TxtLoanAmount.Text.Length
            AddFormatting()
            Exit Sub
        End If

        If Not IsNumeric(TxtDownPayment.Text) Or Val(TxtDownPayment.Text) >= Val(TxtLoanAmount.Text) Then
            Msg = "The down payment amount must be a numeric value less than " & FormatCurrency(Val(TxtLoanAmount.Text)) & "."
            TxtDownPayment.Focus()
            TxtDownPayment.SelectionStart = 0
            TxtDownPayment.SelectionLength = TxtDownPayment.Text.Length
            AddFormatting()
            Exit Sub
        End If

        If Not IsNumeric(TxtInterestRate.Text) Then
            Msg = "The interest rate must be a numeric value."
            TxtInterestRate.Focus()
            TxtInterestRate.SelectionStart = 0
            TxtInterestRate.SelectionLength = TxtInterestRate.Text.Length
            AddFormatting()
            Exit Sub
        End If

        IsValidated = True

    End Sub

    Private Sub BtnCalculatePayment_Click(sender As Object, e As EventArgs) Handles BtnCalculatePayment.Click

        RemoveFormatting()
        ValidateData()

        If Not IsValidated Then
            MessageBox.Show(Msg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim LoanAmt As Double = Val(TxtLoanAmount.Text) - Val(TxtDownPayment.Text)
        Dim InterestRate As Double = Val(TxtInterestRate.Text) / 100
        Dim Terms As Double = Val(TxtTerms.Text)
        Dim MonthlyPayment As Double = Pmt(InterestRate / Terms, Terms, LoanAmt) * -1
        Dim TotalPayable As Double = MonthlyPayment * Terms
        Dim TotalInterest As Double = TotalPayable - LoanAmt

        TxtPayments.Text = FormatCurrency(MonthlyPayment, 2)
        TxtTotalPayable.Text = FormatCurrency(TotalPayable, 2)
        TxtTotalInterest.Text = FormatCurrency(TotalInterest, 2)

        AddFormatting()

    End Sub

    Private Sub TxtInterestRate_Leave(sender As Object, e As EventArgs) Handles TxtInterestRate.Leave

        AddFormatting()

    End Sub

    Private Sub CboPaymentFrequancy_SelectedIndexChanged(sender As Object, e As EventArgs) _
                    Handles CboPaymentFrequancy.SelectedIndexChanged, MyBase.Load

        Dim Frequancy As String = ""

        Select Case CboPaymentFrequancy.SelectedItem
            Case "Daily"
                FrequancyMultiplier = 365
                Frequancy = "Days"
            Case "Weekly"
                FrequancyMultiplier = 52
                Frequancy = "Weeks"
            Case "Monthly"
                FrequancyMultiplier = 12
                Frequancy = "Months"
            Case "Quarterly"
                FrequancyMultiplier = 4
                Frequancy = "Quarters"
            Case "Annually"
                FrequancyMultiplier = 1
                Frequancy = "Years"
        End Select

        LblTerms.Text = "Terms (" & Frequancy & ")"
        TxtTerms.Text = Val(CboTerms.SelectedItem) * FrequancyMultiplier
        BtnCalculatePayment.Text = "Calculate " & IIf(Frequancy = "Years", "Annual", CboPaymentFrequancy.SelectedItem) & " Payment"
        LblPayments.Text = IIf(Frequancy = "Years", "Annual", CboPaymentFrequancy.SelectedItem) & " Payment"

    End Sub

    Private Sub BtnExitApplication_Click(sender As Object, e As EventArgs) Handles BtnExitApplication.Click

        If MessageBox.Show("Are you sure you want to exit?", "Really Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) =
                DialogResult.Yes Then Application.Exit()

    End Sub

    Private Sub TxtLoanAmount_Leave(sender As Object, e As EventArgs) Handles TxtLoanAmount.Leave

        AddFormatting()

    End Sub

    Private Sub TxtDownPayment_Leave(sender As Object, e As EventArgs) Handles TxtDownPayment.Leave

        AddFormatting()

    End Sub
End Class
