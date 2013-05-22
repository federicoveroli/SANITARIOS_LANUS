Imports Fachada
Imports Modelo

Public Class FrmCajaDiaria
    Dim facCajaDiaria As New FachadaCajaDiaria
    Dim facCierreCaja As New FachadaCierreCaja
    Dim fachhh As New FachadaBitacora

    Private Sub cmdAbrirCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirCaja.Click
        Dim caja As New CajaDiaria
        If txtMontoInicial.Text = "" Then
            MessageBox.Show("Debe ingresar el monto inicial de la caja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMontoInicial.Text = "0"
            Exit Sub
        End If
        Dim saldoInicial As Double, saldoAnterior As Double
        saldoInicial = txtMontoInicial.Text
        'saldoAnterior = txtEstado.Text
        'If saldoInicial < saldoAnterior Then
        '    MessageBox.Show("El monto inicial debe ser mayor o igual al estado de la caja" & vbCr & "Operación cancelada. ", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        caja.SaldoInicial = txtMontoInicial.Text
        caja.Fecha = CDate(Date.Now)
        facCajaDiaria.AbrirCajaDiaria(caja)
        fachhh.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, "Se abrió la caja con: $ " & caja.SaldoInicial)
        cmdAbrirCaja.Enabled = False
        cmdCerrarCaja.Enabled = True
        cmdRealizarOperacion.Enabled = True
        ActualizarEstado()

    End Sub


    Public Sub cmdCerrarCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarCaja.Click
        Dim caja As New CajaDiaria

        If MessageBox.Show("Realmente desea cerrar la caja?" & vbCr & "Nota: una vez cerrada, quedará grabado el ingreso diario", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frmCajaCerrar.LimpiarCasillas()
            frmCajaCerrar.ShowDialog()
            If frmCajaCerrar.Acepto Then
                If frmCajaCerrar.DataSource.EsFinal Then
                    caja = facCajaDiaria.TraerUltimaCaja()
                    'caja.SaldoInicial = facCajaDiaria.CalcularSaldoFinal()
                    caja.Cierre = frmCajaCerrar.DataSource.EfvoReal
                    'calculo el total de retiros realizados
                    Dim totalRetiros As Double, totalDepositos As Double
                    totalRetiros = 0
                    totalDepositos = 0
                    For Each fila As DataGridViewRow In dgvOperaciones.Rows
                        If fila.Cells(2).Value = False Then
                            totalRetiros += fila.Cells(3).Value
                        Else
                            totalDepositos += fila.Cells(3).Value
                        End If
                    Next
                    caja.TotalDeposito = totalDepositos
                    caja.TotalRetiro = totalRetiros
                    caja.TotalTarjeta = frmCajaCerrar.txtTotalTarjReal.Text
                    facCajaDiaria.CerrarCaja(caja)
                    cmdCerrarCaja.Enabled = False
                    cmdRealizarOperacion.Enabled = False
                    fachhh.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, "Se cerró la caja correctamente!")

                    ActualizarEstado()
                    'cmdAbrirCaja.Enabled = True


                    cmdAbrirCaja_Click(sender, e)


                    'If CierreCaja.EsFinal Then
                    '    'si el cierre es final abro una nueva caja diaria, con monto inicial el efectivo real del cierre
                    '    Dim caja As New CajaDiaria
                    '    Dim fcd As New FachadaCajaDiaria
                    '    caja.SaldoInicial = CierreCaja.EfvoReal
                    '    caja.Fecha = CDate(Date.Now)
                    '    fcd.AbrirCajaDiaria(caja)
                    'End If
                End If
            End If

        End If



    End Sub

    Private Sub FrmCajaDiaria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub FrmCajaDiaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmdAbrirCaja.Enabled = Not facCajaDiaria.estaAbierta()
        cmdCerrarCaja.Enabled = Not cmdAbrirCaja.Enabled
        cmdRealizarOperacion.Enabled = cmdCerrarCaja.Enabled
        dgvOperaciones.DataSource = facCajaDiaria.ListarOperaciones()
        'traigo las ventas realizadas 
        dgvDetallesCaja.DataSource = facCajaDiaria.ListarFacturas()
        ActualizarEstado()

    End Sub

    Private Sub cmdRealizarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRealizarOperacion.Click
        Dim ope As New OperacionCaja
        If txtMonto.Text = "" Then
            MsgBox("Debe ingresar el monto de la operaciòn", MsgBoxStyle.Exclamation, "Campos incompletos")
            Exit Sub
        End If
        ope.Operacion = RadioDeposito.Checked
        ope.Monto = txtMonto.Text
        ope.Descripcion = txtDescripcion.Text
        ope.Fecha = Date.Now
        facCajaDiaria.RealizarOperacion(ope)
        dgvOperaciones.DataSource = facCajaDiaria.ListarOperaciones()

        ActualizarEstado()
        Dim operacion As String = "deposito"
        If RadioExtraccion.Checked Then
            operacion = "extracción"
        End If


        fachhh.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, "Se realizó una operación de " & operacion & " de: $ " & ope.Monto & " - " & ope.Descripcion)
        txtDescripcion.Text = ""
        txtMonto.Text = ""
        ActualizarEstado()

    End Sub
    Private Sub ActualizarEstado()
        'Traigo el total en efectivo en tarjeta y en total.
        Dim montoTarjeta As Double, montoEfectivo As Double
        Dim efec As Double, tarj As Double
        Dim vtasEfectivo As Double = 0, vtasTarjeta As Double = 0
       
        If facCajaDiaria.estaAbierta() Then

            'recorro las ventas y sumo las efectivo y tarjeta
            'For Each fila As DataGridViewRow In dgvDetallesCaja.Rows
            '    If fila.Cells(2).Value.Equals("E") Then
            '        vtasEfectivo += CDbl(fila.Cells(3).Value)
            '    Else
            '        vtasTarjeta += CDbl(fila.Cells(3).Value)
            '    End If
            'Next
            vtasEfectivo = facCajaDiaria.TraerVentasConEfectivo
            vtasTarjeta = facCajaDiaria.TraerVentasConTarjeta
            txtEfectivoCaja.Text = Math.Round(vtasEfectivo, 2)
            txtTarjetaCaja.Text = Math.Round(vtasTarjeta, 2)
            txtTotalCaja.Text = Math.Round(vtasEfectivo + vtasTarjeta, 2)
            txtMontoInicial.Text = Math.Round(facCajaDiaria.TraerMontoApertura(), 2)
            txtMontoApertura.Text = Math.Round(facCajaDiaria.TraerMontoApertura(), 2)
            montoTarjeta = facCajaDiaria.TraerVentasConTarjetaCajero()
            montoEfectivo = facCajaDiaria.TraerVentasEfectivoCajero
            txtVentasEfectivo.Text = Math.Round(montoEfectivo, 2)
            txtVentasTarjeta.Text = Math.Round(montoTarjeta, 2)
            txtVentasTotal.Text = (montoEfectivo + montoTarjeta)
            efec = Math.Round(facCajaDiaria.TraerRecaudacionEfectivoEnCaja + facCajaDiaria.TraerMontoApertura(), 2)
            tarj = Math.Round(facCajaDiaria.TraerRecaudacionTarjetasEnCaja(), 2)
            txtEfectivo.Text = efec
            txtTarjeta.Text = tarj
            txtTotal.Text = efec + tarj

        Else
            'en el monto inicial pongo el monto final de la caja anterior de la parte de efectivo.
            Dim cierre As CierreCaja
            cierre = facCierreCaja.TraerUltimoCierreCaja
            txtMontoInicial.Text = cierre.EfvoReal
            txtMontoApertura.Text = "0"
            txtVentasEfectivo.Text = "0"
            txtVentasTarjeta.Text = "0"
            txtEfectivo.Text = "0"
            txtTarjeta.Text = "0"
            txtTotal.Text = "0"
            txtVentasTotal.Text = "0"
        End If
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtMontoInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoInicial.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class