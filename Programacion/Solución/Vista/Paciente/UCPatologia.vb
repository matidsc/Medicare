Public Class UCPatologia
    Public Sub New(nombre As String, sintomas As ArrayList)


        InitializeComponent()


    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub
End Class
