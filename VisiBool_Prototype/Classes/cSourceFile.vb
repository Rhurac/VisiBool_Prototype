''' <summary>
''' An instance of a user-created VisiBoole source code file
''' </summary>
Public Class cSourceFile

    ''' <summary>
    ''' The name of this VisiBoole source code file
    ''' </summary>
    Public Property Name As String

    ''' <summary>
    ''' The content of this VisiBoole source code file, displayed in the Editor
    ''' </summary>
    Public Property Text As String

    ''' <summary>
    ''' Contructs an instance of cSourceFile
    ''' </summary>
    ''' <param name="pName">The name of the source code file to be created</param>
    Public Sub New(pName As String, Optional ByVal pContent As String = "")

        Me.Name = pName

        If String.IsNullOrEmpty(pContent) Then
            Text = "This is simulated content for Source File: '" & Me.Name & "'"
        Else
            Text = pContent
        End If


    End Sub

End Class
