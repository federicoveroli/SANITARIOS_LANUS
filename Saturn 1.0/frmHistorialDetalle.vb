Imports Fachada
Imports Modelo

Public Class frmHistorialDetalle
    Dim cierre As CierreCaja
    Dim ff As New FachadaFactura
    Dim fcc As New FachadaCierreCaja
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
            txtDifTarjeta.Text = cierre.TotalTarjetaEstimado - cierre.TotalTarjetaReal
            txtEfectivo.Text = cierre.EfvoEstimado
            txtEfectivoReal.Text = cierre.EfvoReal
            txtDifEfectivo.Text = cierre.EfvoEstimado - cierre.EfvoReal
            txtDifTotal.Text = CDbl(txtDifTarjeta.Text) + CDbl(txtDifEfectivo.Text)
            txtHora.Text = cierre.Hora
            txtFecha.Text = cierre.Fecha.ToShortDateString
            txtTicket.Text = cierre.NroUltimoTicket
            txtTotalCaja.Text = cierre.TotalCajaEstimado
            txtTotalReal.Text = cierre.TotalCajaReal
            txtDifTotal.BackColor = Color.White

            If CDbl(txtDifEfectivo.Text) > 0 Then
                txtDifEfectivo.BackColor = Color.OrangeRed
                txtDifTotal.BackColor = Color.OrangeRed
            Else
                txtDifEfectivo.BackColor = Color.White
            End If

            If CDbl(txtDifTarjeta.Text) > 0 Then
                txtDifTarjeta.BackColor = Color.OrangeRed
                txtDifTotal.BackColor = Color.OrangeRed
            Else
                txtDifTarjeta.BackColor = Color.White
            End If

            If cierre.EsFinal Then
                cmbTipoCierre.SelectedIndex = 1
            Else
                cmbTipoCierre.SelectedIndex = 0
            End If
            dgvDetallesCaja.DataSource = fcc.TrearVentasPorCierre(cierre)
            dgvOperaciones.DataSource = fcc.TraerOperacionesPorCierre(cierre)
            txtVentasEfectivo.Text = fcc.TraerTotalVentasEfectivo(cierre)
            txtVentasTarjeta.Text = fcc.TraerTotalVentasTarjeta(cierre)
            txtVentasTotal.Text = CDbl(txtVentasEfectivo.Text) + CDbl(txtVentasTarjeta.Text)
        End Set
    End Property

End Class