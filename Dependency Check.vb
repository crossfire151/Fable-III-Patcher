Imports System.ComponentModel

Public Class Dependency_Check

    Dim Language As String = My.Settings.Lang

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 1 Then
            If Language = "English" Then
                ListBox1.Items.Add("Searching for /resources folder...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Szukanie folderu /resources...")
            End If
        ElseIf ProgressBar1.Value = 5 Then
            If Language = "English" Then
                If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\resources") Then
                    ListBox1.Items.Add("/resources folder Not Found.")
                Else
                    ListBox1.Items.Add("/resources folder found!")
                End If
            ElseIf Language = "Polish" Then
                If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\resources") Then
                    ListBox1.Items.Add("Folder /resources nie został znaleziony.")
                Else
                    ListBox1.Items.Add("Folder /resources został znaleziony!")
                End If
            End If
        ElseIf ProgressBar1.Value = 8 Then
            If Language = "English" Then
                If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\resources") Then
                    ListBox1.Items.Add("Creating new folder: /resources...")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\resources")
                    ListBox1.Items.Add("Created: /resources folder: SUCCESS.")
                End If
            ElseIf Language = "Polish" Then
                If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\resources") Then
                    ListBox1.Items.Add("Tworzenie nowego folderu: /resources...")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\resources")
                    ListBox1.Items.Add("Tworzenie folderu /resources: SUKCES.")
                End If
            End If
        ElseIf ProgressBar1.Value = 15 Then
            If Language = "English" Then
                ListBox1.Items.Add("Validating resources 0/5...")
                ListBox1.Items.Add("Validating resources 1/5...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Weryfikowanie zasobów 0/5...")
                ListBox1.Items.Add("Weryfikowanie zasobów 1/5...")
            End If
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\resources\gfwlclient.msi") Then
                System.IO.File.WriteAllBytes(Application.StartupPath & "\resources\gfwlclient.msi", My.Resources.gfwlclient)
            End If
        ElseIf ProgressBar1.Value = 20 Then
            If Language = "English" Then
                ListBox1.Items.Add("Validating resources 2/5...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Weryfikowanie zasobów 2/5...")
            End If
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\resources\gfwlivesetup.exe") Then
                System.IO.File.WriteAllBytes(Application.StartupPath & "\resources\gfwlivesetup.exe", My.Resources.gfwlivesetup)
            End If
        ElseIf ProgressBar1.Value = 25 Then
            If Language = "English" Then
                ListBox1.Items.Add("Validating resources 3/5...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Weryfikowanie zasobów 3/5...")
            End If
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\resources\wllogin_32.msi") Then
                System.IO.File.WriteAllBytes(Application.StartupPath & "\resources\wllogin_32.msi", My.Resources.wllogin_32)
            End If
        ElseIf ProgressBar1.Value = 30 Then
            If Language = "English" Then
                ListBox1.Items.Add("Validating resources 4/5...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Weryfikowanie zasobów 4/5...")
            End If
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\resources\wllogin_64.msi") Then
                System.IO.File.WriteAllBytes(Application.StartupPath & "\resources\wllogin_64.msi", My.Resources.wllogin_64)
            End If
        ElseIf ProgressBar1.Value = 35 Then
            If Language = "English" Then
                ListBox1.Items.Add("Validating resources 5/5...")
            ElseIf Language = "Polish" Then
                ListBox1.Items.Add("Weryfikowanie zasobów 5/5...")
            End If
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\resources\xliveredist.msi") Then
                System.IO.File.WriteAllBytes(Application.StartupPath & "\resources\xliveredist.msi", My.Resources.xliveredist)
            End If
        ElseIf ProgressBar1.Value = 80 Then
            Timer1.Interval = 1
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Form1.MetroSetButton1.Enabled = True
            Form1.MetroSetButton15.Visible = True
            Close()
        End If
    End Sub

    Private Sub Dependency_Check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.LinkLabel1.Enabled = False
        Lang()
    End Sub

    Private Sub Dependency_Check_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.LinkLabel1.Enabled = True
    End Sub

    Public Sub Lang()
        If Language = "English" Then
            'DO NOTING
        ElseIf Language = "Polish" Then
            Label1.Text = "Weryfikowanie zależnych..."
            Label2.Text = "Dziennik"
        End If
        Timer1.Start()
    End Sub
End Class