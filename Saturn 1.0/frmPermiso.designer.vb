<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermiso
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
        Me.gpPermisos = New System.Windows.Forms.GroupBox
        Me.lstNivel3 = New System.Windows.Forms.CheckedListBox
        Me.lstNivel2 = New System.Windows.Forms.CheckedListBox
        Me.lstNivel1 = New System.Windows.Forms.CheckedListBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAsignar = New System.Windows.Forms.Button
        Me.gbUsuarios = New System.Windows.Forms.GroupBox
        Me.lstUsuarios = New System.Windows.Forms.ListBox
        Me.gpPermisos.SuspendLayout()
        Me.gbUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpPermisos
        '
        Me.gpPermisos.Controls.Add(Me.lstNivel3)
        Me.gpPermisos.Controls.Add(Me.lstNivel2)
        Me.gpPermisos.Controls.Add(Me.lstNivel1)
        Me.gpPermisos.Location = New System.Drawing.Point(12, 236)
        Me.gpPermisos.Name = "gpPermisos"
        Me.gpPermisos.Size = New System.Drawing.Size(529, 219)
        Me.gpPermisos.TabIndex = 2
        Me.gpPermisos.TabStop = False
        Me.gpPermisos.Text = "Permisos Asignados"
        '
        'lstNivel3
        '
        Me.lstNivel3.FormattingEnabled = True
        Me.lstNivel3.Location = New System.Drawing.Point(359, 21)
        Me.lstNivel3.Name = "lstNivel3"
        Me.lstNivel3.Size = New System.Drawing.Size(155, 184)
        Me.lstNivel3.TabIndex = 2
        '
        'lstNivel2
        '
        Me.lstNivel2.FormattingEnabled = True
        Me.lstNivel2.Location = New System.Drawing.Point(189, 19)
        Me.lstNivel2.Name = "lstNivel2"
        Me.lstNivel2.Size = New System.Drawing.Size(155, 184)
        Me.lstNivel2.TabIndex = 1
        '
        'lstNivel1
        '
        Me.lstNivel1.FormattingEnabled = True
        Me.lstNivel1.HorizontalScrollbar = True
        Me.lstNivel1.Location = New System.Drawing.Point(18, 19)
        Me.lstNivel1.Name = "lstNivel1"
        Me.lstNivel1.Size = New System.Drawing.Size(155, 184)
        Me.lstNivel1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(466, 465)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(385, 465)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignar.TabIndex = 6
        Me.btnAsignar.Text = "&Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'gbUsuarios
        '
        Me.gbUsuarios.Controls.Add(Me.lstUsuarios)
        Me.gbUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.gbUsuarios.Name = "gbUsuarios"
        Me.gbUsuarios.Size = New System.Drawing.Size(209, 205)
        Me.gbUsuarios.TabIndex = 14
        Me.gbUsuarios.TabStop = False
        Me.gbUsuarios.Text = "Seleccione un usuario"
        '
        'lstUsuarios
        '
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.Location = New System.Drawing.Point(22, 19)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(174, 173)
        Me.lstUsuarios.TabIndex = 0
        '
        'frmPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(558, 500)
        Me.Controls.Add(Me.gbUsuarios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gpPermisos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de permisos"
        Me.gpPermisos.ResumeLayout(False)
        Me.gbUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents lstNivel3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstNivel2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstNivel1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents gbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
End Class
