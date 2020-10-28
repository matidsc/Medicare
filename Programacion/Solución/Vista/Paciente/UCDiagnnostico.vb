Imports Logica
Public Class UCDiagnnostico
    Private pat As New ControladorPatologia
    Private sin As New ControladorSintoma
    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte)

        InitializeComponent()

        lblNom.Text = nombre
        txtDescripcion.Text = descripcion
        txtRecomendacion.Text = recomendacion

        If prioridad = 1 Then
            pbAdvertencia.Visible = True
        Else
            pbAdvertencia.Visible = False
        End If

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

        Dim uc = New UCPatologia(lblNom.Text, sin.TraerSintomasDePatologia(lblNom.Text))
        Me.ParentForm.Controls.Add(uc)
        uc.BringToFront()
        uc.Show()
        uc.Top = (frmObtenerDiagnostico.Height / 2) - (uc.Height / 2)
        uc.Left = (frmObtenerDiagnostico.Width / 2) - (uc.Width / 2)
    End Sub

    Private Sub MetroToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub IconPictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles pbAdvertencia.MouseHover
        MetroToolTip1.Show("Advertencia: Recomendamos que solicite un chat debido a la gravedad de la enfermedad.", pbAdvertencia)
    End Sub
    Private Sub IconPictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pbAdvertencia.MouseLeave
        MetroToolTip1.Hide(pbAdvertencia)
    End Sub
End Class
