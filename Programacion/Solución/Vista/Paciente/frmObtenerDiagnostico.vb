Imports Logica
Public Class frmObtenerDiagnostico

    Dim sin As New ControladorSintoma
    Dim pat As New ControladorPatologia
    Dim solicitud As Boolean = True
    Dim contador As Integer = 0
    Dim lista As New List(Of UCDiagnnostico)
    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Public Sub New()

        InitializeComponent()

    End Sub


    Public Sub New(patologias As DataTable, sintomas As ArrayList)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If sin.guardarSintomas(Datos_Temporales.userLog, sintomas) Then

            If pat.guardarDiagnostico(Datos_Temporales.userLog, patologias) Then

                'TableLayoutPanel1.SuspendLayout()

                'TableLayoutPanel1.ColumnCount = patologias.Rows.Count

                'For Each patologia In patologias.Rows
                '    TableLayoutPanel1.ColumnCount += 1
                '    TableLayoutPanel1.Controls.Add(New UCDiagnnostico(patologia.item(0), patologia.item(1), patologia.item(2)))
                '    MsgBox(TableLayoutPanel1.ColumnCount)
                'Next

                '  TableLayoutPanel1.ResumeLayout()

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

    Private Sub dgvPosiblesDiagnosticos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        'If pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString) Is Nothing Then
        '    MsgBox("Error al obtener la descripción")
        'Else
        '    ucRespuesta.lblNom.Text = dgvPosiblesDiagnosticos.CurrentCell.Value.ToString
        '    ucRespuesta.lblDesc.Text = pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString)
        '    ucRespuesta.Visible = True
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        solicitud = True
        Me.Dispose()
    End Sub

    Private Sub btnSolicitarChat_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Visible = True
    End Sub


    Private Sub dgvPosiblesDiagnosticos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        Me.Dispose()
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
                ' MsgBox("tuvieja")
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

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Dim chat As New ControladorChat

        If solicitud Then
            Dim respuesta As Byte = MsgBox("¿Desea iniciar un chat?", vbYesNo)
            If respuesta = vbYes Then
                If chat.crearChat() <> 0 Then
                    If chat.entrarChat(Datos_Temporales.userLog, Datos_Temporales.idchat) Then

                        MsgBox("Se ha enviado una solicitud de chat")
                        solicitud = False

                    Else
                        MsgBox("Error al enviar solicitud de chat")
                    End If
                End If
            End If
        Else
            MsgBox("Ya hay una solicitud en curso")
        End If

    End Sub

    Private Sub lblIngreseSIntomas_Click(sender As Object, e As EventArgs) Handles lblIngreseSIntomas.Click

    End Sub
End Class