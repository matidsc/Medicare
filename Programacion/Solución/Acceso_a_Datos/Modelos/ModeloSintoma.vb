Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de los síntomas.
''' </summary>
Public Class ModeloSintoma

    Private Shared instancia As ModeloSintoma

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloSintoma

        If instancia Is Nothing Then
            instancia = New ModeloSintoma
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de registrar los síntomas.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="descripcion"></param>
    ''' <returns>True si se registraron los síntomas.</returns>
    ''' 
    Public Overloads Function Registrar(tabla As DataTable) As Boolean
        Dim consulta As String = "INSERT INTO sintoma (nombre, descripcion) VALUES(?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int32 = 0

        For Each fila As DataRow In tabla.Rows

            parametros.Add(New OdbcParameter("nombre", fila.Item(0).ToString.ToUpper))
            parametros.Add(New OdbcParameter("descripcion", fila.Item(1).ToString.ToUpper))

            If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
                contador += 1
            End If
            parametros.Clear()

        Next

        If contador = tabla.Rows.Count Then
            Return True
        End If

        Return False
    End Function
    Public Overloads Function Registrar(nombre As String, descripcion As String) As Boolean

        Dim consulta As String = "INSERT INTO sintoma (nombre, descripcion) VALUES(?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("nombre", nombre))
        parametros.Add(New OdbcParameter("descripcion", descripcion))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False

    End Function

    ''' <summary>
    ''' Función encargada de obtener el nombre de los síntomas.
    ''' </summary>
    ''' <returns>ArrayList con las filas encontradas en la consulta.</returns>
    Public Overloads Function TraerSintomas() As ArrayList
        Return ModeloConsultas.Singleton.ConsultaArray("SELECT nombre FROM sintoma WHERE bajalogica = 0")
    End Function

    Public Overloads Function TraerSintomas(sintomas As ArrayList) As ArrayList

        Dim parametros As String
        Dim consulta As String = "
                                SELECT s.nombre
                                FROM sintoma s
                                WHERE s.bajaLogica = 0 AND s.nombre NOT IN ("

        For Each sintoma In sintomas
            parametros = parametros & "'" & sintoma & "'" & ","
        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"

        Return ModeloConsultas.Singleton.ConsultaArray(consulta)

    End Function

    ''' <summary>
    ''' Función encargada de registrar los síntomas seleccionados por el paciente.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="nombreSintoma"></param>
    ''' <returns>True si los síntomas fueron registrados.</returns>
    Public Function GuardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean

        Dim consulta As String

        Try
            For Each nom In nombreSintoma

                consulta = "
                           INSERT INTO paciente_indica_sintoma (cedulaPaciente, idSintoma, fechaIngreso) 
                           SELECT " & usuario & ", s.idSintoma, '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "' 
                           FROM sintoma s WHERE s.nombre = '" & nom & "'"

                ModeloConsultas.Singleton.InsertarSinParametros(consulta)
            Next

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Función encargada de listar los síntomas.
    ''' </summary>
    ''' <returns>DataTable con los datos de los síntomas.</returns>
    Public Function ListarSintomas() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT nombre AS Nombre, descripcion AS Descripcion FROM sintoma WHERE bajalogica = 0")
    End Function

    ''' <summary>
    ''' Función encargada de eliminar los síntomas.
    ''' </summary>
    ''' <param name="ali"></param>
    ''' <returns>True si el delete fue realizado.</returns>
    Public Function EliminarSintomas(ali As ArrayList) As Boolean

        Dim valores As String
        Dim consulta As String = "UPDATE sintoma SET bajalogica = 1 WHERE nombre IN ("

        For i = 0 To ali.Count - 1
            valores = valores & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & valores.TrimEnd(",") & ")"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function

End Class
