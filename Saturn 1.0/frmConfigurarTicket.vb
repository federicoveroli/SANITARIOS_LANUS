Imports Fachada
Imports Modelo

Public Class frmConfigurarTicket
    Dim ticket As InfoTicket
    Dim ft As FachadaInfoTicket

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        ticket = New InfoTicket
        ticket.Encabezado1 = txtEncabezado1.Text
        ticket.Encabezado2 = txtEncabezado2.Text
        ticket.Encabezado3 = txtEncabezado3.Text
        ticket.Encabezado4 = txtEncabezado4.Text
        ticket.Encabezado5 = txtEncabezado5.Text
        ticket.Pie1 = txtPie1.Text
        ticket.Pie2 = txtPie2.Text
        ticket.Pie3 = txtPie3.Text
        ticket.Pie4 = txtPie4.Text
        ticket.Pie5 = txtPie5.Text
        ft.GuardarInfoTicket(ticket)
        MessageBox.Show("La información ha sido guardada correctamente", "Grabación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmConfigurarTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ft = New FachadaInfoTicket
        ticket = ft.TraerInfoTicket
        txtEncabezado1.Text = ticket.Encabezado1
        txtEncabezado2.Text = ticket.Encabezado2
        txtEncabezado3.Text = ticket.Encabezado3
        txtEncabezado4.Text = ticket.Encabezado4
        txtEncabezado5.Text = ticket.Encabezado5
        txtPie1.Text = ticket.Pie1
        txtPie2.Text = ticket.Pie2
        txtPie3.Text = ticket.Pie3
        txtPie4.Text = ticket.Pie4
        txtPie5.Text = ticket.Pie5

    End Sub
End Class