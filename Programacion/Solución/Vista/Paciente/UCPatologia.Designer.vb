<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCPatologia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlWrap = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlWrap.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlWrap
        '
        Me.pnlWrap.BackColor = System.Drawing.Color.Transparent
        Me.pnlWrap.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlWrap.Controls.Add(Me.Label1)
        Me.pnlWrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrap.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrap.Name = "pnlWrap"
        Me.pnlWrap.Size = New System.Drawing.Size(582, 486)
        Me.pnlWrap.TabIndex = 201
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'UCPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlWrap)
        Me.Name = "UCPatologia"
        Me.Size = New System.Drawing.Size(582, 486)
        Me.pnlWrap.ResumeLayout(False)
        Me.pnlWrap.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlWrap As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label1 As Label
End Class
