<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListado
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrar = New Guna.UI.WinForms.GunaButton()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.lblCantSelecc = New System.Windows.Forms.Label()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.btnEliminarElementos = New Guna.UI.WinForms.GunaButton()
        Me.btnModificarElemento = New Guna.UI.WinForms.GunaButton()
        Me.btnSeleccionMultiple = New Guna.UI.WinForms.GunaButton()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.UcAsociar1 = New Vista.UCAsociar()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.lblBuscar)
        Me.pnlContenedor.Controls.Add(Me.PictureBox1)
        Me.pnlContenedor.Controls.Add(Me.GunaTextBox2)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.btnRegistrar)
        Me.pnlContenedor.Controls.Add(Me.scroll)
        Me.pnlContenedor.Controls.Add(Me.dgvListado)
        Me.pnlContenedor.Controls.Add(Me.lblCantSelecc)
        Me.pnlContenedor.Controls.Add(Me.GunaButton4)
        Me.pnlContenedor.Controls.Add(Me.btnEliminarElementos)
        Me.pnlContenedor.Controls.Add(Me.btnModificarElemento)
        Me.pnlContenedor.Controls.Add(Me.btnSeleccionMultiple)
        Me.pnlContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 156
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.Silver
        Me.lblBuscar.Location = New System.Drawing.Point(259, 32)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(46, 17)
        Me.lblBuscar.TabIndex = 191
        Me.lblBuscar.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.buscar
        Me.PictureBox1.Location = New System.Drawing.Point(218, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.DarkSlateBlue
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Location = New System.Drawing.Point(202, 21)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Radius = 17
        Me.GunaTextBox2.Size = New System.Drawing.Size(659, 38)
        Me.GunaTextBox2.TabIndex = 173
        Me.GunaTextBox2.TextOffsetX = 50
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
        Me.btnAtras.TabIndex = 190
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AnimationHoverSpeed = 0.07!
        Me.btnRegistrar.AnimationSpeed = 0.03!
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRegistrar.Image = Nothing
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrar.Location = New System.Drawing.Point(380, 602)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrar.OnHoverImage = Nothing
        Me.btnRegistrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrar.Radius = 8
        Me.btnRegistrar.Size = New System.Drawing.Size(311, 36)
        Me.btnRegistrar.TabIndex = 189
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRegistrar.Visible = False
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(1053, 80)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 187
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'dgvListado
        '
        Me.dgvListado.AllowDrop = True
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.ColumnHeadersVisible = False
        Me.dgvListado.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListado.Location = New System.Drawing.Point(22, 157)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.RowHeadersVisible = False
        Me.dgvListado.RowHeadersWidth = 51
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(1025, 430)
        Me.dgvListado.TabIndex = 186
        '
        'lblCantSelecc
        '
        Me.lblCantSelecc.AutoSize = True
        Me.lblCantSelecc.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantSelecc.ForeColor = System.Drawing.Color.White
        Me.lblCantSelecc.Location = New System.Drawing.Point(957, 27)
        Me.lblCantSelecc.Name = "lblCantSelecc"
        Me.lblCantSelecc.Size = New System.Drawing.Size(28, 32)
        Me.lblCantSelecc.TabIndex = 184
        Me.lblCantSelecc.Text = "0"
        Me.lblCantSelecc.Visible = False
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(56, 91)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 10
        Me.GunaButton4.Size = New System.Drawing.Size(73, 41)
        Me.GunaButton4.TabIndex = 183
        Me.GunaButton4.Text = "FILTRAR"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEliminarElementos
        '
        Me.btnEliminarElementos.AnimationHoverSpeed = 0.07!
        Me.btnEliminarElementos.AnimationSpeed = 0.03!
        Me.btnEliminarElementos.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarElementos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnEliminarElementos.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarElementos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminarElementos.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminarElementos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarElementos.ForeColor = System.Drawing.Color.White
        Me.btnEliminarElementos.Image = Nothing
        Me.btnEliminarElementos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminarElementos.Location = New System.Drawing.Point(751, 91)
        Me.btnEliminarElementos.Name = "btnEliminarElementos"
        Me.btnEliminarElementos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEliminarElementos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminarElementos.OnHoverImage = Nothing
        Me.btnEliminarElementos.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.Radius = 10
        Me.btnEliminarElementos.Size = New System.Drawing.Size(256, 41)
        Me.btnEliminarElementos.TabIndex = 182
        Me.btnEliminarElementos.Text = "ELIMINAR ELEMENTO SELECCIONADO"
        Me.btnEliminarElementos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModificarElemento
        '
        Me.btnModificarElemento.AnimationHoverSpeed = 0.07!
        Me.btnModificarElemento.AnimationSpeed = 0.03!
        Me.btnModificarElemento.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarElemento.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnModificarElemento.BorderColor = System.Drawing.Color.Black
        Me.btnModificarElemento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarElemento.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnModificarElemento.FocusedColor = System.Drawing.Color.Empty
        Me.btnModificarElemento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarElemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnModificarElemento.Image = Nothing
        Me.btnModificarElemento.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnModificarElemento.Location = New System.Drawing.Point(436, 91)
        Me.btnModificarElemento.Name = "btnModificarElemento"
        Me.btnModificarElemento.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnModificarElemento.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnModificarElemento.OnHoverForeColor = System.Drawing.Color.White
        Me.btnModificarElemento.OnHoverImage = Nothing
        Me.btnModificarElemento.OnPressedColor = System.Drawing.Color.Black
        Me.btnModificarElemento.Radius = 10
        Me.btnModificarElemento.Size = New System.Drawing.Size(276, 41)
        Me.btnModificarElemento.TabIndex = 181
        Me.btnModificarElemento.Text = "MODIFICAR ELEMENTO SELECCIONADO"
        Me.btnModificarElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSeleccionMultiple
        '
        Me.btnSeleccionMultiple.AnimationHoverSpeed = 0.07!
        Me.btnSeleccionMultiple.AnimationSpeed = 0.03!
        Me.btnSeleccionMultiple.BackColor = System.Drawing.Color.Transparent
        Me.btnSeleccionMultiple.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSeleccionMultiple.BorderColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionMultiple.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSeleccionMultiple.FocusedColor = System.Drawing.Color.Empty
        Me.btnSeleccionMultiple.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionMultiple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSeleccionMultiple.Image = Nothing
        Me.btnSeleccionMultiple.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSeleccionMultiple.Location = New System.Drawing.Point(160, 91)
        Me.btnSeleccionMultiple.Name = "btnSeleccionMultiple"
        Me.btnSeleccionMultiple.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnSeleccionMultiple.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSeleccionMultiple.OnHoverImage = Nothing
        Me.btnSeleccionMultiple.OnPressedColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.Radius = 10
        Me.btnSeleccionMultiple.Size = New System.Drawing.Size(244, 41)
        Me.btnSeleccionMultiple.TabIndex = 180
        Me.btnSeleccionMultiple.Text = "ACTIVAR SELECCIÓN MÚLTIPLE"
        Me.btnSeleccionMultiple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 192
        '
        'UcAsociar1
        '
        Me.UcAsociar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UcAsociar1.Location = New System.Drawing.Point(0, 0)
        Me.UcAsociar1.Name = "UcAsociar1"
        Me.UcAsociar1.Size = New System.Drawing.Size(1070, 650)
        Me.UcAsociar1.TabIndex = 192
        Me.UcAsociar1.Visible = False
        '
        'frmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.UcAsociar1)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoPatologias"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCantSelecc As Label
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEliminarElementos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnModificarElemento As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSeleccionMultiple As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents btnRegistrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblBuscar As Label
    Friend WithEvents UcAsociar1 As UCAsociar
    Friend WithEvents pnlInstancia As Panel
End Class
