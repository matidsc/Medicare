Imports Logica
Public Class UCPatologia

    Private dtDescripcion As DataTable
    Public Sub New(sintomas As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(nombre As String, sintomas As DataTable)

        InitializeComponent()
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomas, scroll, True)

        lblTitulo.Text += " " & nombre
        lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)
        dtDescripcion = sintomas

        For Each sintoma As DataRow In sintomas.Rows
            dgvSintomas.Rows.Add(sintoma.Item(0))
        Next

        dgvSintomas.Rows(0).Selected = True
        setTextos(dgvSintomas.Rows(0).Cells(0).Value, 0)

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub

    Private Sub setTextos(sintoma As String, indice As Integer)
        Label1.Text = dtDescripcion.Rows.Item(indice).Item(1).ToString
        lblNomSin.Text = "¿Qué es "
        lblNomSin.Text = lblNomSin.Text & sintoma.ToLower & "?"
    End Sub

    Private Sub dgvSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintomas.CellClick
        setTextos(dgvSintomas.CurrentCell.Value, dgvSintomas.CurrentCell.RowIndex)
    End Sub

    Private Sub UCPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
