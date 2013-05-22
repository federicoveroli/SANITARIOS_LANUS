<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticuloAlta
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmdCONVERTIR = New System.Windows.Forms.Button
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox
        Me.cmbMarca = New System.Windows.Forms.ComboBox
        Me.cmbProveedoR = New System.Windows.Forms.ComboBox
        Me.txtDescripcION = New System.Windows.Forms.TextBox
        Me.txtMedida = New System.Windows.Forms.TextBox
        Me.txtPrecioCosto = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSTOcK = New System.Windows.Forms.TextBox
        Me.txtValorDolar = New System.Windows.Forms.TextBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdAgregarSimilar = New System.Windows.Forms.Button
        Me.lblMisterioso = New System.Windows.Forms.Label
        Me.cmdAgregarTipo = New System.Windows.Forms.Button
        Me.cmdAgregarMarca = New System.Windows.Forms.Button
        Me.chFraccionable = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picEliminarMarca = New System.Windows.Forms.PictureBox
        Me.picEliminarTipoProducto = New System.Windows.Forms.PictureBox
        Me.GrabarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerminarGrabaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtPtoReposicion = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCodBarras = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkSeguirCargando = New System.Windows.Forms.CheckBox
        Me.txtidArticulo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtPrecioLista = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDesc1 = New System.Windows.Forms.TextBox
        Me.txtDesc2 = New System.Windows.Forms.TextBox
        Me.txtDesc3 = New System.Windows.Forms.TextBox
        Me.txtDesc4 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtgcia1 = New System.Windows.Forms.TextBox
        Me.txtgcia2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGcia4 = New System.Windows.Forms.TextBox
        Me.txtGcia3 = New System.Windows.Forms.TextBox
        CType(Me.picEliminarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEliminarTipoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Medida (longitud en mts.)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio Lista Prov"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "% desc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Stock"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(398, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Valor Dolar"
        Me.Label12.Visible = False
        '
        'cmdCONVERTIR
        '
        Me.cmdCONVERTIR.Location = New System.Drawing.Point(540, 282)
        Me.cmdCONVERTIR.Name = "cmdCONVERTIR"
        Me.cmdCONVERTIR.Size = New System.Drawing.Size(111, 21)
        Me.cmdCONVERTIR.TabIndex = 12
        Me.cmdCONVERTIR.Text = "Convertir a pesos"
        Me.cmdCONVERTIR.UseVisualStyleBackColor = True
        Me.cmdCONVERTIR.Visible = False
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(118, 16)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(148, 21)
        Me.cmbTipoProducto.TabIndex = 0
        '
        'cmbMarca
        '
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(118, 43)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(148, 21)
        Me.cmbMarca.TabIndex = 1
        '
        'cmbProveedoR
        '
        Me.cmbProveedoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedoR.FormattingEnabled = True
        Me.cmbProveedoR.Location = New System.Drawing.Point(118, 70)
        Me.cmbProveedoR.Name = "cmbProveedoR"
        Me.cmbProveedoR.Size = New System.Drawing.Size(148, 21)
        Me.cmbProveedoR.TabIndex = 2
        '
        'txtDescripcION
        '
        Me.txtDescripcION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcION.Location = New System.Drawing.Point(118, 97)
        Me.txtDescripcION.MaxLength = 99
        Me.txtDescripcION.Name = "txtDescripcION"
        Me.txtDescripcION.Size = New System.Drawing.Size(148, 20)
        Me.txtDescripcION.TabIndex = 3
        '
        'txtMedida
        '
        Me.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida.Location = New System.Drawing.Point(143, 280)
        Me.txtMedida.MaxLength = 19
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(123, 20)
        Me.txtMedida.TabIndex = 16
        Me.txtMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(118, 122)
        Me.txtPrecioCosto.MaxLength = 9
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(148, 20)
        Me.txtPrecioCosto.TabIndex = 4
        Me.txtPrecioCosto.Text = "0"
        Me.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(118, 174)
        Me.txtIVA.MaxLength = 9
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(148, 20)
        Me.txtIVA.TabIndex = 9
        Me.txtIVA.Text = "21"
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSTOcK
        '
        Me.txtSTOcK.Location = New System.Drawing.Point(118, 306)
        Me.txtSTOcK.MaxLength = 9
        Me.txtSTOcK.Name = "txtSTOcK"
        Me.txtSTOcK.Size = New System.Drawing.Size(148, 20)
        Me.txtSTOcK.TabIndex = 18
        Me.txtSTOcK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorDolar
        '
        Me.txtValorDolar.Location = New System.Drawing.Point(504, 256)
        Me.txtValorDolar.Name = "txtValorDolar"
        Me.txtValorDolar.Size = New System.Drawing.Size(148, 20)
        Me.txtValorDolar.TabIndex = 26
        Me.txtValorDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorDolar.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(269, 437)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 25
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(91, 437)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 23
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdAgregarSimilar
        '
        Me.cmdAgregarSimilar.Location = New System.Drawing.Point(180, 437)
        Me.cmdAgregarSimilar.Name = "cmdAgregarSimilar"
        Me.cmdAgregarSimilar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregarSimilar.TabIndex = 24
        Me.cmdAgregarSimilar.Text = "A. &Similar"
        Me.cmdAgregarSimilar.UseVisualStyleBackColor = True
        '
        'lblMisterioso
        '
        Me.lblMisterioso.AutoSize = True
        Me.lblMisterioso.Location = New System.Drawing.Point(258, 163)
        Me.lblMisterioso.Name = "lblMisterioso"
        Me.lblMisterioso.Size = New System.Drawing.Size(0, 13)
        Me.lblMisterioso.TabIndex = 30
        Me.lblMisterioso.Visible = False
        '
        'cmdAgregarTipo
        '
        Me.cmdAgregarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarTipo.Location = New System.Drawing.Point(276, 15)
        Me.cmdAgregarTipo.Name = "cmdAgregarTipo"
        Me.cmdAgregarTipo.Size = New System.Drawing.Size(32, 23)
        Me.cmdAgregarTipo.TabIndex = 1
        Me.cmdAgregarTipo.Text = "+"
        Me.cmdAgregarTipo.UseVisualStyleBackColor = True
        '
        'cmdAgregarMarca
        '
        Me.cmdAgregarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarMarca.Location = New System.Drawing.Point(276, 42)
        Me.cmdAgregarMarca.Name = "cmdAgregarMarca"
        Me.cmdAgregarMarca.Size = New System.Drawing.Size(32, 23)
        Me.cmdAgregarMarca.TabIndex = 3
        Me.cmdAgregarMarca.Text = "+"
        Me.cmdAgregarMarca.UseVisualStyleBackColor = True
        '
        'chFraccionable
        '
        Me.chFraccionable.AutoSize = True
        Me.chFraccionable.Location = New System.Drawing.Point(276, 282)
        Me.chFraccionable.Name = "chFraccionable"
        Me.chFraccionable.Size = New System.Drawing.Size(105, 17)
        Me.chFraccionable.TabIndex = 17
        Me.chFraccionable.Text = "Es fraccionable?"
        Me.chFraccionable.UseVisualStyleBackColor = True
        '
        'picEliminarMarca
        '
        Me.picEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEliminarMarca.Image = Global.Saturn_1.Saturn.My.Resources.Resources.eliminar
        Me.picEliminarMarca.Location = New System.Drawing.Point(314, 43)
        Me.picEliminarMarca.Name = "picEliminarMarca"
        Me.picEliminarMarca.Size = New System.Drawing.Size(27, 24)
        Me.picEliminarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEliminarMarca.TabIndex = 35
        Me.picEliminarMarca.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picEliminarMarca, "Eliminar marca")
        '
        'picEliminarTipoProducto
        '
        Me.picEliminarTipoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEliminarTipoProducto.Image = Global.Saturn_1.Saturn.My.Resources.Resources.eliminar
        Me.picEliminarTipoProducto.Location = New System.Drawing.Point(314, 16)
        Me.picEliminarTipoProducto.Name = "picEliminarTipoProducto"
        Me.picEliminarTipoProducto.Size = New System.Drawing.Size(27, 24)
        Me.picEliminarTipoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEliminarTipoProducto.TabIndex = 34
        Me.picEliminarTipoProducto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picEliminarTipoProducto, "Eliminar tipo de producto")
        '
        'GrabarCambiosToolStripMenuItem
        '
        Me.GrabarCambiosToolStripMenuItem.Name = "GrabarCambiosToolStripMenuItem"
        Me.GrabarCambiosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GrabarCambiosToolStripMenuItem.Text = "Grabar Cambios"
        '
        'TerminarGrabaciónToolStripMenuItem
        '
        Me.TerminarGrabaciónToolStripMenuItem.Name = "TerminarGrabaciónToolStripMenuItem"
        Me.TerminarGrabaciónToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TerminarGrabaciónToolStripMenuItem.Text = "Terminar Grabación"
        '
        'txtPtoReposicion
        '
        Me.txtPtoReposicion.Location = New System.Drawing.Point(118, 332)
        Me.txtPtoReposicion.MaxLength = 9
        Me.txtPtoReposicion.Name = "txtPtoReposicion"
        Me.txtPtoReposicion.Size = New System.Drawing.Size(148, 20)
        Me.txtPtoReposicion.TabIndex = 19
        Me.txtPtoReposicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Pto. de Reposición"
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(118, 358)
        Me.txtCodBarras.MaxLength = 20
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(148, 20)
        Me.txtCodBarras.TabIndex = 20
        Me.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 362)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Cod. de barras"
        '
        'chkSeguirCargando
        '
        Me.chkSeguirCargando.AutoSize = True
        Me.chkSeguirCargando.Checked = True
        Me.chkSeguirCargando.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSeguirCargando.Location = New System.Drawing.Point(236, 388)
        Me.chkSeguirCargando.Name = "chkSeguirCargando"
        Me.chkSeguirCargando.Size = New System.Drawing.Size(105, 17)
        Me.chkSeguirCargando.TabIndex = 22
        Me.chkSeguirCargando.Text = "Seguir Cargando"
        Me.chkSeguirCargando.UseVisualStyleBackColor = True
        '
        'txtidArticulo
        '
        Me.txtidArticulo.Location = New System.Drawing.Point(118, 384)
        Me.txtidArticulo.MaxLength = 20
        Me.txtidArticulo.Name = "txtidArticulo"
        Me.txtidArticulo.ReadOnly = True
        Me.txtidArticulo.Size = New System.Drawing.Size(112, 20)
        Me.txtidArticulo.TabIndex = 21
        Me.txtidArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 388)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Id Articulo"
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.BackColor = System.Drawing.Color.LightBlue
        Me.txtPrecioFinal.Enabled = False
        Me.txtPrecioFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioFinal.ForeColor = System.Drawing.Color.Black
        Me.txtPrecioFinal.Location = New System.Drawing.Point(118, 254)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(148, 20)
        Me.txtPrecioFinal.TabIndex = 15
        Me.txtPrecioFinal.Text = "0"
        Me.txtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Precio final"
        '
        'txtPrecioLista
        '
        Me.txtPrecioLista.BackColor = System.Drawing.Color.LightBlue
        Me.txtPrecioLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioLista.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrecioLista.Location = New System.Drawing.Point(118, 200)
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.Size = New System.Drawing.Size(148, 20)
        Me.txtPrecioLista.TabIndex = 10
        Me.txtPrecioLista.Text = "0"
        Me.txtPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Prec. de costo c/iva"
        '
        'txtDesc1
        '
        Me.txtDesc1.Location = New System.Drawing.Point(118, 148)
        Me.txtDesc1.MaxLength = 9
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.Size = New System.Drawing.Size(32, 20)
        Me.txtDesc1.TabIndex = 5
        Me.txtDesc1.Text = "0"
        Me.txtDesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc2
        '
        Me.txtDesc2.Location = New System.Drawing.Point(156, 148)
        Me.txtDesc2.MaxLength = 9
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.Size = New System.Drawing.Size(32, 20)
        Me.txtDesc2.TabIndex = 6
        Me.txtDesc2.Text = "0"
        Me.txtDesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc3
        '
        Me.txtDesc3.Location = New System.Drawing.Point(194, 148)
        Me.txtDesc3.MaxLength = 9
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.Size = New System.Drawing.Size(32, 20)
        Me.txtDesc3.TabIndex = 7
        Me.txtDesc3.Text = "0"
        Me.txtDesc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc4
        '
        Me.txtDesc4.Location = New System.Drawing.Point(232, 148)
        Me.txtDesc4.MaxLength = 9
        Me.txtDesc4.Name = "txtDesc4"
        Me.txtDesc4.Size = New System.Drawing.Size(32, 20)
        Me.txtDesc4.TabIndex = 8
        Me.txtDesc4.Text = "0"
        Me.txtDesc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "IVA"
        '
        'txtgcia1
        '
        Me.txtgcia1.Location = New System.Drawing.Point(118, 226)
        Me.txtgcia1.MaxLength = 9
        Me.txtgcia1.Name = "txtgcia1"
        Me.txtgcia1.Size = New System.Drawing.Size(32, 20)
        Me.txtgcia1.TabIndex = 11
        Me.txtgcia1.Text = "0"
        Me.txtgcia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtgcia2
        '
        Me.txtgcia2.Location = New System.Drawing.Point(158, 226)
        Me.txtgcia2.MaxLength = 9
        Me.txtgcia2.Name = "txtgcia2"
        Me.txtgcia2.Size = New System.Drawing.Size(32, 20)
        Me.txtgcia2.TabIndex = 12
        Me.txtgcia2.Text = "0"
        Me.txtgcia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "% de ganancia"
        '
        'txtGcia4
        '
        Me.txtGcia4.Location = New System.Drawing.Point(234, 226)
        Me.txtGcia4.MaxLength = 9
        Me.txtGcia4.Name = "txtGcia4"
        Me.txtGcia4.Size = New System.Drawing.Size(32, 20)
        Me.txtGcia4.TabIndex = 14
        Me.txtGcia4.Text = "0"
        Me.txtGcia4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGcia3
        '
        Me.txtGcia3.Location = New System.Drawing.Point(196, 226)
        Me.txtGcia3.MaxLength = 9
        Me.txtGcia3.Name = "txtGcia3"
        Me.txtGcia3.Size = New System.Drawing.Size(32, 20)
        Me.txtGcia3.TabIndex = 13
        Me.txtGcia3.Text = "0"
        Me.txtGcia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmArticuloAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(385, 499)
        Me.Controls.Add(Me.txtGcia4)
        Me.Controls.Add(Me.txtGcia3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtgcia2)
        Me.Controls.Add(Me.txtgcia1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDesc4)
        Me.Controls.Add(Me.txtDesc3)
        Me.Controls.Add(Me.txtDesc2)
        Me.Controls.Add(Me.txtDesc1)
        Me.Controls.Add(Me.txtPrecioLista)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecioFinal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtidArticulo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chkSeguirCargando)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPtoReposicion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.picEliminarMarca)
        Me.Controls.Add(Me.picEliminarTipoProducto)
        Me.Controls.Add(Me.chFraccionable)
        Me.Controls.Add(Me.cmdAgregarMarca)
        Me.Controls.Add(Me.cmdAgregarTipo)
        Me.Controls.Add(Me.lblMisterioso)
        Me.Controls.Add(Me.cmdAgregarSimilar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtValorDolar)
        Me.Controls.Add(Me.txtSTOcK)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtPrecioCosto)
        Me.Controls.Add(Me.txtMedida)
        Me.Controls.Add(Me.txtDescripcION)
        Me.Controls.Add(Me.cmbProveedoR)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbTipoProducto)
        Me.Controls.Add(Me.cmdCONVERTIR)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(357, 350)
        Me.Name = "FrmArticuloAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Alta de Articulos - Saturn 1.0"
        CType(Me.picEliminarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEliminarTipoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdCONVERTIR As System.Windows.Forms.Button
    Friend WithEvents cmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProveedoR As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcION As System.Windows.Forms.TextBox
    Friend WithEvents txtMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSTOcK As System.Windows.Forms.TextBox
    Friend WithEvents txtValorDolar As System.Windows.Forms.TextBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarSimilar As System.Windows.Forms.Button
    Friend WithEvents lblMisterioso As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarTipo As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarMarca As System.Windows.Forms.Button
    Friend WithEvents chFraccionable As System.Windows.Forms.CheckBox
    Friend WithEvents picEliminarTipoProducto As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents picEliminarMarca As System.Windows.Forms.PictureBox
    Friend WithEvents GrabarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminarGrabaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPtoReposicion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkSeguirCargando As System.Windows.Forms.CheckBox
    Friend WithEvents txtidArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioLista As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc4 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtgcia1 As System.Windows.Forms.TextBox
    Friend WithEvents txtgcia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGcia4 As System.Windows.Forms.TextBox
    Friend WithEvents txtGcia3 As System.Windows.Forms.TextBox
End Class
