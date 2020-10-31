Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas del chat.
''' </summary>
Public Class ModeloChat

    Private Shared instancia As ModeloChat

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloChat

        If instancia Is Nothing Then
            instancia = New ModeloChat
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de crear un nuevo chat en la base de datos.
    ''' </summary>
    ''' <returns>Identificador del chat creado</returns>
    Public Function CrearChat()

        Dim consulta As String = "CALL CrearChat"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int32)

    End Function

    ''' <summary>
    ''' Función encargada de registrar un ingreso a un determinado chat.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="id"></param>
    ''' <returns>True si se ingresó al chat.</returns>
    Public Function EntrarChat(cedula As String, id As Int32) As Boolean

        Dim consulta As String = "INSERT INTO usuario_entra_chat (cedula, idChat, fechaIngreso) VALUES (?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("idChat", id))
        parametros.Add(New OdbcParameter("fechaIngreso", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de listar las peticiones de chat.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ListarChat(usuario As String) As DataTable

        Dim consulta As String = "SELECT DISTINCT u.cedula, u.idChat FROM salachat c, usuario_entra_chat u, patologia p, paciente_obtiene_diagnostico up, usuario us                      
                                  WHERE u.cedula = up.cedulaPaciente AND p.idPatologia = up.idPatologia AND p.bajalogica = 0 AND c.idChat = u.idChat AND us.cedula = u.cedula AND finalizado = 0 AND u.idChat NOT IN
                                  (SELECT idChat FROM usuario_entra_chat where cedula = " + usuario + ")" + "ORDER BY prioridad ASC "

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de enviar los mensajes.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="idChat"></param>
    ''' <param name="mensaje"></param>
    ''' <param name="fechaEnvio"></param>
    ''' <returns>True si el mensaje fue enviado.</returns>
    Public Function EnviarMensaje(cedula As String, idChat As Long, mensaje As String, fechaEnvio As Date)

        Dim consulta As String = "INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES (?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("idChat", idChat))
        parametros.Add(New OdbcParameter("mensaje", mensaje))
        parametros.Add(New OdbcParameter("fechaEnvio", fechaEnvio))

        Return ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
    End Function

    ''' <summary>
    ''' Función encargada de refrescar los mensajes del chat.
    ''' </summary>
    ''' <param name="idChat">ID del chat en cuestión.</param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function RecargarChat(idChat As Int32) As DataTable

        Dim consulta As String = "SELECT cedula, mensaje, fechaEnvio, idMensaje FROM mensaje WHERE idChat = " + idChat.ToString

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de actualizar aquellos mensajes posteriores al último mensaje mostrado en pantalla.
    ''' </summary>
    ''' <param name="idChat">ID del chat en cuestión.</param>
    ''' <param name="maxMsj">ID autoincremental del último mensaje recibido</param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function RecargarChatNuevoMSJ(idChat As Int32, maxMsj As Int32) As DataTable
        Dim consulta As String = "SELECT cedula, mensaje, fechaEnvio, idMensaje FROM mensaje WHERE idChat = " & idChat.ToString & " AND idMensaje > " & maxMsj.ToString & ";"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de avisar al paciente si el médico a respondido su solicitud.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <returns>Cantidad de mensajes existentes en una sala de chat.</returns>
    Public Function ObtenerRespuesta(usuario As String) As Int16
        'Dim consulta As String = "SELECT count(*) FROM mensaje WHERE idChat =  " + idChat.ToString
        Dim consulta As String = "SELECT count(*) FROM mensaje inner join salachat on salachat.idChat = mensaje.idChat where mensaje.idChat IN (SELECT MAX(idChat) FROM usuario_entra_chat WHERE cedula = " & usuario & ")" & " and finalizado = 0"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int16)
    End Function

    Public Function VerificarMensaje(usuario As String) As Int16
        Dim consulta As String = "select count(*) from mensaje where cedula = " & usuario & " and idChat IN (SELECT MAX(idChat) FROM usuario_entra_chat WHERE cedula = " & usuario & ")"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Int16)
    End Function

    Public Function DenegarChat(usuario As String) As Boolean

        Dim consulta As String = "update salachat set finalizado = 1 where idchat = (SELECT MAX(idChat) FROM usuario_entra_chat WHERE cedula = " & usuario & ")"

        ModeloConsultas.Singleton.InsertarSinParametros("START TRANSACTION")
        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            ModeloConsultas.Singleton.InsertarSinParametros("COMMIT")
            Return True
        Else
            ModeloConsultas.Singleton.InsertarSinParametros("ROLLBACK")
            Return False
        End If

    End Function

    ''' <summary>
    ''' Función encargada de finalizar una sesión de chat.
    ''' </summary>
    ''' <param name="idChat"></param>
    ''' <returns>True si la sesión fue finalizada.</returns>
    Public Function FinalizarChat(idChat As String) As Boolean

        Dim consulta As String = "UPDATE salachat SET finalizado = 1 WHERE idChat = " + idChat

        Return ModeloConsultas.Singleton.InsertarSinParametros(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el médico ya ingresó al. 
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="idChat"></param>
    ''' <returns>Cantidad de veces que el médico ingresó.</returns>
    Public Function VerificarCedula(cedula As String, idChat As String) As Int16

        Dim consulta = "SELECT count(*) FROM usuario_entra_chat pc, medico m 
                        WHERE m.cedula = pc.cedula AND pc.cedula = " + cedula + " AND idChat = " + idChat

        Return ModeloConsultas.Singleton.ConsultaCampo(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de listar los chats pertenecientes a un médico.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="finalizado"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function MisChats(cedula As String, finalizado As Byte)

        Dim consulta As String = " SELECT p.cedula, c.idChat, u.pNom, u.pApe, mensaje, fechaenvio, CONVERT(fotoPerfil USING utf8)
                                   FROM usuario u, paciente p, salachat c, mensaje m right join usuario_entra_chat uc on m.idChat = uc.idChat
                                   WHERE idMensaje = any (select max(idMensaje) from mensaje group by idChat order by max(fechaenvio))AND uc.cedula = p.cedula AND c.idChat = uc.idChat AND u.cedula = p.cedula AND finalizado = 0
                                   AND c.idChat in 
	                                   (
		                                 SELECT idChat FROM usuario_entra_chat WHERE cedula = " & cedula & "
	                                    )
                                   GROUP BY uc.idChat
                                   ORDER BY MAX(fechaenvio) desc"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    Public Function GetMensaje(idChat As Int32)

        Dim consulta As String = "SELECT mensaje, fechaEnvio, cedula, idChat FROM mensaje WHERE idChat = " & idChat & " ORDER BY idMensaje DESC limit 1"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de obtener el nombre del usuario.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetNombre(cedula As String) As DataTable

        Dim consulta As String = "SELECT pNom, pApe FROM usuario WHERE cedula = " & cedula

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de obtener el e-mail del usuario.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>Correo electrónico del usuario.</returns>
    Public Function GetCorreo(cedula As String) As String

        Dim consulta As String = "SELECT correo FROM usuario WHERE cedula = " + cedula

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), String)
    End Function

    Public Function Notificacion(cedula As String) As DataTable

        Dim consulta As String = "select cedula from mensaje where idChat in 
	                                (
		                                select idChat from usuario_entra_chat where cedula = " & cedula & "
	                                ) 
                                  order by idMensaje desc"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function
    Public Function verificarEstadoChat(cedula As String) As Int16
        Dim consulta = "select finalizado from salachat c, usuario_entra_chat uc where uc.idchat = c.idchat and uc.cedula = " & cedula & " and c.idChat in (select max(c.idchat) from salachat c, usuario_entra_chat uc where uc.idchat = c.idchat and uc.cedula = " & cedula & ")"
        Return ModeloConsultas.Singleton.ConsultaCampo(consulta)

    End Function

    Public Function ObtenerChatPaciente(cedula As String) As Integer
        Dim consulta As String = "SELECT MAX(c.idChat) FROM salachat c, usuario_entra_chat uc WHERE c.idChat = uc.idChat AND finalizado = 0 AND cedula = " & cedula
        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), Integer)
    End Function

    Public Function ordern(cedula As String) As DataTable
        Dim consulta As String = "select uc.idChat, mensaje, fechaenvio from mensaje m right join usuario_entra_chat uc on uc.idChat = m.idChat where uc.idChat in 
(select uc.idchat from usuario_entra_chat uc, salachat c where idMensaje = any (select max(idMensaje) from mensaje group by idChat order by max(fechaenvio)) and uc.idChat = c.idChat and finalizado = 0 and cedula = " & cedula & ") 
group by m.idChat order by max(fechaenvio) asc"
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function
End Class
