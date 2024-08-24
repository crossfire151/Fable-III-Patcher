Imports Microsoft.VisualBasic.FileIO
Imports EO.WebBrowser


Public Class Step3
    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If DoneButton.Text = "Done" Then
            If Clipboard.GetText = "" Then
                MsgBox("It appears you have not copied anything. This information is required in order to enable usage of the DLC.", MsgBoxStyle.Critical, "Missing information")
            Else
                MsgBox("Great, here's what we found in your clipboard: " & Clipboard.GetText & ". Please click Confirm if this is correct, if not; please try again.", MsgBoxStyle.Information, "We found this")
                DoneButton.Text = "Confirm"
            End If
        ElseIf DoneButton.Text = "Confirm" Then
            Dim FileLoc As String = Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\0009XXXXXXXXXXX.LIC"
            Dim ToRename As String = Clipboard.GetText & ".LIC"
            If My.Computer.FileSystem.FileExists(FileLoc) Then
                My.Computer.FileSystem.RenameFile(FileLoc, ToRename)
                MsgBox("Licence file successfully updated! - Final stage, assign licence files. Click OK to start!", MsgBoxStyle.Information)
                ClosePane1.Start()
            Else
                MsgBox("Unable to locate downloaded licence file inside folder: \Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB. Application will now Delete this folder, if this happens on a regular occurrance Please re-download it. You'll need to delete: D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip then click restart.", MsgBoxStyle.Critical, "Missing File")
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\", DeleteDirectoryOption.DeleteAllContents)
                MsgBox("Restarting Installation with Fresh files, press OK to continue.", MsgBoxStyle.Information, "Important information")
                S1.Show()
                Close()
            End If
        End If
    End Sub

    Private Sub LicenceCopyFromLocation_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles LicenceCopyFromLocation.DocumentCompleted

    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        LicDoneButton.Visible = True
    End Sub

    Private Sub LicDoneButton_Click(sender As Object, e As EventArgs) Handles LicDoneButton.Click
        ClosePane2.Start()
    End Sub

    Private Sub ClosePane2_Tick(sender As Object, e As EventArgs) Handles ClosePane2.Tick
        ProgressBar1.Value -= 1
        Pane2.Size = New Point(800, ProgressBar1.Value)
        If ProgressBar1.Value = ProgressBar1.Minimum Then
            ClosePane2.Stop()
            Hide()
            DLC.Close()
            Launcher.SmartButton.Text = "Play"
            Launcher.BringToFront()
            If Form1.Visible = True Then
                Form1.Close()
            End If
            My.Settings.PatchComplete = "1"
            My.Settings.Save()
            Close()
        End If
    End Sub

    Private Sub OpenPane2_Tick(sender As Object, e As EventArgs) Handles OpenPane2.Tick
        ProgressBar1.Increment(1)
        Pane2.Size = New Point(800, ProgressBar1.Value)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            OpenPane2.Stop()
            LicenceCopyFromLocation.Navigate(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
            LicenceCopyToLocation.Navigate("C:\Users\" & My.Settings.username & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
        End If
    End Sub

    Private Sub OpenPane1_Tick(sender As Object, e As EventArgs) Handles OpenPane1.Tick
        ProgressBar1.Increment(1)
        Pane1.Size = New Point(800, ProgressBar1.Value)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            OpenPane1.Stop()
        End If
    End Sub

    Private Sub ClosePane1_Tick(sender As Object, e As EventArgs) Handles ClosePane1.Tick
        ProgressBar1.Value -= 1
        Pane1.Size = New Point(800, ProgressBar1.Value)
        If ProgressBar1.Value = ProgressBar1.Minimum Then
            ClosePane1.Stop()
            OpenPane2.Start()
        End If
    End Sub

    Private xuuid As New EO.WebBrowser.WebView

    Private Sub Step3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenPane1.Start()
        EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP")
        xuuid.Url = "https://cxkes.me/xbox/xuid"
        xuuid.Create(PictureBox1.Handle)
    End Sub
End Class