<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentaCorriente
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboIngreseCliente = New System.Windows.Forms.ComboBox
        Me.grupoDetalles = New System.Windows.Forms.GroupBox
        Me.dgvDetallesCtaCte = New System.Windows.Forms.DataGridView
        Me.grupoFacCtaCte = New System.Windows.Forms.GroupBox
        Me.dgvFacCtaCte = New System.Windows.Forms.DataGridView
        Me.grupoCtaCteABM = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtPago = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumFac = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLimite = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolTipCtaCte = New System.Windows.Forms.ToolTip(Me.components)
        Me.picBuscar = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblDEUDADAAAA = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.grupoDetalles.SuspendLayout()
        CType(Me.dgvDetallesCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoFacCtaCte.SuspendLayout()
        CType(Me.dgvFacCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoCtaCteABM.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total adeudado :"
        '
        'CboIngreseCliente
        '
        Me.CboIngreseCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboIngreseCliente.FormattingEnabled = True
        Me.CboIngreseCliente.Location = New System.Drawing.Point(99, 12)
        Me.CboIngreseCliente.Name = "CboIngreseCliente"
        Me.CboIngreseCliente.Size = New System.Drawing.Size(132, 21)
        Me.CboIngreseCliente.TabIndex = 14
        '
        'grupoDetalles
        '
        Me.grupoDetalles.Controls.Add(Me.dgvDetallesCtaCte)
        Me.grupoDetalles.Location = New System.Drawing.Point(372, 39)
        Me.grupoDetalles.Name = "grupoDetalles"
        Me.grupoDetalles.Size = New System.Drawing.Size(350, 218)
        Me.grupoDetalles.TabIndex = 17
        Me.grupoDetalles.TabStop = False
        Me.grupoDetalles.Text = "Movimientos de cuenta corriente: Detalles de cobros."
        '
        'dgvDetallesCtaCte
        '
        Me.dgvDetallesCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetallesCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetallesCtaCte.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetallesCtaCte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetallesCtaCte.Location = New System.Drawing.Point(17, 19)
        Me.dgvDetallesCtaCte.Name = "dgvDetallesCtaCte"
        Me.dgvDetallesCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallesCtaCte.Size = New System.Drawing.Size(315, 179)
        Me.dgvDetallesCtaCte.TabIndex = 0
        '
        'grupoFacCtaCte
        '
        Me.grupoFacCtaCte.Controls.Add(Me.dgvFacCtaCte)
        Me.grupoFacCtaCte.Location = New System.Drawing.Point(13, 39)
        Me.grupoFacCtaCte.Name = "grupoFacCtaCte"
        Me.grupoFacCtaCte.Size = New System.Drawing.Size(353, 218)
        Me.grupoFacCtaCte.TabIndex = 18
        Me.grupoFacCtaCte.TabStop = False
        Me.grupoFacCtaCte.Text = "Facturas adeudadas por el cliente"
        '
        'dgvFacCtaCte
        '
        Me.dgvFacCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFacCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacCtaCte.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFacCtaCte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFacCtaCte.Location = New System.Drawing.Point(15, 19)
        Me.dgvFacCtaCte.MultiSelect = False
        Me.dgvFacCtaCte.Name = "dgvFacCtaCte"
        Me.dgvFacCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacCtaCte.Size = New System.Drawing.Size(315, 179)
        Me.dgvFacCtaCte.TabIndex = 0
        '
        'grupoCtaCteABM
        '
        Me.grupoCtaCteABM.Controls.Add(Me.cmdCancelar)
        Me.grupoCtaCteABM.Controls.Add(Me.cmdAceptar)
        Me.grupoCtaCteABM.Controls.Add(Me.txtPago)
        Me.grupoCtaCteABM.Controls.Add(Me.Label4)
        Me.grupoCtaCteABM.Controls.Add(Me.txtNumFac)
        Me.grupoCtaCteABM.Controls.Add(Me.Label3)
        Me.grupoCtaCteABM.Controls.Add(Me.dtpFecha)
        Me.grupoCtaCteABM.Controls.Add(Me.Label1)
        Me.grupoCtaCteABM.Location = New System.Drawing.Point(13, 277)
        Me.grupoCtaCteABM.Name = "grupoCtaCteABM"
        Me.grupoCtaCteABM.Size = New System.Drawing.Size(501, 97)
        Me.grupoCtaCteABM.TabIndex = 19
        Me.grupoCtaCteABM.TabStop = False
        Me.grupoCtaCteABM.Text = "Ingresar movimiento"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(401, 63)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Salir"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(320, 63)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "&Ingresar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(392, 32)
        Me.txtPago.MaxLength = 9
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(84, 20)
        Me.txtPago.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "a cuenta:"
        '
        'txtNumFac
        '
        Me.txtNumFac.Location = New System.Drawing.Point(235, 32)
        Me.txtNumFac.MaxLength = 9
        Me.txtNumFac.Name = "txtNumFac"
        Me.txtNumFac.Size = New System.Drawing.Size(84, 20)
        Me.txtNumFac.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Num. Fact:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(59, 32)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLimite)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 97)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(68, 63)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 3
        Me.txtLimite.Text = "0"
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCtaCte.SetToolTip(Me.txtLimite, "Limite de credito establecido para el cliente")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Limite:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(69, 34)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 1
        Me.txtSaldo.Text = "0"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCtaCte.SetToolTip(Me.txtSaldo, "Representa la diferencia entre la deuda del cliente vs. lo que pago")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Saldo:"
        '
        'ToolTipCtaCte
        '
        Me.ToolTipCtaCte.IsBalloon = True
        '
        'picBuscar
        '
        Me.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBuscar.Image = Global.Saturn_1.Saturn.My.Resources.Resources.buscar
        Me.picBuscar.Location = New System.Drawing.Point(237, 12)
        Me.picBuscar.Name = "picBuscar"
        Me.picBuscar.Size = New System.Drawing.Size(21, 21)
        Me.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuscar.TabIndex = 15
        Me.picBuscar.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total adeudado :"
        '
        'lblDEUDADAAAA
        '
        Me.lblDEUDADAAAA.AutoSize = True
        Me.lblDEUDADAAAA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEUDADAAAA.Location = New System.Drawing.Point(465, 15)
        Me.lblDEUDADAAAA.Name = "lblDEUDADAAAA"
        Me.lblDEUDADAAAA.Size = New System.Drawing.Size(16, 16)
        Me.lblDEUDADAAAA.TabIndex = 22
        Me.lblDEUDADAAAA.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(443, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "$"
        '
        'FrmCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 396)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDEUDADAAAA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoCtaCteABM)
        Me.Controls.Add(Me.grupoFacCtaCte)
        Me.Controls.Add(Me.grupoDetalles)
        Me.Controls.Add(Me.picBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboIngreseCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Corrientes - Saturn 1.0"
        Me.grupoDetalles.ResumeLayout(False)
        CType(Me.dgvDetallesCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoFacCtaCte.ResumeLayout(False)
        CType(Me.dgvFacCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoCtaCteABM.ResumeLayout(False)
        Me.grupoCtaCteABM.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboIngreseCliente As System.Windows.Forms.ComboBox
    Friend WithEvents grupoDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetallesCtaCte As System.Windows.Forms.DataGridView
    Friend WithEvents grupoFacCtaCte As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFacCtaCte As System.Windows.Forms.DataGridView
    Friend WithEvents grupoCtaCteABM As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumFac As System.Windows.Forms.TextBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTipCtaCte As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDEUDADAAAA As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
