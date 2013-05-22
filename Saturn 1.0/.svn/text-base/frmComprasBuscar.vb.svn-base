Imports Fachada
Imports Modelo

Public Class frmComprasBuscar
    Dim facProveedor As New FachadaProveedor
    Dim facCompra As New FachadaCompra

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmComprasBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facProveedor.CargarCombo(cmbProveedores)
        dgvCompras.DataSource = facCompra.ListarCompras()
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If Not IsNothing(dgvCompras.SelectedRows(0)) Then
            If MessageBox.Show("Realmente desea anular la compra?" & vbCr & "Se actualizaràn los stocks de articulos.", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                facCompra.Anular(dgvCompras.SelectedRows(0).Cells(0).Value)
                dgvCompras.DataSource = facCompra.ListarCompras()
            End If
        End If
    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.SelectedIndexChanged
        If cmbProveedores.SelectedIndex <> -1 Then dgvCompras.DataSource = facCompra.ListarCompras(CType(cmbProveedores.SelectedItem, IdProveedor).Id)
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If cmbProveedores.SelectedIndex <> -1 Then
            dgvCompras.DataSource = facCompra.ListarCompras(CType(cmbProveedores.SelectedItem, IdProveedor).Id, dtpDesde.Value, dtpHasta.Value)
            dgvCompras.Select()
        End If
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        dgvCompras.DataSource = facCompra.ListarCompras(dtpDesde.Value, dtpHasta.Value)
    End Sub

    Private Sub cmdDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalles.Click
        If Not IsNothing(dgvCompras.SelectedRows(0)) Then
            frmCompras.Show()
            frmCompras.VerCompra(dgvCompras.SelectedRows(0).Cells(0).Value)
        End If

    End Sub
End Class