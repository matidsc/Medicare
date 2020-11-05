Imports Logica
Public Class frmObtenerDiagnostico

    Dim sin As New ControladorSintoma
    Dim pat As New ControladorPatologia
    Dim contador As Integer = 0
    Dim solicitud As Boolean = True
    Dim lista As New List(Of UCDiagnnostico)
    Public Shared listado As Opcion
    Private boton As Short
    Private cedPaciente As String
    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Public Sub New()

        InitializeComponent()

    End Sub
    Public Sub New(patologias As DataTable)


        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        listado = Opcion.paciente

        btnSoliChat.Text = "Ver síntomas ingresados"
        btnSoliChat.Width += 40
        btnSoliChat.Location = New Point(btnSoliChat.Location.X - 40, btnSoliChat.Location.Y)
        btnSoliChat.Image = Nothing
        lblTitulo.Text = "Mis diagnósticos de la fecha "
        lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)
        setPatologias(patologias)

    End Sub

    Public Sub New(patologias As DataTable, boton As Short, cedula As String)

        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        If boton <> 1 Or boton <> 0 Then

        Else
            listado = Opcion.medico
            Me.cedPaciente = cedula


            Me.boton = boton
            setPatologias(patologias)
            btnSoliChat.Text = "Ver síntomas del paciente"
            btnSoliChat.Width += 40
            btnSoliChat.Location = New Point(btnSoliChat.Location.X - 40, btnSoliChat.Location.Y)
            btnSoliChat.Image = Nothing
            lblTitulo.Text = "Diagnosticos del paciente"
            lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)
            listado = Opcion.medico
        End If
    End Sub

    Public Sub New(patologias As DataTable, sintomas As ArrayList)

        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        listado = Opcion.paciente
        If sin.guardarSintomas(Datos_Temporales.userLog, sintomas) Then

            If pat.guardarDiagnostico(Datos_Temporales.userLog, patologias) Then

                setPatologias(patologias)

            Else
                MsgBox("Error al registrar las patologías")
                Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
                Me.Dispose()
            End If
        Else
            MsgBox("Error al registrar los sintomas")
            Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
            Me.Dispose()
        End If


    End Sub
    Private Sub setPatologias(patologias As DataTable)

        For Each patologia In patologias.Rows
            lista.Add(New UCDiagnnostico(patologia.item(0), patologia.item(1), patologia.item(2), patologia.item(3)))
        Next

        If lista.Count > 3 Then
            btnSig.Visible = True
        Else
            btnSig.Visible = False
        End If

        If lista.Count = 1 Then

            TableLayoutPanel1.Controls.Add(lista.Item(0), 1, 0)


        ElseIf lista.Count = 2 Then

            For Each fila In lista
                TableLayoutPanel1.Controls.Add(fila)
            Next
        Else

            For i = 0 To 2
                TableLayoutPanel1.Controls.Add(lista.Item(i))
                contador += 1
            Next

        End If

        If lista.Count < 4 Then
            btnSig.Visible = False
        End If
    End Sub
    Public Enum Opcion
        paciente = 0
        medico = 1
    End Enum
    Private Sub dgvPosiblesDiagnosticos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        'If pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString) Is Nothing Then
        '    MsgBox("Error al obtener la descripción")
        'Else
        '    ucRespuesta.lblNom.Text = dgvPosiblesDiagnosticos.CurrentCell.Value.ToString
        '    ucRespuesta.lblDesc.Text = pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString)
        '    ucRespuesta.Visible = True
        'End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Visible = True
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If listado = Opcion.paciente Then
            If ControladorChat.Singleton.verificarEstadoChat Then
                Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
                Me.Dispose()
            Else
                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
                Dim frm As frmIngresarSintomas = Me.ParentForm
                frm.Dispose()
            End If
        Else
            If boton = 0 Then
                Principal.Singleton.CambiarTamaño(frmBienvenidaMedico)
                Me.Dispose()
            ElseIf boton = 1 Then
                Principal.Singleton.CambiarTamaño(frmChat)
                Me.Dispose()
            ElseIf boton = 2 Then

            End If

        End If


    End Sub

    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        TableLayoutPanel1.Controls.Clear()
        'MsgBox(contador + 3)
        Dim contador2 As Integer = contador + 2
        Dim contador1 As Integer = contador

        For i = contador1 To contador2

            If i = lista.Count Then
                btnSig.Visible = False
                Exit For
            Else

                TableLayoutPanel1.Controls.Add(lista.Item(i))
                contador += 1

            End If

        Next
        btnAnt.Visible = True

    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        contador = contador - TableLayoutPanel1.Controls.Count
        Dim tuvieja As Integer = TableLayoutPanel1.Controls.Count
        TableLayoutPanel1.Controls.Clear()

        ' MsgBox(contador)
        If (contador - 3) = 0 Then
            For i = 0 To 2
                TableLayoutPanel1.Controls.Add(lista.Item(i))

            Next
            contador = 3
        Else
            For i = (lista.Count - tuvieja) - 1 To contador - 3 Step -1
                'MsgBox(i)

                TableLayoutPanel1.Controls.Add(lista.Item(i))
                'contador -= 1

            Next

        End If


        'MsgBox(contador)
        'Dim contador1 As Integer = contador - TableLayoutPanel1.Controls.Count


        'Dim contador2 As Integer = TableLayoutPanel1.Controls.Count
        'TableLayoutPanel1.Controls.Clear()

        ''
        'For i = (lista.Count - contador2) - 1 To contador1 - 3 Step -1
        '    ' MsgBox(i)


        '    TableLayoutPanel1.Controls.Add(lista.Item(i))
        '    'contador -= 1


        'Next


        'MsgBox(contador)

        'Dim contador1 = contador - 3
        'Dim contador2 As Integer = TableLayoutPanel1.Controls.Count
        'contador1 = contador - TableLayoutPanel1.Controls.Count


        'TableLayoutPanel1.Controls.Clear()

        ''MsgBox(contador)
        'For i = (lista.Count - contador2) - 1 To contador1 - 3 Step -1
        '    ' MsgBox(i)


        '    TableLayoutPanel1.Controls.Add(lista.Item(i))
        '    contador -= 1


        'Next
    End Sub

    Private Sub TableLayoutPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles TableLayoutPanel1.ControlAdded, TableLayoutPanel1.ControlRemoved

        If contador < lista.Count Then
            btnSig.Visible = True
        End If
        If contador <= 3 Then
            btnAnt.Visible = False

        Else
            btnAnt.Visible = True

        End If



    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnSoliChat.Click
        If listado = Opcion.paciente Then
            Dim chat As New ControladorChat

            If solicitud Then
                Dim respuesta As Byte = MsgBox("¿Desea iniciar un chat?", vbYesNo)
                If respuesta = vbYes Then
                    If chat.crearChat() Then
                        MsgBox("Se ha enviado una solicitud de chat")
                        solicitud = False
                    Else
                        MsgBox("Error al crear la solicitud de chat")
                    End If
                End If
            Else
                MsgBox("Usted ya ha iniciado un chat")
            End If

        Else

            Dim ucSin As New UCPatologia(ControladorSintoma.Singleton.getSintomasIndicados(Me.cedPaciente))
            Me.Controls.Add(ucSin)
            ucSin.Show()
            ucSin.BringToFront()
            ucSin.Location = New Point((Me.Width - ucSin.Width) / 2, (Me.Height - ucSin.Height) / 2)

        End If

    End Sub

    Private Sub lblIngreseSIntomas_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub
End Class