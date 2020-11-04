Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los pacientes.
'''</summary>
Public Class ControladorPaciente
    Inherits ControladorUsuario

    Property _sexo As String
    Property _fecNac As String

    Public Sub New()

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList,
                   email As String, sexo As String, fecNac As String, imagen As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email, imagen)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._fecNac = fecNac
        Me._sexo = sexo

        If imagen <> Nothing Then
            Me._imagen = imagen
        Else
            Me._imagen = ""
        End If

    End Sub

    Public Function RegistrarPaciente() As Boolean

        Try
            Return ModeloPaciente.Singleton.RegistrarPaciente(_ci, _sexo, _fecNac)
        Catch ex As Odbc.OdbcException
            Return False
        End Try

    End Function



    Public Function verificar(ci As String) As Boolean

        Return ModeloPaciente.Singleton.VerificarEstado(ci)

    End Function
    Public Function getDatosPaciente(cedula As String) As DataTable

        Return ModeloPaciente.Singleton.GetDatosPaciente(cedula)

    End Function
    Public Function getPatologiasCronicas(ci As String) As DataTable

        Return ModeloPaciente.Singleton.GetPatologiasCronicas(ci)
    End Function
    Public Function getHistorialConsultas(ci As String) As DataTable

        Return ModeloPaciente.Singleton.GetHistorialConsultas(ci)
    End Function
End Class
