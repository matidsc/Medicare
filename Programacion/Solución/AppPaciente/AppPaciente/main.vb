Imports Vista
Imports Logica
Imports WindowsApp1
Public Class main

    Public Shared instancia As main
    Public Shared Function Singleton() As main
        If instancia Is Nothing Then
            instancia = New main
        End If

        Return instancia
    End Function
    Public Function GetInstancia() As main
        Return instancia
    End Function
    Public Sub New()
        InitializeComponent()
        instancia = Me
        Dim frm As New WindowsApp1.frmLogin
        'Me.Panel11.Visible = False
        'frm.mcbRecordarUsuario.Visible = False
        'frm.lblCrearCuentaPac.Visible = True
        'frm.lblApp.Text = "Paciente"
        'Me.Location = New Point(Me.Location.X, Me.Location.Y - 35)
        CargarVentana(ventana, frm)
        'Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente
        'cambiarTamaño()
    End Sub

    Public Sub CargarVentana(ventana As Panel, formInterno As Form)
        ventana.Controls.Clear()
        formInterno.TopLevel = False
        formInterno.Dock = DockStyle.Fill
        formInterno.Size = ventana.Size
        ventana.Controls.Add(formInterno)
        formInterno.Show()
    End Sub
    Public Sub cambiarTamaño()
        Me.SuspendLayout()
        Me.Size = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MinimumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MaximumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.CenterToScreen()
        Me.ResumeLayout()
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Red
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Transparent
    End Sub
End Class