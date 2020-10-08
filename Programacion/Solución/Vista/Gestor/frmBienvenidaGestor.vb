Imports Logica

Public Class frmBienvenidaGestor

    Dim gestor As New ControladorGestor
    Public Shared instancia As frmBienvenidaGestor
    Public Shared Function Singleton() As frmBienvenidaGestor
        If instancia Is Nothing Then
            instancia = New frmBienvenidaGestor

        End If
        Return instancia
    End Function


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        NotificacionPacientes()
        instancia = Me
        pnlFlow.AutoScroll = False
        pnlFlow.HorizontalScroll.Enabled = False
        pnlFlow.HorizontalScroll.Visible = False
        pnlFlow.AutoScroll = True
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlFlow, scroll, True)
        ' pnlFlow.HorizontalScroll.Enabled = False

        ' pnlFlow.Width += scroll.Width
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Public Sub cargarHabilitados()

        Dim dt As DataTable = gestor.listarPacientes

        If pnlFlow.Controls.Count <> dt.Rows.Count Then
            pnlFlow.Controls.Clear()
            For Each rows As DataRow In dt.Rows

                pnlFlow.Controls.Add(New UCHabilitar(rows.Item(1) + " " + rows.Item(2) + " " + rows.Item(3), rows.Item(0)))

            Next

        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs)
        frmManualCsv.Show()
    End Sub

    Private Sub btnPatologia_Click(sender As Object, e As EventArgs) Handles btnPatologia.Click
        Dim frm As New frmModular()
        frm.op = 0
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        Dim frm As New frmModular()
        frm.op = 1
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim frm As New frmModular()
        frm.op = 2
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click, lblNotificacion.Click

        If pnlFlow.Visible = False Then
            cargarHabilitados()
            If pnlFlow.Controls.Count = 0 Then
                lblNA.Visible = True
            End If
            setTamaños()
            pnlFlow.Visible = True
        Else
            pnlFlow.Visible = False
            scroll.Visible = False
            lblNA.Visible = False
        End If

    End Sub
    Public Sub setTamaños()
        If pnlFlow.Controls.Count < 4 Then
            scroll.Enabled = False
            scroll.Visible = False
            pnlFlow.Width = 315
        Else
            pnlFlow.Width = 335
        End If
    End Sub


    Private Sub tempListaPacientes_Tick(sender As Object, e As EventArgs) Handles tempListaPacientes.Tick

        NotificacionPacientes()


    End Sub

    Private Sub NotificacionPacientes()
        Dim notificacion As Int16 = gestor.NotificacionListado

        If notificacion <> 0 Then

            If notificacion <> lblNotificacion.Text Then

                pnlNotificacion.Visible = True
                lblNotificacion.Visible = True

                If notificacion > 99 Then
                    lblNotificacion.Text = "99+"
                Else
                    lblNotificacion.Text = notificacion
                End If

                If notificacion < 10 Then
                    lblNotificacion.Location = New Point(2, 1)
                Else
                    lblNotificacion.Location = New Point(-1, 1)
                End If

            End If
        Else
            pnlNotificacion.Visible = False
            lblNotificacion.Visible = False


        End If
    End Sub

    Public Sub AjustarPnl() Handles pnlFlow.ControlRemoved

        setTamaños()
        NotificacionPacientes()

        If pnlFlow.Controls.Count = 0 Then
            lblNA.Visible = True

        End If


    End Sub
    Public Sub hola() Handles pnlFlow.ControlAdded
        lblNA.Visible = False
    End Sub
End Class