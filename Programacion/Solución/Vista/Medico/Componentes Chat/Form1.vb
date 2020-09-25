Imports Logica
Public Class Form1

    Dim SetColor As Boolean = False
    Public Sub New(nombre As String, mensaje As String, fecha As String, idChat As Int32, cedula As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        lblNombre.Text = nombre
        lblMensaje.Text = mensaje
        lblFecha.Text = "21:37"
        lblidChat.Text = idChat
        lblMensaje.Font = New Drawing.Font("Segoe UI", 14, FontStyle.Regular)
        lblMensaje.ForeColor = Color.FromArgb(210, 212, 213)
        lblCed.Text = cedula
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If SetColor = False Then
            Me.BackColor = Color.FromArgb(31, 39, 49)
        End If

    End Sub

    Private Sub lblFecha_MouseEnter(sender As Object, e As EventArgs) Handles lblFecha.MouseEnter
        'Me.BackColor = Color.FromArgb(25, 34, 41)
    End Sub

    Private Sub lblFecha_MouseLeave(sender As Object, e As EventArgs) Handles lblFecha.MouseLeave
        'Me.BackColor = Color.FromArgb(31, 39, 49)
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If SetColor = False Then
            Me.BackColor = Color.FromArgb(25, 34, 41)
        End If

    End Sub
    Private Sub CambioChat() Handles Me.Click
        Me.BackColor = Color.FromArgb(25, 34, 41)
        SetColor = True

        Datos_Temporales.idchat = lblidChat.Text
        Datos_Temporales.pacienteSelecionado = lblCed.Text
        MsgBox(lblidChat.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class