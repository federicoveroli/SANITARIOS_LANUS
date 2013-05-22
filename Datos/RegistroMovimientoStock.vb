Imports Modelo
Imports MySql.Data.MySqlClient


Public Class RegistroMovimientoStock
    Public Sub guardarMovimientoStock(ByVal vta As Venta, ByVal destino As String, ByVal ack As Boolean)
        AccesoDatos.Instancia.IniciarTransaccion()
        Dim params As New List(Of MySqlParameter)
        Dim num As New MySqlParameter("outNumero", 0)
        num.Direction = ParameterDirection.Output
        params.Add(num)
        params.Add(New MySqlParameter("vFecha", Now))
        params.Add(New MySqlParameter("vDestino", destino))
        params.Add(New MySqlParameter("vAck", ack))
        params.Add(New MySqlParameter("vTotal", vta.Total))
        params.Add(New MySqlParameter("vVendedor", vta.Nick))
        AccesoDatos.Instancia.EjecutarComando("movimientostock_insert", params)

        For Each rc As RenglonComprobante In vta.Renglones
            params = New List(Of MySqlParameter)
            params.Add(New MySqlParameter("vidMovimiento", num.Value))
            params.Add(New MySqlParameter("vidArticulo", rc.Articulo.IdArticulo))
            params.Add(New MySqlParameter("vdescripcionArt", rc.Descripcion))
            params.Add(New MySqlParameter("vcodbar", rc.Articulo.CodBarra))
            params.Add(New MySqlParameter("vcantidad", rc.Cantidad))
            params.Add(New MySqlParameter("vpu", rc.PrecioUnitario))
            params.Add(New MySqlParameter("vsubtotal", rc.SubTotal))
            AccesoDatos.Instancia.EjecutarComando("renglonmovimiento_insert", params)
        Next

        AccesoDatos.Instancia.ConfirmarTransaccion()
    End Sub
End Class
