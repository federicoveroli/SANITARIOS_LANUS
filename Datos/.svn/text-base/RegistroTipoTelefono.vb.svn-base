Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroTipoTelefono
    Public Function buscarTipoTelefono(ByVal id As Integer) As TipoTelefono
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from TipoTelefono where idTipoTelefono=" & id)
        Dim fila As DataRow = dt.Rows(0)
        Dim objTelefono As New TipoTelefono()
        objTelefono.Descripcion = fila("descripcion")
        objTelefono.IdTipoTelefono = fila("idTipoTelefono")
        Return objTelefono
    End Function
    Public Function listarTiposTelefonos() As List(Of TipoTelefono)
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from TipoTelefono")
        Dim fila As DataRow
        listarTiposTelefonos = New List(Of TipoTelefono)
        For Each fila In dt.Rows
            Dim objTelefono As New TipoTelefono()
            objTelefono.Descripcion = fila("descripcion")
            objTelefono.IdTipoTelefono = fila("idTipoTelefono")
            listarTiposTelefonos.Add(objTelefono)
        Next

    End Function
End Class
