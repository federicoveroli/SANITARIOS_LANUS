Imports Fachada
'--------------------------------------------------------------------
' Author:      Albert Mata (www.albertmata.net)
' Date:        20080731
' Needs:       MySQL.Data reference.
' Description: Class to create a report using just an XML file. 
'--------------------------------------------------------------------

Public Class clsReportCreator


    'Dim facFactura As New FachadaFactura
    ''----------------------------------------------------------------
    '' Creates XML file in desired path.
    ' ''----------------------------------------------------------------
    Public Sub CreateXMLFile()
        Dim DT As DataTable

        'Creating DataTable.

        Dim fac As New FachadaReporte
        DT = fac.ImpresionDeFactura(5, "A")
        DT.TableName = "venta"
        'Writting XML file in desired path.
        DT.WriteXmlSchema("c:\tito\Factura" & ".xml")
    End Sub

End Class
