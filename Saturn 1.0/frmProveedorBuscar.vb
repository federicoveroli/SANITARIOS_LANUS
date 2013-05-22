Imports Modelo
Imports Fachada

Public Class frmProveedorBuscar
    Dim facProveedor As FachadaProveedor
    Public idProveedorSeleccionado As Integer

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmProveedorBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facProveedor = New FachadaProveedor
        cmbBuscarPor.SelectedIndex = 6
        cmdBuscar_Click(sender, e)

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If cmbBuscarPor.SelectedIndex <> 6 And txtQueContenga.Text.Length = 0 Then
            MessageBox.Show("Debe completar el campo 'que contenga'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQueContenga.Focus()
            Exit Sub
        End If

        Select Case cmbBuscarPor.SelectedIndex
            Case 0
                'Id(Cliente)
                dgvProveedores.DataSource = facProveedor.ListarPorId(txtQueContenga.Text)
            Case 1
                'Nombre()
                dgvProveedores.DataSource = facProveedor.ListarPorNombre(txtQueContenga.Text)
            Case 2
                'Localidad()
                dgvProveedores.DataSource = facProveedor.listarPorLocalidad(txtQueContenga.Text)
            Case 3
                'Codigo(Postal)
                dgvProveedores.DataSource = facProveedor.listarPorCodigoPostal(txtQueContenga.Text)
            Case 4
                'Rubro()
                dgvProveedores.DataSource = facProveedor.listarPorRubro(txtQueContenga.Text)
            Case 5
                'contacto() 
                dgvProveedores.DataSource = facProveedor.listarPorContacto(txtQueContenga.Text)
            Case 6
                'Listado(Total)
                dgvProveedores.DataSource = facProveedor.ListarTodos()
                dgvProveedores.Select()
                dgvProveedores.Focus()
        End Select
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        frmProveedorAlta.cmdAceptar.Visible = False
        frmProveedorAlta.modificarProveedor(CInt(dgvProveedores.SelectedRows(0).Cells(0).Value.ToString))
        frmProveedorAlta.cmdModifProveedor.Visible = True
        frmProveedorAlta.MdiParent = FrmPrincipal
        frmProveedorAlta.Show()
    End Sub

    Private Sub cmdBaja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBaja.Click
        If MessageBox.Show("¿Realmente desea eliminar el proveedor seleccionado?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

           
                facProveedor.BajaProveedor(CInt(dgvProveedores.SelectedRows(0).Cells(0).Value.ToString))
                cmbBuscarPor.SelectedIndex = 6
                cmdBuscar_Click(sender, e)
            Catch ex As Exception
                MsgBox("El proveedor no puede ser eliminado ya que posee compras!")
            End Try
        End If
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If dgvProveedores.SelectedRows(0).Index = dgvProveedores.Rows.Count - 1 Then Exit Sub
        idProveedorSeleccionado = (CInt(dgvProveedores.SelectedRows(0).Cells(0).Value.ToString))
        Me.Close()
    End Sub

    Private Sub IdProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdProveedorToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 0
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub NombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 1
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 2
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub CodigoPostalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoPostalToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 3
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub RubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubroToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 4
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactoToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 5
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTotalToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 6
        txtQueContenga.Text = ""
        cmdBuscar_Click(sender, e)
    End Sub
End Class