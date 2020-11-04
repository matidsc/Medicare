Imports Acceso_a_Datos

'''<summary>
'''Clase principal para los datos de los usuarios.
'''</summary>
Public Class ControladorUsuario

    Public Sub New()

    End Sub

    Property _ci As String
    Property _contraseña As String
    Property _primer_nombre As String
    Property _primer_apellido As String
    Property _segundo_nombre As String
    Property _segundo_apellido As String
    Property _telefono As ArrayList
    Property _email As String
    Property _imagen As String


    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList, email As String, imagen As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._imagen = imagen

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, email As String, imagen As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._email = email
        Me._imagen = imagen
    End Sub

    'Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String) CONSTRUCTOR SIN EMAIL PARA MEDICO??

    '    Me._ci = ci
    '    Me._contraseña = contraseña
    '    Me._primer_nombre = pNom
    '    Me._segundo_nombre = Snom
    '    Me._primer_apellido = PApe
    '    Me._segundo_apellido = SApe

    'End Sub

    Public Function RegistarUsuario() As Boolean
        Try
            Return ModeloUsuario.Singleton.Registrar(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _email, _imagen)
        Catch ex As Odbc.OdbcException
            Return False
        End Try
    End Function

    Public Function RegistrarTelefonos() As Boolean

        Try
            Return ModeloUsuario.Singleton.RegistrarTelefonos(_ci, _telefono)
        Catch ex As Odbc.OdbcException
            Return False
        End Try

    End Function
    Public Function verificarUsuario(usuario As String, pass As String) As Boolean

        Return ModeloUsuario.Singleton.VerificarUsuario(usuario, pass)

    End Function

    Public Function verificarRol(usuario As String) As Boolean

        Return ModeloUsuario.Singleton.verificarRol(usuario, Datos_Temporales.rol)

    End Function

    Public Function VerificarBaja(cedula As String)
        Return ModeloUsuario.Singleton.VerificarBaja(cedula)
    End Function

    Public Function ReingresarUsuario(cedula As String) As Boolean

        Return ModeloUsuario.Singleton.ReingresarUsuario(cedula)

    End Function
    Public Function getTelefonosUsuario() As DataTable
        Return ModeloUsuario.Singleton.getTelefonosPaciente(Datos_Temporales.userLog)
    End Function
    Public Function ListarUsuarios() As DataTable
        Return ModeloUsuario.Singleton.listarUsuarios
    End Function
    Public Function updateUsuario(cedula As String)

    End Function
End Class

