Public Class IdProveedor
    Public Id As Integer
    Public RazonSocial As String
    Public Overrides Function ToString() As String
        Return RazonSocial
    End Function
End Class
