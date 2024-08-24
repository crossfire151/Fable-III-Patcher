<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloader))
        Me.DownloadGoStart = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ExitButton = New Fable_III_Patcher.LogInButton()
        Me.RequestedFile = New System.Windows.Forms.Label()
        Me.Percentage = New Fable_III_Patcher.LogInLabel()
        Me.DownloadProgress = New Fable_III_Patcher.LogInProgressBar()
        Me.StatusText = New Fable_III_Patcher.LogInLabel()
        Me.Prepexit = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DownloadGoStart
        '
        Me.DownloadGoStart.Interval = 5000
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = False
        Me.LogInThemeContainer1.AllowMaximize = False
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.ProgressBar1)
        Me.LogInThemeContainer1.Controls.Add(Me.ExitButton)
        Me.LogInThemeContainer1.Controls.Add(Me.RequestedFile)
        Me.LogInThemeContainer1.Controls.Add(Me.Percentage)
        Me.LogInThemeContainer1.Controls.Add(Me.DownloadProgress)
        Me.LogInThemeContainer1.Controls.Add(Me.StatusText)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(591, 227)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "DLC Downloader"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(464, 192)
        Me.ProgressBar1.Maximum = 5
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 5
        Me.ProgressBar1.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ExitButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ExitButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(201, 128)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ExitButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.Size = New System.Drawing.Size(189, 48)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Close Downloader"
        Me.ExitButton.Visible = False
        '
        'RequestedFile
        '
        Me.RequestedFile.AutoSize = True
        Me.RequestedFile.Location = New System.Drawing.Point(15, 41)
        Me.RequestedFile.Name = "RequestedFile"
        Me.RequestedFile.Size = New System.Drawing.Size(0, 13)
        Me.RequestedFile.TabIndex = 3
        Me.RequestedFile.Visible = False
        '
        'Percentage
        '
        Me.Percentage.BackColor = System.Drawing.Color.Transparent
        Me.Percentage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Percentage.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Percentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Percentage.Location = New System.Drawing.Point(12, 102)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(552, 23)
        Me.Percentage.TabIndex = 2
        Me.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DownloadProgress
        '
        Me.DownloadProgress.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DownloadProgress.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DownloadProgress.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DownloadProgress.Location = New System.Drawing.Point(15, 74)
        Me.DownloadProgress.Maximum = 100
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.DownloadProgress.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DownloadProgress.Size = New System.Drawing.Size(549, 25)
        Me.DownloadProgress.TabIndex = 1
        Me.DownloadProgress.TwoColour = True
        Me.DownloadProgress.Value = 0
        Me.DownloadProgress.Visible = False
        '
        'StatusText
        '
        Me.StatusText.AutoSize = True
        Me.StatusText.BackColor = System.Drawing.Color.Transparent
        Me.StatusText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusText.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusText.Location = New System.Drawing.Point(12, 203)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(42, 15)
        Me.StatusText.TabIndex = 0
        Me.StatusText.Text = "Status:"
        '
        'Prepexit
        '
        Me.Prepexit.Interval = 1000
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Downloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents StatusText As LogInLabel
    Friend WithEvents Percentage As LogInLabel
    Friend WithEvents DownloadProgress As LogInProgressBar
    Friend WithEvents RequestedFile As Label
    Friend WithEvents ExitButton As LogInButton
    Friend WithEvents DownloadGoStart As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Prepexit As Timer
End Class
