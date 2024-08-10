<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateAccessCode
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
        Me.components = New System.ComponentModel.Container()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtConfirmAccessCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAccessCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimCancel = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSystemMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSystemMessage.Location = New System.Drawing.Point(12, 92)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(382, 25)
        Me.LblSystemMessage.TabIndex = 17
        Me.LblSystemMessage.Text = "System Message"
        Me.LblSystemMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblSystemMessage.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Valid characters are numbers 0-9 and letters A-D."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(205, 276)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(111, 40)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(88, 276)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(111, 40)
        Me.BtnOK.TabIndex = 14
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtConfirmAccessCode
        '
        Me.TxtConfirmAccessCode.Location = New System.Drawing.Point(16, 231)
        Me.TxtConfirmAccessCode.MaxLength = 8
        Me.TxtConfirmAccessCode.Name = "TxtConfirmAccessCode"
        Me.TxtConfirmAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmAccessCode.Size = New System.Drawing.Size(378, 29)
        Me.TxtConfirmAccessCode.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Confirm Access Code"
        '
        'TxtAccessCode
        '
        Me.TxtAccessCode.Location = New System.Drawing.Point(16, 158)
        Me.TxtAccessCode.MaxLength = 8
        Me.TxtAccessCode.Name = "TxtAccessCode"
        Me.TxtAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtAccessCode.Size = New System.Drawing.Size(378, 29)
        Me.TxtAccessCode.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Access Code"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 48)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please enter your 8 character Access Code." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will be used to sign in to the a" &
    "pplication."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimCancel
        '
        Me.TimCancel.Interval = 1000
        '
        'FrmCreateAccessCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 325)
        Me.Controls.Add(Me.LblSystemMessage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxtConfirmAccessCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAccessCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmCreateAccessCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCreateAccessCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtConfirmAccessCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAccessCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TimCancel As Timer
End Class
