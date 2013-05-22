Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroEnte
    Public Function listarEnte() As List(Of Ente)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from Ente")
        Dim fila As DataRow
        Dim objEnte As Ente
        listarEnte = New List(Of Ente)
        For Each fila In dt.Rows
            objEnte = New Ente()
            objEnte.IdEnte = fila("idEnte")
            objEnte.CUIT = fila("cuit")
            objEnte.FechaAlta = fila("fechaAlta")

            objEnte.IdRubro = fila("idRubro")
            listarEnte.Add(objEnte)
        Next
    End Function
    Public Function listarEnte(ByVal filtro As String) As List(Of Ente)
        Dim dt As DataTable 'es como un recoset pero que trabaja desconectado
        dt = AccesoDatos.Instancia.EjecutarConsulta("select * from Ente where razonsocial like '%" + filtro + "%'")
        Dim fila As DataRow
        Dim objEnte As Ente
        listarEnte = New List(Of Ente)
        For Each fila In dt.Rows
            objEnte = New Ente()
            objEnte.IdEnte = fila("idEnte")
            objEnte.CUIT = fila("cuit")
            objEnte.FechaAlta = fila("fechaAlta")

            objEnte.IdRubro = fila("idRubro")
            listarEnte.Add(objEnte)
        Next
    End Function
    Public Sub altaEnte(ByVal adEnte As Ente)
        Dim params As New List(Of MySqlParameter)
        Dim idEnte As New MySqlParameter("outIdEnte", 0)
        idEnte.Direction = ParameterDirection.Output
        params.Add(New MySqlParameter("incuit", adEnte.CUIT))
        params.Add(New MySqlParameter("infechaalta", adEnte.FechaAlta))
        params.Add(New MySqlParameter("inidrubro", adEnte.IdRubro))
        params.Add(idEnte)
        AccesoDatos.Instancia.EjecutarComando("Ente_insert", params)
        Dim rd As New RegistroDomicilio
        For Each dom As Domicilio In adEnte.Domicilios.Values
            dom.IdEnte = idEnte.Value
            rd.altaDomicilio(dom)
        Next
        Dim rt As New RegistroTelefono
        For Each tel As Telefono In adEnte.Telefonos.Values
            tel.IdEnte = idEnte.Value
            rt.altaTelefono(tel)
        Next
        adEnte.IdEnte = idEnte.Value
    End Sub
    Public Sub modificarEnte(ByVal adEnte As Ente)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdEnte", adEnte.IdEnte))
        params.Add(New MySqlParameter("incuit", adEnte.CUIT))
        params.Add(New MySqlParameter("infechaalta", adEnte.FechaAlta))
        params.Add(New MySqlParameter("inidrubro", adEnte.IdRubro))
        AccesoDatos.Instancia.EjecutarComando("Ente_update", params)

        ' ente-update actualiza el ente y elmina los domicilios y telefonos del mismo
        Dim rd As New RegistroDomicilio
        For Each dom As Domicilio In adEnte.Domicilios.Values
            dom.IdEnte = adEnte.IdEnte
            rd.altaDomicilio(dom)
        Next
        Dim rt As New RegistroTelefono
        For Each tel As Telefono In adEnte.Telefonos.Values
            tel.IdEnte = adEnte.IdEnte
            rt.altaTelefono(tel)
        Next

    End Sub
    Public Sub eliminarEnte(ByVal idEnte As Integer)
        Dim params As New List(Of MySqlParameter)
        params.Add(New MySqlParameter("inIdEnte", idEnte))
        AccesoDatos.Instancia.EjecutarComando("Ente_delete", params)
    End Sub
End Class

