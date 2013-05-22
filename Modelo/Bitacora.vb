
Public Class Bitacora
    Dim vId As String
    Dim vFecha As Date
    Dim vDescripcion As String
    Public Property Identificador() As String
        Get
            Return vId
        End Get
        Set(ByVal value As String)
            vId = value
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
    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

End Class
