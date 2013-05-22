Imports Datos
Imports Modelo

Public Class FachadaMovimientoStock


    Public Sub guardarMovimientoStock(ByVal vta As Venta, ByVal destino As String, ByVal ack As Boolean)
        Dim rm As New RegistroMovimientoStock
        rm.guardarMovimientoStock(vta, destino, ack)
        Dim ra As New RegistroArticulo
        For Each rc As RenglonComprobante In vta.Renglones
            Dim art As Articulo
            art = rc.Articulo
            art.Stock = art.Stock - rc.Cantidad
            ra.modificarArticulo2(art)
        Next
    End Sub


    Public Sub RecibirStock(ByVal vta As Venta, ByVal destino As String, ByVal ack As Integer)

        If vta.CalcularCodigoMovimiento <> ack Then Throw New ACKInvalidoException

        Dim ra As New RegistroArticulo

        For Each rc As RenglonComprobante In vta.Renglones
            Dim art As Articulo
            art = rc.Articulo
            art.Stock = art.Stock + rc.Cantidad
            ra.modificarArticulo2(art)
        Next
    End Sub

    Public Function ListarMovimientosDeStock() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select * from movimientostock")
    End Function

    Public Function ListarDetallesMovimientoDeStock(ByVal idMovimiento As Integer) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select * from renglonmovimiento where idmovimiento = " & idMovimiento)
    End Function


    Public Sub ValidarRecepcion(ByVal idMovimiento As Integer, ByVal codigoAck As Integer)
        Dim vta As New Venta
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from renglonmovimiento where idmovimiento = " & idMovimiento)
        Dim art As Articulo
        Dim r As RenglonComprobante
        For Each fila As DataRow In dt.Rows
            art = New Articulo
            r = New RenglonComprobante
            art.IdArticulo = fila("idArticulo")
            r.Cantidad = fila("cantidad")
            r.Articulo = art
            vta.Renglones.Add(r)

        Next

        If vta.CalcularCodigoRecepcion() <> codigoAck Then
            Throw New ACKInvalidoException
        Else
            AccesoDatos.Instancia.EjecutarConsulta("update movimientostock set ack=1 where idmovimiento=" & idMovimiento)
        End If

    End Sub
End Class
