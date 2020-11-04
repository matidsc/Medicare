﻿
Imports Logica

Public Class frmIngresarSintomas

    Dim sourcedgv As String
    Dim dv As New DataView

    Dim ScrollHelperSeleccionados As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim ScrollHelperTodos As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Private Shared instancia As frmIngresarSintomas

    Public Shared Function ObtenerInstancia() As frmIngresarSintomas
        Return instancia
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ScrollHelperSeleccionados = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scrollSeleccionados, True)
        ScrollHelperTodos = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodos, scrollTodos, True)

        For Each sintoma In ControladorSintoma.Singleton.traerSintomas
            dgvTodos.Rows.Add(sintoma)
        Next

        dgvTodos.Sort(dgvTodos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Public Sub New()

        InitializeComponent()
        instancia = Me
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

    End Sub
    Private Sub selectItem(origen As DataGridView, destino As DataGridView, e As MouseEventArgs)

        sourcedgv = origen.Name
        Dim SourceRow = origen.HitTest(e.X, e.Y).RowIndex 'obtiene el indice de la fila que contiene las coordenadas

        If SourceRow >= 0 Then ' el usuario solo puede seleccionar una fila, no el fondo de la tabla  

            destino.BorderStyle = BorderStyle.FixedSingle
            origen.Rows(SourceRow).Selected = True
            origen.DoDragDrop(SourceRow, DragDropEffects.Move)

        End If

    End Sub

    Private Sub dropItem(origen As DataGridView, destino As DataGridView, e As DragEventArgs)

        If sourcedgv <> destino.Name Then ' evita que el usuario arrastre una row a la misma datagridview de origen

            destino.BorderStyle = BorderStyle.None
            destino.Rows.Add() 'agrega una row vacia para que entre el elemento

            Dim SourceRow = (e.Data.GetData(Type.GetType("System.Int32")))

            Dim rowDestino = destino.Rows.Count - 1

            destino.Rows(rowDestino).Cells(0).Value = origen.Rows(SourceRow).Cells(0).Value
            destino.Sort(destino.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            origen.Rows.RemoveAt(SourceRow)


        Else
            Exit Sub 'OPCIONAL COLOCAR MSGBOX

        End If

    End Sub

    Private Sub dgvTodos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodos.MouseDown
        selectItem(dgvTodos, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvSintomasSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomasSeleccionados.MouseDown
        selectItem(dgvSintomasSeleccionados, dgvTodos, e)
    End Sub

    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragDrop
        dropItem(dgvTodos, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvTodos_DragOver(sender As Object, e As DragEventArgs) Handles dgvTodos.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvTodos_DragDrop(sender As Object, e As DragEventArgs) Handles dgvTodos.DragDrop
        dropItem(dgvSintomasSeleccionados, dgvTodos, e)
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        'dv.RowFilter = String.Format("Name Like '%{0}%'", txtBuscar.Text)
        'bs.DataSource = dgvTodos.DataSource
        'dt.DefaultView.RowFilter = String.Format(" '{0}'", txtBuscar.Text)
        'bs.Filter = "cedula like '%" & txtBuscar.Text & "%'"

        'dgvTodos.DataSource = bs
    End Sub



    Private Sub btnObtenerDiag_Click(sender As Object, e As EventArgs) Handles btnObtenerDiag.Click

        Dim misSintomas As New ArrayList
        Dim pat As New ControladorPatologia
        Dim sin As New ControladorSintoma

        For i As Integer = 0 To dgvSintomasSeleccionados.RowCount - 1

            If dgvSintomasSeleccionados.Rows.Item(i).Cells(0).Value <> Nothing Then

                misSintomas.Add(dgvSintomasSeleccionados.Rows.Item(i).Cells(0).Value.ToString)

            End If

        Next

        If misSintomas.Count > 0 Then

            Dim dt = pat.obtenerPatologia(misSintomas)

            If dt.Rows.Count > 0 Then

                Dim frm As New frmObtenerDiagnostico(dt, misSintomas)
                Me.SuspendLayout()
                    Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                    Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
                    frm.Show()
                    pnlContenedor.Hide()
                    pnlInstancia.Show()
                Me.ResumeLayout()

                dt.Clear()
                misSintomas.Clear()
            Else
                MsgBox("No se encontraron patologías que contenga los síntomas seleccionados")

            End If

        Else
            MsgBox("No seleccionó ningún síntoma")
        End If
    End Sub

    Private Sub dgvTodos_Paint(sender As Object, e As PaintEventArgs) Handles dgvTodos.Paint, dgvSintomasSeleccionados.Paint
        ScrollHelperSeleccionados.UpdateScrollBar()
        ScrollHelperTodos.UpdateScrollBar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
        Me.Dispose()
    End Sub

    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub
End Class