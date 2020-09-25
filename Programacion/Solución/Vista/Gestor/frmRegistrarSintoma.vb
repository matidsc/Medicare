Imports Logica
Public Class frmRegistrarSintoma

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles mrbtnRegistrarSintoma.Click

        If txtDescripcion.Text.Length > 10 Then
            Dim sintoma As New ControladorSintoma(txtNomSintoma.Text, txtDescripcion.Text)

            If sintoma.registrar(0, Nothing) Then
                MsgBox("Síntoma registrado con éxito")
                txtDescripcion.Clear()
                txtNomSintoma.Clear()
            Else
                MsgBox("Error al registrar el síntoma")
            End If

        Else
            MsgBox("Debe completar la descripción")
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtNomSintoma.Text = Nothing And txtDescripcion.Text = Nothing) Then
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmModular)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmModular)
            Me.Dispose()
        End If

    End Sub
End Class