Imports Modelo
Imports Datos

Public Class FachadaPermiso
    Public Sub ingresarPermiso(ByVal p As Permiso)
        'este metodo es utilizado para ingresar los permisos de una manera mas sencilla
        Dim rp As New RegistroPermisos
        rp.ingresarPermisos(p)
    End Sub
    Public Function listarPermisos() As List(Of Permiso)
        Dim rp As New RegistroPermisos
        Return rp.listarPermisos()
    End Function
End Class
