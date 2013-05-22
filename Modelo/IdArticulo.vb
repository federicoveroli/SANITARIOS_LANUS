Public Class IdArticulo
    Public Id As Integer
    Public Descripcion As String
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
