Imports Logica
Public Class frmRegistrarSintoma
    Private op As Byte
    Private sin As New ControladorSintoma
    Public Sub New()

        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

    End Sub
    Public Sub New(op As Byte)

        InitializeComponent()
        Me.op = op
        Select Case op
            Case 0

            Case 1
                btnRegistrar.Text = "Modificar Síntoma"

        End Select

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub llenarCampos(nombre As String)

        txtNom.Text = nombre
        txtDescripcion.Text = sin.traerInfoSintomas(nombre)
        Label1.Text = nombre
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If op = 0 Then
            If txtDescripcion.Text.Length > 10 Then
                Dim sintoma As New ControladorSintoma(txtNom.Text, txtDescripcion.Text)

                If sintoma.Registrar() Then
                    MsgBox("Síntoma registrado con éxito")
                    txtDescripcion.Text = Nothing
                    txtNom.Text = Nothing
                Else
                    MsgBox("Error al registrar el síntoma")
                End If

            Else
                MsgBox("Debe completar la descripción")
            End If

        ElseIf op = 1 Then

            If txtDescripcion.Text.Length > 10 Then
                Dim sintoma As New ControladorSintoma(txtNom.Text, txtDescripcion.Text)

                If sintoma.Modificar(Label1.Text) Then
                    MsgBox("Síntoma modificado con éxito")
                    Label1.Text = txtNom.Text
                Else
                    MsgBox("Error al modificar el síntoma")
                End If

            Else
                MsgBox("Debe completar la descripción")
            End If
        End If


    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        lblCantText.Text = txtDescripcion.Text.Length & "/300"
    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        If op = 0 Then
            If Not (txtNom.Text = Nothing And txtDescripcion.Text = Nothing) Then
                Dim res = MsgBox("Hay información sin guardar, ¿Seguro desea salir?", vbYesNo)
                If res = vbYes Then
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                End If
            Else
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If

        ElseIf op = 1 Then

            Principal.Singleton.CambiarTamaño(frmListado)
            Me.Dispose()

        End If
    End Sub

    Private Sub pnlContenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenedor.Paint

    End Sub
End Class