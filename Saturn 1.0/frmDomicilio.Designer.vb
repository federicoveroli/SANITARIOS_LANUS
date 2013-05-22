<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDomicilio
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
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDepto = New System.Windows.Forms.TextBox
        Me.txtPiso = New System.Windows.Forms.TextBox
        Me.txtAltura = New System.Windows.Forms.TextBox
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox
        Me.cmbPartido = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(174, 231)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 25)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(264, 231)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 25)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Codigo Postal:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(96, 185)
        Me.txtCodigoPostal.MaxLength = 16
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(189, 20)
        Me.txtCodigoPostal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Partido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Entre calles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Altura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Calle"
        '
        'txtDepto
        '
        Me.txtDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepto.Location = New System.Drawing.Point(83, 77)
        Me.txtDepto.MaxLength = 49
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.Size = New System.Drawing.Size(202, 20)
        Me.txtDepto.TabIndex = 2
        '
        'txtPiso
        '
        Me.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiso.Location = New System.Drawing.Point(83, 102)
        Me.txtPiso.MaxLength = 49
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(202, 20)
        Me.txtPiso.TabIndex = 3
        '
        'txtAltura
        '
        Me.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAltura.Location = New System.Drawing.Point(83, 50)
        Me.txtAltura.MaxLength = 20
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(202, 20)
        Me.txtAltura.TabIndex = 1
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(83, 23)
        Me.txtCalle.MaxLength = 32
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(202, 20)
        Me.txtCalle.TabIndex = 0
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(83, 129)
        Me.cmbLocalidad.MaxLength = 99
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(202, 21)
        Me.cmbLocalidad.Sorted = True
        Me.cmbLocalidad.TabIndex = 4
        '
        'cmbPartido
        '
        Me.cmbPartido.FormattingEnabled = True
        Me.cmbPartido.Location = New System.Drawing.Point(83, 156)
        Me.cmbPartido.MaxLength = 99
        Me.cmbPartido.Name = "cmbPartido"
        Me.cmbPartido.Size = New System.Drawing.Size(202, 21)
        Me.cmbPartido.Sorted = True
        Me.cmbPartido.TabIndex = 5
        '
        'frmDomicilio
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(351, 272)
        Me.Controls.Add(Me.cmbPartido)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.cmbLocalidad)
        Me.Controls.Add(Me.txtPiso)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtCalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDomicilio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del domicilio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDepto As System.Windows.Forms.TextBox
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents cmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartido As System.Windows.Forms.ComboBox
End Class
