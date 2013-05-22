<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClienteBuscar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdBaja = New System.Windows.Forms.Button
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.txtQueContenga = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdNuevoCliente = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CodigoPostalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSeleccionar = New System.Windows.Forms.Button
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdModificar
        '
        Me.cmdModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificar.Location = New System.Drawing.Point(609, 455)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 4
        Me.cmdModificar.Text = "&Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        Me.cmdModificar.Visible = False
        '
        'cmdBaja
        '
        Me.cmdBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBaja.Location = New System.Drawing.Point(608, 455)
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(75, 23)
        Me.cmdBaja.TabIndex = 16
        Me.cmdBaja.Text = "Baja"
        Me.cmdBaja.UseVisualStyleBackColor = True
        Me.cmdBaja.Visible = False
        '
        'CmdSalir
        '
        Me.CmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.Location = New System.Drawing.Point(690, 455)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 5
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(690, 28)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(25, 57)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(740, 381)
        Me.dgvClientes.TabIndex = 3
        '
        'txtQueContenga
        '
        Me.txtQueContenga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga.Location = New System.Drawing.Point(410, 29)
        Me.txtQueContenga.MaxLength = 99
        Me.txtQueContenga.Name = "txtQueContenga"
        Me.txtQueContenga.Size = New System.Drawing.Size(184, 20)
        Me.txtQueContenga.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "que contenga :"
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Id Cliente", "Nombre", "Localidad", "Codigo Postal", "Rubro", "Cuit", "Iva", "Listado Total"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(96, 29)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(203, 21)
        Me.cmbBuscarPor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar por"
        '
        'cmdNuevoCliente
        '
        Me.cmdNuevoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevoCliente.Location = New System.Drawing.Point(506, 455)
        Me.cmdNuevoCliente.Name = "cmdNuevoCliente"
        Me.cmdNuevoCliente.Size = New System.Drawing.Size(96, 23)
        Me.cmdNuevoCliente.TabIndex = 6
        Me.cmdNuevoCliente.Text = "&Nuevo Cliente"
        Me.cmdNuevoCliente.UseVisualStyleBackColor = True
        Me.cmdNuevoCliente.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdClienteToolStripMenuItem, Me.NombreToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.CodigoPostalToolStripMenuItem, Me.RubroToolStripMenuItem, Me.CuitToolStripMenuItem, Me.IvaToolStripMenuItem, Me.ListadoTotalToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'IdClienteToolStripMenuItem
        '
        Me.IdClienteToolStripMenuItem.Name = "IdClienteToolStripMenuItem"
        Me.IdClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.IdClienteToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.IdClienteToolStripMenuItem.Text = "Id Cliente"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'CodigoPostalToolStripMenuItem
        '
        Me.CodigoPostalToolStripMenuItem.Name = "CodigoPostalToolStripMenuItem"
        Me.CodigoPostalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CodigoPostalToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CodigoPostalToolStripMenuItem.Text = "Codigo Postal"
        '
        'RubroToolStripMenuItem
        '
        Me.RubroToolStripMenuItem.Name = "RubroToolStripMenuItem"
        Me.RubroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.RubroToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RubroToolStripMenuItem.Text = "Rubro"
        '
        'CuitToolStripMenuItem
        '
        Me.CuitToolStripMenuItem.Name = "CuitToolStripMenuItem"
        Me.CuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.CuitToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CuitToolStripMenuItem.Text = "Cuit"
        '
        'IvaToolStripMenuItem
        '
        Me.IvaToolStripMenuItem.Name = "IvaToolStripMenuItem"
        Me.IvaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.IvaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.IvaToolStripMenuItem.Text = "Iva"
        '
        'ListadoTotalToolStripMenuItem
        '
        Me.ListadoTotalToolStripMenuItem.Name = "ListadoTotalToolStripMenuItem"
        Me.ListadoTotalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F8), System.Windows.Forms.Keys)
        Me.ListadoTotalToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListadoTotalToolStripMenuItem.Text = "Listado Total"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSeleccionar.Location = New System.Drawing.Point(609, 455)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(74, 23)
        Me.cmdSeleccionar.TabIndex = 20
        Me.cmdSeleccionar.Text = "&Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = True
        Me.cmdSeleccionar.Visible = False
        '
        'FrmClienteBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CmdSalir
        Me.ClientSize = New System.Drawing.Size(794, 492)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.cmdNuevoCliente)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBaja)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtQueContenga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmClienteBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saturn 1.0 - Busqueda de clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdBaja As System.Windows.Forms.Button
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtQueContenga As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodigoPostalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
End Class
