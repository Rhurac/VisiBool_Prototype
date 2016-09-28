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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4 Bit Adder")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8 Bit Adder")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("16 Bit Adder")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adders", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("R-S Flip Flop")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("J-K Flip Flop")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("D Flip Flop")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("T Flip Flop")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flip Flops", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8})
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
        Me.tabSource = New System.Windows.Forms.TabPage()
        Me.tlpSource = New System.Windows.Forms.TableLayoutPanel()
        Me.lboSource = New System.Windows.Forms.ListBox()
        Me.tabLibrary = New System.Windows.Forms.TabPage()
        Me.tlpLibrary = New System.Windows.Forms.TableLayoutPanel()
        Me.tvLibrary = New System.Windows.Forms.TreeView()
        Me.LibraryContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.miImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCollapse = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExpand = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.FunctionContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpMain.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        Me.tcTabControl.SuspendLayout()
        Me.tabSource.SuspendLayout()
        Me.tlpSource.SuspendLayout()
        Me.tabLibrary.SuspendLayout()
        Me.tlpLibrary.SuspendLayout()
        Me.LibraryContextMenu.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
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
        Me.tcTabControl.Controls.Add(Me.tabSource)
        Me.tcTabControl.Controls.Add(Me.tabLibrary)
        Me.tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTabControl.Location = New System.Drawing.Point(3, 84)
        Me.tcTabControl.Name = "tcTabControl"
        Me.tlpMain.SetRowSpan(Me.tcTabControl, 32)
        Me.tcTabControl.SelectedIndex = 0
        Me.tcTabControl.Size = New System.Drawing.Size(225, 875)
        Me.tcTabControl.TabIndex = 1
        '
        'tabSource
        '
        Me.tabSource.Controls.Add(Me.tlpSource)
        Me.tabSource.Location = New System.Drawing.Point(4, 27)
        Me.tabSource.Name = "tabSource"
        Me.tabSource.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSource.Size = New System.Drawing.Size(217, 844)
        Me.tabSource.TabIndex = 0
        Me.tabSource.Text = "Source Code"
        Me.tabSource.UseVisualStyleBackColor = True
        '
        'tlpSource
        '
        Me.tlpSource.CausesValidation = False
        Me.tlpSource.ColumnCount = 10
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSource.Controls.Add(Me.lboSource, 0, 0)
        Me.tlpSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSource.Location = New System.Drawing.Point(3, 3)
        Me.tlpSource.Name = "tlpSource"
        Me.tlpSource.RowCount = 20
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpSource.Size = New System.Drawing.Size(211, 838)
        Me.tlpSource.TabIndex = 0
        '
        'lboSource
        '
        Me.tlpSource.SetColumnSpan(Me.lboSource, 10)
        Me.lboSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lboSource.FormattingEnabled = True
        Me.lboSource.ItemHeight = 18
        Me.lboSource.Location = New System.Drawing.Point(3, 3)
        Me.lboSource.Name = "lboSource"
        Me.tlpSource.SetRowSpan(Me.lboSource, 20)
        Me.lboSource.Size = New System.Drawing.Size(205, 832)
        Me.lboSource.TabIndex = 0
        '
        'tabLibrary
        '
        Me.tabLibrary.Controls.Add(Me.tlpLibrary)
        Me.tabLibrary.Location = New System.Drawing.Point(4, 27)
        Me.tabLibrary.Name = "tabLibrary"
        Me.tabLibrary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLibrary.Size = New System.Drawing.Size(217, 844)
        Me.tabLibrary.TabIndex = 1
        Me.tabLibrary.Text = "My Library"
        Me.tabLibrary.UseVisualStyleBackColor = True
        '
        'tlpLibrary
        '
        Me.tlpLibrary.CausesValidation = False
        Me.tlpLibrary.ColumnCount = 10
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.113636!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLibrary.Controls.Add(Me.tvLibrary, 0, 0)
        Me.tlpLibrary.Controls.Add(Me.pnlPreview, 0, 19)
        Me.tlpLibrary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLibrary.Location = New System.Drawing.Point(3, 3)
        Me.tlpLibrary.Name = "tlpLibrary"
        Me.tlpLibrary.RowCount = 20
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpLibrary.Size = New System.Drawing.Size(211, 838)
        Me.tlpLibrary.TabIndex = 0
        '
        'tvLibrary
        '
        Me.tlpLibrary.SetColumnSpan(Me.tvLibrary, 10)
        Me.tvLibrary.ContextMenuStrip = Me.LibraryContextMenu
        Me.tvLibrary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvLibrary.Location = New System.Drawing.Point(3, 3)
        Me.tvLibrary.Name = "tvLibrary"
        TreeNode1.Name = "tn4BitAdder"
        TreeNode1.Text = "4 Bit Adder"
        TreeNode2.Name = "tn8BitAdder"
        TreeNode2.Text = "8 Bit Adder"
        TreeNode3.Name = "tn16BitAdder"
        TreeNode3.Text = "16 Bit Adder"
        TreeNode4.Name = "tnAdders"
        TreeNode4.Text = "Adders"
        TreeNode5.Name = "tnRSFF"
        TreeNode5.Text = "R-S Flip Flop"
        TreeNode6.Name = "tnJKFF"
        TreeNode6.Text = "J-K Flip Flop"
        TreeNode7.Name = "tnDFF"
        TreeNode7.Text = "D Flip Flop"
        TreeNode8.Name = "tnTFF"
        TreeNode8.Text = "T Flip Flop"
        TreeNode9.Name = "tnFlipFlops"
        TreeNode9.Text = "Flip Flops"
        Me.tvLibrary.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode9})
        Me.tlpLibrary.SetRowSpan(Me.tvLibrary, 19)
        Me.tvLibrary.Size = New System.Drawing.Size(205, 773)
        Me.tvLibrary.TabIndex = 0
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
        'pnlPreview
        '
        Me.tlpLibrary.SetColumnSpan(Me.pnlPreview, 10)
        Me.pnlPreview.Controls.Add(Me.btnPreview)
        Me.pnlPreview.Location = New System.Drawing.Point(3, 782)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(170, 42)
        Me.pnlPreview.TabIndex = 1
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(3, 6)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(164, 33)
        Me.btnPreview.TabIndex = 0
        Me.btnPreview.Text = "Preview Image"
        Me.btnPreview.UseVisualStyleBackColor = True
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
        'FunctionContextMenu
        '
        Me.FunctionContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.FunctionContextMenu.Name = "FunctionContextMenu"
        Me.FunctionContextMenu.Size = New System.Drawing.Size(162, 48)
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
        Me.tabSource.ResumeLayout(False)
        Me.tlpSource.ResumeLayout(False)
        Me.tabLibrary.ResumeLayout(False)
        Me.tlpLibrary.ResumeLayout(False)
        Me.LibraryContextMenu.ResumeLayout(False)
        Me.pnlPreview.ResumeLayout(False)
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
    Friend WithEvents tabSource As System.Windows.Forms.TabPage
    Friend WithEvents tabLibrary As System.Windows.Forms.TabPage
    Friend WithEvents tlpLibrary As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tvLibrary As System.Windows.Forms.TreeView
    Friend WithEvents pnlPreview As System.Windows.Forms.Panel
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents miDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCollapse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExpand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpSource As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lboSource As System.Windows.Forms.ListBox
    Friend WithEvents pnlDisplay As System.Windows.Forms.Panel
    Friend WithEvents TabbedViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunctionContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
