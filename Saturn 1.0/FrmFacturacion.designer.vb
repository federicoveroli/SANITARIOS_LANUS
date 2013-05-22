<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.CmdArmarRenglon = New System.Windows.Forms.Button
        Me.cmdQuitarItem = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotaDeCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnularFacturaF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientePredeterminadoF12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButTarjeta = New System.Windows.Forms.RadioButton
        Me.RadioButCtaCte = New System.Windows.Forms.RadioButton
        Me.RadioButContado = New System.Windows.Forms.RadioButton
        Me.lblNotadeCredito = New System.Windows.Forms.Label
        Me.CboTipoDeComprobante = New System.Windows.Forms.ComboBox
        Me.dgvRenglones = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNumeroFactura = New System.Windows.Forms.Label
        Me.txtCantidadItems = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdFinalizar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCantidadDeCopias = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblToTaL = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbVendedor = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.btnIngresarCliente = New System.Windows.Forms.Button
        Me.frmTarjeta = New System.Windows.Forms.GroupBox
        Me.txtPorcentajeTarjeta = New System.Windows.Forms.TextBox
        Me.btnActualizarPrecios = New System.Windows.Forms.Button
        Me.ToolTipLector = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLector = New System.Windows.Forms.TextBox
        Me.cmdModificarItem = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCantidadActual = New System.Windows.Forms.TextBox
        Me.chkImprimir = New System.Windows.Forms.CheckBox
        Me.picBuscar = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.hiloSegundoPlano = New System.ComponentModel.BackgroundWorker
        Me.btnDeCambio = New System.Windows.Forms.Button
        Me.CheckRemito = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblIva = New System.Windows.Forms.Label
        Me.lblInteres = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.lblDescuento = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.frmTarjeta.SuspendLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdArmarRenglon
        '
        Me.CmdArmarRenglon.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdArmarRenglon.Location = New System.Drawing.Point(497, 121)
        Me.CmdArmarRenglon.Name = "CmdArmarRenglon"
        Me.CmdArmarRenglon.Size = New System.Drawing.Size(91, 45)
        Me.CmdArmarRenglon.TabIndex = 1
        Me.CmdArmarRenglon.Text = "&Armar Renglon"
        Me.CmdArmarRenglon.UseVisualStyleBackColor = True
        '
        'cmdQuitarItem
        '
        Me.cmdQuitarItem.Location = New System.Drawing.Point(497, 245)
        Me.cmdQuitarItem.Name = "cmdQuitarItem"
        Me.cmdQuitarItem.Size = New System.Drawing.Size(91, 23)
        Me.cmdQuitarItem.TabIndex = 2
        Me.cmdQuitarItem.Text = "&Quitar Item"
        Me.cmdQuitarItem.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(106, 38)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(132, 21)
        Me.cmbCliente.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ingrese Cliente: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturarToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FacturarToolStripMenuItem
        '
        Me.FacturarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaFacturaToolStripMenuItem, Me.NotaDeCreditoToolStripMenuItem, Me.AnularFacturaF3ToolStripMenuItem})
        Me.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        Me.FacturarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.FacturarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.FacturarToolStripMenuItem.Text = "Facturar"
        '
        'NuevaFacturaToolStripMenuItem
        '
        Me.NuevaFacturaToolStripMenuItem.Name = "NuevaFacturaToolStripMenuItem"
        Me.NuevaFacturaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.NuevaFacturaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.NuevaFacturaToolStripMenuItem.Text = "Nueva Factura"
        '
        'NotaDeCreditoToolStripMenuItem
        '
        Me.NotaDeCreditoToolStripMenuItem.Name = "NotaDeCreditoToolStripMenuItem"
        Me.NotaDeCreditoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.NotaDeCreditoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.NotaDeCreditoToolStripMenuItem.Text = "Nota de Credito"
        Me.NotaDeCreditoToolStripMenuItem.Visible = False
        '
        'AnularFacturaF3ToolStripMenuItem
        '
        Me.AnularFacturaF3ToolStripMenuItem.Name = "AnularFacturaF3ToolStripMenuItem"
        Me.AnularFacturaF3ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.AnularFacturaF3ToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AnularFacturaF3ToolStripMenuItem.Text = "Buscar Facturas"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeProductoToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.DescripcionToolStripMenuItem, Me.ListadoTotalToolStripMenuItem, Me.ClientePredeterminadoF12ToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'TipoDeProductoToolStripMenuItem
        '
        Me.TipoDeProductoToolStripMenuItem.Name = "TipoDeProductoToolStripMenuItem"
        Me.TipoDeProductoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.TipoDeProductoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TipoDeProductoToolStripMenuItem.Text = "Tipo de producto"
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
        Me.ListadoTotalToolStripMenuItem.Text = "Listado total"
        '
        'ClientePredeterminadoF12ToolStripMenuItem
        '
        Me.ClientePredeterminadoF12ToolStripMenuItem.Name = "ClientePredeterminadoF12ToolStripMenuItem"
        Me.ClientePredeterminadoF12ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.ClientePredeterminadoF12ToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClientePredeterminadoF12ToolStripMenuItem.Text = "Codigo / Cantidad"
        Me.ClientePredeterminadoF12ToolStripMenuItem.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButTarjeta)
        Me.GroupBox1.Controls.Add(Me.RadioButCtaCte)
        Me.GroupBox1.Controls.Add(Me.RadioButContado)
        Me.GroupBox1.Controls.Add(Me.lblNotadeCredito)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones de Venta"
        '
        'RadioButTarjeta
        '
        Me.RadioButTarjeta.AutoSize = True
        Me.RadioButTarjeta.Location = New System.Drawing.Point(152, 19)
        Me.RadioButTarjeta.Name = "RadioButTarjeta"
        Me.RadioButTarjeta.Size = New System.Drawing.Size(94, 17)
        Me.RadioButTarjeta.TabIndex = 2
        Me.RadioButTarjeta.Text = "Tar&jeta / Mixto"
        Me.RadioButTarjeta.UseVisualStyleBackColor = True
        '
        'RadioButCtaCte
        '
        Me.RadioButCtaCte.AutoSize = True
        Me.RadioButCtaCte.Location = New System.Drawing.Point(86, 19)
        Me.RadioButCtaCte.Name = "RadioButCtaCte"
        Me.RadioButCtaCte.Size = New System.Drawing.Size(60, 17)
        Me.RadioButCtaCte.TabIndex = 1
        Me.RadioButCtaCte.Text = "C&ta Cte"
        Me.RadioButCtaCte.UseVisualStyleBackColor = True
        '
        'RadioButContado
        '
        Me.RadioButContado.AutoSize = True
        Me.RadioButContado.Checked = True
        Me.RadioButContado.Location = New System.Drawing.Point(15, 19)
        Me.RadioButContado.Name = "RadioButContado"
        Me.RadioButContado.Size = New System.Drawing.Size(65, 17)
        Me.RadioButContado.TabIndex = 0
        Me.RadioButContado.TabStop = True
        Me.RadioButContado.Text = "C&ontado"
        Me.RadioButContado.UseVisualStyleBackColor = True
        '
        'lblNotadeCredito
        '
        Me.lblNotadeCredito.AutoSize = True
        Me.lblNotadeCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotadeCredito.Location = New System.Drawing.Point(61, 16)
        Me.lblNotadeCredito.Name = "lblNotadeCredito"
        Me.lblNotadeCredito.Size = New System.Drawing.Size(156, 24)
        Me.lblNotadeCredito.TabIndex = 28
        Me.lblNotadeCredito.Text = "Nota de Credito"
        Me.lblNotadeCredito.Visible = False
        '
        'CboTipoDeComprobante
        '
        Me.CboTipoDeComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDeComprobante.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboTipoDeComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoDeComprobante.FormattingEnabled = True
        Me.CboTipoDeComprobante.Items.AddRange(New Object() {"X", "P"})
        Me.CboTipoDeComprobante.Location = New System.Drawing.Point(374, 121)
        Me.CboTipoDeComprobante.Name = "CboTipoDeComprobante"
        Me.CboTipoDeComprobante.Size = New System.Drawing.Size(50, 45)
        Me.CboTipoDeComprobante.TabIndex = 3
        '
        'dgvRenglones
        '
        Me.dgvRenglones.AllowUserToAddRows = False
        Me.dgvRenglones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRenglones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRenglones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRenglones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRenglones.Location = New System.Drawing.Point(20, 176)
        Me.dgvRenglones.Name = "dgvRenglones"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRenglones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRenglones.Size = New System.Drawing.Size(474, 272)
        Me.dgvRenglones.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNumeroFactura)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(64, 51)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Num"
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.Location = New System.Drawing.Point(7, 25)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(19, 13)
        Me.lblNumeroFactura.TabIndex = 0
        Me.lblNumeroFactura.Text = "Nº"
        '
        'txtCantidadItems
        '
        Me.txtCantidadItems.Enabled = False
        Me.txtCantidadItems.Location = New System.Drawing.Point(49, 459)
        Me.txtCantidadItems.Name = "txtCantidadItems"
        Me.txtCantidadItems.Size = New System.Drawing.Size(26, 20)
        Me.txtCantidadItems.TabIndex = 13
        Me.txtCantidadItems.Text = "0"
        Me.txtCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Cant:"
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.Location = New System.Drawing.Point(405, 457)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(86, 23)
        Me.cmdFinalizar.TabIndex = 3
        Me.cmdFinalizar.Text = "&Finalizar"
        Me.cmdFinalizar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cantidad de copias?"
        Me.Label5.Visible = False
        '
        'cboCantidadDeCopias
        '
        Me.cboCantidadDeCopias.FormattingEnabled = True
        Me.cboCantidadDeCopias.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboCantidadDeCopias.Location = New System.Drawing.Point(500, 412)
        Me.cboCantidadDeCopias.Name = "cboCantidadDeCopias"
        Me.cboCantidadDeCopias.Size = New System.Drawing.Size(44, 21)
        Me.cboCantidadDeCopias.TabIndex = 7
        Me.cboCantidadDeCopias.Text = "1"
        Me.cboCantidadDeCopias.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 451)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 29)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "$"
        '
        'lblToTaL
        '
        Me.lblToTaL.AutoSize = True
        Me.lblToTaL.BackColor = System.Drawing.Color.White
        Me.lblToTaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToTaL.Location = New System.Drawing.Point(163, 451)
        Me.lblToTaL.Name = "lblToTaL"
        Me.lblToTaL.Size = New System.Drawing.Size(26, 29)
        Me.lblToTaL.TabIndex = 20
        Me.lblToTaL.Text = "0"
        Me.lblToTaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Vendedor:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(359, 38)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(132, 21)
        Me.cmbVendedor.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(497, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "SubTotal:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.Color.White
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.Black
        Me.lblSubtotal.Location = New System.Drawing.Point(497, 287)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(15, 16)
        Me.lblSubtotal.TabIndex = 23
        Me.lblSubtotal.Text = "0"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(497, 457)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'btnIngresarCliente
        '
        Me.btnIngresarCliente.Location = New System.Drawing.Point(267, 38)
        Me.btnIngresarCliente.Name = "btnIngresarCliente"
        Me.btnIngresarCliente.Size = New System.Drawing.Size(23, 23)
        Me.btnIngresarCliente.TabIndex = 29
        Me.btnIngresarCliente.Text = "+"
        Me.btnIngresarCliente.UseVisualStyleBackColor = True
        '
        'frmTarjeta
        '
        Me.frmTarjeta.Controls.Add(Me.txtPorcentajeTarjeta)
        Me.frmTarjeta.Location = New System.Drawing.Point(290, 117)
        Me.frmTarjeta.Name = "frmTarjeta"
        Me.frmTarjeta.Size = New System.Drawing.Size(82, 49)
        Me.frmTarjeta.TabIndex = 30
        Me.frmTarjeta.TabStop = False
        Me.frmTarjeta.Text = "% Interes"
        Me.frmTarjeta.Visible = False
        '
        'txtPorcentajeTarjeta
        '
        Me.txtPorcentajeTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeTarjeta.Location = New System.Drawing.Point(10, 17)
        Me.txtPorcentajeTarjeta.Name = "txtPorcentajeTarjeta"
        Me.txtPorcentajeTarjeta.Size = New System.Drawing.Size(60, 26)
        Me.txtPorcentajeTarjeta.TabIndex = 0
        Me.txtPorcentajeTarjeta.Text = "0"
        Me.txtPorcentajeTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnActualizarPrecios
        '
        Me.btnActualizarPrecios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnActualizarPrecios.Location = New System.Drawing.Point(497, 176)
        Me.btnActualizarPrecios.Name = "btnActualizarPrecios"
        Me.btnActualizarPrecios.Size = New System.Drawing.Size(91, 37)
        Me.btnActualizarPrecios.TabIndex = 31
        Me.btnActualizarPrecios.Text = "Actualizar Precios"
        Me.btnActualizarPrecios.UseVisualStyleBackColor = True
        '
        'txtLector
        '
        Me.txtLector.Location = New System.Drawing.Point(141, 74)
        Me.txtLector.MaxLength = 20
        Me.txtLector.Name = "txtLector"
        Me.txtLector.Size = New System.Drawing.Size(260, 20)
        Me.txtLector.TabIndex = 0
        '
        'cmdModificarItem
        '
        Me.cmdModificarItem.Location = New System.Drawing.Point(610, 162)
        Me.cmdModificarItem.Name = "cmdModificarItem"
        Me.cmdModificarItem.Size = New System.Drawing.Size(48, 23)
        Me.cmdModificarItem.TabIndex = 6
        Me.cmdModificarItem.Text = "&Modificar Item"
        Me.cmdModificarItem.UseVisualStyleBackColor = True
        Me.cmdModificarItem.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cantidad / Codigo (F12):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(409, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Cantidad:"
        '
        'txtCantidadActual
        '
        Me.txtCantidadActual.Location = New System.Drawing.Point(497, 74)
        Me.txtCantidadActual.Name = "txtCantidadActual"
        Me.txtCantidadActual.ReadOnly = True
        Me.txtCantidadActual.Size = New System.Drawing.Size(91, 20)
        Me.txtCantidadActual.TabIndex = 35
        Me.txtCantidadActual.Text = "1"
        Me.txtCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Checked = True
        Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImprimir.Location = New System.Drawing.Point(502, 21)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(61, 17)
        Me.chkImprimir.TabIndex = 37
        Me.chkImprimir.Text = "Imprimir"
        Me.chkImprimir.UseVisualStyleBackColor = True
        '
        'picBuscar
        '
        Me.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBuscar.Image = Global.Saturn_1.Saturn.My.Resources.Resources.buscar
        Me.picBuscar.Location = New System.Drawing.Point(244, 38)
        Me.picBuscar.Name = "picBuscar"
        Me.picBuscar.Size = New System.Drawing.Size(17, 21)
        Me.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuscar.TabIndex = 7
        Me.picBuscar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Saturn_1.Saturn.My.Resources.Resources.printer
        Me.PictureBox1.Location = New System.Drawing.Point(559, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(405, 457)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 23)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'hiloSegundoPlano
        '
        '
        'btnDeCambio
        '
        Me.btnDeCambio.Location = New System.Drawing.Point(497, 216)
        Me.btnDeCambio.Name = "btnDeCambio"
        Me.btnDeCambio.Size = New System.Drawing.Size(91, 23)
        Me.btnDeCambio.TabIndex = 40
        Me.btnDeCambio.Text = "&De cambio"
        Me.btnDeCambio.UseVisualStyleBackColor = True
        '
        'CheckRemito
        '
        Me.CheckRemito.AutoSize = True
        Me.CheckRemito.Location = New System.Drawing.Point(502, 49)
        Me.CheckRemito.Name = "CheckRemito"
        Me.CheckRemito.Size = New System.Drawing.Size(82, 17)
        Me.CheckRemito.TabIndex = 41
        Me.CheckRemito.Text = "Con remito?"
        Me.CheckRemito.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(497, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "IVA:"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.BackColor = System.Drawing.Color.White
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.ForeColor = System.Drawing.Color.Black
        Me.lblIva.Location = New System.Drawing.Point(497, 319)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(15, 16)
        Me.lblIva.TabIndex = 27
        Me.lblIva.Text = "0"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.BackColor = System.Drawing.Color.White
        Me.lblInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteres.ForeColor = System.Drawing.Color.Black
        Me.lblInteres.Location = New System.Drawing.Point(497, 351)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(15, 16)
        Me.lblInteres.TabIndex = 43
        Me.lblInteres.Text = "0"
        Me.lblInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(497, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Interes:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Location = New System.Drawing.Point(497, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(82, 49)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "% Desc"
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(10, 17)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(60, 26)
        Me.txtDescuento.TabIndex = 0
        Me.txtDescuento.Text = "0"
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.Color.White
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.ForeColor = System.Drawing.Color.Black
        Me.lblDescuento.Location = New System.Drawing.Point(497, 383)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(15, 16)
        Me.lblDescuento.TabIndex = 45
        Me.lblDescuento.Text = "0"
        Me.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(497, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Descuento"
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 484)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckRemito)
        Me.Controls.Add(Me.btnDeCambio)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkImprimir)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantidadActual)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLector)
        Me.Controls.Add(Me.btnActualizarPrecios)
        Me.Controls.Add(Me.frmTarjeta)
        Me.Controls.Add(Me.btnIngresarCliente)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblToTaL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCantidadDeCopias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidadItems)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvRenglones)
        Me.Controls.Add(Me.cmdModificarItem)
        Me.Controls.Add(Me.CboTipoDeComprobante)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.cmdQuitarItem)
        Me.Controls.Add(Me.CmdArmarRenglon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(606, 512)
        Me.MinimumSize = New System.Drawing.Size(606, 512)
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion - Saturn 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmTarjeta.ResumeLayout(False)
        Me.frmTarjeta.PerformLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdArmarRenglon As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarItem As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FacturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeCreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButCtaCte As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButContado As System.Windows.Forms.RadioButton
    Friend WithEvents CboTipoDeComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents dgvRenglones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
    Friend WithEvents txtCantidadItems As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCantidadDeCopias As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblToTaL As System.Windows.Forms.Label
    Friend WithEvents AnularFacturaF3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescripcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents ClientePredeterminadoF12ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblNotadeCredito As System.Windows.Forms.Label
    Friend WithEvents btnIngresarCliente As System.Windows.Forms.Button
    Friend WithEvents frmTarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents txtPorcentajeTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents RadioButTarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents btnActualizarPrecios As System.Windows.Forms.Button
    Friend WithEvents ToolTipLector As System.Windows.Forms.ToolTip
    Friend WithEvents txtLector As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificarItem As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadActual As System.Windows.Forms.TextBox
    Friend WithEvents chkImprimir As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents hiloSegundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnDeCambio As System.Windows.Forms.Button
    Friend WithEvents CheckRemito As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents lblInteres As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
