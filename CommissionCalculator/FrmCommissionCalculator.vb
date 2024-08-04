Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCommissionCalculator

    Private Filename As String = "SalesReps.txt"
    Private MaxID As Long = 1
    Private IsValidated As Boolean, Msg As String, MsgTitle As String
    Dim Counter As Long, S1 As String, S2 As String

    Private Sub ValidateNewSalesRep()

        IsValidated = True
        Msg = ""
        Counter = 0

        If TxtFirstName.Text.Length = 0 Then
            Msg &= "First Name" & Environment.NewLine
            MsgTitle = "Missing Data"
            Counter += 1
            IsValidated = False
        End If

        If TxtLastName.Text.Length = 0 Then
            Msg &= "Last Name" & Environment.NewLine
            MsgTitle = "Missing Data"
            Counter += 1
            IsValidated = False
        End If

        If TxtNewCommRate.Text.Length = 0 Then
            Msg &= "Comm Rate" & Environment.NewLine
            MsgTitle = "Missing Data"
            Counter += 1
            IsValidated = False
        End If

        If (TxtFirstName.Text.Length > 0 And TxtLastName.Text.Length > 0 And
            TxtNewCommRate.Text.Length > 0) And Not IsNumeric(TxtNewCommRate.Text) Then
            Msg = "Commission rate must be numeric!" & Environment.NewLine
            MsgTitle = "Numeric Value Only"
            IsValidated = False
        End If

    End Sub

    Private Sub ValidateCalculation()

        IsValidated = True
        Msg = ""
        Counter = 0

        If CboSalesRep.SelectedIndex = -1 Then
            Msg &= "Sales Rep" & Environment.NewLine
            MsgTitle = "Missing Data"
            Counter += 1
            IsValidated = False
        End If

        If TxtSalesAmount.Text.Length = 0 Then
            Msg &= "Sales Amount" & Environment.NewLine
            MsgTitle = "Missing Data"
            Counter += 1
            IsValidated = False
        End If

        If (CboSalesRep.SelectedIndex >= 0 And TxtSalesAmount.Text.Length > 0) And Not IsNumeric(TxtSalesAmount.Text) Then
            Msg = "Sales amount must be numeric!" & Environment.NewLine
            MsgTitle = "Numeric Value Only"
            IsValidated = False
        End If

    End Sub

    Private Sub DisplayMessage()

        S1 = IIf(Counter = 1, "field", "fields")
        S2 = IIf(Counter = 1, "is", "are")
        If MsgTitle = "Missing Data" Then
            Msg = "The following " & S1 & " " & S2 & " required:" & Environment.NewLine & Environment.NewLine & Msg
        End If
        MessageBox.Show(Msg, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub GetNextID()

        Dim objFile As New IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory & Filename)
        Dim SalesRepArray() As String, S As String
        Dim CurrentID As Long

        S = objFile.ReadLine()

        Do While S IsNot Nothing
            SalesRepArray = Split(S, ",")
            If Long.TryParse(SalesRepArray(0), CurrentID) Then
                If CurrentID > MaxID Then
                    MaxID = CurrentID
                End If
            End If
            S = objFile.ReadLine()
        Loop

        objFile.Close()
        objFile.Dispose()

        MaxID += 1

    End Sub

    Private Sub BtnAddSalesRep_Click(sender As Object, e As EventArgs) Handles BtnAddSalesRep.Click

        ValidateNewSalesRep()
        If Not IsValidated Then DisplayMessage() : Exit Sub
        If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & Filename) Then GetNextID()

        Dim objFile As New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory & Filename, True)
        Dim S As String

        S = MaxID & "," & TxtFirstName.Text & "," & TxtLastName.Text & "," & TxtNewCommRate.Text
        objFile.WriteLine(S)

        objFile.Close()
        objFile.Dispose()

        TxtFirstName.Clear()
        TxtLastName.Clear()
        TxtNewCommRate.Clear()
        TxtFirstName.Focus()

        LoadSalesReps()

    End Sub

    Private Sub LoadSalesReps()

        Try
            Dim objFile As New IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory & Filename)
            Dim SalesRepArray As String(), S As String
            Dim Items As New Dictionary(Of String, Long)

            S = objFile.ReadLine()

            Do While S IsNot Nothing
                SalesRepArray = Split(S, ",")
                Items.Add(SalesRepArray(1) & " " & SalesRepArray(2), SalesRepArray(0))
                S = objFile.ReadLine()
            Loop

            CboSalesRep.DataSource = New BindingSource(Items, Nothing)
            CboSalesRep.DisplayMember = "Key"
            CboSalesRep.ValueMember = "Value"
            CboSalesRep.SelectedIndex = -1
            TxtCommRate.Text = ""

            objFile.Close()
            objFile.Dispose()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetCommRate()

        Try
            Dim objFile As New IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory & Filename)
            Dim SalesRepArray() As String, S As String
            Dim SelectedKeyValuePair As KeyValuePair(Of String, Long) = DirectCast(CboSalesRep.SelectedItem, KeyValuePair(Of String, Long))
            Dim SelectedValue As Long = SelectedKeyValuePair.Value

            S = objFile.ReadLine()

            Do While S IsNot Nothing
                SalesRepArray = Split(S, ",")
                If SalesRepArray(0) = SelectedValue Then
                    TxtCommRate.Text = SalesRepArray(3)
                    Exit Do
                End If
                S = objFile.ReadLine()
            Loop

            objFile.Close()
            objFile.Dispose()

            FormatFields()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormatFields()

        TxtCommRate.Text = FormatPercent(TxtCommRate.Text, 2)
        TxtSalesAmount.Text = FormatCurrency(TxtSalesAmount.Text, 2)
        TxtCommission.Text = FormatCurrency(TxtCommission.Text, 2)

    End Sub

    Private Sub RemoveFormatting()

        Dim CommRate As Double = Strings.Left(TxtCommRate.Text, TxtCommRate.Text.Length - 1)
        Dim SalesAmount As Double = Strings.Right(TxtSalesAmount.Text, TxtSalesAmount.Text.Length - 1)

        TxtCommRate.Text = FormatNumber(CommRate) / 100

    End Sub

    Private Sub FrmCommissionCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSalesReps()

    End Sub

    Private Sub CboSalesRep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSalesRep.SelectedIndexChanged

        If CboSalesRep.SelectedIndex <> -1 Then GetCommRate()
        TxtSalesAmount.Text = ""
        TxtCommission.Text = ""
        TxtSalesAmount.Focus()

    End Sub

    Private Sub BtnCalculateCommission_Click(sender As Object, e As EventArgs) Handles BtnCalculateCommission.Click

        ValidateCalculation()
        If Not IsValidated Then DisplayMessage() : Exit Sub

        RemoveFormatting()
        TxtCommission.Text = Val(TxtSalesAmount.Text) * Val(TxtCommRate.Text)
        FormatFields()

    End Sub
End Class
