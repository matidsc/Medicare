﻿Imports Acceso_a_Datos
Public Class Medico
    Inherits Usuario
    Property _especializacion As String

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As String,
                  email As String, especializacion As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email)
        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = _telefono
        Me._email = email

        Me._especializacion = especializacion
    End Sub
    Public Function agregar()
        Dim datos As New Consultas
        Return datos.registrar_Medico(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _telefono, _especializacion)
    End Function

End Class
