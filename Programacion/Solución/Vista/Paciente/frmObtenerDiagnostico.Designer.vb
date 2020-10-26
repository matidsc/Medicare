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
        Me.btnSolicitarChat = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ucRespuesta = New Vista.UserControl1()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSolicitarChat
        '
        Me.btnSolicitarChat.AutoSize = True
        Me.btnSolicitarChat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSolicitarChat.Depth = 0
        Me.btnSolicitarChat.Icon = Nothing
        Me.btnSolicitarChat.Location = New System.Drawing.Point(393, 636)
        Me.btnSolicitarChat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSolicitarChat.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSolicitarChat.Name = "btnSolicitarChat"
        Me.btnSolicitarChat.Primary = False
        Me.btnSolicitarChat.Size = New System.Drawing.Size(215, 36)
        Me.btnSolicitarChat.TabIndex = 149
        Me.btnSolicitarChat.Text = "solicitar chat con médico"
        Me.btnSolicitarChat.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.btnSolicitarChat)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 150
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(810, 491)
        Me.TableLayoutPanel1.TabIndex = 151
        '
        'ucRespuesta
        '
        Me.ucRespuesta.BackColor = System.Drawing.Color.White
        Me.ucRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucRespuesta.Location = New System.Drawing.Point(200, 77)
        Me.ucRespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.ucRespuesta.Name = "ucRespuesta"
        Me.ucRespuesta.Size = New System.Drawing.Size(607, 541)
        Me.ucRespuesta.TabIndex = 148
        Me.ucRespuesta.Visible = False
        '
        'frmObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.ucRespuesta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmObtenerDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObtenerDiagnóstico"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucRespuesta As UserControl1
    Friend WithEvents btnSolicitarChat As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
