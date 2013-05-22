<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchivarFacturas
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnArchivar = New System.Windows.Forms.Button
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox
        Me.dgvFacturas = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Archivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Fin:"
        '
        'btnArchivar
        '
        Me.btnArchivar.Location = New System.Drawing.Point(488, 453)
        Me.btnArchivar.Name = "btnArchivar"
        Me.btnArchivar.Size = New System.Drawing.Size(75, 23)
        Me.btnArchivar.TabIndex = 3
        Me.btnArchivar.Text = "Archivar"
        Me.btnArchivar.UseVisualStyleBackColor = True
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(118, 8)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(445, 20)
        Me.txtNombreArchivo.TabIndex = 4
        '
        'dgvFacturas
        '
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 86)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.Size = New System.Drawing.Size(551, 361)
        Me.dgvFacturas.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Facturas a archivar"
        '
        'dtphasta
        '
        Me.dtphasta.Enabled = False
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(295, 36)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(94, 20)
        Me.dtphasta.TabIndex = 9
        '
        'dtpdesde
        '
        Me.dtpdesde.Enabled = False
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpdesde.Location = New System.Drawing.Point(118, 36)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(94, 20)
        Me.dtpdesde.TabIndex = 8
        '
        'FrmArchivarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 484)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.txtNombreArchivo)
        Me.Controls.Add(Me.btnArchivar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmArchivarFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Saturn - Archivar Facturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnArchivar As System.Windows.Forms.Button
    Friend WithEvents txtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
End Class
