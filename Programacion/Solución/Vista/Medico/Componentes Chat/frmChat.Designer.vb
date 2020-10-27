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
        Me.Chat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblEscriba = New System.Windows.Forms.Label()
        Me.dgvMisChats = New System.Windows.Forms.DataGridView()
        Me.dgvFinalizados = New System.Windows.Forms.DataGridView()
        Me.pnlYo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlWrapChat = New System.Windows.Forms.Panel()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnEnviar = New FontAwesome.Sharp.IconButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.btnFinalizar = New Guna.UI.WinForms.GunaButton()
        Me.btnFicha = New Guna.UI.WinForms.GunaButton()
        Me.btnSintomasDiag = New Guna.UI.WinForms.GunaButton()
        Me.pbPerfil = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.lblFinalizados = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.txtMsg = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYo.SuspendLayout()
        Me.pnlWrapChat.SuspendLayout()
        CType(Me.pbPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.AutoScroll = True
        Me.Chat.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Chat.Location = New System.Drawing.Point(58, 135)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(687, 445)
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
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(217, 13)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(373, 33)
        Me.lblUsuario.TabIndex = 11
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEscriba
        '
        Me.lblEscriba.AutoSize = True
        Me.lblEscriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblEscriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscriba.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEscriba.Location = New System.Drawing.Point(102, 605)
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
        Me.dgvMisChats.Location = New System.Drawing.Point(8, 74)
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
        Me.dgvMisChats.Size = New System.Drawing.Size(24, 325)
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
        Me.dgvFinalizados.Location = New System.Drawing.Point(8, 399)
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
        Me.dgvFinalizados.Size = New System.Drawing.Size(24, 204)
        Me.dgvFinalizados.TabIndex = 150
        Me.dgvFinalizados.Visible = False
        '
        'pnlYo
        '
        Me.pnlYo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlYo.Controls.Add(Me.Label1)
        Me.pnlYo.Location = New System.Drawing.Point(8, 9)
        Me.pnlYo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlYo.Name = "pnlYo"
        Me.pnlYo.Size = New System.Drawing.Size(24, 65)
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
        'pnlWrapChat
        '
        Me.pnlWrapChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlWrapChat.Controls.Add(Me.lblEscriba)
        Me.pnlWrapChat.Controls.Add(Me.txtMsg)
        Me.pnlWrapChat.Controls.Add(Me.scroll2)
        Me.pnlWrapChat.Controls.Add(Me.btnEnviar)
        Me.pnlWrapChat.Controls.Add(Me.btnAtras)
        Me.pnlWrapChat.Controls.Add(Me.btnFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.btnFicha)
        Me.pnlWrapChat.Controls.Add(Me.btnSintomasDiag)
        Me.pnlWrapChat.Controls.Add(Me.pnlYo)
        Me.pnlWrapChat.Controls.Add(Me.dgvMisChats)
        Me.pnlWrapChat.Controls.Add(Me.pbPerfil)
        Me.pnlWrapChat.Controls.Add(Me.dgvFinalizados)
        Me.pnlWrapChat.Controls.Add(Me.lblGeneral)
        Me.pnlWrapChat.Controls.Add(Me.lblFinalizados)
        Me.pnlWrapChat.Controls.Add(Me.lblUsuario)
        Me.pnlWrapChat.Controls.Add(Me.Chat)
        Me.pnlWrapChat.Location = New System.Drawing.Point(297, 0)
        Me.pnlWrapChat.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWrapChat.Name = "pnlWrapChat"
        Me.pnlWrapChat.Size = New System.Drawing.Size(773, 650)
        Me.pnlWrapChat.TabIndex = 154
        '
        'scroll2
        '
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(751, 149)
        Me.scroll2.Maximum = 100
        Me.scroll2.Name = "scroll2"
        Me.scroll2.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll2.Size = New System.Drawing.Size(10, 200)
        Me.scroll2.TabIndex = 195
        Me.scroll2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll2.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll2.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'btnEnviar
        '
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Silver
        Me.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.btnEnviar.IconColor = System.Drawing.Color.White
        Me.btnEnviar.IconSize = 36
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(694, 596)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Rotation = 0R
        Me.btnEnviar.Size = New System.Drawing.Size(51, 37)
        Me.btnEnviar.TabIndex = 192
        Me.btnEnviar.UseVisualStyleBackColor = True
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
        Me.btnAtras.Location = New System.Drawing.Point(58, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 191
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Animated = True
        Me.btnFinalizar.AnimationHoverSpeed = 0.07!
        Me.btnFinalizar.AnimationSpeed = 0.03!
        Me.btnFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnFinalizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnFinalizar.BorderColor = System.Drawing.Color.Black
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFinalizar.FocusedColor = System.Drawing.Color.Empty
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFinalizar.Image = Nothing
        Me.btnFinalizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFinalizar.Location = New System.Drawing.Point(588, 73)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFinalizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFinalizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFinalizar.OnHoverImage = Nothing
        Me.btnFinalizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnFinalizar.Radius = 10
        Me.btnFinalizar.Size = New System.Drawing.Size(157, 41)
        Me.btnFinalizar.TabIndex = 183
        Me.btnFinalizar.Text = "FINALIZAR CHAT"
        Me.btnFinalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFicha
        '
        Me.btnFicha.Animated = True
        Me.btnFicha.AnimationHoverSpeed = 0.07!
        Me.btnFicha.AnimationSpeed = 0.03!
        Me.btnFicha.BackColor = System.Drawing.Color.Transparent
        Me.btnFicha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnFicha.BorderColor = System.Drawing.Color.Black
        Me.btnFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFicha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFicha.FocusedColor = System.Drawing.Color.Empty
        Me.btnFicha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFicha.Image = Nothing
        Me.btnFicha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFicha.Location = New System.Drawing.Point(324, 73)
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFicha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFicha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFicha.OnHoverImage = Nothing
        Me.btnFicha.OnPressedColor = System.Drawing.Color.Black
        Me.btnFicha.Radius = 10
        Me.btnFicha.Size = New System.Drawing.Size(244, 41)
        Me.btnFicha.TabIndex = 182
        Me.btnFicha.Text = "VER FICHA DEL PACIENTE"
        Me.btnFicha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSintomasDiag
        '
        Me.btnSintomasDiag.Animated = True
        Me.btnSintomasDiag.AnimationHoverSpeed = 0.07!
        Me.btnSintomasDiag.AnimationSpeed = 0.03!
        Me.btnSintomasDiag.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomasDiag.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSintomasDiag.BorderColor = System.Drawing.Color.Black
        Me.btnSintomasDiag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomasDiag.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomasDiag.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomasDiag.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomasDiag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSintomasDiag.Image = Nothing
        Me.btnSintomasDiag.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomasDiag.Location = New System.Drawing.Point(58, 74)
        Me.btnSintomasDiag.Name = "btnSintomasDiag"
        Me.btnSintomasDiag.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnSintomasDiag.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomasDiag.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomasDiag.OnHoverImage = Nothing
        Me.btnSintomasDiag.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomasDiag.Radius = 10
        Me.btnSintomasDiag.Size = New System.Drawing.Size(244, 41)
        Me.btnSintomasDiag.TabIndex = 181
        Me.btnSintomasDiag.Text = "VER SÍNTOMAS Y DIAGNÓSTICO"
        Me.btnSintomasDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbPerfil
        '
        Me.pbPerfil.BaseColor = System.Drawing.Color.White
        Me.pbPerfil.Location = New System.Drawing.Point(663, 9)
        Me.pbPerfil.Name = "pbPerfil"
        Me.pbPerfil.Size = New System.Drawing.Size(45, 43)
        Me.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerfil.TabIndex = 157
        Me.pbPerfil.TabStop = False
        Me.pbPerfil.UseTransfarantBackground = False
        '
        'lblGeneral
        '
        Me.lblGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(8, 603)
        Me.lblGeneral.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(24, 35)
        Me.lblGeneral.TabIndex = 1
        Me.lblGeneral.Text = "GENERAL"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGeneral.Visible = False
        '
        'lblFinalizados
        '
        Me.lblFinalizados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFinalizados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalizados.Location = New System.Drawing.Point(8, 638)
        Me.lblFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFinalizados.Name = "lblFinalizados"
        Me.lblFinalizados.Size = New System.Drawing.Size(24, 29)
        Me.lblFinalizados.TabIndex = 155
        Me.lblFinalizados.Text = "FINALIZADOS"
        Me.lblFinalizados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalizados.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 107)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(299, 543)
        Me.FlowLayoutPanel1.TabIndex = 155
        Me.FlowLayoutPanel1.WrapContents = False
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
        Me.pnlContenedor.Controls.Add(Me.scroll)
        Me.pnlContenedor.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.pnlWrapChat)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 0
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(3, 97)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(10, 200)
        Me.scroll.TabIndex = 194
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.Color.Transparent
        Me.txtMsg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtMsg.BorderColor = System.Drawing.Color.Silver
        Me.txtMsg.BorderSize = 0
        Me.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMsg.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtMsg.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMsg.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMsg.ForeColor = System.Drawing.Color.White
        Me.txtMsg.Location = New System.Drawing.Point(87, 588)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMsg.Radius = 14
        Me.txtMsg.Size = New System.Drawing.Size(590, 50)
        Me.txtMsg.TabIndex = 196
        Me.txtMsg.Text = "GunaTextBox1"
        Me.txtMsg.TextOffsetX = 20
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
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
        CType(Me.pbPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblEscriba As Label
    Friend WithEvents dgvMisChats As DataGridView
    Friend WithEvents dgvFinalizados As DataGridView
    Friend WithEvents pnlYo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlWrapChat As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents lblFinalizados As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlContenedor As Panel
    Public WithEvents Chat As FlowLayoutPanel
    Friend WithEvents pbPerfil As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnSintomasDiag As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFicha As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFinalizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEnviar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents txtMsg As Guna.UI.WinForms.GunaTextBox
End Class
