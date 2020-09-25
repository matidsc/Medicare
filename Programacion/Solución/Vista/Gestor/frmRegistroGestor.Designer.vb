<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroGestor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlDecCI = New System.Windows.Forms.Panel()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblCrearCuentaDe = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.pnlDecPNom = New System.Windows.Forms.Panel()
        Me.txtPNom = New System.Windows.Forms.TextBox()
        Me.pnlDecSApe = New System.Windows.Forms.Panel()
        Me.pnlDecPApe = New System.Windows.Forms.Panel()
        Me.pnlDecSNom = New System.Windows.Forms.Panel()
        Me.txtSApe = New System.Windows.Forms.TextBox()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.txtSNom = New System.Windows.Forms.TextBox()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.pnlDecMail = New System.Windows.Forms.Panel()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.pnlDecCon = New System.Windows.Forms.Panel()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.pnlDecRepCon = New System.Windows.Forms.Panel()
        Me.lblRepCon = New System.Windows.Forms.Label()
        Me.btnRegistrarGestor = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlDecTelefonos = New System.Windows.Forms.Panel()
        Me.lblTxtAgregarTelefonos = New System.Windows.Forms.Label()
        Me.pnlTelefonos = New System.Windows.Forms.Panel()
        Me.btnAceptar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRepCon = New System.Windows.Forms.TextBox()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlTelefonos.SuspendLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDecCI
        '
        Me.pnlDecCI.BackColor = System.Drawing.Color.Black
        Me.pnlDecCI.Location = New System.Drawing.Point(148, 173)
        Me.pnlDecCI.Name = "pnlDecCI"
        Me.pnlDecCI.Size = New System.Drawing.Size(176, 2)
        Me.pnlDecCI.TabIndex = 110
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.White
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.Location = New System.Drawing.Point(148, 143)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(172, 22)
        Me.txtCI.TabIndex = 109
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btnAtras)
        Me.pnlTitulo.Controls.Add(Me.lblCrearCuentaDe)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1019, 77)
        Me.pnlTitulo.TabIndex = 111
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icoFlechaAtrasWhite
        Me.btnAtras.Location = New System.Drawing.Point(24, 27)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 30
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblCrearCuentaDe
        '
        Me.lblCrearCuentaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCrearCuentaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuentaDe.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuentaDe.Location = New System.Drawing.Point(299, 9)
        Me.lblCrearCuentaDe.Name = "lblCrearCuentaDe"
        Me.lblCrearCuentaDe.Size = New System.Drawing.Size(424, 57)
        Me.lblCrearCuentaDe.TabIndex = 4
        Me.lblCrearCuentaDe.Text = "CREAR CUENTA DE GESTOR"
        Me.lblCrearCuentaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(125, 109)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(204, 25)
        Me.lblCI.TabIndex = 108
        Me.lblCI.Text = "Cédula de Identidad"
        '
        'pnlDecPNom
        '
        Me.pnlDecPNom.BackColor = System.Drawing.Color.Black
        Me.pnlDecPNom.Location = New System.Drawing.Point(12, 332)
        Me.pnlDecPNom.Name = "pnlDecPNom"
        Me.pnlDecPNom.Size = New System.Drawing.Size(218, 2)
        Me.pnlDecPNom.TabIndex = 107
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.White
        Me.txtPNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.Location = New System.Drawing.Point(12, 304)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.Size = New System.Drawing.Size(214, 22)
        Me.txtPNom.TabIndex = 112
        '
        'pnlDecSApe
        '
        Me.pnlDecSApe.BackColor = System.Drawing.Color.Black
        Me.pnlDecSApe.Location = New System.Drawing.Point(771, 329)
        Me.pnlDecSApe.Name = "pnlDecSApe"
        Me.pnlDecSApe.Size = New System.Drawing.Size(218, 2)
        Me.pnlDecSApe.TabIndex = 105
        '
        'pnlDecPApe
        '
        Me.pnlDecPApe.BackColor = System.Drawing.Color.Black
        Me.pnlDecPApe.Location = New System.Drawing.Point(505, 332)
        Me.pnlDecPApe.Name = "pnlDecPApe"
        Me.pnlDecPApe.Size = New System.Drawing.Size(218, 2)
        Me.pnlDecPApe.TabIndex = 104
        '
        'pnlDecSNom
        '
        Me.pnlDecSNom.BackColor = System.Drawing.Color.Black
        Me.pnlDecSNom.Location = New System.Drawing.Point(256, 332)
        Me.pnlDecSNom.Name = "pnlDecSNom"
        Me.pnlDecSNom.Size = New System.Drawing.Size(218, 2)
        Me.pnlDecSNom.TabIndex = 103
        '
        'txtSApe
        '
        Me.txtSApe.BackColor = System.Drawing.Color.White
        Me.txtSApe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApe.Location = New System.Drawing.Point(771, 299)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.Size = New System.Drawing.Size(214, 22)
        Me.txtSApe.TabIndex = 115
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApe.Location = New System.Drawing.Point(785, 259)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(181, 25)
        Me.lblSApe.TabIndex = 102
        Me.lblSApe.Text = "Segundo Apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.White
        Me.txtPApe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.Location = New System.Drawing.Point(509, 302)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(214, 22)
        Me.txtPApe.TabIndex = 114
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApe.Location = New System.Drawing.Point(546, 266)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(157, 25)
        Me.lblPApe.TabIndex = 101
        Me.lblPApe.Text = "Primer Apellido"
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.White
        Me.txtSNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.Location = New System.Drawing.Point(256, 302)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.Size = New System.Drawing.Size(218, 22)
        Me.txtSNom.TabIndex = 113
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNom.Location = New System.Drawing.Point(279, 261)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(179, 25)
        Me.lblSNom.TabIndex = 99
        Me.lblSNom.Text = "Segundo Nombre"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.Location = New System.Drawing.Point(40, 262)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(155, 25)
        Me.lblPNom.TabIndex = 96
        Me.lblPNom.Text = "Primer Nombre"
        '
        'pnlDecMail
        '
        Me.pnlDecMail.BackColor = System.Drawing.Color.Black
        Me.pnlDecMail.Location = New System.Drawing.Point(577, 449)
        Me.pnlDecMail.Name = "pnlDecMail"
        Me.pnlDecMail.Size = New System.Drawing.Size(218, 2)
        Me.pnlDecMail.TabIndex = 121
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.White
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(574, 419)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(223, 22)
        Me.txtMail.TabIndex = 116
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(651, 378)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(70, 25)
        Me.lblMail.TabIndex = 120
        Me.lblMail.Text = "e-mail"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.Location = New System.Drawing.Point(323, 373)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(107, 25)
        Me.lblTelefonos.TabIndex = 118
        Me.lblTelefonos.Text = "Teléfonos"
        '
        'pnlDecCon
        '
        Me.pnlDecCon.BackColor = System.Drawing.Color.Black
        Me.pnlDecCon.Location = New System.Drawing.Point(418, 173)
        Me.pnlDecCon.Name = "pnlDecCon"
        Me.pnlDecCon.Size = New System.Drawing.Size(176, 2)
        Me.pnlDecCon.TabIndex = 113
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.Location = New System.Drawing.Point(438, 109)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(123, 25)
        Me.lblCon.TabIndex = 111
        Me.lblCon.Text = "Contraseña"
        '
        'pnlDecRepCon
        '
        Me.pnlDecRepCon.BackColor = System.Drawing.Color.Black
        Me.pnlDecRepCon.Location = New System.Drawing.Point(665, 173)
        Me.pnlDecRepCon.Name = "pnlDecRepCon"
        Me.pnlDecRepCon.Size = New System.Drawing.Size(176, 2)
        Me.pnlDecRepCon.TabIndex = 116
        '
        'lblRepCon
        '
        Me.lblRepCon.AutoSize = True
        Me.lblRepCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepCon.Location = New System.Drawing.Point(652, 109)
        Me.lblRepCon.Name = "lblRepCon"
        Me.lblRepCon.Size = New System.Drawing.Size(198, 25)
        Me.lblRepCon.TabIndex = 114
        Me.lblRepCon.Text = "Repetir Contraseña"
        '
        'btnRegistrarGestor
        '
        Me.btnRegistrarGestor.AutoSize = True
        Me.btnRegistrarGestor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrarGestor.Depth = 0
        Me.btnRegistrarGestor.Icon = Nothing
        Me.btnRegistrarGestor.Location = New System.Drawing.Point(443, 606)
        Me.btnRegistrarGestor.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegistrarGestor.Name = "btnRegistrarGestor"
        Me.btnRegistrarGestor.Primary = True
        Me.btnRegistrarGestor.Size = New System.Drawing.Size(149, 36)
        Me.btnRegistrarGestor.TabIndex = 126
        Me.btnRegistrarGestor.Text = "registrar gestor"
        Me.btnRegistrarGestor.UseVisualStyleBackColor = True
        '
        'pnlDecTelefonos
        '
        Me.pnlDecTelefonos.BackColor = System.Drawing.Color.Black
        Me.pnlDecTelefonos.Location = New System.Drawing.Point(256, 454)
        Me.pnlDecTelefonos.Name = "pnlDecTelefonos"
        Me.pnlDecTelefonos.Size = New System.Drawing.Size(230, 2)
        Me.pnlDecTelefonos.TabIndex = 131
        '
        'lblTxtAgregarTelefonos
        '
        Me.lblTxtAgregarTelefonos.AutoSize = True
        Me.lblTxtAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTxtAgregarTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtAgregarTelefonos.Location = New System.Drawing.Point(288, 419)
        Me.lblTxtAgregarTelefonos.Name = "lblTxtAgregarTelefonos"
        Me.lblTxtAgregarTelefonos.Size = New System.Drawing.Size(182, 25)
        Me.lblTxtAgregarTelefonos.TabIndex = 164
        Me.lblTxtAgregarTelefonos.Text = "Agregar teléfonos"
        '
        'pnlTelefonos
        '
        Me.pnlTelefonos.BackColor = System.Drawing.SystemColors.Window
        Me.pnlTelefonos.Controls.Add(Me.btnAceptar)
        Me.pnlTelefonos.Controls.Add(Me.btnEliminar)
        Me.pnlTelefonos.Controls.Add(Me.dgvTelefonos)
        Me.pnlTelefonos.Location = New System.Drawing.Point(223, 462)
        Me.pnlTelefonos.Name = "pnlTelefonos"
        Me.pnlTelefonos.Size = New System.Drawing.Size(300, 128)
        Me.pnlTelefonos.TabIndex = 163
        Me.pnlTelefonos.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAceptar.Depth = 0
        Me.btnAceptar.Icon = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(212, 62)
        Me.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Primary = True
        Me.btnAceptar.Size = New System.Drawing.Size(82, 36)
        Me.btnAceptar.TabIndex = 162
        Me.btnAceptar.Text = "aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Icon = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(212, 20)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Primary = True
        Me.btnEliminar.Size = New System.Drawing.Size(83, 36)
        Me.btnEliminar.TabIndex = 161
        Me.btnEliminar.Text = "eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvTelefonos
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.White
        Me.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTelefonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.ColumnHeadersVisible = False
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefonos})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.Location = New System.Drawing.Point(12, 3)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(194, 111)
        Me.dgvTelefonos.TabIndex = 159
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'txtRepCon
        '
        Me.txtRepCon.BackColor = System.Drawing.Color.White
        Me.txtRepCon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRepCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepCon.Location = New System.Drawing.Point(656, 143)
        Me.txtRepCon.Name = "txtRepCon"
        Me.txtRepCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepCon.Size = New System.Drawing.Size(181, 22)
        Me.txtRepCon.TabIndex = 111
        '
        'txtCon
        '
        Me.txtCon.BackColor = System.Drawing.Color.White
        Me.txtCon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCon.Location = New System.Drawing.Point(418, 143)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCon.Size = New System.Drawing.Size(176, 22)
        Me.txtCon.TabIndex = 110
        '
        'frmRegistroGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 669)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.pnlDecCI)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.pnlDecCon)
        Me.Controls.Add(Me.lblRepCon)
        Me.Controls.Add(Me.txtRepCon)
        Me.Controls.Add(Me.pnlDecRepCon)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.pnlDecPNom)
        Me.Controls.Add(Me.lblSNom)
        Me.Controls.Add(Me.txtSNom)
        Me.Controls.Add(Me.pnlDecSNom)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.pnlDecPApe)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.txtSApe)
        Me.Controls.Add(Me.pnlDecSApe)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblTxtAgregarTelefonos)
        Me.Controls.Add(Me.pnlDecTelefonos)
        Me.Controls.Add(Me.pnlTelefonos)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.pnlDecMail)
        Me.Controls.Add(Me.btnRegistrarGestor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarGestor"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTelefonos.ResumeLayout(False)
        Me.pnlTelefonos.PerformLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlDecCI As Panel
    Friend WithEvents txtCI As TextBox
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblCrearCuentaDe As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents pnlDecPNom As Panel
    Friend WithEvents txtPNom As TextBox
    Friend WithEvents pnlDecSApe As Panel
    Friend WithEvents pnlDecPApe As Panel
    Friend WithEvents pnlDecSNom As Panel
    Friend WithEvents txtSApe As TextBox
    Friend WithEvents lblSApe As Label
    Friend WithEvents txtPApe As TextBox
    Friend WithEvents lblPApe As Label
    Friend WithEvents txtSNom As TextBox
    Friend WithEvents lblSNom As Label
    Friend WithEvents lblPNom As Label
    Friend WithEvents pnlDecMail As Panel
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents pnlDecCon As Panel
    Friend WithEvents lblCon As Label
    Friend WithEvents pnlDecRepCon As Panel
    Friend WithEvents lblRepCon As Label
    Friend WithEvents btnRegistrarGestor As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlDecTelefonos As Panel
    Friend WithEvents lblTxtAgregarTelefonos As Label
    Friend WithEvents pnlTelefonos As Panel
    Friend WithEvents btnAceptar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents txtRepCon As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents btnAtras As Button
End Class
