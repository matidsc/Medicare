Imports Logica
Public Class UCVerPerfil
    Private pac As New ControladorPaciente
    Private ges As New ControladorGestor
    Private med As New ControladorMedico
    Private _pNom, _sNom, _pApe, _sApe, _email, _sexo, _fecNac, _especializacion As String
    Private path As String

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                Dim alitel As New ArrayList
                If txtPass.Text <> "" And txtRepPass.Text <> "" And txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then
                    If Principal.Singleton.VerificarContraseña(Encriptar.Singleton, txtPass.Text, txtRepPass.Text) Then
                        Dim pass = Encriptar.Singleton.HASH256(txtPass.Text)
                        If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                            If Principal.Singleton.VerificarEmail(Verificacion.Singleton, txtMail.Text) Then
                                If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then

                                    Dim pac As New ControladorPaciente(Datos_Temporales.userLog,
                                                       pass,
                                                       txtPNom.Text.ToUpper,
                                                       txtSNom.Text.ToUpper,
                                                       txtPApe.Text.ToUpper,
                                                       txtSApe.Text.ToUpper,
                                                       alitel,
                                                       txtMail.Text,
                                                       _sexo,
                                                       _fecNac,
                                                       Principal.Singleton.Base64(path)
                                                       )

                                    If pac.RegistarUsuario Then
                                        If pac.RegistrarPaciente() Then
                                            If pac.RegistrarTelefonos Then
                                                MsgBox("Su perfil ha sido modificado con exito")
                                            Else
                                                MsgBox("Error al modificar los teléfonos")
                                                alitel.Clear()
                                            End If
                                        Else
                                            MsgBox("Error")
                                            alitel.Clear()
                                        End If
                                    Else
                                        MsgBox("El usuario ya fue ingresado")
                                        aliTel.Clear()
                                    End If

                                End If

                            Else
                                MsgBox("Ha ingresado un teléfono incorrecto")

                            End If
                        Else
                            MsgBox("Debe ingresar un e-mail correcto")
                        End If
                    Else
                        MsgBox("Las contraseñas no coinciden")
                    End If
                Else
                    MsgBox("Debe rellenar los campos")
                End If


                    Case Datos_Temporales.enumRol.Gestor

                    Case Datos_Temporales.enumRol.Medico
        End Select
    End Sub

    Public Sub New()

        InitializeComponent()

        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                lblEspec.Visible = False
                pnlMedico.Visible = False
                Dim dtPac As DataTable = pac.getDatosPacientePerfil(Datos_Temporales.userLog)
                lblNom.Text = dtPac.Rows(0).Item(1) & " " & dtPac.Rows(0).Item(2) & " " & dtPac.Rows(0).Item(3) & " " & dtPac.Rows(0).Item(4)
                lblEd.Text = dtPac.Rows(0).Item(5).ToString

                Dim telefonos As DataTable = pac.getTelefonosUsuario
                If telefonos.Rows.Count > 0 Then
                    For Each telefono As DataRow In telefonos.Rows
                        lblTel.Text += telefono.Item(0) & ", "
                    Next
                Else
                    lblTel.Text = "No hay teléfonos registrados"
                End If

                lblTel.Text.TrimEnd(", ")

                If dtPac.Rows(0).Item(6) = "M" Then
                    lblSex.Text = "Masculino"
                Else
                    lblSex.Text = "Femenino"
                End If

                lblEmail.Text = dtPac.Rows(0).Item(7)
                GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(dtPac.Rows(0).Item(8))
                _fecNac = dtPac.Rows(0).Item(9)

            Case Datos_Temporales.enumRol.Gestor
                lblEspec.Visible = False
                pnlMedico.Visible = False
                pnlPaciente.Visible = False
                Dim dtGes As DataTable = ges.getInformacionGestor(Datos_Temporales.userLog)
                lblNom.Text = dtGes.Rows(0).Item(0) & " " & dtGes.Rows(0).Item(1) & " " & dtGes.Rows(0).Item(2) & " " & dtGes.Rows(0).Item(3)

                lblEmail.Text = dtGes.Rows(0).Item(4)

                If dtGes.Rows(0).Item(5).ToString() <> "" Then
                    GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(dtGes.Rows(0).Item(5))
                Else
                    GunaCirclePictureBox1.Image = My.Resources.nopic
                End If

                Dim telefonos As DataTable = ges.getTelefonosUsuario
                If telefonos.Rows.Count > 0 Then
                    For Each telefono As DataRow In telefonos.Rows
                        lblTel.Text += telefono.Item(0) & ", "
                    Next
                Else
                    lblTel.Text = "No hay teléfonos registrados"
                End If

            Case Datos_Temporales.enumRol.Medico

                lblEspec.Visible = True
                pnlMedico.Visible = True
                btnAceptar.Visible = False
                btnEliminar.Visible = False
                pnlPaciente.Visible = False
                dgvTelefonos.Visible = False
                lblTel.Visible = False
                lblTelefonos.Visible = False
                lblTeles.Visible = False

                Dim dtMed As DataTable = med.getInformacionMedico(Datos_Temporales.userLog)
                _pNom = dtMed.Rows(0).Item(0)

                If dtMed.Rows(0).Item(1).ToString() <> "" Then
                    _sNom = dtMed.Rows(0).Item(1)
                Else
                    _sNom = ""
                End If
                _pApe = dtMed.Rows(0).Item(2)
                _sApe = dtMed.Rows(0).Item(3)

                lblNom.Text = _pNom & " " & _sNom & " " & _pApe & " " & _sApe

                _email = dtMed.Rows(0).Item(4)
                lblEmail.Text = _email
                txtMail.Text = _email

                _especializacion = dtMed.Rows(0).Item(5)
                lblEspe.Text = _especializacion
                txtEspe.Text = _especializacion

                If dtMed.Rows(0).Item(6).ToString() <> "" Then
                    GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(dtMed.Rows(0).Item(5))
                Else
                    GunaCirclePictureBox1.Image = My.Resources.nopic
                End If

        End Select

    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pnlMain.BringToFront()
        transicion.Hide(pnlMain)
        transicion.Show(pnlCredenciales)
        btnRegistrar.Visible = True
        btnRegistrar.BringToFront()
    End Sub

    Private Sub Mostrar_pnlYo(sender As Object, e As EventArgs) Handles IconButton3.Click
        pnlCredenciales.BringToFront()
        transicion.Hide(pnlCredenciales)
        transicion.Show(pnlYo)
    End Sub
    Private Sub Mostrar_pnlContacto(sender As Object, e As EventArgs) Handles IconButton2.Click
        pnlCredenciales.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlContacto)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        pnlCredenciales.BringToFront()
        transicion.Hide(pnlCredenciales)
        transicion.Show(pnlMain)
        btnRegistrar.Visible = False
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        pnlYo.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlCredenciales)
        btnRegistrar.BringToFront()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        pnlContacto.BringToFront()
        transicion.Hide(pnlContacto)
        transicion.Show(pnlYo)
        btnRegistrar.BringToFront()
    End Sub

End Class
