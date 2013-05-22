Public Class CajaDiaria
    Private vIdCajaDiaria As Integer
    Private vFecha As Date
    Private vSaldoInicio As Double
    Private vTotalRetiro As Double
    Private vCierre As Double
    Private vTotalTarjeta As Double
    Private vTotalDeposito As Double

    Public Property IdCajaDiaria() As Integer
        Get
            Return vIdCajaDiaria
        End Get
        Set(ByVal value As Integer)
            vIdCajaDiaria = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return vFecha
        End Get
        Set(ByVal value As Date)
            vFecha = value
        End Set
    End Property
    Public Property SaldoInicial() As Double
        Get
            Return vSaldoInicio
        End Get
        Set(ByVal value As Double)
            vSaldoInicio = value
        End Set
    End Property
    Public Property TotalRetiro() As Double
        Get
            Return vTotalRetiro
        End Get
        Set(ByVal value As Double)
            vTotalRetiro = value
        End Set
    End Property
    Public Property TotalDeposito() As Double
        Get
            Return vTotalDeposito
        End Get
        Set(ByVal value As Double)
            vTotalDeposito = value
        End Set
    End Property
    Public Property TotalTarjeta() As Double
        Get
            Return vTotalTarjeta
        End Get
        Set(ByVal value As Double)
            vTotalTarjeta = value
        End Set
    End Property
    Public Property Cierre() As Double
        Get
            Return vCierre
        End Get
        Set(ByVal value As Double)
            vCierre = value
        End Set
    End Property

End Class
