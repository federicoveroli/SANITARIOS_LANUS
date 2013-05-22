Public Class UltimoUsuarioException
    Inherits Exception
    Public Overrides ReadOnly Property Message() As String
        Get
            Return "Imposible eliminar el usuario, ya que es el único activo en el sistema"
        End Get
    End Property

End Class
