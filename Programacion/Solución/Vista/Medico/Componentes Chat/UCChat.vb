Imports Logica
Public Class UCChat
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(nombre As String, mensaje As String, fecha As Date, idChat As Int32, cedula As String, foto As String)

        InitializeComponent()
        lblNombre.Text = nombre
        lblMensaje.Text = mensaje
        lblFecha.Text = fecha
        lblidChat.Text = idChat
        lblCed.Text = cedula
        SetDate(fecha)

        If foto <> Nothing Then
            GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(foto)
        Else
            GunaCirclePictureBox1.Image = My.Resources.noPic
        End If

    End Sub
    Public Sub SetDate(fecha As Date)

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

    End Sub
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave

        Dim instancia As frmChat = Me.ParentForm

        If instancia.instanciaChat IsNot Nothing Then
            If (sender IsNot instancia.instanciaChat) Then
                Me.BackColor = Color.FromArgb(31, 39, 49)
            End If
        End If

    End Sub
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

        Dim instancia As frmChat = Me.ParentForm

        If instancia.instanciaChat IsNot Nothing Then
            If (sender IsNot instancia.instanciaChat) Then
                Me.BackColor = Color.FromArgb(25, 34, 41)
            End If
        End If

    End Sub
    Private Sub CambioChat() Handles Me.Click, Me.DoubleClick, GunaCirclePictureBox1.Click, lblMensaje.Click, lblFecha.Click, lblCed.Click, lblidChat.Click, lblNombre.Click

        If Datos_Temporales.idchat <> lblidChat.Text Then

            Datos_Temporales.idchat = lblidChat.Text
            Datos_Temporales.pacienteSelecionado = lblCed.Text

            Dim instancia As frmChat = Me.ParentForm

            Me.BackColor = Color.FromArgb(25, 34, 41)
            instancia.instanciaChat.BackColor = Color.FromArgb(31, 39, 49)
            instancia.instanciaChat = Me
            instancia.ReloadChat()
            instancia.lblUsuario.Text = Me.lblNombre.Text
            instancia.lblUsuario.Visible = True
            instancia.pbPerfil.Visible = True
            instancia.btnFinalizar.Visible = True
            instancia.btnSintomasDiag.Visible = True
            instancia.pbEnviar.Visible = True
            instancia.txtMsg.Visible = True
            instancia.lblEscriba.Visible = True
            instancia.pnlEnviar.Visible = True

            If GunaCirclePictureBox1.Image IsNot Nothing Then
                instancia.pbPerfil.Image = GunaCirclePictureBox1.Image
            Else
                instancia.pbPerfil.Image = My.Resources.noPic
            End If

        End If

    End Sub

End Class