﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UcAjustes1 = New Vista.UCAjustes()
        Me.btnIngresar = New Guna.UI.WinForms.GunaButton()
        Me.lblRecordar = New System.Windows.Forms.Label()
        Me.lblCrearCuenta = New System.Windows.Forms.Label()
        Me.btnAjustes = New FontAwesome.Sharp.IconPictureBox()
        Me.mcbRecordarUsuario = New Guna.UI.WinForms.GunaCheckBox()
        Me.im = New FontAwesome.Sharp.IconPictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsr = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.txtPass = New Guna.UI.WinForms.GunaTextBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.im, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(880, 500)
        Me.pnlInstancia.TabIndex = 37
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.Button2)
        Me.pnlContenedor.Controls.Add(Me.Button1)
        Me.pnlContenedor.Controls.Add(Me.UcAjustes1)
        Me.pnlContenedor.Controls.Add(Me.btnIngresar)
        Me.pnlContenedor.Controls.Add(Me.lblRecordar)
        Me.pnlContenedor.Controls.Add(Me.lblCrearCuenta)
        Me.pnlContenedor.Controls.Add(Me.btnAjustes)
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
        Me.pnlContenedor.Size = New System.Drawing.Size(880, 500)
        Me.pnlContenedor.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UcAjustes1
        '
        Me.UcAjustes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UcAjustes1.Location = New System.Drawing.Point(177, 59)
        Me.UcAjustes1.Name = "UcAjustes1"
        Me.UcAjustes1.Size = New System.Drawing.Size(490, 410)
        Me.UcAjustes1.TabIndex = 52
        Me.UcAjustes1.Visible = False
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
        Me.btnIngresar.Location = New System.Drawing.Point(351, 388)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresar.OnHoverImage = Nothing
        Me.btnIngresar.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresar.Radius = 17
        Me.btnIngresar.Size = New System.Drawing.Size(180, 42)
        Me.btnIngresar.TabIndex = 51
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordar.ForeColor = System.Drawing.Color.White
        Me.lblRecordar.Location = New System.Drawing.Point(371, 297)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(159, 15)
        Me.lblRecordar.TabIndex = 50
        Me.lblRecordar.Text = "Restablecer contraseña"
        '
        'lblCrearCuenta
        '
        Me.lblCrearCuenta.AutoSize = True
        Me.lblCrearCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuenta.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuenta.Location = New System.Drawing.Point(68, 128)
        Me.lblCrearCuenta.Name = "lblCrearCuenta"
        Me.lblCrearCuenta.Size = New System.Drawing.Size(134, 20)
        Me.lblCrearCuenta.TabIndex = 49
        Me.lblCrearCuenta.Text = "Solicitar cuenta"
        '
        'btnAjustes
        '
        Me.btnAjustes.BackColor = System.Drawing.Color.Transparent
        Me.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjustes.ForeColor = System.Drawing.Color.LightGray
        Me.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnAjustes.IconColor = System.Drawing.Color.LightGray
        Me.btnAjustes.Location = New System.Drawing.Point(29, 24)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(32, 32)
        Me.btnAjustes.TabIndex = 48
        Me.btnAjustes.TabStop = False
        '
        'mcbRecordarUsuario
        '
        Me.mcbRecordarUsuario.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mcbRecordarUsuario.CheckedOffColor = System.Drawing.Color.Gray
        Me.mcbRecordarUsuario.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.mcbRecordarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcbRecordarUsuario.FillColor = System.Drawing.Color.White
        Me.mcbRecordarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbRecordarUsuario.ForeColor = System.Drawing.Color.LightGray
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(374, 345)
        Me.mcbRecordarUsuario.Name = "mcbRecordarUsuario"
        Me.mcbRecordarUsuario.Radius = 1
        Me.mcbRecordarUsuario.Size = New System.Drawing.Size(137, 20)
        Me.mcbRecordarUsuario.TabIndex = 47
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
        Me.im.Location = New System.Drawing.Point(553, -362)
        Me.im.Name = "im"
        Me.im.Rotation = 135.0R
        Me.im.Size = New System.Drawing.Size(594, 707)
        Me.im.TabIndex = 46
        Me.im.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(392, 59)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(104, 45)
        Me.lblLogin.TabIndex = 41
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
        Me.txtUsr.Location = New System.Drawing.Point(346, 144)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsr.Radius = 17
        Me.txtUsr.Size = New System.Drawing.Size(181, 42)
        Me.txtUsr.TabIndex = 42
        Me.txtUsr.Text = "Cédula"
        Me.txtUsr.TextOffsetX = 7
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(385, 109)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(77, 10)
        Me.GunaSeparator1.TabIndex = 44
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
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(346, 226)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Radius = 17
        Me.txtPass.Size = New System.Drawing.Size(181, 42)
        Me.txtPass.TabIndex = 43
        Me.txtPass.TextOffsetX = 5
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.Black
        Me.lblApp.Location = New System.Drawing.Point(83, 531)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(352, 57)
        Me.lblApp.TabIndex = 40
        Me.lblApp.Text = "APLICACION"
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Brown
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(729, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.im, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblRecordar As Label
    Friend WithEvents lblCrearCuenta As Label
    Friend WithEvents btnAjustes As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents mcbRecordarUsuario As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents im As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaTextBox
    Public WithEvents lblApp As Label
    Friend WithEvents UcAjustes1 As UCAjustes
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class