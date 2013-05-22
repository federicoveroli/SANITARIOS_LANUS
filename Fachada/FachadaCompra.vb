Imports Datos
Imports Modelo
Imports Microsoft.Office.Interop

Public Class FachadaCompra
    Public Event ArticuloNoEncontrado(ByVal descripcion As String, ByVal cantidad As Integer, ByVal cod_barras As String, ByVal art As Articulo)
    Public Event AgregarRenglonCompra(ByVal idArticulo As Integer, ByVal cantidad As Double, ByVal pcosto As Double, ByVal pventa As Double)
    Private comp As Compra

    Private ReadOnly Property CompraImportada() As Compra
        Get
            Return comp
        End Get
    End Property

    Public Sub ingresarCompra(ByVal compra As Comprobante)
        Dim facArt As New FachadaArticulo
        Dim reg As New RegistroCompra
        reg.ingresarCompra(compra)
        For Each renglon As RenglonComprobante In compra.Renglones
            renglon.Articulo.Costo = renglon.PrecioUnitario
            If renglon.Articulo.Utilidad <> 0 Then
                renglon.Articulo.Precio = renglon.PrecioUnitario + renglon.PrecioUnitario * (renglon.Articulo.Utilidad / 100)
            End If
            renglon.Articulo.Costo = renglon.PrecioUnitario
            renglon.Articulo.Stock += renglon.Cantidad
            facArt.ModificarArticulo2(renglon.Articulo)
        Next
    End Sub
    Public Function TraerCompra(ByVal idCompra As Integer) As Compra
        Dim reg As New RegistroCompra
        Return reg.Traercompra(idCompra)
    End Function
    Public Function ListarCompras() As DataTable
        Dim reg As New RegistroCompra
        Return reg.ListarCompras
    End Function
    Public Function ListarCompras(ByVal idProveedor As Integer) As DataTable
        Dim reg As New RegistroCompra
        Return reg.ListarCompras(idProveedor)
    End Function
    Public Function ListarCompras(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim reg As New RegistroCompra
        Return reg.ListarCompras(fechaDesde, fechaHasta)
    End Function
    Public Function ListarCompras(ByVal idProveedor As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim reg As New RegistroCompra
        Return reg.ListarCompras(idProveedor, fechaDesde, fechaHasta)
    End Function
    Public Sub Anular(ByVal idCompra As Integer)
        Dim reg As New RegistroCompra
        Dim regArt As New RegistroArticulo
        Dim comp As Compra
        comp = reg.Traercompra(idCompra)
        For Each rc As RenglonComprobante In comp.Renglones
            rc.Articulo.Stock -= rc.Cantidad
            regArt.modificarArticulo2(rc.Articulo)
        Next
        reg.eliminarCompra(idCompra)
    End Sub

    Public Function ImportarDesdeExcel(ByVal filename As String) As Compra

        'Hago el proceso de cargar la compra desde el excel

        Dim xlApp As Excel._Application
        Dim xlLibro As Excel._Workbook
        Dim xlHoja1 As Excel._Worksheet
        Dim xlhojas As Excel.Sheets
        comp = New Compra
        xlApp = New Excel.Application
        xlApp.Visible = False
        xlLibro = xlApp.Workbooks.Open(filename)
        xlhojas = xlLibro.Sheets
        xlHoja1 = CType(xlhojas("Hoja1"), Excel._Worksheet)
        Dim cantidad As String, pcosto As String, pventa As String
        Dim nombre_proveedor As String
        Dim regPro As New RegistroProveedor
        Dim dt As DataTable
        Dim codigo_barras As String, descripcion As String
        Dim facArt As New FachadaArticulo
        Dim art As Articulo
        Dim i As Integer
        i = 9

        nombre_proveedor = xlHoja1.Range("B3").Value.ToString
        dt = regPro.listarPorNombre(nombre_proveedor)
        Try
            comp.IdProveedor = dt.Rows(0).Item("idProveedor")
        Catch ex As IndexOutOfRangeException
            Throw New Exception("El proveedor no ha sido encontrado, cambie el nombre de este en el archivo de excel por uno existente.")
        End Try
        comp.FechaEmision = xlHoja1.Range("B4").Value.ToString
        Dim renglon As RenglonComprobante

        codigo_barras = xlHoja1.Range("A9").Value.ToString
        While codigo_barras <> "FIN"
            descripcion = xlHoja1.Range("B" & i).Value.ToString
            cantidad = xlHoja1.Range("C" & i).Value.ToString
            pcosto = xlHoja1.Range("D" & i).Value.ToString
            pventa = xlHoja1.Range("E" & i).Value.ToString
            art = facArt.TraerArticulo(codigo_barras)
            If IsNothing(art) Then
                'busco el articulo por descripcion
                art = facArt.TraerArticuloPorDescripcion(descripcion)
            End If
            If IsNothing(art) Or codigo_barras = "" Then
                art = New Articulo
                art.Precio = pventa
                art.Costo = pcosto
                art.Descripcion = descripcion
                RaiseEvent ArticuloNoEncontrado(descripcion, cantidad, codigo_barras, art)
                i += 1
                codigo_barras = xlHoja1.Range("A" & i).Value.ToString
                Continue While
            End If
            renglon = New RenglonComprobante
            renglon.Cantidad = cantidad
            renglon.PrecioUnitario = pcosto
            art.Precio = pventa
            art.Costo = pcosto
            art.Descripcion = descripcion
            renglon.Descripcion = art.Descripcion
            renglon.Articulo = art
            comp.Renglones.Add(renglon)

            i += 1
            If Not IsNothing(xlHoja1.Range("A" & i).Value) Then
                codigo_barras = xlHoja1.Range("A" & i).Value.ToString
            Else
                codigo_barras = ""
            End If


            RaiseEvent AgregarRenglonCompra(art.IdArticulo, renglon.Cantidad, art.Costo, art.Precio)
        End While


        xlLibro.Close()
        xlApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlLibro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        Return comp



    End Function
End Class
