<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorAlta
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtLista = New System.Windows.Forms.TextBox
        Me.txtBonificaciones = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdAgregarRubro = New System.Windows.Forms.Button
        Me.cmbRubro = New System.Windows.Forms.ComboBox
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnModificarDomicilio = New System.Windows.Forms.Button
        Me.btnEliminarDomicilio = New System.Windows.Forms.Button
        Me.btnAgregarDomicilio = New System.Windows.Forms.Button
        Me.dgvDomicilios = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView
        Me.cmbTipoTelefono = New System.Windows.Forms.ComboBox
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtNombreContacto = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmdModifProveedor = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bonificaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Rubro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(517, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(492, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha alta"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(104, 24)
        Me.txtNombre.MaxLength = 99
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(113, 20)
        Me.txtNombre.TabIndex = 14
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(104, 52)
        Me.txtLista.MaxLength = 20
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(113, 20)
        Me.txtLista.TabIndex = 19
        '
        'txtBonificaciones
        '
        Me.txtBonificaciones.Location = New System.Drawing.Point(309, 24)
        Me.txtBonificaciones.MaxLength = 20
        Me.txtBonificaciones.Name = "txtBonificaciones"
        Me.txtBonificaciones.Size = New System.Drawing.Size(134, 20)
        Me.txtBonificaciones.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(555, 26)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(134, 20)
        Me.txtEmail.TabIndex = 22
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(706, 382)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 25
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(619, 382)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 24
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdAgregarRubro
        '
        Me.cmdAgregarRubro.Location = New System.Drawing.Point(449, 51)
        Me.cmdAgregarRubro.Name = "cmdAgregarRubro"
        Me.cmdAgregarRubro.Size = New System.Drawing.Size(31, 23)
        Me.cmdAgregarRubro.TabIndex = 34
        Me.cmdAgregarRubro.Text = "+"
        Me.cmdAgregarRubro.UseVisualStyleBackColor = True
        '
        'cmbRubro
        '
        Me.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(309, 51)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(134, 21)
        Me.cmbRubro.TabIndex = 33
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(555, 55)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(134, 20)
        Me.dtpFechaAlta.TabIndex = 35
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnModificarDomicilio)
        Me.GroupBox4.Controls.Add(Me.btnEliminarDomicilio)
        Me.GroupBox4.Controls.Add(Me.btnAgregarDomicilio)
        Me.GroupBox4.Controls.Add(Me.dgvDomicilios)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 127)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Domicilios del proveedor:"
        '
        'btnModificarDomicilio
        '
        Me.btnModificarDomicilio.Location = New System.Drawing.Point(687, 95)
        Me.btnModificarDomicilio.Name = "btnModificarDomicilio"
        Me.btnModificarDomicilio.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarDomicilio.TabIndex = 2
        Me.btnModificarDomicilio.Text = "Modificar"
        Me.btnModificarDomicilio.UseVisualStyleBackColor = True
        '
        'btnEliminarDomicilio
        '
        Me.btnEliminarDomicilio.Location = New System.Drawing.Point(687, 66)
        Me.btnEliminarDomicilio.Name = "btnEliminarDomicilio"
        Me.btnEliminarDomicilio.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarDomicilio.TabIndex = 1
        Me.btnEliminarDomicilio.Text = "Eliminar"
        Me.btnEliminarDomicilio.UseVisualStyleBackColor = True
        '
        'btnAgregarDomicilio
        '
        Me.btnAgregarDomicilio.Location = New System.Drawing.Point(687, 37)
        Me.btnAgregarDomicilio.Name = "btnAgregarDomicilio"
        Me.btnAgregarDomicilio.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarDomicilio.TabIndex = 0
        Me.btnAgregarDomicilio.Text = "Agregar"
        Me.btnAgregarDomicilio.UseVisualStyleBackColor = True
        '
        'dgvDomicilios
        '
        Me.dgvDomicilios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDomicilios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDomicilios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDomicilios.Location = New System.Drawing.Point(6, 19)
        Me.dgvDomicilios.MultiSelect = False
        Me.dgvDomicilios.Name = "dgvDomicilios"
        Me.dgvDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDomicilios.Size = New System.Drawing.Size(675, 98)
        Me.dgvDomicilios.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTelefonos)
        Me.GroupBox1.Controls.Add(Me.cmbTipoTelefono)
        Me.GroupBox1.Controls.Add(Me.cmdEliminar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtNombreContacto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 162)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contactos"
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTelefonos.Location = New System.Drawing.Point(325, 28)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(426, 107)
        Me.dgvTelefonos.TabIndex = 32
        '
        'cmbTipoTelefono
        '
        Me.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTelefono.FormattingEnabled = True
        Me.cmbTipoTelefono.Location = New System.Drawing.Point(113, 53)
        Me.cmbTipoTelefono.Name = "cmbTipoTelefono"
        Me.cmbTipoTelefono.Size = New System.Drawing.Size(206, 21)
        Me.cmbTipoTelefono.TabIndex = 1
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(156, 112)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(57, 23)
        Me.cmdEliminar.TabIndex = 30
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(89, 112)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(61, 23)
        Me.cmdModificar.TabIndex = 29
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(26, 112)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(57, 23)
        Me.cmdAgregar.TabIndex = 28
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(113, 80)
        Me.txtTelefono.MaxLength = 18
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(206, 20)
        Me.txtTelefono.TabIndex = 2
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.Location = New System.Drawing.Point(113, 29)
        Me.txtNombreContacto.MaxLength = 99
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(206, 20)
        Me.txtNombreContacto.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Nombre contacto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tipo Telefono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Telefono"
        '
        'cmdModifProveedor
        '
        Me.cmdModifProveedor.Location = New System.Drawing.Point(619, 382)
        Me.cmdModifProveedor.Name = "cmdModifProveedor"
        Me.cmdModifProveedor.Size = New System.Drawing.Size(75, 23)
        Me.cmdModifProveedor.TabIndex = 38
        Me.cmdModifProveedor.Text = "&Modificar"
        Me.cmdModifProveedor.UseVisualStyleBackColor = True
        Me.cmdModifProveedor.Visible = False
        '
        'frmProveedorAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 417)
        Me.Controls.Add(Me.cmdModifProveedor)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFechaAlta)
        Me.Controls.Add(Me.cmdAgregarRubro)
        Me.Controls.Add(Me.cmbRubro)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtBonificaciones)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProveedorAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saturn - Proveedores"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtLista As System.Windows.Forms.TextBox
    Friend WithEvents txtBonificaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarRubro As System.Windows.Forms.Button
    Friend WithEvents cmbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarDomicilio As System.Windows.Forms.Button
    Friend WithEvents btnEliminarDomicilio As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDomicilio As System.Windows.Forms.Button
    Friend WithEvents dgvDomicilios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTelefonos As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTipoTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdModifProveedor As System.Windows.Forms.Button
End Class
