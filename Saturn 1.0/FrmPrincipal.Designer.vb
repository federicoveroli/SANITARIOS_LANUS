<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArticulosF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProximosAReponerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientoDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecibirStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientosDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportarDesdeExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDePreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesF2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasCorrientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturacionF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaDiariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistorialCajaDiariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArchivarFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerFacturasArchivadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnidadesVendidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupYRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministracionDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignacionDePermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrabarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerminarGrabacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MigrarArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigurarTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcuseReciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirF7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.opf = New System.Windows.Forms.OpenFileDialog
        Me.ofdExcel = New System.Windows.Forms.OpenFileDialog
        Me.imgPlay = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosF1ToolStripMenuItem, Me.ClientesF2ToolStripMenuItem, Me.ProveedoresF3ToolStripMenuItem, Me.FacturacionF4ToolStripMenuItem, Me.HerramientasF5ToolStripMenuItem, Me.SalirF7ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArticulosF1ToolStripMenuItem
        '
        Me.ArticulosF1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMArticulosToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ReemplazarToolStripMenuItem, Me.ProximosAReponerToolStripMenuItem, Me.MovimientoDeStockToolStripMenuItem, Me.RecibirStockToolStripMenuItem, Me.MovimientosDeStockToolStripMenuItem, Me.ImportarDesdeExcelToolStripMenuItem, Me.ModificacionDePreciosToolStripMenuItem})
        Me.ArticulosF1ToolStripMenuItem.Name = "ArticulosF1ToolStripMenuItem"
        Me.ArticulosF1ToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ArticulosF1ToolStripMenuItem.Text = "Articulos F1"
        '
        'ABMArticulosToolStripMenuItem
        '
        Me.ABMArticulosToolStripMenuItem.Name = "ABMArticulosToolStripMenuItem"
        Me.ABMArticulosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ABMArticulosToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ModificacionToolStripMenuItem.Text = "Modificacion"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ReemplazarToolStripMenuItem
        '
        Me.ReemplazarToolStripMenuItem.Name = "ReemplazarToolStripMenuItem"
        Me.ReemplazarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ReemplazarToolStripMenuItem.Text = "Reemplazar"
        Me.ReemplazarToolStripMenuItem.Visible = False
        '
        'ProximosAReponerToolStripMenuItem
        '
        Me.ProximosAReponerToolStripMenuItem.Name = "ProximosAReponerToolStripMenuItem"
        Me.ProximosAReponerToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ProximosAReponerToolStripMenuItem.Text = "Proximos a Reponer..."
        '
        'MovimientoDeStockToolStripMenuItem
        '
        Me.MovimientoDeStockToolStripMenuItem.Name = "MovimientoDeStockToolStripMenuItem"
        Me.MovimientoDeStockToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MovimientoDeStockToolStripMenuItem.Text = "Movimiento de Stock"
        '
        'RecibirStockToolStripMenuItem
        '
        Me.RecibirStockToolStripMenuItem.Name = "RecibirStockToolStripMenuItem"
        Me.RecibirStockToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RecibirStockToolStripMenuItem.Text = "Recibir Stock"
        '
        'MovimientosDeStockToolStripMenuItem
        '
        Me.MovimientosDeStockToolStripMenuItem.Name = "MovimientosDeStockToolStripMenuItem"
        Me.MovimientosDeStockToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MovimientosDeStockToolStripMenuItem.Text = "Movimientos de Stock"
        '
        'ImportarDesdeExcelToolStripMenuItem
        '
        Me.ImportarDesdeExcelToolStripMenuItem.Name = "ImportarDesdeExcelToolStripMenuItem"
        Me.ImportarDesdeExcelToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ImportarDesdeExcelToolStripMenuItem.Text = "Importar desde Excel"
        '
        'ModificacionDePreciosToolStripMenuItem
        '
        Me.ModificacionDePreciosToolStripMenuItem.Name = "ModificacionDePreciosToolStripMenuItem"
        Me.ModificacionDePreciosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ModificacionDePreciosToolStripMenuItem.Text = "Cambio Gral. de precios"
        '
        'ClientesF2ToolStripMenuItem
        '
        Me.ClientesF2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem1, Me.ModificarToolStripMenuItem, Me.BuscarToolStripMenuItem1, Me.CuentasCorrientesToolStripMenuItem})
        Me.ClientesF2ToolStripMenuItem.Name = "ClientesF2ToolStripMenuItem"
        Me.ClientesF2ToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ClientesF2ToolStripMenuItem.Text = "Clientes F2"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem1
        '
        Me.BajaToolStripMenuItem1.Name = "BajaToolStripMenuItem1"
        Me.BajaToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.BajaToolStripMenuItem1.Text = "Baja"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
        '
        'CuentasCorrientesToolStripMenuItem
        '
        Me.CuentasCorrientesToolStripMenuItem.Name = "CuentasCorrientesToolStripMenuItem"
        Me.CuentasCorrientesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CuentasCorrientesToolStripMenuItem.Text = "Cuentas Corrientes"
        '
        'ProveedoresF3ToolStripMenuItem
        '
        Me.ProveedoresF3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.BajaToolStripMenuItem2, Me.ModificacionToolStripMenuItem1, Me.BuscarToolStripMenuItem2, Me.CargarCompraToolStripMenuItem, Me.VerComprasToolStripMenuItem})
        Me.ProveedoresF3ToolStripMenuItem.Name = "ProveedoresF3ToolStripMenuItem"
        Me.ProveedoresF3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ProveedoresF3ToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ProveedoresF3ToolStripMenuItem.Text = "Proveedores F3"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'BajaToolStripMenuItem2
        '
        Me.BajaToolStripMenuItem2.Name = "BajaToolStripMenuItem2"
        Me.BajaToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.BajaToolStripMenuItem2.Text = "Baja"
        '
        'ModificacionToolStripMenuItem1
        '
        Me.ModificacionToolStripMenuItem1.Name = "ModificacionToolStripMenuItem1"
        Me.ModificacionToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ModificacionToolStripMenuItem1.Text = "Modificacion"
        '
        'BuscarToolStripMenuItem2
        '
        Me.BuscarToolStripMenuItem2.Name = "BuscarToolStripMenuItem2"
        Me.BuscarToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.BuscarToolStripMenuItem2.Text = "Buscar"
        '
        'CargarCompraToolStripMenuItem
        '
        Me.CargarCompraToolStripMenuItem.Name = "CargarCompraToolStripMenuItem"
        Me.CargarCompraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.CargarCompraToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CargarCompraToolStripMenuItem.Text = "Cargar Compra"
        '
        'VerComprasToolStripMenuItem
        '
        Me.VerComprasToolStripMenuItem.Name = "VerComprasToolStripMenuItem"
        Me.VerComprasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VerComprasToolStripMenuItem.Text = "Ver Compras"
        '
        'FacturacionF4ToolStripMenuItem
        '
        Me.FacturacionF4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.CajaDiariaToolStripMenuItem, Me.HistorialCajaDiariaToolStripMenuItem, Me.ArchivarFacturasToolStripMenuItem, Me.VerFacturasArchivadasToolStripMenuItem, Me.UnidadesVendidasToolStripMenuItem})
        Me.FacturacionF4ToolStripMenuItem.Name = "FacturacionF4ToolStripMenuItem"
        Me.FacturacionF4ToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.FacturacionF4ToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.FacturacionF4ToolStripMenuItem.Text = "Facturacion F4"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'CajaDiariaToolStripMenuItem
        '
        Me.CajaDiariaToolStripMenuItem.Name = "CajaDiariaToolStripMenuItem"
        Me.CajaDiariaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CajaDiariaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CajaDiariaToolStripMenuItem.Text = "Caja Diaria"
        '
        'HistorialCajaDiariaToolStripMenuItem
        '
        Me.HistorialCajaDiariaToolStripMenuItem.Name = "HistorialCajaDiariaToolStripMenuItem"
        Me.HistorialCajaDiariaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.HistorialCajaDiariaToolStripMenuItem.Text = "Historial Caja Diaria"
        '
        'ArchivarFacturasToolStripMenuItem
        '
        Me.ArchivarFacturasToolStripMenuItem.Name = "ArchivarFacturasToolStripMenuItem"
        Me.ArchivarFacturasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ArchivarFacturasToolStripMenuItem.Text = "Archivar Facturas"
        '
        'VerFacturasArchivadasToolStripMenuItem
        '
        Me.VerFacturasArchivadasToolStripMenuItem.Name = "VerFacturasArchivadasToolStripMenuItem"
        Me.VerFacturasArchivadasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VerFacturasArchivadasToolStripMenuItem.Text = "Ver Facturas Archivadas"
        '
        'UnidadesVendidasToolStripMenuItem
        '
        Me.UnidadesVendidasToolStripMenuItem.Name = "UnidadesVendidasToolStripMenuItem"
        Me.UnidadesVendidasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.UnidadesVendidasToolStripMenuItem.Text = "Unidades Vendidas"
        '
        'HerramientasF5ToolStripMenuItem
        '
        Me.HerramientasF5ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupYRestoreToolStripMenuItem, Me.BitacoraToolStripMenuItem, Me.AdministracionDeUsuariosToolStripMenuItem, Me.AsignacionDePermisosToolStripMenuItem, Me.GrabarCambiosToolStripMenuItem, Me.TerminarGrabacionToolStripMenuItem, Me.IngresarCambiosToolStripMenuItem, Me.MigrarArticulosToolStripMenuItem, Me.ConfigurarTicketToolStripMenuItem, Me.AcuseReciboToolStripMenuItem})
        Me.HerramientasF5ToolStripMenuItem.Name = "HerramientasF5ToolStripMenuItem"
        Me.HerramientasF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.HerramientasF5ToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasF5ToolStripMenuItem.Text = "Herramientas"
        '
        'BackupYRestoreToolStripMenuItem
        '
        Me.BackupYRestoreToolStripMenuItem.Name = "BackupYRestoreToolStripMenuItem"
        Me.BackupYRestoreToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BackupYRestoreToolStripMenuItem.Text = "Backup y Restore"
        '
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BitacoraToolStripMenuItem.Text = "Bitacora"
        '
        'AdministracionDeUsuariosToolStripMenuItem
        '
        Me.AdministracionDeUsuariosToolStripMenuItem.Name = "AdministracionDeUsuariosToolStripMenuItem"
        Me.AdministracionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AdministracionDeUsuariosToolStripMenuItem.Text = "Administracion de usuarios"
        '
        'AsignacionDePermisosToolStripMenuItem
        '
        Me.AsignacionDePermisosToolStripMenuItem.Name = "AsignacionDePermisosToolStripMenuItem"
        Me.AsignacionDePermisosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AsignacionDePermisosToolStripMenuItem.Text = "Asignacion de permisos"
        '
        'GrabarCambiosToolStripMenuItem
        '
        Me.GrabarCambiosToolStripMenuItem.Name = "GrabarCambiosToolStripMenuItem"
        Me.GrabarCambiosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.GrabarCambiosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GrabarCambiosToolStripMenuItem.Text = "Grabar cambios de precio"
        '
        'TerminarGrabacionToolStripMenuItem
        '
        Me.TerminarGrabacionToolStripMenuItem.Name = "TerminarGrabacionToolStripMenuItem"
        Me.TerminarGrabacionToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.TerminarGrabacionToolStripMenuItem.Text = "Terminar grabación"
        '
        'IngresarCambiosToolStripMenuItem
        '
        Me.IngresarCambiosToolStripMenuItem.Name = "IngresarCambiosToolStripMenuItem"
        Me.IngresarCambiosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.IngresarCambiosToolStripMenuItem.Text = "Ingresar cambios"
        '
        'MigrarArticulosToolStripMenuItem
        '
        Me.MigrarArticulosToolStripMenuItem.Name = "MigrarArticulosToolStripMenuItem"
        Me.MigrarArticulosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.MigrarArticulosToolStripMenuItem.Text = "Migrar articulos"
        '
        'ConfigurarTicketToolStripMenuItem
        '
        Me.ConfigurarTicketToolStripMenuItem.Name = "ConfigurarTicketToolStripMenuItem"
        Me.ConfigurarTicketToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ConfigurarTicketToolStripMenuItem.Text = "Configurar Ticket"
        '
        'AcuseReciboToolStripMenuItem
        '
        Me.AcuseReciboToolStripMenuItem.CheckOnClick = True
        Me.AcuseReciboToolStripMenuItem.Name = "AcuseReciboToolStripMenuItem"
        Me.AcuseReciboToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AcuseReciboToolStripMenuItem.Text = "Acuse de recibo de mercaderia"
        '
        'SalirF7ToolStripMenuItem
        '
        Me.SalirF7ToolStripMenuItem.Name = "SalirF7ToolStripMenuItem"
        Me.SalirF7ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.SalirF7ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SalirF7ToolStripMenuItem.Text = "Salir F7"
        '
        'opf
        '
        Me.opf.FileName = "OpenFileDialog1"
        '
        'imgPlay
        '
        Me.imgPlay.Image = Global.Saturn_1.Saturn.My.Resources.Resources.icono_play
        Me.imgPlay.Location = New System.Drawing.Point(852, -1)
        Me.imgPlay.Name = "imgPlay"
        Me.imgPlay.Size = New System.Drawing.Size(23, 25)
        Me.imgPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPlay.TabIndex = 2
        Me.imgPlay.TabStop = False
        Me.imgPlay.Visible = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 561)
        Me.Controls.Add(Me.imgPlay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saturn 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArticulosF1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesF2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresF3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionF4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasF5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupYRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirF7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaDiariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionDePermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasCorrientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialCajaDiariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivarFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerFacturasArchivadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminarGrabacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgPlay As System.Windows.Forms.PictureBox
    Friend WithEvents opf As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProximosAReponerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MigrarArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadesVendidasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcuseReciboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientoDeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecibirStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosDeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarDesdeExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdExcel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ModificacionDePreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
