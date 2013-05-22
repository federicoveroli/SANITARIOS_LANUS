<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaCerrar
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
        Me.cmbTipoCierre = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtHora = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTicket = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEfectivo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCantTarj = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotalTarjeta = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEfectivoReal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCantTarjReal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTotalTarjReal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalReal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.txtTotalCaja = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblCierreFinal = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbTipoCierre
        '
        Me.cmbTipoCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCierre.FormattingEnabled = True
        Me.cmbTipoCierre.Items.AddRange(New Object() {"PARCIAL", "FINAL"})
        Me.cmbTipoCierre.Location = New System.Drawing.Point(85, 12)
        Me.cmbTipoCierre.Name = "cmbTipoCierre"
        Me.cmbTipoCierre.Size = New System.Drawing.Size(119, 21)
        Me.cmbTipoCierre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Cierre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(411, 16)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(86, 20)
        Me.txtFecha.TabIndex = 4
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(542, 16)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(70, 20)
        Me.txtHora.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora:"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(289, 16)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.ReadOnly = True
        Me.txtTicket.Size = New System.Drawing.Size(70, 20)
        Me.txtTicket.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "N. Ult. Ticket"
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(61, 51)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.ReadOnly = True
        Me.txtEfectivo.Size = New System.Drawing.Size(70, 20)
        Me.txtEfectivo.TabIndex = 10
        Me.txtEfectivo.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Efectivo"
        '
        'txtCantTarj
        '
        Me.txtCantTarj.Location = New System.Drawing.Point(216, 51)
        Me.txtCantTarj.Name = "txtCantTarj"
        Me.txtCantTarj.ReadOnly = True
        Me.txtCantTarj.Size = New System.Drawing.Size(70, 20)
        Me.txtCantTarj.TabIndex = 12
        Me.txtCantTarj.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cant Tajeta"
        '
        'txtTotalTarjeta
        '
        Me.txtTotalTarjeta.Location = New System.Drawing.Point(383, 51)
        Me.txtTotalTarjeta.Name = "txtTotalTarjeta"
        Me.txtTotalTarjeta.ReadOnly = True
        Me.txtTotalTarjeta.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalTarjeta.TabIndex = 14
        Me.txtTotalTarjeta.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Tarjeta"
        '
        'txtEfectivoReal
        '
        Me.txtEfectivoReal.Location = New System.Drawing.Point(61, 91)
        Me.txtEfectivoReal.Name = "txtEfectivoReal"
        Me.txtEfectivoReal.Size = New System.Drawing.Size(70, 20)
        Me.txtEfectivoReal.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Efectivo"
        '
        'txtCantTarjReal
        '
        Me.txtCantTarjReal.Location = New System.Drawing.Point(216, 91)
        Me.txtCantTarjReal.Name = "txtCantTarjReal"
        Me.txtCantTarjReal.Size = New System.Drawing.Size(70, 20)
        Me.txtCantTarjReal.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(148, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cant Tajeta"
        '
        'txtTotalTarjReal
        '
        Me.txtTotalTarjReal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalTarjReal.Location = New System.Drawing.Point(383, 91)
        Me.txtTotalTarjReal.Name = "txtTotalTarjReal"
        Me.txtTotalTarjReal.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalTarjReal.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total Tarjeta"
        '
        'txtTotalReal
        '
        Me.txtTotalReal.Location = New System.Drawing.Point(542, 91)
        Me.txtTotalReal.Name = "txtTotalReal"
        Me.txtTotalReal.ReadOnly = True
        Me.txtTotalReal.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalReal.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(474, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total caja"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(450, 143)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(537, 143)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.Location = New System.Drawing.Point(542, 51)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.ReadOnly = True
        Me.txtTotalCaja.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalCaja.TabIndex = 30
        Me.txtTotalCaja.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(474, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Total caja"
        '
        'lblCierreFinal
        '
        Me.lblCierreFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierreFinal.ForeColor = System.Drawing.Color.Red
        Me.lblCierreFinal.Location = New System.Drawing.Point(12, 131)
        Me.lblCierreFinal.Name = "lblCierreFinal"
        Me.lblCierreFinal.Size = New System.Drawing.Size(413, 35)
        Me.lblCierreFinal.TabIndex = 31
        Me.lblCierreFinal.Text = "Al realizar un cierre final debe retirar los tickets de venta con tarjeta"
        Me.lblCierreFinal.Visible = False
        '
        'frmCajaCerrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 176)
        Me.Controls.Add(Me.lblCierreFinal)
        Me.Controls.Add(Me.txtTotalCaja)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtTotalReal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotalTarjReal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantTarjReal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEfectivoReal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalTarjeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCantTarj)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipoCierre)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCajaCerrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arqueo de caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoCierre As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantTarj As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivoReal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantTarjReal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTarjReal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalReal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTotalCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCierreFinal As System.Windows.Forms.Label
End Class
