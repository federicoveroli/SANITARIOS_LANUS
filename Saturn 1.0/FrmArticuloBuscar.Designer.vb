<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticuloBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtQueContenga = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.cmdBaja = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.grupoRenglon = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotalFac = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRegistros = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCantidadItems = New System.Windows.Forms.TextBox
        Me.cmdAgregarInexistente = New System.Windows.Forms.Button
        Me.cmdAgregarRenglon = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPU = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDetalle = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.mnuArticulos = New System.Windows.Forms.MenuStrip
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CodigoDeBarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FiltrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdEliminarSeleccionado = New System.Windows.Forms.Button
        Me.cmdAceptarAumento = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtVariable = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.ToolTipLector = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAceptarCambioStock = New System.Windows.Forms.Button
        Me.txtNuevoStock = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtQueContenga2 = New System.Windows.Forms.TextBox
        Me.txtQueContenga3 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoRenglon.SuspendLayout()
        Me.mnuArticulos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por"
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Listado total", "Tipo de Producto", "Descripcion", "Marca", "Proveedor", "Codigo de Barras"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(94, 43)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(164, 21)
        Me.cmbBuscarPor.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "que contenga :"
        '
        'txtQueContenga
        '
        Me.txtQueContenga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga.Location = New System.Drawing.Point(360, 43)
        Me.txtQueContenga.MaxLength = 99
        Me.txtQueContenga.Name = "txtQueContenga"
        Me.txtQueContenga.Size = New System.Drawing.Size(90, 20)
        Me.txtQueContenga.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(33, 71)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(737, 340)
        Me.DataGridView1.TabIndex = 5
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(695, 42)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.Location = New System.Drawing.Point(695, 428)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 6
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'cmdBaja
        '
        Me.cmdBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBaja.Location = New System.Drawing.Point(695, 483)
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(75, 23)
        Me.cmdBaja.TabIndex = 7
        Me.cmdBaja.Text = "&Baja"
        Me.cmdBaja.UseVisualStyleBackColor = True
        Me.cmdBaja.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificar.Location = New System.Drawing.Point(695, 455)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 8
        Me.cmdModificar.Text = "&Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        Me.cmdModificar.Visible = False
        '
        'grupoRenglon
        '
        Me.grupoRenglon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grupoRenglon.Controls.Add(Me.Label15)
        Me.grupoRenglon.Controls.Add(Me.txtTotalFac)
        Me.grupoRenglon.Controls.Add(Me.Label13)
        Me.grupoRenglon.Controls.Add(Me.txtRegistros)
        Me.grupoRenglon.Controls.Add(Me.Label12)
        Me.grupoRenglon.Controls.Add(Me.txtCantidadItems)
        Me.grupoRenglon.Controls.Add(Me.cmdAgregarInexistente)
        Me.grupoRenglon.Controls.Add(Me.cmdAgregarRenglon)
        Me.grupoRenglon.Controls.Add(Me.txtTotal)
        Me.grupoRenglon.Controls.Add(Me.Label6)
        Me.grupoRenglon.Controls.Add(Me.txtPU)
        Me.grupoRenglon.Controls.Add(Me.Label5)
        Me.grupoRenglon.Controls.Add(Me.txtDetalle)
        Me.grupoRenglon.Controls.Add(Me.Label4)
        Me.grupoRenglon.Controls.Add(Me.txtCantidad)
        Me.grupoRenglon.Controls.Add(Me.Label3)
        Me.grupoRenglon.Location = New System.Drawing.Point(33, 421)
        Me.grupoRenglon.Name = "grupoRenglon"
        Me.grupoRenglon.Size = New System.Drawing.Size(639, 85)
        Me.grupoRenglon.TabIndex = 9
        Me.grupoRenglon.TabStop = False
        Me.grupoRenglon.Text = "Detalles del renglon"
        Me.grupoRenglon.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(523, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Total"
        '
        'txtTotalFac
        '
        Me.txtTotalFac.Enabled = False
        Me.txtTotalFac.Location = New System.Drawing.Point(560, 58)
        Me.txtTotalFac.Name = "txtTotalFac"
        Me.txtTotalFac.ReadOnly = True
        Me.txtTotalFac.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalFac.TabIndex = 19
        Me.txtTotalFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(402, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Registros"
        '
        'txtRegistros
        '
        Me.txtRegistros.Enabled = False
        Me.txtRegistros.Location = New System.Drawing.Point(459, 59)
        Me.txtRegistros.Name = "txtRegistros"
        Me.txtRegistros.ReadOnly = True
        Me.txtRegistros.Size = New System.Drawing.Size(53, 20)
        Me.txtRegistros.TabIndex = 17
        Me.txtRegistros.Text = "0"
        Me.txtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(258, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Cantidad de Items"
        '
        'txtCantidadItems
        '
        Me.txtCantidadItems.Enabled = False
        Me.txtCantidadItems.Location = New System.Drawing.Point(358, 59)
        Me.txtCantidadItems.Name = "txtCantidadItems"
        Me.txtCantidadItems.ReadOnly = True
        Me.txtCantidadItems.Size = New System.Drawing.Size(38, 20)
        Me.txtCantidadItems.TabIndex = 15
        Me.txtCantidadItems.Text = "0"
        Me.txtCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAgregarInexistente
        '
        Me.cmdAgregarInexistente.Location = New System.Drawing.Point(133, 56)
        Me.cmdAgregarInexistente.Name = "cmdAgregarInexistente"
        Me.cmdAgregarInexistente.Size = New System.Drawing.Size(119, 23)
        Me.cmdAgregarInexistente.TabIndex = 9
        Me.cmdAgregarInexistente.Text = "Agregar &Inexistente"
        Me.cmdAgregarInexistente.UseVisualStyleBackColor = True
        '
        'cmdAgregarRenglon
        '
        Me.cmdAgregarRenglon.Location = New System.Drawing.Point(19, 56)
        Me.cmdAgregarRenglon.Name = "cmdAgregarRenglon"
        Me.cmdAgregarRenglon.Size = New System.Drawing.Size(99, 23)
        Me.cmdAgregarRenglon.TabIndex = 8
        Me.cmdAgregarRenglon.Text = "&Agregar Renglon"
        Me.cmdAgregarRenglon.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(560, 24)
        Me.txtTotal.MaxLength = 9
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Subtotal"
        '
        'txtPU
        '
        Me.txtPU.Enabled = False
        Me.txtPU.Location = New System.Drawing.Point(434, 24)
        Me.txtPU.MaxLength = 9
        Me.txtPU.Name = "txtPU"
        Me.txtPU.Size = New System.Drawing.Size(68, 20)
        Me.txtPU.TabIndex = 5
        Me.txtPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PU"
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(151, 24)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(242, 20)
        Me.txtDetalle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detalle:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(67, 24)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(40, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cantidad:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Location = New System.Drawing.Point(695, 456)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnNuevo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Ctrl + F1 = Tipo de Producto"
        '
        'mnuArticulos
        '
        Me.mnuArticulos.AllowMerge = False
        Me.mnuArticulos.BackColor = System.Drawing.Color.White
        Me.mnuArticulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaToolStripMenuItem})
        Me.mnuArticulos.Location = New System.Drawing.Point(0, 0)
        Me.mnuArticulos.Name = "mnuArticulos"
        Me.mnuArticulos.Size = New System.Drawing.Size(794, 24)
        Me.mnuArticulos.TabIndex = 11
        Me.mnuArticulos.Text = "MenuStrip1"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.DescripcionToolStripMenuItem, Me.ListadoTotalToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.CodigoDeBarrasToolStripMenuItem, Me.FiltrarToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TToolStripMenuItem.Text = "Tipo de Producto"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'DescripcionToolStripMenuItem
        '
        Me.DescripcionToolStripMenuItem.Name = "DescripcionToolStripMenuItem"
        Me.DescripcionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.DescripcionToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DescripcionToolStripMenuItem.Text = "Descripcion"
        '
        'ListadoTotalToolStripMenuItem
        '
        Me.ListadoTotalToolStripMenuItem.Name = "ListadoTotalToolStripMenuItem"
        Me.ListadoTotalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ListadoTotalToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ListadoTotalToolStripMenuItem.Text = "Listado Total"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor "
        '
        'CodigoDeBarrasToolStripMenuItem
        '
        Me.CodigoDeBarrasToolStripMenuItem.Name = "CodigoDeBarrasToolStripMenuItem"
        Me.CodigoDeBarrasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.CodigoDeBarrasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CodigoDeBarrasToolStripMenuItem.Text = "Codigo de Barras"
        '
        'FiltrarToolStripMenuItem
        '
        Me.FiltrarToolStripMenuItem.Name = "FiltrarToolStripMenuItem"
        Me.FiltrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.FiltrarToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FiltrarToolStripMenuItem.Text = "Filtrar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(197, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Ctrl + F2 = Marca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Ctrl + F3 = Descripcion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(452, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Ctrl + F4 = Listado Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdEliminarSeleccionado)
        Me.GroupBox2.Controls.Add(Me.cmdAceptarAumento)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.txtVariable)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 433)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 47)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambio de precio fijo"
        Me.GroupBox2.Visible = False
        '
        'cmdEliminarSeleccionado
        '
        Me.cmdEliminarSeleccionado.Location = New System.Drawing.Point(342, 17)
        Me.cmdEliminarSeleccionado.Name = "cmdEliminarSeleccionado"
        Me.cmdEliminarSeleccionado.Size = New System.Drawing.Size(111, 23)
        Me.cmdEliminarSeleccionado.TabIndex = 5
        Me.cmdEliminarSeleccionado.Text = "Quitar seleccionado"
        Me.cmdEliminarSeleccionado.UseVisualStyleBackColor = True
        '
        'cmdAceptarAumento
        '
        Me.cmdAceptarAumento.Location = New System.Drawing.Point(261, 17)
        Me.cmdAceptarAumento.Name = "cmdAceptarAumento"
        Me.cmdAceptarAumento.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptarAumento.TabIndex = 4
        Me.cmdAceptarAumento.Text = "Aceptar"
        Me.cmdAceptarAumento.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(188, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Disminuir"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(112, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Aumentar"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(19, 18)
        Me.txtVariable.MaxLength = 6
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(61, 20)
        Me.txtVariable.TabIndex = 1
        Me.txtVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(594, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Ctrl + F5 = Proveedor"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImprimir.Location = New System.Drawing.Point(695, 482)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
        Me.cmdImprimir.TabIndex = 21
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnAceptarCambioStock)
        Me.GroupBox1.Controls.Add(Me.txtNuevoStock)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(503, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 49)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de Stock fijo"
        Me.GroupBox1.Visible = False
        '
        'btnAceptarCambioStock
        '
        Me.btnAceptarCambioStock.Location = New System.Drawing.Point(99, 15)
        Me.btnAceptarCambioStock.Name = "btnAceptarCambioStock"
        Me.btnAceptarCambioStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarCambioStock.TabIndex = 5
        Me.btnAceptarCambioStock.Text = "Aceptar"
        Me.btnAceptarCambioStock.UseVisualStyleBackColor = True
        '
        'txtNuevoStock
        '
        Me.txtNuevoStock.Location = New System.Drawing.Point(44, 17)
        Me.txtNuevoStock.Name = "txtNuevoStock"
        Me.txtNuevoStock.Size = New System.Drawing.Size(49, 20)
        Me.txtNuevoStock.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Stock:"
        '
        'txtQueContenga2
        '
        Me.txtQueContenga2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga2.Location = New System.Drawing.Point(456, 43)
        Me.txtQueContenga2.MaxLength = 99
        Me.txtQueContenga2.Name = "txtQueContenga2"
        Me.txtQueContenga2.Size = New System.Drawing.Size(95, 20)
        Me.txtQueContenga2.TabIndex = 2
        '
        'txtQueContenga3
        '
        Me.txtQueContenga3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga3.Location = New System.Drawing.Point(557, 43)
        Me.txtQueContenga3.MaxLength = 99
        Me.txtQueContenga3.Name = "txtQueContenga3"
        Me.txtQueContenga3.Size = New System.Drawing.Size(95, 20)
        Me.txtQueContenga3.TabIndex = 3
        '
        'FrmArticuloBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CmdSalir
        Me.ClientSize = New System.Drawing.Size(794, 510)
        Me.Controls.Add(Me.txtQueContenga3)
        Me.Controls.Add(Me.txtQueContenga2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cmdBaja)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtQueContenga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuArticulos)
        Me.Controls.Add(Me.grupoRenglon)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuArticulos
        Me.Name = "FrmArticuloBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de articulos - Saturn 1.0 "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoRenglon.ResumeLayout(False)
        Me.grupoRenglon.PerformLayout()
        Me.mnuArticulos.ResumeLayout(False)
        Me.mnuArticulos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQueContenga As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBaja As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents grupoRenglon As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPU As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarRenglon As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregarInexistente As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mnuArticulos As System.Windows.Forms.MenuStrip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescripcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptarAumento As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVariable As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadItems As System.Windows.Forms.TextBox
    Friend WithEvents cmdEliminarSeleccionado As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFac As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRegistros As System.Windows.Forms.TextBox
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents FiltrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTipLector As System.Windows.Forms.ToolTip
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents CodigoDeBarrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptarCambioStock As System.Windows.Forms.Button
    Friend WithEvents txtNuevoStock As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtQueContenga2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQueContenga3 As System.Windows.Forms.TextBox
End Class
