<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCVerPerfil
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCVerPerfil))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New Guna.UI.WinForms.GunaButton()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnModificar = New FontAwesome.Sharp.IconPictureBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.pnlMedico = New System.Windows.Forms.Panel()
        Me.lblEspecializacion = New System.Windows.Forms.Label()
        Me.lblEspe = New System.Windows.Forms.Label()
        Me.pnlPaciente = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblEd = New System.Windows.Forms.Label()
        Me.lblPatologiasCronicas = New System.Windows.Forms.Label()
        Me.lblPatCron = New System.Windows.Forms.Label()
        Me.transicion = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.pnlCredenciales = New System.Windows.Forms.Panel()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRepPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.txtPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlYo = New System.Windows.Forms.Panel()
        Me.lblEspec = New System.Windows.Forms.Label()
        Me.txtEspe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.txtSApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.txtPApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.txtSNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.txtMail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTeles = New System.Windows.Forms.Label()
        Me.btnEliminar = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlMedYo = New System.Windows.Forms.Panel()
        Me.pnlMain.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMedico.SuspendLayout()
        Me.pnlPaciente.SuspendLayout()
        Me.pnlCredenciales.SuspendLayout()
        Me.pnlYo.SuspendLayout()
        Me.pnlContacto.SuspendLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMedYo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.btnRegistrar)
        Me.pnlMain.Controls.Add(Me.lblTel)
        Me.pnlMain.Controls.Add(Me.lblEmail)
        Me.pnlMain.Controls.Add(Me.lblNom)
        Me.pnlMain.Controls.Add(Me.GunaCirclePictureBox1)
        Me.pnlMain.Controls.Add(Me.btnModificar)
        Me.pnlMain.Controls.Add(Me.lblMail)
        Me.pnlMain.Controls.Add(Me.lblNombre)
        Me.pnlMain.Controls.Add(Me.lblTelefonos)
        Me.pnlMain.Controls.Add(Me.pnlMedico)
        Me.pnlMain.Controls.Add(Me.pnlPaciente)
        Me.transicion.SetDecoration(Me.pnlMain, Guna.UI.Animation.DecorationType.None)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(424, 648)
        Me.pnlMain.TabIndex = 36
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Animated = True
        Me.btnRegistrar.AnimationHoverSpeed = 0.07!
        Me.btnRegistrar.AnimationSpeed = 0.03!
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnRegistrar, Guna.UI.Animation.DecorationType.None)
        Me.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Image = Nothing
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrar.Location = New System.Drawing.Point(108, 579)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrar.OnHoverImage = Nothing
        Me.btnRegistrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrar.Radius = 10
        Me.btnRegistrar.Size = New System.Drawing.Size(199, 42)
        Me.btnRegistrar.TabIndex = 245
        Me.btnRegistrar.Text = "Aplicar cambios"
        Me.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRegistrar.Visible = False
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.transicion.SetDecoration(Me.lblTel, Guna.UI.Animation.DecorationType.None)
        Me.lblTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.Silver
        Me.lblTel.Location = New System.Drawing.Point(59, 395)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(0, 21)
        Me.lblTel.TabIndex = 31
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEmail, Guna.UI.Animation.DecorationType.None)
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(62, 300)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(68, 21)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Nombre"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNom, Guna.UI.Animation.DecorationType.None)
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Silver
        Me.lblNom.Location = New System.Drawing.Point(62, 206)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(68, 21)
        Me.lblNom.TabIndex = 29
        Me.lblNom.Text = "Nombre"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.transicion.SetDecoration(Me.GunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(160, 22)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 28
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnModificar, Guna.UI.Animation.DecorationType.None)
        Me.btnModificar.ForeColor = System.Drawing.Color.Silver
        Me.btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnModificar.IconColor = System.Drawing.Color.Silver
        Me.btnModificar.IconSize = 46
        Me.btnModificar.Location = New System.Drawing.Point(352, 33)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(53, 46)
        Me.btnModificar.TabIndex = 25
        Me.btnModificar.TabStop = False
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.transicion.SetDecoration(Me.lblMail, Guna.UI.Animation.DecorationType.None)
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(30, 250)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(148, 21)
        Me.lblMail.TabIndex = 2
        Me.lblMail.Text = "Correo electrónico"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNombre, Guna.UI.Animation.DecorationType.None)
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(30, 166)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 21)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.transicion.SetDecoration(Me.lblTelefonos, Guna.UI.Animation.DecorationType.None)
        Me.lblTelefonos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.White
        Me.lblTelefonos.Location = New System.Drawing.Point(27, 350)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(81, 21)
        Me.lblTelefonos.TabIndex = 3
        Me.lblTelefonos.Text = "Teléfonos"
        '
        'pnlMedico
        '
        Me.pnlMedico.Controls.Add(Me.lblEspecializacion)
        Me.pnlMedico.Controls.Add(Me.lblEspe)
        Me.transicion.SetDecoration(Me.pnlMedico, Guna.UI.Animation.DecorationType.None)
        Me.pnlMedico.Location = New System.Drawing.Point(31, 337)
        Me.pnlMedico.Name = "pnlMedico"
        Me.pnlMedico.Size = New System.Drawing.Size(366, 100)
        Me.pnlMedico.TabIndex = 34
        '
        'lblEspecializacion
        '
        Me.lblEspecializacion.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspecializacion, Guna.UI.Animation.DecorationType.None)
        Me.lblEspecializacion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecializacion.ForeColor = System.Drawing.Color.White
        Me.lblEspecializacion.Location = New System.Drawing.Point(3, 16)
        Me.lblEspecializacion.Name = "lblEspecializacion"
        Me.lblEspecializacion.Size = New System.Drawing.Size(118, 21)
        Me.lblEspecializacion.TabIndex = 4
        Me.lblEspecializacion.Text = "Especialización"
        '
        'lblEspe
        '
        Me.lblEspe.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspe, Guna.UI.Animation.DecorationType.None)
        Me.lblEspe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspe.ForeColor = System.Drawing.Color.Silver
        Me.lblEspe.Location = New System.Drawing.Point(28, 54)
        Me.lblEspe.Name = "lblEspe"
        Me.lblEspe.Size = New System.Drawing.Size(68, 21)
        Me.lblEspe.TabIndex = 32
        Me.lblEspe.Text = "Nombre"
        '
        'pnlPaciente
        '
        Me.pnlPaciente.Controls.Add(Me.Label3)
        Me.pnlPaciente.Controls.Add(Me.lblSex)
        Me.pnlPaciente.Controls.Add(Me.lblEdad)
        Me.pnlPaciente.Controls.Add(Me.lblEd)
        Me.pnlPaciente.Controls.Add(Me.lblPatologiasCronicas)
        Me.pnlPaciente.Controls.Add(Me.lblPatCron)
        Me.transicion.SetDecoration(Me.pnlPaciente, Guna.UI.Animation.DecorationType.None)
        Me.pnlPaciente.Location = New System.Drawing.Point(31, 451)
        Me.pnlPaciente.Name = "pnlPaciente"
        Me.pnlPaciente.Size = New System.Drawing.Size(369, 168)
        Me.pnlPaciente.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.transicion.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(230, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Sexo"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSex, Guna.UI.Animation.DecorationType.None)
        Me.lblSex.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Silver
        Me.lblSex.Location = New System.Drawing.Point(255, 142)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(68, 21)
        Me.lblSex.TabIndex = 36
        Me.lblSex.Text = "Nombre"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEdad, Guna.UI.Animation.DecorationType.None)
        Me.lblEdad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.White
        Me.lblEdad.Location = New System.Drawing.Point(6, 104)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(46, 21)
        Me.lblEdad.TabIndex = 33
        Me.lblEdad.Text = "Edad"
        '
        'lblEd
        '
        Me.lblEd.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEd, Guna.UI.Animation.DecorationType.None)
        Me.lblEd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEd.ForeColor = System.Drawing.Color.Silver
        Me.lblEd.Location = New System.Drawing.Point(31, 142)
        Me.lblEd.Name = "lblEd"
        Me.lblEd.Size = New System.Drawing.Size(68, 21)
        Me.lblEd.TabIndex = 34
        Me.lblEd.Text = "Nombre"
        '
        'lblPatologiasCronicas
        '
        Me.lblPatologiasCronicas.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPatologiasCronicas, Guna.UI.Animation.DecorationType.None)
        Me.lblPatologiasCronicas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologiasCronicas.ForeColor = System.Drawing.Color.White
        Me.lblPatologiasCronicas.Location = New System.Drawing.Point(3, 16)
        Me.lblPatologiasCronicas.Name = "lblPatologiasCronicas"
        Me.lblPatologiasCronicas.Size = New System.Drawing.Size(150, 21)
        Me.lblPatologiasCronicas.TabIndex = 4
        Me.lblPatologiasCronicas.Text = "Patologías crónicas"
        '
        'lblPatCron
        '
        Me.lblPatCron.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPatCron, Guna.UI.Animation.DecorationType.None)
        Me.lblPatCron.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatCron.ForeColor = System.Drawing.Color.Silver
        Me.lblPatCron.Location = New System.Drawing.Point(28, 54)
        Me.lblPatCron.Name = "lblPatCron"
        Me.lblPatCron.Size = New System.Drawing.Size(68, 21)
        Me.lblPatCron.TabIndex = 32
        Me.lblPatCron.Text = "Nombre"
        '
        'transicion
        '
        Me.transicion.AnimationType = Guna.UI.Animation.AnimationType.Leaf
        Me.transicion.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 1.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.transicion.DefaultAnimation = Animation3
        Me.transicion.Interval = 7
        Me.transicion.TimeStep = 0.05!
        '
        'pnlCredenciales
        '
        Me.pnlCredenciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlCredenciales.Controls.Add(Me.IconButton4)
        Me.pnlCredenciales.Controls.Add(Me.IconButton3)
        Me.pnlCredenciales.Controls.Add(Me.Label6)
        Me.pnlCredenciales.Controls.Add(Me.txtRepPass)
        Me.pnlCredenciales.Controls.Add(Me.lblCon)
        Me.pnlCredenciales.Controls.Add(Me.txtPass)
        Me.pnlCredenciales.Controls.Add(Me.Label5)
        Me.transicion.SetDecoration(Me.pnlCredenciales, Guna.UI.Animation.DecorationType.None)
        Me.pnlCredenciales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCredenciales.Location = New System.Drawing.Point(0, 0)
        Me.pnlCredenciales.Name = "pnlCredenciales"
        Me.pnlCredenciales.Size = New System.Drawing.Size(424, 648)
        Me.pnlCredenciales.TabIndex = 35
        '
        'IconButton4
        '
        Me.IconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton4, Guna.UI.Animation.DecorationType.None)
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.Silver
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton4.IconColor = System.Drawing.Color.Silver
        Me.IconButton4.IconSize = 20
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(22, 22)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(37, 37)
        Me.IconButton4.TabIndex = 246
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton3, Guna.UI.Animation.DecorationType.None)
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.Silver
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton3.IconColor = System.Drawing.Color.Silver
        Me.IconButton3.IconSize = 20
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.Location = New System.Drawing.Point(300, 22)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 180.0R
        Me.IconButton3.Size = New System.Drawing.Size(105, 37)
        Me.IconButton3.TabIndex = 245
        Me.IconButton3.Text = "Siguiente"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.transicion.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(40, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "Repetir contraseña"
        '
        'txtRepPass
        '
        Me.txtRepPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRepPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtRepPass, Guna.UI.Animation.DecorationType.None)
        Me.txtRepPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepPass.ForeColor = System.Drawing.Color.White
        Me.txtRepPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtRepPass.LineSize = 1
        Me.txtRepPass.Location = New System.Drawing.Point(44, 381)
        Me.txtRepPass.Name = "txtRepPass"
        Me.txtRepPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepPass.Size = New System.Drawing.Size(246, 32)
        Me.txtRepPass.TabIndex = 211
        Me.txtRepPass.UseSystemPasswordChar = True
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCon, Guna.UI.Animation.DecorationType.None)
        Me.lblCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.ForeColor = System.Drawing.Color.Silver
        Me.lblCon.Location = New System.Drawing.Point(40, 213)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(83, 20)
        Me.lblCon.TabIndex = 213
        Me.lblCon.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPass, Guna.UI.Animation.DecorationType.None)
        Me.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPass.LineSize = 1
        Me.txtPass.Location = New System.Drawing.Point(44, 242)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(246, 32)
        Me.txtPass.TabIndex = 210
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.transicion.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 32)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Credenciales"
        '
        'pnlYo
        '
        Me.pnlYo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlYo.Controls.Add(Me.pnlMedYo)
        Me.pnlYo.Controls.Add(Me.IconButton2)
        Me.pnlYo.Controls.Add(Me.IconButton1)
        Me.pnlYo.Controls.Add(Me.lblSApe)
        Me.pnlYo.Controls.Add(Me.txtSApe)
        Me.pnlYo.Controls.Add(Me.lblPApe)
        Me.pnlYo.Controls.Add(Me.txtPApe)
        Me.pnlYo.Controls.Add(Me.lblSNom)
        Me.pnlYo.Controls.Add(Me.txtSNom)
        Me.pnlYo.Controls.Add(Me.txtPNom)
        Me.pnlYo.Controls.Add(Me.lblPNom)
        Me.pnlYo.Controls.Add(Me.Label9)
        Me.transicion.SetDecoration(Me.pnlYo, Guna.UI.Animation.DecorationType.None)
        Me.pnlYo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlYo.Location = New System.Drawing.Point(0, 0)
        Me.pnlYo.Name = "pnlYo"
        Me.pnlYo.Size = New System.Drawing.Size(424, 648)
        Me.pnlYo.TabIndex = 232
        '
        'lblEspec
        '
        Me.lblEspec.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspec, Guna.UI.Animation.DecorationType.None)
        Me.lblEspec.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspec.ForeColor = System.Drawing.Color.Silver
        Me.lblEspec.Location = New System.Drawing.Point(8, 14)
        Me.lblEspec.Name = "lblEspec"
        Me.lblEspec.Size = New System.Drawing.Size(110, 20)
        Me.lblEspec.TabIndex = 246
        Me.lblEspec.Text = "Especialización"
        '
        'txtEspe
        '
        Me.txtEspe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEspe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtEspe, Guna.UI.Animation.DecorationType.None)
        Me.txtEspe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEspe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspe.ForeColor = System.Drawing.Color.White
        Me.txtEspe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEspe.LineSize = 1
        Me.txtEspe.Location = New System.Drawing.Point(8, 45)
        Me.txtEspe.Name = "txtEspe"
        Me.txtEspe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEspe.Size = New System.Drawing.Size(246, 32)
        Me.txtEspe.TabIndex = 245
        '
        'IconButton2
        '
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton2, Guna.UI.Animation.DecorationType.None)
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Silver
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton2.IconColor = System.Drawing.Color.Silver
        Me.IconButton2.IconSize = 20
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(300, 22)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 180.0R
        Me.IconButton2.Size = New System.Drawing.Size(105, 37)
        Me.IconButton2.TabIndex = 244
        Me.IconButton2.Text = "Siguiente"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton1, Guna.UI.Animation.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Silver
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton1.IconColor = System.Drawing.Color.Silver
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(22, 22)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(37, 37)
        Me.IconButton1.TabIndex = 243
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSApe, Guna.UI.Animation.DecorationType.None)
        Me.lblSApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApe.ForeColor = System.Drawing.Color.Silver
        Me.lblSApe.Location = New System.Drawing.Point(40, 472)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(127, 20)
        Me.lblSApe.TabIndex = 239
        Me.lblSApe.Text = "Segundo apellido"
        '
        'txtSApe
        '
        Me.txtSApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtSApe, Guna.UI.Animation.DecorationType.None)
        Me.txtSApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApe.ForeColor = System.Drawing.Color.White
        Me.txtSApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSApe.LineSize = 1
        Me.txtSApe.Location = New System.Drawing.Point(40, 503)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSApe.Size = New System.Drawing.Size(246, 32)
        Me.txtSApe.TabIndex = 238
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPApe, Guna.UI.Animation.DecorationType.None)
        Me.lblPApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApe.ForeColor = System.Drawing.Color.Silver
        Me.lblPApe.Location = New System.Drawing.Point(40, 374)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(111, 20)
        Me.lblPApe.TabIndex = 237
        Me.lblPApe.Text = "Primer apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPApe, Guna.UI.Animation.DecorationType.None)
        Me.txtPApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.White
        Me.txtPApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPApe.LineSize = 1
        Me.txtPApe.Location = New System.Drawing.Point(40, 406)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPApe.Size = New System.Drawing.Size(246, 32)
        Me.txtPApe.TabIndex = 236
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSNom, Guna.UI.Animation.DecorationType.None)
        Me.lblSNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNom.ForeColor = System.Drawing.Color.Silver
        Me.lblSNom.Location = New System.Drawing.Point(40, 262)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(124, 20)
        Me.lblSNom.TabIndex = 235
        Me.lblSNom.Text = "Segundo nombre"
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtSNom, Guna.UI.Animation.DecorationType.None)
        Me.txtSNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.ForeColor = System.Drawing.Color.White
        Me.txtSNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSNom.LineSize = 1
        Me.txtSNom.Location = New System.Drawing.Point(40, 289)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNom.Size = New System.Drawing.Size(246, 32)
        Me.txtSNom.TabIndex = 234
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPNom, Guna.UI.Animation.DecorationType.None)
        Me.txtPNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.White
        Me.txtPNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPNom.LineSize = 1
        Me.txtPNom.Location = New System.Drawing.Point(40, 189)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.Size = New System.Drawing.Size(246, 32)
        Me.txtPNom.TabIndex = 233
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPNom, Guna.UI.Animation.DecorationType.None)
        Me.lblPNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.ForeColor = System.Drawing.Color.Silver
        Me.lblPNom.Location = New System.Drawing.Point(40, 160)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(108, 20)
        Me.lblPNom.TabIndex = 232
        Me.lblPNom.Text = "Primer nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.transicion.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(28, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 32)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Mi información"
        '
        'pnlContacto
        '
        Me.pnlContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContacto.Controls.Add(Me.btnAtras)
        Me.pnlContacto.Controls.Add(Me.txtMail)
        Me.pnlContacto.Controls.Add(Me.Label7)
        Me.pnlContacto.Controls.Add(Me.lblTeles)
        Me.pnlContacto.Controls.Add(Me.btnEliminar)
        Me.pnlContacto.Controls.Add(Me.btnAceptar)
        Me.pnlContacto.Controls.Add(Me.dgvTelefonos)
        Me.pnlContacto.Controls.Add(Me.Label12)
        Me.transicion.SetDecoration(Me.pnlContacto, Guna.UI.Animation.DecorationType.None)
        Me.pnlContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContacto.Location = New System.Drawing.Point(0, 0)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(424, 648)
        Me.pnlContacto.TabIndex = 240
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnAtras, Guna.UI.Animation.DecorationType.None)
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
        Me.btnAtras.Size = New System.Drawing.Size(37, 37)
        Me.btnAtras.TabIndex = 242
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtMail, Guna.UI.Animation.DecorationType.None)
        Me.txtMail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.White
        Me.txtMail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMail.LineSize = 1
        Me.txtMail.Location = New System.Drawing.Point(38, 190)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.Size = New System.Drawing.Size(246, 32)
        Me.txtMail.TabIndex = 241
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.transicion.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(34, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 20)
        Me.Label7.TabIndex = 240
        Me.Label7.Text = "Correo electrónico"
        '
        'lblTeles
        '
        Me.lblTeles.AutoSize = True
        Me.transicion.SetDecoration(Me.lblTeles, Guna.UI.Animation.DecorationType.None)
        Me.lblTeles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeles.ForeColor = System.Drawing.Color.Silver
        Me.lblTeles.Location = New System.Drawing.Point(117, 284)
        Me.lblTeles.Name = "lblTeles"
        Me.lblTeles.Size = New System.Drawing.Size(73, 20)
        Me.lblTeles.TabIndex = 239
        Me.lblTeles.Text = "Teléfonos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Animated = True
        Me.btnEliminar.AnimationHoverSpeed = 0.07!
        Me.btnEliminar.AnimationSpeed = 0.03!
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEliminar.BorderColor = System.Drawing.Color.Black
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnEliminar, Guna.UI.Animation.DecorationType.None)
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Nothing
        Me.btnEliminar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminar.Location = New System.Drawing.Point(300, 315)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminar.OnHoverImage = Nothing
        Me.btnEliminar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminar.Radius = 10
        Me.btnEliminar.Size = New System.Drawing.Size(96, 42)
        Me.btnEliminar.TabIndex = 238
        Me.btnEliminar.Text = "Borrar"
        Me.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptar
        '
        Me.btnAceptar.Animated = True
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAceptar.BorderColor = System.Drawing.Color.Black
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnAceptar, Guna.UI.Animation.DecorationType.None)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Nothing
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(300, 384)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(96, 42)
        Me.btnAceptar.TabIndex = 237
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Silver
        Me.dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTelefonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.ColumnHeadersVisible = False
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefonos})
        Me.transicion.SetDecoration(Me.dgvTelefonos, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTelefonos.Location = New System.Drawing.Point(43, 315)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(237, 111)
        Me.dgvTelefonos.TabIndex = 236
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.transicion.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(28, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 32)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Contacto"
        '
        'pnlMedYo
        '
        Me.pnlMedYo.Controls.Add(Me.lblEspec)
        Me.pnlMedYo.Controls.Add(Me.txtEspe)
        Me.transicion.SetDecoration(Me.pnlMedYo, Guna.UI.Animation.DecorationType.None)
        Me.pnlMedYo.Location = New System.Drawing.Point(34, 541)
        Me.pnlMedYo.Name = "pnlMedYo"
        Me.pnlMedYo.Size = New System.Drawing.Size(260, 88)
        Me.pnlMedYo.TabIndex = 247
        '
        'UCVerPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnlYo)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlCredenciales)
        Me.Controls.Add(Me.pnlContacto)
        Me.transicion.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Name = "UCVerPerfil"
        Me.Size = New System.Drawing.Size(424, 648)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMedico.ResumeLayout(False)
        Me.pnlMedico.PerformLayout()
        Me.pnlPaciente.ResumeLayout(False)
        Me.pnlPaciente.PerformLayout()
        Me.pnlCredenciales.ResumeLayout(False)
        Me.pnlCredenciales.PerformLayout()
        Me.pnlYo.ResumeLayout(False)
        Me.pnlYo.PerformLayout()
        Me.pnlContacto.ResumeLayout(False)
        Me.pnlContacto.PerformLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMedYo.ResumeLayout(False)
        Me.pnlMedYo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblMail As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents pnlMedico As Panel
    Friend WithEvents lblEspecializacion As Label
    Friend WithEvents lblEspe As Label
    Friend WithEvents pnlPaciente As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblEd As Label
    Friend WithEvents lblPatologiasCronicas As Label
    Friend WithEvents lblPatCron As Label
    Friend WithEvents transicion As Guna.UI.WinForms.GunaTransition
    Friend WithEvents pnlCredenciales As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRepPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCon As Label
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pnlYo As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSApe As Label
    Friend WithEvents txtSApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPApe As Label
    Friend WithEvents txtPApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblSNom As Label
    Friend WithEvents txtSNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPNom As Label
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEliminar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents lblTeles As Label
    Friend WithEvents txtMail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblEspec As Label
    Friend WithEvents txtEspe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pnlMedYo As Panel
End Class
