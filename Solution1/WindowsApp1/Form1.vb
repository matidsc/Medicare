Public Class Form1

    Private nomPanelActual As String = Nothing
    Private cantPaneles As Byte = 0 'nombres unicos de controles
    Private titulos() As String = {"Patologías", "Síntomas", "Registro de usuarios", "Ajustes", "Usuarios", "Mi perfil", "Ayuda"}
    Private subtitulos() As String =
        {"Registrar, modificar, eliminar y buscar patologías",
        "Registrar, modificar, eliminar y buscar síntomas",
        "Registrar médicos y gestores en la aplicación",
        "Entrar a la configuración de la aplicación",
        "Buscar, modificar o eliminar usuarios",
        "Ver y configurar Perfil",
        "Cómo usar la aplicación"}

    Private imagenes() As Image = {
        My.Resources.doctor,
        My.Resources.doctor,
        My.Resources.doctor,
        My.Resources.doctor,
        My.Resources.doctor,
        My.Resources.doctor,
        My.Resources.doctor}

    Public Sub addPanel()

        Dim pnl As New Panel
        cantPaneles += 1

        With pnl
            .BackColor = Color.White
            .Size = New Size(190, 240)
            .Name = "pnl" & (cantPaneles).ToString
            .Margin = New Padding(10)
            .Cursor = Cursors.Hand
            .Tag = cantPaneles
            .Margin = New System.Windows.Forms.Padding(100)
        End With

        roundedCorners(pnl)
        flowpnl.Controls.Add(pnl)
        nomPanelActual = pnl.Name

        AddHandler pnl.MouseEnter, AddressOf hoverEvent
        AddHandler pnl.MouseLeave, AddressOf leaveEvent
        AddHandler pnl.Click, AddressOf clickEvent

    End Sub
    Public Function getpnlWIdth() As Integer

        For Each ctrl As Control In flowpnl.Controls

            If ctrl.Name = nomPanelActual Then ' la ubicacion se setea despues de que se crea el panel, se basa en el ultimo panel creado
                Return ctrl.Width
            End If
        Next

    End Function


    '' AÑADIR HANDLER DE HOVER Y LEAVE CON UN FOR EACH
    Public Function setTitulo(titulo As String) As Label

        Dim lblTitulo As New Label

        With lblTitulo

            .AutoSize = False
            .Width = 160
            .Height = 38
            .TextAlign = ContentAlignment.MiddleCenter
            .Name = "lblTitulo" & (cantPaneles).ToString
            .Font = New Font("Roboto", 12, FontStyle.Regular)
            .Text = titulo
            .Location = New Point(getpnlWIdth() \ 2 - lblTitulo.Width \ 2, 10)
            .Tag = cantPaneles

        End With

        AddHandler lblTitulo.Click, AddressOf clickEvent
        AddHandler lblTitulo.MouseEnter, AddressOf hoverEvent
        AddHandler lblTitulo.MouseLeave, AddressOf leaveEvent

        Return lblTitulo

    End Function

    Public Function setSubtitulo(subtitulo As String) As Label
        Dim lblSubtitulo As New Label

        With lblSubtitulo
            .AutoSize = False
            .Height = 62
            .Width = 157
            .TextAlign = ContentAlignment.MiddleCenter
            .Location = New Point(getpnlWIdth() \ 2 - lblSubtitulo.Width \ 2, 140)
            .Name = "lblTitulo" & (cantPaneles).ToString
            .Font = New Font("Roboto", 12, FontStyle.Regular)
            .Text = subtitulo
            .Tag = cantPaneles
        End With

        AddHandler lblSubtitulo.Click, AddressOf clickEvent
        AddHandler lblSubtitulo.MouseEnter, AddressOf hoverEvent
        AddHandler lblSubtitulo.MouseLeave, AddressOf leaveEvent

        Return lblSubtitulo

    End Function

    Public Function setImagen(origen As Image) As PictureBox

        Dim pb As New PictureBox

        With pb
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Size(45, 45)
            .Location = New Point(getpnlWIdth() \ 2 - pb.Width \ 2, 70)
            .Name = "pb" & (cantPaneles).ToString
            .Image = origen
            .Tag = cantPaneles
        End With

        AddHandler pb.Click, AddressOf clickEvent
        AddHandler pb.MouseEnter, AddressOf hoverEvent
        AddHandler pb.MouseLeave, AddressOf leaveEvent

        Return pb

    End Function
    Public Sub leaveEvent(sender As Object, e As EventArgs)

        If TypeOf sender IsNot Panel Then

            For Each ctrl As Control In flowpnl.Controls

                For Each childctrl As Control In ctrl.Controls

                    If childctrl.Name = sender.name Then
                        childctrl.Parent.BackColor = Color.White

                    End If

                Next

            Next

        Else
            sender.backcolor = Color.White ' si el usuario solo pone el mouse sobre el panel
        End If


    End Sub
    Public Sub hoverEvent(sender As Object, e As EventArgs)

        If TypeOf sender IsNot Panel Then

            For Each ctrl As Control In flowpnl.Controls

                For Each childctrl As Control In ctrl.Controls

                    If childctrl.Name = sender.name Then
                        childctrl.Parent.BackColor = Color.Yellow

                    End If

                Next

            Next

        Else
            sender.backcolor = Color.Yellow ' si el usuario solo pone el mouse sobre el panel
        End If

    End Sub
    Public Sub clickEvent(sender As Object, e As EventArgs)

        If sender.tag = 1 Then
            Form2.Show()
            Form2.BackColor = Color.Purple
        End If
        If sender.tag > 2 Then
            Form2.Close()
        End If
    End Sub
    Public Function getNombrePanel(sender As Object, e As EventArgs)

        'Dim parentPanelName As String = Nothing

        'For Each ctrl As Control In flowpnl.Controls
        '    For Each childctrl As Control In ctrl.Controls
        '        If childctrl.Name = sender.name Then
        '            parentPanelName = childctrl.Parent.Name

        '        End If
        '    Next
        'Next

        'Return parentPanelName 'retorna el nombre del panel "padre"

        'For Each ctrl As Control In flowpnl.Controls
        '    If ctrl.Name = parentPanelName Then
        '        If parentPanelName = "pnl1" Then
        '            Form2.Show()
        '        End If
        '    End If
        'Next


    End Function
    Public Sub roundedCorners(rect As Object)

        Dim gp As New Drawing2D.GraphicsPath()
        Dim radio As Integer = 10

        gp.StartFigure()
        gp.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        gp.AddLine(radio, 0, rect.Width - radio, 0)
        gp.AddArc(New Rectangle(rect.Width - radio, 0, radio, radio), -90, 90)
        gp.AddLine(rect.Width, radio, rect.Width, rect.Height - radio)
        gp.AddArc(New Rectangle(rect.Width - radio, rect.Height - radio, radio, radio), 0, 90)
        gp.AddLine(rect.Width - radio, rect.Height, radio, rect.Height)
        gp.AddArc(New Rectangle(0, rect.Height - radio, radio, radio), 90, 90)
        gp.CloseFigure()

        rect.Region = New Region(gp)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        roundedCorners(Me)


        For i = 0 To 10

            Dim uc As New UCPacientes

            flowpnl.Controls.Add(uc)


            'For Each ctrl As Control In Panel1.Controls
            '    If ctrl.Name = "Label2" Then
            '        ctrl.Text = i.ToString
            '    End If
            'Next

        Next

        'For i = 0 To titulos.Length - 1

        '    addPanel()

        '    For Each ctrl As Control In flowpnl.Controls

        '        If ctrl.Name = nomPanelActual Then
        '            ctrl.Controls.Add(setImagen(imagenes(i)))
        '            ctrl.Controls.Add(setTitulo(titulos(i)))
        '            ctrl.Controls.Add(setSubtitulo(subtitulos(i)))

        '        End If

        '    Next

        'Next

    End Sub

    Private Sub flowpnl_Paint(sender As Object, e As PaintEventArgs) Handles flowpnl.Paint

    End Sub
End Class
