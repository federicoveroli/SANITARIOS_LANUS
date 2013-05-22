Public Class frmSplash
    Dim ciclo As Integer
    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ciclo = 0
        TimerSplash.Start()
    End Sub

    Private Sub TimerSplash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSplash.Tick
        ciclo += 30
        If ciclo > 500 Then
            TimerSplash.Stop()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub
End Class