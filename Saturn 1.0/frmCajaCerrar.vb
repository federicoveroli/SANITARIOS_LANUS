Imports Modelo
Imports Fachada

Public Class frmCajaCerrar
    Dim cierre As CierreCaja
    Dim ff As New FachadaFactura
    Dim fcd As New FachadaCajaDiaria
    Dim vAcepto As Boolean

    Public ReadOnly Property Acepto() As Boolean
        Get
            Return vAcepto
        End Get
    End Property

    Public Property DataSource() As CierreCaja
        Get
            Return cierre
        End Get
        Set(ByVal value As CierreCaja)
            cierre = value
            txtCantTarjReal.Text = cierre.CantTarjetaReal
            txtCantTarj.Text = cierre.CantTarjetaEstimado
            txtTotalTarjReal.Text = cierre.TotalTarjetaReal
            txtTotalTarjeta.Text = cierre.TotalTarjetaEstimado
            txtEfectivo.Text = cierre.EfvoEstimado
            txtEfectivoReal.Text = cierre.EfvoReal
            txtHora.Text = cierre.Hora
            txtFecha.Text = cierre.Fecha.ToShortDateString
            txtTicket.Text = cierre.NroUltimoTicket
            txtTotalCaja.Text = cierre.TotalTarjetaEstimado
            txtTotalReal.Text = cierre.TotalCajaReal
            If cierre.EsFinal Then
                cmbTipoCierre.SelectedIndex = 0
            Else
                cmbTipoCierre.SelectedIndex = 1
            End If
        End Set
    End Property

    Private Sub frmCajaCerrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Public Sub LimpiarCasillas()
        txtEfectivoReal.Text = ""
        txtTotalReal.Text = ""
        txtCantTarjReal.Text = ""
        txtEfectivoReal.BackColor = Color.White
        txtTotalTarjReal.BackColor = Color.White
        txtCantTarjReal.BackColor = Color.White
    End Sub
    Private Sub frmCajaCerrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToShortTimeString
        txtTicket.Text = ff.TraerMaxIDVenta()
        Dim efec As Double, tarj As Double
        efec = Math.Round(fcd.TraerRecaudacionEfectivoCajero() + fcd.TraerMontoApertura(), 2)
        tarj = Math.Round(fcd.TraerRecaudacionTarjetasEnCaja(), 2)
        txtEfectivo.Text = efec
        txtTotalTarjeta.Text = tarj
        txtTotalCaja.Text = efec + tarj
        txtCantTarj.Text = fcd.TraerCantidadVentasConTarjetaEnCaja()
        cierre = New CierreCaja
        vAcepto = False
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If cmbTipoCierre.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el tipo de cierre", "Cierre de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbTipoCierre.Focus()
            Exit Sub
        End If
        If txtEfectivoReal.Text.Length = 0 Or txtCantTarjReal.Text.Length = 0 Or txtTotalTarjReal.Text.Length = 0 Then
            MessageBox.Show("Debe cargar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEfectivoReal.Focus()
            Exit Sub
        End If

        With cierre
            .EsFinal = cmbTipoCierre.SelectedIndex
            .NroUltimoTicket = txtTicket.Text
            .Hora = txtHora.Text
            .Fecha = txtFecha.Text
            .EfvoReal = txtEfectivoReal.Text
            .EfvoEstimado = txtEfectivo.Text
            .CantTarjetaReal = txtCantTarj.Text
            .CantTarjetaEstimado = txtCantTarjReal.Text
            .TotalTarjetaReal = txtTotalTarjReal.Text
            .TotalTarjetaEstimado = txtTotalTarjeta.Text
            .TotalCajaReal = txtTotalReal.Text
            .TotalCajaEstimado = txtTotalCaja.Text
            .IdCajaDiaria = fcd.MaxID()
            .IdUltOperacion = fcd.MaxIDOperacion()
            .NickUsuario = Sesion.getSesion.UsuarioActivo.Nick
        End With
        Dim fCierre As New FachadaCierreCaja
        fCierre.AltaCierreCaja(cierre)
        MessageBox.Show("Se realizó un cierre " & cmbTipoCierre.Text & " de caja", "Cierre realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        vAcepto = True
        Me.Hide()

    End Sub





    Private Sub txtEfectivoReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivoReal.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtCantTarjReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantTarjReal.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

    Private Sub txtTotalTarjReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalTarjReal.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())

    End Sub

    Private Sub txtTotalReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalReal.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtTotalTarjReal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalTarjReal.TextChanged
        If txtTotalTarjReal.Text <> txtTotalTarjeta.Text Then
            txtTotalTarjReal.BackColor = Color.Red
            txtTotalTarjReal.ForeColor = Color.White
        Else
            txtTotalTarjReal.BackColor = Color.LightGreen
            txtTotalTarjReal.ForeColor = Color.Black
        End If
        If txtTotalTarjReal.Text.Length = 0 Or txtEfectivoReal.Text.Length = 0 Then Exit Sub
        txtTotalReal.Text = CDbl(txtTotalTarjReal.Text) + CDbl(txtEfectivoReal.Text)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        vAcepto = False
        Me.Hide()
    End Sub

    Private Sub cmbTipoCierre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCierre.SelectedIndexChanged
        If cmbTipoCierre.SelectedIndex = 1 Then
            lblCierreFinal.Visible = True
        Else
            lblCierreFinal.Visible = False
        End If
    End Sub

    Private Sub txtEfectivoReal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEfectivoReal.TextChanged
        If txtEfectivoReal.Text <> txtEfectivo.Text Then
            txtEfectivoReal.BackColor = Color.Red
            txtEfectivoReal.ForeColor = Color.White
        Else
            txtEfectivoReal.BackColor = Color.LightGreen
            txtEfectivoReal.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCantTarjReal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantTarjReal.TextChanged
        If txtCantTarjReal.Text <> txtCantTarj.Text Then
            txtCantTarjReal.BackColor = Color.Red
            txtCantTarjReal.ForeColor = Color.White
        Else
            txtCantTarjReal.BackColor = Color.LightGreen
            txtCantTarjReal.ForeColor = Color.Black
        End If
    End Sub
End Class