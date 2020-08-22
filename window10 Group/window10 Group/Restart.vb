Public Class Restart

    Private Sub Restart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)

        If ProgressBar1.Value = 25 Then
            Label1.Text = "loading"

        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Restarting"
            Timer1.Stop()
            Form1.Show()
            Desktop.Close()
            Shutdown.Close()
            Login.Close()
            Me.Close()


        End If
    End Sub
End Class