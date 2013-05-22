Imports Modelo
Imports Datos
Imports System.Windows.Forms

Public Class FachadaArticuloDescuentoGananciaIva

    Dim regArt As New Registro_articulo_descuento_ganancia_iva
    Public Sub ingresarArticulo_descuento_ganancia_iva(ByVal art_descuento_ganancia_iva As Articulo_descuento_ganancia_iva)
        Dim regDGI As New Registro_articulo_descuento_ganancia_iva
        regDGI.ingresarArticulo_descuento_ganancia_iva(art_descuento_ganancia_iva)
    End Sub

    Public Sub Modificar_Articulo_descuento_ganancia_iva(ByVal art_descuento_ganancia_iva As Articulo_descuento_ganancia_iva) 'lo modifico en la base
        Dim regDGI As New Registro_articulo_descuento_ganancia_iva
        regDGI.Modificar_Articulo_descuento_ganancia_iva(art_descuento_ganancia_iva)
    End Sub


    Public Function traerArticuloPorId(ByVal idArticulo As Integer) As Articulo_descuento_ganancia_iva
        Dim regArt As New Registro_articulo_descuento_ganancia_iva
        Dim artDGI As New Articulo_descuento_ganancia_iva

        artDGI = regArt.traerArticuloPorId(idArticulo)

        Return artDGI

    End Function

    Public Function listarArticulosConDescYGcias() As DataTable
        Return regArt.listarArticulosConDescYGcias()
    End Function

    Public Sub ModificacionPrecioListaProveedor(ByVal IdsAactualizar As String, ByVal variable As Double)
        regArt.ModificacionPrecioListaProveedor(IdsAactualizar, variable)
    End Sub

    Public Sub ModificarPrecioCostoyPrecioDeVenta(ByVal listaDeAdgi As List(Of Articulo_descuento_ganancia_iva))
        regArt.ModificarPrecioCostoyPrecioDeVenta(listaDeAdgi)
    End Sub
    Public Sub ModificarDescuentos(ByVal IdsAactualizar As String, ByVal listaDeDescuentos As List(Of Double), ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva))
        regArt.ModificarDescuentos(IdsAactualizar, listaDeDescuentos, listaadgi)
    End Sub
    Public Sub ModificarUtilidades(ByVal IdsAactualizar As String, ByVal listaDeDescuentos As List(Of Double), ByVal listaadgi As List(Of Articulo_descuento_ganancia_iva), ByVal articulos As List(Of Articulo))
        regArt.ModificarUtilidades(IdsAactualizar, listaDeDescuentos, listaadgi, articulos)
    End Sub



    Public Function ListarArticulosXTipo(ByVal desc As String) As DataTable
        Dim d As String
        d = desc

        Return regArt.TaerArticuloXTipo(d)
    End Function
    Public Function ListarArticulosXDescripcion(ByVal desc As String) As DataTable
        Dim d As String
        d = desc

        Return regArt.TraerArticuloPorDescripcion(d)
    End Function

    Public Function ListarArticulosXCodBarras(ByVal codigo_barras As String) As DataTable
        Return regArt.TraerArticuloPorCodBarras(codigo_barras)
    End Function
    'Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
    '    Return regArt.EjecutarConsulta(consulta)
    'End Function
    Public Function ListarArticulosXMarca(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Return regArt.TaerArticuloXMarca(d)
    End Function
    Public Function ListarArticulosXProveedor(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Return regArt.TaerArticuloXProveedor(d)
    End Function

    Public Function ListarArticulosXCodBarrasDT(ByVal desc As String) As DataTable
        Dim d As String
        d = desc
        Return regArt.TaerArticuloXCodBarras(desc)
    End Function
End Class
