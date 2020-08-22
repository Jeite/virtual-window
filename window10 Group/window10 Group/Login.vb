Public Class Login


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = "1234" Then



            Desktop.Show()
            Me.Close()


        End If
    End Sub




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        AcceptButton = OK
        Panel1.Hide()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("hh mm ss tt")
        Label3.Text = Date.Now.ToString("dddd")
        Label2.Text = Date.Now.Date
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True
    End Sub

      Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Restart.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shutdown.Show()

    End Sub


End Class
