Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroRubro
    Public Function listarRubros() As List(Of Rubro)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from rubro")
        Dim fila As DataRow
        Dim objrubro As Rubro
        listarRubros = New List(Of Rubro)
        For Each fila In dt.Rows
            objrubro = New Rubro()
            objrubro.IdRubro = fila("idrubro")
            objrubro.Descripcion = fila("descripcion")
            listarRubros.Add(objrubro)
        Next
    End Function
    Public Sub Alta(ByVal descripcion As String)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inDescripcion", descripcion))
        AccesoDatos.Instancia.EjecutarComando("rubro_insert", params)
    End Sub
    Public Function traerIdRubroXdescripcion(ByVal descripcion As String) As Integer
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from rubro where descripcion='" & descripcion & "'")
        If dt.Rows.Count = 0 Then
            Return 0
        Else
            Return dt.Rows(0).Item(0)
        End If

    End Function
End Class
