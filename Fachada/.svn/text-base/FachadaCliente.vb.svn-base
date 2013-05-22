Imports System.Windows.Forms
Imports Modelo
Imports Datos

Public Class FachadaCliente
    Public Sub AltaCliente(ByVal cli As Cliente)
        Dim regCli As New RegistroCliente
        regCli.altaCliente(cli)
    End Sub
    Public Sub ModificarCliente(ByVal cli As Cliente)
        Dim regCli As New RegistroCliente
        regCli.modificarCliente(cli)
    End Sub
    Public Sub BajaCliente(ByVal idCliente As Integer)
        Dim regCli As New RegistroCliente
        regCli.bajaCliente(idCliente)
    End Sub
    Public Function ListarTodos() As DataTable
        Dim regCli As New RegistroCliente
        Return regCli.listarTodos
    End Function
    Public Function ListarPorIva(ByVal iva As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorIva(iva)
    End Function
    Public Function ListarPorNombre(ByVal nombre As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorNombre(nombre)
    End Function
    Public Function ListarPorId(ByVal id As Integer) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorID(id)
    End Function
    Public Function listarPorRubro(ByVal rubro As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorRubro(rubro)
    End Function
    Public Function listarPorCuit(ByVal cuit As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorCuit(cuit)
    End Function
    Public Function listarPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorCodigoPostal(codigoPostal)
    End Function
    Public Function listarPorLocalidad(ByVal localidad As String) As DataTable
        Dim regcli As New RegistroCliente
        Return regcli.listarPorLocalidad(localidad)
    End Function
    Public Function TraerPorId(ByVal idCliente As Integer) As Cliente
        Dim regcli As New RegistroCliente
        Return regcli.TraerPorId(idCliente)
    End Function
    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim regpro As New RegistroCliente
        Dim dt As DataTable = regpro.listarParaCombo()
        Dim clie As IdCliente
        combo.Items.Clear()
        For Each fila As DataRow In dt.Rows
            clie = New IdCliente
            clie.Id = fila("idcliente")
            clie.nombre = fila("nombre")
            combo.Items.Add(clie)
        Next
    End Sub
    Public Function TraerLimite(ByVal id As Integer) As DataTable
        Dim regClien As New RegistroCliente
        Return regClien.TraerLimiteCredito(id)
    End Function
    Public Function FijarmeSidebe(ByVal id As Integer)
        Dim dt As DataTable
        Dim r As New RegistroCliente
        dt = r.MirarSiDeBe(id)
        Return dt
    End Function
End Class
