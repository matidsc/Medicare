Imports Logica
Public Class frmRegistrarSintoma

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        If Not (txtNom.Text = Nothing And txtDescripcion.Text = Nothing) Then
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtDescripcion.Text.Length > 10 Then
            Dim sintoma As New ControladorSintoma(txtNom.Text, txtDescripcion.Text)

            If sintoma.Registrar() Then
                MsgBox("Síntoma registrado con éxito")
                txtDescripcion.Text = Nothing
                txtNom.Text = Nothing
            Else
                MsgBox("Error al registrar el síntoma")
            End If

        Else
            MsgBox("Debe completar la descripción")
        End If

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        lblCantText.Text = txtDescripcion.Text.Length & "/300"
    End Sub
End Class