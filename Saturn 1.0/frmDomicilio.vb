Imports Fachada
Imports Modelo

Public Class frmDomicilio
    Private vConfirmo As Boolean
    Private facDomicilio As FachadaDomicilio
    Private vDomicilio As Domicilio
    Public cancelo As Boolean
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        '*************VALIDO LO INGRESADO
        cancelo = False
        'If txtAltura.Text.Trim() = "" Then
        '    MessageBox.Show("Debe ingresar la altura.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtAltura.Select()
        '    Exit Sub
        'End If
        vDomicilio = New Domicilio
        vDomicilio.Altura = 0
        If txtAltura.Text <> "" Then
            vDomicilio.Altura = txtAltura.Text
        End If
        
        vDomicilio.Calle = txtCalle.Text

        vDomicilio.CodigoPostal = txtCodigoPostal.Text
        vDomicilio.Depto = txtDepto.Text
        vDomicilio.Localidad = cmbLocalidad.Text
        vDomicilio.Partido = cmbPartido.Text
        vDomicilio.Piso = txtPiso.Text
        vConfirmo = True
        Me.Close()
    End Sub
    Public Property DataSource() As Domicilio
        Get
            Return vDomicilio
        End Get
        Set(ByVal value As Domicilio)
            vDomicilio = value
            txtAltura.Text = vDomicilio.Altura
            txtCalle.Text = vDomicilio.Calle
            txtCodigoPostal.Text = vDomicilio.CodigoPostal
            txtDepto.Text = vDomicilio.Depto
            cmbLocalidad.Text = vDomicilio.Localidad
            cmbPartido.Text = vDomicilio.Partido
            txtPiso.Text = vDomicilio.Piso
        End Set
    End Property

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        vConfirmo = False
        cancelo = True
        Me.Close()
    End Sub
    Public ReadOnly Property Confirmo() As Boolean
        Get
            Return vConfirmo 'si presiona Aceptar = true
        End Get
    End Property

    Private Sub frmDomicilio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        facDomicilio = New FachadaDomicilio
        vDomicilio = New Domicilio
        cmbLocalidad.DataSource = facDomicilio.TraerLocalidades
        cmbLocalidad.DisplayMember = "localidad"
        cmbPartido.DataSource = facDomicilio.TraerPartidos
        cmbPartido.DisplayMember = "partido"
        cmbLocalidad.Text = ""
        cmbPartido.Text = ""
        cancelo = False
        LimpiarFormulario()
    End Sub
    Public Sub LimpiarFormulario()
        Limpiar.LimpiarControles(Me.Controls)
    End Sub

    Private Sub txtCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalle.KeyPress
    End Sub


    Private Sub txtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltura.KeyPress
        e.Handled = Not Validar.EsNumero(e.KeyChar.ToString())
    End Sub


    Private Sub txtPiso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiso.KeyPress
        'e.Handled = Not Validar.EsNumero(e.KeyChar.ToString()) MILI PERMITE TEXTO
    End Sub

End Class