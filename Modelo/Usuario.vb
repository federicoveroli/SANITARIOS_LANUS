
Public Class Usuario

    Private vNick As String
    Private vId As Integer
    Private vPass As String
    Private vNombre As String
    Private vApellido As String
    Private vBorrado As Boolean
    Private vIdPerfil As Integer
    Private colPermisos As Hashtable
    Public Sub New()
        colPermisos = New Hashtable
    End Sub
    Public Sub New(ByVal nick As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String)
        vNick = nick
        vPass = pass
        vNombre = nombre
        vApellido = apellido
        colPermisos = New Hashtable
    End Sub
    Public Sub New(ByVal id As Integer, ByVal nick As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String)
        vId = id
        vNick = nick
        vPass = pass
        vNombre = nombre
        vApellido = apellido
        colPermisos = New Hashtable
    End Sub
    Public Sub New(ByVal id As Integer, ByVal nick As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String, ByVal borrado As Boolean)
        vId = id
        vNick = nick
        vPass = pass
        vNombre = nombre
        vApellido = apellido
        vBorrado = borrado
        colPermisos = New Hashtable
    End Sub
    Public Sub New(ByVal id As Integer, ByVal nick As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String, ByVal idPerfil As Integer, ByVal borrado As Boolean)
        vId = id
        vNick = nick
        vPass = pass
        vNombre = nombre
        vApellido = apellido
        vIdPerfil = idPerfil
        vBorrado = borrado
        colPermisos = New Hashtable
    End Sub
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Public Property Nick() As String
        Get
            Return vNick
        End Get
        Set(ByVal value As String)
            vNick = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return vApellido
        End Get
        Set(ByVal value As String)
            vApellido = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return vPass
        End Get
        Set(ByVal value As String)
            vPass = value
        End Set
    End Property
    Public Property Eliminado() As Boolean
        Get
            Return vBorrado
        End Get
        Set(ByVal value As Boolean)
            vBorrado = value
        End Set
    End Property
    Public Property IdPerfil() As Integer
        Get
            Return vIdPerfil
        End Get
        Set(ByVal value As Integer)
            vIdPerfil = value
        End Set
    End Property
    Public Function AddPermiso(ByVal p As Permiso) As Boolean
        If colPermisos.Contains("" + CStr(p.IdPermiso)) Then
            Return False
        Else
            colPermisos.Add("" + CStr(p.IdPermiso), p)
            Return True
        End If
    End Function
    Public Sub RemovePermiso(ByVal idPermiso As Integer)
        colPermisos.Remove("" + CStr(idPermiso))
    End Sub
    Public Function TienePermiso(ByVal idPermiso As Integer) As Boolean
        Return colPermisos.Contains("" + CStr(idPermiso))
    End Function
    Public Function TienePermiso(ByVal control As String) As Boolean
        For Each p As Permiso In colPermisos.Values
            If p.Control = control Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Property Permisos() As Hashtable
        Get
            Return colPermisos
        End Get
        Set(ByVal value As Hashtable)
            colPermisos = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return vNick
    End Function
End Class
