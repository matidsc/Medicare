﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManualCsv
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
        Me.lblManualmente = New System.Windows.Forms.Label()
        Me.lblDesdeArchivoCSV = New System.Windows.Forms.Label()
        Me.lblComoDeseaRegistrarElMedico = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.picManualmente = New System.Windows.Forms.PictureBox()
        Me.picDesdeArchivoCSV = New System.Windows.Forms.PictureBox()
        CType(Me.picManualmente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesdeArchivoCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblManualmente
        '
        Me.lblManualmente.AutoSize = True
        Me.lblManualmente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManualmente.Location = New System.Drawing.Point(45, 115)
        Me.lblManualmente.Name = "lblManualmente"
        Me.lblManualmente.Size = New System.Drawing.Size(142, 25)
        Me.lblManualmente.TabIndex = 78
        Me.lblManualmente.Text = "Manualmente"
        '
        'lblDesdeArchivoCSV
        '
        Me.lblDesdeArchivoCSV.AutoSize = True
        Me.lblDesdeArchivoCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesdeArchivoCSV.Location = New System.Drawing.Point(268, 115)
        Me.lblDesdeArchivoCSV.Name = "lblDesdeArchivoCSV"
        Me.lblDesdeArchivoCSV.Size = New System.Drawing.Size(199, 25)
        Me.lblDesdeArchivoCSV.TabIndex = 79
        Me.lblDesdeArchivoCSV.Text = "Desde archivo CSV"
        '
        'lblComoDeseaRegistrarElMedico
        '
        Me.lblComoDeseaRegistrarElMedico.AutoSize = True
        Me.lblComoDeseaRegistrarElMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComoDeseaRegistrarElMedico.Location = New System.Drawing.Point(58, 45)
        Me.lblComoDeseaRegistrarElMedico.Name = "lblComoDeseaRegistrarElMedico"
        Me.lblComoDeseaRegistrarElMedico.Size = New System.Drawing.Size(330, 24)
        Me.lblComoDeseaRegistrarElMedico.TabIndex = 80
        Me.lblComoDeseaRegistrarElMedico.Text = "¿Cómo desea registrar el médico?"
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.Black
        Me.lblMinimizar.Location = New System.Drawing.Point(419, -7)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 84
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.Black
        Me.lblCerrar.Location = New System.Drawing.Point(449, -1)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 83
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picManualmente
        '
        Me.picManualmente.Image = Global.Vista.My.Resources.Resources.icons8_form_64_1_
        Me.picManualmente.Location = New System.Drawing.Point(83, 169)
        Me.picManualmente.Name = "picManualmente"
        Me.picManualmente.Size = New System.Drawing.Size(64, 64)
        Me.picManualmente.TabIndex = 82
        Me.picManualmente.TabStop = False
        '
        'picDesdeArchivoCSV
        '
        Me.picDesdeArchivoCSV.Image = Global.Vista.My.Resources.Resources.icons8_csv_64
        Me.picDesdeArchivoCSV.Location = New System.Drawing.Point(329, 169)
        Me.picDesdeArchivoCSV.Name = "picDesdeArchivoCSV"
        Me.picDesdeArchivoCSV.Size = New System.Drawing.Size(66, 64)
        Me.picDesdeArchivoCSV.TabIndex = 81
        Me.picDesdeArchivoCSV.TabStop = False
        '
        'frmManualCsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 260)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.picManualmente)
        Me.Controls.Add(Me.picDesdeArchivoCSV)
        Me.Controls.Add(Me.lblComoDeseaRegistrarElMedico)
        Me.Controls.Add(Me.lblDesdeArchivoCSV)
        Me.Controls.Add(Me.lblManualmente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManualCsv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picManualmente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesdeArchivoCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblManualmente As Label
    Friend WithEvents lblDesdeArchivoCSV As Label
    Friend WithEvents lblComoDeseaRegistrarElMedico As Label
    Friend WithEvents picDesdeArchivoCSV As PictureBox
    Friend WithEvents picManualmente As PictureBox
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
End Class
