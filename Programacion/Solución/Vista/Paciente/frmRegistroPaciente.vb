Imports Logica
Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim pass As String
    Dim sexo As String
    Dim path As String

    Public Sub New()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)
    End Sub

    Private Sub btnSoli_Click(sender As Object, e As EventArgs) Handles btnSoli.Click

        If txtCI.Text <> "" And txtPass.Text <> "" And txtRepPass.Text <> "" And txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then
            If Principal.Singleton.VerificarCedula(check, txtCI.Text) Then
                If Principal.Singleton.VerificarContraseña(seg, txtPass.Text, txtRepPass.Text) Then
                    pass = seg.HASH256(txtPass.Text)
                    If Principal.Singleton.VerificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                        If Principal.Singleton.VerificarEmail(check, txtMail.Text) Then
                            If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then

                                If txtFecNac.MaskCompleted Then

                                    If cbM.Checked Then
                                        sexo = "M"
                                    ElseIf cbF.Checked Then
                                        sexo = "F"

                                        Dim pac As New ControladorPaciente(txtCI.Text,
                                                       pass,
                                                       txtPNom.Text.ToUpper,
                                                       txtSNom.Text.ToUpper,
                                                       txtPApe.Text.ToUpper,
                                                       txtSApe.Text.ToUpper,
                                                       aliTel,
                                                       txtMail.Text,
                                                       sexo,
                                                       txtFecNac.Text, Principal.Singleton.Base64(path)
                                                       )

                                        If pac.VerificarBaja(txtCI.Text) Then

                                            If pac.registrar() Then
                                                MsgBox("Su registro ha sido solicitado con éxito, debe esperar a ser habilitiado")
                                                Principal.Singleton.limpiar(txtCI, txtPass, txtRepPass, txtPNom,
                                                txtPApe,
                                                        txtSApe, txtSNom,
                                                       txtMail, dgvTelefonos, aliTel)
                                                txtFecNac.Clear()
                                                cbM.Checked = False
                                                cbF.Checked = False
                                                aliTel.Clear()
                                                path = Nothing
                                                GunaPictureBox1.Image = Nothing
                                            Else
                                                MsgBox("El paciente ya fue registrado")
                                                aliTel.Clear()
                                            End If

                                        Else
                                            Dim respuesta As Integer = MsgBox("Usted se encuentra dado de baja. ¿Desea solicitar reingresar al sistema? (Se mantendrá su información anterior)", vbQuestion + vbYesNo + vbDefaultButton2)

                                            If respuesta = vbYes Then
                                                pac.ReingresarUsuario(txtCI.Text)
                                                MsgBox("Su registro ha sido solicitado con éxito, debe esperar a ser habilitiado")
                                                Principal.Singleton.limpiar(txtCI, txtPass, txtRepPass, txtPNom,
                                                            txtPApe,
                                                            txtSApe, txtSNom,
                                                            txtMail, dgvTelefonos, aliTel)
                                                txtFecNac.Clear()
                                                cbM.Checked = False
                                                cbF.Checked = False
                                                GunaPictureBox1.Image = Nothing
                                                path = Nothing
                                            End If

                                        End If
                                    Else
                                        MsgBox("Debe ingresar un sexo")
                                    End If
                                End If

                                Else

                                    MsgBox("Debe ingresar su fecha de nacimiento")
                                End If
                            Else
                                MsgBox("Ha ingresado un teléfono incorrecto")
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

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtFecNac_GotFocus(sender As Object, e As EventArgs) Handles txtFecNac.GotFocus
        sepFecNac.LineColor = Color.FromArgb(100, 88, 255)
        txtFecNac.Select(0, 0)
    End Sub
    Private Sub txtFecNac_Lost(sender As Object, e As EventArgs) Handles txtFecNac.LostFocus
        sepFecNac.LineColor = Color.Silver
    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click

        Dim dial As New OpenFileDialog

        dial.Title = "Seleccione una fotografía"
        dial.Filter = "Image Files (*.jpg;*.jpeg;*bmp;*.png;)|*.jpg;*.jpeg;*bmp;*.png;"


        If dial.ShowDialog = DialogResult.OK Then
            path = dial.FileName
            GunaPictureBox1.Image = Image.FromFile(path)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If dgvTelefonos.Rows.Count = 0 Then
            dgvTelefonos.Rows.Add()

        ElseIf dgvTelefonos.Rows.Count > 0 Then

            If dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 1).Cells(0).Value <> "" Or dgvTelefonos.Rows.Count = 0 Then
                dgvTelefonos.Rows.Add()
            End If

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgvTelefonos.Rows.Count > 0 Then
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
        End If

    End Sub
    Private Sub dgvTelefonos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTelefonos.RowsAdded

        btnEliminar.Enabled = True
        If dgvTelefonos.Rows.Count = 10 Then
            btnAceptar.Enabled = False
        End If

    End Sub

    Private Sub dgvTelefonos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTelefonos.RowsRemoved
        btnAceptar.Enabled = True

        If dgvTelefonos.Rows.Count = 0 Then
            btnEliminar.Enabled = False
        End If

    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmLogin)
        Me.Dispose()
    End Sub

    Private Sub txtPApe_TextChanged(sender As Object, e As EventArgs) Handles txtPApe.TextChanged

    End Sub
End Class