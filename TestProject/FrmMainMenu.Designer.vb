<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Me.PicMainImage = New System.Windows.Forms.PictureBox()
        Me.BtnDatesAndTimes = New System.Windows.Forms.Button()
        Me.BtnStrings = New System.Windows.Forms.Button()
        Me.BtnLooping = New System.Windows.Forms.Button()
        CType(Me.PicMainImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicMainImage
        '
        Me.PicMainImage.Location = New System.Drawing.Point(12, 12)
        Me.PicMainImage.Name = "PicMainImage"
        Me.PicMainImage.Size = New System.Drawing.Size(279, 226)
        Me.PicMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMainImage.TabIndex = 0
        Me.PicMainImage.TabStop = False
        '
        'BtnDatesAndTimes
        '
        Me.BtnDatesAndTimes.Location = New System.Drawing.Point(315, 76)
        Me.BtnDatesAndTimes.Name = "BtnDatesAndTimes"
        Me.BtnDatesAndTimes.Size = New System.Drawing.Size(447, 58)
        Me.BtnDatesAndTimes.TabIndex = 1
        Me.BtnDatesAndTimes.Text = "Working with Dates && Times"
        Me.BtnDatesAndTimes.UseVisualStyleBackColor = True
        '
        'BtnStrings
        '
        Me.BtnStrings.Location = New System.Drawing.Point(315, 12)
        Me.BtnStrings.Name = "BtnStrings"
        Me.BtnStrings.Size = New System.Drawing.Size(447, 58)
        Me.BtnStrings.TabIndex = 2
        Me.BtnStrings.Text = "Working with Strings"
        Me.BtnStrings.UseVisualStyleBackColor = True
        '
        'BtnLooping
        '
        Me.BtnLooping.Location = New System.Drawing.Point(315, 140)
        Me.BtnLooping.Name = "BtnLooping"
        Me.BtnLooping.Size = New System.Drawing.Size(447, 58)
        Me.BtnLooping.TabIndex = 3
        Me.BtnLooping.Text = "Working with Loops"
        Me.BtnLooping.UseVisualStyleBackColor = True
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 475)
        Me.Controls.Add(Me.BtnLooping)
        Me.Controls.Add(Me.BtnStrings)
        Me.Controls.Add(Me.BtnDatesAndTimes)
        Me.Controls.Add(Me.PicMainImage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PicMainImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicMainImage As PictureBox
    Friend WithEvents BtnDatesAndTimes As Button
    Friend WithEvents BtnStrings As Button
    Friend WithEvents BtnLooping As Button
End Class
