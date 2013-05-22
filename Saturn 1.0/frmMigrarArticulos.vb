Imports Fachada
Imports Modelo


Public Class frmMigrarArticulos


    Dim facarticulo As New FachadaArticulo
    Dim cnOrigen As OleDb.OleDbConnection

    Dim art As Articulo
    Private Sub cmdMigrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMigrar.Click

        MIgrarArticulos()
    End Sub
    Private Sub MIgrarArticulos()

        Dim facPro As New FachadaProveedor
        Dim dt As DataTable
        Dim facArt As New FachadaArticulo
        Dim dt1 As DataTable

        dt1 = facArt.traerDESCvalmar() ''traigo todo
        Dim str As String
        Dim idCategoria As Integer, idProveedor As Integer, idMarca As Integer
        Dim art As Articulo

        For Each fila As DataRow In dt1.Rows

            Dim datt As DataTable

            art = New Articulo

            str = fila.Item(2)
            datt = facArt.traerIDSdeMIbaseCAT(str)
            idCategoria = 1
            If datt.Rows.Count <> 0 Then idCategoria = datt.Rows(0).Item(0)
            idProveedor = facPro.TraerIdPorNombre(fila(3))
            idMarca = facArt.TraerIdMarcaPorDescripcion(fila(1))

            'Cargo las propiedades del articulo a agregar
            With art
                .Descripcion = fila("DESCRIPCION")
                .Medida = fila("MEDIDA")

                If .Descripcion.Contains("M") And .Descripcion.Contains("CANO") Then
                    If .Descripcion.IndexOf("M") <> 0 Then
                        If IsNumeric(.Descripcion.Substring(.Descripcion.IndexOf("M") - 1, 1)) Then
                            .esFraccionable = True
                            Dim i As Integer, indice As Integer
                            i = .Descripcion.IndexOf("M") - 1
                            indice = .Descripcion.IndexOf("M") - 1
                            For i = 0 To .Descripcion.IndexOf("M") - 1
                                If .Descripcion.Substring(indice, 1) = " " Then
                                    Exit For
                                End If
                                indice -= 1
                            Next
                            .Medida = .Descripcion.Substring(indice, .Descripcion.IndexOf("M") - indice)
                        Else

                        End If
                    End If


                End If

                .IdMarca = idMarca
                .Idcategoria = idCategoria
                .Idproveedor = idProveedor
                .Costo = fila("PRECIO_COSTO")
                .PorcDesc = fila("PORCENTAJE_DESCUENTO")
                .Utilidad = fila("PORCENTAJE_GANANCIA")
                .Precio = fila("PRECIO_CLIENTE")
                .Stock = fila("STOCK")

            End With

            facArt.ingresarArticulo(art)
           
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fachada As New FachadaArticulo
        Dim dt As DataTable
        dt = fachada.TraerCategoriasDeValmar
        Dim cat As New TipoArticulo
        For Each fila As DataRow In dt.Rows
            cat.Descripcion = fila.Item(0)
            Dim fff As New FachadaArticulo
            fff.ingresarTipo(cat.Descripcion)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fachada As New FachadaArticulo
        Dim dt As DataTable
        dt = fachada.TraerMarcasDeValmar
        Dim cat As New Marca("", 0)
        For Each fila As DataRow In dt.Rows
            cat.Descripcion = fila.Item(0)
            Dim fff As New FachadaArticulo
            fff.ingresarMarca(cat.Descripcion)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pepe As Integer
        Dim fachada As New FachadaArticulo
        Dim facPro As New FachadaProveedor
        Dim dt As DataTable
        dt = fachada.ProveedoresValmar
        Dim p As New Proveedor
        For Each fila As DataRow In dt.Rows
            p.RazonSocial = fila.Item(0)
            p.CUIT = "11-11111111-1"
            p.IdRubro = 1 'el rubro por defecto es desconocido
            p.Lista = ""
            p.Bonificaciones = ""
            p.Email = ""
            p.FechaAlta = Date.Now
            facPro.AltaProveedor(p)
        Next
    End Sub

    Private Sub btnMigrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMigrarDatos.Click
        cnOrigen = New OleDb.OleDbConnection()
        'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="D:\LIMAKU\Liti\Saturn\Saturn 1.0\bin\Debug\PROVEDOR.mdb"
        cnOrigen.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\PROVEDOR.mdb"
        cnOrigen.Open()
        Dim da As New OleDb.OleDbDataAdapter("SELECT cod_pro, nom_pro, dir_pro, loc_pro, pos_pro, tel_pro, cor_pro from provedor", cnOrigen)
        Dim dt As New DataTable

        da.Fill(dt)
        Dim pro As Proveedor
        Dim dir As Domicilio
        Dim tel As Telefono
        Dim facpro As New FachadaProveedor

        For Each fila As DataRow In dt.Rows
            pro = New Proveedor
            dir = New Domicilio
            tel = New Telefono

            With pro
                .IdProveedor = fila("cod_pro")
                .RazonSocial = fila("nom_pro")
                .CUIT = ""
                .IdRubro = 1
                dir.Altura = 0
                If IsDBNull(fila("dir_pro")) Then
                    dir.Calle = ""
                Else
                    dir.Calle = fila("dir_pro")
                End If
                If IsDBNull(fila("loc_pro")) Then
                    dir.Localidad = ""
                Else
                    dir.Localidad = fila("loc_pro")
                End If

                dir.Partido = ""
                .Lista = ""
                .Bonificaciones = ""
                .Email = ""
                If IsDBNull(fila("tel_pro")) Then
                    tel.Numero = ""
                Else
                    tel.Numero = fila("tel_pro")
                End If
                If IsDBNull(fila("cor_pro")) Then
                    tel.NombreContacto = ""
                Else
                    tel.NombreContacto = fila("cor_pro")
                End If
                tel.IdTipoTelefono = 1
                .AddTelefono(tel)
                .AddDomicilio(dir)
            End With

            facpro.AltaProveedor(pro)
        Next

        cnOrigen.Close()


        Dim cnArt As New OleDb.OleDbConnection()
        'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="D:\LIMAKU\Liti\Saturn\Saturn 1.0\bin\Debug\PROVEDOR.mdb"
        cnArt.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\ARTICULO.mdb"
        cnOrigen.Open()
        Dim da2 As New OleDb.OleDbDataAdapter("select cod_art, pro_art, bar_art, des_art, stk_art, ven_art from articulo", cnArt)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        Dim cm As New OleDb.OleDbCommand("", cnOrigen)
        Dim dr As OleDb.OleDbDataReader, idProveedor As String
        Dim art As Articulo
        Dim facArt As New FachadaArticulo
        Dim dtProv As DataTable

        For Each fila As DataRow In dt2.Rows
            cm.CommandText = "SELECT nom_pro from provedor where cod_pro = '" & fila("pro_art") & "' "
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dtProv = facpro.ListarPorNombre(dr(0))
                idProveedor = dtProv.Rows(0).Item("idProveedor")
            Else
                idProveedor = "819"
            End If

            dr.Close()

            art = New Articulo
            art.CodBarra = NullToEmpty(fila("bar_art"))
            art.Costo = NullToEmpty(fila("ven_art"))
            art.Descripcion = NullToEmpty(fila("des_art"))
            art.esFraccionable = False
            art.IdArticulo = NullToEmpty(fila("cod_art"))
            art.Idcategoria = 279
            art.IdMarca = 388
            art.Idproveedor = idProveedor
            art.Medida = 1
            art.PorcDesc = 0
            art.Precio = NullToEmpty(fila("ven_art"))
            art.PtoReposicion = 0
            art.Stock = fila("stk_art")
            art.Utilidad = 0
            facArt.ingresarArticulo(art)
            ProgressBar1.Increment(1)
        Next


    End Sub

    Private Function NullToEmpty(ByVal obj As Object) As String
        If IsDBNull(obj) Then
            Return ""
        Else
            Return obj.ToString()
        End If
    End Function
End Class