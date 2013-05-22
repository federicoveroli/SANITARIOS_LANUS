Imports Fachada
Imports Modelo
Public Class frmBitacora
    Dim facUsu As New FachadaUsuario

    Private Sub frmBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUsuario.DataSource = facUsu.listarUsuarios()
        cmbUsuario.DisplayMember = "nick"
        cmbUsuario.SelectedIndex = 0
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
        dgvBitacora.DataSource = ""
        Dim faca As New FachadaBitacora
        Dim xx As String
        xx = cmbUsuario.Text
        Dim dt As DataTable
        dt = faca.TraerXnick(xx)
        dgvBitacora.DataSource = dt
        dgvBitacora.Columns(0).Width = 95
        dgvBitacora.Columns(1).Width = 100
        dgvBitacora.Columns(2).Width = 431
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdesde.ValueChanged
        Dim fac As New FachadaBitacora
        dgvBitacora.DataSource = fac.ListarBitacorasXfecha(dtpdesde.Value, dtphasta.Value)
    End Sub

    Private Sub dtp2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphasta.ValueChanged
        Dim fac As New FachadaBitacora
        dgvBitacora.DataSource = fac.ListarBitacorasXfecha(dtpdesde.Value, dtphasta.Value)
    End Sub
End Class