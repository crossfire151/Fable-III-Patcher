<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrashReporter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrashReporter))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.SendCrash = New Fable_III_Patcher.LogInButtonWithProgress()
        Me.LogInButton2 = New Fable_III_Patcher.LogInButton()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.appid = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel3 = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel4 = New Fable_III_Patcher.LogInLabel()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
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
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.SendCrash)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInButton2)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel1)
        Me.LogInThemeContainer1.Controls.Add(Me.appid)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel3)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel4)
        Me.LogInThemeContainer1.Controls.Add(Me.NameText)
        Me.LogInThemeContainer1.Controls.Add(Me.EmailText)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Crash Reporter"
        '
        'SendCrash
        '
        Me.SendCrash.BackColor = System.Drawing.Color.Transparent
        Me.SendCrash.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SendCrash.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SendCrash.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SendCrash.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SendCrash.Location = New System.Drawing.Point(267, 238)
        Me.SendCrash.Maximum = 100
        Me.SendCrash.Name = "SendCrash"
        Me.SendCrash.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SendCrash.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SendCrash.Size = New System.Drawing.Size(272, 30)
        Me.SendCrash.TabIndex = 6
        Me.SendCrash.Text = "Send Crash Log"
        Me.SendCrash.Value = 0
        '
        'LogInButton2
        '
        Me.LogInButton2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton2.Location = New System.Drawing.Point(541, 142)
        Me.LogInButton2.Name = "LogInButton2"
        Me.LogInButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton2.Size = New System.Drawing.Size(75, 30)
        Me.LogInButton2.TabIndex = 5
        Me.LogInButton2.Text = "Copy"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(202, 147)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(62, 15)
        Me.LogInLabel1.TabIndex = 1
        Me.LogInLabel1.Text = "Referance:"
        '
        'appid
        '
        Me.appid.AutoSize = True
        Me.appid.BackColor = System.Drawing.Color.Transparent
        Me.appid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.appid.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.appid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.appid.Location = New System.Drawing.Point(270, 147)
        Me.appid.Name = "appid"
        Me.appid.Size = New System.Drawing.Size(0, 15)
        Me.appid.TabIndex = 2
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(195, 176)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(69, 15)
        Me.LogInLabel3.TabIndex = 3
        Me.LogInLabel3.Text = "Your Name:"
        '
        'LogInLabel4
        '
        Me.LogInLabel4.AutoSize = True
        Me.LogInLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.Location = New System.Drawing.Point(195, 214)
        Me.LogInLabel4.Name = "LogInLabel4"
        Me.LogInLabel4.Size = New System.Drawing.Size(66, 15)
        Me.LogInLabel4.TabIndex = 4
        Me.LogInLabel4.Text = "Your Email:"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(267, 174)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(272, 20)
        Me.NameText.TabIndex = 2
        '
        'EmailText
        '
        Me.EmailText.Location = New System.Drawing.Point(267, 212)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(272, 20)
        Me.EmailText.TabIndex = 1
        '
        'CrashReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrashReporter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crash Reporter"
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents NameText As TextBox
    Friend WithEvents EmailText As TextBox
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents appid As LogInLabel
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents LogInLabel4 As LogInLabel
    Friend WithEvents LogInButton2 As LogInButton
    Friend WithEvents SendCrash As LogInButtonWithProgress
    Friend WithEvents Timer1 As Timer
End Class
