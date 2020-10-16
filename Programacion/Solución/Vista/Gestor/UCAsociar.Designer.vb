<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAsociar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.lblPatologia = New System.Windows.Forms.Label()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Silver
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Silver
        Me.btnVolver.IconSize = 20
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(22, 22)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Rotation = 0R
        Me.btnVolver.Size = New System.Drawing.Size(117, 37)
        Me.btnVolver.TabIndex = 190
        Me.btnVolver.Text = "Atrás"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'scroll2
        '
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(615, 246)
        Me.scroll2.Maximum = 100
        Me.scroll2.Name = "scroll2"
        Me.scroll2.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll2.Size = New System.Drawing.Size(5, 200)
        Me.scroll2.TabIndex = 189
        Me.scroll2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll2.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll2.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(540, 246)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 188
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'dgvTodosLosSintomas
        '
        Me.dgvTodosLosSintomas.AllowDrop = True
        Me.dgvTodosLosSintomas.AllowUserToAddRows = False
        Me.dgvTodosLosSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(168, 167)
        Me.dgvTodosLosSintomas.MultiSelect = False
        Me.dgvTodosLosSintomas.Name = "dgvTodosLosSintomas"
        Me.dgvTodosLosSintomas.ReadOnly = True
        Me.dgvTodosLosSintomas.RowHeadersVisible = False
        Me.dgvTodosLosSintomas.RowHeadersWidth = 51
        Me.dgvTodosLosSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTodosLosSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodosLosSintomas.Size = New System.Drawing.Size(250, 430)
        Me.dgvTodosLosSintomas.TabIndex = 115
        '
        'dgvColSintomas
        '
        Me.dgvColSintomas.HeaderText = "Column1"
        Me.dgvColSintomas.MinimumWidth = 6
        Me.dgvColSintomas.Name = "dgvColSintomas"
        Me.dgvColSintomas.ReadOnly = True
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(683, 167)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(250, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 114
        '
        'dgvColSintomasSel
        '
        Me.dgvColSintomasSel.HeaderText = "Column1"
        Me.dgvColSintomasSel.MinimumWidth = 6
        Me.dgvColSintomasSel.Name = "dgvColSintomasSel"
        Me.dgvColSintomasSel.ReadOnly = True
        '
        'lblTodosLosSintomas
        '
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.Silver
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(131, 79)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(339, 70)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.Silver
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(660, 88)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(312, 55)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Nothing
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(440, 584)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 20
        Me.btnGuardar.Size = New System.Drawing.Size(199, 42)
        Me.btnGuardar.TabIndex = 191
        Me.btnGuardar.Text = "Guardar síntomas"
        Me.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPatologia
        '
        Me.lblPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPatologia.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologia.ForeColor = System.Drawing.Color.Silver
        Me.lblPatologia.Location = New System.Drawing.Point(433, 12)
        Me.lblPatologia.Name = "lblPatologia"
        Me.lblPatologia.Size = New System.Drawing.Size(253, 47)
        Me.lblPatologia.TabIndex = 192
        Me.lblPatologia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCAsociar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.lblPatologia)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.scroll2)
        Me.Controls.Add(Me.dgvTodosLosSintomas)
        Me.Controls.Add(Me.scroll)
        Me.Controls.Add(Me.lblTodosLosSintomas)
        Me.Controls.Add(Me.lblSintomasSeleccionados)
        Me.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.Name = "UCAsociar"
        Me.Size = New System.Drawing.Size(1070, 650)
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblPatologia As Label
End Class
