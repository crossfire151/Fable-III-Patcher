Public Class Launcher
    Private Sub SmartButton_Click(sender As Object, e As EventArgs) Handles SmartButton.Click
        If SmartButton.Text = "Begin Installation" Then
            Startup.Show()
        ElseIf SmartButton.Text = "Play" Then
            System.Diagnostics.Process.Start("steam://rungameid/")
            TopMost = True
            SmartButton.Enabled = False
            SmartButton.Text = "Launching"
            SmartLoader.Start()
        End If
    End Sub

    Private Sub ResetRestartInstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetRestartInstallationToolStripMenuItem.Click
        My.Settings.PatchComplete = "0"
        My.Settings.Save()
        SmartButton.Text = "Begin Installation"
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PatchComplete = "0" Then
            SmartButton.Text = "Begin Installation"
        ElseIf My.Settings.PatchComplete = "1" Then
            SmartButton.Text = "Play"
        End If
        StartupTimer.Start()
    End Sub

    Private Sub SmartButton_TextChanged(sender As Object, e As EventArgs) Handles SmartButton.TextChanged
        If SmartButton.Text = "Play" Or SmartButton.Text = "Launching" Then
            SmartButton.ContextMenuStrip = ContextMenuStrip1
            ContextMenuStrip1.Enabled = True
            MTUwarn.Visible = True
        Else
            If MTUwarn.Visible = True Then
                MTUwarn.Visible = False
            End If
        End If
    End Sub

    Private Sub SmartLoader_Tick(sender As Object, e As EventArgs) Handles SmartLoader.Tick
        SmartButton.Increment(1)
        If SmartButton.Value = "1" Then
            TopMost = True
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 1 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "6" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 2 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "11" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 3 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "16" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 4 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "21" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 5 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "26" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 6 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "31" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 7 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "36" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 8 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "41" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 9 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "46" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 10 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "51" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 11 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "56" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 12 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "61" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 13 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "66" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 14 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "71" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 15 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "76" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 16 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "81" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 17 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "86" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 18 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "91" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 19 mtu=1492 store=persistent”)
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = "96" Then
            System.Diagnostics.Process.Start(“Netsh.exe”, “interface ipv4 set subinterface 20 mtu=1492 store=persistent”)
            StatusLabel.Text = "Preparing Fable II... (" & SmartButton.Value & "%)"
        ElseIf SmartButton.Value = SmartButton.Maximum Then
            SmartLoader.Stop()
            System.Diagnostics.Process.Start("steam://rungameid/105400")
            StatusLabel.Text = "Opening Fable III..."
            GetReadyClose.Start()
        Else
            StatusLabel.Text = "Loading Interfaces... (" & SmartButton.Value & "%)"
        End If
    End Sub

    Private Sub GetReadyClose_Tick(sender As Object, e As EventArgs) Handles GetReadyClose.Tick
        GetReadyClose.Stop()
        Close()
    End Sub

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles StartupTimer.Tick
        StartupTimer.Stop()
        PictureBox2.Visible = False
        SmartButton.Visible = True
        LoadingLabel.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        System.Diagnostics.Process.Start("https://discord.gg/nQRsMxZ3Ha")
    End Sub
End Class