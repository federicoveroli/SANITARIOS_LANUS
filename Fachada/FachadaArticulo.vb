Imports Modelo
Imports Datos
Imports System.Windows.Forms
Imports Microsoft.Office.Interop

Public Class FachadaArticulo
    Public Sub aumentarprecio(ByVal IdsAactualizar As String, ByVal variable As Double)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ModificarCostoDeArticulos(IdsAactualizar, variable)
    End Sub

    Public Function TraerNuevoIdArticulo() As Integer
        Dim idArt As Integer
        idArt = AccesoDatos.Instancia.EjecutarConsulta("select max(idArticulo) from articulo").Rows(0).Item(0)
        idArt = idArt + 1
        Return idArt
    End Function

    Public Sub cambiarrprecio(ByVal IdsAactualizar As String, ByVal variable As Double)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ModificarCostoFijoDeArticulos(IdsAactualizar, variable)
    End Sub

    Public Sub CambiarStock(ByVal IdsAactualizar As String, ByVal variable As Double)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ModificarStockFijoDeArticulos(IdsAactualizar, variable)
    End Sub

    Public Sub ingresarArticulo(ByVal art As Articulo)
        Dim regArticulo As New RegistroArticulo
        'verifico si esta disponible le codigo de barra.
        If art.CodBarra.Length = 0 Then
            regArticulo.ingresarArticulo(art)
            Exit Sub
        End If

        If regArticulo.EstaDisponible(art.CodBarra) Then
            If regArticulo.EstaDisponible(art.IdArticulo) Then
                regArticulo.ingresarArticulo(art)
            Else
                Throw New IdNoDisponibleException()
            End If
        Else
            Throw New CodigoBarraNoDisponibleException()

        End If
    End Sub

    Public Sub ActualizarArticulo(ByVal art As Articulo)
        Dim regArticulo As New RegistroArticulo
        'busco el id del articulo
        Dim idArticulo As Integer
        idArticulo = regArticulo.traerArticuloPorBarCode(art.CodBarra).IdArticulo
        art.IdArticulo = idArticulo
        'modifico el articulo
        regArticulo.modificarArticulo2(art)

    End Sub

    Public Function TraerArticulo(ByVal idArt As Integer) As Articulo
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.traerArticuloPorId(idArt)
    End Function
    Public Function TraerArticulo(ByVal cod_barras As String, ByVal Proveedor As String) As Articulo
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.traerArticuloPorBarCodeYProveedor(cod_barras, Proveedor)
    End Function
    Public Function TraerArticuloPorDescripcion(ByVal descripcion As String, ByVal proveedor As String) As Articulo
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.BuscarArticuloPorDescripcion(descripcion, proveedor)
    End Function

    Public Function TraerArticulo(ByVal cod_barras As String) As Articulo
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.traerArticuloPorBarCode(cod_barras)
    End Function

    Public Function TraerArticuloPorDescripcion(ByVal descripcion As String) As Articulo
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.BuscarArticuloPorDescripcion(descripcion)
    End Function

    Public Function ListarArticulosXIds(ByVal ids As String) As DataTable
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.ListarArticulosXIds(ids)
    End Function
    Public Function listarArticulos() As DataTable
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.listarArticulos()
    End Function
    Public Function listarArticulosPorReponer() As DataTable
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.listarArticulosPorReponer()
    End Function
    Public Function ListarArticulosXTipo(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TaerArticuloXTipo(d)
    End Function
    Public Function ListarArticulosXDescripcion(ByVal Criterio1 As String, ByVal Criterio2 As String, ByVal Criterio3 As String) As DataTable
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TraerArticuloPorDescripcion(Criterio1, Criterio2, Criterio3)
    End Function

    Public Function ListarArticulosXCodBarras(ByVal codigo_barras As String) As DataTable

        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TraerArticuloPorCodBarras(codigo_barras)
    End Function
    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.EjecutarConsulta(consulta)
    End Function
    Public Function ListarArticulosXMarca(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TaerArticuloXMarca(d)
    End Function
    Public Function ListarArticulosXProveedor(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TaerArticuloXProveedor(d)
    End Function

    Public Function ListarArticulosXCodBarrasDT(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Dim RegArticulo As New RegistroArticulo
        Return RegArticulo.TaerArticuloXCodBarras(desc)
    End Function
    Public Function modificarArticulo(ByVal idArticulo As Integer) 'lo traigo de la base y lo muestro en el formulario de alta
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.modificarArticulo(idArticulo)
    End Function
    Public Sub ModificarArticulo2(ByVal art As Articulo) 'lo modifico en la base
        Dim regArticulo As New RegistroArticulo
        regArticulo.modificarArticulo2(art)
    End Sub
    Public Sub eliminarArticulo(ByVal idArticulo As Integer)
        Dim regArticulo As New RegistroArticulo
        regArticulo.eliminarArticulo(idArticulo)
    End Sub
   
    Public Function listarCategoriasArticulos() As List(Of TipoArticulo)
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.listarCategoriasArticulo()
    End Function
    Public Function traerTipoPorId(ByVal idTipo As Integer) As String
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.traerTipoPorId(idTipo)
    End Function
    Public Function traerMarcaPorId(ByVal idMarca As Integer) As String
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.TraerMarcaPorId(idMarca)
    End Function
    Public Sub ingresarTipo(ByVal descripcion As String)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ingresarCategoriaArticulo(descripcion)
    End Sub
    Public Function listarMarcas() As List(Of Marca)
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.listarMarcas()
    End Function
    Public Sub ingresarMarca(ByVal descripcion As String)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ingresarMarca(descripcion)
    End Sub
    Public Sub ReemplazarArticulos(ByVal cons As String)
        Dim regArticulo As New RegistroArticulo
        regArticulo.ReemplazoDeArticulos(cons)
    End Sub
    'Public Function traerIDSdearticulos(ByVal precio As Double)
    '    Dim reg As New RegistroArticulo
    '    return reg.
    'End Function
    Public Function TRAERtodosLOSarticulosDEvalmar()
        Dim dt As DataTable
        Dim r As New RegistroArticulo
        dt = r.TRAERarticulosDEvalmar
        Return dt
    End Function
    Public Function TraerCategoriasDeValmar()
        Dim dt As DataTable
        Dim fachada As New RegistroArticulo
        dt = fachada.TrAeRCatValmAR
        Return dt
    End Function
    Public Function TraerMarcasDeValmar()
        Dim dt As DataTable
        Dim fachada As New RegistroArticulo
        dt = fachada.TrAeRMarcasValmAR
        Return dt
    End Function
    Public Function ProveedoresValmar()
        Dim dt As DataTable
        Dim fachada As New RegistroArticulo
        dt = fachada.TrAeRProveedoresValmar
        Return dt
    End Function
    Public Function traerIDSdeMIbaseCAT(ByVal desc As String) As DataTable
        Dim dt As DataTable
        Dim d As New RegistroArticulo
        dt = d.TraeridsDecatego(desc)
        Return dt
    End Function
    Public Function traerDESCvalmar()
        Dim dt As DataTable
        Dim r As New RegistroArticulo
        dt = r.TraerDESCdeVALMAR
        Return dt
    End Function
    Public Function traerIdProveedor()
        Dim dt As DataTable
        Dim r As New RegistroArticulo
        dt = r.TraerDESCdeVALMAR
        Return dt
    End Function
    Public Function TraerIdMarcaPorDescripcion(ByVal descripcion As String) As Integer
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.TraerIdMarcaPorDescripcion(descripcion)
    End Function
    Public Sub eliminarTipoArticulo(ByVal idTipo As Integer)
        Dim regArticulo As New RegistroArticulo
        regArticulo.eliminarTipoArticulo(idTipo)
    End Sub
    Public Sub eliminarMarca(ByVal idMarca As Integer)
        Dim regArticulo As New RegistroArticulo
        regArticulo.eliminarMarca(idMarca)
    End Sub
    Public Function TieneArticulosTipoArticulo(ByVal idtipo As Integer) As Boolean
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.TieneArticulosTipoArticulo(idtipo)
    End Function
    Public Function TieneArticulosMarca(ByVal idMarca As Integer) As Boolean
        Dim regArticulo As New RegistroArticulo
        Return regArticulo.TieneArticulosMarca(idMarca)
    End Function
    Public Sub grabarScript()
        AccesoDatos.Instancia.IniciarGrabacion()
    End Sub
    Public Sub pararScript(ByVal filePath As String)
        AccesoDatos.Instancia.FinalizarGrabacion(filePath)
    End Sub
    Public Sub pararScript()
        AccesoDatos.Instancia.FinalizarGrabacion()
    End Sub

    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim regArt As New RegistroArticulo
        Dim dt As DataTable = regArt.listarParaCombo()
        Dim idArt As IdArticulo
        combo.Items.Clear()
        For Each fila As DataRow In dt.Rows
            idArt = New IdArticulo
            idArt.Id = fila("idArticulo")
            idArt.Descripcion = fila("descripcion")
            combo.Items.Add(idArt)
        Next
    End Sub
    Public Sub ImportarDesdeExcel(ByVal filename As String, ByVal txtInfo As TextBox, ByVal progressBar As ProgressBar)

        txtInfo.Text = "Comenzando la importación..."
        'Hago el proceso de cargar la compra desde el excel

        Dim xlApp As Excel._Application
        Dim xlLibro As Excel._Workbook
        Dim xlHoja1 As Excel._Worksheet
        Dim xlhojas As Excel.Sheets
        xlApp = New Excel.Application
        xlApp.Visible = False
        xlLibro = xlApp.Workbooks.Open(filename)
        xlhojas = xlLibro.Sheets
        xlHoja1 = CType(xlhojas("Hoja1"), Excel._Worksheet)
        Dim cantidad As String, pcosto As String, pventa As String, marca As String, categoriaArticulo As String

        Dim nombre_proveedor As String
        Dim regPro As New RegistroProveedor
        Dim dt As DataTable
        Dim codigo_barras As String, descripcion As String
        Dim facArt As New FachadaArticulo
        Dim art As Articulo
        Dim i As Integer
        Dim IdProveedor As Integer
        i = 8

        nombre_proveedor = xlHoja1.Range("B4").Value.ToString.ToUpper
        dt = regPro.listarPorNombre(nombre_proveedor)
        Try
            IdProveedor = dt.Rows(0).Item("idProveedor")
        Catch ex As IndexOutOfRangeException
            Throw New Exception("El proveedor no ha sido encontrado, cambie el nombre de este en el archivo de excel por uno existente.")
        End Try


        Try


            descripcion = xlHoja1.Range("B" & i).Value.ToString.ToUpper.Replace("'", " ")


            Dim facrubro As New FachadaRubro
            Dim idMarca As Integer
            Dim idCategoriaArticulo As Integer
            Dim utilidad As String
            Dim descuento As String
            Dim ptoRep As String
            Dim regArt As New RegistroArticulo
            Dim artCosto As New Articulo_descuento_ganancia_iva
            Dim facArtCosto As New FachadaArticuloDescuentoGananciaIva


            While descripcion <> "" 'codigo_barras <> "FIN"

                txtInfo.Text = "Procesando fila " & i

                If progressBar.Value = 100 Then progressBar.Value = 0

                progressBar.Value += 1

                If Not IsNothing(xlHoja1.Range("A" & i).Value) Then
                    codigo_barras = xlHoja1.Range("A" & i).Value.ToString
                Else
                    codigo_barras = ""
                End If
                descripcion = xlHoja1.Range("B" & i).Value.ToString.ToUpper.Replace("'", " ")
                cantidad = xlHoja1.Range("C" & i).Value.ToString
                marca = xlHoja1.Range("D" & i).Value.ToString.ToUpper.Trim
                categoriaArticulo = xlHoja1.Range("E" & i).Value.ToString.ToUpper.Trim
                utilidad = 0
                descuento = 0
                ptoRep = xlHoja1.Range("F" & i).Value.ToString

                'busco la marca y si no existe la doy de alta
                idMarca = facArt.TraerIdMarcaPorDescripcion(marca)
                If idMarca = 6 Then 'es una inexistente
                    facArt.ingresarMarca(marca)
                    idMarca = facArt.TraerIdMarcaPorDescripcion(marca)
                End If

                idCategoriaArticulo = regArt.listarIdCategoriaPorDescripcion(categoriaArticulo) 'facrubro.traerIdRubroXdescripcion(rubro)

                If idCategoriaArticulo = 0 Then 'es una inexistente
                    regArt.ingresarCategoriaArticulo(categoriaArticulo)
                    idCategoriaArticulo = regArt.listarIdCategoriaPorDescripcion(categoriaArticulo)
                End If

                pcosto = xlHoja1.Range("U" & i).Value.ToString 'como precio de costo guardamos el precio de lista
                pventa = xlHoja1.Range("Z" & i).Value.ToString
                If codigo_barras <> "" Then
                    art = facArt.TraerArticulo(codigo_barras, nombre_proveedor)
                End If

                If IsNothing(art) Then
                    'busco el articulo por descripcion
                    art = facArt.TraerArticuloPorDescripcion(descripcion, nombre_proveedor)
                End If
                If IsNothing(art) Then 'lo damos de alta
                    art = New Articulo
                    art.Precio = Math.Round(CDbl(pventa), 2)
                    art.Costo = Math.Round(CDbl(pcosto), 2)
                    art.Descripcion = descripcion.Trim
                    art.Utilidad = Math.Round(CDbl(utilidad), 2)
                    art.PorcDesc = Math.Round(CDbl(descuento), 2)
                    art.IdMarca = idMarca
                    art.Stock = cantidad
                    art.Idcategoria = idCategoriaArticulo
                    art.Idproveedor = IdProveedor
                    art.PtoReposicion = ptoRep
                    art.CodBarra = codigo_barras
                    art.Medida = ""
                    'RaiseEvent ArticuloNoEncontrado(descripcion, cantidad, codigo_barras, art)
                    'lo comentamos porque si no encontramos el articulo lo vamos a dar de alta directamente
                    facArt.ingresarArticulo(art)
                    artCosto.Descuento1 = xlHoja1.Range("H" & i).Value.ToString
                    artCosto.Descuento2 = xlHoja1.Range("I" & i).Value.ToString
                    artCosto.Descuento3 = xlHoja1.Range("J" & i).Value.ToString
                    artCosto.Descuento4 = xlHoja1.Range("K" & i).Value.ToString
                    artCosto.Ganancia1 = xlHoja1.Range("L" & i).Value.ToString
                    artCosto.Ganancia2 = xlHoja1.Range("M" & i).Value.ToString
                    artCosto.Ganancia3 = xlHoja1.Range("N" & i).Value.ToString
                    artCosto.Ganancia4 = xlHoja1.Range("O" & i).Value.ToString
                    artCosto.IdArticulo = TraerNuevoIdArticulo() - 1
                    artCosto.IVA = xlHoja1.Range("P" & i).Value.ToString
                    artCosto.PrecioListaProveedor = xlHoja1.Range("G" & i).Value.ToString
                    facArtCosto.ingresarArticulo_descuento_ganancia_iva(artCosto)
                    'i += 1
                    'codigo_barras = xlHoja1.Range("A" & i).Value.ToString
                Else
                    'significa que el articulo existe  
                    art.Precio = Math.Round(CDbl(pventa), 2)
                    art.Costo = Math.Round(CDbl(pcosto), 2)
                    art.Descripcion = descripcion
                    art.Utilidad = Math.Round(CDbl(utilidad), 2)
                    art.PorcDesc = Math.Round(CDbl(descuento), 2)
                    art.IdMarca = idMarca
                    art.Idcategoria = idCategoriaArticulo
                    art.Idproveedor = IdProveedor
                    art.PtoReposicion = ptoRep
                    art.CodBarra = codigo_barras
                    art.Medida = ""
                    art.Stock += cantidad
                    facArt.ModificarArticulo2(art)
                    artCosto.Descuento1 = xlHoja1.Range("H" & i).Value.ToString
                    artCosto.Descuento2 = xlHoja1.Range("I" & i).Value.ToString
                    artCosto.Descuento3 = xlHoja1.Range("J" & i).Value.ToString
                    artCosto.Descuento4 = xlHoja1.Range("K" & i).Value.ToString
                    artCosto.Ganancia1 = xlHoja1.Range("L" & i).Value.ToString
                    artCosto.Ganancia2 = xlHoja1.Range("M" & i).Value.ToString
                    artCosto.Ganancia3 = xlHoja1.Range("N" & i).Value.ToString
                    artCosto.Ganancia4 = xlHoja1.Range("O" & i).Value.ToString
                    artCosto.IdArticulo = art.IdArticulo
                    artCosto.IVA = xlHoja1.Range("P" & i).Value.ToString
                    artCosto.PrecioListaProveedor = xlHoja1.Range("G" & i).Value.ToString
                    facArtCosto.Modificar_Articulo_descuento_ganancia_iva(artCosto)

                End If
                art = Nothing
                i += 1
                If Not IsNothing(xlHoja1.Range("B" & i).Value) Then
                    descripcion = xlHoja1.Range("B" & i).Value.ToString.ToUpper.Trim.Replace("'", " ")
                Else
                    descripcion = ""
                End If


                ' RaiseEvent AgregarRenglonCompra(art.IdArticulo, renglon.Cantidad, art.Costo, art.Precio)
            End While

            progressBar.Value = 100
            txtInfo.Text = "Listo!"


        Catch ex As Exception
            Throw New Exception("El archivo no posee el formato adecuado. Error procesando la fila " & i)
        Finally
            xlLibro.Close(0)
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlLibro)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        End Try


    End Sub
End Class
