Public Class Desktop

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Panel1.Hide()

        Panel2.Hide()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("hh:mm:tt")

        Label2.Text = Date.Now.Date
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        If Panel1.Visible = False Then
            Panel1.Visible = True
            Panel1.BringToFront()

        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.Visible = True
        Button1.Show()
        Button2.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Restart.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shutdown.Show()


    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Panel1.Hide()

    End Sub


 
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Process.Start("D:\sawiro")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("c:\")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("c:\")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("Control Panel\Network and Internet\Network and Sharing Center")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("Control Panel\Network and Internet\Network and Sharing Center")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("control.exe")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Process.Start("control.exe")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Process.Start("C:\Program Files\NetBeans 8.2\bin\netbeans64.exe")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("C:\Program Files\Adobe\Adobe Premiere Pro CC 2019\Adobe Premiere Pro.exe")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("C:\Program Files\Adobe\Adobe Premiere Pro CC 2019\Adobe Premiere Pro.exe")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Process.Start("C:\Program Files\Adobe\Adobe Photoshop CC 2019\Photoshop.exe")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("C:\Program Files\Adobe\Adobe Photoshop CC 2019\Photoshop.exe")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Process.Start("C:\Program Files\Adobe\Adobe Audition CC 2019\Adobe Audition CC.exe")

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Process.Start("C:\Program Files (x86)\Notepad++\notepad++.exe")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Process.Start("C:\Program Files\Adobe\Adobe Audition CC 2019\Adobe Audition CC.exe")

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Process.Start("C:\Program Files (x86)\Notepad++\notepad++.exe")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Process.Start("C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe")
    End Sub


    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Process.Start("C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe")
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Process.Start("C:\Program Files\Adobe\Adobe Audition CC 2019\Adobe Audition CC.exe")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Process.Start("C:\Program Files\Adobe\Adobe Photoshop CC 2019\Photoshop.exe")
    End Sub


    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Process.Start("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Process.Start("Word 2013.exe ")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        calculator.Show()
        'Process.Start("calculator.exe")
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs)
        calculator.Show()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Process.Start("C:\Program Files\NetBeans 8.2\bin\netbeans64.exe")
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Process.Start("C:\Program Files\NetBeans 8.2\bin\netbeans64.exe")
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Process.Start("Recycle Bin.exe")
    End Sub

    Private Sub FududeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FududeeToolStripMenuItem.Click
        Me.Refresh()

    End Sub


    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Notepad++\notepad++.exe")
    End Sub

    Private Sub MicrosoftAccessDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftAccessDatabaseToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE")
    End Sub

    Private Sub MicrosoftExcelWorksheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftExcelWorksheetToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE")
    End Sub

    Private Sub MicrosoftPowerPointPresentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftPowerPointPresentationToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE")
    End Sub

    Private Sub MicrosoftPublisherDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftPublisherDocumentToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\MSPUB.EXE")
    End Sub

    Private Sub MicrosoftProjectDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftProjectDocumentToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\WINPROJ.EXE")
    End Sub

    Private Sub MicrosoftVisioDrawingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftVisioDrawingToolStripMenuItem.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\VISIO.EXE")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Process.Start("%windir%\System32\Control.exe")
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Process.Start("C:\Program Files\PDF Reader for Windows 10\PDFReader.exe")
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE")

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE")
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Process.Start("C:\Program Files (x86)\AOMEI Backupper\Backupper.exe")
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Process.Start("C:\Program Files (x86)\AOMEI Backupper\Backupper.exe")
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Java")

    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Java")
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\resources")
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\resources")
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\statistics assignment")
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\statistics assignment")
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Multimedia asignment 1")
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Multimedia asignment 1")
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Sports materila")
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Process.Start("C:\Users\C.Qani Jeyte\Desktop\Sports materila")
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Process.Start("C:\Users\C.Qani Jeyte\AppData\Roaming\Telegram Desktop\Telegram.exe")
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Process.Start("C:\Users\C.Qani Jeyte\AppData\Roaming\Telegram Desktop\Telegram.exe")
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Process.Start("C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe")
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Process.Start("C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe")
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Process.Start("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe")
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Process.Start("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe")
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        Process.Start("C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe")
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Process.Start("C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("Recycle Bin.exe")
    End Sub

    Private Sub MicrosoftWordDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftWordDocumentToolStripMenuItem.Click
        Process.Start("Word 2013.exe ")
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Shutdown.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class