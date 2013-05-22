<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientoStock
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
        Me.CmdArmarRenglon = New System.Windows.Forms.Button
        Me.cmdQuitarItem = New System.Windows.Forms.Button
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvRenglones = New System.Windows.Forms.DataGridView
        Me.txtCantidadItems = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdFinalizar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblToTaL = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbVendedor = New System.Windows.Forms.ComboBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ToolTipLector = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLector = New System.Windows.Forms.TextBox
        Me.cmdModificarItem = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCantidadActual = New System.Windows.Forms.TextBox
        Me.chkImprimir = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.hiloSegundoPlano = New System.ComponentModel.BackgroundWorker
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdArmarRenglon
        '
        Me.CmdArmarRenglon.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdArmarRenglon.Location = New System.Drawing.Point(20, 86)
        Me.CmdArmarRenglon.Name = "CmdArmarRenglon"
        Me.CmdArmarRenglon.Size = New System.Drawing.Size(105, 26)
        Me.CmdArmarRenglon.TabIndex = 1
        Me.CmdArmarRenglon.Text = "&Armar Renglon"
        Me.CmdArmarRenglon.UseVisualStyleBackColor = True
        '
        'cmdQuitarItem
        '
        Me.cmdQuitarItem.Location = New System.Drawing.Point(313, 445)
        Me.cmdQuitarItem.Name = "cmdQuitarItem"
        Me.cmdQuitarItem.Size = New System.Drawing.Size(86, 23)
        Me.cmdQuitarItem.TabIndex = 2
        Me.cmdQuitarItem.Text = "&Quitar Item"
        Me.cmdQuitarItem.UseVisualStyleBackColor = True
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Items.AddRange(New Object() {"BOEDO 122", "BOEDO 186", "MEEKS"})
        Me.cmbSucursal.Location = New System.Drawing.Point(141, 14)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(109, 21)
        Me.cmbSucursal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ingrese Sucursal: "
        '
        'dgvRenglones
        '
        Me.dgvRenglones.AllowUserToAddRows = False
        Me.dgvRenglones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRenglones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRenglones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRenglones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRenglones.Location = New System.Drawing.Point(20, 128)
        Me.dgvRenglones.Name = "dgvRenglones"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRenglones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRenglones.Size = New System.Drawing.Size(562, 305)
        Me.dgvRenglones.TabIndex = 11
        '
        'txtCantidadItems
        '
        Me.txtCantidadItems.Enabled = False
        Me.txtCantidadItems.Location = New System.Drawing.Point(115, 447)
        Me.txtCantidadItems.Name = "txtCantidadItems"
        Me.txtCantidadItems.Size = New System.Drawing.Size(26, 20)
        Me.txtCantidadItems.TabIndex = 13
        Me.txtCantidadItems.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Cant. productos:"
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.Location = New System.Drawing.Point(405, 445)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(86, 23)
        Me.cmdFinalizar.TabIndex = 3
        Me.cmdFinalizar.Text = "&Finalizar"
        Me.cmdFinalizar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 29)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "$"
        '
        'lblToTaL
        '
        Me.lblToTaL.AutoSize = True
        Me.lblToTaL.BackColor = System.Drawing.Color.White
        Me.lblToTaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToTaL.Location = New System.Drawing.Point(254, 439)
        Me.lblToTaL.Name = "lblToTaL"
        Me.lblToTaL.Size = New System.Drawing.Size(26, 29)
        Me.lblToTaL.TabIndex = 20
        Me.lblToTaL.Text = "0"
        Me.lblToTaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Vendedor:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(346, 14)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(145, 21)
        Me.cmbVendedor.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(497, 445)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtLector
        '
        Me.txtLector.Location = New System.Drawing.Point(141, 50)
        Me.txtLector.MaxLength = 20
        Me.txtLector.Name = "txtLector"
        Me.txtLector.Size = New System.Drawing.Size(260, 20)
        Me.txtLector.TabIndex = 0
        '
        'cmdModificarItem
        '
        Me.cmdModificarItem.Location = New System.Drawing.Point(610, 162)
        Me.cmdModificarItem.Name = "cmdModificarItem"
        Me.cmdModificarItem.Size = New System.Drawing.Size(48, 23)
        Me.cmdModificarItem.TabIndex = 6
        Me.cmdModificarItem.Text = "&Modificar Item"
        Me.cmdModificarItem.UseVisualStyleBackColor = True
        Me.cmdModificarItem.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cantidad / Codigo (F12):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(407, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Cantidad actual:"
        '
        'txtCantidadActual
        '
        Me.txtCantidadActual.Location = New System.Drawing.Point(500, 50)
        Me.txtCantidadActual.Name = "txtCantidadActual"
        Me.txtCantidadActual.ReadOnly = True
        Me.txtCantidadActual.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidadActual.TabIndex = 35
        Me.txtCantidadActual.Text = "1"
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Checked = True
        Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImprimir.Location = New System.Drawing.Point(502, 18)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(61, 17)
        Me.chkImprimir.TabIndex = 37
        Me.chkImprimir.Text = "Imprimir"
        Me.chkImprimir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Saturn_1.Saturn.My.Resources.Resources.printer
        Me.PictureBox1.Location = New System.Drawing.Point(559, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'hiloSegundoPlano
        '
        '
        'FrmMovimientoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 474)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkImprimir)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantidadActual)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLector)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblToTaL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidadItems)
        Me.Controls.Add(Me.dgvRenglones)
        Me.Controls.Add(Me.cmdModificarItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmdQuitarItem)
        Me.Controls.Add(Me.CmdArmarRenglon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(606, 502)
        Me.MinimumSize = New System.Drawing.Size(606, 502)
        Me.Name = "FrmMovimientoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion - Saturn 1.0"
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdArmarRenglon As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarItem As System.Windows.Forms.Button
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRenglones As System.Windows.Forms.DataGridView
    Friend WithEvents txtCantidadItems As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblToTaL As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTipLector As System.Windows.Forms.ToolTip
    Friend WithEvents txtLector As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificarItem As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadActual As System.Windows.Forms.TextBox
    Friend WithEvents chkImprimir As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents hiloSegundoPlano As System.ComponentModel.BackgroundWorker
End Class
