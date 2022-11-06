Public Class Launcher
    Private Sub SmartButton_Click(sender As Object, e As EventArgs) Handles SmartButton.Click
        If SmartButton.Text = "Zacznij instalację" Then
            Startup.Show()
        ElseIf SmartButton.Text = "Graj" Then
            System.Diagnostics.Process.Start("steam://rungameid/")
            TopMost = True
            SmartButton.Enabled = False
            SmartButton.Text = "Uruchamianie"
            SmartLoader.Start()
        End If
    End Sub

    Private Sub ResetRestartInstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetRestartInstallationToolStripMenuItem.Click
        My.Settings.PatchComplete = "0"
        My.Settings.Save()
        SmartButton.Text = "Zacznij instalację"
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PatchComplete = "0" Then
            SmartButton.Text = "Zacznij instalację"
        ElseIf My.Settings.PatchComplete = "1" Then
            SmartButton.Text = "Graj"
        End If
    End Sub

    Private Sub SmartButton_TextChanged(sender As Object, e As EventArgs) Handles SmartButton.TextChanged
        If SmartButton.Text = "Graj" Then
            SmartButton.ContextMenuStrip = ContextMenuStrip1
            ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub SmartLoader_Tick(sender As Object, e As EventArgs) Handles SmartLoader.Tick
        SmartButton.Increment(1)
        If SmartButton.Value = SmartButton.Maximum Then
            SmartLoader.Stop()
            System.Diagnostics.Process.Start("steam://rungameid/105400")
            Close()
        End If
    End Sub
End Class