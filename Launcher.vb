Public Class Launcher
    Private Sub SmartButton_Click(sender As Object, e As EventArgs) Handles SmartButton.Click
        If My.Settings.Lang = "English" Then
            If SmartButton.Text = "Begin Installation" Then
                Form1.Show()
            ElseIf SmartButton.Text = "Play" Then
                System.Diagnostics.Process.Start("steam://rungameid/")
                TopMost = True
                SmartButton.Enabled = False
                SmartButton.Text = "Launching"
                SmartLoader.Start()
            End If
        ElseIf My.Settings.Lang = "Polish" Then
            If SmartButton.Text = "Zacznij instalację" Then
                Form1.Show()
            ElseIf SmartButton.Text = "Graj" Then
                System.Diagnostics.Process.Start("steam://rungameid/")
                TopMost = True
                SmartButton.Enabled = False
                SmartButton.Text = "Uruchamianie"
                SmartLoader.Start()
            End If
        End If
    End Sub

    Private Sub ResetRestartInstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetRestartInstallationToolStripMenuItem.Click
        My.Settings.PatchComplete = "0"
        My.Settings.Save()
        If My.Settings.Lang = "English" Then
            SmartButton.Text = "Begin Installation"
        ElseIf My.Settings.Lang = "Polish" Then
            SmartButton.Text = "Zacznij instalację"
        End If
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lang()
    End Sub

    Public Sub Lang()
        If My.Settings.Lang = "English" Then
            If My.Settings.PatchComplete = "0" Then
                SmartButton.Text = "Begin Installation"
            ElseIf My.Settings.PatchComplete = "1" Then
                SmartButton.Text = "Play"
            End If
        ElseIf My.Settings.Lang = "Polish" Then
            If My.Settings.PatchComplete = "0" Then
                SmartButton.Text = "Zacznij instalację"
            ElseIf My.Settings.PatchComplete = "1" Then
                SmartButton.Text = "Graj"
            End If
            ResetRestartInstallationToolStripMenuItem.Text = "Reset - Instaluj ponownie"
            ThemeContainer1.Text = "Fable III Patcher | Z wbudowanym launcherem"
            LanguageButton.Text = "Zmień Język"
            LogInRichTextBox1.Text = "Patcher Fable III. Stworzony przez Crossfire151, Ten patcher ma za cel polepszyć zdolność grania z innymi online; Zawiera on wszystkie DLC, których nie można już pobrać z poziomu gry. Ten patcher pomoże ci je zainstalować bez większego wysiłku."
        End If
    End Sub

    Private Sub SmartButton_TextChanged(sender As Object, e As EventArgs) Handles SmartButton.TextChanged
        If My.Settings.Lang = "English" Then
            If SmartButton.Text = "Play" Then
                SmartButton.ContextMenuStrip = ContextMenuStrip1
                ContextMenuStrip1.Enabled = True
            End If
        ElseIf My.Settings.Lang = "Polish" Then
            If SmartButton.Text = "Graj" Then
                SmartButton.ContextMenuStrip = ContextMenuStrip1
                ContextMenuStrip1.Enabled = True
            End If
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

    Private Sub LanguageButton_Click(sender As Object, e As EventArgs) Handles LanguageButton.Click
        My.Settings.Lang = ""
        My.Settings.Save()
        Startup.Show()
        Close()
    End Sub
End Class