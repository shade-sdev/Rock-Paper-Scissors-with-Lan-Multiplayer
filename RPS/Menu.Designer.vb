<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PlayBtn = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.HostBtn = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.JoinBtn = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PlayBtn
        '
        Me.PlayBtn.AnimationHoverSpeed = 0.07!
        Me.PlayBtn.AnimationSpeed = 0.03!
        Me.PlayBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayBtn.BorderColor = System.Drawing.Color.Black
        Me.PlayBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.PlayBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.PlayBtn.CheckedForeColor = System.Drawing.Color.White
        Me.PlayBtn.CheckedImage = CType(resources.GetObject("PlayBtn.CheckedImage"), System.Drawing.Image)
        Me.PlayBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.PlayBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PlayBtn.FocusedColor = System.Drawing.Color.Empty
        Me.PlayBtn.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Image = CType(resources.GetObject("PlayBtn.Image"), System.Drawing.Image)
        Me.PlayBtn.ImageSize = New System.Drawing.Size(52, 52)
        Me.PlayBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PlayBtn.Location = New System.Drawing.Point(68, 177)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PlayBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.PlayBtn.OnHoverImage = Nothing
        Me.PlayBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PlayBtn.OnPressedColor = System.Drawing.Color.Black
        Me.PlayBtn.Size = New System.Drawing.Size(160, 96)
        Me.PlayBtn.TabIndex = 0
        Me.PlayBtn.Text = "PLAY VS CPU"
        '
        'HostBtn
        '
        Me.HostBtn.AnimationHoverSpeed = 0.07!
        Me.HostBtn.AnimationSpeed = 0.03!
        Me.HostBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HostBtn.BorderColor = System.Drawing.Color.Black
        Me.HostBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.HostBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.HostBtn.CheckedForeColor = System.Drawing.Color.White
        Me.HostBtn.CheckedImage = CType(resources.GetObject("HostBtn.CheckedImage"), System.Drawing.Image)
        Me.HostBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.HostBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.HostBtn.FocusedColor = System.Drawing.Color.Empty
        Me.HostBtn.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.HostBtn.ForeColor = System.Drawing.Color.White
        Me.HostBtn.Image = CType(resources.GetObject("HostBtn.Image"), System.Drawing.Image)
        Me.HostBtn.ImageSize = New System.Drawing.Size(52, 52)
        Me.HostBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.HostBtn.Location = New System.Drawing.Point(322, 177)
        Me.HostBtn.Name = "HostBtn"
        Me.HostBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HostBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.HostBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.HostBtn.OnHoverImage = Nothing
        Me.HostBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.HostBtn.OnPressedColor = System.Drawing.Color.Black
        Me.HostBtn.Size = New System.Drawing.Size(160, 96)
        Me.HostBtn.TabIndex = 1
        Me.HostBtn.Text = "HOST GAME"
        '
        'JoinBtn
        '
        Me.JoinBtn.AnimationHoverSpeed = 0.07!
        Me.JoinBtn.AnimationSpeed = 0.03!
        Me.JoinBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JoinBtn.BorderColor = System.Drawing.Color.Black
        Me.JoinBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.JoinBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.JoinBtn.CheckedForeColor = System.Drawing.Color.White
        Me.JoinBtn.CheckedImage = CType(resources.GetObject("JoinBtn.CheckedImage"), System.Drawing.Image)
        Me.JoinBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.JoinBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.JoinBtn.FocusedColor = System.Drawing.Color.Empty
        Me.JoinBtn.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.JoinBtn.ForeColor = System.Drawing.Color.White
        Me.JoinBtn.Image = CType(resources.GetObject("JoinBtn.Image"), System.Drawing.Image)
        Me.JoinBtn.ImageSize = New System.Drawing.Size(52, 52)
        Me.JoinBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.JoinBtn.Location = New System.Drawing.Point(576, 177)
        Me.JoinBtn.Name = "JoinBtn"
        Me.JoinBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JoinBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.JoinBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.JoinBtn.OnHoverImage = Nothing
        Me.JoinBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.JoinBtn.OnPressedColor = System.Drawing.Color.Black
        Me.JoinBtn.Size = New System.Drawing.Size(160, 96)
        Me.JoinBtn.TabIndex = 2
        Me.JoinBtn.Text = "JOIN GAME"
        '
        'IPTextBox
        '
        Me.IPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPTextBox.Location = New System.Drawing.Point(576, 300)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(160, 19)
        Me.IPTextBox.TabIndex = 3
        Me.IPTextBox.Text = "IP Address"
        Me.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IPTextBox)
        Me.Controls.Add(Me.JoinBtn)
        Me.Controls.Add(Me.HostBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayBtn As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents HostBtn As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents JoinBtn As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents IPTextBox As TextBox
End Class
