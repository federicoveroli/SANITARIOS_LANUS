Public Class Venta
    Inherits Comprobante

    Private vIdCliente As Integer
    Private vIdVendedor As Integer
    Private vIdTipoVenta As Boolean
    Private vIdVenta As Integer
    Private vCondicionVenta As String
    Private vHora As DateTime
    Private vNumero As Integer
    Private vPagado As Boolean
    Private vNick As String
    Private vPorcentaje As Double
    Private vMontoTarjeta As Double
    Private vDescuento As Double

    'la condicion de venta es el tipo de factura ABXPN
    'el numero de factura, remito,

    Public Property Porcentaje() As Double
        Get
            Return vPorcentaje
        End Get
        Set(ByVal value As Double)
            vPorcentaje = value
        End Set
    End Property

    Public Property MontoTarjeta() As Double
        Get
            Return vMontoTarjeta
        End Get
        Set(ByVal value As Double)
            vMontoTarjeta = value
        End Set
    End Property

    Public Property Numero() As Integer
        Get
            Return vNumero
        End Get
        Set(ByVal value As Integer)
            vNumero = value
        End Set
    End Property
    Public Property Nick() As String
        Get
            Return vNick
        End Get
        Set(ByVal value As String)
            vNick = value
        End Set
    End Property
    Public Property IdCliente() As Integer
        Get
            Return vIdCliente
        End Get
        Set(ByVal value As Integer)
            vIdCliente = value
        End Set
    End Property

    Public Property IdTipoVenta() As Boolean
        Get
            Return vIdTipoVenta
        End Get
        Set(ByVal value As Boolean)
            vIdTipoVenta = value
        End Set
    End Property

    Public Property IdVenta() As Integer
        Get
            Return vIdVenta
        End Get
        Set(ByVal value As Integer)
            vIdVenta = value
        End Set
    End Property

    Public Property CondicionVenta() As String
        Get
            Return vCondicionVenta
        End Get
        Set(ByVal value As String)
            vCondicionVenta = value
        End Set
    End Property

    Public Property Hora() As DateTime
        Get
            Return vHora
        End Get
        Set(ByVal value As DateTime)
            vHora = value
        End Set
    End Property

    Public Property Pagado() As Boolean
        Get
            Return vPagado
        End Get
        Set(ByVal value As Boolean)
            vPagado = value
        End Set
    End Property

    Public Property Descuento() As Double
        Get
            Return vDescuento
        End Get
        Set(ByVal value As Double)
            vDescuento = value
        End Set
    End Property
    Public Overrides ReadOnly Property Total() As Double
        Get
            Return MyBase.Total - vDescuento
        End Get
    End Property

    Public Function CalcularCodigoMovimiento() As Integer
        Dim codigo As Integer = 0
        For Each r As RenglonComprobante In Me.Renglones
            codigo += r.Articulo.IdArticulo
            codigo += r.Cantidad
        Next
        Dim fechaHoy As Date
        fechaHoy = Now
        codigo += fechaHoy.Year
        codigo += fechaHoy.Day
        codigo += fechaHoy.Month
        Return codigo
    End Function

    Public Function CalcularCodigoRecepcion() As Integer
        Dim codigo As Integer = 0
        For Each r As RenglonComprobante In Me.Renglones
            codigo += r.Articulo.IdArticulo
            codigo += r.Cantidad
        Next
        Dim fechaHoy As Date
        fechaHoy = Now
        codigo -= fechaHoy.Year
        codigo -= fechaHoy.Day
        codigo -= fechaHoy.Month
        Return codigo
    End Function
End Class
