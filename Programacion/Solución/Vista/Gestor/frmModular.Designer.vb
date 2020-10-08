<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModular
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
        Me.pnlOpcion1 = New System.Windows.Forms.Panel()
        Me.lblSubtitulo1 = New System.Windows.Forms.Label()
        Me.pnlDecorativo1 = New System.Windows.Forms.Panel()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.pnlOpcion2 = New System.Windows.Forms.Panel()
        Me.lblSubtitulo2 = New System.Windows.Forms.Label()
        Me.pnlDecorativo2 = New System.Windows.Forms.Panel()
        Me.lblTitulo2 = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlOpcion1.SuspendLayout()
        Me.pnlOpcion2.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOpcion1
        '
        Me.pnlOpcion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlOpcion1.Controls.Add(Me.lblSubtitulo1)
        Me.pnlOpcion1.Controls.Add(Me.pnlDecorativo1)
        Me.pnlOpcion1.Controls.Add(Me.lblTitulo1)
        Me.pnlOpcion1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion1.Location = New System.Drawing.Point(100, 100)
        Me.pnlOpcion1.Name = "pnlOpcion1"
        Me.pnlOpcion1.Size = New System.Drawing.Size(678, 151)
        Me.pnlOpcion1.TabIndex = 7
        '
        'lblSubtitulo1
        '
        Me.lblSubtitulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtitulo1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo1.ForeColor = System.Drawing.Color.White
        Me.lblSubtitulo1.Location = New System.Drawing.Point(25, 80)
        Me.lblSubtitulo1.Name = "lblSubtitulo1"
        Me.lblSubtitulo1.Size = New System.Drawing.Size(620, 25)
        Me.lblSubtitulo1.TabIndex = 5
        Me.lblSubtitulo1.Text = "Registre patologías manualmente o desde un archivo CSV"
        Me.lblSubtitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDecorativo1
        '
        Me.pnlDecorativo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlDecorativo1.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecorativo1.Name = "pnlDecorativo1"
        Me.pnlDecorativo1.Size = New System.Drawing.Size(675, 11)
        Me.pnlDecorativo1.TabIndex = 2
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.Color.White
        Me.lblTitulo1.Location = New System.Drawing.Point(283, 14)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(145, 45)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "Registrar"
        '
        'pnlOpcion2
        '
        Me.pnlOpcion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlOpcion2.Controls.Add(Me.lblSubtitulo2)
        Me.pnlOpcion2.Controls.Add(Me.pnlDecorativo2)
        Me.pnlOpcion2.Controls.Add(Me.lblTitulo2)
        Me.pnlOpcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion2.Location = New System.Drawing.Point(100, 270)
        Me.pnlOpcion2.Name = "pnlOpcion2"
        Me.pnlOpcion2.Size = New System.Drawing.Size(678, 156)
        Me.pnlOpcion2.TabIndex = 11
        '
        'lblSubtitulo2
        '
        Me.lblSubtitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtitulo2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo2.ForeColor = System.Drawing.Color.White
        Me.lblSubtitulo2.Location = New System.Drawing.Point(26, 75)
        Me.lblSubtitulo2.Name = "lblSubtitulo2"
        Me.lblSubtitulo2.Size = New System.Drawing.Size(630, 60)
        Me.lblSubtitulo2.TabIndex = 7
        Me.lblSubtitulo2.Text = "Acceda a todas las patologías registradas y a opciones de eliminar y modificar"
        Me.lblSubtitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDecorativo2
        '
        Me.pnlDecorativo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlDecorativo2.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecorativo2.Name = "pnlDecorativo2"
        Me.pnlDecorativo2.Size = New System.Drawing.Size(678, 10)
        Me.pnlDecorativo2.TabIndex = 2
        '
        'lblTitulo2
        '
        Me.lblTitulo2.AutoSize = True
        Me.lblTitulo2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo2.ForeColor = System.Drawing.Color.White
        Me.lblTitulo2.Location = New System.Drawing.Point(283, 15)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(122, 45)
        Me.lblTitulo2.TabIndex = 0
        Me.lblTitulo2.Text = "Listado"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.lblTitulo)
        Me.pnlContenedor.Controls.Add(Me.pnlOpcion2)
        Me.pnlContenedor.Controls.Add(Me.pnlOpcion1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(880, 500)
        Me.pnlContenedor.TabIndex = 6
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(880, 500)
        Me.pnlInstancia.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(196, 444)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(490, 45)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "ddddddd"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmModular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlOpcion1.ResumeLayout(False)
        Me.pnlOpcion1.PerformLayout()
        Me.pnlOpcion2.ResumeLayout(False)
        Me.pnlOpcion2.PerformLayout()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlOpcion1 As Panel
    Friend WithEvents lblSubtitulo1 As Label
    Friend WithEvents pnlDecorativo1 As Panel
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents pnlOpcion2 As Panel
    Friend WithEvents lblSubtitulo2 As Label
    Friend WithEvents pnlDecorativo2 As Panel
    Friend WithEvents lblTitulo2 As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents lblTitulo As Label
End Class
