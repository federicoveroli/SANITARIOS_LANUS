Imports Fachada
Imports System
Imports System.Windows.Forms
Imports System.IO
Imports Modelo

Public Class frmBackup
    Const vbquote As Char = Chr(34)
    Private Sub picBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBackup.Click
        Dim f As New FachadaCadenaDeConexion
        Dim Cad As New CadenaDeConexion
        Dim vCadena As String
        Cad = f.TraerConexion()
        vCadena = Cad.Servidor

        If vCadena.Contains("host") Then
        Else
            MsgBox("Esta accion debe realizarse desde el servidor de Base de Datos!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim explorer As SaveFileDialog = New SaveFileDialog
        Dim ruta As String
        Dim comando As String
        Dim result As DialogResult = explorer.ShowDialog()
        'FOR OL GENERICS
        Dim facCC As New FachadaCadenaDeConexion
        Dim cc As CadenaDeConexion
        cc = facCC.TraerConexion()

        'FIN FOR OL GENERICS
        If result = Windows.Forms.DialogResult.OK Then
            ruta = explorer.FileName
            Dim enc As New Encriptador
            'comando = "c:\archivos de programa\mysql\mysql server 5.0\bin\mysqldump --routines --user=root --password=0303456 --default-character-set=latin1 --databases valmar -r " & ruta & ".sql"
            'comando = "mysqldump --routines --user=root --password=0303456 --default-character-set=latin1 --databases valmar -r " & ruta & ".sql"
            comando = "mysqldump --routines --user=" & cc.Usuario & " --password=" & enc.DesEncriptarCadena(cc.Password) & " --default-character-set=latin1 --databases " & cc.Base & " -r " & ruta & ".sql"
            Shell(comando, AppWinStyle.MinimizedFocus, True)
            MsgBox("EL backUp se realizo correctamente!!", MsgBoxStyle.Information)
            picBackup.Enabled = False
            Me.Close()
        End If
        'Dim explorer As SaveFileDialog = New SaveFileDialog
        'Dim ruta As String
        'Dim comando As String
        'Dim result As DialogResult = explorer.ShowDialog()
        'If result = Windows.Forms.DialogResult.OK Then
        '    ruta = explorer.FileName
        '    comando = "c:\archivos de programa\mysql\mysql server 5.0\bin\mysqldump --routines --user=root --password=0303456 --databases cookie -r " & ruta & ".sql"
        '    Shell(comando, AppWinStyle.MinimizedFocus, True)
        'End If
    End Sub

    Private Sub picRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRestaurar.Click
        Dim f As New FachadaCadenaDeConexion
        Dim Cad As New CadenaDeConexion
        Dim vCadena As String
        Cad = f.TraerConexion()
        vCadena = Cad.Servidor
        If vCadena.Contains("host") Then
        Else
            MsgBox("Esta accion debe realizarse desde el servidor de Base de Datos!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim explorer As OpenFileDialog = New OpenFileDialog
        Dim ruta As String
        Dim result As DialogResult = explorer.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            ruta = explorer.FileName
            Dim _Arg, _NomUsr, _PasUsr, _Serv, _NomArc As String
            Dim _DobA As String = """"
            'FOR OL GENERICS
            Dim facCC As New FachadaCadenaDeConexion
            Dim cc As CadenaDeConexion
            cc = facCC.TraerConexion()
            Dim enc As New Encriptador
            'FIN FOR OL GENERICS
            _NomUsr = cc.Usuario
            _PasUsr = enc.DesEncriptarCadena(cc.Password)
            _Serv = cc.Servidor
            _NomArc = ruta
            '_Arg = vbquote & "c:\archivos de programa\mysql\mysql server 5.0\bin\" & vbquote & "mysql.exe --host=" & _Serv & " --user=" & _NomUsr & " --password=" & _PasUsr & " --force " & " valmar " & " < " & _NomArc
            _Arg = "mysql.exe --host=" & _Serv & " --user=" & _NomUsr & " --password=" & _PasUsr & " --force " & " liti " & " < " & _NomArc
            Try
                TextABat(_Arg, "C:\batch.bat")
                Shell("c:\batch.bat", AppWinStyle.Hide, True)
                Process.Start("c:\batch.bat")
                MessageBox.Show("El sistema se ha restaurado con exito al estado en el backup.", "Restauración completa!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error durante la restauración del sistema." & vbCr & "Detalle: " & ex.Message, "Error restaurando", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Dim Spath As String = "c:\batch.bat"
                My.Computer.FileSystem.DeleteFile(Spath) ' eliminamos el archivo para que no queden restos
            End Try

        End If
    End Sub
    Public Function TextABat(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean
        ' Creamos el .bat
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
        Return bAns
    End Function
End Class