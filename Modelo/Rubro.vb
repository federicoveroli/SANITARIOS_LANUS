Public Class Rubro
    Private vIdRubro As Integer
    Private vDescripcion As String
    Public Property IdRubro() As Integer
        Get
            Return vIdRubro
        End Get
        Set(ByVal value As Integer)
            vIdRubro = value
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
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
