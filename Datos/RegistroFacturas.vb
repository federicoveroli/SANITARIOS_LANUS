Imports Modelo
Imports MySql.Data.MySqlClient
Imports System.Text.StringBuilder
Public Class RegistroFacturas
    Public Sub ArchivarFacturas(ByVal nombreArchivo As String, ByVal nombreTabla As String, ByVal fechadesde As Date, ByVal fechaHasta As Date)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("vDescripcion", nombreArchivo))
        params.Add(New MySqlParameter("vNombreTabla", nombreTabla))
        params.Add(New MySqlParameter("vFechaInicio", fechadesde))
        params.Add(New MySqlParameter("vFechafin", fechaHasta))
        AccesoDatos.Instancia.EjecutarComando("facturasarchivadas_insert", params)
    End Sub
    Public Sub ScriptArchivar(ByVal script As String)
        AccesoDatos.Instancia.EjecutarConsulta(script)
    End Sub

    Public Function TraerUnidadesVendidas(ByVal condicionStr As String) As DataTable
        Dim consulta As String
        If condicionStr.Length > 0 Then condicionStr = " where " & condicionStr & " and rc.cantidad > 0 "
        ' consulta = "select numero as Nro,fechaemision as fecha, IF(montotarjeta>0,'T','E') as FP,art.descripcion as 'Descripcion', rc.cantidad as 'Cant', rc.preciounitario as 'PU', rc.cantidad * rc.preciounitario as 'Sub', pr.razonsocial as 'Proveedor' from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join rengloncomprobante rc on rc.idcomprobante = comprobante.idcomprobante inner join articulo art on art.idarticulo = rc.idarticulo inner join proveedor pr on pr.idproveedor = art.Idproveedor  " & condicionStr & " order by fechaemision  desc"
        consulta = "select numero as Nro,fechaemision as fecha, IF(montotarjeta>0,'T','E') as FP, rc.descripcion as 'Descripcion', rc.cantidad as 'Cant', rc.preciounitario as 'PU', rc.cantidad * rc.preciounitario as 'Sub', pr.razonsocial as 'Proveedor' from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join rengloncomprobante rc on rc.idcomprobante = comprobante.idcomprobante left join articulo art on art.idarticulo = rc.idarticulo left join proveedor pr on pr.idproveedor = art.Idproveedor  " & condicionStr & " order by fechaemision  desc"

        Return AccesoDatos.Instancia.EjecutarConsulta(consulta)

    End Function

    Public Function TraerMinFecha() As Date
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select min(fechaEmision) from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante where CondicionVenta='X'")
        Return Date.Parse(Dt.Rows(0).Item(0).ToString)
    End Function
    Public Function TraerMaxFecha() As Date
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select max(fechaEmision) from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante where CondicionVenta='X'")
        Return Date.Parse(Dt.Rows(0).Item(0).ToString)
    End Function
    Public Function TraerNumero(ByVal tipoFac As String) As Integer
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select max(numero) from venta where CondicionVenta='" & tipoFac & "'")
        If IsDBNull(Dt.Rows(0).Item(0)) Then Return 1
        Return CInt(Dt.Rows(0).Item(0) + 1)
    End Function

    Public Function TraerMaxIdVenta() As Integer
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select max(idventa) from venta")
        Return Dt.Rows(0).Item(0).ToString
    End Function

    Public Function TraerNumeroNotaDeCredito(ByVal tipofac As String) As Integer
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select max(numero) from notadecredito where CondicionVenta='" & tipofac & "'")
        If IsDBNull(Dt.Rows(0).Item(0)) Then Return 1
        Return CInt(Dt.Rows(0).Item(0) + 1)
    End Function
    Public Sub Eliminar(ByVal numero As Integer, ByVal condicion As String)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inNumero", numero))
        params.Add(New MySqlParameter("inCondicion", condicion))
        AccesoDatos.Instancia.EjecutarComando("venta_delete", params)
    End Sub
    Public Function ListarFacturasCtaCte(ByVal cliente As Integer) As DataTable
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select numero as NumFac, CondicionVenta as Condicion, fechaemision as Fecha_Emision,total as Total from venta inner join comprobante on venta.idcomprobante=comprobante.idcomprobante where venta.idcliente=" & cliente & " and venta.pagado=0 and venta.idtipoventa=1 and condicionventa <> 'P'")
        Return Dt
    End Function
    Public Function ListarFacturasConDetalle(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select numero as NumFac, condicionventa as Condicion, fecha as Fecha, montopagado as Monto_Pagado from detctacte inner join venta on `detctacte`.`idventa`	= `venta`.`idventa` where `detctacte`.`idventa`= (select idventa from venta where numero = " & numero & " and condicionVenta ='" & condicion & "')") '("select numero as NumFac, CondicionVenta as Condicion, fecha as Fecha, montopagado as Monto_Pagado from detctacte where idventa= " & id)
        Return dt
    End Function
    Public Function ListarFacturas() As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo, IF(montotarjeta>0,'T','E') as 'FP', cliente.`nombre` as Cliente,descuento as Descuento, total as Total  from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente order by fechaemision desc,numero desc")
        Return dt
    End Function
    Public Function ListarNotasDeCredito() As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha,numero as Nro,condicionVenta as Tipo,cliente.`nombre` as Cliente,total as Total,numeroFactura as Factura from notadecredito inner join comprobante on notadecredito.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on notadecredito.`idcliente`= cliente.idcliente")
        Return dt
    End Function
    Public Function ListarNotasDeCredito(ByVal numero As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha,numero as Nro,condicionVenta as Tipo,cliente.`nombre` as Cliente,total as Total,numeroFactura as Factura from notadecredito inner join comprobante on notadecredito.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on notadecredito.`idcliente`= cliente.idcliente where numero=" & numero)
        Return dt
    End Function
    Public Function ListarFacturas(ByVal idcliente As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo,cliente.`nombre` as Cliente,descuento as Descuento, total as Total  from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente where cliente.idCliente =" & idcliente & " order by fechaemision desc,numero desc ")
        Return dt
    End Function
    Public Function ListarFacturasPorVendedor(ByVal nick As String) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo, IF(montotarjeta>0,'T','E') as 'FP', cliente.`nombre` as Cliente,descuento as Descuento, total as Total  from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente where nick ='" & nick & "'" & " order by fechaemision desc,numero desc")
        Return dt
    End Function

    Public Function ListarFacturasPorIdArticulo(ByVal idArticulo As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo, IF(montotarjeta>0,'T','E') as 'FP', cliente.`nombre` as Cliente,descuento as Descuento, total as Total  from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente inner join rengloncomprobante rc on comprobante.idcomprobante = rc.idcomprobante where rc.idarticulo =" & idArticulo & " order by fechaemision desc,numero desc")
        Return dt
    End Function

    Public Function ListarFacturasPorIdTipoProducto(ByVal idTipoProducto As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo,cliente.`nombre` as Cliente,descuento as Descuento, total as Total from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente inner join rengloncomprobante rc on comprobante.idcomprobante = rc.idcomprobante inner join articulo a on a.idarticulo = rc.idarticulo inner join categoriaarticulo ca on ca.idcategoria = a.idcategoria where a.idcategoria =" & idTipoProducto & " order by fechaemision desc,numero desc")
        Return dt
    End Function

    Public Function ListarFacturas(ByVal tipo As String) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo,cliente.`nombre` as Cliente,total as Total from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente where condicionVenta ='" & tipo & "'" & " order by fechaemision desc,numero desc")
        Return dt
    End Function
    Public Function ListarFacturas(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select fechaemision as fecha, numero as Nro,condicionVenta as Tipo, IF(montotarjeta>0,'T','E') as 'FP', cliente.`nombre` as Cliente,total as Total from venta inner join comprobante on venta.`idcomprobante`=comprobante.`idcomprobante` inner join cliente on venta.`idcliente`= cliente.idcliente where numero =" & numero & " and condicionventa= '" & condicion & "' order by fechaemision desc ,numero desc")
        Return dt
    End Function

    Public Sub FacturaPagada(ByVal numero As Integer, ByVal condicion As String)
        AccesoDatos.Instancia.EjecutarConsulta("update venta set pagado=1 where numero= " & numero & " and CondicionVenta ='" & condicion & "'")
    End Sub
    Public Function TraerId(ByVal numero As Integer, ByVal condicion As String) As Integer
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select idventa from venta where numero = " & numero & " and condicionVenta ='" & condicion & "'")
        Return dt.Rows(0).Item(0)
    End Function
    Public Sub ingresarFactura(ByVal fac As Venta)
        Dim params As New List(Of MySqlParameter)
        Dim regComprobante As New RegistroComprobante

        regComprobante.AltaComprobante(fac)

        Dim num As New MySqlParameter("outNumero", 0)
        num.Direction = ParameterDirection.Output
        params.Add(num)
        params.Add(New MySqlParameter("inIdComprobante", fac.IdComprobante))
        params.Add(New MySqlParameter("inIdTipoVenta", fac.IdTipoVenta))
        params.Add(New MySqlParameter("inIdCliente", fac.IdCliente))
        params.Add(New MySqlParameter("inCondicionesVenta", fac.CondicionVenta))
        params.Add(New MySqlParameter("inHora", fac.Hora))
        params.Add(New MySqlParameter("inPagado", fac.Pagado))
        params.Add(New MySqlParameter("inNick", fac.Nick))
        params.Add(New MySqlParameter("inPorcentaje", fac.Porcentaje))
        params.Add(New MySqlParameter("inMontoTarjeta", fac.MontoTarjeta))
        params.Add(New MySqlParameter("inDescuento", fac.Descuento))
        AccesoDatos.Instancia.EjecutarComando("venta_insert", params)
        fac.Numero = num.Value

    End Sub

    Public Sub modificarFactura(ByVal fac As Venta)
        Dim params As New List(Of MySqlParameter)
        Dim regComprobante As New RegistroComprobante

        regComprobante.AltaComprobante(fac)
        params.Add(New MySqlParameter("inIdVenta", fac.IdVenta))
        params.Add(New MySqlParameter("inMontoTarjeta", fac.MontoTarjeta))
        params.Add(New MySqlParameter("inNick", fac.Nick))
        AccesoDatos.Instancia.EjecutarComando("venta_update", params)


    End Sub


    Public Sub ingresarFactura(ByVal fac As Venta, ByVal procedure As String)
        Dim params As New List(Of MySqlParameter)
        Dim regComprobante As New RegistroComprobante
        regComprobante.AltaComprobante(fac)
        params.Add(New MySqlParameter("inIdComprobante", fac.IdComprobante))
        params.Add(New MySqlParameter("inIdTipoVenta", fac.IdTipoVenta))
        params.Add(New MySqlParameter("inIdCliente", fac.IdCliente))
        params.Add(New MySqlParameter("inCondicionesVenta", fac.CondicionVenta))
        params.Add(New MySqlParameter("inHora", fac.Hora))
        params.Add(New MySqlParameter("inPagado", fac.Pagado))
        params.Add(New MySqlParameter("inNumero", fac.Numero))
        params.Add(New MySqlParameter("inNick", fac.Nick))
        params.Add(New MySqlParameter("inPorcentaje", fac.Porcentaje))
        AccesoDatos.Instancia.EjecutarComando(procedure, params)
    End Sub

    Public Sub ingresarNotaDeCredito(ByVal nota As NotaDeCredito)
        Dim params As New List(Of MySqlParameter)
        Dim regComprobante As New RegistroComprobante
        regComprobante.AltaComprobante(nota)
        params.Add(New MySqlParameter("inIdComprobante", nota.IdComprobante))
        params.Add(New MySqlParameter("inidVenta", nota.IdVenta))
        params.Add(New MySqlParameter("inIdTipoVenta", nota.IdTipoVenta))
        params.Add(New MySqlParameter("inIdCliente", nota.IdCliente))
        params.Add(New MySqlParameter("inCondicionesVenta", nota.CondicionVenta))
        params.Add(New MySqlParameter("inHora", nota.Hora))
        params.Add(New MySqlParameter("inNumeroFactura", nota.NumeroFactura))
        params.Add(New MySqlParameter("inNumero", nota.Numero))
        params.Add(New MySqlParameter("inNick", nota.Nick))
        AccesoDatos.Instancia.EjecutarComando("notadecredito_insert", params)
    End Sub
    Public Function SumarVentas(ByVal id As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select sum(comprobante.total) from comprobante inner join venta on venta.idcomprobante = comprobante.idcomprobante where venta.pagado = 0 and venta.idtipoventa =1 and venta.idcliente=" & id)
        Return dt
    End Function
    Public Function ChequearLimite(ByVal id As Integer) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select credito from cliente where idcliente=" & id)
        Return dt
    End Function
    Public Function TraerNotaDeCredito(ByVal numero As Integer, ByVal condicion As String) As NotaDeCredito
        Dim nota As New NotaDeCredito
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from notadecredito inner join comprobante on notadecredito.idComprobante = comprobante.idComprobante where numero = " & numero & " and condicionVenta ='" & condicion & "'")
        nota.IdVenta = dt.Rows(0).Item("idVenta")
        nota.IdComprobante = dt.Rows(0).Item("idComprobante")
        nota.IdCliente = dt.Rows(0).Item("idCliente")
        nota.CondicionVenta = dt.Rows(0).Item("condicionVenta")
        nota.Nick = dt.Rows(0).Item("nick")
        nota.Numero = dt.Rows(0).Item("numero")
        nota.Hora = dt.Rows(0).Item("hora")
        nota.NumeroFactura = dt.Rows(0).Item("numeroFactura")
        nota.IdTipoVenta = dt.Rows(0).Item("IdTipoVenta")
        nota.FechaEmision = dt.Rows(0).Item("fechaemision")
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from rengloncomprobante where idComprobante=" & nota.IdComprobante)
        Dim rc As RenglonComprobante
        Dim regArt As New RegistroArticulo
        For Each fila As DataRow In dt.Rows
            If fila("idArticulo") <> 0 Then
                rc = New RenglonComprobante(fila("preciounitario"), fila("cantidad"), regArt.traerArticuloPorId(fila("idArticulo")))
            Else
                rc = New RenglonComprobante
                rc.PrecioUnitario = fila("preciounitario")
                rc.Cantidad = fila("cantidad")
                rc.Descripcion = fila("descripcion")
            End If
            nota.Renglones.Add(rc)
        Next
        Return nota
    End Function
    Public Function TraerFactura(ByVal numero As Integer, ByVal condicion As String) As Venta
        Dim vta As New Venta
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from venta inner join comprobante on venta.idComprobante = comprobante.idComprobante where numero = " & numero & " and condicionVenta ='" & condicion & "'")
        vta.IdVenta = dt.Rows(0).Item("idVenta")
        vta.IdComprobante = dt.Rows(0).Item("idComprobante")
        vta.IdCliente = dt.Rows(0).Item("idCliente")
        vta.CondicionVenta = dt.Rows(0).Item("condicionVenta")
        vta.Nick = dt.Rows(0).Item("nick")
        vta.Numero = dt.Rows(0).Item("numero")
        vta.Hora = dt.Rows(0).Item("hora")
        vta.Pagado = dt.Rows(0).Item("pagado")
        vta.IdTipoVenta = dt.Rows(0).Item("IdTipoVenta")
        vta.Porcentaje = dt.Rows(0).Item("porcentajeTarjeta")
        vta.FechaEmision = dt.Rows(0).Item("fechaemision")
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from rengloncomprobante where idComprobante=" & vta.IdComprobante)
        Dim rc As RenglonComprobante
        Dim regArt As New RegistroArticulo
        For Each fila As DataRow In dt.Rows
            If fila("idArticulo") <> 0 And fila("descripcion").ToString.Contains("[") = False Then
                rc = New RenglonComprobante(fila("preciounitario"), fila("cantidad"), regArt.traerArticuloPorId(fila("idArticulo")))
            Else
                rc = New RenglonComprobante
                rc.PrecioUnitario = fila("preciounitario")
                rc.Cantidad = fila("cantidad")
                rc.Descripcion = fila("descripcion")
            End If
            vta.Renglones.Add(rc)
        Next
        Return vta
    End Function
    Public Function SumarLosPagos(ByVal id As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select sum(montopagado) from detctacte inner join venta on venta.idventa = detctacte.idventa where venta.idcliente= " & id & " and venta.pagado = 0 ")
    End Function

    Public Function TraerFacturas() As List(Of Venta)
        Dim vta As Venta
        Dim dt As DataTable
        Dim ventas As New List(Of Venta)
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from venta inner join comprobante on venta.idComprobante = comprobante.idComprobante where venta.condicionventa= 'X'")
        For Each dRow As DataRow In dt.Rows
            vta = New Venta

            vta.IdVenta = dt.Rows(0).Item("idVenta")
            vta.IdComprobante = dt.Rows(0).Item("idComprobante")
            vta.IdCliente = dt.Rows(0).Item("idCliente")
            vta.CondicionVenta = dt.Rows(0).Item("condicionVenta")
            vta.Nick = dt.Rows(0).Item("nick")
            vta.Numero = dt.Rows(0).Item("numero")
            vta.Hora = dt.Rows(0).Item("hora")
            vta.Pagado = dt.Rows(0).Item("pagado")
            vta.IdTipoVenta = dt.Rows(0).Item("IdTipoVenta")
            vta.Porcentaje = dt.Rows(0).Item("porcentajeTarjeta")
            vta.FechaEmision = dt.Rows(0).Item("fechaemision")
            ventas.Add(vta)

        Next
        Return ventas
    End Function

    Public Function TraerFacturasArchivadas() As List(Of FacturasArchivadas)
        Dim fa As FacturasArchivadas
        Dim facts As New List(Of FacturasArchivadas)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from facturasarchivadas")

        For Each dRow As DataRow In dt.Rows
            fa = New FacturasArchivadas

            fa.FechaDesde = dRow.Item("FechaInicio")
            fa.FechaHasta = dRow.Item("FechaFin")
            fa.IdFacturaArchivada = dRow.Item("IdFacturaArchivada")
            fa.NombreArchivo = dRow.Item("descripcion")
            fa.NombreTabla = dRow.Item("NombreTabla")

            facts.Add(fa)

        Next
        Return facts
    End Function


End Class
