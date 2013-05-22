Public Class Domicilio

    Private vIdDomicilio As Integer
    Private vCalle As String
    Private vAltura As String
    Private vPiso As String
    Private vDepto As String
    Private vLocalidad As String
    Private vIdEnte As Integer
    Private vPartido As String
    Private vCodigoPostal As String

    Public Property IdDomicilio() As Integer
        Get
            Return vIdDomicilio
        End Get
        Set(ByVal value As Integer)
            vIdDomicilio = value
        End Set
    End Property

    Public Property Calle() As String
        Get
            Return vCalle
        End Get
        Set(ByVal value As String)
            vCalle = value
        End Set
    End Property

    Public Property Altura() As String
        Get
            Return vAltura
        End Get
        Set(ByVal value As String)
            vAltura = value
        End Set
    End Property

    Public Property Piso() As String
        Get
            Return vPiso
        End Get
        Set(ByVal value As String)
            vPiso = value
        End Set
    End Property

    Public Property Depto() As String
        Get
            Return vDepto
        End Get
        Set(ByVal value As String)
            vDepto = value
        End Set
    End Property

    Public Property Localidad() As String
        Get
            Return vLocalidad
        End Get
        Set(ByVal value As String)
            vLocalidad = value
        End Set
    End Property

    Public Property IdEnte() As Integer
        Get
            Return vIdEnte
        End Get
        Set(ByVal value As Integer)
            vIdEnte = value
        End Set
    End Property

    Public Property Partido() As String
        Get
            Return vPartido
        End Get
        Set(ByVal value As String)
            vPartido = value
        End Set
    End Property

    Public Property CodigoPostal() As String
        Get
            Return vCodigoPostal
        End Get
        Set(ByVal value As String)
            vCodigoPostal = value
        End Set
    End Property
End Class
