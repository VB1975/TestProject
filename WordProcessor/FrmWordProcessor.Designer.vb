<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWordProcessor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWordProcessor))
        Me.MnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFilePageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuEditFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuInsertCurrentDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuInsertCurrentTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuInsertCurrentDateTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuViewToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuViewStatusbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormatShortDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormatMediumDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormatLongDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFormatShortTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormatLongTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormat12HourFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFormat24HourFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuFormatCustomDateTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TspStandard = New System.Windows.Forms.ToolStrip()
        Me.BtnNewDocument = New System.Windows.Forms.ToolStripButton()
        Me.BtnOpenDocument = New System.Windows.Forms.ToolStripButton()
        Me.BtnSaveDocument = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintDocument = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCut = New System.Windows.Forms.ToolStripButton()
        Me.BtnCopy = New System.Windows.Forms.ToolStripButton()
        Me.BtnPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.BtnRedo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.BtnAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.BtnAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.BtnAlignJustify = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnFontBold = New System.Windows.Forms.ToolStripButton()
        Me.BtnFontItalic = New System.Windows.Forms.ToolStripButton()
        Me.BtnFontUnderline = New System.Windows.Forms.ToolStripButton()
        Me.BtnFontStrikeThrough = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.CboFont = New System.Windows.Forms.ToolStripComboBox()
        Me.CboFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.SspStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RtfDocument = New System.Windows.Forms.RichTextBox()
        Me.OfdOpenDocument = New System.Windows.Forms.OpenFileDialog()
        Me.SfdSaveDocument = New System.Windows.Forms.SaveFileDialog()
        Me.MnuEditClearClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMain.SuspendLayout()
        Me.TspStandard.SuspendLayout()
        Me.SspStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMain
        '
        Me.MnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.InsertToolStripMenuItem, Me.ViewToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MnuMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuMain.Name = "MnuMain"
        Me.MnuMain.Size = New System.Drawing.Size(1219, 24)
        Me.MnuMain.TabIndex = 0
        Me.MnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFileNew, Me.ToolStripSeparator2, Me.MnuFileOpen, Me.MnuFileSave, Me.MnuFileSaveAs, Me.ToolStripSeparator3, Me.MnuFilePrint, Me.MnuFilePrintPreview, Me.ToolStripSeparator4, Me.MnuFilePageSetup, Me.ToolStripSeparator5, Me.MnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MnuFileNew
        '
        Me.MnuFileNew.Name = "MnuFileNew"
        Me.MnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MnuFileNew.Size = New System.Drawing.Size(146, 22)
        Me.MnuFileNew.Text = "&New"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'MnuFileOpen
        '
        Me.MnuFileOpen.Name = "MnuFileOpen"
        Me.MnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MnuFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.MnuFileOpen.Text = "&Open"
        '
        'MnuFileSave
        '
        Me.MnuFileSave.Name = "MnuFileSave"
        Me.MnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MnuFileSave.Size = New System.Drawing.Size(146, 22)
        Me.MnuFileSave.Text = "&Save"
        '
        'MnuFileSaveAs
        '
        Me.MnuFileSaveAs.Name = "MnuFileSaveAs"
        Me.MnuFileSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.MnuFileSaveAs.Text = "Save as..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'MnuFilePrint
        '
        Me.MnuFilePrint.Name = "MnuFilePrint"
        Me.MnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MnuFilePrint.Size = New System.Drawing.Size(146, 22)
        Me.MnuFilePrint.Text = "&Print"
        '
        'MnuFilePrintPreview
        '
        Me.MnuFilePrintPreview.Name = "MnuFilePrintPreview"
        Me.MnuFilePrintPreview.Size = New System.Drawing.Size(146, 22)
        Me.MnuFilePrintPreview.Text = "Print Pre&view"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(143, 6)
        '
        'MnuFilePageSetup
        '
        Me.MnuFilePageSetup.Name = "MnuFilePageSetup"
        Me.MnuFilePageSetup.Size = New System.Drawing.Size(146, 22)
        Me.MnuFilePageSetup.Text = "Page Setup"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(143, 6)
        '
        'MnuFileExit
        '
        Me.MnuFileExit.Name = "MnuFileExit"
        Me.MnuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.MnuFileExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEditUndo, Me.MnuEditRedo, Me.ToolStripSeparator6, Me.MnuEditCut, Me.MnuEditCopy, Me.MnuEditPaste, Me.MnuEditClearClipboard, Me.ToolStripSeparator7, Me.MnuEditSelectAll, Me.ToolStripSeparator8, Me.MnuEditFont})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'MnuEditUndo
        '
        Me.MnuEditUndo.Name = "MnuEditUndo"
        Me.MnuEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MnuEditUndo.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditUndo.Text = "&Undo"
        '
        'MnuEditRedo
        '
        Me.MnuEditRedo.Name = "MnuEditRedo"
        Me.MnuEditRedo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MnuEditRedo.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditRedo.Text = "&Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'MnuEditCut
        '
        Me.MnuEditCut.Name = "MnuEditCut"
        Me.MnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MnuEditCut.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditCut.Text = "C&ut"
        '
        'MnuEditCopy
        '
        Me.MnuEditCopy.Name = "MnuEditCopy"
        Me.MnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MnuEditCopy.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditCopy.Text = "&Copy"
        '
        'MnuEditPaste
        '
        Me.MnuEditPaste.Name = "MnuEditPaste"
        Me.MnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.MnuEditPaste.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditPaste.Text = "&Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(177, 6)
        '
        'MnuEditSelectAll
        '
        Me.MnuEditSelectAll.Name = "MnuEditSelectAll"
        Me.MnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MnuEditSelectAll.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditSelectAll.Text = "Select &All"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(177, 6)
        '
        'MnuEditFont
        '
        Me.MnuEditFont.Name = "MnuEditFont"
        Me.MnuEditFont.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditFont.Text = "&Font..."
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "&Insert"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuInsertCurrentDate, Me.MnuInsertCurrentTime, Me.MnuInsertCurrentDateTime})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DateToolStripMenuItem.Text = "Date && Time"
        '
        'MnuInsertCurrentDate
        '
        Me.MnuInsertCurrentDate.Name = "MnuInsertCurrentDate"
        Me.MnuInsertCurrentDate.Size = New System.Drawing.Size(183, 22)
        Me.MnuInsertCurrentDate.Text = "Current Date"
        '
        'MnuInsertCurrentTime
        '
        Me.MnuInsertCurrentTime.Name = "MnuInsertCurrentTime"
        Me.MnuInsertCurrentTime.Size = New System.Drawing.Size(183, 22)
        Me.MnuInsertCurrentTime.Text = "CurrentTime"
        '
        'MnuInsertCurrentDateTime
        '
        Me.MnuInsertCurrentDateTime.Name = "MnuInsertCurrentDateTime"
        Me.MnuInsertCurrentDateTime.Size = New System.Drawing.Size(183, 22)
        Me.MnuInsertCurrentDateTime.Text = "Current Date && Time"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuViewToolbar, Me.MnuViewStatusbar})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'MnuViewToolbar
        '
        Me.MnuViewToolbar.Checked = True
        Me.MnuViewToolbar.CheckOnClick = True
        Me.MnuViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MnuViewToolbar.Name = "MnuViewToolbar"
        Me.MnuViewToolbar.Size = New System.Drawing.Size(123, 22)
        Me.MnuViewToolbar.Text = "Toolbar"
        '
        'MnuViewStatusbar
        '
        Me.MnuViewStatusbar.Checked = True
        Me.MnuViewStatusbar.CheckOnClick = True
        Me.MnuViewStatusbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MnuViewStatusbar.Name = "MnuViewStatusbar"
        Me.MnuViewStatusbar.Size = New System.Drawing.Size(123, 22)
        Me.MnuViewStatusbar.Text = "Statusbar"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatesToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'DatesToolStripMenuItem
        '
        Me.DatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFormatShortDate, Me.MnuFormatMediumDate, Me.MnuFormatLongDate, Me.ToolStripSeparator9, Me.MnuFormatShortTime, Me.MnuFormatLongTime, Me.MnuFormat12HourFormat, Me.MnuFormat24HourFormat, Me.ToolStripSeparator10, Me.MnuFormatCustomDateTime})
        Me.DatesToolStripMenuItem.Name = "DatesToolStripMenuItem"
        Me.DatesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DatesToolStripMenuItem.Text = "Dates && Times"
        '
        'MnuFormatShortDate
        '
        Me.MnuFormatShortDate.Name = "MnuFormatShortDate"
        Me.MnuFormatShortDate.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatShortDate.Text = "Short Date"
        '
        'MnuFormatMediumDate
        '
        Me.MnuFormatMediumDate.Name = "MnuFormatMediumDate"
        Me.MnuFormatMediumDate.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatMediumDate.Text = "Medium Date"
        '
        'MnuFormatLongDate
        '
        Me.MnuFormatLongDate.Name = "MnuFormatLongDate"
        Me.MnuFormatLongDate.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatLongDate.Text = "Long Date"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(154, 6)
        '
        'MnuFormatShortTime
        '
        Me.MnuFormatShortTime.Name = "MnuFormatShortTime"
        Me.MnuFormatShortTime.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatShortTime.Text = "Short Time"
        '
        'MnuFormatLongTime
        '
        Me.MnuFormatLongTime.Name = "MnuFormatLongTime"
        Me.MnuFormatLongTime.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatLongTime.Text = "Long Time"
        '
        'MnuFormat12HourFormat
        '
        Me.MnuFormat12HourFormat.Name = "MnuFormat12HourFormat"
        Me.MnuFormat12HourFormat.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormat12HourFormat.Text = "12 Hour Format"
        '
        'MnuFormat24HourFormat
        '
        Me.MnuFormat24HourFormat.Name = "MnuFormat24HourFormat"
        Me.MnuFormat24HourFormat.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormat24HourFormat.Text = "24 Hour Format"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(154, 6)
        '
        'MnuFormatCustomDateTime
        '
        Me.MnuFormatCustomDateTime.Name = "MnuFormatCustomDateTime"
        Me.MnuFormatCustomDateTime.Size = New System.Drawing.Size(157, 22)
        Me.MnuFormatCustomDateTime.Text = "Custom..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuHelpIndex, Me.ToolStripSeparator11, Me.MnuHelpAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'MnuHelpIndex
        '
        Me.MnuHelpIndex.Name = "MnuHelpIndex"
        Me.MnuHelpIndex.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.MnuHelpIndex.Size = New System.Drawing.Size(150, 22)
        Me.MnuHelpIndex.Text = "&Help Index"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(147, 6)
        '
        'MnuHelpAbout
        '
        Me.MnuHelpAbout.Name = "MnuHelpAbout"
        Me.MnuHelpAbout.Size = New System.Drawing.Size(150, 22)
        Me.MnuHelpAbout.Text = "About..."
        '
        'TspStandard
        '
        Me.TspStandard.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TspStandard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewDocument, Me.BtnOpenDocument, Me.BtnSaveDocument, Me.BtnPrintDocument, Me.toolStripSeparator, Me.BtnCut, Me.BtnCopy, Me.BtnPaste, Me.ToolStripSeparator12, Me.BtnUndo, Me.BtnRedo, Me.toolStripSeparator1, Me.BtnAlignLeft, Me.BtnAlignCenter, Me.BtnAlignRight, Me.BtnAlignJustify, Me.ToolStripSeparator13, Me.BtnFontBold, Me.BtnFontItalic, Me.BtnFontUnderline, Me.BtnFontStrikeThrough, Me.ToolStripSeparator14, Me.CboFont, Me.CboFontSize, Me.ToolStripSeparator15})
        Me.TspStandard.Location = New System.Drawing.Point(0, 24)
        Me.TspStandard.Name = "TspStandard"
        Me.TspStandard.Size = New System.Drawing.Size(1219, 39)
        Me.TspStandard.TabIndex = 1
        Me.TspStandard.Text = "ToolStrip1"
        '
        'BtnNewDocument
        '
        Me.BtnNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNewDocument.Image = Global.WordProcessor.My.Resources.Resources._New
        Me.BtnNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewDocument.Name = "BtnNewDocument"
        Me.BtnNewDocument.Size = New System.Drawing.Size(36, 36)
        Me.BtnNewDocument.Text = "New"
        '
        'BtnOpenDocument
        '
        Me.BtnOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnOpenDocument.Image = Global.WordProcessor.My.Resources.Resources.Open
        Me.BtnOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOpenDocument.Name = "BtnOpenDocument"
        Me.BtnOpenDocument.Size = New System.Drawing.Size(36, 36)
        Me.BtnOpenDocument.Text = "Open"
        '
        'BtnSaveDocument
        '
        Me.BtnSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSaveDocument.Image = Global.WordProcessor.My.Resources.Resources.Save
        Me.BtnSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveDocument.Name = "BtnSaveDocument"
        Me.BtnSaveDocument.Size = New System.Drawing.Size(36, 36)
        Me.BtnSaveDocument.Text = "Save"
        '
        'BtnPrintDocument
        '
        Me.BtnPrintDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintDocument.Image = Global.WordProcessor.My.Resources.Resources.Print
        Me.BtnPrintDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintDocument.Name = "BtnPrintDocument"
        Me.BtnPrintDocument.Size = New System.Drawing.Size(36, 36)
        Me.BtnPrintDocument.Text = "Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'BtnCut
        '
        Me.BtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCut.Enabled = False
        Me.BtnCut.Image = Global.WordProcessor.My.Resources.Resources.Cut
        Me.BtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.Size = New System.Drawing.Size(36, 36)
        Me.BtnCut.Text = "Cut"
        '
        'BtnCopy
        '
        Me.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Image = Global.WordProcessor.My.Resources.Resources.Copy
        Me.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(36, 36)
        Me.BtnCopy.Text = "Copy"
        '
        'BtnPaste
        '
        Me.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPaste.Enabled = False
        Me.BtnPaste.Image = Global.WordProcessor.My.Resources.Resources.Paste
        Me.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(36, 36)
        Me.BtnPaste.Text = "Paste"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 39)
        '
        'BtnUndo
        '
        Me.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnUndo.Enabled = False
        Me.BtnUndo.Image = Global.WordProcessor.My.Resources.Resources.Undo
        Me.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(36, 36)
        Me.BtnUndo.Text = "Undo"
        '
        'BtnRedo
        '
        Me.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRedo.Enabled = False
        Me.BtnRedo.Image = Global.WordProcessor.My.Resources.Resources.Redo
        Me.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRedo.Name = "BtnRedo"
        Me.BtnRedo.Size = New System.Drawing.Size(36, 36)
        Me.BtnRedo.Text = "Redo"
        Me.BtnRedo.ToolTipText = "Redo"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BtnAlignLeft
        '
        Me.BtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAlignLeft.Image = Global.WordProcessor.My.Resources.Resources.AlignLeft
        Me.BtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAlignLeft.Name = "BtnAlignLeft"
        Me.BtnAlignLeft.Size = New System.Drawing.Size(36, 36)
        Me.BtnAlignLeft.Text = "Align Left"
        '
        'BtnAlignCenter
        '
        Me.BtnAlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAlignCenter.Image = Global.WordProcessor.My.Resources.Resources.AlignCentre
        Me.BtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.BtnAlignCenter.Name = "BtnAlignCenter"
        Me.BtnAlignCenter.Size = New System.Drawing.Size(36, 36)
        Me.BtnAlignCenter.Text = "Align Center"
        '
        'BtnAlignRight
        '
        Me.BtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAlignRight.Image = Global.WordProcessor.My.Resources.Resources.AlignRight
        Me.BtnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAlignRight.Name = "BtnAlignRight"
        Me.BtnAlignRight.Size = New System.Drawing.Size(36, 36)
        Me.BtnAlignRight.Text = "Align Right"
        '
        'BtnAlignJustify
        '
        Me.BtnAlignJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAlignJustify.Image = Global.WordProcessor.My.Resources.Resources.AlignJustify
        Me.BtnAlignJustify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAlignJustify.Name = "BtnAlignJustify"
        Me.BtnAlignJustify.Size = New System.Drawing.Size(36, 36)
        Me.BtnAlignJustify.Text = "Justify"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 39)
        '
        'BtnFontBold
        '
        Me.BtnFontBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFontBold.Image = Global.WordProcessor.My.Resources.Resources.FontBold
        Me.BtnFontBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFontBold.Name = "BtnFontBold"
        Me.BtnFontBold.Size = New System.Drawing.Size(36, 36)
        Me.BtnFontBold.Text = "Bold"
        '
        'BtnFontItalic
        '
        Me.BtnFontItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFontItalic.Image = Global.WordProcessor.My.Resources.Resources.FontItalic
        Me.BtnFontItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFontItalic.Name = "BtnFontItalic"
        Me.BtnFontItalic.Size = New System.Drawing.Size(36, 36)
        Me.BtnFontItalic.Text = "Italic"
        '
        'BtnFontUnderline
        '
        Me.BtnFontUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFontUnderline.Image = Global.WordProcessor.My.Resources.Resources.FontUnderline
        Me.BtnFontUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFontUnderline.Name = "BtnFontUnderline"
        Me.BtnFontUnderline.Size = New System.Drawing.Size(36, 36)
        Me.BtnFontUnderline.Text = "Underline"
        '
        'BtnFontStrikeThrough
        '
        Me.BtnFontStrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFontStrikeThrough.Image = Global.WordProcessor.My.Resources.Resources.FontStrikeThrough
        Me.BtnFontStrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFontStrikeThrough.Name = "BtnFontStrikeThrough"
        Me.BtnFontStrikeThrough.Size = New System.Drawing.Size(36, 36)
        Me.BtnFontStrikeThrough.Text = "Strike Through"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 39)
        '
        'CboFont
        '
        Me.CboFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFont.DropDownWidth = 250
        Me.CboFont.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFont.Name = "CboFont"
        Me.CboFont.Size = New System.Drawing.Size(250, 39)
        '
        'CboFontSize
        '
        Me.CboFontSize.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFontSize.Name = "CboFontSize"
        Me.CboFontSize.Size = New System.Drawing.Size(75, 39)
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 39)
        '
        'SspStatus
        '
        Me.SspStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.SspStatus.Location = New System.Drawing.Point(0, 675)
        Me.SspStatus.Name = "SspStatus"
        Me.SspStatus.Size = New System.Drawing.Size(1219, 22)
        Me.SspStatus.TabIndex = 2
        Me.SspStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel1.Text = "Ready..."
        '
        'RtfDocument
        '
        Me.RtfDocument.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RtfDocument.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtfDocument.Location = New System.Drawing.Point(0, 66)
        Me.RtfDocument.Name = "RtfDocument"
        Me.RtfDocument.Size = New System.Drawing.Size(1219, 597)
        Me.RtfDocument.TabIndex = 3
        Me.RtfDocument.Text = resources.GetString("RtfDocument.Text")
        '
        'OfdOpenDocument
        '
        Me.OfdOpenDocument.FileName = "OpenFileDialog1"
        '
        'MnuEditClearClipboard
        '
        Me.MnuEditClearClipboard.Name = "MnuEditClearClipboard"
        Me.MnuEditClearClipboard.Size = New System.Drawing.Size(180, 22)
        Me.MnuEditClearClipboard.Text = "Clear Clipboard"
        '
        'FrmWordProcessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 697)
        Me.Controls.Add(Me.RtfDocument)
        Me.Controls.Add(Me.SspStatus)
        Me.Controls.Add(Me.TspStandard)
        Me.Controls.Add(Me.MnuMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmWordProcessor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Processor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuMain.ResumeLayout(False)
        Me.MnuMain.PerformLayout()
        Me.TspStandard.ResumeLayout(False)
        Me.TspStandard.PerformLayout()
        Me.SspStatus.ResumeLayout(False)
        Me.SspStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TspStandard As ToolStrip
    Friend WithEvents BtnNewDocument As ToolStripButton
    Friend WithEvents BtnOpenDocument As ToolStripButton
    Friend WithEvents BtnSaveDocument As ToolStripButton
    Friend WithEvents BtnPrintDocument As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents BtnCut As ToolStripButton
    Friend WithEvents BtnCopy As ToolStripButton
    Friend WithEvents BtnPaste As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SspStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents RtfDocument As RichTextBox
    Friend WithEvents MnuFileNew As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MnuFileOpen As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuFileSave As ToolStripMenuItem
    Friend WithEvents MnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MnuFilePrint As ToolStripMenuItem
    Friend WithEvents MnuFilePrintPreview As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MnuFilePageSetup As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents MnuFileExit As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuEditUndo As ToolStripMenuItem
    Friend WithEvents MnuEditRedo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents MnuEditCut As ToolStripMenuItem
    Friend WithEvents MnuEditCopy As ToolStripMenuItem
    Friend WithEvents MnuEditPaste As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents MnuEditSelectAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents MnuEditFont As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuInsertCurrentDate As ToolStripMenuItem
    Friend WithEvents MnuInsertCurrentTime As ToolStripMenuItem
    Friend WithEvents MnuInsertCurrentDateTime As ToolStripMenuItem
    Friend WithEvents MnuViewToolbar As ToolStripMenuItem
    Friend WithEvents MnuViewStatusbar As ToolStripMenuItem
    Friend WithEvents DatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuFormatShortDate As ToolStripMenuItem
    Friend WithEvents MnuFormatMediumDate As ToolStripMenuItem
    Friend WithEvents MnuFormatLongDate As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents MnuFormatShortTime As ToolStripMenuItem
    Friend WithEvents MnuFormatLongTime As ToolStripMenuItem
    Friend WithEvents MnuFormat12HourFormat As ToolStripMenuItem
    Friend WithEvents MnuFormat24HourFormat As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents MnuFormatCustomDateTime As ToolStripMenuItem
    Friend WithEvents MnuHelpIndex As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents MnuHelpAbout As ToolStripMenuItem
    Friend WithEvents OfdOpenDocument As OpenFileDialog
    Friend WithEvents SfdSaveDocument As SaveFileDialog
    Friend WithEvents BtnUndo As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents BtnRedo As ToolStripButton
    Friend WithEvents BtnFontBold As ToolStripButton
    Friend WithEvents BtnFontItalic As ToolStripButton
    Friend WithEvents BtnFontUnderline As ToolStripButton
    Friend WithEvents BtnFontStrikeThrough As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents BtnAlignLeft As ToolStripButton
    Friend WithEvents BtnAlignCenter As ToolStripButton
    Friend WithEvents BtnAlignJustify As ToolStripButton
    Friend WithEvents BtnAlignRight As ToolStripButton
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents CboFont As ToolStripComboBox
    Friend WithEvents CboFontSize As ToolStripComboBox
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents MnuEditClearClipboard As ToolStripMenuItem
End Class
