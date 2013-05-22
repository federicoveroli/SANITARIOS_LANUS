Imports System.Data
Imports MySql.Data.MySqlClient
Imports Modelo
Imports System.IO

Imports System.Data.OleDb  ' DESPUES BORRAR LO DE ACCESS Sr MAMPUSO


Public Class AccesoDatos
    Private Shared vInstancia As AccesoDatos
    Private Shared vStrCn As String
    Private cn As MySqlConnection
    Private Shared tx As MySqlTransaction
    Private Shared cm As MySqlCommand
    Private Shared enTransaccion As Boolean
    Private esta_grabando_script As Boolean = False
    Private esc_archivo As StreamWriter

    Private Sub New()
        'El constructor es privado para controlar que solo de pueda instanciar una vez esta clase
        'desde la propiedad Instancia

        'establezco el string de conexion para poder utilizar el acceso a datos
        'el string de conexion lo deberia cargar de un archivo xml o config
        'limaku.no-ip.org
        Dim regCon As New RegistroCadenaDeConexion
        ConnectionString = regCon.GenerarConecctionString(regCon.TraerCadenaDeConexion())
    End Sub
    Public WriteOnly Property ConnectionString()
        Set(ByVal value)
            cn = New MySqlConnection(value)
        End Set
    End Property
    Public Shared ReadOnly Property Instancia() As AccesoDatos
        Get
            If IsNothing(vInstancia) Then vInstancia = New AccesoDatos
            Return vInstancia
        End Get
    End Property
    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Dim da As New MySqlDataAdapter(consulta, cn)
        Dim dt As New DataTable
        If esta_grabando_script Then
            esc_archivo.WriteLine(consulta + ";")
        End If
        da.Fill(dt)
        Return dt
    End Function

    Public Function EjecutarConsultaMigracion(ByVal consulta As String) As DataTable  ' DESPUES BORRARR

        Dim oConn As New OleDbConnection

        Dim cn As String
        Dim cm As OleDbCommand
        cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\ARTICULOS2009.mdb;User Id=admin;Password=;"
        oConn.ConnectionString = cn

        oConn.Open()
        Dim da As New OleDbDataAdapter(consulta, oConn)
        Dim dt As New DataTable
        da.Fill(dt)
        oConn.Close()
        Return dt
    End Function

    Public Sub EjecutarComando(ByVal procedure As String, ByVal params As List(Of MySqlParameter))
        'ejecuta un procedimiento almacenado de escritura o actualizacion
        'contempla utilizar una transaccion en caso que halla sido iniciada
        Try


            Dim com As MySqlCommand
            com = New MySqlCommand(procedure, cn)
            com.CommandType = CommandType.StoredProcedure

            If Not enTransaccion Then cn.Open()

            If Not IsNothing(params) Then
                'si no es nula la coleccion de parametros, o sea,
                'si posee parametros los carga
                Dim p As MySqlParameter
                For Each p In params
                    com.Parameters.Add(p)
                Next
            End If

            'ejecuto el procedimiento almacenado
            com.ExecuteNonQuery()

            'rescatar parametro
            'Dim output As Integer
            'output = CInt(com.Parameters("salida").Value)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If Not enTransaccion Then cn.Close()
        End Try


    End Sub

    Public Sub IniciarTransaccion()
        cm = New MySqlCommand
        If cn.State = 1 Then
            cn.Close()
        End If
        cn.Open()
        tx = cn.BeginTransaction
        cm.Transaction = tx
        enTransaccion = True
    End Sub
    Public Sub ConfirmarTransaccion()
        tx.Commit()
        cn.Close()
        enTransaccion = False
    End Sub
    Public Sub DeshacerTransaccion()
        tx.Rollback()
        cn.Close()
        enTransaccion = False
    End Sub
    Public Sub IniciarGrabacion()
        esta_grabando_script = True
        esc_archivo = New StreamWriter("cambios.sql")


    End Sub
    Public Sub FinalizarGrabacion(ByVal filePath As String)
        esta_grabando_script = False
        esc_archivo.Close()
        Dim Source As String = "cambios.sql"
        Dim Destination As String = filePath
        System.IO.File.Copy(Source, Destination, True)
        esc_archivo.Dispose()
    End Sub
    Public Sub FinalizarGrabacion()
        esta_grabando_script = False
        esc_archivo.Close()
        esc_archivo.Dispose()
    End Sub

End Class
