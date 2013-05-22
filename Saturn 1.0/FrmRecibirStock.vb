Imports Modelo
Imports Fachada

Public Class FrmRecibirStock

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


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbVendedor.DataSource = fu.listarUsuarios()
        cmbVendedor.DisplayMember = "nick"
        cmbVendedor.Text = Sesion.getSesion.UsuarioActivo.Nick
        txtLector.Focus()
    End Sub

    Private Sub NuevaFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dgvRenglones.DataSource = Nothing
        'vta = New Venta
        'ActualizarRenglones()
        'GroupBox1.Visible = True
        'cmbSucursal.Text = "AA"
        'lblNotadeCredito.Visible = False
        'CboTipoDeComprobante.Items.Clear()
        'CboTipoDeComprobante.Items.Add("X")
        'CboTipoDeComprobante.Items.Add("B")
        'CboTipoDeComprobante.Items.Add("A")
        'CboTipoDeComprobante.Items.Add("P")
        'CboTipoDeComprobante.Text = "X"
        'txtPorcentajeTarjeta.Text = "0"
        'RadioButContado.Checked = True
        'frmTarjeta.Visible = False

    End Sub



    Private Sub picBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmClienteBuscar.MdiParent = Me.MdiParent
        FrmClienteBuscar.cmdNuevoCliente.Visible = True
        FrmClienteBuscar.cmdSeleccionar.Visible = True
        FrmClienteBuscar.ShowDialog()
        facCliente.CargarCombo(cmbSucursal)
        If FrmClienteBuscar.idClienteSeleccionado = 0 Then Exit Sub
        For Each clie As IdCliente In cmbSucursal.Items
            If clie.Id = FrmClienteBuscar.idClienteSeleccionado Then
                cmbSucursal.SelectedItem = clie
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

        If cmbSucursal.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una sucursal de destino", "Seleccione el cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        If vta.Renglones.Count > 47 Then
            MessageBox.Show("Debe confeccionar una nueva factura, esta ha llegado al limite de renglones permitidos (48 máx.)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        lblToTaL.Text = "" & Math.Round(vta.Total, 2)

        txtCantidadItems.Text = cantProductos
        'frmArtBuscar.txtTotalFac.Text = lblToTaL.Text
    End Sub

    Private Sub TipoDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub DescripcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub ClientePredeterminadoF12ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLector.Focus()
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

    Private Sub cmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizar.Click
        Try
            If MessageBox.Show("¿Desea Finalizar la operación?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            vta.Nick = cmbVendedor.Text
            Dim facMovStock As New FachadaMovimientoStock
            facMovStock.RecibirStock(vta, cmbSucursal.Text, InputBox("Ingrese el ACK del movimiento", 0))
            If chkImprimir.Checked Then hiloSegundoPlano.RunWorkerAsync(vta)
            MessageBox.Show("Recepción realizada correctamente " & vbCr & " ** CODIGO CRC **  " & vta.CalcularCodigoRecepcion, "Saturn 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vta = New Venta
            ActualizarRenglones()

        Catch ex As ACKInvalidoException
            MessageBox.Show("El ACK ingresado no es válido.", "Ack inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If frmArtBuscar.IsDisposed Then frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar = New FrmArticuloBuscar
        frmArtBuscar.grupoRenglon.Visible = True
        frmArtBuscar.grupoRenglon.Visible = True
        'frmArtBuscar.MdiParent = Me.MdiParent
        frmArtBuscar.GroupBox2.Visible = False
        frmArtBuscar.ShowDialog()
        txtLector.Focus()
    End Sub


    Private Sub AnularFacturaF3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFacturasBuscar.MdiParent = FrmPrincipal
        frmFacturasBuscar.Show()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If MessageBox.Show("Realmente desea cancelar?", "Confirme la cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dgvRenglones.DataSource = Nothing
            vta = New Venta
            ActualizarRenglones()
        End If
    End Sub

    Private Sub txtPorcentajeTarjeta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
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
    End Sub


    Private Sub FrmFacturacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub btnActualizarPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub RadioButTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not RadioButTarjeta.Checked Then
        '    'si esta deschequeado borro el procentaje de tarjeta
        '    txtPorcentajeTarjeta.Text = "0"
        'End If
    End Sub

    Private Sub txtPorcentajeTarjeta_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPorcentajeTarjeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            If txtLector.Text.Length > 2 Then
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



    Private Sub RadioButCtaCte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub hiloSegundoPlano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles hiloSegundoPlano.DoWork
        Dim venta As Venta
        venta = CType(e.Argument, Venta)
        Impresora.imprimirTicketRecepcion(venta)

    End Sub

End Class
