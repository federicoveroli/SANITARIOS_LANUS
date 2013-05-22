Imports Fachada
Imports Modelo
Imports CrystalDecisions

Public Class frmVisualizarInformes

    Dim facCliente As New FachadaCliente
    Dim facTel As New FachadaTelefono
    Dim facDom As New FachadaDomicilio
    Dim facIVa As New FachadaIva
    Public Shared llevaRemito As Boolean

    Public Sub Visualizar(ByVal vta As Venta, ByVal cantCopias As Integer) 'ByVal numeroFac As Integer, ByVal tipofac As String, ByVal idCliente As Integer, ByVal condicion As String, ByVal numfac As String)
        'Try

        'para el remito   si la cantidad de copias es 2 es que es un remito

        If cantCopias = 2 Then
            Dim rc As New clsReportCreator
            Dim rd As New RptRemitoA ''rptVenta
            Dim dt As DataTable
            Dim fac As New FachadaReporte
            Dim cli As Cliente
            Dim txt As CrystalDecisions.CrystalReports.Engine.TextObject
            dt = fac.ImpresionDeFactura(vta.Numero, vta.CondicionVenta)

            cli = facCliente.TraerPorId(vta.IdCliente)

            txt = CType(rd.Section1.ReportObjects("txtCUIT"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = cli.CUIT

            txt = CType(rd.Section1.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject)
            If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
                Dim dom As Domicilio
                dom = facDom.colDomiciliosEnte(cli.IdEnte).Item(0)
                txt.Text = dom.Calle ' **** PARA IMAGEN 2 EN CALLE SE ENCUENTRA CONCATENADO TODO EL DOMICILIO
            Else
                txt.Text = "No especificado."
            End If

    

            rd.SetDataSource(dt)
            Me.CrystalReportViewer1.ReportSource = rd

            rd.PrintToPrinter(cantCopias, False, 0, 1)



            Exit Sub

        End If

        '*******************************************************************************************************
        ' para los presupuestos o X
        If vta.CondicionVenta = "X" Or vta.CondicionVenta = "x" Or vta.CondicionVenta = "P" Or vta.CondicionVenta = "p" Then

            ImprimirReporteA4(vta, cantCopias)

            'Dim rc As New clsReportCreator
            'Dim rd As New RptXDaniel ''rptVenta
            'Dim dt As DataTable
            'Dim fac As New FachadaReporte
            'Dim cli As Cliente
            'Dim txt As CrystalDecisions.CrystalReports.Engine.TextObject
            'dt = fac.ImpresionDeFactura(vta.Numero, vta.CondicionVenta)
            ''If dt.Rows.Count < 15 Then
            ''Else
            ''    ImprimirReporteA4(vta, cantCopias)
            ''    Exit Sub
            ''End If
            'cli = facCliente.TraerPorId(vta.IdCliente)
            ''If facTel.colTelefonosEnte(cli.IdEnte).Count > 0 Then
            ''    txt = CType(rd.Section1.ReportObjects("txtTelefono"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''    txt.Text = facTel.colTelefonosEnte(cli.IdEnte).Item(0).Numero
            ''End If

            'txt = CType(rd.Section2.ReportObjects("txtCuit"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'txt.Text = cli.CUIT
            ''txt = CType(rd.Section1.ReportObjects("txtTipoFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''txt.Text = vta.CondicionVenta

            'txt = CType(rd.Section2.ReportObjects("txtcondicion"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'If vta.Porcentaje > 0 Then
            '    'es con tarjeta
            '    txt.Text = "Tarjeta  " '& vta.Porcentaje & "%"
            'Else
            '    If vta.IdTipoVenta = True Then
            '        txt.Text = "Cuenta Corriente"
            '    Else
            '        txt.Text = "Contado"
            '    End If
            'End If

            'txt = CType(rd.Section2.ReportObjects("txtNroFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'txt.Text = vta.Numero
            ''txt = CType(rd.Section1.ReportObjects("txtLocalidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
            '    Dim dom As Domicilio
            '    dom = facDom.colDomiciliosEnte(cli.IdEnte).Item(0)
            '    'txt.Text = dom.Localidad
            '    'txt = CType(rd.Section4.ReportObjects("lblFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    'txt.Text = "Domicilio:"

            '    txt = CType(rd.Section2.ReportObjects("txtDomicilio"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    txt.Text = dom.Calle & " " & dom.Altura & " " & dom.Piso & " " & dom.Depto

            'End If
            'txt = CType(rd.Section2.ReportObjects("txtIva"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'txt.Text = facIVa.traerPorId(cli.IdIva).Descripcion

            ''If vta.CondicionVenta = "A" Then
            ''    txt = CType(rd.Section4.ReportObjects("txtSubtotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''    txt.Text = Math.Round(vta.Total, 2)
            ''    txt = CType(rd.Section4.ReportObjects("txtTotalIVA"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''    txt.Text = Math.Round(vta.TotalIVA, 2)
            ''ElseIf vta.CondicionVenta = "X" Or vta.CondicionVenta = "P" Then
            ''    txt = CType(rd.Section4.ReportObjects("txtNoValido"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''    txt.Text = "DOCUMENTO NO VÁLIDO COMO FACTURA"
            ''    txt = CType(rd.Section4.ReportObjects("txtPresupuesto"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ''    txt.Text = "PRESUPUESTO"
            ''End If

            '' rd.SetParameterValue("tipoFac", tipofac)
            'rd.SetDataSource(dt)
            'rd.Subreports(0).SetDataSource(dt)
            'Me.CrystalReportViewer1.ReportSource = rd

            ' ''rd.PrintOptions.PaperOrientation = [Shared].PaperOrientation.Landscape 'imprime apaizado
            'rd.PrintToPrinter(cantCopias, False, 0, 1)

            ''Catch ex As Exception

            ''End Try
            'Exit Sub
        End If





        'Para la impresion de Facturas A
        If vta.CondicionVenta = "A" Or vta.CondicionVenta = "B" Or vta.CondicionVenta = "b" Or vta.CondicionVenta = "a" Then
            Dim rc As New clsReportCreator
            Dim rd As New RptADaniel ' rptFacturaLegalA4_p_Imagen2 ''rptVenta
            Dim dt As DataTable
            Dim fac As New FachadaReporte
            Dim cli As Cliente
            Dim txt As CrystalDecisions.CrystalReports.Engine.TextObject
            dt = fac.ImpresionDeFactura(vta.Numero, vta.CondicionVenta)
            'If dt.Rows.Count < 15 Then
            'Else
            '    ImprimirReporteA4(vta, cantCopias)
            '    Exit Sub
            'End If
            cli = facCliente.TraerPorId(vta.IdCliente)
            'If facTel.colTelefonosEnte(cli.IdEnte).Count > 0 Then
            '    txt = CType(rd.Section1.ReportObjects("txtTelefono"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    txt.Text = facTel.colTelefonosEnte(cli.IdEnte).Item(0).Numero
            'End If

            txt = CType(rd.Section2.ReportObjects("txtCuit"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = cli.CUIT
            'txt = CType(rd.Section1.ReportObjects("txtTipoFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'txt.Text = vta.CondicionVenta

            txt = CType(rd.Section2.ReportObjects("txtcondicion"), CrystalDecisions.CrystalReports.Engine.TextObject)
            If vta.Porcentaje > 0 Then
                'es con tarjeta
                txt.Text = "Tarjeta  " '& vta.Porcentaje & "%"
            Else
                If vta.IdTipoVenta = True Then
                    txt.Text = "7 DIAS"
                Else
                    txt.Text = "Contado"
                End If
            End If

            txt = CType(rd.Section2.ReportObjects("txtNroFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = vta.Numero
            'txt = CType(rd.Section1.ReportObjects("txtLocalidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
            If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
                Dim dom As Domicilio
                dom = facDom.colDomiciliosEnte(cli.IdEnte).Item(0)
                'txt.Text = dom.Localidad
                'txt = CType(rd.Section4.ReportObjects("lblFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'txt.Text = "Domicilio:"

                txt = CType(rd.Section2.ReportObjects("txtDomicilio"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = dom.Calle & " " & dom.Altura & " " & dom.Piso & " " & dom.Depto

            End If
            txt = CType(rd.Section2.ReportObjects("txtIva"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = facIVa.traerPorId(cli.IdIva).Descripcion
            'If vta.CondicionVenta = "A" Then
            txt = CType(rd.Section4.ReportObjects("txtSubtotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = Math.Round(vta.Total, 2)
            txt = CType(rd.Section4.ReportObjects("txtTotalIVA"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = Math.Round(vta.TotalIVA, 2)
            'ElseIf vta.CondicionVenta = "X" Or vta.CondicionVenta = "P" Then
            '    txt = CType(rd.Section4.ReportObjects("txtNoValido"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    txt.Text = "DOCUMENTO NO VÁLIDO COMO FACTURA"
            '    txt = CType(rd.Section4.ReportObjects("txtPresupuesto"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    txt.Text = "PRESUPUESTO"
            'End If

            ' rd.SetParameterValue("tipoFac", tipofac)
            rd.SetDataSource(dt)
            '  rd.Subreports(0).SetDataSource(dt)
            Me.CrystalReportViewer1.ReportSource = rd

            ''rd.PrintOptions.PaperOrientation = [Shared].PaperOrientation.Landscape 'imprime apaizado
            rd.PrintToPrinter(3, False, 0, 1) '**************PONER 2 COPIASSSSSS

            'Catch ex As Exception

            'End Try
            If llevaRemito Then
                'imprimo el remito 
                Dim rdRemito As New RptRemitoDaniel ' rptFacturaLegalA4_p_Imagen2 ''rptVenta
                Dim txt1 As CrystalDecisions.CrystalReports.Engine.TextObject

                dt = fac.ImpresionDeFactura(vta.Numero, vta.CondicionVenta)
                'If dt.Rows.Count < 15 Then
                'Else
                '    ImprimirReporteA4(vta, cantCopias)
                '    Exit Sub
                'End If
                cli = facCliente.TraerPorId(vta.IdCliente)
                'If facTel.colTelefonosEnte(cli.IdEnte).Count > 0 Then
                '    txt1 = CType(rdRemito.Section1.ReportObjects("txt1Telefono"), CrystalDecisions.CrystalReports.Engine.TextObject)
                '    txt1.Text = facTel.colTelefonosEnte(cli.IdEnte).Item(0).Numero
                'End If

                txt1 = CType(rdRemito.Section2.ReportObjects("txtCuit"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt1.Text = cli.CUIT
                'txt1 = CType(rdRemito.Section1.ReportObjects("txt1TipoFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'txt1.Text = vta.CondicionVenta

                txt1 = CType(rdRemito.Section2.ReportObjects("txtcondicion"), CrystalDecisions.CrystalReports.Engine.TextObject)
                If vta.Porcentaje > 0 Then
                    'es con tarjeta
                    txt1.Text = "Tarjeta  " '& vta.Porcentaje & "%"
                Else
                    If vta.IdTipoVenta = True Then
                        txt1.Text = "7 DIAS"
                    Else
                        txt1.Text = "Contado"
                    End If
                End If

                txt1 = CType(rdRemito.Section2.ReportObjects("txtNroFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt1.Text = vta.Numero
                'txt1 = CType(rdRemito.Section1.ReportObjects("txt1Localidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
                If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
                    Dim dom As Domicilio
                    dom = facDom.colDomiciliosEnte(cli.IdEnte).Item(0)
                    'txt1.Text = dom.Localidad
                    'txt1 = CType(rdRemito.Section4.ReportObjects("lblFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    'txt1.Text = "Domicilio:"

                    txt1 = CType(rdRemito.Section2.ReportObjects("txtDomicilio"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    txt1.Text = dom.Calle & " " & dom.Altura & " " & dom.Piso & " " & dom.Depto

                End If
                'txt1 = CType(rdRemito.Section2.ReportObjects("txt1Iva"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'txt1.Text = facIVa.traerPorId(cli.IdIva).Descripcion
                ''If vta.CondicionVenta = "A" Then
                'txt1 = CType(rdRemito.Section4.ReportObjects("txt1Subtotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'txt1.Text = Math.Round(vta.Total, 2)
                'txt1 = CType(rdRemito.Section4.ReportObjects("txt1TotalIVA"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'txt1.Text = Math.Round(vta.TotalIVA, 2)
                'ElseIf vta.CondicionVenta = "X" Or vta.CondicionVenta = "P" Then
                '    txt1 = CType(rdRemito.Section4.ReportObjects("txt1NoValido"), CrystalDecisions.CrystalReports.Engine.TextObject)
                '    txt1.Text = "DOCUMENTO NO VÁLIDO COMO FACTURA"
                '    txt1 = CType(rdRemito.Section4.ReportObjects("txt1Presupuesto"), CrystalDecisions.CrystalReports.Engine.TextObject)
                '    txt1.Text = "PRESUPUESTO"
                'End If

                ' rdRemito.SetParameterValue("tipoFac", tipofac)
                rdRemito.SetDataSource(dt)
                '  rdRemito.Subreports(0).SetDataSource(dt)
                Me.CrystalReportViewer1.ReportSource = rdRemito

                ''rdRemito.PrintOptions.PaperOrientation = [Shared].PaperOrientation.Landscape 'imprime apaizado
                rdRemito.PrintToPrinter(3, False, 0, 1) '**************PONER 2 COPIASSSSSS
            End If
            Exit Sub
        End If


        

      
    End Sub
    Public Sub VisualizarNotaDeCredito(ByVal nc As NotaDeCredito)
        Dim rc As New clsReportCreator
        Dim rd As New rptVenta
        Dim dt As DataTable
        Dim fac As New FachadaReporte
        Dim cli As Cliente
        Dim txt As CrystalDecisions.CrystalReports.Engine.TextObject

        txt = CType(rd.Section4.ReportObjects("txtNotaDeCredito"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = "NOTA DE CREDITO"

        txt = CType(rd.Section4.ReportObjects("lblFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = "Fac. Relacionada:"
        If nc.NumeroFactura <> 0 Then
            txt = CType(rd.Section4.ReportObjects("txtFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = "" & nc.NumeroFactura
        End If

        cli = facCliente.TraerPorId(nc.IdCliente)
        If facTel.colTelefonosEnte(cli.IdEnte).Count > 0 Then
            txt = CType(rd.Section1.ReportObjects("txtTelefono"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = facTel.colTelefonosEnte(cli.IdEnte).Item(0).Numero
        End If

        txt = CType(rd.Section1.ReportObjects("txtCuit"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = cli.CUIT
        txt = CType(rd.Section1.ReportObjects("txtTipoFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = nc.CondicionVenta

        txt = CType(rd.Section1.ReportObjects("txtcondicion"), CrystalDecisions.CrystalReports.Engine.TextObject)
        If nc.IdTipoVenta = True Then
            txt.Text = "Cuenta Corriente"
        Else
            txt.Text = "Contado"
        End If




        txt = CType(rd.Section1.ReportObjects("txtNroFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = nc.Numero
        txt = CType(rd.Section1.ReportObjects("txtLocalidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = "Desconocida"
        If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
            txt.Text = facDom.colDomiciliosEnte(cli.IdEnte).Item(0).Localidad
        End If
        txt = CType(rd.Section1.ReportObjects("txtIva"), CrystalDecisions.CrystalReports.Engine.TextObject)
        txt.Text = facIVa.traerPorId(cli.IdIva).Descripcion

        If nc.CondicionVenta = "A" Then
            txt = CType(rd.Section4.ReportObjects("txtSubtotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = Math.Round(nc.Total, 2)
            txt = CType(rd.Section4.ReportObjects("txtTotalIVA"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = Math.Round(nc.TotalIVA, 2)
        End If
        dt = fac.ImpNot(nc.Numero, nc.CondicionVenta)
        ' rd.SetParameterValue("tipoFac", tipofac)
        rd.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rd
    End Sub


    Private Sub err(ByVal source As System.Object, ByVal e As CrystalDecisions.Windows.Forms.ExceptionEventArgs) Handles CrystalReportViewer1.Error
        MsgBox("No se pudo imprimir el listado")
        Exit Sub
    End Sub
    Private Sub ImprimirReporteA4(ByVal vta As Venta, ByVal cantCopias As Integer)
        Try
            Dim rc As New clsReportCreator
            Dim rd As New rptVentaA4 ''rptVenta
            Dim dt As DataTable
            Dim fac As New FachadaReporte
            Dim cli As Cliente
            Dim txt As CrystalDecisions.CrystalReports.Engine.TextObject
            dt = fac.ImpresionDeFactura(vta.Numero, vta.CondicionVenta)
            cli = facCliente.TraerPorId(vta.IdCliente)
            If facTel.colTelefonosEnte(cli.IdEnte).Count > 0 Then
                txt = CType(rd.Section1.ReportObjects("txtTelefono"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = facTel.colTelefonosEnte(cli.IdEnte).Item(0).Numero
            End If

            txt = CType(rd.Section1.ReportObjects("txtCuit"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = cli.CUIT
            txt = CType(rd.Section1.ReportObjects("txtTipoFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = vta.CondicionVenta

            txt = CType(rd.Section1.ReportObjects("txtcondicion"), CrystalDecisions.CrystalReports.Engine.TextObject)


            If vta.Porcentaje > 0 Then
                'es con tarjeta
                txt.Text = "Tarjeta  " '& vta.Porcentaje & "%"
            Else
                If vta.IdTipoVenta = True Then
                    txt.Text = "7 DIAS"
                Else
                    txt.Text = "Contado"
                End If
            End If
            
            txt = CType(rd.Section1.ReportObjects("txtNroFac"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = vta.Numero
            txt = CType(rd.Section1.ReportObjects("txtLocalidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
            If facDom.colDomiciliosEnte(cli.IdEnte).Count > 0 Then
                Dim dom As Domicilio
                dom = facDom.colDomiciliosEnte(cli.IdEnte).Item(0)
                txt.Text = dom.Localidad
                txt = CType(rd.Section4.ReportObjects("lblFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = "Domicilio:"

                txt = CType(rd.Section4.ReportObjects("txtFacturaRelacionada"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = dom.Calle & " " & dom.Altura & " " & dom.Piso & " " & dom.Depto

            End If
            txt = CType(rd.Section1.ReportObjects("txtIva"), CrystalDecisions.CrystalReports.Engine.TextObject)
            txt.Text = facIVa.traerPorId(cli.IdIva).Descripcion

            If vta.CondicionVenta = "A" Then
                txt = CType(rd.Section4.ReportObjects("txtSubtotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = Math.Round(vta.Total, 2)
                txt = CType(rd.Section4.ReportObjects("txtTotalIVA"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = Math.Round(vta.TotalIVA, 2)
            ElseIf vta.CondicionVenta = "X" Or vta.CondicionVenta = "P" Then
                txt = CType(rd.Section4.ReportObjects("txtNoValido"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = "DOCUMENTO NO VÁLIDO COMO FACTURA"
                txt = CType(rd.Section4.ReportObjects("txtPresupuesto"), CrystalDecisions.CrystalReports.Engine.TextObject)
                txt.Text = "PRESUPUESTO"
            End If

            ' rd.SetParameterValue("tipoFac", tipofac)
            rd.SetDataSource(dt)
            rd.Subreports(0).SetDataSource(dt)
            Me.CrystalReportViewer1.ReportSource = rd

            rd.PrintToPrinter(cantCopias, False, 0, 1)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class