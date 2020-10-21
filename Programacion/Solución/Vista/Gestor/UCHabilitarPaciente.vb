Imports Logica
Public Class UCHabilitarPaciente

    Private gestor As New ControladorGestor


    Private Sub UCHabilitar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(nombre As String, cedula As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        lblCedula.Text = cedula
        lblNombre.Text = nombre
        Label1.Text = cedula

        lblNombre.Location = New Point((Me.Width - lblNombre.Width) \ 2, lblNombre.Location.Y)
        lblCedula.Location = New Point((Me.Width - lblCedula.Width) \ 2, lblCedula.Location.Y)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub hover(sender As Object, e As EventArgs) Handles lblCedula.MouseEnter, lblNombre.MouseEnter, Me.MouseEnter

        Me.BackColor = Color.FromArgb(21, 30, 43)
        Me.btnMasInfo.Visible = True
    End Sub
    Private Sub leave(sender As Object, e As EventArgs) Handles lblCedula.MouseLeave, lblNombre.MouseLeave, Me.MouseLeave

        Me.BackColor = Color.FromArgb(18, 25, 36)
        Me.btnMasInfo.Visible = False
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim respuesta As Integer = MsgBox("¿Desea habilitar a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.HabilitarPacientes(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        Dim respuesta As Integer = MsgBox("¿Desea dar de baja a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.eliminar(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

End Class
