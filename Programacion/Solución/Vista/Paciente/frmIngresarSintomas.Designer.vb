﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIngreseSIntomas = New System.Windows.Forms.Label()
        Me.lblArrastreSintomas = New System.Windows.Forms.Label()
        Me.lblMisSintomas = New System.Windows.Forms.Label()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.MISintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodos = New System.Windows.Forms.DataGridView()
        Me.SintomaTodos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.scrollSeleccionados = New Guna.UI.WinForms.GunaVScrollBar()
        Me.scrollTodos = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
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
        Me.lblIngreseSIntomas.Location = New System.Drawing.Point(345, 45)
        Me.lblIngreseSIntomas.Name = "lblIngreseSIntomas"
        Me.lblIngreseSIntomas.Size = New System.Drawing.Size(381, 45)
        Me.lblIngreseSIntomas.TabIndex = 25
        Me.lblIngreseSIntomas.Text = "¿Cuáles son tus síntomas?"
        Me.lblIngreseSIntomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArrastreSintomas
        '
        Me.lblArrastreSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArrastreSintomas.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrastreSintomas.ForeColor = System.Drawing.Color.White
        Me.lblArrastreSintomas.Location = New System.Drawing.Point(459, 238)
        Me.lblArrastreSintomas.Name = "lblArrastreSintomas"
        Me.lblArrastreSintomas.Size = New System.Drawing.Size(152, 185)
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MISintoma})
        Me.dgvSintomasSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvTodos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvTodos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.ColumnHeadersVisible = False
        Me.dgvTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SintomaTodos})
        Me.dgvTodos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodos.DefaultCellStyle = DataGridViewCellStyle12
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
        Me.pnlContenedor.Controls.Add(Me.scrollSeleccionados)
        Me.pnlContenedor.Controls.Add(Me.scrollTodos)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.btnObtenerDiag)
        Me.pnlContenedor.Controls.Add(Me.lblIngreseSIntomas)
        Me.pnlContenedor.Controls.Add(Me.lblMisSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvTodos)
        Me.pnlContenedor.Controls.Add(Me.lblArrastreSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 160
        '
        'scrollSeleccionados
        '
        Me.scrollSeleccionados.LargeChange = 10
        Me.scrollSeleccionados.Location = New System.Drawing.Point(1019, 168)
        Me.scrollSeleccionados.Maximum = 100
        Me.scrollSeleccionados.Name = "scrollSeleccionados"
        Me.scrollSeleccionados.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scrollSeleccionados.Size = New System.Drawing.Size(5, 200)
        Me.scrollSeleccionados.TabIndex = 195
        Me.scrollSeleccionados.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scrollSeleccionados.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scrollSeleccionados.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'scrollTodos
        '
        Me.scrollTodos.LargeChange = 10
        Me.scrollTodos.Location = New System.Drawing.Point(353, 257)
        Me.scrollTodos.Maximum = 100
        Me.scrollTodos.Name = "scrollTodos"
        Me.scrollTodos.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scrollTodos.Size = New System.Drawing.Size(5, 200)
        Me.scrollTodos.TabIndex = 194
        Me.scrollTodos.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scrollTodos.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scrollTodos.ThumbPressedColor = System.Drawing.Color.DarkGray
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
        Me.btnAtras.TabIndex = 193
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnObtenerDiag
        '
        Me.btnObtenerDiag.AnimationHoverSpeed = 0.07!
        Me.btnObtenerDiag.AnimationSpeed = 0.03!
        Me.btnObtenerDiag.BackColor = System.Drawing.Color.Transparent
        Me.btnObtenerDiag.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnObtenerDiag.BorderColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObtenerDiag.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnObtenerDiag.FocusedColor = System.Drawing.Color.Empty
        Me.btnObtenerDiag.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerDiag.ForeColor = System.Drawing.Color.White
        Me.btnObtenerDiag.Image = Nothing
        Me.btnObtenerDiag.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnObtenerDiag.Location = New System.Drawing.Point(420, 523)
        Me.btnObtenerDiag.Name = "btnObtenerDiag"
        Me.btnObtenerDiag.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnObtenerDiag.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.OnHoverForeColor = System.Drawing.Color.White
        Me.btnObtenerDiag.OnHoverImage = Nothing
        Me.btnObtenerDiag.OnPressedColor = System.Drawing.Color.Black
        Me.btnObtenerDiag.Radius = 16
        Me.btnObtenerDiag.Size = New System.Drawing.Size(240, 49)
        Me.btnObtenerDiag.TabIndex = 161
        Me.btnObtenerDiag.Text = "Obtener diagnósitco primario"
        Me.btnObtenerDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 160
        '
        'frmIngresarSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
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
    Friend WithEvents btnObtenerDiag As Guna.UI.WinForms.GunaButton
    Public WithEvents pnlInstancia As Panel
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents scrollSeleccionados As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scrollTodos As Guna.UI.WinForms.GunaVScrollBar
End Class
