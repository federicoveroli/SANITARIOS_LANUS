Public Class Articulo
    Private vIdArticulo As Integer
    Private vIdmarca As Integer
    Private vStock As Integer
    Private vCosto As Double
    Private vUtilidad As Double
    Private vDescripcion As String
    Private vPrecio As Double
    Private vIdcategoria As Integer
    Private vMedida As String
    Private vPorcDesc As Double
    Private vIdproveedor As Integer
    Private vEsfraccionable As Boolean
    Private vCodBarra As String
    Private vPtoReposicion As Integer

    Public Property CodBarra() As String
        Get
            Return vCodBarra
        End Get
        Set(ByVal value As String)
            vCodBarra = value
        End Set
    End Property

    Public Property PtoReposicion() As Integer
        Get
            Return vPtoReposicion
        End Get
        Set(ByVal value As Integer)
            vPtoReposicion = value
        End Set
    End Property

    Public Property IdArticulo() As Integer
        Get
            Return vIdArticulo
        End Get
        Set(ByVal value As Integer)
            vIdArticulo = value
        End Set
    End Property
    Public Property Utilidad() As Double
        Get
            Return vUtilidad
        End Get
        Set(ByVal value As Double)
            vUtilidad = value
        End Set
    End Property
    Public Property Stock() As Integer
        Get
            Return vStock
        End Get
        Set(ByVal value As Integer)
            vStock = value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return vPrecio
        End Get
        Set(ByVal value As Double)
            vPrecio = value
        End Set
    End Property
    Public Property Idcategoria() As Integer
        Get
            Return vIdcategoria
        End Get
        Set(ByVal value As Integer)
            vIdcategoria = value
        End Set
    End Property
    Public Property IdMarca() As Integer
        Get
            Return vIdmarca
        End Get
        Set(ByVal value As Integer)
            vIdmarca = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property
    Public Property Costo() As Double
        Get
            Return vCosto
        End Get
        Set(ByVal value As Double)
            vCosto = value
        End Set
    End Property
    Public Property Medida() As String
        Get
            Return vMedida
        End Get
        Set(ByVal value As String)
            vMedida = value
        End Set
    End Property
    Public Property PorcDesc() As Double
        Get
            Return vPorcDesc
        End Get
        Set(ByVal value As Double)
            vPorcDesc = value
        End Set
    End Property
    Public Property Idproveedor() As Integer
        Get
            Return vIdproveedor
        End Get
        Set(ByVal value As Integer)
            vIdproveedor = value
        End Set
    End Property
    Public Property esFraccionable() As Boolean
        Get
            Return vEsfraccionable
        End Get
        Set(ByVal value As Boolean)
            vEsfraccionable = value
        End Set
    End Property
    Public Sub New(ByVal idArticulo As Integer, ByVal idMarca As Integer, ByVal descripcion As String, ByVal Stock As Integer, ByVal Utilidad As Double, ByVal Costo As Double, ByVal Precio As Double, ByVal Medida As String, ByVal PorcDesc As Double, ByVal Idproveedor As Integer, ByVal idcategoria As Integer)
        vIdArticulo = idArticulo
        vIdmarca = idMarca
        vDescripcion = descripcion
        vStock = Stock
        vUtilidad = Utilidad
        vCosto = Costo
        vPrecio = Precio
        vMedida = Medida
        vPorcDesc = PorcDesc
        vIdproveedor = Idproveedor
        vIdcategoria = idcategoria
        vEsfraccionable = esFraccionable
        vCodBarra = ""
    End Sub
    Public Sub New()
        vCodBarra = ""
    End Sub

   
    Public Overrides Function ToString() As String
        Return vDescripcion
    End Function
End Class
