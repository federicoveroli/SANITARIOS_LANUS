Public Class TipoArticulo

    Private vIdTipo As Integer
    Private VDescripcion As String
    Public Property IdTipo() As Integer
        Get
            Return vIdTipo
        End Get
        Set(ByVal value As Integer)
            vIdTipo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return VDescripcion
        End Get
        Set(ByVal value As String)
            VDescripcion = value
        End Set
    End Property
    Public Sub New(ByVal desc As String, ByVal id As Integer)
        VDescripcion = desc
        vIdTipo = id
    End Sub
    Public Sub New()
    End Sub

    Public Overrides Function ToString() As String
        Return VDescripcion
    End Function
End Class
