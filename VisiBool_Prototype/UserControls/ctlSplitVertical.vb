''' <summary>
''' Main display for viewing in split vertical panes
''' </summary>
Public Class ctlSplitVertical
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

    Public Sub DisplayOutput() Implements IDisplay.DisplayOutput

    End Sub

End Class
