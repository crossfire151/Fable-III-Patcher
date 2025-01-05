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
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.LogInGroupBox1 = New Fable_III_Patcher.LogInGroupBox()
        Me.TrackingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ExtractStatus = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel2 = New Fable_III_Patcher.LogInLabel()
        Me.LogInRadialProgressBar1 = New Fable_III_Patcher.LogInRadialProgressBar()
        Me.DownloadedFilesgoBack = New Fable_III_Patcher.LogInButton()
        Me.DLCgoBack = New Fable_III_Patcher.LogInButton()
        Me.LoginButton1 = New Fable_III_Patcher.LogInButton()
        Me.Fable3DLCLocation = New System.Windows.Forms.WebBrowser()
        Me.DownloadedFiles = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Extraction = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = True
        Me.LogInThemeContainer1.AllowMaximize = True
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.LogInGroupBox1)
        Me.LogInThemeContainer1.Controls.Add(Me.DownloadedFilesgoBack)
        Me.LogInThemeContainer1.Controls.Add(Me.DLCgoBack)
        Me.LogInThemeContainer1.Controls.Add(Me.LoginButton1)
        Me.LogInThemeContainer1.Controls.Add(Me.Fable3DLCLocation)
        Me.LogInThemeContainer1.Controls.Add(Me.DownloadedFiles)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Patcher | Installation Step 2 of 3"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.TrackingProgressBar)
        Me.LogInGroupBox1.Controls.Add(Me.ExtractStatus)
        Me.LogInGroupBox1.Controls.Add(Me.LogInLabel1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInLabel2)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadialProgressBar1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(39, 49)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(730, 313)
        Me.LogInGroupBox1.TabIndex = 3
        Me.LogInGroupBox1.Text = "Extraction Wizzard - Version 1"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TrackingProgressBar
        '
        Me.TrackingProgressBar.Location = New System.Drawing.Point(659, 49)
        Me.TrackingProgressBar.Maximum = 5
        Me.TrackingProgressBar.Minimum = 1
        Me.TrackingProgressBar.Name = "TrackingProgressBar"
        Me.TrackingProgressBar.Size = New System.Drawing.Size(60, 2)
        Me.TrackingProgressBar.TabIndex = 8
        Me.TrackingProgressBar.Value = 1
        Me.TrackingProgressBar.Visible = False
        '
        'ExtractStatus
        '
        Me.ExtractStatus.AutoSize = True
        Me.ExtractStatus.BackColor = System.Drawing.Color.Transparent
        Me.ExtractStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExtractStatus.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExtractStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExtractStatus.Location = New System.Drawing.Point(51, 295)
        Me.ExtractStatus.Name = "ExtractStatus"
        Me.ExtractStatus.Size = New System.Drawing.Size(119, 15)
        Me.ExtractStatus.TabIndex = 7
        Me.ExtractStatus.Text = "Awaiting Extraction..."
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(3, 295)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(42, 15)
        Me.LogInLabel1.TabIndex = 6
        Me.LogInLabel1.Text = "Status:"
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(656, 30)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(0, 15)
        Me.LogInLabel2.TabIndex = 5
        '
        'LogInRadialProgressBar1
        '
        Me.LogInRadialProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadialProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadialProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadialProgressBar1.Location = New System.Drawing.Point(224, 48)
        Me.LogInRadialProgressBar1.Maximum = 100
        Me.LogInRadialProgressBar1.Name = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInRadialProgressBar1.RotationAngle = 255
        Me.LogInRadialProgressBar1.Size = New System.Drawing.Size(273, 249)
        Me.LogInRadialProgressBar1.StartingAngle = 110
        Me.LogInRadialProgressBar1.TabIndex = 4
        Me.LogInRadialProgressBar1.Text = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.Value = 0
        '
        'DownloadedFilesgoBack
        '
        Me.DownloadedFilesgoBack.BackColor = System.Drawing.Color.Transparent
        Me.DownloadedFilesgoBack.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DownloadedFilesgoBack.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DownloadedFilesgoBack.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadedFilesgoBack.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DownloadedFilesgoBack.Location = New System.Drawing.Point(369, 201)
        Me.DownloadedFilesgoBack.Name = "DownloadedFilesgoBack"
        Me.DownloadedFilesgoBack.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DownloadedFilesgoBack.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadedFilesgoBack.Size = New System.Drawing.Size(75, 30)
        Me.DownloadedFilesgoBack.TabIndex = 1
        Me.DownloadedFilesgoBack.Text = "LogInButton2"
        Me.DownloadedFilesgoBack.Visible = False
        '
        'DLCgoBack
        '
        Me.DLCgoBack.BackColor = System.Drawing.Color.Transparent
        Me.DLCgoBack.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLCgoBack.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLCgoBack.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLCgoBack.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLCgoBack.Location = New System.Drawing.Point(127, 179)
        Me.DLCgoBack.Name = "DLCgoBack"
        Me.DLCgoBack.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLCgoBack.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLCgoBack.Size = New System.Drawing.Size(75, 30)
        Me.DLCgoBack.TabIndex = 2
        Me.DLCgoBack.Text = "LogInButton3"
        Me.DLCgoBack.Visible = False
        '
        'LoginButton1
        '
        Me.LoginButton1.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoginButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LoginButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LoginButton1.Location = New System.Drawing.Point(334, 368)
        Me.LoginButton1.Name = "LoginButton1"
        Me.LoginButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LoginButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton1.Size = New System.Drawing.Size(149, 40)
        Me.LoginButton1.TabIndex = 2
        Me.LoginButton1.Text = "Begin Extraction..."
        '
        'Fable3DLCLocation
        '
        Me.Fable3DLCLocation.Location = New System.Drawing.Point(295, 64)
        Me.Fable3DLCLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Fable3DLCLocation.Name = "Fable3DLCLocation"
        Me.Fable3DLCLocation.Size = New System.Drawing.Size(250, 250)
        Me.Fable3DLCLocation.TabIndex = 1
        Me.Fable3DLCLocation.Visible = False
        '
        'DownloadedFiles
        '
        Me.DownloadedFiles.Location = New System.Drawing.Point(39, 64)
        Me.DownloadedFiles.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DownloadedFiles.Name = "DownloadedFiles"
        Me.DownloadedFiles.Size = New System.Drawing.Size(250, 250)
        Me.DownloadedFiles.TabIndex = 0
        Me.DownloadedFiles.Visible = False
        '
        'Timer1
        '
        '
        'Extraction
        '
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
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
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.LogInGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents Fable3DLCLocation As WebBrowser
    Friend WithEvents DownloadedFiles As WebBrowser
    Friend WithEvents LoginButton1 As LogInButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Extraction As Timer
    Friend WithEvents DownloadedFilesgoBack As LogInButton
    Friend WithEvents DLCgoBack As LogInButton
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents LogInRadialProgressBar1 As LogInRadialProgressBar
    Friend WithEvents ExtractStatus As LogInLabel
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents TrackingProgressBar As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
