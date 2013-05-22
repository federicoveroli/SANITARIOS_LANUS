Imports Fachada


Public Class FrmImportarArticulos

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        ofdExcel.Filter = "Archivos de Excel |*.xls"
        ofdExcel.ShowDialog()
        If ofdExcel.FileName = "" Then
            Exit Sub
        End If
        Try
            Dim FacArt As New FachadaArticulo
            FacArt.ImportarDesdeExcel(ofdExcel.FileName, TextBox1, ProgressBar1)
            MessageBox.Show("Los artículos han sido importados correctamente.", "Importación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class