Imports Modelo
Imports Datos
Imports System.Windows.Forms

Public Class FachadaBitacora
    Public Sub RegistrarBitacora(ByVal id As String, ByVal fecha As Date, ByVal descripcion As String)
        Dim reg As New RegistroBitacora
        reg.IngresarEnBitacora(id, fecha, descripcion)
    End Sub


    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim reg As New RegistroBitacora
        Dim dt As DataTable = reg.listarParaCombo()
        Dim usu As Usuario

        For Each fila As DataRow In dt.Rows
            usu = New Usuario
            usu.Nick = fila("nick")
        Next
    End Sub
    Public Function TraerXnick(ByVal nick As String)
        Dim reg As New RegistroBitacora
        Return reg.TraerPorNick(nick)
    End Function
    Public Function ListarBitacorasXfecha(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim reg As New RegistroBitacora
        Return reg.ListarBitacoraFecha(fechaDesde, fechaHasta)
    End Function

    Public Sub traeriD(ByVal where As String)
        Dim reg As New RegistroBitacora
        Dim dt As DataTable
        dt = reg.traeridSSSSS(where)
        'recorro el dt insertando las modificaciones
        Dim facart As New FachadaArticulo, art As Articulo
        For Each fila As DataRow In dt.Rows
            Dim variableString As String
            variableString = "Art= " & fila(0)
            art = facart.TraerArticulo(fila(0))
            art.Precio = art.Costo + (art.Costo * art.Utilidad / 100)
            facart.ModificarArticulo2(art)
            variableString = variableString & ", " & fila(1) & ", " & "y su precio era " & fila(2)
            RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, variableString)
        Next
    End Sub
    Public Function traeriDs(ByVal where As String) As DataTable
        Dim dt As DataTable
        Dim reg As New RegistroBitacora
        dt = reg.traeridSSSSS(where)
        Return dt
    End Function
    Public Sub GrabarReemplazo(ByVal where As String)
        Dim reg As New RegistroBitacora
        Dim dt As DataTable
        dt = reg.traeridSSSSS(where)
        'recorro el dt insertando las modificaciones
        For Each fila As DataRow In dt.Rows
            Dim variableString As String
            variableString = "Art= " & fila(0)
            variableString = variableString & ", " & fila(1) & ", " & "y su precio era " & fila(2)
            RegistrarBitacora(Sesion.getSesion.UsuarioActivo.Nick, Date.Now, variableString)
        Next
    End Sub
    Public Sub ActualizarPrecios(ByVal dt As DataTable)
        Dim reg As New RegistroBitacora

        'recorro el dt insertando las modificaciones
        Dim facart As New FachadaArticulo, art As Articulo
        For Each fila As DataRow In dt.Rows
            art = facart.TraerArticulo(fila(0))
            art.Precio = art.Costo + (art.Costo * art.Utilidad / 100)
            facart.ModificarArticulo2(art)
        Next
    End Sub

End Class
