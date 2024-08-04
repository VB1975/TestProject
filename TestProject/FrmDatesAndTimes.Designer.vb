<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatesAndTimes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalDateOfBirth = New System.Windows.Forms.MonthCalendar()
        Me.TxtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblAppointmentMessage = New System.Windows.Forms.Label()
        Me.BtnSetAppointment = New System.Windows.Forms.Button()
        Me.DtpAppointmentTime = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAppointment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSetCurrentTime = New System.Windows.Forms.Button()
        Me.BtnSetCurrentDate = New System.Windows.Forms.Button()
        Me.BtnPlus1Second = New System.Windows.Forms.Button()
        Me.BtnMinus1Second = New System.Windows.Forms.Button()
        Me.BtnPlus1Minute = New System.Windows.Forms.Button()
        Me.BtnMinus1Minute = New System.Windows.Forms.Button()
        Me.BtnPlus1Hour = New System.Windows.Forms.Button()
        Me.BtnMinus1Hour = New System.Windows.Forms.Button()
        Me.TxtTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnPlus1Year = New System.Windows.Forms.Button()
        Me.BtnMinus1Year = New System.Windows.Forms.Button()
        Me.BtnPlus1Month = New System.Windows.Forms.Button()
        Me.BtnMinus1Month = New System.Windows.Forms.Button()
        Me.BtnPlus1Day = New System.Windows.Forms.Button()
        Me.BtnMinus1Day = New System.Windows.Forms.Button()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CalHolidays = New System.Windows.Forms.MonthCalendar()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDateRange = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date of Birth"
        '
        'CalDateOfBirth
        '
        Me.CalDateOfBirth.Location = New System.Drawing.Point(22, 57)
        Me.CalDateOfBirth.MaxSelectionCount = 1
        Me.CalDateOfBirth.Name = "CalDateOfBirth"
        Me.CalDateOfBirth.TabIndex = 1
        '
        'TxtDateOfBirth
        '
        Me.TxtDateOfBirth.Location = New System.Drawing.Point(147, 21)
        Me.TxtDateOfBirth.Name = "TxtDateOfBirth"
        Me.TxtDateOfBirth.ReadOnly = True
        Me.TxtDateOfBirth.Size = New System.Drawing.Size(342, 29)
        Me.TxtDateOfBirth.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(315, 54)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(174, 29)
        Me.TxtAge.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblAppointmentMessage)
        Me.Panel1.Controls.Add(Me.BtnSetAppointment)
        Me.Panel1.Controls.Add(Me.DtpAppointmentTime)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DtpAppointmentDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtAppointment)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(524, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 272)
        Me.Panel1.TabIndex = 5
        '
        'LblAppointmentMessage
        '
        Me.LblAppointmentMessage.ForeColor = System.Drawing.Color.Teal
        Me.LblAppointmentMessage.Location = New System.Drawing.Point(13, 144)
        Me.LblAppointmentMessage.Name = "LblAppointmentMessage"
        Me.LblAppointmentMessage.Size = New System.Drawing.Size(524, 112)
        Me.LblAppointmentMessage.TabIndex = 11
        Me.LblAppointmentMessage.Text = "Appointment Message"
        Me.LblAppointmentMessage.Visible = False
        '
        'BtnSetAppointment
        '
        Me.BtnSetAppointment.Location = New System.Drawing.Point(147, 91)
        Me.BtnSetAppointment.Name = "BtnSetAppointment"
        Me.BtnSetAppointment.Size = New System.Drawing.Size(200, 35)
        Me.BtnSetAppointment.TabIndex = 10
        Me.BtnSetAppointment.Text = "Set Appointment"
        Me.BtnSetAppointment.UseVisualStyleBackColor = True
        '
        'DtpAppointmentTime
        '
        Me.DtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpAppointmentTime.Location = New System.Drawing.Point(463, 47)
        Me.DtpAppointmentTime.Name = "DtpAppointmentTime"
        Me.DtpAppointmentTime.ShowUpDown = True
        Me.DtpAppointmentTime.Size = New System.Drawing.Size(109, 29)
        Me.DtpAppointmentTime.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time"
        '
        'DtpAppointmentDate
        '
        Me.DtpAppointmentDate.Location = New System.Drawing.Point(147, 47)
        Me.DtpAppointmentDate.Name = "DtpAppointmentDate"
        Me.DtpAppointmentDate.Size = New System.Drawing.Size(234, 29)
        Me.DtpAppointmentDate.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date"
        '
        'TxtAppointment
        '
        Me.TxtAppointment.Location = New System.Drawing.Point(147, 12)
        Me.TxtAppointment.Name = "TxtAppointment"
        Me.TxtAppointment.Size = New System.Drawing.Size(425, 29)
        Me.TxtAppointment.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Appointment"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnSetCurrentTime)
        Me.Panel2.Controls.Add(Me.BtnSetCurrentDate)
        Me.Panel2.Controls.Add(Me.BtnPlus1Second)
        Me.Panel2.Controls.Add(Me.BtnMinus1Second)
        Me.Panel2.Controls.Add(Me.BtnPlus1Minute)
        Me.Panel2.Controls.Add(Me.BtnMinus1Minute)
        Me.Panel2.Controls.Add(Me.BtnPlus1Hour)
        Me.Panel2.Controls.Add(Me.BtnMinus1Hour)
        Me.Panel2.Controls.Add(Me.TxtTime)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.BtnPlus1Year)
        Me.Panel2.Controls.Add(Me.BtnMinus1Year)
        Me.Panel2.Controls.Add(Me.BtnPlus1Month)
        Me.Panel2.Controls.Add(Me.BtnMinus1Month)
        Me.Panel2.Controls.Add(Me.BtnPlus1Day)
        Me.Panel2.Controls.Add(Me.BtnMinus1Day)
        Me.Panel2.Controls.Add(Me.TxtDate)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(524, 290)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 189)
        Me.Panel2.TabIndex = 12
        '
        'BtnSetCurrentTime
        '
        Me.BtnSetCurrentTime.ForeColor = System.Drawing.Color.Purple
        Me.BtnSetCurrentTime.Location = New System.Drawing.Point(483, 99)
        Me.BtnSetCurrentTime.Name = "BtnSetCurrentTime"
        Me.BtnSetCurrentTime.Size = New System.Drawing.Size(89, 72)
        Me.BtnSetCurrentTime.TabIndex = 25
        Me.BtnSetCurrentTime.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time"
        Me.BtnSetCurrentTime.UseVisualStyleBackColor = True
        '
        'BtnSetCurrentDate
        '
        Me.BtnSetCurrentDate.ForeColor = System.Drawing.Color.Blue
        Me.BtnSetCurrentDate.Location = New System.Drawing.Point(483, 12)
        Me.BtnSetCurrentDate.Name = "BtnSetCurrentDate"
        Me.BtnSetCurrentDate.Size = New System.Drawing.Size(89, 72)
        Me.BtnSetCurrentDate.TabIndex = 24
        Me.BtnSetCurrentDate.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        Me.BtnSetCurrentDate.UseVisualStyleBackColor = True
        '
        'BtnPlus1Second
        '
        Me.BtnPlus1Second.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Second.Location = New System.Drawing.Point(415, 134)
        Me.BtnPlus1Second.Name = "BtnPlus1Second"
        Me.BtnPlus1Second.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Second.TabIndex = 23
        Me.BtnPlus1Second.Text = "+1s"
        Me.BtnPlus1Second.UseVisualStyleBackColor = True
        '
        'BtnMinus1Second
        '
        Me.BtnMinus1Second.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Second.Location = New System.Drawing.Point(347, 134)
        Me.BtnMinus1Second.Name = "BtnMinus1Second"
        Me.BtnMinus1Second.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Second.TabIndex = 22
        Me.BtnMinus1Second.Text = "-1s"
        Me.BtnMinus1Second.UseVisualStyleBackColor = True
        '
        'BtnPlus1Minute
        '
        Me.BtnPlus1Minute.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Minute.Location = New System.Drawing.Point(279, 134)
        Me.BtnPlus1Minute.Name = "BtnPlus1Minute"
        Me.BtnPlus1Minute.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Minute.TabIndex = 21
        Me.BtnPlus1Minute.Text = "+1m"
        Me.BtnPlus1Minute.UseVisualStyleBackColor = True
        '
        'BtnMinus1Minute
        '
        Me.BtnMinus1Minute.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Minute.Location = New System.Drawing.Point(211, 134)
        Me.BtnMinus1Minute.Name = "BtnMinus1Minute"
        Me.BtnMinus1Minute.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Minute.TabIndex = 20
        Me.BtnMinus1Minute.Text = "-1m"
        Me.BtnMinus1Minute.UseVisualStyleBackColor = True
        '
        'BtnPlus1Hour
        '
        Me.BtnPlus1Hour.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Hour.Location = New System.Drawing.Point(143, 134)
        Me.BtnPlus1Hour.Name = "BtnPlus1Hour"
        Me.BtnPlus1Hour.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Hour.TabIndex = 19
        Me.BtnPlus1Hour.Text = "+1h"
        Me.BtnPlus1Hour.UseVisualStyleBackColor = True
        '
        'BtnMinus1Hour
        '
        Me.BtnMinus1Hour.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Hour.Location = New System.Drawing.Point(75, 134)
        Me.BtnMinus1Hour.Name = "BtnMinus1Hour"
        Me.BtnMinus1Hour.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Hour.TabIndex = 18
        Me.BtnMinus1Hour.Text = "-1h"
        Me.BtnMinus1Hour.UseVisualStyleBackColor = True
        '
        'TxtTime
        '
        Me.TxtTime.Location = New System.Drawing.Point(75, 99)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.ReadOnly = True
        Me.TxtTime.Size = New System.Drawing.Size(402, 29)
        Me.TxtTime.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Time"
        '
        'BtnPlus1Year
        '
        Me.BtnPlus1Year.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Year.Location = New System.Drawing.Point(416, 47)
        Me.BtnPlus1Year.Name = "BtnPlus1Year"
        Me.BtnPlus1Year.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Year.TabIndex = 15
        Me.BtnPlus1Year.Text = "+1y"
        Me.BtnPlus1Year.UseVisualStyleBackColor = True
        '
        'BtnMinus1Year
        '
        Me.BtnMinus1Year.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Year.Location = New System.Drawing.Point(348, 47)
        Me.BtnMinus1Year.Name = "BtnMinus1Year"
        Me.BtnMinus1Year.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Year.TabIndex = 14
        Me.BtnMinus1Year.Text = "-1y"
        Me.BtnMinus1Year.UseVisualStyleBackColor = True
        '
        'BtnPlus1Month
        '
        Me.BtnPlus1Month.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Month.Location = New System.Drawing.Point(280, 47)
        Me.BtnPlus1Month.Name = "BtnPlus1Month"
        Me.BtnPlus1Month.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Month.TabIndex = 13
        Me.BtnPlus1Month.Text = "+1m"
        Me.BtnPlus1Month.UseVisualStyleBackColor = True
        '
        'BtnMinus1Month
        '
        Me.BtnMinus1Month.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Month.Location = New System.Drawing.Point(212, 47)
        Me.BtnMinus1Month.Name = "BtnMinus1Month"
        Me.BtnMinus1Month.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Month.TabIndex = 12
        Me.BtnMinus1Month.Text = "-1m"
        Me.BtnMinus1Month.UseVisualStyleBackColor = True
        '
        'BtnPlus1Day
        '
        Me.BtnPlus1Day.ForeColor = System.Drawing.Color.Green
        Me.BtnPlus1Day.Location = New System.Drawing.Point(144, 47)
        Me.BtnPlus1Day.Name = "BtnPlus1Day"
        Me.BtnPlus1Day.Size = New System.Drawing.Size(62, 37)
        Me.BtnPlus1Day.TabIndex = 11
        Me.BtnPlus1Day.Text = "+1d"
        Me.BtnPlus1Day.UseVisualStyleBackColor = True
        '
        'BtnMinus1Day
        '
        Me.BtnMinus1Day.ForeColor = System.Drawing.Color.Red
        Me.BtnMinus1Day.Location = New System.Drawing.Point(76, 47)
        Me.BtnMinus1Day.Name = "BtnMinus1Day"
        Me.BtnMinus1Day.Size = New System.Drawing.Size(62, 37)
        Me.BtnMinus1Day.TabIndex = 10
        Me.BtnMinus1Day.Text = "-1d"
        Me.BtnMinus1Day.UseVisualStyleBackColor = True
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(76, 12)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(401, 29)
        Me.TxtDate.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtAge)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TxtDateOfBirth)
        Me.Panel3.Controls.Add(Me.CalDateOfBirth)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(506, 236)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtDuration)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.TxtDateRange)
        Me.Panel4.Controls.Add(Me.TxtEndDate)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.TxtStartDate)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.CalHolidays)
        Me.Panel4.Location = New System.Drawing.Point(12, 254)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(506, 236)
        Me.Panel4.TabIndex = 14
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(318, 6)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.ReadOnly = True
        Me.TxtStartDate.Size = New System.Drawing.Size(171, 29)
        Me.TxtStartDate.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Start"
        '
        'CalHolidays
        '
        Me.CalHolidays.Location = New System.Drawing.Point(22, 9)
        Me.CalHolidays.MaxSelectionCount = 14
        Me.CalHolidays.Name = "CalHolidays"
        Me.CalHolidays.TabIndex = 1
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(318, 41)
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.ReadOnly = True
        Me.TxtEndDate.Size = New System.Drawing.Size(171, 29)
        Me.TxtEndDate.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "End"
        '
        'TxtDateRange
        '
        Me.TxtDateRange.Location = New System.Drawing.Point(95, 183)
        Me.TxtDateRange.Name = "TxtDateRange"
        Me.TxtDateRange.ReadOnly = True
        Me.TxtDateRange.Size = New System.Drawing.Size(394, 29)
        Me.TxtDateRange.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Range"
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(265, 110)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.ReadOnly = True
        Me.TxtDuration.Size = New System.Drawing.Size(224, 29)
        Me.TxtDuration.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Duration"
        '
        'FrmDatesAndTimes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 494)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmDatesAndTimes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Dates & Times"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CalDateOfBirth As MonthCalendar
    Friend WithEvents TxtDateOfBirth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DtpAppointmentDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAppointment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSetAppointment As Button
    Friend WithEvents DtpAppointmentTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents LblAppointmentMessage As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnPlus1Day As Button
    Friend WithEvents BtnMinus1Day As Button
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnPlus1Year As Button
    Friend WithEvents BtnMinus1Year As Button
    Friend WithEvents BtnPlus1Month As Button
    Friend WithEvents BtnMinus1Month As Button
    Friend WithEvents BtnPlus1Second As Button
    Friend WithEvents BtnMinus1Second As Button
    Friend WithEvents BtnPlus1Minute As Button
    Friend WithEvents BtnMinus1Minute As Button
    Friend WithEvents BtnPlus1Hour As Button
    Friend WithEvents BtnMinus1Hour As Button
    Friend WithEvents TxtTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSetCurrentTime As Button
    Friend WithEvents BtnSetCurrentDate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtEndDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtStartDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CalHolidays As MonthCalendar
    Friend WithEvents TxtDateRange As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents Label11 As Label
End Class
