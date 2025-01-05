<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Step3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step3))
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.Pane2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LicDoneButton = New Fable_III_Patcher.LogInButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LogInLabel5 = New Fable_III_Patcher.LogInLabel()
        Me.LicenceCopyToLocation = New System.Windows.Forms.WebBrowser()
        Me.LicenceCopyFromLocation = New System.Windows.Forms.WebBrowser()
        Me.Pane1 = New System.Windows.Forms.Panel()
        Me.DoneButton = New Fable_III_Patcher.LogInButton()
        Me.LogInLabel4 = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel2 = New Fable_III_Patcher.LogInLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenPane1 = New System.Windows.Forms.Timer(Me.components)
        Me.ClosePane1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenPane2 = New System.Windows.Forms.Timer(Me.components)
        Me.ClosePane2 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1.SuspendLayout()
        Me.Pane2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pane1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LogInThemeContainer1.Controls.Add(Me.Pane2)
        Me.LogInThemeContainer1.Controls.Add(Me.Pane1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Patcher | Installation Final Step"
        '
        'Pane2
        '
        Me.Pane2.Controls.Add(Me.ProgressBar1)
        Me.Pane2.Controls.Add(Me.LicDoneButton)
        Me.Pane2.Controls.Add(Me.PictureBox2)
        Me.Pane2.Controls.Add(Me.LogInLabel5)
        Me.Pane2.Controls.Add(Me.LicenceCopyToLocation)
        Me.Pane2.Controls.Add(Me.LicenceCopyFromLocation)
        Me.Pane2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pane2.Location = New System.Drawing.Point(0, 450)
        Me.Pane2.Name = "Pane2"
        Me.Pane2.Size = New System.Drawing.Size(800, 0)
        Me.Pane2.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 390)
        Me.ProgressBar1.Maximum = 416
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'LicDoneButton
        '
        Me.LicDoneButton.BackColor = System.Drawing.Color.Transparent
        Me.LicDoneButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LicDoneButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LicDoneButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicDoneButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LicDoneButton.Location = New System.Drawing.Point(363, 382)
        Me.LicDoneButton.Name = "LicDoneButton"
        Me.LicDoneButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LicDoneButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicDoneButton.Size = New System.Drawing.Size(82, 31)
        Me.LicDoneButton.TabIndex = 10
        Me.LicDoneButton.Text = "Done"
        Me.LicDoneButton.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.chevron
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(328, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 312)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LogInLabel5
        '
        Me.LogInLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogInLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel5.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.LogInLabel5.Location = New System.Drawing.Point(179, 15)
        Me.LogInLabel5.Name = "LogInLabel5"
        Me.LogInLabel5.Size = New System.Drawing.Size(418, 39)
        Me.LogInLabel5.TabIndex = 6
        Me.LogInLabel5.Text = "Copy all the files in the left box to the right box!"
        Me.LogInLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LicenceCopyToLocation
        '
        Me.LicenceCopyToLocation.Location = New System.Drawing.Point(478, 64)
        Me.LicenceCopyToLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LicenceCopyToLocation.Name = "LicenceCopyToLocation"
        Me.LicenceCopyToLocation.ScriptErrorsSuppressed = True
        Me.LicenceCopyToLocation.Size = New System.Drawing.Size(310, 312)
        Me.LicenceCopyToLocation.TabIndex = 8
        '
        'LicenceCopyFromLocation
        '
        Me.LicenceCopyFromLocation.Location = New System.Drawing.Point(12, 64)
        Me.LicenceCopyFromLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LicenceCopyFromLocation.Name = "LicenceCopyFromLocation"
        Me.LicenceCopyFromLocation.ScriptErrorsSuppressed = True
        Me.LicenceCopyFromLocation.Size = New System.Drawing.Size(310, 312)
        Me.LicenceCopyFromLocation.TabIndex = 7
        '
        'Pane1
        '
        Me.Pane1.Controls.Add(Me.DoneButton)
        Me.Pane1.Controls.Add(Me.LogInLabel4)
        Me.Pane1.Controls.Add(Me.LogInLabel2)
        Me.Pane1.Controls.Add(Me.PictureBox1)
        Me.Pane1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pane1.Location = New System.Drawing.Point(0, 450)
        Me.Pane1.Name = "Pane1"
        Me.Pane1.Size = New System.Drawing.Size(800, 0)
        Me.Pane1.TabIndex = 0
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.Color.Transparent
        Me.DoneButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DoneButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DoneButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DoneButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DoneButton.Location = New System.Drawing.Point(362, 378)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DoneButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DoneButton.Size = New System.Drawing.Size(75, 30)
        Me.DoneButton.TabIndex = 5
        Me.DoneButton.Text = "Done"
        '
        'LogInLabel4
        '
        Me.LogInLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogInLabel4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.LogInLabel4.Location = New System.Drawing.Point(138, 8)
        Me.LogInLabel4.Name = "LogInLabel4"
        Me.LogInLabel4.Size = New System.Drawing.Size(519, 33)
        Me.LogInLabel4.TabIndex = 4
        Me.LogInLabel4.Text = "Licence Setup - XUID Grabber"
        Me.LogInLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(227, 40)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(344, 30)
        Me.LogInLabel2.TabIndex = 3
        Me.LogInLabel2.Text = "Enter Your Xbox Gamertag below then click Get." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will fetch your unique ID. P" &
    "lease Copy the XUID (HEX) code."
        Me.LogInLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(86, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(621, 299)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OpenPane1
        '
        Me.OpenPane1.Interval = 1
        '
        'ClosePane1
        '
        Me.ClosePane1.Interval = 1
        '
        'OpenPane2
        '
        Me.OpenPane2.Interval = 1
        '
        'ClosePane2
        '
        Me.ClosePane2.Interval = 1
        '
        'Step3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Step3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 3"
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.Pane2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pane1.ResumeLayout(False)
        Me.Pane1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents Pane1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents LogInLabel4 As LogInLabel
    Friend WithEvents DoneButton As LogInButton
    Friend WithEvents Pane2 As Panel
    Friend WithEvents LicDoneButton As LogInButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LogInLabel5 As LogInLabel
    Friend WithEvents LicenceCopyToLocation As WebBrowser
    Friend WithEvents LicenceCopyFromLocation As WebBrowser
    Friend WithEvents OpenPane1 As Timer
    Friend WithEvents ClosePane1 As Timer
    Friend WithEvents OpenPane2 As Timer
    Friend WithEvents ClosePane2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
