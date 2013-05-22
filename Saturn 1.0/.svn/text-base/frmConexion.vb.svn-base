Imports Modelo
Imports Fachada

Public Class frmConexion

    Private Sub cmdConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConexion.Click
        Dim registroCC As New FachadaCadenaDeConexion
        Dim enc As New Encriptador
        Dim cc As New CadenaDeConexion
        If txtUsuario.Text.Length = 0 Or txtBase.Text.Length = 0 Or txtPassword.Text.Length = 0 Or txtServidor.Text.Length = 0 Then
            MessageBox.Show("Debe completar todos los datos de la conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        cc.Usuario = txtUsuario.Text
        cc.Base = txtBase.Text
        cc.Password = txtPassword.Text
        cc.Servidor = txtServidor.Text
        Try
            registroCC.GuardarConexion(cc)
            MessageBox.Show("La conexión se ha persistido exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            'Prueba la conexion y la persiste en el archivo "Conexion.xml" si esta conecta
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class