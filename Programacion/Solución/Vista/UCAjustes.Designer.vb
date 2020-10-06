<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAjustes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.switchTema = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.cbIdiomas = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.btnAplicarCambios = New Guna.UI.WinForms.GunaButton()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(195, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración"
        '
        'switchTema
        '
        Me.switchTema.BaseColor = System.Drawing.SystemColors.Control
        Me.switchTema.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switchTema.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.switchTema.FillColor = System.Drawing.Color.White
        Me.switchTema.Location = New System.Drawing.Point(121, 150)
        Me.switchTema.Name = "switchTema"
        Me.switchTema.Size = New System.Drawing.Size(38, 20)
        Me.switchTema.TabIndex = 1
        '
        'cbIdiomas
        '
        Me.cbIdiomas.BackColor = System.Drawing.Color.Transparent
        Me.cbIdiomas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbIdiomas.BorderColor = System.Drawing.Color.Silver
        Me.cbIdiomas.BorderSize = 0
        Me.cbIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbIdiomas.FocusedColor = System.Drawing.Color.Empty
        Me.cbIdiomas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbIdiomas.ForeColor = System.Drawing.Color.White
        Me.cbIdiomas.FormattingEnabled = True
        Me.cbIdiomas.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.cbIdiomas.Location = New System.Drawing.Point(173, 260)
        Me.cbIdiomas.Name = "cbIdiomas"
        Me.cbIdiomas.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbIdiomas.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbIdiomas.Size = New System.Drawing.Size(168, 26)
        Me.cbIdiomas.Sorted = True
        Me.cbIdiomas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desactivado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(181, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Activado"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaElipsePanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(304, 148)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 17
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(32, 32)
        Me.GunaElipsePanel1.TabIndex = 6
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.GunaElipsePanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(357, 148)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 17
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(32, 32)
        Me.GunaElipsePanel2.TabIndex = 7
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.GunaElipsePanel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(405, 148)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 17
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(32, 32)
        Me.GunaElipsePanel3.TabIndex = 8
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaElipsePanel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(453, 148)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 17
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(32, 32)
        Me.GunaElipsePanel4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tema oscuro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(326, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Color secundario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(228, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Idioma"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(80, 194)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(122, 12)
        Me.GunaSeparator1.TabIndex = 15
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(332, 198)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(122, 12)
        Me.GunaSeparator2.TabIndex = 16
        '
        'btnAplicarCambios
        '
        Me.btnAplicarCambios.AnimationHoverSpeed = 0.07!
        Me.btnAplicarCambios.AnimationSpeed = 0.03!
        Me.btnAplicarCambios.BackColor = System.Drawing.Color.Transparent
        Me.btnAplicarCambios.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAplicarCambios.BorderColor = System.Drawing.Color.Black
        Me.btnAplicarCambios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAplicarCambios.FocusedColor = System.Drawing.Color.Empty
        Me.btnAplicarCambios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarCambios.ForeColor = System.Drawing.Color.White
        Me.btnAplicarCambios.Image = Nothing
        Me.btnAplicarCambios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAplicarCambios.Location = New System.Drawing.Point(177, 359)
        Me.btnAplicarCambios.Name = "btnAplicarCambios"
        Me.btnAplicarCambios.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAplicarCambios.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAplicarCambios.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAplicarCambios.OnHoverImage = Nothing
        Me.btnAplicarCambios.OnPressedColor = System.Drawing.Color.Black
        Me.btnAplicarCambios.Radius = 20
        Me.btnAplicarCambios.Size = New System.Drawing.Size(160, 42)
        Me.btnAplicarCambios.TabIndex = 17
        Me.btnAplicarCambios.Tag = ""
        Me.btnAplicarCambios.Text = "Aplicar cambios"
        Me.btnAplicarCambios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator3.Location = New System.Drawing.Point(207, 306)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(122, 12)
        Me.GunaSeparator3.TabIndex = 18
        '
        'UCAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.GunaSeparator3)
        Me.Controls.Add(Me.btnAplicarCambios)
        Me.Controls.Add(Me.GunaSeparator2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbIdiomas)
        Me.Controls.Add(Me.switchTema)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCAjustes"
        Me.Size = New System.Drawing.Size(522, 441)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents switchTema As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents cbIdiomas As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents btnAplicarCambios As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
End Class
