Imports Modelo
Imports Datos
Public Class FachadaReporte
    Dim Dt As DataTable
    Public Function ImpresionDeFactura(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim regRep As New RegistroReporte
        Dt = regRep.ImpFac(numero, condicion)
        'Dt.TableName = "Factura"
        'Dt.WriteXmlSchema("d:\FacturaSaturn.xml")
        Return Dt
    End Function

    Public Function ImpNot(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim regRep As New RegistroReporte
        Dt = regRep.ImpNot(numero, condicion)
        Return Dt
    End Function

    'Public Sub CrearXML()
    '    Dim regRep As New RegistroReporte
    '    Dt = regRep.ImpFac(1, "A")
    '    Dt.TableName = "venta"
    '    Dt.WriteXmlSchema("c:\Factura.xml")
    'End Sub
End Class
