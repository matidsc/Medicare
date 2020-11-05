Imports Logica
Public Class frmListado

    Public dt As New DataTable
    Dim esCSV As Boolean = False
    Dim op As Byte
    Dim filtrarPor As String
    Private Shared instancia As frmListado
    Public Shared Function Singleton() As frmListado
        If instancia Is Nothing Then
            instancia = New frmListado
        End If
        Return instancia
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
    End Sub
    Public Sub New(op As Byte)

        Me.op = op
        ''AGREAGAR IF   
        ' For Each ctrl As Control In pnlContenedor.Controls

        ' ctrl.Text = Principal.Singleton.Idioma(ctrl.Name)

        ' Next

        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvListado, scroll, True)

        Select Case op
            Case 0
                Dim p As New ControladorPatologia
                dgvListado.DataSource = p.listarPatologias
                Me.filtrarPor = "nombre"
            Case 1
                Dim s As New ControladorSintoma
                dgvListado.DataSource = s.listarSintomas
                Me.filtrarPor = "nombre"
            Case 2
                Dim u As New ControladorUsuario
                dgvListado.DataSource = u.ListarUsuarios()
                Me.filtrarPor = "pNom"
                btnEliminarElementos.Visible = False
                btnModificarElemento.Visible = False
                btnSeleccionMultiple.Visible = False
            Case 3
                dgvListado.DataSource = ControladorPaciente.Singleton.getHistorialConsultas(Datos_Temporales.userLog)
                dgvListado.Columns(0).Visible = False
                btnEliminarElementos.Visible = False
                btnModificarElemento.Visible = False
                btnSeleccionMultiple.Visible = False
                btnRegistrar.Visible = False
                Me.filtrarPor = "nombre"
        End Select

    End Sub
    Public Sub New(path As String, lista As List(Of String), op As Byte)

        InitializeComponent()

        dt.Columns.Add("nombre")
        dt.Columns.Add("sintoma")
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvListado, scroll, True)
        Me.esCSV = True
        Me.op = op
        dgvListado.DataSource = Configuracion.Singleton.LeerCSV(path, lista)
        btnRegistrar.Visible = True
        btnEliminarElementos.Visible = False
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        instancia = Me
    End Sub

    Private Sub btnSeleccionMultiple_Click(sender As Object, e As EventArgs) Handles btnSeleccionMultiple.Click

        If dgvListado.MultiSelect = True Then

            dgvListado.MultiSelect = False
            btnSeleccionMultiple.Text = "ACTIVAR DESACTIVAR SELECCIÓN MÚLTIPLE"

        Else
            dgvListado.MultiSelect = True
            btnSeleccionMultiple.Text = "DESACTIVAR SELECCIÓN MÚLTIPLE"

        End If

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()

        Select Case op
            Case 0
                Dim p As New ControladorPatologia
                dgvListado.DataSource = p.listarPatologias
            Case 1
                Dim s As New ControladorSintoma
                dgvListado.DataSource = s.listarSintomas

        End Select
    End Sub

    Private Sub dgvListadoPatologias_MouseClick(sender As Object, e As MouseEventArgs)
        'btnEliminarElementos.Visible = True
        'btnModificarElemento.Visible = True
    End Sub
    Private Sub modificarCSV(nombre As String)

        If esCSV Then

            If op = 0 Then

                UcAsociar1.lblPatologia.Text = nombre
                Dim array As New ArrayList
                Dim bool As Boolean = False


                For Each row As DataRow In dt.Rows

                    If row.Item(0) = UcAsociar1.lblPatologia.Text Then

                        UcAsociar1.dgvSintomasSeleccionados.Rows.Add(row.Item(1))
                        array.Add(row.Item(1))
                        bool = True

                    End If

                Next

                If bool Then

                    For Each sintoma In ControladorSintoma.Singleton.traerSintomas(array)
                        UcAsociar1.dgvTodosLosSintomas.Rows.Add(sintoma)
                    Next

                Else
                    For Each sintoma In ControladorSintoma.Singleton.traerSintomas
                        UcAsociar1.dgvTodosLosSintomas.Rows.Add(sintoma)
                    Next


                End If

                UcAsociar1.Visible = True
                UcAsociar1.BringToFront()
                UcAsociar1.dgvSintomasSeleccionados.Sort(UcAsociar1.dgvSintomasSeleccionados.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                UcAsociar1.dgvTodosLosSintomas.Sort(UcAsociar1.dgvTodosLosSintomas.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                'MsgBox(UcAsociar1.dgvSintomasSeleccionados.Rows.Count)

            End If

        End If
    End Sub


    Private Sub dgvListadoPatologias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListado.SelectionChanged

        If dgvListado.MultiSelect = True And dgvListado.SelectedRows.Count > 1 Then

            lblCantSelecc.Visible = True
            btnEliminarElementos.Enabled = True
            lblCantSelecc.Text = dgvListado.SelectedRows.Count.ToString
            btnEliminarElementos.Text = "ELIMINAR " & dgvListado.SelectedRows.Count.ToString & "ELEMENTOS" '& op & ""
            btnModificarElemento.Enabled = False

        ElseIf dgvListado.SelectedRows.Count = 1 Then

            btnEliminarElementos.Enabled = True
            btnModificarElemento.Enabled = True
            btnEliminarElementos.Text = "ELIMINAR ELEMENTO SELECCIONADO"

            If dgvListado.MultiSelect = True Then

                lblCantSelecc.Text = "1"

            End If

        Else

            lblCantSelecc.Text = Nothing 'al cambiar a modo de seleccion unica, el contador de rows seleccionadas no cambiaba a 0
            btnEliminarElementos.Enabled = False
            btnModificarElemento.Enabled = False

        End If

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    If btnPrio.Visible = False Then
    '        btnDesc.Visible = True
    '        btnNom.Visible = True
    '        btnPrio.Visible = True

    '    Else
    '        btnDesc.Visible = False
    '        btnNom.Visible = False
    '        btnPrio.Visible = False

    '    End If

    'End Sub

    'Private Sub btnBuscarPor_Click(sender As Object, e As EventArgs)

    '    If btnPrio.Visible = False Then

    '        Panel1.Height = 191
    '        btnPrio.Visible = True
    '        btnRec.Visible = True
    '        btnNom.Visible = True
    '        btnDesc.Visible = True

    '    Else
    '        Panel1.Height = btnBuscarPor.Height
    '        btnPrio.Visible = False
    '        btnRec.Visible = False
    '        btnNom.Visible = False
    '        btnDesc.Visible = False

    '    End If

    'End Sub


    'Private Sub btnPrio_Click(sender As Object, e As EventArgs)

    '    btnBuscarPor.Text = "buscar por " & sender.text
    '    Me.criterio = sender.text
    '    Panel1.Height = btnBuscarPor.Height
    '    btnPrio.Visible = False
    '    btnRec.Visible = False
    '    btnNom.Visible = False
    '    btnDesc.Visible = False

    'End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Dim DV As New DataView(dgvListado.DataSource)
        'DV.RowFilter = String.Format("convert(" & Me.filtrarPor & ", 'System.String') Like '%{0}%' ",
        '                     txtBuscar.Text)
        'dgvListado.DataSource = DV

        Dim bs As New BindingSource
        bs.DataSource = dgvListado.DataSource
        dt.DefaultView.RowFilter = String.Format(" '{0}'", txtBuscar.Text)
        bs.Filter = Me.filtrarPor & " like '%" & txtBuscar.Text & "%'"
        dgvListado.DataSource = bs

    End Sub
    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        If txtBuscar.Text = Nothing Then
            lblBuscar.Visible = False
        End If
    End Sub
    Private Sub txtBuscar_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus
        If txtBuscar.Text = Nothing Then
            lblBuscar.Visible = True
        End If
    End Sub

    Private Sub btnEliminarElementos_Click_(sender As Object, e As EventArgs) Handles btnEliminarElementos.Click

        Dim YN As Integer

        If dgvListado.SelectedRows.Count = 1 Then

            YN = MsgBox("¿Seguro desea eliminar 1 ", vbQuestion + vbYesNo + vbDefaultButton2, "")

        Else
            YN = MsgBox("¿Seguro desea eliminar " & dgvListado.SelectedRows.Count & " ", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar patologías")

        End If

        If YN = vbYes Then


            Dim arrayNombres As New ArrayList

            For Each selectedRow As DataGridViewRow In dgvListado.SelectedRows
                arrayNombres.Add(dgvListado.Rows(selectedRow.Index).Cells(0).Value.ToString)
            Next

            If op = 1 Then

                Dim sin As New ControladorSintoma

                If sin.eliminarSintomas(arrayNombres) Then

                    For Each selectedRow2 As DataGridViewRow In dgvListado.SelectedRows
                        dgvListado.Rows.Remove(selectedRow2)
                    Next

                End If

            Else

                Dim pat As New ControladorPatologia

                If pat.eliminarPatologias(arrayNombres) Then

                    For Each selectedRow2 As DataGridViewRow In dgvListado.SelectedRows
                        dgvListado.Rows.Remove(selectedRow2)
                    Next

                End If

            End If

        End If

    End Sub

    Private Sub ModificarPatologia(nombre As String)
        Dim frm As New frmRegistrarPatologia(1)
        frm.llenarCampos(nombre)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmRegistrarPatologia)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
    Private Sub ModificarSintoma(nombre As String)
        Dim frm As New frmRegistrarSintoma(1)
        frm.llenarCampos(nombre)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmRegistrarSintoma)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
    Private Sub btnModificarElemento_Click_1(sender As Object, e As EventArgs) Handles btnModificarElemento.Click

        If op = 0 And esCSV = False Then
            ModificarPatologia(dgvListado.Rows(dgvListado.CurrentRow.Index).Cells(0).Value)
        ElseIf op = 1 And esCSV = False Then
            ModificarSintoma(dgvListado.Rows(dgvListado.CurrentRow.Index).Cells(0).Value)
        ElseIf esCSV = True Then
            modificarCSV(dgvListado.Rows(dgvListado.CurrentRow.Index).Cells(0).Value)

        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim tabla As DataTable = dgvListado.DataSource

        Select Case op

            Case 0

                Dim pat As New ControladorPatologia

                If pat.Registrar(tabla, dt) Then
                    MsgBox("Se registraron las patologías exitosamente")
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                Else
                    MsgBox("Error al registrar las patologías")
                End If

            Case 1
                Dim sin As New ControladorSintoma
                If sin.Registrar(tabla) Then
                    MsgBox("Se registraron los síntomas exitosamente")
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                Else
                    MsgBox("Error al registrar los síntomas")
                End If

            Case 2
                Dim med As New ControladorMedico
                If med.registrar(tabla) Then
                    MsgBox("Se registraron los médicos exitosamente")
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                Else
                    MsgBox("Error al registrar a los médicos")
                End If

        End Select

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Datos_Temporales.enumRol.Gestor Then
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        ElseIf Datos_Temporales.enumRol.Medico Then
            Principal.Singleton.CambiarTamaño(frmBienvenidaMedico)
            Me.Dispose()
        Else
            Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
            Me.Dispose()
        End If

    End Sub

    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        MsgBox(dgvListado.CurrentRow.Cells(0).Value)
        Dim frm As New frmObtenerDiagnostico(ControladorPatologia.Singleton.traerDiagnosticoPorId(dgvListado.CurrentRow.Cells(1).Value, Datos_Temporales.userLog))
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
End Class
