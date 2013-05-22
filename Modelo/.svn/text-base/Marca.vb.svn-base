Public Class Marca

    Private vIdMarca As Integer
    Private vDescripcion As String
    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Public Property IdMarca() As Integer
        Get
            Return vIdMarca
        End Get
        Set(ByVal value As Integer)
            vIdMarca = value

        End Set
    End Property
    Public Sub New(ByVal desc As String, ByVal idmar As Integer)
        vDescripcion = desc
        vIdMarca = idmar
    End Sub
    Public Overrides Function ToString() As String
        Return vDescripcion
    End Function
End Class
