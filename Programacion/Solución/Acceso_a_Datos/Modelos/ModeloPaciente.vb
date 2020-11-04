﻿Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de los adminstradores.
''' </summary>
Public Class ModeloPaciente

    Private Shared instancia As ModeloPaciente

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloPaciente

        If instancia Is Nothing Then
            instancia = New ModeloPaciente
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el paciente fue ingresado.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>True si el paciente ya es usuario del sistema.</returns>
    Public Function VerificarEstado(cedula As String) As Boolean
        Conexion.Singleton.abrirConexion()
        Dim consulta As String = "SELECT verificacion FROM paciente WHERE cedula = " + cedula
        Dim resultado As Int16 = CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int16)

        If resultado = 1 Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registar a los pacientes en la tabla pacientes.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="sexo"></param>
    ''' <param name="FechaNacimiento"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarPaciente(cedula As String, sexo As String, FechaNacimiento As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO paciente (cedula, verificacion, fecNac, sexo) VALUES (?,?,?,?)"

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("verificacion", "0"))
        parametros.Add(New OdbcParameter("fecNac", FechaNacimiento))
        parametros.Add(New OdbcParameter("sexo", sexo))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registar los telefonos de los administradores.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="Telefonos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarTelefono(cedula As String, Telefonos As ArrayList) As Boolean

        Dim consulta = "INSERT INTO usuarioTel (cedula, telefono) VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0

        For Each var As Int16 In Telefonos
            parametros.Clear()
            parametros.Add(New OdbcParameter("cedula", cedula))
            parametros.Add(New OdbcParameter("telefono", var))

            ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
            contador += 1
        Next

        If contador = Telefonos.Count Then

            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Función encargada de listar a los pacientes habilitados.
    ''' </summary>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function TraerPacientes() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT cedula FROM paciente WHERE verificacion = 1 ")
    End Function

    ''' <summary>
    ''' Función encargada de obtener los datos del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetDatosPaciente(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT contrasena,pNom,sNom,pApe,sApe,TIMESTAMPDIFF(YEAR, p.fecNac, CURDATE()),sexo,correo, CONVERT(fotoPerfil USING utf8) from usuario u, paciente p WHERE u.cedula=p.cedula AND u.bajalogica = 0 AND u.cedula= " & cedula)
    End Function

    ''' <summary>
    ''' Función encargada de obtener las enfermedades crónicas del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetPatologiasCronicas(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT patologia FROM paciente_selecciona_patologia WHERE cedula = " & cedula)
    End Function

    ''' <summary>
    ''' Función encargada de obtener el historial de consultas del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetHistorialConsultas(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT p.nombre,date_format(pod.fecha," & "'%d / %m / %y')" & "FROM paciente_obtiene_diagnostico pod,patologia p WHERE pod.idPatologia=p.idPatologia AND pod.cedulaPaciente =" & cedula)
    End Function

End Class
