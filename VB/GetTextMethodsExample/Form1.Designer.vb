Imports Microsoft.VisualBasic
Imports System
Namespace GetTextMethods
    Public Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.fontBar1 = New DevExpress.XtraRichEdit.UI.FontBar()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.illustrationsBar1 = New DevExpress.XtraRichEdit.UI.IllustrationsBar()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(60, 5)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(50, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Mht"
'            Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.simpleButton4)
            Me.panelControl1.Controls.Add(Me.simpleButton3)
            Me.panelControl1.Controls.Add(Me.simpleButton2)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 53)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(677, 34)
            Me.panelControl1.TabIndex = 5
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(12, 10)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(42, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "Save as:"
            ' 
            ' simpleButton4
            ' 
            Me.simpleButton4.Location = New System.Drawing.Point(234, 5)
            Me.simpleButton4.Name = "simpleButton4"
            Me.simpleButton4.Size = New System.Drawing.Size(50, 23)
            Me.simpleButton4.TabIndex = 4
            Me.simpleButton4.Text = "Rtf"
'            Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
            ' 
            ' simpleButton3
            ' 
            Me.simpleButton3.Location = New System.Drawing.Point(176, 5)
            Me.simpleButton3.Name = "simpleButton3"
            Me.simpleButton3.Size = New System.Drawing.Size(50, 23)
            Me.simpleButton3.TabIndex = 3
            Me.simpleButton3.Text = "Docx"
'            Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(117, 5)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(50, 23)
            Me.simpleButton2.TabIndex = 2
            Me.simpleButton2.Text = "Html"
'            Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 87)
            Me.richEditControl.MenuManager = Me.barManager1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(677, 302)
            Me.richEditControl.TabIndex = 0
'            Me.richEditControl.BeforeExport += New DevExpress.XtraRichEdit.BeforeExportEventHandler(Me.richEditControl_BeforeExport);
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.fontBar1, Me.commonBar1, Me.illustrationsBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.insertPictureItem1, Me.insertPageBreakItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1})
            Me.barManager1.MaxItemId = 39
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
            ' 
            ' fontBar1
            ' 
            Me.fontBar1.DockCol = 0
            Me.fontBar1.DockRow = 1
            Me.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.fontBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontNameItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontSizeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontBackColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontBoldItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontItalicItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSuperscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSubscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeIncreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeDecreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.clearFormattingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showFontFormItem1)})
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 0
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            Me.changeFontNameItem1.Width = 150
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 1
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Glyph = (CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
            Me.changeFontColorItem1.Id = 2
            Me.changeFontColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Glyph = (CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
            Me.changeFontBackColorItem1.Id = 3
            Me.changeFontBackColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Glyph = (CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontBoldItem1.Id = 4
            Me.toggleFontBoldItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
            Me.toggleFontBoldItem1.LargeGlyph = (CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Glyph = (CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontItalicItem1.Id = 5
            Me.toggleFontItalicItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
            Me.toggleFontItalicItem1.LargeGlyph = (CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.Id = 6
            Me.toggleFontUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
            Me.toggleFontUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.Id = 7
            Me.toggleFontDoubleUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D))
            Me.toggleFontDoubleUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.Id = 8
            Me.toggleFontStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.Id = 9
            Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.Id = 10
            Me.toggleFontSuperscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemplus))
            Me.toggleFontSuperscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.Id = 11
            Me.toggleFontSubscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus))
            Me.toggleFontSubscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Glyph = (CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.Id = 12
            Me.fontSizeIncreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.OemPeriod))
            Me.fontSizeIncreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Glyph = (CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.Id = 13
            Me.fontSizeDecreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemcomma))
            Me.fontSizeDecreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Glyph = (CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image))
            Me.clearFormattingItem1.Id = 14
            Me.clearFormattingItem1.LargeGlyph = (CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image))
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' showFontFormItem1
            ' 
            Me.showFontFormItem1.Glyph = (CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image))
            Me.showFontFormItem1.Id = 15
            Me.showFontFormItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
            Me.showFontFormItem1.LargeGlyph = (CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' commonBar1
            ' 
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Glyph = (CType(resources.GetObject("fileNewItem1.Glyph"), System.Drawing.Image))
            Me.fileNewItem1.Id = 30
            Me.fileNewItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.fileNewItem1.LargeGlyph = (CType(resources.GetObject("fileNewItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Glyph = (CType(resources.GetObject("fileOpenItem1.Glyph"), System.Drawing.Image))
            Me.fileOpenItem1.Id = 31
            Me.fileOpenItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.fileOpenItem1.LargeGlyph = (CType(resources.GetObject("fileOpenItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Glyph = (CType(resources.GetObject("fileSaveItem1.Glyph"), System.Drawing.Image))
            Me.fileSaveItem1.Id = 32
            Me.fileSaveItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.fileSaveItem1.LargeGlyph = (CType(resources.GetObject("fileSaveItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Glyph = (CType(resources.GetObject("fileSaveAsItem1.Glyph"), System.Drawing.Image))
            Me.fileSaveAsItem1.Id = 33
            Me.fileSaveAsItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
            Me.fileSaveAsItem1.LargeGlyph = (CType(resources.GetObject("fileSaveAsItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Glyph = (CType(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image))
            Me.quickPrintItem1.Id = 34
            Me.quickPrintItem1.LargeGlyph = (CType(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image))
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Glyph = (CType(resources.GetObject("printItem1.Glyph"), System.Drawing.Image))
            Me.printItem1.Id = 35
            Me.printItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.printItem1.LargeGlyph = (CType(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image))
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Glyph = (CType(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image))
            Me.printPreviewItem1.Id = 36
            Me.printPreviewItem1.LargeGlyph = (CType(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image))
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
            Me.undoItem1.Id = 37
            Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
            Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
            Me.redoItem1.Id = 38
            Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
            Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' illustrationsBar1
            ' 
            Me.illustrationsBar1.DockCol = 1
            Me.illustrationsBar1.DockRow = 1
            Me.illustrationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.illustrationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertPictureItem1)})
            Me.illustrationsBar1.Offset = 596
            ' 
            ' insertPictureItem1
            ' 
            Me.insertPictureItem1.Glyph = (CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image))
            Me.insertPictureItem1.Id = 28
            Me.insertPictureItem1.LargeGlyph = (CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.Id = 16
            Me.toggleParagraphAlignmentLeftItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
            Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.Id = 17
            Me.toggleParagraphAlignmentCenterItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
            Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.Id = 18
            Me.toggleParagraphAlignmentRightItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
            Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.Id = 19
            Me.toggleParagraphAlignmentJustifyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J))
            Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Glyph = (CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
            Me.toggleNumberingListItem1.Id = 20
            Me.toggleNumberingListItem1.LargeGlyph = (CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Glyph = (CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
            Me.toggleBulletedListItem1.Id = 21
            Me.toggleBulletedListItem1.LargeGlyph = (CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Glyph = (CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.Id = 22
            Me.toggleMultiLevelListItem1.LargeGlyph = (CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Glyph = (CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
            Me.decreaseIndentItem1.Id = 23
            Me.decreaseIndentItem1.LargeGlyph = (CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Glyph = (CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
            Me.increaseIndentItem1.Id = 24
            Me.increaseIndentItem1.LargeGlyph = (CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Glyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.Id = 25
            Me.toggleShowWhitespaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D8))
            Me.toggleShowWhitespaceItem1.LargeGlyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            Me.showParagraphFormItem1.Glyph = (CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
            Me.showParagraphFormItem1.Id = 26
            Me.showParagraphFormItem1.LargeGlyph = (CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' changeStyleItem1
            ' 
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 27
            Me.changeStyleItem1.Name = "changeStyleItem1"
            Me.changeStyleItem1.Width = 100
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' insertPageBreakItem1
            ' 
            Me.insertPageBreakItem1.Glyph = (CType(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Id = 29
            Me.insertPageBreakItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Enter))
            Me.insertPageBreakItem1.LargeGlyph = (CType(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.RichEditControl = Me.richEditControl
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(677, 389)
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents richEditControl As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private fontBar1 As DevExpress.XtraRichEdit.UI.FontBar
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private illustrationsBar1 As DevExpress.XtraRichEdit.UI.IllustrationsBar
    End Class
End Namespace

