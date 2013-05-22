Imports System.Xml.Serialization
Imports System.IO
Imports Modelo


Public Class FachadaConfigSaturn
    Public Sub Guardar(ByVal cc As ConfigSaturn)

        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(ConfigSaturn))
        Dim writer As TextWriter = New StreamWriter("configSaturn.xml")
        xmlSerial.Serialize(writer, cc)
        writer.Close()
    End Sub
    Public Function TraerConfigSaturn() As ConfigSaturn
        Dim cc As New ConfigSaturn
        ' Construct an instance of the XmlSerializer with the type
        ' of object that is being deserialized.
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(ConfigSaturn))
        ' To read the file, create a FileStream.
        Dim myFileStream As FileStream = _
        New FileStream("configSaturn.xml", FileMode.Open)
        ' Call the Deserialize method and cast to the object type.
        cc = CType(mySerializer.Deserialize(myFileStream), ConfigSaturn)
        myFileStream.Close()
        Return cc
    End Function
End Class
