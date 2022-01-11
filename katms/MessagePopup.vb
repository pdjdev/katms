Public Class MessagePopup
    Dim fadedelta As Double = 0.01

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Opacity - fadedelta > 0 Then
            Opacity -= fadedelta
        Else
            Close()
        End If
    End Sub

    Private Sub MessagePopup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        Refresh()
    End Sub

    Private Sub MessagePopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()

        Opacity = 0.8
        Threading.Thread.Sleep(300)

        Timer1.Start()
    End Sub
End Class