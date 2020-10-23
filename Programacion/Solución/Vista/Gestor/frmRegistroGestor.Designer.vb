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
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtCI = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtCon = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.txtRepCon = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.txtPApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.txtSNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.txtSApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtMail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtTelefonos = New System.Windows.Forms.Label()
        Me.btnRegistrar = New Guna.UI.WinForms.GunaButton()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.btnEliminar = New Guna.UI.WinForms.GunaButton()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnImg = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.ForeColor = System.Drawing.Color.Silver
        Me.lblCI.Location = New System.Drawing.Point(31, 93)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(144, 20)
        Me.lblCI.TabIndex = 108
        Me.lblCI.Text = "Cédula de Identidad"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Silver
        Me.lblMail.Location = New System.Drawing.Point(727, 65)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(132, 20)
        Me.lblMail.TabIndex = 120
        Me.lblMail.Text = "Correo electrónico"
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCI.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCI.LineSize = 1
        Me.txtCI.Location = New System.Drawing.Point(35, 121)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCI.Size = New System.Drawing.Size(246, 32)
        Me.txtCI.TabIndex = 165
        '
        'txtCon
        '
        Me.txtCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCon.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCon.ForeColor = System.Drawing.Color.White
        Me.txtCon.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCon.LineSize = 1
        Me.txtCon.Location = New System.Drawing.Point(35, 232)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCon.Size = New System.Drawing.Size(246, 32)
        Me.txtCon.TabIndex = 166
        Me.txtCon.UseSystemPasswordChar = True
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.ForeColor = System.Drawing.Color.Silver
        Me.lblCon.Location = New System.Drawing.Point(31, 203)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(83, 20)
        Me.lblCon.TabIndex = 167
        Me.lblCon.Text = "Contraseña"
        '
        'txtRepCon
        '
        Me.txtRepCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRepCon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepCon.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepCon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepCon.ForeColor = System.Drawing.Color.White
        Me.txtRepCon.LineColor = System.Drawing.Color.Gainsboro
        Me.txtRepCon.LineSize = 1
        Me.txtRepCon.Location = New System.Drawing.Point(35, 371)
        Me.txtRepCon.Name = "txtRepCon"
        Me.txtRepCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepCon.Size = New System.Drawing.Size(246, 32)
        Me.txtRepCon.TabIndex = 168
        Me.txtRepCon.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(31, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Repetir contraseña"
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApe.ForeColor = System.Drawing.Color.Silver
        Me.lblPApe.Location = New System.Drawing.Point(407, 279)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(111, 20)
        Me.lblPApe.TabIndex = 175
        Me.lblPApe.Text = "Primer apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.White
        Me.txtPApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPApe.LineSize = 1
        Me.txtPApe.Location = New System.Drawing.Point(411, 319)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPApe.Size = New System.Drawing.Size(246, 32)
        Me.txtPApe.TabIndex = 174
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNom.ForeColor = System.Drawing.Color.Silver
        Me.lblSNom.Location = New System.Drawing.Point(407, 159)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(124, 20)
        Me.lblSNom.TabIndex = 173
        Me.lblSNom.Text = "Segundo nombre"
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.ForeColor = System.Drawing.Color.White
        Me.txtSNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSNom.LineSize = 1
        Me.txtSNom.Location = New System.Drawing.Point(411, 194)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNom.Size = New System.Drawing.Size(246, 32)
        Me.txtSNom.TabIndex = 172
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.White
        Me.txtPNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPNom.LineSize = 1
        Me.txtPNom.Location = New System.Drawing.Point(411, 93)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.Size = New System.Drawing.Size(246, 32)
        Me.txtPNom.TabIndex = 171
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.ForeColor = System.Drawing.Color.Silver
        Me.lblPNom.Location = New System.Drawing.Point(407, 65)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(108, 20)
        Me.lblPNom.TabIndex = 170
        Me.lblPNom.Text = "Primer nombre"
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApe.ForeColor = System.Drawing.Color.Silver
        Me.lblSApe.Location = New System.Drawing.Point(407, 378)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(127, 20)
        Me.lblSApe.TabIndex = 177
        Me.lblSApe.Text = "Segundo apellido"
        '
        'txtSApe
        '
        Me.txtSApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApe.ForeColor = System.Drawing.Color.White
        Me.txtSApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSApe.LineSize = 1
        Me.txtSApe.Location = New System.Drawing.Point(411, 417)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSApe.Size = New System.Drawing.Size(246, 32)
        Me.txtSApe.TabIndex = 176
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.White
        Me.txtMail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMail.LineSize = 1
        Me.txtMail.Location = New System.Drawing.Point(731, 93)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.Size = New System.Drawing.Size(246, 32)
        Me.txtMail.TabIndex = 178
        '
        'txtTelefonos
        '
        Me.txtTelefonos.AutoSize = True
        Me.txtTelefonos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonos.ForeColor = System.Drawing.Color.Silver
        Me.txtTelefonos.Location = New System.Drawing.Point(786, 177)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(73, 20)
        Me.txtTelefonos.TabIndex = 179
        Me.txtTelefonos.Text = "Teléfonos"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Animated = True
        Me.btnRegistrar.AnimationHoverSpeed = 0.07!
        Me.btnRegistrar.AnimationSpeed = 0.03!
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Image = Nothing
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrar.Location = New System.Drawing.Point(436, 568)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrar.OnHoverImage = Nothing
        Me.btnRegistrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrar.Radius = 10
        Me.btnRegistrar.Size = New System.Drawing.Size(199, 42)
        Me.btnRegistrar.TabIndex = 180
        Me.btnRegistrar.Text = "Registrarme"
        Me.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        Me.dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.Location = New System.Drawing.Point(719, 220)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(194, 111)
        Me.dgvTelefonos.TabIndex = 159
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
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Nothing
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(931, 289)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(96, 42)
        Me.btnAceptar.TabIndex = 181
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Nothing
        Me.btnEliminar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminar.Location = New System.Drawing.Point(931, 220)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminar.OnHoverImage = Nothing
        Me.btnEliminar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminar.Radius = 10
        Me.btnEliminar.Size = New System.Drawing.Size(96, 42)
        Me.btnEliminar.TabIndex = 182
        Me.btnEliminar.Text = "Borrar"
        Me.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(1024, 489)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(10, 107)
        Me.scroll.TabIndex = 188
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 191
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaPictureBox1.Location = New System.Drawing.Point(790, 378)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Radius = 30
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 194
        Me.GunaPictureBox1.TabStop = False
        '
        'btnImg
        '
        Me.btnImg.Animated = True
        Me.btnImg.AnimationHoverSpeed = 0.07!
        Me.btnImg.AnimationSpeed = 0.03!
        Me.btnImg.BackColor = System.Drawing.Color.Transparent
        Me.btnImg.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnImg.BorderColor = System.Drawing.Color.Black
        Me.btnImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImg.FocusedColor = System.Drawing.Color.Empty
        Me.btnImg.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImg.ForeColor = System.Drawing.Color.White
        Me.btnImg.Image = Nothing
        Me.btnImg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImg.Location = New System.Drawing.Point(822, 504)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnImg.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImg.OnHoverImage = Nothing
        Me.btnImg.OnPressedColor = System.Drawing.Color.Black
        Me.btnImg.Radius = 10
        Me.btnImg.Size = New System.Drawing.Size(58, 32)
        Me.btnImg.TabIndex = 195
        Me.btnImg.Text = "+"
        Me.btnImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(818, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Mi foto"
        '
        'frmRegistroGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.scroll)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.dgvTelefonos)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.txtSApe)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.lblSNom)
        Me.Controls.Add(Me.txtSNom)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRepCon)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.lblMail)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarGestor"
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCI As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents txtCI As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtCon As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCon As Label
    Friend WithEvents txtRepCon As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPApe As Label
    Friend WithEvents txtPApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblSNom As Label
    Friend WithEvents txtSNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPNom As Label
    Friend WithEvents lblSApe As Label
    Friend WithEvents txtSApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtMail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtTelefonos As Label
    Friend WithEvents btnRegistrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEliminar As Guna.UI.WinForms.GunaButton
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnImg As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
End Class
