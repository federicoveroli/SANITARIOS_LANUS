Imports Modelo
Imports Fachada
Public Class FrmArticuloReemplazar
    Dim esElPrimero As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub cmdReemplazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReemplazar.Click
        Dim ConSultASet As String
        Dim ConsultaWhere As String
        Dim ConSulTa As String
        Dim fac As New Fachada.FachadaArticulo
        esElPrimero = True
        Dim consultaSet2 As String
        Dim consultaWhere2 As String
        Try



            ConSultASet = "update articulo set"
            ConsultaWhere = " where"

            If txtDesc1.Text <> "" Then
                ConSultASet = ConSultASet & " descripcion =" & "'" & txtDesc2.Text & "'"
                ConsultaWhere = ConsultaWhere & " descripcion like '%" & txtDesc1.Text & "%'"
                esElPrimero = False
            End If
            If txtMedida1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                ConSultASet = ConSultASet & " medida =" & "'" & txtMedida2.Text & "'"
                ConsultaWhere = ConsultaWhere & " medida = " & "'" & txtMedida1.Text & "'"
                esElPrimero = False
            End If
            If txtPrecioCOsto1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "

                End If
                ConSultASet = ConSultASet & " costo =" & txtPrecioCosto2.Text
                ConsultaWhere = ConsultaWhere & " costo =" & txtPrecioCOsto1.Text
                esElPrimero = False
            End If
            If txtPorcDesc1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                ConSultASet = ConSultASet & " porcentajedescuento =" & txtPorcDesc2.Text
                ConsultaWhere = ConsultaWhere & " porcentajedescuento =" & txtPorcDesc1.Text
                esElPrimero = False
            End If
            If txtPorcGcia1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                ConSultASet = ConSultASet & " utilidad =" & txtPorcGcia2.Text
                ConsultaWhere = ConsultaWhere & " utilidad =" & txtPorcGcia1.Text
                esElPrimero = False
            End If
            If txtPrecioALCliente1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                ConSultASet = ConSultASet & " precio =" & txtPrecioALCliente2.Text
                ConsultaWhere = ConsultaWhere & " precio=" & txtPrecioALCliente1.Text
                esElPrimero = False
            End If
            If txtStock1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                ConSultASet = ConSultASet & " stock =" & txtStock2.Text
                ConsultaWhere = ConsultaWhere & " stock =" & txtStock1.Text
                esElPrimero = False
            End If
            If txtPrecioConDesc1.Text <> "" Then
                If esElPrimero = False Then
                    ConSultASet = ConSultASet & ","
                    ConsultaWhere = ConsultaWhere & " and "
                End If
                Dim dtIdArticulos As DataTable = fac.EjecutarConsulta("select idarticulo from articulo where costo-costo * porcentajedescuento/100 = " & txtPrecioConDesc1.Text)
                ConSultASet = ConSultASet & " porcentajedescuento= 100- " & txtPrecioConDesc2.Text & " *100/costo "
                ConsultaWhere += " idarticulo in ("
                For Each fila As DataRow In dtIdArticulos.Rows
                    ConsultaWhere += fila(0) & ","
                Next
                ConsultaWhere = ConsultaWhere.Substring(0, ConsultaWhere.Length - 1)
                ConsultaWhere += ")"
            End If
            If txtTipoProd1.Text <> "" Then
                Dim consUlta2 As String
                consultaSet2 = "update categoriaarticulo set "
                consultaWhere2 = " where"
                consultaSet2 = consultaSet2 & " descripcion = " & "'" & txtTipoProd2.Text & "'"
                consultaWhere2 = consultaWhere2 & " descripcion like '%" & txtTipoProd1.Text & "%'"
                consUlta2 = consultaSet2 & consultaWhere2
                fac.ReemplazarArticulos(consUlta2)
            End If
            If txtMarca1.Text <> "" Then
                'Dim consUlta2 As String
                'consultaSet2 = "update marca set "
                'consultaWhere2 = " where"
                'consultaSet2 = consultaSet2 & " descripcion = " & "'" & txtMarca2.Text & "'"
                'consultaWhere2 = consultaWhere2 & " descripcion like '%" & txtMarca1.Text & "%'"
                'consUlta2 = consultaSet2 & consultaWhere2
                'fac.ReemplazarArticulos(consUlta2)
            End If
            If txtpRoveedor1.Text <> "" Then
                Dim consUlta2 As String
                'consultaSet2 = "update proveedor set "
                'consultaWhere2 = " where"
                'consultaSet2 = consultaSet2 & " razonsocial = " & "'" & txtpRoveedor2.Text & "'"
                'consultaWhere2 = consultaWhere2 & " razonsocial like '%" & txtpRoveedor1.Text & "%'"
                'consUlta2 = consultaSet2 & consultaWhere2
                'fac.ReemplazarArticulos(consUlta2)


                '************ modificación 21/05/2010
                'obtengo el id de la marca introducida
                Dim idMarca As Integer
                idMarca = Integer.Parse(fac.EjecutarConsulta("select idMarca from marca where descripcion = '" & txtMarca1.Text & "'").Rows(0).Item("idMarca").ToString)
                'obtengo el id de la categoria del articulo
                Dim idCategoriaArticulo As Integer
                idCategoriaArticulo = Integer.Parse(fac.EjecutarConsulta("select idCategoria from categoriaarticulo where descripcion = '" & txtTipoProd1.Text & "'").Rows(0).Item(0).ToString)
                'obtengo el id del proveedor
                Dim idProveedor As Integer
                idProveedor = Integer.Parse(fac.EjecutarConsulta("select idProveedor from proveedor where razonsocial = '" & txtpRoveedor1.Text & "'").Rows(0).Item(0).ToString)

                Dim idProveedorNew As Integer
                idProveedorNew = Integer.Parse(fac.EjecutarConsulta("select idProveedor from proveedor where razonsocial = '" & txtpRoveedor2.Text & "'").Rows(0).Item(0).ToString)

                consUlta2 = "Update articulo set idProveedor=" & idProveedorNew & " where idCategoria =" & idCategoriaArticulo & " and idMarca = " & idMarca & " and idProveedor = " & idProveedor
                fac.ReemplazarArticulos(consUlta2)
            End If
            If esElPrimero = False Then
                ' Try
                ConSulTa = ConSultASet & ConsultaWhere
                Dim fachada As New FachadaBitacora
                Dim dtIds As DataTable
                dtIds = fachada.traeriDs(ConsultaWhere)
                fachada.GrabarReemplazo(ConsultaWhere)

                fac.ReemplazarArticulos(ConSulTa)
                'graba en la bitacora y recalcula los precios
                fachada.ActualizarPrecios(dtIds)
                'fachada.traeriD(ConsultaWhere)


                '   Catch
                '  End Try
            End If
            Limpiar.LimpiarControles(Me.Controls)
            MessageBox.Show("Los cambios han sido realizados!", "Cambios realizados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmArticuloReemplazar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            My.Computer.Keyboard.SendKeys(Chr(Keys.Tab))
        End If
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub
    Private Sub txtPrecioCOsto1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCOsto1.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPorcDesc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcDesc1.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPrecioConDesc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioConDesc1.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPorcGcia1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcGcia1.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPrecioALCliente1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioALCliente1.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtStock1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock1.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub
    Private Sub txtPrecioCosto2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCosto2.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPorcDesc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcDesc2.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPrecioConDesc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioConDesc2.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPorcGcia2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcGcia2.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtPrecioALCliente2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioALCliente2.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub
    Private Sub txtStock2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock2.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

    Private Sub FrmArticuloReemplazar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'For Each ctrl As Control In GroupBox1.Controls
        '    If ctrl.Name.StartsWith("txt") Then
        '        ctrl.Text = ctrl.Name
        '    End If
        'Next

        'For Each ctrl As Control In GroupBox2.Controls
        '    If ctrl.Name.StartsWith("txt") Then
        '        ctrl.Text = ctrl.Name
        '    End If
        'Next
    End Sub
End Class