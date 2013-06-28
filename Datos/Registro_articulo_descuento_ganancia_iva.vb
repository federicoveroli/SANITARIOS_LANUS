
Imports Modelo
Imports MySql.Data.MySqlClient

Public Class Registro_articulo_descuento_ganancia_iva
    Public Sub ingresarArticulo_descuento_ganancia_iva(ByVal art_descuento_ganancia_iva As Articulo_descuento_ganancia_iva)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("indto1", art_descuento_ganancia_iva.Descuento1))
        params.Add(New MySqlParameter("indto2", art_descuento_ganancia_iva.Descuento2))
        params.Add(New MySqlParameter("indto3", art_descuento_ganancia_iva.Descuento3))
        params.Add(New MySqlParameter("indto4", art_descuento_ganancia_iva.Descuento4))
        params.Add(New MySqlParameter("ingcia1", art_descuento_ganancia_iva.Ganancia1))
        params.Add(New MySqlParameter("ingcia2", art_descuento_ganancia_iva.Ganancia2))
        params.Add(New MySqlParameter("ingcia3", art_descuento_ganancia_iva.Ganancia3))
        params.Add(New MySqlParameter("ingcia4", art_descuento_ganancia_iva.Ganancia4))
        params.Add(New MySqlParameter("inpreciolistaproveedor", art_descuento_ganancia_iva.PrecioListaProveedor))
        params.Add(New MySqlParameter("inIva", art_descuento_ganancia_iva.IVA))
        params.Add(New MySqlParameter("inidArticulo", art_descuento_ganancia_iva.IdArticulo))
        AccesoDatos.Instancia.EjecutarComando("Articulo_descuento_ganancia_iva_insert", params)

    End Sub

    Public Sub Modificar_Articulo_descuento_ganancia_iva(ByVal art_descuento_ganancia_iva As Articulo_descuento_ganancia_iva) 'lo modifico en la base
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdArticulo", art_descuento_ganancia_iva.IdArticulo))
        params.Add(New MySqlParameter("indto1", art_descuento_ganancia_iva.Descuento1))
        params.Add(New MySqlParameter("indto2", art_descuento_ganancia_iva.Descuento2))
        params.Add(New MySqlParameter("indto3", art_descuento_ganancia_iva.Descuento3))
        params.Add(New MySqlParameter("indto4", art_descuento_ganancia_iva.Descuento4))
        params.Add(New MySqlParameter("ingcia1", art_descuento_ganancia_iva.Ganancia1))
        params.Add(New MySqlParameter("ingcia2", art_descuento_ganancia_iva.Ganancia2))
        params.Add(New MySqlParameter("ingcia3", art_descuento_ganancia_iva.Ganancia3))
        params.Add(New MySqlParameter("ingcia4", art_descuento_ganancia_iva.Ganancia4))
        params.Add(New MySqlParameter("inpreciolistaproveedor", art_descuento_ganancia_iva.PrecioListaProveedor))
        params.Add(New MySqlParameter("inIva", art_descuento_ganancia_iva.IVA))

        AccesoDatos.Instancia.EjecutarComando("articulo_descuento_ganancia_iva_update", params)
    End Sub
    Private Function MapearArticulo(ByVal fila As DataRow) As Articulo_descuento_ganancia_iva

        Dim art As New Articulo_descuento_ganancia_iva

        art.Descuento1 = fila("dto1")
        art.Descuento2 = fila("dto2")
        art.Descuento3 = fila("dto3")
        art.Descuento4 = fila("dto4")
        art.Ganancia1 = fila("gcia1")
        art.Ganancia2 = fila("gcia2")
        art.Ganancia3 = fila("gcia3")
        art.Ganancia4 = fila("gcia4")
        art.IdArticulo = fila("idarticulo")
        art.IVA = fila("iva")
        art.PrecioListaProveedor = fila("PrecioListaProveedor")

        Return art

    End Function

    Public Function traerArticuloPorId(ByVal idArticulo As Integer) As Articulo_descuento_ganancia_iva
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select * from Articulo_descuento_ganancia_iva where idarticulo=" & CStr(idArticulo))
        Dim art As New Articulo_descuento_ganancia_iva
        If dt.Rows.Count = 0 Then Return Nothing ' OJO LIBERE A FRANKY.... MODIF MATI

        Dim fila As DataRow = dt.Rows(0)

        art = MapearArticulo(fila)

        Return art
    End Function


    Public Function listarArticulosConDescYGcias() As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo")
        'For Each r As DataRow In dt.Rows
        '    r.Item("Prec Lista Prov") = Math.Round(CDbl(r.Item("Prec Lista Prov")), 3).ToString()
        'Next
        Return dt
    End Function

    Public Sub ModificacionPrecioListaProveedor(ByVal IdsAactualizar As String, ByVal variable As Double)
        AccesoDatos.Instancia.EjecutarConsulta("update articulo_descuento_ganancia_iva set precioListaProveedor=precioListaProveedor + precioListaProveedor  * " & variable.ToString().Replace(",", ".") & "/100 where idarticulo in(" & IdsAactualizar & ")")
    End Sub

    Public Sub ModificarPrecioCostoyPrecioDeVenta(ByVal listaDeAdgi As List(Of Articulo_descuento_ganancia_iva))
        For Each adgi As Articulo_descuento_ganancia_iva In listaDeAdgi

            Dim RdoDesc1 As Double, RdoDesc2 As Double, RdoDesc3 As Double, RdoDesc4 As Double
            Dim PrecioListaProveedor As Double
            Dim precioCostoConIVA As Double = 0

            'calculo los desc
            PrecioListaProveedor = adgi.PrecioListaProveedor
            RdoDesc1 = PrecioListaProveedor - (PrecioListaProveedor * adgi.Descuento1 / 100)
            RdoDesc2 = RdoDesc1 - (RdoDesc1 * adgi.Descuento2 / 100)
            RdoDesc3 = RdoDesc2 - (RdoDesc2 * adgi.Descuento3 / 100)
            RdoDesc4 = RdoDesc3 - (RdoDesc3 * adgi.Descuento4 / 100)
            precioCostoConIVA = Math.Round(RdoDesc4 + (RdoDesc4 * adgi.IVA / 100), 3)

            'calculo la ganancia
            Dim RdoGcia1 As Double, RdoGcia2 As Double, RdoGcia3 As Double, RdoGcia4 As Double
            Dim Precio As Double
            Dim precioFinal As Double = 0
            Dim precioBaseParaCalcularGanancia As Double = 0
            precioBaseParaCalcularGanancia = precioCostoConIVA
            RdoGcia1 = precioBaseParaCalcularGanancia + (precioBaseParaCalcularGanancia * adgi.Ganancia1 / 100)
            RdoGcia2 = RdoGcia1 + (RdoGcia1 * adgi.Ganancia2 / 100)
            RdoGcia3 = RdoGcia2 + (RdoGcia2 * adgi.Ganancia3 / 100)
            RdoGcia4 = RdoGcia3 + (RdoGcia3 * adgi.Ganancia4 / 100)
            precioFinal = Math.Round(RdoGcia4, 3)


            'lo persisto en la bd
            AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo = " & precioCostoConIVA.ToString().Replace(",", ".") & " , precio = " & precioFinal.ToString().Replace(",", ".") & " where articulo.idarticulo = " & adgi.IdArticulo)

        Next
    End Sub
    Public Sub ModificarDescuentos(ByVal IdsAactualizar As String, ByVal listaDeDescuentos As List(Of Double), ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva))
        AccesoDatos.Instancia.EjecutarConsulta("update articulo_descuento_ganancia_iva set dto1= " & listaDeDescuentos(0).ToString().Replace(",", ".") & " , dto2 = " & listaDeDescuentos(1).ToString().Replace(",", ".") & " , dto3 = " & listaDeDescuentos(2).ToString().Replace(",", ".") & ", dto4 =  " & listaDeDescuentos(3).ToString().Replace(",", ".") & " where articulo_descuento_ganancia_iva.idarticulo in (" & IdsAactualizar & ")")
        Dim precioCostoMasIva As Double = 0
        For Each adgi As Articulo_descuento_ganancia_iva In listaadgi
            precioCostoMasIva = adgi.PrecioListaProveedor - (adgi.PrecioListaProveedor * listaDeDescuentos(0) / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(1) / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(2) / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(3) / 100)
            precioCostoMasIva = Math.Round(precioCostoMasIva + (precioCostoMasIva * 21 / 100), 3)

            Dim RdoGcia As Double = 0
            Dim precioBaseParaCalcularGanancia As Double
            precioBaseParaCalcularGanancia = precioCostoMasIva

            RdoGcia = precioBaseParaCalcularGanancia + (precioBaseParaCalcularGanancia * adgi.Ganancia1 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia2 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia3 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia4 / 100)
            RdoGcia = Math.Round(RdoGcia, 3)

            AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo = " & precioCostoMasIva.ToString().Replace(",", ".") & " , precio = " & RdoGcia.ToString().Replace(",", ".") & " where articulo.idarticulo = " & adgi.IdArticulo)

        Next
    End Sub
    ' ESTE METODO UTILIZARÁ EL SIGUIENTE PROTOCOLO, ACTUALIZARÁ LOS DESCUENTOS DISTINTO DE -1
    ' SI ES DISTINTO DE -1 REALIZARÁ EL CALCULO DEL NUEVO DESCUENTO
    Public Sub ModificarDescuento(ByVal IdsAactualizar As String, ByVal listaDeDescuentos As List(Of Double), ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva))
        Dim consulta As String
        consulta = "update articulo_descuento_ganancia_iva set"
        If listaDeDescuentos(0) <> -1 Then
            consulta += " dto1= " & listaDeDescuentos(0).ToString().Replace(",", ".") & " "
        End If
        If listaDeDescuentos(1) <> -1 Then
            If consulta.Contains("dto1") Then consulta += ", "
            consulta += " dto2 = " & listaDeDescuentos(1).ToString().Replace(",", ".")
        End If
        If listaDeDescuentos(2) <> -1 Then
            If consulta.Contains("dto2") Then consulta += ", "
            consulta += " dto3 = " & listaDeDescuentos(2).ToString().Replace(",", ".")
        End If
        If listaDeDescuentos(3) <> -1 Then
            If consulta.Contains("dto3") Then consulta += ", "
            consulta += " dto4 =  " & listaDeDescuentos(3).ToString().Replace(",", ".")
        End If
        consulta += " where articulo_descuento_ganancia_iva.idarticulo in (" & IdsAactualizar & ")"


        AccesoDatos.Instancia.EjecutarConsulta(consulta)

        Dim precioCostoMasIva As Double = 0
        For Each adgi As Articulo_descuento_ganancia_iva In listaadgi


            If listaDeDescuentos(0) <> -1 Then
                precioCostoMasIva = adgi.PrecioListaProveedor - (adgi.PrecioListaProveedor * listaDeDescuentos(0) / 100)
            Else
                precioCostoMasIva = adgi.PrecioListaProveedor
            End If
            If listaDeDescuentos(1) <> -1 Then
                precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(1) / 100)
            End If
            If listaDeDescuentos(2) <> -1 Then
                precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(2) / 100)
            End If
            If listaDeDescuentos(3) <> -1 Then
                precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * listaDeDescuentos(3) / 100)
            End If

            precioCostoMasIva = Math.Round(precioCostoMasIva + (precioCostoMasIva * 21 / 100), 3)

            Dim RdoGcia As Double = 0
            Dim precioBaseParaCalcularGanancia As Double
            precioBaseParaCalcularGanancia = precioCostoMasIva

            RdoGcia = precioBaseParaCalcularGanancia + (precioBaseParaCalcularGanancia * adgi.Ganancia1 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia2 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia3 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia4 / 100)
            RdoGcia = Math.Round(RdoGcia, 3)

            AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo = " & precioCostoMasIva.ToString().Replace(",", ".") & " , precio = " & RdoGcia.ToString().Replace(",", ".") & " where articulo.idarticulo = " & adgi.IdArticulo)

        Next
    End Sub

    Public Sub ModificarDescuento1(ByVal IdsAactualizar As String, ByVal Dto1 As Double, ByVal Dto2 As Double, ByVal Dto3 As Double, ByVal Dto4 As Double, ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva))
        AccesoDatos.Instancia.EjecutarConsulta("update articulo_descuento_ganancia_iva set dto1= " & Dto1.ToString().Replace(",", ".") & " where articulo_descuento_ganancia_iva.idarticulo in (" & IdsAactualizar & ")")
        Dim precioCostoMasIva As Double = 0
        For Each adgi As Articulo_descuento_ganancia_iva In listaadgi
            precioCostoMasIva = adgi.PrecioListaProveedor - (adgi.PrecioListaProveedor * Dto1 / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * Dto2 / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * Dto3 / 100)
            precioCostoMasIva = precioCostoMasIva - (precioCostoMasIva * Dto4 / 100)
            precioCostoMasIva = Math.Round(precioCostoMasIva + (precioCostoMasIva * 21 / 100), 3)

            Dim RdoGcia As Double = 0
            Dim precioBaseParaCalcularGanancia As Double
            precioBaseParaCalcularGanancia = precioCostoMasIva

            RdoGcia = precioBaseParaCalcularGanancia + (precioBaseParaCalcularGanancia * adgi.Ganancia1 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia2 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia3 / 100)
            RdoGcia = RdoGcia + (RdoGcia * adgi.Ganancia4 / 100)
            RdoGcia = Math.Round(RdoGcia, 3)

            AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo = " & precioCostoMasIva.ToString().Replace(",", ".") & " , precio = " & RdoGcia.ToString().Replace(",", ".") & " where articulo.idarticulo = " & adgi.IdArticulo)

        Next
    End Sub

    Public Sub ModificarUtilidades(ByVal IdsAactualizar As String, ByVal listaDeDescuentos As List(Of Double), ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva), ByVal articulos As List(Of Articulo))
        AccesoDatos.Instancia.EjecutarConsulta("update articulo_descuento_ganancia_iva set gcia1= " & listaDeDescuentos(0).ToString().Replace(",", ".") & " , gcia2 = " & listaDeDescuentos(1).ToString().Replace(",", ".") & " , gcia3 = " & listaDeDescuentos(2).ToString().Replace(",", ".") & ", gcia4 =  " & listaDeDescuentos(3).ToString().Replace(",", ".") & " where articulo_descuento_ganancia_iva.idarticulo in (" & IdsAactualizar & ")")
        Dim precioCostoMasIva As Double = 0
        Dim index As Integer = 0
        For Each adgi As Articulo_descuento_ganancia_iva In listaadgi
            Dim RdoGcia As Double = 0
            Dim art As Articulo
            Dim precioBaseParaCalcularGanancia As Double
            art = articulos(index)
            precioBaseParaCalcularGanancia = art.Costo
            RdoGcia = precioBaseParaCalcularGanancia + (precioBaseParaCalcularGanancia * listaDeDescuentos(0) / 100)
            RdoGcia = RdoGcia + (RdoGcia * listaDeDescuentos(1) / 100)
            RdoGcia = RdoGcia + (RdoGcia * listaDeDescuentos(2) / 100)
            RdoGcia = RdoGcia + (RdoGcia * listaDeDescuentos(3) / 100)
            RdoGcia = Math.Round(RdoGcia, 3)
            AccesoDatos.Instancia.EjecutarConsulta("update articulo set precio = " & RdoGcia.ToString().Replace(",", ".") & " where articulo.idarticulo = " & adgi.IdArticulo)
            index = index + 1
        Next
    End Sub

    Public Function TraerArticuloPorDescripcion(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where a.descripcion like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TraerArticuloPorCodBarras(ByVal codigo_barras As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where a.cod_barra = '" & codigo_barras & "'")
        Return dt
    End Function
    Public Function TaerArticuloXTipo(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where ca.descripcion like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXMarca(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where m.descripcion like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXProveedor(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where p.razonsocial like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXCodBarras(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',m.descripcion as 'Marca',p.razonsocial as 'Provedor',adgi.precioListaProveedor as 'Prec Lista Prov',adgi.dto1 as 'Desc 1',adgi.dto2 as 'Desc 2',adgi.dto3 as 'Desc 3',adgi.dto4 as 'Desc 4',a.costo as 'Prec costo',adgi.gcia1 as 'Gcia 1',adgi.gcia2 as 'Gcia 2',adgi.gcia3 as 'Gcia 3',adgi.gcia4 as 'Gcia 4',a.precio as 'Prec vta',a.stock as 'Stock' , a.cod_barra as 'Cod barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	inner join articulo_descuento_ganancia_iva adgi on adgi.idArticulo = a.idarticulo	where cod_barra like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
End Class
