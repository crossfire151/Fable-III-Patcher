Public Class GFWL_Uninstall_Helper

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region

    Dim Language = My.Settings.Lang

    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        SetupInstaller.MetroSetButton3.Enabled = False
        SetupInstaller.MetroSetButton4.Enabled = True
        Close()
    End Sub

    Private Sub MetroSetButton13_Click(sender As Object, e As EventArgs) Handles MetroSetButton13.Click
        Close()
    End Sub

    Private Sub MetroSetButton12_Click(sender As Object, e As EventArgs) Handles MetroSetButton12.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GFWL_Uninstall_Helper_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lang()
    End Sub

    Public Sub Lang()
        If Language = "English" Then
            'DO NOTHING
        ElseIf Language = "Polish" Then
            MetroSetButton1.Text = "Zakończ"
            MetroSetLabel1.Text = "1. Kliknij ""Zainstalowano"" w pasku sortowania, by GFWL i Marketplace pojawiły się na górze." & vbNewLine & "2. Odinstaluj zarówno Microsoft Games For Windows Live Redistributable i Microsoft Games For Windows Live Marketplace." & vbNewLine & "3. Kliknij ""Zakończ"", kiedy oba programy zostaną odinstalowane."
        End If
    End Sub
End Class