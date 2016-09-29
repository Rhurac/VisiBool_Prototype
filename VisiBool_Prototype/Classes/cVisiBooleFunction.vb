''' <summary>
''' An instance of a reusable user-created function in VisiBoole
''' </summary>
''' <remarks></remarks>
Public Class cVisiBooleFunction

    ''' <summary>
    ''' The name of this VisiBoole Function
    ''' </summary>
    Public Property Name As String

    ''' <summary>
    ''' The content of this VisiBoole function
    ''' </summary>
    Public Property Text As String

    ''' <summary>
    ''' Contructs an instance of cVisiBooleFunction
    ''' </summary>
    ''' <param name="pName">The name of the function to be created</param>
    Public Sub New(pName As String, Optional ByVal pContent As String = "")

        Me.Name = pName

        If String.IsNullOrEmpty(pContent) Then
            Text = "This is simulated content for '" & Me.Name & "'"
        Else
            Text = pContent
        End If


    End Sub

End Class
