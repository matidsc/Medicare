<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresarSintomas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIngreseSIntomas = New System.Windows.Forms.Label()
        Me.lblArrastreSintomas = New System.Windows.Forms.Label()
        Me.lblMisSintomas = New System.Windows.Forms.Label()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.MISintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodos = New System.Windows.Forms.DataGridView()
        Me.SintomaTodos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.scrollSeleccionados = New Guna.UI.WinForms.GunaVScrollBar()
        Me.scrollTodos = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnObtenerDiag = New Guna.UI.WinForms.GunaButton()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIngreseSIntomas
        '
        Me.lblIngreseSIntomas.BackColor = System.Drawing.Color.Transparent
        Me.lblIngreseSIntomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIngreseSIntomas.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSIntomas.ForeColor = System.Drawing.Color.White
        Me.lblIngreseSIntomas.Location = New System.Drawing.Point(345, 32)
        Me.lblIngreseSIntomas.Name = "lblIngreseSIntomas"
        Me.lblIngreseSIntomas.Size = New System.Drawing.Size(381, 45)
        Me.lblIngreseSIntomas.TabIndex = 25
        Me.lblIngreseSIntomas.Text = "¿Cuáles son tus síntomas?"
        Me.lblIngreseSIntomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArrastreSintomas
        '
        Me.lblArrastreSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArrastreSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrastreSintomas.ForeColor = System.Drawing.Color.White
        Me.lblArrastreSintomas.Location = New System.Drawing.Point(459, 238)
        Me.lblArrastreSintomas.Name = "lblArrastreSintomas"
        Me.lblArrastreSintomas.Size = New System.Drawing.Size(152, 152)
        Me.lblArrastreSintomas.TabIndex = 82
        Me.lblArrastreSintomas.Text = "Arrastre síntomas hacia la derecha "
        Me.lblArrastreSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMisSintomas
        '
        Me.lblMisSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMisSintomas.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMisSintomas.ForeColor = System.Drawing.Color.White
        Me.lblMisSintomas.Location = New System.Drawing.Point(804, 92)
        Me.lblMisSintomas.Name = "lblMisSintomas"
        Me.lblMisSintomas.Size = New System.Drawing.Size(177, 37)
        Me.lblMisSintomas.TabIndex = 85
        Me.lblMisSintomas.Text = "Mis síntomas"
        Me.lblMisSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
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
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MISintoma})
        Me.dgvSintomasSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(774, 142)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(239, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 159
        '
        'MISintoma
        '
        Me.MISintoma.HeaderText = "Column1"
        Me.MISintoma.MinimumWidth = 6
        Me.MISintoma.Name = "MISintoma"
        Me.MISintoma.ReadOnly = True
        '
        'dgvTodos
        '
        Me.dgvTodos.AllowDrop = True
        Me.dgvTodos.AllowUserToAddRows = False
        Me.dgvTodos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvTodos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvTodos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.ColumnHeadersVisible = False
        Me.dgvTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SintomaTodos})
        Me.dgvTodos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTodos.Location = New System.Drawing.Point(73, 139)
        Me.dgvTodos.MultiSelect = False
        Me.dgvTodos.Name = "dgvTodos"
        Me.dgvTodos.ReadOnly = True
        Me.dgvTodos.RowHeadersVisible = False
        Me.dgvTodos.RowHeadersWidth = 51
        Me.dgvTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodos.Size = New System.Drawing.Size(249, 430)
        Me.dgvTodos.TabIndex = 158
        '
        'SintomaTodos
        '
        Me.SintomaTodos.HeaderText = "Column1"
        Me.SintomaTodos.MinimumWidth = 6
        Me.SintomaTodos.Name = "SintomaTodos"
        Me.SintomaTodos.ReadOnly = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.GunaElipsePanel2)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.scrollSeleccionados)
        Me.pnlContenedor.Controls.Add(Me.scrollTodos)
        Me.pnlContenedor.Controls.Add(Me.btnObtenerDiag)
        Me.pnlContenedor.Controls.Add(Me.lblIngreseSIntomas)
        Me.pnlContenedor.Controls.Add(Me.lblMisSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvTodos)
        Me.pnlContenedor.Controls.Add(Me.lblArrastreSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 635)
        Me.pnlContenedor.TabIndex = 160
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(337, 87)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 2
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(397, 2)
        Me.GunaElipsePanel2.TabIndex = 163
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.White
        Me.btnAtras.IconSize = 32
        Me.btnAtras.Location = New System.Drawing.Point(39, 32)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(33, 30)
        Me.btnAtras.TabIndex = 165
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'scrollSeleccionados
        '
        Me.scrollSeleccionados.LargeChange = 10
        Me.scrollSeleccionados.Location = New System.Drawing.Point(1003, 143)
        Me.scrollSeleccionados.Maximum = 100
        Me.scrollSeleccionados.Name = "scrollSeleccionados"
        Me.scrollSeleccionados.ScrollIdleColor = System.Drawing.Color.Silver
        Me.scrollSeleccionados.Size = New System.Drawing.Size(10, 429)
        Me.scrollSeleccionados.TabIndex = 164
        Me.scrollSeleccionados.ThumbColor = System.Drawing.Color.DimGray
        Me.scrollSeleccionados.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scrollSeleccionados.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'scrollTodos
        '
        Me.scrollTodos.LargeChange = 10
        Me.scrollTodos.Location = New System.Drawing.Point(312, 139)
        Me.scrollTodos.Maximum = 100
        Me.scrollTodos.Name = "scrollTodos"
        Me.scrollTodos.ScrollIdleColor = System.Drawing.Color.Silver
        Me.scrollTodos.Size = New System.Drawing.Size(10, 429)
        Me.scrollTodos.TabIndex = 163
        Me.scrollTodos.ThumbColor = System.Drawing.Color.DimGray
        Me.scrollTodos.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scrollTodos.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'btnObtenerDiag
        '
        Me.btnObtenerDiag.AnimationHoverSpeed = 0.07!
        Me.btnObtenerDiag.AnimationSpeed = 0.03!
        Me.btnObtenerDiag.BackColor = System.Drawing.Color.Transparent
        Me.btnObtenerDiag.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnObtenerDiag.BorderColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnObtenerDiag.FocusedColor = System.Drawing.Color.Empty
        Me.btnObtenerDiag.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerDiag.ForeColor = System.Drawing.Color.White
        Me.btnObtenerDiag.Image = Nothing
        Me.btnObtenerDiag.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnObtenerDiag.Location = New System.Drawing.Point(420, 523)
        Me.btnObtenerDiag.Name = "btnObtenerDiag"
        Me.btnObtenerDiag.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnObtenerDiag.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.OnHoverForeColor = System.Drawing.Color.White
        Me.btnObtenerDiag.OnHoverImage = Nothing
        Me.btnObtenerDiag.OnPressedColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.Radius = 24
        Me.btnObtenerDiag.Size = New System.Drawing.Size(231, 49)
        Me.btnObtenerDiag.TabIndex = 161
        Me.btnObtenerDiag.Text = "Obtener diagnósitco primario"
        Me.btnObtenerDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 635)
        Me.pnlInstancia.TabIndex = 160
        '
        'frmIngresarSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 635)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIngresarSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblArrastreSintomas As Label
    Friend WithEvents lblMisSintomas As Label
    Friend WithEvents lblIngreseSIntomas As Label
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents MISintoma As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodos As DataGridView
    Friend WithEvents SintomaTodos As DataGridViewTextBoxColumn
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents btnObtenerDiag As Guna.UI.WinForms.GunaButton
    Friend WithEvents scrollSeleccionados As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scrollTodos As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
End Class
