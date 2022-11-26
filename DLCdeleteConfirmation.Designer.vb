<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLCdeleteConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLCdeleteConfirmation))
        Me.DLCdeleteThemeContainer = New Fable_III_Patcher.LogInThemeContainer()
        Me.LogInLabel1 = New Fable_III_Patcher.LogInLabel()
        Me.YesButton = New Fable_III_Patcher.LogInButton()
        Me.NoButton = New Fable_III_Patcher.LogInButton()
        Me.DLCdeleteThemeContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'DLCdeleteThemeContainer
        '
        Me.DLCdeleteThemeContainer.AllowClose = True
        Me.DLCdeleteThemeContainer.AllowMaximize = True
        Me.DLCdeleteThemeContainer.AllowMinimize = True
        Me.DLCdeleteThemeContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DLCdeleteThemeContainer.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DLCdeleteThemeContainer.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DLCdeleteThemeContainer.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DLCdeleteThemeContainer.Controls.Add(Me.NoButton)
        Me.DLCdeleteThemeContainer.Controls.Add(Me.YesButton)
        Me.DLCdeleteThemeContainer.Controls.Add(Me.LogInLabel1)
        Me.DLCdeleteThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DLCdeleteThemeContainer.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DLCdeleteThemeContainer.FontSize = 12
        Me.DLCdeleteThemeContainer.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DLCdeleteThemeContainer.Location = New System.Drawing.Point(0, 0)
        Me.DLCdeleteThemeContainer.Name = "DLCdeleteThemeContainer"
        Me.DLCdeleteThemeContainer.ShowIcon = True
        Me.DLCdeleteThemeContainer.Size = New System.Drawing.Size(392, 164)
        Me.DLCdeleteThemeContainer.TabIndex = 0
        Me.DLCdeleteThemeContainer.Text = "DLC Delete Confirmation"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(69, 40)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(266, 58)
        Me.LogInLabel1.TabIndex = 1
        Me.LogInLabel1.Text = "Are you sure you want to Delete your OLD DLC installation?"
        Me.LogInLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Transparent
        Me.YesButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.YesButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.YesButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YesButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.YesButton.Location = New System.Drawing.Point(59, 98)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.YesButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YesButton.Size = New System.Drawing.Size(121, 35)
        Me.YesButton.TabIndex = 2
        Me.YesButton.Text = "Yes"
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Transparent
        Me.NoButton.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NoButton.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.NoButton.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NoButton.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.NoButton.Location = New System.Drawing.Point(213, 98)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.NoButton.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NoButton.Size = New System.Drawing.Size(121, 35)
        Me.NoButton.TabIndex = 3
        Me.NoButton.Text = "No, Cancel"
        '
        'DLCdeleteConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 164)
        Me.Controls.Add(Me.DLCdeleteThemeContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DLCdeleteConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DLC Delete Confirmation"
        Me.TopMost = True
        Me.DLCdeleteThemeContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DLCdeleteThemeContainer As LogInThemeContainer
    Friend WithEvents NoButton As LogInButton
    Friend WithEvents YesButton As LogInButton
    Friend WithEvents LogInLabel1 As LogInLabel
End Class
