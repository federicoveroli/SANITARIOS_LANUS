Public Class Iva
    Private vIdIva As Integer
    Private vDescripcion As String
    Private vAlicuota As Double
    Public Sub New()

    End Sub
    Public Sub New(ByVal idIva As Integer, ByVal descripcion As String, ByVal valicuota As Double)

    End Sub
    Public Property IdIva() As Integer
        Get
            Return vIdIva
        End Get
        Set(ByVal value As Integer)
            vIdIva = value
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
    Public Property Alicuota() As Double
        Get
            Return vAlicuota
        End Get
        Set(ByVal value As Double)
            vAlicuota = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return vDescripcion
    End Function
End Class