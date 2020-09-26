Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False
    Private contPac As New ControladorPaciente
    Public Property maxID As Int32
    Private Shared instancia As frmChat

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
        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Me.CenterToScreen()
            Me.Width = pnlWrapChat.Width
            'pnlWrapChat.Location = New Point((Me.Width - pnlWrapChat.Width) \ 2, (Me.Height - pnlWrapChat.Height) \ 2)
            pnlWrapChat.Location = New Point(0, 0)
            btnFinalizar.Visible = False
            pbFinalizar.Visible = False
            pnlYo.Visible = False
            dgvFinalizados.Visible = False
            dgvMisChats.Visible = False
            pnlAcciones.Location = New Point((pnlWrapChat.Width - pnlAcciones.Width) \ 2, pnlAcciones.Location.Y)
            lblGeneral.Visible = False
            lblFinalizados.Visible = False
            btnFicha.Visible = False
            pbFicha.Visible = False
            'Me.BackColor = Color.WhiteSmoke
            'pnlWrapChat.BackColor = Color.White
            'Chat.BackColor = Color.White
        Else
            updateChats()
            Dim Listado As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)
            CargarPanel(Listado)
        End If

        Chat.AutoScroll = False
        instancia = Me
        Chat.HorizontalScroll.Enabled = False

        FlowLayoutPanel1.HorizontalScroll.Enabled = False

        Chat.AutoScroll = True

        Update()

    End Sub

    Public Sub New()

        InitializeComponent()
        Update()
        instancia = Me
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height


    End Sub

    Private Sub CargarPanel(Listado As DataTable)



        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Controls.Clear()

        Dim UltimoMensaje As New DataTable
        Dim mensaje As String = ""
        Dim fecha As String = ""
        Dim setear As New List(Of Form1)

        For Each panel As DataRow In Listado.Rows

            UltimoMensaje.Clear()
            UltimoMensaje = contChat.GetMensaje(panel.Item(1))


            For Each columnaMensaje As DataRow In UltimoMensaje.Rows
                mensaje = columnaMensaje.Item(0)
            Next

            setear.Add(New Form1(panel.Item(2) & " " & panel.Item(3), mensaje, "", panel.Item(1), panel.ItemArray(0)))
            mensaje = ""
        Next

        For Each chat As Form1 In setear

            chat.TopLevel = False
            chat.Width = chat.Width - 25
            FlowLayoutPanel1.Controls.Add(chat)
            chat.Show()

        Next

        FlowLayoutPanel1.ResumeLayout()



    End Sub
    Public Sub ReloadChat()
        maxID = 0
        Dim Mensajes As DataTable = contChat.recargarChat
        Chat.SuspendLayout()
        Chat.Controls.Clear()
        GC.Collect()

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

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            frmBienvenidaPaciente.Show()
            Me.Dispose()

        Else
            Datos_Temporales.idchat = Nothing
            Principal.Singleton.CambiarTamaño(frmListadoChat)
            Me.Dispose()
        End If

    End Sub

    Private Function finalizar() As Boolean

        If Chat.Controls.Count > 0 And Datos_Temporales.idchat <> "" Then

            Dim respuesta = MsgBox("¿Desea finalizar la sesión de chat?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                If contChat.finalizarChat() Then

                    MsgBox("Sesión finalizada")
                    updateChats()
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

        If txtMensaje.Text <> "" Then

            If contChat.enviarMensaje(Datos_Temporales.userLog, Datos_Temporales.idchat, txtMensaje.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) Then
                lblEscriba.Focus()
                ReloadSentMessage()
                'Dim Listado As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)
                'CargarPanel(Listado)


                Dim nuevoMensaje As New DataTable
                Dim mensaje As String

                For Each var As Form1 In FlowLayoutPanel1.Controls

                    nuevoMensaje.Clear()
                    nuevoMensaje = contChat.GetMensaje(var.lblidChat.Text)

                    If var.lblidChat.Text = nuevoMensaje.Rows.Item(0).Item(3) Then

                        For Each columnaMensaje As DataRow In nuevoMensaje.Rows
                            mensaje = columnaMensaje.Item(0)
                        Next

                        var.lblMensaje.Text = mensaje
                    End If

                Next
                txtMensaje.Text = Nothing

            Else
                MsgBox("Error al enviar el mensaje")
            End If

        End If
    End Sub

    Private Sub txtMensaje_GotFocus(sender As Object, e As EventArgs)

        If txtMensaje.Text = Nothing Then
            lblEscriba.Visible = True
        Else
            lblEscriba.Visible = False
        End If

    End Sub
    Private Sub txtMensaje_LostFocus(sender As Object, e As EventArgs)

        If txtMensaje.Text = Nothing Then
            lblEscriba.Visible = True
        End If

    End Sub

    Private Sub updateChats()

        dgvMisChats.DataSource = contChat.listarMisChats(Datos_Temporales.userLog, 0)
        dgvMisChats.Columns("idChat").Visible = False

        dgvFinalizados.DataSource = contChat.listarMisChats(Datos_Temporales.userLog, 1)
        dgvFinalizados.Columns("idChat").Visible = False

    End Sub

    Private Sub pbCancelar_Click(sender As Object, e As EventArgs) Handles pbFinalizar.Click
        finalizar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'updateChats()
        'Dim Listado As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)

        'If Listado.Rows.Count <> FlowLayoutPanel1.Controls.Count Then
        '    CargarPanel(Listado)
        'End If

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click



        If finalizar() Then

            Dim correoPaciente = contChat.getCorreo(Datos_Temporales.pacienteSelecionado)
            Dim mensajeEnviar = contChat.setFormato

            If correoPaciente <> Nothing And mensajeEnviar <> Nothing Then

                If contChat.enviarCorreo(correoPaciente, mensajeEnviar) Then
                    MsgBox("Se ha enviado el historial al paciente")
                    updateChats()
                Else
                    MsgBox("Error al enviar el correo")
                End If

            End If
        End If

    End Sub



    Private Sub dgvMisChats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMisChats.CellClick

        Dim fila As Integer = dgvMisChats.CurrentCell.RowIndex
        Dim controladorChat As New ControladorChat
        Chat.Controls.Clear()

        Datos_Temporales.idchat = dgvMisChats.Rows(fila).Cells(columnName:="idChat").Value.ToString
        Datos_Temporales.pacienteSelecionado = dgvMisChats.CurrentCell.Value.ToString

        txtMensaje.Enabled = True
        btnFinalizar.Enabled = True
        pbFinalizar.Visible = True
        lblEscriba.Text = "Escriba un mensaje"

        setNombreUsuario(dgvMisChats.CurrentCell.Value)
        controladorChat.recargarChat()

    End Sub

    Private Sub dgvFinalizados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinalizados.CellClick

        Dim controladorChat As New ControladorChat
        Dim fila As Integer = dgvFinalizados.CurrentCell.RowIndex
        Chat.Controls.Clear()

        Datos_Temporales.idchat = dgvFinalizados.Rows(fila).Cells(columnName:="idChat").Value.ToString

        txtMensaje.Enabled = False
        btnFinalizar.Enabled = False
        pbFinalizar.Visible = False
        lblEscriba.Text = "Chat finalizado, no es posible enviar un mensaje"

        setNombreUsuario(dgvFinalizados.CurrentCell.Value)
        controladorChat.recargarChat()

    End Sub

    Public Sub setNombreUsuario(cedula As String)

        Dim controladorchat As New ControladorChat
        Dim dt As DataTable = controladorchat.getNombreUsr(cedula)

        lblUsuario.Text = dt.Rows.Item(0).Item(0) & " " & dt.Rows.Item(0).Item(1)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub


    Private Sub MaterialSingleLineTextField1_TextChanged(sender As Object, e As EventArgs) Handles txtMensaje.TextChanged
        If Not (txtMensaje.Text = Nothing) Then
            lblEscriba.Visible = False
        Else
            lblEscriba.Visible = True
        End If
    End Sub

    Private Sub pbEnviar_Click(sender As Object, e As EventArgs) Handles pbEnviar.Click
        enviarMensaje()
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyEventArgs) Handles txtMensaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviarMensaje()
        End If

    End Sub

    Private Sub lblEscriba_Click(sender As Object, e As EventArgs) Handles lblEscriba.Click
        txtMensaje.Focus()
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

    Private Sub btnVerSintomas_Click(sender As Object, e As EventArgs) Handles btnVerSintomas.Click

        'UcDiagnostico1.Visible = True

    End Sub

    'Private Sub btnFicha_Click(sender As Object, e As EventArgs) Handles btnFicha.Click

    '    If UcFicha1.Visible = False Then

    '        UcFicha1.Visible = True
    '        Dim dt As DataTable = contPac.getDatosPaciente(Datos_Temporales.pacienteSelecionado)

    '        For Each datarow As DataRow In dt.Rows
    '            UcFicha1.lblNom.Text += " " & datarow.Item(0) & " " & datarow.Item(2) & " " & datarow.Item(3)
    '            Dim fechaNacimiento As Date = datarow.Item(4)
    '            Dim edad As Integer = Date.Now.Year - fechaNacimiento.Year
    '            UcFicha1.lblEdad.Text += " " & edad.ToString
    '            UcFicha1.lblSexo.Text += " " & datarow.Item(5)
    '            UcFicha1.lblMail.Text += " " & datarow.Item(6)
    '        Next
    '        UcFicha1.dgvPatCron.DataSource = contPac.getPatologiasCronicas(Datos_Temporales.pacienteSelecionado)
    '        UcFicha1.dgvHistorial.DataSource = contPac.getHistorialConsultas(Datos_Temporales.pacienteSelecionado)
    '    Else
    '        UcFicha1.Visible = False
    '        UcFicha1.lblEdad.Text = "Edad:"
    '        UcFicha1.lblMail.Text = "Mail:"
    '        UcFicha1.lblSexo.Text = "Sexo:"
    '        UcFicha1.lblNom.Text = "Nombre completo:"

    '    End If




    'End Sub

    Private Sub pnlWrapChat_Paint(sender As Object, e As PaintEventArgs) Handles pnlWrapChat.Paint

    End Sub

    Private Sub dgvMisChats_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMisChats.CellContentClick

    End Sub
    'Private Shared thread As New Threading.Thread(New Threading.ThreadStart(AddressOf cargarPanel))
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        'thread.Start()
    End Sub

End Class