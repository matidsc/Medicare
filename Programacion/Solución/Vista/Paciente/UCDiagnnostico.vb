Imports Logica
Public Class UCDiagnnostico
    Private pat As New controladorpatologia
    Public Sub New(nombre As String, descripcion As String, recomendacion As String)

        InitializeComponent()

        lblNom.Text = nombre
        txtDescripcion.Text = descripcion
        txtRecomendacion.Text = recomendacion


    End Sub
    Private Sub lblNom_Click(sender As Object, e As EventArgs) Handles lblNom.Click

    End Sub


    Private Sub btnSintomas_Click(sender As Object, e As EventArgs)




        'Dim frm As New UCPatologia
        'Me.SuspendLayout()
        'Principal.Singleton.CargarVentana(frmObtenerDiagnostico.pnlInstancia, frm)
        'Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
        'frm.Show()
        'frmObtenerDiagnostico.pnlContenedor.Hide()
        'frmObtenerDiagnostico.pnlInstancia.Show()
        'Me.ResumeLayout()

        'uc.Show()

        'frmObtenerDiagnostico.UcPatologia1.Top = Me.Top
        'frmObtenerDiagnostico.UcPatologia1.Left = Me.Left + Me.Width

    End Sub

    Private Sub btnSintomas_Click_1(sender As Object, e As EventArgs) Handles btnSintomas.Click
        Dim dt = pat.informacionPatologia(lblNom.Text)

        Dim uc = New UCPatologia(lblNom.Text)
        Me.ParentForm.Controls.Add(uc)
        uc.BringToFront()
        uc.Show()
        uc.Top = (frmObtenerDiagnostico.Height / 2) - (uc.Height / 2)
        uc.Left = (frmObtenerDiagnostico.Width / 2) - (uc.Width / 2)
        'Dim uc As New UCPatologia
        'Me.Hide()
        'Dim ParentForm As frmObtenerDiagnostico = (Me.FindForm)
        'ParentForm.Controls.Add(uc)
        'MsgBox(ParentForm.ToString)
    End Sub

End Class
