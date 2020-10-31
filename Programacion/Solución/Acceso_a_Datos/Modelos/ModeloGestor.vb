Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de los adminstradores.
''' </summary>
Public Class ModeloGestor

    Private Shared instancia As ModeloGestor

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloGestor

        If instancia Is Nothing Then
            instancia = New ModeloGestor
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de registar a los administradores del sistema en la tabla gestor.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarGestor(cedula As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO gestor (cedula) VALUES (?)"

        parametros.Add(New OdbcParameter("cedula", cedula))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de listar a los pacientes que se deban habilitar.
    ''' </summary>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ListadoHabilitarPacientes() As DataTable

        Dim consulta = "SELECT p.cedula, u.pNom, u.pApe, u.sApe FROM paciente p, usuario u WHERE p.verificacion = 0 and u.bajaLogica = 0 and p.cedula = u.cedula"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    Public Function ListadoHabilitarGestores() As DataTable

        Dim consulta = "SELECT g.cedula, u.pNom, u.pApe, u.sApe FROM gestor g, usuario u WHERE g.verificacion = 0 and u.bajaLogica = 0 and g.cedula = u.cedula"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    Public Function NotificacionListadoPaciente() As Int16

        Dim consulta As String = "SELECT count(*) FROM paciente p, usuario u WHERE verificacion = 0 AND p.cedula = u.cedula AND u.bajalogica = 0"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int16)

    End Function

    Public Function NotificacionListadoGestor() As Int16

        Dim consulta As String = "SELECT count(*) FROM gestor g, usuario u WHERE verificacion = 0 AND g.cedula = u.cedula AND u.bajalogica = 0"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int16)

    End Function

    Public Function getInformacionGestor(cedula As String) As DataTable

        Dim consulta = "SELECT cedula,pNom,sNom,pApe,sApe,correo,CONVERT(fotoPerfil USING utf8) FROM usuario where cedula= " & cedula
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de habilitar a los pacientes.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>True si el update fue realizado.</returns>
    Public Function HabilitarPaciente(cedula As String) As Boolean

        Dim consulta As String = "UPDATE paciente SET verificacion = 1 WHERE cedula=" + cedula

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function

    Public Function HabilitarGestor(cedula As String) As Boolean

        Dim consulta As String = "UPDATE gestor SET verificacion = 1 WHERE cedula=" + cedula

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function


    ''' <summary>
    ''' Función encargada de dar de baja a un usuario.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>True si el update fue realizado.</returns>
    Public Function Eliminar(cedula As String) As Boolean

        Dim consulta As String = "UPDATE usuario SET bajaLogica = 1 WHERE cedula = " + cedula

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function

    Public Function VerificarEstado(cedula As String) As Boolean

        Dim consulta As String = "SELECT verificacion FROM gestor WHERE cedula = " + cedula

        If ModeloConsultas.Singleton.ConsultaCampo(consulta) = 1 Then
            Return True
        End If

        Return False
    End Function

End Class
