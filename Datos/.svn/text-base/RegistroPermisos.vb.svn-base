Imports MySql.Data.MySqlClient
Imports Modelo

Public Class RegistroPermisos
    Public Sub ingresarPermisos(ByVal p As Permiso)
        Dim params As New List(Of MySqlParameter)
        Dim parametro As New MySqlParameter

    

        params.Add(New MySqlParameter("niv", p.Nivel))
        params.Add(New MySqlParameter("descrip", p.Descripcion))
        params.Add(New MySqlParameter("form", p.Formulario))
        params.Add(New MySqlParameter("ctrl", p.Control))
        

        AccesoDatos.Instancia.EjecutarComando("permiso_insert", params)
    End Sub
    Public Function listarPermisos() As List(Of Permiso)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from permiso order by nivel")
        Dim listaPermisos As New List(Of Permiso)
        Dim p As Permiso
        Dim fila As DataRow
        For Each fila In dt.Rows
            p = New Permiso(fila("idPermiso"), fila("nivel"), fila("descripcion"), fila("formulario"), fila("control"))
            listaPermisos.Add(p)
        Next
        Return listaPermisos
    End Function
    Public Function traerPermisosPorUsuario(ByVal idUsuario) As Hashtable
        Dim dt As DataTable
        Dim consulta As String
        consulta = "select * from usuariopermiso up inner join permiso p " + _
        "on up.`idPermiso` = p.`idPermiso` where idUsuario = " + CStr(idUsuario)
        dt = AccesoDatos.Instancia.EjecutarConsulta(consulta)
        Dim htPermisos As New Hashtable
        Dim p As Permiso
        Dim fila As DataRow
        For Each fila In dt.Rows
            p = New Permiso(fila("idPermiso"), fila("nivel"), fila("descripcion"), fila("formulario"), fila("control"))
            htPermisos.Add("" + CStr(p.IdPermiso), p)
        Next
        Return htPermisos

    End Function
    Public Function traerPermisosPorUsuarioYPerfil(ByVal idUsuario) As Hashtable
        Dim dt As DataTable
        Dim consulta As String
        consulta = "select p.* from usuariopermiso up inner join permiso p " + _
        "on up.`idPermiso` = p.`idPermiso` where idUsuario = " + CStr(idUsuario)

        'consulta += " Union "

        'consulta += "select p.* from permiso p inner join perfilpermiso pp " + _
        '"on pp.`idPermiso`=p.idpermiso inner join usuario u on u.`idPerfil` = pp.`idPerfil` where idusuario=" + CStr(idUsuario)


        dt = AccesoDatos.Instancia.EjecutarConsulta(consulta)
        Dim htPermisos As New Hashtable
        Dim p As Permiso
        Dim fila As DataRow
        For Each fila In dt.Rows
            p = New Permiso(fila("idPermiso"), fila("nivel"), fila("descripcion"), fila("formulario"), fila("control"))
            htPermisos.Add("" + CStr(p.IdPermiso), p)
        Next
        Return htPermisos
    End Function
End Class
