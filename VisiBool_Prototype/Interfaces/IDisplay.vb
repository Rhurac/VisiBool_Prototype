''' <summary>
''' Shared attributes amongst the UserControl displays
''' </summary>
Public Interface IDisplay

    Function GetInput() As String

    Sub DisplayInput(pInput As String)

    Sub AppendInput(pInput As String)

    Sub DisplayOutput()

    Sub DisplayIndependentVars()

End Interface
