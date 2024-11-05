<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Step2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.DLCgoBack = New Fable_III_Patcher.LogInButton()
        Me.DownloadedFilesgoBack = New Fable_III_Patcher.LogInButton()
        Me.LogInButton1 = New Fable_III_Patcher.LogInButton()
        Me.Fable3DLCLocation = New System.Windows.Forms.WebBrowser()
        Me.DownloadedFiles = New System.Windows.Forms.WebBrowser()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.Step5Progress = New System.Windows.Forms.ProgressBar()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = True
        Me.LogInThemeContainer1.AllowMaximize = False
        Me.LogInThemeContainer1.AllowMinimize = False
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.DLCgoBack)
        Me.LogInThemeContainer1.Controls.Add(Me.DownloadedFilesgoBack)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInButton1)
        Me.LogInThemeContainer1.Controls.Add(Me.Fable3DLCLocation)
        Me.LogInThemeContainer1.Controls.Add(Me.DownloadedFiles)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel1)
        Me.LogInThemeContainer1.Controls.Add(Me.Step5Progress)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Patcher | Installation Step 2"
        '
        'DLCgoBack
        '
        Me.DLCgoBack.BackColor = System.Drawing.Color.Transparent
        Me.DLCgoBack.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLCgoBack.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLCgoBack.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLCgoBack.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLCgoBack.Location = New System.Drawing.Point(639, 406)
        Me.DLCgoBack.Name = "DLCgoBack"
        Me.DLCgoBack.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLCgoBack.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLCgoBack.Size = New System.Drawing.Size(94, 30)
        Me.DLCgoBack.TabIndex = 18
        Me.DLCgoBack.Text = "Previous Folder"
        '
        'DownloadedFilesgoBack
        '
        Me.DownloadedFilesgoBack.BackColor = System.Drawing.Color.Transparent
        Me.DownloadedFilesgoBack.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DownloadedFilesgoBack.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DownloadedFilesgoBack.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadedFilesgoBack.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DownloadedFilesgoBack.Location = New System.Drawing.Point(68, 404)
        Me.DownloadedFilesgoBack.Name = "DownloadedFilesgoBack"
        Me.DownloadedFilesgoBack.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DownloadedFilesgoBack.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadedFilesgoBack.Size = New System.Drawing.Size(94, 30)
        Me.DownloadedFilesgoBack.TabIndex = 17
        Me.DownloadedFilesgoBack.Text = "Previous Folder"
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(317, 406)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(164, 28)
        Me.LogInButton1.TabIndex = 16
        Me.LogInButton1.Text = "Next Step"
        '
        'Fable3DLCLocation
        '
        Me.Fable3DLCLocation.Location = New System.Drawing.Point(405, 154)
        Me.Fable3DLCLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Fable3DLCLocation.Name = "Fable3DLCLocation"
        Me.Fable3DLCLocation.ScriptErrorsSuppressed = True
        Me.Fable3DLCLocation.Size = New System.Drawing.Size(328, 250)
        Me.Fable3DLCLocation.TabIndex = 12
        '
        'DownloadedFiles
        '
        Me.DownloadedFiles.Location = New System.Drawing.Point(68, 154)
        Me.DownloadedFiles.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DownloadedFiles.Name = "DownloadedFiles"
        Me.DownloadedFiles.ScriptErrorsSuppressed = True
        Me.DownloadedFiles.Size = New System.Drawing.Size(328, 250)
        Me.DownloadedFiles.TabIndex = 15
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(65, 45)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(671, 105)
        Me.LogInLabel1.TabIndex = 13
        Me.LogInLabel1.Text = resources.GetString("LogInLabel1.Text")
        '
        'Step5Progress
        '
        Me.Step5Progress.Location = New System.Drawing.Point(225, 256)
        Me.Step5Progress.Maximum = 542
        Me.Step5Progress.Name = "Step5Progress"
        Me.Step5Progress.Size = New System.Drawing.Size(100, 23)
        Me.Step5Progress.TabIndex = 14
        Me.Step5Progress.Visible = False
        '
        'Step2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Step2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step2"
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents DLCgoBack As LogInButton
    Friend WithEvents DownloadedFilesgoBack As LogInButton
    Friend WithEvents LogInButton1 As LogInButton
    Friend WithEvents Fable3DLCLocation As WebBrowser
    Friend WithEvents DownloadedFiles As WebBrowser
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents Step5Progress As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
