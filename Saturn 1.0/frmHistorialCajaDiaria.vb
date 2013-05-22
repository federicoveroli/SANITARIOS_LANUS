Imports Fachada
Imports Modelo


Public Class frmHistorialCajaDiaria
    Dim fac As New Fachada.FachadaCajaDiaria
    Dim facCC As New FachadaCierreCaja

    Private Sub frmHistorialCajaDiaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvHistorialCD.DataSource = fac.listarHistoricoCajaDiaria()

        'dgvHistorialCD.Rows(0).DefaultCellStyle.BackColor = Color.OrangeRed
        'dgvHistorialCD.Rows(0).Cells(0).Style.BackColor = Color.Red
    End Sub

    Private Sub dgvHistorialCD_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvHistorialCD.SelectionChanged
        'Try
        '    'dgvHistorialCD.Rows(0).Tag = 1
        '    'dgvHistorialCD.Rows(1).Tag = 22
        '    If dgvHistorialCD.SelectedRows.Count > 0 Then
        '        'dgvOperaciones.DataSource = fac.ListarOperaciones(dgvHistorialCD.SelectedRows(0).Cells(0).Value)
        '        'dgvDetallesCaja.DataSource = fac.ListarFacturas(dgvHistorialCD.SelectedRows(0).Cells(0).Value)
        '    End If
        'Catch ex As Exception

        'End Try
        Dim idCaja As Integer
        If dgvHistorialCD.SelectedRows.Count = 0 Then Exit Sub
        idCaja = CInt(dgvHistorialCD.SelectedRows(0).Cells(0).Value)
        dgvCierresCaja.DataSource = facCC.TraerCierreCaja(idCaja)
        If dgvDetallesCaja.Rows.Count > 0 Then dgvDetallesCaja.Rows(0).Cells(0).Style.BackColor = Color.Red


    End Sub


    Private Sub dgvDetallesCaja_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetallesCaja.CellContentDoubleClick


        frmFacturasBuscar.MdiParent = Me.MdiParent
        frmFacturasBuscar.Show()
        frmFacturasBuscar.cmbTipo.Text = Me.dgvDetallesCaja.SelectedRows(0).Cells(2).Value
        frmFacturasBuscar.txtNumero.Text = Me.dgvDetallesCaja.SelectedRows(0).Cells(1).Value
        frmFacturasBuscar.cmdBuscar_Click(sender, e)

    End Sub


    Private Sub dgvDetallesCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvDetallesCaja.KeyPress
        If Asc(e.KeyChar) = 13 Then

            frmFacturasBuscar.MdiParent = Me.MdiParent
            frmFacturasBuscar.Show()
            frmFacturasBuscar.cmbTipo.Text = Me.dgvDetallesCaja.SelectedRows(0).Cells(2).Value
            frmFacturasBuscar.txtNumero.Text = Me.dgvDetallesCaja.SelectedRows(0).Cells(1).Value
            frmFacturasBuscar.cmdBuscar_Click(sender, e)
        End If
    End Sub



    Private Sub dgvCierresCaja_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCierresCaja.CellDoubleClick
        Dim cierre As CierreCaja
        Dim idCaja As Integer
        idCaja = CInt(dgvCierresCaja.SelectedRows(0).Cells(0).Value)
        cierre = facCC.TraerCierreCajaPorId(idCaja)
        frmHistorialDetalle.DataSource = cierre
        frmHistorialDetalle.ShowDialog()

    End Sub



    Private Sub dgvCierresCaja_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCierresCaja.CellFormatting
        For Each fila As DataGridViewRow In dgvCierresCaja.Rows
            If fila.Cells(7).Value < fila.Cells(8).Value Then
                'HUBO DIFERENCIA EN EL ARQUEDO DE CAJA
                fila.DefaultCellStyle.BackColor = Color.OrangeRed
            Else 'NO HUBO DIFERENCIA EN EL ARQUEO DE CAJA
                fila.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub


End Class