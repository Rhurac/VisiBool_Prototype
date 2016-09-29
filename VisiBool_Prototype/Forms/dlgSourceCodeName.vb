''' <summary>
''' Displays a dialog for choosing the name of a user-created VisiBoole source code file
''' </summary>
Public Class dlgSourceCodeName

    ''' <summary>
    ''' The name of the property to be created
    ''' </summary>
    Public Property SourceFileName As String

    ''' <summary>
    ''' Constructs an instance of dlgSourceCodeName
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        cGlobals.FadeIn(Me)

    End Sub

    ''' <summary>
    ''' Initializes the dialog with a default source code file name
    ''' </summary>
    Private Sub dlgSourceCodeName_Load(sender As Object, e As EventArgs) Handles Me.Load

        SourceFileName = "New Sample Source Code File"
        txtSourceFileName.Text = SourceFileName

        txtSourceFileName.SelectionStart = 0
        txtSourceFileName.SelectionLength = SourceFileName.Length
        txtSourceFileName.Focus()

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
    ''' Stores the selected source code file name
    ''' </summary>
    ''' <remarks>Assumes that the Validating event passed the check</remarks>
    Private Sub txtFunctionName_Validated(sender As Object, e As EventArgs) Handles txtSourceFileName.Validated

        SourceFileName = sender.Text.Trim()

    End Sub

End Class