Imports System.Threading
Public Class Launcher

    Public server As String = "crossfire151.co.uk"

    Private Sub SmartButton_Click(sender As Object, e As EventArgs) Handles SmartButton.Click
        If SmartButton.Text = "Begin Installation" Then
            If ServerStatus.Text = "Server Online" Then
                SetupInstaller.Show()
            ElseIf ServerStatus.Text = "Server Offline" Then
                MsgBox("The server is currently offline. Please try again later. Check the Server Status tab for more details", MsgBoxStyle.Critical, "Server Offline")
            ElseIf ServerStatus.Text = "Update Available!" Then
                MsgBox("An update is available for the Fable III Patcher. Please update to continue.", MsgBoxStyle.Information, "Update Available")
            ElseIf ServerStatus.Text = "Waiting on Server..." Then
                MsgBox("Please wait for the server to come online. Check the Server Status tab for more details", MsgBoxStyle.Critical, "Server Offline")
            End If
        ElseIf SmartButton.Text = "Click to Update" Then
            System.Diagnostics.Process.Start("https://github.com/crossfire151/Fable-III-Patcher/releases/tag/release")
        ElseIf SmartButton.Text = "Play" Then
            System.Diagnostics.Process.Start("steam://rungameid/")
            TopMost = True
            SmartButton.Enabled = False
            SmartButton.Text = "Launching"
            SmartLoader.Start()
        End If
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PatchComplete = "0" Then
            SmartButton.Text = "Begin Installation"
        ElseIf My.Settings.PatchComplete = "1" Then
            SmartButton.Text = "Play"
        End If
        WebInfo.Navigate("https://cloud.crossfire151.co.uk/Fable-III/Fable-III.php?version=" & Application.ProductVersion)
        StartupTimer.Start()
    End Sub

    Public Sub RecallDLC()
        DLC.Close()
        Thread.Sleep(200)
        DLC.Show()
    End Sub

    Private Sub SmartButton_TextChanged(sender As Object, e As EventArgs)
        'If SmartButton.Text = "Play" Or SmartButton.Text = "Launching" Then
        'SmartButton.ContextMenuStrip = ContextMenuStrip1
        'ContextMenuStrip1.Enabled = True
        'MTUwarn.Visible = True
        ' Else
        'If MTUwarn.Visible = True Then
        'MTUwarn.Visible = False
        'End If
        'End If
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
        If My.Computer.Network.Ping(server) Then
            If WebInfo.DocumentTitle.Contains("ServerStatus:Offline") Then
                ServerStatus.Text = "Server Offline"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            ElseIf WebInfo.DocumentTitle.Contains("ServerStatus:UpdateRequired") Then
                ServerStatus.Text = "Update Available!"
                SmartButton.Text = "Click to Update"
            ElseIf WebInfo.DocumentTitle.Contains("ServerStatus:Online") Then
                ServerStatus.Text = "Server Online"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            Else
                ServerStatus.Text = "Server Online"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            End If
        Else
            ServerStatus.Text = "Server Offline"
            If My.Settings.PatchComplete = "0" Then
                SmartButton.Text = "Begin Installation"
            ElseIf My.Settings.PatchComplete = "1" Then
                SmartButton.Text = "Play"
            End If
        End If
        'PictureBox2.Visible = False
        SmartButton.Visible = True
        LoadingLabel.Visible = False
        Timer1.Start()
        ServerStatusChecker.Start()
    End Sub

    Private Sub WebInfo_DocumentTitleChanged(sender As Object, e As EventArgs) Handles WebInfo.DocumentTitleChanged
        If WebInfo.Document.Title.Contains("https://github.com/crossfire151/Fable-III-Patcher/releases/tag/release") Then
            WebInfo.Refresh()
            System.Diagnostics.Process.Start("https://github.com/crossfire151/Fable-III-Patcher/releases/tag/release")
        End If
        If WebInfo.DocumentTitle.Contains("HotFix::READY") Then
            HotFixButton.Visible = True
        ElseIf Not WebInfo.DocumentTitle.Contains("HotFix::READY") Then
            HotFixButton.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        WebInfo.Navigate("https://cloud.crossfire151.co.uk/Fable-III/Fable-III.php?version=" & Application.ProductVersion)
        If WebInfo.DocumentTitle.Contains("DiscordHelp:Enabled") Then
            Discord.Visible = True
        End If
        If WebInfo.DocumentTitle.Contains("DiscordHelp:Disabled") Then
            Discord.Visible = False
        End If
        If WebInfo.DocumentTitle.Contains("WebSupport:Enabled") Then
            SupportButton.Visible = True
        End If
        If WebInfo.DocumentTitle.Contains("WebSupport:Disabled") Then
            SupportButton.Visible = False
        End If
        Timer1.Start()
    End Sub

    Private Sub Discord_Click(sender As Object, e As EventArgs) Handles Discord.Click
        System.Diagnostics.Process.Start("https://cloud.crossfire151.co.uk/Fable-III/Support?get=Discord")
    End Sub

    Private Sub SupportButton_Click(sender As Object, e As EventArgs) Handles SupportButton.Click
        System.Diagnostics.Process.Start("https://cloud.crossfire151.co.uk/Fable-III/Support?get=WebSupport")
    End Sub

    Private Sub ResetApplicationToDefaultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetApplicationToDefaultsToolStripMenuItem.Click
        My.Settings.PatchComplete = "0"
        My.Settings.CurrentStep = ""
        My.Settings.FableLocation = ""
        My.Settings.Save()
        SmartButton.Text = "Begin Installation"
        SetupInstaller.Show()
    End Sub

    Private Sub ViewPatchNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPatchNotesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://cloud.crossfire151.co.uk/Fable-III/Support/help/viewforum.php?f=7&i=1")
    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LogInButton2.Click
        LogInGroupBox1.Visible = False
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        LogInGroupBox1.Visible = False
        DLC.Show()
    End Sub

    Private Sub HotFixButton_Click(sender As Object, e As EventArgs) Handles HotFixButton.Click
        LogInGroupBox1.Visible = True
        Beep()
    End Sub

    Private Sub ServerStatus_TextChanged(sender As Object, e As EventArgs) Handles ServerStatus.TextChanged
        If ServerStatus.Text = "Server Online" Then
            ServerStatus.ForeColor = Color.ForestGreen
            ServerWarning.Visible = False
        ElseIf ServerStatus.Text = "Server Offline" Then
            ServerStatus.ForeColor = Color.Red
            ServerWarning.Visible = True
        ElseIf ServerStatus.Text = "Update Available!" Then
            ServerStatus.ForeColor = Color.Yellow
            ServerWarning.Visible = False
        ElseIf ServerStatus.Text = "Waiting on Server..." Then
            ServerStatus.ForeColor = Color.Orange
            ServerWarning.Visible = False
        End If
        If Not ServerStatus.Text = "Server Online" Then
            If DLC.Visible = True Then
                DLC.Close()
            End If
            If S1.Visible = True Then
                S1.Close()
            End If
            If Downloader.Visible = True Then
                Downloader.Close()
            End If
            If StageChecker.Visible = True Then
                StageChecker.Close()
            End If
        End If
    End Sub

    Private Sub ServerStatusChecker_Tick(sender As Object, e As EventArgs) Handles ServerStatusChecker.Tick
        ServerStatusChecker.Stop()
        If My.Computer.Network.Ping(server) Then
            If WebInfo.DocumentTitle.Contains("ServerStatus:Offline") Then
                ServerStatus.Text = "Server Offline"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            ElseIf WebInfo.DocumentTitle.Contains("ServerStatus:UpdateRequired") Then
                ServerStatus.Text = "Update Available!"
                SmartButton.Text = "Click to Update"
            ElseIf WebInfo.DocumentTitle.Contains("ServerStatus:Online") Then
                ServerStatus.Text = "Server Online"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            Else
                ServerStatus.Text = "Server Online"
                If My.Settings.PatchComplete = "0" Then
                    SmartButton.Text = "Begin Installation"
                ElseIf My.Settings.PatchComplete = "1" Then
                    SmartButton.Text = "Play"
                End If
            End If
        Else
            ServerStatus.Text = "Server Offline"
            If My.Settings.PatchComplete = "0" Then
                SmartButton.Text = "Begin Installation"
            ElseIf My.Settings.PatchComplete = "1" Then
                SmartButton.Text = "Play"
            End If
        End If
        ServerStatusChecker.Start()
    End Sub
End Class