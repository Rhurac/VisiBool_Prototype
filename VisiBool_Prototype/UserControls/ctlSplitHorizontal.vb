Imports VisiBool_Prototype.cGlobals.VFunctions

''' <summary>
''' Main display for viewing in split horizontal panes
''' </summary>
Public Class ctlSplitHorizontal
    Implements IDisplay

    Public Property Editor As RichTextBox Implements IDisplay.Editor

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
    ''' Displays hard-coded content in the output RichTextBox
    ''' </summary>
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        DisplayOutput()

    End Sub

End Class
