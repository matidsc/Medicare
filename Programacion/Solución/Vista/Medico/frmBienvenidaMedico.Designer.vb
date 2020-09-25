<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaMedico
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
        Me.pnlChat = New System.Windows.Forms.Panel()
        Me.pnlDeChat = New System.Windows.Forms.Panel()
        Me.lblDesChat = New System.Windows.Forms.Label()
        Me.lblChat = New System.Windows.Forms.Label()
        Me.pnlMiHistorial = New System.Windows.Forms.Panel()
        Me.pnlDecMiHistorial = New System.Windows.Forms.Panel()
        Me.lblDescMiHistorial = New System.Windows.Forms.Label()
        Me.lblMiHistorial = New System.Windows.Forms.Label()
        Me.pnlAjustes = New System.Windows.Forms.Panel()
        Me.lblAjustes = New System.Windows.Forms.Label()
        Me.pnlDecAjustes = New System.Windows.Forms.Panel()
        Me.lblDescAjustes = New System.Windows.Forms.Label()
        Me.pnlMiPerfil = New System.Windows.Forms.Panel()
        Me.pnlDecMiPerfil = New System.Windows.Forms.Panel()
        Me.lblDescMiPerfil = New System.Windows.Forms.Label()
        Me.lblMiPerfil = New System.Windows.Forms.Label()
        Me.pnlAyuda = New System.Windows.Forms.Panel()
        Me.pnlDecAyuda = New System.Windows.Forms.Panel()
        Me.lblDescAyuda = New System.Windows.Forms.Label()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.pnlPatologias = New System.Windows.Forms.Panel()
        Me.pnlDecPatologias = New System.Windows.Forms.Panel()
        Me.lblDescPatologias = New System.Windows.Forms.Label()
        Me.lblPatologias = New System.Windows.Forms.Label()
        Me.temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlChat.SuspendLayout()
        Me.pnlMiHistorial.SuspendLayout()
        Me.pnlAjustes.SuspendLayout()
        Me.pnlMiPerfil.SuspendLayout()
        Me.pnlAyuda.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlPatologias.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlChat
        '
        Me.pnlChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlChat.Controls.Add(Me.pnlDeChat)
        Me.pnlChat.Controls.Add(Me.lblDesChat)
        Me.pnlChat.Controls.Add(Me.lblChat)
        Me.pnlChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlChat.Location = New System.Drawing.Point(36, 120)
        Me.pnlChat.Name = "pnlChat"
        Me.pnlChat.Size = New System.Drawing.Size(485, 146)
        Me.pnlChat.TabIndex = 0
        '
        'pnlDeChat
        '
        Me.pnlDeChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlDeChat.Location = New System.Drawing.Point(0, 0)
        Me.pnlDeChat.Name = "pnlDeChat"
        Me.pnlDeChat.Size = New System.Drawing.Size(529, 10)
        Me.pnlDeChat.TabIndex = 2
        '
        'lblDesChat
        '
        Me.lblDesChat.AutoSize = True
        Me.lblDesChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDesChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesChat.ForeColor = System.Drawing.Color.White
        Me.lblDesChat.Location = New System.Drawing.Point(25, 85)
        Me.lblDesChat.Name = "lblDesChat"
        Me.lblDesChat.Size = New System.Drawing.Size(398, 24)
        Me.lblDesChat.TabIndex = 1
        Me.lblDesChat.Text = "Ver lista de chats que tiene con sus pacientes "
        '
        'lblChat
        '
        Me.lblChat.AutoSize = True
        Me.lblChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChat.ForeColor = System.Drawing.Color.White
        Me.lblChat.Location = New System.Drawing.Point(22, 27)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(85, 37)
        Me.lblChat.TabIndex = 0
        Me.lblChat.Text = "Chat"
        '
        'pnlMiHistorial
        '
        Me.pnlMiHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMiHistorial.Controls.Add(Me.pnlDecMiHistorial)
        Me.pnlMiHistorial.Controls.Add(Me.lblDescMiHistorial)
        Me.pnlMiHistorial.Controls.Add(Me.lblMiHistorial)
        Me.pnlMiHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlMiHistorial.Location = New System.Drawing.Point(36, 289)
        Me.pnlMiHistorial.Name = "pnlMiHistorial"
        Me.pnlMiHistorial.Size = New System.Drawing.Size(224, 193)
        Me.pnlMiHistorial.TabIndex = 2
        '
        'pnlDecMiHistorial
        '
        Me.pnlDecMiHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pnlDecMiHistorial.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecMiHistorial.Name = "pnlDecMiHistorial"
        Me.pnlDecMiHistorial.Size = New System.Drawing.Size(255, 10)
        Me.pnlDecMiHistorial.TabIndex = 4
        '
        'lblDescMiHistorial
        '
        Me.lblDescMiHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescMiHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMiHistorial.ForeColor = System.Drawing.Color.White
        Me.lblDescMiHistorial.Location = New System.Drawing.Point(25, 91)
        Me.lblDescMiHistorial.Name = "lblDescMiHistorial"
        Me.lblDescMiHistorial.Size = New System.Drawing.Size(178, 92)
        Me.lblDescMiHistorial.TabIndex = 1
        Me.lblDescMiHistorial.Text = "Vea su historial completo dentro de la aplicación"
        '
        'lblMiHistorial
        '
        Me.lblMiHistorial.AutoSize = True
        Me.lblMiHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiHistorial.ForeColor = System.Drawing.Color.White
        Me.lblMiHistorial.Location = New System.Drawing.Point(22, 33)
        Me.lblMiHistorial.Name = "lblMiHistorial"
        Me.lblMiHistorial.Size = New System.Drawing.Size(175, 37)
        Me.lblMiHistorial.TabIndex = 0
        Me.lblMiHistorial.Text = "Mi Historial"
        '
        'pnlAjustes
        '
        Me.pnlAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAjustes.Controls.Add(Me.lblAjustes)
        Me.pnlAjustes.Controls.Add(Me.pnlDecAjustes)
        Me.pnlAjustes.Controls.Add(Me.lblDescAjustes)
        Me.pnlAjustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAjustes.Location = New System.Drawing.Point(282, 289)
        Me.pnlAjustes.Name = "pnlAjustes"
        Me.pnlAjustes.Size = New System.Drawing.Size(239, 193)
        Me.pnlAjustes.TabIndex = 3
        '
        'lblAjustes
        '
        Me.lblAjustes.AutoSize = True
        Me.lblAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjustes.ForeColor = System.Drawing.Color.White
        Me.lblAjustes.Location = New System.Drawing.Point(22, 33)
        Me.lblAjustes.Name = "lblAjustes"
        Me.lblAjustes.Size = New System.Drawing.Size(122, 37)
        Me.lblAjustes.TabIndex = 0
        Me.lblAjustes.Text = "Ajustes"
        '
        'pnlDecAjustes
        '
        Me.pnlDecAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.pnlDecAjustes.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecAjustes.Name = "pnlDecAjustes"
        Me.pnlDecAjustes.Size = New System.Drawing.Size(255, 10)
        Me.pnlDecAjustes.TabIndex = 5
        '
        'lblDescAjustes
        '
        Me.lblDescAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescAjustes.ForeColor = System.Drawing.Color.White
        Me.lblDescAjustes.Location = New System.Drawing.Point(25, 91)
        Me.lblDescAjustes.Name = "lblDescAjustes"
        Me.lblDescAjustes.Size = New System.Drawing.Size(178, 92)
        Me.lblDescAjustes.TabIndex = 1
        Me.lblDescAjustes.Text = "Entrar a la configuración de la aplicación"
        '
        'pnlMiPerfil
        '
        Me.pnlMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMiPerfil.Controls.Add(Me.pnlDecMiPerfil)
        Me.pnlMiPerfil.Controls.Add(Me.lblDescMiPerfil)
        Me.pnlMiPerfil.Controls.Add(Me.lblMiPerfil)
        Me.pnlMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlMiPerfil.Location = New System.Drawing.Point(538, 289)
        Me.pnlMiPerfil.Name = "pnlMiPerfil"
        Me.pnlMiPerfil.Size = New System.Drawing.Size(162, 193)
        Me.pnlMiPerfil.TabIndex = 4
        '
        'pnlDecMiPerfil
        '
        Me.pnlDecMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.pnlDecMiPerfil.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecMiPerfil.Name = "pnlDecMiPerfil"
        Me.pnlDecMiPerfil.Size = New System.Drawing.Size(162, 10)
        Me.pnlDecMiPerfil.TabIndex = 6
        '
        'lblDescMiPerfil
        '
        Me.lblDescMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMiPerfil.ForeColor = System.Drawing.Color.White
        Me.lblDescMiPerfil.Location = New System.Drawing.Point(18, 91)
        Me.lblDescMiPerfil.Name = "lblDescMiPerfil"
        Me.lblDescMiPerfil.Size = New System.Drawing.Size(125, 92)
        Me.lblDescMiPerfil.TabIndex = 1
        Me.lblDescMiPerfil.Text = "Ver y configurar Perfil"
        '
        'lblMiPerfil
        '
        Me.lblMiPerfil.AutoSize = True
        Me.lblMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiPerfil.ForeColor = System.Drawing.Color.White
        Me.lblMiPerfil.Location = New System.Drawing.Point(3, 33)
        Me.lblMiPerfil.Name = "lblMiPerfil"
        Me.lblMiPerfil.Size = New System.Drawing.Size(131, 37)
        Me.lblMiPerfil.TabIndex = 0
        Me.lblMiPerfil.Text = "Mi Perfil"
        '
        'pnlAyuda
        '
        Me.pnlAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAyuda.Controls.Add(Me.pnlDecAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblDescAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblAyuda)
        Me.pnlAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAyuda.Location = New System.Drawing.Point(718, 289)
        Me.pnlAyuda.Name = "pnlAyuda"
        Me.pnlAyuda.Size = New System.Drawing.Size(162, 193)
        Me.pnlAyuda.TabIndex = 5
        '
        'pnlDecAyuda
        '
        Me.pnlDecAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlDecAyuda.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecAyuda.Name = "pnlDecAyuda"
        Me.pnlDecAyuda.Size = New System.Drawing.Size(162, 10)
        Me.pnlDecAyuda.TabIndex = 3
        '
        'lblDescAyuda
        '
        Me.lblDescAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescAyuda.ForeColor = System.Drawing.Color.White
        Me.lblDescAyuda.Location = New System.Drawing.Point(14, 80)
        Me.lblDescAyuda.Name = "lblDescAyuda"
        Me.lblDescAyuda.Size = New System.Drawing.Size(137, 53)
        Me.lblDescAyuda.TabIndex = 1
        Me.lblDescAyuda.Text = "Cómo usar la aplicación"
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.White
        Me.lblAyuda.Location = New System.Drawing.Point(11, 27)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(108, 37)
        Me.lblAyuda.TabIndex = 0
        Me.lblAyuda.Text = "Ayuda"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Controls.Add(Me.btn1)
        Me.pnlTitulo.Controls.Add(Me.btn2)
        Me.pnlTitulo.Location = New System.Drawing.Point(10, 6)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(780, 80)
        Me.pnlTitulo.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(59, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(226, 29)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Bienvenido, Médico"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(591, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(70, 55)
        Me.btn1.TabIndex = 23
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(504, 12)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(70, 55)
        Me.btn2.TabIndex = 24
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'pnlPatologias
        '
        Me.pnlPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlPatologias.Controls.Add(Me.pnlDecPatologias)
        Me.pnlPatologias.Controls.Add(Me.lblDescPatologias)
        Me.pnlPatologias.Controls.Add(Me.lblPatologias)
        Me.pnlPatologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPatologias.Location = New System.Drawing.Point(538, 120)
        Me.pnlPatologias.Name = "pnlPatologias"
        Me.pnlPatologias.Size = New System.Drawing.Size(342, 146)
        Me.pnlPatologias.TabIndex = 6
        '
        'pnlDecPatologias
        '
        Me.pnlDecPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlDecPatologias.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecPatologias.Name = "pnlDecPatologias"
        Me.pnlDecPatologias.Size = New System.Drawing.Size(342, 10)
        Me.pnlDecPatologias.TabIndex = 3
        '
        'lblDescPatologias
        '
        Me.lblDescPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescPatologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPatologias.ForeColor = System.Drawing.Color.White
        Me.lblDescPatologias.Location = New System.Drawing.Point(14, 80)
        Me.lblDescPatologias.Name = "lblDescPatologias"
        Me.lblDescPatologias.Size = New System.Drawing.Size(295, 53)
        Me.lblDescPatologias.TabIndex = 1
        Me.lblDescPatologias.Text = "Busque patologías registradas en la aplicación"
        '
        'lblPatologias
        '
        Me.lblPatologias.AutoSize = True
        Me.lblPatologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologias.ForeColor = System.Drawing.Color.White
        Me.lblPatologias.Location = New System.Drawing.Point(11, 27)
        Me.lblPatologias.Name = "lblPatologias"
        Me.lblPatologias.Size = New System.Drawing.Size(167, 37)
        Me.lblPatologias.TabIndex = 0
        Me.lblPatologias.Text = "Patologías"
        '
        'temporizador
        '
        Me.temporizador.Enabled = True
        Me.temporizador.Interval = 4000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlTitulo)
        Me.pnlContenedor.Controls.Add(Me.pnlChat)
        Me.pnlContenedor.Controls.Add(Me.pnlPatologias)
        Me.pnlContenedor.Controls.Add(Me.pnlMiHistorial)
        Me.pnlContenedor.Controls.Add(Me.pnlAjustes)
        Me.pnlContenedor.Controls.Add(Me.pnlMiPerfil)
        Me.pnlContenedor.Controls.Add(Me.pnlAyuda)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(915, 530)
        Me.pnlContenedor.TabIndex = 23
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(915, 530)
        Me.pnlInstancia.TabIndex = 7
        '
        'frmBienvenidaMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 530)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlChat.ResumeLayout(False)
        Me.pnlChat.PerformLayout()
        Me.pnlMiHistorial.ResumeLayout(False)
        Me.pnlMiHistorial.PerformLayout()
        Me.pnlAjustes.ResumeLayout(False)
        Me.pnlAjustes.PerformLayout()
        Me.pnlMiPerfil.ResumeLayout(False)
        Me.pnlMiPerfil.PerformLayout()
        Me.pnlAyuda.ResumeLayout(False)
        Me.pnlAyuda.PerformLayout()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlPatologias.ResumeLayout(False)
        Me.pnlPatologias.PerformLayout()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlChat As Panel
    Friend WithEvents lblDesChat As Label
    Friend WithEvents lblChat As Label
    Friend WithEvents pnlMiHistorial As Panel
    Friend WithEvents lblDescMiHistorial As Label
    Friend WithEvents lblMiHistorial As Label
    Friend WithEvents pnlAjustes As Panel
    Friend WithEvents lblDescAjustes As Label
    Friend WithEvents lblAjustes As Label
    Friend WithEvents pnlMiPerfil As Panel
    Friend WithEvents lblMiPerfil As Label
    Friend WithEvents pnlAyuda As Panel
    Friend WithEvents lblDescAyuda As Label
    Friend WithEvents lblAyuda As Label
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pnlDeChat As Panel
    Friend WithEvents pnlDecAyuda As Panel
    Friend WithEvents pnlDecMiHistorial As Panel
    Friend WithEvents pnlDecAjustes As Panel
    Friend WithEvents pnlDecMiPerfil As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lblDescMiPerfil As Label
    Friend WithEvents pnlPatologias As Panel
    Friend WithEvents pnlDecPatologias As Panel
    Friend WithEvents lblDescPatologias As Label
    Friend WithEvents lblPatologias As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents temporizador As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
End Class

