<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadesVendidas
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
        Me.gbFecha = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.gbVendedor = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbVendedores = New System.Windows.Forms.ComboBox
        Me.chkVendedor = New System.Windows.Forms.CheckBox
        Me.gbProveedor = New System.Windows.Forms.GroupBox
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbProveedores = New System.Windows.Forms.ComboBox
        Me.chkProveedor = New System.Windows.Forms.CheckBox
        Me.dgvFacturas = New System.Windows.Forms.DataGridView
        Me.gbProducto = New System.Windows.Forms.GroupBox
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbProductos = New System.Windows.Forms.ComboBox
        Me.ToolTipDetalles = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotales = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtUnidades = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.gbFP = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbFP = New System.Windows.Forms.ComboBox
        Me.chkFP = New System.Windows.Forms.CheckBox
        Me.chkProducto = New System.Windows.Forms.CheckBox
        Me.gbFecha.SuspendLayout()
        Me.gbVendedor.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProducto.SuspendLayout()
        Me.gbFP.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFecha
        '
        Me.gbFecha.Controls.Add(Me.Label2)
        Me.gbFecha.Controls.Add(Me.Label1)
        Me.gbFecha.Controls.Add(Me.dtphasta)
        Me.gbFecha.Controls.Add(Me.dtpdesde)
        Me.gbFecha.Enabled = False
        Me.gbFecha.Location = New System.Drawing.Point(12, 12)
        Me.gbFecha.Name = "gbFecha"
        Me.gbFecha.Size = New System.Drawing.Size(158, 89)
        Me.gbFecha.TabIndex = 1
        Me.gbFecha.TabStop = False
        Me.gbFecha.Text = "                                             "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde"
        '
        'dtphasta
        '
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(54, 54)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(94, 20)
        Me.dtphasta.TabIndex = 7
        '
        'dtpdesde
        '
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesde.Location = New System.Drawing.Point(56, 28)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(94, 20)
        Me.dtpdesde.TabIndex = 6
        '
        'gbVendedor
        '
        Me.gbVendedor.Controls.Add(Me.Label4)
        Me.gbVendedor.Controls.Add(Me.cmbVendedores)
        Me.gbVendedor.Enabled = False
        Me.gbVendedor.Location = New System.Drawing.Point(578, 11)
        Me.gbVendedor.Name = "gbVendedor"
        Me.gbVendedor.Size = New System.Drawing.Size(181, 90)
        Me.gbVendedor.TabIndex = 2
        Me.gbVendedor.TabStop = False
        Me.gbVendedor.Text = "                                           "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Vendedor:"
        '
        'cmbVendedores
        '
        Me.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedores.FormattingEnabled = True
        Me.cmbVendedores.Location = New System.Drawing.Point(18, 54)
        Me.cmbVendedores.Name = "cmbVendedores"
        Me.cmbVendedores.Size = New System.Drawing.Size(139, 21)
        Me.cmbVendedores.TabIndex = 1
        '
        'chkVendedor
        '
        Me.chkVendedor.AutoSize = True
        Me.chkVendedor.Location = New System.Drawing.Point(594, 10)
        Me.chkVendedor.Name = "chkVendedor"
        Me.chkVendedor.Size = New System.Drawing.Size(119, 17)
        Me.chkVendedor.TabIndex = 4
        Me.chkVendedor.Text = "Filtrar Por Vendedor"
        Me.chkVendedor.UseVisualStyleBackColor = True
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.txtProveedor)
        Me.gbProveedor.Controls.Add(Me.Label5)
        Me.gbProveedor.Controls.Add(Me.Label3)
        Me.gbProveedor.Controls.Add(Me.cmbProveedores)
        Me.gbProveedor.Enabled = False
        Me.gbProveedor.Location = New System.Drawing.Point(176, 12)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(396, 90)
        Me.gbProveedor.TabIndex = 3
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "                                           "
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(80, 29)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(301, 20)
        Me.txtProveedor.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contenido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Proveedor"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(80, 53)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(301, 21)
        Me.cmbProveedores.TabIndex = 1
        '
        'chkProveedor
        '
        Me.chkProveedor.AutoSize = True
        Me.chkProveedor.Location = New System.Drawing.Point(192, 10)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.Size = New System.Drawing.Size(122, 17)
        Me.chkProveedor.TabIndex = 4
        Me.chkProveedor.Text = "Filtrar Por Proveedor"
        Me.chkProveedor.UseVisualStyleBackColor = True
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
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 180)
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
        Me.dgvFacturas.Size = New System.Drawing.Size(747, 248)
        Me.dgvFacturas.TabIndex = 44
        '
        'gbProducto
        '
        Me.gbProducto.Controls.Add(Me.txtProducto)
        Me.gbProducto.Controls.Add(Me.Label6)
        Me.gbProducto.Controls.Add(Me.Label7)
        Me.gbProducto.Controls.Add(Me.cmbProductos)
        Me.gbProducto.Enabled = False
        Me.gbProducto.Location = New System.Drawing.Point(12, 118)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(560, 52)
        Me.gbProducto.TabIndex = 45
        Me.gbProducto.TabStop = False
        Me.gbProducto.Text = "                                           "
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(75, 19)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(115, 20)
        Me.txtProducto.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contenido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Producto"
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(252, 20)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(293, 21)
        Me.cmbProductos.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(642, 440)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "$"
        '
        'txtTotales
        '
        Me.txtTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotales.Location = New System.Drawing.Point(661, 437)
        Me.txtTotales.Name = "txtTotales"
        Me.txtTotales.ReadOnly = True
        Me.txtTotales.Size = New System.Drawing.Size(98, 20)
        Me.txtTotales.TabIndex = 46
        Me.txtTotales.Text = "0"
        Me.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(517, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Unidades:"
        '
        'txtUnidades
        '
        Me.txtUnidades.AcceptsReturn = True
        Me.txtUnidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnidades.Location = New System.Drawing.Point(574, 437)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.ReadOnly = True
        Me.txtUnidades.Size = New System.Drawing.Size(53, 20)
        Me.txtUnidades.TabIndex = 48
        Me.txtUnidades.Text = "0"
        Me.txtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(451, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Totales"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Checked = True
        Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFecha.Location = New System.Drawing.Point(29, 11)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(103, 17)
        Me.chkFecha.TabIndex = 51
        Me.chkFecha.Text = "Filtrar Por Fecha"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'gbFP
        '
        Me.gbFP.Controls.Add(Me.Label10)
        Me.gbFP.Controls.Add(Me.cmbFP)
        Me.gbFP.Enabled = False
        Me.gbFP.Location = New System.Drawing.Point(580, 118)
        Me.gbFP.Name = "gbFP"
        Me.gbFP.Size = New System.Drawing.Size(181, 52)
        Me.gbFP.TabIndex = 52
        Me.gbFP.TabStop = False
        Me.gbFP.Text = "                                           "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "FP"
        '
        'cmbFP
        '
        Me.cmbFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFP.FormattingEnabled = True
        Me.cmbFP.Items.AddRange(New Object() {"EFECTIVO (E)", "TARJETA (T)"})
        Me.cmbFP.Location = New System.Drawing.Point(39, 22)
        Me.cmbFP.Name = "cmbFP"
        Me.cmbFP.Size = New System.Drawing.Size(115, 21)
        Me.cmbFP.TabIndex = 1
        '
        'chkFP
        '
        Me.chkFP.AutoSize = True
        Me.chkFP.Location = New System.Drawing.Point(596, 115)
        Me.chkFP.Name = "chkFP"
        Me.chkFP.Size = New System.Drawing.Size(86, 17)
        Me.chkFP.TabIndex = 53
        Me.chkFP.Text = "Filtrar Por FP"
        Me.chkFP.UseVisualStyleBackColor = True
        '
        'chkProducto
        '
        Me.chkProducto.AutoSize = True
        Me.chkProducto.Location = New System.Drawing.Point(29, 114)
        Me.chkProducto.Name = "chkProducto"
        Me.chkProducto.Size = New System.Drawing.Size(116, 17)
        Me.chkProducto.TabIndex = 53
        Me.chkProducto.Text = "Filtrar Por Producto"
        Me.chkProducto.UseVisualStyleBackColor = True
        '
        'frmUnidadesVendidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 469)
        Me.Controls.Add(Me.chkFP)
        Me.Controls.Add(Me.chkProducto)
        Me.Controls.Add(Me.chkVendedor)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkProveedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotales)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.gbProveedor)
        Me.Controls.Add(Me.gbFecha)
        Me.Controls.Add(Me.gbProducto)
        Me.Controls.Add(Me.gbVendedor)
        Me.Controls.Add(Me.gbFP)
        Me.Name = "frmUnidadesVendidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unidades Vendidas"
        Me.gbFecha.ResumeLayout(False)
        Me.gbFecha.PerformLayout()
        Me.gbVendedor.ResumeLayout(False)
        Me.gbVendedor.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProducto.ResumeLayout(False)
        Me.gbProducto.PerformLayout()
        Me.gbFP.ResumeLayout(False)
        Me.gbFP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVendedores As System.Windows.Forms.ComboBox
    Friend WithEvents chkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipDetalles As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotales As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents gbFP As System.Windows.Forms.GroupBox
    Friend WithEvents chkFP As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbFP As System.Windows.Forms.ComboBox
    Friend WithEvents chkProducto As System.Windows.Forms.CheckBox
End Class
