Imports Datos
Imports Modelo
Imports Fachada
Imports System.Windows.Forms


Public Class FachadaUsuario
    Public Sub AutenticarUsuario(ByVal nick As String, ByVal pass As String)
        Dim sumaDeVerif As New Checksum
        Dim ru As New RegistroUsuarios
        Dim usu As Usuario = ru.buscarUsuario(nick)
        If IsNothing(usu) Then
            'lanzo una LoginException ya que el usuario no existe
            Throw New LoginException
        End If
        If sumaDeVerif.GenerarCheckSum(pass) <> usu.Pass Then
            'lanzo una LoginException ya que el password no coincide
            Throw New LoginException
        End If
        CargarTodosLosPermisos(usu)
        Sesion.getSesion.UsuarioActivo = usu

    End Sub
    Public Sub altaUsuario(ByVal nick As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String)
        Dim sumaDeVerif As New Checksum
        Dim usuario As New Usuario(nick, sumaDeVerif.GenerarCheckSum(pass), nombre, apellido)
        Dim ru As New RegistroUsuarios
        Dim usu As Usuario = ru.buscarUsuario(nick)
        If Not IsNothing(usu) Then
            If usu.Eliminado Then
                'si existe el usuario verifico si no esta dado de baja
                Throw New UsuarioEliminadoException()
            Else
                'si no esta dado de baja lanzo la excepcion de nick no disponible
                Throw New NickNoDisponibleException()
            End If
        End If
        'ingreso el usuario a la base de datos
        ru.ingresarUsuario(usuario)
    End Sub
    Public Function listarUsuarios() As List(Of Usuario)
        Dim ru As New RegistroUsuarios
        Return ru.listarUsuarios()
    End Function
    Public Sub cargarCombo(ByVal cmbUsuarios As ComboBox)
        Dim listUsers As List(Of Usuario)
        listUsers = listarUsuarios()
        cmbUsuarios.Items.Clear()
        cmbUsuarios.Items.Add("TODOS")
        For Each user As Usuario In listUsers
            cmbUsuarios.Items.Add(user)
        Next
    End Sub
    Public Sub bajaUsuario(ByVal idUsuario As Integer)
        Dim ru As New RegistroUsuarios
        If ru.usuariosActivos = 1 Then Throw New UltimoUsuarioException
        ru.eliminarUsuario(idUsuario)
    End Sub
    Public Sub modificarUsuario(ByVal nickAnterior As String, ByVal usuario As Usuario)
        Dim ru As New RegistroUsuarios
        Dim sumaDeVerif As New Checksum
        If nickAnterior <> usuario.Nick Then
            'si cambia el nick verifico la disponibilidad del nuevo
            If ru.nickDisponible(usuario.Nick) = False Then Throw New NickNoDisponibleException()
        End If
        usuario.Pass = sumaDeVerif.GenerarCheckSum(usuario.Pass)
        ru.modificarUsuario(usuario)
    End Sub
    Public Sub restaurarUsuario(ByVal nick As String)
        Dim ru As New RegistroUsuarios
        ru.restaurarUsuario(nick)
    End Sub
    Public Sub CargarPermisos(ByVal usu As Usuario)
        Dim rp As New RegistroPermisos
        usu.Permisos = rp.traerPermisosPorUsuario(usu.Id)
    End Sub
    Public Sub GuardarPermisos(ByVal usu As Usuario)
        Dim ru As New RegistroUsuarios
        ru.GuardarPermisos(usu)
    End Sub
    Private Sub CargarTodosLosPermisos(ByVal usu As Usuario)
        'cargo los permisos del usuario y el perfil
        Dim rp As New RegistroPermisos
        usu.Permisos = rp.traerPermisosPorUsuarioYPerfil(usu.Id)
    End Sub
End Class
