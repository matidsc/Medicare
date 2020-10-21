<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDatosGestor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCed = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.pbFoto = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.lblMail = New System.Windows.Forms.Label()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCed
        '
        Me.lblCed.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCed.ForeColor = System.Drawing.Color.Silver
        Me.lblCed.Location = New System.Drawing.Point(107, 209)
        Me.lblCed.Name = "lblCed"
        Me.lblCed.Size = New System.Drawing.Size(121, 30)
        Me.lblCed.TabIndex = 0
        Me.lblCed.Text = "5.298.615-5"
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Silver
        Me.lblNom.Location = New System.Drawing.Point(10, 275)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(315, 71)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Franco Matias da SIlva Calleros "
        '
        'pbFoto
        '
        Me.pbFoto.BaseColor = System.Drawing.Color.White
        Me.pbFoto.Location = New System.Drawing.Point(107, 34)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(120, 120)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 2
        Me.pbFoto.TabStop = False
        Me.pbFoto.UseTransfarantBackground = False
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
        Me.btnAtras.Location = New System.Drawing.Point(3, 3)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(40, 37)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Silver
        Me.lblMail.Location = New System.Drawing.Point(50, 373)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(235, 38)
        Me.lblMail.TabIndex = 11
        Me.lblMail.Text = "dmdasdas@gmail.com"
        '
        'UCDatosGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCed)
        Me.Name = "UCDatosGestor"
        Me.Size = New System.Drawing.Size(335, 466)
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCed As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents pbFoto As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblMail As Label
End Class
