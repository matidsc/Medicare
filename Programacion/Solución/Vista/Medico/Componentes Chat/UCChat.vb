Imports Logica
Public Class ucchat



    Public Sub New(nombre As String, mensaje As String, fecha As Date, idChat As Int32, cedula As String, foto As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        lblNombre.Text = nombre
        lblMensaje.Text = mensaje
        lblFecha.Text = fecha


        If fecha.Hour < 10 Then
            lblFecha.Text = "0" & fecha.Hour().ToString() & ":"
        Else
            lblFecha.Text = fecha.Hour().ToString() & ":"
        End If

        If fecha.Minute < 10 Then
            lblFecha.Text = lblFecha.Text & "0" & fecha.Minute.ToString
        Else
            lblFecha.Text = lblFecha.Text & fecha.Minute.ToString
        End If

        lblidChat.Text = idChat
        If foto <> Nothing Then
            GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(foto)
        Else
            GunaCirclePictureBox1.Image = My.Resources.noPic
        End If
        lblCed.Text = cedula
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Dim instancia As frmChat = Me.ParentForm

        If instancia.instanciaChat IsNot Nothing Then

            If (sender IsNot instancia.instanciaChat) Then
                Me.BackColor = Color.FromArgb(31, 39, 49)
            End If

        End If

    End Sub

    Private Sub lblFecha_MouseEnter(sender As Object, e As EventArgs) Handles lblFecha.MouseEnter
        'Me.BackColor = Color.FromArgb(25, 34, 41)
    End Sub

    Private Sub lblFecha_MouseLeave(sender As Object, e As EventArgs) Handles lblFecha.MouseLeave
        'Me.BackColor = Color.FromArgb(31, 39, 49)
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Dim instancia As frmChat = Me.ParentForm

        If instancia.instanciaChat IsNot Nothing Then

            If (sender IsNot instancia.instanciaChat) Then
                Me.BackColor = Color.FromArgb(25, 34, 41)
            End If

        End If

    End Sub

    Private Sub CambioChat() Handles Me.Click

        Datos_Temporales.idchat = lblidChat.Text
        Datos_Temporales.pacienteSelecionado = lblCed.Text

        Dim instancia As frmChat = Me.ParentForm
        instancia.ReloadChat()
        instancia.lblUsuario.Text = Me.lblNombre.Text
        instancia.lblUsuario.Visible = True
        instancia.pbPerfil.Visible = True
        instancia.btnFinalizar.Visible = True
        instancia.btnSintomasDiag.Visible = True

        If GunaCirclePictureBox1.Image IsNot Nothing Then
            instancia.pbPerfil.Image = GunaCirclePictureBox1.Image
        Else
            instancia.pbPerfil.Image = My.Resources.noPic
        End If

        If instancia.instanciaChat IsNot Nothing Then
            Me.BackColor = Color.FromArgb(25, 34, 41)
            instancia.instanciaChat.BackColor = Color.FromArgb(31, 39, 49)
            instancia.instanciaChat = Me
        End If
    End Sub
End Class