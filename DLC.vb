Imports System.Data.Common
Imports System.Net
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
        'NEW AUTO FUNCTION -><> Licence Setup- Auto Click
        LicencePanel.Visible = True
        LicencePanel.Size = New Point(918, 426)
        LicencePanel.Location = New Point(227, 58)
        LicencePanel.BringToFront()
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
        If My.Computer.FileSystem.FileExists("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\" & ToRename) Then
            Beep()
        Else
            Try
                My.Computer.FileSystem.RenameFile(FileLoc, ToRename)
            Catch ex As Exception

            End Try
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
            DLC1.BorderColour = Color.FromArgb(25, 25, 25)
            DLC2.Enabled = True
            DLC2.BorderColour = Color.Lime
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
            DLC2.BorderColour = Color.FromArgb(25, 25, 25)
            DLC3.Enabled = True
            DLC3.BorderColour = Color.Lime
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
            DLC3.BorderColour = Color.FromArgb(25, 25, 25)
            DLC4.Enabled = True
            DLC4.BorderColour = Color.Lime
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
            DLC4.BorderColour = Color.FromArgb(25, 25, 25)
            Step2.Enabled = True
            LogInButton1.BorderColour = Color.Lime
            'NEW - AutoGO next function ->
            FolderBrowserDialog1.ShowDialog()
            If Not FolderBrowserDialog1.SelectedPath = "" Then
                SaveLocationButton.Tag = FolderBrowserDialog1.SelectedPath
                SaveLocationButton.Enabled = False
                My.Computer.FileSystem.CreateDirectory(SaveLocationButton.Tag & "\DLC")
                Step3.Enabled = True
                DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
                Fable3DLCLocation.Navigate(SaveLocationButton.Tag & "\DLC")
            End If
        End If
    End Sub

    Private Sub DLC_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ComboBox1.SelectedIndex = 0
        InitialSetupTimerOPEN.Start()
        ChangeUsernameButton.Visible = False
    End Sub

    Private Sub UsernameSaveButton_Click(sender As Object, e As EventArgs) Handles UsernameSaveButton.Click
        MsgBox(ComboBox1.SelectedItem)
        My.Settings.username = ComboBox1.SelectedItem
        My.Settings.Save()
        InitialSetupTimerCLOSE.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            UsernameSaveButton.Enabled = False
        ElseIf Not ComboBox1.SelectedIndex = 0 Then
            UsernameSaveButton.Enabled = True
        End If
    End Sub

    'C:\Users\" & USERNAME & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\
    'C:\Users\" & USERNAME & "\Saved Games\Lionhead Studios\Fable 3 - as reference
End Class