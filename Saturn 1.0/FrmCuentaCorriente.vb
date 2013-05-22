Imports Fachada
Imports Modelo
Public Class FrmCuentaCorriente
    Dim facCLiente As New FachadaCliente
    Private Sub picBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBuscar.Click
        FrmClienteBuscar.cmdSeleccionar.Visible = True
        FrmClienteBuscar.cmdSeleccionar.Visible = True
        'frmProveedorBuscar.MdiParent = FrmPrincipal
        FrmClienteBuscar.ShowDialog()
        If FrmClienteBuscar.idClienteSeleccionado = 0 Then Exit Sub
        For Each clie As IdCliente In CboIngreseCliente.Items
            If clie.Id = FrmClienteBuscar.idClienteSeleccionado Then
                CboIngreseCliente.SelectedItem = clie
            End If
        Next
    End Sub

    Private Sub FrmCuentaCorriente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub FrmCuentaCorriente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facCLiente.CargarCombo(CboIngreseCliente)
    End Sub

    Private Sub CboIngreseCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboIngreseCliente.SelectedIndexChanged
        Dim id As IdCliente
        id = CType(CboIngreseCliente.SelectedItem, IdCliente)

        Dim parametro As Integer
        Dim fachas As New FachadaCliente
        parametro = id.Id
        Dim dt As DataTable = fachas.TraerLimite(parametro)

        Dim fac As New FachadaFactura
        dgvFacCtaCte.DataSource = fac.ListarFacturasEnCuentaCorriente(parametro)
        txtLimite.Text = dt.Columns(0).Table.Rows(0).Item(0)

        Dim n As Integer
        n = dgvFacCtaCte.Rows.Count - 1
        Dim total As Double
        total = 0
        Dim i As Integer = 0
        If n = 0 Then
            lblDEUDADAAAA.Text = 0
        Else
            For i = 0 To n
                total = Math.Round(total + dgvFacCtaCte.Rows(i).Cells(3).Value, 2)
            Next
        End If
        Dim fachada3 As New FachadaFactura
        Dim dta As DataTable
        dta = fachada3.SumarPagos(id.Id)
        Dim montoPagado As Double
        montoPagado = 0
        If Not IsDBNull(dta.Rows(0).Item(0)) Then
            montoPagado = dta.Rows(0).Item(0)
        End If
        lblDEUDADAAAA.Text = total - montoPagado
    End Sub
    Private Sub dgvFacCtaCte_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFacCtaCte.SelectionChanged
        Dim TotalDeudaDeFactura As Double = 0
        Try
            txtPago.Text = 0
            txtSaldo.Text = "0"
            txtNumFac.Text = ""

            dgvDetallesCtaCte.DataSource = ""
            txtNumFac.Text = dgvFacCtaCte.SelectedRows(0).Cells(0).Value

            Dim fac As New FachadaFactura
            dgvDetallesCtaCte.DataSource = fac.ListarFacturasDetalles(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
            Calcular()

            txtPago.Text = txtSaldo.Text
        Catch ex As Exception
        End Try

      
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtNumFac.Text = "" Or txtPago.Text = "" Then
            MsgBox("Debe completar los campos requeridos !")
            Exit Sub
        Else
            Dim fac As New FachadaFactura
            Dim objeto As New Pago

            Dim id As IdCliente
            id = CType(CboIngreseCliente.SelectedItem, IdCliente)
            Dim parametro As Integer
            parametro = id.Id

            Dim dt As DataTable = fac.ListarFacturasEnCuentaCorriente(parametro)
            Dim facaa As New FachadaFactura
            facaa.TraerIds(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
            objeto.NumFac = facaa.TraerIds(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
            objeto.Fecha = dtpFecha.Text
            objeto.Pago = txtPago.Text
            'Verifico si el pago supera la deuda
            If CDbl(txtPago.Text) > CDbl(txtSaldo.Text) Then
                MsgBox("El maximo a ingresar es: " & txtSaldo.Text, MsgBoxStyle.Exclamation, "Verifique el valor ingresado")
                txtPago.Text = txtSaldo.Text
                Exit Sub
            End If
            Dim faca As New FachadaFactura
            faca.InsertarPago(objeto)
            Dim ope As New OperacionCaja
            ope.Operacion = True
            ope.Monto = objeto.Pago
            ope.Descripcion = "Deposito en cuenta corriente de " & CboIngreseCliente.Text
            ope.Fecha = Date.Now
            Dim FacCajaDiaria As New FachadaCajaDiaria
            FacCajaDiaria.RealizarOperacion(ope)
            Try
                Dim fac2 As New FachadaFactura
                dgvDetallesCtaCte.DataSource = fac2.ListarFacturasDetalles(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
                MsgBox("Se ha ingresado pago exitosamente !", MsgBoxStyle.Information, "Pago realizado")
                txtPago.Text = ""
                Calcular()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error inesperado", MsgBoxStyle.Critical, "Error")
            End Try
        End If

        If CDbl(txtSaldo.Text) <= 0 Then
            Dim fac As New FachadaFactura
            fac.FacturaPagadaCompletamente(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
            Dim fac2 As New FachadaFactura
            dgvDetallesCtaCte.DataSource = fac2.ListarFacturasDetalles(txtNumFac.Text, dgvFacCtaCte.SelectedRows(0).Cells(1).Value)
            Dim fac3 As New FachadaFactura
            Dim parametro As Integer
            Dim id As IdCliente
            id = CType(CboIngreseCliente.SelectedItem, IdCliente)
            parametro = id.Id
            dgvFacCtaCte.DataSource = fac.ListarFacturasEnCuentaCorriente(parametro)
        End If
        CboIngreseCliente_SelectedIndexChanged(sender, e)
    End Sub
    Public Sub Calcular()
        Dim n As Integer
        n = dgvDetallesCtaCte.Rows.Count - 1
        Dim total As Double
        total = 0
        Dim i As Integer
        For i = 0 To n
            total = total + dgvDetallesCtaCte.Rows(i).Cells(3).Value
        Next
        txtSaldo.Text = Math.Round(dgvFacCtaCte.SelectedRows(0).Cells(3).Value - total, 2)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPago.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtNumFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumFac.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

    Private Sub dgvFacCtaCte_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacCtaCte.CellContentClick

    End Sub
End Class