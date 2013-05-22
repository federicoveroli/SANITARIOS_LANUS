Imports Modelo

Public Class Sesion
    Private vHoraInicio As DateTime
    Private vHoraFin As DateTime
    Private vUsuario As Usuario
    Private Shared vSesion As Sesion

    Public Shared Function getSesion() As Sesion
        If IsNothing(vSesion) Then vSesion = New Sesion
        Return vSesion
    End Function
    Public Property HoraInicio() As DateTime
        Get
            Return vHoraInicio
        End Get
        Set(ByVal value As DateTime)
            vHoraInicio = value
        End Set
    End Property
    Public Property HoraFin() As DateTime
        Get
            Return vHoraFin
        End Get
        Set(ByVal value As DateTime)
            vHoraFin = value
        End Set
    End Property
    Public Property UsuarioActivo() As Usuario
        Get
            Return vUsuario
        End Get
        Set(ByVal value As Usuario)
            vUsuario = value
        End Set
    End Property
    Private Sub New()
        'es un singleton
    End Sub
End Class
