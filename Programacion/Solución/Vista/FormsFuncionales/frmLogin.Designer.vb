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
        Me.ing = New System.Windows.Forms.RadioButton()
        Me.esp = New System.Windows.Forms.RadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.lblCrearCuentaPac = New System.Windows.Forms.Button()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.btnIngresar = New Guna.UI.WinForms.GunaButton()
        Me.lblRecordar = New System.Windows.Forms.Label()
        Me.lblCrearCuenta = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.mcbRecordarUsuario = New Guna.UI.WinForms.GunaCheckBox()
        Me.im = New FontAwesome.Sharp.IconPictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsr = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.txtPass = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.im, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.ForeColor = System.Drawing.SystemColors.Control
        Me.ing.Location = New System.Drawing.Point(204, 408)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(52, 17)
        Me.ing.TabIndex = 24
        Me.ing.TabStop = True
        Me.ing.Text = "ingles"
        Me.ing.UseVisualStyleBackColor = True
        '
        'esp
        '
        Me.esp.AutoSize = True
        Me.esp.ForeColor = System.Drawing.SystemColors.Control
        Me.esp.Location = New System.Drawing.Point(215, 316)
        Me.esp.Name = "esp"
        Me.esp.Size = New System.Drawing.Size(58, 17)
        Me.esp.TabIndex = 23
        Me.esp.TabStop = True
        Me.esp.Text = "espalol"
        Me.esp.UseVisualStyleBackColor = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(94, 305)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 22
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'lblCrearCuentaPac
        '
        Me.lblCrearCuentaPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrearCuentaPac.BackColor = System.Drawing.Color.DimGray
        Me.lblCrearCuentaPac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCrearCuentaPac.FlatAppearance.BorderSize = 0
        Me.lblCrearCuentaPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCrearCuentaPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblCrearCuentaPac.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuentaPac.Location = New System.Drawing.Point(75, 254)
        Me.lblCrearCuentaPac.Name = "lblCrearCuentaPac"
        Me.lblCrearCuentaPac.Size = New System.Drawing.Size(148, 40)
        Me.lblCrearCuentaPac.TabIndex = 31
        Me.lblCrearCuentaPac.UseVisualStyleBackColor = False
        Me.lblCrearCuentaPac.Visible = False
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.Black
        Me.lblApp.Location = New System.Drawing.Point(110, 417)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(269, 57)
        Me.lblApp.TabIndex = 25
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.Controls.Add(Me.btnIngresar)
        Me.pnlContenedor.Controls.Add(Me.lblCrearCuentaPac)
        Me.pnlContenedor.Controls.Add(Me.esp)
        Me.pnlContenedor.Controls.Add(Me.lblRecordar)
        Me.pnlContenedor.Controls.Add(Me.lblCrearCuenta)
        Me.pnlContenedor.Controls.Add(Me.ing)
        Me.pnlContenedor.Controls.Add(Me.MetroButton1)
        Me.pnlContenedor.Controls.Add(Me.IconPictureBox3)
        Me.pnlContenedor.Controls.Add(Me.mcbRecordarUsuario)
        Me.pnlContenedor.Controls.Add(Me.im)
        Me.pnlContenedor.Controls.Add(Me.lblLogin)
        Me.pnlContenedor.Controls.Add(Me.txtUsr)
        Me.pnlContenedor.Controls.Add(Me.GunaSeparator1)
        Me.pnlContenedor.Controls.Add(Me.txtPass)
        Me.pnlContenedor.Controls.Add(Me.lblApp)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1199, 648)
        Me.pnlContenedor.TabIndex = 25
        '
        'btnIngresar
        '
        Me.btnIngresar.AnimationHoverSpeed = 0.07!
        Me.btnIngresar.AnimationSpeed = 0.03!
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnIngresar.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresar.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Image = Nothing
        Me.btnIngresar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnIngresar.Location = New System.Drawing.Point(450, 417)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresar.OnHoverImage = Nothing
        Me.btnIngresar.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresar.Radius = 17
        Me.btnIngresar.Size = New System.Drawing.Size(180, 42)
        Me.btnIngresar.TabIndex = 36
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.Font = New System.Drawing.Font("Circular Std Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordar.ForeColor = System.Drawing.Color.White
        Me.lblRecordar.Location = New System.Drawing.Point(470, 319)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(138, 15)
        Me.lblRecordar.TabIndex = 35
        Me.lblRecordar.Text = "Restablecer contraseña"
        '
        'lblCrearCuenta
        '
        Me.lblCrearCuenta.AutoSize = True
        Me.lblCrearCuenta.Font = New System.Drawing.Font("Circular Std Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuenta.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuenta.Location = New System.Drawing.Point(164, 131)
        Me.lblCrearCuenta.Name = "lblCrearCuenta"
        Me.lblCrearCuenta.Size = New System.Drawing.Size(125, 20)
        Me.lblCrearCuenta.TabIndex = 34
        Me.lblCrearCuenta.Text = "Solicitar cuenta"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconPictureBox3.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox3.Location = New System.Drawing.Point(128, 46)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 33
        Me.IconPictureBox3.TabStop = False
        '
        'mcbRecordarUsuario
        '
        Me.mcbRecordarUsuario.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mcbRecordarUsuario.CheckedOffColor = System.Drawing.Color.Gray
        Me.mcbRecordarUsuario.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.mcbRecordarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcbRecordarUsuario.FillColor = System.Drawing.Color.White
        Me.mcbRecordarUsuario.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbRecordarUsuario.ForeColor = System.Drawing.Color.LightGray
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(473, 367)
        Me.mcbRecordarUsuario.Name = "mcbRecordarUsuario"
        Me.mcbRecordarUsuario.Radius = 1
        Me.mcbRecordarUsuario.Size = New System.Drawing.Size(136, 20)
        Me.mcbRecordarUsuario.TabIndex = 32
        Me.mcbRecordarUsuario.Text = "Recordar usuario"
        Me.mcbRecordarUsuario.Visible = False
        '
        'im
        '
        Me.im.BackColor = System.Drawing.Color.Transparent
        Me.im.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.im.IconChar = FontAwesome.Sharp.IconChar.GripLinesVertical
        Me.im.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.im.IconSize = 594
        Me.im.Location = New System.Drawing.Point(652, -340)
        Me.im.Name = "im"
        Me.im.Rotation = 135.0R
        Me.im.Size = New System.Drawing.Size(594, 707)
        Me.im.TabIndex = 31
        Me.im.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(491, 81)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(104, 45)
        Me.lblLogin.TabIndex = 26
        Me.lblLogin.Text = "Login"
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.Color.Transparent
        Me.txtUsr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsr.BorderColor = System.Drawing.Color.Silver
        Me.txtUsr.BorderSize = 1
        Me.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsr.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtUsr.FocusedBorderColor = System.Drawing.Color.White
        Me.txtUsr.FocusedForeColor = System.Drawing.Color.White
        Me.txtUsr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsr.Location = New System.Drawing.Point(449, 182)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsr.Radius = 17
        Me.txtUsr.Size = New System.Drawing.Size(181, 42)
        Me.txtUsr.TabIndex = 27
        Me.txtUsr.Text = "Cédula"
        Me.txtUsr.TextOffsetX = 7
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(484, 131)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(77, 10)
        Me.GunaSeparator1.TabIndex = 29
        Me.GunaSeparator1.Thickness = 5
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.BorderColor = System.Drawing.Color.Silver
        Me.txtPass.BorderSize = 1
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPass.FocusedBorderColor = System.Drawing.Color.White
        Me.txtPass.FocusedForeColor = System.Drawing.Color.White
        Me.txtPass.Font = New System.Drawing.Font("Circular Std Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(449, 264)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Radius = 17
        Me.txtPass.Size = New System.Drawing.Size(181, 42)
        Me.txtPass.TabIndex = 28
        Me.txtPass.TextOffsetX = 5
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1199, 648)
        Me.pnlInstancia.TabIndex = 37
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1199, 648)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.im, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ing As RadioButton
    Friend WithEvents esp As RadioButton
    Friend WithEvents pnlContenedor As Panel
    Public WithEvents lblCrearCuentaPac As Button
    Public WithEvents lblApp As Label
    Friend WithEvents lblRecordar As Label
    Friend WithEvents lblCrearCuenta As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents mcbRecordarUsuario As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents im As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlInstancia As Panel
End Class