Imports Logica
Imports System.IO

''' <summary>
''' User Control encargado de los ajustes del sistema
''' </summary>
Public Class UCAjustes

    Private Shared instancia As UCAjustes

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UCAjustes_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbIdiomas.SelectedIndex = Configuracion.Singleton.lenguaje ''' Setea el índice del combobox en función al idioma cargado.
    End Sub

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As UCAjustes

        If instancia Is Nothing Then
            instancia = New UCAjustes
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Subrutina encargada de verificar si la tabla de recursos existe.
    ''' </summary>
    Public Sub VerificarArchivo()
        If File.Exists(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) = False Then
            Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
            Configuracion.Singleton.GuardarConfiguracion()
            CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "es_ES"))
        End If
    End Sub
    Private Sub BtnAplicarCambios_Click(sender As Object, e As EventArgs) Handles btnAplicarCambios.Click

        Dim bool As Boolean = False

        If cbIdiomas.SelectedIndex = Configuracion.Idioma.en_US Then
            If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.en_US Then
                If PreguntaIdioma() Then
                    bool = True
                    Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US
                    Configuracion.Singleton.GuardarConfiguracion()
                End If
            End If
        ElseIf cbIdiomas.SelectedIndex = Configuracion.Idioma.es_ES Then
            If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.es_ES Then
                If PreguntaIdioma() Then
                    bool = True
                    Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
                    Configuracion.Singleton.GuardarConfiguracion()
                End If
            End If
        End If

        If bool Then
            CargarIdioma()
            Application.Restart()
        End If

    End Sub

    ''' <summary>
    ''' Subrutina encargada de cargar la tabla de recursos en función al idioma seleccionado.
    ''' </summary>
    Private Sub CargarIdioma()
        If Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "es_ES"))
        ElseIf Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "en_US"))
        End If
    End Sub

    ''' <summary>
    ''' Subrutina encargada de cargar la tabla de recursos.
    ''' </summary>
    ''' <param name="archivo"></param>
    Public Sub CambiarTabla(archivo As String)

        Dim componentes As DataTable = Configuracion.Singleton.RecorrerTablaIdioma(archivo)
        Dim obj As New Resources.ResXResourceWriter(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx"))

        For i As Integer = 0 To componentes.Rows.Count - 1
            obj.AddResource(componentes.Rows.Item(i).Item(0).ToString, componentes.Rows.Item(i).Item(1).ToString)
        Next

        obj.Close()

    End Sub
    Public Function PreguntaIdioma() As Boolean

        Dim respuesta As Integer

        respuesta = MsgBox(Principal.Singleton.Idioma("msgPreguntaIdioma"), vbQuestion + vbYesNo + vbDefaultButton2, "")

        If respuesta = vbYes Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
