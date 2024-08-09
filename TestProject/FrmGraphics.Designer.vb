<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGraphics
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LblTransparantFill = New System.Windows.Forms.Label()
        Me.CboPenWidth = New System.Windows.Forms.ComboBox()
        Me.PnlFillColor = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboDashStyle = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlPenColor = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnClearCanvas = New System.Windows.Forms.Button()
        Me.BtnElipse = New System.Windows.Forms.Button()
        Me.BtnRectangle = New System.Windows.Forms.Button()
        Me.TxtY2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtY1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtX2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtX1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLine = New System.Windows.Forms.Button()
        Me.PicCanvas = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PicCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1191, 755)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 64)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblTransparantFill)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CboPenWidth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PnlFillColor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CboDashStyle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PnlPenColor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnClearCanvas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnElipse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnRectangle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtY2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtY1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtX2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtX1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnLine)
        Me.SplitContainer1.Panel1MinSize = 192
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicCanvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(1183, 686)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 1
        '
        'LblTransparantFill
        '
        Me.LblTransparantFill.AutoSize = True
        Me.LblTransparantFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblTransparantFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransparantFill.ForeColor = System.Drawing.Color.Blue
        Me.LblTransparantFill.Location = New System.Drawing.Point(3, 300)
        Me.LblTransparantFill.Name = "LblTransparantFill"
        Me.LblTransparantFill.Size = New System.Drawing.Size(135, 16)
        Me.LblTransparantFill.TabIndex = 19
        Me.LblTransparantFill.Text = "Transparent Fill Color"
        '
        'CboPenWidth
        '
        Me.CboPenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPenWidth.DropDownWidth = 58
        Me.CboPenWidth.FormattingEnabled = True
        Me.CboPenWidth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CboPenWidth.Location = New System.Drawing.Point(117, 172)
        Me.CboPenWidth.Name = "CboPenWidth"
        Me.CboPenWidth.Size = New System.Drawing.Size(58, 32)
        Me.CboPenWidth.TabIndex = 18
        '
        'PnlFillColor
        '
        Me.PnlFillColor.BackColor = System.Drawing.Color.Transparent
        Me.PnlFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFillColor.Location = New System.Drawing.Point(117, 274)
        Me.PnlFillColor.Name = "PnlFillColor"
        Me.PnlFillColor.Size = New System.Drawing.Size(56, 23)
        Me.PnlFillColor.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fill Color"
        '
        'CboDashStyle
        '
        Me.CboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDashStyle.DropDownWidth = 125
        Me.CboDashStyle.FormattingEnabled = True
        Me.CboDashStyle.Items.AddRange(New Object() {"________________________________________________", "................................................................................", "------------------------------------------------", "-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.", "-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-..-."})
        Me.CboDashStyle.Location = New System.Drawing.Point(117, 207)
        Me.CboDashStyle.Name = "CboDashStyle"
        Me.CboDashStyle.Size = New System.Drawing.Size(58, 32)
        Me.CboDashStyle.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Dash Style"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Pen Width"
        '
        'PnlPenColor
        '
        Me.PnlPenColor.BackColor = System.Drawing.Color.Black
        Me.PnlPenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPenColor.Location = New System.Drawing.Point(117, 245)
        Me.PnlPenColor.Name = "PnlPenColor"
        Me.PnlPenColor.Size = New System.Drawing.Size(56, 23)
        Me.PnlPenColor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pen Color"
        '
        'BtnClearCanvas
        '
        Me.BtnClearCanvas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClearCanvas.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnClearCanvas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearCanvas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClearCanvas.Location = New System.Drawing.Point(11, 628)
        Me.BtnClearCanvas.Name = "BtnClearCanvas"
        Me.BtnClearCanvas.Size = New System.Drawing.Size(166, 53)
        Me.BtnClearCanvas.TabIndex = 11
        Me.BtnClearCanvas.Text = "Clear Canvas"
        Me.BtnClearCanvas.UseVisualStyleBackColor = False
        '
        'BtnElipse
        '
        Me.BtnElipse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnElipse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnElipse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnElipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnElipse.Location = New System.Drawing.Point(11, 543)
        Me.BtnElipse.Name = "BtnElipse"
        Me.BtnElipse.Size = New System.Drawing.Size(166, 53)
        Me.BtnElipse.TabIndex = 10
        Me.BtnElipse.Text = "Elipse"
        Me.BtnElipse.UseVisualStyleBackColor = False
        '
        'BtnRectangle
        '
        Me.BtnRectangle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRectangle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRectangle.Location = New System.Drawing.Point(11, 484)
        Me.BtnRectangle.Name = "BtnRectangle"
        Me.BtnRectangle.Size = New System.Drawing.Size(166, 53)
        Me.BtnRectangle.TabIndex = 9
        Me.BtnRectangle.Text = "Rectangle"
        Me.BtnRectangle.UseVisualStyleBackColor = False
        '
        'TxtY2
        '
        Me.TxtY2.Location = New System.Drawing.Point(55, 120)
        Me.TxtY2.Name = "TxtY2"
        Me.TxtY2.Size = New System.Drawing.Size(122, 29)
        Me.TxtY2.TabIndex = 8
        Me.TxtY2.Text = "0"
        Me.TxtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Y2:"
        '
        'TxtY1
        '
        Me.TxtY1.Location = New System.Drawing.Point(55, 85)
        Me.TxtY1.Name = "TxtY1"
        Me.TxtY1.Size = New System.Drawing.Size(122, 29)
        Me.TxtY1.TabIndex = 6
        Me.TxtY1.Text = "0"
        Me.TxtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Y1:"
        '
        'TxtX2
        '
        Me.TxtX2.Location = New System.Drawing.Point(55, 50)
        Me.TxtX2.Name = "TxtX2"
        Me.TxtX2.Size = New System.Drawing.Size(122, 29)
        Me.TxtX2.TabIndex = 4
        Me.TxtX2.Text = "0"
        Me.TxtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X2:"
        '
        'TxtX1
        '
        Me.TxtX1.Location = New System.Drawing.Point(55, 15)
        Me.TxtX1.Name = "TxtX1"
        Me.TxtX1.Size = New System.Drawing.Size(122, 29)
        Me.TxtX1.TabIndex = 2
        Me.TxtX1.Text = "0"
        Me.TxtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X1:"
        '
        'BtnLine
        '
        Me.BtnLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLine.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLine.Location = New System.Drawing.Point(11, 425)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.Size = New System.Drawing.Size(166, 53)
        Me.BtnLine.TabIndex = 0
        Me.BtnLine.Text = "Line"
        Me.BtnLine.UseVisualStyleBackColor = False
        '
        'PicCanvas
        '
        Me.PicCanvas.BackColor = System.Drawing.Color.White
        Me.PicCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicCanvas.Location = New System.Drawing.Point(0, 0)
        Me.PicCanvas.Name = "PicCanvas"
        Me.PicCanvas.Size = New System.Drawing.Size(988, 684)
        Me.PicCanvas.TabIndex = 0
        Me.PicCanvas.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1183, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Working With Graphics"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 779)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Graphics"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PicCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnLine As Button
    Friend WithEvents BtnClearCanvas As Button
    Friend WithEvents BtnElipse As Button
    Friend WithEvents BtnRectangle As Button
    Friend WithEvents TxtY2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtY1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtX2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtX1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PicCanvas As PictureBox
    Friend WithEvents PnlPenColor As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CboDashStyle As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlFillColor As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents CboPenWidth As ComboBox
    Friend WithEvents LblTransparantFill As Label
End Class
