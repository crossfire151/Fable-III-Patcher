Imports System.ComponentModel
Imports System.IO.Compression

Public Class Step2
    Private Sub Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
        Fable3DLCLocation.Navigate(My.Settings.FableLocation & "\DLC")
        'Timer1.Start()
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LoginButton1.Click
        If LoginButton1.Text = "Begin Extraction..." Then
            LoginButton1.Text = "Processing..."
            Extraction.Start()
        ElseIf LoginButton1.Text = "Next Step" Then
            Step3.Show()
            My.Settings.CurrentStep = "Step3"
            My.Settings.Save()
            Close()
        End If
    End Sub

    Private Sub DownloadedFilesgoBack_Click(sender As Object, e As EventArgs)
        If DownloadedFiles.CanGoBack Then
            DownloadedFiles.GoBack()
        End If
    End Sub

    Private Sub DLCgoBack_Click(sender As Object, e As EventArgs)
        If Fable3DLCLocation.CanGoBack Then
            Fable3DLCLocation.GoBack()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If DownloadedFiles.CanGoBack Then
        'DownloadedFilesgoBack.Visible = True
        'Else
        'DownloadedFilesgoBack.Visible = False
        'End If
        'If Fable3DLCLocation.CanGoBack Then
        'LoginButton1.Visible = True
        'Else
        'LoginButton1.Visible = False
        'End If
    End Sub

    Private Sub Extraction_Tick(sender As Object, e As EventArgs) Handles Extraction.Tick
        LogInRadialProgressBar1.Increment(1)
        If TrackingProgressBar.Value = 1 Then
            LogInLabel2.Text = "Stage 1 of 5"
            ExtractStatus.Text = "Extracting - 01_Understone.zip..."
            If LogInRadialProgressBar1.Value = 5 Then
                Extraction.Stop()
                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads\01_Understone") Then
                    My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\01_Understone", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads\02_TraitorsKeep") Then
                    My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\02_TraitorsKeep", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads\03_InquisitorsPack") Then
                    My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\03_InquisitorsPack", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB") Then
                    My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Settings.FableLocation & "\DLC\01_Understone") Then
                    My.Computer.FileSystem.DeleteDirectory(My.Settings.FableLocation & "\DLC\01_Understone", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Settings.FableLocation & "\DLC\02_TraitorsKeep") Then
                    My.Computer.FileSystem.DeleteDirectory(My.Settings.FableLocation & "\DLC\02_TraitorsKeep", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Settings.FableLocation & "\DLC\03_InquisitorsPack") Then
                    My.Computer.FileSystem.DeleteDirectory(My.Settings.FableLocation & "\DLC\03_InquisitorsPack", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                Extraction.Start()
            ElseIf LogInRadialProgressBar1.Value = 10 Then
                ZipFile.ExtractToDirectory(Application.StartupPath & "\Downloads\01_Understone.zip", Application.StartupPath & "\Downloads\01_Understone")
                'IronZipArchive.ExtractArchiveToDirectory("Downloads\01_Understone.zip", "Downloads")
            ElseIf LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
                Extraction.Stop()
                TrackingProgressBar.Value = 2
                LogInRadialProgressBar1.Value = 0
                Extraction.Start()
            End If
        ElseIf TrackingProgressBar.Value = 2 Then
            LogInLabel2.Text = "Stage 2 of 5"
            ExtractStatus.Text = "Extracting - 02_TraitorsKeep.zip..."
            If LogInRadialProgressBar1.Value = 10 Then
                ZipFile.ExtractToDirectory(Application.StartupPath & "\Downloads\02_TraitorsKeep.zip", Application.StartupPath & "\Downloads\02_TraitorsKeep")
                'IronZipArchive.ExtractArchiveToDirectory("Downloads\02_TraitorsKeep.zip", "Downloads")
            ElseIf LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
                Extraction.Stop()
                TrackingProgressBar.Value = 3
                LogInRadialProgressBar1.Value = 0
                Extraction.Start()
            End If
        ElseIf TrackingProgressBar.Value = 3 Then
            LogInLabel2.Text = "Stage 3 of 5"
            ExtractStatus.Text = "Extracting - 03_InquisitorsPack.zip..."
            If LogInRadialProgressBar1.Value = 10 Then
                BackgroundWorker2.RunWorkerAsync()
                'IronZipArchive.ExtractArchiveToDirectory("Downloads\03_InquisitorsPack.zip", "Downloads")
            ElseIf LogInRadialProgressBar1.Value = 98 Then
                Extraction.Stop()
            ElseIf LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
                Extraction.Stop()
                TrackingProgressBar.Value = 4
                LogInRadialProgressBar1.Value = 0
                Extraction.Start()
            End If
        ElseIf TrackingProgressBar.Value = 4 Then
            LogInLabel2.Text = "Stage 4 of 5"
            ExtractStatus.Text = "Extracting - D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip..."
            If LogInRadialProgressBar1.Value = 10 Then
                BackgroundWorker1.RunWorkerAsync()
                'IronZipArchive.ExtractArchiveToDirectory("Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip", "Downloads")
            ElseIf LogInRadialProgressBar1.Value = 98 Then
                Extraction.Stop()
            ElseIf LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
                Extraction.Stop()
                TrackingProgressBar.Value = 5
                LogInRadialProgressBar1.Value = 0
                Extraction.Start()
            End If
        ElseIf TrackingProgressBar.Value = 5 Then
            LogInLabel2.Text = "Stage 5 of 5"
            If LogInRadialProgressBar1.Value <= 1 Then
                ExtractStatus.Text = "Copying Data to DLC Directory..."
            End If
            If LogInRadialProgressBar1.Value = 2 Then
                ExtractStatus.Text = "Copying Data to DLC Directory - 01_Understone.zip..."
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Downloads\01_Understone", My.Settings.FableLocation & "\DLC\01_Understone")
            ElseIf LogInRadialProgressBar1.Value = 5 Then
                ExtractStatus.Text = "Copying Data to DLC Directory - 02_TraitorsKeep.zip..."
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Downloads\02_TraitorsKeep", My.Settings.FableLocation & "\DLC\02_TraitorsKeep")
            ElseIf LogInRadialProgressBar1.Value = 8 Then
                ExtractStatus.Text = "Copying Data to DLC Directory - 03_InquisitorsPack.zip..."
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Downloads\03_InquisitorsPack", My.Settings.FableLocation & "\DLC\03_InquisitorsPack")
            ElseIf LogInRadialProgressBar1.Value = 20 Then
                ExtractStatus.Text = "Cleaning Up..."
                Extraction.Interval = 10
            ElseIf LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
                ExtractStatus.Text = "Complete!"
                    Extraction.Stop()
                    Beep()
                    My.Computer.Audio.Play(My.Resources.complete, AudioPlayMode.Background)
                    LoginButton1.Text = "Next Step"
                End If
            End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ZipFile.ExtractToDirectory(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip", Application.StartupPath & "\Downloads\")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        LogInRadialProgressBar1.Value = 99
        Extraction.Start()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        ZipFile.ExtractToDirectory(Application.StartupPath & "\Downloads\03_InquisitorsPack.zip", Application.StartupPath & "\Downloads\03_InquisitorsPack")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        LogInRadialProgressBar1.Value = 99
        Extraction.Start()
    End Sub
End Class