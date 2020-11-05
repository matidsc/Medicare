
Imports Logica
Public Class frmBienvenidaPaciente

    Dim contChat As New ControladorChat
    Private Shared instancia As New frmBienvenidaPaciente
    Private chatComenzo As Boolean = False

    Public Shared Function ObtenerInstancia() As frmBienvenidaPaciente
        Return instancia
    End Function
    Dim solicitudChat As Boolean = True
    Public Sub New()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        instancia = Me
        lblNA.Visible = True

        If Not contChat.verificarEstadoChat() Then ' si ya empezo un chat
            pnlReanudar.Location = New Point(287, 30)
            pnlReanudar.Size = New Size(393, 276)
            btnReanudar.Size = btnIngresar.Size
            Label6.Size = lblIngSin.Size
            Label6.Font = lblIngSin.Font
            Label5.Size = lblSubIngSin.Size
            Label5.Font = lblSubIngSin.Font

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlConsultaActual.Controls
                ctrl.Location = New Point((pnlConsultaActual.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            Panel6.Dock = DockStyle.Bottom

            pnlIngresar.Visible = False
            pnlConsultaActual.Visible = True
            pnlConsultaActual.BringToFront()
        Else
            pnlReanudar.Location = New Point(740, 41)
            pnlReanudar.Size = New Size(183, 248)
            pnlIngresar.Visible = True
            pnlConsultaActual.Visible = False
            pnlListado.Visible = True
            pnlListado.BringToFront()
            pnlIngresar.Location = New Point(287, 30)
            pnlIngresar.Size = New Size(393, 276)

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlIngresar.Controls
                ctrl.Location = New Point((pnlIngresar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            pnlIngresar.BringToFront()
            Panel6.Dock = DockStyle.Bottom

        End If

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
        Datos_Temporales.instancia = instancia

        If Not contChat.verificarEstadoChat() Then ' si ya empezo un chat
            pnlReanudar.Location = New Point(287, 30)
            pnlReanudar.Size = New Size(393, 276)
            btnReanudar.Size = btnIngresar.Size
            Label6.Size = lblIngSin.Size
            Label6.Font = lblIngSin.Font
            Label5.Size = lblSubIngSin.Size
            Label5.Font = lblSubIngSin.Font

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlConsultaActual.Controls
                ctrl.Location = New Point((pnlConsultaActual.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            Panel6.Dock = DockStyle.Bottom

            pnlIngresar.Visible = False
            pnlConsultaActual.Visible = True
            pnlConsultaActual.BringToFront()
        Else
            pnlReanudar.Location = New Point(740, 41)
            pnlReanudar.Size = New Size(183, 248)
            pnlIngresar.Visible = True
            pnlConsultaActual.Visible = False
            pnlListado.Visible = True
            pnlListado.BringToFront()
            pnlIngresar.Location = New Point(287, 30)
            pnlIngresar.Size = New Size(393, 276)

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlIngresar.Controls
                ctrl.Location = New Point((pnlIngresar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            pnlIngresar.BringToFront()
            Panel6.Dock = DockStyle.Bottom

        End If
    End Sub


    Dim bool As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If obtenerRespuesta() Then
            If VerificarMensaje() Then
                pnlNoti.Visible = True
                lblNA.Visible = False
                bool = True
                solicitudChat = False
            Else
                pnlNoti.Visible = False
                lblNA.Visible = True
            End If
        Else
            pnlNoti.Visible = False
            lblNA.Visible = True
        End If

    End Sub

    Public Function obtenerRespuesta() As Boolean

        If contChat.obtenerRespuesta >= 1 Then
            Return True
        End If

        Return False
    End Function

    Public Function VerificarMensaje() As Boolean

        If contChat.VerificarMensaje = 0 Then
            Return True
        End If

        Return False
    End Function

    Dim cantNotificacion As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim tabla As DataTable = contChat.Notificacion

        For Each row As DataRow In tabla.Rows
            If row.Item(0) <> Datos_Temporales.userLog Then
                cantNotificacion += 1
            Else
                Exit For
            End If
        Next

        If cantNotificacion > 0 Then
            notificacion.Text = cantNotificacion

        Else
            notificacion.Visible = False
            pnlNoti.Visible = False
        End If

        cantNotificacion = 0

    End Sub

    Private Sub pnlReanudar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReanudar.Click

        If Not ControladorChat.Singleton.verificarEstadoChat Then

            Dim frm As New frmChat
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frmChat)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()

        Else
            MsgBox("Usted aún no ha iniciado ningún chat")
        End If

    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click

        chatComenzo = True
        Dim frm As New frmChat
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmChat)
        lblNA.Visible = True
        pnlNoti.Visible = False
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()

    End Sub

    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click

        If pnlNotis.Visible = False Then
            pnlNotis.Visible = True
        Else
            pnlNotis.Visible = False
        End If

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        If contChat.DenegarChat Then
            pnlNoti.Visible = False
            lblNA.Visible = True
        Else
            MsgBox("Error al cerrar el chat")
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If contChat.verificarEstadoChat() Then
            Dim frm As New frmIngresarSintomas(0)
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        Else
            MsgBox("Usted ya ha realizado una consulta")
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

        Dim frm As frmLogin = Me.ParentForm
        frm.txtUsr.Text = Nothing
        frm.txtPass.Text = Nothing
        frm.lblUsuario.Visible = True
        frm.lblContraseña.Visible = True
        Principal.Singleton.CambiarTamaño(frmLogin)
        Me.Dispose()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If pnlOps.Visible = True Then
            pnlOps.Visible = False
        Else
            pnlOps.Visible = True
        End If

    End Sub

    Private Sub pnlReanudar_MouseClick(sender As Object, e As EventArgs) Handles btnReanudar.Click

    End Sub
    Dim chatEmpezo As Boolean
    Private Sub timVerificarSiSolicitud_Tick(sender As Object, e As EventArgs) Handles timVerificarSiSolicitud.Tick


        If Not contChat.verificarEstadoChat() Then ' si ya empezo un chat
            pnlReanudar.Location = New Point(287, 30)
            pnlReanudar.Size = New Size(393, 276)
            btnReanudar.Size = btnIngresar.Size
            Label6.Size = lblIngSin.Size
            Label6.Font = lblIngSin.Font
            Label5.Size = lblSubIngSin.Size
            Label5.Font = lblSubIngSin.Font

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlConsultaActual.Controls
                ctrl.Location = New Point((pnlConsultaActual.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            Panel6.Dock = DockStyle.Bottom

            pnlIngresar.Visible = False
            pnlConsultaActual.Visible = True
            pnlConsultaActual.BringToFront()
        Else
            pnlReanudar.Location = New Point(740, 41)
            pnlReanudar.Size = New Size(183, 248)
            pnlIngresar.Visible = True
            pnlConsultaActual.Visible = False
            pnlListado.Visible = True
            pnlListado.BringToFront()
            pnlIngresar.Location = New Point(287, 30)
            pnlIngresar.Size = New Size(393, 276)

            For Each ctrl As Control In pnlReanudar.Controls
                ctrl.Location = New Point((pnlReanudar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next

            For Each ctrl As Control In pnlIngresar.Controls
                ctrl.Location = New Point((pnlIngresar.Width - ctrl.Width) \ 2, ctrl.Location.Y)
            Next
            pnlIngresar.BringToFront()
            Panel6.Dock = DockStyle.Bottom

        End If

    End Sub

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click

        Dim frm As New frmListado(0)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmListado)
        frm.Show()
        frm.btnEliminarElementos.Visible = False
        frm.btnModificarElemento.Visible = False
        frm.btnRegistrar.Visible = False
        frm.btnSeleccionMultiple.Visible = False
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click

        Dim frm As New frmListado(3)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmListado)
        frm.Show()
        frm.btnEliminarElementos.Visible = False
        frm.btnModificarElemento.Visible = False
        frm.btnRegistrar.Visible = False
        frm.btnSeleccionMultiple.Visible = False
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
End Class