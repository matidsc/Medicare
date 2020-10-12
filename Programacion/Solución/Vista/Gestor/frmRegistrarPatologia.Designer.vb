<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarPatologia

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components__1 IsNot Nothing Then
                components__1.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components__1 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarPatologia))
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.mrbtnRegistrarPat = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlPatologia = New System.Windows.Forms.Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSintomas = New Guna.UI.WinForms.GunaButton()
        Me.lblPrioPat = New System.Windows.Forms.Label()
        Me.mrbPMedia = New Guna.UI.WinForms.GunaRadioButton()
        Me.mrbPBaja = New Guna.UI.WinForms.GunaRadioButton()
        Me.mrbPAlta = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.txtRecPat = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.txtDescPat = New Guna.UI.WinForms.GunaTextBox()
        Me.lblDescPat = New System.Windows.Forms.Label()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.txtNomPat = New Guna.UI.WinForms.GunaLineTextBox()
        Me.pnlSintomas = New System.Windows.Forms.Panel()
        Me.transicion = New Guna.UI.WinForms.GunaTransition(Me.components)
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlPatologia.SuspendLayout()
        Me.pnlSintomas.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        Me.transicion.SetDecoration(Me.dgvSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(598, 133)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(214, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 114
        '
        'dgvColSintomasSel
        '
        Me.dgvColSintomasSel.HeaderText = "Column1"
        Me.dgvColSintomasSel.MinimumWidth = 6
        Me.dgvColSintomasSel.Name = "dgvColSintomasSel"
        Me.dgvColSintomasSel.ReadOnly = True
        '
        'dgvTodosLosSintomas
        '
        Me.dgvTodosLosSintomas.AllowDrop = True
        Me.dgvTodosLosSintomas.AllowUserToAddRows = False
        Me.dgvTodosLosSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        Me.transicion.SetDecoration(Me.dgvTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(173, 146)
        Me.dgvTodosLosSintomas.MultiSelect = False
        Me.dgvTodosLosSintomas.Name = "dgvTodosLosSintomas"
        Me.dgvTodosLosSintomas.ReadOnly = True
        Me.dgvTodosLosSintomas.RowHeadersVisible = False
        Me.dgvTodosLosSintomas.RowHeadersWidth = 51
        Me.dgvTodosLosSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodosLosSintomas.Size = New System.Drawing.Size(214, 430)
        Me.dgvTodosLosSintomas.TabIndex = 115
        '
        'dgvColSintomas
        '
        Me.dgvColSintomas.HeaderText = "Column1"
        Me.dgvColSintomas.MinimumWidth = 6
        Me.dgvColSintomas.Name = "dgvColSintomas"
        Me.dgvColSintomas.ReadOnly = True
        '
        'lblTodosLosSintomas
        '
        Me.transicion.SetDecoration(Me.lblTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(127, 71)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(277, 43)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.transicion.SetDecoration(Me.lblSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(541, 58)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(312, 43)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mrbtnRegistrarPat
        '
        Me.mrbtnRegistrarPat.AutoSize = True
        Me.mrbtnRegistrarPat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.transicion.SetDecoration(Me.mrbtnRegistrarPat, Guna.UI.Animation.DecorationType.None)
        Me.mrbtnRegistrarPat.Depth = 0
        Me.mrbtnRegistrarPat.Icon = Nothing
        Me.mrbtnRegistrarPat.Location = New System.Drawing.Point(441, 586)
        Me.mrbtnRegistrarPat.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnRegistrarPat.Name = "mrbtnRegistrarPat"
        Me.mrbtnRegistrarPat.Primary = True
        Me.mrbtnRegistrarPat.Size = New System.Drawing.Size(172, 36)
        Me.mrbtnRegistrarPat.TabIndex = 127
        Me.mrbtnRegistrarPat.Text = "Registrar patología"
        Me.mrbtnRegistrarPat.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlPatologia)
        Me.pnlContenedor.Controls.Add(Me.pnlSintomas)
        Me.pnlContenedor.Controls.Add(Me.mrbtnRegistrarPat)
        Me.transicion.SetDecoration(Me.pnlContenedor, Guna.UI.Animation.DecorationType.None)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 132
        '
        'pnlPatologia
        '
        Me.pnlPatologia.Controls.Add(Me.GunaButton2)
        Me.pnlPatologia.Controls.Add(Me.Label3)
        Me.pnlPatologia.Controls.Add(Me.btnSintomas)
        Me.pnlPatologia.Controls.Add(Me.lblPrioPat)
        Me.pnlPatologia.Controls.Add(Me.mrbPMedia)
        Me.pnlPatologia.Controls.Add(Me.mrbPBaja)
        Me.pnlPatologia.Controls.Add(Me.mrbPAlta)
        Me.pnlPatologia.Controls.Add(Me.GunaSeparator2)
        Me.pnlPatologia.Controls.Add(Me.txtRecPat)
        Me.pnlPatologia.Controls.Add(Me.Label2)
        Me.pnlPatologia.Controls.Add(Me.Label1)
        Me.pnlPatologia.Controls.Add(Me.GunaSeparator1)
        Me.pnlPatologia.Controls.Add(Me.txtDescPat)
        Me.pnlPatologia.Controls.Add(Me.lblDescPat)
        Me.pnlPatologia.Controls.Add(Me.lblNomPat)
        Me.pnlPatologia.Controls.Add(Me.txtNomPat)
        Me.transicion.SetDecoration(Me.pnlPatologia, Guna.UI.Animation.DecorationType.None)
        Me.pnlPatologia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlPatologia.Name = "pnlPatologia"
        Me.pnlPatologia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlPatologia.TabIndex = 176
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(272, 570)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 25
        Me.GunaButton2.Size = New System.Drawing.Size(243, 53)
        Me.GunaButton2.TabIndex = 197
        Me.GunaButton2.Text = "Registrar"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.transicion.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(818, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "0/300"
        '
        'btnSintomas
        '
        Me.btnSintomas.AnimationHoverSpeed = 0.07!
        Me.btnSintomas.AnimationSpeed = 0.03!
        Me.btnSintomas.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomas.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnSintomas, Guna.UI.Animation.DecorationType.None)
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.Location = New System.Drawing.Point(569, 570)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Radius = 25
        Me.btnSintomas.Size = New System.Drawing.Size(243, 53)
        Me.btnSintomas.TabIndex = 195
        Me.btnSintomas.Text = "Añadir síntomas"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrioPat
        '
        Me.lblPrioPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPrioPat, Guna.UI.Animation.DecorationType.None)
        Me.lblPrioPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrioPat.Location = New System.Drawing.Point(689, 58)
        Me.lblPrioPat.Name = "lblPrioPat"
        Me.lblPrioPat.Size = New System.Drawing.Size(90, 25)
        Me.lblPrioPat.TabIndex = 192
        Me.lblPrioPat.Text = "Prioridad"
        '
        'mrbPMedia
        '
        Me.mrbPMedia.BaseColor = System.Drawing.Color.Silver
        Me.mrbPMedia.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPMedia.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transicion.SetDecoration(Me.mrbPMedia, Guna.UI.Animation.DecorationType.None)
        Me.mrbPMedia.FillColor = System.Drawing.Color.White
        Me.mrbPMedia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPMedia.Location = New System.Drawing.Point(686, 117)
        Me.mrbPMedia.Name = "mrbPMedia"
        Me.mrbPMedia.Size = New System.Drawing.Size(74, 24)
        Me.mrbPMedia.TabIndex = 191
        Me.mrbPMedia.Text = "Media"
        '
        'mrbPBaja
        '
        Me.mrbPBaja.BaseColor = System.Drawing.Color.Silver
        Me.mrbPBaja.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPBaja.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transicion.SetDecoration(Me.mrbPBaja, Guna.UI.Animation.DecorationType.None)
        Me.mrbPBaja.FillColor = System.Drawing.Color.White
        Me.mrbPBaja.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPBaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPBaja.Location = New System.Drawing.Point(600, 116)
        Me.mrbPBaja.Name = "mrbPBaja"
        Me.mrbPBaja.Size = New System.Drawing.Size(59, 24)
        Me.mrbPBaja.TabIndex = 190
        Me.mrbPBaja.Text = "Baja"
        '
        'mrbPAlta
        '
        Me.mrbPAlta.BaseColor = System.Drawing.Color.Silver
        Me.mrbPAlta.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPAlta.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transicion.SetDecoration(Me.mrbPAlta, Guna.UI.Animation.DecorationType.None)
        Me.mrbPAlta.FillColor = System.Drawing.Color.White
        Me.mrbPAlta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPAlta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPAlta.Location = New System.Drawing.Point(787, 117)
        Me.mrbPAlta.Name = "mrbPAlta"
        Me.mrbPAlta.Size = New System.Drawing.Size(58, 24)
        Me.mrbPAlta.TabIndex = 189
        Me.mrbPAlta.Text = "Alta"
        '
        'GunaSeparator2
        '
        Me.transicion.SetDecoration(Me.GunaSeparator2, Guna.UI.Animation.DecorationType.None)
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(223, 515)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(654, 10)
        Me.GunaSeparator2.TabIndex = 188
        '
        'txtRecPat
        '
        Me.txtRecPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.BorderColor = System.Drawing.Color.Silver
        Me.txtRecPat.BorderSize = 0
        Me.txtRecPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtRecPat, Guna.UI.Animation.DecorationType.None)
        Me.txtRecPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Location = New System.Drawing.Point(223, 427)
        Me.txtRecPat.MaxLength = 300
        Me.txtRecPat.MultiLine = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecPat.Size = New System.Drawing.Size(667, 96)
        Me.txtRecPat.TabIndex = 187
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.transicion.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(223, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Recomendaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.transicion.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(812, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "0/300"
        '
        'GunaSeparator1
        '
        Me.transicion.SetDecoration(Me.GunaSeparator1, Guna.UI.Animation.DecorationType.None)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(223, 363)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(654, 10)
        Me.GunaSeparator1.TabIndex = 184
        '
        'txtDescPat
        '
        Me.txtDescPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.BorderColor = System.Drawing.Color.Silver
        Me.txtDescPat.BorderSize = 0
        Me.txtDescPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtDescPat, Guna.UI.Animation.DecorationType.None)
        Me.txtDescPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Location = New System.Drawing.Point(223, 251)
        Me.txtDescPat.MaxLength = 300
        Me.txtDescPat.MultiLine = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescPat.Size = New System.Drawing.Size(654, 122)
        Me.txtDescPat.TabIndex = 183
        '
        'lblDescPat
        '
        Me.lblDescPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblDescPat, Guna.UI.Animation.DecorationType.None)
        Me.lblDescPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescPat.Location = New System.Drawing.Point(223, 205)
        Me.lblDescPat.Name = "lblDescPat"
        Me.lblDescPat.Size = New System.Drawing.Size(111, 25)
        Me.lblDescPat.TabIndex = 182
        Me.lblDescPat.Text = "Descripción"
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNomPat, Guna.UI.Animation.DecorationType.None)
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(223, 58)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(212, 25)
        Me.lblNomPat.TabIndex = 181
        Me.lblNomPat.Text = "Nombre de la patología"
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNomPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtNomPat, Guna.UI.Animation.DecorationType.None)
        Me.txtNomPat.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNomPat.LineColor = System.Drawing.Color.Gainsboro
        Me.txtNomPat.LineSize = 1
        Me.txtNomPat.Location = New System.Drawing.Point(223, 104)
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomPat.Size = New System.Drawing.Size(317, 36)
        Me.txtNomPat.TabIndex = 180
        '
        'pnlSintomas
        '
        Me.pnlSintomas.Controls.Add(Me.dgvTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlSintomas.Controls.Add(Me.lblTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.lblSintomasSeleccionados)
        Me.transicion.SetDecoration(Me.pnlSintomas, Guna.UI.Animation.DecorationType.None)
        Me.pnlSintomas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSintomas.Location = New System.Drawing.Point(0, 0)
        Me.pnlSintomas.Name = "pnlSintomas"
        Me.pnlSintomas.Size = New System.Drawing.Size(1070, 650)
        Me.pnlSintomas.TabIndex = 177
        '
        'transicion
        '
        Me.transicion.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.transicion.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.transicion.DefaultAnimation = Animation1
        Me.transicion.Interval = 7
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.transicion.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlPatologia.ResumeLayout(False)
        Me.pnlPatologia.PerformLayout()
        Me.pnlSintomas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
    Friend WithEvents mrbtnRegistrarPat As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlPatologia As Panel
    Friend WithEvents lblPrioPat As Label
    Friend WithEvents mrbPMedia As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents mrbPBaja As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents mrbPAlta As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtRecPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtDescPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblDescPat As Label
    Friend WithEvents lblNomPat As Label
    Friend WithEvents txtNomPat As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pnlSintomas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSintomas As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents transicion As Guna.UI.WinForms.GunaTransition
    Private components As System.ComponentModel.IContainer
End Class
