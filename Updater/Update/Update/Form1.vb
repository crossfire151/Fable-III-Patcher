Public Class Form1
    Dim f3() As Process
    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles InstallButton.Click
        InstallButton.Text = "Installing..."
        InstallButton.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        InstallButton.Value += 1
        If InstallButton.Value = 1 Then
            Timer1.Stop()
            f3 = Process.GetProcessesByName("Fable III Patcher")
            If f3.Length > 0 Then
                For Each p As Process In f3
                    p.Kill()
                Next
            End If
            InstallProgress.AddItem("Fable III Patcher closed.")
            Timer1.Start()
        ElseIf InstallButton.Value = 2 Then
            Timer1.Stop()
            InstallProgress.AddItem("Deleting old files...")
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Fable III Patcher.exe") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Fable III Patcher.exe")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 13 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.Base.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.Base.dll")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 14 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.Base.xml") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.Base.xml")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 15 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.Web.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.Web.dll")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 16 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.Web.xml") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.Web.xml")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 17 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebBrowser.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebBrowser.dll")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 18 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebBrowser.Wpf.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebBrowser.Wpf.dll")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 19 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebBrowser.Wpf.xml") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebBrowser.Wpf.xml")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 20 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebBrowser.xml") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebBrowser.xml")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 21 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebEngine.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebEngine.dll")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 22 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\EO.WebEngine.xml") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\EO.WebEngine.xml")
            End If
            Timer1.Start()
        ElseIf InstallButton.Value = 23 Then
            Timer1.Stop()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\MetroSet UI.dll") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\MetroSet UI.dll")
            End If
            InstallProgress.AddItem("Old files deleted.")
            Timer1.Start()
        ElseIf InstallButton.Value = 25 Then
            Timer1.Stop()
            InstallProgress.AddItem("Downloading new dependency files...")
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/MetroSet%20UI.dll", Application.StartupPath & "\Fable III Patcher.exe")
            Timer1.Start()
        ElseIf InstallButton.Created = 26 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.Base.dll", Application.StartupPath & "\EO.Base.dll")
            Timer1.Start()
        ElseIf InstallButton.Value = 27 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.Base.xml", Application.StartupPath & "\EO.Base.xml")
            Timer1.Start()
        ElseIf InstallButton.Value = 28 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.Web.dll", Application.StartupPath & "\EO.Web.dll")
            Timer1.Start()
        ElseIf InstallButton.Value = 29 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.Web.xml", Application.StartupPath & "\EO.Web.xml")
            Timer1.Start()
        ElseIf InstallButton.Value = 30 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebBrowser.dll", Application.StartupPath & "\EO.WebBrowser.dll")
            Timer1.Start()
        ElseIf InstallButton.Value = 31 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebBrowser.Wpf.dll", Application.StartupPath & "\EO.WebBrowser.Wpf.dll")
            Timer1.Start()
        ElseIf InstallButton.Value = 32 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebBrowser.Wpf.xml", Application.StartupPath & "\EO.WebBrowser.Wpf.xml")
            Timer1.Start()
        ElseIf InstallButton.Value = 33 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebBrowser.xml", Application.StartupPath & "\EO.WebBrowser.xml")
            Timer1.Start()
        ElseIf InstallButton.Value = 34 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebEngine.dll", Application.StartupPath & "\EO.WebEngine.dll")
            Timer1.Start()
        ElseIf InstallButton.Value = 35 Then
            Timer1.Stop()
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/EO.WebEngine.xml", Application.StartupPath & "\EO.WebEngine.xml")
            InstallProgress.AddItem("Dependiencies downloaded.")
            Timer1.Start()
        ElseIf InstallButton.Value = 90 Then
            Timer1.Stop()
            InstallProgress.AddItem("Downloading Fable III Patcher...")
            Dim webClient As New Net.WebClient()
            webClient.DownloadFile("https://cloud.crossfire151.co.uk/Fable-III/installer/Fable%20III%20Patcher.exe", Application.StartupPath & "\Fable III Patcher.exe")
            Timer1.Start()
        ElseIf InstallButton.Value = 95 Then
            Timer1.Stop()
            InstallProgress.AddItem("Fable III Patcher downloaded.")
            Timer1.Start()
        ElseIf InstallButton.Value = 96 Then
            Timer1.Stop()
            InstallProgress.AddItem("Finalizing installation...")
            Timer1.Start()
        ElseIf InstallButton.Value = 100 Then
            Timer1.Stop()
            InstallProgress.AddItem("Installation complete!")
            InstallButton.Text = "Installed"
            System.Diagnostics.Process.Start(Application.StartupPath & "\Fable III Patcher.exe")
            Close()
        End If
    End Sub
End Class
