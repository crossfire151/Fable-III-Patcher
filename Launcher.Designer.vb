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
        Me.ThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.LanguageButton = New Fable_III_Patcher.LogInButton()
        Me.SmartButton = New Fable_III_Patcher.LogInButtonWithProgress()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInRichTextBox1 = New Fable_III_Patcher.LogInRichTextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ThemeContainer1.SuspendLayout()
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
        Me.SmartLoader.Interval = 50
        '
        'ThemeContainer1
        '
        Me.ThemeContainer1.AllowClose = True
        Me.ThemeContainer1.AllowMaximize = True
        Me.ThemeContainer1.AllowMinimize = True
        Me.ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ThemeContainer1.Controls.Add(Me.LanguageButton)
        Me.ThemeContainer1.Controls.Add(Me.SmartButton)
        Me.ThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ThemeContainer1.Controls.Add(Me.LogInRichTextBox1)
        Me.ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeContainer1.FontSize = 12
        Me.ThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ThemeContainer1.Name = "ThemeContainer1"
        Me.ThemeContainer1.ShowIcon = True
        Me.ThemeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ThemeContainer1.TabIndex = 0
        Me.ThemeContainer1.Text = "Fable III Patcher | With embeded Launcher"
        '
        'LanguageButton
        '
        Me.LanguageButton.BackColor = System.Drawing.Color.Transparent
        Me.LanguageButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LanguageButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LanguageButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LanguageButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LanguageButton.Location = New System.Drawing.Point(6, 37)
        Me.LanguageButton.Name = "LanguageButton"
        Me.LanguageButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LanguageButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LanguageButton.Size = New System.Drawing.Size(111, 30)
        Me.LanguageButton.TabIndex = 4
        Me.LanguageButton.Text = "Change Language"
        '
        'SmartButton
        '
        Me.SmartButton.BackColor = System.Drawing.Color.Transparent
        Me.SmartButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SmartButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SmartButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SmartButton.Location = New System.Drawing.Point(301, 397)
        Me.SmartButton.Maximum = 100
        Me.SmartButton.Name = "SmartButton"
        Me.SmartButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SmartButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmartButton.Size = New System.Drawing.Size(189, 48)
        Me.SmartButton.TabIndex = 3
        Me.SmartButton.Text = "%smart%"
        Me.SmartButton.Value = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.Fable3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(18, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(540, 307)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LogInRichTextBox1
        '
        Me.LogInRichTextBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRichTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRichTextBox1.Location = New System.Drawing.Point(564, 70)
        Me.LogInRichTextBox1.Name = "LogInRichTextBox1"
        Me.LogInRichTextBox1.Size = New System.Drawing.Size(219, 307)
        Me.LogInRichTextBox1.TabIndex = 0
        Me.LogInRichTextBox1.Text = resources.GetString("LogInRichTextBox1.Text")
        Me.LogInRichTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ThemeContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThemeContainer1 As LogInThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogInRichTextBox1 As LogInRichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ResetRestartInstallationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmartButton As LogInButtonWithProgress
    Friend WithEvents SmartLoader As Timer
    Friend WithEvents LanguageButton As LogInButton
End Class
