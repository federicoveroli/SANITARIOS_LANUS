Imports Fachada

Public Class FrmArchivarFacturas
    Dim facFactura As FachadaFactura

    Private Sub FrmArchivarFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facFactura = New FachadaFactura
        dgvFacturas.DataSource = facFactura.ListarFacturas("X")
        dtpdesde.Value = facFactura.TraerMinFecha()
        dtphasta.Value = Date.Now
    End Sub

    Private Sub btnArchivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivar.Click
        Dim frmBarra As New frmBarraProgreso
        frmBarra.Show()
        facFactura.ArchivarFacturas(txtNombreArchivo.Text, dtpdesde.Value, dtphasta.Value, frmBarra.ProgressBar1)
        frmBarra.Close()
        MessageBox.Show("Archivo generado correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class