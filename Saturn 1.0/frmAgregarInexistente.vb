Imports Modelo
Public Class frmAgregarInexistente
    Public acepto As Boolean
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtCantidad.Text = "" Then
            MessageBox.Show("Debe indicar la cantidad", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidad.Select()
            Exit Sub
        End If
        If txtPU.Text = "" Then
            MessageBox.Show("Debe indicar el precio", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidad.Select()
            Exit Sub
        End If
        If txtDetalle.Text = "" Then
            MessageBox.Show("Debe indicar el detalle", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDetalle.Select()
            Exit Sub
        End If
        txtDetalle.Text += "                 "
        acepto = True
        Me.Hide()

    End Sub

    Private Sub frmAgregarInexistente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub

    Private Sub frmAgregarInexistente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCantidad.Text = ""
        txtDetalle.Text = ""
        txtPU.Text = ""
        txtTotal.Text = ""
        txtCantidad.Select()
        acepto = False
    End Sub

    Private Sub txtPU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPU.KeyPress
        e.Handled = Not Validar.EsFlotante(e.KeyChar.ToString())
    End Sub

    Private Sub txtPU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPU.TextChanged
        If txtCantidad.Text <> "" And txtPU.Text <> "" Then txtTotal.Text = CInt(txtCantidad.Text) * CDbl(txtPU.Text)
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub

End Class