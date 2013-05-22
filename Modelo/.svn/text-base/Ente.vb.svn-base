Public Class Ente

    Protected vIdEnte As Integer
    Protected colDomicilios As Dictionary(Of String, Domicilio)
    Protected colTelefonos As Dictionary(Of String, Telefono)

    Protected vCUIT As String
    Protected vFechaAlta As Date
    Protected vIdRubro As Integer



    Public Sub New()
        colDomicilios = New Dictionary(Of String, Domicilio)
        colTelefonos = New Dictionary(Of String, Telefono)
    End Sub

    Public Property IdEnte() As Integer
        Get
            Return (vIdEnte)
        End Get
        Set(ByVal value As Integer)
            vIdEnte = value
        End Set
    End Property

  
    Public Property IdRubro() As Integer
        Get
            Return vIdRubro
        End Get
        Set(ByVal value As Integer)
            vIdRubro = value
        End Set
    End Property

    Public Property CUIT() As String
        Get
            Return vCUIT
        End Get
        Set(ByVal value As String)
            vCUIT = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return vFechaAlta
        End Get
        Set(ByVal value As Date)
            vFechaAlta = value
        End Set
    End Property


    Public Property Domicilios() As Dictionary(Of String, Domicilio)
        Get
            Return colDomicilios
        End Get
        Set(ByVal value As Dictionary(Of String, Domicilio))
            colDomicilios = value
        End Set
    End Property

    Public Property Telefonos() As Dictionary(Of String, Telefono)
        Get
            Return colTelefonos
        End Get
        Set(ByVal value As Dictionary(Of String, Telefono))
            colTelefonos = value
        End Set
    End Property

    Public Function AddDomicilio(ByVal d As Domicilio) As Boolean
        If colDomicilios.ContainsKey(d.Calle + d.Altura) Then
            Return False
        Else
            colDomicilios.Add(d.Calle + d.Altura, d)
            Return True
        End If
    End Function
    Public Sub RemoveDomicilio(ByVal d As Domicilio)
        colDomicilios.Remove(d.Calle + d.Altura)
    End Sub
    Public Function AddTelefono(ByVal t As Telefono) As Boolean
        If colTelefonos.ContainsKey(t.Numero) Then
            Return False
        Else
            colTelefonos.Add(t.Numero, t)
            Return True
        End If
    End Function
    Public Sub RemoveTelefono(ByVal t As Telefono)
        colTelefonos.Remove(t.Numero)
    End Sub
End Class
