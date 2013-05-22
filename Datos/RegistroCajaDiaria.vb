Imports Modelo

Imports MySql.Data.MySqlClient

Public Class RegistroCajaDiaria
    Public Sub ModificarCajaDiaria(ByVal caja As CajaDiaria)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdCaja", caja.IdCajaDiaria))
        params.Add(New MySqlParameter("inSaldoInicio", caja.SaldoInicial))
        params.Add(New MySqlParameter("inTotalRetiro", caja.TotalRetiro))
        params.Add(New MySqlParameter("inTotalTarjeta", caja.TotalTarjeta))
        params.Add(New MySqlParameter("inTotalDeposito", caja.TotalDeposito))
        params.Add(New MySqlParameter("inCierre", caja.Cierre))
        params.Add(New MySqlParameter("inCerrada", 1))
        AccesoDatos.Instancia.EjecutarComando("cajadiaria_update", params)

    End Sub
    Public Function listarHistoricoCajaDiaria() As DataTable
        'SELECT idcaja, fecha, saldoinicio as apertura, totalretiro, totaldeposito, totaltarjeta, round(cierre - saldoinicio , 2) as 'totalefectivo', (totaltarjeta + (round(cierre - saldoinicio , 2))) as 'totalcaja', cierre, cerrada  FROM cajadiaria order by idcaja desc
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("SELECT idcaja, fecha, saldoinicio as apertura, totalretiro, totaldeposito, totaltarjeta, round(cierre - saldoinicio + totalRetiro - totalDeposito , 2) as 'totalefectivo', ((round(cierre - saldoinicio + totaltarjeta - totaldeposito + totalretiro , 2))) as 'totalcaja', cierre, cerrada  FROM cajadiaria order by idcaja desc")
        'la siguiente linea fue comentada por Frank
        'Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("SELECT idcaja, fecha, saldoinicio as apertura, totalretiro, totaldeposito, totaltarjeta, round(cierre -saldoinicio + totaltarjeta, 2) as 'totalefectivo', (totaltarjeta + (round(cierre -saldoinicio + totaltarjeta, 2))) as 'totalcaja', cierre, cerrada  FROM cajadiaria order by idcaja desc")
        Return dt
    End Function
    Public Function TraerSaldoInicial() As Double
        Dim strFecha As String
        ' strFecha = CStr(fecha.Year) & "-" & CStr(fecha.Month) & "-" & CStr(fecha.Day)
        'select max( cd.idcaja ), cd.cerrada,cd.fecha, cd.saldo, cd.saldofinal, cd.saldoinicio from cajadiaria cd
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select saldoinicio from CajaDiaria order by idcaja desc")
        'Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select max( cd.idcaja ), cd.cerrada,cd.fecha, cd.saldo, cd.saldofinal, cd.saldoinicio from cajadiaria cd where fecha= '" & strFecha & "'")
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMontoApertura() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select saldoinicio from CajaDiaria order by idcaja desc")
        Return dt.Rows(0).Item(0)
    End Function
    Public Function TraerMontoEfectivo() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(c.total -  montotarjeta) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja where es_final = 1)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMontoCuentaCorriente() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(c.total) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idTipoVenta = 1 and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerCantidadVentasConTajetas() As Integer
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select count(*) from venta where montotarjeta > 0 and idventa > (select max(nro_ultimo_ticket) from cierrecaja)")
        Return dt.Rows(0).Item(0)
    End Function



    Public Function TraerCantidadVentasConTarjetasEnCaja() As Integer
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select count(*) from venta where montotarjeta > 0 and idventa > (select max(nro_ultimo_ticket) from cierrecaja where es_final = 1)")
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMaxIdCajaDiaria() As Integer
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select max(idcaja) from cajadiaria")
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMaxIdOperacion() As Integer
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select max(idOperacionCaja) from operacioncaja")
        Return dt.Rows(0).Item(0)
    End Function
    Public Function TraerMontoEfectivoCajero() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(c.total -  montotarjeta) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerDepositosCaja() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(monto) from operacioncaja where operacion=1 and idOperacionCaja > (select max(id_ult_operacion) from cierrecaja where es_final = 1)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerDepositosCajero() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(monto) from operacioncaja where operacion=1 and idOperacionCaja > (select max(id_ult_operacion) from cierrecaja)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerExtraccionesCaja() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(monto) from operacioncaja where operacion=0 and idOperacionCaja > (select max(id_ult_operacion) from cierrecaja where es_final = 1)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerUltimaCaja() As CajaDiaria

        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select * from cajadiaria where idcaja = (select max(idcaja) from cajadiaria)")
        Dim fila As DataRow

        fila = dt.Rows(0)

        Dim caja As New CajaDiaria
        With caja
            .IdCajaDiaria = fila("idcaja")
            .Fecha = fila("fecha")
            .TotalTarjeta = fila("totaltarjeta")
            .SaldoInicial = fila("saldoinicio")
            .TotalRetiro = fila("totalretiro")
            If Not IsDBNull(fila("cierre")) Then .Cierre = fila("cierre")

        End With

        Return caja
    End Function

    Public Function TraerExtraccionesCajero() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(monto) from operacioncaja where operacion=0 and idOperacionCaja > (select max(id_ult_operacion) from cierrecaja)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function
    Public Function TraerMontoTarjeta() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(montotarjeta) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja where es_final = 1)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMontoTarjetaCajero() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(montotarjeta) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function

    Public Function TraerMontoTarjetaCaja() As Double
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select sum(montotarjeta) as 'Monto Efectivo' from venta v inner join comprobante c on v.idcomprobante = c.idcomprobante and v.idventa > (select max(nro_ultimo_ticket) from cierrecaja where es_final = 1)")
        If IsDBNull(dt.Rows(0).Item(0)) Then Return 0
        Return dt.Rows(0).Item(0)
    End Function
    Public Sub IngresarCaja(ByVal caja As CajaDiaria)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("infecha", caja.Fecha))
        params.Add(New MySqlParameter("inSaldoInicio", caja.SaldoInicial))
        AccesoDatos.Instancia.EjecutarComando("cajadiaria_insert", params)
    End Sub

    Public Sub MovimientoDeSaldo(ByVal valor As Double)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inValor", valor))
        AccesoDatos.Instancia.EjecutarComando("cajadiaria_movsaldo", params)
    End Sub

    Public Function EstaAbierta() As Boolean
        Dim strFecha As String
        ' strFecha = CStr(fecha.Year) & "-" & CStr(fecha.Month) & "-" & CStr(fecha.Day)
        'Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select * from CajaDiaria where fecha= '" & strFecha & "'")
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select cd.idcaja, cd.cerrada,cd.fecha from cajadiaria cd order by cd.idcaja desc")
        Dim fila As DataRow
        fila = dt.Rows(0)
        If fila Is Nothing Then Return False 'solo se ejecutara la primera vez, ya que no hay registros en la bd
        'reparar error
        If IsDBNull(fila("cerrada")) Then
            'si es nula es debido a que no se cerro una caja, verifico si tiene permiso, y si es asi
            'le pregunto si quiere cerrar la caja diaria
            Return False
        End If
        Dim cerrada As Boolean = fila("cerrada")
        'Dim cerrada As Boolean
        'cerrada = valor
        Return Not cerrada
    End Function

    Public Function EstaCerrada(ByVal fecha As Date) As Boolean
        Dim strFecha As String
        strFecha = CStr(fecha.Year) & "-" & CStr(fecha.Month) & "-" & CStr(fecha.Day)
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select cerrada from CajaDiaria where fecha= '" & strFecha & "'")
        If dt.Rows.Count = 0 Then Return True
        Return dt.Rows(0).Item(0)
    End Function

    Public Sub IngresarOperacion(ByVal ope As OperacionCaja)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inFecha", ope.Fecha))
        params.Add(New MySqlParameter("inOperacion", ope.Operacion))
        params.Add(New MySqlParameter("inDescripcion", ope.Descripcion))
        params.Add(New MySqlParameter("inMonto", ope.Monto))
        AccesoDatos.Instancia.EjecutarComando("operacioncaja_insert", params)
    End Sub
    Public Function ListarOperaciones() As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select fecha as Fecha,descripcion as Descripcion, operacion as Deposito,monto as Monto from OperacionCaja where idOperacionCaja > (select max(id_ult_operacion) from cierrecaja where es_final = 1)")
        Return dt
    End Function
    Public Function ListarFacturas() As DataTable
        'Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac',condicionVenta as Condicion,total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and idTipoVenta = 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )")

        Dim consulta As String
        'consulta = " select * from "
        'consulta += "(Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','T' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta > 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 ) "
        'consulta += "union Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','E' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta = 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )) as vtas order by vtas.Hora "
        consulta = " select * from "
        consulta += "(Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','T' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montoTarjeta = total  and montotarjeta > 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )"
        consulta += " union "
        consulta += " Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','E' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta = 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )"
        consulta += " union "
        consulta += "Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','M' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta > 0 and montotarjeta < total and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )) as vtas order by vtas.Hora "

        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta(consulta)
        Return dt
    End Function

    Public Function ListarOperaciones(ByVal idOpDesde As Integer, ByVal idOpHasta As Integer) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select fecha as Fecha,descripcion as Descripcion, operacion as Deposito,monto as Monto from OperacionCaja where idOperacionCaja > " & CStr(idOpDesde) & "  and idOperacionCaja <= " & CStr(idOpHasta))
        Return dt
    End Function
    Public Function ListarFacturas(ByVal numDesde As Integer, ByVal numHasta As Integer) As DataTable
        'Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac',condicionVenta as Condicion,total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and idTipoVenta = 0 and v.idventa > ( select max(nro_ultimo_ticket) from cierrecaja where es_final = 1 )")

        Dim consulta As String
        'consulta = " select * from "
        'consulta += "(Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','T' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta > 0 and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta)
        'consulta += " union Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','E' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta = 0 and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta) & ") as vtas order by vtas.Hora "


        consulta = " select * from "
        consulta += "(Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','T' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montoTarjeta = total  and montotarjeta > 0 and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta)
        consulta += " union "
        consulta += " Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','E' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta = 0 and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta)
        consulta += " union "
        consulta += "Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','M' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and montotarjeta > 0 and montotarjeta < total and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta) & " ) as vtas order by vtas.Hora "

        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta(consulta)
        Return dt
    End Function

    Public Function ListarFacturasCaja(ByVal idVtaInicial As Integer, ByVal idVtaFinal As Integer) As DataTable
        Dim consulta As String
        consulta = " Select DATE_FORMAT(hora,'%T') as Hora,numero as 'N Fac','E' as 'Pago',total as Total from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and v.idventa > " & CStr(idVtaInicial) & " and v.idventa < " & CStr(idVtaFinal)
        Return AccesoDatos.Instancia.EjecutarConsulta(consulta)
    End Function


    Public Function TraerTotalVentasEfectivo(ByVal numDesde As Integer, ByVal numHasta As Integer) As Double
        Dim consulta As String
        consulta = "Select sum(total - montotarjeta) as 'Efectivo' from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta)
        Dim fila As DataRow
        fila = AccesoDatos.Instancia.EjecutarConsulta(consulta).Rows(0)
        If IsDBNull(fila(0)) Then Return 0
        Return CDbl(fila(0))
    End Function


    Public Function TraerTotalVentasTarjeta(ByVal numDesde As Integer, ByVal numHasta As Integer) As Double
        Dim consulta As String
        consulta = "select sum(montotarjeta) as 'Tarjeta' from venta v inner join comprobante c on c.idcomprobante = v.idcomprobante where condicionVenta <> 'P' and v.idventa > " & CStr(numDesde) & " and v.idventa < " & CStr(numHasta)
        Dim fila As DataRow
        fila = AccesoDatos.Instancia.EjecutarConsulta(consulta).Rows(0)
        If IsDBNull(fila(0)) Then Return 0
        Return CDbl(fila(0))
    End Function

End Class
