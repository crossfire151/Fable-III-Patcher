Public Class StageChecker
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LogInProgressBar1.Increment(1)
        If LogInProgressBar1.Value = LogInProgressBar1.Maximum Then
            Timer1.Stop()
            Hide()
            If My.Settings.CurrentStep = "Step2" Then
                Step2.Show()
            ElseIf My.Settings.CurrentStep = "Step3" Then
                Step3.Show()
            ElseIf My.Settings.CurrentStep = "" Then
                S1.Show()
                S1.BringToFront()
            End If
            Close()
        End If
    End Sub

    Private Sub StageChecker_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username) Then
            Timer1.Start()
        ElseIf Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username) Then
            MsgBox("Coudln't find username: " & My.Settings.username & ". Please select a new username.", MsgBoxStyle.Critical, "Username not found")
            If S1.Visible = True Then
                S1.Close()
            End If
            If Downloader.Visible = True Then
                Downloader.Close()
            End If
            My.Settings.username = ""
            My.Settings.Save()
            DLC.ComboBox1.SelectedIndex = 0
            DLC.InitialSetupTimerOPEN.Start()
            DLC.ChangeUsernameButton.Visible = False
            Close()
        End If

    End Sub
End Class