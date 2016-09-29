''' <summary>
''' Dialog for displaying the content of the given function
''' </summary>
''' <remarks></remarks>
Public Class dlgFunctionContent

    ''' <summary>
    ''' Constructs a new instance of dlgFunctionContent
    ''' </summary>
    Public Sub New(pFunc As cVisiBooleFunction)

        InitializeComponent()

        Me.Text = pFunc.Name
        Me.rteContent.Text = pFunc.Text
        cGlobals.FadeIn(Me)

    End Sub

End Class