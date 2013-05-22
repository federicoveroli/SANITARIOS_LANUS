Imports Fachada
Imports Modelo

Public Class frmCompras
    Dim facProveedor As New FachadaProveedor
    Dim facArticulo As New FachadaArticulo
    Dim WithEvents facComprobante As New FachadaCompra
    Dim comp As New Compra
    Private WithEvents frmArtBuscar As New FrmArticuloBuscar

    Private Sub CmdArmarRenglon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdArmarRenglon.Click
        If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.cmdAgregarInexistente.Visible = False
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.MdiParent = FrmPrincipal
        frmArtBuscar.seleccionBusqueda = True
        frmArtBuscar.cmbBuscarPor.SelectedIndex = 4
        frmArtBuscar.txtQueContenga.Text = cmbProveedores.Text
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.cmdBuscar_Click(sender, e)
        frmArtBuscar.Label5.Text = "PC"
        frmArtBuscar.Label6.Text = "PVenta"
        frmArtBuscar.btnNuevo.Visible = True
        Dim txt As TextBox
        txt = frmArtBuscar.txtPU
        RemoveHandler txt.TextChanged, AddressOf frmArtBuscar.txtPU_TextChanged
        txt = frmArtBuscar.txtCantidad
        RemoveHandler txt.TextChanged, AddressOf frmArtBuscar.txtCantidad_TextChanged
        frmArtBuscar.txtPU.Enabled = True
        frmArtBuscar.txtTotal.ReadOnly = False
        'frmartbuscar.txtPU
        frmArtBuscar.Show()

        'Dim pc As Double, cantidad As Integer, idArticulo As Integer, pventa As Double
        'pc = frmArtBuscar.txtPU.Text
        'pventa = frmArtBuscar.txtTotal.Text
        'cantidad = frmArtBuscar.txtCantidad.Text
        'idArticulo = frmArtBuscar.DataGridView1.SelectedRows(0).Cells(0).Value
    End Sub
    Private Sub AgregarRenglon(ByVal idArticulo As Integer, ByVal cantidad As Double, ByVal pcosto As Double, ByVal pventa As Double) Handles frmArtBuscar.AgregarRenglonCompra, facComprobante.AgregarRenglonCompra
        Dim art As Articulo = facArticulo.TraerArticulo(idArticulo)
        art.Precio = pventa
        comp.Renglones.Add(New RenglonComprobante(pcosto, cantidad, art))
        dgvRenglonesCompra.DataSource = Nothing
        ActualizarRenglones()
    End Sub
    Private Sub picBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBuscar.Click
        frmProveedorBuscar.cmdNuevoProveedor.Visible = True
        frmProveedorBuscar.cmdSeleccionar.Visible = True
        'frmProveedorBuscar.MdiParent = FrmPrincipal
        frmProveedorBuscar.ShowDialog()
        If frmProveedorBuscar.idProveedorSeleccionado = 0 Then Exit Sub
        For Each pro As IdProveedor In cmbProveedores.Items
            If pro.Id = frmProveedorBuscar.idProveedorSeleccionado Then
                cmbProveedores.SelectedItem = pro
            End If
        Next
    End Sub

    Private Sub cmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizar.Click
        If cmbProveedores.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un proveedor", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbProveedores.Select()
            Exit Sub
        End If
        comp.IdProveedor = CType(cmbProveedores.SelectedItem, IdProveedor).Id
        comp.FechaEmision = dtpFecha.Value
        If MessageBox.Show("Desea Finalizar la compra", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            facComprobante.ingresarCompra(comp)
            MessageBox.Show("La compra fue ingresada exitosamente", "compra ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            comp = New Compra
            ActualizarRenglones()
        End If
    End Sub

    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facProveedor.CargarCombo(cmbProveedores)
    End Sub
    Public Sub VerCompra(ByVal idCompra As Integer)
        comp = facComprobante.TraerCompra(idCompra)
        ActualizarRenglones()
        For Each IdProvee As IdProveedor In cmbProveedores.Items
            If IdProvee.Id = comp.IdProveedor Then
                cmbProveedores.SelectedItem = IdProvee
                Exit For
            End If
        Next
        dtpFecha.Value = comp.FechaEmision
        CmdArmarRenglon.Visible = False
        cmdEliminar.Visible = False
        cmdFinalizar.Visible = False
        cmbProveedores.Enabled = False
        dtpFecha.Enabled = False
        picBuscar.Enabled = False
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If dgvRenglonesCompra.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim indice As Integer
        indice = dgvRenglonesCompra.SelectedRows(0).Index
        comp.Renglones.RemoveAt(indice)
        ActualizarRenglones()
    End Sub
    Private Sub ActualizarRenglones()
        dgvRenglonesCompra.Rows.Clear()
        If dgvRenglonesCompra.Columns.Count = 0 Then
            dgvRenglonesCompra.Columns.Add("articulo", "articulo")
            dgvRenglonesCompra.Columns.Add("articulo", "cantidad")
            dgvRenglonesCompra.Columns.Add("articulo", "PU")
            dgvRenglonesCompra.Columns.Add("articulo", "SubTotal")
        End If
        For Each rc As RenglonComprobante In comp.Renglones
            dgvRenglonesCompra.Rows.Add(rc.Articulo.Descripcion, rc.Cantidad, Math.Round(rc.PrecioUnitario, 2), Math.Round(rc.SubTotal, 2))
        Next
        lblToTaL.Text = "" & Math.Round(comp.Total, 2)
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        ofdExcel.Filter = "Archivos de Excel |*.xls"
        ofdExcel.ShowDialog()
        Dim compImp As Compra = facComprobante.ImportarDesdeExcel(ofdExcel.FileName)
        comp.IdProveedor = compImp.IdProveedor
        SeleccionarProveedor()

        dtpFecha.Value = compImp.FechaEmision

        'ActualizarRenglones()
    
    End Sub

    Private Sub ArticuloNoEncontrado(ByVal descripcion As String, ByVal cantidad As Integer, ByVal codigo_barra As String, ByVal art As Articulo) Handles facComprobante.ArticuloNoEncontrado

        With FrmArticuloAlta
            .Show()
            .Hide()
            .txtPrecioCosto.Text = art.Costo
            .txtPrecioFinal.Text = art.Precio
            .txtCodBarras.Text = codigo_barra
            .txtDescripcION.Text = art.Descripcion
            .txtSTOcK.Text = cantidad
            .txtPtoReposicion.Text = "1"
            .chkSeguirCargando.Checked = False
            .ShowDialog()
        End With

        If FrmArticuloAlta.Acepto Then
            Dim arti As Articulo
            arti = facArticulo.TraerArticuloPorDescripcion(descripcion)
            AgregarRenglon(arti.IdArticulo, cantidad, art.Costo, art.Precio)
        Else
            Dim detallesArticulo As String
            detallesArticulo = "Descripcion: " & art.Descripcion
            detallesArticulo += vbCr & "Precio: " & art.Precio
            detallesArticulo += vbCr + "Codigo: " & art.CodBarra
            MessageBox.Show("El articulo no será agregado. " & vbCr & vbCr & detallesArticulo, "Articulo cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SeleccionarProveedor()
        For Each id As IdProveedor In cmbProveedores.Items
            If id.Id = comp.IdProveedor Then
                cmbProveedores.SelectedItem = id
                Exit For
            End If
        Next
    End Sub
End Class