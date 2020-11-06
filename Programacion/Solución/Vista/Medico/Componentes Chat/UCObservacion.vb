Imports Logica
Public Class UCObservacion
    Public Sub New(nombre As String)

        InitializeComponent()
        lblObservacion.Text += " " & nombre
        lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        If txtObservacion.Text <> Nothing And GunaTextBox1.Text <> Nothing Then

            If ControladorChat.Singleton.enviarObservacion(txtObservacion.Text, GunaTextBox1.Text) Then
                MsgBox("Observacion enviada con éxito")
                Me.Dispose()
            End If
        Else
            MsgBox("Debe llenar los campos")
        End If

    End Sub

    Private Sub txtObservacion_TextChanged(sender As Object, e As EventArgs) Handles txtObservacion.TextChanged
        lblCantDesc.Text = txtObservacion.Text.Length & "/60"
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        lblCantDesc.Text = txtObservacion.Text.Length & "/30"
    End Sub
End Class
