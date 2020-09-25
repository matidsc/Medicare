Imports System.Drawing.Drawing2D
Imports WinFormAnimation
Public Class Form2
    Private drag As Boolean
    Private obj As Object
    Private mousex, mousey As Integer
    Private radio = 100

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub RoundedCorners(rect As Object, radio As Integer)

        Dim gp As New Drawing2D.GraphicsPath()

        gp.StartFigure()
        gp.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        gp.AddLine(radio, 0, rect.Width - radio, 0)
        gp.AddArc(New Rectangle(rect.Width - radio, 0, radio, radio), -90, 90)
        gp.AddLine(rect.Width, radio, rect.Width, rect.Height - radio)
        gp.AddArc(New Rectangle(rect.Width - radio, rect.Height - radio, radio, radio), 0, 90)
        gp.AddLine(rect.Width - radio, rect.Height, radio, rect.Height)
        gp.AddArc(New Rectangle(0, rect.Height - radio, radio, radio), 90, 90)
        gp.CloseFigure()

        rect.Region = New Region(gp)
    End Sub

    Public Sub moverVentanaDown(form As Form)
        Me.drag = True
        Me.mousex = Cursor.Position.X - form.Left
        Me.mousey = Cursor.Position.Y - form.Top
    End Sub
    Public Sub moverVentanaUp()
        Me.drag = False
    End Sub

    Private Sub pnlCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseMove
        moverVentanaMove(Me)
    End Sub

    Private Sub pnlCerrar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseDown
        moverVentanaDown(Me)
    End Sub

    Private Sub pnlCerrar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseUp
        moverVentanaUp()
    End Sub

    Public Sub moverVentanaMove(form As Form)

        If Me.drag Then
            form.Top = Cursor.Position.Y - mousey
            form.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        RoundedCorners(Panel9, 70)
        'RoundedCorners(Me, 20)
        RoundedCorners(Panel1, 20)
        RoundedCorners(Panel3, 20)
        RoundedCorners(Panel5, 20)
        RoundedCorners(Panel7, 20)

        enterAnimation(Panel10)
        tEnter.Enabled = True
        tEnter.Start()
        'Dim an As New Animator2D(New Path2D(142, 142, -100, 119, 1000))
        'an.Play(Panel1, Animator2D.KnownProperties.Location)
    End Sub

    Public Sub enterAnimation(obj As Panel)
        Me.obj = obj
    End Sub

    Public Sub tEnter_Tick() Handles tEnter.Tick

        While obj.Location <> New Point(obj.Location.X, 137)
            obj.Location = New Point(obj.Location.X, obj.Location.Y - 1)
            Threading.Thread.Sleep(0.4)
            Console.WriteLine(obj.location.y)
        End While
        tEnter.Stop()

        'While obj.Location <> New Point(obj.Location.X, 100)
        '    obj.Location = New Point(obj.Location.X, obj.Location.Y - 1)
        '    Threading.Thread.Sleep(1)
        '    Console.WriteLine(obj.Location.Y)
        'End While

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'Dim brush As New LineargradientBrush(Me.ClientRectangle, Color.Aqua, Color.Blue, 90)
        Dim brush As New SolidBrush(Color.FromArgb(32, 39, 50))

        Dim gp As New Drawing2D.GraphicsPath()
        'gp.AddArc(New Rectangle(New Point(0, 0), New Size(Me.Height, Me.Height)), 90, 180)
        'gp.AddLine(New Point(Me.Height / 2, 0), New Point(Me.Width - (Me.Height / 2), 0))
        'gp.AddArc(New Rectangle(New Point(Me.Width - Me.Height, 0), New Size(Me.Height, Me.Height)), -90, 180)
        'gp.CloseFigure()

        gp.StartFigure()
        gp.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        gp.AddLine(radio, 0, Panel9.Width - radio, 0)
        gp.AddArc(New Rectangle(Panel9.Width - radio, 0, radio, radio), -90, 90)
        gp.AddLine(Panel9.Width, radio, Panel9.Width, Panel9.Height - radio)
        gp.AddArc(New Rectangle(Panel9.Width - radio, Panel9.Height - radio, radio, radio), 0, 90)
        gp.AddLine(Panel9.Width - radio, Panel9.Height, radio, Panel9.Height)
        gp.AddArc(New Rectangle(0, Panel9.Height - radio, radio, radio), 90, 90)
        gp.CloseFigure()

        e.Graphics.FillPath(brush, gp)
        MyBase.OnPaint(e)

    End Sub




    'MyBase.OnPaint(e)

    'Graphics g = e.Graphics
    '    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    'Dim brush As Brush = New SolidBrush()


    '    //Inner part. Button itself
    '    g.FillEllipse(Brush, 3, 3, Height - _borderThickness, Height - _borderThickness)

    'g.FillEllipse(Brush, (Width - Height) + 3, 3, Height - _borderThickness, Height - _borderThickness)

    'g.FillRectangle(Brush, Height / 2 + 3, 3, Width - Height - _borderThickness, Height - _borderThickness)


    'Brush.Dispose()
End Class