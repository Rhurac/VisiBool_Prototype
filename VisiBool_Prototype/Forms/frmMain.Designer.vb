<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabbedViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcTabControl = New System.Windows.Forms.TabControl()
        Me.tabLibrary = New System.Windows.Forms.TabPage()
        Me.pnlLibrary = New System.Windows.Forms.TableLayoutPanel()
        Me.lboLibrary = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddFunc = New System.Windows.Forms.Button()
        Me.btnDelFunc = New System.Windows.Forms.Button()
        Me.tabSourceCode = New System.Windows.Forms.TabPage()
        Me.pnlSource = New System.Windows.Forms.TableLayoutPanel()
        Me.lboSource = New System.Windows.Forms.ListBox()
        Me.pnlSourceBtnTray = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelSource = New System.Windows.Forms.Button()
        Me.btnAddSource = New System.Windows.Forms.Button()
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.LibraryContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.miImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCollapse = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExpand = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpMain.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        Me.tcTabControl.SuspendLayout()
        Me.tabLibrary.SuspendLayout()
        Me.pnlLibrary.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabSourceCode.SuspendLayout()
        Me.pnlSource.SuspendLayout()
        Me.pnlSourceBtnTray.SuspendLayout()
        Me.LibraryContextMenu.SuspendLayout()
        Me.FunctionContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.CausesValidation = False
        Me.tlpMain.ColumnCount = 35
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.Controls.Add(Me.MainMenuStrip, 0, 0)
        Me.tlpMain.Controls.Add(Me.tcTabControl, 0, 3)
        Me.tlpMain.Controls.Add(Me.pnlDisplay, 7, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 35
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143!))
        Me.tlpMain.Size = New System.Drawing.Size(1184, 962)
        Me.tlpMain.TabIndex = 0
        '
        'MainMenuStrip
        '
        Me.tlpMain.SetColumnSpan(Me.MainMenuStrip, 35)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiFile, Me.EditToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.tlpMain.SetRowSpan(Me.MainMenuStrip, 2)
        Me.MainMenuStrip.Size = New System.Drawing.Size(1184, 24)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'tsiFile
        '
        Me.tsiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.tsiFile.Name = "tsiFile"
        Me.tsiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsiFile.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplitHorizontalToolStripMenuItem, Me.SplitVerticalToolStripMenuItem, Me.TabbedViewToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SplitHorizontalToolStripMenuItem
        '
        Me.SplitHorizontalToolStripMenuItem.Name = "SplitHorizontalToolStripMenuItem"
        Me.SplitHorizontalToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SplitHorizontalToolStripMenuItem.Text = "Split Horizontal"
        '
        'SplitVerticalToolStripMenuItem
        '
        Me.SplitVerticalToolStripMenuItem.Name = "SplitVerticalToolStripMenuItem"
        Me.SplitVerticalToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SplitVerticalToolStripMenuItem.Text = "Split Vertical"
        '
        'TabbedViewToolStripMenuItem
        '
        Me.TabbedViewToolStripMenuItem.Name = "TabbedViewToolStripMenuItem"
        Me.TabbedViewToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TabbedViewToolStripMenuItem.Text = "Tabbed View"
        '
        'tcTabControl
        '
        Me.tlpMain.SetColumnSpan(Me.tcTabControl, 7)
        Me.tcTabControl.Controls.Add(Me.tabLibrary)
        Me.tcTabControl.Controls.Add(Me.tabSourceCode)
        Me.tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTabControl.Location = New System.Drawing.Point(3, 84)
        Me.tcTabControl.Name = "tcTabControl"
        Me.tlpMain.SetRowSpan(Me.tcTabControl, 32)
        Me.tcTabControl.SelectedIndex = 0
        Me.tcTabControl.Size = New System.Drawing.Size(225, 875)
        Me.tcTabControl.TabIndex = 1
        '
        'tabLibrary
        '
        Me.tabLibrary.Controls.Add(Me.pnlLibrary)
        Me.tabLibrary.Location = New System.Drawing.Point(4, 27)
        Me.tabLibrary.Name = "tabLibrary"
        Me.tabLibrary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLibrary.Size = New System.Drawing.Size(217, 844)
        Me.tabLibrary.TabIndex = 0
        Me.tabLibrary.Text = "My Library"
        Me.tabLibrary.UseVisualStyleBackColor = True
        '
        'pnlLibrary
        '
        Me.pnlLibrary.CausesValidation = False
        Me.pnlLibrary.ColumnCount = 10
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLibrary.Controls.Add(Me.lboLibrary, 0, 0)
        Me.pnlLibrary.Controls.Add(Me.TableLayoutPanel1, 0, 20)
        Me.pnlLibrary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLibrary.Location = New System.Drawing.Point(3, 3)
        Me.pnlLibrary.Name = "pnlLibrary"
        Me.pnlLibrary.RowCount = 21
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.pnlLibrary.Size = New System.Drawing.Size(211, 838)
        Me.pnlLibrary.TabIndex = 0
        '
        'lboLibrary
        '
        Me.pnlLibrary.SetColumnSpan(Me.lboLibrary, 10)
        Me.lboLibrary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lboLibrary.FormattingEnabled = True
        Me.lboLibrary.ItemHeight = 18
        Me.lboLibrary.Location = New System.Drawing.Point(3, 3)
        Me.lboLibrary.Name = "lboLibrary"
        Me.pnlLibrary.SetRowSpan(Me.lboLibrary, 20)
        Me.lboLibrary.Size = New System.Drawing.Size(205, 774)
        Me.lboLibrary.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.pnlLibrary.SetColumnSpan(Me.TableLayoutPanel1, 10)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddFunc, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelFunc, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 783)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 52)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnAddFunc
        '
        Me.btnAddFunc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddFunc.Location = New System.Drawing.Point(103, 3)
        Me.btnAddFunc.Name = "btnAddFunc"
        Me.btnAddFunc.Size = New System.Drawing.Size(94, 46)
        Me.btnAddFunc.TabIndex = 1
        Me.btnAddFunc.Text = "&Add " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Function"
        Me.btnAddFunc.UseVisualStyleBackColor = True
        '
        'btnDelFunc
        '
        Me.btnDelFunc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelFunc.Location = New System.Drawing.Point(3, 3)
        Me.btnDelFunc.Name = "btnDelFunc"
        Me.btnDelFunc.Size = New System.Drawing.Size(94, 46)
        Me.btnDelFunc.TabIndex = 2
        Me.btnDelFunc.Text = "&Remove " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Function"
        Me.btnDelFunc.UseVisualStyleBackColor = True
        '
        'tabSourceCode
        '
        Me.tabSourceCode.Controls.Add(Me.pnlSource)
        Me.tabSourceCode.Location = New System.Drawing.Point(4, 27)
        Me.tabSourceCode.Name = "tabSourceCode"
        Me.tabSourceCode.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSourceCode.Size = New System.Drawing.Size(217, 844)
        Me.tabSourceCode.TabIndex = 1
        Me.tabSourceCode.Text = "My Source Code"
        Me.tabSourceCode.UseVisualStyleBackColor = True
        '
        'pnlSource
        '
        Me.pnlSource.CausesValidation = False
        Me.pnlSource.ColumnCount = 1
        Me.pnlSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSource.Controls.Add(Me.lboSource, 0, 0)
        Me.pnlSource.Controls.Add(Me.pnlSourceBtnTray, 0, 1)
        Me.pnlSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSource.Location = New System.Drawing.Point(3, 3)
        Me.pnlSource.Name = "pnlSource"
        Me.pnlSource.RowCount = 2
        Me.pnlSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.60143!))
        Me.pnlSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.398568!))
        Me.pnlSource.Size = New System.Drawing.Size(211, 838)
        Me.pnlSource.TabIndex = 0
        '
        'lboSource
        '
        Me.lboSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lboSource.ItemHeight = 18
        Me.lboSource.Location = New System.Drawing.Point(3, 3)
        Me.lboSource.Name = "lboSource"
        Me.lboSource.Size = New System.Drawing.Size(205, 770)
        Me.lboSource.TabIndex = 1
        '
        'pnlSourceBtnTray
        '
        Me.pnlSourceBtnTray.ColumnCount = 2
        Me.pnlSourceBtnTray.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSourceBtnTray.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSourceBtnTray.Controls.Add(Me.btnDelSource, 0, 0)
        Me.pnlSourceBtnTray.Controls.Add(Me.btnAddSource, 1, 0)
        Me.pnlSourceBtnTray.Location = New System.Drawing.Point(3, 779)
        Me.pnlSourceBtnTray.Name = "pnlSourceBtnTray"
        Me.pnlSourceBtnTray.RowCount = 1
        Me.pnlSourceBtnTray.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSourceBtnTray.Size = New System.Drawing.Size(200, 56)
        Me.pnlSourceBtnTray.TabIndex = 2
        '
        'btnDelSource
        '
        Me.btnDelSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelSource.Location = New System.Drawing.Point(3, 3)
        Me.btnDelSource.Name = "btnDelSource"
        Me.btnDelSource.Size = New System.Drawing.Size(94, 50)
        Me.btnDelSource.TabIndex = 0
        Me.btnDelSource.Text = "&Remove " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
        Me.btnDelSource.UseVisualStyleBackColor = True
        '
        'btnAddSource
        '
        Me.btnAddSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddSource.Location = New System.Drawing.Point(103, 3)
        Me.btnAddSource.Name = "btnAddSource"
        Me.btnAddSource.Size = New System.Drawing.Size(94, 50)
        Me.btnAddSource.TabIndex = 1
        Me.btnAddSource.Text = "&Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
        Me.btnAddSource.UseVisualStyleBackColor = True
        '
        'pnlDisplay
        '
        Me.pnlDisplay.BackColor = System.Drawing.Color.Transparent
        Me.tlpMain.SetColumnSpan(Me.pnlDisplay, 28)
        Me.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay.Location = New System.Drawing.Point(234, 57)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.tlpMain.SetRowSpan(Me.pnlDisplay, 33)
        Me.pnlDisplay.Size = New System.Drawing.Size(947, 902)
        Me.pnlDisplay.TabIndex = 2
        '
        'LibraryContextMenu
        '
        Me.LibraryContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miDescription, Me.miImport, Me.miExport, Me.miCollapse, Me.miExpand})
        Me.LibraryContextMenu.Name = "cmsLibrary"
        Me.LibraryContextMenu.Size = New System.Drawing.Size(138, 114)
        '
        'miDescription
        '
        Me.miDescription.Name = "miDescription"
        Me.miDescription.Size = New System.Drawing.Size(137, 22)
        Me.miDescription.Text = "What's this?"
        '
        'miImport
        '
        Me.miImport.Name = "miImport"
        Me.miImport.Size = New System.Drawing.Size(137, 22)
        Me.miImport.Text = "Import ..."
        '
        'miExport
        '
        Me.miExport.Name = "miExport"
        Me.miExport.Size = New System.Drawing.Size(137, 22)
        Me.miExport.Text = "Export ..."
        '
        'miCollapse
        '
        Me.miCollapse.Name = "miCollapse"
        Me.miCollapse.Size = New System.Drawing.Size(137, 22)
        Me.miCollapse.Text = "Collapse All"
        '
        'miExpand
        '
        Me.miExpand.Name = "miExpand"
        Me.miExpand.Size = New System.Drawing.Size(137, 22)
        Me.miExpand.Text = "Expand All"
        '
        'FunctionContextMenu
        '
        Me.FunctionContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.FunctionContextMenu.Name = "FunctionContextMenu"
        Me.FunctionContextMenu.Size = New System.Drawing.Size(162, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem1.Text = "Paste in Editor ..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 962)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisiBool - Editor"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.tcTabControl.ResumeLayout(False)
        Me.tabLibrary.ResumeLayout(False)
        Me.pnlLibrary.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabSourceCode.ResumeLayout(False)
        Me.pnlSource.ResumeLayout(False)
        Me.pnlSourceBtnTray.ResumeLayout(False)
        Me.LibraryContextMenu.ResumeLayout(False)
        Me.FunctionContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcTabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabLibrary As System.Windows.Forms.TabPage
    Friend WithEvents tabSourceCode As System.Windows.Forms.TabPage
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents miDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCollapse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExpand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlLibrary As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlDisplay As System.Windows.Forms.Panel
    Friend WithEvents TabbedViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunctionContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lboLibrary As System.Windows.Forms.ListBox
    Friend WithEvents pnlSource As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lboSource As System.Windows.Forms.ListBox
    Friend WithEvents pnlSourceBtnTray As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnDelSource As System.Windows.Forms.Button
    Friend WithEvents btnAddSource As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddFunc As System.Windows.Forms.Button
    Friend WithEvents btnDelFunc As System.Windows.Forms.Button

End Class
