Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        If Not My.Settings.Lang = "" Then
            Hide()
            Launcher.Show()
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Lang = ComboBox1.SelectedItem
        My.Settings.Save()
        Launcher.Show()
        Close()
    End Sub

    Private Sub ComboBox1_ValueMemberChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Lang()
    End Sub

    Public Sub Lang()
        If ComboBox1.SelectedItem = "English" Then
            Text = "Choose your Language"
            Button1.Text = "Save"
            Label1.Text = "More Languages coming soon."
        ElseIf ComboBox1.SelectedItem = "Polish" Then
            Text = "Wybierz Język"
            Button1.Text = "Zapisz"
            Label1.Text = "Więcej języków zostanie dodanych później."
        End If
    End Sub

    'Notes:
    'NONE
End Class