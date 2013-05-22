Imports Modelo
Imports Fachada
Public Class frmFraccionar
    Public Cancelo As Boolean = False
    Public precioFraccion As Double
    Public a As Articulo, cant As Integer, cantidadAsisminUIR As Integer
    Public Sub PasarArticulo(ByVal art As Articulo, ByVal cantidad As Integer)
        a = art
        cant = cantidad
    End Sub

    
    Private Sub frmFraccionar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.DoEvents()
        txtmedida.Text = a.Medida
        txtentero.Text = a.Precio
        txtfraccion.Text = a.Medida
        txtprecioFraccion.Text = a.Precio
        txtfraccion.Select()
        Cancelo = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        precioFraccion = a.Precio
        Cancelo = True
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'el 0.1 es porque al fraccionarlo se le aumenta un 10%
        CalcFracc()
        a.Descripcion += " [ " & txtfraccion.Text & " Mts]"
        Cancelo = False
        Me.Close()

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CalcFracc()

    End Sub
    Private Sub CalcFracc()
        'el 0.1 es porque al fraccionarlo se le aumenta un 10%
        Dim regladetres As Double
        If txtfraccion.Text.Length = 0 Or txtfraccion.Text = 0 Then
            MsgBox("Debe completar el campo fraccion o seleccioar salir en caso de no querer fraccionar el articulo")
            Exit Sub
        End If

        If txtfraccion.Text < 0 Then
            MsgBox("La fraccion debe ser mayor a 0")
            Exit Sub
        End If
        If txtfraccion.Text = txtmedida.Text Then
            txtprecioFraccion.Text = a.Precio
            precioFraccion = txtprecioFraccion.Text
            Exit Sub
        End If

        Dim var As Double

        var = cant * txtfraccion.Text
        Dim var2 As Double
        var2 = var / txtentero.Text

        cantidadAsisminUIR = -Int(-var2)


        regladetres = (txtfraccion.Text / txtmedida.Text * txtentero.Text) * 1.1
        ' regladetres = (CDbl(txtfraccion.Text & CStr(e.KeyChar)) / CDbl(txtmedida.Text) * CDbl(txtentero.Text)) * 1.1
        txtprecioFraccion.Text = Math.Round(regladetres, 2)
        precioFraccion = txtprecioFraccion.Text
    End Sub

    Private Sub txtfraccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfraccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)
        End If
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

End Class