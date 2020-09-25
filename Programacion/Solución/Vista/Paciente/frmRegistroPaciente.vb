﻿Imports Logica
Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim pass As String
    Dim sexo As String

    Public Sub New()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles mrbtnSolicitarCuenta.Click

        If txtCI.Text <> "" And txtPass.Text <> "" And txtRepPass.Text <> "" And txtPNom.Text <> "" And txtPApe.Text <> "" And txtSNom.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" And txtFecNac.Text <> "" Then
            If Principal.Singleton.VerificarCedula(check, txtCI.Text) Then
                If Principal.Singleton.VerificarContraseña(seg, txtPass.Text, txtRepPass.Text) Then
                    pass = seg.HASH256(txtPass.Text)
                    If Principal.Singleton.VerificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                        If Principal.Singleton.VerificarEmail(check, txtMail.Text) Then
                            If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then
                                If txtFecNac.Text <> "" Then

                                    If cbM.Checked Then
                                        sexo = "M"
                                    Else
                                        sexo = "F"
                                    End If

                                    Dim pac As New ControladorPaciente(txtCI.Text,
                                               pass,
                                               txtPNom.Text.ToUpper,
                                               txtSNom.Text.ToUpper,
                                               txtPApe.Text.ToUpper,
                                               txtSApe.Text.ToUpper,
                                               aliTel,
                                               txtMail.Text,
                                               sexo,
                                               txtFecNac.Text)

                                    If pac.registrar() Then

                                        MsgBox("Paciente registrado, debe esperar a ser habilitiado")
                                        Principal.Singleton.limpiar(txtCI, txtPass, txtRepPass, txtPNom,
                                                txtPApe,
                                                txtSApe, txtSNom,
                                                txtMail, dgvTelefonos, aliTel)
                                        txtFecNac.Clear()
                                        cbM.Checked = True

                                    Else
                                        MsgBox("El paciente ya fue registrado")

                                    End If

                                Else
                                    MsgBox("Debe ingresar su fecha de nacimiento")
                                End If

                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("La cédula ingresada no es correcta")
            End If
        Else
            MsgBox("Debe rellenar los campos")
        End If

    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If check.Verificar_Int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)

        End If

        pnlAgregarTelefonos1.Hide()
        ''add animacion

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblAgregarTelefonos.Click

        If pnlAgregarTelefonos1.Visible = False Then

            pnlAgregarTelefonos1.Visible = True

        End If

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
    End Sub

    Private Sub dgvTelefonos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellClick

        btnEliminar.Enabled = True
        ' no permite elimianr si no hay ninguna cell seleccionada
    End Sub

    Private Sub txtFecNac_Click(sender As Object, e As EventArgs) Handles txtFecNac.Click
        txtFecNac.Select(0, 0)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        If Not (txtCI.Text = Nothing And txtPNom.Text = Nothing And txtPApe.Text = Nothing And
            txtPNom.Text = Nothing And txtSApe.Text = Nothing And txtSNom.Text = Nothing And
            txtPass.Text = Nothing And txtRepPass.Text = Nothing And dgvTelefonos.Rows.Count > 0) Then 'agregar txtFecnac
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmLogin)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmLogin)
            Me.Dispose()
        End If

    End Sub

End Class