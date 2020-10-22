﻿Imports Logica
Imports Google.Cloud.Translation.V2

Public Class frmBienvenidaGestor
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
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

        '   Dim t As TranslationClient = TranslationClient.Create


        '  Dim result As TranslationResult = t.TranslateText(Label10.Text, LanguageCodes.English, LanguageCodes.Spanish)
        '  Label10.Text = result.TranslatedText

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)
        'Notificacion()
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
    Public Sub cargarGestores()
        Dim dt As DataTable = gestor.ListadoHabilitarGest

        If pnlFlow.Controls.Count <> dt.Rows.Count Then
            pnlFlow.Controls.Clear()
            pnlFlow.SuspendLayout()

            For Each rows As DataRow In dt.Rows

                pnlFlow.Controls.Add(New UCHabilitarGestor(rows.Item(1) + " " + rows.Item(2) + " " + rows.Item(3), rows.Item(0)))

            Next
            pnlFlow.ResumeLayout()
        End If

    End Sub
    Public Sub cargarPacientes()

        Dim dt As DataTable = gestor.ListadoHabilitarPac

        If pnlFlow.Controls.Count <> dt.Rows.Count Then
            pnlFlow.Controls.Clear()
            pnlFlow.SuspendLayout()

            For Each rows As DataRow In dt.Rows

                pnlFlow.Controls.Add(New UCHabilitarPaciente(rows.Item(1) + " " + rows.Item(2) + " " + rows.Item(3), rows.Item(0)))

            Next
            pnlFlow.ResumeLayout()
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub btnPatologia_Click(sender As Object, e As EventArgs) Handles btnPatologia.Click
        Dim frm As New frmOpciones()
        frm.op = 0
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        Dim frm As New frmOpciones()
        frm.op = 1
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim frm As New frmOpciones()
        frm.op = 2
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click, lblNotificacion.Click

        If pnlFlow.Visible = False Then

            lblNA.Location = New Point(615, 2)
            pnlFlow.Location = New Point(612, 0)
            cargarPacientes()

            pnlFlow.AutoScroll = False
            pnlFlow.HorizontalScroll.Enabled = False
            pnlFlow.HorizontalScroll.Visible = False
            pnlFlow.AutoScroll = True


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

    Private Sub btnGestores_Click(sender As Object, e As EventArgs) Handles btnGestores.Click

        If pnlFlow.Visible = False Then

            pnlFlow.Location = New Point(570, 0)
            lblNA.Location = New Point(573, 2)
            cargarGestores()



            pnlFlow.AutoScroll = False
            pnlFlow.HorizontalScroll.Enabled = False
            pnlFlow.HorizontalScroll.Visible = False
            pnlFlow.VerticalScroll.Enabled = False
            pnlFlow.VerticalScroll.Visible = False

            pnlFlow.AutoScroll = True


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

        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)

    End Sub

    Private Sub Notificacion(consulta As Short, lblNotificacion As Label, pnlNotificacion As Panel)

        Dim notificacion As Int16 = consulta

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
            lblNotificacion.Text = "0"

        End If
    End Sub

    Public Sub AjustarPnl() Handles pnlFlow.ControlRemoved

        setTamaños()
        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)

        If pnlFlow.Controls.Count = 0 Then
            lblNA.Visible = True

        End If


    End Sub
    Public Sub AjustarPnl2() Handles pnlFlow.ControlAdded
        lblNA.Visible = False
    End Sub

    Private Sub Enter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter, Panel5.MouseEnter, Panel3.MouseEnter, Panel1.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label1.MouseEnter, btnUsuarios.MouseEnter, btnSintomas.MouseEnter, btnRegistro.MouseEnter, btnPatologia.MouseEnter, IconButton1.MouseEnter

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Color.FromArgb(25, 32, 37)
        Else
            sender.backcolor = Color.FromArgb(25, 32, 37)
        End If

    End Sub

    Private Sub Leave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave, Panel5.MouseLeave, Panel3.MouseLeave, Panel1.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label1.MouseLeave, btnUsuarios.MouseLeave, btnSintomas.MouseLeave, btnRegistro.MouseLeave, btnPatologia.MouseLeave, IconButton1.MouseLeave

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.primario_DARK
        Else
            sender.backcolor = Colores.primario_DARK
        End If
    End Sub

    Private Sub UcDatosGestor1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub
End Class