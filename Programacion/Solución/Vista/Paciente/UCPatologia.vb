Public Class UCPatologia
    Public Sub New(nombre As String)


        InitializeComponent()
        lblNomPat.Text = nombre

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub
End Class
