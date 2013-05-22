<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.gbUsuario = New System.Windows.Forms.GroupBox
        Me.txtClave2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnIngresar = New System.Windows.Forms.Button
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbUsuarios = New System.Windows.Forms.GroupBox
        Me.lstUsuarios = New System.Windows.Forms.ListBox
        Me.gbUsuario.SuspendLayout()
        Me.gbUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUsuario
        '
        Me.gbUsuario.Controls.Add(Me.txtClave2)
        Me.gbUsuario.Controls.Add(Me.Label5)
        Me.gbUsuario.Controls.Add(Me.btnEliminar)
        Me.gbUsuario.Controls.Add(Me.btnModificar)
        Me.gbUsuario.Controls.Add(Me.btnIngresar)
        Me.gbUsuario.Controls.Add(Me.txtApellido)
        Me.gbUsuario.Controls.Add(Me.txtNombre)
        Me.gbUsuario.Controls.Add(Me.txtClave)
        Me.gbUsuario.Controls.Add(Me.txtUsuario)
        Me.gbUsuario.Controls.Add(Me.Label4)
        Me.gbUsuario.Controls.Add(Me.Label3)
        Me.gbUsuario.Controls.Add(Me.Label2)
        Me.gbUsuario.Controls.Add(Me.Label1)
        Me.gbUsuario.Location = New System.Drawing.Point(224, 2)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Size = New System.Drawing.Size(261, 205)
        Me.gbUsuario.TabIndex = 12
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Datos del Usuario"
        '
        'txtClave2
        '
        Me.txtClave2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave2.Location = New System.Drawing.Point(81, 73)
        Me.txtClave2.MaxLength = 50
        Me.txtClave2.Name = "txtClave2"
        Me.txtClave2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtClave2.Size = New System.Drawing.Size(162, 20)
        Me.txtClave2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Repita:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(168, 162)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(87, 162)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(6, 162)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(81, 123)
        Me.txtApellido.MaxLength = 99
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(162, 20)
        Me.txtApellido.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(81, 99)
        Me.txtNombre.MaxLength = 99
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(162, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(81, 47)
        Me.txtClave.MaxLength = 50
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtClave.Size = New System.Drawing.Size(162, 20)
        Me.txtClave.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(81, 23)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(162, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nick:"
        '
        'gbUsuarios
        '
        Me.gbUsuarios.Controls.Add(Me.lstUsuarios)
        Me.gbUsuarios.Location = New System.Drawing.Point(9, 2)
        Me.gbUsuarios.Name = "gbUsuarios"
        Me.gbUsuarios.Size = New System.Drawing.Size(209, 205)
        Me.gbUsuarios.TabIndex = 13
        Me.gbUsuarios.TabStop = False
        Me.gbUsuarios.Text = "Usuarios Existentes"
        '
        'lstUsuarios
        '
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.Location = New System.Drawing.Point(22, 19)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(174, 173)
        Me.lstUsuarios.TabIndex = 0
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 208)
        Me.Controls.Add(Me.gbUsuario)
        Me.Controls.Add(Me.gbUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(505, 240)
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Usuarios"
        Me.gbUsuario.ResumeLayout(False)
        Me.gbUsuario.PerformLayout()
        Me.gbUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents txtClave2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
End Class
