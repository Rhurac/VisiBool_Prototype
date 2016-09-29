Imports VisiBool_Prototype.cGlobals.VFunctions

''' <summary>
''' Main display for viewing in split vertical panes
''' </summary>
Public Class ctlSplitVertical
    Implements IDisplay

    ''' <summary>
    ''' Constructs an instance of ctlSplitVertical
    ''' </summary>
    ''' <param name="pEditorInput">optional Text to be displayed in Editor</param>
    Public Sub New(Optional ByVal pEditorInput = "")

        InitializeComponent()

        DisplayInput(pEditorInput)

    End Sub

    ''' <summary>
    ''' Returns the content in the editor
    ''' </summary>
    ''' <returns>Contents of the editor of type System.String</returns>
    Public Function GetInput() As String Implements IDisplay.GetInput

        Return rteEditor.Text.Trim()

    End Function

    ''' <summary>
    ''' Displays input in the editor
    ''' </summary>
    ''' <param name="pInput">The input to be displayed in the editor</param>
    Public Sub DisplayInput(pInput As String) Implements IDisplay.DisplayInput

        If String.IsNullOrEmpty(pInput) Then Exit Sub

        rteEditor.Text = pInput

    End Sub

    ''' <summary>
    ''' Appends input to the editor
    ''' </summary>
    ''' <param name="pInput">The input to be appended to the editor</param>
    Public Sub AppendInput(pInput As String) Implements IDisplay.AppendInput

        If String.IsNullOrEmpty(pInput) Then Exit Sub

        rteEditor.Text += pInput

    End Sub

    ''' <summary>
    ''' Displays hard-coded content in the output RichTextBox
    ''' </summary>
    ''' <remarks>The output printed here does not reflect the actual input in the editor yet</remarks>
    Public Sub DisplayOutput() Implements IDisplay.DisplayOutput

        rteOutput.AppendText(cGlobals.GetFuncOutput(COUNTER))

    End Sub

    ''' <summary>
    ''' Displays the independent variables on Run
    ''' </summary>
    Public Sub DisplayIndependentVars() Implements IDisplay.DisplayIndependentVars

        txtIndependentVars.Text = "C0 C1 C2 C3 D"

    End Sub

    ''' <summary>
    ''' Displays hard-coded content in the output RichTextBox
    ''' </summary>
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        DisplayOutput()

        DisplayIndependentVars()

    End Sub

    ''' <summary>
    ''' Clears the editor of text
    ''' </summary>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        rteEditor.Text = ""

    End Sub

    ''' <summary>
    ''' Simulates updating the selected source code file with the editor content
    ''' </summary>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MessageBox.Show("This button updates the source code file that you are working on with the text that is currently displayed in the editor. It is currently disabled so as not to overwrite the Help information set by default.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    ''' <summary>
    ''' Simulates a tick of the clock
    ''' </summary>
    Private Sub btnTick_Click(sender As Object, e As EventArgs) Handles btnTick.Click

        MessageBox.Show("This button ticks the output. You may increase the number of ticks per click by adjusting the up-down control to the left.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

End Class
