Imports Logica
Public Class UCVerPerfil
    Private pac As New ControladorPaciente
    Private ges As New ControladorGestor
    Private med As New ControladorMedico
    Private usu As New ControladorUsuario
    Private _pNom, _sNom, _pApe, _sApe, _email As String
    Private path As String
    Private _especializacion As String
    Private _fecNac, _edad, _sexo As String
    Private cambiados As Boolean = False
    Dim aliPatologias As New ArrayList
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                Dim aliPatologias As New ArrayList
                Dim alitel As New ArrayList
                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then 'txtPass.Text <> "" And txtRepPass.Text <> "" And

                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                            If Principal.Singleton.VerificarEmail(Verificacion.Singleton, txtMail.Text) Then

                                If Principal.Singleton.VerificarTelefonos(dgvTelefonos, alitel) Then
                                Dim pac As New ControladorPaciente(Datos_Temporales.userLog,
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

                                If pac.updateUsuario() Then
                                        If pac.updatePaciente(Datos_Temporales.userLog) Then



                                            If pac.updateTelefonos(alitel) Then

                                                MsgBox("Su perfil ha sido modificado con exito")
                                                setVariablesUsuario()
                                                setTelefonosUsuario()
                                                setVariablesPaciente()
                                            Else
                                                MsgBox("Error al modificar los teléfonos")
                                                alitel.Clear()
                                            End If

                                        End If
                                    Else
                                        MsgBox("Error al modificar el perfil")
                                        alitel.Clear()
                                    End If

                                Else
                                    MsgBox("Ha ingresado un teléfono incorrecto")

                                End If
                            Else
                                MsgBox("Debe ingresar un e-mail correcto")
                            End If
                        End If

                Else
                    MsgBox("Debe rellenar los campos")
                End If


            Case Datos_Temporales.enumRol.Gestor

                Dim alitel As New ArrayList
                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then 'txtPass.Text <> "" And txtRepPass.Text <> "" And

                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                            If Principal.Singleton.VerificarEmail(Verificacion.Singleton, txtMail.Text) Then
                                If Principal.Singleton.VerificarTelefonos(dgvTelefonos, alitel) Then
                                Dim ges As New ControladorGestor(Datos_Temporales.userLog,
                                                           txtPNom.Text.ToUpper,
                                                           txtSNom.Text.ToUpper,
                                                           txtPApe.Text.ToUpper,
                                                           txtSApe.Text.ToUpper,
                                                           alitel,
                                                           txtMail.Text,
                                                           Principal.Singleton.Base64(path)
                                                           )

                                If ges.updateUsuario() Then

                                        If ges.updateTelefonos(alitel) Then

                                            MsgBox("Su perfil ha sido modificado con exito")
                                            setVariablesUsuario()
                                            setTelefonosUsuario()
                                        Else
                                            MsgBox("Error al modificar los teléfonos")
                                            alitel.Clear()
                                        End If
                                    Else
                                        MsgBox("Error al modificar el perfil")
                                        alitel.Clear()
                                    End If

                                Else
                                    MsgBox("Ha ingresado un teléfono incorrecto")

                                End If
                            Else
                                MsgBox("Debe ingresar un e-mail correcto")
                            End If
                        End If

                Else
                    MsgBox("Debe rellenar los campos")
                End If

            Case Datos_Temporales.enumRol.Medico

                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then


                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then

                        If Verificacion.Singleton.VerificarEmail(txtMail.Text) Then

                            Dim med As New ControladorMedico(
                                    Datos_Temporales.userLog,
                                    "", txtPNom.Text.ToUpper(),
                                    txtSNom.Text.ToUpper,
                                    txtPApe.Text.ToUpper,
                                    txtSApe.Text.ToUpper,
                                    txtEspe.Text.ToUpper,
                                    txtMail.Text,
                                    Principal.Singleton.Base64(path))

                            If med.updateUsuario() Then

                                If med.updateMedico(Datos_Temporales.userLog) Then
                                    MsgBox("Su perfil ha sido modificado con exito")
                                    setVariablesUsuario()
                                    setVariableMedico()
                                Else
                                    MsgBox("Error al modificar su perfil")
                                End If


                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

    Public Sub New()

        InitializeComponent()
        ' Me.Location = New Point((Me.ParentForm.Width / 2) - (Me.Width / 2), Me.Location.Y)

        'Me.Location = New Point((Me.Width - frmBienvenidaPaciente.Width) \ 2, (Me.Height - frmBienvenidaPaciente.Height) \ 2)
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)

        Me.Top = 0
        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                'btnRegistrar.BringToFront()
                Me.Location = New Point((frmBienvenidaPaciente.Width - Me.Width) \ 2, Me.Location.Y)
                pnlCredenciales.Visible = False
                lblEspec.Visible = False
                pnlMedico.Visible = False
                pnlMedYo.Visible = False
                btnModPatologias.Visible = True
                setVariablesUsuario()
                setTelefonosUsuario()
                setVariablesPaciente()


            Case Datos_Temporales.enumRol.Gestor
                btnModPatologias.Visible = False
                'btnRegistrar.BringToFront()
                Me.Location = New Point((frmBienvenidaGestor.Width - Me.Width) \ 2, Me.Location.Y)
                pnlCredenciales.Visible = False
                lblEspec.Visible = False
                pnlMedico.Visible = False
                pnlPaciente.Visible = False
                pnlMedYo.Visible = False
                setVariablesUsuario()
                setTelefonosUsuario()

            Case Datos_Temporales.enumRol.Medico
                btnModPatologias.Visible = False
                pnlCredenciales.Visible = False
                Me.Location = New Point((frmBienvenidaMedico.Width - Me.Width) \ 2, Me.Location.Y)
                ' pnlMedYo.Location = pnlPaciente.Location
                lblEspec.Visible = True
                txtEspe.Visible = True
                pnlMedico.Visible = True
                btnAceptar.Visible = False
                btnEliminar.Visible = False
                pnlPaciente.Visible = False
                dgvTelefonos.Visible = False
                lblTel.Visible = False
                lblTelefonos.Visible = False
                lblTeles.Visible = False

                setVariablesUsuario()
                setVariableMedico()
        End Select

    End Sub
    Private Sub setVariableMedico()
        Dim Mayus = med.getInformacionMedico(Datos_Temporales.userLog)
        _especializacion = Mayus.ToString.Substring(0, 1).ToUpper + Mayus.ToString.Substring(1).ToLower
        txtEspe.Text = _especializacion
        lblEspe.Text = _especializacion
    End Sub
    Private Sub setVariablesPaciente()
        Dim datos As DataRow = pac.getDatosPacientePerfil(Datos_Temporales.userLog).Rows(0)

        _edad = datos.Item(0).ToString.Substring(0, 1).ToUpper + datos.Item(0).ToString.Substring(1).ToLower
        lblEd.Text = _edad

        _sexo = datos.Item(1)
        lblSex.Text = _sexo

        If _sexo = "M" Then
            lblSex.Text = "Masculino"
        Else
            lblSex.Text = "Femenino"
        End If

        _fecNac = datos.Item(2)
        Dim patologias As DataTable = pac.getPatologiasCronicas(Datos_Temporales.userLog)

        If patologias.Rows.Count > 0 Then
            For Each patologia As DataRow In patologias.Rows
                lblPatCron.Text += patologia.Item(0) & ", "
                'dgvPatologias.Rows.Add(patologia.Item(0)).ToString()
                aliPatologias.Add(patologia.Item(0))
            Next
        Else
            lblPatCron.Text = "Usted no tiene patologías crónicas registradas"
        End If
        lblPatCron.Text.TrimEnd(", ")
    End Sub
    Private Sub setVariablesUsuario()

        'SET VARIABLES
        Dim datos As DataRow = usu.getDatosUsuario(Datos_Temporales.userLog).rows(0)
        _pNom = datos.Item(1).ToString.Substring(0, 1).ToUpper + datos.Item(1).ToString.Substring(1).ToLower

        If datos.Item(2).ToString() <> "" Then
            _sNom = datos.Item(2).ToString.Substring(0, 1).ToUpper + datos.Item(2).ToString.Substring(1).ToLower
        Else
            _sNom = ""
            lblSNom.Visible = False
            txtSNom.Visible = False
            lblPApe.Location = New Point(40, 262)
            txtPApe.Location = New Point(40, 289)
            lblSApe.Location = New Point(40, 374)
            txtSApe.Location = New Point(40, 406)
            'pnlMedYo.Location = New Point(40, 503)
            pnlMedYo.Location = New Point(34, 454)
        End If

        _pApe = datos.Item(3).ToString.Substring(0, 1).ToUpper + datos.Item(3).ToString.Substring(1).ToLower
        _sApe = datos.Item(4).ToString.Substring(0, 1).ToUpper + datos.Item(4).ToString.Substring(1).ToLower
        _email = datos.Item(5).ToString.Substring(0, 1).ToUpper + datos.Item(5).ToString.Substring(1).ToLower

        If datos.Item(6).ToString() <> "" Then
            GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(datos.Item(6))
        Else
            GunaCirclePictureBox1.Image = My.Resources.nopic
        End If

        'SET TEXTOS
        lblEmail.Text = _email
        txtMail.Text = _email

        lblNom.Text = _pNom & " " & _sNom & " " & _pApe & " " & _sApe

        txtPNom.Text = _pNom
        txtSNom.Text = _sNom
        txtPApe.Text = _pApe
        txtSApe.Text = _sApe
        cambiados = True
    End Sub

    Private Sub txtPNom_TextChanged(sender As Object, e As EventArgs) Handles txtSNom.TextChanged, txtSApe.TextChanged, txtPNom.TextChanged, txtPApe.TextChanged, txtEspe.TextChanged, txtMail.TextChanged, txtEspe.TextChanged

        If cambiados Then
            If _pNom <> txtPNom.Text Or _sNom <> txtSNom.Text Or _pApe <> txtPApe.Text Or _sApe <> txtSApe.Text Or _email <> txtMail.Text Or _especializacion <> txtEspe.Text Then
                btnRegistrar.Enabled = True
            Else
                btnRegistrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvTelefonos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellValueChanged

        Dim i = 0
        Dim contador As Short = 0

        For Each telefono In alitel

            If telefono = dgvTelefonos.Rows(i).Cells(0).Value Then
                contador += 1
            End If
            i += 1
        Next

        If contador <> alitel.Count Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
    Dim alitel As New ArrayList

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgvTelefonos.Rows.Add()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvTelefonos.Rows.Count > 0 Then
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
        ElseIf dgvTelefonos.Rows.Count < 0 Then
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub setTelefonosUsuario()

        Dim telefonos As DataTable = ges.getTelefonosUsuario
        If telefonos.Rows.Count > 0 Then
            For Each telefono As DataRow In telefonos.Rows
                lblTel.Text += telefono.Item(0) & ", "
                dgvTelefonos.Rows.Add(telefono.Item(0)).ToString()
                alitel.Add(telefono.Item(0))
            Next
        Else
            lblTel.Text = "No hay teléfonos registrados"
        End If
        lblTel.Text.TrimEnd(", ")

    End Sub

    Private Sub btnVerPatologias_Click(sender As Object, e As EventArgs) Handles btnVerPatologias.Click
        If pnlPatologias.Visible = True Then
            pnlPatologias.Visible = False
        Else
            pnlPatologias.Visible = True
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Dispose()
    End Sub

    Private Sub btnModPatologias_Click(sender As Object, e As EventArgs) Handles btnModPatologias.Click

        Dim instancia As frmBienvenidaPaciente = Me.ParentForm
        Dim frm As New frmIngresarSintomas(aliPatologias, 1)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        frm.Show()
        instancia.pnlContenedor.Hide()
        instancia.pnlInstancia.Show()
        Me.ResumeLayout()
        Me.Dispose()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pnlMain.BringToFront()
        transicion.Hide(pnlMain)
        transicion.Show(pnlYo)
        btnRegistrar.Visible = True
        btnRegistrar.BringToFront()
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        pnlYo.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlMain)
        btnRegistrar.BringToFront()
    End Sub
    Private Sub Mostrar_pnlContacto(sender As Object, e As EventArgs) Handles IconButton2.Click
        pnlYo.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlContacto)
        btnRegistrar.BringToFront()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        pnlContacto.BringToFront()
        transicion.Hide(pnlContacto)
        transicion.Show(pnlYo)
        btnRegistrar.BringToFront()
    End Sub

    'Private Sub dgvTelefonos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvTelefonos.CellBeginEdit
    '    MsgBox(dgvTelefonos(e.ColumnIndex, e.RowIndex).Value).ToString()
    'End Sub
    'Private Sub dgvTelefonos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellEndEdit
    '    MsgBox(dgvTelefonos(e.ColumnIndex, e.RowIndex).Value).ToString()
    'End Sub
End Class
