Public Class Form1
    Private Sub SalirF7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirF7ToolStripMenuItem.Click
        End
    End Sub

    Private Sub ABMArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMArticulosToolStripMenuItem.Click
        FrmArticuloAlta.MdiParent = Me
        FrmArticuloAlta.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        FrmArticuloBuscar.MdiParent = Me
        FrmArticuloBuscar.Show()
        FrmArticuloBuscar.grupoRenglon.Visible = False
        FrmArticuloBuscar.cmdModificar.Visible = False
        FrmArticuloBuscar.cmdBaja.Visible = False
        FrmArticuloBuscar.grupoRenglon.Visible = False
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem.Click
        FrmArticuloBuscar.MdiParent = Me
        FrmArticuloBuscar.Show()
        FrmArticuloBuscar.cmdBaja.Visible = True
        FrmArticuloBuscar.cmdModificar.Visible = False
        FrmArticuloBuscar.grupoRenglon.Visible = False

    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem.Click
        FrmArticuloBuscar.MdiParent = Me
        FrmArticuloBuscar.Show()
        FrmArticuloBuscar.grupoRenglon.Visible = False
        FrmArticuloBuscar.cmdModificar.Visible = True
        FrmArticuloBuscar.cmdBaja.Visible = False

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        FrmClienteAlta.MdiParent = Me
        FrmClienteAlta.Show()

    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem1.Click
        FrmClienteBuscar.MdiParent = Me
        FrmClienteBuscar.Show()
        FrmClienteBuscar.cmdBaja.Visible = False
        FrmClienteBuscar.cmdModificar.Visible = False

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        FrmClienteBuscar.MdiParent = Me
        FrmClienteBuscar.Show()
        FrmClienteBuscar.cmdBaja.Visible = False
        FrmClienteBuscar.cmdModificar.Visible = True
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        FrmClienteBuscar.MdiParent = Me
        FrmClienteBuscar.Show()
        FrmClienteBuscar.cmdBaja.Visible = True
        FrmClienteBuscar.cmdModificar.Visible = False
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        frmProveedorAlta.MdiParent = Me
        frmProveedorAlta.Show()
    End Sub

    Private Sub BajaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem2.Click
        frmProveedorBuscar.MdiParent = Me
        frmProveedorBuscar.Show()
        frmProveedorBuscar.cmdBaja.Visible = True
        frmProveedorBuscar.cmdModificar.Visible = False
    End Sub

    Private Sub ModificacionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem1.Click
        frmProveedorBuscar.MdiParent = Me
        frmProveedorBuscar.Show()
        frmProveedorBuscar.cmdBaja.Visible = False
        frmProveedorBuscar.cmdModificar.Visible = True
    End Sub

    Private Sub BuscarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem2.Click
        frmProveedorBuscar.MdiParent = Me
        frmProveedorBuscar.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        frmBitacora.MdiParent = Me
        frmBitacora.Show()
    End Sub

    Private Sub FacturaciónF4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónF4ToolStripMenuItem.Click
        ''''FrmFacturacion.MdiParent = Me
        FrmFacturacion.Show()
    End Sub

    Private Sub CargarCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarCompraToolStripMenuItem.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub
End Class
