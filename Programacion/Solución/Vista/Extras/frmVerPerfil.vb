Imports Logica
Public Class frmVerPerfil
    Dim con As New ControladorPaciente
    Private Sub frmVerPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim dt As DataTable = con.getDatosPaciente(Datos_Temporales.userLog)

        MsgBox(dt.Rows(0).Item(7).ToString)
        picImagenPerfil.Image = Principal.Singleton.Base64ToImage(dt.Rows(0).Item(7))
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class