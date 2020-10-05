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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaGestor))
        Me.pnlListadoPacientes = New System.Windows.Forms.Panel()
        Me.btnRefrescarListadoPac = New System.Windows.Forms.Button()
        Me.lblTituloLIstadoPacientes = New System.Windows.Forms.Label()
        Me.dgvListadoPacientes = New System.Windows.Forms.DataGridView()
        Me.Rechazar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Aceptar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tempListaPacientes = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegistro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNoti = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlListadoPacientes.SuspendLayout()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlListadoPacientes
        '
        Me.pnlListadoPacientes.Controls.Add(Me.btnRefrescarListadoPac)
        Me.pnlListadoPacientes.Controls.Add(Me.lblTituloLIstadoPacientes)
        Me.pnlListadoPacientes.Controls.Add(Me.dgvListadoPacientes)
        Me.pnlListadoPacientes.Location = New System.Drawing.Point(621, 83)
        Me.pnlListadoPacientes.Name = "pnlListadoPacientes"
        Me.pnlListadoPacientes.Size = New System.Drawing.Size(260, 451)
        Me.pnlListadoPacientes.TabIndex = 24
        Me.pnlListadoPacientes.Visible = False
        '
        'btnRefrescarListadoPac
        '
        Me.btnRefrescarListadoPac.FlatAppearance.BorderSize = 0
        Me.btnRefrescarListadoPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescarListadoPac.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.btnRefrescarListadoPac.Location = New System.Drawing.Point(224, 3)
        Me.btnRefrescarListadoPac.Name = "btnRefrescarListadoPac"
        Me.btnRefrescarListadoPac.Size = New System.Drawing.Size(28, 30)
        Me.btnRefrescarListadoPac.TabIndex = 25
        Me.btnRefrescarListadoPac.UseVisualStyleBackColor = True
        '
        'lblTituloLIstadoPacientes
        '
        Me.lblTituloLIstadoPacientes.AutoSize = True
        Me.lblTituloLIstadoPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloLIstadoPacientes.ForeColor = System.Drawing.Color.White
        Me.lblTituloLIstadoPacientes.Location = New System.Drawing.Point(63, 8)
        Me.lblTituloLIstadoPacientes.Name = "lblTituloLIstadoPacientes"
        Me.lblTituloLIstadoPacientes.Size = New System.Drawing.Size(128, 18)
        Me.lblTituloLIstadoPacientes.TabIndex = 147
        Me.lblTituloLIstadoPacientes.Text = "Habilitar pacientes"
        '
        'dgvListadoPacientes
        '
        Me.dgvListadoPacientes.AllowUserToAddRows = False
        Me.dgvListadoPacientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoPacientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoPacientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvListadoPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPacientes.ColumnHeadersVisible = False
        Me.dgvListadoPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rechazar, Me.Aceptar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoPacientes.EnableHeadersVisualStyles = False
        Me.dgvListadoPacientes.Location = New System.Drawing.Point(0, 39)
        Me.dgvListadoPacientes.MultiSelect = False
        Me.dgvListadoPacientes.Name = "dgvListadoPacientes"
        Me.dgvListadoPacientes.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoPacientes.RowHeadersVisible = False
        Me.dgvListadoPacientes.RowHeadersWidth = 51
        Me.dgvListadoPacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPacientes.Size = New System.Drawing.Size(257, 409)
        Me.dgvListadoPacientes.TabIndex = 146
        '
        'Rechazar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Green
        Me.Rechazar.DefaultCellStyle = DataGridViewCellStyle3
        Me.Rechazar.HeaderText = "Rechazar"
        Me.Rechazar.MinimumWidth = 6
        Me.Rechazar.Name = "Rechazar"
        Me.Rechazar.ReadOnly = True
        Me.Rechazar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Rechazar.Text = "rechazar"
        '
        'Aceptar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        Me.Aceptar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Aceptar.HeaderText = "Aceptar"
        Me.Aceptar.MinimumWidth = 6
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.ReadOnly = True
        Me.Aceptar.Text = "aceptar"
        '
        'tempListaPacientes
        '
        Me.tempListaPacientes.Interval = 6000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlListadoPacientes)
        Me.pnlContenedor.Controls.Add(Me.Panel9)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1940, 569)
        Me.pnlContenedor.TabIndex = 25
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(0, 83)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1070, 490)
        Me.Panel9.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(406, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 29)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Buenas tardes, Rodrigo"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Location = New System.Drawing.Point(34, 125)
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
        Me.Panel1.Location = New System.Drawing.Point(106, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 248)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 7)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnPatologia.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPatologia.BorderColor = System.Drawing.Color.Black
        Me.btnPatologia.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnPatologia.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPatologia.CheckedForeColor = System.Drawing.Color.White
        Me.btnPatologia.CheckedImage = CType(resources.GetObject("btnPatologia.CheckedImage"), System.Drawing.Image)
        Me.btnPatologia.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPatologia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatologia.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPatologia.FocusedColor = System.Drawing.Color.Empty
        Me.btnPatologia.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatologia.ForeColor = System.Drawing.Color.White
        Me.btnPatologia.Image = Nothing
        Me.btnPatologia.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPatologia.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologia.Location = New System.Drawing.Point(30, 179)
        Me.btnPatologia.Name = "btnPatologia"
        Me.btnPatologia.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnPatologia.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPatologia.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPatologia.OnHoverImage = Nothing
        Me.btnPatologia.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologia.OnPressedColor = System.Drawing.Color.Black
        Me.btnPatologia.Radius = 12
        Me.btnPatologia.Size = New System.Drawing.Size(125, 28)
        Me.btnPatologia.TabIndex = 9
        Me.btnPatologia.Text = "Ingresar"
        Me.btnPatologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patologías"
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
        Me.btnSintomas.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSintomas.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedForeColor = System.Drawing.Color.White
        Me.btnSintomas.CheckedImage = Nothing
        Me.btnSintomas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.Location = New System.Drawing.Point(34, 183)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Radius = 12
        Me.btnSintomas.Size = New System.Drawing.Size(125, 28)
        Me.btnSintomas.TabIndex = 10
        Me.btnSintomas.Text = "Ingresar"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 7)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 59)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Registrar, modificar, eliminar y buscar síntoamas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Síntomas"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel8.Location = New System.Drawing.Point(714, 265)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(183, 7)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel7.Controls.Add(Me.GunaAdvenceButton4)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(714, 24)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 248)
        Me.Panel7.TabIndex = 7
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Nothing
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(29, 181)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Radius = 12
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(125, 28)
        Me.GunaAdvenceButton4.TabIndex = 12
        Me.GunaAdvenceButton4.Text = "Ingresar"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(46, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Usuarios"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Panel5.Location = New System.Drawing.Point(508, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 248)
        Me.Panel5.TabIndex = 6
        '
        'btnRegistro
        '
        Me.btnRegistro.AnimationHoverSpeed = 0.07!
        Me.btnRegistro.AnimationSpeed = 0.03!
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnRegistro.BorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRegistro.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedForeColor = System.Drawing.Color.White
        Me.btnRegistro.CheckedImage = CType(resources.GetObject("btnRegistro.CheckedImage"), System.Drawing.Image)
        Me.btnRegistro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistro.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistro.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Image = Nothing
        Me.btnRegistro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.Location = New System.Drawing.Point(33, 184)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRegistro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistro.OnHoverImage = Nothing
        Me.btnRegistro.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistro.Radius = 12
        Me.btnRegistro.Size = New System.Drawing.Size(125, 28)
        Me.btnRegistro.TabIndex = 11
        Me.btnRegistro.Text = "Ingresar"
        Me.btnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Registro"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 7)
        Me.Panel6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 59)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Registrar médicos y gestores en la aplicación"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.GunaElipsePanel1)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox3)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 25
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(729, 29)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 5
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(10, 10)
        Me.GunaElipsePanel1.TabIndex = 9
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.Location = New System.Drawing.Point(757, 27)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(37, 32)
        Me.IconPictureBox3.TabIndex = 11
        Me.IconPictureBox3.TabStop = False
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
        Me.btnNoti.Location = New System.Drawing.Point(707, 27)
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
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1940, 569)
        Me.pnlInstancia.TabIndex = 6
        '
        'frmBienvenidaGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1940, 569)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlListadoPacientes.ResumeLayout(False)
        Me.pnlListadoPacientes.PerformLayout()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlCerrar.ResumeLayout(False)
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlListadoPacientes As Panel
    Friend WithEvents lblTituloLIstadoPacientes As Label
    Friend WithEvents dgvListadoPacientes As DataGridView
    Friend WithEvents btnRefrescarListadoPac As Button
    Friend WithEvents tempListaPacientes As Timer
    Friend WithEvents Rechazar As DataGridViewButtonColumn
    Friend WithEvents Aceptar As DataGridViewButtonColumn
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
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRegistro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNoti As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class

