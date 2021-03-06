Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroComprobante
    Public Sub AltaComprobante(ByVal comp As Comprobante)
        Dim params As New List(Of MySqlParameter)
        Dim idComp As New MySqlParameter("outIdComprobante", 0)
        idComp.Direction = ParameterDirection.Output
        params.Add(idComp)
        params.Add(New MySqlParameter("inFechaEmision", comp.FechaEmision))

        If TypeOf comp Is Venta Then
            Dim vta As Venta
            vta = comp
            If vta.CondicionVenta = "A" Then
                params.Add(New MySqlParameter("inTotal", vta.TotalMasIVA))
            Else
                params.Add(New MySqlParameter("inTotal", comp.Total))
            End If
            params.Add(New MySqlParameter("inMontoTarjeta", vta.MontoTarjeta))
        Else
            params.Add(New MySqlParameter("inTotal", comp.Total))
        End If
        '' params.Add(New MySqlParameter("inTotal", comp.Total))

        AccesoDatos.Instancia.EjecutarComando("comprobante_insert", params)
        comp.IdComprobante = idComp.Value

        For Each r As RenglonComprobante In comp.Renglones
            params = New List(Of MySqlParameter)
            params.Add(New MySqlParameter("inIdComprobante", comp.IdComprobante))
            params.Add(New MySqlParameter("inPrecioUnitario", r.PrecioUnitario))
            params.Add(New MySqlParameter("inCantidad", r.Cantidad))
            If IsNothing(r.Articulo) = False Then
                params.Add(New MySqlParameter("inidArticulo", r.Articulo.IdArticulo))
            Else
                params.Add(New MySqlParameter("inidArticulo", 0))
            End If


            params.Add(New MySqlParameter("inDescripcion", r.Descripcion))
            AccesoDatos.Instancia.EjecutarComando("rengloncomprobante_insert", params)
        Next
    End Sub

End Class
