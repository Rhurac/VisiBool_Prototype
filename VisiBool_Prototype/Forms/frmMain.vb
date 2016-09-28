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
    Private _myFunctions As New SortedDictionary(Of String, VisiBooleFunction)

    ''' <summary>
    ''' ContextMenu for the selected function in MyFunctions listbox
    ''' </summary>
    ''' <remarks></remarks>
    Private _listboxContextMenu As ContextMenuStrip

    ''' <summary>
    ''' Binding source for the ListBox control
    ''' </summary>
    Private _bindingSource As BindingSource

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

        InitializeBindings()

    End Sub

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
    ''' Sets up databindings for VisiBoole functions on form startup
    ''' </summary>
    Private Sub InitializeBindings()

        lboSource.DisplayMember = "Key"
        lboSource.ValueMember = "Value"

        _bindingSource = New BindingSource(_myFunctions, Nothing)
        lboSource.DataSource = _bindingSource

        _listboxContextMenu = FunctionContextMenu

    End Sub

    ''' <summary>
    ''' Refreshes the databindings for the ListBox control
    ''' </summary>
    Private Sub RefreshBindings()

        _bindingSource = New BindingSource(_myFunctions, Nothing)
        lboSource.DataSource = _bindingSource
        lboSource.Refresh()

    End Sub

    ''' <summary>
    ''' Loads initial content into Visiboole functions on form load
    ''' </summary>
    Private Sub InitializeVFunctions()

        Dim content As String = My.Resources.counter
        _myFunctions.Add("Function Counter()", New VisiBooleFunction("Function Counter()", content))

        content = My.Resources.decoder_mux
        _myFunctions.Add("Function DecoderMux()", New VisiBooleFunction("Function DecoderMux()", content))

        content = My.Resources.seven_seg_display
        _myFunctions.Add("Function SevenSegment()", New VisiBooleFunction("Function SevenSegment()", content))

    End Sub

    ''' <summary>
    ''' Display the Split Horizontal UserControl
    ''' </summary>
    Private Sub SplitHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitHorizontalToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Horizontal" Then Exit Sub

        LoadUserControl(New ctlSplitHorizontal)

    End Sub

    ''' <summary>
    ''' Display the Split Vertical UserControl
    ''' </summary>
    Private Sub SplitVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitVerticalToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Vertical" Then Exit Sub

        LoadUserControl(New ctlSplitVertical)

    End Sub

    ''' <summary>
    ''' Display the Tabbed View UserControl
    ''' </summary>
    Private Sub TabbedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabbedViewToolStripMenuItem.Click

        If CType(_currentDisplay, UserControl).Tag = "Tabbed" Then Exit Sub

        LoadUserControl(New ctlSplitTabbed)

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Dim dlg As New dlgFunctionName

        Me.Opacity = 0.7
        If dlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Me.Opacity = 1.0
            Exit Sub
        End If
        Me.Opacity = 1.0

        _myFunctions.Add(dlg.FunctionName, New VisiBooleFunction(dlg.FunctionName))
        RefreshBindings()

    End Sub

    ''' <summary>
    ''' Open a VisiBoole file and load it in the editor
    ''' </summary>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Filter = "VisiBoole File|*.vbi"
        openFileDialog.Title = "Open File"

        openFileDialog.ShowDialog()

        _currentDisplay.DisplayInput(cGlobals.gEditorInput)

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
    Private Sub lboSource_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lboSource.MouseDoubleClick

        Dim index As Integer = CType(sender, ListBox).IndexFromPoint(e.Location)
        If index <> ListBox.NoMatches Then
            Dim dlg As New dlgFunctionContent(CType(sender, ListBox).SelectedValue)
            dlg.Show()
        End If

    End Sub

    ''' <summary>
    ''' Opens the context menu for the selected listbox item
    ''' </summary>
    Private Sub lboSource_MouseDown(sender As Object, e As MouseEventArgs) Handles lboSource.MouseDown

        If Not e.Button = Windows.Forms.MouseButtons.Right Then Exit Sub

        Dim index As Integer = lboSource.IndexFromPoint(e.Location)
        If index <> ListBox.NoMatches Then

            If index = lboSource.SelectedIndex Then
                _listboxContextMenu.Show(Cursor.Position)
            End If

        End If

    End Sub

    ''' <summary>
    ''' Display the content of the selected VisiBoole function in the Editor
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        _currentDisplay.AppendInput(lboSource.SelectedValue.Text)

    End Sub

End Class
