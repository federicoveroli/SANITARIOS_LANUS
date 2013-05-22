<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.lblToTaL = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdFinalizar = New System.Windows.Forms.Button
        Me.dgvRenglonesCompra = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbProveedores = New System.Windows.Forms.ComboBox
        Me.CmdArmarRenglon = New System.Windows.Forms.Button
        Me.picBuscar = New System.Windows.Forms.PictureBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.ofdExcel = New System.Windows.Forms.OpenFileDialog
        CType(Me.dgvRenglonesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToTaL
        '
        Me.lblToTaL.AutoSize = True
        Me.lblToTaL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblToTaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToTaL.Location = New System.Drawing.Point(382, 388)
        Me.lblToTaL.Name = "lblToTaL"
        Me.lblToTaL.Size = New System.Drawing.Size(23, 25)
        Me.lblToTaL.TabIndex = 29
        Me.lblToTaL.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total : "
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.Location = New System.Drawing.Point(454, 392)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(86, 23)
        Me.cmdFinalizar.TabIndex = 23
        Me.cmdFinalizar.Text = "&Finalizar"
        Me.cmdFinalizar.UseVisualStyleBackColor = True
        '
        'dgvRenglonesCompra
        '
        Me.dgvRenglonesCompra.AllowUserToAddRows = False
        Me.dgvRenglonesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglonesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRenglonesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRenglonesCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRenglonesCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRenglonesCompra.Location = New System.Drawing.Point(11, 58)
        Me.dgvRenglonesCompra.Name = "dgvRenglonesCompra"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglonesCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRenglonesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRenglonesCompra.Size = New System.Drawing.Size(529, 314)
        Me.dgvRenglonesCompra.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Ingrese Proveedor:"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(112, 17)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(214, 21)
        Me.cmbProveedores.TabIndex = 21
        '
        'CmdArmarRenglon
        '
        Me.CmdArmarRenglon.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdArmarRenglon.Location = New System.Drawing.Point(465, 4)
        Me.CmdArmarRenglon.Name = "CmdArmarRenglon"
        Me.CmdArmarRenglon.Size = New System.Drawing.Size(75, 45)
        Me.CmdArmarRenglon.TabIndex = 22
        Me.CmdArmarRenglon.Text = "&Armar Renglon"
        Me.CmdArmarRenglon.UseVisualStyleBackColor = True
        '
        'picBuscar
        '
        Me.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBuscar.Image = Global.Saturn_1.Saturn.My.Resources.Resources.buscar
        Me.picBuscar.Location = New System.Drawing.Point(332, 17)
        Me.picBuscar.Name = "picBuscar"
        Me.picBuscar.Size = New System.Drawing.Size(17, 21)
        Me.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuscar.TabIndex = 24
        Me.picBuscar.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(365, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecha.TabIndex = 30
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(12, 392)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(82, 23)
        Me.cmdEliminar.TabIndex = 31
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(100, 392)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(120, 23)
        Me.cmdImportar.TabIndex = 32
        Me.cmdImportar.Text = "Importar desde excel"
        Me.cmdImportar.UseVisualStyleBackColor = True
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 430)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblToTaL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.dgvRenglonesCompra)
        Me.Controls.Add(Me.picBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.CmdArmarRenglon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Compras - Saturn 1.0"
        CType(Me.dgvRenglonesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblToTaL As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button
    Friend WithEvents dgvRenglonesCompra As System.Windows.Forms.DataGridView
    Friend WithEvents picBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents CmdArmarRenglon As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents ofdExcel As System.Windows.Forms.OpenFileDialog
End Class
