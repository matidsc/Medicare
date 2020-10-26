<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnnostico
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDiagnnostico))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.btnRegistro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblRecomendacion = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(30, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(195, 79)
        Me.lblDescripcion.TabIndex = 189
        Me.lblDescripcion.Text = "Nombre"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(20, 118)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(225, 79)
        Me.lblNom.TabIndex = 190
        Me.lblNom.Text = "Descripción"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRegistro
        '
        Me.btnRegistro.Animated = True
        Me.btnRegistro.AnimationHoverSpeed = 0.07!
        Me.btnRegistro.AnimationSpeed = 0.03!
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnRegistro.BorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnRegistro.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.CheckedForeColor = System.Drawing.Color.White
        Me.btnRegistro.CheckedImage = CType(resources.GetObject("btnRegistro.CheckedImage"), System.Drawing.Image)
        Me.btnRegistro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistro.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Image = Nothing
        Me.btnRegistro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.Location = New System.Drawing.Point(50, 411)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnRegistro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistro.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistro.OnHoverImage = Nothing
        Me.btnRegistro.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistro.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistro.Radius = 5
        Me.btnRegistro.Size = New System.Drawing.Size(165, 50)
        Me.btnRegistro.TabIndex = 191
        Me.btnRegistro.Text = "VER SÍNTOMAS"
        Me.btnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRecomendacion
        '
        Me.lblRecomendacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRecomendacion.Location = New System.Drawing.Point(30, 279)
        Me.lblRecomendacion.Name = "lblRecomendacion"
        Me.lblRecomendacion.Size = New System.Drawing.Size(204, 79)
        Me.lblRecomendacion.TabIndex = 192
        Me.lblRecomendacion.Text = "Prioridad"
        Me.lblRecomendacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.ForeColor = System.Drawing.Color.Silver
        Me.lblPNom.Location = New System.Drawing.Point(21, 75)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(87, 20)
        Me.lblPNom.TabIndex = 194
        Me.lblPNom.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(31, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Descripción"
        '
        'UCDiagnnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.lblRecomendacion)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Name = "UCDiagnnostico"
        Me.Size = New System.Drawing.Size(262, 486)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents btnRegistro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblRecomendacion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPNom As Label
End Class
