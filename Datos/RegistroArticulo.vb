Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroArticulo
    Public Sub ingresarArticulo(ByVal art As Articulo)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("stockv", art.Stock))
        params.Add(New MySqlParameter("costo", art.Costo))
        params.Add(New MySqlParameter("utilidad", art.Utilidad))
        params.Add(New MySqlParameter("inDescripcion", art.Descripcion))
        params.Add(New MySqlParameter("precio", art.Precio))
        params.Add(New MySqlParameter("marcas", art.IdMarca))
        params.Add(New MySqlParameter("caegoria", art.Idcategoria))
        params.Add(New MySqlParameter("medidas", art.Medida))
        params.Add(New MySqlParameter("porcdesc", art.PorcDesc))
        params.Add(New MySqlParameter("provee", art.Idproveedor))
        params.Add(New MySqlParameter("inesfraccionable", art.esFraccionable))
        params.Add(New MySqlParameter("inCodBarra", art.CodBarra))
        params.Add(New MySqlParameter("inPtoReposicion", art.PtoReposicion))
        params.Add(New MySqlParameter("idArticulo", art.IdArticulo))
        AccesoDatos.Instancia.EjecutarComando("articulo_insert", params)
    End Sub

    Public Function listarParaCombo() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idArticulo,descripcion from articulo order by descripcion")
    End Function

    Public Function EstaDisponible(ByVal cod_barras As String)
        Dim consultaSQL As String
        consultaSQL = "select * from articulo where cod_barra = '" + cod_barras + "'"
        Dim tabla As New DataTable
        tabla = AccesoDatos.Instancia.EjecutarConsulta(consultaSQL)
        Return Not CBool(tabla.Rows.Count)
    End Function

    Public Function EstaDisponible(ByVal idArticulo As Integer)
        Dim consultaSQL As String
        consultaSQL = "select * from articulo where idArticulo = " & idArticulo
        Dim tabla As New DataTable
        tabla = AccesoDatos.Instancia.EjecutarConsulta(consultaSQL)
        Return Not CBool(tabla.Rows.Count)
    End Function
    Public Function ListarArticulosXIds(ByVal ids As String) As DataTable
        ids = ids.Substring(0, ids.Length - 4)
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'N Articulo', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio al Clie',a.stock as 'Stock' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where a.idArticulo in (" & ids & ")   order by a.descripcion")
        Return dt
    End Function
    Public Function traerTipoPorId(ByVal idTipoArt As Integer) As String
        Return AccesoDatos.Instancia.EjecutarConsulta("select descripcion from categoriaarticulo where idCategoria=" & idTipoArt).Rows(0).Item(0)
    End Function
    Public Function TraerMarcaPorId(ByVal idMarca As Integer) As String
        Return AccesoDatos.Instancia.EjecutarConsulta("select descripcion from marca where idMarca=" & idMarca).Rows(0).Item(0)
    End Function
    Public Sub ModificarCostoDeArticulos(ByVal IdsAactualizar As String, ByVal variable As Double)

        AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo=costo + costo  * " & variable.ToString().Replace(",", ".") & "/100 where idarticulo in(" & IdsAactualizar & ")")
        AccesoDatos.Instancia.EjecutarConsulta("update articulo set precio=precio + precio * " & variable.ToString().Replace(",", ".") & "/100 where idarticulo in(" & IdsAactualizar & ")")



    End Sub
    Public Sub ModificarCostoFijoDeArticulos(ByVal IdsAactualizar As String, ByVal variable As Double)
        AccesoDatos.Instancia.EjecutarConsulta("update articulo set costo= " & variable.ToString().Replace(",", ".") & " where idarticulo in ( " & IdsAactualizar.Substring(0, IdsAactualizar.Length) & " )")
        AccesoDatos.Instancia.EjecutarConsulta("update articulo set precio= " & variable.ToString().Replace(",", ".") & " where idarticulo in ( " & IdsAactualizar.Substring(0, IdsAactualizar.Length) & " )")
    End Sub

    Public Sub ModificarStockFijoDeArticulos(ByVal IdsAactualizar As String, ByVal variable As Integer)
        AccesoDatos.Instancia.EjecutarConsulta("update articulo set stock= " & variable & " where idarticulo in ( " & IdsAactualizar.Substring(0, IdsAactualizar.Length) & " )")
    End Sub

    Public Function EjecutarConsulta(ByVal consulta As String)
        Return AccesoDatos.Instancia.EjecutarConsulta(consulta)
    End Function
  
    Public Function listarArticulos() As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	order by descripcion")
        Return dt
    End Function

    Public Function listarArticulosPorReponer() As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio al Clie',a.stock as 'Stock' , (stock - pto_reposicion) as 'Diferencia'  from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	 order by (stock - pto_reposicion) asc")
        Return dt
    End Function
    Public Function traerArticuloPorId(ByVal id As Integer) As Articulo
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select * from Articulo where idarticulo=" & CStr(id))
        Dim art As New Articulo
        Dim fila As DataRow = dt.Rows(0)
        art.Costo = fila("costo")
        art.Descripcion = fila("descripcion")
        art.IdArticulo = fila("idArticulo")
        art.Idcategoria = fila("idCategoria")
        art.IdMarca = fila("idMarca")
        art.Idproveedor = fila("Idproveedor")
        art.Medida = fila("medida")
        art.PorcDesc = fila("porcentajedescuento")
        art.Precio = fila("precio")
        art.Stock = fila("stock")
        art.Utilidad = fila("utilidad")
        art.esFraccionable = fila("esfraccionable")
        art.PtoReposicion = fila("pto_reposicion")
        art.CodBarra = fila("cod_barra")
        Return art
    End Function

    Public Function traerArticuloPorBarCode(ByVal cod_barra As String) As Articulo
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select * from Articulo where cod_barra= '" & cod_barra & "'")
        Dim art As New Articulo
        If dt.Rows.Count = 0 Then Return Nothing
        Dim fila As DataRow = dt.Rows(0)
        art.Costo = fila("costo")
        art.Descripcion = fila("descripcion")
        art.IdArticulo = fila("idArticulo")
        art.Idcategoria = fila("idCategoria")
        art.IdMarca = fila("idMarca")
        art.Idproveedor = fila("Idproveedor")
        art.Medida = fila("medida")
        art.PorcDesc = fila("porcentajedescuento")
        art.Precio = fila("precio")
        art.Stock = fila("stock")
        art.Utilidad = fila("utilidad")
        art.esFraccionable = fila("esfraccionable")
        art.PtoReposicion = fila("pto_reposicion")
        art.CodBarra = fila("cod_barra")
        Return art
    End Function

    Public Function BuscarArticuloPorDescripcion(ByVal descripcion As String) As Articulo
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select * from Articulo where descripcion= '" & descripcion & "'")
        Dim art As New Articulo
        If dt.Rows.Count = 0 Then Return Nothing
        Dim fila As DataRow = dt.Rows(0)
        art.Costo = fila("costo")
        art.Descripcion = fila("descripcion")
        art.IdArticulo = fila("idArticulo")
        art.Idcategoria = fila("idCategoria")
        art.IdMarca = fila("idMarca")
        art.Idproveedor = fila("Idproveedor")
        art.Medida = fila("medida")
        art.PorcDesc = fila("porcentajedescuento")
        art.Precio = fila("precio")
        art.Stock = fila("stock")
        art.Utilidad = fila("utilidad")
        art.esFraccionable = fila("esfraccionable")
        art.PtoReposicion = fila("pto_reposicion")
        art.CodBarra = fila("cod_barra")
        Return art
    End Function
    Public Function BuscarArticuloPorDescripcion(ByVal descripcion As String, ByVal Proveedor As String) As Articulo
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select a.* from Articulo a inner join  proveedor p on a.Idproveedor = p.idproveedor where descripcion= '" & descripcion & "' and p.razonsocial='" & Proveedor & "'")
        Dim art As New Articulo
        If dt.Rows.Count = 0 Then Return Nothing
        Dim fila As DataRow = dt.Rows(0)
        art.Costo = fila("costo")
        art.Descripcion = fila("descripcion")
        art.IdArticulo = fila("idArticulo")
        art.Idcategoria = fila("idCategoria")
        art.IdMarca = fila("idMarca")
        art.Idproveedor = fila("Idproveedor")
        art.Medida = fila("medida")
        art.PorcDesc = fila("porcentajedescuento")
        art.Precio = fila("precio")
        art.Stock = fila("stock")
        art.Utilidad = fila("utilidad")
        art.esFraccionable = fila("esfraccionable")
        art.PtoReposicion = fila("pto_reposicion")
        art.CodBarra = fila("cod_barra")
        Return art
    End Function
    Public Sub eliminarTipoArticulo(ByVal idTipo)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inidCat", idTipo))
        AccesoDatos.Instancia.EjecutarComando("categoriaarticulo_delete", params)
    End Sub
    Public Sub eliminarMarca(ByVal idMarca As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdMarca", idMarca))
        AccesoDatos.Instancia.EjecutarComando("marca_delete", params)
    End Sub
    Public Function TraerArticuloPorDescripcion(ByVal Criterio1 As String, ByVal Criterio2 As String, ByVal Criterio3 As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	 where a.descripcion like '%" & Criterio1 & "%'" & " and a.descripcion like '%" & Criterio2 & "%'" & " and a.descripcion like '%" & Criterio3 & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TraerArticuloPorCodBarras(ByVal codigo_barras As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'N Articulo', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio al Clie',a.stock as 'Stock' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where a.cod_barra = '" & codigo_barras & "'")
        Return dt
    End Function
    Public Function TaerArticuloXTipo(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where ca.descripcion like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXMarca(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where m.descripcion like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXProveedor(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where p.razonsocial like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function TaerArticuloXCodBarras(ByVal desc As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select a.idarticulo as 'Id', a.descripcion as 'Descripcion', ca.descripcion as 'Tipo Producto',p.razonsocial as 'Provedor',m.descripcion as 'Marca',a.precio as 'Precio',a.stock as 'Stock' , a.cod_barra as 'Cod de barra' from articulo a inner join categoriaarticulo ca on a.idcategoria = ca.idcategoria inner join proveedor p on a.idproveedor=p.idproveedor inner join marca m on a.idmarca=m.idmarca	where cod_barra like '%" & desc & "%'" & " order by a.descripcion")
        Return dt
    End Function
    Public Function modificarArticulo(ByVal art As Integer) As DataTable 'lo traigo de la base
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from articulo where idarticulo=" & art)
        Return dt
    End Function
    Public Sub eliminarArticulo(ByVal idArticulo As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdArticulo", idArticulo))
        AccesoDatos.Instancia.EjecutarComando("articulo_delete", params)
    End Sub
    Public Function listarCategoriasArticulo() As List(Of TipoArticulo)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from categoriaarticulo order by descripcion")
        Dim fila As DataRow
        Dim objtipoArticulo As tipoArticulo
        listarCategoriasArticulo = New List(Of TipoArticulo)
        For Each fila In dt.Rows
            objtipoArticulo = New TipoArticulo(fila("descripcion"), fila("idCategoria"))
            listarCategoriasArticulo.Add(objtipoArticulo)
        Next
    End Function

    Public Function listarIdCategoriaPorDescripcion(ByVal descripcion As String) As Integer
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from categoriaarticulo where descripcion = '" & descripcion & "'")

        If dt.Rows.Count = 0 Then
            Return 0
        Else
            Return dt.Rows(0).Item("idCategoria")
        End If


    End Function
    Public Sub ingresarCategoriaArticulo(ByVal descripcion As String)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inDescripcion", descripcion))
        AccesoDatos.Instancia.EjecutarComando("categoriaarticulo_insert", params)
    End Sub
    Public Function listarMarcas() As List(Of Marca)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from marca order by descripcion")
        Dim fila As DataRow
        Dim objtipoArticulo As Marca
        listarMarcas = New List(Of Marca)
        For Each fila In dt.Rows
            objtipoArticulo = New Marca(fila("descripcion"), fila("idMarca"))
            listarMarcas.Add(objtipoArticulo)
        Next
    End Function
    Public Sub ingresarMarca(ByVal descripcion As String)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inDescripcion", descripcion))
        AccesoDatos.Instancia.EjecutarComando("marca_insert", params)
    End Sub
    Public Sub modificarArticulo2(ByVal art As Articulo) 'lo modifico en la base
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdArticulo", art.IdArticulo))
        params.Add(New MySqlParameter("incosto", art.Costo))
        params.Add(New MySqlParameter("inStock", art.Stock))
        params.Add(New MySqlParameter("inutilidad", art.Utilidad))
        params.Add(New MySqlParameter("inprecio", art.Precio))
        params.Add(New MySqlParameter("inIdMarca", art.IdMarca))
        params.Add(New MySqlParameter("inDescripcion", art.Descripcion))
        params.Add(New MySqlParameter("inidcategoria", art.Idcategoria))
        params.Add(New MySqlParameter("inmedida", art.Medida))
        params.Add(New MySqlParameter("inporcentajedescuento", art.PorcDesc))
        params.Add(New MySqlParameter("inidproveedor", art.Idproveedor))
        params.Add(New MySqlParameter("inesfraccionable", art.esFraccionable))
        params.Add(New MySqlParameter("inCodBarra", art.CodBarra))
        params.Add(New MySqlParameter("inPtoReposicion", art.PtoReposicion))
        AccesoDatos.Instancia.EjecutarComando("articulo_update", params)
    End Sub
    Public Sub ReemplazoDeArticulos(ByVal cons As String)
        AccesoDatos.Instancia.EjecutarConsulta(cons)
    End Sub

    Public Function TRAERarticulosDEvalmar() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select * from articulos")
    End Function
    Public Function TrAeRCatValmAR() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select distinct(tipo_producto) from articulos")
    End Function
    Public Function TrAeRMarcasValmAR() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select distinct(marca) from articulos")
    End Function
    Public Function TraeridsDecatego(ByVal desc As String) As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select idcategoria from categoriaarticulo where descripcion= '" & desc & "'")

    End Function
    Public Function TraerDESCdeVALMAR() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select * from articulos")
    End Function
    Public Function TraerDESCdeVALMAR1() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select idProveedor from articulos")
    End Function
    Public Function TrAeRProveedoresValmar() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsultaMigracion("select distinct(proveedor) from articulos")
    End Function
    Public Function TraerIdMarcaPorDescripcion(ByVal descripcion As String) As Integer
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select idMarca from Marca where descripcion='" & descripcion & "'")
        If dt.Rows.Count = 0 Then
            Return 6 'es generico
        Else
            Return dt.Rows(0).Item(0)
        End If

    End Function
    Public Function TieneArticulosTipoArticulo(ByVal idtipo As Integer) As Boolean
        Return AccesoDatos.Instancia.EjecutarConsulta("select count(*) from articulo where idCategoria=" & idtipo).Rows(0).Item(0)
    End Function
    Public Function TieneArticulosMarca(ByVal idMarca As Integer) As Boolean
        Return AccesoDatos.Instancia.EjecutarConsulta("select count(*) from articulo where idMarca=" & idMarca).Rows(0).Item(0)
    End Function
    Public Function traerArticuloPorBarCodeYProveedor(ByVal cod_barra As String, ByVal proveedor As String) As Articulo
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("Select a.* from Articulo a inner join  proveedor p on a.Idproveedor = p.idproveedor where a.cod_barra = '" & cod_barra & "' and p.razonsocial = '" & proveedor & "'")
        Dim art As New Articulo
        If dt.Rows.Count = 0 Then Return Nothing
        Dim fila As DataRow = dt.Rows(0)
        art.Costo = fila("costo")
        art.Descripcion = fila("descripcion")
        art.IdArticulo = fila("idArticulo")
        art.Idcategoria = fila("idCategoria")
        art.IdMarca = fila("idMarca")
        art.Idproveedor = fila("Idproveedor")
        art.Medida = fila("medida")
        art.PorcDesc = fila("porcentajedescuento")
        art.Precio = fila("precio")
        art.Stock = fila("stock")
        art.Utilidad = fila("utilidad")
        art.esFraccionable = fila("esfraccionable")
        art.PtoReposicion = fila("pto_reposicion")
        art.CodBarra = fila("cod_barra")
        Return art
    End Function
End Class
