Imports System.Windows.Forms
Imports Modelo
Imports Datos

Public Class FachadaProveedor
    Public Sub AltaProveedor(ByVal pro As Proveedor)
        Dim regpro As New RegistroProveedor
        regpro.altaProveedor(pro)

    End Sub
    Public Sub ModificarProveedor(ByVal pro As Proveedor)
        Dim regpro As New RegistroProveedor
        regpro.modificarProveedor(pro)
    End Sub
    Public Sub BajaProveedor(ByVal idProveedor As Integer)
        Dim regpro As New RegistroProveedor
        regpro.bajaProveedor(idProveedor)

    End Sub
    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim regpro As New RegistroProveedor
        Dim dt As DataTable = regpro.listarParaCombo()
        Dim pro As IdProveedor

        For Each fila As DataRow In dt.Rows
            pro = New IdProveedor
            pro.Id = fila("idProveedor")
            pro.RazonSocial = fila("razonsocial")
            combo.Items.Add(pro)
        Next

    End Sub
    Public Function ListarTodos() As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarTodos
    End Function

    Public Function ListarPorNombre(ByVal nombre As String) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorNombre(nombre)
    End Function
    Public Function ListarPorId(ByVal id As Integer) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorID(id)
    End Function
    Public Function listarPorRubro(ByVal rubro As String) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorRubro(rubro)
    End Function
    Public Function listarPorContacto(ByVal contacto As String) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorContacto(contacto)
    End Function
    Public Function listarPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorCodigoPostal(codigoPostal)
    End Function
    Public Function listarPorLocalidad(ByVal localidad As String) As DataTable
        Dim regpro As New RegistroProveedor
        Return regpro.listarPorLocalidad(localidad)
    End Function
    Public Function TraerPorId(ByVal idProveedor As Integer) As Proveedor
        Dim regpro As New RegistroProveedor
        Return regpro.TraerPorId(idProveedor)
    End Function
    Public Function TraerIdPorNombre(ByVal nombre As String) As Integer
        Dim regpro As New RegistroProveedor
        Return regpro.TraerIdPorNombre(nombre)
    End Function
End Class
