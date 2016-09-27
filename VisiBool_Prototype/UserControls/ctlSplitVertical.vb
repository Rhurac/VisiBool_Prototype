Public Class ctlSplitVertical
    Implements IDisplay

    ''' <summary>
    ''' Displays input of type System.String in child Editor RichTextBox Control
    ''' </summary>
    ''' <param name="pInput">Input of type System.String to be displayed in the editor</param>
    Public Sub DisplayInput(pInput As String) Implements IDisplay.DisplayInput

        If pInput Is Nothing Then
            rteEditor.Text = ""
        Else
            rteEditor.Text = pInput
        End If

    End Sub

    Public Property Editor As RichTextBox Implements IDisplay.Editor

End Class
