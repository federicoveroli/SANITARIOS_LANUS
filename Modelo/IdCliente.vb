Public Class IdCliente
    Public Id As Integer
    Public nombre As String
    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class
