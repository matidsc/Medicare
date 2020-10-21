﻿Imports Logica
Public Class frmRegistrarMedico

    Dim check As New Verificacion

    Public Sub New()

        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

    End Sub

    Private Sub btnRegistrarMedico_Click(sender As Object, e As EventArgs) Handles btnRegistrarMedico.Click

        If Principal.Singleton.VerificarCedula(check, txtCed.Text) Then
            If Principal.Singleton.VerificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                If check.Verificar_String(txtEspec.Text) Then
                    If check.VerificarEmail(txtMail.Text) Then

                        Dim med As New ControladorMedico(
                            txtCed.Text,
                            txtCed.Text,
                            txtPrimerNombre.Text.ToUpper,
                            txtSegundoNombre.Text.ToUpper,
                            txtPrimerApellido.Text.ToUpper,
                            txtSegundoApellido.Text.ToUpper,
                            txtEspec.Text.ToUpper,
                            txtMail.Text())

                        If med.VerificarBaja(txtCed.Text) Then

                            If med.registrar() Then
                                MsgBox("Médico registrado con éxito")
                                limpiar()
                            Else
                                MsgBox("El médico ya fue registrado")
                            End If

                        Else
                            Dim respuesta As Integer = MsgBox("El médico se ecuentra dado de baja. ¿Desea reingresar al sistema?", vbQuestion + vbYesNo + vbDefaultButton2)

                            If respuesta = vbYes Then
                                med.ReingresarUsuario(txtCed.Text)
                                limpiar()
                            End If

                        End If

                    Else
                        MsgBox("El correo ingresado no es correcto")
                    End If

                End If
            End If
        Else
            MsgBox("La cédula ingresada no es correcta")
        End If

    End Sub
    Private Sub limpiar()
        txtCed.Text = Nothing
        txtPrimerNombre.Text = Nothing
        txtSegundoApellido.Text = Nothing
        txtSegundoNombre.Text = Nothing
        txtPrimerNombre.Text = Nothing
        txtPrimerApellido.Text = Nothing
        txtEspec.Text = Nothing
        txtMail.Text = Nothing
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtCed.Text = Nothing And txtEspec.Text = Nothing And txtPrimerApellido.Text = Nothing And txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing) Then
            Dim res = MsgBox("Hay información sin guardar, ¿Seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        End If
    End Sub

End Class