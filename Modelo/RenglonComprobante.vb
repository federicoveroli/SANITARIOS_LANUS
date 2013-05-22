Public Class RenglonComprobante

    Private vPrecioUnitario As Double
    Private vCantidad As Double
    Private vArticulo As Articulo
    Private vDescripcion As String
    Private vCantADisminuir As Integer

    Public Property PrecioUnitario() As Double
        Get
            Return vPrecioUnitario
        End Get
        Set(ByVal value As Double)
            vPrecioUnitario = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return vCantidad
        End Get
        Set(ByVal value As Double)
            vCantidad = value
        End Set
    End Property

    Public Property Articulo() As Articulo
        Get
            Return vArticulo
        End Get
        Set(ByVal value As Articulo)
            vArticulo = value
        End Set
    End Property
    Public ReadOnly Property SubTotal() As Double
        Get
            Return vCantidad * vPrecioUnitario
        End Get
    End Property
    Public Sub New(ByVal pu As Double, ByVal cant As Double, ByVal art As Articulo)
        vPrecioUnitario = pu
        vCantidad = cant
        vArticulo = art
        vDescripcion = art.Descripcion
    End Sub
    Public Sub New()

    End Sub
    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property
    Public Property CantADisminuir() As Integer
        Get
            Return vCantADisminuir
        End Get
        Set(ByVal value As Integer)
            vCantADisminuir = value
        End Set
    End Property
End Class

