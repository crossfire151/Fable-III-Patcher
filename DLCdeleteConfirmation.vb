Imports Microsoft.VisualBasic.FileIO

Public Class DLCdeleteConfirmation
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        DLC.DeleteDLCCheckBox.Checked = False
        Close()
    End Sub

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Try
            My.Computer.FileSystem.DeleteDirectory("C:\Users\" & DLC.ComboBox1.SelectedItem & "\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\", DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception

        End Try
        Hide()
        MsgBox("Old DLC installation has been deleted. Please continue with the installation.", MsgBoxStyle.Information, "DLC Deleted")
        DLC.InitialSetupTimerCLOSE.Start()
        Close()
    End Sub
End Class