Imports Logica
Public Class UCHabilitarGestor
    Private gestor As New ControladorGestor
    Public Sub New(nombre As String, cedula As String)


        InitializeComponent()
        lblCedula.Text = cedula
        lblNombre.Text = nombre
        Label1.Text = cedula

        lblNombre.Location = New Point((Me.Width - lblNombre.Width) \ 2, lblNombre.Location.Y)
        lblCedula.Location = New Point((Me.Width - lblCedula.Width) \ 2, lblCedula.Location.Y)

    End Sub
    'Private Sub hover(sender As Object, e As EventArgs) Handles lblCedula.MouseEnter, lblNombre.MouseEnter, Me.MouseEnter, btnMasInfo.MouseEnter

    '    Me.BackColor = Color.FromArgb(21, 30, 43)
    '    Me.btnMasInfo.Visible = True
    'End Sub
    'Private Sub leave(sender As Object, e As EventArgs) Handles lblCedula.MouseLeave, lblNombre.MouseLeave, Me.MouseLeave, btnMasInfo.MouseLeave

    '    Me.BackColor = Color.FromArgb(18, 25, 36)
    '    Me.btnMasInfo.Visible = False
    'End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim respuesta As Integer = MsgBox("¿Desea habilitar a este gestor?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.HabilitarGestores(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        Dim respuesta As Integer = MsgBox("¿Desea dar de baja a este gestor?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.eliminar(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnMasInfo_Click(sender As Object, e As EventArgs)

        frmBienvenidaGestor.mostrar(gestor.getInformacionGestor(Label1.Text))

        'Dim row As DataRow = gestor.getInformacionGestor(Label1.Text).Rows(0)
        'MsgBox(row.Item(0))
        'frmBienvenidaGestor.Singleton.UcDatosGestor1.lblCed.Text = row.Item(0).ToString
        'frmBienvenidaGestor.Singleton.UcDatosGestor1.lblNom.Text = row.Item(1).ToString & " " & row.Item(2).ToString & " " & row.Item(3).ToString & " " & row.Item(4).ToString
        'frmBienvenidaGestor.Singleton.UcDatosGestor1.lblMail.Text = row.Item(5).ToString
        'frmBienvenidaGestor.Singleton.UcDatosGestor1.Visible = False
        'frmBienvenidaGestor.Singleton.UcDatosGestor1.BringToFront()


        'Dim info As New UCDatosGestor(gestor.getInformacionGestor(Label1.Text))
        'info.Visible = True
        'frmBienvenidaGestor.Panel9.Controls.Add(info)
        'frmBienvenidaGestor.Panel9.ResumeLayout()

        'info.Location = frmBienvenidaGestor.pnlFlow.Location

        'info.BringToFront()

    End Sub

End Class
