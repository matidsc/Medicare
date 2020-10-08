Imports Logica
Public Class frmModular
    Public op As Byte
    Private Sub frmPatologiasySintomas_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case op
            Case 0
                lblTitulo.Text = "MENU PATOLOGÍAS"
                lblTitulo2.Text = "Listado de patologías"
                lblSubtitulo1.Text = "Registre patologías manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Acceda a todas las patologías registradas y a opciones de eliminar y modificar"
            Case 1
                lblTitulo.Text = "MENU SÍNTOMAS"
                lblTitulo2.Text = "Listado de síntomas"
                lblSubtitulo1.Text = "Registre síntomas manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar"
            Case 2
                lblTitulo.Text = "MENU USUARIOS"
                lblTitulo1.Text = "Registrar médico"
                lblTitulo2.Text = "Registrar gestor"
                lblSubtitulo1.Text = "Registre médicos manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Registre gestores manualmente o desde un archivo CSV"
        End Select


    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub pnlIngresar_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseEnter, lblTitulo1.MouseEnter, lblSubtitulo1.MouseEnter
        Principal.Singleton.hover(pnlOpcion1)
    End Sub

    Private Sub pnlIngresar_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseLeave, lblTitulo1.MouseLeave, lblSubtitulo1.MouseLeave
        Principal.Singleton.leave(pnlOpcion1)
    End Sub

    Private Sub pnlListado_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseEnter, lblTitulo2.MouseEnter, lblSubtitulo2.MouseEnter
        Principal.Singleton.hover(pnlOpcion2)
    End Sub

    Private Sub pnlListado_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseLeave, lblSubtitulo2.MouseLeave, lblTitulo2.MouseLeave
        Principal.Singleton.leave(pnlOpcion2)
    End Sub

    Private Sub pnlOpcion1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpcion1.MouseDown

        If op = 0 Then
            Dim frm As New frmRegistrarPatologia
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frmRegistrarPatologia)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        ElseIf op = 1 Then
            Dim frm As New frmRegistrarSintoma
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frmRegistrarSintoma)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        Else
            Dim frm As New frmRegistrarMedico
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frmRegistrarMedico)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        End If

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub


    Private Sub pnlOpcion2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpcion2.MouseDown

        Select Case op
            Case 2
                Dim frm As New frmRegistroGestor
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmRegistroGestor)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()
            Case 1

                Dim frm As New frmListadoPatologiasySintomas
                frm.op = "síntomas"
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListadoPatologiasySintomas)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 0
                Dim frm As New frmListadoPatologiasySintomas
                frm.op = "patologías"
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListadoPatologiasySintomas)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()
        End Select

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Principal.Singleton.CambiarTamaño(frmBienvenidaGestor)
        Me.Dispose()
    End Sub
End Class
