Imports Logica
Public Class frmRegistroGestor

    Dim pass As String
    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)
    End Sub

    Private Sub dgvTelefonos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvTelefonos.CellValidating

        'If dgvTelefonos.Rows(e.RowIndex).IsNewRow Then
        '    If e.ColumnIndex = 0 Then
        '        If ver.verificar_int(e.FormattedValue.ToString) Then
        '        Else
        '            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If Principal.Singleton.VerificarCedula(check, txtCI.Text) Then
            If Principal.Singleton.VerificarContraseña(seg, txtCon.Text, txtRepCon.Text) Then
                pass = seg.HASH256(txtCon.Text)
                If Principal.Singleton.VerificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                    If Principal.Singleton.VerificarEmail(check, txtMail.Text) Then
                        If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then
                            Dim ges As New ControladorGestor(txtCI.Text,
                                                 pass,
                                                 txtPNom.Text.ToUpper,
                                                 txtSNom.Text.ToUpper,
                                                 txtPApe.Text.ToUpper,
                                                 txtSApe.Text.ToUpper,
                                                 aliTel,
                                                 txtMail.Text)

                            If ges.VerificarBaja(txtCI.Text) Then

                                If ges.registrar() Then
                                    MsgBox("Gestor registrado con éxito")
                                    Principal.Singleton.limpiar(txtCI, txtCon, txtRepCon, txtPApe, txtPNom, txtSApe, txtSNom, txtMail, dgvTelefonos, aliTel)
                                Else
                                    MsgBox("El gestor ya fue registrado")
                                End If
                            Else
                                Dim respuesta As Integer = MsgBox("Usted se encuentra dado de baja. ¿Desea reingresar al sistema?", vbQuestion + vbYesNo + vbDefaultButton2)

                                If respuesta = vbYes Then
                                    ges.ReingresarUsuario(txtCI.Text)
                                    MsgBox("Ha sido reingresado")
                                    Principal.Singleton.limpiar(txtCI, txtCon, txtRepCon, txtPApe, txtPNom, txtSApe, txtSNom, txtMail, dgvTelefonos, aliTel)
                                End If
                            End If

                        End If
                    End If
                End If
            End If

        Else
            MsgBox("La cédula ingresada no es correcta")

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If check.Verificar_Int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)
        Else

        End If


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
    End Sub

    Private Sub dgvTelefonos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTelefonos.RowsAdded
        If dgvTelefonos.Rows.Count > 1 Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmLogin)
        Me.Dispose()
    End Sub
End Class