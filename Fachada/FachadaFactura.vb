Imports Datos
Imports Modelo


Public Class FachadaFactura
    Public Function TraerNumero(ByVal tipoFac As String) As Integer
        Dim regFacT As New RegistroFacturas
        Return regFacT.TraerNumero(tipoFac)
    End Function

    Public Function TraerMaxIDVenta() As Integer
        Dim regFacT As New RegistroFacturas
        Return regFacT.TraerMaxIdVenta
    End Function

    Public Function TraerUnidadesVendidas(ByVal condicionStr As String) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.TraerUnidadesVendidas(condicionStr)
    End Function
    Public Function TraerNumeroNotaDeCredito(ByVal tipofac As String) As Integer
        Dim regFacT As New RegistroFacturas
        Return regFacT.TraerNumeroNotaDeCredito(tipofac)
    End Function
    Public Function ListarFacturasEnCuentaCorriente(ByVal param As Integer)
        Dim regFacT As New RegistroFacturas
        Return regFacT.ListarFacturasCtaCte(param)
    End Function

    Public Sub InsertarPago(ByVal p As Pago)
        Dim regPago As New RegistroPago
        regPago.InsertarPago(p)
    End Sub
    Public Function ListarFacturasDetalles(ByVal numero As Integer, ByVal condicion As String)
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturasConDetalle(numero, condicion)
    End Function
    Public Function ListarFacturas() As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturas()
    End Function
    Public Function ListarFacturasPorVendedor(ByVal nick As String) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturasPorVendedor(nick)
    End Function
    Public Function ListarFacturasPorIdArticulo(ByVal idArticulo As Integer) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturasPorIdArticulo(idArticulo)
    End Function

    Public Function ListarFacturasPorIdTipoProducto(ByVal idTipoProducto As Integer) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturasPorIdTipoProducto(idTipoProducto)
    End Function
    Public Function ListarNotasDeCredito() As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarNotasDeCredito()
    End Function
    Public Function ListarNotasDeCredito(ByVal numero As Integer) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarNotasDeCredito(numero)
    End Function
    Public Sub Eliminar(ByVal vta As Venta)
        Dim regFac As New RegistroFacturas
        Dim facArt As New FachadaArticulo
        For Each renglon As RenglonComprobante In vta.Renglones
            If Not IsNothing(renglon.Articulo) Then
                renglon.Articulo = facArt.TraerArticulo(renglon.Articulo.IdArticulo)
                renglon.Articulo.Stock += renglon.Cantidad
                facArt.ModificarArticulo2(renglon.Articulo)
            End If
        Next
        regFac.Eliminar(vta.Numero, vta.CondicionVenta)
    End Sub
    Public Function ListarFacturas(ByVal numero As Integer, ByVal condicion As String) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturas(numero, condicion)
    End Function
    Public Function ListarFacturas(ByVal idCliente As Integer) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturas(idCliente)
    End Function
    Public Function ListarFacturas(ByVal TIPO As String) As DataTable
        Dim regFac As New RegistroFacturas
        Return regFac.ListarFacturas(TIPO)
    End Function
    Public Sub FacturaPagadaCompletamente(ByVal numero As Integer, ByVal condicion As String)
        Dim f As New RegistroFacturas
        f.FacturaPagada(numero, condicion)
    End Sub
    Public Function TraerIds(ByVal numero As Integer, ByVal condicion As String)
        Dim f As New RegistroFacturas
        Return f.TraerId(numero, condicion)
    End Function
    Public Sub ingresarFactura(ByVal fac As Venta)
        Dim facArt As New FachadaArticulo
        Dim reg As New RegistroFacturas
        Try
            AccesoDatos.Instancia.IniciarTransaccion()

            reg.ingresarFactura(fac)
            If fac.CondicionVenta = "P" Then
                'no hago nada porque no muevo stock
            Else
                For Each renglon As RenglonComprobante In fac.Renglones
                    If Not IsNothing(renglon.Articulo) Then
                        renglon.Articulo = facArt.TraerArticulo(renglon.Articulo.IdArticulo)
                        'If renglon. < 0 Then 'este if seguramente es para tener en cuenta un articulo de cambio    MOFIF MATI Orginal line: If renglon.PrecioUnitario < 0 Then
                        '    renglon.Articulo.Stock += renglon.Cantidad
                        'Else
                        '    renglon.Articulo.Stock -= renglon.CantADisminuir
                        'End If
                        renglon.Articulo.Stock += (renglon.Cantidad) * -1 'mati modif OJOOOOOOOOO
                        facArt.ModificarArticulo2(renglon.Articulo)
                    End If
                Next
            End If


            AccesoDatos.Instancia.ConfirmarTransaccion()

        Catch ex As Exception
            AccesoDatos.Instancia.DeshacerTransaccion()
            Throw New Exception(ex.Message)
            'Throw New Exception("Error al ingresar el comprobante", ex)
        End Try

    End Sub

    Public Sub modificarFactura(ByVal fac As Venta)
        Dim regFac As New RegistroFacturas
        regFac.modificarFactura(fac)

    End Sub

    Public Sub ingresarNotaDeCredito(ByVal nota As NotaDeCredito)
        Dim facArt As New FachadaArticulo
        Dim reg As New RegistroFacturas

        AccesoDatos.Instancia.IniciarTransaccion()
        reg.ingresarNotaDeCredito(nota)
        
        For Each renglon As RenglonComprobante In nota.Renglones
            If Not IsNothing(renglon.Articulo) Then
                renglon.Articulo = facArt.TraerArticulo(renglon.Articulo.IdArticulo)
                renglon.Articulo.Stock += renglon.Cantidad
                facArt.ModificarArticulo2(renglon.Articulo)
            End If
        Next


        AccesoDatos.Instancia.ConfirmarTransaccion()

    End Sub
    Public Function SumarLasVentas(ByVal id As Integer)
        Dim fac As New RegistroFacturas
        Return fac.SumarVentas(id)
    End Function
    Public Function ChequearCredito(ByVal id As Integer)
        Dim fac As New RegistroFacturas
        Return fac.ChequearLimite(id)
    End Function

    Public Function TraerFactura(ByVal numero As Integer, ByVal condicion As String) As Venta
        Dim fac As New RegistroFacturas
        Return fac.TraerFactura(numero, condicion)
    End Function
    Public Function TraerNotaDeCredito(ByVal numero As Integer, ByVal condicion As String) As NotaDeCredito
        Dim fac As New RegistroFacturas
        Return fac.TraerNotaDeCredito(numero, condicion)
    End Function
    Public Function SumarPagos(ByVal id As Integer)
        Dim fac As New RegistroFacturas
        Return fac.SumarLosPagos(id)
    End Function
    Public Function TraerMaxFecha() As Date
        Dim fac As New RegistroFacturas
        Return fac.TraerMaxFecha()
    End Function
    Public Function TraerMinFecha() As Date
        Dim fac As New RegistroFacturas
        Return fac.TraerMinFecha()
    End Function
    Public Sub ArchivarFacturas(ByVal nombreArchivo As String, ByVal fechadesde As Date, ByVal fechaHasta As Date,barra as System.Windows.Forms.ProgressBar)
        Dim reg As New RegistroFacturas
        Dim nombreTabla As String
        'aca traemos el ultimo nombre de tabla...
        'archivo_01_08_2010 
        nombreTabla = "archivo_" & fechaHasta.Day & "_" & fechaHasta.Month & "_" & fechaHasta.Year

        reg.ScriptArchivar("Delete from facturasarchivadas where nombretabla='" & nombreTabla & "'")

        reg.ArchivarFacturas(nombreArchivo, nombreTabla, fechadesde, fechaHasta)

        Dim script As New System.Text.StringBuilder

        'script.Append("Delete from facturasarchivadas where nombretabla='" & nombreTabla & "';")
        script.Append(" DROP TABLE IF EXISTS `valmar`.`" & nombreTabla & "`; ")
        script.Append("	CREATE TABLE `" & nombreTabla & "` (	")
        script.Append("	  `idcliente` int(11) NOT NULL,	")
        script.Append("	  `idventa` int(11) NOT NULL AUTO_INCREMENT,	")
        script.Append("	  `idcomprobante` int(11) NOT NULL,	")
        script.Append("	  `idtipoventa` bit(1) NOT NULL DEFAULT b'0' COMMENT 'por defecto esta contado (0)',	")
        script.Append("	  `condicionventa` varchar(2) NOT NULL DEFAULT '' COMMENT 'es ABXPN',	")
        script.Append("	  `hora` datetime DEFAULT NULL,	")
        script.Append("	  `pagado` bit(1) NOT NULL DEFAULT b'0',	")
        script.Append("	  `numero` int(11) NOT NULL DEFAULT '0',	")
        script.Append("	  `nick` varchar(20) NOT NULL DEFAULT '',	")
        script.Append("	  `porcentajetarjeta` float(10,2) DEFAULT '0.00',	")
        script.Append("	  PRIMARY KEY (`idventa`)	")
        script.Append("	) ENGINE=InnoDB AUTO_INCREMENT=903 DEFAULT CHARSET=latin1;	")
        'CREA UN PROCEDURE DE INSERT PARA LA TABLA QUE ESTAMOS CREANDO EN LAS SENTENCIAS ANTERIORES
        script.Append(" DROP PROCEDURE IF EXISTS `valmar`.`" & nombreTabla & "_insert`; ")
        script.Append("	CREATE PROCEDURE valmar.`" & nombreTabla & "_insert`(	")
        script.Append("	        IN inIdComprobante INTEGER(11),	")
        script.Append("	        IN inIdTipoVenta BIT,	")
        script.Append("	        IN inIdCliente INTEGER,	")
        script.Append("	        IN inCondicionesVenta VARCHAR(2),	")
        script.Append("	        IN inHora DATETIME,	")
        script.Append("	        IN inPagado BIT,	")
        script.Append("	        IN inNumero INTEGER(11),	")
        script.Append("	        IN inNick VARCHAR(20),	")
        script.Append("	in inporcentaje float(10,2)	")
        script.Append("	    )	")
        script.Append("	BEGIN	")
        script.Append("	insert into `" & nombreTabla & "`(idComprobante,idTipoVenta,IdCliente,condicionVenta,hora,pagado,numero,nick,porcentajetarjeta) values(inIdComprobante,inidTipoVenta,inIdCliente,inCondicionesVenta,inHora,inPagado,inNumero,inNick,inporcentaje);	")
        script.Append(" delete from venta where condicionventa= 'X';")
        script.Append("	END;	")

        Dim ArrayFacturas As List(Of Venta)
        ArrayFacturas = reg.TraerFacturas
        barra.Maximum = ArrayFacturas.Count
        reg.ScriptArchivar(script.ToString)
        For Each v As Venta In ArrayFacturas
            reg.ingresarFactura(v, nombreTabla & "_insert")
            barra.Value += 1
            System.Windows.Forms.Application.DoEvents()
        Next


    End Sub
    Public Function ListarFacturasArchivadas() As List(Of FacturasArchivadas)
        Dim rf As New RegistroFacturas
        Return rf.TraerFacturasArchivadas
    End Function
    Public Function TraerDetallesDeFacturasArchivadas(ByVal tabla As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select * from " + tabla)
    End Function
End Class
