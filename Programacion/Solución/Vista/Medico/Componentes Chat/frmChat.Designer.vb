﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Chat = New System.Windows.Forms.FlowLayoutPanel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblEscriba = New System.Windows.Forms.Label()
        Me.pnlWrapChat = New System.Windows.Forms.Panel()
        Me.pnlUsuario = New System.Windows.Forms.Panel()
        Me.pbPerfil = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMsg = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlEnviar = New Guna.UI.WinForms.GunaElipsePanel()
        Me.pbEnviar = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnFinalizar = New Guna.UI.WinForms.GunaButton()
        Me.btnSintomasDiag = New Guna.UI.WinForms.GunaButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlChats = New System.Windows.Forms.FlowLayoutPanel()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.UcFicha1 = New Vista.UCFicha()
        Me.pnlWrapChat.SuspendLayout()
        Me.pnlUsuario.SuspendLayout()
        CType(Me.pbPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlEnviar.SuspendLayout()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.AutoScroll = True
        Me.Chat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Chat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Chat.Location = New System.Drawing.Point(0, 73)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(757, 500)
        Me.Chat.TabIndex = 3
        Me.Chat.WrapContents = False
        '
        'scroll
        '
        Me.scroll.Location = New System.Drawing.Point(0, 0)
        Me.scroll.Margin = New System.Windows.Forms.Padding(0)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(10, 200)
        Me.scroll.TabIndex = 194
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
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
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Silver
        Me.lblUsuario.Location = New System.Drawing.Point(80, 24)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(79, 25)
        Me.lblUsuario.TabIndex = 11
        Me.lblUsuario.Text = "fdfdsfds"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUsuario.Visible = False
        '
        'lblEscriba
        '
        Me.lblEscriba.AutoSize = True
        Me.lblEscriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lblEscriba.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblEscriba.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscriba.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEscriba.Location = New System.Drawing.Point(19, 15)
        Me.lblEscriba.Name = "lblEscriba"
        Me.lblEscriba.Size = New System.Drawing.Size(143, 21)
        Me.lblEscriba.TabIndex = 16
        Me.lblEscriba.Text = "Escriba un mensaje"
        Me.lblEscriba.Visible = False
        '
        'pnlWrapChat
        '
        Me.pnlWrapChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlWrapChat.Controls.Add(Me.scroll)
        Me.pnlWrapChat.Controls.Add(Me.Chat)
        Me.pnlWrapChat.Controls.Add(Me.pnlUsuario)
        Me.pnlWrapChat.Controls.Add(Me.Panel1)
        Me.pnlWrapChat.Controls.Add(Me.btnFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.btnSintomasDiag)
        Me.pnlWrapChat.Location = New System.Drawing.Point(313, 0)
        Me.pnlWrapChat.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWrapChat.Name = "pnlWrapChat"
        Me.pnlWrapChat.Size = New System.Drawing.Size(757, 650)
        Me.pnlWrapChat.TabIndex = 154
        '
        'pnlUsuario
        '
        Me.pnlUsuario.Controls.Add(Me.lblUsuario)
        Me.pnlUsuario.Controls.Add(Me.pbPerfil)
        Me.pnlUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlUsuario.Location = New System.Drawing.Point(3, 3)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(401, 67)
        Me.pnlUsuario.TabIndex = 200
        '
        'pbPerfil
        '
        Me.pbPerfil.BaseColor = System.Drawing.Color.White
        Me.pbPerfil.Location = New System.Drawing.Point(16, 12)
        Me.pbPerfil.Name = "pbPerfil"
        Me.pbPerfil.Size = New System.Drawing.Size(45, 43)
        Me.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerfil.TabIndex = 157
        Me.pbPerfil.TabStop = False
        Me.pbPerfil.UseTransfarantBackground = False
        Me.pbPerfil.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblEscriba)
        Me.Panel1.Controls.Add(Me.txtMsg)
        Me.Panel1.Controls.Add(Me.pnlEnviar)
        Me.Panel1.Location = New System.Drawing.Point(16, 586)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 52)
        Me.Panel1.TabIndex = 199
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.Color.Transparent
        Me.txtMsg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtMsg.BorderColor = System.Drawing.Color.Silver
        Me.txtMsg.BorderSize = 0
        Me.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMsg.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtMsg.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtMsg.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMsg.FocusedForeColor = System.Drawing.Color.White
        Me.txtMsg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.ForeColor = System.Drawing.Color.White
        Me.txtMsg.Location = New System.Drawing.Point(0, 0)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMsg.Radius = 14
        Me.txtMsg.Size = New System.Drawing.Size(673, 52)
        Me.txtMsg.TabIndex = 196
        Me.txtMsg.TextOffsetX = 20
        Me.txtMsg.Visible = False
        '
        'pnlEnviar
        '
        Me.pnlEnviar.BackColor = System.Drawing.Color.Transparent
        Me.pnlEnviar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlEnviar.Controls.Add(Me.pbEnviar)
        Me.pnlEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlEnviar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEnviar.Location = New System.Drawing.Point(679, 0)
        Me.pnlEnviar.Name = "pnlEnviar"
        Me.pnlEnviar.Radius = 14
        Me.pnlEnviar.Size = New System.Drawing.Size(50, 52)
        Me.pnlEnviar.TabIndex = 198
        Me.pnlEnviar.Visible = False
        '
        'pbEnviar
        '
        Me.pbEnviar.BaseColor = System.Drawing.Color.White
        Me.pbEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEnviar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbEnviar.Image = Global.Vista.My.Resources.Resources.icons8_email_send_24
        Me.pbEnviar.Location = New System.Drawing.Point(0, 0)
        Me.pbEnviar.Name = "pbEnviar"
        Me.pbEnviar.Size = New System.Drawing.Size(50, 52)
        Me.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbEnviar.TabIndex = 197
        Me.pbEnviar.TabStop = False
        Me.pbEnviar.UseTransfarantBackground = False
        Me.pbEnviar.Visible = False
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
        Me.btnFinalizar.Location = New System.Drawing.Point(648, 17)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFinalizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFinalizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFinalizar.OnHoverImage = Nothing
        Me.btnFinalizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnFinalizar.Radius = 10
        Me.btnFinalizar.Size = New System.Drawing.Size(97, 42)
        Me.btnFinalizar.TabIndex = 183
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFinalizar.Visible = False
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
        Me.btnSintomasDiag.Location = New System.Drawing.Point(419, 17)
        Me.btnSintomasDiag.Name = "btnSintomasDiag"
        Me.btnSintomasDiag.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnSintomasDiag.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomasDiag.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomasDiag.OnHoverImage = Nothing
        Me.btnSintomasDiag.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomasDiag.Radius = 10
        Me.btnSintomasDiag.Size = New System.Drawing.Size(199, 42)
        Me.btnSintomasDiag.TabIndex = 181
        Me.btnSintomasDiag.Text = "Ver síntomas y diagnóstico"
        Me.btnSintomasDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSintomasDiag.Visible = False
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
        Me.btnAtras.TabIndex = 191
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.scroll2)
        Me.pnlContenedor.Controls.Add(Me.pnlChats)
        Me.pnlContenedor.Controls.Add(Me.pnlWrapChat)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.UcFicha1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 0
        '
        'pnlChats
        '
        Me.pnlChats.AutoScroll = True
        Me.pnlChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlChats.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlChats.Location = New System.Drawing.Point(0, 73)
        Me.pnlChats.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlChats.Name = "pnlChats"
        Me.pnlChats.Size = New System.Drawing.Size(313, 577)
        Me.pnlChats.TabIndex = 195
        Me.pnlChats.WrapContents = False
        '
        'scroll2
        '
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(0, 37)
        Me.scroll2.Margin = New System.Windows.Forms.Padding(0)
        Me.scroll2.Maximum = 100
        Me.scroll2.Name = "scroll2"
        Me.scroll2.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll2.Size = New System.Drawing.Size(10, 200)
        Me.scroll2.TabIndex = 195
        Me.scroll2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll2.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll2.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 6000
        '
        'UcFicha1
        '
        Me.UcFicha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.UcFicha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFicha1.Location = New System.Drawing.Point(158, 74)
        Me.UcFicha1.Name = "UcFicha1"
        Me.UcFicha1.Size = New System.Drawing.Size(747, 384)
        Me.UcFicha1.TabIndex = 196
        Me.UcFicha1.Visible = False
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
        Me.pnlWrapChat.ResumeLayout(False)
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        CType(Me.pbPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlEnviar.ResumeLayout(False)
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblEscriba As Label
    Friend WithEvents pnlWrapChat As Panel
    Friend WithEvents pnlContenedor As Panel
    Public WithEvents Chat As FlowLayoutPanel
    Friend WithEvents pbPerfil As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnSintomasDiag As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFinalizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents txtMsg As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pbEnviar As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pnlEnviar As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlUsuario As Panel
    Friend WithEvents UcFicha1 As UCFicha
    Friend WithEvents pnlChats As FlowLayoutPanel
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Timer3 As Timer
End Class
