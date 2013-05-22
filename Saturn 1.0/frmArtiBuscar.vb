Public Class frmArtiBuscar
    Public frm As FrmArticuloBuscar

    Private Sub txtNArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNArticulo.TextChanged
        If txtNArticulo.Text.Length = 0 Then Exit Sub
        frm.DataGridView1.CurrentCell = Nothing
        frm.DataGridView1.ClearSelection()
        'dgvRenglones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each fila As DataGridViewRow In frm.DataGridView1.Rows
            If IsNothing(fila.Cells(0).Value) Then Exit Sub
            If fila.Cells(0).Value.ToString().StartsWith(txtNArticulo.Text) Then
                frm.DataGridView1.Rows(fila.Index).Selected = True
                frm.DataGridView1.CurrentCell = fila.Cells(0)
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If txtDescripcion.Text.Length = 0 Then Exit Sub

        EncontroArticulo()

        'If Not EncontroArticulo() Then

        '    'sino encontro el producto hacemos abrir la ventana de alta de articulo 
        '    'para que lo pueda ingresar. Tener en cueenta que esto solo debe pasar en el caso que 
        '    'estemos agregando un renglon a la compra
        '    With FrmArticuloAlta
        '        .Show()
        '        .Hide()
        '        .setProveedor(frm.txtQueContenga.Text)
        '        .txtDescripcION.Text = txtDescripcion.Text
        '        .chkSeguirCargando.Checked = False
        '        .ShowDialog()
        '    End With

        '    Me.frm.cmdBuscar_Click(sender, e)

        '    EncontroArticulo()

        '    Me.Close()

        'End If

    End Sub

    Private Function EncontroArticulo() As Boolean

        frm.DataGridView1.CurrentCell = Nothing
        frm.DataGridView1.ClearSelection()

        For Each fila As DataGridViewRow In frm.DataGridView1.Rows
            If IsNothing(fila.Cells(1).Value) Then Exit Function
            If fila.Cells(1).Value.ToString().Contains(txtDescripcion.Text) Then
                frm.DataGridView1.Rows(fila.Index).Selected = True
                frm.DataGridView1.CurrentCell = fila.Cells(0)
                Return True
            End If
        Next

        Return False

    End Function

    Private Sub txtTipoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoProducto.TextChanged
        If txtTipoProducto.Text.Length = 0 Then Exit Sub
        frm.DataGridView1.CurrentCell = Nothing
        frm.DataGridView1.ClearSelection()
        'dgvRenglones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each fila As DataGridViewRow In frm.DataGridView1.Rows
            If IsNothing(fila.Cells(2).Value) Then Exit Sub
            If fila.Cells(2).Value.ToString().Contains(txtTipoProducto.Text) Then
                frm.DataGridView1.Rows(fila.Index).Selected = True
                frm.DataGridView1.CurrentCell = fila.Cells(0)
                Exit For
            End If
        Next
    End Sub

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.TextChanged
        If txtProveedor.Text.Length = 0 Then Exit Sub
        frm.DataGridView1.CurrentCell = Nothing
        frm.DataGridView1.ClearSelection()
        'dgvRenglones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each fila As DataGridViewRow In frm.DataGridView1.Rows
            If IsNothing(fila.Cells(3).Value) Then Exit Sub
            If fila.Cells(3).Value.ToString().Contains(txtProveedor.Text) Then
                frm.DataGridView1.Rows(fila.Index).Selected = True
                frm.DataGridView1.CurrentCell = fila.Cells(0)
                Exit For
            End If
        Next
    End Sub

    Private Sub txtMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarca.TextChanged
        If txtMarca.Text.Length = 0 Then Exit Sub
        frm.DataGridView1.CurrentCell = Nothing
        frm.DataGridView1.ClearSelection()
        'dgvRenglones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each fila As DataGridViewRow In frm.DataGridView1.Rows
            If IsNothing(fila.Cells(4).Value) Then Exit Sub
            If fila.Cells(4).Value.ToString().Contains(txtMarca.Text) Then
                frm.DataGridView1.Rows(fila.Index).Selected = True
                frm.DataGridView1.CurrentCell = fila.Cells(0)
                Exit For
            End If
        Next
    End Sub
End Class