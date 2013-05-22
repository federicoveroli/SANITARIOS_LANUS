Public Class Limpiar
    Public Shared Sub LimpiarControles(ByVal controls As System.Windows.Forms.Control.ControlCollection)
        Dim cmb As ComboBox
        For Each control As Control In controls
            If control.Name.StartsWith("txt") Then
                control.Text = ""
            ElseIf control.Name.StartsWith("cmb") Then
                cmb = control
                If cmb.Items.Count > 0 Then
                    cmb.SelectedIndex = 0
                End If
            End If
            If control.HasChildren Then
                LimpiarControles(control.Controls)
            End If
        Next
    End Sub
End Class
