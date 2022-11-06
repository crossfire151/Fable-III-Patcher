Imports System.Net

Public Class Downloader
    Public WithEvents download As WebClient

    Dim FileServerURL As String = "https://cloud.crossfire151.xyz/download/" & My.Settings.data & "/Fable3-Packages/"

    Public Sub FileDownload()
        StatusText.Cursor = Cursors.Default
        If My.Settings.Lang = "English" Then
            StatusText.Text = "Status: Initializing"
        ElseIf My.Settings.Lang = "Polish" Then
            StatusText.Text = "Status: Inicjalizacja"
        End If
        StatusText.ForeColor = Color.Lime
        DownloadProgress.Visible = True
        download = New WebClient
        download.DownloadFileAsync(New Uri(FileServerURL & RequestedFile.Text), Application.StartupPath & "\Downloads\" & RequestedFile.Text)
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        DownloadProgress.Value = e.ProgressPercentage
        Percentage.Text = DownloadProgress.Value & "%"
        DownloadProgress.Text = DownloadProgress.Value
    End Sub

    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Downloads")
        End If
        Lang()
    End Sub

    Public Sub Lang()
        If My.Settings.Lang = "Polish" Then
            ThemeContainer1.Text = "Pobieranie DLC"
            ExitButton.Text = "Zamknij pobieranie"
            Text = "Pobieranie"
        End If
    End Sub

    Private Sub DownloadProgress_TextChanged(sender As Object, e As EventArgs) Handles DownloadProgress.TextChanged
        If DownloadProgress.Text = 1 Then
            If My.Settings.Lang = "English" Then
                StatusText.Text = "Status: Downloading... (" & RequestedFile.Text & ")"
            ElseIf My.Settings.Lang = "Polish" Then
                StatusText.Text = "Status: Pobieranie... (" & RequestedFile.Text & ")"
            End If
        ElseIf DownloadProgress.Text = DownloadProgress.Maximum Then
            DownloadProgress.Visible = False
            If My.Settings.Lang = "English" Then
                StatusText.Text = "Status: File:- " & RequestedFile.Text & ", Download Complete!"
            ElseIf My.Settings.Lang = "Polish" Then
                StatusText.Text = "Status: Plik:- " & RequestedFile.Text & ", pobieranie zakończone!"
            End If
            ExitButton.Visible = True
        End If
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If RequestedFile.Text = "01_Understone.zip" Then
            DLC.DLC1.Enabled = False
            DLC.DLC1.BorderColour = Color.FromArgb(25, 25, 25)
            DLC.DLC2.Enabled = True
            DLC.DLC2.BorderColour = Color.Lime
        ElseIf RequestedFile.Text = "02_TraitorsKeep.zip" Then
            DLC.DLC2.Enabled = False
            DLC.DLC2.BorderColour = Color.FromArgb(25, 25, 25)
            DLC.DLC3.Enabled = True
            DLC.DLC3.BorderColour = Color.Lime
        ElseIf RequestedFile.Text = "03_InquisitorsPack.zip" Then
            DLC.DLC3.Enabled = False
            DLC.DLC3.BorderColour = Color.FromArgb(25, 25, 25)
            DLC.DLC4.Enabled = True
            DLC.DLC4.BorderColour = Color.Lime
        ElseIf RequestedFile.Text = "D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip" Then
            DLC.DLC4.Enabled = False
            DLC.DLC4.BorderColour = Color.FromArgb(25, 25, 25)
            DLC.Step2.Enabled = True
            DLC.LogInButton1.BorderColour = Color.Lime
        End If
        Close()
    End Sub

    Private Sub DownloadGoStart_Tick(sender As Object, e As EventArgs) Handles DownloadGoStart.Tick
        DownloadGoStart.Stop()
        FileDownload()
    End Sub
End Class