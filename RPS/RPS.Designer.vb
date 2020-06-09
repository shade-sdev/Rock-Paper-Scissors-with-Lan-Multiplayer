<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPS))
        Me.UserPicBox = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.CpuPicBox = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.RockBtn = New Guna.UI.WinForms.GunaButton()
        Me.PaperBtn = New Guna.UI.WinForms.GunaButton()
        Me.ScissorsBtn = New Guna.UI.WinForms.GunaButton()
        Me.UserName = New Guna.UI.WinForms.GunaLabel()
        Me.CpuName = New Guna.UI.WinForms.GunaLabel()
        Me.WinnerAnnounce = New Guna.UI.WinForms.GunaLabel()
        Me.PlayerScoreLabel = New Guna.UI.WinForms.GunaLabel()
        Me.CpuScoreLabel = New Guna.UI.WinForms.GunaLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CpuPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPicBox
        '
        Me.UserPicBox.BackColor = System.Drawing.Color.Transparent
        Me.UserPicBox.BaseColor = System.Drawing.Color.Black
        Me.UserPicBox.Location = New System.Drawing.Point(51, 46)
        Me.UserPicBox.MaximumSize = New System.Drawing.Size(252, 244)
        Me.UserPicBox.MinimumSize = New System.Drawing.Size(252, 244)
        Me.UserPicBox.Name = "UserPicBox"
        Me.UserPicBox.Size = New System.Drawing.Size(252, 244)
        Me.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicBox.TabIndex = 0
        Me.UserPicBox.TabStop = False
        '
        'CpuPicBox
        '
        Me.CpuPicBox.BackColor = System.Drawing.Color.Transparent
        Me.CpuPicBox.BaseColor = System.Drawing.Color.Black
        Me.CpuPicBox.Location = New System.Drawing.Point(570, 46)
        Me.CpuPicBox.MaximumSize = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.MinimumSize = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.Name = "CpuPicBox"
        Me.CpuPicBox.Size = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CpuPicBox.TabIndex = 1
        Me.CpuPicBox.TabStop = False
        '
        'RockBtn
        '
        Me.RockBtn.AnimationHoverSpeed = 0.07!
        Me.RockBtn.AnimationSpeed = 0.03!
        Me.RockBtn.BackColor = System.Drawing.Color.Transparent
        Me.RockBtn.BaseColor = System.Drawing.Color.Transparent
        Me.RockBtn.BorderColor = System.Drawing.Color.Black
        Me.RockBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RockBtn.FocusedColor = System.Drawing.Color.Empty
        Me.RockBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RockBtn.ForeColor = System.Drawing.Color.White
        Me.RockBtn.Image = CType(resources.GetObject("RockBtn.Image"), System.Drawing.Image)
        Me.RockBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RockBtn.ImageSize = New System.Drawing.Size(80, 80)
        Me.RockBtn.Location = New System.Drawing.Point(399, 357)
        Me.RockBtn.Name = "RockBtn"
        Me.RockBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.RockBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.RockBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.RockBtn.OnHoverImage = Nothing
        Me.RockBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.RockBtn.Size = New System.Drawing.Size(64, 81)
        Me.RockBtn.TabIndex = 2
        '
        'PaperBtn
        '
        Me.PaperBtn.AnimationHoverSpeed = 0.07!
        Me.PaperBtn.AnimationSpeed = 0.03!
        Me.PaperBtn.BackColor = System.Drawing.Color.Transparent
        Me.PaperBtn.BaseColor = System.Drawing.Color.Transparent
        Me.PaperBtn.BorderColor = System.Drawing.Color.Black
        Me.PaperBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PaperBtn.FocusedColor = System.Drawing.Color.Empty
        Me.PaperBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PaperBtn.ForeColor = System.Drawing.Color.White
        Me.PaperBtn.Image = CType(resources.GetObject("PaperBtn.Image"), System.Drawing.Image)
        Me.PaperBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PaperBtn.ImageSize = New System.Drawing.Size(80, 80)
        Me.PaperBtn.Location = New System.Drawing.Point(319, 357)
        Me.PaperBtn.Name = "PaperBtn"
        Me.PaperBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.PaperBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PaperBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.PaperBtn.OnHoverImage = Nothing
        Me.PaperBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.PaperBtn.Size = New System.Drawing.Size(64, 81)
        Me.PaperBtn.TabIndex = 3
        '
        'ScissorsBtn
        '
        Me.ScissorsBtn.AnimationHoverSpeed = 0.07!
        Me.ScissorsBtn.AnimationSpeed = 0.03!
        Me.ScissorsBtn.BackColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.BaseColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.BorderColor = System.Drawing.Color.Black
        Me.ScissorsBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ScissorsBtn.FocusedColor = System.Drawing.Color.Empty
        Me.ScissorsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ScissorsBtn.ForeColor = System.Drawing.Color.White
        Me.ScissorsBtn.Image = CType(resources.GetObject("ScissorsBtn.Image"), System.Drawing.Image)
        Me.ScissorsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ScissorsBtn.ImageSize = New System.Drawing.Size(80, 80)
        Me.ScissorsBtn.Location = New System.Drawing.Point(478, 357)
        Me.ScissorsBtn.Name = "ScissorsBtn"
        Me.ScissorsBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ScissorsBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.ScissorsBtn.OnHoverImage = Nothing
        Me.ScissorsBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.Size = New System.Drawing.Size(64, 81)
        Me.ScissorsBtn.TabIndex = 4
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UserName.Location = New System.Drawing.Point(148, 303)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(74, 19)
        Me.UserName.TabIndex = 5
        Me.UserName.Text = "PLAYER"
        '
        'CpuName
        '
        Me.CpuName.AutoSize = True
        Me.CpuName.BackColor = System.Drawing.Color.Transparent
        Me.CpuName.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpuName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CpuName.Location = New System.Drawing.Point(683, 303)
        Me.CpuName.Name = "CpuName"
        Me.CpuName.Size = New System.Drawing.Size(42, 19)
        Me.CpuName.TabIndex = 6
        Me.CpuName.Text = "CPU"
        '
        'WinnerAnnounce
        '
        Me.WinnerAnnounce.AutoSize = True
        Me.WinnerAnnounce.BackColor = System.Drawing.Color.Transparent
        Me.WinnerAnnounce.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinnerAnnounce.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.WinnerAnnounce.Location = New System.Drawing.Point(395, 172)
        Me.WinnerAnnounce.Name = "WinnerAnnounce"
        Me.WinnerAnnounce.Size = New System.Drawing.Size(89, 19)
        Me.WinnerAnnounce.TabIndex = 7
        Me.WinnerAnnounce.Text = "Have Fun!"
        Me.WinnerAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerScoreLabel
        '
        Me.PlayerScoreLabel.AutoSize = True
        Me.PlayerScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlayerScoreLabel.Font = New System.Drawing.Font("Russo One", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayerScoreLabel.Location = New System.Drawing.Point(12, 423)
        Me.PlayerScoreLabel.Name = "PlayerScoreLabel"
        Me.PlayerScoreLabel.Size = New System.Drawing.Size(109, 15)
        Me.PlayerScoreLabel.TabIndex = 9
        Me.PlayerScoreLabel.Text = "PLAYER SCORE:"
        '
        'CpuScoreLabel
        '
        Me.CpuScoreLabel.AutoSize = True
        Me.CpuScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.CpuScoreLabel.Font = New System.Drawing.Font("Russo One", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpuScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CpuScoreLabel.Location = New System.Drawing.Point(758, 423)
        Me.CpuScoreLabel.Name = "CpuScoreLabel"
        Me.CpuScoreLabel.Size = New System.Drawing.Size(84, 15)
        Me.CpuScoreLabel.TabIndex = 10
        Me.CpuScoreLabel.Text = "CPU SCORE:"
        '
        'RPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(868, 450)
        Me.Controls.Add(Me.CpuScoreLabel)
        Me.Controls.Add(Me.PlayerScoreLabel)
        Me.Controls.Add(Me.WinnerAnnounce)
        Me.Controls.Add(Me.CpuName)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.ScissorsBtn)
        Me.Controls.Add(Me.PaperBtn)
        Me.Controls.Add(Me.RockBtn)
        Me.Controls.Add(Me.CpuPicBox)
        Me.Controls.Add(Me.UserPicBox)
        Me.Name = "RPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPS"
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CpuPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserPicBox As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents CpuPicBox As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents RockBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PaperBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents ScissorsBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents UserName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CpuName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents WinnerAnnounce As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PlayerScoreLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CpuScoreLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
