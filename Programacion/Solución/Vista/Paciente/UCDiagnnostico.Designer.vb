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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtRecomendacion = New System.Windows.Forms.TextBox()
        Me.pnlPatologia = New Guna.UI.WinForms.GunaElipsePanel()
        Me.pnlWrap = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnSintomas = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlWrap.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(20, 28)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(225, 79)
        Me.lblNom.TabIndex = 190
        Me.lblNom.Text = "nom"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.ForeColor = System.Drawing.Color.White
        Me.lblPNom.Location = New System.Drawing.Point(21, 99)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(87, 20)
        Me.lblPNom.TabIndex = 194
        Me.lblPNom.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Recomendación"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.txtDescripcion.Location = New System.Drawing.Point(25, 133)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(210, 88)
        Me.txtDescripcion.TabIndex = 196
        '
        'txtRecomendacion
        '
        Me.txtRecomendacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtRecomendacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecomendacion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendacion.ForeColor = System.Drawing.Color.Silver
        Me.txtRecomendacion.Location = New System.Drawing.Point(25, 298)
        Me.txtRecomendacion.Multiline = True
        Me.txtRecomendacion.Name = "txtRecomendacion"
        Me.txtRecomendacion.Size = New System.Drawing.Size(210, 88)
        Me.txtRecomendacion.TabIndex = 197
        '
        'pnlPatologia
        '
        Me.pnlPatologia.BackColor = System.Drawing.Color.Transparent
        Me.pnlPatologia.BaseColor = System.Drawing.Color.Lime
        Me.pnlPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlPatologia.Name = "pnlPatologia"
        Me.pnlPatologia.Size = New System.Drawing.Size(582, 486)
        Me.pnlPatologia.TabIndex = 199
        Me.pnlPatologia.Visible = False
        '
        'pnlWrap
        '
        Me.pnlWrap.BackColor = System.Drawing.Color.Transparent
        Me.pnlWrap.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlWrap.Controls.Add(Me.txtRecomendacion)
        Me.pnlWrap.Controls.Add(Me.txtDescripcion)
        Me.pnlWrap.Controls.Add(Me.Label1)
        Me.pnlWrap.Controls.Add(Me.lblPNom)
        Me.pnlWrap.Controls.Add(Me.btnSintomas)
        Me.pnlWrap.Controls.Add(Me.lblNom)
        Me.pnlWrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrap.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrap.Name = "pnlWrap"
        Me.pnlWrap.Size = New System.Drawing.Size(262, 486)
        Me.pnlWrap.TabIndex = 200
        '
        'btnSintomas
        '
        Me.btnSintomas.Animated = True
        Me.btnSintomas.AnimationHoverSpeed = 0.07!
        Me.btnSintomas.AnimationSpeed = 0.03!
        Me.btnSintomas.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnSintomas.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.CheckedForeColor = System.Drawing.Color.White
        Me.btnSintomas.CheckedImage = CType(resources.GetObject("btnSintomas.CheckedImage"), System.Drawing.Image)
        Me.btnSintomas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.Location = New System.Drawing.Point(49, 411)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Radius = 5
        Me.btnSintomas.Size = New System.Drawing.Size(165, 50)
        Me.btnSintomas.TabIndex = 191
        Me.btnSintomas.Text = "VER SÍNTOMAS"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCDiagnnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Controls.Add(Me.pnlWrap)
        Me.Controls.Add(Me.pnlPatologia)
        Me.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Name = "UCDiagnnostico"
        Me.Size = New System.Drawing.Size(262, 486)
        Me.pnlWrap.ResumeLayout(False)
        Me.pnlWrap.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblNom As Label
    Friend WithEvents btnSintomas As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPNom As Label
    Friend WithEvents txtRecomendacion As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents pnlPatologia As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents pnlWrap As Guna.UI.WinForms.GunaElipsePanel
End Class
