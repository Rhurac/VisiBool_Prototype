''' <summary>
''' Global variables accessible by all components of the application
''' </summary>
''' <remarks>These are currently just hard-coded values</remarks>
Public Class cGlobals

    ''' <summary>
    ''' Enumeration representing names of VisiBoole functions
    ''' </summary>
    Enum VFunctions
        COUNTER
        DECODER
        SEVENSEG
    End Enum

    ''' <summary>
    ''' Returns function output corresponding to the VFunction enum
    ''' </summary>
    ''' <param name="pFunc">VFunction enum to fetch output for</param>
    ''' <returns>Output corresponding to VFunction enum</returns>
    Public Shared Function GetFuncOutput(pFunc As VFunctions) As String

        Dim output As String

        Select Case pFunc
            Case VFunctions.COUNTER
                output = My.Resources.CounterOutput
            Case VFunctions.DECODER
                output = My.Resources.DecoderMuxOutput
            Case VFunctions.SEVENSEG
                output = My.Resources.SevenSegOutput
            Case Else
                output = ""
        End Select

        Return output

    End Function

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
        tmr.Enabled = True

    End Sub

End Class
