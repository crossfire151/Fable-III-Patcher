Imports System.Data.Common
Imports System.Net
Imports Microsoft.VisualBasic.FileIO

Public Class DLC
#Region "CloudServer"
    Dim CloudServer As String = "https://cloud.crossfire151.xyz/download/f_files_downloads_33jhuf-_-ih83h2!uhgr7u9g3b/"
#End Region
    Dim InquisitorPack As String = CloudServer & "4d53090a0ecf000e_INQUISITOR.cab"
    Dim TraitorsKeepPack As String = CloudServer & "4d53090a0ecf0010_TRAITORS.cab"
    Dim UnderstonePack As String = CloudServer & "4d53090a0ecf0000_UNDERSTONE.cab"

    Private Sub SaveLocationButton_Click(sender As Object, e As EventArgs) Handles SaveLocationButton.Click
        FolderBrowserDialog1.ShowDialog()
        If Not FolderBrowserDialog1.SelectedPath = "" Then
            SaveLocationButton.Tag = FolderBrowserDialog1.SelectedPath
            SaveLocationButton.Enabled = False
            My.Computer.FileSystem.CreateDirectory(SaveLocationButton.Tag & "\DLC")
            Step3.Enabled = True
            DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
            Fable3DLCLocation.Navigate(SaveLocationButton.Tag & "\DLC")
        End If
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        Step3.Enabled = False
        Step4.Enabled = True
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If DoneButton.Text = "Done" Then
            If Clipboard.GetText = "" Then
                MsgBox("It appears you have not copied anything. This information is required in order to enable usage of the DLC.", MsgBoxStyle.Critical, "Missing information")
            Else
                MsgBox("Great, here's what we found in your clipboard: " & Clipboard.GetText & ". Please click Confirm if this is correct, if not; please try again.", MsgBoxStyle.Information, "We found this")
                DoneButton.Text = "Confirm"
            End If
        ElseIf DoneButton.Text = "Confirm" Then
            LicenceSetupButton.Enabled = False
            RenameLicenceButton.Enabled = True
            LicencePanel.Visible = False
        End If

    End Sub

    Private Sub DoneButton_TextChanged(sender As Object, e As EventArgs) Handles DoneButton.TextChanged
        If DoneButton.Text = "Confirm" Then
            RetryButton.Visible = True
        ElseIf DoneButton.Text = "Done" Then
            If RetryButton.Visible = True Then
                RetryButton.Visible = False
            End If
        End If
    End Sub

    Private Sub xuidPanelClose_Click(sender As Object, e As EventArgs) Handles xuidPanelClose.Click
        LicencePanel.Visible = False
    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LicenceSetupButton.Click
        LicencePanel.Visible = True
        LicencePanel.Size = New Point(918, 426)
        LicencePanel.Location = New Point(227, 58)
        LicencePanel.BringToFront()
    End Sub

    Private Sub RenameLicenceButton_Click(sender As Object, e As EventArgs) Handles RenameLicenceButton.Click
        Dim FileLoc As String = Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\0009XXXXXXXXXXX.LIC"
        Dim ToRename As String = Clipboard.GetText & ".LIC"
        If My.Computer.FileSystem.FileExists(FileLoc) Then
            My.Computer.FileSystem.RenameFile(FileLoc, ToRename)
        Else
            MsgBox("Unable to locate downloaded licence file inside folder: \Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB. Application will now Delete this folder, if this happens on a regular occurrance Please re-download it. You'll need to delete: D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip then click restart.", MsgBoxStyle.Critical, "Missing File")
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\", DeleteDirectoryOption.DeleteAllContents)
            RenameLicenceButton.Enabled = False
            Step4.Enabled = False
            Step3.Enabled = True
            MsgBox("Please Extract D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip, then try again with the rename function. Click Next to continue.", MsgBoxStyle.Information, "Important information")
        End If
        RenameLicenceButton.Enabled = False
    End Sub

    Private Sub OpenStep5Panel_Tick(sender As Object, e As EventArgs) Handles OpenStep5Panel.Tick
        Step5Progress.Increment(1)
        Step5Panel.Size = New Point(1373, Step5Progress.Value)
        If Step5Progress.Value = Step5Progress.Maximum Then
            OpenStep5Panel.Stop()
            LicenceCopyFromLocation.Navigate(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
            LicenceCopyToLocation.Navigate("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
        End If
    End Sub

    Private Sub LicenceAllocationClose_Click(sender As Object, e As EventArgs) Handles LicenceAllocationClose.Click
        LicenceAllocationClose.Enabled = False
        CloseStep5Panel.Start()
    End Sub

    Private Sub CloseStep5Panel_Tick(sender As Object, e As EventArgs) Handles CloseStep5Panel.Tick
        Step5Progress.Value -= 1
        Step5Panel.Size = New Point(1373, Step5Progress.Value)
        If Step5Progress.Value = Step5Progress.Minimum Then
            CloseStep5Panel.Start()
            If LicenceAllocationClose.Enabled = True Then
                My.Settings.PatchComplete = "1"
                My.Settings.Save()
                Form1.Close()
                Launcher.SmartButton.Text = "Play"
                Launcher.BringToFront()
                Close()
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        LicDoneButton.Visible = True
    End Sub

    Private Sub LicDoneButton_Click(sender As Object, e As EventArgs) Handles LicDoneButton.Click
        CloseStep5Panel.Start()
    End Sub

    Private Sub LogInButton2_Click_1(sender As Object, e As EventArgs) Handles LogInButton2.Click
        LogInButton2.Enabled = False
        Phase1()
    End Sub

    Public Sub Phase1()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\")
        End If
        Phase2()
    End Sub

    Public Sub Phase2()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\")
        End If
        Phase3()
    End Sub
    Public Sub Phase3()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\")
        End If
        Phase4()
    End Sub
    Public Sub Phase4()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\")
        End If
        Phase5()
    End Sub
    Public Sub Phase5()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\")
        End If
        Phase6()
    End Sub

    Public Sub Phase6()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
        End If
        Allocation()
    End Sub

    Public Sub Allocation()
        OpenStep5Panel.Start()
    End Sub

    Private Sub DLC1_Click(sender As Object, e As EventArgs) Handles DLC1.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC1.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC1.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC1.Enabled = False
            DLC2.Enabled = True
        End If
    End Sub

    Private Sub DLC2_Click(sender As Object, e As EventArgs) Handles DLC2.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC2.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC2.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC2.Enabled = False
            DLC3.Enabled = True
        End If
    End Sub

    Private Sub DLC3_Click(sender As Object, e As EventArgs) Handles DLC3.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC3.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC3.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC3.Enabled = False
            DLC4.Enabled = True
        End If
    End Sub

    Private Sub DLC4_Click(sender As Object, e As EventArgs) Handles DLC4.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC4.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC4.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC4.Enabled = False
            Step2.Enabled = True
        End If
    End Sub

    Private Sub DLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildUserList()
    End Sub

    Public Sub BuildUserList()
        InitialSetupTimerOPEN.Start()
        Dim grabusers() As String = IO.Directory.GetDirectories("C:\Users", "*")
        Dim users As String
        ComboBox1.Items.Add("Select One*")
        ComboBox1.SelectedIndex = 0
        For Each users In grabusers
            ComboBox1.Items.Add(users.Replace("C:\Users\", ""))
        Next
    End Sub

    Private Sub InitialSetupTimer_Tick(sender As Object, e As EventArgs) Handles InitialSetupTimerOPEN.Tick
        UserProgressBar.Increment(1)
        UsernameSetup.Size = New Point(880, UserProgressBar.Value)
        If UserProgressBar.Value = UserProgressBar.Maximum Then
            InitialSetupTimerOPEN.Stop()
            If My.Computer.FileSystem.DirectoryExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC") Then
                DeleteDLCCheckBox.Visible = True
            End If
            If Not My.Settings.username = "" Then
                    InitialSetupTimerCLOSE.Start()
                End If
            End If
    End Sub

    Private Sub InitialSetupTimerCLOSE_Tick(sender As Object, e As EventArgs) Handles InitialSetupTimerCLOSE.Tick
        UserProgressBar.Value -= 1
        UsernameSetup.Size = New Point(880, UserProgressBar.Value)
        If UserProgressBar.Value = UserProgressBar.Minimum Then
            InitialSetupTimerCLOSE.Stop()
            Step1.Enabled = True
            ChangeUsernameButton.Visible = True
        End If
    End Sub

    Private Sub ChangeUsernameButton_Click(sender As Object, e As EventArgs) Handles ChangeUsernameButton.Click
        My.Settings.username = ""
        My.Settings.Save()
        ComboBox1.SelectedIndex = 0
        InitialSetupTimerOPEN.Start()
        ChangeUsernameButton.Visible = False
    End Sub

    Private Sub UsernameSaveButton_Click(sender As Object, e As EventArgs) Handles UsernameSaveButton.Click
        If DeleteDLCCheckBox.Checked = True Then
            DLCdeleteConfirmation.show()
        ElseIf DeleteDLCCheckBox.Checked = False Then
            My.Settings.username = ComboBox1.SelectedItem
            My.Settings.Save()
            InitialSetupTimerCLOSE.Start()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            UsernameSaveButton.Enabled = False
        ElseIf Not ComboBox1.SelectedIndex = 0 Then
            UsernameSaveButton.Enabled = True
        End If
    End Sub

    Private Sub DLC1_EnabledChanged(sender As Object, e As EventArgs) Handles DLC1.EnabledChanged
        If DLC1.Enabled = True Then
            DLC1.BorderColour = Color.Lime
        ElseIf DLC1.Enabled = False Then
            DLC1.BorderColour = Color.FromArgb(25, 25, 25)
        End If
    End Sub

    Private Sub DLC2_EnabledChanged(sender As Object, e As EventArgs) Handles DLC2.EnabledChanged
        If DLC2.Enabled = True Then
            DLC2.BorderColour = Color.Lime
            DLC1.BorderColour = Color.FromArgb(25, 25, 25)
        ElseIf DLC2.Enabled = False Then
            DLC2.BorderColour = Color.FromArgb(25, 25, 25)
        End If
    End Sub

    Private Sub DLC3_EnabledChanged(sender As Object, e As EventArgs) Handles DLC3.EnabledChanged
        If DLC3.Enabled = True Then
            DLC3.BorderColour = Color.Lime
            DLC2.BorderColour = Color.FromArgb(25, 25, 25)
        ElseIf DLC3.Enabled = False Then
            Dim color As Color = Color.FromArgb(25, 25, 25)
            DLC3.BorderColour = color
        End If
    End Sub

    Private Sub DLC4_EnabledChanged(sender As Object, e As EventArgs) Handles DLC4.EnabledChanged
        If DLC4.Enabled = True Then
            DLC4.BorderColour = Color.Lime
            DLC3.BorderColour = Color.FromArgb(25, 25, 25)
        ElseIf DLC4.Enabled = False Then
            DLC4.BorderColour = Color.FromArgb(25, 25, 25)
        End If
    End Sub

    Private Sub RenameLicenceButton_EnabledChanged(sender As Object, e As EventArgs) Handles RenameLicenceButton.EnabledChanged
        If RenameLicenceButton.Enabled = True Then
            RenameLicenceButton.BorderColour = Color.Lime
        ElseIf RenameLicenceButton.Enabled = False Then
            RenameLicenceButton.BorderColour = Color.FromArgb(25, 25, 25)
            DLC4.BorderColour = Color.FromArgb(25, 25, 25)
        End If
    End Sub

    Private Sub LogInButton2_EnabledChanged(sender As Object, e As EventArgs) Handles LogInButton2.EnabledChanged
        If LogInButton2.Enabled = True Then
            LogInButton2.BorderColour = Color.Lime
        ElseIf LogInButton2.Enabled = False Then
            LogInButton2.BorderColour = Color.FromArgb(25, 25, 25)
        End If
    End Sub

    Private Sub LogInButton3_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        Launcher.RecallDLC()
    End Sub

    'C:\Users\" & USERNAME & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\
    'C:\Users\" & USERNAME & "\Saved Games\Lionhead Studios\Fable 3 - as reference
End Class