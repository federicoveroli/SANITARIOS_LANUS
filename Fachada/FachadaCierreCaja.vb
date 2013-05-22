Imports Modelo
Imports Datos
Public Class FachadaCierreCaja
    Public Sub AltaCierreCaja(ByVal cierrecaja As CierreCaja)
        Dim regCierreCaja As New RegistroCiereCaja

        If cierrecaja.EfvoReal <> cierrecaja.EfvoEstimado Then
            Dim ope As New OperacionCaja
            Dim regCaja As New RegistroCajaDiaria
            ope.Descripcion = "Dif. de Caja  ( " & cierrecaja.EfvoEstimado - cierrecaja.EfvoReal & ")  "
            Dim detalle As String = ""
            detalle = InputBox("Si lo desea ingrese un comentario acerca del arqueo de caja", "Ingrese un comentario")
            If detalle.Length > 0 Then
                ope.Descripcion += " - " + detalle
            End If
            ope.Fecha = Now
            ope.Operacion = Not (cierrecaja.EfvoReal < cierrecaja.EfvoEstimado)
            'If cierrecaja.EfvoReal < cierrecaja.EfvoEstimado Then
            '    ope.Operacion = False
            'Else
            '    ope.Operacion = True
            'End If
            ope.Monto = 0 'Math.Abs(cierrecaja.EfvoEstimado - cierrecaja.EfvoReal)
            regCaja.IngresarOperacion(ope)
        End If

        regCierreCaja.ingresarCierreCaja(cierrecaja)

    End Sub
    Public Function TraerUltimoCierreCaja() As CierreCaja
        Dim regCC As New RegistroCiereCaja
        Return regCC.TraerUltimoCierre()
    End Function

    Public Function TraerCierreCaja(ByVal idCaja As Integer) As DataTable
        Dim regCC As New RegistroCiereCaja
        Return regCC.TraerCierreCaja(idCaja)
    End Function

    Public Function TraerCierreCajaPorId(ByVal idCierre As Integer) As CierreCaja
        Dim regCC As New RegistroCiereCaja
        Return regCC.TraerCierreCajaPorId(idCierre)
    End Function

    Public Function TrearVentasPorCierre(ByVal cierre As CierreCaja) As DataTable
        Dim regCC As New RegistroCiereCaja
        Dim regCD As New RegistroCajaDiaria
        Dim cierreAnterior As CierreCaja
        cierreAnterior = regCC.TraerCierreCajaPorId(cierre.IdCierreCaja - 1)
        Return regCD.ListarFacturas(cierreAnterior.NroUltimoTicket, cierre.NroUltimoTicket + 1)

    End Function
    Public Function TraerOperacionesPorCierre(ByVal cierre As CierreCaja) As DataTable
        Dim regCC As New RegistroCiereCaja
        Dim regCD As New RegistroCajaDiaria
        Dim cierreAnterior As CierreCaja
        cierreAnterior = regCC.TraerCierreCajaPorId(cierre.IdCierreCaja - 1)
        Return regCD.ListarOperaciones(cierreAnterior.IdUltOperacion, cierre.IdUltOperacion)

    End Function

    Public Function TraerTotalVentasEfectivo(ByVal cierre As CierreCaja) As Double

        Dim regCC As New RegistroCiereCaja
        Dim regCD As New RegistroCajaDiaria
        Dim cierreAnterior As CierreCaja
        cierreAnterior = regCC.TraerCierreCajaPorId(cierre.IdCierreCaja - 1)
        Return regCD.TraerTotalVentasEfectivo(cierreAnterior.NroUltimoTicket, cierre.NroUltimoTicket + 1)
    End Function

    Public Function TraerTotalVentasTarjeta(ByVal cierre As CierreCaja) As Double

        Dim regCC As New RegistroCiereCaja
        Dim regCD As New RegistroCajaDiaria
        Dim cierreAnterior As CierreCaja
        cierreAnterior = regCC.TraerCierreCajaPorId(cierre.IdCierreCaja - 1)
        Return regCD.TraerTotalVentasTarjeta(cierreAnterior.NroUltimoTicket, cierre.NroUltimoTicket + 1)
    End Function
End Class
