Public Class CompatibilityHelper


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
    Dim Language As String = My.Settings.Lang
    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        Form1.MetroSetButton11.Enabled = False
        Form1.MetroSetButton2.Enabled = True
        Close()
    End Sub

    Private Sub MetroSetButton13_Click(sender As Object, e As EventArgs) Handles MetroSetButton13.Click
        Close()
    End Sub

    Private Sub MetroSetButton12_Click(sender As Object, e As EventArgs) Handles MetroSetButton12.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CompatibilityHelper_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lang()
    End Sub

    Public Sub Lang()
        If Language = "English" Then
            'DO NOTHING
        ElseIf Language = "Polish" Then
            MetroSetButton1.Text = "Zakończ"
            MetroSetLabel1.Text = "1. Znajdź plik Fable3.exe" & vbNewLine & "2. Kliknij na nim prawym przyciskiem myszy i wybierz ""Właściwości""" & vbNewLine & "3. Kliknij na zakładkę ""Zgodność""." & vbNewLine & "4. Zaznacz ""Uruchom ten program w trybie zgodności z:"" i upewnij się, że jest wybrany Windows 7." & vbNewLine & "5.Kliknij ""Zastosuj"", a potem ""OK""." & vbNewLine & "Powtórz wyżej wymienione czynności dla pliku FableLauncher.exe" & vbNewLine & "Po wykonaniu tych czynności dla obu plików, kliknij ""Zakończ""."

        End If
    End Sub
End Class