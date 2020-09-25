<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoChat
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
        Me.dgvListadoChat = New System.Windows.Forms.DataGridView()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblSolicitudesDeChat = New System.Windows.Forms.Label()
        Me.brnActualizar = New System.Windows.Forms.Button()
        Me.btnVerMisChat = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTituloPatologia.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoChat
        '
        Me.dgvListadoChat.AllowUserToAddRows = False
        Me.dgvListadoChat.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoChat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoChat.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListadoChat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoChat.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoChat.EnableHeadersVisualStyles = False
        Me.dgvListadoChat.Location = New System.Drawing.Point(49, 141)
        Me.dgvListadoChat.MultiSelect = False
        Me.dgvListadoChat.Name = "dgvListadoChat"
        Me.dgvListadoChat.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoChat.RowHeadersVisible = False
        Me.dgvListadoChat.RowHeadersWidth = 51
        Me.dgvListadoChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoChat.Size = New System.Drawing.Size(333, 481)
        Me.dgvListadoChat.TabIndex = 152
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblSolicitudesDeChat)
        Me.pnlTituloPatologia.Controls.Add(Me.brnActualizar)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1006, 80)
        Me.pnlTituloPatologia.TabIndex = 153
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(9, 19)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAtras.Size = New System.Drawing.Size(49, 32)
        Me.btnAtras.TabIndex = 153
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblSolicitudesDeChat
        '
        Me.lblSolicitudesDeChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSolicitudesDeChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitudesDeChat.ForeColor = System.Drawing.Color.White
        Me.lblSolicitudesDeChat.Location = New System.Drawing.Point(305, 16)
        Me.lblSolicitudesDeChat.Name = "lblSolicitudesDeChat"
        Me.lblSolicitudesDeChat.Size = New System.Drawing.Size(396, 45)
        Me.lblSolicitudesDeChat.TabIndex = 26
        Me.lblSolicitudesDeChat.Text = "SOLICITUDES DE CHAT"
        Me.lblSolicitudesDeChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'brnActualizar
        '
        Me.brnActualizar.FlatAppearance.BorderSize = 0
        Me.brnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnActualizar.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.brnActualizar.Location = New System.Drawing.Point(841, 45)
        Me.brnActualizar.Name = "brnActualizar"
        Me.brnActualizar.Size = New System.Drawing.Size(40, 35)
        Me.brnActualizar.TabIndex = 150
        Me.brnActualizar.UseVisualStyleBackColor = True
        '
        'btnVerMisChat
        '
        Me.btnVerMisChat.FlatAppearance.BorderSize = 0
        Me.btnVerMisChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerMisChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerMisChat.Image = Global.Vista.My.Resources.Resources.icons8_right_arrow_64
        Me.btnVerMisChat.Location = New System.Drawing.Point(645, 319)
        Me.btnVerMisChat.Name = "btnVerMisChat"
        Me.btnVerMisChat.Size = New System.Drawing.Size(236, 58)
        Me.btnVerMisChat.TabIndex = 154
        Me.btnVerMisChat.Text = "Ver mis chats"
        Me.btnVerMisChat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerMisChat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnVerMisChat.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlTituloPatologia)
        Me.pnlContenedor.Controls.Add(Me.btnVerMisChat)
        Me.pnlContenedor.Controls.Add(Me.dgvListadoChat)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1006, 645)
        Me.pnlContenedor.TabIndex = 155
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1006, 645)
        Me.pnlInstancia.TabIndex = 156
        '
        'frmListadoChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 645)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListadoChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListadoChat"
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTituloPatologia.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerMisChat As Button
    Friend WithEvents dgvListadoChat As DataGridView
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents brnActualizar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents lblSolicitudesDeChat As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
End Class
