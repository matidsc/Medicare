
Public Class Mensaje
    Public Property idMsj
    Public Sub New(esEmisor As Boolean, Mensaje As String, Fecha As Date, idMsj As Int32, Perfil As Bitmap)
        InitializeComponent()

        Me.idMsj = idMsj

        If (esEmisor) Then

            lbl_Enviado.Text = Mensaje
            horaRecibido.Visible = False
            horaEnviado.Visible = True
            lbl_Recibido.Visible = False
            lbl_Enviado.Visible = True
            horaEnviado.Text = Fecha.Hour().ToString() & ":" & Fecha.Minute.ToString & ":" & Fecha.Second.ToString
            lbl_Enviado.Size = TextRenderer.MeasureText(lbl_Enviado.Text, lbl_Enviado.Font)
            Me.Height = lbl_Enviado.Height + 15
            'Principal.Singleton.SuperRoundedCorners(lbl_Enviado)

        Else
            lbl_Recibido.Text = Mensaje
            horaEnviado.Visible = False
            horaRecibido.Visible = True
            lbl_Recibido.Visible = True
            lbl_Enviado.Visible = False
            horaRecibido.Text = Fecha.Hour().ToString() & ":" & Fecha.Minute.ToString & ":" & Fecha.Second.ToString
            lbl_Recibido.Size = TextRenderer.MeasureText(lbl_Recibido.Text, lbl_Recibido.Font)
            Me.Height = lbl_Recibido.Height + 15
            'Principal.Singleton.SuperRoundedCorners(lbl_Recibido)
        End If

    End Sub

    Private Sub Mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class