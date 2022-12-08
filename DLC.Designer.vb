<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLC))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenStep5Panel = New System.Windows.Forms.Timer(Me.components)
        Me.CloseStep5Panel = New System.Windows.Forms.Timer(Me.components)
        Me.InitialSetupTimerOPEN = New System.Windows.Forms.Timer(Me.components)
        Me.InitialSetupTimerCLOSE = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.UsernameSetup = New System.Windows.Forms.Panel()
        Me.DeleteDLCCheckBox = New Fable_III_Patcher.LogInCheckBox()
        Me.UsernameSaveButton = New Fable_III_Patcher.LogInButton()
        Me.ComboBox1 = New Fable_III_Patcher.LogInComboBox()
        Me.LogInLabel6 = New Fable_III_Patcher.LogInLabel()
        Me.UserProgressBar = New System.Windows.Forms.ProgressBar()
        Me.RestartButton = New Fable_III_Patcher.LogInButton()
        Me.ChangeUsernameButton = New Fable_III_Patcher.LogInButton()
        Me.Step5Panel = New System.Windows.Forms.Panel()
        Me.LicDoneButton = New Fable_III_Patcher.LogInButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInLabel5 = New Fable_III_Patcher.LogInLabel()
        Me.LicenceCopyToLocation = New System.Windows.Forms.WebBrowser()
        Me.LicenceCopyFromLocation = New System.Windows.Forms.WebBrowser()
        Me.LicenceAllocationClose = New Fable_III_Patcher.LogInButton()
        Me.LogInLabel4 = New Fable_III_Patcher.LogInLabel()
        Me.LicencePanel = New System.Windows.Forms.Panel()
        Me.xuidPanelClose = New Fable_III_Patcher.LogInButton()
        Me.RetryButton = New Fable_III_Patcher.LogInButton()
        Me.DoneButton = New Fable_III_Patcher.LogInButton()
        Me.LogInLabel3 = New Fable_III_Patcher.LogInLabel()
        Me.XuidGrabber = New System.Windows.Forms.WebBrowser()
        Me.LogInLabel2 = New Fable_III_Patcher.LogInLabel()
        Me.Step4 = New Fable_III_Patcher.LogInGroupBox()
        Me.LogInButton2 = New Fable_III_Patcher.LogInButton()
        Me.RenameLicenceButton = New Fable_III_Patcher.LogInButton()
        Me.LicenceSetupButton = New Fable_III_Patcher.LogInButton()
        Me.Step3 = New Fable_III_Patcher.LogInGroupBox()
        Me.LogInButton1 = New Fable_III_Patcher.LogInButton()
        Me.Fable3DLCLocation = New System.Windows.Forms.WebBrowser()
        Me.DownloadedFiles = New System.Windows.Forms.WebBrowser()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.Step5Progress = New System.Windows.Forms.ProgressBar()
        Me.Step2 = New Fable_III_Patcher.LogInGroupBox()
        Me.SaveLocationButton = New Fable_III_Patcher.LogInButton()
        Me.Step1 = New Fable_III_Patcher.LogInGroupBox()
        Me.DLC4 = New Fable_III_Patcher.LogInButton()
        Me.DLC3 = New Fable_III_Patcher.LogInButton()
        Me.DLC2 = New Fable_III_Patcher.LogInButton()
        Me.DLC1 = New Fable_III_Patcher.LogInButton()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.UsernameSetup.SuspendLayout()
        Me.Step5Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LicencePanel.SuspendLayout()
        Me.Step4.SuspendLayout()
        Me.Step3.SuspendLayout()
        Me.Step2.SuspendLayout()
        Me.Step1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenStep5Panel
        '
        Me.OpenStep5Panel.Interval = 1
        '
        'CloseStep5Panel
        '
        Me.CloseStep5Panel.Interval = 1
        '
        'InitialSetupTimerOPEN
        '
        Me.InitialSetupTimerOPEN.Interval = 1
        '
        'InitialSetupTimerCLOSE
        '
        Me.InitialSetupTimerCLOSE.Interval = 1
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
        Me.LogInThemeContainer1.Controls.Add(Me.UsernameSetup)
        Me.LogInThemeContainer1.Controls.Add(Me.RestartButton)
        Me.LogInThemeContainer1.Controls.Add(Me.ChangeUsernameButton)
        Me.LogInThemeContainer1.Controls.Add(Me.Step5Panel)
        Me.LogInThemeContainer1.Controls.Add(Me.LicencePanel)
        Me.LogInThemeContainer1.Controls.Add(Me.Step4)
        Me.LogInThemeContainer1.Controls.Add(Me.Step3)
        Me.LogInThemeContainer1.Controls.Add(Me.Step2)
        Me.LogInThemeContainer1.Controls.Add(Me.Step1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(1373, 565)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "DLC Installer"
        '
        'UsernameSetup
        '
        Me.UsernameSetup.Controls.Add(Me.DeleteDLCCheckBox)
        Me.UsernameSetup.Controls.Add(Me.UsernameSaveButton)
        Me.UsernameSetup.Controls.Add(Me.ComboBox1)
        Me.UsernameSetup.Controls.Add(Me.LogInLabel6)
        Me.UsernameSetup.Controls.Add(Me.UserProgressBar)
        Me.UsernameSetup.Location = New System.Drawing.Point(246, 35)
        Me.UsernameSetup.MaximumSize = New System.Drawing.Size(880, 0)
        Me.UsernameSetup.Name = "UsernameSetup"
        Me.UsernameSetup.Size = New System.Drawing.Size(880, 0)
        Me.UsernameSetup.TabIndex = 3
        '
        'DeleteDLCCheckBox
        '
        Me.DeleteDLCCheckBox.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DeleteDLCCheckBox.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DeleteDLCCheckBox.Checked = False
        Me.DeleteDLCCheckBox.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.DeleteDLCCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteDLCCheckBox.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeleteDLCCheckBox.Location = New System.Drawing.Point(518, 99)
        Me.DeleteDLCCheckBox.Name = "DeleteDLCCheckBox"
        Me.DeleteDLCCheckBox.Size = New System.Drawing.Size(100, 22)
        Me.DeleteDLCCheckBox.TabIndex = 4
        Me.DeleteDLCCheckBox.Text = "Delete DLC"
        '
        'UsernameSaveButton
        '
        Me.UsernameSaveButton.BackColor = System.Drawing.Color.Transparent
        Me.UsernameSaveButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.UsernameSaveButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UsernameSaveButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameSaveButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.UsernameSaveButton.Location = New System.Drawing.Point(364, 90)
        Me.UsernameSaveButton.Name = "UsernameSaveButton"
        Me.UsernameSaveButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.UsernameSaveButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameSaveButton.Size = New System.Drawing.Size(148, 42)
        Me.UsernameSaveButton.TabIndex = 2
        Me.UsernameSaveButton.Text = "Save Username"
        '
        'ComboBox1
        '
        Me.ComboBox1.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ComboBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ComboBox1.Location = New System.Drawing.Point(302, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(277, 26)
        Me.ComboBox1.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ComboBox1.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ComboBox1.StartIndex = 0
        Me.ComboBox1.TabIndex = 1
        '
        'LogInLabel6
        '
        Me.LogInLabel6.AutoSize = True
        Me.LogInLabel6.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel6.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel6.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel6.Location = New System.Drawing.Point(318, 5)
        Me.LogInLabel6.Name = "LogInLabel6"
        Me.LogInLabel6.Size = New System.Drawing.Size(245, 27)
        Me.LogInLabel6.TabIndex = 0
        Me.LogInLabel6.Text = "Select your Username"
        '
        'UserProgressBar
        '
        Me.UserProgressBar.Location = New System.Drawing.Point(381, 102)
        Me.UserProgressBar.Maximum = 142
        Me.UserProgressBar.Name = "UserProgressBar"
        Me.UserProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.UserProgressBar.TabIndex = 3
        Me.UserProgressBar.Visible = False
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.Transparent
        Me.RestartButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RestartButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RestartButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RestartButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RestartButton.Location = New System.Drawing.Point(578, 41)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RestartButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RestartButton.Size = New System.Drawing.Size(75, 30)
        Me.RestartButton.TabIndex = 5
        Me.RestartButton.Text = "Restart"
        '
        'ChangeUsernameButton
        '
        Me.ChangeUsernameButton.BackColor = System.Drawing.Color.Transparent
        Me.ChangeUsernameButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ChangeUsernameButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ChangeUsernameButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChangeUsernameButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ChangeUsernameButton.Location = New System.Drawing.Point(1263, 37)
        Me.ChangeUsernameButton.Name = "ChangeUsernameButton"
        Me.ChangeUsernameButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ChangeUsernameButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChangeUsernameButton.Size = New System.Drawing.Size(105, 26)
        Me.ChangeUsernameButton.TabIndex = 4
        Me.ChangeUsernameButton.Text = "Change Username"
        Me.ChangeUsernameButton.Visible = False
        '
        'Step5Panel
        '
        Me.Step5Panel.Controls.Add(Me.LicDoneButton)
        Me.Step5Panel.Controls.Add(Me.PictureBox1)
        Me.Step5Panel.Controls.Add(Me.LogInLabel5)
        Me.Step5Panel.Controls.Add(Me.LicenceCopyToLocation)
        Me.Step5Panel.Controls.Add(Me.LicenceCopyFromLocation)
        Me.Step5Panel.Controls.Add(Me.LicenceAllocationClose)
        Me.Step5Panel.Controls.Add(Me.LogInLabel4)
        Me.Step5Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Step5Panel.Location = New System.Drawing.Point(0, 565)
        Me.Step5Panel.MaximumSize = New System.Drawing.Size(1373, 542)
        Me.Step5Panel.Name = "Step5Panel"
        Me.Step5Panel.Size = New System.Drawing.Size(1373, 0)
        Me.Step5Panel.TabIndex = 3
        '
        'LicDoneButton
        '
        Me.LicDoneButton.BackColor = System.Drawing.Color.Transparent
        Me.LicDoneButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LicDoneButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LicDoneButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicDoneButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LicDoneButton.Location = New System.Drawing.Point(645, 489)
        Me.LicDoneButton.Name = "LicDoneButton"
        Me.LicDoneButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LicDoneButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicDoneButton.Size = New System.Drawing.Size(82, 51)
        Me.LicDoneButton.TabIndex = 5
        Me.LicDoneButton.Text = "Done"
        Me.LicDoneButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Fable_III_Patcher.My.Resources.Resources.chevron
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(610, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 312)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LogInLabel5
        '
        Me.LogInLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogInLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel5.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.LogInLabel5.Location = New System.Drawing.Point(421, 90)
        Me.LogInLabel5.Name = "LogInLabel5"
        Me.LogInLabel5.Size = New System.Drawing.Size(492, 71)
        Me.LogInLabel5.TabIndex = 1
        Me.LogInLabel5.Text = "Copy all the files in the left box to the right box!"
        Me.LogInLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LicenceCopyToLocation
        '
        Me.LicenceCopyToLocation.Location = New System.Drawing.Point(760, 171)
        Me.LicenceCopyToLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LicenceCopyToLocation.Name = "LicenceCopyToLocation"
        Me.LicenceCopyToLocation.ScriptErrorsSuppressed = True
        Me.LicenceCopyToLocation.Size = New System.Drawing.Size(377, 315)
        Me.LicenceCopyToLocation.TabIndex = 3
        '
        'LicenceCopyFromLocation
        '
        Me.LicenceCopyFromLocation.Location = New System.Drawing.Point(227, 171)
        Me.LicenceCopyFromLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LicenceCopyFromLocation.Name = "LicenceCopyFromLocation"
        Me.LicenceCopyFromLocation.ScriptErrorsSuppressed = True
        Me.LicenceCopyFromLocation.Size = New System.Drawing.Size(377, 314)
        Me.LicenceCopyFromLocation.TabIndex = 2
        '
        'LicenceAllocationClose
        '
        Me.LicenceAllocationClose.BackColor = System.Drawing.Color.Transparent
        Me.LicenceAllocationClose.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LicenceAllocationClose.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LicenceAllocationClose.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicenceAllocationClose.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LicenceAllocationClose.Location = New System.Drawing.Point(1341, 3)
        Me.LicenceAllocationClose.Name = "LicenceAllocationClose"
        Me.LicenceAllocationClose.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LicenceAllocationClose.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicenceAllocationClose.Size = New System.Drawing.Size(29, 30)
        Me.LicenceAllocationClose.TabIndex = 1
        Me.LicenceAllocationClose.Text = "×"
        '
        'LogInLabel4
        '
        Me.LogInLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogInLabel4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.Location = New System.Drawing.Point(9, 34)
        Me.LogInLabel4.Name = "LogInLabel4"
        Me.LogInLabel4.Size = New System.Drawing.Size(1343, 44)
        Me.LogInLabel4.TabIndex = 0
        Me.LogInLabel4.Text = "Step 5 - Licence File Allocation"
        Me.LogInLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LicencePanel
        '
        Me.LicencePanel.Controls.Add(Me.xuidPanelClose)
        Me.LicencePanel.Controls.Add(Me.RetryButton)
        Me.LicencePanel.Controls.Add(Me.DoneButton)
        Me.LicencePanel.Controls.Add(Me.LogInLabel3)
        Me.LicencePanel.Controls.Add(Me.XuidGrabber)
        Me.LicencePanel.Controls.Add(Me.LogInLabel2)
        Me.LicencePanel.Location = New System.Drawing.Point(676, 556)
        Me.LicencePanel.Name = "LicencePanel"
        Me.LicencePanel.Size = New System.Drawing.Size(24, 21)
        Me.LicencePanel.TabIndex = 5
        Me.LicencePanel.Visible = False
        '
        'xuidPanelClose
        '
        Me.xuidPanelClose.BackColor = System.Drawing.Color.Transparent
        Me.xuidPanelClose.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.xuidPanelClose.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.xuidPanelClose.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xuidPanelClose.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.xuidPanelClose.Location = New System.Drawing.Point(884, 3)
        Me.xuidPanelClose.Name = "xuidPanelClose"
        Me.xuidPanelClose.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.xuidPanelClose.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xuidPanelClose.Size = New System.Drawing.Size(33, 30)
        Me.xuidPanelClose.TabIndex = 5
        Me.xuidPanelClose.Text = "×"
        '
        'RetryButton
        '
        Me.RetryButton.BackColor = System.Drawing.Color.Transparent
        Me.RetryButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RetryButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RetryButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetryButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RetryButton.Location = New System.Drawing.Point(709, 351)
        Me.RetryButton.Name = "RetryButton"
        Me.RetryButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RetryButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetryButton.Size = New System.Drawing.Size(100, 30)
        Me.RetryButton.TabIndex = 4
        Me.RetryButton.Text = "Try Again"
        Me.RetryButton.Visible = False
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.Color.Transparent
        Me.DoneButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DoneButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DoneButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DoneButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DoneButton.Location = New System.Drawing.Point(389, 388)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DoneButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DoneButton.Size = New System.Drawing.Size(140, 30)
        Me.DoneButton.TabIndex = 3
        Me.DoneButton.Text = "Done"
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(287, 60)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(344, 30)
        Me.LogInLabel3.TabIndex = 2
        Me.LogInLabel3.Text = "Enter Your Xbox Gamertag below then click Get." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will fetch your unique ID. P" &
    "lease Copy the XUID (HEX) code."
        Me.LogInLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XuidGrabber
        '
        Me.XuidGrabber.Location = New System.Drawing.Point(145, 108)
        Me.XuidGrabber.MinimumSize = New System.Drawing.Size(20, 20)
        Me.XuidGrabber.Name = "XuidGrabber"
        Me.XuidGrabber.ScriptErrorsSuppressed = True
        Me.XuidGrabber.ScrollBarsEnabled = False
        Me.XuidGrabber.Size = New System.Drawing.Size(664, 273)
        Me.XuidGrabber.TabIndex = 1
        Me.XuidGrabber.Url = New System.Uri("https://cxkes.me/xbox/xuid", System.UriKind.Absolute)
        '
        'LogInLabel2
        '
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogInLabel2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(17, 16)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(862, 33)
        Me.LogInLabel2.TabIndex = 0
        Me.LogInLabel2.Text = "Licence Setup - XUID Grabber"
        Me.LogInLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Step4
        '
        Me.Step4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Step4.Controls.Add(Me.LogInButton2)
        Me.Step4.Controls.Add(Me.RenameLicenceButton)
        Me.Step4.Controls.Add(Me.LicenceSetupButton)
        Me.Step4.Enabled = False
        Me.Step4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Step4.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Step4.Location = New System.Drawing.Point(12, 234)
        Me.Step4.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Step4.Name = "Step4"
        Me.Step4.Size = New System.Drawing.Size(658, 325)
        Me.Step4.TabIndex = 4
        Me.Step4.Text = "Step 4 - Licence File | Setup & Preperation"
        Me.Step4.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInButton2
        '
        Me.LogInButton2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton2.Location = New System.Drawing.Point(17, 192)
        Me.LogInButton2.Name = "LogInButton2"
        Me.LogInButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.Size = New System.Drawing.Size(624, 30)
        Me.LogInButton2.TabIndex = 2
        Me.LogInButton2.Text = "Move Licence files"
        '
        'RenameLicenceButton
        '
        Me.RenameLicenceButton.BackColor = System.Drawing.Color.Transparent
        Me.RenameLicenceButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RenameLicenceButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RenameLicenceButton.Enabled = False
        Me.RenameLicenceButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RenameLicenceButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RenameLicenceButton.Location = New System.Drawing.Point(17, 138)
        Me.RenameLicenceButton.Name = "RenameLicenceButton"
        Me.RenameLicenceButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RenameLicenceButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RenameLicenceButton.Size = New System.Drawing.Size(624, 30)
        Me.RenameLicenceButton.TabIndex = 1
        Me.RenameLicenceButton.Text = "Rename Licence File"
        '
        'LicenceSetupButton
        '
        Me.LicenceSetupButton.BackColor = System.Drawing.Color.Transparent
        Me.LicenceSetupButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LicenceSetupButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LicenceSetupButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicenceSetupButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LicenceSetupButton.Location = New System.Drawing.Point(17, 102)
        Me.LicenceSetupButton.Name = "LicenceSetupButton"
        Me.LicenceSetupButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LicenceSetupButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicenceSetupButton.Size = New System.Drawing.Size(624, 30)
        Me.LicenceSetupButton.TabIndex = 0
        Me.LicenceSetupButton.Text = "Setup Licence..."
        '
        'Step3
        '
        Me.Step3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Step3.Controls.Add(Me.LogInButton1)
        Me.Step3.Controls.Add(Me.Fable3DLCLocation)
        Me.Step3.Controls.Add(Me.DownloadedFiles)
        Me.Step3.Controls.Add(Me.LogInLabel1)
        Me.Step3.Controls.Add(Me.Step5Progress)
        Me.Step3.Enabled = False
        Me.Step3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Step3.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Step3.Location = New System.Drawing.Point(679, 134)
        Me.Step3.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Step3.Name = "Step3"
        Me.Step3.Size = New System.Drawing.Size(685, 425)
        Me.Step3.TabIndex = 3
        Me.Step3.Text = "Step 3 - DLC Location | Preperation"
        Me.Step3.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(260, 393)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(164, 28)
        Me.LogInButton1.TabIndex = 2
        Me.LogInButton1.Text = "Next Step"
        '
        'Fable3DLCLocation
        '
        Me.Fable3DLCLocation.Location = New System.Drawing.Point(348, 141)
        Me.Fable3DLCLocation.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Fable3DLCLocation.Name = "Fable3DLCLocation"
        Me.Fable3DLCLocation.ScriptErrorsSuppressed = True
        Me.Fable3DLCLocation.Size = New System.Drawing.Size(328, 250)
        Me.Fable3DLCLocation.TabIndex = 0
        '
        'DownloadedFiles
        '
        Me.DownloadedFiles.Location = New System.Drawing.Point(11, 141)
        Me.DownloadedFiles.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DownloadedFiles.Name = "DownloadedFiles"
        Me.DownloadedFiles.ScriptErrorsSuppressed = True
        Me.DownloadedFiles.Size = New System.Drawing.Size(328, 250)
        Me.DownloadedFiles.TabIndex = 1
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(8, 32)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(671, 105)
        Me.LogInLabel1.TabIndex = 0
        Me.LogInLabel1.Text = resources.GetString("LogInLabel1.Text")
        '
        'Step5Progress
        '
        Me.Step5Progress.Location = New System.Drawing.Point(168, 243)
        Me.Step5Progress.Maximum = 542
        Me.Step5Progress.Name = "Step5Progress"
        Me.Step5Progress.Size = New System.Drawing.Size(100, 23)
        Me.Step5Progress.TabIndex = 0
        Me.Step5Progress.Visible = False
        '
        'Step2
        '
        Me.Step2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Step2.Controls.Add(Me.SaveLocationButton)
        Me.Step2.Enabled = False
        Me.Step2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Step2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Step2.Location = New System.Drawing.Point(693, 41)
        Me.Step2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(641, 87)
        Me.Step2.TabIndex = 1
        Me.Step2.Text = "Step 2 - Specify Fable 3 Game Location"
        Me.Step2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'SaveLocationButton
        '
        Me.SaveLocationButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveLocationButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SaveLocationButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SaveLocationButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveLocationButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SaveLocationButton.Location = New System.Drawing.Point(17, 40)
        Me.SaveLocationButton.Name = "SaveLocationButton"
        Me.SaveLocationButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SaveLocationButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveLocationButton.Size = New System.Drawing.Size(608, 30)
        Me.SaveLocationButton.TabIndex = 2
        Me.SaveLocationButton.Text = "Specify Fable III Game Location..."
        '
        'Step1
        '
        Me.Step1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Step1.Controls.Add(Me.DLC4)
        Me.Step1.Controls.Add(Me.DLC3)
        Me.Step1.Controls.Add(Me.DLC2)
        Me.Step1.Controls.Add(Me.DLC1)
        Me.Step1.Enabled = False
        Me.Step1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Step1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Step1.Location = New System.Drawing.Point(12, 45)
        Me.Step1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(641, 183)
        Me.Step1.TabIndex = 0
        Me.Step1.Text = "Step 1 - Download DLC"
        Me.Step1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DLC4
        '
        Me.DLC4.BackColor = System.Drawing.Color.Transparent
        Me.DLC4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLC4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLC4.Enabled = False
        Me.DLC4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLC4.Location = New System.Drawing.Point(17, 148)
        Me.DLC4.Name = "DLC4"
        Me.DLC4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLC4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC4.Size = New System.Drawing.Size(608, 30)
        Me.DLC4.TabIndex = 3
        Me.DLC4.Tag = "D7FCB87DC6790538CC5EE45EC44EC782603B8ACB.zip"
        Me.DLC4.Text = "Download Licence Files"
        '
        'DLC3
        '
        Me.DLC3.BackColor = System.Drawing.Color.Transparent
        Me.DLC3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLC3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLC3.Enabled = False
        Me.DLC3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLC3.Location = New System.Drawing.Point(17, 112)
        Me.DLC3.Name = "DLC3"
        Me.DLC3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLC3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC3.Size = New System.Drawing.Size(608, 30)
        Me.DLC3.TabIndex = 2
        Me.DLC3.Tag = "03_InquisitorsPack.zip"
        Me.DLC3.Text = "Download Inquisitors Pack"
        '
        'DLC2
        '
        Me.DLC2.BackColor = System.Drawing.Color.Transparent
        Me.DLC2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLC2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLC2.Enabled = False
        Me.DLC2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLC2.Location = New System.Drawing.Point(17, 76)
        Me.DLC2.Name = "DLC2"
        Me.DLC2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLC2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC2.Size = New System.Drawing.Size(608, 30)
        Me.DLC2.TabIndex = 1
        Me.DLC2.Tag = "02_TraitorsKeep.zip"
        Me.DLC2.Text = "Download Traitors Keep Pack"
        '
        'DLC1
        '
        Me.DLC1.BackColor = System.Drawing.Color.Transparent
        Me.DLC1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLC1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DLC1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DLC1.Location = New System.Drawing.Point(17, 40)
        Me.DLC1.Name = "DLC1"
        Me.DLC1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DLC1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLC1.Size = New System.Drawing.Size(608, 30)
        Me.DLC1.TabIndex = 0
        Me.DLC1.Tag = "01_Understone.zip"
        Me.DLC1.Text = "Download Understone Pack"
        '
        'DLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 565)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DLC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fable 3 | DLC Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.UsernameSetup.ResumeLayout(False)
        Me.UsernameSetup.PerformLayout()
        Me.Step5Panel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LicencePanel.ResumeLayout(False)
        Me.LicencePanel.PerformLayout()
        Me.Step4.ResumeLayout(False)
        Me.Step3.ResumeLayout(False)
        Me.Step3.PerformLayout()
        Me.Step2.ResumeLayout(False)
        Me.Step1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents Step1 As LogInGroupBox
    Friend WithEvents DLC4 As LogInButton
    Friend WithEvents DLC3 As LogInButton
    Friend WithEvents DLC2 As LogInButton
    Friend WithEvents DLC1 As LogInButton
    Friend WithEvents Step2 As LogInGroupBox
    Friend WithEvents SaveLocationButton As LogInButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Step4 As LogInGroupBox
    Friend WithEvents Step3 As LogInGroupBox
    Friend WithEvents Fable3DLCLocation As WebBrowser
    Friend WithEvents DownloadedFiles As WebBrowser
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents LogInButton1 As LogInButton
    Friend WithEvents LicencePanel As Panel
    Friend WithEvents DoneButton As LogInButton
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents XuidGrabber As WebBrowser
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents LicenceSetupButton As LogInButton
    Friend WithEvents RetryButton As LogInButton
    Friend WithEvents xuidPanelClose As LogInButton
    Friend WithEvents RenameLicenceButton As LogInButton
    Friend WithEvents Step5Panel As Panel
    Friend WithEvents LogInButton2 As LogInButton
    Friend WithEvents Step5Progress As ProgressBar
    Friend WithEvents OpenStep5Panel As Timer
    Friend WithEvents CloseStep5Panel As Timer
    Friend WithEvents LicenceAllocationClose As LogInButton
    Friend WithEvents LogInLabel4 As LogInLabel
    Friend WithEvents LicenceCopyToLocation As WebBrowser
    Friend WithEvents LicenceCopyFromLocation As WebBrowser
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogInLabel5 As LogInLabel
    Friend WithEvents LicDoneButton As LogInButton
    Friend WithEvents UsernameSetup As Panel
    Friend WithEvents ComboBox1 As LogInComboBox
    Friend WithEvents LogInLabel6 As LogInLabel
    Friend WithEvents UserProgressBar As ProgressBar
    Friend WithEvents UsernameSaveButton As LogInButton
    Friend WithEvents InitialSetupTimerOPEN As Timer
    Friend WithEvents InitialSetupTimerCLOSE As Timer
    Friend WithEvents ChangeUsernameButton As LogInButton
    Friend WithEvents DeleteDLCCheckBox As LogInCheckBox
    Friend WithEvents RestartButton As LogInButton
End Class
