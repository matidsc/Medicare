﻿Imports Logica
''https://github.com/IgnaceMaes/MaterialSkin

Public Class frmListadoPatologiasySintomas

    Public op As String

    Dim criterio As String
    Dim textoBusqueda As String = "Buscar por " & Me.criterio

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(path As String, lista As List(Of String))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.MetroButton1.Text = "Guardar"
        Me.MetroButton1.Visible = True
        dgvListado.DataSource = Configuracion.Singleton.LeerCSV(path, lista)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmPatologiasRegistradas_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblTitulo.Text = "LISTADO DE " & op.ToUpper

        Panel1.Height = btnBuscarPor.Height

        If op = "síntomas" Then
            Dim s As New ControladorSintoma
            dgvListado.DataSource = s.listarSintomas

        ElseIf op = "patologías" Then
            Dim p As New ControladorPatologia
            dgvListado.DataSource = p.listarPatologias

            'For i As Integer = 0 To dgvListado.Rows.Count - 1

            '    If dgvListado.Rows(i).Cells(3).Value = 1 Then

            '        dgvListado.Rows(i).Cells(3).Value = "Alta"

            '    ElseIf dgvListado.Rows(i).Cells(3).Value = 2 Then

            '        dgvListado.Rows(i).Cells(3).Value = "Media"

            '    Else
            '        dgvListado.Rows(i).Cells(3).Value = "Baja"

            '    End If

            'Next

        End If


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

    Private Sub dgvListadoPatologias_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListado.MouseClick
        'btnEliminarElementos.Visible = True
        'btnModificarElemento.Visible = True
    End Sub

    Private Sub dgvListadoPatologias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick

        If dgvListado.MultiSelect = False Then

        End If

    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialSingleLineTextField1_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus

        If txtBuscar.Text = "" Then

            txtBuscar.Text = textoBusqueda

        End If

    End Sub

    Private Sub dgvListadoPatologias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListado.SelectionChanged

        If dgvListado.MultiSelect = True And dgvListado.SelectedRows.Count > 1 Then

            btnEliminarElementos.Enabled = True
            lblCantSelecc.Text = dgvListado.SelectedRows.Count.ToString
            btnEliminarElementos.Text = "eliminar " & dgvListado.SelectedRows.Count.ToString & " " & op & ""
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If btnPrio.Visible = False Then
            btnDesc.Visible = True
            btnNom.Visible = True
            btnPrio.Visible = True

        Else
            btnDesc.Visible = False
            btnNom.Visible = False
            btnPrio.Visible = False

        End If

    End Sub

    Private Sub btnBuscarPor_Click(sender As Object, e As EventArgs) Handles btnBuscarPor.Click

        If btnPrio.Visible = False Then

            Panel1.Height = 191
            btnPrio.Visible = True
            btnRec.Visible = True
            btnNom.Visible = True
            btnDesc.Visible = True

        Else
            Panel1.Height = btnBuscarPor.Height
            btnPrio.Visible = False
            btnRec.Visible = False
            btnNom.Visible = False
            btnDesc.Visible = False

        End If

    End Sub



    Private Sub btnModificarElemento_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminarElementos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click

        If txtBuscar.Text = "Buscar" Then

            txtBuscar.Text = ""

        End If

    End Sub

    Private Sub btnPrio_Click(sender As Object, e As EventArgs) Handles btnPrio.Click, btnDesc.Click, btnRec.Click, btnNom.Click

        btnBuscarPor.Text = "buscar por " & sender.text
        Me.criterio = sender.text
        Panel1.Height = btnBuscarPor.Height
        btnPrio.Visible = False
        btnRec.Visible = False
        btnNom.Visible = False
        btnDesc.Visible = False

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim dt As New DataTable
        Dim bs As New BindingSource

        bs.DataSource = dgvListado.DataSource
        dt.DefaultView.RowFilter = String.Format("'{0}'", txtBuscar.Text)
        bs.Filter = "Nombre like '%" & txtBuscar.Text & "%'"
        dgvListado.DataSource = bs

    End Sub

    Private Sub btnBuscarPor_TextChanged(sender As Object, e As EventArgs) Handles btnBuscarPor.TextChanged

    End Sub

    Private Sub btnBuscarPor_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscarPor.MouseClick

        If txtBuscar.Text = "" Then

            txtBuscar.Text = "Buscar por " & Me.criterio

        End If

    End Sub

    Private Sub btnEliminarElementos_Click_1(sender As Object, e As EventArgs) Handles btnEliminarElementos.Click

        Dim YN As Integer

        If dgvListado.SelectedRows.Count = 1 Then

            YN = MsgBox("¿Seguro desea eliminar 1 " & op.Substring(0, op.Length - 1) & "?", vbQuestion + vbYesNo + vbDefaultButton2, "" & op.Substring(0, op.Length - 1 & ""))

        Else
            YN = MsgBox("¿Seguro desea eliminar " & dgvListado.SelectedRows.Count & " " & op & "?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar patologías")

        End If

        If YN = vbYes Then


            Dim arrayNombres As New ArrayList

            For Each selectedRow As DataGridViewRow In dgvListado.SelectedRows
                arrayNombres.Add(dgvListado.Rows(selectedRow.Index).Cells(0).Value.ToString)
            Next

            If op = "síntomas" Then

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

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmModular)
        Me.Dispose()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblMinimizar.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub btnModificarElemento_Click_1(sender As Object, e As EventArgs) Handles btnModificarElemento.Click
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim tabla As DataTable = dgvListado.DataSource
        Dim a As New ControladorSintoma
        a.registrar(1, tabla)
    End Sub
End Class
