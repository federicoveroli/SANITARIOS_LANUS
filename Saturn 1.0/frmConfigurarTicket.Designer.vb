<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurarTicket
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtEncabezado4 = New System.Windows.Forms.TextBox
        Me.txtEncabezado3 = New System.Windows.Forms.TextBox
        Me.txtEncabezado2 = New System.Windows.Forms.TextBox
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.txtEncabezado1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPie2 = New System.Windows.Forms.TextBox
        Me.txtPie1 = New System.Windows.Forms.TextBox
        Me.txtEncabezado5 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPie4 = New System.Windows.Forms.TextBox
        Me.txtPie3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPie5 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPie5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPie4)
        Me.GroupBox1.Controls.Add(Me.txtPie3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPie2)
        Me.GroupBox1.Controls.Add(Me.txtPie1)
        Me.GroupBox1.Controls.Add(Me.txtEncabezado5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEncabezado4)
        Me.GroupBox1.Controls.Add(Me.txtEncabezado3)
        Me.GroupBox1.Controls.Add(Me.txtEncabezado2)
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.txtEncabezado1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 205)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la conexión"
        '
        'txtEncabezado4
        '
        Me.txtEncabezado4.Location = New System.Drawing.Point(87, 105)
        Me.txtEncabezado4.MaxLength = 32
        Me.txtEncabezado4.Name = "txtEncabezado4"
        Me.txtEncabezado4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEncabezado4.Size = New System.Drawing.Size(164, 20)
        Me.txtEncabezado4.TabIndex = 3
        '
        'txtEncabezado3
        '
        Me.txtEncabezado3.Location = New System.Drawing.Point(87, 78)
        Me.txtEncabezado3.MaxLength = 32
        Me.txtEncabezado3.Name = "txtEncabezado3"
        Me.txtEncabezado3.Size = New System.Drawing.Size(164, 20)
        Me.txtEncabezado3.TabIndex = 2
        '
        'txtEncabezado2
        '
        Me.txtEncabezado2.Location = New System.Drawing.Point(87, 51)
        Me.txtEncabezado2.MaxLength = 32
        Me.txtEncabezado2.Name = "txtEncabezado2"
        Me.txtEncabezado2.Size = New System.Drawing.Size(164, 20)
        Me.txtEncabezado2.TabIndex = 1
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(365, 171)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(110, 23)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "&Guardar Datos"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'txtEncabezado1
        '
        Me.txtEncabezado1.Location = New System.Drawing.Point(87, 25)
        Me.txtEncabezado1.MaxLength = 32
        Me.txtEncabezado1.Name = "txtEncabezado1"
        Me.txtEncabezado1.Size = New System.Drawing.Size(164, 20)
        Me.txtEncabezado1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Encabezado 4:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Encabezado 3:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Encabezado 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Encabezado 1:"
        '
        'txtPie2
        '
        Me.txtPie2.Location = New System.Drawing.Point(311, 51)
        Me.txtPie2.MaxLength = 32
        Me.txtPie2.Name = "txtPie2"
        Me.txtPie2.Size = New System.Drawing.Size(164, 20)
        Me.txtPie2.TabIndex = 9
        '
        'txtPie1
        '
        Me.txtPie1.Location = New System.Drawing.Point(311, 25)
        Me.txtPie1.MaxLength = 32
        Me.txtPie1.Name = "txtPie1"
        Me.txtPie1.Size = New System.Drawing.Size(164, 20)
        Me.txtPie1.TabIndex = 8
        '
        'txtEncabezado5
        '
        Me.txtEncabezado5.Location = New System.Drawing.Point(87, 131)
        Me.txtEncabezado5.MaxLength = 32
        Me.txtEncabezado5.Name = "txtEncabezado5"
        Me.txtEncabezado5.Size = New System.Drawing.Size(164, 20)
        Me.txtEncabezado5.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pie 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pie 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Encabezado 5:"
        '
        'txtPie4
        '
        Me.txtPie4.Location = New System.Drawing.Point(311, 104)
        Me.txtPie4.MaxLength = 32
        Me.txtPie4.Name = "txtPie4"
        Me.txtPie4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPie4.Size = New System.Drawing.Size(164, 20)
        Me.txtPie4.TabIndex = 13
        '
        'txtPie3
        '
        Me.txtPie3.Location = New System.Drawing.Point(311, 78)
        Me.txtPie3.MaxLength = 32
        Me.txtPie3.Name = "txtPie3"
        Me.txtPie3.Size = New System.Drawing.Size(164, 20)
        Me.txtPie3.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Pie 4:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Pie 3:"
        '
        'txtPie5
        '
        Me.txtPie5.Location = New System.Drawing.Point(311, 131)
        Me.txtPie5.MaxLength = 32
        Me.txtPie5.Name = "txtPie5"
        Me.txtPie5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPie5.Size = New System.Drawing.Size(164, 20)
        Me.txtPie5.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Pie 5:"
        '
        'frmConfigurarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 219)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConfigurarTicket"
        Me.Text = "Configuración del Ticket..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPie2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPie1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEncabezado5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEncabezado4 As System.Windows.Forms.TextBox
    Friend WithEvents txtEncabezado3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEncabezado2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents txtEncabezado1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPie4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPie3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPie5 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
