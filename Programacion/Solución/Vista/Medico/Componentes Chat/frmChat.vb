Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False
    Private contPac As New ControladorPaciente
    Public Property maxID As Int32
    Public instanciaChat As ucchat = New ucchat()
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim scrollHelper2 As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim id As New ArrayList

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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

            'pbPerfil.Visible = True
            'btnFinalizar.Visible = True
            'btnSintomasDiag.Visible = True
            pbEnviar.Visible = True
            txtMsg.Visible = True
            lblEscriba.Visible = True
            pnlEnviar.Visible = True
            'Me.BackColor = Color.WhiteSmoke
            'pnlWrapChat.BackColor = Color.White
            'Chat.BackColor = Color.White
        Else
            ' updateChats() dgv viejo

            ActualizarPanel()
            'Dim ScrollHelper2 As Guna.UI.Lib.ScrollBar.PanelScrollHelper
            'ScrollHelper2 = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel1, scroll, True)
        End If


        'Chat.AutoScroll = False

        Chat.HorizontalScroll.Enabled = False
        Chat.HorizontalScroll.Visible = False



        'Chat.AutoScroll = True

        Update()

    End Sub

    Public Sub New()

        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height









        'pnlChats.AutoScroll = False
        'pnlChats.HorizontalScroll.Enabled = False
        'pnlChats.HorizontalScroll.Visible = False
        'pnlChats.AutoScroll = True






        ScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Chat, scroll, True)
        scrollHelper2 = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlChats, scroll2, True)

        'ScrollHelper.UpdateScrollBar()
        'scrollHelper2.UpdateScrollBar()

        Update()

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

            pnlChats.Controls.Add(form)
            form.Show()
            mensaje = ""
            fecha = Nothing
            id.Add(panel.Item(1))
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
            instanciaChat.lblMensaje.Text = mensaje.Item(1)
            msj.Show()
            msj.Visible = True
        Next


        ' Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()

        'ScrollHelper.UpdateScrollBar()
        Chat.ResumeLayout()
        'scroll.Value = 3097
        Try
            Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum
            scroll.Refresh()
            scroll.Value = scroll.Value + 2749
            'scroll.Update()
            ScrollHelper.UpdateScrollBar()
        Catch ex As Exception
            MsgBox("asdas")
        End Try

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

        Dim SetearLista As Boolean = False
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
            instanciaChat.lblMensaje.Text = var.Item(1)
            ActualizarPanel()
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

    Private Sub pnlChats_Paint(sender As Object, e As PaintEventArgs) Handles pnlChats.Paint

    End Sub

    Private Sub scroll_Scroll(sender As Object, e As ScrollEventArgs) Handles scroll.Scroll
        ScrollHelper.UpdateScrollBar()
        Console.WriteLine(scroll.Value & "    " & scroll.Maximum & "  " & Chat.VerticalScroll.Maximum)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMsg.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

        End If

    End Sub
    Private Sub ActualizarPanel()
        Dim dt As DataTable = contChat.listarMisChats(Datos_Temporales.userLog, 0)
        Dim contador As Integer = 0

        If dt.Rows.Count <> pnlChats.Controls.Count Then
            CargarPanel(dt)
            id.Reverse()
        Else
            Dim dt2 As ArrayList = ControladorChat.Singleton.orden

            If dt2.Count = id.Count Then


                For i As Integer = 0 To dt2.Count - 1

                    If dt2.Item(i) = id.Item(i) Then
                        contador += 1
                    Else
                        Exit For
                    End If

                Next
            End If

            If contador <> dt2.Count Then
                id.Clear()
                For Each fila In dt2
                    For Each control As ucchat In pnlChats.Controls
                        If fila = control.lblidChat.Text Then
                            pnlChats.Controls.SetChildIndex(control, 0)
                        End If
                    Next
                    id.Add(fila)
                Next
            End If

        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ActualizarPanel()
    End Sub


End Class