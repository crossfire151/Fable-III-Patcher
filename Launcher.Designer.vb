<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetRestartInstallationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmartLoader = New System.Windows.Forms.Timer(Me.components)
        Me.GetReadyClose = New System.Windows.Forms.Timer(Me.components)
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.LoadingLabel = New Fable_III_Patcher.LogInLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MTUwarn = New Fable_III_Patcher.LogInLabel()
        Me.StatusLabel = New Fable_III_Patcher.LogInLabel()
        Me.SmartButton = New Fable_III_Patcher.LogInButtonWithProgress()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInRichTextBox1 = New Fable_III_Patcher.LogInRichTextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetRestartInstallationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 26)
        '
        'ResetRestartInstallationToolStripMenuItem
        '
        Me.ResetRestartInstallationToolStripMenuItem.Name = "ResetRestartInstallationToolStripMenuItem"
        Me.ResetRestartInstallationToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ResetRestartInstallationToolStripMenuItem.Text = "Reset - Restart Installation"
        '
        'SmartLoader
        '
        Me.SmartLoader.Interval = 120
        '
        'GetReadyClose
        '
        Me.GetReadyClose.Interval = 15000
        '
        'StartupTimer
        '
        Me.StartupTimer.Interval = 6500
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
        Me.LogInThemeContainer1.Controls.Add(Me.LoadingLabel)
        Me.LogInThemeContainer1.Controls.Add(Me.ToolStrip1)
        Me.LogInThemeContainer1.Controls.Add(Me.PictureBox2)
        Me.LogInThemeContainer1.Controls.Add(Me.MTUwarn)
        Me.LogInThemeContainer1.Controls.Add(Me.StatusLabel)
        Me.LogInThemeContainer1.Controls.Add(Me.SmartButton)
        Me.LogInThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInRichTextBox1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(810, 467)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Patcher | With embeded Launcher"
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoadingLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLabel.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoadingLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoadingLabel.Location = New System.Drawing.Point(359, 399)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(96, 23)
        Me.LoadingLabel.TabIndex = 7
        Me.LoadingLabel.Text = "Loading..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(690, 436)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(146, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "Discord Support Server"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Fable_III_Patcher.My.Resources.Resources.Discord_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButton1.Text = "Discord Support"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.Splash
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(9, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(553, 325)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'MTUwarn
        '
        Me.MTUwarn.BackColor = System.Drawing.Color.Transparent
        Me.MTUwarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MTUwarn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTUwarn.FontColour = System.Drawing.Color.Red
        Me.MTUwarn.ForeColor = System.Drawing.Color.Red
        Me.MTUwarn.Location = New System.Drawing.Point(12, 272)
        Me.MTUwarn.Name = "MTUwarn"
        Me.MTUwarn.Size = New System.Drawing.Size(356, 96)
        Me.MTUwarn.TabIndex = 1
        Me.MTUwarn.Text = resources.GetString("MTUwarn.Text")
        Me.MTUwarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MTUwarn.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusLabel.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusLabel.Location = New System.Drawing.Point(306, 440)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 15)
        Me.StatusLabel.TabIndex = 4
        '
        'SmartButton
        '
        Me.SmartButton.BackColor = System.Drawing.Color.Transparent
        Me.SmartButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SmartButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SmartButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SmartButton.Location = New System.Drawing.Point(306, 386)
        Me.SmartButton.Maximum = 100
        Me.SmartButton.Name = "SmartButton"
        Me.SmartButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SmartButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.Size = New System.Drawing.Size(204, 51)
        Me.SmartButton.TabIndex = 3
        Me.SmartButton.Text = "%smart%"
        Me.SmartButton.Value = 0
        Me.SmartButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.Fable3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(9, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 325)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LogInRichTextBox1
        '
        Me.LogInRichTextBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRichTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRichTextBox1.Location = New System.Drawing.Point(568, 46)
        Me.LogInRichTextBox1.Name = "LogInRichTextBox1"
        Me.LogInRichTextBox1.Size = New System.Drawing.Size(234, 325)
        Me.LogInRichTextBox1.TabIndex = 0
        Me.LogInRichTextBox1.Text = resources.GetString("LogInRichTextBox1.Text")
        Me.LogInRichTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 467)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogInRichTextBox1 As LogInRichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ResetRestartInstallationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmartButton As LogInButtonWithProgress
    Friend WithEvents SmartLoader As Timer
    Friend WithEvents StatusLabel As LogInLabel
    Friend WithEvents GetReadyClose As Timer
    Friend WithEvents MTUwarn As LogInLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StartupTimer As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LoadingLabel As LogInLabel
End Class
