Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroCompra
    Public Sub ingresarCompra(ByVal comp As Compra)
        Dim params As New List(Of MySqlParameter)
        Dim regComprobante As New RegistroComprobante
        AccesoDatos.Instancia.IniciarTransaccion()
        regComprobante.AltaComprobante(comp)
        params.Add(New MySqlParameter("inIdComprobante", comp.IdComprobante))
        params.Add(New MySqlParameter("inIdProveedor", comp.IdProveedor))
        AccesoDatos.Instancia.EjecutarComando("compra_insert", params)
        AccesoDatos.Instancia.ConfirmarTransaccion()
    End Sub
    Public Sub eliminarCompra(ByVal idCompra As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdCompra", idCompra))
        AccesoDatos.Instancia.EjecutarComando("compra_delete", params)
    End Sub
    Public Function ListarCompras() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("Select c.idcompra, p.`razonsocial`,co.`fechaemision`, co.total from compra c inner join comprobante co on c.idComprobante = co.idComprobante inner join proveedor p on p.idproveedor=c.`idproveedor`")
    End Function
    Public Function ListarCompras(ByVal idProveedor As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("Select c.idcompra,p.`razonsocial`,co.`fechaemision`, co.total from compra c inner join comprobante co on c.idComprobante = co.idComprobante inner join proveedor p on p.idproveedor=c.`idproveedor` where p.idProveedor = " & idProveedor)
    End Function
    Public Function ListarCompras(ByVal idProveedor As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim fechaDesdeSTR As String, fechaHastaSTR As String
        fechaDesdeSTR = CStr(fechaDesde.Year) & "-" & CStr(fechaDesde.Month) & "-" & CStr(fechaDesde.Day)
        fechaHastaSTR = CStr(fechaHasta.Year) & "-" & CStr(fechaHasta.Month) & "-" & CStr(fechaHasta.Day)
        Return AccesoDatos.Instancia.EjecutarConsulta("Select c.idcompra,p.`razonsocial`,co.`fechaemision`, co.total from compra c inner join comprobante co on c.idComprobante = co.idComprobante inner join Proveedor p on c.idproveedor = p.idproveedor where fechaemision > '" & fechaDesdeSTR & "' and fechaemision < '" & fechaHastaSTR & "' and p.idProveedor = " & idProveedor)
    End Function
    Public Function ListarCompras(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim fechaDesdeSTR As String, fechaHastaSTR As String
        fechaDesdeSTR = CStr(fechaDesde.Year) & "-" & CStr(fechaDesde.Month) & "-" & CStr(fechaDesde.Day)
        fechaHastaSTR = CStr(fechaHasta.Year) & "-" & CStr(fechaHasta.Month) & "-" & CStr(fechaHasta.Day)
        Return AccesoDatos.Instancia.EjecutarConsulta("Select c.idcompra,p.`razonsocial`,co.`fechaemision`, co.total from compra c inner join comprobante co on c.idComprobante = co.idComprobante inner join Proveedor p on c.idproveedor = p.idproveedor where fechaemision > '" & fechaDesdeSTR & "' and fechaemision < '" & fechaHastaSTR & "'")
    End Function
    Public Function Traercompra(ByVal idCompra) As Compra
        Dim c As New Compra
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from compra c inner join comprobante co on c.idComprobante = co.idComprobante where idCompra=" & idCompra)
        c.IdCompra = idCompra
        c.IdComprobante = dt.Rows(0).Item("idComprobante")
        c.IdProveedor = dt.Rows(0).Item("idProveedor")
        c.FechaEmision = dt.Rows(0).Item("fechaemision")
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from rengloncomprobante where idComprobante=" & c.IdComprobante)
        Dim rc As RenglonComprobante
        Dim regArt As New RegistroArticulo
        For Each fila As DataRow In dt.Rows

            rc = New RenglonComprobante(fila("preciounitario"), fila("cantidad"), regArt.traerArticuloPorId(fila("idArticulo")))
            c.Renglones.Add(rc)
        Next
        Return c

    End Function
End Class

