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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaMedico))
        Me.timerChat = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblNuevosMsg = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNAChats = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.pnlNotificacion = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotiMsg = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlNoti = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotiChats = New System.Windows.Forms.Label()
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
        Me.timerMsg = New System.Windows.Forms.Timer(Me.components)
        Me.Redondear = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        Me.pnlNotificacion.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoti.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerChat
        '
        Me.timerChat.Enabled = True
        Me.timerChat.Interval = 4000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.lblNuevosMsg)
        Me.pnlContenedor.Controls.Add(Me.Label9)
        Me.pnlContenedor.Controls.Add(Me.lblNAChats)
        Me.pnlContenedor.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Controls.Add(Me.Panel10)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 23
        '
        'lblNuevosMsg
        '
        Me.lblNuevosMsg.AutoSize = True
        Me.lblNuevosMsg.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevosMsg.ForeColor = System.Drawing.Color.White
        Me.lblNuevosMsg.Location = New System.Drawing.Point(398, 182)
        Me.lblNuevosMsg.Name = "lblNuevosMsg"
        Me.lblNuevosMsg.Size = New System.Drawing.Size(0, 32)
        Me.lblNuevosMsg.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(421, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 32)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Buenas tardes, Rodrigo"
        '
        'lblNAChats
        '
        Me.lblNAChats.AutoSize = True
        Me.lblNAChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblNAChats.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNAChats.ForeColor = System.Drawing.Color.Silver
        Me.lblNAChats.Location = New System.Drawing.Point(600, 305)
        Me.lblNAChats.Name = "lblNAChats"
        Me.lblNAChats.Size = New System.Drawing.Size(297, 32)
        Me.lblNAChats.TabIndex = 0
        Me.lblNAChats.Text = "No hay solicitudes de chat"
        Me.lblNAChats.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(539, 78)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(420, 497)
        Me.FlowLayoutPanel1.TabIndex = 31
        Me.FlowLayoutPanel1.Visible = False
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.pnlNotificacion)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox2)
        Me.pnlCerrar.Controls.Add(Me.pnlNoti)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 27
        '
        'pnlNotificacion
        '
        Me.pnlNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotificacion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNotificacion.Controls.Add(Me.lblNotiMsg)
        Me.pnlNotificacion.Location = New System.Drawing.Point(728, 23)
        Me.pnlNotificacion.Name = "pnlNotificacion"
        Me.pnlNotificacion.Size = New System.Drawing.Size(16, 16)
        Me.pnlNotificacion.TabIndex = 12
        Me.pnlNotificacion.Visible = False
        '
        'lblNotiMsg
        '
        Me.lblNotiMsg.AutoSize = True
        Me.lblNotiMsg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotiMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotiMsg.ForeColor = System.Drawing.Color.White
        Me.lblNotiMsg.Location = New System.Drawing.Point(-1, 1)
        Me.lblNotiMsg.Name = "lblNotiMsg"
        Me.lblNotiMsg.Size = New System.Drawing.Size(13, 13)
        Me.lblNotiMsg.TabIndex = 0
        Me.lblNotiMsg.Text = "0"
        Me.lblNotiMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotiMsg.Visible = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CommentAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.Location = New System.Drawing.Point(710, 26)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 13
        Me.IconPictureBox2.TabStop = False
        '
        'pnlNoti
        '
        Me.pnlNoti.BackColor = System.Drawing.Color.Transparent
        Me.pnlNoti.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNoti.Controls.Add(Me.lblNotiChats)
        Me.pnlNoti.Location = New System.Drawing.Point(777, 23)
        Me.pnlNoti.Name = "pnlNoti"
        Me.pnlNoti.Size = New System.Drawing.Size(16, 16)
        Me.pnlNoti.TabIndex = 9
        Me.pnlNoti.Visible = False
        '
        'lblNotiChats
        '
        Me.lblNotiChats.AutoSize = True
        Me.lblNotiChats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotiChats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotiChats.ForeColor = System.Drawing.Color.White
        Me.lblNotiChats.Location = New System.Drawing.Point(-1, 1)
        Me.lblNotiChats.Name = "lblNotiChats"
        Me.lblNotiChats.Size = New System.Drawing.Size(13, 13)
        Me.lblNotiChats.TabIndex = 1
        Me.lblNotiChats.Text = "0"
        Me.lblNotiChats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotiChats.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.LOGO_MEDICARE_SIN_SUB_WHITE_V2_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 56)
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(803, 26)
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
        Me.Panel10.TabIndex = 10
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
        Me.btnIngresar.Animated = True
        Me.btnIngresar.AnimationHoverSpeed = 0.07!
        Me.btnIngresar.AnimationSpeed = 0.03!
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnIngresar.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Label2.Text = "Ver lista de chats que tiene con su pacientes"
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
        Me.Label1.Text = "Chat"
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
        Me.btnHistorial.Animated = True
        Me.btnHistorial.AnimationHoverSpeed = 0.07!
        Me.btnHistorial.AnimationSpeed = 0.03!
        Me.btnHistorial.BackColor = System.Drawing.Color.Transparent
        Me.btnHistorial.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnHistorial.BorderColor = System.Drawing.Color.Black
        Me.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btnReanudar.Animated = True
        Me.btnReanudar.AnimationHoverSpeed = 0.07!
        Me.btnReanudar.AnimationSpeed = 0.03!
        Me.btnReanudar.BackColor = System.Drawing.Color.Transparent
        Me.btnReanudar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReanudar.BorderColor = System.Drawing.Color.Black
        Me.btnReanudar.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Label6.Size = New System.Drawing.Size(180, 53)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Listado de patologías"
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
        Me.Label5.Location = New System.Drawing.Point(21, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 59)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Vea todas las patologías registradas en la aplicación"
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
        'timerMsg
        '
        Me.timerMsg.Enabled = True
        Me.timerMsg.Interval = 5000
        '
        'Redondear
        '
        Me.Redondear.Radius = 7
        Me.Redondear.TargetControl = Me.FlowLayoutPanel1
        '
        'frmBienvenidaMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlCerrar.ResumeLayout(False)
        Me.pnlNotificacion.ResumeLayout(False)
        Me.pnlNotificacion.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoti.ResumeLayout(False)
        Me.pnlNoti.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerChat As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnHistorial As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnReanudar As Guna.UI.WinForms.GunaButton
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
    Friend WithEvents timerMsg As Timer
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlNotificacion As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblNotiMsg As Label
    Friend WithEvents lblNuevosMsg As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Redondear As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblNotiChats As Label
    Friend WithEvents lblNAChats As Label
End Class

