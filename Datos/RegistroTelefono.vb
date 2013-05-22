Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroTelefono
    Public Function colTelefonosEnte(ByVal idEnte As Integer) As List(Of Telefono)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from Telefono where idente=" & idEnte)
        Dim fila As DataRow
        Dim objTelefono As Telefono
        colTelefonosEnte = New List(Of Telefono)
        For Each fila In dt.Rows
            objTelefono = New Telefono()

            objTelefono.IdTelefono = fila("idTelefono")
            objTelefono.IdEnte = fila("idente")
            objTelefono.IdTipoTelefono = fila("idtipotelefono")
            objTelefono.NombreContacto = fila("nombrecontacto")
            objTelefono.Numero = fila("numero")

            colTelefonosEnte.Add(objTelefono)
        Next
    End Function
    Public Sub altaTelefono(ByVal adTelefono As Telefono)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inidtipotelefono", adTelefono.IdTipoTelefono))
        params.Add(New MySqlParameter("innombrecontacto", adTelefono.NombreContacto))
        params.Add(New MySqlParameter("innumero", adTelefono.Numero))
        params.Add(New MySqlParameter("inidente", adTelefono.IdEnte))
        AccesoDatos.Instancia.EjecutarComando("Telefono_insert", params)
    End Sub
    Public Sub modificarTelefono(ByVal adTelefono As Telefono)
        Dim params As New List(Of MySqlParameter)

        params.Add(New MySqlParameter("inIdTelefono", adTelefono.IdTelefono))
        params.Add(New MySqlParameter("inidtipotelefono", adTelefono.IdTipoTelefono))
        params.Add(New MySqlParameter("innombrecontacto", adTelefono.NombreContacto))
        params.Add(New MySqlParameter("innumero", adTelefono.Numero))
        params.Add(New MySqlParameter("inidente", adTelefono.IdEnte))

        AccesoDatos.Instancia.EjecutarComando("Telefono_update", params)
    End Sub
    Public Sub eliminarTelefono(ByVal mpTelefono As Telefono)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdTelefono", mpTelefono.IdTelefono))
        AccesoDatos.Instancia.EjecutarComando("Telefono_delete", params)
    End Sub
End Class

