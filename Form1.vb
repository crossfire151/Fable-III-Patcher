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

    Dim language As String = My.Settings.Lang
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
        If language = "English" Then
            MetroSetLabel7.Text = "Unfortunately due to the age of GFWL it doesn't support the latest technology in 2FA. Also unfortunately it also does not support one time passwords or app passwords, we all know how secure 2FA is but in your case you'll need to remove it and use a password instead. Remember to use a maximum of 16 characters in your password as the login password field on the GFWL login panel only supports a max of 16 characters. Have you activated your key on account already, if not then there is some great news, just create a new account and have it only for GFWL that way your personal account stays secure :)"
        ElseIf language = "Polish" Then
            MetroSetLabel7.Text = "Niestety, ze względu na wiek GFWL, nie wspiera ono dwustopniowej weryfikacji (2FA). Nie wspiera ono także haseł jednorazowych i aplikacji. Wszyscy wiemy, jak bezpieczne jest 2FA, ale w tej sytuacji musisz je wyłączyć i w zamian używać hasła. Pamiętaj, by użyć maksymalnie 16 znaków, ponieważ pole hasła w panelu logowania GFWL wspiera maksymalnie 16 znaków. Czy aktywowałeś już grę? Jeśli nie, to świetna wiadomość: po prostu stwórz drugie konto tylko dla GFWL, w taki sposób twoje konto osobiste zostanie bezpieczne :)"
        End If
    End Sub

    Private Sub MetroSetButton10_Click(sender As Object, e As EventArgs) Handles MetroSetButton10.Click
        If language = "English" Then
            MetroSetLabel7.Text = "Great! Having 2FA is not suported by GFWL due to how outdated it is, so good on you. Are you getting password in incorrect? How long is your password? Does it exceed 16 characters? Unfortunately you'll need to reduce it to at least 16 or less characters (16 preferably for security of course!). But wait! Have you activated already?, if not then stop there; let's save you hassle, let's say you wanted to add 2FA in the future; why not just create a new account and have Fable just for that one email address, then your personal email stays secure! If not then go ahead and continue :) "
        ElseIf language = "Polish" Then
            MetroSetLabel7.Text = "Świetnie! Dwustopniowa weryfikacja (2FA) nie jest wspierana przez GFWL ze względu na jego wiek, więc dobrze dla ciebie. Czy wpisujesz złe hasło? Jak długie ono jest i czy przekracza 16 znaków? Jeśli tak, to niestety musisz je zmniejszyć do 16 znaków lub mniej (oczywiście dla bezpieczeństwa najlepiej, by było ich 16!) Zaczekaj! Czy aktywowałeś już grę? Jeśli nie, to poczekaj; oszczędźmy ci kłopotów, powiedzmy, że chcesz w przyszłości dodać 2FA; Czemu nie stworzyć nowego konta tylko dla Fable? Wtedy twój e-mail będzie bezpieczny! Jeśli nie zamierzać tworzyć nowego konta, to śmiało kontynuuj."
        End If
    End Sub

    Private Sub MetroSetButton5_Click(sender As Object, e As EventArgs) Handles MetroSetButton5.Click
        MetroSetPanel2.Visible = True
        MetroSetPanel2.Location = New Point(22, 10)
    End Sub

    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        If language = "English" Then
            FolderBrowserDialog1.Description = "Tell us where you have Fable III installed"
        ElseIf language = "Polish" Then
            FolderBrowserDialog1.Description = "Wskaż, gdzie jest zainstalowane Fable III"
        End If
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
        Lang()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Settings.Lang = ""
        My.Settings.Save()
        Startup.Show()
        Close()
    End Sub

    Public Sub Lang()
        If My.Settings.Lang = "English" Then
            'DO NOTHING - > Continue load sequence
        ElseIf My.Settings.Lang = "Polish" Then
            'SET Languages:
            MetroSetButton1.Text = "Szukaj..."
            MetroSetButton2.Text = "Graj w Fable III"
            MetroSetButton3.Text = "Odinstaluj stare GFWL"
            MetroSetButton4.Text = "Zacznij naprawiać i zainstaluj nowszą wersję GFWL"
            MetroSetButton5.Text = "Rozwiązywanie problemów z GFWL"
            MetroSetButton6.Text = "Mam już konto"
            MetroSetButton7.Text = "Potrzebuję założyć konto"
            'BUTTON 8 -> CLOSE BUTTON -> NO TRANSLATION REQURED
            MetroSetButton9.Text = "Moje konto LIVE MA włączoną dwustopniową weryfikację (2FA)"
            MetroSetButton10.Text = "Moje konto LIVE NIE ma włączonej dwustopniowej weryfikacji (2FA)"
            MetroSetButton11.Text = "Sprawmy, by Fable III działało na Windows 10 przez narzędzia kompatybilności!"
            'MetroSetButton12  -> MINIMIZE (IGNORE THIS)
            'MetroSetButton13  -> CLOSE (IGNORE THIS)
            MetroSetButton14.Text = "Powrót"
            MetroSetButton15.Text = "Instalacja DLC"
            MetroSetLabel1.Text = "Znajdźmy Fable III"
            'LABEL 2 -> DELETED LABEL (IGNORE THIS)
            MetroSetLabel3.Text = "Tą wersję Steam instaluje automatycznie"
            MetroSetLabel4.Text = "Rozwiązywanie problemów z GFWL"
            MetroSetLabel5.Text = "Masz problemy z zalogowaniem się"
            MetroSetLabel6.Text = "Masz problemy z założeniem konta nie wychodząc z gry? To jest właściwe miejsce do rejestracji!"
            LinkLabel1.Text = "Zmień Język"
        End If
        'Continue Load Sequence:
        MetroSetPanel1.Size = New Point(752, 387)
        MetroSetPanel1.Location = New Point(23, 10)
        Dependency_Check.Show()
    End Sub
End Class
