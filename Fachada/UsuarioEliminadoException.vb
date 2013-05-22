Public Class UsuarioEliminadoException
    Inherits Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "El usuario se encuentra eliminado." _
            + vbCr + "Ingrese otro y vuelva a intentarlo"
        End Get
    End Property

End Class
