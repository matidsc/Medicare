<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.flowpnl = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'flowpnl
        '
        Me.flowpnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.flowpnl.Location = New System.Drawing.Point(71, 45)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(854, 513)
        Me.flowpnl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar, modificar o eliminar usuarios registrados en la aplicación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 570)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flowpnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowpnl As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
