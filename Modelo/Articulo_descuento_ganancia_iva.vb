

Public Class Articulo_descuento_ganancia_iva
    Private vIdArticulo As Integer
    Private vDescuento1 As Double
    Private vDescuento2 As Double
    Private vDescuento3 As Double
    Private vDescuento4 As Double
    Private vGanancia1 As Double
    Private vGanancia2 As Double
    Private vGanancia3 As Double
    Private vGanancia4 As Double
    Private vIVA As Double
    Private vPrecioListaProveedor As Double


    Public Property IdArticulo() As Integer
        Get
            Return vIdArticulo
        End Get
        Set(ByVal value As Integer)
            vIdArticulo = value
        End Set
    End Property
    Public Property Descuento1() As Double
        Get
            Return vDescuento1
        End Get
        Set(ByVal value As Double)
            vDescuento1 = value
        End Set
    End Property
    Public Property Descuento2() As Double
        Get
            Return vDescuento2
        End Get
        Set(ByVal value As Double)
            vDescuento2 = value
        End Set
    End Property
    Public Property Descuento3() As Double
        Get
            Return vDescuento3
        End Get
        Set(ByVal value As Double)
            vDescuento3 = value
        End Set
    End Property
    Public Property Descuento4() As Double
        Get
            Return vDescuento4
        End Get
        Set(ByVal value As Double)
            vDescuento4 = value
        End Set
    End Property

    Public Property Ganancia1() As Double
        Get
            Return vGanancia1
        End Get
        Set(ByVal value As Double)
            vGanancia1 = value
        End Set
    End Property
    Public Property Ganancia2() As Double
        Get
            Return vGanancia2
        End Get
        Set(ByVal value As Double)
            vGanancia2 = value
        End Set
    End Property
    Public Property Ganancia3() As Double
        Get
            Return vGanancia3
        End Get
        Set(ByVal value As Double)
            vGanancia3 = value
        End Set
    End Property
    Public Property Ganancia4() As Double
        Get
            Return vGanancia4
        End Get
        Set(ByVal value As Double)
            vGanancia4 = value
        End Set
    End Property


    Public Property IVA() As Double
        Get
            Return vIVA
        End Get
        Set(ByVal value As Double)
            vIVA = value
        End Set
    End Property
    Public Property PrecioListaProveedor() As Double
        Get
            Return vPrecioListaProveedor
        End Get
        Set(ByVal value As Double)
            vPrecioListaProveedor = Math.Round(value, 3)
        End Set
    End Property

End Class
