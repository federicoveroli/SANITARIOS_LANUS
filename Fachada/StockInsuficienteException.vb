Public Class StockInsuficienteException
    Inherits Exception
    Public Overrides ReadOnly Property Message() As String
        Get
            Return "El stock es insuficiente, imposible realizar la operación"
        End Get
    End Property

End Class
