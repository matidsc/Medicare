
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
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
        Datos_Temporales.instancia = instancia
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
            'Acá se pone el circulito con el número
        Else
            'Acá se saca el circulito
        End If

        cantNotificacion = 0

    End Sub


    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub

    Private Sub pnlCerrar_Paint(sender As Object, e As PaintEventArgs) Handles pnlCerrar.Paint

    End Sub

    Private Sub pnlReanudar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReanudar.Click
        If chatComenzo Then
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
        lblNA.Visible = True
        pnlNoti.Visible = False
        Principal.Singleton.CargarVentana(Me.pnlContenedor, frm)
        Principal.Singleton.CambiarTamaño(frmChat)
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
        Dim frm As New frmIngresarSintomas
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim frm As New frmVerPerfil
        frm.Show()
    End Sub
End Class