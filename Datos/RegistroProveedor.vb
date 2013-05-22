Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroProveedor
    Public Function TraerPorId(ByVal idProveedor As Integer) As Proveedor
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from ente e inner join Proveedor ex on e.`idEnte`=ex.`idEnte` where idProveedor=" & CStr(idProveedor))
        Dim fila As DataRow
        Dim objProveedor As Proveedor
        fila = dt.Rows(0)

        objProveedor = New Proveedor()
        objProveedor.IdProveedor = fila("idProveedor")
        objProveedor.IdEnte = fila("idEnte")
        objProveedor.CUIT = fila("CUIT")
        objProveedor.IdRubro = fila("idrubro")
        objProveedor.FechaAlta = fila("fechaalta")
        objProveedor.Lista = fila("lista")
        objProveedor.IdProveedor = fila("idProveedor")
        objProveedor.Bonificaciones = fila("bonificaciones")
        objProveedor.Email = fila("email")
        objProveedor.RazonSocial = fila("razonsocial")

        Return objProveedor
    End Function
    Public Function TraerIdPorNombre(ByVal nombre As String) As Integer
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select idProveedor from Proveedor where razonsocial = '" & nombre & "'")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 1
        End If

    End Function
    Public Sub altaProveedor(ByVal adProveedor As Proveedor)
        AccesoDatos.Instancia.IniciarTransaccion()
        Dim regEnte As New RegistroEnte
        regEnte.altaEnte(adProveedor)


        Dim params As New List(Of MySqlParameter)

        params.Add(New MySqlParameter("inRazonSocial", adProveedor.RazonSocial))
        params.Add(New MySqlParameter("inIdEnte", adProveedor.IdEnte))
        params.Add(New MySqlParameter("inLista", adProveedor.Lista))
        params.Add(New MySqlParameter("inBonificaciones", adProveedor.Bonificaciones))
        params.Add(New MySqlParameter("inEmail", adProveedor.Email))

        AccesoDatos.Instancia.EjecutarComando("proveedor_insert", params)
        AccesoDatos.Instancia.ConfirmarTransaccion()

    End Sub
    Public Sub modificarProveedor(ByVal adProveedor As Proveedor)
        AccesoDatos.Instancia.IniciarTransaccion()
        Dim regEnte As New RegistroEnte
        regEnte.modificarEnte(adProveedor)


        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdProveedor", adProveedor.IdProveedor))
        params.Add(New MySqlParameter("inRazonSocial", adProveedor.RazonSocial))
        params.Add(New MySqlParameter("inIdEnte", adProveedor.IdEnte))
        params.Add(New MySqlParameter("inLista", adProveedor.Lista))
        params.Add(New MySqlParameter("inBonificaciones", adProveedor.Bonificaciones))
        params.Add(New MySqlParameter("inEmail", adProveedor.Email))
        AccesoDatos.Instancia.EjecutarComando("Proveedor_update", params)
        AccesoDatos.Instancia.ConfirmarTransaccion()
    End Sub
    Public Sub bajaProveedor(ByVal idProveedor As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdProveedor", idProveedor))
        AccesoDatos.Instancia.EjecutarComando("Proveedor_delete", params)
    End Sub
    Public Function listarParaCombo() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor,razonsocial from proveedor order by razonsocial")
    End Function
    Public Function listarTodos() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`from ente e inner join rubro r on e.`idRubro` = r.`idRubro`inner join Proveedor p on e.`idEnte`=p.`idEnte` left join telefono t  on p.idente=t.idente")
    End Function
    Public Function listarPorNombre(ByVal nombre As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`from ente e inner join rubro r on e.`idRubro` = r.`idRubro`inner join Proveedor p on e.`idEnte`=p.`idEnte` left join telefono t  on p.idente=t.idente where p.razonsocial like '%" + nombre + "%'")
    End Function
    Public Function listarPorID(ByVal id As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`from ente e inner join rubro r on e.`idRubro` = r.`idRubro`inner join Proveedor p on e.`idEnte`=p.`idEnte` left join telefono t  on p.idente=t.idente where p.idProveedor=" + CStr(id))
    End Function
    Public Function listarPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`, d.`localidad` from ente e inner join rubro r on e.`idRubro` = r.`idRubro` inner join Proveedor p on e.`idEnte`=p.`idEnte` left join domicilio d on d.`idente`= p.idente left join telefono t  on p.idente=t.idente where d.codigopostal like '%" + codigoPostal + "%'")
    End Function
    Public Function listarPorRubro(ByVal rubro As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`from ente e inner join rubro r on e.`idRubro` = r.`idRubro`inner join Proveedor p on e.`idEnte`=p.`idEnte` left join telefono t  on p.idente=t.idente where r.descripcion like '%" + rubro + "%'")
    End Function
    Public Function listarPorLocalidad(ByVal localidad As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`, CONVERT(CONCAT(calle,' ', altura,' ', piso,' ',depto ) using utf8) as 'direccion' from ente e inner join rubro r on e.`idRubro` = r.`idRubro` inner join Proveedor p on e.`idEnte`=p.`idEnte` left join domicilio d on d.`idente`= p.idente left join telefono t  on p.idente=t.idente where d.localidad like '%" + localidad + "%'")
    End Function
    Public Function listarPorContacto(ByVal nombreContacto As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idProveedor, razonSocial, r.`descripcion` as 'rubro', bonificaciones,t.`nombrecontacto` as 'contacto',t.`numero`from ente e inner join rubro r on e.`idRubro` = r.`idRubro`inner join Proveedor p on e.`idEnte`=p.`idEnte` inner join telefono t  on p.idente=t.idente where t.nombrecontacto like '%" + nombreContacto + "%'")
    End Function
End Class
