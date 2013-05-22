
Public Class Permiso

    Private vIdPermiso As Integer
    Private vNivel As Integer
    Private vDescripcion As String
    Private vFormulario As String
    Private vControl As String
    Public Property IdPermiso() As Integer
        Get
            Return vIdPermiso
        End Get
        Set(ByVal value As Integer)
            vIdPermiso = value
        End Set
    End Property

    Public Property Nivel() As Integer
        Get
            Return vNivel
        End Get
        Set(ByVal value As Integer)
            vNivel = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Public Property Formulario() As String
        Get
            Return vFormulario
        End Get
        Set(ByVal value As String)
            vFormulario = value
        End Set
    End Property

    Public Property Control() As String
        Get
            Return vControl
        End Get
        Set(ByVal value As String)
            vControl = value
        End Set
    End Property
    Public Sub New(ByVal idPermiso As Integer, ByVal nivel As Integer, ByVal descripcion As String, ByVal formulario As String, ByVal control As String)
        vIdPermiso = idPermiso
        vNivel = nivel
        vDescripcion = descripcion
        vFormulario = formulario
        vControl = control
    End Sub
    Public Sub New(ByVal idPermiso As Integer)
        vIdPermiso = idPermiso
    End Sub
    Public Overrides Function ToString() As String
        Return vDescripcion
    End Function
End Class
