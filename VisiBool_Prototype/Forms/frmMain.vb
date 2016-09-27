''' <summary>
''' Main menu of the application
''' </summary>
Public Class frmMain

    ''' <summary>
    ''' The currently displayed UserControl
    ''' </summary>
    Private _currentDisplay As IDisplay

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

        _currentDisplay.DisplayInput("<Simulation of new file created. Added new file to 'My Source Code'>")

        Dim dlg As New dlgFunctionName

        Me.Opacity = 0.7
        If dlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Me.Opacity = 1.0
            Exit Sub
        End If
        Me.Opacity = 1.0

        lboSource.Items.Add(dlg.FunctionName)

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
End Class
