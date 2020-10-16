Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de las patologías.
'''</summary>
Public Class ControladorPatologia

    Property _nombre As String
    Property _descripcion As String
    Property _recomendacion As String
    Property _prioridad As Byte
    Property _sintomas As ArrayList

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList)

        Me._nombre = nombre
        Me._descripcion = descripcion
        Me._recomendacion = recomendacion
        Me._prioridad = prioridad
        Me._sintomas = sintomas

    End Sub

    Public Overloads Function registrar() As Boolean
        Try
            Return ModeloPatologia.Singleton.Registrar(_nombre, _descripcion, _recomendacion, _prioridad, _sintomas)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Overloads Function Registrar(tabla As DataTable) As Boolean
        Try
            Return ModeloPatologia.Singleton.Registrar(tabla)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function listarPatologias() As DataTable

        Return ModeloPatologia.Singleton.ListarPatologias

    End Function

    Public Function eliminarPatologias(aliPatologias As ArrayList)

        If ModeloPatologia.Singleton.EliminarPatologias(aliPatologias) Then
            Return True
        End If

        Return False
    End Function

    Public Function informacionPatologia(nombre As String) As String

        Return ModeloPatologia.Singleton.DescripcionPatologia(nombre)

    End Function

    Public Function obtenerPatologia(sintomas As ArrayList) As DataTable

        Return ModeloPatologia.Singleton.ObtenerDiagnostico(sintomas)

    End Function

    Public Function guardarDiagnostico(usuario As String, nombreDiagnostico As ArrayList) As Boolean

        Return ModeloPatologia.Singleton.GuardarDiagnostico(usuario, nombreDiagnostico)

    End Function

    Public Function VerificarBaja(nombre As String) As Boolean
        Return ModeloPatologia.Singleton.VerificarBaja(nombre)
    End Function

    Public Function ReingresarPatologia(nombre As String) As Boolean
        Return ModeloPatologia.Singleton.ReingresarPatologia(nombre)
    End Function

    Public Function ReingresarConDatos(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList) As Boolean

        Return ModeloPatologia.Singleton.UpdateBajaLogica(nombre, descripcion, recomendacion, prioridad, sintomas)
    End Function

    'Public Function VerificarExistencia(nombre As String) As Boolean
    '    Return ModeloPatologia.Singleton.VerificarExistencia(nombre)
    'End Function

End Class
