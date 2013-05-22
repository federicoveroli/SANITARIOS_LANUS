Imports Fachada
Imports Modelo

Public Class frmProveedorAlta
    Dim facTel As New FachadaTelefono
    Dim facDomicilio As New FachadaDomicilio
    Dim objproveedor As New proveedor
    Dim facEnte As New FachadaProveedor
    Dim facIva As New FachadaIva
    Dim facRubro As New FachadaRubro
    Dim tel As Telefono
    Dim modificar As Boolean = False
    Dim saltearSeleccion As Boolean = False

    Public Sub modificarProveedor(ByVal idProveedor As Integer)
        modificar = True
        cmbRubro.DataSource = facRubro.listarRubros
        cmbTipoTelefono.DataSource = facTel.listarTiposTelefonos()
        objproveedor = facEnte.TraerPorId(idProveedor)
        txtNombre.Text = objproveedor.RazonSocial
        txtBonificaciones.Text = objproveedor.Bonificaciones
        txtEmail.Text = objproveedor.Email
        txtLista.Text = objproveedor.Lista
        For Each r As Rubro In cmbRubro.Items
            If r.IdRubro = objproveedor.IdProveedor Then
                cmbRubro.SelectedItem = r
                Exit For
            End If
        Next
        facTel.GenerarColumnasEnGrilla(dgvTelefonos)
        facTel.CargarGrilla(objproveedor, dgvTelefonos)
        facDomicilio.GenerarColumnasGrilla(dgvDomicilios)
        facDomicilio.CargarGrilla(objproveedor, dgvDomicilios)
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        ''Dim tel As Telefono
        If Not dgvTelefonos.CurrentRow.Index < dgvTelefonos.Rows.Count - 1 Then Exit Sub

        'en la variable tel ya tengo el telefono a eliminar!

        If dgvTelefonos.Rows.Count > 1 Then


            tel = New Telefono
            tel.Numero = dgvTelefonos.Rows.Item(dgvTelefonos.CurrentRow.Index).Cells(1).Value

            objproveedor.RemoveTelefono(tel)
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
            tel.NombreContacto = txtNombreContacto.Text
            tel.IdTipoTelefono = CType(cmbTipoTelefono.SelectedItem, TipoTelefono).IdTipoTelefono
            tel.Numero = txtTelefono.Text
            If objproveedor.AddTelefono(tel) = True Then
                facTel.CargarTelefonoEnGrilla(tel, dgvTelefonos)
            Else
                MsgBox("El telefono ingresado ya existe", MsgBoxStyle.Exclamation, "Atención")
                txtTelefono.Select()
                Exit Sub
            End If


        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim tel As New Telefono
        tel.IdTipoTelefono = CType(cmbTipoTelefono.SelectedItem, TipoTelefono).IdTipoTelefono
        tel.NombreContacto = txtNombreContacto.Text
        tel.Numero = txtTelefono.Text
        If objproveedor.AddTelefono(tel) = False Then
            MsgBox("El telefono ingresado ya existe", MsgBoxStyle.Exclamation, "Atención")
            txtTelefono.Select()
            Exit Sub
        Else
            facTel.CargarTelefonoEnGrilla(tel, dgvTelefonos)
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If dgvTelefonos.Rows.Count <= 1 Or dgvTelefonos.SelectedRows(0).Index = dgvTelefonos.Rows.Count - 1 Then Exit Sub
        tel = objproveedor.Telefonos(dgvTelefonos.SelectedRows(0).Cells(1).Value)
        objproveedor.RemoveTelefono(tel)
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
    End Sub

    Private Sub btnAgregarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDomicilio.Click
        Limpiar.LimpiarControles(frmDomicilio.Controls)
        frmDomicilio.ShowDialog()

        If frmDomicilio.Confirmo Then
            Dim d As Domicilio = frmDomicilio.DataSource
            If objproveedor.AddDomicilio(d) = False Then
                MessageBox.Show("Ya posee un domicilio con esa dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                facDomicilio.CargarDomicilioEnGrilla(d, dgvDomicilios)
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        '************ VALIDO LOS DATOS INGRESADOS
        If txtNombre.Text.Length = 0 Then
            MessageBox.Show("Debe ingresar el nombre del proveedor", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Select()
            Exit Sub
        End If
        

        objproveedor.CUIT = "0000000000000"
        objproveedor.FechaAlta = dtpFechaAlta.Value
        objproveedor.RazonSocial = txtNombre.Text
        objproveedor.IdRubro = CType(cmbRubro.SelectedItem, Rubro).IdRubro
        objproveedor.Lista = txtLista.Text
        objproveedor.Bonificaciones = txtBonificaciones.Text
        objproveedor.Email = txtEmail.Text

        facEnte.AltaProveedor(objproveedor)

        MessageBox.Show("El proveedor se ha ingresado al sistema exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        saltearSeleccion = True
        dgvTelefonos.Rows.Clear()
        dgvDomicilios.Rows.Clear()
        Limpiar.LimpiarControles(Me.Controls)
    End Sub

    Private Sub frmProveedorAlta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub frmProveedorAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        saltearSeleccion = False
        If modificar = False Then
            cmbRubro.DataSource = facRubro.listarRubros
            cmbTipoTelefono.DataSource = facTel.listarTiposTelefonos()
            facTel.GenerarColumnasEnGrilla(dgvTelefonos)
            facDomicilio.GenerarColumnasGrilla(dgvDomicilios)
        End If
    End Sub

    Private Sub btnEliminarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDomicilio.Click
        If dgvDomicilios.SelectedRows(0).Index = dgvDomicilios.Rows.Count - 1 Then Exit Sub
        Dim dom As Domicilio
        dom = objproveedor.Domicilios(dgvDomicilios.SelectedRows(0).Cells(0).Value.ToString() + dgvDomicilios.SelectedRows(0).Cells(1).Value.ToString())
        objproveedor.RemoveDomicilio(dom)
        dgvDomicilios.Rows.RemoveAt(dgvDomicilios.SelectedRows(0).Index)
    End Sub

    Private Sub btnModificarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDomicilio.Click
        If dgvDomicilios.Rows.Count > 1 Then
            Dim dom As Domicilio
            Dim ClaveDomicilio As String
            'ClaveDomicilio = dgvDomicilios.SelectedRows(dgvDomicilios.CurrentRow.Index).Cells(0).Value + dgvDomicilios.SelectedRows(0).Cells(1).Value

            ClaveDomicilio = dgvDomicilios.Rows.Item(dgvDomicilios.CurrentRow.Index).Cells(0).Value + dgvDomicilios.Rows.Item(dgvDomicilios.CurrentRow.Index).Cells(1).Value
            dom = objproveedor.Domicilios(ClaveDomicilio)
            frmDomicilio.DataSource = dom
            frmDomicilio.ShowDialog()

            If frmDomicilio.Confirmo Then
                objproveedor.RemoveDomicilio(dom)
                dgvDomicilios.Rows.RemoveAt(dgvDomicilios.SelectedRows(0).Index)
                objproveedor.AddDomicilio(frmDomicilio.DataSource)
                facDomicilio.CargarDomicilioEnGrilla(frmDomicilio.DataSource, dgvDomicilios)
            End If
        End If
    End Sub

    Private Sub cmdModifProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModifProveedor.Click
        '************ VALIDO LOS DATOS INGRESADOS
        If txtNombre.Text.Length = 0 Then
            MessageBox.Show("Debe ingresar el nombre del proveedor", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Select()
            Exit Sub
        End If


        objproveedor.CUIT = "0000000000000"
        objproveedor.FechaAlta = dtpFechaAlta.Value
        objproveedor.RazonSocial = txtNombre.Text
        objproveedor.IdRubro = CType(cmbRubro.SelectedItem, Rubro).IdRubro
        objproveedor.Lista = txtLista.Text
        objproveedor.Bonificaciones = txtBonificaciones.Text
        objproveedor.Email = txtEmail.Text

        facEnte.ModificarProveedor(objproveedor)

        MessageBox.Show("El proveedor se ha modificado al sistema exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objproveedor = New Proveedor
        Me.Close()
    End Sub

    Private Sub cmdAgregarRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarRubro.Click
        Dim rubro As String
        rubro = InputBox("Ingrese el Rubro")
        If rubro.Trim.Length <> 0 Then
            facRubro.altaRubro(rubro)
            cmbRubro.DataSource = facRubro.listarRubros
        End If
    End Sub


    Private Sub dgvTelefonos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTelefonos.SelectionChanged
        If dgvTelefonos.Rows.Count - 1 = dgvTelefonos.CurrentRow.Index Or saltearSeleccion Then Exit Sub
        Dim tel As Telefono
        Dim ClaveTelefono As String
        ClaveTelefono = dgvTelefonos.Rows.Item(dgvTelefonos.CurrentRow.Index).Cells(1).Value
        tel = objproveedor.Telefonos(ClaveTelefono)
        txtNombreContacto.Text = tel.NombreContacto
        txtTelefono.Text = tel.Numero
        For Each tt As TipoTelefono In cmbTipoTelefono.Items
            If tt.IdTipoTelefono = tel.IdTipoTelefono Then
                cmbTipoTelefono.SelectedItem = tt
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        e.Handled = Not Validar.EsLetra(e.KeyChar.ToString())
    End Sub
    Private Sub txtNombreContacto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreContacto.KeyPress
        e.Handled = Not Validar.EsLetra(e.KeyChar.ToString())
    End Sub

    Private Sub txtNombreContacto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreContacto.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

End Class