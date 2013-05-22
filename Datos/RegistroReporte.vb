Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroReporte
    Public Function ImpFac(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select cliente.nombre as Cliente, venta.nick as Vendedor, venta.idtipoventa , venta.condicionventa , venta.numero , comprobante.fechaemision , comprobante.total , rengloncomprobante.preciounitario as PU , rengloncomprobante.cantidad as Cantidad , rengloncomprobante.descripcion as Descripcion, venta.porcentajetarjeta from  cliente inner join venta on cliente.idcliente = venta.idcliente inner join comprobante on venta.idcomprobante = comprobante.idcomprobante inner join rengloncomprobante on rengloncomprobante.idcomprobante = comprobante.idcomprobante where venta.numero= " & numero & " and " & " venta.condicionventa= " & " '" & condicion & "'")
        Return Dt
    End Function
    Public Function ImpNot(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim Dt As DataTable
        Dt = AccesoDatos.Instancia.EjecutarConsulta("select cliente.nombre as Cliente, notadecredito.nick as Vendedor, notadecredito.idtipoventa , notadecredito.condicionventa , notadecredito.numero , comprobante.fechaemision , comprobante.total , rengloncomprobante.preciounitario as PU , rengloncomprobante.cantidad as Cantidad , rengloncomprobante.descripcion as Descripcion , venta.porcentajetarjeta from  cliente inner join notadecredito on cliente.idcliente = notadecredito.idcliente inner join comprobante on notadecredito.idcomprobante = comprobante.idcomprobante inner join rengloncomprobante on rengloncomprobante.idcomprobante = comprobante.idcomprobante where notadecredito.numero= " & numero & " and " & " notadecredito.condicionventa= " & " '" & condicion & "'")
        Return Dt
    End Function
End Class
