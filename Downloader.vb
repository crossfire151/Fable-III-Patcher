Imports System.ComponentModel
Imports System.Net

Public Class Downloader
    Public WithEvents download As WebClient

    Dim FileServerURL As String = "https://cloud.crossfire151.xyz/download/" & My.Settings.data & "/Fable3-Packages/"

    Public Sub FileDownload()
        StatusText.Cursor = Cursors.Default
        StatusText.Text = "Status: Initializing"
        StatusText.ForeColor = Color.Lime
        DownloadProgress.Visible = True
        download = New WebClient
        download.DownloadFileAsync(New Uri(FileServerURL & RequestedFile.Text), Application.StartupPath & "\Downloads\" & RequestedFile.Text)
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        'Dim readdata
        'readdata = My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\Downloads\" & RequestedFile.Text)
        DownloadProgress.Value = e.ProgressPercentage
        Percentage.Text = DownloadProgress.Value & "%"
        StatusText.Text = "Status: Downloading... (" & RequestedFile.Text & ")"
        DownloadProgress.Text = DownloadProgress.Value
    End Sub

    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Downloads") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Downloads")
        End If
    End Sub

    Private Sub DownloadProgress_TextChanged(sender As Object, e As EventArgs) Handles DownloadProgress.TextChanged
        If DownloadProgress.Text = DownloadProgress.Maximum Then
            DownloadProgress.Visible = False
            StatusText.Text = "Status: File:- " & RequestedFile.Text & ", Download Complete!"
            'ExitButton.Visible = True
            DownloadProgress.Value = 0
            prepexit.start()
        End If
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If RequestedFile.Text = "01_Understone.zip" Then
            DLC.DLC1.Enabled = False
            DLC.DLC2.Enabled = True
        ElseIf RequestedFile.Text = "02_TraitorsKeep.zip" Then
            DLC.DLC2.Enabled = False
            DLC.DLC3.Enabled = True
        ElseIf RequestedFile.Text = "03_InquisitorsPack.zip" Then
            DLC.DLC3.Enabled = False
            DLC.DLC4.Enabled = True
        ElseIf RequestedFile.Text = "D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip" Then
            DLC.DLC4.Enabled = False
            DLC.Step2.Enabled = True
        End If
        Close()
    End Sub

    Private Sub DownloadGoStart_Tick(sender As Object, e As EventArgs) Handles DownloadGoStart.Tick
        DownloadGoStart.Stop()
        FileDownload()
    End Sub

    Private Sub Prepexit_Tick(sender As Object, e As EventArgs) Handles Prepexit.Tick
        ProgressBar1.Value -= 1
        If ProgressBar1.Value = ProgressBar1.Minimum Then
            Close()
        End If
    End Sub

    Private Sub Downloader_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If S1.LogInProgressBar1.Value = S1.LogInProgressBar1.Maximum Then
            S1.Timer2.Start()
        Else
            If S1.ProgressBar1.Value = 6 Then
                S1.Timer2.Start()
            Else
                S1.Timer1.Start()
            End If
        End If
    End Sub
End Class