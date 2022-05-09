Public Class Form1

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region


    Private Sub MetroSetButton7_Click(sender As Object, e As EventArgs) Handles MetroSetButton7.Click
        System.Diagnostics.Process.Start("https://signup.live.com/?lic=1")
    End Sub

    Private Sub MetroSetButton6_Click(sender As Object, e As EventArgs) Handles MetroSetButton6.Click
        MetroSetPanel3.Visible = True
    End Sub

    Private Sub MetroSetButton8_Click(sender As Object, e As EventArgs) Handles MetroSetButton8.Click
        MetroSetPanel2.Visible = False
    End Sub

    Private Sub MetroSetButton9_Click(sender As Object, e As EventArgs) Handles MetroSetButton9.Click
        MetroSetLabel7.Text = "Niestety, ze względu na wiek GFWL, nie wspiera ono dwustopniowej weryfikacji (2FA). Nie wspiera ono także haseł jednorazowych i aplikacji. Wszyscy wiemy, jak bezpieczne jest 2FA, ale w tej sytuacji musisz je wyłączyć i w zamian używać hasła. Pamiętaj, by użyć maksymalnie 16 znaków, ponieważ pole hasła w panelu logowania GFWL wspiera maksymalnie 16 znaków. Czy aktywowałeś już grę? Jeśli nie, to świetna wiadomość: po prostu stwórz drugie konto tylko dla GFWL, w taki sposób twoje konto osobiste zostanie bezpieczne :)"
    End Sub

    Private Sub MetroSetButton10_Click(sender As Object, e As EventArgs) Handles MetroSetButton10.Click
        MetroSetLabel7.Text = "Świetnie! Dwustopniowa weryfikacja (2FA) nie jest wspierana przez GFWL ze względu na jego wiek, więc dobrze dla ciebie. Czy wpisujesz złe hasło? Jak długie ono jest i czy przekracza 16 znaków? Jeśli tak, to niestety musisz je zmniejszyć do 16 znaków lub mniej (oczywiście dla bezpieczeństwa najlepiej, by było ich 16!) Zaczekaj! Czy aktywowałeś już grę? Jeśli nie, to poczekaj; oszczędźmy ci kłopotów, powiedzmy, że chcesz w przyszłości dodać 2FA; Czemu nie stworzyć nowego konta tylko dla Fable? Wtedy twój e-mail będzie bezpieczny! Jeśli nie zamierzać tworzyć nowego konta, to śmiało kontynuuj."
    End Sub

    Private Sub MetroSetButton5_Click(sender As Object, e As EventArgs) Handles MetroSetButton5.Click
        MetroSetPanel2.Visible = True
        MetroSetPanel2.Location = New Point(22, 10)
    End Sub

    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        FolderBrowserDialog1.Description = "Wskaż, gdzie jest zainstalowane Fable III"
        FolderBrowserDialog1.ShowDialog()
        MetroSetTextBox1.Text = FolderBrowserDialog1.SelectedPath
        MetroSetButton3.Enabled = True
    End Sub

    Private Sub MetroSetButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroSetButton3_Click(sender As Object, e As EventArgs) Handles MetroSetButton3.Click
        System.Diagnostics.Process.Start("appwiz.cpl") '
        GFWL_Uninstall_Helper.Show()
    End Sub

    Private Sub MetroSetButton4_Click(sender As Object, e As EventArgs) Handles MetroSetButton4.Click
        MetroSetProgressBar1.Visible = True
        Installer.Start()
        MetroSetButton4.Enabled = False
    End Sub

    Private Sub Installer_Tick(sender As Object, e As EventArgs) Handles Installer.Tick
        MetroSetProgressBar1.Value += 1
        If MetroSetProgressBar1.Value = 5 Then
            Diagnostics.Process.Start(Application.StartupPath & "\resources\gfwlivesetup.exe")
            Installer.Stop()
            GWFLInstaller.Start()
        ElseIf MetroSetProgressBar1.Visible = 80 Then
            Installer.Stop()
            If Environment.Is64BitOperatingSystem = True Then
                System.Diagnostics.Process.Start(Application.StartupPath & "\resources\wllogin_64.msi")
            Else
                System.Diagnostics.Process.Start(Application.StartupPath & "\resources\wllogin_32.msi")
            End If
            Installer.Start()
        ElseIf MetroSetProgressBar1.Value = 100 Then
            Installer.Stop()
            MetroSetButton11.Enabled = True
        End If
    End Sub

    Dim GFWL() As Process

    Private Sub GWFLInstaller_Tick(sender As Object, e As EventArgs) Handles GWFLInstaller.Tick
        GFWL = Process.GetProcessesByName("gfwlivesetup")
        If GFWL.Length = 0 Then
            GWFLInstaller.Stop()
            Installer.Start()
        End If
    End Sub

    Private Sub MetroSetButton11_Click(sender As Object, e As EventArgs) Handles MetroSetButton11.Click
        System.Diagnostics.Process.Start(MetroSetTextBox1.Text)
        CompatibilityHelper.Show()
    End Sub

    Private Sub MetroSetButton2_Click_1(sender As Object, e As EventArgs) Handles MetroSetButton2.Click
        System.Diagnostics.Process.Start("steam://rungameid/105400")
    End Sub

    Private Sub MetroSetButton13_Click(sender As Object, e As EventArgs) Handles MetroSetButton13.Click
        Close()
    End Sub

    Private Sub MetroSetButton12_Click(sender As Object, e As EventArgs) Handles MetroSetButton12.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MetroSetButton14_Click(sender As Object, e As EventArgs) Handles MetroSetButton14.Click
        MetroSetPanel3.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dependency_Check.Show()
    End Sub
End Class
