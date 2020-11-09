<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCHabilitarGestor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnRechazarGestor = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptarGestor = New Guna.UI.WinForms.GunaButton()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(107, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(118, 15)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Juan Perez Rodriguez"
        '
        'btnRechazarGestor
        '
        Me.btnRechazarGestor.AnimationHoverSpeed = 0.07!
        Me.btnRechazarGestor.AnimationSpeed = 0.03!
        Me.btnRechazarGestor.BackColor = System.Drawing.Color.Transparent
        Me.btnRechazarGestor.BaseColor = System.Drawing.Color.Brown
        Me.btnRechazarGestor.BorderColor = System.Drawing.Color.Black
        Me.btnRechazarGestor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRechazarGestor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRechazarGestor.FocusedColor = System.Drawing.Color.Empty
        Me.btnRechazarGestor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRechazarGestor.ForeColor = System.Drawing.Color.White
        Me.btnRechazarGestor.Image = Nothing
        Me.btnRechazarGestor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRechazarGestor.Location = New System.Drawing.Point(170, 76)
        Me.btnRechazarGestor.Name = "btnRechazarGestor"
        Me.btnRechazarGestor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRechazarGestor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRechazarGestor.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRechazarGestor.OnHoverImage = Nothing
        Me.btnRechazarGestor.OnPressedColor = System.Drawing.Color.Black
        Me.btnRechazarGestor.Size = New System.Drawing.Size(88, 22)
        Me.btnRechazarGestor.TabIndex = 17
        Me.btnRechazarGestor.Text = "Rechazar"
        Me.btnRechazarGestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptarGestor
        '
        Me.btnAceptarGestor.AnimationHoverSpeed = 0.07!
        Me.btnAceptarGestor.AnimationSpeed = 0.03!
        Me.btnAceptarGestor.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarGestor.BaseColor = System.Drawing.Color.ForestGreen
        Me.btnAceptarGestor.BorderColor = System.Drawing.Color.Black
        Me.btnAceptarGestor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarGestor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptarGestor.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptarGestor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptarGestor.ForeColor = System.Drawing.Color.White
        Me.btnAceptarGestor.Image = Nothing
        Me.btnAceptarGestor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptarGestor.Location = New System.Drawing.Point(75, 76)
        Me.btnAceptarGestor.Name = "btnAceptarGestor"
        Me.btnAceptarGestor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAceptarGestor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptarGestor.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptarGestor.OnHoverImage = Nothing
        Me.btnAceptarGestor.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptarGestor.Size = New System.Drawing.Size(88, 22)
        Me.btnAceptarGestor.TabIndex = 16
        Me.btnAceptarGestor.Text = "Aceptar"
        Me.btnAceptarGestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(124, 21)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(85, 20)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "5.298.615-5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'UCHabilitarGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnRechazarGestor)
        Me.Controls.Add(Me.btnAceptarGestor)
        Me.Controls.Add(Me.lblCedula)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UCHabilitarGestor"
        Me.Size = New System.Drawing.Size(315, 118)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnRechazarGestor As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAceptarGestor As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
End Class
