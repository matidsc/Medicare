Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False
    Private contPac As New ControladorPaciente
    Public Property maxID As Int32
    Private Shared instancia As frmChat
    Public instanciaChat As ucchat = New ucchat()
    Dim scrollHelper2 As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As frmChat

        If instancia Is Nothing Then
            instancia = New frmChat
        End If

        Return instancia
    End Function

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Chat, scroll, True)
        scrollHelper2 = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlChats, scroll2, True)

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then

            Dim i As Integer = 120

            Me.CenterToScreen()
            Me.SuspendLayout()

            pnlWrapChat.Width += i
            pnlWrapChat.Location = New Point((Me.Width - pnlWrapChat.Width) \ 2, (Me.Height - pnlWrapChat.Height) \ 2)

            Panel1.Width += i
            txtMsg.Width += i
            txtMsg.Location = New Point(txtMsg.Location.X + i, txtMsg.Location.Y)
            'txtMsg.Width += i
            'lblEscriba.Location = New Point(lblEscriba.Location.X - i, lblEscriba.Location.Y)

            Chat.Location = New Point(Chat.Location.X - i, Chat.Location.Y)
            Chat.Width += i
            Chat.Height += 50
            Chat.Location = New Point(Chat.Location.X, Chat.Location.Y - 50)

            Me.ResumeLayout()

            btnFinalizar.Visible = False
            'btnFicha.Visible = False
            btnSintomasDiag.Visible = False

            pnlChats.Visible = False
            scroll.Visible = False
            ' b.Location = New Point((pnlWrapChat.Width - pnlAcciones.Width) \ 2, pnlAcciones.Location.Y)          


            'Me.BackColor = Color.WhiteSmoke
            'pnlWrapChat.BackColor = Color.White
            'Chat.BackColor = Color.White
        Else
            ' updateChats() dgv viejo

            CargarPanel(contChat.listarMisChats(Datos_Temporales.userLog, 0))
            'Dim ScrollHelper2 As Guna.UI.Lib.ScrollBar.PanelScrollHelper
            'ScrollHelper2 = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel1, scroll, True)
        End If
        ScrollHelper.UpdateScrollBar()
        scrollHelper2.UpdateScrollBar()

        'Chat.AutoScroll = False

        Chat.HorizontalScroll.Enabled = False

        pnlChats.HorizontalScroll.Enabled = False
        Chat.HorizontalScroll.Visible = False

        pnlChats.HorizontalScroll.Visible = False

        'Chat.AutoScroll = True

        Update()

    End Sub

    Public Sub New()

        InitializeComponent()
        Update()
        instancia = Me
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Datos_Temporales.idchat = ControladorChat.Singleton.ObtenerChatPaciente
        End If

    End Sub

    Private Sub CargarPanel(Listado As DataTable)

        pnlChats.SuspendLayout()
        pnlChats.Controls.Clear()

        Dim UltimoMensaje As New DataTable
        Dim mensaje As String = ""
        Dim fecha As Date


        For Each panel As DataRow In Listado.Rows

            UltimoMensaje.Clear()
            UltimoMensaje = contChat.GetMensaje(panel.Item(1))

            For Each columnaMensaje As DataRow In UltimoMensaje.Rows
                mensaje = columnaMensaje.Item(0)
                fecha = columnaMensaje.Item(1)
            Next

            Dim form As New ucchat(panel.Item(2) & " " & panel.Item(3), mensaje, fecha, panel.Item(1), panel.Item(0), panel.Item(4))

            form.Width = Chat.Width - 25
            pnlChats.Controls.Add(form)
            form.Show()
            mensaje = ""
            fecha = Nothing
        Next

        pnlChats.ResumeLayout()

    End Sub

    Public Sub ReloadChat()

        maxID = 0
        Dim Mensajes As DataTable = contChat.recargarChat
        Chat.SuspendLayout()
        Chat.Controls.Clear()

        For Each mensaje As DataRow In Mensajes.Rows

            Dim esEmisor As Boolean = False

            If mensaje.Item(0) = Datos_Temporales.userLog Then
                esEmisor = True
            End If

            Dim msj As New Mensaje(esEmisor, mensaje.Item(1), mensaje.Item(2), mensaje.Item(3), Nothing)

            If msj.idMsj > maxID Then
                maxID = msj.idMsj
            End If
            msj.TopLevel = False
            msj.Width = Chat.Width - 25
            Chat.Controls.Add(msj)

            msj.Show()
            msj.Visible = True
        Next

        Chat.ResumeLayout()
        Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Chat.Controls.Count = 0 Then
            ReloadChat()
        Else
            ReloadSentMessage()
        End If

    End Sub

    Private Function finalizar() As Boolean

        If Chat.Controls.Count > 0 And Datos_Temporales.idchat <> "" Then

            Dim respuesta = MsgBox("¿Desea finalizar la sesión de chat?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                If contChat.finalizarChat() Then

                    MsgBox("Sesión finalizada")
                    'updateChats() dgv viejo
                    Chat.Controls.Clear()
                    Datos_Temporales.idchat = Nothing
                    Timer1.Enabled = False
                    Return True

                Else
                    MsgBox("Error al finalizar el chat")
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Private Sub ReloadSentMessage()

        Dim Mensajes As DataTable = contChat.RecargarChatNuevoMSJ(maxID)

        For Each var As DataRow In Mensajes.Rows
            Dim esEmisor As Boolean = False

            If var.Item(0) = Datos_Temporales.userLog Then
                esEmisor = True
            End If

            Dim msj As New Mensaje(esEmisor, var.Item(1), var.Item(2), var.Item(3), Nothing)
            maxID = msj.idMsj
            msj.TopLevel = False
            msj.Width = Chat.Width - 25
            Chat.Controls.Add(msj)
            msj.Show()
            Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()
            Chat.Update()
        Next
    End Sub

    Private Sub enviarMensaje()


        If txtMsg.Text <> "" Then
            If Datos_Temporales.idchat IsNot Nothing Then
                If contChat.enviarMensaje(Datos_Temporales.userLog, Datos_Temporales.idchat, txtMsg.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) Then
                    lblEscriba.Focus()
                    ReloadSentMessage()
                    'Dim Listado As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)
                    'CargarPanel(Listado)


                    Dim nuevoMensaje As New DataTable
                    Dim mensaje As String

                    'For Each var As Form1 In FlowLayoutPanel1.Controls

                    '    nuevoMensaje.Clear()
                    '    nuevoMensaje = contChat.GetMensaje(var.lblidChat.Text)

                    '    If var.lblidChat.Text = nuevoMensaje.Rows.Item(0).Item(3) Then

                    '        For Each columnaMensaje As DataRow In nuevoMensaje.Rows
                    '            mensaje = columnaMensaje.Item(0)
                    '        Next

                    '        var.lblMensaje.Text = mensaje
                    '    End If

                    'Next
                    txtMsg.Text = Nothing

                Else
                    MsgBox("Error al enviar el mensaje")
                End If
            End If
        End If
    End Sub

    Private Sub txtMensaje_GotFocus(sender As Object, e As EventArgs)

        If txtMsg.Text = Nothing Then
            lblEscriba.Visible = True
        Else
            lblEscriba.Visible = False
        End If

    End Sub
    Private Sub txtMensaje_LostFocus(sender As Object, e As EventArgs)

        If txtMsg.Text = Nothing Then
            lblEscriba.Visible = True
        End If

    End Sub

    'Private Sub updateChats()

    '    dgvMisChats.DataSource = contChat.listarMisChats(Datos_Temporales.userLog, 0)
    '    dgvMisChats.Columns("idChat").Visible = False

    '    dgvFinalizados.DataSource = contChat.listarMisChats(Datos_Temporales.userLog, 1)
    '    dgvFinalizados.Columns("idChat").Visible = False

    'End Sub

    Private Sub pbCancelar_Click(sender As Object, e As EventArgs)
        finalizar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'updateChats()
        'Dim Listado As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)

        'If Listado.Rows.Count <> FlowLayoutPanel1.Controls.Count Then
        '    CargarPanel(Listado)
        'End If

    End Sub





    'Private Sub dgvMisChats_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    '    Dim fila As Integer = dgvMisChats.CurrentCell.RowIndex
    '    Dim controladorChat As New ControladorChat
    '    Chat.Controls.Clear()

    '    Datos_Temporales.idchat = dgvMisChats.Rows(fila).Cells(columnName:="idChat").Value.ToString
    '    Datos_Temporales.pacienteSelecionado = dgvMisChats.CurrentCell.Value.ToString

    '    txtMsg.Enabled = True
    '    btnFinalizar.Enabled = True

    '    lblEscriba.Text = "Escriba un mensaje"

    '    setNombreUsuario(dgvMisChats.CurrentCell.Value)
    '    controladorChat.recargarChat()

    'End Sub
    Public Sub recargar()
        ' ReloadChat()
        Chat.Controls.Clear()
        Timer1.Start()
    End Sub
    'Private Sub dgvFinalizados_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    '    Dim controladorChat As New ControladorChat
    '    Dim fila As Integer = dgvFinalizados.CurrentCell.RowIndex
    '    Chat.Controls.Clear()

    '    Datos_Temporales.idchat = dgvFinalizados.Rows(fila).Cells(columnName:="idChat").Value.ToString

    '    txtMsg.Enabled = False
    '    btnFinalizar.Enabled = False

    '    lblEscriba.Text = "Chat finalizado, no es posible enviar un mensaje"

    '    setNombreUsuario(dgvFinalizados.CurrentCell.Value)
    '    controladorChat.recargarChat()

    'End Sub

    Public Sub setNombreUsuario(cedula As String)

        Dim controladorchat As New ControladorChat
        Dim dt As DataTable = controladorchat.getNombreUsr(cedula)

        lblUsuario.Text = dt.Rows.Item(0).Item(0) & " " & dt.Rows.Item(0).Item(1)

    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            enviarMensaje()
        End If

    End Sub

    Private Sub lblEscriba_Click(sender As Object, e As EventArgs) Handles lblEscriba.Click
        txtMsg.Focus()
    End Sub

    Private Sub pnlWrapChat_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlWrapChat.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlWrapChat_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlWrapChat.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlWrapChat_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlWrapChat.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub





    'Private Shared thread As New Threading.Thread(New Threading.ThreadStart(AddressOf cargarPanel))
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
        'thread.Start()
    End Sub
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If finalizar() Then

            Dim correoPaciente = contChat.getCorreo(Datos_Temporales.pacienteSelecionado)
            Dim mensajeEnviar = contChat.setFormato

            If correoPaciente <> Nothing And mensajeEnviar <> Nothing Then

                If contChat.enviarCorreo(correoPaciente, mensajeEnviar) Then
                    MsgBox("Se ha enviado el historial al paciente")
                    'updateChats()
                Else
                    MsgBox("Error al enviar el correo")
                End If

            End If
        End If
    End Sub

    Private Sub txtMsg_TextChanged(sender As Object, e As EventArgs) Handles txtMsg.TextChanged
        If Not (txtMsg.Text = Nothing) Then
            lblEscriba.Visible = False
        Else
            lblEscriba.Visible = True
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
            Me.Dispose()

        Else
            Datos_Temporales.idchat = Nothing
            Principal.Singleton.CambiarTamaño(frmListadoChat)
            Me.Dispose()
        End If
    End Sub

    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviarMensaje()
        End If
    End Sub

    Private Sub pbEnviar_Click(sender As Object, e As EventArgs) Handles pbEnviar.Click
        enviarMensaje()
    End Sub

    Private Sub pnlWrapChat_Paint(sender As Object, e As PaintEventArgs) Handles pnlWrapChat.Paint

    End Sub

    Private Sub Chat_Paint(sender As Object, e As PaintEventArgs) Handles Chat.Paint

    End Sub

    Private Sub pnlUsuario_Click(sender As Object, e As EventArgs) Handles pnlUsuario.Click

        If UcFicha1.Visible = False Then

            UcFicha1.Visible = True
            UcFicha1.BringToFront()
            Dim dt As DataTable = contPac.getDatosPaciente(Datos_Temporales.pacienteSelecionado)

            For Each datarow As DataRow In dt.Rows
                UcFicha1.lblNom.Text += " " & datarow.Item(0) & " " & datarow.Item(2) & " " & datarow.Item(3)
                Dim fechaNacimiento As Date = datarow.Item(4)
                Dim edad As Integer = Date.Now.Year - fechaNacimiento.Year
                UcFicha1.lblEdad.Text += " " & edad.ToString
                UcFicha1.lblSexo.Text += " " & datarow.Item(5)
                UcFicha1.lblMail.Text += " " & datarow.Item(6)
            Next
            'UcFicha1.dgvPatCron.DataSource = contPac.getPatologiasCronicas(Datos_Temporales.pacienteSelecionado)
        Else
            UcFicha1.Visible = False
            UcFicha1.lblEdad.Text = "Edad:"
            UcFicha1.lblMail.Text = "Mail:"
            UcFicha1.lblSexo.Text = "Sexo:"
            UcFicha1.lblNom.Text = "Nombre completo:"

        End If





    End Sub
End Class