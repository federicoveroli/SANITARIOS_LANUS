Imports Datos
Imports Modelo
Imports System.Windows.Forms

Public Class FachadaTelefono
    Public Sub CargarGrilla(ByVal objEnte As Ente, ByVal grilla As DataGridView)
        Dim colTelefonos As New List(Of Telefono)
        Dim objTelefono As Telefono
        Dim regTelefono As New RegistroTelefono
        colTelefonos = regTelefono.colTelefonosEnte(objEnte.IdEnte)


        For Each objTelefono In colTelefonos
            objEnte.AddTelefono(objTelefono)
            CargarTelefonoEnGrilla(objTelefono, grilla)
        Next

    End Sub
    Public Sub CargarTelefonoEnGrilla(ByVal objTelefono As Telefono, ByVal grilla As DataGridView)
        Dim regTelefono As New RegistroTelefono
        Dim regTipoTelefono As New RegistroTipoTelefono

        Dim objTipoTelefono As New TipoTelefono
        objTipoTelefono = regTipoTelefono.buscarTipoTelefono(objTelefono.IdTipoTelefono)
        grilla.Rows.Add(objTelefono.NombreContacto, objTelefono.Numero, objTipoTelefono.Descripcion)
        grilla.Rows(grilla.NewRowIndex).Tag = objTelefono
        grilla.AutoResizeColumns()
        grilla.AutoResizeRows()
    End Sub

    Public Sub GenerarColumnasEnGrilla(ByVal grilla As DataGridView)
        grilla.Columns.Clear()
        grilla.Columns.Add("nombrecontacto", "Contacto")
        grilla.Columns.Add("numero", "Número")
        grilla.Columns.Add("tipotelefono", "Tipo")
    End Sub

    Public Function colTelefonosEnte(ByVal idEnte As Integer) As List(Of Telefono)
        Dim regTelefono As New RegistroTelefono
        'If regTelefono.descipcionDisponible(apTelefono.descripcion) = True Then
        Return regTelefono.colTelefonosEnte(idEnte)
    End Function
    Public Function listarTiposTelefonos() As List(Of TipoTelefono)
        Dim regTT As New RegistroTipoTelefono
        Return regTT.listarTiposTelefonos()
    End Function
End Class
