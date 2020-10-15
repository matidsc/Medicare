<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarPatologia

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components__1 IsNot Nothing Then
                components__1.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components__1 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarPatologia))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.transicion = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlPatologia = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.btnReg = New Guna.UI.WinForms.GunaButton()
        Me.txtNomPat = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCantRec = New System.Windows.Forms.Label()
        Me.lblDescPat = New System.Windows.Forms.Label()
        Me.btnSintomas = New Guna.UI.WinForms.GunaButton()
        Me.txtDescPat = New Guna.UI.WinForms.GunaTextBox()
        Me.lblPrioPat = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.mrbPMedia = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblCantDesc = New System.Windows.Forms.Label()
        Me.mrbPBaja = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mrbPAlta = New Guna.UI.WinForms.GunaRadioButton()
        Me.txtRecPat = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.pnlSintomas = New System.Windows.Forms.Panel()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlPatologia.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSintomas.SuspendLayout()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transicion
        '
        Me.transicion.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.transicion.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 1.0!
        Me.transicion.DefaultAnimation = Animation3
        Me.transicion.Interval = 3
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlPatologia)
        Me.pnlContenedor.Controls.Add(Me.pnlSintomas)
        Me.transicion.SetDecoration(Me.pnlContenedor, Guna.UI.Animation.DecorationType.None)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 133
        '
        'pnlPatologia
        '
        Me.pnlPatologia.Controls.Add(Me.Panel1)
        Me.transicion.SetDecoration(Me.pnlPatologia, Guna.UI.Animation.DecorationType.None)
        Me.pnlPatologia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlPatologia.Name = "pnlPatologia"
        Me.pnlPatologia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlPatologia.TabIndex = 176
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.lblNomPat)
        Me.Panel1.Controls.Add(Me.btnReg)
        Me.Panel1.Controls.Add(Me.txtNomPat)
        Me.Panel1.Controls.Add(Me.lblCantRec)
        Me.Panel1.Controls.Add(Me.lblDescPat)
        Me.Panel1.Controls.Add(Me.btnSintomas)
        Me.Panel1.Controls.Add(Me.txtDescPat)
        Me.Panel1.Controls.Add(Me.lblPrioPat)
        Me.Panel1.Controls.Add(Me.GunaSeparator1)
        Me.Panel1.Controls.Add(Me.mrbPMedia)
        Me.Panel1.Controls.Add(Me.lblCantDesc)
        Me.Panel1.Controls.Add(Me.mrbPBaja)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.mrbPAlta)
        Me.Panel1.Controls.Add(Me.txtRecPat)
        Me.Panel1.Controls.Add(Me.GunaSeparator2)
        Me.transicion.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 650)
        Me.Panel1.TabIndex = 198
        '
        'IconButton1
        '
        Me.transicion.SetDecoration(Me.IconButton1, Guna.UI.Animation.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Silver
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton1.IconColor = System.Drawing.Color.Silver
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(22, 22)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(117, 37)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.Text = "Atrás"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNomPat, Guna.UI.Animation.DecorationType.None)
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(204, 37)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(212, 25)
        Me.lblNomPat.TabIndex = 181
        Me.lblNomPat.Text = "Nombre de la patología"
        '
        'btnReg
        '
        Me.btnReg.AnimationHoverSpeed = 0.07!
        Me.btnReg.AnimationSpeed = 0.03!
        Me.btnReg.BackColor = System.Drawing.Color.Transparent
        Me.btnReg.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnReg.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnReg, Guna.UI.Animation.DecorationType.None)
        Me.btnReg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReg.FocusedColor = System.Drawing.Color.Empty
        Me.btnReg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Image = Nothing
        Me.btnReg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnReg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReg.Location = New System.Drawing.Point(253, 571)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReg.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReg.OnHoverImage = Nothing
        Me.btnReg.OnPressedColor = System.Drawing.Color.Black
        Me.btnReg.Radius = 25
        Me.btnReg.Size = New System.Drawing.Size(243, 53)
        Me.btnReg.TabIndex = 8
        Me.btnReg.Text = "Registrar"
        Me.btnReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNomPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtNomPat, Guna.UI.Animation.DecorationType.None)
        Me.txtNomPat.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNomPat.LineColor = System.Drawing.Color.Gainsboro
        Me.txtNomPat.LineSize = 1
        Me.txtNomPat.Location = New System.Drawing.Point(204, 83)
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomPat.Size = New System.Drawing.Size(317, 36)
        Me.txtNomPat.TabIndex = 1
        '
        'lblCantRec
        '
        Me.lblCantRec.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCantRec, Guna.UI.Animation.DecorationType.None)
        Me.lblCantRec.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantRec.ForeColor = System.Drawing.Color.Silver
        Me.lblCantRec.Location = New System.Drawing.Point(799, 377)
        Me.lblCantRec.Name = "lblCantRec"
        Me.lblCantRec.Size = New System.Drawing.Size(41, 17)
        Me.lblCantRec.TabIndex = 196
        Me.lblCantRec.Text = "0/300"
        '
        'lblDescPat
        '
        Me.lblDescPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblDescPat, Guna.UI.Animation.DecorationType.None)
        Me.lblDescPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescPat.Location = New System.Drawing.Point(199, 165)
        Me.lblDescPat.Name = "lblDescPat"
        Me.lblDescPat.Size = New System.Drawing.Size(111, 25)
        Me.lblDescPat.TabIndex = 182
        Me.lblDescPat.Text = "Descripción"
        '
        'btnSintomas
        '
        Me.btnSintomas.AnimationHoverSpeed = 0.07!
        Me.btnSintomas.AnimationSpeed = 0.03!
        Me.btnSintomas.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomas.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnSintomas, Guna.UI.Animation.DecorationType.None)
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.Location = New System.Drawing.Point(550, 571)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Radius = 25
        Me.btnSintomas.Size = New System.Drawing.Size(243, 53)
        Me.btnSintomas.TabIndex = 7
        Me.btnSintomas.Text = "Añadir síntomas"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescPat
        '
        Me.txtDescPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.BorderColor = System.Drawing.Color.Silver
        Me.txtDescPat.BorderSize = 0
        Me.txtDescPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtDescPat, Guna.UI.Animation.DecorationType.None)
        Me.txtDescPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Location = New System.Drawing.Point(205, 211)
        Me.txtDescPat.MaxLength = 300
        Me.txtDescPat.MultiLine = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescPat.Size = New System.Drawing.Size(654, 122)
        Me.txtDescPat.TabIndex = 5
        '
        'lblPrioPat
        '
        Me.lblPrioPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPrioPat, Guna.UI.Animation.DecorationType.None)
        Me.lblPrioPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrioPat.Location = New System.Drawing.Point(670, 37)
        Me.lblPrioPat.Name = "lblPrioPat"
        Me.lblPrioPat.Size = New System.Drawing.Size(90, 25)
        Me.lblPrioPat.TabIndex = 192
        Me.lblPrioPat.Text = "Prioridad"
        '
        'GunaSeparator1
        '
        Me.transicion.SetDecoration(Me.GunaSeparator1, Guna.UI.Animation.DecorationType.None)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaSeparator1.Location = New System.Drawing.Point(205, 339)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(654, 10)
        Me.GunaSeparator1.TabIndex = 184
        '
        'mrbPMedia
        '
        Me.mrbPMedia.BaseColor = System.Drawing.Color.Silver
        Me.mrbPMedia.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPMedia.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPMedia, Guna.UI.Animation.DecorationType.None)
        Me.mrbPMedia.FillColor = System.Drawing.Color.White
        Me.mrbPMedia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPMedia.Location = New System.Drawing.Point(667, 96)
        Me.mrbPMedia.Name = "mrbPMedia"
        Me.mrbPMedia.Size = New System.Drawing.Size(74, 24)
        Me.mrbPMedia.TabIndex = 3
        Me.mrbPMedia.Text = "Media"
        '
        'lblCantDesc
        '
        Me.lblCantDesc.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCantDesc, Guna.UI.Animation.DecorationType.None)
        Me.lblCantDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantDesc.ForeColor = System.Drawing.Color.Silver
        Me.lblCantDesc.Location = New System.Drawing.Point(799, 165)
        Me.lblCantDesc.Name = "lblCantDesc"
        Me.lblCantDesc.Size = New System.Drawing.Size(41, 17)
        Me.lblCantDesc.TabIndex = 185
        Me.lblCantDesc.Text = "0/300"
        '
        'mrbPBaja
        '
        Me.mrbPBaja.BaseColor = System.Drawing.Color.Silver
        Me.mrbPBaja.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPBaja.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPBaja, Guna.UI.Animation.DecorationType.None)
        Me.mrbPBaja.FillColor = System.Drawing.Color.White
        Me.mrbPBaja.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPBaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPBaja.Location = New System.Drawing.Point(581, 95)
        Me.mrbPBaja.Name = "mrbPBaja"
        Me.mrbPBaja.Size = New System.Drawing.Size(59, 24)
        Me.mrbPBaja.TabIndex = 2
        Me.mrbPBaja.Text = "Baja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.transicion.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(204, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Recomendaciones"
        '
        'mrbPAlta
        '
        Me.mrbPAlta.BaseColor = System.Drawing.Color.Silver
        Me.mrbPAlta.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPAlta.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPAlta, Guna.UI.Animation.DecorationType.None)
        Me.mrbPAlta.FillColor = System.Drawing.Color.White
        Me.mrbPAlta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPAlta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPAlta.Location = New System.Drawing.Point(768, 96)
        Me.mrbPAlta.Name = "mrbPAlta"
        Me.mrbPAlta.Size = New System.Drawing.Size(58, 24)
        Me.mrbPAlta.TabIndex = 4
        Me.mrbPAlta.Text = "Alta"
        '
        'txtRecPat
        '
        Me.txtRecPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.BorderColor = System.Drawing.Color.Silver
        Me.txtRecPat.BorderSize = 0
        Me.txtRecPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtRecPat, Guna.UI.Animation.DecorationType.None)
        Me.txtRecPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Location = New System.Drawing.Point(204, 435)
        Me.txtRecPat.MaxLength = 300
        Me.txtRecPat.MultiLine = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecPat.Size = New System.Drawing.Size(667, 96)
        Me.txtRecPat.TabIndex = 6
        '
        'GunaSeparator2
        '
        Me.transicion.SetDecoration(Me.GunaSeparator2, Guna.UI.Animation.DecorationType.None)
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaSeparator2.Location = New System.Drawing.Point(204, 537)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(667, 10)
        Me.GunaSeparator2.TabIndex = 188
        '
        'pnlSintomas
        '
        Me.pnlSintomas.Controls.Add(Me.btnVolver)
        Me.pnlSintomas.Controls.Add(Me.scroll2)
        Me.pnlSintomas.Controls.Add(Me.scroll)
        Me.pnlSintomas.Controls.Add(Me.dgvTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlSintomas.Controls.Add(Me.lblTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.lblSintomasSeleccionados)
        Me.transicion.SetDecoration(Me.pnlSintomas, Guna.UI.Animation.DecorationType.None)
        Me.pnlSintomas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSintomas.Location = New System.Drawing.Point(0, 0)
        Me.pnlSintomas.Name = "pnlSintomas"
        Me.pnlSintomas.Size = New System.Drawing.Size(1070, 650)
        Me.pnlSintomas.TabIndex = 177
        '
        'btnVolver
        '
        Me.transicion.SetDecoration(Me.btnVolver, Guna.UI.Animation.DecorationType.None)
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
        Me.transicion.SetDecoration(Me.scroll2, Guna.UI.Animation.DecorationType.None)
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(611, 229)
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
        Me.transicion.SetDecoration(Me.scroll, Guna.UI.Animation.DecorationType.None)
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(536, 229)
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
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        Me.transicion.SetDecoration(Me.dgvTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(164, 150)
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
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        Me.transicion.SetDecoration(Me.dgvSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(679, 150)
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
        Me.transicion.SetDecoration(Me.lblTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.Silver
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(127, 62)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(339, 70)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.transicion.SetDecoration(Me.lblSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.Silver
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(656, 71)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(312, 55)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.transicion.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlPatologia.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSintomas.ResumeLayout(False)
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents transicion As Guna.UI.WinForms.GunaTransition
    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlPatologia As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblNomPat As Label
    Friend WithEvents btnReg As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtNomPat As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCantRec As Label
    Friend WithEvents lblDescPat As Label
    Friend WithEvents btnSintomas As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtDescPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblPrioPat As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents mrbPMedia As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblCantDesc As Label
    Friend WithEvents mrbPBaja As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents mrbPAlta As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents txtRecPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents pnlSintomas As Panel
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
End Class
