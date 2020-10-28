﻿Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los síntomas.
'''</summary>
Public Class ControladorSintoma

    Property _nombre As String
    Property _descripcion As String

    Private Shared instancia As ControladorSintoma
    Public Shared Function Singleton() As ControladorSintoma
        If instancia Is Nothing Then
            instancia = New ControladorSintoma
        End If
        Return instancia
    End Function

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Overloads Function Registrar(tabla As DataTable) As Boolean

        Try
            Return ModeloSintoma.Singleton.Registrar(tabla)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Modificar(nombreViejo As String) As Boolean
        Try
            Return ModeloSintoma.Singleton.Modificar(nombreViejo, _nombre, _descripcion)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function traerInfoSintomas(nombre As String) As String
        Return ModeloSintoma.Singleton.traerInfoSintoma(nombre)
    End Function
    Public Overloads Function Registrar() As Boolean
        Return ModeloSintoma.Singleton.Registrar(_nombre, _descripcion)
    End Function
    Public Overloads Function traerSintomas(sintomas As ArrayList) As ArrayList
        Return ModeloSintoma.Singleton.TraerSintomas(sintomas)
    End Function
    Public Function TraerSintomasDePatologia(nombre As String) As DataTable
        Return ModeloSintoma.Singleton.TraerSintomasDePatologia(nombre)
    End Function
    Public Overloads Function traerSintomas() As ArrayList

        Return ModeloSintoma.Singleton.TraerSintomas

    End Function
    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean

        Return ModeloSintoma.Singleton.GuardarSintomas(usuario, nombreSintoma)

    End Function

    Public Function listarSintomas() As DataTable

        Return ModeloSintoma.Singleton.ListarSintomas

    End Function

    Public Function eliminarSintomas(aliSintomas As ArrayList)

        If ModeloSintoma.Singleton.EliminarSintomas(aliSintomas) Then
            Return True
        End If

        Return False
    End Function

End Class
