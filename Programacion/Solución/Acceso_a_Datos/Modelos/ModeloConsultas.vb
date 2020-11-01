Imports System.Data.Odbc

''' <summary>
''' Clase base para realizar las consultas.
''' </summary>
Public Class ModeloConsultas

    Private Shared instancia As ModeloConsultas
    Property command As OdbcCommand
    Property trans As OdbcTransaction


    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloConsultas

        If instancia Is Nothing Then
            instancia = New ModeloConsultas
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de devolver en forma de tabla los valores obtenidos a través de la consulta.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ConsultaTabla(Comando As String, con As OdbcConnection) As DataTable

        Conexion.Singleton.abrirConexion()

        Dim table As New DataTable
        Dim adapter As New OdbcDataAdapter(Comando, con)

        adapter.Fill(table)

        Return table
    End Function

    ''' <summary>
    ''' Función genérica encargada de devolver el dato solicitado por la consulta.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>La primera fila afectada por la consulta.</returns>
    Public Function ConsultaCampo(Comando As String, transaccion As OdbcTransaction, boolTransaccion As Boolean, con As OdbcConnection)

        command = New OdbcCommand(Comando, con)

        If boolTransaccion Then
            command.Transaction = transaccion
        End If

        Dim result As String = command.ExecuteScalar()

        Return result
    End Function


    ''' <summary>
    ''' Función encargada de devolver los datos solicitados de una columna en forma de ArrayList.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>ArrayList con las filas encontradas en la consulta.</returns>
    Public Function ConsultaArray(Comando As String) As ArrayList

        Conexion.Singleton.abrirConexion()

        Dim array As New ArrayList
        Dim tablaIterar As DataTable = ConsultaTabla(Comando, Conexion.Singleton.Connection)

        For var As Int32 = 0 To tablaIterar.Rows.Count - 1
            array.Add(tablaIterar.Rows.Item(var).Item(0))
        Next

        Return array
    End Function
    ''' <summary>
    ''' Función encargada de ejecutar un insert en la base de datos utilizando OdbcParameters.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <param name="Parametros"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function InsertParametros(Comando As String, Parametros As List(Of OdbcParameter), transaccion As OdbcTransaction) As Boolean

        command = New OdbcCommand(Comando, Conexion.Singleton.Connection)
        command.Transaction = transaccion

        For Each parametro In Parametros
            command.Parameters.Add(parametro)
        Next

        If command.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Return False
    End Function

    Public Function Transaccion() As Boolean

        Dim transaccion1 As OdbcTransaction

        transaccion1 = Conexion.Singleton.Connection().BeginTransaction()


    End Function

    ''' <summary>
    ''' Función encargada de ejecutar un insert en la base de datos.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function InsertarSinParametros(Comando As String) As Boolean

        Conexion.Singleton.abrirConexion()

        Dim insert As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        If insert.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Return False
    End Function
    Public Function ConsultaDelete(consulta As String) As Boolean

        Conexion.Singleton.abrirConexion()

        Dim insert As New OdbcCommand(consulta, Conexion.Singleton.Connection)

        If insert.ExecuteNonQuery() >= 0 Then
            Return True
        End If

        Return False

    End Function

End Class
