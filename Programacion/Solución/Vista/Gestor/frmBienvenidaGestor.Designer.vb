<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaGestor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaGestor))
        Me.tempListaPacientes = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPatologia = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSintomas = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegistro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlNotificacion = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotificacion = New System.Windows.Forms.Label()
        Me.btnRefrescarListadoPac = New System.Windows.Forms.Button()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnPacientes = New FontAwesome.Sharp.IconPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNoti = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        Me.pnlNotificacion.SuspendLayout()
        CType(Me.btnPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tempListaPacientes
        '
        Me.tempListaPacientes.Enabled = True
        Me.tempListaPacientes.Interval = 6000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.scroll)
        Me.pnlContenedor.Controls.Add(Me.Panel9)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 25
        '
        'scroll
        '
        Me.scroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scroll.Enabled = False
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(-88, 120)
        Me.scroll.Margin = New System.Windows.Forms.Padding(0)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.Silver
        Me.scroll.Size = New System.Drawing.Size(10, 467)
        Me.scroll.TabIndex = 0
        Me.scroll.ThumbColor = System.Drawing.Color.DimGray
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblNA)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.pnlFlow)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(0, 80)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1070, 570)
        Me.Panel9.TabIndex = 26
        '
        'lblNA
        '
        Me.lblNA.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblNA.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.Color.White
        Me.lblNA.Location = New System.Drawing.Point(1045, 127)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(300, 420)
        Me.lblNA.TabIndex = 0
        Me.lblNA.Text = "No hay solicitudes"
        Me.lblNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNA.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(405, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(266, 29)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Buenas tardes, Rodrigo"
        '
        'pnlFlow
        '
        Me.pnlFlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlFlow.Location = New System.Drawing.Point(1041, 104)
        Me.pnlFlow.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlow.Name = "pnlFlow"
        Me.pnlFlow.Size = New System.Drawing.Size(335, 466)
        Me.pnlFlow.TabIndex = 26
        Me.pnlFlow.Visible = False
        Me.pnlFlow.WrapContents = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Location = New System.Drawing.Point(35, 168)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1003, 306)
        Me.Panel10.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnPatologia)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(82, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 248)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 7)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 59)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Registrar, modificar, eliminar y buscar patologías"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPatologia
        '
        Me.btnPatologia.AnimationHoverSpeed = 0.07!
        Me.btnPatologia.AnimationSpeed = 0.03!
        Me.btnPatologia.BackColor = System.Drawing.Color.Transparent
        Me.btnPatologia.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnPatologia.BorderColor = System.Drawing.Color.Black
        Me.btnPatologia.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnPatologia.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPatologia.CheckedForeColor = System.Drawing.Color.White
        Me.btnPatologia.CheckedImage = CType(resources.GetObject("btnPatologia.CheckedImage"), System.Drawing.Image)
        Me.btnPatologia.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPatologia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatologia.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPatologia.FocusedColor = System.Drawing.Color.Empty
        Me.btnPatologia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatologia.ForeColor = System.Drawing.Color.White
        Me.btnPatologia.Image = Nothing
        Me.btnPatologia.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPatologia.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologia.Location = New System.Drawing.Point(29, 179)
        Me.btnPatologia.Name = "btnPatologia"
        Me.btnPatologia.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnPatologia.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPatologia.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPatologia.OnHoverImage = Nothing
        Me.btnPatologia.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologia.OnPressedColor = System.Drawing.Color.Black
        Me.btnPatologia.Radius = 12
        Me.btnPatologia.Size = New System.Drawing.Size(125, 30)
        Me.btnPatologia.TabIndex = 9
        Me.btnPatologia.Text = "Ingresar"
        Me.btnPatologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patologías"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSintomas)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(306, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 248)
        Me.Panel3.TabIndex = 5
        '
        'btnSintomas
        '
        Me.btnSintomas.AnimationHoverSpeed = 0.07!
        Me.btnSintomas.AnimationSpeed = 0.03!
        Me.btnSintomas.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomas.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSintomas.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedForeColor = System.Drawing.Color.White
        Me.btnSintomas.CheckedImage = Nothing
        Me.btnSintomas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.Location = New System.Drawing.Point(30, 183)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Radius = 12
        Me.btnSintomas.Size = New System.Drawing.Size(125, 30)
        Me.btnSintomas.TabIndex = 10
        Me.btnSintomas.Text = "Ingresar"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 59)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Registrar, modificar, eliminar y buscar síntomas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Síntomas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel8.Location = New System.Drawing.Point(749, 265)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(183, 7)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnUsuarios)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(749, 24)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 248)
        Me.Panel7.TabIndex = 7
        '
        'btnUsuarios
        '
        Me.btnUsuarios.AnimationHoverSpeed = 0.07!
        Me.btnUsuarios.AnimationSpeed = 0.03!
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUsuarios.BorderColor = System.Drawing.Color.Black
        Me.btnUsuarios.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUsuarios.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUsuarios.CheckedForeColor = System.Drawing.Color.White
        Me.btnUsuarios.CheckedImage = CType(resources.GetObject("btnUsuarios.CheckedImage"), System.Drawing.Image)
        Me.btnUsuarios.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUsuarios.FocusedColor = System.Drawing.Color.Empty
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Nothing
        Me.btnUsuarios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUsuarios.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(29, 181)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUsuarios.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUsuarios.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUsuarios.OnHoverImage = Nothing
        Me.btnUsuarios.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUsuarios.OnPressedColor = System.Drawing.Color.Black
        Me.btnUsuarios.Radius = 12
        Me.btnUsuarios.Size = New System.Drawing.Size(125, 30)
        Me.btnUsuarios.TabIndex = 12
        Me.btnUsuarios.Text = "Ingresar"
        Me.btnUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 40)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Usuarios"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 59)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Buscar, modificar o eliminar usuarios"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnRegistro)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(532, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 248)
        Me.Panel5.TabIndex = 6
        '
        'btnRegistro
        '
        Me.btnRegistro.AnimationHoverSpeed = 0.07!
        Me.btnRegistro.AnimationSpeed = 0.03!
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistro.BorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRegistro.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedForeColor = System.Drawing.Color.White
        Me.btnRegistro.CheckedImage = CType(resources.GetObject("btnRegistro.CheckedImage"), System.Drawing.Image)
        Me.btnRegistro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistro.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Image = Nothing
        Me.btnRegistro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.Location = New System.Drawing.Point(32, 184)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRegistro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistro.OnHoverImage = Nothing
        Me.btnRegistro.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistro.Radius = 12
        Me.btnRegistro.Size = New System.Drawing.Size(125, 30)
        Me.btnRegistro.TabIndex = 11
        Me.btnRegistro.Text = "Ingresar"
        Me.btnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Registro"
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
        Me.Label5.Location = New System.Drawing.Point(23, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 59)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Registrar médicos y gestores en la aplicación"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.Label10)
        Me.pnlCerrar.Controls.Add(Me.pnlNotificacion)
        Me.pnlCerrar.Controls.Add(Me.btnRefrescarListadoPac)
        Me.pnlCerrar.Controls.Add(Me.GunaElipsePanel1)
        Me.pnlCerrar.Controls.Add(Me.btnPacientes)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(485, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Hola"
        Me.Label10.Visible = False
        '
        'pnlNotificacion
        '
        Me.pnlNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotificacion.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.pnlNotificacion.Controls.Add(Me.lblNotificacion)
        Me.pnlNotificacion.Location = New System.Drawing.Point(784, 27)
        Me.pnlNotificacion.Name = "pnlNotificacion"
        Me.pnlNotificacion.Size = New System.Drawing.Size(16, 16)
        Me.pnlNotificacion.TabIndex = 10
        Me.pnlNotificacion.Visible = False
        '
        'lblNotificacion
        '
        Me.lblNotificacion.AutoSize = True
        Me.lblNotificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotificacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion.ForeColor = System.Drawing.Color.White
        Me.lblNotificacion.Location = New System.Drawing.Point(-1, 1)
        Me.lblNotificacion.Name = "lblNotificacion"
        Me.lblNotificacion.Size = New System.Drawing.Size(13, 13)
        Me.lblNotificacion.TabIndex = 0
        Me.lblNotificacion.Text = "0"
        Me.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotificacion.Visible = False
        '
        'btnRefrescarListadoPac
        '
        Me.btnRefrescarListadoPac.FlatAppearance.BorderSize = 0
        Me.btnRefrescarListadoPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescarListadoPac.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.btnRefrescarListadoPac.Location = New System.Drawing.Point(973, 29)
        Me.btnRefrescarListadoPac.Name = "btnRefrescarListadoPac"
        Me.btnRefrescarListadoPac.Size = New System.Drawing.Size(28, 30)
        Me.btnRefrescarListadoPac.TabIndex = 25
        Me.btnRefrescarListadoPac.UseVisualStyleBackColor = True
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaElipsePanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(839, 27)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 5
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(15, 15)
        Me.GunaElipsePanel1.TabIndex = 9
        '
        'btnPacientes
        '
        Me.btnPacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnPacientes.IconColor = System.Drawing.Color.White
        Me.btnPacientes.Location = New System.Drawing.Point(762, 27)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(37, 32)
        Me.btnPacientes.TabIndex = 11
        Me.btnPacientes.TabStop = False
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
        Me.btnNoti.Location = New System.Drawing.Point(819, 27)
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
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 6
        '
        'frmBienvenidaGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnlCerrar.ResumeLayout(False)
        Me.pnlCerrar.PerformLayout()
        Me.pnlNotificacion.ResumeLayout(False)
        Me.pnlNotificacion.PerformLayout()
        CType(Me.btnPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tempListaPacientes As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPatologia As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSintomas As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnUsuarios As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRegistro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnPacientes As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNoti As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlFlow As FlowLayoutPanel
    Friend WithEvents btnRefrescarListadoPac As Button
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents pnlNotificacion As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblNotificacion As Label
    Friend WithEvents lblNA As Label
    Friend WithEvents Label10 As Label
End Class

