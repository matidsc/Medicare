Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de las patologías.
''' </summary>
Public Class ModeloPatologia

    Private Shared instancia As ModeloPatologia

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloPatologia

        If instancia Is Nothing Then
            instancia = New ModeloPatologia
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de registrar las patologías.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="recomendacion"></param>
    ''' <param name="prioridad"></param>
    ''' <param name="nomSintomas"></param>
    ''' <returns>True si el insert fue realizado.</returns>

    Public Overloads Function Registrar(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintomas As ArrayList) As Boolean

        Dim consulta As String = "INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES (?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("nombre", nombre))
        parametros.Add(New OdbcParameter("descripcion", descripcion))
        parametros.Add(New OdbcParameter("recomendacion", recomendacion))
        parametros.Add(New OdbcParameter("prioridad", prioridad))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            If RegistrarAsociacion(nombre, nomSintomas) Then
                Return True
            End If
        End If

        Return False
    End Function
    Public Overloads Function Registrar(tablaPatologia As DataTable, tablaSintoma As DataTable)

        Dim consulta As String = "INSERT INTO patologia(nombre, descripcion,recomendacion,prioridad) VALUES(?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int32 = 0

        For Each fila As DataRow In tablaPatologia.Rows

            parametros.Add(New OdbcParameter("nombre", fila.Item(0).ToString.ToUpper))
            parametros.Add(New OdbcParameter("descripcion", fila.Item(1).ToString.ToUpper))
            parametros.Add(New OdbcParameter("recomendacion", fila.Item(2).ToString.ToUpper))
            parametros.Add(New OdbcParameter("priodidad", fila.Item(3)))

            If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
                contador += 1
            End If
            parametros.Clear()

        Next

        If contador = tablaPatologia.Rows.Count Then
            If RegistrarAsociacion(tablaSintoma) Then
                Return True
            End If
        End If

        Return False

    End Function

    Public Overloads Function RegistrarAsociacion(tabla As DataTable) As Boolean

        Dim contador As Int32 = 0
        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia) 
                                  VALUES((SELECT idSintoma FROM sintoma WHERE nombre = ?), 
                                  (SELECT idPatologia FROM patologia WHERE nombre = ?))"

        For Each row As DataRow In tabla.Rows

            parametros.Clear()
            parametros.Add(New OdbcParameter("nombre", row.Item(1)))
            parametros.Add(New OdbcParameter("nombre", row.Item(0)))

            If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
                contador += 1
            End If

        Next

        If contador = tabla.Rows.Count Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registrar la asociación de los síntomas y las patologías.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="nomSintomas"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Overloads Function RegistrarAsociacion(nombre As String, nomSintomas As ArrayList) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0
        Dim consulta As String = "INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia) 
                                  VALUES ((SELECT idSintoma FROM sintoma WHERE nombre = ?), 
                                  (SELECT idPatologia FROM patologia WHERE nombre = ?))"

        For Each var In nomSintomas
            parametros.Clear()
            parametros.Add(New OdbcParameter("nombre", var))
            parametros.Add(New OdbcParameter("nombre", nombre))

            If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
                contador += 1
            End If

        Next

        If contador = nomSintomas.Count Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de listar las patologías.
    ''' </summary>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ListarPatologias() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT nombre AS Nombre, descripcion AS Descripcion, recomendacion AS Recomendacion, prioridad AS Prioridad FROM patologia WHERE bajalogica = 0")
    End Function

    ''' <summary>
    ''' Función encargada de eliminar las patologías
    ''' </summary>
    ''' <param name="ali"></param>
    ''' <returns>True si el delete fue realizado.</returns>
    Public Function EliminarPatologias(ali As ArrayList) As Boolean

        Dim valores As String
        Dim consulta As String = "UPDATE patologia SET bajalogica = 1 WHERE nombre IN ("

        For i = 0 To ali.Count - 1
            valores = valores & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & valores.TrimEnd(",") & ")"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de obtener un diagnóstico basado en los síntomas del paciente.
    ''' </summary>
    ''' <param name="sintomas"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ObtenerDiagnostico(sintomas As ArrayList) As DataTable

        Dim parametros As String
        Dim consulta As String = "
                                SELECT p.nombre
                                FROM patologia p, sintoma s, patologia_contiene_sintoma ps
                                WHERE p.idPatologia = ps.idPatologia AND s.idSintoma = ps.idSintoma AND p.bajalogica = 0 
                                AND s.nombre IN ("

        For i As Integer = 0 To sintomas.Count - 1
            parametros = parametros & "'" & sintomas.Item(i) & "'" & ","
        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"
        consulta = consulta & " GROUP BY ps.idPatologia HAVING count(*) >= " & sintomas.Count & " ORDER BY count(*) desc"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de obtener la descripción de una patología
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <returns>Descripción de la patología seleccionada</returns>
    Public Function DescripcionPatologia(nombre As String) As String

        Dim consulta As String = "SELECT descripcion FROM patologia WHERE nombre = '" & nombre & "'"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), String)
    End Function

    ''' <summary>
    ''' Función encargada de registrar las patologías asociadas a los síntomas del paciente.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="diagnosticos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function GuardarDiagnostico(usuario As String, diagnosticos As ArrayList) As Boolean

        Dim consulta As String

        Try
            For Each nom In diagnosticos
                consulta = "
                    INSERT INTO paciente_obtiene_diagnostico (cedulaPaciente, idPatologia, fecha) 
                    SELECT " & usuario & ", p.idPatologia, '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm") & "' 
                    FROM patologia p WHERE p.nombre = '" & nom & "'"

                ModeloConsultas.Singleton.InsertarSinParametros(consulta)
            Next

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function VerificarBaja(nombre As String) As Boolean

        Dim consulta As String = "SELECT count(*) FROM patologia WHERE bajalogica = 1 AND nombre = '" & nombre & "'"

        If ModeloConsultas.Singleton.ConsultaCampo(consulta) = 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function ReingresarPatologia(nombre As String) As Boolean

        Dim consulta As String = "UPDATE patologia SET bajalogica = 0 WHERE nombre = '" & nombre & "'"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then

            Return True
        End If

        Return False
    End Function

    Public Function UpdateBajaLogica(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList) As Boolean

        Dim consulta As String = "UPDATE patologia SET bajalogica = 0, descripcion = '" & descripcion & "', " & "recomendacion = '" & recomendacion & "', " & "prioridad = '" & prioridad & "' " & "WHERE nombre = '" & nombre & "'"

        Dim consultaBorrado As String = "DELETE patologia_contiene_sintoma 
                                         FROM patologia_contiene_sintoma 
                                         INNER JOIN patologia ON patologia.idPatologia = patologia_contiene_sintoma.idPatologia 
                                         WHERE nombre = '" & nombre & "'"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            If ModeloConsultas.Singleton.ConsultaDelete(consultaBorrado) Then
                If RegistrarAsociacion(nombre, sintomas) Then
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    'Public Function VerificarExistencia(nombre As String) As Boolean

    '    If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM patologia WHERE nombre = '" & nombre & "'") = 0 Then
    '        Return True
    '    End If

    '    Return False

    'End Function

End Class
