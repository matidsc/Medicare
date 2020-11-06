Public Class UCAdvertencia
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim instancia As frmBienvenidaMedico = Me.ParentForm

        Me.Dispose()
        instancia.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        instancia.Controls.Add(perfil)
        perfil.pnlCredenciales.BringToFront()
        perfil.pnlCredenciales.Visible = True

        perfil.BringToFront()
        Me.ResumeLayout()

    End Sub
End Class
