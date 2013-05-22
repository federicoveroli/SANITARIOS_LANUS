<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosPorReponer
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
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtQueContenga = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mnuArticulos = New System.Windows.Forms.MenuStrip
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.mnuArticulos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdSalir
        '
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.Location = New System.Drawing.Point(674, 393)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 7
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(576, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Ctrl + F5 = Proveedor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(434, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Ctrl + F4 = Listado Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Ctrl + F3 = Descripcion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Ctrl + F2 = Marca"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Ctrl + F1 = Tipo de Producto"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(674, 36)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 33
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtQueContenga
        '
        Me.txtQueContenga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQueContenga.Location = New System.Drawing.Point(388, 38)
        Me.txtQueContenga.MaxLength = 99
        Me.txtQueContenga.Name = "txtQueContenga"
        Me.txtQueContenga.Size = New System.Drawing.Size(241, 20)
        Me.txtQueContenga.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "que contenga :"
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Listado total", "Tipo de Producto", "Descripcion", "Marca", "Proveedor"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(87, 38)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(164, 21)
        Me.cmbBuscarPor.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Buscar por"
        '
        'mnuArticulos
        '
        Me.mnuArticulos.AllowMerge = False
        Me.mnuArticulos.BackColor = System.Drawing.Color.White
        Me.mnuArticulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaToolStripMenuItem})
        Me.mnuArticulos.Location = New System.Drawing.Point(0, 0)
        Me.mnuArticulos.Name = "mnuArticulos"
        Me.mnuArticulos.Size = New System.Drawing.Size(761, 24)
        Me.mnuArticulos.TabIndex = 35
        Me.mnuArticulos.Text = "MenuStrip1"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.DescripcionToolStripMenuItem, Me.ListadoTotalToolStripMenuItem, Me.ProveedorToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(734, 322)
        Me.DataGridView1.TabIndex = 40
        '
        'frmArticulosPorReponer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 428)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtQueContenga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuArticulos)
        Me.Controls.Add(Me.CmdSalir)
        Me.Name = "frmArticulosPorReponer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos Por Reponer"
        Me.mnuArticulos.ResumeLayout(False)
        Me.mnuArticulos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtQueContenga As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuArticulos As System.Windows.Forms.MenuStrip
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescripcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
