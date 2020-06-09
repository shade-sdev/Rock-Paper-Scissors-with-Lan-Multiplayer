<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.CpuScoreLabel = New Guna.UI.WinForms.GunaLabel()
        Me.PlayerScoreLabel = New Guna.UI.WinForms.GunaLabel()
        Me.CpuName = New Guna.UI.WinForms.GunaLabel()
        Me.UserName = New Guna.UI.WinForms.GunaLabel()
        Me.ScissorsBtn = New Guna.UI.WinForms.GunaButton()
        Me.PaperBtn = New Guna.UI.WinForms.GunaButton()
        Me.RockBtn = New Guna.UI.WinForms.GunaButton()
        Me.CpuPicBox = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.UserPicBox = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.WinnerAnnounce = New Guna.UI.WinForms.GunaLabel()
        CType(Me.CpuPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CpuScoreLabel
        '
        Me.CpuScoreLabel.AutoSize = True
        Me.CpuScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.CpuScoreLabel.Font = New System.Drawing.Font("Russo One", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpuScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CpuScoreLabel.Location = New System.Drawing.Point(718, 406)
        Me.CpuScoreLabel.Name = "CpuScoreLabel"
        Me.CpuScoreLabel.Size = New System.Drawing.Size(127, 15)
        Me.CpuScoreLabel.TabIndex = 19
        Me.CpuScoreLabel.Text = "OPPONENT SCORE:"
        '
        'PlayerScoreLabel
        '
        Me.PlayerScoreLabel.AutoSize = True
        Me.PlayerScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlayerScoreLabel.Font = New System.Drawing.Font("Russo One", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayerScoreLabel.Location = New System.Drawing.Point(19, 406)
        Me.PlayerScoreLabel.Name = "PlayerScoreLabel"
        Me.PlayerScoreLabel.Size = New System.Drawing.Size(109, 15)
        Me.PlayerScoreLabel.TabIndex = 18
        Me.PlayerScoreLabel.Text = "PLAYER SCORE:"
        '
        'CpuName
        '
        Me.CpuName.AutoSize = True
        Me.CpuName.BackColor = System.Drawing.Color.Transparent
        Me.CpuName.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpuName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CpuName.Location = New System.Drawing.Point(668, 286)
        Me.CpuName.Name = "CpuName"
        Me.CpuName.Size = New System.Drawing.Size(99, 19)
        Me.CpuName.TabIndex = 17
        Me.CpuName.Text = "OPPONENT"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UserName.Location = New System.Drawing.Point(155, 286)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(74, 19)
        Me.UserName.TabIndex = 16
        Me.UserName.Text = "PLAYER"
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
        Me.ScissorsBtn.Location = New System.Drawing.Point(485, 340)
        Me.ScissorsBtn.Name = "ScissorsBtn"
        Me.ScissorsBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ScissorsBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.ScissorsBtn.OnHoverImage = Nothing
        Me.ScissorsBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.ScissorsBtn.Size = New System.Drawing.Size(64, 81)
        Me.ScissorsBtn.TabIndex = 15
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
        Me.PaperBtn.Location = New System.Drawing.Point(326, 340)
        Me.PaperBtn.Name = "PaperBtn"
        Me.PaperBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.PaperBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PaperBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.PaperBtn.OnHoverImage = Nothing
        Me.PaperBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.PaperBtn.Size = New System.Drawing.Size(64, 81)
        Me.PaperBtn.TabIndex = 14
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
        Me.RockBtn.Location = New System.Drawing.Point(406, 340)
        Me.RockBtn.Name = "RockBtn"
        Me.RockBtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.RockBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.RockBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.RockBtn.OnHoverImage = Nothing
        Me.RockBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.RockBtn.Size = New System.Drawing.Size(64, 81)
        Me.RockBtn.TabIndex = 13
        '
        'CpuPicBox
        '
        Me.CpuPicBox.BackColor = System.Drawing.Color.Transparent
        Me.CpuPicBox.BaseColor = System.Drawing.Color.Black
        Me.CpuPicBox.Location = New System.Drawing.Point(577, 29)
        Me.CpuPicBox.MaximumSize = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.MinimumSize = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.Name = "CpuPicBox"
        Me.CpuPicBox.Size = New System.Drawing.Size(252, 244)
        Me.CpuPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CpuPicBox.TabIndex = 12
        Me.CpuPicBox.TabStop = False
        '
        'UserPicBox
        '
        Me.UserPicBox.BackColor = System.Drawing.Color.Transparent
        Me.UserPicBox.BaseColor = System.Drawing.Color.Black
        Me.UserPicBox.Location = New System.Drawing.Point(58, 29)
        Me.UserPicBox.MaximumSize = New System.Drawing.Size(252, 244)
        Me.UserPicBox.MinimumSize = New System.Drawing.Size(252, 244)
        Me.UserPicBox.Name = "UserPicBox"
        Me.UserPicBox.Size = New System.Drawing.Size(252, 244)
        Me.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicBox.TabIndex = 11
        Me.UserPicBox.TabStop = False
        '
        'WinnerAnnounce
        '
        Me.WinnerAnnounce.AutoSize = True
        Me.WinnerAnnounce.BackColor = System.Drawing.Color.Transparent
        Me.WinnerAnnounce.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinnerAnnounce.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.WinnerAnnounce.Location = New System.Drawing.Point(392, 145)
        Me.WinnerAnnounce.Name = "WinnerAnnounce"
        Me.WinnerAnnounce.Size = New System.Drawing.Size(89, 19)
        Me.WinnerAnnounce.TabIndex = 20
        Me.WinnerAnnounce.Text = "Have Fun!"
        Me.WinnerAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(868, 450)
        Me.Controls.Add(Me.WinnerAnnounce)
        Me.Controls.Add(Me.CpuScoreLabel)
        Me.Controls.Add(Me.PlayerScoreLabel)
        Me.Controls.Add(Me.CpuName)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.ScissorsBtn)
        Me.Controls.Add(Me.PaperBtn)
        Me.Controls.Add(Me.RockBtn)
        Me.Controls.Add(Me.CpuPicBox)
        Me.Controls.Add(Me.UserPicBox)
        Me.Name = "Game"
        Me.Text = "RPS"
        CType(Me.CpuPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CpuScoreLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PlayerScoreLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CpuName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UserName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ScissorsBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PaperBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents RockBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents CpuPicBox As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents UserPicBox As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents WinnerAnnounce As Guna.UI.WinForms.GunaLabel
End Class
