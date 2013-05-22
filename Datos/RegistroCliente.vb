Imports MySql.Data.MySqlClient
Imports Modelo


Public Class RegistroCliente

    Public Function TraerPorId(ByVal idCliente As Integer) As Cliente
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from ente e inner join Cliente ex on e.`idEnte`=ex.`idEnte` where idcliente=" & CStr(idCliente))
        Dim fila As DataRow
        Dim objCliente As Cliente
        fila = dt.Rows(0)

        objCliente = New Cliente()
        objCliente.IdCliente = fila("idCliente")
        objCliente.IdEnte = fila("idEnte")
        objCliente.Nombre = fila("nombre")
        objCliente.IdCliente = fila("idCliente")
        objCliente.CUIT = fila("cuit")
        objCliente.Credito = fila("credito")
        objCliente.IdIva = fila("idIva")
        objCliente.IdRubro = fila("idrubro")
        objCliente.FechaAlta = fila("fechaalta")
        Return objCliente
    End Function
    Public Sub altaCliente(ByVal adCliente As Cliente)
        AccesoDatos.Instancia.IniciarTransaccion()
        Dim regEnte As New RegistroEnte
        regEnte.altaEnte(adCliente)
        Dim idCliente As New MySqlParameter("outIdCliente", 0)
        idCliente.Direction = ParameterDirection.Output

        Dim params As New List(Of MySqlParameter)
        params.Add(idCliente)
        params.Add(New MySqlParameter("innombre", adCliente.Nombre))
        params.Add(New MySqlParameter("infechaalta", adCliente.FechaAlta))
        params.Add(New MySqlParameter("inidiva", adCliente.IdIva))
        params.Add(New MySqlParameter("inidente", adCliente.IdEnte))
        params.Add(New MySqlParameter("incredito", adCliente.Credito))
        AccesoDatos.Instancia.EjecutarComando("Cliente_insert", params)
        adCliente.IdCliente = idCliente.Value
        AccesoDatos.Instancia.ConfirmarTransaccion()

    End Sub
    Public Sub modificarCliente(ByVal adCliente As Cliente)
        AccesoDatos.Instancia.IniciarTransaccion()
        Dim regEnte As New RegistroEnte
        regEnte.modificarEnte(adCliente)


        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdCliente", adCliente.IdCliente))
        params.Add(New MySqlParameter("innombre", adCliente.Nombre))
        params.Add(New MySqlParameter("infechaalta", adCliente.FechaAlta))
        params.Add(New MySqlParameter("inidiva", adCliente.IdIva))
        params.Add(New MySqlParameter("inidente", adCliente.IdEnte))
        params.Add(New MySqlParameter("incredito", adCliente.Credito))
        AccesoDatos.Instancia.EjecutarComando("cliente_update", params)
        AccesoDatos.Instancia.ConfirmarTransaccion()
    End Sub
    Public Sub bajaCliente(ByVal idCliente As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdCliente", idCliente))
        AccesoDatos.Instancia.EjecutarComando("cliente_delete", params)
    End Sub
    Public Function listarTodos() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, nombre, CONVERT(CONCAT(calle ) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` order by nombre")
    End Function
    Public Function listarPorIva(ByVal iva As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente, i.descripcion, cuit, nombre, CONVERT(CONCAT(calle ) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` inner join iva i on c.idIva= i.idIva where i.descripcion like '%" + iva + "%' order by nombre")
    End Function
    Public Function listarPorNombre(ByVal nombre As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, nombre, CONVERT(CONCAT(calle ) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` where c.nombre like '%" + nombre + "%' order by nombre")
    End Function
    Public Function listarPorCuit(ByVal cuit As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, nombre, CONVERT(CONCAT(calle ) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` where e.cuit like '%" + cuit + "%' order by nombre")
    End Function
    Public Function listarPorID(ByVal id As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, nombre, CONVERT(CONCAT(calle) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` where c.idCliente=" + CStr(id) & " order by nombre")
    End Function
    Public Function listarPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, nombre, CONVERT(CONCAT(calle) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` where d.codigopostal like '%" + codigoPostal + "%' order by nombre")
    End Function
    Public Function listarPorRubro(ByVal rubro As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, r.descripcion as rubro, nombre, CONVERT(CONCAT(calle) using utf8) as 'direccion', localidad from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` inner join rubro r on e.idrubro=r.idrubro where r.descripcion like '%" + rubro + "%' order by nombre")
    End Function
    Public Function listarPorLocalidad(ByVal localidad As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idCliente,cuit, d.localidad, nombre, CONVERT(CONCAT(calle ) using utf8) as 'direccion' from ente e inner join Cliente c on e.`idEnte`=c.`idEnte` left join domicilio d on e.`idente`=d.`idente` where d.localidad like '%" + localidad + "%' order by nombre")
    End Function
    Public Function listarParaCombo() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idcliente,nombre from cliente order by nombre")
    End Function
    Public Function TraerLimiteCredito(ByVal id As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select credito from cliente where idcliente=" & id & " order by nombre")
    End Function
    Public Function MirarSiDeBe(ByVal id As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select count(*) from venta where idcliente= " & id & " and pagado=0 ")
    End Function

End Class
