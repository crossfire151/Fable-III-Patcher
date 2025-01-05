Imports Microsoft.SqlServer.Server
Imports Microsoft.VisualBasic.FileIO

Public Class S1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 1 Then
            StageCount.Text = "1/5"
            Timer1.Stop()
            Timer2.Start()
        ElseIf ProgressBar1.Value = 2 Then
            StageCount.Text = "2/5"
            Timer1.Stop()
            Timer2.Start()
        ElseIf ProgressBar1.Value = 3 Then
            StageCount.Text = "3/5"
            Timer1.Stop()
            Timer2.Start()
        ElseIf ProgressBar1.Value = 4 Then
            StageCount.Text = "4/5"
            Timer1.Stop()
            Timer2.Start()
        ElseIf ProgressBar1.Value = 5 Then
            StageCount.Text = "5/5"
            Timer1.Stop()
            Timer2.Start()
        ElseIf ProgressBar1.Value = 6 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LogInProgressBar1.Increment(1)
        If LogInProgressBar1.Value = 1 Then
            Statustext.Text = "Refreshing Data..."
            Timer2.Stop()
            Try
                My.Computer.FileSystem.DeleteDirectory("C:\Users\" & DLC.ComboBox1.SelectedItem & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\", DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception

            End Try
            Try
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads", DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception

            End Try
            Try
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Downloads")
            Catch ex As Exception

            End Try
            Timer1.Start()
        ElseIf LogInProgressBar1.Value = 2 Then
            Statustext.Text = "Downloading Addons (1/4)"
            Timer2.Stop()
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC.DLC1.Tag
            Downloader.DownloadGoStart.Start()
        ElseIf LogInProgressBar1.Value = 3 Then
            Statustext.Text = "Downloading Addons (2/4)"
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC.DLC2.Tag
            Downloader.DownloadGoStart.Start()
        ElseIf LogInProgressBar1.Value = 4 Then
            Statustext.Text = "Downloading Addons (3/4)"
            Timer2.Stop()
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC.DLC3.Tag
            Downloader.DownloadGoStart.Start()
        ElseIf LogInProgressBar1.Value = 5 Then
            Statustext.Text = "Downloading Addons (4/4)"
            Timer2.Stop()
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC.DLC4.Tag
            Downloader.DownloadGoStart.Start()
        ElseIf LogInProgressBar1.Value >= 5 And LogInProgressBar1.Value <= LogInProgressBar1.Maximum Then
            Statustext.Text = "Validating files..."
        End If
        If LogInProgressBar1.Value = LogInProgressBar1.Maximum Then
            Timer2.Stop()
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\02_TraitorsKeep.zip") Then
                Statustext.Text = "Found missing file - 02_TraitorsKeep.zip | Downloading..."
                LogInProgressBar1.Value -= 1
                Downloader.Show()
                Downloader.TopMost = True
                Downloader.RequestedFile.Text = DLC.DLC2.Tag
                Downloader.DownloadGoStart.Start()
            Else
                Statustext.Text = "Waiting for User..."
            MsgBox("Please locate Fable III Installation directory to continue...", MsgBoxStyle.Information)
            DLC.FolderBrowserDialog1.ShowDialog()
            If Not DLC.FolderBrowserDialog1.SelectedPath = "" Then
                    DLC.SaveLocationButton.Tag = DLC.FolderBrowserDialog1.SelectedPath
                    My.Settings.FableLocation = DLC.FolderBrowserDialog1.SelectedPath
                    My.Settings.Save()
                    DLC.SaveLocationButton.Enabled = False
                My.Computer.FileSystem.CreateDirectory(DLC.SaveLocationButton.Tag & "\DLC")
                    DLC.Step3.Enabled = True
                    My.Settings.CurrentStep = "Step2"
                    My.Settings.Save()
                    Step2.Show()
                Close()
            End If
        End If
        End If

    End Sub

    Private Sub S1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
End Class