Imports Fachada
Imports Modelo

Public Class FrmClienteBuscar
    Dim facCliente As FachadaCliente

    Public idClienteSeleccionado As Integer
    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoCliente.Click
        FrmClienteAlta.cmdAceptar.Visible = True
        FrmClienteAlta.cmdModifCliente.Visible = False
        FrmClienteAlta.Show()
    End Sub

    Private Sub FrmClienteBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If
        If Asc(e.KeyChar) = 46 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(44)
        End If
    End Sub

    Private Sub FrmClienteBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facCliente = New FachadaCliente
        cmbBuscarPor.SelectedIndex = 7
        dgvClientes.DataSource = facCliente.ListarTodos()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        If cmbBuscarPor.SelectedIndex <> 7 And txtQueContenga.Text.Length = 0 Then
            MessageBox.Show("Debe completar el campo 'que contenga'", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQueContenga.Focus()
            Exit Sub
        End If

        Select Case cmbBuscarPor.SelectedIndex
            Case 0
                'Id(Cliente)
                dgvClientes.DataSource = facCliente.ListarPorId(txtQueContenga.Text)
            Case 1
                'Nombre()
                dgvClientes.DataSource = facCliente.ListarPorNombre(txtQueContenga.Text)
            Case 2
                'Localidad()
                dgvClientes.DataSource = facCliente.listarPorLocalidad(txtQueContenga.Text)
            Case 3
                'Codigo(Postal)
                dgvClientes.DataSource = facCliente.listarPorCodigoPostal(txtQueContenga.Text)
            Case 4
                'Rubro()
                dgvClientes.DataSource = facCliente.listarPorRubro(txtQueContenga.Text)
            Case 5
                'Cuit()
                dgvClientes.DataSource = facCliente.listarPorCuit(txtQueContenga.Text)
            Case 6
                'Iva()
                dgvClientes.DataSource = facCliente.ListarPorIva(txtQueContenga.Text)
            Case 7
                'Listado(Total)
                dgvClientes.DataSource = facCliente.ListarTodos()
                dgvClientes.Select()
                dgvClientes.Focus()
        End Select
    End Sub

    

  
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If dgvClientes.SelectedRows(0).Index = dgvClientes.Rows.Count - 1 Then Exit Sub
        FrmClienteAlta.cmdAceptar.Visible = False
        FrmClienteAlta.modificarCliente(CInt(dgvClientes.SelectedRows(0).Cells(0).Value.ToString))
        FrmClienteAlta.cmdModifCliente.Visible = True
        FrmClienteAlta.MdiParent = FrmPrincipal
        FrmClienteAlta.Show()
    End Sub

    Private Sub cmdBaja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBaja.Click
        Dim id As Integer = (CInt(dgvClientes.SelectedRows(0).Cells(0).Value.ToString))
        Dim f As New FachadaCliente
        Dim dt As DataTable
        dt = f.FijarmeSidebe(id)
        If dt.Rows(0).Item(0) = 0 Then
            If MessageBox.Show("�Realmente desea eliminar el cliente seleccionado?", "Confirme la operaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                facCliente.BajaCliente(CInt(dgvClientes.SelectedRows(0).Cells(0).Value.ToString))
                cmbBuscarPor.SelectedIndex = 7
                cmdBuscar_Click(sender, e)
            End If
        Else
            MsgBox("No puede eliminar ese cliente porque posee deudas!")
        End If
    End Sub

    Private Sub IdClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdClienteToolStripMenuItem.Click
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

    Private Sub CuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuitToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 5
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub IvaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IvaToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 6
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTotalToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 7
        txtQueContenga.Text = ""
        cmdBuscar_Click(sender, e)
    End Sub

    Private Sub dgvClientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvClientes.KeyPress
        If Asc(e.KeyChar) = 32 And cmdModificar.Visible Then
            cmdModificar_Click(sender, e)
        End If
    End Sub


    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If dgvClientes.SelectedRows(0).Index = dgvClientes.Rows.Count - 1 Then Exit Sub
        idClienteSeleccionado = (CInt(dgvClientes.SelectedRows(0).Cells(0).Value.ToString))
        Me.Close()
    End Sub

    Private Sub cmbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBuscarPor.SelectedIndexChanged
        If cmbBuscarPor.SelectedIndex = 7 Then
            txtQueContenga.Enabled = False
            cmdBuscar_Click(sender, e)
        Else
            txtQueContenga.Enabled = True
        End If
    End Sub
End Class
