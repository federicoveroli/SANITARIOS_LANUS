<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMigrarArticulos
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
        Me.cmdMigrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnMigrarDatos = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdMigrar
        '
        Me.cmdMigrar.Location = New System.Drawing.Point(116, 12)
        Me.cmdMigrar.Name = "cmdMigrar"
        Me.cmdMigrar.Size = New System.Drawing.Size(75, 44)
        Me.cmdMigrar.TabIndex = 0
        Me.cmdMigrar.Text = "Migrar Articulos"
        Me.cmdMigrar.UseVisualStyleBackColor = True
        Me.cmdMigrar.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(28, 73)
        Me.ProgressBar1.Maximum = 2919
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(435, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Categorias"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Marcas"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(388, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Proveedores"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'btnMigrarDatos
        '
        Me.btnMigrarDatos.Location = New System.Drawing.Point(28, 12)
        Me.btnMigrarDatos.Name = "btnMigrarDatos"
        Me.btnMigrarDatos.Size = New System.Drawing.Size(75, 44)
        Me.btnMigrarDatos.TabIndex = 5
        Me.btnMigrarDatos.Text = "Migrar Datos"
        Me.btnMigrarDatos.UseVisualStyleBackColor = True
        '
        'frmMigrarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 127)
        Me.Controls.Add(Me.btnMigrarDatos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmdMigrar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(507, 165)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(507, 165)
        Me.Name = "frmMigrarArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Migracion de datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdMigrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnMigrarDatos As System.Windows.Forms.Button
End Class
