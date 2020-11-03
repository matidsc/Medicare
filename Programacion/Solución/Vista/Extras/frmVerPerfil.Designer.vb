<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerPerfil
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblPatologiasCronicas = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.picImagenPerfil = New System.Windows.Forms.PictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.txtPNom = New Guna.UI.WinForms.GunaLineTextBox()
        CType(Me.picImagenPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Silver
        Me.lblNombre.Location = New System.Drawing.Point(23, 223)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 34)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:  xxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Silver
        Me.lblMail.Location = New System.Drawing.Point(23, 317)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(261, 34)
        Me.lblMail.TabIndex = 2
        Me.lblMail.Text = "e-mail: xxxxxxxxxxxxxxxxxxx"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.Silver
        Me.lblTelefonos.Location = New System.Drawing.Point(23, 396)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(214, 24)
        Me.lblTelefonos.TabIndex = 3
        Me.lblTelefonos.Text = "Teléfonos: xxxxxxxxxxx"
        '
        'lblPatologiasCronicas
        '
        Me.lblPatologiasCronicas.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologiasCronicas.ForeColor = System.Drawing.Color.Silver
        Me.lblPatologiasCronicas.Location = New System.Drawing.Point(23, 470)
        Me.lblPatologiasCronicas.Name = "lblPatologiasCronicas"
        Me.lblPatologiasCronicas.Size = New System.Drawing.Size(391, 58)
        Me.lblPatologiasCronicas.TabIndex = 4
        Me.lblPatologiasCronicas.Text = "Patologías crónicas: xxxxxxxxx,xxxxxxxxxxxx,xxxxxxxx"
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.Black
        Me.lblMinimizar.Location = New System.Drawing.Point(0, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 24
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.Black
        Me.lblCerrar.Location = New System.Drawing.Point(0, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picImagenPerfil
        '
        Me.picImagenPerfil.Image = Global.Vista.My.Resources.Resources.icons8_user_80px_1
        Me.picImagenPerfil.Location = New System.Drawing.Point(163, 85)
        Me.picImagenPerfil.Name = "picImagenPerfil"
        Me.picImagenPerfil.Size = New System.Drawing.Size(101, 95)
        Me.picImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagenPerfil.TabIndex = 0
        Me.picImagenPerfil.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Silver
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Silver
        Me.IconPictureBox1.IconSize = 46
        Me.IconPictureBox1.Location = New System.Drawing.Point(352, 33)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(53, 46)
        Me.IconPictureBox1.TabIndex = 25
        Me.IconPictureBox1.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.Silver
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconPictureBox2.IconColor = System.Drawing.Color.Silver
        Me.IconPictureBox2.IconSize = 30
        Me.IconPictureBox2.Location = New System.Drawing.Point(363, 245)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.IconPictureBox2.TabIndex = 26
        Me.IconPictureBox2.TabStop = False
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.White
        Me.txtPNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPNom.LineSize = 1
        Me.txtPNom.Location = New System.Drawing.Point(28, 260)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.Size = New System.Drawing.Size(246, 32)
        Me.txtPNom.TabIndex = 27
        '
        'frmVerPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 623)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.picImagenPerfil)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblPatologiasCronicas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVerPerfil"
        Me.Text = "VerPerfil"
        CType(Me.picImagenPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picImagenPerfil As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents lblPatologiasCronicas As Label
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents txtPNom As Guna.UI.WinForms.GunaLineTextBox
End Class
