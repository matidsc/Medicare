Imports System.Data.Odbc
''' <summary>
''' Clase encargada de realizar las consultas de los usuarios.
''' </summary>
Public Class ModeloUsuario

    Private Shared instancia As ModeloUsuario

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloUsuario

        If instancia Is Nothing Then
            instancia = New ModeloUsuario
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de registar a los médicos en la tabla usuarios.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="contraseña"></param>
    ''' <param name="PrimerNombre"></param>
    ''' <param name="SegundoNombre"></param>
    ''' <param name="PrimerApellido"></param>
    ''' <param name="SegundoApellido"></param>
    ''' <param name="Especializacion"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, correo As String, imagen As String) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo, fotoPerfil) VALUES (?,?,?,?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", SegundoApellido))
        parametros.Add(New OdbcParameter("correo", correo))
        parametros.Add(New OdbcParameter("fotoPerfil", imagen))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

    Public Function RegistrarTelefonos(cedula As String, Telefonos As ArrayList)

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
    ''' Función encargada de verificar si el usuario y la contraseña ingresados por el usuario son correctos.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="pass"></param>
    ''' <returns>True si coinciden las credenciales.</returns>
    Public Function VerificarUsuario(usuario As String, pass As String) As Boolean

        Conexion.Singleton.cerrarConexion()
        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM usuario WHERE cedula = " & usuario & " and contrasena = '" & pass & "' AND bajalogica = 0") = 1 Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el rol al que el usuario quiere acceder es correcto.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="rol"></param>
    ''' <returns>True si el rol es correcto.</returns>
    Public Function verificarRol(usuario As String, rol As Int16) As Boolean
        Select Case rol
            Case 0
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM paciente WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If

            Case 1
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM medico WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If

            Case 2
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM gestor WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If
        End Select

        Return False
    End Function

    Public Function VerificarBaja(cedula As String) As Boolean

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM usuario WHERE bajalogica = 1 AND cedula = " & cedula) = 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function ReingresarUsuario(cedula As String) As Boolean

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        If ModeloConsultas.Singleton.InsertarSinParametros("UPDATE usuario u, paciente p SET u.bajalogica = 0 , p.verificacion=0 WHERE u.cedula=p.cedula AND u.cedula = " & cedula) Then
            Return True
        End If

        Return False
    End Function

    Public Function listarUsuarios() As DataTable
        Dim consulta = "SELECT cedula,pNom,sNom,pApe,sApe,correo FROM usuario where bajaLogica=0"
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Subrutina encargada de setear una conexión en función del usuario logeado.
    ''' </summary>
    ''' <param name="rol"></param>
    Public Sub SetConnection(rol As Int16)
        Select Case rol
            Case 0
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.paciente)
                Conexion.Singleton.abrirConexion()

            Case 1
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.medico)
                Conexion.Singleton.abrirConexion()

            Case 2
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.admin)
                Conexion.Singleton.abrirConexion()
        End Select
    End Sub

End Class
