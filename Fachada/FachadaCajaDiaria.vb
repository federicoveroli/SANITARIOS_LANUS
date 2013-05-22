Imports Modelo
Imports Datos

Public Class FachadaCajaDiaria
    Public Function TraerSaldoInicial() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerSaldoInicial()
    End Function
    Public Function TrearVentasPorCaja() As DataTable

    End Function
    Public Function TraerOperacionesPorCaja() As DataTable

    End Function
    Public Function TraerUltimaCaja() As CajaDiaria
        Dim regCaja As New RegistroCajaDiaria

        Return regCaja.TraerUltimaCaja()
    End Function
    Public Function TraerRecaudacionEfectivoCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Dim montoEfectivo As Double, deposito As Double, extraccion As Double, recaudacion As Double, montoCuentaCorriente As Double
        montoEfectivo = regCaja.TraerMontoEfectivo
        deposito = regCaja.TraerDepositosCaja
        extraccion = regCaja.TraerExtraccionesCaja
        montoCuentaCorriente = regCaja.TraerMontoCuentaCorriente()
        recaudacion = montoEfectivo + deposito - extraccion - montoCuentaCorriente

        Return recaudacion
    End Function



    Public Function TraerVentasEfectivoCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Dim montoEfectivo As Double ', deposito As Double, extraccion As Double, recaudacion As Double
        montoEfectivo = regCaja.TraerMontoEfectivoCajero
        'deposito = regCaja.TraerDepositosCaja
        'extraccion = regCaja.TraerExtraccionesCaja
        'recaudacion = montoEfectivo + deposito - extraccion

        Return montoEfectivo
    End Function

    Public Function TraerRecaudacionEfectivoEnCaja() As Double
        Dim regCaja As New RegistroCajaDiaria
        Dim montoEfectivo As Double, deposito As Double, extraccion As Double, recaudacion As Double, cuentaCorriente As Double
        montoEfectivo = regCaja.TraerMontoEfectivo
        deposito = regCaja.TraerDepositosCaja
        extraccion = regCaja.TraerExtraccionesCaja
        cuentaCorriente = regCaja.TraerMontoCuentaCorriente()
        recaudacion = montoEfectivo + deposito - extraccion - cuentaCorriente

        Return recaudacion
    End Function

    Public Function CalcularSaldoFinal() As Double
        Dim regCaja As New RegistroCajaDiaria
        Dim montoEfectivo As Double, montoTarjeta As Double
        montoEfectivo = regCaja.TraerMontoEfectivo
        montoTarjeta = regCaja.TraerMontoTarjeta
        Return montoEfectivo + montoTarjeta
    End Function

    Public Function TraerVentasConEfectivo() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoEfectivo
    End Function

    Public Function TraerVentasConTarjeta() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoTarjeta
    End Function

    Public Function TraerVentasConTarjetaCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoTarjetaCajero
    End Function

    Public Function TraerMontoApertura() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoApertura()
    End Function

    Public Function TraerDepositosCaja() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerDepositosCaja
    End Function


    Public Function TraerExtraccionesCaja() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerExtraccionesCaja
    End Function

    Public Function TraerRecaudacionTarjetasCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoTarjetaCajero
    End Function

    Public Function TraerRecaudacionTarjetasEnCaja() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMontoTarjetaCaja
    End Function

    Public Function TraerCantidadVentasConTarjeta() As Integer
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerCantidadVentasConTajetas
    End Function
    Public Function TraerCantidadVentasConTarjetaEnCaja() As Integer
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerCantidadVentasConTarjetasEnCaja
    End Function

    Public Function MaxID() As Integer
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMaxIdCajaDiaria
    End Function

    Public Function MaxIDOperacion() As Integer
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerMaxIdOperacion
    End Function

    Public Function TraerDepositosCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerDepositosCajero
    End Function


    Public Function TraerExtraccionesCajero() As Double
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.TraerExtraccionesCajero
    End Function
    Public Function listarHistoricoCajaDiaria() As DataTable
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.listarHistoricoCajaDiaria
    End Function
    Public Sub AbrirCajaDiaria(ByVal Caja As CajaDiaria)
        Dim regCaja As New RegistroCajaDiaria
        regCaja.IngresarCaja(Caja)
    End Sub
    Public Sub MovimientoDeSaldo(ByVal valor As Double)
        Dim regCaja As New RegistroCajaDiaria
        regCaja.MovimientoDeSaldo(valor)
    End Sub
    Public Function estaAbierta()
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.EstaAbierta()
    End Function
    Public Function estaCerrada(ByVal fecha As Date)
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.estaCerrada(fecha)
    End Function
    Public Sub CerrarCaja(ByVal caja As CajaDiaria)
        Dim regCaja As New RegistroCajaDiaria
        'sumo todos los importes ingresados por ventas
        'y las cantidad de depositos, y le resto las extraciones
        regCaja.ModificarCajaDiaria(caja)
    End Sub
    Public Sub RealizarOperacion(ByVal ope As OperacionCaja)
        Dim regCaja As New RegistroCajaDiaria
        regCaja.IngresarOperacion(ope)
    End Sub
    Public Function ListarOperaciones() As DataTable
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.ListarOperaciones()
    End Function
    Public Function ListarFacturas() As DataTable
        Dim regCaja As New RegistroCajaDiaria
        Return regCaja.ListarFacturas()
    End Function

 
End Class
