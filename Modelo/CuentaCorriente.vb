Public Class CuentaCorriente

    Dim vNumfacId As Integer
    Dim vfecha As Date
    Dim vmonTo As Double
    Public Property numfacID() As Integer
        Get
            Return vNumfacId
        End Get
        Set(ByVal value As Integer)
            vNumfacId = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return vfecha
        End Get
        Set(ByVal value As Date)
            vfecha = value
        End Set
    End Property
    Public Property monto() As Double
        Get
            Return vmonTo
        End Get
        Set(ByVal value As Double)
            vmonTo = value
        End Set
    End Property

   
End Class
