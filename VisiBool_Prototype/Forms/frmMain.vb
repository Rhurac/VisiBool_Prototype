Imports System.IO

''' <summary>
''' Main menu of the application
''' </summary>
Public Class frmMain

    ''' <summary>
    ''' The currently displayed UserControl
    ''' </summary>
    Private _currentDisplay As IDisplay

    ''' <summary>
    ''' User-created VisiBoole Functions
    ''' </summary>
    Private _myFunctions As New SortedDictionary(Of String, cVisiBooleFunction)

    ''' <summary>
    ''' User-created VisiBoole source code files
    ''' </summary>
    ''' <remarks></remarks>
    Private _mySourceCodes As New SortedDictionary(Of String, cSourceFile)

    ''' <summary>
    ''' ContextMenu for the selected function in MyFunctions listbox
    ''' </summary>
    ''' <remarks></remarks>
    Private _listboxContextMenu As ContextMenuStrip

    ''' <summary>
    ''' Binding source for the user's visiboole functions
    ''' </summary>
    Private _myLibraryBindingSource As BindingSource

    ''' <summary>
    ''' Binding source for the user's source code files
    ''' </summary>
    ''' <remarks></remarks>
    Private _mySourceCodeBindingSource As BindingSource

    ''' <summary>
    ''' Constructs an instance of frmMain
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        cGlobals.FadeIn(Me)

    End Sub

    ''' <summary>
    ''' Initialize the form
    ''' </summary>
    Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadUserControl(New ctlSplitHorizontal)

        InitializeVFunctions()

        InitializeVSourceCodes()

        InitializeBindings()

    End Sub

#Region "Helper Functions"

    ''' <summary>
    ''' Replace the current display with the given UserControl
    ''' </summary>
    ''' <param name="pControl">The UserControl to replace the current display</param>
    Private Sub LoadUserControl(pControl As UserControl)

        If pControl Is Nothing Then Exit Sub

        pnlDisplay.Controls.Remove(_currentDisplay)

        _currentDisplay = pControl

        pnlDisplay.Controls.Add(_currentDisplay)

        CType(_currentDisplay, UserControl).Dock = DockStyle.Fill
        CType(_currentDisplay, UserControl).Show()

    End Sub

    ''' <summary>
    ''' Loads initial content into Visiboole functions on form load
    ''' </summary>
    Private Sub InitializeVFunctions()

        Dim content As String = My.Resources.counter
        _myFunctions.Add("Function Counter()", New cVisiBooleFunction("Function Counter()", content))

        content = My.Resources.decoder_mux
        _myFunctions.Add("Function DecoderMux()", New cVisiBooleFunction("Function DecoderMux()", content))

        content = My.Resources.seven_seg_display
        _myFunctions.Add("Function SevenSegment()", New cVisiBooleFunction("Function SevenSegment()", content))

    End Sub

    ''' <summary>
    ''' Loads initial content into VisiBoole Source Codes on form load
    ''' </summary>
    Private Sub InitializeVSourceCodes()

        Dim content As String = My.Resources.MySourceCodeExample
        _mySourceCodes.Add("MySourceCodeExample", New cSourceFile("MySourceCodeExample", content))

    End Sub

    ''' <summary>
    ''' Attaches databindings for ListBox controls on form load
    ''' </summary>
    Private Sub InitializeBindings()

        AttachLibraryBindings()

        AttachSourceCodeBindings()

    End Sub

    ''' <summary>
    ''' Sets up databindings for VisiBoole functions on form load
    ''' </summary>
    Private Sub AttachLibraryBindings()

        lboLibrary.DisplayMember = "Key"
        lboLibrary.ValueMember = "Value"

        _myLibraryBindingSource = New BindingSource(_myFunctions, Nothing)
        lboLibrary.DataSource = _myLibraryBindingSource

        _listboxContextMenu = FunctionContextMenu

    End Sub

    ''' <summary>
    ''' Sets up databindings for VisiBoole source codes on form load
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AttachSourceCodeBindings()

        lboSource.DisplayMember = "Key"
        lboSource.ValueMember = "Value"

        _mySourceCodeBindingSource = New BindingSource(_mySourceCodes, Nothing)
        lboSource.DataSource = _mySourceCodeBindingSource

    End Sub

    ''' <summary>
    ''' Refreshes the databindings for the library ListBox
    ''' </summary>
    Private Sub RefreshLibraryBindings()

        _myLibraryBindingSource = New BindingSource(_myFunctions, Nothing)
        lboLibrary.DataSource = _myLibraryBindingSource
        lboLibrary.Refresh()

    End Sub

    ''' <summary>
    ''' Refreshes the databindings for the source codes ListBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshSourceCodeBindings()

        _mySourceCodeBindingSource = New BindingSource(_mySourceCodes, Nothing)
        lboSource.DataSource = _mySourceCodeBindingSource
        lboSource.Refresh()

    End Sub

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Display the Split Horizontal UserControl
    ''' </summary>
    Private Sub SplitHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitHorizontalToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Horizontal" Then Exit Sub

        LoadUserControl(New ctlSplitHorizontal(_currentDisplay.GetInput()))

    End Sub

    ''' <summary>
    ''' Display the Split Vertical UserControl
    ''' </summary>
    Private Sub SplitVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitVerticalToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Vertical" Then Exit Sub

        LoadUserControl(New ctlSplitVertical(_currentDisplay.GetInput()))

    End Sub

    ''' <summary>
    ''' Display the Tabbed View UserControl
    ''' </summary>
    Private Sub TabbedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabbedViewToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Tabbed" Then Exit Sub

        LoadUserControl(New ctlSplitTabbed(_currentDisplay.GetInput()))

    End Sub

    ''' <summary>
    ''' Simulates creating a new project, returning all controls to default state
    ''' </summary>
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        MessageBox.Show("Selecting new file here would create an entirely new project, with no functions and a default starting source code file", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    ''' <summary>
    ''' Open a VisiBoole file and load it in the editor
    ''' </summary>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Filter = "VisiBoole File|*.vbi"
        openFileDialog.Title = "Open File"

        openFileDialog.ShowDialog()

    End Sub

    ''' <summary>
    ''' Open SaveFileDialog and save a valid VisiBoole file
    ''' </summary>
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim saveFileDialog As New SaveFileDialog

        saveFileDialog.Filter = "VisiBoole File|*.vbi"
        saveFileDialog.Title = "Save File"

        saveFileDialog.ShowDialog()

        If Not String.IsNullOrEmpty(saveFileDialog.FileName) Then
            MessageBox.Show("File " & saveFileDialog.FileName & " was saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    ''' <summary>
    ''' Exit the application 
    ''' </summary>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Opens a dialog displaying the content of the function
    ''' </summary>
    Private Sub lboSource_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lboLibrary.MouseDoubleClick

        Dim index As Integer = CType(sender, ListBox).IndexFromPoint(e.Location)
        If index <> ListBox.NoMatches Then
            Dim dlg As New dlgFunctionContent(CType(sender, ListBox).SelectedValue)
            dlg.Show()
        End If

    End Sub

    ''' <summary>
    ''' Opens the context menu for the selected listbox item
    ''' </summary>
    Private Sub lboSource_MouseDown(sender As Object, e As MouseEventArgs) Handles lboLibrary.MouseDown

        If Not e.Button = Windows.Forms.MouseButtons.Right Then Exit Sub

        Dim index As Integer = lboLibrary.IndexFromPoint(e.Location)
        If index <> ListBox.NoMatches Then

            If index = lboLibrary.SelectedIndex Then
                _listboxContextMenu.Show(Cursor.Position)
            End If

        End If

    End Sub

    ''' <summary>
    ''' Display the content of the selected VisiBoole function in the Editor
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        _currentDisplay.AppendInput(lboLibrary.SelectedValue.Text)

    End Sub

    ''' <summary>
    ''' Add a new VisiBoole Function to My Library
    ''' </summary>
    Private Sub btnAddFunc_Click(sender As Object, e As EventArgs) Handles btnAddFunc.Click

        Dim dlg As New dlgFunctionName

        Me.Opacity = 0.7
        If dlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Me.Opacity = 1.0
            Exit Sub
        End If
        Me.Opacity = 1.0


        If _myFunctions.ContainsKey(dlg.FunctionName) Then
            MessageBox.Show("A VisiBoole Function with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        _myFunctions.Add(dlg.FunctionName, New cVisiBooleFunction(dlg.FunctionName))
        RefreshLibraryBindings()

    End Sub

    ''' <summary>
    ''' Remove a VisiBoole Function from My Library
    ''' </summary>
    Private Sub btnDelFunc_Click(sender As Object, e As EventArgs) Handles btnDelFunc.Click

        If DialogResult.No = MessageBox.Show("This will irreversably destroy this item - do you wish to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then Exit Sub

        _myFunctions.Remove(lboLibrary.SelectedValue.Name)

        RefreshLibraryBindings()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddSource_Click(sender As Object, e As EventArgs) Handles btnAddSource.Click

        Dim dlg As New dlgSourceCodeName

        Me.Opacity = 0.7
        If dlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Me.Opacity = 1.0
            Exit Sub
        End If
        Me.Opacity = 1.0

        If _mySourceCodes.ContainsKey(dlg.SourceFileName) Then
            MessageBox.Show("A VisiBoole Source Code file with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        _mySourceCodes.Add(dlg.SourceFileName, New cSourceFile(dlg.SourceFileName))
        RefreshSourceCodeBindings()

    End Sub

    ''' <summary>
    ''' Simulates the deletion of the selected source code file
    ''' </summary>
    Private Sub btnDelSource_Click(sender As Object, e As EventArgs) Handles btnDelSource.Click

        If DialogResult.No = MessageBox.Show("This will irreversably destroy this item - do you wish to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then Exit Sub

        _mySourceCodes.Remove(lboSource.SelectedValue.Name)

        RefreshSourceCodeBindings()

    End Sub

    ''' <summary>
    ''' Displays the content of the selected source code file in the editor
    ''' </summary>
    Private Sub lboSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboSource.SelectedIndexChanged

        _currentDisplay.DisplayInput(sender.SelectedValue.Text)

    End Sub

#End Region

End Class
