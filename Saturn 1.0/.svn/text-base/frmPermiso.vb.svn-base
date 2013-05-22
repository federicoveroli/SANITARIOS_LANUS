Imports Fachada
Imports Modelo

Public Class frmPermiso
    Dim fu As FachadaUsuario
    Dim objUsuario As Usuario
    Dim fachPermiso As FachadaPermiso
    Dim permisos As List(Of Permiso)
    Dim cargar As Boolean
    Dim cargarPerfiles As Boolean

    Private Sub frmPermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fu = New FachadaUsuario
        fachPermiso = New FachadaPermiso
        objUsuario = New Usuario
        permisos = fachPermiso.listarPermisos
        ActualizarListaUsuarios()
        CargarPermisos(1, "")
    End Sub
    Private Sub ActualizarListaUsuarios()
        cargar = False
        lstUsuarios.DataSource = fu.listarUsuarios()
        cargar = False
        lstUsuarios.DisplayMember = "nick"
        cargar = False
        lstUsuarios.SelectedIndex = -1
    End Sub


    Private Sub CargarPermisos(ByVal nivel As Integer, ByVal startWith As String)
        'limpio las grillas posteriores
        Dim x As Integer
        x = nivel + 1
        For x = nivel To 3
            CType(gpPermisos.Controls("lstNivel" + CStr(x)), CheckedListBox).Items.Clear()
        Next

        For Each p As Permiso In permisos
            If p.Nivel.ToString().Length = nivel Then
                If nivel <> 1 Then
                    If p.Nivel.ToString().StartsWith(startWith) Then
                        CType(gpPermisos.Controls("lstNivel" + CStr(nivel)), ListBox).Items.Add(p)
                    End If
                Else
                    CType(gpPermisos.Controls("lstNivel" + CStr(nivel)), ListBox).Items.Add(p)
                End If

            End If
        Next
        Dim idPermiso As Integer
        For i As Integer = 0 To CType(gpPermisos.Controls("lstNivel" + CStr(nivel)), ListBox).Items.Count - 1
            idPermiso = CType(CType(gpPermisos.Controls("lstNivel" + CStr(nivel)), CheckedListBox).Items(i), Permiso).IdPermiso
            If objUsuario.TienePermiso(idPermiso) Then
                CType(gpPermisos.Controls("lstNivel" + CStr(nivel)), CheckedListBox).SetItemCheckState(i, CheckState.Checked)
            End If
        Next
    End Sub

    Private Sub lstNivel1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstNivel1.ItemCheck
        If e.NewValue = CheckState.Checked Then
            objUsuario.AddPermiso(CType(lstNivel1.Items(e.Index), Permiso))
        Else
            Dim idPer As Integer
            idPer = CType(lstNivel1.Items(e.Index), Permiso).IdPermiso
            objUsuario.RemovePermiso(idPer)
        End If
    End Sub

    Private Sub lstNivel1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNivel1.SelectedIndexChanged
        CargarPermisos(2, CStr(CType(lstNivel1.SelectedItem, Permiso).Nivel))
    End Sub

    Private Sub lstNivel2_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstNivel2.ItemCheck
        If e.NewValue = CheckState.Checked Then
            objUsuario.AddPermiso(CType(lstNivel2.Items(e.Index), Permiso))
        Else
            Dim idPer As Integer
            idPer = CType(lstNivel2.Items(e.Index), Permiso).IdPermiso
            
            objUsuario.RemovePermiso(idPer)
        End If
    End Sub

    Private Sub lstNivel2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNivel2.SelectedIndexChanged
        CargarPermisos(3, CStr(CType(lstNivel2.SelectedItem, Permiso).Nivel))
    End Sub

    Private Sub lstNivel3_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstNivel3.ItemCheck
        If e.NewValue = CheckState.Checked Then
            objUsuario.AddPermiso(CType(lstNivel3.Items(e.Index), Permiso))
        Else
            Dim idPer As Integer
            idPer = CType(lstNivel3.Items(e.Index), Permiso).IdPermiso
            
            objUsuario.RemovePermiso(idPer)
        End If
    End Sub

    Private Sub lstNivel3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNivel3.SelectedIndexChanged
        CargarPermisos(4, CStr(CType(lstNivel3.SelectedItem, Permiso).Nivel))
    End Sub

    


    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedIndex <> -1 And Cargar = True Then
            objUsuario = lstUsuarios.SelectedItem
            fu.CargarPermisos(objUsuario)
            CargarPermisos(1, "")
            
        End If
        cargar = True
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click

        If MessageBox.Show("¿Realmente desea asignar los permisos seleccionados al usuario '" + objUsuario.Nombre + "'?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
           
            fu.GuardarPermisos(objUsuario)
            MessageBox.Show("Los permisos del usuario '" + objUsuario.Nombre + "' han sido modificados correctamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    

    

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        objUsuario = New Usuario
        lstUsuarios.SelectedIndex = -1
        CargarPermisos(1, "")
    End Sub

End Class