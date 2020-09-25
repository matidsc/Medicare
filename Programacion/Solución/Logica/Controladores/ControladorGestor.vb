﻿Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los administradores.
'''</summary>
Public Class ControladorGestor
    Inherits ControladorUsuario
    Public Sub New()

    End Sub
    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList,
                  email As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email

    End Sub

    Public Function registrar() As Boolean

        Return ModeloGestor.Singleton.Registrar(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _telefono)

    End Function

    Public Function listarPacientes() As DataTable

        Return ModeloGestor.Singleton.ListarPacientes

    End Function

    Public Function eliminar(cedula As String) As Boolean

        Return ModeloGestor.Singleton.Eliminar(cedula)

    End Function

    Public Function habilitar(cedula As String) As Boolean

        Return ModeloGestor.Singleton.HabilitarPaciente(cedula)

    End Function

End Class
