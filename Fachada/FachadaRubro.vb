Imports Datos
Imports Modelo

Public Class FachadaRubro
    Public Function listarRubros() As List(Of Rubro)
        Dim regRubro As New RegistroRubro
        Return regRubro.listarRubros
    End Function
    Public Sub altaRubro(ByVal descripcion As String)
        Dim regRubro As New RegistroRubro
        regRubro.Alta(descripcion)
    End Sub
    Public Function traerIdRubroXdescripcion(ByVal descripcion As String) As Integer
        Dim regRubro As New RegistroRubro
        Return regRubro.traerIdRubroXdescripcion(descripcion)
    End Function
End Class
