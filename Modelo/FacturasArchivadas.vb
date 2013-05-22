Public Class FacturasArchivadas
    Private _Fechadesde As Date
    Private _FechaHasta As Date
    Private _NombreArchivo As String
    Private _NombreTabla As String
    Private _IdFacturaArchivada As Integer


    Public Property FechaDesde() As Date
        Get
            Return _Fechadesde
        End Get
        Set(ByVal value As Date)
            _Fechadesde = value
        End Set
    End Property

    Public Property FechaHasta() As Date
        Get
            Return _FechaHasta
        End Get
        Set(ByVal value As Date)
            _FechaHasta = value
        End Set
    End Property

    Public Property NombreArchivo() As String
        Get
            Return _NombreArchivo
        End Get
        Set(ByVal value As String)
            _NombreArchivo = value
        End Set
    End Property

    Public Property IdFacturaArchivada() As Integer
        Get
            Return _IdFacturaArchivada
        End Get
        Set(ByVal value As Integer)
            _IdFacturaArchivada = value
        End Set
    End Property

    Public Property NombreTabla() As String
        Get
            Return _NombreTabla
        End Get
        Set(ByVal value As String)
            _NombreTabla = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _Fechadesde.ToShortDateString + " - " + _FechaHasta.ToShortDateString + " - " + _NombreArchivo
    End Function

End Class
