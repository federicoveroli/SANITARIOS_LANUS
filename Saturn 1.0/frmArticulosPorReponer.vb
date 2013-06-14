Imports Fachada
Imports Modelo

Public Class frmArticulosPorReponer
    Dim fac As New Fachada.FachadaArticulo

    Private Sub frmArticulosPorReponer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = fac.listarArticulosPorReponer()

        Dim i As Integer
        For i = 0 To DataGridView1.Columns.Count - 2
            DataGridView1.Columns(i).ReadOnly = True
        Next
        If Not DataGridView1.Columns.Contains("cantidad") Then
            DataGridView1.Columns.Add("cantidad", "cantidad")
            DataGridView1.Columns("cantidad").ReadOnly = False
        End If
        'MsgBox((Me.Width - CmdSalir.Left))
    End Sub

    Private Sub frmArticulosPorReponer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CmdSalir.Top = Me.Height - 73
        CmdSalir.Left = Me.Width - 103
    End Sub

    Private Sub TipoDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 1
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 3
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub DescripcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 2
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub
    Private Sub ListadoTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTotalToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 0
        txtQueContenga.Text = ""
        txtQueContenga.Select()
        cmdBuscar_Click(sender, e)
    End Sub

    Public Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        BuscarArticulo()
        DataGridView1.Select()

    End Sub

    Private Sub BuscarArticulo()
        If cmbBuscarPor.SelectedIndex <> 0 And txtQueContenga.Text <> "" Then

            Dim lista As New FachadaArticulo
            Dim X As Integer
            X = cmbBuscarPor.SelectedIndex
            Select Case (X)
                Case 0 'todos
                    DataGridView1.DataSource = lista.listarArticulos
                Case 1 'tipo de Producto
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXTipo(z)
                Case 2
                    Dim z As String 'Descripcion
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXDescripcion(z, "", "")
                Case 3 'marca
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXMarca(z)
                Case 4 ' proveedor
                    Dim z As String
                    z = txtQueContenga.Text
                    DataGridView1.DataSource = lista.ListarArticulosXProveedor(z)
            End Select
           

        End If
        ResizearColumnas()

    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        cmbBuscarPor.SelectedIndex = 4
        txtQueContenga.Text = ""
        txtQueContenga.Select()
    End Sub

  

    Public Sub ResizearColumnas()
        Try
            'DataGridView1.Columns(0).Width = 30
            'DataGridView1.Columns(1).Width = 100
            'DataGridView1.Columns(2).Width = 50
            'DataGridView1.Columns(3).Width = 50
            'DataGridView1.Columns(4).Width = 50
            'DataGridView1.Columns(5).Width = 40
            'DataGridView1.Columns(6).Width = 40
            'DataGridView1.Columns(7).Width = 40

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtQueContenga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQueContenga.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataGridView1.Select()
            Exit Sub
        End If
    End Sub


    Private Sub txtQueContenga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQueContenga.TextChanged
        BuscarArticulo()
    End Sub

End Class