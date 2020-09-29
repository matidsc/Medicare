Imports Logica
Public Class frmRegistrarMedico

    Dim check As New Verificacion

    Private Sub RegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCed.Select()

    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btnRegistrarMedico.Click

        If Principal.Singleton.VerificarCedula(check, txtCed.Text) Then
            If Principal.Singleton.VerificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                If check.Verificar_String(txtEspec.Text) Then

                    Dim med As New ControladorMedico(
                            txtCed.Text,
                            txtCed.Text,
                            txtPrimerNombre.Text,
                            txtSegundoNombre.Text,
                            txtPrimerApellido.Text,
                            txtSegundoApellido.Text,
                            txtEspec.Text)

                    If med.VerificarBaja(txtCed.Text) Then

                        If med.registrar() Then
                            MsgBox("Médico registrado con éxito")
                            txtCed.Clear()
                            txtPrimerNombre.Clear()
                            txtSegundoApellido.Clear()
                            txtSegundoNombre.Clear()
                            txtPrimerNombre.Clear()
                            txtPrimerApellido.Clear()
                            txtEspec.Clear()
                        Else
                            MsgBox("El médico ya fue registrado")
                        End If

                    Else
                        Dim respuesta As Integer = MsgBox("Usted se encuentra dado de baja. ¿Desea reingresar al sistema?", vbQuestion + vbYesNo + vbDefaultButton2)

                        If respuesta = vbYes Then
                            med.ReingresarUsuario(txtCed.Text)
                            txtCed.Clear()
                            txtPrimerNombre.Clear()
                            txtSegundoApellido.Clear()
                            txtSegundoNombre.Clear()
                            txtPrimerNombre.Clear()
                            txtPrimerApellido.Clear()
                            txtEspec.Clear()
                        End If

                    End If


                End If
            End If
        Else
            MsgBox("La cédula ingresada no es correcta")
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtCed.Text = Nothing And txtEspec.Text = Nothing And txtPrimerApellido.Text = Nothing And txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing) Then
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