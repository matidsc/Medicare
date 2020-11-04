Imports Logica
Public Class UCSolicitudes
    Dim idChat As Int32
    Dim cedula As String
    Private pat As New ControladorPatologia
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(cedula As String, idChat As Integer, nombre As String, edad As Integer)


        InitializeComponent()
        Me.idChat = idChat
        Me.cedula = cedula
        lblNombre.Text = nombre
        lblEdad.Text = edad.ToString & " años"

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarChat.Click

        Dim instancia As frmChat = Me.ParentForm
        If ControladorChat.Singleton.verificarCedula(idChat) Then

            Dim respuesta As Integer

            respuesta = MsgBox("¿Desea entrar al chat con el usuario " + cedula + "?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                ControladorChat.Singleton.entrarChat(Datos_Temporales.userLog, idChat)
                Datos_Temporales.idchat = idChat
                Datos_Temporales.pacienteSelecionado = cedula

                Dim frm As New frmChat()
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmChat)
                frm.Show()
                instancia.pnlContenedor.Hide()
                instancia.pnlInstancia.Show()
                Me.ResumeLayout()
                frmChat.Update()

            End If

        Else
            MsgBox("Error al ingresar al chat")
        End If
    End Sub

    Private Sub btnDiagnostico_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click

        Dim instancia As frmBienvenidaMedico = Me.ParentForm
        Dim frm As New frmObtenerDiagnostico(pat.traerUltimoDiagnostico(Me.cedula), 0)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
        frm.Show()
        instancia.pnlContenedor.Hide()
        instancia.pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
End Class
