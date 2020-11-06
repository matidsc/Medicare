<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAdvertencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEnviar = New Guna.UI.WinForms.GunaButton()
        Me.pbAdvertencia = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 84)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "No has cambiado tu constraseña desde que fuiste registreado, por razones de segur" &
    "idad, debes cambiarla"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 32)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Advertencia"
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
        Me.btnEnviar.Location = New System.Drawing.Point(185, 187)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEnviar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEnviar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviar.OnHoverImage = Nothing
        Me.btnEnviar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviar.Radius = 10
        Me.btnEnviar.Size = New System.Drawing.Size(199, 42)
        Me.btnEnviar.TabIndex = 202
        Me.btnEnviar.Text = "ir a cambiar contraseña"
        Me.btnEnviar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbAdvertencia
        '
        Me.pbAdvertencia.BackColor = System.Drawing.Color.Transparent
        Me.pbAdvertencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAdvertencia.ForeColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.pbAdvertencia.IconColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.IconSize = 73
        Me.pbAdvertencia.Location = New System.Drawing.Point(467, 15)
        Me.pbAdvertencia.Name = "pbAdvertencia"
        Me.pbAdvertencia.Size = New System.Drawing.Size(73, 76)
        Me.pbAdvertencia.TabIndex = 204
        Me.pbAdvertencia.TabStop = False
        '
        'UCAdvertencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbAdvertencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEnviar)
        Me.Name = "UCAdvertencia"
        Me.Size = New System.Drawing.Size(551, 248)
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pbAdvertencia As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEnviar As Guna.UI.WinForms.GunaButton
End Class
