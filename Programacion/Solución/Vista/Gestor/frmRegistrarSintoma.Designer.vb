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
        Me.Panel1__ = New System.Windows.Forms.Panel()
        Me.Label1__ = New System.Windows.Forms.Label()
        Me.Panel9__ = New System.Windows.Forms.Panel()
        Me.TextBox1__ = New System.Windows.Forms.TextBox()
        Me.mrbtnRegistrarSintoma = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.txtNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New Guna.UI.WinForms.GunaTextBox()
        Me.sepDesc = New Guna.UI.WinForms.GunaSeparator()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
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
        'mrbtnRegistrarSintoma
        '
        Me.mrbtnRegistrarSintoma.AutoSize = True
        Me.mrbtnRegistrarSintoma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnRegistrarSintoma.Depth = 0
        Me.mrbtnRegistrarSintoma.Icon = Nothing
        Me.mrbtnRegistrarSintoma.Location = New System.Drawing.Point(488, 573)
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
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.lblNomPat)
        Me.pnlContenedor.Controls.Add(Me.txtNom)
        Me.pnlContenedor.Controls.Add(Me.lblDescripcion)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcion)
        Me.pnlContenedor.Controls.Add(Me.sepDesc)
        Me.pnlContenedor.Controls.Add(Me.mrbtnRegistrarSintoma)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 128
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(426, 117)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(184, 25)
        Me.lblNomPat.TabIndex = 187
        Me.lblNomPat.Text = "Nombre del síntoma"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtNom.LineSize = 1
        Me.txtNom.Location = New System.Drawing.Point(308, 166)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.Size = New System.Drawing.Size(413, 36)
        Me.txtNom.TabIndex = 185
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(499, 265)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(111, 25)
        Me.lblDescripcion.TabIndex = 188
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcion.BorderColor = System.Drawing.Color.Silver
        Me.txtDescripcion.BorderSize = 0
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcion.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(232, 307)
        Me.txtDescripcion.MaxLength = 300
        Me.txtDescripcion.MultiLine = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(654, 122)
        Me.txtDescripcion.TabIndex = 186
        '
        'sepDesc
        '
        Me.sepDesc.LineColor = System.Drawing.Color.Gainsboro
        Me.sepDesc.Location = New System.Drawing.Point(232, 435)
        Me.sepDesc.Name = "sepDesc"
        Me.sepDesc.Size = New System.Drawing.Size(654, 10)
        Me.sepDesc.TabIndex = 189
        '
        'frmRegistrarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1__ As Panel
    Friend WithEvents Label1__ As Label
    Friend WithEvents Panel9__ As Panel
    Friend WithEvents TextBox1__ As TextBox
    Friend WithEvents mrbtnRegistrarSintoma As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblNomPat As Label
    Friend WithEvents txtNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtDescripcion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sepDesc As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents lblDescripcion As Label
End Class
