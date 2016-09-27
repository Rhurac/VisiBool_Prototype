''' <summary>
''' Global variables accessible by all components of the application
''' </summary>
''' <remarks>These are currently just hard-coded values</remarks>
Public Class cGlobals

    ''' <summary>
    ''' Generic Lorem Ipsum text 
    ''' </summary>
    ''' <remarks>Used to simulate pushing text to the editor control of the current display</remarks>
    Public Shared gEditorInput As String = "Lorem ipsum dolor sit amet, vitae eu tellus dolor eleifend nascetur sed, commodo etiam varius, eu varius risus mattis condimentum nam, aenean sollicitudin ut praesent non. Suscipit orci vitae erat nullam at, sed gravida lectus rutrum, diam at lectus malesuada lobortis commodo fugit. Convallis bibendum ridiculus eros ut, feugiat class ultrices vestibulum nullam vehicula, volutpat mauris eros felis dolor sagittis, wisi quam quisque orci sapien, eu rhoncus. Vitae morbi libero. Massa proin vel ut molestie, bibendum ultrices felis vulputate lobortis pulvinar, et lorem turpis imperdiet morbi egestas sed. Vestibulum sagittis vivamus, etiam tristique sit nisl vitae varius, interdum magna amet vivamus. Praesent purus nulla, massa eu nullam ac mauris nunc, sed pulvinar tortor, quis consequat feugiat. Tellus vivamus, sollicitudin purus, consequat mauris interdum tellus ultrices morbi."

    ''' <summary>
    ''' Fade-In animation for the given System.Windows.Form
    ''' </summary>
    ''' <param name="pForm">The System.Windows.Form to fade in</param>
    Public Shared Sub FadeIn(pForm As Form)

        If pForm Is Nothing Then Exit Sub

        pForm.Opacity = 0

        Dim tmr As New System.Windows.Forms.Timer()
        tmr.Interval = 10
        AddHandler tmr.Tick, Sub()
                                 pForm.Opacity += 0.05
                                 If pForm.Opacity >= 1.0 Then tmr.Enabled = False
                             End Sub

        tmr.Enabled = True

    End Sub

    ''' <summary>
    ''' Fade-Out animation for the given System.Windows.Form
    ''' </summary>
    ''' <param name="pForm">The System.Windows.Form to fade out</param>
    Public Shared Sub FadeOut(pForm As Form)

        If pForm Is Nothing Then Exit Sub

        pForm.Opacity = 1.0

        Dim tmr As New System.Windows.Forms.Timer()
        tmr.Interval = 10
        AddHandler tmr.Tick, Sub()
                                 pForm.Opacity -= 0.05
                                 If pForm.Opacity <= 0 Then tmr.Enabled = False
                             End Sub
    End Sub

End Class
