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
        Me.lblCantSelecc = New System.Windows.Forms.Label()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.btnEliminarElementos = New Guna.UI.WinForms.GunaButton()
        Me.btnModificarElemento = New Guna.UI.WinForms.GunaButton()
        Me.btnSeleccionMultiple = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.MISintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantSelecc
        '
        Me.lblCantSelecc.AutoSize = True
        Me.lblCantSelecc.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantSelecc.ForeColor = System.Drawing.Color.White
        Me.lblCantSelecc.Location = New System.Drawing.Point(61, 46)
        Me.lblCantSelecc.Name = "lblCantSelecc"
        Me.lblCantSelecc.Size = New System.Drawing.Size(29, 32)
        Me.lblCantSelecc.TabIndex = 174
        Me.lblCantSelecc.Text = "0"
        Me.lblCantSelecc.Visible = False
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Location = New System.Drawing.Point(37, 0)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Radius = 5
        Me.GunaTextBox2.Size = New System.Drawing.Size(659, 32)
        Me.GunaTextBox2.TabIndex = 173
        Me.GunaTextBox2.Text = "Buscar"
        Me.GunaTextBox2.TextOffsetX = 5
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(116, 157)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 15
        Me.GunaButton4.Size = New System.Drawing.Size(62, 29)
        Me.GunaButton4.TabIndex = 170
        Me.GunaButton4.Text = "Filtrar"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEliminarElementos
        '
        Me.btnEliminarElementos.AnimationHoverSpeed = 0.07!
        Me.btnEliminarElementos.AnimationSpeed = 0.03!
        Me.btnEliminarElementos.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarElementos.BaseColor = System.Drawing.Color.Brown
        Me.btnEliminarElementos.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarElementos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminarElementos.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminarElementos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarElementos.ForeColor = System.Drawing.Color.White
        Me.btnEliminarElementos.Image = Nothing
        Me.btnEliminarElementos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminarElementos.Location = New System.Drawing.Point(713, 157)
        Me.btnEliminarElementos.Name = "btnEliminarElementos"
        Me.btnEliminarElementos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEliminarElementos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminarElementos.OnHoverImage = Nothing
        Me.btnEliminarElementos.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminarElementos.Radius = 15
        Me.btnEliminarElementos.Size = New System.Drawing.Size(236, 29)
        Me.btnEliminarElementos.TabIndex = 169
        Me.btnEliminarElementos.Text = "Eliminar elemento seleccionado"
        Me.btnEliminarElementos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModificarElemento
        '
        Me.btnModificarElemento.AnimationHoverSpeed = 0.07!
        Me.btnModificarElemento.AnimationSpeed = 0.03!
        Me.btnModificarElemento.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarElemento.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnModificarElemento.BorderColor = System.Drawing.Color.Black
        Me.btnModificarElemento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarElemento.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnModificarElemento.FocusedColor = System.Drawing.Color.Empty
        Me.btnModificarElemento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarElemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnModificarElemento.Image = Nothing
        Me.btnModificarElemento.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnModificarElemento.Location = New System.Drawing.Point(443, 157)
        Me.btnModificarElemento.Name = "btnModificarElemento"
        Me.btnModificarElemento.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnModificarElemento.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnModificarElemento.OnHoverForeColor = System.Drawing.Color.White
        Me.btnModificarElemento.OnHoverImage = Nothing
        Me.btnModificarElemento.OnPressedColor = System.Drawing.Color.Black
        Me.btnModificarElemento.Radius = 15
        Me.btnModificarElemento.Size = New System.Drawing.Size(236, 29)
        Me.btnModificarElemento.TabIndex = 168
        Me.btnModificarElemento.Text = "Modificar elemento seleccionado"
        Me.btnModificarElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSeleccionMultiple
        '
        Me.btnSeleccionMultiple.AnimationHoverSpeed = 0.07!
        Me.btnSeleccionMultiple.AnimationSpeed = 0.03!
        Me.btnSeleccionMultiple.BackColor = System.Drawing.Color.Transparent
        Me.btnSeleccionMultiple.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSeleccionMultiple.BorderColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionMultiple.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSeleccionMultiple.FocusedColor = System.Drawing.Color.Empty
        Me.btnSeleccionMultiple.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionMultiple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSeleccionMultiple.Image = Nothing
        Me.btnSeleccionMultiple.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSeleccionMultiple.Location = New System.Drawing.Point(212, 157)
        Me.btnSeleccionMultiple.Name = "btnSeleccionMultiple"
        Me.btnSeleccionMultiple.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSeleccionMultiple.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSeleccionMultiple.OnHoverImage = Nothing
        Me.btnSeleccionMultiple.OnPressedColor = System.Drawing.Color.Black
        Me.btnSeleccionMultiple.Radius = 15
        Me.btnSeleccionMultiple.Size = New System.Drawing.Size(197, 29)
        Me.btnSeleccionMultiple.TabIndex = 167
        Me.btnSeleccionMultiple.Text = "Activar selección múltiple"
        Me.btnSeleccionMultiple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaTextBox2)
        Me.GunaElipsePanel1.Controls.Add(Me.PictureBox1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(180, 82)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 5
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(711, 32)
        Me.GunaElipsePanel1.TabIndex = 177
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.buscar
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer))
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
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MISintoma, Me.Column1})
        Me.dgvSintomasSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(62, 208)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(946, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 178
        '
        'MISintoma
        '
        Me.MISintoma.HeaderText = "Column1"
        Me.MISintoma.MinimumWidth = 6
        Me.MISintoma.Name = "MISintoma"
        Me.MISintoma.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cedula"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(1026, 157)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 179
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'frmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.scroll)
        Me.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.lblCantSelecc)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.btnEliminarElementos)
        Me.Controls.Add(Me.btnModificarElemento)
        Me.Controls.Add(Me.btnSeleccionMultiple)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListado"
        Me.GunaElipsePanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantSelecc As Label
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEliminarElementos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnModificarElemento As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSeleccionMultiple As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents MISintoma As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
End Class
