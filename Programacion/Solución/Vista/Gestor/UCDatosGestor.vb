Imports Logica
Public Class UCDatosGestor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Public Sub New(informacionGestor As DataTable)

    '    InitializeComponent()

    '    lblCed.Text = informacionGestor(0)(0)
    '    lblNom.Text = informacionGestor(0)(1) & " " & informacionGestor(0)(2) & " " & informacionGestor.Rows(0).Item(3) & " " & informacionGestor.Rows(0).Item(4)
    '    lblMail.Text = informacionGestor.Rows(0).Item(5)

    '    lblNom.Location = New Point((Me.Width - lblNom.Width) \ 2, lblNom.Location.Y)
    '    lblMail.Location = New Point((Me.Width - lblMail.Width) \ 2, lblMail.Location.Y)
    '    lblCed.Location = New Point((Me.Width - lblCed.Width) \ 2, lblCed.Location.Y)

    'End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub
End Class
