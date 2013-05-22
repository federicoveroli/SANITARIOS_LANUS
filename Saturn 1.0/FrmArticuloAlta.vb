Imports Modelo
Imports Fachada

Public Class FrmArticuloAlta
    Dim facArt As New Fachada.FachadaArticulo
    Dim facProveedor As New FachadaProveedor
    Dim vAcepto As Boolean
    Dim vArticulo As Articulo
    Dim vArticulo_Desc_Gan_IVA As Articulo_descuento_ganancia_iva
    Dim EselLoad As Boolean = True
    Public Property DataSource() As Articulo
        Get
            Return vArticulo
        End Get
        Set(ByVal value As Articulo)
            vArticulo = value
        End Set
    End Property

    Public ReadOnly Property Acepto()
        Get
            Return vAcepto
        End Get
    End Property

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        vAcepto = False
        Me.Close()
    End Sub

    Public Sub setProveedor(ByVal proveedor As String)
        cmbProveedoR.Text = proveedor
    End Sub


    Private Sub FrmArticuloAlta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If

        'Dim SeparadorDecimal As String
        'SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        'If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
        '    e.KeyChar = Chr(Asc(SeparadorDecimal))
        'End If

    End Sub
    Private Sub FrmArticuloAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtidArticulo.Text = facArt.TraerNuevoIdArticulo()
        If cmdAceptar.Text <> "Modificar" Then
            cmbTipoProducto.DataSource = facArt.listarCategoriasArticulos()
            'cmbTipoProducto.SelectedIndex = 0
            cmbTipoProducto.Text = "DESCONOCIDO"
            facProveedor.CargarCombo(cmbProveedoR)
            cmbProveedoR.Text = "DESCONOCIDO"
            cmbMarca.DataSource = facArt.listarMarcas()
            cmbMarca.Text = "DESCONOCIDA"
            'cmbMarca.SelectedIndex = 0
            txtDescripcION.Select()
        End If
        vAcepto = False
    End Sub
    Private Sub cmbTipoArticuLO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoProducto.KeyPress
        'If e.KeyCode = Keys.Enter Then My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
    End Sub

    Public Sub CompletarArticulo(ByVal idArticulo As Integer)
        Dim FacArt As New FachadaArticulo
        Dim FacArtDtoGcia As New FachadaArticuloDescuentoGananciaIva
        Dim Art As New Articulo
        Dim ArtDtoGcia As Articulo_descuento_ganancia_iva

        Art = FacArt.TraerArticulo(idArticulo)
        txtDescripcION.Text = Art.Descripcion
        txtMedida.Text = Art.Medida
        txtIVA.Text = Art.PorcDesc
        'txtPorcGananciA.Text = Art.Utilidad
        'txtPrecioConDescuento.Text = Math.Round(Art.Costo - (Art.Costo * Art.PorcDesc / 100), 2)
        txtCodBarras.Text = Art.CodBarra
        txtPtoReposicion.Text = Art.PtoReposicion



        txtPrecioCosto.Text = 0 'Math.Round(Art.Costo, 2)
        txtPrecioLista.Text = Math.Round(Art.Costo, 2)
        'txtPrecioFinal.Text = Math.Round(txtPrecioConDescuento.Text + (txtPrecioConDescuento.Text * Art.Utilidad / 100), 2) ADASDSADASDADASD
        txtSTOcK.Text = Art.Stock

        cmbTipoProducto.DataSource = FacArt.listarCategoriasArticulos()

        facProveedor.CargarCombo(cmbProveedoR)

        cmbMarca.DataSource = FacArt.listarMarcas()


        For Each m As Marca In cmbMarca.Items
            If m.IdMarca = Art.IdMarca Then
                cmbMarca.SelectedItem = m
                Exit For
            End If
        Next
        For Each m As IdProveedor In cmbProveedoR.Items
            If m.Id = Art.Idproveedor Then
                cmbProveedoR.SelectedItem = m
                Exit For
            End If
        Next
        For Each m As TipoArticulo In cmbTipoProducto.Items
            If m.IdTipo = Art.Idcategoria Then
                cmbTipoProducto.SelectedItem = m
                Exit For
            End If
        Next

        chFraccionable.Checked = Art.esFraccionable

        Dim artDGI As Articulo_descuento_ganancia_iva

        artDGI = FacArtDtoGcia.traerArticuloPorId(idArticulo)


        txtDesc1.Text = artDGI.Descuento1
        txtDesc2.Text = artDGI.Descuento2
        txtDesc3.Text = artDGI.Descuento3
        txtDesc4.Text = artDGI.Descuento4
        txtgcia1.Text = artDGI.Ganancia1
        txtgcia2.Text = artDGI.Ganancia2
        txtGcia3.Text = artDGI.Ganancia3
        txtGcia4.Text = artDGI.Ganancia4
        txtIVA.Text = artDGI.IVA
        txtPrecioCosto.Text = artDGI.PrecioListaProveedor



        'For Each r As Rubro In cmbRubro.Items
        '    If r.IdRubro = objCliente.IdCliente Then
        '        cmbRubro.SelectedItem = r
        '        Exit For
        '    End If
        'Next






    End Sub



    Private Sub cmdAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        vAcepto = True

        Dim facArticulo_Desc_gan_iva As New FachadaArticuloDescuentoGananciaIva
        vArticulo_Desc_Gan_IVA = New Articulo_descuento_ganancia_iva

        If cmbProveedoR.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el proveedor", "Seleccione el proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProveedoR.Focus()
            Exit Sub
        End If

        If cmdAceptar.Text = "Modificar" Then
            'Application.DoEvents()
            vArticulo = New Articulo


            With vArticulo
                .Costo = txtPrecioLista.Text
                .Descripcion = txtDescripcION.Text
                .IdArticulo = lblMisterioso.Text
                .IdMarca = CType(cmbMarca.SelectedItem, Marca).IdMarca
                .Idproveedor = CType(cmbProveedoR.SelectedItem, IdProveedor).Id
                .Idcategoria = CType(cmbTipoProducto.SelectedItem, TipoArticulo).IdTipo
                .Medida = txtMedida.Text
                .PorcDesc = txtIVA.Text
                .Precio = txtPrecioFinal.Text
                .Stock = txtSTOcK.Text
                .Utilidad = 0
                .esFraccionable = chFraccionable.Checked
                .CodBarra = txtCodBarras.Text
                .PtoReposicion = txtPtoReposicion.Text


                vArticulo_Desc_Gan_IVA.Descuento1 = txtDesc1.Text
                vArticulo_Desc_Gan_IVA.Descuento2 = txtDesc2.Text
                vArticulo_Desc_Gan_IVA.Descuento3 = txtDesc3.Text
                vArticulo_Desc_Gan_IVA.Descuento4 = txtDesc4.Text
                vArticulo_Desc_Gan_IVA.Ganancia1 = txtgcia1.Text
                vArticulo_Desc_Gan_IVA.Ganancia2 = txtgcia2.Text
                vArticulo_Desc_Gan_IVA.Ganancia3 = txtGcia3.Text
                vArticulo_Desc_Gan_IVA.Ganancia4 = txtGcia4.Text
                vArticulo_Desc_Gan_IVA.IdArticulo = lblMisterioso.Text
                vArticulo_Desc_Gan_IVA.IVA = txtIVA.Text
                vArticulo_Desc_Gan_IVA.PrecioListaProveedor = txtPrecioCosto.Text


                Dim FacArticulo As New FachadaArticulo

                Dim ObjArticulo As Articulo
                ObjArticulo = FacArticulo.TraerArticulo(vArticulo.IdArticulo)
                Dim precio_anterior As Double
                precio_anterior = Math.Round(ObjArticulo.Precio, 2)
                If precio_anterior <> vArticulo.Precio Then
                    Dim facc As New FachadaBitacora
                    Dim varSTRING As String
                    varSTRING = vArticulo.Descripcion & " [el precio era " & precio_anterior & " y ahora es " & vArticulo.Precio & "]"
                    facc.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, varSTRING)
                End If

                'modif mati LO MISMO DE PRECIO PERO PARA STOCK TAMBIEN TENGO QUE GUARDAR EN BITACORA
                '----------------#################-----------#################---------################3333

                Dim Stock_anterior As Double
                Stock_anterior = ObjArticulo.Stock
                If Stock_anterior <> vArticulo.Stock Then
                    Dim facc As New FachadaBitacora
                    Dim varSTRING As String
                    varSTRING = vArticulo.Descripcion & " [el Stock era " & Stock_anterior & " y ahora es " & vArticulo.Stock & "]"
                    facc.RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, varSTRING)
                End If


                Try

                    facArt.ModificarArticulo2(vArticulo)
                    facArticulo_Desc_gan_iva.Modificar_Articulo_descuento_ganancia_iva(vArticulo_Desc_Gan_IVA)
                    MsgBox("Modificado exitosamente!!", MsgBoxStyle.Information, "Articulo Modificado")
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error inesperado..", MsgBoxStyle.Critical, "Error")
                End Try
            End With
        Else 'POR ACA VA AL ALTA DE ARTICULO
            If txtDescripcION.Text = "" Or txtIVA.Text = "" Or txtPrecioCosto.Text = "" Or txtPrecioLista.Text = "" Or txtSTOcK.Text = "" Or txtPtoReposicion.Text = "" Then
                MsgBox("Debe completar todos los campos!!", MsgBoxStyle.Exclamation, "Campos incompletos")
                Exit Sub
            Else
                vArticulo = New Articulo
                Try
                    With vArticulo
                        .Idcategoria = CType(cmbTipoProducto.SelectedItem, TipoArticulo).IdTipo
                        .Costo = txtPrecioLista.Text
                        .Descripcion = txtDescripcION.Text
                        .IdMarca = CType(cmbMarca.SelectedItem, Marca).IdMarca
                        .Idproveedor = CType(cmbProveedoR.SelectedItem, IdProveedor).Id
                        .Medida = txtMedida.Text
                        .PorcDesc = txtIVA.Text
                        .Precio = txtPrecioFinal.Text
                        .Stock = txtSTOcK.Text
                        .Utilidad = 0
                        .esFraccionable = chFraccionable.Checked
                        .CodBarra = txtCodBarras.Text
                        .PtoReposicion = txtPtoReposicion.Text
                        .IdArticulo = txtidArticulo.Text
                    End With


                    facArt.ingresarArticulo(vArticulo)
                    txtidArticulo.Text = facArt.TraerNuevoIdArticulo()


                    vArticulo_Desc_Gan_IVA.Descuento1 = txtDesc1.Text
                    vArticulo_Desc_Gan_IVA.Descuento2 = txtDesc2.Text
                    vArticulo_Desc_Gan_IVA.Descuento3 = txtDesc3.Text
                    vArticulo_Desc_Gan_IVA.Descuento4 = txtDesc4.Text
                    vArticulo_Desc_Gan_IVA.Ganancia1 = txtgcia1.Text
                    vArticulo_Desc_Gan_IVA.Ganancia2 = txtgcia2.Text
                    vArticulo_Desc_Gan_IVA.Ganancia3 = txtGcia3.Text
                    vArticulo_Desc_Gan_IVA.Ganancia4 = txtGcia4.Text
                    vArticulo_Desc_Gan_IVA.IdArticulo = txtidArticulo.Text - 1
                    vArticulo_Desc_Gan_IVA.IVA = txtIVA.Text
                    vArticulo_Desc_Gan_IVA.PrecioListaProveedor = txtPrecioCosto.Text


                    facArticulo_Desc_gan_iva.ingresarArticulo_descuento_ganancia_iva(vArticulo_Desc_Gan_IVA)


                    MsgBox("Artículo cargado exitosamente!", MsgBoxStyle.Information, "Articulo ingresado")
                    cmbTipoProducto.Text = ""
                    cmbMarca.Text = ""
                    cmbProveedoR.Text = ""
                    txtPrecioCosto.Text = "0"
                    txtDescripcION.Text = ""
                    txtMedida.Text = ""
                    txtIVA.Text = "0"
                    txtPrecioLista.Text = "0"
                    txtSTOcK.Text = ""


                    txtDesc1.Text = "0"
                    txtDesc2.Text = "0"
                    txtDesc3.Text = "0"
                    txtDesc4.Text = "0"
                    txtgcia1.Text = "0"
                    txtgcia2.Text = "0"
                    txtGcia3.Text = "0"
                    txtGcia4.Text = "0"
                    txtidArticulo.Text = ""
                    txtIVA.Text = "21"
                    txtPrecioCosto.Text = "0"



                    'txtPrecioConDescuento.Text = "0"
                    txtPtoReposicion.Text = ""
                    txtCodBarras.Text = ""
                    chFraccionable.Checked = False
                Catch ex As CodigoBarraNoDisponibleException
                    Dim art As Articulo
                    art = facArt.TraerArticulo(txtCodBarras.Text)
                    Dim detallesArt As String
                    detallesArt = "Detalles del articulo:" & vbCr
                    detallesArt += "Descripción: " & art.Descripcion & vbCr & "Precio: " & art.Precio & vbCr & "Codigo de Barras: " & art.CodBarra
                    If MessageBox.Show("El codigo de barra se encuentra utilizado por otro articulo, desea modificar la información de ese articulo?" & vbCr & vbCr & detallesArt, "Codigo de barra existente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        facArt.ActualizarArticulo(vArticulo)
                        facArticulo_Desc_gan_iva.Modificar_Articulo_descuento_ganancia_iva(vArticulo_Desc_Gan_IVA)
                    End If
                    MsgBox("Artículo modificado exitosamente!", MsgBoxStyle.Information, "Articulo modificado")
                Catch ex As IdNoDisponibleException
                    MessageBox.Show("El id que intenta ingresar esta siendo utilizado por otro articulo, ingrese otro id o modifique ese articulo", "Id no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try


            End If
        End If
        If Not chkSeguirCargando.Checked Then Me.Close()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSimilar.Click
        If txtDescripcION.Text = "" Or txtIVA.Text = "" Or txtPrecioCosto.Text = "" Or txtPrecioLista.Text = "" Or txtSTOcK.Text = "" Then
            MsgBox("Debe completar todos los campos!!", MsgBoxStyle.Exclamation, "Campos incompletos")
        Else
            Dim alta As New Articulo
            alta.Idcategoria = CType(cmbTipoProducto.SelectedItem, TipoArticulo).IdTipo 'cmbTipoProducto.Text
            alta.Costo = txtPrecioLista.Text
            alta.Descripcion = txtDescripcION.Text
            alta.IdMarca = CType(cmbMarca.SelectedItem, Marca).IdMarca
            alta.Idproveedor = CType(cmbProveedoR.SelectedItem, IdProveedor).Id
            alta.Medida = txtMedida.Text
            alta.PorcDesc = txtIVA.Text
            alta.Precio = txtPrecioFinal.Text
            alta.Stock = txtSTOcK.Text
            alta.Utilidad = 0
            alta.CodBarra = txtCodBarras.Text
            Try
                facArt.ingresarArticulo(alta)
                MsgBox("Artículo cargado exitosamente!", MsgBoxStyle.Information, "Articulo ingresado")
                txtMedida.Text = ""
                'txtPrecioConDescuento.Text = "0"
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try


        End If
    End Sub

    Private Sub txtPorcDESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVA.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPorcDESC_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVA.LostFocus
        'Dim precio As Double
        'Try
        '    precio = txtPrecioCosto.Text
        '    txtPrecioConDescuento.Text = Math.Round(precio - (precio * (txtPorcDESC.Text) / 100), 2)
        'Catch ex As Exception
        '    'MsgBox("Debe completar los campos requeridos!")
        'End Try
        'CalcularPrecioFinal()
        CalcularDescuentosAcumulados()
    End Sub
    'Private Sub CalcularPrecios()
    '    Dim precio As Double
    '    precio = txtPrecioFinal.Text
    '    txtPrecioConDescuento.Text = Math.Round(precio - (precio * (txtPorcDESC.Text) / 100), 2)
    '    precio = txtPrecioConDescuento.Text
    '    txtPrecioConDescuento.Text = Math.Round(precio - (precio * (txtPorcDESC.Text) / 100), 2)
    'End Sub

    Private Sub txtPorcGananciA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtPorcGananciA_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    Dim precio As Double
        '    txtPorcDESC_LostFocus(sender, e)
        '    precio = txtPrecioConDescuento.Text
        '    Dim precioVenta As Double
        '    precioVenta = Math.Round(precio + (precio * (txtPorcGananciA.Text) / 100), 2)
        '    txtPrecioLista.Text = precioVenta ' * 1.21 'ver de desharcodearlo
        'Catch ex As Exception
        'End Try
        ' CalcularPrecioFinal()
    End Sub
    Private Sub cmdCONVERTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCONVERTIR.Click
        Try
            txtPrecioCosto.Text = CDbl(txtValorDolar.Text) * txtPrecioCosto.Text
            txtIVA.Focus()

            txtSTOcK.Focus()
        Catch ex As Exception
            MsgBox("Debe escribir el valor del dolar y el precio de costo", MsgBoxStyle.Exclamation, "Campos incompletos")
        End Try
    End Sub

    Private Sub cmdAgregarTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTipo.Click
        Dim tipo As String
        tipo = InputBox("Ingrese el tipo")
        If tipo.Trim.Length <> 0 Then
            facArt.ingresarTipo(tipo)
            cmbTipoProducto.DataSource = facArt.listarCategoriasArticulos
            cmbTipoProducto.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmdAgregarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarMarca.Click
        Dim tipo As String
        tipo = InputBox("Ingrese la marca")
        If tipo.Trim.Length <> 0 Then
            facArt.ingresarMarca(tipo)
            cmbMarca.DataSource = facArt.listarMarcas
            cmbMarca.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtSTOcK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSTOcK.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

    Private Sub txtPrecioCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCosto.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtMedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMedida.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub




    Private Sub picEliminarTipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEliminarTipoProducto.Click

        If MessageBox.Show("Realmente desea eliminar el tipo de producto" & vbCr & "'" & cmbTipoProducto.Text & "'", "Confirme la eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim idCategoria As Integer = CType(cmbTipoProducto.SelectedItem, TipoArticulo).IdTipo
            If facArt.TieneArticulosTipoArticulo(idCategoria) = False Then
                facArt.eliminarTipoArticulo(idCategoria)
                cmbTipoProducto.DataSource = facArt.listarCategoriasArticulos()
                cmbTipoProducto.Text = "DESCONOCIDO"
            Else
                MessageBox.Show("Imposible eliminar el tipo de producto ya que se encuentra asignado a uno o más articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub picEliminarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEliminarMarca.Click

        If MessageBox.Show("Realmente desea eliminar la marca" & vbCr & "'" & cmbMarca.Text & "'", "Confirme la eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim idMarca As Integer = CType(cmbMarca.SelectedItem, Marca).IdMarca
            If facArt.TieneArticulosMarca(idMarca) = False Then
                facArt.eliminarMarca(idMarca)
                cmbMarca.DataSource = facArt.listarMarcas()
                cmbMarca.Text = "DESCONOCIDA"
            Else
                MessageBox.Show("Imposible eliminar la marca ya que se encuentra asignado a uno o más articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub txtPrecioLista_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'CalcularPrecioFinal()
    End Sub



    'Private Sub CalcularPrecioFinal()
    '    Dim precioFinal 'As Double, precioLista As Double, descuentomm As Double, utilidadmm As Double
    '    'precioLista = CDbl(txtPrecioLista.Text)
    '    'descuentomm = precioLista * CDbl(txtPorcDESC.Text) / 100
    '    'utilidadmm = (precioLista - descuentomm) * CDbl(txtPorcGananciA.Text) / 100
    '    'txtPrecioCosto.Text = precioLista - descuentomm
    '    precioFinal = Math.Round(CDbl(txtPrecioLista.Text)) ' + (CDbl(txtPrecioLista.Text) * CDbl(txtPorcGananciA.Text) / 100), 3)
    '    'precioFinal = Math.Round(CDbl(txtPrecioCosto.Text) + utilidadmm, 2)
    '    If txtgcia1.Text = "" Then
    '        txtgcia1.Text = "0"
    '    End If
    '    If txtgcia2.Text = "" Then
    '        txtgcia2.Text = "0"
    '    End If
    '    'precioFinal = precioFinal + (precioFinal * CDbl(txtgcia1.Text) / 100)
    '    'precioFinal = precioFinal + (precioFinal * CDbl(txtgcia2.Text) / 100)
    '    txtPrecioFinal.Text = Math.Round(precioFinal, 3)


    'End Sub
    Private Sub CalcularGananciaAcumulada()


        Dim RdoGcia1 As Double, RdoGcia2 As Double, RdoGcia3 As Double, RdoGcia4 As Double
        Dim Precio As Double
        Dim precioFinal As Double = 0
        Precio = CDbl(txtPrecioLista.Text)

        RdoGcia1 = Precio + (Precio * CDbl(txtgcia1.Text) / 100)
        RdoGcia2 = RdoGcia1 + (RdoGcia1 * CDbl(txtgcia2.Text) / 100)
        RdoGcia3 = RdoGcia2 + (RdoGcia2 * CDbl(txtGcia3.Text) / 100)
        RdoGcia4 = RdoGcia3 + (RdoGcia3 * CDbl(txtGcia4.Text) / 100)


        'precioFinal = RdoDesc4 * 1.21
        txtPrecioFinal.Text = Math.Round(RdoGcia4, 3)

    End Sub
    Private Sub CalcularDescuentosAcumulados()

        Dim RdoDesc1 As Double, RdoDesc2 As Double, RdoDesc3 As Double, RdoDesc4 As Double
        Dim PrecioListaProveedor As Double
        Dim precioFinal As Double = 0
        PrecioListaProveedor = CDbl(txtPrecioCosto.Text)

        RdoDesc1 = PrecioListaProveedor - (PrecioListaProveedor * CDbl(txtDesc1.Text) / 100)
        RdoDesc2 = RdoDesc1 - (RdoDesc1 * CDbl(txtDesc2.Text) / 100)
        RdoDesc3 = RdoDesc2 - (RdoDesc2 * CDbl(txtDesc3.Text) / 100)
        RdoDesc4 = RdoDesc3 - (RdoDesc3 * CDbl(txtDesc4.Text) / 100)


        precioFinal = RdoDesc4 + (RdoDesc4 * CDbl(txtIVA.Text) / 100)

        txtPrecioLista.Text = Math.Round(precioFinal, 3)
        CalcularGananciaAcumulada()

    End Sub
    Private Sub txtDesc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc1.LostFocus
        CalcularDescuentosAcumulados()
    End Sub

    Private Sub txtDesc2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc2.LostFocus
        CalcularDescuentosAcumulados()
    End Sub
    Private Sub txtDesc3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc3.LostFocus
        CalcularDescuentosAcumulados()
    End Sub
    Private Sub txtDesc4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc4.LostFocus
        CalcularDescuentosAcumulados()
    End Sub


    Private Sub txtPrecioCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioCosto.TextChanged
        If EselLoad = False Then
            CalcularDescuentosAcumulados()
        End If
        EselLoad = False
    End Sub

    Private Sub txtPrecioLista_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioLista.TextChanged
        'CalcularPrecioFinal()
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgcia1.LostFocus
        CalcularDescuentosAcumulados()
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgcia2.LostFocus
        CalcularDescuentosAcumulados()
    End Sub



    Private Sub txtgcia1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgcia1.TextChanged

    End Sub

    Private Sub txtPorcGananciA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDesc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc1.TextChanged

    End Sub

    Private Sub txtIVA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIVA.TextChanged

    End Sub

    Private Sub txtgcia2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgcia2.TextChanged

    End Sub

    Private Sub txtGcia3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGcia3.LostFocus
        CalcularDescuentosAcumulados()
    End Sub

    Private Sub txtGcia3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGcia3.TextChanged

    End Sub

    Private Sub txtGcia4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGcia4.LostFocus
        CalcularDescuentosAcumulados()
    End Sub

    Private Sub txtGcia4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGcia4.TextChanged

    End Sub
End Class
