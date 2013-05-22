Imports Modelo
Imports Datos

Public Class FachadaInfoTicket
    Public Sub GuardarInfoTicket(ByVal cn As InfoTicket)
        Dim regCon As New RegistroInfoTicket
        regCon.Guardar(cn)
    End Sub
    Public Function TraerInfoTicket() As InfoTicket
        Dim regCon As New RegistroInfoTicket
        Return regCon.TraerInfoTicket()
    End Function
End Class
