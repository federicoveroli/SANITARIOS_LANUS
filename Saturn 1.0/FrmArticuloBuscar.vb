Imports Fachada
Imports Modelo
Public Class FrmArticuloBuscar
    Dim fa As New Fachada.FachadaArticulo
    Dim facBit As New FachadaBitacora
    Public Event AgregarRenglon(ByVal idArticulo As Integer, ByVal cantidad As Double, ByVal PU As Double)
    Public Event AgregarRenglonCompra(ByVal idArticulo As Integer, ByVal cantidad As Double, ByVal pcosto As Double, ByVal pventa As Double)
    Public Event AgregarInexistente(ByVal descripcion As String, ByVal cantidad As Double, ByVal pu As Double)
    Public seleccionBusqueda As Boolean = False
    Public encontrado As Boolean = True
    Private esElUltimo As Boolean = False

    Private Sub FrmArticuloBuscar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub

    'Private Sub FrmArticuloBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        If DataGridView1.Focused Then
    '            'e.Handled = True
    '            Exit Sub
    '        End If

    '        My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
    '    End If
    '    'Dim SeparadorDecimal As String
    '    'SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
    '    'If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
    '    '    e.KeyChar = Chr(Asc(SeparadorDecimal))
    '    'End If
    'End Sub
    Private Sub FrmArticuloBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GroupBox2.Visible = True Then
            DataGridView1.MultiSelect = True
        End If
        If Not encontrado Then
            ToolTipLector.RemoveAll()
            ToolTipLector.ToolTipTitle = "Articulo no encontrado"
            ToolTipLector.SetToolTip(txtQueContenga, "Se inicia el formulario de busqueda, para la seleccion manual...")
            ToolTipLector.ToolTipIcon = ToolTipIcon.Warning
            ToolTipLector.Show("Se inicia el formulario de busqueda, para la seleccion manual...", txtQueContenga, 1500)
        End If
    End Sub
    Public Sub ResizearColumnas()
        Try
            'DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(0).Width = 22
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 32
            DataGridView1.Columns(3).Width = 32
            DataGridView1.Columns(4).Width = 32
            DataGridView1.Columns(5).Width = 18
            DataGridView1.Columns(6).Width = 20
            DataGridView1.Columns(7).Width = 101

        Catch ex As Exception

        End Try


    End Sub
    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Hide()
    End Sub
    Private Sub cmdAgregarRenglon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarRenglon.Click
        If txtCantidad.Text = "" Then
            MessageBox.Show("Debe indicar la cantidad", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidad.Select()
            Exit Sub
        End If
        If txtPU.Text = "" Then
            MessageBox.Show("Debe indicar el precio", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPU.Select()
            Exit Sub
        End If
        RaiseEvent AgregarRenglon(DataGridView1.SelectedRows(0).Cells(0).Value, txtCantidad.Text, txtPU.Text)
        RaiseEvent AgregarRenglonCompra(DataGridView1.SelectedRows(0).Cells(0).Value, txtCantidad.Text, txtPU.Text, txtTotal.Text)

        txtCantidad.Text = ""
        txtCantidadItems.Text += 1
        txtDetalle.Text = ""
        txtPU.Text = ""
        txtTotal.Text = ""
        DataGridView1.Select()

        Me.Hide()

    End Sub
    Private Sub TipoDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 1
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 3
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub DescripcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 2
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTotalToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 0
        txtQueContenga.Text = ""
        txtQueContenga.Select()
        cmdBuscar_Click(sender, e)
    End Sub
    Public Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        BuscarArticulo()
        DataGridView1.Select()

    End Sub

    Private Sub BuscarArticulo()
        If cmbBuscarPor.SelectedIndex <> -1 Then

            Dim lista As New FachadaArticulo
            Dim X As Integer
            X = cmbBuscarPor.SelectedIndex
            Select Case (X)
                Case 0 'todos
                    DataGridView1.DataSource = lista.listarArticulos
                Case 1 'tipo de Producto
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXTipo(z)
                Case 2
                    Dim z As String 'Descripcion
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXDescripcion(z)
                Case 3 'marca
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXMarca(z)
                Case 4 ' proveedor
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXProveedor(z)
                Case 5 'por codigo de Barra
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXCodBarrasDT(z)
            End Select
        End If
        ResizearColumnas()
        txtRegistros.Text = DataGridView1.Rows.Count - 1
    End Sub
    Private Sub cmdBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaja.Click
        If MsgBox("¿Desea eliminar ese registro/s?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim idarticulo As Integer
                Dim lista As New FachadaArticulo
                If DataGridView1.SelectedRows.Count > 1 Then
                    Dim i As Integer
                    For i = 0 To DataGridView1.SelectedRows.Count - 1
                        idarticulo = DataGridView1.SelectedRows(i).Cells(0).Value
                        lista.eliminarArticulo(idarticulo)
                    Next
                Else
                    idarticulo = DataGridView1.SelectedRows(0).Cells(0).Value
                    lista.eliminarArticulo(idarticulo)
                End If

                cmdBuscar_Click(sender, e)
            Catch ex As Exception
                MsgBox("No se ha podido eliminar!")
            End Try
        End If
    End Sub
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Try
            Dim idarticulo As Integer
            idarticulo = DataGridView1.SelectedRows(0).Cells(0).Value
            'FrmArticuloAlta.MdiParent = FrmPrincipal
            'FrmArticuloAlta.Show()
            'FrmArticuloAlta.Hide()
            FrmArticuloAlta.lblMisterioso.Text = idarticulo
            FrmArticuloAlta.CompletarArticulo(idarticulo)
            FrmArticuloAlta.cmdAceptar.Text = "Modificar"

            FrmArticuloAlta.cmdAgregarSimilar.Visible = False
            FrmArticuloAlta.ShowDialog()
            'actualiza el listado de articulos
            'If FrmArticuloAlta.Acepto Then
            '    'actualizo el listado de articulos
            '    cmdBuscar_Click(sender, e)
            'End If
         
        Catch ex As Exception
            'MsgBox("Debe seleccionar un artículo para modificar...")
        End Try


    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        Application.DoEvents()

        If DataGridView1.CurrentRow.Index = 0 Then
            DataGridView1_SelectionChanged(sender, e)
        End If

        'MsgBox("Inicio DataGridView1_KeyPress" & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Index)
        If Asc(e.KeyChar) = 13 Then
            If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

            'seleccionar la anterior .......................................................................

            If Not esElUltimo And DataGridView1.Rows.Count <> 1 Then
                '' DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Selected = True
                DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index - 1).Cells(0)
            End If


            If cmdModificar.Visible = True Then
                cmdModificar_Click(sender, e)
            Else
                If cmdAgregarRenglon.Visible = True Then


                    txtCantidad.Select()
                    'e.Handled = False
                    'DataGridView1.Rows(DataGridView1.SelectedRows(0).Index - 1).Selected = True
                    'DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index - 1).Cells(0)
                    'DataGridView1.Rows(DataGridView1.SelectedRows(0).Index - 1)
                    'cmdAgregarRenglon_Click(sender, e)
                Else
                    If cmdBaja.Visible = True Then
                        cmdBaja_Click(sender, e)
                    End If
                End If
            End If
        End If
        If Asc(e.KeyChar) = 32 Then
            FiltrarToolStripMenuItem_Click(sender, e)
        End If
        'MsgBox("Termino DataGridView1_KeyPress" & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Index)
    End Sub
    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Application.DoEvents()
        Try
            'MsgBox("Inicio DataGridView1_SelectionChanged" & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Index)
            If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
            If DataGridView1.SelectedRows(0).Index = DataGridView1.Rows.Count - 1 Then
                esElUltimo = True
            Else
                esElUltimo = False
            End If
            txtDetalle.Text = DataGridView1.SelectedRows(0).Cells(1).Value
            Dim art As Articulo, facArt As New FachadaArticulo
            art = facArt.TraerArticulo(CInt(DataGridView1.SelectedRows(0).Cells(0).Value))

            txtTotal.Text = art.Precio

            If cmdAgregarInexistente.Visible = True Then
                txtPU.Text = Math.Round(art.Precio, 2)
            Else
                txtPU.Text = Math.Round(art.Costo, 2)
            End If
            'MsgBox("Termino DataGridView1_SelectionChanged" & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Index)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtPU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPU.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Public Sub txtPU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPU.TextChanged
        If txtCantidad.Text <> "" And txtPU.Text <> "" Then txtTotal.Text = CDbl(txtCantidad.Text) * CDbl(txtPU.Text)
    End Sub

    Private Sub txtCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.Select(0, txtCantidad.Text.Length)
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtCantidad.Text.Trim <> "" Then
                cmdAgregarRenglon_Click(sender, e)
            Else
                e.Handled = True
            End If
        Else
            e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
        End If
    End Sub
    Private Sub cmdAceptarAumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptarAumento.Click

        If txtVariable.Text = "" Then
            MsgBox("Debe ingresar un precio!")
        Else
            If MessageBox.Show("¿Está seguro que desea modificar el precio de los articulos listados?", "Confirme operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Dim updetearLista As New FachadaArticulo
            Dim i As Integer
            Dim TodosLosId As String
            Dim idarticulo As Integer
            Dim variable As Double
            Dim Fach As New FachadaArticulo
            Dim descripcion As String
            Dim cambioPrecio As String
            Dim artMod As Articulo

            TodosLosId = ""
            For i = 0 To DataGridView1.RowCount - 1
                idarticulo = DataGridView1.Rows(i).Cells(0).Value
                descripcion = DataGridView1.Rows(i).Cells(1).Value
                TodosLosId = TodosLosId & idarticulo & ", "
                artMod = fa.TraerArticulo(idarticulo)
                cambioPrecio = descripcion & " [el precio era " & artMod.Precio & " y ahora es " & txtVariable.Text & "]"

                facBit.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, cambioPrecio)

            Next

            TodosLosId = TodosLosId.Substring(0, TodosLosId.Length - 2)
            'Try
            'If RadioButton1.Checked = True Then
            '    If txtVariable.Text > 150 Then
            '        MsgBox("No puede ser mayor a 150% el aumento !")
            '        Exit Sub
            '    End If
            '    TodosLosId = TodosLosId.Substring(0, TodosLosId.Length - 1)
            '    Fach.aumentarprecio(TodosLosId, txtVariable.Text)
            'Else
            '    If txtVariable.Text > 100 Then
            '        MsgBox("No puede ser mayor a 100% la disminucion !")
            '        Exit Sub
            '    End If
            '    variable = "-" & CDbl(txtVariable.Text)
            '    TodosLosId = TodosLosId.Substring(0, TodosLosId.Length - 1)
            '    Fach.aumentarprecio(TodosLosId, variable)
            'End If
            variable = CDbl(txtVariable.Text)
            Fach.cambiarrprecio(TodosLosId, variable)

            Dim fachhh As New FachadaBitacora
            Dim stringDescripcionBitacora As String
            If RadioButton1.Checked = True Then
                stringDescripcionBitacora = "Se modificaron los articulos filtrados por  " & cmbBuscarPor.Text & " y que contenga " & txtQueContenga.Text & " con un aumento de " & txtVariable.Text & " %"
            Else
                stringDescripcionBitacora = "Se modificaron los articulos filtrados por  " & cmbBuscarPor.Text & " y que contenga " & txtQueContenga.Text & " con una disminucion de " & txtVariable.Text & " %"
            End If
            'fachhh.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, stringDescripcionBitacora)
            'Catch ex As Exception
            '    MsgBox("Ocurrió un error inesperado.")
            'End Try
            cmdBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cmdAgregarInexistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarInexistente.Click


        frmAgregarInexistente.ShowDialog()
        If frmAgregarInexistente.acepto Then
            RaiseEvent AgregarInexistente(frmAgregarInexistente.txtDetalle.Text, frmAgregarInexistente.txtCantidad.Text, frmAgregarInexistente.txtPU.Text)
            txtCantidadItems.Text += 1
            Me.Hide()
        End If

        'txtCantidad.Text = ""
        'txtDetalle.Text = ""
        'txtPU.Text = ""
        'txtTotal.Text = ""
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 4
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub txtVariable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVariable.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub cmbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBuscarPor.SelectedIndexChanged
        If cmbBuscarPor.SelectedIndex = 0 Then
            txtQueContenga.Text = ""
            txtQueContenga.Enabled = False
            'RESOLUCION DE BUG AL CARGAR EL LISTADO TOTAL
            'CUANDO SE CARGABA ESTE LISTADO QUEDABA EL FOCO EN LA GRILLA Y SI DABAMOS ENTER EN LA FILA SELECCIONADA NOS ELEGIA LA SIGUIENTE.
            RemoveHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
            BuscarArticulo()
            AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
            DataGridView1.Select()
        Else
            txtQueContenga.Enabled = True
        End If
    End Sub
    Public Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        Try
            If txtCantidad.Text <> "" And txtPU.Text <> "" Then txtTotal.Text = CDbl(txtCantidad.Text) * CDbl(txtPU.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtQueContenga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQueContenga.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataGridView1.Select()
            Exit Sub
        End If
    End Sub

    Private Sub cmdEliminarSeleccionado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarSeleccionado.Click
        Try
            If MessageBox.Show("Desea eliminar el/los articulos seleccionados del listado", "Confirme la operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0)) 'carece ede sentido, segun mariano, pero funciona
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Try
            Dim rpt As New rptListadoArticulos
            'aca genero el dataset con todos los ids del listado que se esta visualizando
            Dim ids As String = ""
            For Each fila As DataGridViewRow In DataGridView1.Rows
                ids = ids & fila.Cells(0).Value & ", "
            Next
            Dim facArt As New FachadaArticulo
            rpt.SetDataSource(facArt.ListarArticulosXIds(ids))
            frmVisualizarInformes.MdiParent = FrmPrincipal
            frmVisualizarInformes.CrystalReportViewer1.ReportSource = rpt
            frmVisualizarInformes.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FiltrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrarToolStripMenuItem.Click
        frmArtiBuscar.frm = Me
        frmArtiBuscar.txtDescripcion.Text = ""
        frmArtiBuscar.txtDescripcion.Select()
        frmArtiBuscar.ShowDialog()
        
    End Sub

    Private Sub grupoRenglon_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grupoRenglon.Enter

    End Sub

    Private Sub txtVariable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVariable.TextChanged

    End Sub

   
    Private Sub GrabarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fa.grabarScript()

    End Sub

  
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        FrmArticuloAlta.ShowDialog()
        cmdBuscar_Click(sender, e)

    End Sub

   
    Private Sub txtQueContenga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQueContenga.TextChanged
        RemoveHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        BuscarArticulo()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
    End Sub


    Private Sub CodigoDeBarrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoDeBarrasToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 5
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub btnAceptarCambioStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarCambioStock.Click
        If MessageBox.Show("¿Está seguro que desea modificar el stock de los articulos que hay en el listado?", "Confirme operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        '  Dim updetearLista As New FachadaArticulo
        Dim i As Integer
        Dim TodosLosId As String
        Dim idarticulo As Integer
        Dim variable As Double
        Dim Fach As New FachadaArticulo
        Dim descripcion As String
        Dim cambioPrecio As String
        Dim artMod As Articulo

        TodosLosId = ""
        For i = 0 To DataGridView1.RowCount - 1
            idarticulo = DataGridView1.Rows(i).Cells(0).Value
            descripcion = DataGridView1.Rows(i).Cells(1).Value
            TodosLosId = TodosLosId & idarticulo & ", "
            'artMod = fa.TraerArticulo(idarticulo)
            'cambioPrecio = descripcion & " [el precio era " & artMod.Precio & " y ahora es " & txtVariable.Text & "]"
            'facBit.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, cambioPrecio)
        Next

        TodosLosId = TodosLosId.Substring(0, TodosLosId.Length - 2)
        variable = CDbl(txtNuevoStock.Text)
        Fach.CambiarStock(TodosLosId, variable)

        Dim fachhh As New FachadaBitacora
        Dim stringDescripcionBitacora As String
        If RadioButton1.Checked = True Then
            stringDescripcionBitacora = "Se modificaron los articulos filtrados por  " & cmbBuscarPor.Text & " y que contenga " & txtQueContenga.Text & " con un aumento de " & txtVariable.Text & " %"
        Else
            stringDescripcionBitacora = "Se modificaron los articulos filtrados por  " & cmbBuscarPor.Text & " y que contenga " & txtQueContenga.Text & " con una disminucion de " & txtVariable.Text & " %"
        End If

        cmdBuscar_Click(sender, e)

    End Sub
End Class
