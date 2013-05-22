<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialDetalle
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtVentasTotal = New System.Windows.Forms.TextBox
        Me.txtVentasTarjeta = New System.Windows.Forms.TextBox
        Me.txtVentasEfectivo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView
        Me.dgvDetallesCaja = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDifTotal = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDifEfectivo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDifTarjeta = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotalCaja = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalReal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTotalTarjReal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCantTarjReal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEfectivoReal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTotalTarjeta = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCantTarj = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEfectivo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTicket = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHora = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbTipoCierre = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetallesCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvOperaciones)
        Me.GroupBox1.Controls.Add(Me.dgvDetallesCaja)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 312)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de movimientos hasta el cierre de caja"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.txtVentasTotal)
        Me.GroupBox6.Controls.Add(Me.txtVentasTarjeta)
        Me.GroupBox6.Controls.Add(Me.txtVentasEfectivo)
        Me.GroupBox6.Location = New System.Drawing.Point(389, 253)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(362, 53)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Totales de Ventas del Cajero"
        '
        'txtVentasTotal
        '
        Me.txtVentasTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasTotal.Location = New System.Drawing.Point(245, 21)
        Me.txtVentasTotal.Name = "txtVentasTotal"
        Me.txtVentasTotal.ReadOnly = True
        Me.txtVentasTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtVentasTotal.TabIndex = 2
        Me.txtVentasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVentasTarjeta
        '
        Me.txtVentasTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasTarjeta.Location = New System.Drawing.Point(123, 21)
        Me.txtVentasTarjeta.Name = "txtVentasTarjeta"
        Me.txtVentasTarjeta.ReadOnly = True
        Me.txtVentasTarjeta.Size = New System.Drawing.Size(111, 20)
        Me.txtVentasTarjeta.TabIndex = 1
        Me.txtVentasTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVentasEfectivo
        '
        Me.txtVentasEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentasEfectivo.Location = New System.Drawing.Point(6, 21)
        Me.txtVentasEfectivo.Name = "txtVentasEfectivo"
        Me.txtVentasEfectivo.ReadOnly = True
        Me.txtVentasEfectivo.Size = New System.Drawing.Size(111, 20)
        Me.txtVentasEfectivo.TabIndex = 0
        Me.txtVentasEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(386, 16)
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
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ventas realizadas"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOperaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOperaciones.Location = New System.Drawing.Point(389, 32)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOperaciones.Size = New System.Drawing.Size(362, 212)
        Me.dgvOperaciones.TabIndex = 13
        '
        'dgvDetallesCaja
        '
        Me.dgvDetallesCaja.AllowUserToAddRows = False
        Me.dgvDetallesCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetallesCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetallesCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetallesCaja.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetallesCaja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetallesCaja.Location = New System.Drawing.Point(6, 32)
        Me.dgvDetallesCaja.Name = "dgvDetallesCaja"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetallesCaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetallesCaja.Size = New System.Drawing.Size(365, 274)
        Me.dgvDetallesCaja.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDifTotal)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDifEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDifTarjeta)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTotalCaja)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalReal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTotalTarjReal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCantTarjReal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEfectivoReal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTotalTarjeta)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCantTarj)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTicket)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtHora)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbTipoCierre)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 141)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del cierre de caja"
        '
        'txtDifTotal
        '
        Me.txtDifTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifTotal.Location = New System.Drawing.Point(687, 98)
        Me.txtDifTotal.Name = "txtDifTotal"
        Me.txtDifTotal.ReadOnly = True
        Me.txtDifTotal.Size = New System.Drawing.Size(70, 20)
        Me.txtDifTotal.TabIndex = 60
        Me.txtDifTotal.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label17.Location = New System.Drawing.Point(631, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Dif Total:"
        '
        'txtDifEfectivo
        '
        Me.txtDifEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifEfectivo.Location = New System.Drawing.Point(687, 58)
        Me.txtDifEfectivo.Name = "txtDifEfectivo"
        Me.txtDifEfectivo.ReadOnly = True
        Me.txtDifEfectivo.Size = New System.Drawing.Size(70, 20)
        Me.txtDifEfectivo.TabIndex = 58
        Me.txtDifEfectivo.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label16.Location = New System.Drawing.Point(620, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Dif Efectivo:"
        '
        'txtDifTarjeta
        '
        Me.txtDifTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifTarjeta.Location = New System.Drawing.Point(687, 20)
        Me.txtDifTarjeta.Name = "txtDifTarjeta"
        Me.txtDifTarjeta.ReadOnly = True
        Me.txtDifTarjeta.Size = New System.Drawing.Size(70, 20)
        Me.txtDifTarjeta.TabIndex = 56
        Me.txtDifTarjeta.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label15.Location = New System.Drawing.Point(626, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Dif Tarjeta:"
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.Location = New System.Drawing.Point(544, 58)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.ReadOnly = True
        Me.txtTotalCaja.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalCaja.TabIndex = 54
        Me.txtTotalCaja.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(476, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Total caja"
        '
        'txtTotalReal
        '
        Me.txtTotalReal.Location = New System.Drawing.Point(544, 98)
        Me.txtTotalReal.Name = "txtTotalReal"
        Me.txtTotalReal.ReadOnly = True
        Me.txtTotalReal.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalReal.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(476, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Total caja"
        '
        'txtTotalTarjReal
        '
        Me.txtTotalTarjReal.Location = New System.Drawing.Point(385, 98)
        Me.txtTotalTarjReal.Name = "txtTotalTarjReal"
        Me.txtTotalTarjReal.ReadOnly = True
        Me.txtTotalTarjReal.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalTarjReal.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Total Tarjeta"
        '
        'txtCantTarjReal
        '
        Me.txtCantTarjReal.Location = New System.Drawing.Point(218, 98)
        Me.txtCantTarjReal.Name = "txtCantTarjReal"
        Me.txtCantTarjReal.ReadOnly = True
        Me.txtCantTarjReal.Size = New System.Drawing.Size(70, 20)
        Me.txtCantTarjReal.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(139, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Cant Tajeta"
        '
        'txtEfectivoReal
        '
        Me.txtEfectivoReal.Location = New System.Drawing.Point(63, 98)
        Me.txtEfectivoReal.Name = "txtEfectivoReal"
        Me.txtEfectivoReal.ReadOnly = True
        Me.txtEfectivoReal.Size = New System.Drawing.Size(70, 20)
        Me.txtEfectivoReal.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Efectivo"
        '
        'txtTotalTarjeta
        '
        Me.txtTotalTarjeta.Location = New System.Drawing.Point(385, 58)
        Me.txtTotalTarjeta.Name = "txtTotalTarjeta"
        Me.txtTotalTarjeta.ReadOnly = True
        Me.txtTotalTarjeta.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalTarjeta.TabIndex = 47
        Me.txtTotalTarjeta.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(317, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Total Tarjeta"
        '
        'txtCantTarj
        '
        Me.txtCantTarj.Location = New System.Drawing.Point(218, 58)
        Me.txtCantTarj.Name = "txtCantTarj"
        Me.txtCantTarj.ReadOnly = True
        Me.txtCantTarj.Size = New System.Drawing.Size(70, 20)
        Me.txtCantTarj.TabIndex = 45
        Me.txtCantTarj.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Cant Tajeta"
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(63, 58)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.ReadOnly = True
        Me.txtEfectivo.Size = New System.Drawing.Size(70, 20)
        Me.txtEfectivo.TabIndex = 43
        Me.txtEfectivo.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Efectivo"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(291, 20)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.ReadOnly = True
        Me.txtTicket.Size = New System.Drawing.Size(70, 20)
        Me.txtTicket.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "N. Ult. Ticket"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(544, 20)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(70, 20)
        Me.txtHora.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Hora:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(413, 20)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(86, 20)
        Me.txtFecha.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(367, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Fecha:"
        '
        'cmbTipoCierre
        '
        Me.cmbTipoCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCierre.FormattingEnabled = True
        Me.cmbTipoCierre.Items.AddRange(New Object() {"PARCIAL", "FINAL"})
        Me.cmbTipoCierre.Location = New System.Drawing.Point(87, 19)
        Me.cmbTipoCierre.Name = "cmbTipoCierre"
        Me.cmbTipoCierre.Size = New System.Drawing.Size(119, 21)
        Me.cmbTipoCierre.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Tipo de Cierre"
        '
        'frmHistorialDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 474)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHistorialDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de los movimientos en el cierre de caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetallesCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetallesCaja As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalReal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTarjReal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantTarjReal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivoReal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCantTarj As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCierre As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDifTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDifEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDifTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVentasTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtVentasTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txtVentasEfectivo As System.Windows.Forms.TextBox
End Class
