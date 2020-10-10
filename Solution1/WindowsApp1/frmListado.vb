Public Class frmListado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmListado_Load(sender As Object, e As EventArgs) Handles Me.Load
        scroll.Width = 5
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scroll, True)
        dgvSintomasSeleccionados.Rows.Add()

        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()

        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
        dgvSintomasSeleccionados.Rows.Add()
    End Sub
End Class