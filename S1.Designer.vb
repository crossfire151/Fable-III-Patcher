<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class S1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S1))
        Me.LogInThemeContainer1 = New Fable_III_Patcher.LogInThemeContainer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LogInLabel3 = New Fable_III_Patcher.LogInLabel()
        Me.StageCount = New Fable_III_Patcher.LogInLabel()
        Me.Statustext = New Fable_III_Patcher.LogInLabel()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.LogInProgressBar1 = New Fable_III_Patcher.LogInProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = False
        Me.LogInThemeContainer1.AllowMaximize = False
        Me.LogInThemeContainer1.AllowMinimize = False
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.ProgressBar1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel3)
        Me.LogInThemeContainer1.Controls.Add(Me.StageCount)
        Me.LogInThemeContainer1.Controls.Add(Me.Statustext)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInLabel1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInProgressBar1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(538, 235)
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Fable III Patcher | Installation Step 1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(402, 164)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(430, 76)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(39, 15)
        Me.LogInLabel3.TabIndex = 5
        Me.LogInLabel3.Text = "Stage:"
        '
        'StageCount
        '
        Me.StageCount.AutoSize = True
        Me.StageCount.BackColor = System.Drawing.Color.Transparent
        Me.StageCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StageCount.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StageCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StageCount.Location = New System.Drawing.Point(475, 76)
        Me.StageCount.Name = "StageCount"
        Me.StageCount.Size = New System.Drawing.Size(24, 15)
        Me.StageCount.TabIndex = 4
        Me.StageCount.Text = "0/5"
        '
        'Statustext
        '
        Me.Statustext.AutoSize = True
        Me.Statustext.BackColor = System.Drawing.Color.Transparent
        Me.Statustext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Statustext.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Statustext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Statustext.Location = New System.Drawing.Point(72, 127)
        Me.Statustext.Name = "Statustext"
        Me.Statustext.Size = New System.Drawing.Size(0, 15)
        Me.Statustext.TabIndex = 3
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(32, 126)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(42, 15)
        Me.LogInLabel1.TabIndex = 2
        Me.LogInLabel1.Text = "Status:"
        '
        'LogInProgressBar1
        '
        Me.LogInProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LogInProgressBar1.Location = New System.Drawing.Point(32, 94)
        Me.LogInProgressBar1.Maximum = 100
        Me.LogInProgressBar1.Name = "LogInProgressBar1"
        Me.LogInProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LogInProgressBar1.Size = New System.Drawing.Size(470, 25)
        Me.LogInProgressBar1.TabIndex = 1
        Me.LogInProgressBar1.Text = "LogInProgressBar1"
        Me.LogInProgressBar1.TwoColour = True
        Me.LogInProgressBar1.Value = 0
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'S1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 235)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "S1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fable III Patcher - Installation Step 1"
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents StageCount As LogInLabel
    Friend WithEvents Statustext As LogInLabel
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents LogInProgressBar1 As LogInProgressBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
