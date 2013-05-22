Imports Fachada
Imports System.Text

Public Class FrmPrincipal
    Dim objFrmAriculoAlta As FrmArticuloAlta
    Dim objfrmArticuloBuscar As FrmArticuloBuscar
    Dim objfrmBackup As frmBackup
    Dim objfrmBitacora As frmBitacora
    Dim objfrmCajaDiaria As FrmCajaDiaria
    Dim objfrmClienteAlta As FrmClienteAlta
    Dim objfrmClienteBuscar As FrmClienteBuscar
    Dim objfrmCompras As frmCompras
    Dim objfrmCuentaCorriente As FrmCuentaCorriente
    Dim objfrmFacturacion As FrmFacturacion
    Dim objfrmLogin As frmLogin
    Dim objPermiso As frmPermiso
    Dim objProveedorAlta As frmProveedorAlta
    Dim objfrmproveedorBuscar As frmProveedorBuscar
    Dim objUsuario As frmUsuario
    Dim objFrmArticuloReemplazar As FrmArticuloReemplazar
    Dim objFrmComprasBuscar As frmComprasBuscar
    Dim objFrmHistorialCaja As frmHistorialCajaDiaria
    Dim facCajaDiaria As New Fachada.FachadaCajaDiaria
    Dim objFrmArchivarFacturas As FrmArchivarFacturas
    Dim objFrmFacturasArchivadas As frmVerFacturasArchivadas
    Dim objFrmArticulosModificarAumentar As FrmArticulosModificarAumentar
    Dim fa As New FachadaArticulo

    Public Sub CargarPermisos()
        Dim cp As New CargadorDePermisos
        cp.HabilitarMenu(MenuStrip1.Items)
    End Sub

    Private Sub SalirF7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirF7ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ABMArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMArticulosToolStripMenuItem.Click
        If Not IsNothing(objFrmAriculoAlta) Then
            objFrmAriculoAlta.Dispose()
        End If
        objFrmAriculoAlta = New FrmArticuloAlta
        objFrmAriculoAlta.MdiParent = Me
        objFrmAriculoAlta.Show()
        ''frmMigrarArticulos.Show() ''despues BORRAARRRRRRRRRRRR
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        If Not IsNothing(objfrmArticuloBuscar) Then
            objfrmArticuloBuscar.Dispose()
        End If
        objfrmArticuloBuscar = New FrmArticuloBuscar
        'objfrmArticuloBuscar.MdiParent = Me
        objfrmArticuloBuscar.WindowState = FormWindowState.Maximized
        objfrmArticuloBuscar.grupoRenglon.Visible = False
        objfrmArticuloBuscar.cmdModificar.Visible = False
        objfrmArticuloBuscar.cmdBaja.Visible = False
        objfrmArticuloBuscar.grupoRenglon.Visible = False
        objfrmArticuloBuscar.Show()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem.Click
        If Not IsNothing(objfrmArticuloBuscar) Then
            objfrmArticuloBuscar.Dispose()
        End If
        objfrmArticuloBuscar = New FrmArticuloBuscar

        objfrmArticuloBuscar.MdiParent = Me
        objfrmArticuloBuscar.Show()
        objfrmArticuloBuscar.cmdBaja.Visible = True
        objfrmArticuloBuscar.cmdModificar.Visible = False
        objfrmArticuloBuscar.grupoRenglon.Visible = False


    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem.Click
        If Not IsNothing(objfrmArticuloBuscar) Then
            objfrmArticuloBuscar.Dispose()
        End If
        objfrmArticuloBuscar = New FrmArticuloBuscar
        objfrmArticuloBuscar.GroupBox1.Visible = True
        objfrmArticuloBuscar.MdiParent = Me
        objfrmArticuloBuscar.Show()
        objfrmArticuloBuscar.grupoRenglon.Visible = False
        objfrmArticuloBuscar.cmdModificar.Visible = True
        objfrmArticuloBuscar.cmdBaja.Visible = True


    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        If Not IsNothing(objfrmClienteAlta) Then
            objfrmClienteAlta.Dispose()
        End If
        objfrmClienteAlta = New FrmClienteAlta

        objfrmClienteAlta.MdiParent = Me
        objfrmClienteAlta.cmdModifCliente.Visible = False
        objfrmClienteAlta.cmdAceptar.Visible = True
        objfrmClienteAlta.Show()

    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem1.Click
        If Not IsNothing(objfrmClienteBuscar) Then
            objfrmClienteBuscar.Dispose()
        End If
        objfrmClienteBuscar = New FrmClienteBuscar

        objfrmClienteBuscar.MdiParent = Me
        objfrmClienteBuscar.Show()
        objfrmClienteBuscar.cmdBaja.Visible = False
        objfrmClienteBuscar.cmdModificar.Visible = False
        objfrmClienteBuscar.cmdSeleccionar.Visible = False

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If Not IsNothing(objfrmClienteBuscar) Then
            objfrmClienteBuscar.Dispose()
        End If
        objfrmClienteBuscar = New FrmClienteBuscar

        objfrmClienteBuscar.MdiParent = Me
        objfrmClienteBuscar.Show()
        objfrmClienteBuscar.cmdBaja.Visible = False
        objfrmClienteBuscar.cmdModificar.Visible = True
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        If Not IsNothing(objfrmClienteBuscar) Then
            objfrmClienteBuscar.Dispose()
        End If
        objfrmClienteBuscar = New FrmClienteBuscar

        objfrmClienteBuscar.MdiParent = Me
        objfrmClienteBuscar.Show()
        objfrmClienteBuscar.cmdBaja.Visible = True
        objfrmClienteBuscar.cmdModificar.Visible = False
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        If Not IsNothing(objProveedorAlta) Then
            objProveedorAlta.Dispose()
        End If
        objProveedorAlta = New frmProveedorAlta

        objProveedorAlta.MdiParent = Me
        objProveedorAlta.Show()
    End Sub

    Private Sub BajaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem2.Click
        If Not IsNothing(objfrmproveedorBuscar) Then
            objfrmproveedorBuscar.Dispose()
        End If
        objfrmproveedorBuscar = New frmProveedorBuscar

        objfrmproveedorBuscar.MdiParent = Me
        objfrmproveedorBuscar.Show()
        objfrmproveedorBuscar.cmdBaja.Visible = True
        objfrmproveedorBuscar.cmdModificar.Visible = False
    End Sub

    Private Sub ModificacionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem1.Click
        If Not IsNothing(objfrmproveedorBuscar) Then
            objfrmproveedorBuscar.Dispose()
        End If
        objfrmproveedorBuscar = New frmProveedorBuscar

        objfrmproveedorBuscar.MdiParent = Me
        objfrmproveedorBuscar.Show()
        objfrmproveedorBuscar.cmdBaja.Visible = False
        objfrmproveedorBuscar.cmdModificar.Visible = True
    End Sub

    Private Sub BuscarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem2.Click
        If Not IsNothing(objfrmproveedorBuscar) Then
            objfrmproveedorBuscar.Dispose()
        End If
        objfrmproveedorBuscar = New frmProveedorBuscar
        objfrmproveedorBuscar.MdiParent = Me
        objfrmproveedorBuscar.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        If Not IsNothing(objfrmBitacora) Then
            objfrmBitacora.Dispose()
        End If
        objfrmBitacora = New frmBitacora

        objfrmBitacora.MdiParent = Me
        objfrmBitacora.Show()
    End Sub

    Private Sub CargarCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarCompraToolStripMenuItem.Click
        If Not IsNothing(objfrmCompras) Then
            objfrmCompras.Dispose()
        End If
        objfrmCompras = New frmCompras

        objfrmCompras.MdiParent = Me
        objfrmCompras.Show()
    End Sub


    Private Sub CuentasCorrientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasCorrientesToolStripMenuItem.Click
        If Not IsNothing(objfrmCuentaCorriente) Then
            objfrmCuentaCorriente.Dispose()
        End If
        objfrmCuentaCorriente = New FrmCuentaCorriente

        objfrmCuentaCorriente.MdiParent = Me
        objfrmCuentaCorriente.Show()
    End Sub

    Private Sub CajaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaDiariaToolStripMenuItem.Click
        If Not IsNothing(objfrmCajaDiaria) Then
            objfrmCajaDiaria.Dispose()
        End If
        objfrmCajaDiaria = New FrmCajaDiaria

        objfrmCajaDiaria.MdiParent = Me
        objfrmCajaDiaria.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionToolStripMenuItem.Click
        If Not IsNothing(objfrmFacturacion) Then
            objfrmFacturacion.Dispose()
        End If
        objfrmFacturacion = New FrmFacturacion
        objfrmFacturacion.MdiParent = Me
        objfrmFacturacion.Show()
    End Sub

    Private Sub BackupYRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupYRestoreToolStripMenuItem.Click
        If Not IsNothing(objfrmBackup) Then
            objfrmBackup.Dispose()
        End If
        objfrmBackup = New frmBackup

        objfrmBackup.MdiParent = Me
        objfrmBackup.Show()
    End Sub

    Private Sub AdministracionDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministracionDeUsuariosToolStripMenuItem.Click
        If Not IsNothing(objUsuario) Then
            objUsuario.Dispose()
        End If
        objUsuario = New frmUsuario

        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub

    Private Sub AsignacionDePermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignacionDePermisosToolStripMenuItem.Click
        If Not IsNothing(objPermiso) Then
            objPermiso.Dispose()
        End If
        objPermiso = New frmPermiso

        objPermiso.MdiParent = Me
        objPermiso.Show()
    End Sub



    Private Sub FrmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If facCajaDiaria.estaAbierta() = True Then
            If facCajaDiaria.estaCerrada(Date.Now) = False Then
                If MessageBox.Show("La caja se encuentra abierta, desea cerrarla?", "Caja abierta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    FrmCajaDiaria.ShowDialog()
                End If
            End If
        End If
        Application.Exit()
    End Sub


    Private Sub FrmPrincipal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'For Each frm As Form In Me.MdiChildren()

        '    frm.WindowState = Me.WindowState

        'Next

    End Sub

    Private Sub ReemplazarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReemplazarToolStripMenuItem.Click
        If Not IsNothing(objFrmArticuloReemplazar) Then
            objFrmArticuloReemplazar.Dispose()
        End If
        objFrmArticuloReemplazar = New FrmArticuloReemplazar

        objFrmArticuloReemplazar.MdiParent = Me
        objFrmArticuloReemplazar.Show()
    End Sub

    Private Sub VerComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerComprasToolStripMenuItem.Click
        If Not IsNothing(objFrmComprasBuscar) Then
            objFrmComprasBuscar.Dispose()
        End If
        objFrmComprasBuscar = New frmComprasBuscar

        objFrmComprasBuscar.MdiParent = Me
        objFrmComprasBuscar.Show()
    End Sub

    Private Sub HistorialCajaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialCajaDiariaToolStripMenuItem.Click
        If Not IsNothing(objFrmHistorialCaja) Then
            objFrmHistorialCaja.Dispose()
        End If
        objFrmHistorialCaja = New frmHistorialCajaDiaria

        objFrmHistorialCaja.MdiParent = Me
        objFrmHistorialCaja.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVisualizarInformes.Show()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FacturacionToolStripMenuItem_Click(sender, e)
        Dim fcc As New FachadaCadenaDeConexion
        Dim cc As Modelo.CadenaDeConexion
        cc = fcc.TraerConexion()
        Me.Text = Me.Text & " (en " & cc.Servidor & ")"
        Dim fcs As New FachadaConfigSaturn
        AcuseReciboToolStripMenuItem.Checked = fcs.TraerConfigSaturn().ackMercaderia
    End Sub

    Private Sub FrmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Realmente desea salir de Saturn?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ArchivarFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivarFacturasToolStripMenuItem.Click

        If Not IsNothing(objFrmArchivarFacturas) Then
            If Not objFrmArchivarFacturas.Disposing Then
                objFrmArchivarFacturas.Dispose()
            End If
        End If
        objFrmArchivarFacturas = New FrmArchivarFacturas
        objFrmArchivarFacturas.MdiParent = Me
        objFrmArchivarFacturas.Show()


    End Sub

    Private Sub VerFacturasArchivadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerFacturasArchivadasToolStripMenuItem.Click
        If Not IsNothing(objFrmFacturasArchivadas) Then
            If Not objFrmFacturasArchivadas.Disposing Then
                objFrmFacturasArchivadas.Dispose()
            End If
        End If
        objFrmFacturasArchivadas = New frmVerFacturasArchivadas
        objFrmFacturasArchivadas.MdiParent = Me
        objFrmFacturasArchivadas.Show()
    End Sub

    Private Sub GrabarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarCambiosToolStripMenuItem.Click
        fa.grabarScript()
        Me.imgPlay.Visible = True

    End Sub

    Private Sub TerminarGrabaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminarGrabacionToolStripMenuItem.Click

        'Dim explorer As SaveFileDialog = New SaveFileDialog
        'Dim result As DialogResult = explorer.ShowDialog()
        'If result = Windows.Forms.DialogResult.OK Then
        '    fa.pararScript(explorer.FileName)
        '    Me.imgPlay.Visible = False
        'End If
        fa.pararScript()
        MessageBox.Show("Los cambios se han grabado en el archivo cambios.sql dentro de la  carpeta" & vbCr & Application.StartupPath.ToString, "Cambios grabados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.imgPlay.Visible = False
    End Sub

    Private Sub IngresarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarCambiosToolStripMenuItem.Click
        'opf.Filter = "Script SQL |*.sql"
        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'si presiono abrir, abro el archivo de entrada
            Dim lector As New System.IO.StreamReader(opf.FileName)
            Dim consulta As String
            Dim linea As String
            Dim facCambios As New FachadaIngresarScriptCambios

            linea = lector.ReadLine()

            While (linea <> Nothing)
                'consulta.Append(linea)

                If Not linea.ToUpper.StartsWith("SELECT") Then facCambios.IngresarScriptCambios(linea)
                linea = lector.ReadLine()
            End While




            'facCambios.IngresarScriptCambios(consulta.ToString)

            MessageBox.Show("Los cambios han sido ingresados en la base de datos", "Cambios ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub ProximosAReponerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProximosAReponerToolStripMenuItem.Click
        frmArticulosPorReponer.MdiParent = Me
        frmArticulosPorReponer.Show()
    End Sub

    Private Sub MigrarArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrarArticulosToolStripMenuItem.Click
        frmMigrarArticulos.MdiParent = Me
        frmMigrarArticulos.Show()
    End Sub

    Private Sub UnidadesVendidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesVendidasToolStripMenuItem.Click
        frmUnidadesVendidas.MdiParent = Me
        frmUnidadesVendidas.Show()
    End Sub



    Private Sub ConfigurarTicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarTicketToolStripMenuItem.Click
        frmConfigurarTicket.MdiParent = Me
        frmConfigurarTicket.Show()
    End Sub

    Private Sub AcuseReciboToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AcuseReciboToolStripMenuItem.CheckStateChanged
        Dim cs As New Modelo.ConfigSaturn
        cs.ackMercaderia = AcuseReciboToolStripMenuItem.Checked
        Dim fcs As New FachadaConfigSaturn
        fcs.Guardar(cs)
    End Sub

    Private Sub MovimientoDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoDeStockToolStripMenuItem.Click
        FrmMovimientoStock.MdiParent = Me
        FrmMovimientoStock.Show()
    End Sub

    Private Sub RecibirStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirStockToolStripMenuItem.Click
        FrmRecibirStock.MdiParent = Me
        FrmRecibirStock.Show()
    End Sub

    Private Sub MovimientosDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeStockToolStripMenuItem.Click
        FrmMovimientosDeStock.MdiParent = Me
        FrmMovimientosDeStock.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ImportarDesdeExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarDesdeExcelToolStripMenuItem.Click
        Dim frm As New FrmImportarArticulos
        frm.ShowDialog()

    End Sub

    Private Sub ModificacionDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDePreciosToolStripMenuItem.Click
        'frmConfigurarTicket.MdiParent = Me
        If Not IsNothing(objFrmArticulosModificarAumentar) Then
            objFrmArticulosModificarAumentar.Dispose()
        End If
        objFrmArticulosModificarAumentar = FrmArticulosModificarAumentar
        objFrmArticulosModificarAumentar.Show()
    End Sub
End Class
