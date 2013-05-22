Imports Modelo
Imports MySql.Data.MySqlClient
Public Class RegistroBitacora
    Public Sub IngresarEnBitacora(ByVal id As String, ByVal fechas As Date, ByVal descripcion As String)
        Dim fechaDesdeSTR As String
        fechaDesdeSTR = CStr(fechas.Year) & "-" & CStr(fechas.Month) & "-" & CStr(fechas.Day) & " " & CStr(fechas.Hour & ":" & fechas.Minute & ":" & fechas.Second)
        AccesoDatos.Instancia.EjecutarConsulta("insert into bitacora values ('" & id & "'," & "'" & fechaDesdeSTR & "','" & descripcion & "')")
    End Sub
    Public Function listarParaCombo() As DataTable
        Return AccesoDatos.Instancia.EjecutarConsulta("select nick  from usuario")
    End Function
    Public Function TraerPorNick(ByVal nick As String) As DataTable
        Dim dt As DataTable = AccesoDatos.Instancia.EjecutarConsulta("select id as Nick, fecha as Fecha,descripcion as Descripcion from bitacora where id ='" & nick & "' order by Fecha DESC")
        Return dt
    End Function
    Public Function ListarBitacoraFecha(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim fechaDesdeSTR As String, fechaHastaSTR As String
        fechaDesdeSTR = CStr(fechaDesde.Year) & "-" & CStr(fechaDesde.Month) & "-" & CStr(fechaDesde.Day)
        fechaHastaSTR = CStr(fechaHasta.Year) & "-" & CStr(fechaHasta.Month) & "-" & CStr(fechaHasta.Day)
        Return AccesoDatos.Instancia.EjecutarConsulta("select id as Nick, fecha as Fecha,descripcion as Descripcion from bitacora where fecha > '" & fechaDesdeSTR & "' and fecha < '" & fechaHastaSTR & "'")
    End Function
    Public Function traeridSSSSS(ByVal where As String) As DataTable
        Dim dt As DataTable
        dt = AccesoDatos.Instancia.EjecutarConsulta("select idarticulo  , descripcion, precio  from articulo " & where)
        Return dt
    End Function


End Class
