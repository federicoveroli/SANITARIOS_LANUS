Imports Modelo
Imports System.Windows.Forms

Public Class CargadorDePermisos

    Public Sub HabilitarMenu(ByVal menuItems As ToolStripItemCollection)

        Dim fp As New FachadaPermiso
        For Each item As ToolStripMenuItem In menuItems

            item.Visible = Sesion.getSesion().UsuarioActivo.TienePermiso(item.Name)
            If (item.HasDropDownItems) Then
                HabilitarMenu(item.DropDownItems)
            End If

        Next

    End Sub
End Class
