Imports Modelo
Imports Fachada

Public Class FrmFacturacion

    Private WithEvents frmArtBuscar As FrmArticuloBuscar
    Dim facArticulo As New FachadaArticulo
    Dim facCliente As New FachadaCliente
    Dim facFactura As New FachadaFactura
    Dim facCaja As New FachadaCajaDiaria
    Dim fu As New FachadaUsuario
    Dim vta As New Venta
    Dim tipoFacturaAnterior As String
    Public notaDeCredito As Boolean
    Public vtaOriginal As Venta
    Public TotalFactura As String
    Dim objNotaDeCredito As NotaDeCredito
    Dim codigo_barra As String
    Dim cantidad As Integer = 1
    Dim encontrado As Boolean
    Dim WithEvents frm As frmMonto
    Dim esMixto As Boolean = False

    Public Sub MostrarVenta(ByVal fac As Venta)
        If notaDeCredito Then NotaDeCreditoToolStripMenuItem_Click(Me.CboTipoDeComprobante, New EventArgs())

        vta = fac

        'Selecciono el cliente
        For Each idcli As IdCliente In cmbCliente.Items
            If idcli.Id = vta.IdCliente Then
                cmbCliente.SelectedItem = idcli
                Exit For
            End If
        Next
        For Each usu As Usuario In cmbVendedor.Items
            If usu.Nick = vta.Nick Then
                cmbVendedor.SelectedItem = usu
                Exit For
            End If
        Next
        Dim cat As String
        Dim mar As String
        For Each r As RenglonComprobante In fac.Renglones
            If Not IsNothing(r.Articulo) Then
                mar = facArticulo.traerMarcaPorId(r.Articulo.IdMarca)
                cat = facArticulo.traerTipoPorId(r.Articulo.Idcategoria)
                r.Descripcion = r.Descripcion & " " & cat & " " & mar
            End If
        Next
        ActualizarRenglones()
        cmbCliente.Enabled = False
        CboTipoDeComprobante.Enabled = False
        CboTipoDeComprobante.Text = vta.CondicionVenta
        lblNumeroFactura.Text = vta.Numero

        If notaDeCredito Then
            objNotaDeCredito = New NotaDeCredito
            objNotaDeCredito.IdVenta = fac.IdVenta
            objNotaDeCredito.NumeroFactura = fac.Numero
            CboTipoDeComprobante.Text = fac.CondicionVenta
            Exit Sub
        End If

        If vta.Porcentaje > 0 Or vta.MontoTarjeta > 0 Then
            RadioButTarjeta.Checked = True
            txtPorcentajeTarjeta.Text = Math.Round(vta.Porcentaje, 2)
            frmTarjeta.Visible = True
        End If

        CmdArmarRenglon.Enabled = False

        cmdCancelar.Enabled = False
        cmbVendedor.Enabled = True
        cmdFinalizar.Enabled = False
        cmdModificarItem.Enabled = False
        cmdQuitarItem.Enabled = False
        cboCantidadDeCopias.Enabled = False
        btnModificar.Visible = True

    End Sub

    Public Sub MostrarNotaDeCredito(ByVal nc As NotaDeCredito)
        NotaDeCreditoToolStripMenuItem_Click(Me.CboTipoDeComprobante, New EventArgs())
        vta.Renglones = nc.Renglones

        'Selecciono el cliente
        For Each idcli As IdCliente In cmbCliente.Items
            If idcli.Id = nc.IdCliente Then
                cmbCliente.SelectedItem = idcli
                Exit For
            End If
        Next
        For Each usu As Usuario In cmbVendedor.Items
            If usu.Nick = nc.Nick Then
                cmbVendedor.SelectedItem = usu
                Exit For
            End If
        Next
        Dim cat As String
        Dim mar As String
        For Each r As RenglonComprobante In nc.Renglones
            If Not IsNothing(r.Articulo) Then
                mar = facArticulo.traerMarcaPorId(r.Articulo.IdMarca)
                cat = facArticulo.traerTipoPorId(r.Articulo.Idcategoria)
                r.Descripcion = r.Descripcion & " " & cat & " " & mar
            End If
        Next
        ActualizarRenglones()
        cmbCliente.Enabled = False
        CboTipoDeComprobante.Enabled = False




        CboTipoDeComprobante.Text = nc.CondicionVenta
        lblNumeroFactura.Text = nc.Numero
        CmdArmarRenglon.Enabled = False

        cmdCancelar.Enabled = False
        cmbVendedor.Enabled = False
        cmdFinalizar.Enabled = False
        cmdModificarItem.Enabled = False
        cmdQuitarItem.Enabled = False
        cboCantidadDeCopias.Enabled = False
    End Sub

    Public Sub ImportarPedido(ByVal ped As Venta)
        vta = ped

        'Selecciono el cliente
        For Each idcli As IdCliente In cmbCliente.Items
            If idcli.Id = vta.IdCliente Then
                cmbCliente.SelectedItem = idcli
                Exit For
            End If
        Next
        For Each usu As Usuario In cmbVendedor.Items
            If usu.Nick = vta.Nick Then
                cmbVendedor.SelectedItem = usu
                Exit For
            End If
        Next
        CboTipoDeComprobante.Text = "X"
        Dim cat As String
        Dim mar As String
        For Each r As RenglonComprobante In ped.Renglones
            If Not IsNothing(r.Articulo) Then
                mar = facArticulo.traerMarcaPorId(r.Articulo.IdMarca)
                cat = facArticulo.traerTipoPorId(r.Articulo.Idcategoria)
                r.Descripcion = r.Descripcion & " " & cat & " " & mar
            End If

        Next

        If vta.Porcentaje > 0 Then
            RadioButTarjeta.Checked = True
            txtPorcentajeTarjeta.Text = Math.Round(vta.Porcentaje, 2)
            frmTarjeta.Visible = True
        End If

        ActualizarRenglones()

        lblNumeroFactura.Text = vta.Numero


    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        facCliente.CargarCombo(cmbCliente)
        cmbVendedor.DataSource = fu.listarUsuarios()
        cmbVendedor.DisplayMember = "nick"
        lblNotadeCredito.Visible = False
        cmbCliente.Text = "CONSUMIDOR FINAL"
        cmbVendedor.Text = Sesion.getSesion.UsuarioActivo.Nick
        CboTipoDeComprobante.Text = "X"
        CheckRemito.Checked = False
        txtLector.Focus()
    End Sub

    Private Sub NuevaFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaFacturaToolStripMenuItem.Click
        dgvRenglones.DataSource = Nothing
        vta = New Venta
        ActualizarRenglones()
        GroupBox1.Visible = True
        cmbCliente.Text = "AA"
        lblNotadeCredito.Visible = False
        CboTipoDeComprobante.Items.Clear()
        CboTipoDeComprobante.Items.Add("X")
        CboTipoDeComprobante.Items.Add("B")
        CboTipoDeComprobante.Items.Add("A")
        CboTipoDeComprobante.Items.Add("P")
        CboTipoDeComprobante.Items.Add("C")
        CboTipoDeComprobante.Text = "X"
        txtPorcentajeTarjeta.Text = "0"
        RadioButContado.Checked = True
        frmTarjeta.Visible = False

    End Sub



    Private Sub picBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBuscar.Click
        'FrmClienteBuscar.MdiParent = Me.MdiParent
        FrmClienteBuscar.cmdNuevoCliente.Visible = True
        FrmClienteBuscar.cmdSeleccionar.Visible = True
        FrmClienteBuscar.ShowDialog()
        facCliente.CargarCombo(cmbCliente)
        If FrmClienteBuscar.idClienteSeleccionado = 0 Then Exit Sub
        For Each clie As IdCliente In cmbCliente.Items
            If clie.Id = FrmClienteBuscar.idClienteSeleccionado Then
                cmbCliente.SelectedItem = clie
            End If
        Next
    End Sub

    Private Sub CmdArmarRenglon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdArmarRenglon.Click
        'se elimino el limete en la fatura
        'If vta.Renglones.Count > 47 Then
        'MessageBox.Show("Debe confeccionar una nueva factura, esta ha llegado al limite de renglones permitidos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Exit Sub
        'End If


        frmArtBuscar = New FrmArticuloBuscar()
        tipoFacturaAnterior = CboTipoDeComprobante.Text
        If cmbCliente.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un cliente para realizar la operación", "Seleccione el cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False

        frmArtBuscar.txtCantidadItems.Text = Me.txtCantidadItems.Text
        frmArtBuscar.ShowDialog()

        'Application.DoEvents()

        txtLector.Focus()

    End Sub

    Private Sub AgregarRenglon(ByVal idArticulo As Integer, ByVal cantidad As Double, ByVal PU As Double) Handles frmArtBuscar.AgregarRenglon
        Dim art As Articulo = facArticulo.TraerArticulo(idArticulo)
        If vta.Renglones.Count > 15 Then
            MessageBox.Show("Debe confeccionar una nueva factura, esta ha llegado al limite de renglones permitidos (15 máx.)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            'verifico que no este agregado el articulo
            'For Each r As RenglonComprobante In vta.Renglones
            '    If Not IsNothing(r.Articulo) Then
            '        If r.Articulo.IdArticulo = idArticulo Then
            '            Throw New Exception("El articulo ya esta ingresado")
            '        End If
            '    End If

            'Next
            art.Precio = PU
            Dim renglon As New RenglonComprobante

            If cantidad = 0 Then
                'Se da soporte al nuevo requisito que dice cuando un articulo tiene precio 0 se debe poner en el momento
                'de facturarlo
                Dim valor As String
                valor = InputBox("Ingrese el precio del articulo", "Ingresar Precio")
                art.Precio = CDbl(valor)
                PU = art.Precio
            End If


            renglon.CantADisminuir = cantidad
            renglon.Cantidad = cantidad

            If art.esFraccionable Then

                frmFraccionar.PasarArticulo(art, cantidad)
                frmFraccionar.ShowDialog()
                If frmFraccionar.Cancelo = False Then
                    PU = frmFraccionar.precioFraccion
                    art = frmFraccionar.a
                    renglon.CantADisminuir = frmFraccionar.cantidadAsisminUIR
                Else
                    Exit Sub
                End If
            End If

            If notaDeCredito = False And renglon.CantADisminuir > art.Stock Then
                'Throw New StockInsuficienteException
            End If
            renglon.PrecioUnitario = PU
            If CboTipoDeComprobante.Text = "A" Then
                'discrimino el iva
                renglon.PrecioUnitario = PU / 1.21

            End If

            renglon.Articulo = art
            Dim cat As String
            Dim mar As String

            mar = facArticulo.traerMarcaPorId(art.IdMarca)
            cat = facArticulo.traerTipoPorId(art.Idcategoria)
            renglon.Descripcion = art.Descripcion & " " & cat & " " & mar
            If notaDeCredito Then
                'verifico si la cantidad a acreditar es mayor que la vendida
                Dim estaElArticulo As Boolean
                estaElArticulo = False
                For Each r As RenglonComprobante In vtaOriginal.Renglones
                    If Not IsNothing(r.Articulo) Then
                        If renglon.Articulo.IdArticulo = r.Articulo.IdArticulo Then
                            estaElArticulo = True
                            If renglon.Cantidad > r.Cantidad Then
                                MessageBox.Show("No puede ingresar una cantidad mayor a la vendida", "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        End If
                    End If
                Next
                If estaElArticulo = False Then
                    MessageBox.Show("No puede ingresar un articulo que no fue vendido en la factura", "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            vta.Renglones.Add(renglon)
            dgvRenglones.DataSource = Nothing




            ActualizarRenglones()



            txtLector.Focus()

        Catch ex As StockInsuficienteException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Stock insuficiente")
            'frmArtBuscar.txtCantidadItems.Text -= 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Articulo existente")
            'frmArtBuscar.txtCantidadItems.Text -= 1
        End Try


    End Sub

    Private Sub AgregarInexistente(ByVal desc As String, ByVal cant As Double, ByVal pu As Double) Handles frmArtBuscar.AgregarInexistente
        Dim rc As New RenglonComprobante
        rc.Cantidad = cant
        rc.Descripcion = desc
        rc.PrecioUnitario = pu
        vta.Renglones.Add(rc)
        dgvRenglones.DataSource = Nothing
        ActualizarRenglones()
    End Sub
    Private Sub ActualizarRenglones()
        dgvRenglones.DataSource = Nothing
        dgvRenglones.Rows.Clear()
        If dgvRenglones.Columns.Count = 0 Then
            dgvRenglones.Columns.Add("articulo", "Descripcion")
            dgvRenglones.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvRenglones.Columns(0).Width = 257

            dgvRenglones.Columns.Add("cantidad", "Cantidad")
            dgvRenglones.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvRenglones.Columns(1).Width = 50
            dgvRenglones.Columns.Add("PU", "PU")
            dgvRenglones.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvRenglones.Columns(2).Width = 51
            dgvRenglones.Columns.Add("SubTotal", "SubTotal")
            dgvRenglones.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvRenglones.Columns(3).Width = 70




        End If
        Dim cantProductos As Integer = 0

        For Each rc As RenglonComprobante In vta.Renglones
            dgvRenglones.Rows.Add(rc.Descripcion, rc.Cantidad, Math.Round(rc.PrecioUnitario, 2), Math.Round(rc.SubTotal, 2))
            If IsNothing(rc.Articulo) = False Then
                dgvRenglones.Rows(dgvRenglones.Rows.Count - 1).Tag = rc.Articulo.IdArticulo
            End If
            cantProductos = cantProductos + rc.Cantidad
        Next
        If dgvRenglones.Rows.Count > 10 Then dgvRenglones.FirstDisplayedScrollingRowIndex = dgvRenglones.Rows.Count - 10
        lblSubtotal.Text = "" & Math.Round(vta.Total, 2)
        If CboTipoDeComprobante.Text = "A" Then

            lblToTaL.Text = "" & Math.Round(vta.TotalMasIVA, 2)
            lblIva.Text = CStr(Math.Round(vta.TotalIVA, 2))
            lblSubtotal.Text = CStr(Math.Round(vta.Total, 2))

        
        Else 'ES X B o P
            lblIva.Text = 0
            lblToTaL.Text = "" & Math.Round(vta.Total, 2)
            lblSubtotal.Text = Math.Round(vta.Total, 2) - CDbl(lblInteres.Text)
        End If
        'calculo interes
        If RadioButTarjeta.Checked = True Then
            Dim precioSinInteres As Double
            precioSinInteres = CDbl(lblToTaL.Text)
            lblToTaL.Text = Math.Round(precioSinInteres + precioSinInteres * CDbl(txtPorcentajeTarjeta.Text) / 100, 2)
            lblInteres.Text = Math.Round(precioSinInteres * CDbl(txtPorcentajeTarjeta.Text) / 100, 2)



        End If
        txtCantidadItems.Text = cantProductos

        'calculo el desc
        Dim precioSindesc As Double
        precioSindesc = CDbl(lblToTaL.Text)
        lblToTaL.Text = Math.Round(precioSindesc - precioSindesc * CDbl(txtDescuento.Text) / 100, 2)
        lblDescuento.Text = Math.Round(precioSindesc * CDbl(txtDescuento.Text) / 100, 2)

        'frmArtBuscar.txtTotalFac.Text = lblToTaL.Text
    End Sub
    Private Sub agregarRenlonInteres()
        Dim rcInteres As New RenglonComprobante
        rcInteres.Cantidad = 1
        rcInteres.Descripcion = "Recargo por tarjeta"
        rcInteres.PrecioUnitario = lblInteres.Text
        vta.Renglones.Add(rcInteres)
        'dgvRenglones.DataSource = Nothing
    End Sub
    Private Sub agregarRenlonDescuento()
        Dim rcDesc As New RenglonComprobante
        rcDesc.Cantidad = 1
        rcDesc.Descripcion = "Descuento"
        rcDesc.PrecioUnitario = CDbl(lblDescuento.Text) * (-1)
        vta.Renglones.Add(rcDesc)
        'dgvRenglones.DataSource = Nothing
    End Sub
    Private Sub TipoDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeProductoToolStripMenuItem.Click

        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.txtCantidadItems.Text = Me.txtCantidadItems.Text
        frmArtBuscar.seleccionBusqueda = True
        frmArtBuscar.cmbBuscarPor.SelectedIndex = 1
        frmArtBuscar.txtQueContenga.Text = ""
        frmArtBuscar.txtQueContenga.Select()
        frmArtBuscar.ShowDialog()
        txtLector.Focus()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.seleccionBusqueda = True
        frmArtBuscar.txtCantidadItems.Text = Me.txtCantidadItems.Text
        frmArtBuscar.cmbBuscarPor.SelectedIndex = 3
        frmArtBuscar.txtQueContenga.Text = ""
        frmArtBuscar.txtQueContenga.Select()
        frmArtBuscar.ShowDialog()
        txtLector.Focus()
    End Sub

    Private Sub DescripcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionToolStripMenuItem.Click
        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar = New FrmArticuloBuscar()
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.encontrado = False
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.seleccionBusqueda = True
        frmArtBuscar.cmbBuscarPor.SelectedIndex = 2
        frmArtBuscar.txtQueContenga.Text = ""
        frmArtBuscar.txtQueContenga.Select()
        frmArtBuscar.ShowDialog()
        txtLector.Focus()
    End Sub

    Private Sub ClientePredeterminadoF12ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientePredeterminadoF12ToolStripMenuItem.Click
        txtLector.Focus()
    End Sub

    Private Sub NotaDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCreditoToolStripMenuItem.Click
        lblNotadeCredito.Visible = True
        GroupBox1.Visible = False
        CboTipoDeComprobante.Items.Clear()
        CboTipoDeComprobante.Items.Add("A")
        CboTipoDeComprobante.Items.Add("B")
        CboTipoDeComprobante.Items.Add("X")
        CboTipoDeComprobante.Text = "X"
        objNotaDeCredito = New NotaDeCredito
        vta = New Venta
    End Sub

    Private Sub cmdQuitarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarItem.Click
        If dgvRenglones.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim indice As Integer
        indice = dgvRenglones.SelectedRows(0).Index
        vta.Renglones.RemoveAt(indice)
        ActualizarRenglones()
    End Sub

    Private Sub cmdModificarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarItem.Click
        If dgvRenglones.Rows.Count = 0 Then
            Exit Sub
        End If
        If IsNothing(vta.Renglones(dgvRenglones.SelectedRows(0).Index).Articulo) Then
            'es un inexistente muestro el form de agregar inexistente ocn los datos del articulo
            MessageBox.Show("Debe eliminar el inexistente, y luego agregar otro", "Articulo inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.Show()
        Dim valor As String
        valor = dgvRenglones.SelectedRows(0).Cells(0).Value
        frmArtBuscar.cmbBuscarPor.SelectedIndex = 0
        frmArtBuscar.cmdBuscar_Click(sender, e)
        Dim desc As String
        desc = vta.Renglones(dgvRenglones.SelectedRows(0).Index).Articulo.Descripcion
        Dim idArt As Integer
        idArt = dgvRenglones.SelectedRows(0).Tag
        For Each fila As DataGridViewRow In frmArtBuscar.DataGridView1.Rows
            If CInt(fila.Cells(0).Value.ToString()) = idArt Then
                fila.Selected = True
                frmArtBuscar.DataGridView1.CurrentCell = fila.Cells(0)
                Exit For
            End If
        Next

        frmArtBuscar.txtCantidad.Text = dgvRenglones.SelectedRows(0).Cells(1).Value
        frmArtBuscar.txtDetalle.Text = dgvRenglones.SelectedRows(0).Cells(0).Value
        frmArtBuscar.txtPU.Text = dgvRenglones.SelectedRows(0).Cells(2).Value
        frmArtBuscar.txtCantidad.Select()
        Dim indice As Integer
        indice = dgvRenglones.SelectedRows(0).Index
        vta.Renglones.RemoveAt(indice)
        ActualizarRenglones()
    End Sub

    Private Sub cmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizar.Click
        'Valido que esten ingresados todos los campos necesarios
        'Application.DoEvents()
        If dgvRenglones.Rows.Count = 0 Then
            MessageBox.Show("Para realizar la factura debe haber al menos un itema", "Facturación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            cmdFinalizar.Enabled = False

            Dim montoEfectivo As Double
            Dim sumaTotal As Double


            If cmbVendedor.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un vendedor para realizar la operación", "Seleccione el vendedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbVendedor.Select()
                Exit Sub
            End If
            If RadioButCtaCte.Checked = True Then
                Dim fachadaV As New FachadaFactura
                Dim x As Integer
                x = CType(cmbCliente.SelectedItem, IdCliente).Id
                Dim suma As DataTable
                suma = fachadaV.SumarLasVentas(x)

                If IsDBNull(suma.Columns(0).Table.Rows(0).Item(0)) Then
                    sumaTotal = 0
                Else
                    sumaTotal = suma.Columns(0).Table.Rows(0).Item(0)
                End If
                sumaTotal = sumaTotal + lblToTaL.Text
                sumaTotal = Math.Round(sumaTotal, 2)
                Dim facha As New FachadaFactura
                Dim credito As DataTable
                credito = facha.ChequearCredito(x)
                Dim creditoTotal As Double
                creditoTotal = credito.Columns(0).Table.Rows(0).Item(0)
                Dim fachada3 As New FachadaFactura
                Dim dta As DataTable
                dta = fachada3.SumarPagos(CType(cmbCliente.SelectedItem, IdCliente).Id)
                Dim montoPagado As Double
                montoPagado = 0
                If Not IsDBNull(dta.Rows(0).Item(0)) Then
                    montoPagado = dta.Rows(0).Item(0)
                End If

                montoEfectivo = sumaTotal




                If sumaTotal - montoPagado > creditoTotal Then
                    MsgBox("El cliente ha llegado a su limite de credito!!")
                    Exit Sub
                End If

            ElseIf RadioButTarjeta.Checked Then
                'pregunto cuanto paga con tarjeta o mixto 
                Dim montoTarjeta As Double = 0
                'Dim montoTarjetaSTR As String
                sumaTotal = lblToTaL.Text

                frmMonto.MostrarInputBox("Ingrese el monto abonado con tarjeta", lblToTaL.Text, lblToTaL.Text)
                montoTarjeta = frmMonto.GetInstancia().Monto

                If frmMonto.GetInstancia().Descuento > 0 Then
                    MessageBox.Show("No debe ingresar descuentos en un pago realizado con tarjeta." & vbCr & "Solo lo puede ingresar en efectivo", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    frmMonto.GetInstancia().Descuento = 0
                    frmMonto.GetInstancia().Monto = 0
                    Exit Sub
                End If

                'montoTarjetaSTR = InputBox("Ingrese el monto abonado con tarjeta", "Monto tarjeta")
                If montoTarjeta = 0 Then
                    MessageBox.Show("Debe ingresar el monto con tarjeta.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                vta.MontoTarjeta = montoTarjeta
                montoEfectivo = Math.Round((sumaTotal - montoTarjeta), 2)
                If montoEfectivo > 0 Then
                    'solicito el monto del pago para calcular el vuelto
                    Dim montoPagado As Double

                    frmMonto.MostrarInputBox("Ingrese el monto pagado con efectivo", montoEfectivo, lblToTaL.Text)
                    'frmMonto.MostrarInputBox("Ingrese el monto pagado con efectivo" & vbCr & "Si desea ingresar un dto digite signo '-' y el descuento ej: 100-20", montoEfectivo, vta.Total)

                    vta.Descuento = frmMonto.GetInstancia.Descuento
                    montoPagado = frmMonto.GetInstancia.Monto
                    If frmMonto.GetInstancia.Acepto = False Then Exit Sub
                    Dim vuelto As Double
                    If montoPagado < montoEfectivo - vta.Descuento Then
                        MessageBox.Show("El monto en efectivo debe ser al menos: $" + CStr(montoEfectivo), "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        frmMonto.GetInstancia().Descuento = 0
                        frmMonto.GetInstancia().Monto = 0
                        Exit Sub
                    End If
                    'montoPagado = Double.Parse(montoPagadoSTR)
                    vuelto = Math.Round((montoPagado + vta.Descuento) - montoEfectivo, 2)
                    lblToTaL.Text = Math.Round(vta.Total, 2)
                    MessageBox.Show("El vuelto a entregar es de $: " & CStr(vuelto), "Vuelto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'termino el calculo del vuelto 
                    'facCaja.MovimientoDeSaldo(montoEfectivo)
                End If

                'MessageBox.Show("Resta abonar en efectivo: $ " & montoEfectivo, "Resto", MessageBoxButtons.OK, MessageBoxIcon.Information)



            End If

            'If MessageBox.Show("¿Desea Finalizar la operación?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            '    Exit Sub
            'End If

            'Try

            'verifico si es una nota de credito  

            If lblNotadeCredito.Visible = True Then

                objNotaDeCredito.Renglones = vta.Renglones
                With objNotaDeCredito
                    .FechaEmision = Date.Now
                    .IdCliente = CType(cmbCliente.SelectedItem, IdCliente).Id
                    .IdTipoVenta = RadioButCtaCte.Checked
                    .Nick = CType(cmbVendedor.SelectedItem, Usuario).Nick
                    .Numero = facFactura.TraerNumeroNotaDeCredito(CboTipoDeComprobante.Text)
                    .NumeroFactura = vta.Numero
                    .Hora = Date.Now
                    .CondicionVenta = CboTipoDeComprobante.Text
                End With

                facFactura.ingresarNotaDeCredito(objNotaDeCredito)

                ' frmVisualizarInformes.VisualizarNotaDeCredito(objNotaDeCredito)
                '********************ACA VA LA IMPRESION **********************************************************
                Impresora.imprimir(objNotaDeCredito)


                frmVisualizarInformes.Show()
                dgvRenglones.Rows.Clear()
                objNotaDeCredito = New NotaDeCredito
                vta = New Venta
            Else 'es una venta
                'cargo los datos a la venta y la persisto 

                If RadioButContado.Checked Then
                    'solicito el monto del pago para calcular el vuelto
                    Dim montoPagado As Double
                    'Dim montoPagadoSTR As String
                    'frmMonto.MostrarInputBox("Ingrese el monto pagado con efectivo" & vbCr & "Si desea ingresar un dto digite signo '-' y el descuento ej: 100-20", lblToTaL.Text, vta.Total)
                    frmMonto.MostrarInputBox("Ingrese el monto pagado con efectivo", lblToTaL.Text, vta.Total)

                    vta.Descuento = frmMonto.GetInstancia.Descuento
                    montoPagado = frmMonto.GetInstancia.Monto
                    If frmMonto.GetInstancia.Acepto = False Then Exit Sub
                    Dim vuelto As Double
                    If montoPagado < vta.Total Then
                        MessageBox.Show("El monto en efectivo debe ser al menos: $" + CStr(Math.Round(vta.Total, 2)), "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                    If CboTipoDeComprobante.Text = "A" Then
                        vuelto = Math.Round((montoPagado - vta.TotalMasIVA), 2)
                        lblToTaL.Text = Math.Round(vta.TotalMasIVA, 2)
                    Else
                        vuelto = Math.Round((montoPagado - vta.Total), 2)
                        lblToTaL.Text = Math.Round(vta.Total, 2)
                    End If


                    MessageBox.Show("El vuelto a entregar es de $: " & CStr(vuelto), "Vuelto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'termino el calculo del vuelto 
                    'facCaja.MovimientoDeSaldo(vta.Total)
                End If

                With vta
                    .FechaEmision = Date.Now
                    .IdCliente = CType(cmbCliente.SelectedItem, IdCliente).Id
                    .IdTipoVenta = RadioButCtaCte.Checked
                    .Nick = CType(cmbVendedor.SelectedItem, Usuario).Nick
                    '.Numero = facFactura.TraerNumero(CboTipoDeComprobante.Text)
                    .Pagado = False
                    .Hora = Date.Now
                    .CondicionVenta = CboTipoDeComprobante.Text
                    .Pagado = RadioButContado.Checked
                    .Porcentaje = txtPorcentajeTarjeta.Text
                End With
                vta.Descuento = frmMonto.GetInstancia.Descuento
                If RadioButTarjeta.Checked = True Then
                    agregarRenlonInteres()
                End If
                If CDbl(txtDescuento.Text > 0) Then
                    agregarRenlonDescuento()
                End If

                facFactura.ingresarFactura(vta)


                ''frmVisualizarInformes.Show()

                'frmVisualizarInformes.Visualizar(vta, cboCantidadDeCopias.Text)
                '********************ACA VA LA IMPRESION **********************************************************
                'Application.DoEvents()

                'If chkImprimir.Checked Then hiloSegundoPlano.RunWorkerAsync(vta) 'Impresora.imprimirTicket(vta)
                'Application.DoEvents()

                frmVisualizarInformes.llevaRemito = CheckRemito.Checked
                'impresion para A4 de i2Online
                '***************************************************************************************
                If CboTipoDeComprobante.Text = "A" Or CboTipoDeComprobante.Text = "B" Then
                    frmVisualizarInformes.Visualizar(vta, cboCantidadDeCopias.Text)
                Else
                    frmVisualizarInformes.Visualizar(vta, cboCantidadDeCopias.Text)
                End If


                ' Imprimo remito
                'If CheckRemito.Checked = True Then
                '    frmVisualizarInformes.Visualizar(vta, 2)
                'End If

                '***************************************************************************************

                vta = New Venta
                dgvRenglones.Rows.Clear()
                txtCantidadActual.Text = "0"

                NuevaFacturaToolStripMenuItem_Click(sender, e)
                'MessageBox.Show("Operación realizada correctamente", "Saturn 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            'End Try
            txtCantidadItems.Text = 0
            vta.Descuento = 0
            lblDescuento.Text = "0"
            frmMonto.GetInstancia.Descuento = 0
            lblToTaL.Text = "0"
            cboCantidadDeCopias.Text = 1
            CheckRemito.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdFinalizar.Enabled = True
            CheckRemito.Checked = False
        End Try
    End Sub

    Private Sub CboTipoDeComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoDeComprobante.SelectedIndexChanged
        'traigo el numero de factura que corresponde dependiendo del tipo de comprobante
        CambiarColor()
        If CboTipoDeComprobante.Text = "A" Then
            For Each r As RenglonComprobante In vta.Renglones
                r.PrecioUnitario = r.PrecioUnitario / 1.21
            Next
        End If
        If tipoFacturaAnterior = "A" And CboTipoDeComprobante.Text <> "A" Then
            For Each r As RenglonComprobante In vta.Renglones
                r.PrecioUnitario = r.PrecioUnitario * 1.21
            Next
        Else

        End If
        tipoFacturaAnterior = CboTipoDeComprobante.Text
        lblNumeroFactura.Text = facFactura.TraerNumero(CboTipoDeComprobante.Text)
        Call ActualizarRenglones()
    End Sub

    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTotalToolStripMenuItem.Click
        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.grupoRenglon.Visible = True
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.ShowDialog()
        txtLector.Focus()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        Dim cli As Cliente
        cli = facCliente.TraerPorId(CType(cmbCliente.SelectedItem, IdCliente).Id)
        Select Case cli.IdIva
            Case 1 'CONSUMIDOR FINAL
                CboTipoDeComprobante.Text = "B"
            Case 2 'EXENTO
                CboTipoDeComprobante.Text = "B"
            Case 3 'RESPONSABLE INSCRIPTO
                CboTipoDeComprobante.Text = "A"
            Case 4 'RESPONSABLE NO INSCRIPTO
                CboTipoDeComprobante.Text = "A"
            Case 5 'MONOTRIBUTO
                CboTipoDeComprobante.Text = "B"
            Case 6 'NO RESPONSABLE
        End Select
    End Sub


    Private Sub AnularFacturaF3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularFacturaF3ToolStripMenuItem.Click
        frmFacturasBuscar.MdiParent = FrmPrincipal
        frmFacturasBuscar.Show()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If MessageBox.Show("Realmente desea cancelar la Factura?", "Confirme la cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dgvRenglones.DataSource = Nothing
            vta = New Venta
            ActualizarRenglones()
        End If
    End Sub
    Private Sub CambiarColor()
        Select Case CboTipoDeComprobante.Text
            Case "A"
                dgvRenglones.BackgroundColor = Color.FromArgb(255, 255, 192)
            Case "B"
                dgvRenglones.BackgroundColor = Color.FromArgb(192, 192, 255)
            Case "X"
                dgvRenglones.BackgroundColor = Color.FromArgb(235, 254, 251)
            Case "P"
                dgvRenglones.BackgroundColor = Color.FromArgb(255, 224, 192)
        End Select
    End Sub

    Private Sub btnIngresarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarCliente.Click
        Dim cli As New Cliente
        cli.Nombre = InputBox("Ingrese el nombre:", "Nuevo Cliente")
        cli.CUIT = "11111111111"
        cli.FechaAlta = Date.Now
        cli.IdRubro = 1
        cli.IdIva = 1
        If cli.Nombre.Trim() = "" Then Exit Sub
        Dim dom As Domicilio
        frmDomicilio.LimpiarFormulario()
        frmDomicilio.txtCalle.Select()
        frmDomicilio.ShowDialog()
        If frmDomicilio.cancelo Then
            MessageBox.Show("El cliente no ha sido dado de alta", "Cliente no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        dom = frmDomicilio.DataSource
        cli.Domicilios.Add(dom.Calle & dom.Altura, dom)
        facCliente.AltaCliente(cli)
        cmbCliente.Items.Clear()
        facCliente.CargarCombo(cmbCliente)
        For Each id As IdCliente In cmbCliente.Items
            If id.Id = cli.IdCliente Then
                cmbCliente.SelectedItem = id
            End If
        Next
        ''cmbCliente.Text = cli.Nombre
        CboTipoDeComprobante.Text = "X"
    End Sub

    Private Sub txtPorcentajeTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentajeTarjeta.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
        'If Asc(e.KeyChar) = 13 Then
        '    'ACA ACTUALIZAMOS EL PRECIO DE EL ARTICULO EN MEMORIA
        '    Dim aumento As Double
        '    aumento = 0
        '    For Each r As RenglonComprobante In vta.Renglones
        '        'r.PrecioUnitario = r.Articulo.Precio + Double.Parse(r.Articulo.Precio * txtPorcentajeTarjeta.Text / 100)
        '        'r.PrecioUnitario = r.PrecioUnitario + Double.Parse(r.PrecioUnitario * txtPorcentajeTarjeta.Text / 100)
        '        aumento += Double.Parse(r.SubTotal * txtPorcentajeTarjeta.Text / 100)
        '    Next

        '    'agrego un renglon con el total a aumentar 
        '    Dim renglonTarjeta As New RenglonComprobante
        '    renglonTarjeta.CantADisminuir = 0
        '    renglonTarjeta.Cantidad = 1
        '    renglonTarjeta.Descripcion = "PLAN TARJETA CRED/DEB                               "
        '    renglonTarjeta.PrecioUnitario = aumento
        '    vta.Renglones.Add(renglonTarjeta)
        '    ActualizarRenglones()

        '    cmdFinalizar_Click(sender, e)
        'End If
    End Sub

    Private Sub RadioButTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButTarjeta.Click
        frmTarjeta.Visible = True
        txtPorcentajeTarjeta.Focus()
    End Sub

    Private Sub RadioButContado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButContado.Click
        frmTarjeta.Visible = False

        'For Each r As RenglonComprobante In vta.Renglones
        '    r.PrecioUnitario = r.PrecioUnitario * 100 / (100 + txtPorcentajeTarjeta.Text)
        'Next

        txtPorcentajeTarjeta.Text = 0
        lblInteres.Text = 0
        ActualizarRenglones()
    End Sub

    Private Sub RadioButCtaCte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButCtaCte.Click

        frmTarjeta.Visible = False
        'frmTarjeta.Visible = False

        'For Each r As RenglonComprobante In vta.Renglones
        '    r.PrecioUnitario = r.PrecioUnitario * 100 / (100 + txtPorcentajeTarjeta.Text)
        'Next

        'txtPorcentajeTarjeta.Text = 0
        txtPorcentajeTarjeta.Text = 0
        lblInteres.Text = 0
        ActualizarRenglones()
    End Sub

    Private Sub txtPorcentajeTarjeta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentajeTarjeta.LostFocus
        ''ACA ACTUALIZAMOS EL PRECIO DE EL ARTICULO EN MEMORIA
        'Dim aumento As Double
        'aumento = 0
        'For Each r As RenglonComprobante In vta.Renglones
        '    'r.PrecioUnitario = r.Articulo.Precio + Double.Parse(r.Articulo.Precio * txtPorcentajeTarjeta.Text / 100)
        '    'r.PrecioUnitario = r.PrecioUnitario + Double.Parse(r.PrecioUnitario * txtPorcentajeTarjeta.Text / 100)
        '    aumento += Double.Parse(r.PrecioUnitario * txtPorcentajeTarjeta.Text / 100)
        'Next

        ''agrego un renglon con el total a aumentar 
        'Dim renglonTarjeta As New RenglonComprobante
        'renglonTarjeta.CantADisminuir = 0
        'renglonTarjeta.Cantidad = 1
        'renglonTarjeta.Descripcion = "Recargo por venta con tarjeta"
        'renglonTarjeta.PrecioUnitario = aumento
        'vta.Renglones.Add(renglonTarjeta)
        'ActualizarRenglones()





        ''ACA ACTUALIZAMOS EL PRECIO DEL ARTICULO EN EL DATAGRID
        'For Each fila As DataGridViewRow In dgvRenglones.Rows
        '    'If IsNothing(fila.Cells(1).Value) Then Exit Sub
        '    'If fila.Cells(1).Value.ToString().Contains(txtDescripcion.Text) Then
        '    '    frm.DataGridView1.Rows(fila.Index).Selected = True
        '    '    frm.DataGridView1.CurrentCell = fila.Cells(0)
        '    '    Exit For

        '    'End If

        'Next

        'lblToTaL.Text = Math.Round(CDbl(lblToTaL.Text) + CDbl(lblToTaL.Text) * CDbl(txtPorcentajeTarjeta.Text) / 100, 2)
        'lblInteres.Text = Math.Round(CDbl(lblToTaL.Text) * CDbl(txtPorcentajeTarjeta.Text) / 100, 2)
        If txtPorcentajeTarjeta.Text.Trim().Equals(String.Empty) Then
            txtPorcentajeTarjeta.Text = "0"
        End If
        ActualizarRenglones()
    End Sub


    Private Sub FrmFacturacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub btnActualizarPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarPrecios.Click
        'ACA ACTUALIZAMOS EL PRECIO DE EL ARTICULO EN MEMORIA
        Dim objArticulo As Articulo
        Dim strNoActualizados As String = ""

        For Each r As RenglonComprobante In vta.Renglones
            If IsNothing(r.Articulo) = False Then
                'NO es un caño, modifica el precio
                objArticulo = facArticulo.TraerArticulo(r.Articulo.IdArticulo)
                r.PrecioUnitario = objArticulo.Precio
            Else
                strNoActualizados += r.Descripcion + vbCr
            End If
        Next

        If strNoActualizados.Length > 0 Then

            MessageBox.Show("Imposible actualizar precios para los siguientes articulos: " + vbCr + vbCr + strNoActualizados, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        ActualizarRenglones()
    End Sub


    Private Sub RadioButTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButTarjeta.CheckedChanged
        esMixto = RadioButTarjeta.Checked
        'If Not RadioButTarjeta.Checked Then
        '    'si esta deschequeado borro el procentaje de tarjeta
        '    txtPorcentajeTarjeta.Text = "0"
        'End If
    End Sub

    Private Sub txtPorcentajeTarjeta_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentajeTarjeta.RightToLeftChanged

    End Sub

    Private Sub txtPorcentajeTarjeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcentajeTarjeta.TextChanged

    End Sub



    Private Sub txtLector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLector.KeyPress
        'If Not IsNumeric(e.KeyChar) Then e.Handled = True
        'Application.DoEvents()

        If Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then e.Handled = Not IsNumeric(e.KeyChar)

        If Asc(e.KeyChar) = 13 Then
            'MsgBox("Enter")
            'aca verifico si lo ingresado es un enter, si es asi proceso los datos que hay en la casilla
            If txtLector.Text.Trim().Length = 0 Then
                If cmdFinalizar.Enabled Then cmdFinalizar_Click(sender, e)
                Exit Sub
            End If
            If txtLector.Text.Length > 3 Then
                'es un codigo de barra, se ejecuta la busqueda
                Dim tabla As DataTable
                tabla = facArticulo.ListarArticulosXCodBarras(txtLector.Text)
                If tabla.Rows.Count = 0 Then

                    'Articulo no encontrado
                    'Se inicia el formulario de busqueda, para la seleccion manual...
                    txtLector.Text = ""
                    DescripcionToolStripMenuItem_Click(sender, e)

                    Exit Sub
                End If
                AgregarRenglon(tabla.Rows(0)("N Articulo"), cantidad, tabla.Rows(0)("Precio al Clie"))
                txtCantidadActual.Text = "1"
                cantidad = 1
            Else
                'es una cantidad, se pone en el campo de cantidad
                txtCantidadActual.Text = txtLector.Text
                cantidad = Integer.Parse(txtCantidadActual.Text)
            End If
            txtLector.Text = ""
            txtLector.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frm.Monto = lblToTaL.Text
        frm.ShowDialog()

    End Sub

    Private Sub controlaevento() Handles frm.ProcesarMonto

    End Sub

    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmMonto.MostrarInputBox("Ingresa el monto en Efectivo", lblToTaL.Text)
    'End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        chkImprimir.Checked = Not chkImprimir.Checked
    End Sub


    Private Sub dgvRenglones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvRenglones.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdFinalizar_Click(sender, e)
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        vta.Nick = cmbVendedor.Text
        If RadioButTarjeta.Checked Then
            vta.MontoTarjeta = 0.01
        Else
            vta.MontoTarjeta = 0
            vta.Porcentaje = 0
        End If

        facFactura.modificarFactura(vta)
        MessageBox.Show("Se ha modificado el comprobante!", "Modificación exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RadioButCtaCte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButCtaCte.CheckedChanged

    End Sub

    Private Sub hiloSegundoPlano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles hiloSegundoPlano.DoWork
        Dim venta As Venta
        venta = CType(e.Argument, Venta)
        Impresora.imprimirTicket(venta)

    End Sub


    Private Sub btnDeCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeCambio.Click
        If dgvRenglones.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim indice As Integer
        indice = dgvRenglones.SelectedRows(0).Index
        vta.Renglones(indice).Descripcion = "(CAMBIO) " & vta.Renglones(indice).Descripcion
        'vta.Renglones(indice).PrecioUnitario *= -1 MODIF MATI.... PARA ARREGLAR EL STOCK CON ARTICULOS DE CAMBIO
        vta.Renglones(indice).Cantidad *= -1
        ActualizarRenglones()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescuento.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtDescuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.LostFocus
        If txtDescuento.Text.Trim().Equals(String.Empty) Then
            txtDescuento.Text = "0"
        End If
        ActualizarRenglones()
    End Sub

    Private Sub txtDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged

    End Sub
End Class
