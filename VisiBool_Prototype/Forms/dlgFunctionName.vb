''' <summary>
''' Displays a dialog for choosing the name of a user-created VisiBoole function
''' </summary>
Public Class dlgFunctionName

    ''' <summary>
    ''' The name of the property to be created
    ''' </summary>
    Public Property FunctionName As String

    ''' <summary>
    ''' Constructs an instance of dlgFunctionName
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        cGlobals.FadeIn(Me)

    End Sub

    ''' <summary>
    ''' Initializes the dialog with a default function name
    ''' </summary>
    Private Sub dlgFunctionName_Load(sender As Object, e As EventArgs) Handles Me.Load

        FunctionName = "NewFunc()"
        txtFunctionName.Text = FunctionName

        txtFunctionName.SelectionStart = 0
        txtFunctionName.SelectionLength = FunctionName.Length
        txtFunctionName.Focus()

    End Sub

    ''' <summary>
    ''' Closes the form in state DialogResult.OK
    ''' </summary>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

        cGlobals.FadeOut(Me)
        Me.Close()

    End Sub

    ''' <summary>
    ''' Closes the form in state DialogResult.Cancel
    ''' </summary>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        cGlobals.FadeOut(Me)
        Me.Close()

    End Sub

    ''' <summary>
    ''' Stores the selected Function Name
    ''' </summary>
    ''' <remarks>Assumes that the Validating event passed the check</remarks>
    Private Sub txtFunctionName_Validated(sender As Object, e As EventArgs) Handles txtFunctionName.Validated

        FunctionName = sender.Text.Trim()

    End Sub

End Class