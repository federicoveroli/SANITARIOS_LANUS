Public Class OperacionCaja

    Private vFecha As Date
    Private vMonto As Double
    Private vOperacion As Boolean
    Private vDescripcion As String

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
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

    Public Property Monto() As Double
        Get
            Return vMonto
        End Get
        Set(ByVal value As Double)
            vMonto = value
        End Set
    End Property

    Public Property Operacion() As Boolean
        Get
            Return vOperacion
        End Get
        Set(ByVal value As Boolean)
            vOperacion = value
        End Set
    End Property
End Class
