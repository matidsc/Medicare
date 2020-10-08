<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPatologia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNueva = New System.Windows.Forms.Label()
        Me.txtNombreVieja = New System.Windows.Forms.TextBox()
        Me.txtNombreNueva = New System.Windows.Forms.TextBox()
        Me.mdTxtNombreNueva = New MaterialSkin.Controls.MaterialDivider()
        Me.grpNombre = New System.Windows.Forms.GroupBox()
        Me.mdTxtNombreVieja = New MaterialSkin.Controls.MaterialDivider()
        Me.mrbtnBajaV = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnMediaV = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnAltaV = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnBajaN = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnAltaN = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnMediaN = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtDescripcionVieja = New System.Windows.Forms.TextBox()
        Me.txtDescripcionNueva = New System.Windows.Forms.TextBox()
        Me.pnlNueva = New System.Windows.Forms.Panel()
        Me.grpDescripcion = New System.Windows.Forms.GroupBox()
        Me.grpRecomendaciones = New System.Windows.Forms.GroupBox()
        Me.txtRecomendacionVieja = New System.Windows.Forms.TextBox()
        Me.txtRecomendacionNueva = New System.Windows.Forms.TextBox()
        Me.mdTxtRecomendacionNueva = New MaterialSkin.Controls.MaterialDivider()
        Me.mdTxtRecomendacionVieja = New MaterialSkin.Controls.MaterialDivider()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.lblVerYModifcar = New System.Windows.Forms.Label()
        Me.grpPrioridad = New System.Windows.Forms.GroupBox()
        Me.grpNombre.SuspendLayout()
        Me.pnlNueva.SuspendLayout()
        Me.grpDescripcion.SuspendLayout()
        Me.grpRecomendaciones.SuspendLayout()
        Me.grpPrioridad.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNueva
        '
        Me.lblNueva.AutoSize = True
        Me.lblNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNueva.Location = New System.Drawing.Point(590, 47)
        Me.lblNueva.Name = "lblNueva"
        Me.lblNueva.Size = New System.Drawing.Size(82, 29)
        Me.lblNueva.TabIndex = 151
        Me.lblNueva.Text = "Nueva"
        '
        'txtNombreVieja
        '
        Me.txtNombreVieja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreVieja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreVieja.ForeColor = System.Drawing.Color.Black
        Me.txtNombreVieja.Location = New System.Drawing.Point(116, 28)
        Me.txtNombreVieja.Name = "txtNombreVieja"
        Me.txtNombreVieja.Size = New System.Drawing.Size(200, 22)
        Me.txtNombreVieja.TabIndex = 133
        '
        'txtNombreNueva
        '
        Me.txtNombreNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreNueva.ForeColor = System.Drawing.Color.Black
        Me.txtNombreNueva.Location = New System.Drawing.Point(443, 29)
        Me.txtNombreNueva.Name = "txtNombreNueva"
        Me.txtNombreNueva.Size = New System.Drawing.Size(200, 22)
        Me.txtNombreNueva.TabIndex = 132
        '
        'mdTxtNombreNueva
        '
        Me.mdTxtNombreNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.mdTxtNombreNueva.Depth = 0
        Me.mdTxtNombreNueva.Location = New System.Drawing.Point(443, 58)
        Me.mdTxtNombreNueva.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdTxtNombreNueva.Name = "mdTxtNombreNueva"
        Me.mdTxtNombreNueva.Size = New System.Drawing.Size(200, 1)
        Me.mdTxtNombreNueva.TabIndex = 131
        Me.mdTxtNombreNueva.Text = "MaterialDivider2"
        '
        'grpNombre
        '
        Me.grpNombre.Controls.Add(Me.txtNombreVieja)
        Me.grpNombre.Controls.Add(Me.txtNombreNueva)
        Me.grpNombre.Controls.Add(Me.mdTxtNombreNueva)
        Me.grpNombre.Controls.Add(Me.mdTxtNombreVieja)
        Me.grpNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNombre.Location = New System.Drawing.Point(88, 95)
        Me.grpNombre.Name = "grpNombre"
        Me.grpNombre.Size = New System.Drawing.Size(755, 75)
        Me.grpNombre.TabIndex = 150
        Me.grpNombre.TabStop = False
        Me.grpNombre.Text = "Nombre"
        '
        'mdTxtNombreVieja
        '
        Me.mdTxtNombreVieja.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.mdTxtNombreVieja.Depth = 0
        Me.mdTxtNombreVieja.Location = New System.Drawing.Point(116, 57)
        Me.mdTxtNombreVieja.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdTxtNombreVieja.Name = "mdTxtNombreVieja"
        Me.mdTxtNombreVieja.Size = New System.Drawing.Size(200, 1)
        Me.mdTxtNombreVieja.TabIndex = 130
        Me.mdTxtNombreVieja.Text = "MaterialDivider1"
        '
        'mrbtnBajaV
        '
        Me.mrbtnBajaV.AutoSize = True
        Me.mrbtnBajaV.Depth = 0
        Me.mrbtnBajaV.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnBajaV.Location = New System.Drawing.Point(156, 93)
        Me.mrbtnBajaV.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnBajaV.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnBajaV.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnBajaV.Name = "mrbtnBajaV"
        Me.mrbtnBajaV.Ripple = True
        Me.mrbtnBajaV.Size = New System.Drawing.Size(56, 30)
        Me.mrbtnBajaV.TabIndex = 141
        Me.mrbtnBajaV.TabStop = True
        Me.mrbtnBajaV.Text = "Baja"
        Me.mrbtnBajaV.UseVisualStyleBackColor = True
        '
        'mrbtnMediaV
        '
        Me.mrbtnMediaV.AutoSize = True
        Me.mrbtnMediaV.Depth = 0
        Me.mrbtnMediaV.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnMediaV.Location = New System.Drawing.Point(156, 63)
        Me.mrbtnMediaV.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnMediaV.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnMediaV.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnMediaV.Name = "mrbtnMediaV"
        Me.mrbtnMediaV.Ripple = True
        Me.mrbtnMediaV.Size = New System.Drawing.Size(67, 30)
        Me.mrbtnMediaV.TabIndex = 140
        Me.mrbtnMediaV.TabStop = True
        Me.mrbtnMediaV.Text = "Media"
        Me.mrbtnMediaV.UseVisualStyleBackColor = True
        '
        'mrbtnAltaV
        '
        Me.mrbtnAltaV.AutoSize = True
        Me.mrbtnAltaV.Depth = 0
        Me.mrbtnAltaV.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnAltaV.Location = New System.Drawing.Point(156, 33)
        Me.mrbtnAltaV.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnAltaV.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnAltaV.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnAltaV.Name = "mrbtnAltaV"
        Me.mrbtnAltaV.Ripple = True
        Me.mrbtnAltaV.Size = New System.Drawing.Size(54, 30)
        Me.mrbtnAltaV.TabIndex = 139
        Me.mrbtnAltaV.TabStop = True
        Me.mrbtnAltaV.Text = "Alta"
        Me.mrbtnAltaV.UseVisualStyleBackColor = True
        '
        'mrbtnBajaN
        '
        Me.mrbtnBajaN.AutoSize = True
        Me.mrbtnBajaN.Depth = 0
        Me.mrbtnBajaN.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnBajaN.Location = New System.Drawing.Point(0, 70)
        Me.mrbtnBajaN.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnBajaN.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnBajaN.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnBajaN.Name = "mrbtnBajaN"
        Me.mrbtnBajaN.Ripple = True
        Me.mrbtnBajaN.Size = New System.Drawing.Size(56, 30)
        Me.mrbtnBajaN.TabIndex = 127
        Me.mrbtnBajaN.TabStop = True
        Me.mrbtnBajaN.Text = "Baja"
        Me.mrbtnBajaN.UseVisualStyleBackColor = True
        '
        'mrbtnAltaN
        '
        Me.mrbtnAltaN.AutoSize = True
        Me.mrbtnAltaN.Depth = 0
        Me.mrbtnAltaN.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnAltaN.Location = New System.Drawing.Point(0, 10)
        Me.mrbtnAltaN.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnAltaN.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnAltaN.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnAltaN.Name = "mrbtnAltaN"
        Me.mrbtnAltaN.Ripple = True
        Me.mrbtnAltaN.Size = New System.Drawing.Size(54, 30)
        Me.mrbtnAltaN.TabIndex = 125
        Me.mrbtnAltaN.TabStop = True
        Me.mrbtnAltaN.Text = "Alta"
        Me.mrbtnAltaN.UseVisualStyleBackColor = True
        '
        'mrbtnMediaN
        '
        Me.mrbtnMediaN.AutoSize = True
        Me.mrbtnMediaN.Depth = 0
        Me.mrbtnMediaN.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnMediaN.Location = New System.Drawing.Point(0, 40)
        Me.mrbtnMediaN.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnMediaN.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnMediaN.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnMediaN.Name = "mrbtnMediaN"
        Me.mrbtnMediaN.Ripple = True
        Me.mrbtnMediaN.Size = New System.Drawing.Size(67, 30)
        Me.mrbtnMediaN.TabIndex = 126
        Me.mrbtnMediaN.TabStop = True
        Me.mrbtnMediaN.Text = "Media"
        Me.mrbtnMediaN.UseVisualStyleBackColor = True
        '
        'txtDescripcionVieja
        '
        Me.txtDescripcionVieja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionVieja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionVieja.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionVieja.Location = New System.Drawing.Point(17, 68)
        Me.txtDescripcionVieja.Multiline = True
        Me.txtDescripcionVieja.Name = "txtDescripcionVieja"
        Me.txtDescripcionVieja.Size = New System.Drawing.Size(263, 48)
        Me.txtDescripcionVieja.TabIndex = 132
        Me.txtDescripcionVieja.Text = "fghjghjjgh"
        '
        'txtDescripcionNueva
        '
        Me.txtDescripcionNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionNueva.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionNueva.Location = New System.Drawing.Point(443, 68)
        Me.txtDescripcionNueva.Multiline = True
        Me.txtDescripcionNueva.Name = "txtDescripcionNueva"
        Me.txtDescripcionNueva.Size = New System.Drawing.Size(263, 48)
        Me.txtDescripcionNueva.TabIndex = 130
        Me.txtDescripcionNueva.Text = "fghjghjjgh"
        '
        'pnlNueva
        '
        Me.pnlNueva.Controls.Add(Me.mrbtnBajaN)
        Me.pnlNueva.Controls.Add(Me.mrbtnAltaN)
        Me.pnlNueva.Controls.Add(Me.mrbtnMediaN)
        Me.pnlNueva.Location = New System.Drawing.Point(486, 33)
        Me.pnlNueva.Name = "pnlNueva"
        Me.pnlNueva.Size = New System.Drawing.Size(113, 100)
        Me.pnlNueva.TabIndex = 142
        '
        'grpDescripcion
        '
        Me.grpDescripcion.Controls.Add(Me.txtDescripcionVieja)
        Me.grpDescripcion.Controls.Add(Me.txtDescripcionNueva)
        Me.grpDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDescripcion.Location = New System.Drawing.Point(88, 316)
        Me.grpDescripcion.Name = "grpDescripcion"
        Me.grpDescripcion.Size = New System.Drawing.Size(755, 166)
        Me.grpDescripcion.TabIndex = 148
        Me.grpDescripcion.TabStop = False
        Me.grpDescripcion.Text = "Descripción"
        '
        'grpRecomendaciones
        '
        Me.grpRecomendaciones.Controls.Add(Me.txtRecomendacionVieja)
        Me.grpRecomendaciones.Controls.Add(Me.txtRecomendacionNueva)
        Me.grpRecomendaciones.Controls.Add(Me.mdTxtRecomendacionNueva)
        Me.grpRecomendaciones.Controls.Add(Me.mdTxtRecomendacionVieja)
        Me.grpRecomendaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRecomendaciones.Location = New System.Drawing.Point(88, 488)
        Me.grpRecomendaciones.Name = "grpRecomendaciones"
        Me.grpRecomendaciones.Size = New System.Drawing.Size(755, 115)
        Me.grpRecomendaciones.TabIndex = 147
        Me.grpRecomendaciones.TabStop = False
        Me.grpRecomendaciones.Text = "Recomendaciones"
        '
        'txtRecomendacionVieja
        '
        Me.txtRecomendacionVieja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecomendacionVieja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendacionVieja.ForeColor = System.Drawing.Color.Black
        Me.txtRecomendacionVieja.Location = New System.Drawing.Point(11, 33)
        Me.txtRecomendacionVieja.Multiline = True
        Me.txtRecomendacionVieja.Name = "txtRecomendacionVieja"
        Me.txtRecomendacionVieja.Size = New System.Drawing.Size(263, 33)
        Me.txtRecomendacionVieja.TabIndex = 132
        '
        'txtRecomendacionNueva
        '
        Me.txtRecomendacionNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecomendacionNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendacionNueva.ForeColor = System.Drawing.Color.Black
        Me.txtRecomendacionNueva.Location = New System.Drawing.Point(434, 42)
        Me.txtRecomendacionNueva.Multiline = True
        Me.txtRecomendacionNueva.Name = "txtRecomendacionNueva"
        Me.txtRecomendacionNueva.Size = New System.Drawing.Size(263, 33)
        Me.txtRecomendacionNueva.TabIndex = 130
        '
        'mdTxtRecomendacionNueva
        '
        Me.mdTxtRecomendacionNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.mdTxtRecomendacionNueva.Depth = 0
        Me.mdTxtRecomendacionNueva.Location = New System.Drawing.Point(440, 90)
        Me.mdTxtRecomendacionNueva.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdTxtRecomendacionNueva.Name = "mdTxtRecomendacionNueva"
        Me.mdTxtRecomendacionNueva.Size = New System.Drawing.Size(263, 10)
        Me.mdTxtRecomendacionNueva.TabIndex = 131
        Me.mdTxtRecomendacionNueva.Text = "MaterialDivider3"
        '
        'mdTxtRecomendacionVieja
        '
        Me.mdTxtRecomendacionVieja.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.mdTxtRecomendacionVieja.Depth = 0
        Me.mdTxtRecomendacionVieja.Location = New System.Drawing.Point(23, 90)
        Me.mdTxtRecomendacionVieja.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdTxtRecomendacionVieja.Name = "mdTxtRecomendacionVieja"
        Me.mdTxtRecomendacionVieja.Size = New System.Drawing.Size(263, 10)
        Me.mdTxtRecomendacionVieja.TabIndex = 133
        Me.mdTxtRecomendacionVieja.Text = "MaterialDivider4"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(256, 47)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(108, 29)
        Me.lblActual.TabIndex = 146
        Me.lblActual.Text = "Actual     "
        '
        'lblVerYModifcar
        '
        Me.lblVerYModifcar.AutoSize = True
        Me.lblVerYModifcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerYModifcar.Location = New System.Drawing.Point(737, 47)
        Me.lblVerYModifcar.Name = "lblVerYModifcar"
        Me.lblVerYModifcar.Size = New System.Drawing.Size(274, 29)
        Me.lblVerYModifcar.TabIndex = 145
        Me.lblVerYModifcar.Text = "Ver y modificar síntomas"
        '
        'grpPrioridad
        '
        Me.grpPrioridad.Controls.Add(Me.pnlNueva)
        Me.grpPrioridad.Controls.Add(Me.mrbtnBajaV)
        Me.grpPrioridad.Controls.Add(Me.mrbtnMediaV)
        Me.grpPrioridad.Controls.Add(Me.mrbtnAltaV)
        Me.grpPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrioridad.Location = New System.Drawing.Point(88, 176)
        Me.grpPrioridad.Name = "grpPrioridad"
        Me.grpPrioridad.Size = New System.Drawing.Size(755, 139)
        Me.grpPrioridad.TabIndex = 149
        Me.grpPrioridad.TabStop = False
        Me.grpPrioridad.Text = "Prioridad"
        '
        'frmModificarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.lblNueva)
        Me.Controls.Add(Me.grpNombre)
        Me.Controls.Add(Me.grpDescripcion)
        Me.Controls.Add(Me.grpRecomendaciones)
        Me.Controls.Add(Me.lblVerYModifcar)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.grpPrioridad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModificarPatologia"
        Me.Text = "frmModificarPatologia"
        Me.grpNombre.ResumeLayout(False)
        Me.grpNombre.PerformLayout()
        Me.pnlNueva.ResumeLayout(False)
        Me.pnlNueva.PerformLayout()
        Me.grpDescripcion.ResumeLayout(False)
        Me.grpDescripcion.PerformLayout()
        Me.grpRecomendaciones.ResumeLayout(False)
        Me.grpRecomendaciones.PerformLayout()
        Me.grpPrioridad.ResumeLayout(False)
        Me.grpPrioridad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNueva As Label
    Friend WithEvents txtNombreVieja As TextBox
    Friend WithEvents txtNombreNueva As TextBox
    Friend WithEvents mdTxtNombreNueva As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents grpNombre As GroupBox
    Friend WithEvents mdTxtNombreVieja As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents mrbtnBajaV As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnMediaV As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnAltaV As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnBajaN As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnAltaN As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnMediaN As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtDescripcionVieja As TextBox
    Friend WithEvents txtDescripcionNueva As TextBox
    Friend WithEvents pnlNueva As Panel
    Friend WithEvents grpDescripcion As GroupBox
    Friend WithEvents grpRecomendaciones As GroupBox
    Friend WithEvents txtRecomendacionVieja As TextBox
    Friend WithEvents txtRecomendacionNueva As TextBox
    Friend WithEvents mdTxtRecomendacionNueva As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents mdTxtRecomendacionVieja As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents lblActual As Label
    Friend WithEvents lblVerYModifcar As Label
    Friend WithEvents grpPrioridad As GroupBox
End Class
