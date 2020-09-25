<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarSintoma
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
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblRegistrarSintoma = New System.Windows.Forms.Label()
        Me.Panel1__ = New System.Windows.Forms.Panel()
        Me.Label1__ = New System.Windows.Forms.Label()
        Me.Panel9__ = New System.Windows.Forms.Panel()
        Me.TextBox1__ = New System.Windows.Forms.TextBox()
        Me.pnlTxtDescripcion = New System.Windows.Forms.Panel()
        Me.lblNomSintoma = New System.Windows.Forms.Label()
        Me.pnlTxtNomSintoma = New System.Windows.Forms.Panel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNomSintoma = New System.Windows.Forms.TextBox()
        Me.mrbtnRegistrarSintoma = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.panelTitulo.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.btnAtras)
        Me.panelTitulo.Controls.Add(Me.lblRegistrarSintoma)
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(701, 77)
        Me.panelTitulo.TabIndex = 92
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icoFlechaAtrasWhite
        Me.btnAtras.Location = New System.Drawing.Point(37, 27)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 30
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblRegistrarSintoma
        '
        Me.lblRegistrarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegistrarSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrarSintoma.ForeColor = System.Drawing.Color.White
        Me.lblRegistrarSintoma.Location = New System.Drawing.Point(186, 16)
        Me.lblRegistrarSintoma.Name = "lblRegistrarSintoma"
        Me.lblRegistrarSintoma.Size = New System.Drawing.Size(341, 45)
        Me.lblRegistrarSintoma.TabIndex = 27
        Me.lblRegistrarSintoma.Text = "REGISTRAR SÍNTOMA"
        Me.lblRegistrarSintoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1__
        '
        Me.Panel1__.Location = New System.Drawing.Point(0, 0)
        Me.Panel1__.Name = "Panel1__"
        Me.Panel1__.Size = New System.Drawing.Size(200, 100)
        Me.Panel1__.TabIndex = 0
        '
        'Label1__
        '
        Me.Label1__.Location = New System.Drawing.Point(0, 0)
        Me.Label1__.Name = "Label1__"
        Me.Label1__.Size = New System.Drawing.Size(100, 23)
        Me.Label1__.TabIndex = 0
        '
        'Panel9__
        '
        Me.Panel9__.Location = New System.Drawing.Point(0, 0)
        Me.Panel9__.Name = "Panel9__"
        Me.Panel9__.Size = New System.Drawing.Size(200, 100)
        Me.Panel9__.TabIndex = 0
        '
        'TextBox1__
        '
        Me.TextBox1__.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1__.Name = "TextBox1__"
        Me.TextBox1__.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1__.TabIndex = 0
        '
        'pnlTxtDescripcion
        '
        Me.pnlTxtDescripcion.BackColor = System.Drawing.Color.Black
        Me.pnlTxtDescripcion.Location = New System.Drawing.Point(128, 357)
        Me.pnlTxtDescripcion.Name = "pnlTxtDescripcion"
        Me.pnlTxtDescripcion.Size = New System.Drawing.Size(459, 2)
        Me.pnlTxtDescripcion.TabIndex = 114
        '
        'lblNomSintoma
        '
        Me.lblNomSintoma.AutoSize = True
        Me.lblNomSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomSintoma.Location = New System.Drawing.Point(260, 133)
        Me.lblNomSintoma.Name = "lblNomSintoma"
        Me.lblNomSintoma.Size = New System.Drawing.Size(203, 25)
        Me.lblNomSintoma.TabIndex = 110
        Me.lblNomSintoma.Text = "Nombre del sintoma"
        '
        'pnlTxtNomSintoma
        '
        Me.pnlTxtNomSintoma.BackColor = System.Drawing.Color.Black
        Me.pnlTxtNomSintoma.Location = New System.Drawing.Point(274, 200)
        Me.pnlTxtNomSintoma.Name = "pnlTxtNomSintoma"
        Me.pnlTxtNomSintoma.Size = New System.Drawing.Size(176, 2)
        Me.pnlTxtNomSintoma.TabIndex = 111
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 259)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(459, 92)
        Me.txtDescripcion.TabIndex = 113
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(113, 230)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(125, 25)
        Me.lblDescripcion.TabIndex = 112
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtNomSintoma
        '
        Me.txtNomSintoma.BackColor = System.Drawing.Color.White
        Me.txtNomSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomSintoma.Location = New System.Drawing.Point(274, 171)
        Me.txtNomSintoma.Name = "txtNomSintoma"
        Me.txtNomSintoma.Size = New System.Drawing.Size(176, 22)
        Me.txtNomSintoma.TabIndex = 115
        '
        'mrbtnRegistrarSintoma
        '
        Me.mrbtnRegistrarSintoma.AutoSize = True
        Me.mrbtnRegistrarSintoma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnRegistrarSintoma.Depth = 0
        Me.mrbtnRegistrarSintoma.Icon = Nothing
        Me.mrbtnRegistrarSintoma.Location = New System.Drawing.Point(274, 421)
        Me.mrbtnRegistrarSintoma.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnRegistrarSintoma.Name = "mrbtnRegistrarSintoma"
        Me.mrbtnRegistrarSintoma.Primary = True
        Me.mrbtnRegistrarSintoma.Size = New System.Drawing.Size(158, 36)
        Me.mrbtnRegistrarSintoma.TabIndex = 127
        Me.mrbtnRegistrarSintoma.Text = "Registrar síntoma"
        Me.mrbtnRegistrarSintoma.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.panelTitulo)
        Me.pnlContenedor.Controls.Add(Me.lblNomSintoma)
        Me.pnlContenedor.Controls.Add(Me.txtNomSintoma)
        Me.pnlContenedor.Controls.Add(Me.pnlTxtNomSintoma)
        Me.pnlContenedor.Controls.Add(Me.lblDescripcion)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcion)
        Me.pnlContenedor.Controls.Add(Me.pnlTxtDescripcion)
        Me.pnlContenedor.Controls.Add(Me.mrbtnRegistrarSintoma)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(700, 499)
        Me.pnlContenedor.TabIndex = 128
        '
        'frmRegistrarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 499)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTitulo.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As Panel
    Friend WithEvents Panel1__ As Panel
    Friend WithEvents Label1__ As Label
    Friend WithEvents Panel9__ As Panel
    Friend WithEvents TextBox1__ As TextBox
    Friend WithEvents pnlTxtDescripcion As Panel
    Friend WithEvents lblNomSintoma As Label
    Friend WithEvents pnlTxtNomSintoma As Panel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNomSintoma As TextBox
    Friend WithEvents mrbtnRegistrarSintoma As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblRegistrarSintoma As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents pnlContenedor As Panel
End Class
