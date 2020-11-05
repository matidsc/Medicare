<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCObservacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtObservacion = New Guna.UI.WinForms.GunaTextBox()
        Me.btnEnviar = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'txtObservacion
        '
        Me.txtObservacion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtObservacion.BorderColor = System.Drawing.Color.Silver
        Me.txtObservacion.BorderSize = 0
        Me.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacion.FocusedBaseColor = System.Drawing.Color.White
        Me.txtObservacion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObservacion.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Silver
        Me.txtObservacion.Location = New System.Drawing.Point(147, 37)
        Me.txtObservacion.MultiLine = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.Size = New System.Drawing.Size(572, 189)
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Text = "GunaTextBox1"
        '
        'btnEnviar
        '
        Me.btnEnviar.Animated = True
        Me.btnEnviar.AnimationHoverSpeed = 0.07!
        Me.btnEnviar.AnimationSpeed = 0.03!
        Me.btnEnviar.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEnviar.BorderColor = System.Drawing.Color.Black
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnviar.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEnviar.Image = Nothing
        Me.btnEnviar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnviar.Location = New System.Drawing.Point(319, 258)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEnviar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEnviar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviar.OnHoverImage = Nothing
        Me.btnEnviar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviar.Radius = 10
        Me.btnEnviar.Size = New System.Drawing.Size(199, 42)
        Me.btnEnviar.TabIndex = 182
        Me.btnEnviar.Text = "Enviar observación"
        Me.btnEnviar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEnviar.Visible = False
        '
        'UCObservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtObservacion)
        Me.Name = "UCObservacion"
        Me.Size = New System.Drawing.Size(864, 319)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtObservacion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnEnviar As Guna.UI.WinForms.GunaButton
End Class
