Public Class CierreCaja
    Private vEsFinal As Boolean
    Private vIdCierreCaja As Integer
    Private vEfvoReal As Double
    Private vEfvoEstimado As Double
    Private vCantTarjetaReal As Integer
    Private vCantTarjetaEstimado As Integer
    Private vTotalTarjetaReal As Double
    Private vTotalTarjetaEstimado As Double
    Private vTotalCajaReal As Double
    Private vTotalCajaEstimado As Double
    Private vNroUltimoTicket As Integer
    Private vFecha As Date
    Private vHora As String
    Private vIdUltOperacion As Integer
    Private vIdCajaDiaria As Integer
    Private vNickUsuario As String

    Public Property NickUsuario() As String
        Get
            Return vNickUsuario
        End Get
        Set(ByVal value As String)
            vNickUsuario = value
        End Set
    End Property

    Public Property IdCajaDiaria() As Integer
        Get
            Return vIdCajaDiaria
        End Get
        Set(ByVal value As Integer)
            vIdCajaDiaria = value
        End Set
    End Property

    Public Property IdUltOperacion() As Integer
        Get
            Return vIdUltOperacion
        End Get
        Set(ByVal value As Integer)
            vIdUltOperacion = value
        End Set
    End Property

    Public Property IdCierreCaja() As Integer
        Get
            Return vIdCierreCaja
        End Get
        Set(ByVal value As Integer)
            vIdCierreCaja = value
        End Set
    End Property
    Public Property EfvoReal() As Double
        Get
            Return vEfvoReal
        End Get
        Set(ByVal value As Double)
            vEfvoReal = value
        End Set
    End Property
    Public Property EsFinal() As Boolean
        Get
            Return vEsFinal
        End Get
        Set(ByVal value As Boolean)
            vEsFinal = value
        End Set
    End Property
    Public Property EfvoEstimado() As Double
        Get
            Return vEfvoEstimado
        End Get
        Set(ByVal value As Double)
            vEfvoEstimado = value
        End Set
    End Property
    Public Property CantTarjetaReal() As Integer
        Get
            Return vCantTarjetaReal
        End Get
        Set(ByVal value As Integer)
            vCantTarjetaReal = value
        End Set
    End Property
    Public Property CantTarjetaEstimado() As Integer
        Get
            Return vCantTarjetaEstimado
        End Get
        Set(ByVal value As Integer)
            vCantTarjetaEstimado = value
        End Set
    End Property
    Public Property TotalTarjetaReal() As Double
        Get
            Return vTotalTarjetaReal
        End Get
        Set(ByVal value As Double)
            vTotalTarjetaReal = value
        End Set
    End Property
    Public Property TotalTarjetaEstimado() As Double
        Get
            Return vTotalTarjetaEstimado
        End Get
        Set(ByVal value As Double)
            vTotalTarjetaEstimado = value
        End Set
    End Property
    Public Property TotalCajaReal() As Double
        Get
            Return vTotalCajaReal
        End Get
        Set(ByVal value As Double)
            vTotalCajaReal = value
        End Set
    End Property
    Public Property TotalCajaEstimado() As Double
        Get
            Return vTotalCajaEstimado
        End Get
        Set(ByVal value As Double)
            vTotalCajaEstimado = value
        End Set
    End Property
    Public Property NroUltimoTicket() As Integer
        Get
            Return vNroUltimoTicket
        End Get
        Set(ByVal value As Integer)
            vNroUltimoTicket = value
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
    Public Property Hora() As String
        Get
            Return vHora
        End Get
        Set(ByVal value As String)
            vHora = value
        End Set
    End Property

End Class
