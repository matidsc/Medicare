Imports Logica
Public Class frmOpciones
    Public op As Byte
    Private Sub frmPatologiasySintomas_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case op
            Case 0
                lblTitulo.Text = "MENU PATOLOGÍAS"
                lblTitulo3.Text = "Listado de patologías"
                lblSubtitulo1.Text = "Registre patologías manualmente o desde un archivo CSV"
                lblSubtitulo3.Text = "Acceda a todas las patologías registradas y a opciones de eliminar y modificar"
            Case 1
                lblTitulo.Text = "MENU SÍNTOMAS"
                lblTitulo3.Text = "Listado de síntomas"
                lblSubtitulo1.Text = "Registre síntomas manualmente o desde un archivo CSV"
                lblSubtitulo3.Text = "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar"
            Case 2
                lblTitulo.Text = "MENU USUARIOS"
                lblTitulo1.Text = "Registrar médico"
                lblTitulo3.Text = "Registrar gestor"
                lblSubtitulo1.Text = "Registre médicos manualmente o desde un archivo CSV"
                lblSubtitulo3.Text = "Registre gestores manualmente o desde un archivo CSV"
        End Select


    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

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


    Private Sub pnlOpcion2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpcion3.MouseDown

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

                Dim frm As New frmListado(1)
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListado)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 0
                Dim frm As New frmListado(0)
                'frm.op = "patologías"
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListado)
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

    Private Sub Enter(sender As Object, e As EventArgs) Handles pnlOpcion3.MouseEnter, pnlOpcion2.MouseEnter, pnlOpcion1.MouseEnter, lblTitulo3.MouseEnter, lblTitulo2.MouseEnter, lblTitulo1.MouseEnter, lblSubtitulo3.MouseEnter, lblSubtitulo2.MouseEnter, lblSubtitulo1.MouseEnter

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.hover_DARK
        Else
            sender.backcolor = Colores.hover_DARK
        End If

    End Sub

    Private Sub Leave(sender As Object, e As EventArgs) Handles pnlOpcion3.MouseLeave, pnlOpcion2.MouseLeave, pnlOpcion1.MouseLeave, lblTitulo3.MouseLeave, lblTitulo2.MouseLeave, lblTitulo1.MouseLeave, lblSubtitulo3.MouseLeave, lblSubtitulo2.MouseLeave, lblSubtitulo1.MouseLeave

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.secundario_DARK
        Else
            sender.backcolor = Colores.secundario_DARK
        End If

    End Sub

End Class
