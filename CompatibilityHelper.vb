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
End Class