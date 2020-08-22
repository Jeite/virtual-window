Public Class Shutdown

    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Desktop.Close()
            Login.Close()
            Form1.Close()
            Me.Close()

        End If
    End Sub
End Class