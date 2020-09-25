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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblRegistrar = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.pnlDescPatologia = New System.Windows.Forms.Panel()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.pnlNomPat = New System.Windows.Forms.Panel()
        Me.lblDescPat = New System.Windows.Forms.Label()
        Me.pnlTxtRecPat = New System.Windows.Forms.Panel()
        Me.lblRecPat = New System.Windows.Forms.Label()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.txtNomPat = New System.Windows.Forms.TextBox()
        Me.lblArrastreSintomas = New System.Windows.Forms.Label()
        Me.txtDescPat = New System.Windows.Forms.TextBox()
        Me.txtRecPat = New System.Windows.Forms.TextBox()
        Me.mrbtnRegistrarPat = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.mrbPAlta = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbPBaja = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbPMedia = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblRegistrar)
        Me.pnlTituloPatologia.Controls.Add(Me.lblMinimizar)
        Me.pnlTituloPatologia.Controls.Add(Me.lblCerrar)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1103, 77)
        Me.pnlTituloPatologia.TabIndex = 92
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icoFlechaAtrasWhite
        Me.btnAtras.Location = New System.Drawing.Point(32, 23)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 29
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblRegistrar
        '
        Me.lblRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrar.ForeColor = System.Drawing.Color.White
        Me.lblRegistrar.Location = New System.Drawing.Point(369, 16)
        Me.lblRegistrar.Name = "lblRegistrar"
        Me.lblRegistrar.Size = New System.Drawing.Size(365, 45)
        Me.lblRegistrar.TabIndex = 26
        Me.lblRegistrar.Text = "REGISTRAR PATOLOGÍA"
        Me.lblRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(1027, -6)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 24
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1057, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDescPatologia
        '
        Me.pnlDescPatologia.BackColor = System.Drawing.Color.Black
        Me.pnlDescPatologia.Location = New System.Drawing.Point(49, 391)
        Me.pnlDescPatologia.Name = "pnlDescPatologia"
        Me.pnlDescPatologia.Size = New System.Drawing.Size(374, 2)
        Me.pnlDescPatologia.TabIndex = 109
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.lblNomPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.Location = New System.Drawing.Point(49, 120)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(266, 29)
        Me.lblNomPat.TabIndex = 105
        Me.lblNomPat.Text = "Nombre de la patologia"
        '
        'pnlNomPat
        '
        Me.pnlNomPat.BackColor = System.Drawing.Color.Black
        Me.pnlNomPat.Location = New System.Drawing.Point(49, 191)
        Me.pnlNomPat.Name = "pnlNomPat"
        Me.pnlNomPat.Size = New System.Drawing.Size(279, 2)
        Me.pnlNomPat.TabIndex = 106
        '
        'lblDescPat
        '
        Me.lblDescPat.AutoSize = True
        Me.lblDescPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPat.Location = New System.Drawing.Point(49, 258)
        Me.lblDescPat.Name = "lblDescPat"
        Me.lblDescPat.Size = New System.Drawing.Size(141, 29)
        Me.lblDescPat.TabIndex = 107
        Me.lblDescPat.Text = "Descripción"
        '
        'pnlTxtRecPat
        '
        Me.pnlTxtRecPat.BackColor = System.Drawing.Color.Black
        Me.pnlTxtRecPat.Location = New System.Drawing.Point(47, 555)
        Me.pnlTxtRecPat.Name = "pnlTxtRecPat"
        Me.pnlTxtRecPat.Size = New System.Drawing.Size(374, 2)
        Me.pnlTxtRecPat.TabIndex = 112
        '
        'lblRecPat
        '
        Me.lblRecPat.AutoSize = True
        Me.lblRecPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecPat.Location = New System.Drawing.Point(47, 422)
        Me.lblRecPat.Name = "lblRecPat"
        Me.lblRecPat.Size = New System.Drawing.Size(215, 29)
        Me.lblRecPat.TabIndex = 110
        Me.lblRecPat.Text = "Recomendaciones"
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(847, 181)
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
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(474, 181)
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
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(445, 111)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(277, 43)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(776, 111)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(312, 43)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.White
        Me.txtNomPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.Location = New System.Drawing.Point(49, 161)
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.Size = New System.Drawing.Size(279, 22)
        Me.txtNomPat.TabIndex = 119
        '
        'lblArrastreSintomas
        '
        Me.lblArrastreSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArrastreSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrastreSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblArrastreSintomas.Location = New System.Drawing.Point(694, 313)
        Me.lblArrastreSintomas.Name = "lblArrastreSintomas"
        Me.lblArrastreSintomas.Size = New System.Drawing.Size(147, 141)
        Me.lblArrastreSintomas.TabIndex = 120
        Me.lblArrastreSintomas.Text = "Arrastre Síntomas hacia la derecha"
        Me.lblArrastreSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescPat
        '
        Me.txtDescPat.BackColor = System.Drawing.Color.White
        Me.txtDescPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.Location = New System.Drawing.Point(49, 310)
        Me.txtDescPat.Multiline = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.Size = New System.Drawing.Size(372, 66)
        Me.txtDescPat.TabIndex = 121
        '
        'txtRecPat
        '
        Me.txtRecPat.BackColor = System.Drawing.Color.White
        Me.txtRecPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.Location = New System.Drawing.Point(47, 467)
        Me.txtRecPat.Multiline = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.Size = New System.Drawing.Size(372, 70)
        Me.txtRecPat.TabIndex = 122
        '
        'mrbtnRegistrarPat
        '
        Me.mrbtnRegistrarPat.AutoSize = True
        Me.mrbtnRegistrarPat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnRegistrarPat.Depth = 0
        Me.mrbtnRegistrarPat.Icon = Nothing
        Me.mrbtnRegistrarPat.Location = New System.Drawing.Point(481, 679)
        Me.mrbtnRegistrarPat.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnRegistrarPat.Name = "mrbtnRegistrarPat"
        Me.mrbtnRegistrarPat.Primary = True
        Me.mrbtnRegistrarPat.Size = New System.Drawing.Size(172, 36)
        Me.mrbtnRegistrarPat.TabIndex = 127
        Me.mrbtnRegistrarPat.Text = "Registrar patología"
        Me.mrbtnRegistrarPat.UseVisualStyleBackColor = True
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad.Location = New System.Drawing.Point(44, 582)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(112, 29)
        Me.lblPrioridad.TabIndex = 128
        Me.lblPrioridad.Text = "Prioridad"
        '
        'mrbPAlta
        '
        Me.mrbPAlta.AutoSize = True
        Me.mrbPAlta.Depth = 0
        Me.mrbPAlta.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPAlta.Location = New System.Drawing.Point(47, 629)
        Me.mrbPAlta.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPAlta.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPAlta.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPAlta.Name = "mrbPAlta"
        Me.mrbPAlta.Ripple = True
        Me.mrbPAlta.Size = New System.Drawing.Size(54, 30)
        Me.mrbPAlta.TabIndex = 129
        Me.mrbPAlta.TabStop = True
        Me.mrbPAlta.Text = "Alta"
        Me.mrbPAlta.UseVisualStyleBackColor = True
        '
        'mrbPBaja
        '
        Me.mrbPBaja.AutoSize = True
        Me.mrbPBaja.Depth = 0
        Me.mrbPBaja.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPBaja.Location = New System.Drawing.Point(47, 689)
        Me.mrbPBaja.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPBaja.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPBaja.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPBaja.Name = "mrbPBaja"
        Me.mrbPBaja.Ripple = True
        Me.mrbPBaja.Size = New System.Drawing.Size(56, 30)
        Me.mrbPBaja.TabIndex = 130
        Me.mrbPBaja.TabStop = True
        Me.mrbPBaja.Text = "Baja"
        Me.mrbPBaja.UseVisualStyleBackColor = True
        '
        'mrbPMedia
        '
        Me.mrbPMedia.AutoSize = True
        Me.mrbPMedia.Depth = 0
        Me.mrbPMedia.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPMedia.Location = New System.Drawing.Point(47, 659)
        Me.mrbPMedia.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPMedia.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPMedia.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPMedia.Name = "mrbPMedia"
        Me.mrbPMedia.Ripple = True
        Me.mrbPMedia.Size = New System.Drawing.Size(67, 30)
        Me.mrbPMedia.TabIndex = 131
        Me.mrbPMedia.TabStop = True
        Me.mrbPMedia.Text = "Media"
        Me.mrbPMedia.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlTituloPatologia)
        Me.pnlContenedor.Controls.Add(Me.lblNomPat)
        Me.pnlContenedor.Controls.Add(Me.txtNomPat)
        Me.pnlContenedor.Controls.Add(Me.pnlNomPat)
        Me.pnlContenedor.Controls.Add(Me.lblDescPat)
        Me.pnlContenedor.Controls.Add(Me.txtDescPat)
        Me.pnlContenedor.Controls.Add(Me.pnlDescPatologia)
        Me.pnlContenedor.Controls.Add(Me.lblRecPat)
        Me.pnlContenedor.Controls.Add(Me.txtRecPat)
        Me.pnlContenedor.Controls.Add(Me.pnlTxtRecPat)
        Me.pnlContenedor.Controls.Add(Me.lblPrioridad)
        Me.pnlContenedor.Controls.Add(Me.mrbPAlta)
        Me.pnlContenedor.Controls.Add(Me.mrbPMedia)
        Me.pnlContenedor.Controls.Add(Me.mrbPBaja)
        Me.pnlContenedor.Controls.Add(Me.mrbtnRegistrarPat)
        Me.pnlContenedor.Controls.Add(Me.lblSintomasSeleccionados)
        Me.pnlContenedor.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlContenedor.Controls.Add(Me.lblArrastreSintomas)
        Me.pnlContenedor.Controls.Add(Me.lblTodosLosSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvTodosLosSintomas)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1100, 747)
        Me.pnlContenedor.TabIndex = 132
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 747)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents pnlDescPatologia As Panel
    Friend WithEvents lblNomPat As Label
    Friend WithEvents pnlNomPat As Panel
    Friend WithEvents lblDescPat As Label
    Friend WithEvents pnlTxtRecPat As Panel
    Friend WithEvents lblRecPat As Label
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
    Friend WithEvents txtNomPat As TextBox
    Friend WithEvents lblArrastreSintomas As Label
    Friend WithEvents txtDescPat As TextBox
    Friend WithEvents txtRecPat As TextBox
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents mrbtnRegistrarPat As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents mrbPAlta As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbPBaja As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbPMedia As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblRegistrar As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents pnlContenedor As Panel
End Class
