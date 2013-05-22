Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroPago
    Public Sub InsertarPago(ByVal p As Pago)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("innumfac", p.NumFac))
        params.Add(New MySqlParameter("infecha", p.Fecha))
        params.Add(New MySqlParameter("inpago", p.Pago))
        AccesoDatos.Instancia.EjecutarComando("pago_insert", params)
    End Sub
End Class
