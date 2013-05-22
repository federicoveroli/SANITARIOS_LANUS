Imports Modelo
Imports Fachada

Public Class frmVerFacturasArchivadas
    Dim ff As New FachadaFactura
    Dim factArchivada As FacturasArchivadas
    Dim facFactura As FachadaFactura

    Private Sub frmVerFacturasArchivadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFacturasArchivadas.DataSource = ff.ListarFacturasArchivadas
        facFactura = New FachadaFactura
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmbFacturasArchivadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFacturasArchivadas.SelectedIndexChanged
        dgvFacturasArchivadas.DataSource = ff.TraerDetallesDeFacturasArchivadas(CType(cmbFacturasArchivadas.SelectedItem, FacturasArchivadas).NombreTabla)
    End Sub

    Private Sub cmdDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalles.Click
        Try

            Dim tipoFac As String
            tipoFac = dgvFacturasArchivadas.SelectedRows(0).Cells(2).Value
            If tipoFac = "NC" Then
                Dim nota As NotaDeCredito, numero As Integer, condicion As String
                numero = dgvFacturasArchivadas.SelectedRows(0).Cells(1).Value
                condicion = dgvFacturasArchivadas.SelectedRows(0).Cells(2).Value
                nota = facFactura.TraerNotaDeCredito(numero, condicion)
                FrmFacturacion.MdiParent = Me.MdiParent
                FrmFacturacion.Show()
                FrmFacturacion.MainMenuStrip.Enabled = False
                FrmFacturacion.MostrarNotaDeCredito(nota)
            Else
                Dim vta As Venta, numero As Integer, condicion As String
                numero = dgvFacturasArchivadas.SelectedRows(0).Cells(1).Value
                condicion = dgvFacturasArchivadas.SelectedRows(0).Cells(2).Value
                vta = facFactura.TraerFactura(numero, condicion)
                FrmFacturacion.MdiParent = Me.MdiParent
                FrmFacturacion.Show()
                FrmFacturacion.MainMenuStrip.Enabled = False
                FrmFacturacion.MostrarVenta(vta)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click

        Dim vta As Venta, numero As Integer, condicion As String, vtaOriginal As Venta
        numero = dgvFacturasArchivadas.SelectedRows(0).Cells(1).Value
        condicion = dgvFacturasArchivadas.SelectedRows(0).Cells(2).Value
        vta = facFactura.TraerFactura(numero, condicion)
        vtaOriginal = facFactura.TraerFactura(numero, condicion)
        FrmFacturacion.MdiParent = Me.MdiParent
        FrmFacturacion.Show()
        FrmFacturacion.vtaOriginal = vtaOriginal
        FrmFacturacion.ImportarPedido(vta)
    End Sub
End Class