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
    ''' Función encargada de registar a los administradores del sistema en la tabla usuarios.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="contraseña"></param>
    ''' <param name="PrimerNombre"></param>
    ''' <param name="SegundoNombre"></param>
    ''' <param name="PrimerApellido"></param>
    ''' <param name="SegundoApellido"></param>
    ''' <param name="Telefonos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList, mail As String) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) VALUES (?,?,?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", SegundoApellido))
        parametros.Add(New OdbcParameter("correo", mail))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            If RegistrarGestor(cedula) Then
                If RegistrarTelefono(cedula, Telefonos) Then
                    Return True
                End If
            End If
        End If

        Return False
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
    ''' Función encargada de registar los telefonos de los administradores.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="Telefonos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarTelefono(cedula As String, Telefonos As ArrayList)

        Dim consulta = "INSERT INTO usuarioTel (cedula, telefono) VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0

        For i As Int16 = 0 To Telefonos.Count - 1
            parametros.Clear()
            parametros.Add(New OdbcParameter("cedula", cedula))
            parametros.Add(New OdbcParameter("telefono", Telefonos.Item(i)))

            ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
            contador += 1
        Next

        If contador = Telefonos.Count Then
            Return True
            Telefonos.Clear()
        End If

        Return False
        Telefonos.Clear()
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

        Dim consulta = "SELECT cedula,pNom,sNom,pApe,sApe,fotoPerfil FROM usuario where cedula= " & cedula
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
