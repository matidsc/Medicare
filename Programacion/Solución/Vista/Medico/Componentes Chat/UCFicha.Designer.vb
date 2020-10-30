<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCFicha
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblPatCro = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.dgvPatCron = New System.Windows.Forms.DataGridView()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        CType(Me.dgvPatCron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.Silver
        Me.lblSexo.Location = New System.Drawing.Point(54, 244)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(44, 20)
        Me.lblSexo.TabIndex = 163
        Me.lblSexo.Text = "Sexo:"
        '
        'lblPatCro
        '
        Me.lblPatCro.AutoSize = True
        Me.lblPatCro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatCro.ForeColor = System.Drawing.Color.Silver
        Me.lblPatCro.Location = New System.Drawing.Point(514, 62)
        Me.lblPatCro.Name = "lblPatCro"
        Me.lblPatCro.Size = New System.Drawing.Size(142, 21)
        Me.lblPatCro.TabIndex = 159
        Me.lblPatCro.Text = "Patologías crónicas"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Silver
        Me.lblMail.Location = New System.Drawing.Point(54, 298)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(49, 20)
        Me.lblMail.TabIndex = 158
        Me.lblMail.Text = "Email:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.Silver
        Me.lblEdad.Location = New System.Drawing.Point(54, 187)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(46, 20)
        Me.lblEdad.TabIndex = 157
        Me.lblEdad.Text = "Edad:"
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Silver
        Me.lblNom.Location = New System.Drawing.Point(54, 126)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(338, 43)
        Me.lblNom.TabIndex = 156
        Me.lblNom.Text = "Nombre completo:"
        '
        'lblFicha
        '
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.Silver
        Me.lblFicha.Location = New System.Drawing.Point(52, 51)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(208, 32)
        Me.lblFicha.TabIndex = 155
        Me.lblFicha.Text = "Ficha del paciente"
        '
        'dgvPatCron
        '
        Me.dgvPatCron.AllowDrop = True
        Me.dgvPatCron.AllowUserToAddRows = False
        Me.dgvPatCron.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvPatCron.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatCron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatCron.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPatCron.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvPatCron.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPatCron.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatCron.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatCron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatCron.ColumnHeadersVisible = False
        Me.dgvPatCron.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatCron.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPatCron.Location = New System.Drawing.Point(491, 105)
        Me.dgvPatCron.MultiSelect = False
        Me.dgvPatCron.Name = "dgvPatCron"
        Me.dgvPatCron.ReadOnly = True
        Me.dgvPatCron.RowHeadersVisible = False
        Me.dgvPatCron.RowHeadersWidth = 51
        Me.dgvPatCron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatCron.Size = New System.Drawing.Size(195, 250)
        Me.dgvPatCron.TabIndex = 164
        '
        'scroll2
        '
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(368, 92)
        Me.scroll2.Maximum = 100
        Me.scroll2.Name = "scroll2"
        Me.scroll2.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll2.Size = New System.Drawing.Size(10, 200)
        Me.scroll2.TabIndex = 196
        Me.scroll2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll2.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll2.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'UCFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.scroll2)
        Me.Controls.Add(Me.dgvPatCron)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblPatCro)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblFicha)
        Me.Name = "UCFicha"
        Me.Size = New System.Drawing.Size(747, 384)
        CType(Me.dgvPatCron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSexo As Label
    Friend WithEvents lblPatCro As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblFicha As Label
    Friend WithEvents dgvPatCron As DataGridView
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
End Class
