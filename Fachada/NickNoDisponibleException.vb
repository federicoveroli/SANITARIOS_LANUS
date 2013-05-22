Public Class NickNoDisponibleException
    Inherits Exception
    Public Overrides ReadOnly Property Message() As String
        Get
            Return "El nombre de usuario ingresado no se encuentra disponible." _
            + vbCr + "Ingrese otro y vuelva a intentarlo"
        End Get
    End Property
End Class
