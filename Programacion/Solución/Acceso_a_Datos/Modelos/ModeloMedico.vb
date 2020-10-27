Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de los médicos.
''' </summary>
Public Class ModeloMedico

    Private Shared instancia As ModeloMedico

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloMedico

        If instancia Is Nothing Then
            instancia = New ModeloMedico
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
    Public Overloads Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Especializacion As String, correo As String, imagen As String) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe,correo, fotoPerfil) VALUES (?,?,?,?,?,?,?,?)"
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
            If RegistrarMedico(cedula, Especializacion) Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Overloads Function Registrar(tabla As DataTable) As Boolean

        Dim consultaUsuario As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) VALUES (?,?,?,?,?,?,?)"
        Dim consultaMedico As String = "INSERT INTO medico (cedula, especializacion) VALUES(?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim parametrosMedico As New List(Of OdbcParameter)
        Dim contador As Int32 = 0

        For Each fila As DataRow In tabla.Rows

            parametros.Add(New OdbcParameter("cedula", fila.Item(0)))
            parametros.Add(New OdbcParameter("contrasena", fila.Item(1).ToString))
            parametros.Add(New OdbcParameter("pNom", fila.Item(2).ToString))
            parametros.Add(New OdbcParameter("sNom", fila.Item(3).ToString))
            parametros.Add(New OdbcParameter("pApe", fila.Item(4).ToString))
            parametros.Add(New OdbcParameter("sApe", fila.Item(5).ToString))
            parametros.Add(New OdbcParameter("correo", fila.Item(6).ToString))

            parametrosMedico.Add(New OdbcParameter("cedula", fila.Item(0)))
            parametrosMedico.Add(New OdbcParameter("especializacion", fila.Item(7).ToString.ToUpper))

            If ModeloConsultas.Singleton.InsertParametros(consultaUsuario, parametros) Then
                If ModeloConsultas.Singleton.InsertParametros(consultaMedico, parametrosMedico) Then
                    contador += 1
                End If
            End If

            parametros.Clear()
            parametrosMedico.Clear()

        Next

        If contador = tabla.Rows.Count Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Función encargada de registar a los médicos en la tabla médico.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="esp"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarMedico(cedula As String, esp As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO medico (cedula, especializacion) VALUES (?,?)"

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("especializacion", esp))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

End Class


