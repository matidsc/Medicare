<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmObtenerDiagnostico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.lblIngreseSIntomas = New System.Windows.Forms.Label()
        Me.btnAnt = New FontAwesome.Sharp.IconButton()
        Me.btnSig = New FontAwesome.Sharp.IconButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.GunaButton1)
        Me.pnlContenedor.Controls.Add(Me.lblIngreseSIntomas)
        Me.pnlContenedor.Controls.Add(Me.btnAnt)
        Me.pnlContenedor.Controls.Add(Me.btnSig)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 150
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Vista.My.Resources.Resources.icono_Chat
        Me.GunaButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton1.Location = New System.Drawing.Point(857, 28)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 14
        Me.GunaButton1.Size = New System.Drawing.Size(192, 42)
        Me.GunaButton1.TabIndex = 197
        Me.GunaButton1.Text = "Solicitar chat"
        Me.GunaButton1.TextOffsetX = 16
        '
        'lblIngreseSIntomas
        '
        Me.lblIngreseSIntomas.BackColor = System.Drawing.Color.Transparent
        Me.lblIngreseSIntomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIngreseSIntomas.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSIntomas.ForeColor = System.Drawing.Color.White
        Me.lblIngreseSIntomas.Location = New System.Drawing.Point(378, 22)
        Me.lblIngreseSIntomas.Name = "lblIngreseSIntomas"
        Me.lblIngreseSIntomas.Size = New System.Drawing.Size(315, 45)
        Me.lblIngreseSIntomas.TabIndex = 195
        Me.lblIngreseSIntomas.Text = "Posibles Diagnósticos"
        Me.lblIngreseSIntomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnt
        '
        Me.btnAnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnt.FlatAppearance.BorderSize = 0
        Me.btnAnt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnt.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAnt.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnAnt.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAnt.IconSize = 48
        Me.btnAnt.Location = New System.Drawing.Point(23, 338)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Rotation = 0R
        Me.btnAnt.Size = New System.Drawing.Size(56, 38)
        Me.btnAnt.TabIndex = 194
        Me.btnAnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAnt.UseVisualStyleBackColor = True
        Me.btnAnt.Visible = False
        '
        'btnSig
        '
        Me.btnSig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSig.FlatAppearance.BorderSize = 0
        Me.btnSig.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSig.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnSig.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.btnSig.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSig.IconSize = 48
        Me.btnSig.Location = New System.Drawing.Point(993, 338)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Padding = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.btnSig.Rotation = 0R
        Me.btnSig.Size = New System.Drawing.Size(56, 38)
        Me.btnSig.TabIndex = 193
        Me.btnSig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSig.UseVisualStyleBackColor = True
        Me.btnSig.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(22, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 192
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(810, 514)
        Me.TableLayoutPanel1.TabIndex = 151
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 198
        '
        'frmObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmObtenerDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObtenerDiagnóstico"
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSig As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAnt As FontAwesome.Sharp.IconButton
    Friend WithEvents lblIngreseSIntomas As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlInstancia As Panel
End Class
