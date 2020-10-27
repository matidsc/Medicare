<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaPaciente))
        Me.notificacion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlNotis = New System.Windows.Forms.Panel()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.btnNo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSi = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.pnlNoti = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNoti = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIngresar = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHistorial = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnReanudar = New Guna.UI.WinForms.GunaButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.pnlNotis.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'notificacion
        '
        Me.notificacion.AutoSize = True
        Me.notificacion.ForeColor = System.Drawing.SystemColors.Control
        Me.notificacion.Location = New System.Drawing.Point(105, 103)
        Me.notificacion.Name = "notificacion"
        Me.notificacion.Size = New System.Drawing.Size(61, 13)
        Me.notificacion.TabIndex = 10
        Me.notificacion.Text = "notificacion"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlNotis)
        Me.pnlContenedor.Controls.Add(Me.Label9)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Controls.Add(Me.notificacion)
        Me.pnlContenedor.Controls.Add(Me.Panel10)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 7
        '
        'pnlNotis
        '
        Me.pnlNotis.Controls.Add(Me.lblNA)
        Me.pnlNotis.Controls.Add(Me.btnNo)
        Me.pnlNotis.Controls.Add(Me.btnSi)
        Me.pnlNotis.Controls.Add(Me.Label8)
        Me.pnlNotis.Controls.Add(Me.Label7)
        Me.pnlNotis.Location = New System.Drawing.Point(615, 82)
        Me.pnlNotis.Name = "pnlNotis"
        Me.pnlNotis.Size = New System.Drawing.Size(345, 232)
        Me.pnlNotis.TabIndex = 28
        Me.pnlNotis.Visible = False
        '
        'lblNA
        '
        Me.lblNA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.Color.Silver
        Me.lblNA.Location = New System.Drawing.Point(18, 21)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(309, 197)
        Me.lblNA.TabIndex = 12
        Me.lblNA.Text = "No hay respuestas"
        Me.lblNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNA.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Animated = True
        Me.btnNo.AnimationHoverSpeed = 0.07!
        Me.btnNo.AnimationSpeed = 0.03!
        Me.btnNo.BackColor = System.Drawing.Color.Transparent
        Me.btnNo.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnNo.BorderColor = System.Drawing.Color.Black
        Me.btnNo.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNo.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNo.CheckedForeColor = System.Drawing.Color.White
        Me.btnNo.CheckedImage = CType(resources.GetObject("btnNo.CheckedImage"), System.Drawing.Image)
        Me.btnNo.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNo.FocusedColor = System.Drawing.Color.Empty
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Image = Nothing
        Me.btnNo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNo.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNo.Location = New System.Drawing.Point(184, 166)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnNo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNo.OnHoverImage = Nothing
        Me.btnNo.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNo.OnPressedColor = System.Drawing.Color.Black
        Me.btnNo.Radius = 15
        Me.btnNo.Size = New System.Drawing.Size(125, 32)
        Me.btnNo.TabIndex = 11
        Me.btnNo.Text = "No"
        Me.btnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSi
        '
        Me.btnSi.Animated = True
        Me.btnSi.AnimationHoverSpeed = 0.07!
        Me.btnSi.AnimationSpeed = 0.03!
        Me.btnSi.BackColor = System.Drawing.Color.Transparent
        Me.btnSi.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSi.BorderColor = System.Drawing.Color.Black
        Me.btnSi.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSi.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSi.CheckedForeColor = System.Drawing.Color.White
        Me.btnSi.CheckedImage = CType(resources.GetObject("btnSi.CheckedImage"), System.Drawing.Image)
        Me.btnSi.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSi.FocusedColor = System.Drawing.Color.Empty
        Me.btnSi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.White
        Me.btnSi.Image = Nothing
        Me.btnSi.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSi.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSi.Location = New System.Drawing.Point(39, 165)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSi.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSi.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSi.OnHoverImage = Nothing
        Me.btnSi.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSi.OnPressedColor = System.Drawing.Color.Black
        Me.btnSi.Radius = 15
        Me.btnSi.Size = New System.Drawing.Size(125, 32)
        Me.btnSi.TabIndex = 10
        Me.btnSi.Text = "Sí"
        Me.btnSi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(24, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 46)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "¿Desea Iniciar la conversación?"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(19, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 89)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ha recibido una respuesta del médico"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(410, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 32)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Buenas tardes, Rodrigo"
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.pnlNoti)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 26
        '
        'pnlNoti
        '
        Me.pnlNoti.BackColor = System.Drawing.Color.Transparent
        Me.pnlNoti.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.pnlNoti.Location = New System.Drawing.Point(780, 29)
        Me.pnlNoti.Name = "pnlNoti"
        Me.pnlNoti.Radius = 5
        Me.pnlNoti.Size = New System.Drawing.Size(10, 10)
        Me.pnlNoti.TabIndex = 9
        Me.pnlNoti.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnNoti
        '
        Me.btnNoti.BackColor = System.Drawing.Color.Transparent
        Me.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoti.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNoti.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.btnNoti.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnNoti.Location = New System.Drawing.Point(758, 27)
        Me.btnNoti.Name = "btnNoti"
        Me.btnNoti.Size = New System.Drawing.Size(32, 32)
        Me.btnNoti.TabIndex = 4
        Me.btnNoti.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.BackgroundImage = CType(resources.GetObject("IconButton1.BackgroundImage"), System.Drawing.Image)
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.CaretDown
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconSize = 16
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(857, 27)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(86, 32)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.Location = New System.Drawing.Point(809, 27)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Location = New System.Drawing.Point(55, 247)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(965, 336)
        Me.Panel10.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(287, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 276)
        Me.Panel1.TabIndex = 0
        '
        'btnIngresar
        '
        Me.btnIngresar.AnimationHoverSpeed = 0.07!
        Me.btnIngresar.AnimationSpeed = 0.03!
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnIngresar.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresar.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Image = Nothing
        Me.btnIngresar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnIngresar.Location = New System.Drawing.Point(85, 208)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresar.OnHoverImage = Nothing
        Me.btnIngresar.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresar.Radius = 12
        Me.btnIngresar.Size = New System.Drawing.Size(213, 32)
        Me.btnIngresar.TabIndex = 199
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 266)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 10)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(70, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 73)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dígamos cuáles son sus síntomas y le daremos un diagnóstico primario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingresar síntomas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnHistorial)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(52, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 248)
        Me.Panel3.TabIndex = 5
        '
        'btnHistorial
        '
        Me.btnHistorial.AnimationHoverSpeed = 0.07!
        Me.btnHistorial.AnimationSpeed = 0.03!
        Me.btnHistorial.BackColor = System.Drawing.Color.Transparent
        Me.btnHistorial.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnHistorial.BorderColor = System.Drawing.Color.Black
        Me.btnHistorial.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHistorial.FocusedColor = System.Drawing.Color.Empty
        Me.btnHistorial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.White
        Me.btnHistorial.Image = Nothing
        Me.btnHistorial.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnHistorial.Location = New System.Drawing.Point(31, 181)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnHistorial.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHistorial.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHistorial.OnHoverImage = Nothing
        Me.btnHistorial.OnPressedColor = System.Drawing.Color.Black
        Me.btnHistorial.Radius = 12
        Me.btnHistorial.Size = New System.Drawing.Size(128, 32)
        Me.btnHistorial.TabIndex = 198
        Me.btnHistorial.Text = "Ingresar"
        Me.btnHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 7)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 59)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vea su historial completo dentro de la aplicación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mi historial"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnReanudar)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(740, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 248)
        Me.Panel5.TabIndex = 6
        '
        'btnReanudar
        '
        Me.btnReanudar.AnimationHoverSpeed = 0.07!
        Me.btnReanudar.AnimationSpeed = 0.03!
        Me.btnReanudar.BackColor = System.Drawing.Color.Transparent
        Me.btnReanudar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReanudar.BorderColor = System.Drawing.Color.Black
        Me.btnReanudar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReanudar.FocusedColor = System.Drawing.Color.Empty
        Me.btnReanudar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReanudar.ForeColor = System.Drawing.Color.White
        Me.btnReanudar.Image = Nothing
        Me.btnReanudar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReanudar.Location = New System.Drawing.Point(33, 181)
        Me.btnReanudar.Name = "btnReanudar"
        Me.btnReanudar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnReanudar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReanudar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReanudar.OnHoverImage = Nothing
        Me.btnReanudar.OnPressedColor = System.Drawing.Color.Black
        Me.btnReanudar.Radius = 12
        Me.btnReanudar.Size = New System.Drawing.Size(117, 32)
        Me.btnReanudar.TabIndex = 200
        Me.btnReanudar.Text = "Ingresar"
        Me.btnReanudar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Reanudar chat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 7)
        Me.Panel6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 59)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Continuar chat con médico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 7
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'frmBienvenidaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlNotis.ResumeLayout(False)
        Me.pnlCerrar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents notificacion As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents pnlNoti As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNoti As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Public WithEvents pnlInstancia As Panel
    Friend WithEvents pnlNotis As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNo As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSi As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblNA As Label
    Friend WithEvents btnHistorial As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnReanudar As Guna.UI.WinForms.GunaButton
End Class
