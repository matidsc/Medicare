Public Class UCDiagnnostico
    Public Sub New(nombre As String, descripcion As String, recomendacion As String)

        InitializeComponent()

        lblNom.Text = nombre
        txtDescripcion.Text = descripcion
        txtRecomendacion.Text = recomendacion

        AddHandler btnSintomas.Click, AddressOf evento
    End Sub
    Private Sub lblNom_Click(sender As Object, e As EventArgs) Handles lblNom.Click

    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        'frmObtenerDiagnostico.UcPatologia1.Top = Me.Top
        'frmObtenerDiagnostico.UcPatologia1.Left = Me.Left + Me.Width

    End Sub
    Public Sub evento(sender As Object, e As EventArgs)

        frmObtenerDiagnostico.Panel1.BackColor = Color.Red
        frmObtenerDiagnostico.UcPatologia1.BringToFront()
        MsgBox("hola")
    End Sub
End Class
