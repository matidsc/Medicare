<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChat))
        Me.Chat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnVerSintomas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblEscriba = New System.Windows.Forms.Label()
        Me.dgvMisChats = New System.Windows.Forms.DataGridView()
        Me.dgvFinalizados = New System.Windows.Forms.DataGridView()
        Me.pnlYo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New MaterialSkin.Controls.MaterialFlatButton()
        Me.divider = New MetroSet_UI.Controls.MetroSetDivider()
        Me.pnlWrapChat = New System.Windows.Forms.Panel()
        Me.lblFinalizados = New System.Windows.Forms.Label()
        Me.pbFicha = New System.Windows.Forms.PictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.btnFicha = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.pbVerSintomas = New System.Windows.Forms.PictureBox()
        Me.pbFinalizar = New System.Windows.Forms.PictureBox()
        Me.txtMensaje = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pbEnviar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYo.SuspendLayout()
        Me.pnlWrapChat.SuspendLayout()
        CType(Me.pbFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAcciones.SuspendLayout()
        CType(Me.pbVerSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.AutoScroll = True
        Me.Chat.Location = New System.Drawing.Point(60, 121)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(646, 498)
        Me.Chat.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 4000
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(184, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(373, 33)
        Me.lblUsuario.TabIndex = 11
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerSintomas
        '
        Me.btnVerSintomas.AutoSize = True
        Me.btnVerSintomas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVerSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerSintomas.Depth = 0
        Me.btnVerSintomas.Icon = Nothing
        Me.btnVerSintomas.Location = New System.Drawing.Point(40, 6)
        Me.btnVerSintomas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnVerSintomas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnVerSintomas.Name = "btnVerSintomas"
        Me.btnVerSintomas.Primary = False
        Me.btnVerSintomas.Size = New System.Drawing.Size(223, 36)
        Me.btnVerSintomas.TabIndex = 12
        Me.btnVerSintomas.Text = "Ver síntomas y diagnóstico"
        Me.btnVerSintomas.UseVisualStyleBackColor = True
        '
        'lblEscriba
        '
        Me.lblEscriba.AutoSize = True
        Me.lblEscriba.BackColor = System.Drawing.Color.White
        Me.lblEscriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscriba.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEscriba.Location = New System.Drawing.Point(71, 636)
        Me.lblEscriba.Name = "lblEscriba"
        Me.lblEscriba.Size = New System.Drawing.Size(138, 18)
        Me.lblEscriba.TabIndex = 16
        Me.lblEscriba.Text = "Escriba un mensaje"
        '
        'dgvMisChats
        '
        Me.dgvMisChats.AllowUserToAddRows = False
        Me.dgvMisChats.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMisChats.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMisChats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMisChats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMisChats.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMisChats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMisChats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMisChats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMisChats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMisChats.ColumnHeadersVisible = False
        Me.dgvMisChats.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMisChats.EnableHeadersVisualStyles = False
        Me.dgvMisChats.Location = New System.Drawing.Point(403, 110)
        Me.dgvMisChats.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvMisChats.MultiSelect = False
        Me.dgvMisChats.Name = "dgvMisChats"
        Me.dgvMisChats.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvMisChats.RowHeadersVisible = False
        Me.dgvMisChats.RowHeadersWidth = 51
        Me.dgvMisChats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMisChats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMisChats.Size = New System.Drawing.Size(246, 325)
        Me.dgvMisChats.TabIndex = 149
        Me.dgvMisChats.Visible = False
        '
        'dgvFinalizados
        '
        Me.dgvFinalizados.AllowUserToAddRows = False
        Me.dgvFinalizados.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFinalizados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvFinalizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFinalizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFinalizados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFinalizados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFinalizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFinalizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinalizados.ColumnHeadersVisible = False
        Me.dgvFinalizados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvFinalizados.EnableHeadersVisualStyles = False
        Me.dgvFinalizados.Location = New System.Drawing.Point(403, 464)
        Me.dgvFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvFinalizados.MultiSelect = False
        Me.dgvFinalizados.Name = "dgvFinalizados"
        Me.dgvFinalizados.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvFinalizados.RowHeadersVisible = False
        Me.dgvFinalizados.RowHeadersWidth = 51
        Me.dgvFinalizados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFinalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFinalizados.Size = New System.Drawing.Size(246, 204)
        Me.dgvFinalizados.TabIndex = 150
        Me.dgvFinalizados.Visible = False
        '
        'pnlYo
        '
        Me.pnlYo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlYo.Controls.Add(Me.Label1)
        Me.pnlYo.Location = New System.Drawing.Point(402, 12)
        Me.pnlYo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlYo.Name = "pnlYo"
        Me.pnlYo.Size = New System.Drawing.Size(246, 65)
        Me.pnlYo.TabIndex = 0
        Me.pnlYo.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.AutoSize = True
        Me.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.Depth = 0
        Me.btnFinalizar.Icon = Nothing
        Me.btnFinalizar.Location = New System.Drawing.Point(627, 77)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Primary = False
        Me.btnFinalizar.Size = New System.Drawing.Size(128, 36)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "finalizar chat"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'divider
        '
        Me.divider.Location = New System.Drawing.Point(67, 61)
        Me.divider.Name = "divider"
        Me.divider.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.divider.Size = New System.Drawing.Size(662, 4)
        Me.divider.Style = MetroSet_UI.Design.Style.Light
        Me.divider.StyleManager = Nothing
        Me.divider.TabIndex = 153
        Me.divider.Text = "MetroSetDivider1"
        Me.divider.ThemeAuthor = "Narwin"
        Me.divider.ThemeName = "MetroLite"
        Me.divider.Thickness = 1
        '
        'pnlWrapChat
        '
        Me.pnlWrapChat.Controls.Add(Me.lblFinalizados)
        Me.pnlWrapChat.Controls.Add(Me.pbFicha)
        Me.pnlWrapChat.Controls.Add(Me.lblGeneral)
        Me.pnlWrapChat.Controls.Add(Me.pnlYo)
        Me.pnlWrapChat.Controls.Add(Me.btnFicha)
        Me.pnlWrapChat.Controls.Add(Me.dgvFinalizados)
        Me.pnlWrapChat.Controls.Add(Me.pnlAcciones)
        Me.pnlWrapChat.Controls.Add(Me.dgvMisChats)
        Me.pnlWrapChat.Controls.Add(Me.btnFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.pbFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.lblEscriba)
        Me.pnlWrapChat.Controls.Add(Me.txtMensaje)
        Me.pnlWrapChat.Controls.Add(Me.divider)
        Me.pnlWrapChat.Controls.Add(Me.btnAtras)
        Me.pnlWrapChat.Controls.Add(Me.pbEnviar)
        Me.pnlWrapChat.Controls.Add(Me.lblUsuario)
        Me.pnlWrapChat.Controls.Add(Me.PictureBox1)
        Me.pnlWrapChat.Controls.Add(Me.Chat)
        Me.pnlWrapChat.Location = New System.Drawing.Point(265, 0)
        Me.pnlWrapChat.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWrapChat.Name = "pnlWrapChat"
        Me.pnlWrapChat.Size = New System.Drawing.Size(748, 679)
        Me.pnlWrapChat.TabIndex = 154
        '
        'lblFinalizados
        '
        Me.lblFinalizados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFinalizados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalizados.Location = New System.Drawing.Point(403, 435)
        Me.lblFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFinalizados.Name = "lblFinalizados"
        Me.lblFinalizados.Size = New System.Drawing.Size(246, 29)
        Me.lblFinalizados.TabIndex = 155
        Me.lblFinalizados.Text = "FINALIZADOS"
        Me.lblFinalizados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalizados.Visible = False
        '
        'pbFicha
        '
        Me.pbFicha.Image = CType(resources.GetObject("pbFicha.Image"), System.Drawing.Image)
        Me.pbFicha.Location = New System.Drawing.Point(336, 77)
        Me.pbFicha.Name = "pbFicha"
        Me.pbFicha.Size = New System.Drawing.Size(30, 30)
        Me.pbFicha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbFicha.TabIndex = 16
        Me.pbFicha.TabStop = False
        '
        'lblGeneral
        '
        Me.lblGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(402, 77)
        Me.lblGeneral.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(246, 35)
        Me.lblGeneral.TabIndex = 1
        Me.lblGeneral.Text = "GENERAL"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGeneral.Visible = False
        '
        'btnFicha
        '
        Me.btnFicha.AutoSize = True
        Me.btnFicha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFicha.Depth = 0
        Me.btnFicha.Icon = Nothing
        Me.btnFicha.Location = New System.Drawing.Point(373, 77)
        Me.btnFicha.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFicha.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Primary = False
        Me.btnFicha.Size = New System.Drawing.Size(184, 36)
        Me.btnFicha.TabIndex = 16
        Me.btnFicha.Text = "ver ficha del paciente"
        Me.btnFicha.UseVisualStyleBackColor = True
        '
        'pnlAcciones
        '
        Me.pnlAcciones.AutoSize = True
        Me.pnlAcciones.Controls.Add(Me.btnVerSintomas)
        Me.pnlAcciones.Controls.Add(Me.pbVerSintomas)
        Me.pnlAcciones.Location = New System.Drawing.Point(60, 71)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(267, 48)
        Me.pnlAcciones.TabIndex = 156
        '
        'pbVerSintomas
        '
        Me.pbVerSintomas.Image = CType(resources.GetObject("pbVerSintomas.Image"), System.Drawing.Image)
        Me.pbVerSintomas.Location = New System.Drawing.Point(3, 9)
        Me.pbVerSintomas.Name = "pbVerSintomas"
        Me.pbVerSintomas.Size = New System.Drawing.Size(30, 30)
        Me.pbVerSintomas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbVerSintomas.TabIndex = 15
        Me.pbVerSintomas.TabStop = False
        '
        'pbFinalizar
        '
        Me.pbFinalizar.Image = CType(resources.GetObject("pbFinalizar.Image"), System.Drawing.Image)
        Me.pbFinalizar.Location = New System.Drawing.Point(586, 79)
        Me.pbFinalizar.Name = "pbFinalizar"
        Me.pbFinalizar.Size = New System.Drawing.Size(34, 28)
        Me.pbFinalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFinalizar.TabIndex = 10
        Me.pbFinalizar.TabStop = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Depth = 0
        Me.txtMensaje.Hint = ""
        Me.txtMensaje.Location = New System.Drawing.Point(75, 636)
        Me.txtMensaje.MaxLength = 32767
        Me.txtMensaje.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMensaje.SelectedText = ""
        Me.txtMensaje.SelectionLength = 0
        Me.txtMensaje.SelectionStart = 0
        Me.txtMensaje.Size = New System.Drawing.Size(585, 23)
        Me.txtMensaje.TabIndex = 154
        Me.txtMensaje.TabStop = False
        Me.txtMensaje.UseSystemPasswordChar = False
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(35, 18)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'pbEnviar
        '
        Me.pbEnviar.BackColor = System.Drawing.Color.White
        Me.pbEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEnviar.Image = CType(resources.GetObject("pbEnviar.Image"), System.Drawing.Image)
        Me.pbEnviar.Location = New System.Drawing.Point(666, 623)
        Me.pbEnviar.Name = "pbEnviar"
        Me.pbEnviar.Size = New System.Drawing.Size(41, 42)
        Me.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEnviar.TabIndex = 9
        Me.pbEnviar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(101, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 42)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 107)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(294, 573)
        Me.FlowLayoutPanel1.TabIndex = 155
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 107)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chat"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.Panel1)
        Me.pnlContenedor.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.pnlWrapChat)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1014, 680)
        Me.pnlContenedor.TabIndex = 0
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 680)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChat"
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlYo.ResumeLayout(False)
        Me.pnlWrapChat.ResumeLayout(False)
        Me.pnlWrapChat.PerformLayout()
        CType(Me.pbFicha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlAcciones.PerformLayout()
        CType(Me.pbVerSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chat As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAtras As Button
    Friend WithEvents pbEnviar As PictureBox
    Friend WithEvents pbFinalizar As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnVerSintomas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFinalizar As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pbVerSintomas As PictureBox
    Friend WithEvents lblEscriba As Label
    Friend WithEvents dgvMisChats As DataGridView
    Friend WithEvents dgvFinalizados As DataGridView
    Friend WithEvents pnlYo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents divider As MetroSet_UI.Controls.MetroSetDivider
    Friend WithEvents pnlWrapChat As Panel
    Friend WithEvents txtMensaje As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents lblFinalizados As Label
    Friend WithEvents btnFicha As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pbFicha As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlContenedor As Panel
End Class
