Public Class FormVerProducto

    'Private Sub FormVerProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    adapter.SelectCommand.CommandText = "select * from eventos where nombre like '%" & txtnombre.Text & "%' "
    '    If Not lec.IsClosed Then lec.Close()
    '    lec = comando.ExecuteReader
    '    FlowLayoutPanel1.Controls.Clear()
    '    cmbEvento.Items.Clear()
    '    Dim img As PictureBox
    '    Do While lec.Read
    '        img = New PictureBox()
    '        AddHandler img.Click, AddressOf picEvento_Click
    '        AddHandler img.DoubleClick, AddressOf picEvento_DoubleClick
    '        With img
    '            .SizeMode = PictureBoxSizeMode.Zoom
    '            .Image = Image.FromFile(lec.Item("URLImagen"))
    '            .Height = 96
    '            .Width = 119
    '            .BorderStyle = BorderStyle.FixedSingle
    '            .Tag = lec.Item("idEvento")
    '            .Cursor = Cursors.Hand

    '        End With

    '        cmbEvento.Items.Add(lec.Item("nombre"))
    '        idsEventos(cmbEvento.Items.Count - 1) = lec.Item("idEvento")

    '        FlowLayoutPanel1.Controls.Add(img)
    '    Loop
    '    lec.Close()
    'End Sub
End Class