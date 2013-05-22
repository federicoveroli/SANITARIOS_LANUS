Imports Fachada
Imports Modelo

Public Class frmFacturasBuscar
    Dim facFactura As New FachadaFactura
    Dim faccliente As New FachadaCliente
    Dim facArt As New FachadaArticulo
    Dim fu As New FachadaUsuario
    Dim facPro As New FachadaProveedor


    Public Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        cmdImportar.Enabled = False
        cmdNotaDeCredito.Enabled = False
        If txtNumero.Text = "" Then
            MsgBox("Debe ingresar el numero del comprobante", MsgBoxStyle.Exclamation, "Campos incompletos")
            txtNumero.Select()
            Exit Sub
        End If
        If cmbTipo.Text = "NC" Then
            dgvFacturas.DataSource = facFactura.ListarNotasDeCredito(txtNumero.Text)
        Else
            dgvFacturas.DataSource = facFactura.ListarFacturas(txtNumero.Text, cmbTipo.Text)
        End If

    End Sub

    Private Sub frmFacturasBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        faccliente.CargarCombo(cmbCliente)
        facArt.CargarCombo(cmbProducto)
        cmbTipoProducto.DataSource = facArt.listarCategoriasArticulos()
        fu.cargarCombo(cmbVendedor)
        cmbVendedor.SelectedIndex = -1
        facPro.CargarCombo(cmbProveedores)
        cmdAnular.Enabled = Sesion.getSesion.UsuarioActivo.Nick.Equals("ADMIN")
        dgvFacturas.DataSource = facFactura.ListarFacturas()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        Try
            cmdImportar.Enabled = False
            cmdNotaDeCredito.Enabled = False
            dgvFacturas.DataSource = facFactura.ListarFacturas(CType(cmbCliente.SelectedItem, IdCliente).Id)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        cmbCliente.SelectedIndex = -1
        cmdImportar.Enabled = False
        cmdNotaDeCredito.Enabled = False
        If cmbTipo.Text = "NC" Then
            dgvFacturas.DataSource = facFactura.ListarNotasDeCredito()
        Else
            dgvFacturas.DataSource = facFactura.ListarFacturas(cmbTipo.Text)

        End If

    End Sub

    Private Sub cmdDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalles.Click
        Try
            If cmbTipo.Text = "NC" Then
                Dim nota As NotaDeCredito, numero As Integer, condicion As String
                numero = dgvFacturas.SelectedRows(0).Cells(1).Value
                condicion = dgvFacturas.SelectedRows(0).Cells(2).Value
                nota = facFactura.TraerNotaDeCredito(numero, condicion)
                FrmFacturacion.MdiParent = Me.MdiParent
                FrmFacturacion.Show()
                FrmFacturacion.MainMenuStrip.Enabled = False
                FrmFacturacion.MostrarNotaDeCredito(nota)
            Else
                Dim vta As Venta, numero As Integer, condicion As String
                numero = dgvFacturas.SelectedRows(0).Cells(1).Value
                condicion = dgvFacturas.SelectedRows(0).Cells(2).Value
                vta = facFactura.TraerFactura(numero, condicion)
                FrmFacturacion.MdiParent = Me.MdiParent
                FrmFacturacion.Show()
                FrmFacturacion.MainMenuStrip.Enabled = False
                FrmFacturacion.MostrarVenta(vta)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        Dim numero As Integer, condicion As String, vta As Venta

        If Not IsNothing(dgvFacturas.SelectedRows(0)) Then
            numero = dgvFacturas.SelectedRows(0).Cells(1).Value
            condicion = dgvFacturas.SelectedRows(0).Cells(2).Value
            If MessageBox.Show("¿Realmente desea eliminar el comprobamte?" & vbCr & "Se actualizaràn los stocks de articulos.", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vta = facFactura.TraerFactura(numero, condicion)
                facFactura.Eliminar(vta)
                dgvFacturas.DataSource = facFactura.ListarFacturas()
            End If
        End If
    End Sub

    Private Sub cmdNotaDeCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotaDeCredito.Click
        Dim vta As Venta, numero As Integer, condicion As String, vtaOriginal As Venta
        numero = dgvFacturas.SelectedRows(0).Cells(1).Value
        condicion = dgvFacturas.SelectedRows(0).Cells(2).Value
        vta = facFactura.TraerFactura(numero, condicion)
        vtaOriginal = facFactura.TraerFactura(numero, condicion)
        FrmFacturacion.MdiParent = Me.MdiParent
        FrmFacturacion.Show()
        FrmFacturacion.notaDeCredito = True
        FrmFacturacion.vtaOriginal = vtaOriginal
        FrmFacturacion.MostrarVenta(vta)
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim vta As Venta, numero As Integer, condicion As String, vtaOriginal As Venta
        numero = dgvFacturas.SelectedRows(0).Cells(1).Value
        condicion = dgvFacturas.SelectedRows(0).Cells(2).Value
        vta = facFactura.TraerFactura(numero, condicion)
        vtaOriginal = facFactura.TraerFactura(numero, condicion)
        FrmFacturacion.MdiParent = Me.MdiParent
        FrmFacturacion.Show()
        FrmFacturacion.vtaOriginal = vtaOriginal
        FrmFacturacion.ImportarPedido(vta)
    End Sub


    Private Sub dgvFacturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFacturas.SelectionChanged
        Dim tipo As String
        Try
            tipo = dgvFacturas.SelectedRows(0).Cells(2).Value
            cmdImportar.Enabled = False
            cmdNotaDeCredito.Enabled = False
            If cmbTipo.Text = "NC" Then
                cmdNotaDeCredito.Enabled = False
                cmdImportar.Enabled = False
            Else
                If tipo = "P" Or tipo = "X" Then
                    cmdImportar.Enabled = True
                Else
                    cmdNotaDeCredito.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim vta As Venta, numero As Integer, condicion As String, vtaOriginal As Venta, nota As NotaDeCredito
        Try

       
            numero = dgvFacturas.SelectedRows(0).Cells(1).Value
            condicion = dgvFacturas.SelectedRows(0).Cells(2).Value

            If cmbTipo.Text = "NC" Then
                nota = facFactura.TraerNotaDeCredito(numero, condicion)
                frmVisualizarInformes.VisualizarNotaDeCredito(nota)
                frmVisualizarInformes.Show()
            Else
                vta = facFactura.TraerFactura(numero, condicion)
                frmVisualizarInformes.Visualizar(vta, 0)
                frmVisualizarInformes.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvFacturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellContentClick

    End Sub

    Private Sub txtDescripcionProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionProducto.KeyPress

        Dim i As Integer
        Dim idArt As IdArticulo

        For i = 0 To cmbProducto.Items.Count - 1
            idArt = cmbProducto.Items(i)
            If idArt.Descripcion.ToUpper.Contains(txtDescripcionProducto.Text.ToUpper) Then
                cmbProducto.SelectedIndex = i
                Exit For
            End If
        Next

    End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendedor.SelectedIndexChanged
        If cmbVendedor.SelectedIndex = -1 Then Exit Sub
        If cmbVendedor.SelectedIndex = 0 Then
            dgvFacturas.DataSource = facFactura.ListarFacturas()
            Exit Sub
        End If
        dgvFacturas.DataSource = facFactura.ListarFacturasPorVendedor(cmbVendedor.Text)
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.SelectedIndexChanged
        Dim idArt As IdArticulo
        idArt = cmbProducto.SelectedItem
        If IsNothing(idArt) Then Exit Sub
        dgvFacturas.DataSource = facFactura.ListarFacturasPorIdArticulo(idArt.Id)
    End Sub

    Private Sub cmbTipoProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoProducto.SelectedIndexChanged

    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.SelectedIndexChanged

    End Sub
End Class