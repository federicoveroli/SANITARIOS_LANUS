Public Class UltimoUsuarioException
    Inherits Exception
    Public Overrides ReadOnly Property Message() As String
        Get
            Return "Imposible eliminar el usuario, ya que es el �nico activo en el sistema"
        End Get
    End Property

End Class
