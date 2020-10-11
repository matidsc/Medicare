Imports Logica
''https://github.com/IgnaceMaes/MaterialSkin

Public Class frmListadoPatologiasySintomas


    Dim op As Byte
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvListado, scroll, True)
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

        Select Case op
            Case 0
                Dim p As New ControladorPatologia
                dgvListado.DataSource = p.listarPatologias
            Case 1
                Dim s As New ControladorSintoma
                dgvListado.DataSource = s.listarSintomas
            Case 2

        End Select

    End Sub
    Public Sub New(path As String, lista As List(Of String))

        ''AGREAGAR IF   
        For Each ctrl As Control In pnlContenedor.Controls

            ctrl.Text = Principal.Singleton.Idioma(ctrl.Name)

        Next

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.MetroButton1.Text = "Guardar"
        Me.MetroButton1.Visible = True
        dgvListado.DataSource = Configuracion.Singleton.LeerCSV(path, lista)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnSeleccionMultiple_Click(sender As Object, e As EventArgs) Handles btnSeleccionMultiple.Click

        If dgvListado.MultiSelect = True Then

            dgvListado.MultiSelect = False
            btnSeleccionMultiple.Text = "activar selección múltiple"

        Else
            dgvListado.MultiSelect = True
            btnSeleccionMultiple.Text = "desactivar selección múltiple"

        End If

    End Sub

    Private Sub dgvListadoPatologias_MouseClick(sender As Object, e As MouseEventArgs)
        'btnEliminarElementos.Visible = True
        'btnModificarElemento.Visible = True
    End Sub

    Private Sub dgvListadoPatologias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick

        If dgvListado.MultiSelect = False Then

        End If

    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvListadoPatologias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListado.SelectionChanged

        If dgvListado.MultiSelect = True And dgvListado.SelectedRows.Count > 1 Then

            btnEliminarElementos.Enabled = True
            lblCantSelecc.Text = dgvListado.SelectedRows.Count.ToString
            btnEliminarElementos.Text = "eliminar " & dgvListado.SelectedRows.Count.ToString & " " '& op & ""
            btnModificarElemento.Enabled = False

        ElseIf dgvListado.SelectedRows.Count = 1 Then

            btnEliminarElementos.Enabled = True
            btnModificarElemento.Enabled = True
            btnEliminarElementos.Text = "eliminar elemento seleccionado"

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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox2.TextChanged

        Dim dt As New DataTable
        Dim bs As New BindingSource

        bs.DataSource = dgvListado.DataSource
        ' dt.DefaultView.RowFilter = String.Format("'{0}'", txtBuscar.Text)
        ' bs.Filter = "Nombre like '%" & txtBuscar.Text & "%'"
        dgvListado.DataSource = bs

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

    Private Sub btnModificarElemento_Click_1(sender As Object, e As EventArgs) Handles btnModificarElemento.Click
        MsgBox("En construcción...")
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim tabla As DataTable = dgvListado.DataSource
        Dim a As New ControladorSintoma
        a.registrar(1, tabla)
    End Sub
End Class
