''' <summary>
''' Shared attributes amongst the UserControl displays
''' </summary>
Public Interface IDisplay

    Property Editor As RichTextBox

    Sub DisplayInput(pInput As String)

    Sub AppendInput(pInput As String)

    Sub DisplayOutput()

End Interface
