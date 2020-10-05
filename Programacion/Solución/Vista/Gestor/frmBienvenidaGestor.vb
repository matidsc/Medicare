Imports Logica

Public Class frmBienvenidaGestor

    Dim gestor As New ControladorGestor

    Private Sub BienvenidaGestor_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Principal.Singleton.RoundedCorners(Me)


        'Me.BackColor = Color.FromArgb(236, 236, 236)
        'Dim col As Color = Color.FromArgb(52, 73, 94)

        'Panel1.BackColor = Color.WhiteSmoke

        'Panel3.BackColor = Color.WhiteSmoke
        'Panel4.BackColor = Color.WhiteSmoke
        'Panel5.BackColor = Color.WhiteSmoke
        'Panel6.BackColor = Color.FromArgb(236, 236, 236)
        'Panel12.BackColor = Color.WhiteSmoke
        'Panel15.BackColor = Color.WhiteSmoke
        'Panel16.BackColor = Color.WhiteSmoke

        'Label1.ForeColor = col
        'Label2.ForeColor = col
        'Label3.ForeColor = col

        'Label5.ForeColor = col
        'Label6.ForeColor = col
        'Label7.ForeColor = col
        'Label8.ForeColor = col
        'Label9.ForeColor = col
        'Label10.ForeColor = col
        'Label11.ForeColor = col
        'Label12.ForeColor = col
        'Label13.ForeColor = col
        'Label14.ForeColor = col

        'Label16.ForeColor = col
        'Label17.ForeColor = col
        'Label18.ForeColor = col
        'Label19.ForeColor = col

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs)
        'Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs)
        'Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub Panel6_MouseUp(sender As Object, e As MouseEventArgs)
        ' Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub pnlPatologias_MouseDown(sender As Object, e As MouseEventArgs)
        Dim frm As New frmModular()
        frm.op = 0
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub
    Private Sub pnlSintomas_MouseDown(sender As Object, e As MouseEventArgs)
        Dim frm As New frmModular()
        frm.op = 1
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
    Private Sub pnlRegistrodeUsuarios_MouseDown(sender As Object, e As MouseEventArgs)
        Dim frm As New frmModular()
        frm.op = 2
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmRegistroGestor.Show() 'registro gestor
    End Sub

    Private Sub btnNotificacion_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tempListaPacientes.Tick
        dgvListadoPacientes.DataSource = gestor.listarPacientes
    End Sub

    Private Sub dgvListadoPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellDoubleClick

    End Sub

    Private Sub dgvListadoPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
                                           Handles dgvListadoPacientes.CellContentClick
        If e.RowIndex >= 0 Then

            If dgvListadoPacientes.Columns(e.ColumnIndex).Index = 0 Then
                Dim respuesta As Integer = MsgBox("¿Desea habilitar a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

                If respuesta = vbYes Then

                    gestor.habilitar(dgvListadoPacientes.Rows(e.RowIndex).Cells(2).Value)

                End If

            Else
                Dim respuesta As Integer = MsgBox("¿Desea dar de baja a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

                If respuesta = vbYes Then

                    gestor.eliminar(dgvListadoPacientes.Rows(e.RowIndex).Cells(2).Value)

                End If

            End If
        End If

    End Sub

    Private Sub btnRefrescarListadoPac_Click(sender As Object, e As EventArgs) Handles btnRefrescarListadoPac.Click
        dgvListadoPacientes.DataSource = gestor.listarPacientes
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub



    Private Sub btn2_Click(sender As Object, e As EventArgs)
        frmManualCsv.Show()
    End Sub

    Private Sub btnPatologia_Click(sender As Object, e As EventArgs) Handles btnPatologia.Click
        Dim frm As New frmModular()
        frm.op = 0
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        Dim frm As New frmModular()
        frm.op = 1
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim frm As New frmModular()
        frm.op = 2
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmModular)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub


    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click

        If pnlListadoPacientes.Visible = True Then
            pnlListadoPacientes.Visible = False
        Else
            pnlListadoPacientes.Visible = True

        End If
    End Sub
End Class