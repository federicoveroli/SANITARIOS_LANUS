Imports Fachada
Imports Modelo


Public Class frmUsuario

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        e.Handled = Not Validar.EsLetra(e.KeyChar.ToString())
    End Sub
    Dim fu As FachadaUsuario
    Dim usu As Usuario

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Try
            If CamposValidos() = False Then Exit Sub
            If txtClave.Text <> txtClave2.Text Then
                MessageBox.Show("Las claves ingresadas deben ser iguales", "Clave invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClave.Text = ""
                txtClave2.Text = ""
                txtClave.Focus()
                Exit Sub
            End If
            fu.altaUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text)
            MessageBox.Show("El usuario '" + txtUsuario.Text + "' ha sido ingresado al sistema.", "Usuario ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarListaUsuarios()
        Catch ex As NickNoDisponibleException
            MessageBox.Show(ex.Message, "Usuario no valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
        Catch ex As UsuarioEliminadoException
            If MessageBox.Show("El nick ingresado corresponde a un usuario eliminado." + vbCr + "¿Desea restaurar ese usuario?", "Usuario no valido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'restauro el usuario eliminado
                fu.restaurarUsuario(txtUsuario.Text)
                ActualizarListaUsuarios()
            Else
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fu = New FachadaUsuario
        txtUsuario.Focus()
        ActualizarListaUsuarios()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Realmente desea eliminar el usuario '" + lstUsuarios.Text + "'?", "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                fu.bajaUsuario(usu.Id)
                ActualizarListaUsuarios()
            Catch ex As UltimoUsuarioException
                MessageBox.Show(ex.Message, "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged

        usu = CType(lstUsuarios.SelectedItem, Usuario)
        txtApellido.Text = usu.Apellido
        txtNombre.Text = usu.Nombre
        txtUsuario.Text = usu.Nick

    End Sub
    Private Sub ActualizarListaUsuarios()
        lstUsuarios.DataSource = fu.listarUsuarios()
        lstUsuarios.DisplayMember = "nick"
        LimpiarCasillas()
    End Sub
    Private Sub LimpiarCasillas()
        txtApellido.Clear()
        txtClave.Clear()
        txtClave2.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
    End Sub



    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim nickAnterior As String
        If CamposValidos() = False Then Exit Sub
        If txtClave.Text <> txtClave2.Text Then
            MessageBox.Show("Las claves ingresadas deben ser iguales", "Clave invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClave.Text = ""
            txtClave2.Text = ""
            txtClave.Focus()
            Exit Sub
        End If
        nickAnterior = usu.Nick
        usu.Nick = txtUsuario.Text
        usu.Nombre = txtNombre.Text
        usu.Apellido = txtApellido.Text
        usu.Pass = txtClave.Text
        Try
            fu.modificarUsuario(nickAnterior, usu)
            MessageBox.Show("El usuario '" + txtUsuario.Text + "' ha sido modificado con exito.", "Usuario ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarListaUsuarios()
        Catch ex As NickNoDisponibleException
            MessageBox.Show(ex.Message, "Usuario no valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function CamposValidos() As Boolean
        If txtNombre.Text.Trim.Length = 0 Or txtUsuario.Text.Trim.Length = 0 Or txtApellido.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe completar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Return False
        End If
        If txtClave.Text.Length < 6 Then
            MessageBox.Show("La clave debe poseer como minimo 6 caracteres.", "Clave invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClave.Focus()
            Return False
        End If
        Return True
    End Function


    
   

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        e.Handled = Not Validar.EsLetra(e.KeyChar.ToString())
    End Sub


End Class