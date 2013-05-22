<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarInexistente
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
        Me.grupoRenglon = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPU = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDetalle = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grupoRenglon.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoRenglon
        '
        Me.grupoRenglon.Controls.Add(Me.cmdCancelar)
        Me.grupoRenglon.Controls.Add(Me.cmdAceptar)
        Me.grupoRenglon.Controls.Add(Me.txtTotal)
        Me.grupoRenglon.Controls.Add(Me.Label6)
        Me.grupoRenglon.Controls.Add(Me.txtPU)
        Me.grupoRenglon.Controls.Add(Me.Label5)
        Me.grupoRenglon.Controls.Add(Me.txtDetalle)
        Me.grupoRenglon.Controls.Add(Me.Label4)
        Me.grupoRenglon.Controls.Add(Me.txtCantidad)
        Me.grupoRenglon.Controls.Add(Me.Label3)
        Me.grupoRenglon.Location = New System.Drawing.Point(7, 6)
        Me.grupoRenglon.Name = "grupoRenglon"
        Me.grupoRenglon.Size = New System.Drawing.Size(642, 85)
        Me.grupoRenglon.TabIndex = 10
        Me.grupoRenglon.TabStop = False
        Me.grupoRenglon.Text = "Detalles del renglon"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(133, 56)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(119, 23)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(19, 56)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(99, 23)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(560, 24)
        Me.txtTotal.MaxLength = 9
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Subtotal"
        '
        'txtPU
        '
        Me.txtPU.Location = New System.Drawing.Point(434, 24)
        Me.txtPU.MaxLength = 9
        Me.txtPU.Name = "txtPU"
        Me.txtPU.Size = New System.Drawing.Size(68, 20)
        Me.txtPU.TabIndex = 5
        Me.txtPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PU"
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(151, 24)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(242, 20)
        Me.txtDetalle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detalle:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(67, 24)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(40, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cantidad:"
        '
        'frmAgregarInexistente
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(660, 100)
        Me.Controls.Add(Me.grupoRenglon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarInexistente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Inexistente"
        Me.grupoRenglon.ResumeLayout(False)
        Me.grupoRenglon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoRenglon As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPU As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
