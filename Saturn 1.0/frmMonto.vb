Public Class frmMonto
    Public Event ProcesarMonto()
    Private Shared instancia As frmMonto
    Private vDescuento As Double
    Private vMonto As Double
    Private vTotalFactura As Double
    Private vAcepto As Boolean

    Public WriteOnly Property TotalFactura() As Double

        Set(ByVal value As Double)
            vTotalFactura = value
        End Set
    End Property

    Public Property Descuento() As Double
        Get
            Return vDescuento
        End Get
        Set(ByVal value As Double)
            vDescuento = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return vMonto
        End Get
        Set(ByVal value As Double)
            vMonto = value
            txtMonto.Text = value
        End Set
    End Property

    Public ReadOnly Property Acepto() As Boolean
        Get
            Return vAcepto
        End Get
    End Property


    Public Property Mensaje() As String
        Get
            Return lblMensaje.Text
        End Get
        Set(ByVal value As String)
            lblMensaje.Text = value
        End Set
    End Property

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If txtMonto.Text.Contains("-") Then
                    Dim vars As String()
                    vars = txtMonto.Text.Split("-")
                    vMonto = vars(0)
                    vDescuento = vars(1)
                    If vDescuento > vTotalFactura Then
                        MessageBox.Show("El descuento nunca puede superar el total" & vbCr & "Reingrese los valores correctos" & vbCr & "Recuerde que el formato será monto-descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    vMonto = Double.Parse(txtMonto.Text)
                End If
                vAcepto = True
                instancia.Hide()

            End If
            If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 45 Then
                e.Handled = False
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Debe ingresar el monto menos el descuento a aplicar (ej 100-20)", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Sub MostrarInputBox(ByVal mensaje As String, ByVal monto As String, ByVal totalFactura As String)
        'EL MANEJADOR ES EL OBJETO QUE VA A MANTENER UNA REFERENCIA A LA VENTANA
        'PARA MANEJAR LOS EVENTOS DE LA MISMA.
        Dim instance As frmMonto
        instance = GetInstancia()
        instance.TotalFactura = totalFactura
        instance.Monto = monto
        instance.txtMonto.Select(0, instance.txtMonto.Text.Length)
        instance.Mensaje = mensaje
        instance.ShowDialog()
    End Sub


    'Public Sub MostrarDescuento()
    '    Dim frm As New frmMonto
    '    frm.Mensaje = "Ingrese el monto descontado."
    '    frm.ShowDialog()
    '    instancia.Descuento = frm.Descuento
    'End Sub

    Public Shared Function GetInstancia() As frmMonto
        If instancia Is Nothing Then instancia = New frmMonto 'PATRON SINGLETON
        Return instancia
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        txtMonto.Text = "0"
        vMonto = 0
        Me.Hide()
    End Sub

    Private Sub frmMonto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.txtMonto.Text = "0"
            vAcepto = False
            vMonto = 0
            Me.Hide()
        End If

    End Sub


    Private Sub frmMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If Asc(e.KeyChar) = 45 Then
        '    MostrarDescuento()

        'End If

        Dim SeparadorDecimal As String
        SeparadorDecimal = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then ' hay que cambiar el punto por la coma
            e.KeyChar = Chr(Asc(SeparadorDecimal))
        End If
    End Sub


    Private Sub frmMonto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

End Class