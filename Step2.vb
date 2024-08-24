Public Class Step2
    Private Sub Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
        Fable3DLCLocation.Navigate(DLC.SaveLocationButton.Tag & "\DLC")
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        step3.show()
        Close()
    End Sub
End Class