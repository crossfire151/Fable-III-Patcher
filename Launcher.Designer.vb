﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.LoadingLabel = New Fable_III_Patcher.LogInLabel()
        Me.SmartButton = New Fable_III_Patcher.LogInButtonWithProgress()
        Me.StatusLabel = New Fable_III_Patcher.LogInLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Discord = New System.Windows.Forms.ToolStripButton()
        Me.SupportButton = New System.Windows.Forms.ToolStripButton()
        Me.LogInTabControl1 = New Fable_III_Patcher.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebInfo = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SmartLoader = New System.Windows.Forms.Timer(Me.components)
        Me.GetReadyClose = New System.Windows.Forms.Timer(Me.components)
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.LogInThemeContainer1.Controls.Add(Me.LoadingLabel)
        Me.LogInThemeContainer1.Controls.Add(Me.SmartButton)
        Me.LogInThemeContainer1.Controls.Add(Me.StatusLabel)
        Me.LogInThemeContainer1.Controls.Add(Me.ToolStrip1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInTabControl1)
        Me.LogInThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(896, 558)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Launcher"
        '
        'LoadingLabel
        '
        Me.LoadingLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoadingLabel.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.LoadingLabel.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoadingLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LoadingLabel.Location = New System.Drawing.Point(343, 476)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(257, 55)
        Me.LoadingLabel.TabIndex = 1
        Me.LoadingLabel.Text = "Loading..."
        Me.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SmartButton
        '
        Me.SmartButton.BackColor = System.Drawing.Color.Transparent
        Me.SmartButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SmartButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SmartButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SmartButton.Location = New System.Drawing.Point(363, 476)
        Me.SmartButton.Maximum = 100
        Me.SmartButton.Name = "SmartButton"
        Me.SmartButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SmartButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.Size = New System.Drawing.Size(228, 55)
        Me.SmartButton.TabIndex = 4
        Me.SmartButton.Text = "Begin Installation"
        Me.SmartButton.Value = 0
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusLabel.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusLabel.Location = New System.Drawing.Point(360, 534)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(231, 23)
        Me.StatusLabel.TabIndex = 3
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.Discord, Me.SupportButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 530)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(171, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripButton1.Text = "Reset Application to defaults"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Discord
        '
        Me.Discord.Image = Global.Fable_III_Patcher.My.Resources.Resources.Discord_icon
        Me.Discord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Discord.Name = "Discord"
        Me.Discord.Size = New System.Drawing.Size(112, 22)
        Me.Discord.Text = "Discord Support"
        Me.Discord.Visible = False
        '
        'SupportButton
        '
        Me.SupportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SupportButton.Image = CType(resources.GetObject("SupportButton.Image"), System.Drawing.Image)
        Me.SupportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SupportButton.Name = "SupportButton"
        Me.SupportButton.Size = New System.Drawing.Size(53, 22)
        Me.SupportButton.Text = "Support"
        Me.SupportButton.Visible = False
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage1)
        Me.LogInTabControl1.Controls.Add(Me.TabPage2)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(643, 44)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(241, 414)
        Me.LogInTabControl1.TabIndex = 1
        Me.LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.WebInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(233, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "About"
        '
        'WebInfo
        '
        Me.WebInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebInfo.Location = New System.Drawing.Point(3, 3)
        Me.WebInfo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebInfo.Name = "WebInfo"
        Me.WebInfo.ScriptErrorsSuppressed = True
        Me.WebInfo.ScrollBarsEnabled = False
        Me.WebInfo.Size = New System.Drawing.Size(225, 366)
        Me.WebInfo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.LogInLabel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(233, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Information"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(3, 3)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(225, 366)
        Me.LogInLabel1.TabIndex = 0
        Me.LogInLabel1.Text = resources.GetString("LogInLabel1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.Fable3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 414)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'SmartLoader
        '
        '
        'GetReadyClose
        '
        Me.GetReadyClose.Interval = 8000
        '
        'StartupTimer
        '
        Me.StartupTimer.Interval = 6000
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 558)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Discord As ToolStripButton
    Friend WithEvents SupportButton As ToolStripButton
    Friend WithEvents LogInTabControl1 As LogInTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebInfo As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SmartLoader As Timer
    Friend WithEvents GetReadyClose As Timer
    Friend WithEvents StartupTimer As Timer
    Friend WithEvents StatusLabel As LogInLabel
    Friend WithEvents SmartButton As LogInButtonWithProgress
    Friend WithEvents LoadingLabel As LogInLabel
    Friend WithEvents LogInLabel1 As LogInLabel
End Class
