Imports Fachada
Imports Modelo


Public Class frmUnidadesVendidas
    Dim facFactura As New FachadaFactura
    Dim faccliente As New FachadaCliente
    Dim facArt As New FachadaArticulo
    Dim fu As New FachadaUsuario
    Dim facPro As New FachadaProveedor
    Dim estaCargando As Boolean = True

    Private Sub frmUnidadesVendidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        facArt.CargarCombo(cmbProductos)
        cmbVendedores.DataSource = fu.listarUsuarios()
        cmbVendedores.SelectedIndex = -1
        facPro.CargarCombo(cmbProveedores)
        estaCargando = False
        'dtpdesde.Value = Date.Now.AddDays(-30)
        ResizearColumnas()
    End Sub

 
    Private Sub txtProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        Dim i As Integer
        Dim idArt As IdArticulo

        For i = 0 To cmbProductos.Items.Count - 1
            idArt = cmbProductos.Items(i)
            If idArt.Descripcion.ToUpper.Contains(txtProducto.Text.ToUpper) Then
                cmbProductos.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub txtProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProveedor.KeyPress
        Dim i As Integer
        Dim idPro As IdProveedor

        For i = 0 To cmbProveedores.Items.Count - 1
            idPro = cmbProveedores.Items(i)
            If idPro.RazonSocial.ToUpper.Contains(txtProveedor.Text.ToUpper) Then
                cmbProveedores.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If Not chkFecha.Checked Then Filtrar()
        gbFecha.Enabled = chkFecha.Checked
    End Sub

    Private Sub chkProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProveedor.CheckedChanged
        If Not chkProveedor.Checked Then Filtrar()
        gbProveedor.Enabled = chkProveedor.Checked
    End Sub

    Private Sub chkVendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVendedor.CheckedChanged
        If Not chkVendedor.Checked Then Filtrar()
        gbVendedor.Enabled = chkVendedor.Checked
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductos.SelectedIndexChanged
        ToolTipDetalles.SetToolTip(cmbProductos, cmbProductos.Text)
        Filtrar()
    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.SelectedIndexChanged
        ToolTipDetalles.SetToolTip(cmbProveedores, cmbProveedores.Text)
        Filtrar()
    End Sub

    Private Sub chkFP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFP.CheckedChanged
        If Not chkFP.Checked Then Filtrar()
        gbFP.Enabled = chkFP.Checked
    End Sub

    Private Sub dtphasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphasta.ValueChanged
        Filtrar()
    End Sub
    Private Sub Filtrar()
        If estaCargando Then Exit Sub
        Dim condicionStr As String = ""
        Dim hayUnaCondicion As Boolean = False

        If chkFecha.Checked Then
            Dim fechaDesdeSTR As String, fechaHastaSTR As String
            fechaDesdeSTR = CStr(dtpdesde.Value.Year) & "-" & CStr(dtpdesde.Value.Month) & "-" & CStr(dtpdesde.Value.Day)
            fechaHastaSTR = CStr(dtphasta.Value.Year) & "-" & CStr(dtphasta.Value.Month) & "-" & CStr(dtphasta.Value.Day)
            condicionStr = " fechaemision between '" & fechaDesdeSTR & "' and '" & fechaHastaSTR & "' "
            hayUnaCondicion = True
        End If
        If chkProveedor.Checked And Not IsNothing(cmbProveedores.SelectedItem) Then
            If hayUnaCondicion Then condicionStr += " and "
            Dim idProv As IdProveedor
            idProv = cmbProveedores.SelectedItem
            condicionStr += " pr.idproveedor = " & CStr(idProv.Id)
            hayUnaCondicion = True
        End If
        If chkVendedor.Checked Then
            If hayUnaCondicion Then condicionStr += " and "
            condicionStr += " venta.nick = '" & cmbVendedores.Text & "' "
            hayUnaCondicion = True
        End If
        If chkProducto.Checked And Not IsNothing(cmbProductos.SelectedItem) Then
            If hayUnaCondicion Then condicionStr += " and "
            Dim idArt As IdArticulo
            idArt = cmbProductos.SelectedItem
            condicionStr += " art.idarticulo = " & CStr(idArt.Id)
            hayUnaCondicion = True
        End If
        If chkFP.Checked Then
            If hayUnaCondicion Then condicionStr += " and "
            If cmbFP.SelectedIndex = 0 Then
                '0 Efectivo
                condicionStr += " montotarjeta = 0"
            Else
                '1 Tarjeta
                condicionStr += " montotarjeta > 0"
            End If
        End If
        dgvFacturas.DataSource = facFactura.TraerUnidadesVendidas(condicionStr)
        llenarTotales()
    End Sub

    Private Sub cmbFP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFP.SelectedIndexChanged
        Filtrar()
    End Sub

    Private Sub cmbVendedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendedores.SelectedIndexChanged
        Filtrar()
    End Sub
    Public Sub llenarTotales()
        txtUnidades.Text = "0"
        txtTotales.Text = "0"
        For Each linea As DataGridViewRow In dgvFacturas.Rows

            Dim total As Double
            Dim unidades As Integer
            total += linea.Cells(5).Value
            unidades += linea.Cells(4).Value
            txtUnidades.Text = unidades
            txtTotales.Text = Math.Round(total, 2)

        Next
    End Sub

    Private Sub dtpdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdesde.ValueChanged
        Filtrar()
    End Sub

    Private Sub chkProducto_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProducto.CheckedChanged
        If Not chkProducto.Checked Then Filtrar()
        gbProducto.Enabled = chkProducto.Checked
    End Sub

    Public Sub ResizearColumnas()

        'dgvFacturas.Columns(0).Width = 38
        'dgvFacturas.Columns(1).Width = 83
        'dgvFacturas.Columns(2).Width = 29
        'dgvFacturas.Columns(3).Width = 243
        'dgvFacturas.Columns(4).Width = 30
        'dgvFacturas.Columns(5).Width = 45
        'dgvFacturas.Columns(6).Width = 50
        'dgvFacturas.Columns(7).Width = 169



    End Sub


End Class