
Public Class Comprobante

    Private vFechaEmision As Date
    Private vIdComprobante As Integer
    Private vTotal As Double
    Private colRenglonComprobante As List(Of RenglonComprobante)

    Public Property FechaEmision() As Date
        Get
            Return vFechaEmision
        End Get
        Set(ByVal value As Date)
            vFechaEmision = value
        End Set
    End Property

    Public Property IdComprobante() As Integer
        Get
            Return vIdComprobante
        End Get
        Set(ByVal value As Integer)
            vIdComprobante = value
        End Set
    End Property

    Public Overridable ReadOnly Property Total() As Double
        Get
            Dim tot As Double
            For Each rc As RenglonComprobante In colRenglonComprobante
                tot += rc.SubTotal
            Next
            Return tot
        End Get
    End Property
    Public ReadOnly Property TotalMasIVA() As Double
        Get
            Dim tot As Double
            For Each rc As RenglonComprobante In colRenglonComprobante
                tot += rc.SubTotal * 1.21
            Next
            Return tot
        End Get
    End Property
    Public ReadOnly Property TotalIVA() As Double
        Get
            Dim tot As Double
            For Each rc As RenglonComprobante In colRenglonComprobante
                tot += rc.SubTotal * 0.21
            Next
            Return tot
        End Get
    End Property

    Public Sub New()
        colRenglonComprobante = New List(Of RenglonComprobante)
    End Sub
    Public Property Renglones() As List(Of RenglonComprobante)
        Get
            Return colRenglonComprobante
        End Get
        Set(ByVal value As List(Of RenglonComprobante))
            colRenglonComprobante = value
        End Set
    End Property
End Class
