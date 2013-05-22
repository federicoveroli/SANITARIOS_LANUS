Imports MySql.Data.MySqlClient
Imports Modelo

Public Class RegistroUsuarios
    Public Sub ingresarUsuario(ByVal usuario As Usuario)
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter

        parametro.DbType = DbType.String
        parametro.ParameterName = "nick"
        parametro.Value = usuario.Nick

        params.Add(parametro) 'agrego el 1º paramotro del procedimiento almacenado

        parametro = New MySqlParameter("pass", usuario.Pass)

        params.Add(parametro) 'agrego el 2º paramotro del procedimiento almacenado

        parametro = New MySqlParameter()
        parametro.DbType = DbType.String
        parametro.ParameterName = "nombre"
        parametro.Value = usuario.Nombre

        params.Add(parametro) 'agrego el 3º paramotro del procedimiento almacenado

        parametro = New MySqlParameter()
        parametro.DbType = DbType.String
        parametro.ParameterName = "apellido"
        parametro.Value = usuario.Apellido

        params.Add(parametro) 'agrego el 4º paramotro del procedimiento almacenado

        AccesoDatos.Instancia.EjecutarComando("usuario_insert", params)
    End Sub
    Public Function nickDisponible(ByVal nick As String) As Boolean
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter
        Dim salida As Integer

        parametro = New MySqlParameter("nicka", nick)
        params.Add(parametro)

        parametro = New MySqlParameter("salida", salida)
        parametro.Direction = ParameterDirection.Output
        params.Add(parametro)

        AccesoDatos.Instancia.EjecutarComando("usuario_nick_disponible", params)

        Return Not CBool(parametro.Value)
    End Function
    Public Function buscarUsuario(ByVal nick As String) As Usuario
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from usuario where nick='" + nick + "'")
        If dt.Rows.Count = 0 Then Return Nothing
        Dim fila As DataRow = dt.Rows(0)
        Dim usu As New Usuario(CInt(fila("idUsuario")), fila("nick").ToString(), fila("pass").ToString(), _
                    fila("nombre").ToString(), CStr(fila("apellido")), fila("borrado"))
        Return usu
    End Function
    Public Sub eliminarUsuario(ByVal idUsuario As Integer)
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter

        parametro = New MySqlParameter("idUsu", idUsuario)
        params.Add(parametro)


        AccesoDatos.Instancia.EjecutarComando("usuario_delete", params)

    End Sub
    Public Function listarUsuarios() As List(Of Usuario)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from usuario where borrado = 0")
        Dim listaUsuarios As New List(Of Usuario)
        Dim usuario As Usuario
        Dim fila As DataRow
        For Each fila In dt.Rows
            usuario = New Usuario(CInt(fila("idUsuario")), fila("nick").ToString(), fila("pass").ToString(), _
            fila("nombre").ToString(), CStr(fila("apellido")), fila("borrado"))
            listaUsuarios.Add(usuario)
        Next
        Return listaUsuarios
    End Function
    Public Function listarUsuariosPorPerfil(ByVal idPerfil) As List(Of Usuario)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from usuario where borrado = 0 and idPerfil=" + CStr(idPerfil))
        Dim listaUsuarios As New List(Of Usuario)
        Dim usuario As Usuario
        Dim fila As DataRow
        For Each fila In dt.Rows
            usuario = New Usuario(CInt(fila("idUsuario")), fila("nick").ToString(), fila("pass").ToString(), _
            fila("nombre").ToString(), CStr(fila("apellido")))
            listaUsuarios.Add(usuario)
        Next
        Return listaUsuarios
    End Function
    Public Sub modificarUsuario(ByVal usuario As Usuario)
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter

        parametro = New MySqlParameter("idUsu", usuario.Id)
        params.Add(parametro) 'agrego el 1º paramotro del procedimiento almacenado

        parametro = New MySqlParameter("nick", usuario.Nick)
        params.Add(parametro) 'agrego el 2º paramotro del procedimiento almacenado

        parametro = New MySqlParameter("pass", usuario.Pass)
        params.Add(parametro) 'agrego el 3º paramotro del procedimiento almacenado


        parametro = New MySqlParameter("nombre", usuario.Nombre)
        params.Add(parametro) 'agrego el 4º paramotro del procedimiento almacenado

        
        parametro = New MySqlParameter("apellido", usuario.Apellido)
        params.Add(parametro) 'agrego el 5º paramotro del procedimiento almacenado

        AccesoDatos.Instancia.EjecutarComando("usuario_update", params)
    End Sub
    Public Sub restaurarUsuario(ByVal nick As String)
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter

        parametro = New MySqlParameter("nickR", nick)
        params.Add(parametro)


        AccesoDatos.Instancia.EjecutarComando("usuario_restaurar", params)
    End Sub

    Public Function usuariosActivos() As Integer
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter
        Dim cantidad As Integer

        parametro = New MySqlParameter("cantidad", cantidad)
        parametro.Direction = ParameterDirection.Output
        params.Add(parametro)

        AccesoDatos.Instancia.EjecutarComando("usuario_activos", params)

        Return parametro.Value
    End Function
    Public Sub GuardarPermisos(ByVal usu As Usuario)
        Dim params As New List(Of MySqlParameter)

        Try
            AccesoDatos.Instancia.IniciarTransaccion()
            params.Clear()
            params.Add(New MySqlParameter("idUsu", usu.Id))
            AccesoDatos.Instancia.EjecutarComando("usuariopermiso_delete", params)

            For Each per As Permiso In usu.Permisos.Values
                agregarPermiso(usu.Id, per.IdPermiso)
            Next
            AccesoDatos.Instancia.ConfirmarTransaccion()
        Catch ex As MySqlException
            AccesoDatos.Instancia.DeshacerTransaccion()
            Throw New Exception("Ocurrió un error tratando de guardar los permisos del Usuario", ex)
        End Try
    End Sub
    Private Sub agregarPermiso(ByVal idUsuario As Integer, ByVal idPermiso As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("idUsu", idUsuario))
        params.Add(New MySqlParameter("idPer", idPermiso))
        AccesoDatos.Instancia.EjecutarComando("usuariopermiso_insert", params)
    End Sub
End Class
