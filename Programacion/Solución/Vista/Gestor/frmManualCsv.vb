Imports Logica
Imports System.IO
Public Class frmManualCsv
    Dim op As Byte
    Private Sub picDesdeArchivoCSV_Click(sender As Object, e As EventArgs) Handles picDesdeArchivoCSV.Click

        Dim opf As New OpenFileDialog
        Dim listaColumnas As New List(Of String)
        opf.Title = "Seleccione un archivo"
        opf.InitialDirectory = "C:\Users\rpere\OneDrive\Escritorio\Programacion\Solución\Vista\bin\Debug"
        opf.Filter = "Archivo|*.csv"
        op = 1
        Select Case op
            Case 0
                listaColumnas.Add("Nombre")
                listaColumnas.Add("Descrpcion")
                listaColumnas.Add("Recomendación")
                listaColumnas.Add("Prioridad")
            Case 1
                listaColumnas.Add("Nombre")
                listaColumnas.Add("Descripción")

        End Select

        If opf.ShowDialog = DialogResult.OK Then
            Dim a As New frmListadoPatologiasySintomas(opf.FileName, listaColumnas)
            a.Show()
        End If

    End Sub

End Class