Imports Logica

Public Class frmRegistrarPatologia

    Dim sourcedgv As String
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim ScrollHelper2 As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scroll, True)

        ScrollHelper2 = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodosLosSintomas, scroll2, True)
        traerSintomas()


        ScrollHelper.UpdateScrollBar()
        ScrollHelper2.UpdateScrollBar()
    End Sub


    Private Sub selectItem(origen As DataGridView, destino As DataGridView, e As MouseEventArgs)

        sourcedgv = origen.Name ' obtiene el nombre del datagridview de origen
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
            Exit Sub

        End If

    End Sub

    Private Sub dgvTodos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodosLosSintomas.MouseDown
        selectItem(dgvTodosLosSintomas, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvSintomasSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomasSeleccionados.MouseDown
        selectItem(dgvSintomasSeleccionados, dgvTodosLosSintomas, e)
    End Sub

    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragDrop
        dropItem(dgvTodosLosSintomas, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvTodos_DragOver(sender As Object, e As DragEventArgs) Handles dgvTodosLosSintomas.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvTodos_DragDrop(sender As Object, e As DragEventArgs) Handles dgvTodosLosSintomas.DragDrop
        dropItem(dgvSintomasSeleccionados, dgvTodosLosSintomas, e)
    End Sub

    Private Sub traerSintomas()

        Dim s As New ControladorSintoma
        Dim arraySintomas = s.traerSintomas

        For i = 0 To arraySintomas.Count - 1
            dgvTodosLosSintomas.Rows.Add(arraySintomas(i))
        Next
    End Sub


    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        Dim prioridad As Byte
        Dim ali As New ArrayList
        Dim check As New Verificacion

        If dgvSintomasSeleccionados.Rows.Count() <> 0 Then
            If txtNomPat.Text <> Nothing Then
                If txtDescPat.Text.Length > 10 Then
                    If txtRecPat.Text.Length > 10 Then
                        If mrbPAlta.Checked = True Or mrbPBaja.Checked = True Or mrbPMedia.Checked = True Then

                            If mrbPAlta.Checked Then
                                prioridad = 1
                            ElseIf mrbPMedia.Checked Then
                                prioridad = 2
                            ElseIf mrbPBaja.Checked Then
                                prioridad = 3
                            End If

                            For i = 0 To dgvSintomasSeleccionados.Rows.Count() - 1
                                ali.Add(dgvSintomasSeleccionados.Rows(i).Cells(0).Value)
                            Next

                            Dim p As New ControladorPatologia(txtNomPat.Text.ToUpper, txtDescPat.Text.ToUpper, txtRecPat.Text.ToUpper, prioridad, ali)

                            If p.VerificarBaja(txtNomPat.Text.ToUpper) Then

                                If p.registrar() Then
                                    MsgBox("Patología registrada con éxito")
                                    txtNomPat.Text = Nothing
                                    txtDescPat.Text = Nothing
                                    txtRecPat.Text = Nothing
                                    dgvTodosLosSintomas.Rows.Clear()
                                    dgvSintomasSeleccionados.Rows.Clear()
                                    mrbPAlta.Checked = False
                                    mrbPBaja.Checked = False
                                    mrbPMedia.Checked = False
                                    traerSintomas()
                                    ali.Clear()
                                Else
                                    MsgBox("La patología ya fue ingresada")
                                End If

                            Else
                                Dim respuesta As Integer = MsgBox("La patología se encuentra dada de baja. ¿Desea reingresarla al sistema?", vbQuestion + vbYesNo + vbDefaultButton2)

                                If respuesta = vbYes Then

                                    Dim respuesta2 As Integer = MsgBox("¿Desea actualizar la patología con los datos ingresados?", vbQuestion + vbYesNo + vbDefaultButton2)

                                    If respuesta2 = vbYes Then
                                        If p.ReingresarConDatos(txtNomPat.Text.ToUpper, txtDescPat.Text.ToUpper, txtRecPat.Text.ToUpper, prioridad, ali) Then

                                            MsgBox("Patología reingresada con éxito")
                                            txtNomPat.Text = Nothing
                                            txtDescPat.Text = Nothing
                                            txtRecPat.Text = Nothing
                                            dgvTodosLosSintomas.Rows.Clear()
                                            dgvSintomasSeleccionados.Rows.Clear()
                                            mrbPAlta.Checked = False
                                            mrbPBaja.Checked = False
                                            mrbPMedia.Checked = False
                                            traerSintomas()
                                            ali.Clear()
                                        Else
                                            MsgBox("Error al reingresar la patología")
                                            ali.Clear()
                                        End If

                                    Else

                                        If p.ReingresarPatologia(txtNomPat.Text.ToUpper) Then
                                            MsgBox("Patología reingresada con éxito")
                                            txtNomPat.Text = Nothing
                                            txtDescPat.Text = Nothing
                                            txtRecPat.Text = Nothing
                                            dgvTodosLosSintomas.Rows.Clear()
                                            dgvSintomasSeleccionados.Rows.Clear()
                                            mrbPAlta.Checked = False
                                            mrbPBaja.Checked = False
                                            mrbPMedia.Checked = False
                                            traerSintomas()
                                            ali.Clear()
                                        Else
                                            MsgBox("Error al reingresar la patología")
                                            ali.Clear()
                                        End If

                                    End If

                                End If

                            End If

                        Else
                            MsgBox("Debe ingresar una prioridad")
                        End If
                    Else
                        MsgBox("Debe ingresar una recomendación completa")
                    End If
                Else
                    MsgBox("Debe ingresar una descripción completa")
                End If
            Else
                MsgBox("Debe ingresar un nombre")
            End If
        Else
            MsgBox("Debe seleccionar síntomas para la patología")
        End If

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pnlTituloPatologia_MouseDown(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseMove(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseUp(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        If Not (txtDescPat.Text = Nothing And txtNomPat.Text = Nothing And txtRecPat.Text = Nothing And dgvSintomasSeleccionados.Rows.Count = 0) Then
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        End If

    End Sub

    Private Sub pnlTituloPatologia_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        pnlPatologia.BringToFront()
        transicion.Hide(pnlPatologia)
        transicion.Show(pnlSintomas)
    End Sub

    Private Sub txtDescPat_TextChanged(sender As Object, e As EventArgs) Handles txtDescPat.TextChanged
        lblCantDesc.Text = txtDescPat.Text.Length & "/300"
    End Sub

    Private Sub txtRecPat_TextChanged(sender As Object, e As EventArgs) Handles txtRecPat.TextChanged
        lblCantRec.Text = txtRecPat.Text.Length & "/300"
    End Sub

    Private Sub dgvTodosLosSintomas_Resize(sender As Object, e As EventArgs) Handles dgvTodosLosSintomas.Resize
        If ScrollHelper2 IsNot Nothing Then
            ScrollHelper2.UpdateScrollBar()
        End If

    End Sub
    Private Sub dgvSintomasSeleccionados_Resize(sender As Object, e As EventArgs) Handles dgvSintomasSeleccionados.Resize
        If ScrollHelper IsNot Nothing Then
            ScrollHelper.UpdateScrollBar()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        pnlSintomas.BringToFront()
        transicion.Hide(pnlSintomas)
        transicion.Show(pnlPatologia)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Not (txtDescPat.Text = Nothing And txtNomPat.Text = Nothing And txtRecPat.Text = Nothing And dgvSintomasSeleccionados.Rows.Count = 0) Then
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

    Private Sub txtDescPat_GotFocus(sender As Object, e As EventArgs) Handles txtDescPat.GotFocus
        sepDesc.LineColor = Colores.violeta_DARK
    End Sub

    Private Sub txtRecPat_GotFocus(sender As Object, e As EventArgs) Handles txtRecPat.GotFocus
        sepRec.LineColor = Colores.violeta_DARK
    End Sub
End Class