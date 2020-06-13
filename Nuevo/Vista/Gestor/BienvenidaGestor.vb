Public Class BienvenidaGestor
    Dim drag As Boolean
    Dim mousex, mousey As Integer
    Private Sub BienvenidaGestor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim p As New Principal
        p.roundedCorners(Me)
        p.roundedCorners(Panel1)
        p.roundedCorners(Panel16)
        p.roundedCorners(Panel15)
        p.roundedCorners(Panel12)
        p.roundedCorners(Panel16)
        p.roundedCorners(Panel5)
        p.roundedCorners(Panel14)
    End Sub
    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel6.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel6.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel6_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel6.MouseUp
        drag = False

    End Sub



    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub


End Class