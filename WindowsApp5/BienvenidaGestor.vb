Public Class BienvenidaGestor
    Dim drag As Boolean
    Dim mousex, mousey As Integer

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