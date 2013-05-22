Imports Modelo
Imports Fachada
Public Class frmReportes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim fac As New FachadaReporte
        'Dim dt As DataTable
        'dt = fac.ImpresionDeFactura(1, "A")

        ''Creating report.
        'Dim RD As New ReporteVenta

        ''Setting data source for report.

        'RD.SetDataSource(DT)

        ''Setting data source for possible subreports.
        ''For Each SR As ReporteVenta In RD.Subreports
        ''    If SR.Database.Tables.Count > 0 Then
        ''        SR.SetDataSource(dt)
        ''    End If
        ''Next

        ''Setting recently created report must be shown in viewer.
        'Me.CrystalReportViewer1.ReportSource = RD

        ''Dim fac As New FachadaReporte
        ''   fac.ImpresionDeFactura(1, "A")
        ''fac.CrearXML()
        'Me.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub frmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fac As New FachadaReporte
        Dim dt As DataTable
        dt = fac.ImpresionDeFactura(1, "A")

        'Creating report.
        Dim RD As New ReporteVenta

        'Setting data source for report.

        RD.SetDataSource(dt)

        'Setting data source for possible subreports.
        'For Each SR As ReporteVenta In RD.Subreports
        '    If SR.Database.Tables.Count > 0 Then
        '        SR.SetDataSource(dt)
        '    End If
        'Next

        'Setting recently created report must be shown in viewer.
        Me.CrystalReportViewer1.ReportSource = RD

        'Dim fac As New FachadaReporte
        '   fac.ImpresionDeFactura(1, "A")
        'fac.CrearXML()
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class