Imports Modelo
Imports Datos
Imports System.Xml.Serialization
Imports System.IO

Public Class FachadaCadenaDeConexion
    Public Sub GuardarConexion(ByVal cn As CadenaDeConexion)
        Dim regCon As New RegistroCadenaDeConexion
        regCon.Guardar(cn)
    End Sub

    Public Sub GuardarConexiones(ByVal conexiones As List(Of CadenaDeConexion))
        ' ********** PRUEBA GUARDAR MUCHAS CONEXIONES
        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(List(Of CadenaDeConexion)))
        Dim writer As TextWriter = New StreamWriter("Conexiones.xml")
        xmlSerial.Serialize(writer, conexiones)
        writer.Close()
        ' ********** fin PRUEBA GUARDAR MUCHAS CONEXIONES
    End Sub

    Public Function TraerConexion() As CadenaDeConexion
        Dim regCon As New RegistroCadenaDeConexion
        Return regCon.TraerCadenaDeConexion()
    End Function

    Public Function TraerConexiones() As List(Of CadenaDeConexion)
        Dim cc As New List(Of CadenaDeConexion)
        ' Construct an instance of the XmlSerializer with the type
        ' of object that is being deserialized.
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(List(Of CadenaDeConexion)))
        ' To read the file, create a FileStream.
        Dim myFileStream As FileStream = _
        New FileStream("Conexiones.xml", FileMode.Open)
        ' Call the Deserialize method and cast to the object type.
        cc = CType(mySerializer.Deserialize(myFileStream), List(Of CadenaDeConexion))
        myFileStream.Close()
        Return cc
    End Function


End Class
