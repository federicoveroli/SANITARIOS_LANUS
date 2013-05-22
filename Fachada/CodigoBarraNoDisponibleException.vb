Public Class CodigoBarraNoDisponibleException
    Inherits Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "El codigo de barras ingresado no se encuentra disponible"
        End Get
    End Property
End Class
