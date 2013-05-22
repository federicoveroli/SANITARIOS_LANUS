Imports Fachada

Public Class FrmMovimientosDeStock
    Dim facMov As New FachadaMovimientoStock
    Dim idMovimiento As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarRecepcion.Click
        idMovimiento = dgvMovimientos.SelectedRows(0).Cells(0).Value
        Try
            facMov.ValidarRecepcion(idMovimiento, InputBox("Ingrese el ACK obtenido en el momento de ingresar el stock", "Ingrese ACK"))
            dgvMovimientos.DataSource = facMov.ListarMovimientosDeStock()
        Catch ex As ACKInvalidoException
            MessageBox.Show("El ACK ingresado no es válido.", "Ack inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("El ACK debe contener solo números", "Ack inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub FrmMovimientosDeStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvMovimientos.DataSource = facMov.ListarMovimientosDeStock()
    End Sub

    Private Sub dgvMovimientos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvMovimientos.SelectionChanged
        If dgvMovimientos.SelectedRows.Count = 0 Then Exit Sub
        idMovimiento = dgvMovimientos.SelectedRows(0).Cells(0).Value
        dgvDetallesMovimiento.DataSource = facMov.ListarDetallesMovimientoDeStock(idMovimiento)
    End Sub


End Class