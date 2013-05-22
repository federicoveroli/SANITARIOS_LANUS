Imports System.Xml.Serialization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Modelo

Public Class RegistroCadenaDeConexion
    Public Sub Guardar(ByVal cc As CadenaDeConexion)
        Dim enc As New Encriptador
        cc.Password = enc.EncriptarCadena(cc.Password)
        ProbarConexion(cc)
        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(CadenaDeConexion))
        Dim writer As TextWriter = New StreamWriter("Conexion.xml")
        xmlSerial.Serialize(writer, cc)
        writer.Close()
    End Sub
    Public Function TraerCadenaDeConexion() As CadenaDeConexion
        Dim cc As New CadenaDeConexion
        ' Construct an instance of the XmlSerializer with the type
        ' of object that is being deserialized.
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(CadenaDeConexion))
        ' To read the file, create a FileStream.
        Dim myFileStream As FileStream = _
        New FileStream("Conexion.xml", FileMode.Open)
        ' Call the Deserialize method and cast to the object type.
        cc = CType(mySerializer.Deserialize(myFileStream), CadenaDeConexion)
        myFileStream.Close()
        Return cc
    End Function
    Public Function GenerarConecctionString(ByVal cc As CadenaDeConexion) As String
        Dim cnStr As String
        Dim enc As New Encriptador
        cnStr = "server=" & cc.Servidor & ";user id=" & cc.Usuario & ";password=" & enc.DesEncriptarCadena(cc.Password) & ";database=" & cc.Base & ";persist security info=True"
        Return cnStr
    End Function
    Private Sub ProbarConexion(ByVal cc As CadenaDeConexion)
        Dim cn As New MySqlConnection(GenerarConecctionString(cc))
        cn.Open()
    End Sub
End Class
