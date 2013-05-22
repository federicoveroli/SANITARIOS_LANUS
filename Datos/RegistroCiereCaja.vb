Imports Modelo

Imports MySql.Data.MySqlClient

Public Class RegistroCiereCaja
    Public Sub ingresarCierreCaja(ByVal cierrecaja As CierreCaja)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("efvo_real", cierrecaja.EfvoReal))
        params.Add(New MySqlParameter("efvo_estimado", cierrecaja.EfvoEstimado))
        params.Add(New MySqlParameter("cant_tarjeta_real", cierrecaja.CantTarjetaReal))
        params.Add(New MySqlParameter("cant_tarjeta_estimado", cierrecaja.CantTarjetaEstimado))
        params.Add(New MySqlParameter("total_tarjeta_real", cierrecaja.TotalTarjetaReal))
        params.Add(New MySqlParameter("total_tarjeta_estimado", cierrecaja.TotalTarjetaEstimado))
        params.Add(New MySqlParameter("total_caja_real", cierrecaja.TotalCajaReal))
        params.Add(New MySqlParameter("total_caja_estimado", cierrecaja.TotalCajaEstimado))
        params.Add(New MySqlParameter("nro_ultimo_ticket", cierrecaja.NroUltimoTicket))
        params.Add(New MySqlParameter("fecha", cierrecaja.Fecha))
        params.Add(New MySqlParameter("hora", cierrecaja.Hora))
        params.Add(New MySqlParameter("es_final", cierrecaja.EsFinal))
        params.Add(New MySqlParameter("id_ult_operacion", cierrecaja.IdUltOperacion))
        params.Add(New MySqlParameter("id_caja_diaria", cierrecaja.IdCajaDiaria))
        params.Add(New MySqlParameter("nick_us", cierrecaja.NickUsuario))
        AccesoDatos.Instancia.EjecutarComando("cierrecaja_insert", params)
    End Sub

    Public Function TraerUltimoCierre() As CierreCaja
        Dim cierre As New CierreCaja
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from cierrecaja order by idcierrecaja desc")
        Dim fila As DataRow
        fila = dt.Rows(0)

        With cierre
            .EfvoReal = fila("efvo_real")
            .EfvoEstimado = fila("efvo_estimado")
            .CantTarjetaReal = fila("cant_tarjeta_real")
            .CantTarjetaEstimado = fila("cant_tarjeta_estimado")
            .TotalTarjetaEstimado = fila("total_tarjeta_estimado")
            .TotalTarjetaReal = fila("total_tarjeta_real")
            .TotalCajaReal = fila("total_caja_real")
            .TotalCajaEstimado = fila("total_caja_estimado")
            .NroUltimoTicket = fila("nro_ultimo_ticket")
            .Fecha = fila("fecha")
            .Hora = fila("hora").ToString()
            .EsFinal = fila("Es_Final")
            .IdUltOperacion = fila("id_ult_operacion")
            .IdCajaDiaria = fila("id_caja_diaria")
            .IdCierreCaja = fila("IdCierreCaja")
            .NickUsuario = fila("nick_us")
        End With

        Return cierre
    End Function


    Public Function TraerCierre(ByVal idCierre As Integer) As CierreCaja
        Dim cierre As New CierreCaja
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from cierrecaja where idCierre= " & CStr(idCierre) & " order by idcierrecaja desc")
        Dim fila As DataRow
        fila = dt.Rows(0)

        With cierre
            .EfvoReal = fila("efvo_real")
            .EfvoEstimado = fila("efvo_estimado")
            .CantTarjetaReal = fila("cant_tarjeta_real")
            .CantTarjetaEstimado = fila("cant_tarjeta_estimado")
            .TotalTarjetaEstimado = fila("total_tarjeta_estimado")
            .TotalTarjetaReal = fila("total_tarjeta_real")
            .TotalCajaReal = fila("total_caja_real")
            .TotalCajaEstimado = fila("total_caja_estimado")
            .NroUltimoTicket = fila("nro_ultimo_ticket")
            .Fecha = fila("fecha")
            .Hora = fila("hora").ToString()
            .EsFinal = fila("Es_Final")
            .IdUltOperacion = fila("id_ult_operacion")
            .IdCajaDiaria = fila("id_caja_diaria")
            .IdCierreCaja = fila("IdCierreCaja")
            .NickUsuario = fila("nick_us")
        End With

        Return cierre
    End Function

    Public Function TraerCierreCaja(ByVal idCaja As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select * from cierrecaja where id_caja_diaria =" & CStr(idCaja))
    End Function

    Public Function TraerCierreCajaPorId(ByVal idCierre As Integer) As CierreCaja
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from cierrecaja where idCierreCaja =" & CStr(idCierre))
        Dim fila As DataRow
        Dim cierre As New CierreCaja
        fila = dt.Rows(0)

        With cierre
            .EfvoReal = fila("efvo_real")
            .EfvoEstimado = fila("efvo_estimado")
            .CantTarjetaReal = fila("cant_tarjeta_real")
            .CantTarjetaEstimado = fila("cant_tarjeta_estimado")
            .TotalTarjetaEstimado = fila("total_tarjeta_estimado")
            .TotalTarjetaReal = fila("total_tarjeta_real")
            .TotalCajaReal = fila("total_caja_real")
            .TotalCajaEstimado = fila("total_caja_estimado")
            .NroUltimoTicket = fila("nro_ultimo_ticket")
            .Fecha = fila("fecha")
            .Hora = fila("hora").ToString()
            .EsFinal = fila("Es_Final")
            .IdUltOperacion = fila("id_ult_operacion")
            .IdCajaDiaria = fila("id_caja_diaria")
            .IdCierreCaja = fila("IdCierreCaja")
            .NickUsuario = fila("nick_us")
        End With

        Return cierre

    End Function
End Class
