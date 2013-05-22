<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerFacturasArchivadas
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
        Me.dgvFacturasArchivadas = New System.Windows.Forms.DataGridView
        Me.cmbFacturasArchivadas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.cmdDetalles = New System.Windows.Forms.Button
        CType(Me.dgvFacturasArchivadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFacturasArchivadas
        '
        Me.dgvFacturasArchivadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFacturasArchivadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturasArchivadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacturasArchivadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturasArchivadas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFacturasArchivadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFacturasArchivadas.Location = New System.Drawing.Point(26, 58)
        Me.dgvFacturasArchivadas.MultiSelect = False
        Me.dgvFacturasArchivadas.Name = "dgvFacturasArchivadas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturasArchivadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFacturasArchivadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturasArchivadas.Size = New System.Drawing.Size(740, 365)
        Me.dgvFacturasArchivadas.TabIndex = 70
        '
        'cmbFacturasArchivadas
        '
        Me.cmbFacturasArchivadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFacturasArchivadas.FormattingEnabled = True
        Me.cmbFacturasArchivadas.Location = New System.Drawing.Point(137, 17)
        Me.cmbFacturasArchivadas.Name = "cmbFacturasArchivadas"
        Me.cmbFacturasArchivadas.Size = New System.Drawing.Size(629, 21)
        Me.cmbFacturasArchivadas.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Nombre del Archivo:"
        '
        'cmdImportar
        '
        Me.cmdImportar.Enabled = False
        Me.cmdImportar.Location = New System.Drawing.Point(605, 429)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(80, 23)
        Me.cmdImportar.TabIndex = 82
        Me.cmdImportar.Text = "&Importar"
        Me.cmdImportar.UseVisualStyleBackColor = True
        '
        'cmdDetalles
        '
        Me.cmdDetalles.Location = New System.Drawing.Point(691, 429)
        Me.cmdDetalles.Name = "cmdDetalles"
        Me.cmdDetalles.Size = New System.Drawing.Size(80, 23)
        Me.cmdDetalles.TabIndex = 81
        Me.cmdDetalles.Text = "&Detalles"
        Me.cmdDetalles.UseVisualStyleBackColor = True
        '
        'frmVerFacturasArchivadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 462)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdDetalles)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvFacturasArchivadas)
        Me.Controls.Add(Me.cmbFacturasArchivadas)
        Me.Name = "frmVerFacturasArchivadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Visor de facturas archivadas"
        CType(Me.dgvFacturasArchivadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFacturasArchivadas As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFacturasArchivadas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents cmdDetalles As System.Windows.Forms.Button
End Class
