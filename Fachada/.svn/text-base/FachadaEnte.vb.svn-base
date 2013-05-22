Imports Datos
Imports Modelo

Public Class FachadaEnte



    Public Overridable Function listarTodos() As ICollection
        Dim regEnte As New RegistroEnte
        Return (regEnte.listarEnte())
    End Function
    Public Overridable Function listarTodos(ByVal RazonSocial As String) As ICollection
        Dim regEnte As New RegistroEnte
        Return (regEnte.listarEnte(RazonSocial))
    End Function
    Public Overridable Sub AltaEnte(ByVal e As Ente)
        Dim re As New RegistroEnte
        re.altaEnte(e)
    End Sub
    Public Overridable Sub ModificarEnte(ByVal e As Ente)
        Dim re As New RegistroEnte
        re.modificarEnte(e)
    End Sub
    Public Overridable Sub EliminarEnte(ByVal e As Ente)
        Dim re As New RegistroEnte
        re.eliminarEnte(e.IdEnte)
    End Sub


End Class
