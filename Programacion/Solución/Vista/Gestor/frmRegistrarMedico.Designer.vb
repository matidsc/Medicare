<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarMedico
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
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.txtCed = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtEspec = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblEspec = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSegundoApellido = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.btnRegistrarMedico = New Guna.UI.WinForms.GunaButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(35, 123)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(182, 25)
        Me.lblNomPat.TabIndex = 183
        Me.lblNomPat.Text = "Cédula de identidad"
        '
        'txtCed
        '
        Me.txtCed.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCed.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCed.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCed.LineSize = 1
        Me.txtCed.Location = New System.Drawing.Point(40, 170)
        Me.txtCed.Name = "txtCed"
        Me.txtCed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCed.Size = New System.Drawing.Size(262, 36)
        Me.txtCed.TabIndex = 1
        '
        'txtEspec
        '
        Me.txtEspec.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEspec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEspec.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEspec.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEspec.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEspec.LineSize = 1
        Me.txtEspec.Location = New System.Drawing.Point(33, 383)
        Me.txtEspec.Name = "txtEspec"
        Me.txtEspec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEspec.Size = New System.Drawing.Size(262, 36)
        Me.txtEspec.TabIndex = 2
        '
        'lblEspec
        '
        Me.lblEspec.AutoSize = True
        Me.lblEspec.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblEspec.Location = New System.Drawing.Point(28, 336)
        Me.lblEspec.Name = "lblEspec"
        Me.lblEspec.Size = New System.Drawing.Size(140, 25)
        Me.lblEspec.TabIndex = 185
        Me.lblEspec.Text = "Especialización"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimerNombre.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrimerNombre.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPrimerNombre.LineSize = 1
        Me.txtPrimerNombre.Location = New System.Drawing.Point(404, 179)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimerNombre.Size = New System.Drawing.Size(262, 36)
        Me.txtPrimerNombre.TabIndex = 3
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPNom.Location = New System.Drawing.Point(399, 123)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(139, 25)
        Me.lblPNom.TabIndex = 187
        Me.lblPNom.Text = "Primer nombre"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoNombre.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSegundoNombre.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSegundoNombre.LineSize = 1
        Me.txtSegundoNombre.Location = New System.Drawing.Point(404, 387)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoNombre.Size = New System.Drawing.Size(262, 36)
        Me.txtSegundoNombre.TabIndex = 4
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSNom.Location = New System.Drawing.Point(400, 336)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(158, 25)
        Me.lblSNom.TabIndex = 189
        Me.lblSNom.Text = "Segundo nombre"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimerApellido.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrimerApellido.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPrimerApellido.LineSize = 1
        Me.txtPrimerApellido.Location = New System.Drawing.Point(746, 179)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimerApellido.Size = New System.Drawing.Size(262, 36)
        Me.txtPrimerApellido.TabIndex = 5
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoApellido.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSegundoApellido.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSegundoApellido.LineSize = 1
        Me.txtSegundoApellido.Location = New System.Drawing.Point(764, 390)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoApellido.Size = New System.Drawing.Size(262, 36)
        Me.txtSegundoApellido.TabIndex = 6
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPApe.Location = New System.Drawing.Point(741, 123)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(141, 25)
        Me.lblPApe.TabIndex = 192
        Me.lblPApe.Text = "Primer apellido"
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSApe.Location = New System.Drawing.Point(760, 336)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(160, 25)
        Me.lblSApe.TabIndex = 193
        Me.lblSApe.Text = "Segundo apellido"
        '
        'btnRegistrarMedico
        '
        Me.btnRegistrarMedico.AnimationHoverSpeed = 0.07!
        Me.btnRegistrarMedico.AnimationSpeed = 0.03!
        Me.btnRegistrarMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarMedico.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegistrarMedico.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrarMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrarMedico.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarMedico.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarMedico.Image = Nothing
        Me.btnRegistrarMedico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrarMedico.Location = New System.Drawing.Point(436, 572)
        Me.btnRegistrarMedico.Name = "btnRegistrarMedico"
        Me.btnRegistrarMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegistrarMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrarMedico.OnHoverImage = Nothing
        Me.btnRegistrarMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.Radius = 20
        Me.btnRegistrarMedico.Size = New System.Drawing.Size(199, 42)
        Me.btnRegistrarMedico.TabIndex = 7
        Me.btnRegistrarMedico.Text = "Registrar"
        Me.btnRegistrarMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(22, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 195
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmRegistrarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrarMedico)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.lblSNom)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.lblEspec)
        Me.Controls.Add(Me.txtEspec)
        Me.Controls.Add(Me.lblNomPat)
        Me.Controls.Add(Me.txtCed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNomPat As Label
    Friend WithEvents txtCed As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtEspec As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblEspec As Label
    Friend WithEvents txtPrimerNombre As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPNom As Label
    Friend WithEvents txtSegundoNombre As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblSNom As Label
    Friend WithEvents txtPrimerApellido As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSegundoApellido As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPApe As Label
    Friend WithEvents lblSApe As Label
    Friend WithEvents btnRegistrarMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
End Class
