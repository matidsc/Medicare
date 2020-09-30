Public Class Form3



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sc As New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, GunaVScrollBar1, True)

        dgvTodos.Rows.Add()
        dgvTodos.Rows.Add()
        dgvTodos.Rows.Add()
        dgvTodos.Rows.Add()
        dgvTodos.Rows.Add()
        dgvTodos.Rows.Add()


        For i = 0 To 25
            dgvSintomasSeleccionados.Rows.Add()
            dgvSintomasSeleccionados.Rows(i).Cells(0).Value = i

        Next


        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
        GunaDataGridView1.Rows.Add()
    End Sub
End Class