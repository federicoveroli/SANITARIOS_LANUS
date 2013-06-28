<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulosModificarAumentar
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtQueContenga = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.CmdSalir = New System.Windows.Forms.Button
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
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmdAceptarAumento = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtVariable = New System.Windows.Forms.TextBox
        Me.cmdEliminarSeleccionado = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.ToolTipLector = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDto1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdto4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdto3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdto2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdto1 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtg4 = New System.Windows.Forms.TextBox
        Me.txtg3 = New System.Windows.Forms.TextBox
        Me.txtg2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtg1 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuArticulos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
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
        Me.cmbBuscarPor.Location = New System.Drawing.Point(105, 37)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(164, 21)
        Me.cmbBuscarPor.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "que contenga :"
        '
        'txtQueContenga
        '
        Me.txtQueContenga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga.Location = New System.Drawing.Point(406, 37)
        Me.txtQueContenga.MaxLength = 99
        Me.txtQueContenga.Name = "txtQueContenga"
        Me.txtQueContenga.Size = New System.Drawing.Size(241, 20)
        Me.txtQueContenga.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(33, 63)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(940, 343)
        Me.DataGridView1.TabIndex = 4
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(695, 35)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.Location = New System.Drawing.Point(898, 554)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 4
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
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
        Me.mnuArticulos.Size = New System.Drawing.Size(997, 24)
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
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmdAceptarAumento)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.txtVariable)
        Me.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GroupBox2.Location = New System.Drawing.Point(33, 408)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 47)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar porcentaje para modificar el precio de lista del proveedor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(86, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "%"
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
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(9, 18)
        Me.txtVariable.MaxLength = 6
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(71, 20)
        Me.txtVariable.TabIndex = 0
        Me.txtVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdEliminarSeleccionado
        '
        Me.cmdEliminarSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminarSeleccionado.Location = New System.Drawing.Point(862, 412)
        Me.cmdEliminarSeleccionado.Name = "cmdEliminarSeleccionado"
        Me.cmdEliminarSeleccionado.Size = New System.Drawing.Size(111, 23)
        Me.cmdEliminarSeleccionado.TabIndex = 5
        Me.cmdEliminarSeleccionado.Text = "Quitar seleccionado"
        Me.cmdEliminarSeleccionado.UseVisualStyleBackColor = True
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
        Me.cmdImprimir.Location = New System.Drawing.Point(817, 554)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
        Me.cmdImprimir.TabIndex = 3
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnDto1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdto4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtdto3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdto2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdto1)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GroupBox1.Location = New System.Drawing.Point(33, 461)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 86)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar descuentos del proveedor"
        '
        'btnDto1
        '
        Me.btnDto1.Location = New System.Drawing.Point(9, 47)
        Me.btnDto1.Name = "btnDto1"
        Me.btnDto1.Size = New System.Drawing.Size(327, 23)
        Me.btnDto1.TabIndex = 9
        Me.btnDto1.Text = "Modif. solo descuentos completos"
        Me.btnDto1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Dto. 4"
        '
        'txtdto4
        '
        Me.txtdto4.Location = New System.Drawing.Point(300, 21)
        Me.txtdto4.MaxLength = 6
        Me.txtdto4.Name = "txtdto4"
        Me.txtdto4.Size = New System.Drawing.Size(36, 20)
        Me.txtdto4.TabIndex = 7
        Me.txtdto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dto. 3"
        '
        'txtdto3
        '
        Me.txtdto3.Location = New System.Drawing.Point(216, 21)
        Me.txtdto3.MaxLength = 6
        Me.txtdto3.Name = "txtdto3"
        Me.txtdto3.Size = New System.Drawing.Size(36, 20)
        Me.txtdto3.TabIndex = 5
        Me.txtdto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Dto. 2"
        '
        'txtdto2
        '
        Me.txtdto2.Location = New System.Drawing.Point(132, 21)
        Me.txtdto2.MaxLength = 6
        Me.txtdto2.Name = "txtdto2"
        Me.txtdto2.Size = New System.Drawing.Size(36, 20)
        Me.txtdto2.TabIndex = 3
        Me.txtdto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dto. 1"
        '
        'txtdto1
        '
        Me.txtdto1.Location = New System.Drawing.Point(48, 21)
        Me.txtdto1.MaxLength = 6
        Me.txtdto1.Name = "txtdto1"
        Me.txtdto1.Size = New System.Drawing.Size(36, 20)
        Me.txtdto1.TabIndex = 1
        Me.txtdto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtg4)
        Me.GroupBox3.Controls.Add(Me.txtg3)
        Me.GroupBox3.Controls.Add(Me.txtg2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.txtg1)
        Me.GroupBox3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GroupBox3.Location = New System.Drawing.Point(406, 461)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 86)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modificar Utilidad del artículo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(261, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Gcia. 4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(90, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Gcia. 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(174, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Gcia. 3"
        '
        'txtg4
        '
        Me.txtg4.Location = New System.Drawing.Point(300, 21)
        Me.txtg4.MaxLength = 6
        Me.txtg4.Name = "txtg4"
        Me.txtg4.Size = New System.Drawing.Size(36, 20)
        Me.txtg4.TabIndex = 7
        Me.txtg4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtg3
        '
        Me.txtg3.Location = New System.Drawing.Point(219, 21)
        Me.txtg3.MaxLength = 6
        Me.txtg3.Name = "txtg3"
        Me.txtg3.Size = New System.Drawing.Size(36, 20)
        Me.txtg3.TabIndex = 5
        Me.txtg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtg2
        '
        Me.txtg2.Location = New System.Drawing.Point(132, 21)
        Me.txtg2.MaxLength = 6
        Me.txtg2.Name = "txtg2"
        Me.txtg2.Size = New System.Drawing.Size(36, 20)
        Me.txtg2.TabIndex = 3
        Me.txtg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Gcia. 1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(330, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Modif todos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtg1
        '
        Me.txtg1.Location = New System.Drawing.Point(48, 21)
        Me.txtg1.MaxLength = 6
        Me.txtg1.Name = "txtg1"
        Me.txtg1.Size = New System.Drawing.Size(36, 20)
        Me.txtg1.TabIndex = 1
        Me.txtg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmArticulosModificarAumentar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CmdSalir
        Me.ClientSize = New System.Drawing.Size(997, 589)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdEliminarSeleccionado)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuArticulos
        Me.MinimumSize = New System.Drawing.Size(800, 538)
        Me.Name = "FrmArticulosModificarAumentar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Precioss - Saturn 1.0 "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuArticulos.ResumeLayout(False)
        Me.mnuArticulos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminarSeleccionado As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents FiltrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTipLector As System.Windows.Forms.ToolTip
    Friend WithEvents CodigoDeBarrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdto4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdto3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdto2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdto1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtg4 As System.Windows.Forms.TextBox
    Friend WithEvents txtg3 As System.Windows.Forms.TextBox
    Friend WithEvents txtg2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtg1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDto1 As System.Windows.Forms.Button
End Class
