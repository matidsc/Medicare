Imports Logica
Public Class frmBienvenidaMedico

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        MsgBox(ControladorMedico.Singleton.verificarPassMedico().ToLower)
        MsgBox(Encriptar.Singleton.HASH256(Datos_Temporales.userLog))

        If Encriptar.Singleton.HASH256(Datos_Temporales.userLog) = ControladorMedico.Singleton.verificarPassMedico().ToLower Then
            Dim advertencia As New UCAdvertencia
            Me.Controls.Add(advertencia)
            advertencia.Location = New Point((Me.Width - advertencia.Width) \ 2, (Me.Height - advertencia.Height) \ 2)
            advertencia.Show()
            advertencia.BringToFront()
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Me.BackColor = Color.FromArgb(236, 236, 236)
    '    Dim col As Color = Color.FromArgb(52, 73, 94)

    '    Panel1.BackColor = Color.WhiteSmoke
    '    Panel2.BackColor = Color.WhiteSmoke
    '    Panel3.BackColor = Color.WhiteSmoke
    '    Panel4.BackColor = Color.WhiteSmoke
    '    Panel5.BackColor = Color.WhiteSmoke
    '    Label1.ForeColor = col
    '    Label2.ForeColor = col
    '    Label3.ForeColor = col
    '    Label4.ForeColor = col
    '    Label5.ForeColor = col
    '    Label6.ForeColor = col
    '    Label7.ForeColor = col
    '    Label8.ForeColor = col
    '    Label9.ForeColor = col
    '    Label10.ForeColor = col
    '    Label11.ForeColor = col
    '    Label12.ForeColor = col
    '    Label13.ForeColor = col

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    Me.BackColor = Color.FromArgb(19, 19, 19)
    '    Panel1.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel2.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel3.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel4.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel5.BackColor = Color.FromArgb(64, 64, 64)
    '    Label1.ForeColor = Color.White
    '    Label2.ForeColor = Color.White
    '    Label3.ForeColor = Color.White
    '    Label4.ForeColor = Color.White
    '    Label5.ForeColor = Color.White
    '    Label6.ForeColor = Color.White
    '    Label7.ForeColor = Color.White
    '    Label8.ForeColor = Color.White
    '    Label9.ForeColor = Color.White
    '    Label10.ForeColor = Color.White
    '    Label11.ForeColor = Color.White
    '    Label12.ForeColor = Color.White
    '    Label13.ForeColor = Color.White

    'End Sub

    'Private Sub hover(sender As Object)
    '    sender.backcolor = Color.FromArgb(56, 62, 80)
    'End Sub

    'Private Sub Panel1_MouseHover_1(sender As Object, e As EventArgs) Handles Panel1.MouseHover
    '    'hover(Panel1)
    'End Sub
    'Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
    '    hover(Panel2)
    'End Sub

    'Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
    '    hover(Panel3)
    'End Sub

    'Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
    '    hover(Panel4)
    'End Sub

    'Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
    '    hover(Panel5)
    'End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim frm As New frmChat
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmChat)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
        ' Me.Timer1.Enabled = False
        '   MsgBox(Me.Timer1.Enabled)
    End Sub
    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub timerChat_Tick(sender As Object, e As EventArgs) Handles timerChat.Tick

        Dim notificacion As String = ControladorChat.Singleton.ListarNotificacionChat

        If notificacion IsNot Nothing Then
            If notificacion <> 0 Then
                If notificacion <> lblNotiChats.Text Then

                    pnlNoti.Visible = True
                    Me.lblNotiChats.Visible = True

                    If notificacion > 99 Then
                        Me.lblNotiChats.Text = "99+"

                    Else
                        Me.lblNotiChats.Text = cantNotificacion

                    End If

                    If notificacion < 10 Then
                        Me.lblNotiChats.Location = New Point(2, 1)
                    Else
                        Me.lblNotiChats.Location = New Point(-1, 1)
                    End If
                End If
            Else
                pnlNoti.Visible = False
                Me.lblNotiChats.Visible = False
            End If

        End If

    End Sub

    Dim cantNotificacion = 0
    Private Sub timerMsg_Tick(sender As Object, e As EventArgs) Handles timerMsg.Tick

        For Each row As DataRow In ControladorChat.Singleton.Notificacion.Rows 'la cantidad de mensajes nuevos desde que mandaste uno
            If row.Item(0) <> Datos_Temporales.userLog Then
                cantNotificacion += 1
            Else
                Exit For
            End If
        Next

        If cantNotificacion <> 0 Then

            If cantNotificacion <> lblNotiMsg.Text Then

                pnlNotificacion.Visible = True
                lblNotiMsg.Visible = True

                If cantNotificacion > 99 Then
                    lblNotiMsg.Text = "99+"
                    lblNuevosMsg.Text = "Tienes 99+ mensajes sin responder"
                    lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
                Else
                    lblNotiMsg.Text = cantNotificacion
                    lblNuevosMsg.Text = "Tienes " & cantNotificacion & " mensajes sin responder"
                    lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
                End If

                If cantNotificacion < 10 Then
                    lblNotiMsg.Location = New Point(2, 1)
                Else
                    lblNotiMsg.Location = New Point(-1, 1)
                End If
                lblNuevosMsg.Text = "Tienes " & cantNotificacion & " mensajes sin responder"
                lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)

            End If
        Else
            pnlNotificacion.Visible = False
            lblNotiMsg.Visible = False
            lblNotiMsg.Text = "0"
            lblNuevosMsg.Text = "No tienes mensajes nuevos"
            lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
        End If

        cantNotificacion = 0
    End Sub

    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click

        Dim dt As DataTable = ControladorChat.Singleton.listarChat
        If FlowLayoutPanel1.Visible = False Then
            FlowLayoutPanel1.Visible = True
            If dt.Rows.Count > 0 Then

                lblNAChats.Visible = False
                FlowLayoutPanel1.Controls.Clear()
                FlowLayoutPanel1.BringToFront()
                FlowLayoutPanel1.SuspendLayout()

                For Each row In dt.Rows
                    Dim uc As New UCSolicitudes(row.item(0), row.item(1), row.item(2) & " " & row.item(3), row.item(4))
                    FlowLayoutPanel1.Controls.Add(uc)
                    uc.Show()
                Next
                FlowLayoutPanel1.ResumeLayout()

            Else
                FlowLayoutPanel1.Controls.Clear()
                lblNAChats.Visible = True
            End If
        Else
            FlowLayoutPanel1.Visible = False
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If pnlOps.Visible = True Then
            pnlOps.Visible = False
        Else
            pnlOps.Visible = True
        End If
    End Sub

    Private Sub btnVerPerfil_Click(sender As Object, e As EventArgs) Handles btnVerPerfil.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        perfil.pnlCredenciales.BringToFront()
        perfil.pnlCredenciales.Visible = True
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Principal.Singleton.CambiarTamaño(frmLogin)
        Dim instancia As frmLogin = Me.ParentForm

        If instancia.mcbRecordarUsuario.Checked Then
            instancia.txtPass.Text = Nothing
            instancia.lblContraseña.Visible = True
            instancia.lblUsuario.Visible = False
        Else
            instancia.txtUsr.Text = Nothing
            instancia.txtPass.Text = Nothing
            instancia.lblContraseña.Visible = True
            instancia.lblUsuario.Visible = True
        End If

        Me.Dispose()
    End Sub

    Private Sub btnReanudar_Click(sender As Object, e As EventArgs) Handles btnReanudar.Click
        Dim frm As New frmListado(0)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmListado)
        frm.btnEliminarElementos.Visible = False
        frm.btnModificarElemento.Visible = False
        frm.btnRegistrar.Visible = False
        frm.btnSeleccionMultiple.Visible = False
        frm.Show()

        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
End Class