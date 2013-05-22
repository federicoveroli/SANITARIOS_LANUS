<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasBuscar
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
        Me.cmdDetalles = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdAnular = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.dgvFacturas = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.cmdNotaDeCredito = New System.Windows.Forms.Button
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbVendedor = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbProducto = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox
        Me.ToolTipDescripcion = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbProveedores = New System.Windows.Forms.ComboBox
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDetalles
        '
        Me.cmdDetalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDetalles.Location = New System.Drawing.Point(510, 436)
        Me.cmdDetalles.Name = "cmdDetalles"
        Me.cmdDetalles.Size = New System.Drawing.Size(80, 23)
        Me.cmdDetalles.TabIndex = 47
        Me.cmdDetalles.Text = "&Detalles"
        Me.cmdDetalles.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(677, 13)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 46
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdAnular
        '
        Me.cmdAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.Location = New System.Drawing.Point(596, 436)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnular.TabIndex = 45
        Me.cmdAnular.Text = "&Eliminar"
        Me.cmdAnular.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(677, 436)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 44
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 89)
        Me.dgvFacturas.MultiSelect = False
        Me.dgvFacturas.Name = "dgvFacturas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(740, 334)
        Me.dgvFacturas.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(710, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cliente:"
        Me.Label2.Visible = False
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(758, 31)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(140, 21)
        Me.cmbCliente.TabIndex = 37
        Me.cmbCliente.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Tipo:"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"A", "B", "X", "P", "NC"})
        Me.cmbTipo.Location = New System.Drawing.Point(528, 14)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(62, 21)
        Me.cmbTipo.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(596, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "N:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(620, 14)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(49, 20)
        Me.txtNumero.TabIndex = 51
        '
        'cmdNotaDeCredito
        '
        Me.cmdNotaDeCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdNotaDeCredito.Enabled = False
        Me.cmdNotaDeCredito.Location = New System.Drawing.Point(15, 436)
        Me.cmdNotaDeCredito.Name = "cmdNotaDeCredito"
        Me.cmdNotaDeCredito.Size = New System.Drawing.Size(119, 23)
        Me.cmdNotaDeCredito.TabIndex = 52
        Me.cmdNotaDeCredito.Text = "&Nota de credito"
        Me.cmdNotaDeCredito.UseVisualStyleBackColor = True
        '
        'cmdImportar
        '
        Me.cmdImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImportar.Enabled = False
        Me.cmdImportar.Location = New System.Drawing.Point(141, 436)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(80, 23)
        Me.cmdImportar.TabIndex = 53
        Me.cmdImportar.Text = "&Importar"
        Me.cmdImportar.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImprimir.Location = New System.Drawing.Point(227, 436)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 23)
        Me.cmdImprimir.TabIndex = 54
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Vendedor:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(335, 14)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(140, 21)
        Me.cmbVendedor.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Producto:"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(227, 49)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(248, 21)
        Me.cmbProducto.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(524, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Tipo \Producto:"
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(612, 50)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(140, 21)
        Me.cmbTipoProducto.TabIndex = 59
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(69, 50)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(140, 20)
        Me.txtDescripcionProducto.TabIndex = 61
        Me.ToolTipDescripcion.SetToolTip(Me.txtDescripcionProducto, "Ingrese la descripción del producto o parte de esta....")
        '
        'ToolTipDescripcion
        '
        Me.ToolTipDescripcion.IsBalloon = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Proveedor:"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(69, 14)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(198, 21)
        Me.cmbProveedores.TabIndex = 62
        '
        'frmFacturasBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 481)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.txtDescripcionProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTipoProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdNotaDeCredito)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDetalles)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdAnular)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCliente)
        Me.Name = "frmFacturasBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Facturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdDetalles As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdAnular As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cmdNotaDeCredito As System.Windows.Forms.Button
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipDescripcion As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
End Class
