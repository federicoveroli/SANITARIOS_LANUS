Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroDomicilio
    Public Function colDomiciliosEnte(ByVal idEnte As Integer) As List(Of Domicilio)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from Domicilio where idente=" & idEnte)
        Dim fila As DataRow
        Dim objDomicilio As Domicilio
        colDomiciliosEnte = New List(Of Domicilio)
        For Each fila In dt.Rows
            objDomicilio = New Domicilio()
            objDomicilio.IdDomicilio = fila("idDomicilio")
            objDomicilio.Altura = fila("altura")
            objDomicilio.Calle = fila("calle")
            If Not IsDBNull(fila("depto")) Then objDomicilio.Depto = fila("depto")
            objDomicilio.IdEnte = fila("idente")
            objDomicilio.Localidad = fila("localidad")
            objDomicilio.Partido = fila("Partido")
            If Not IsDBNull(fila("piso")) Then objDomicilio.Piso = fila("piso")
            If Not IsDBNull(fila("CodigoPostal")) Then objDomicilio.CodigoPostal = fila("CodigoPostal")
            colDomiciliosEnte.Add(objDomicilio)
        Next
    End Function
    Public Function traerPartidos() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select DISTINCT partido from domicilio")
    End Function
    Public Function traerLocalidades() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select DISTINCT localidad from domicilio")
    End Function

    Public Sub altaDomicilio(ByVal adDomicilio As Domicilio)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("incalle", adDomicilio.Calle))
        params.Add(New MySqlParameter("inaltura", adDomicilio.Altura))
        params.Add(New MySqlParameter("inpiso", adDomicilio.Piso))
        params.Add(New MySqlParameter("indepto", adDomicilio.Depto))
        params.Add(New MySqlParameter("inlocalidad", adDomicilio.Localidad))
        params.Add(New MySqlParameter("inidente", adDomicilio.IdEnte))
        params.Add(New MySqlParameter("inPartido", adDomicilio.Partido))
        params.Add(New MySqlParameter("inCodigoPostal", adDomicilio.CodigoPostal))

        AccesoDatos.Instancia.EjecutarComando("Domicilio_insert", params)

    End Sub
    Public Sub modificarDomicilio(ByVal adDomicilio As Domicilio)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdDomicilio", adDomicilio.IdDomicilio))
        params.Add(New MySqlParameter("incalle", adDomicilio.Calle))
        params.Add(New MySqlParameter("inaltura", adDomicilio.Altura))
        params.Add(New MySqlParameter("inpiso", adDomicilio.Piso))
        params.Add(New MySqlParameter("indepto", adDomicilio.Depto))
        params.Add(New MySqlParameter("inlocalidad", adDomicilio.Localidad))
        params.Add(New MySqlParameter("inidente", adDomicilio.IdEnte))
        params.Add(New MySqlParameter("inPartido", adDomicilio.Partido))
        params.Add(New MySqlParameter("inCodigoPostal", adDomicilio.CodigoPostal))


        AccesoDatos.Instancia.EjecutarComando("Domicilio_update", params)
    End Sub
    Public Sub eliminarDomicilio(ByVal mpDomicilio As Domicilio)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdDomicilio", mpDomicilio.IdDomicilio))
        AccesoDatos.Instancia.EjecutarComando("Domicilio_delete", params)
    End Sub

End Class
