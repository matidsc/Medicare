Imports Logica
Public Class UCPatologia
    Private sin As New ControladorSintoma
    Public Sub New(nombre As String, sintomas As ArrayList)

        InitializeComponent()

        lblTitulo.Text += "" & nombre
        For Each sintoma In sintomas
            dgvSintomas.Rows.Add(sintoma)
        Next
        dgvSintomas.Rows(0).Selected = True
        setTextos(dgvSintomas.Rows(0).Cells(0).Value)

        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomas, scroll, True)
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub

    Private Sub setTextos(sintoma As String)
        Label1.Text = sin.traerInfoSintomas(sintoma)
        lblNomSin2.Text = sintoma.ToLower & "?"
        ' lblNomSin.Text += sintoma & " ?"
    End Sub

    Private Sub dgvSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintomas.CellClick
        setTextos(dgvSintomas.CurrentCell.Value)
    End Sub

End Class
