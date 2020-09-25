<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.im = New FontAwesome.Sharp.IconPictureBox()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        CType(Me.im, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Circular Std Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(385, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(350, 431)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 20
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 10
        Me.GunaAdvenceButton1.Text = "Ingresar"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox1.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox1.Location = New System.Drawing.Point(350, 203)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 10
        Me.GunaTextBox1.Size = New System.Drawing.Size(181, 42)
        Me.GunaTextBox1.TabIndex = 6
        Me.GunaTextBox1.TextOffsetX = 5
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(378, 130)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(77, 10)
        Me.GunaSeparator1.TabIndex = 9
        Me.GunaSeparator1.Thickness = 5
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Location = New System.Drawing.Point(350, 285)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.GunaTextBox2.Radius = 10
        Me.GunaTextBox2.Size = New System.Drawing.Size(181, 42)
        Me.GunaTextBox2.TabIndex = 7
        Me.GunaTextBox2.TextOffsetX = 5
        Me.GunaTextBox2.UseSystemPasswordChar = True
        '
        'im
        '
        Me.im.BackColor = System.Drawing.Color.Transparent
        Me.im.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.im.IconChar = FontAwesome.Sharp.IconChar.GripLinesVertical
        Me.im.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.im.IconSize = 594
        Me.im.Location = New System.Drawing.Point(553, -362)
        Me.im.Name = "im"
        Me.im.Rotation = 135.0R
        Me.im.Size = New System.Drawing.Size(594, 707)
        Me.im.TabIndex = 11
        Me.im.TabStop = False
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.Silver
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.LightGray
        Me.GunaCheckBox1.Location = New System.Drawing.Point(376, 382)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Radius = 1
        Me.GunaCheckBox1.Size = New System.Drawing.Size(136, 20)
        Me.GunaCheckBox1.TabIndex = 12
        Me.GunaCheckBox1.Text = "Recordar usuario"
        Me.GunaCheckBox1.Visible = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconPictureBox3.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox3.Location = New System.Drawing.Point(29, 24)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 14
        Me.IconPictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Circular Std Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(378, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Solicitar cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Circular Std Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(371, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Restablecer contraseña"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Me.Label1
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 535)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.GunaCheckBox1)
        Me.Controls.Add(Me.im)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.im, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents im As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
End Class
