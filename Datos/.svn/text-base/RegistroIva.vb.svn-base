Imports Modelo
Imports MySql.Data.MySqlClient

Public Class RegistroIva
    Public Function listarIvas() As List(Of Iva)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from iva")
        Dim fila As DataRow
        Dim objIva As Iva
        listarIvas = New List(Of Iva)
        For Each fila In dt.Rows
            objIva = New Iva()
            objIva.IdIva = fila("idIva")
            objIva.Descripcion = fila("descripcion")
            objIva.Alicuota = fila("alicuota")
            listarIvas.Add(objIva)
        Next
    End Function
    Public Function traerPorId(ByVal id As Integer) As Iva
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from iva where idIva=" & id)
        Dim fila As DataRow
        fila = dt.Rows(0)
        Dim objIva As Iva
        objIva = New Iva()
        objIva.IdIva = fila("idIva")
        objIva.Descripcion = fila("descripcion")
        objIva.Alicuota = fila("alicuota")
        Return objIva
    End Function
End Class