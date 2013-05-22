<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCajaDiaria
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtTotalCaja = New System.Windows.Forms.TextBox
        Me.txtTarjetaCaja = New System.Windows.Forms.TextBox
        Me.txtEfectivoCaja = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtVentasTotal = New System.Windows.Forms.TextBox
        Me.txtVentasTarjeta = New System.Windows.Forms.TextBox
        Me.txtVentasEfectivo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView
        Me.dgvDetallesCaja = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAbrirCaja = New System.Windows.Forms.Button
        Me.txtMontoInicial = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.cmdRealizarOperacion = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.RadioDeposito = New System.Windows.Forms.RadioButton
        Me.RadioExtraccion = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtTarjeta = New System.Windows.Forms.TextBox
        Me.cmdCerrarCaja = New System.Windows.Forms.Button
        Me.txtEfectivo = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMontoApertura = New System.Windows.Forms.TextBox
        Me.ToolTipInformacion = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetallesCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvOperaciones)
        Me.GroupBox1.Controls.Add(Me.dgvDetallesCaja)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de movimientos de la caja"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.txtTotalCaja)
        Me.GroupBox7.Controls.Add(Me.txtTarjetaCaja)
        Me.GroupBox7.Controls.Add(Me.txtEfectivoCaja)
        Me.GroupBox7.Location = New System.Drawing.Point(24, 268)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(292, 53)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Totales de Ventas"
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalCaja.Location = New System.Drawing.Point(198, 21)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.ReadOnly = True
        Me.txtTotalCaja.Size = New System.Drawing.Size(90, 20)
        Me.txtTotalCaja.TabIndex = 2
        Me.txtTotalCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtTotalCaja, "Total de ventas")
        '
        'txtTarjetaCaja
        '
        Me.txtTarjetaCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarjetaCaja.Location = New System.Drawing.Point(102, 21)
        Me.txtTarjetaCaja.Name = "txtTarjetaCaja"
        Me.txtTarjetaCaja.ReadOnly = True
        Me.txtTarjetaCaja.Size = New System.Drawing.Size(90, 20)
        Me.txtTarjetaCaja.TabIndex = 1
        Me.txtTarjetaCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtTarjetaCaja, "Total de ventas con tarjeta")
        '
        'txtEfectivoCaja
        '
        Me.txtEfectivoCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEfectivoCaja.Location = New System.Drawing.Point(6, 21)
        Me.txtEfectivoCaja.Name = "txtEfectivoCaja"
        Me.txtEfectivoCaja.ReadOnly = True
        Me.txtEfectivoCaja.Size = New System.Drawing.Size(90, 20)
        Me.txtEfectivoCaja.TabIndex = 0
        Me.txtEfectivoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtEfectivoCaja, "Total de ventas en efectivo")
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.txtVentasTotal)
        Me.GroupBox6.Controls.Add(Me.txtVentasTarjeta)
        Me.GroupBox6.Controls.Add(Me.txtVentasEfectivo)
        Me.GroupBox6.Location = New System.Drawing.Point(348, 268)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(316, 53)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Totales de Ventas del Cajero"
        '
        'txtVentasTotal
        '
        Me.txtVentasTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasTotal.Location = New System.Drawing.Point(198, 21)
        Me.txtVentasTotal.Name = "txtVentasTotal"
        Me.txtVentasTotal.ReadOnly = True
        Me.txtVentasTotal.Size = New System.Drawing.Size(90, 20)
        Me.txtVentasTotal.TabIndex = 2
        Me.txtVentasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtVentasTotal, "Total de ventas")
        '
        'txtVentasTarjeta
        '
        Me.txtVentasTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasTarjeta.Location = New System.Drawing.Point(102, 21)
        Me.txtVentasTarjeta.Name = "txtVentasTarjeta"
        Me.txtVentasTarjeta.ReadOnly = True
        Me.txtVentasTarjeta.Size = New System.Drawing.Size(90, 20)
        Me.txtVentasTarjeta.TabIndex = 1
        Me.txtVentasTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtVentasTarjeta, "Total de ventas con tarjeta")
        '
        'txtVentasEfectivo
        '
        Me.txtVentasEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasEfectivo.Location = New System.Drawing.Point(6, 21)
        Me.txtVentasEfectivo.Name = "txtVentasEfectivo"
        Me.txtVentasEfectivo.ReadOnly = True
        Me.txtVentasEfectivo.Size = New System.Drawing.Size(90, 20)
        Me.txtVentasEfectivo.TabIndex = 0
        Me.txtVentasEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtVentasEfectivo, "Total de ventas en efectivo")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(345, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Operaciones realizadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(21, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ventas realizadas"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvOperaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOperaciones.Location = New System.Drawing.Point(348, 32)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvOperaciones.Size = New System.Drawing.Size(316, 230)
        Me.dgvOperaciones.TabIndex = 13
        '
        'dgvDetallesCaja
        '
        Me.dgvDetallesCaja.AllowUserToAddRows = False
        Me.dgvDetallesCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetallesCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvDetallesCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetallesCaja.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvDetallesCaja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetallesCaja.Location = New System.Drawing.Point(24, 32)
        Me.dgvDetallesCaja.Name = "dgvDetallesCaja"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetallesCaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvDetallesCaja.Size = New System.Drawing.Size(292, 230)
        Me.dgvDetallesCaja.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAbrirCaja)
        Me.GroupBox2.Controls.Add(Me.txtMontoInicial)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Abrir Caja"
        '
        'cmdAbrirCaja
        '
        Me.cmdAbrirCaja.Location = New System.Drawing.Point(180, 20)
        Me.cmdAbrirCaja.Name = "cmdAbrirCaja"
        Me.cmdAbrirCaja.Size = New System.Drawing.Size(75, 23)
        Me.cmdAbrirCaja.TabIndex = 1
        Me.cmdAbrirCaja.Text = "&Abrir caja"
        Me.cmdAbrirCaja.UseVisualStyleBackColor = True
        '
        'txtMontoInicial
        '
        Me.txtMontoInicial.Location = New System.Drawing.Point(82, 21)
        Me.txtMontoInicial.MaxLength = 9
        Me.txtMontoInicial.Name = "txtMontoInicial"
        Me.txtMontoInicial.ReadOnly = True
        Me.txtMontoInicial.Size = New System.Drawing.Size(81, 20)
        Me.txtMontoInicial.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto inicial:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtMonto)
        Me.GroupBox4.Controls.Add(Me.cmdRealizarOperacion)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.RadioDeposito)
        Me.GroupBox4.Controls.Add(Me.RadioExtraccion)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(679, 56)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extraccion / Deposito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(493, 21)
        Me.txtMonto.MaxLength = 9
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(50, 20)
        Me.txtMonto.TabIndex = 4
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdRealizarOperacion
        '
        Me.cmdRealizarOperacion.Location = New System.Drawing.Point(549, 19)
        Me.cmdRealizarOperacion.Name = "cmdRealizarOperacion"
        Me.cmdRealizarOperacion.Size = New System.Drawing.Size(115, 24)
        Me.cmdRealizarOperacion.TabIndex = 5
        Me.cmdRealizarOperacion.Text = "&Realizar Operación"
        Me.cmdRealizarOperacion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(235, 21)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(206, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'RadioDeposito
        '
        Me.RadioDeposito.AutoSize = True
        Me.RadioDeposito.Location = New System.Drawing.Point(87, 23)
        Me.RadioDeposito.Name = "RadioDeposito"
        Me.RadioDeposito.Size = New System.Drawing.Size(67, 17)
        Me.RadioDeposito.TabIndex = 1
        Me.RadioDeposito.TabStop = True
        Me.RadioDeposito.Text = "Deposito"
        Me.RadioDeposito.UseVisualStyleBackColor = True
        '
        'RadioExtraccion
        '
        Me.RadioExtraccion.AutoSize = True
        Me.RadioExtraccion.Checked = True
        Me.RadioExtraccion.Location = New System.Drawing.Point(6, 23)
        Me.RadioExtraccion.Name = "RadioExtraccion"
        Me.RadioExtraccion.Size = New System.Drawing.Size(75, 17)
        Me.RadioExtraccion.TabIndex = 0
        Me.RadioExtraccion.TabStop = True
        Me.RadioExtraccion.Text = "Extraccion"
        Me.RadioExtraccion.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txtTotal)
        Me.GroupBox5.Controls.Add(Me.txtTarjeta)
        Me.GroupBox5.Controls.Add(Me.cmdCerrarCaja)
        Me.GroupBox5.Controls.Add(Me.txtEfectivo)
        Me.GroupBox5.Location = New System.Drawing.Point(399, 345)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(294, 53)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Estado"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(148, 21)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(59, 20)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtTotal, "Monto total en la caja")
        '
        'txtTarjeta
        '
        Me.txtTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarjeta.Location = New System.Drawing.Point(83, 21)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.ReadOnly = True
        Me.txtTarjeta.Size = New System.Drawing.Size(59, 20)
        Me.txtTarjeta.TabIndex = 1
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtTarjeta, "Monto con tarjeta en la caja")
        '
        'cmdCerrarCaja
        '
        Me.cmdCerrarCaja.Location = New System.Drawing.Point(213, 20)
        Me.cmdCerrarCaja.Name = "cmdCerrarCaja"
        Me.cmdCerrarCaja.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrarCaja.TabIndex = 0
        Me.cmdCerrarCaja.Text = "&Cerrar Caja"
        Me.cmdCerrarCaja.UseVisualStyleBackColor = True
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEfectivo.Location = New System.Drawing.Point(18, 21)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.ReadOnly = True
        Me.txtEfectivo.Size = New System.Drawing.Size(59, 20)
        Me.txtEfectivo.TabIndex = 0
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipInformacion.SetToolTip(Me.txtEfectivo, "Total de efectivo en la caja")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMontoApertura)
        Me.GroupBox3.Location = New System.Drawing.Point(290, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(101, 53)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monto apertura"
        '
        'txtMontoApertura
        '
        Me.txtMontoApertura.Location = New System.Drawing.Point(22, 21)
        Me.txtMontoApertura.MaxLength = 9
        Me.txtMontoApertura.Name = "txtMontoApertura"
        Me.txtMontoApertura.ReadOnly = True
        Me.txtMontoApertura.Size = New System.Drawing.Size(52, 20)
        Me.txtMontoApertura.TabIndex = 0
        '
        'ToolTipInformacion
        '
        Me.ToolTipInformacion.IsBalloon = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(728, 210)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmCajaDiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(705, 472)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCajaDiaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja diaria - Saturn 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetallesCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetallesCaja As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRealizarOperacion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents RadioDeposito As System.Windows.Forms.RadioButton
    Friend WithEvents RadioExtraccion As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAbrirCaja As System.Windows.Forms.Button
    Friend WithEvents txtMontoInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerrarCaja As System.Windows.Forms.Button
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontoApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipInformacion As System.Windows.Forms.ToolTip
    Friend WithEvents txtTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVentasTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtVentasTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txtVentasEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalCaja As System.Windows.Forms.TextBox
    Friend WithEvents txtTarjetaCaja As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivoCaja As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
