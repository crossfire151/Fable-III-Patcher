Public Class Step2
    Private Sub Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
        Fable3DLCLocation.Navigate(DLC.SaveLocationButton.Tag & "\DLC")
        Timer1.Start()
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        Step3.Show()
        My.Settings.CurrentStep = "Step3"
        My.Settings.Save()
        Close()
    End Sub

    Private Sub DownloadedFilesgoBack_Click(sender As Object, e As EventArgs) Handles DownloadedFilesgoBack.Click
        If DownloadedFiles.CanGoBack Then
            DownloadedFiles.GoBack()
        End If
    End Sub

    Private Sub DLCgoBack_Click(sender As Object, e As EventArgs) Handles DLCgoBack.Click
        If Fable3DLCLocation.CanGoBack Then
            Fable3DLCLocation.GoBack()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DownloadedFiles.CanGoBack Then
            DownloadedFilesgoBack.Visible = True
        Else
            DownloadedFilesgoBack.Visible = False
        End If
        If Fable3DLCLocation.CanGoBack Then
            DLCgoBack.Visible = True
        Else
            DLCgoBack.Visible = False
        End If
    End Sub
End Class