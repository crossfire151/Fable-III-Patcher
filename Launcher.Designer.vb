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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SmartLoader = New System.Windows.Forms.Timer(Me.components)
        Me.GetReadyClose = New System.Windows.Forms.Timer(Me.components)
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ServerStatusChecker = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.LogInLabel4 = New Fable_III_Patcher.LogInLabel()
        Me.LogInGroupBox1 = New Fable_III_Patcher.LogInGroupBox()
        Me.LogInButton2 = New Fable_III_Patcher.LogInButton()
        Me.LogInButton1 = New Fable_III_Patcher.LogInButton()
        Me.LogInLabel2 = New Fable_III_Patcher.LogInLabel()
        Me.LoadingLabel = New Fable_III_Patcher.LogInLabel()
        Me.SmartButton = New Fable_III_Patcher.LogInButtonWithProgress()
        Me.StatusLabel = New Fable_III_Patcher.LogInLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.HotFixButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ResetApplicationToDefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewPatchNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UploadCrashLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Discord = New System.Windows.Forms.ToolStripButton()
        Me.SupportButton = New System.Windows.Forms.ToolStripButton()
        Me.LogInTabControl1 = New Fable_III_Patcher.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebInfo = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ServerWarning = New Fable_III_Patcher.LogInLabel()
        Me.ServerStatus = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel3 = New Fable_III_Patcher.LogInLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ServerStatusChecker
        '
        Me.ServerStatusChecker.Interval = 30000
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
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel4)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInGroupBox1)
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
        'LogInLabel4
        '
        Me.LogInLabel4.AutoSize = True
        Me.LogInLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.ForeColor = System.Drawing.Color.Red
        Me.LogInLabel4.Location = New System.Drawing.Point(12, 461)
        Me.LogInLabel4.Name = "LogInLabel4"
        Me.LogInLabel4.Size = New System.Drawing.Size(373, 15)
        Me.LogInLabel4.TabIndex = 6
        Me.LogInLabel4.Text = "*Only genuine copies of this game will function with this Application."
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInButton2)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButton1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInLabel2)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(22, 98)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(399, 181)
        Me.LogInGroupBox1.TabIndex = 5
        Me.LogInGroupBox1.Text = "Are You Sure?"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInGroupBox1.Visible = False
        '
        'LogInButton2
        '
        Me.LogInButton2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton2.Location = New System.Drawing.Point(3, 148)
        Me.LogInButton2.Name = "LogInButton2"
        Me.LogInButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.Size = New System.Drawing.Size(75, 30)
        Me.LogInButton2.TabIndex = 2
        Me.LogInButton2.Text = "Cancel"
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(309, 148)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(87, 30)
        Me.LogInButton1.TabIndex = 1
        Me.LogInButton1.Text = "Yes, Download"
        '
        'LogInLabel2
        '
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(3, 31)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(393, 108)
        Me.LogInLabel2.TabIndex = 0
        Me.LogInLabel2.Text = resources.GetString("LogInLabel2.Text")
        '
        'LoadingLabel
        '
        Me.LoadingLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoadingLabel.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.LoadingLabel.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoadingLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LoadingLabel.Location = New System.Drawing.Point(349, 476)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotFixButton, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.Discord, Me.SupportButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(22, 53)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(354, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'HotFixButton
        '
        Me.HotFixButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HotFixButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HotFixButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotFixButton.ForeColor = System.Drawing.Color.White
        Me.HotFixButton.Image = CType(resources.GetObject("HotFixButton.Image"), System.Drawing.Image)
        Me.HotFixButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HotFixButton.Name = "HotFixButton"
        Me.HotFixButton.Size = New System.Drawing.Size(87, 22)
        Me.HotFixButton.Text = "HotFix Ready!"
        Me.HotFixButton.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetApplicationToDefaultsToolStripMenuItem, Me.ToolStripSeparator2, Me.ViewPatchNotesToolStripMenuItem, Me.ToolStripSeparator3, Me.UploadCrashLogToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripDropDownButton1.Text = "Options"
        '
        'ResetApplicationToDefaultsToolStripMenuItem
        '
        Me.ResetApplicationToDefaultsToolStripMenuItem.Image = CType(resources.GetObject("ResetApplicationToDefaultsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetApplicationToDefaultsToolStripMenuItem.Name = "ResetApplicationToDefaultsToolStripMenuItem"
        Me.ResetApplicationToDefaultsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ResetApplicationToDefaultsToolStripMenuItem.Text = "Reset Application to defaults"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(222, 6)
        '
        'ViewPatchNotesToolStripMenuItem
        '
        Me.ViewPatchNotesToolStripMenuItem.Image = Global.Fable_III_Patcher.My.Resources.Resources.settings_icon
        Me.ViewPatchNotesToolStripMenuItem.Name = "ViewPatchNotesToolStripMenuItem"
        Me.ViewPatchNotesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ViewPatchNotesToolStripMenuItem.Text = "View Patch Notes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(222, 6)
        '
        'UploadCrashLogToolStripMenuItem
        '
        Me.UploadCrashLogToolStripMenuItem.Image = Global.Fable_III_Patcher.My.Resources.Resources.up
        Me.UploadCrashLogToolStripMenuItem.Name = "UploadCrashLogToolStripMenuItem"
        Me.UploadCrashLogToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.UploadCrashLogToolStripMenuItem.Text = "Upload Crash Log"
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
        Me.LogInTabControl1.Controls.Add(Me.TabPage3)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(625, 44)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(259, 414)
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
        Me.TabPage1.Size = New System.Drawing.Size(251, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "About"
        '
        'WebInfo
        '
        Me.WebInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebInfo.IsWebBrowserContextMenuEnabled = False
        Me.WebInfo.Location = New System.Drawing.Point(3, 3)
        Me.WebInfo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebInfo.Name = "WebInfo"
        Me.WebInfo.ScriptErrorsSuppressed = True
        Me.WebInfo.ScrollBarsEnabled = False
        Me.WebInfo.Size = New System.Drawing.Size(243, 366)
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
        Me.TabPage2.Size = New System.Drawing.Size(251, 374)
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
        Me.LogInLabel1.Size = New System.Drawing.Size(243, 366)
        Me.LogInLabel1.TabIndex = 0
        Me.LogInLabel1.Text = resources.GetString("LogInLabel1.Text")
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.ServerWarning)
        Me.TabPage3.Controls.Add(Me.ServerStatus)
        Me.TabPage3.Controls.Add(Me.LogInLabel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(251, 374)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Server Status"
        '
        'ServerWarning
        '
        Me.ServerWarning.BackColor = System.Drawing.Color.Transparent
        Me.ServerWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServerWarning.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ServerWarning.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ServerWarning.Location = New System.Drawing.Point(3, 180)
        Me.ServerWarning.Name = "ServerWarning"
        Me.ServerWarning.Size = New System.Drawing.Size(242, 181)
        Me.ServerWarning.TabIndex = 2
        Me.ServerWarning.Text = "It appears the server appears to be Offline for Maintenance, we were unable to co" &
    "mmunicate with the server. We will keep trying in the background."
        Me.ServerWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ServerWarning.Visible = False
        '
        'ServerStatus
        '
        Me.ServerStatus.BackColor = System.Drawing.Color.Transparent
        Me.ServerStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ServerStatus.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerStatus.Location = New System.Drawing.Point(3, 111)
        Me.ServerStatus.Name = "ServerStatus"
        Me.ServerStatus.Size = New System.Drawing.Size(242, 36)
        Me.ServerStatus.TabIndex = 1
        Me.ServerStatus.Text = "Waiting on Server..."
        Me.ServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogInLabel3
        '
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(3, 15)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(242, 80)
        Me.LogInLabel3.TabIndex = 0
        Me.LogInLabel3.Text = "Server Status"
        Me.LogInLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.Fable3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 414)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
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
    Friend WithEvents HotFixButton As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ResetApplicationToDefaultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ViewPatchNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents LogInButton2 As LogInButton
    Friend WithEvents LogInButton1 As LogInButton
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ServerStatus As LogInLabel
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents ServerWarning As LogInLabel
    Friend WithEvents ServerStatusChecker As Timer
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents UploadCrashLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInLabel4 As LogInLabel
End Class
