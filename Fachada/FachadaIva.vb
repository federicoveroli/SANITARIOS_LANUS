Imports Datos
Imports Modelo

Public Class FachadaIva
    Public Function listarIva() As List(Of Iva)
        Dim regIva As New RegistroIva
        Return regIva.listarIvas()
    End Function
    Public Function traerPorId(ByVal id As Integer) As Iva
        Dim regIva As New RegistroIva
        Return regIva.traerPorId(id)
    End Function
End Class
