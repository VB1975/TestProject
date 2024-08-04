Imports System.Globalization

Public Class FrmDatesAndTimes
    Private Sub CalDateOfBirth_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalDateOfBirth.DateChanged

        Dim DOB As Date = CalDateOfBirth.SelectionStart
        Dim culture As New CultureInfo("en-GB")
        Dim age As Integer

        If CalDateOfBirth.SelectionStart > Today() Then
            CalDateOfBirth.SelectionStart = Today()
            Exit Sub
        End If

        TxtDateOfBirth.Text = Format(DOB, "dddd, d MMMM yyyy")

        If DateTime.TryParseExact(DOB, "yyyy-MM-dd", culture, DateTimeStyles.None, DOB) Then
            age = CalculateAge(DOB)
            TxtAge.Text = age
        End If

    End Sub

    Private Sub BtnSetAppointment_Click(sender As Object, e As EventArgs) Handles BtnSetAppointment.Click

        Dim apptDate As Date = DtpAppointmentDate.Value
        Dim apptTime As Date = DtpAppointmentTime.Value
        Dim DateStr As String, TimeStr As String, msg As String

        LblAppointmentMessage.Visible = False

        DateStr = Format(apptDate, "dddd, d MMMM yyyy")
        TimeStr = Format(apptTime, "h:mm tt")

        If TxtAppointment.Text.Length = 0 Then
            msg = "A name for this appointment is required"
            TxtAppointment.Focus()
        Else
            msg = "Your appontment named '" & TxtAppointment.Text & "' is on " & DateStr & " at " & TimeStr & "." &
                Environment.NewLine & Environment.NewLine & "Don't be late".ToUpper
        End If

        If msg.Length > 0 Then
            LblAppointmentMessage.Text = msg
            LblAppointmentMessage.Visible = True
        End If

    End Sub

    Private Sub SetCurrentDate() Handles MyBase.Load, BtnSetCurrentDate.Click

        TxtDate.Text = Today().ToLongDateString

    End Sub

    Private Sub SetCurrentTime() Handles MyBase.Load, BtnSetCurrentTime.Click

        TxtTime.Text = TimeOfDay().ToLongTimeString

    End Sub

    Private Sub BtnMinus1Day_Click(sender As Object, e As EventArgs) Handles BtnMinus1Day.Click

        TxtDate.Text = CDate(TxtDate.Text).AddDays(-1).ToLongDateString

    End Sub

    Private Sub BtnPlus1Day_Click(sender As Object, e As EventArgs) Handles BtnPlus1Day.Click

        TxtDate.Text = CDate(TxtDate.Text).AddDays(1).ToLongDateString

    End Sub

    Private Sub BtnMinus1Month_Click(sender As Object, e As EventArgs) Handles BtnMinus1Month.Click

        TxtDate.Text = CDate(TxtDate.Text).AddMonths(-1).ToLongDateString

    End Sub

    Private Sub BtnPlus1Month_Click(sender As Object, e As EventArgs) Handles BtnPlus1Month.Click

        TxtDate.Text = CDate(TxtDate.Text).AddMonths(1).ToLongDateString

    End Sub

    Private Sub BtnMinus1Year_Click(sender As Object, e As EventArgs) Handles BtnMinus1Year.Click

        TxtDate.Text = CDate(TxtDate.Text).AddYears(-1).ToLongDateString

    End Sub

    Private Sub BtnPlus1Year_Click(sender As Object, e As EventArgs) Handles BtnPlus1Year.Click

        TxtDate.Text = CDate(TxtDate.Text).AddYears(1).ToLongDateString

    End Sub

    Private Sub BtnMinus1Hour_Click(sender As Object, e As EventArgs) Handles BtnMinus1Hour.Click

        TxtTime.Text = CDate(TxtTime.Text).AddHours(-1).ToLongTimeString

    End Sub

    Private Sub BtnPlus1Hour_Click(sender As Object, e As EventArgs) Handles BtnPlus1Hour.Click

        TxtTime.Text = CDate(TxtTime.Text).AddHours(1).ToLongTimeString

    End Sub

    Private Sub BtnMinus1Minute_Click(sender As Object, e As EventArgs) Handles BtnMinus1Minute.Click

        TxtTime.Text = CDate(TxtTime.Text).AddMinutes(-1).ToLongTimeString

    End Sub

    Private Sub BtnPlus1Minute_Click(sender As Object, e As EventArgs) Handles BtnPlus1Minute.Click

        TxtTime.Text = CDate(TxtTime.Text).AddMinutes(1).ToLongTimeString

    End Sub

    Private Sub BtnMinus1Second_Click(sender As Object, e As EventArgs) Handles BtnMinus1Second.Click

        TxtTime.Text = CDate(TxtTime.Text).AddSeconds(-1).ToLongTimeString

    End Sub

    Private Sub BtnPlus1Second_Click(sender As Object, e As EventArgs) Handles BtnPlus1Second.Click

        TxtTime.Text = CDate(TxtTime.Text).AddSeconds(1).ToLongTimeString

    End Sub

    Private Sub CalHolidays_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalHolidays.DateChanged

        Dim Duration As Integer, S As String

        TxtStartDate.Text = CalHolidays.SelectionStart.ToShortDateString
        TxtEndDate.Text = CalHolidays.SelectionEnd.ToShortDateString
        TxtDateRange.Text = CalHolidays.SelectionRange.Start.ToLongDateString & " - " & CalHolidays.SelectionRange.End.ToLongDateString

        Duration = DateDiff(DateInterval.Day, CDate(TxtStartDate.Text), CDate(TxtEndDate.Text)) + 1
        S = IIf(Duration = 1, "Day", "Days")
        TxtDuration.Text = Duration & " " & S

    End Sub
End Class