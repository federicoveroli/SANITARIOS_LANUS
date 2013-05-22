Imports Fachada

Public Class frmLogin
    Dim fu As FachadaUsuario
    Dim inicioSession As Boolean


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            fu.AutenticarUsuario(txtNick.Text, txtClave.Text)
            frmPrincipal.CargarPermisos()
            frmPrincipal.Show()
            inicioSession = True
            Me.Hide()
        Catch ex As LoginException
            MessageBox.Show(ex.Message, "Error de Logeo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            'en caso de lanzarse una excepcion es debido al string de conexion invalido
            MessageBox.Show("El archivo de conexion a la base no esta configurado adecuadamente," & vbCr & "configure los datos de la conexion al servidor de la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmConexion.ShowDialog()
        End Try


    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not inicioSession Then Application.Exit()

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fu = New FachadaUsuario
        txtNick.Text = ""
        txtClave.Text = ""
        txtNick.Select()
        inicioSession = False
        'Impresora.imprimir(vta)

        'Dim fac As New clsReportCreator
        'fac.CreateXMLFile()
        'loguear()
        'Dim puerto As New System.IO.Ports.SerialPort()
        'puerto.PortName = "LTP1"
        'puerto.Open()
        'puerto.WriteLine("Hola Carola!")
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub loguear()
        txtClave.Text = "123456"
        txtNick.Text = "ADMIN"
        btnAceptar_Click(New Object, New EventArgs)
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    FrmPrincipal.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    '    Application.Exit()
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' frmMigrarArticulos.Show()
        Dim ff As New FachadaReporte
        ff.ImpresionDeFactura(22, "X")

    End Sub



End Class