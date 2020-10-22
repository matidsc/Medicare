<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCDatosGestor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDatosGestor))
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
        resources.ApplyResources(Me.lblCed, "lblCed")
        Me.lblCed.ForeColor = System.Drawing.Color.Silver
        Me.lblCed.Name = "lblCed"
        '
        'lblNom
        '
        resources.ApplyResources(Me.lblNom, "lblNom")
        Me.lblNom.ForeColor = System.Drawing.Color.Silver
        Me.lblNom.Name = "lblNom"
        '
        'pbFoto
        '
        Me.pbFoto.BaseColor = System.Drawing.Color.White
        resources.ApplyResources(Me.pbFoto, "pbFoto")
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.TabStop = False
        Me.pbFoto.UseTransfarantBackground = False
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnAtras, "btnAtras")
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblMail
        '
        resources.ApplyResources(Me.lblMail, "lblMail")
        Me.lblMail.ForeColor = System.Drawing.Color.Silver
        Me.lblMail.Name = "lblMail"
        '
        'UCDatosGestor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCed)
        Me.Name = "UCDatosGestor"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCed As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents pbFoto As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblMail As Label
End Class
