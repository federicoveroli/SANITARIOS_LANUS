Imports System.Xml.Serialization
Imports System.IO
Imports Modelo

Public Class RegistroInfoTicket
    Public Sub Guardar(ByVal cc As InfoTicket)

        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(InfoTicket))
        Dim writer As TextWriter = New StreamWriter("Ticket.xml")
        xmlSerial.Serialize(writer, cc)
        writer.Close()
    End Sub
    Public Function TraerInfoTicket() As InfoTicket
        Dim cc As New InfoTicket
        ' Construct an instance of the XmlSerializer with the type
        ' of object that is being deserialized.
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(InfoTicket))
        ' To read the file, create a FileStream.
        Dim myFileStream As FileStream = _
        New FileStream("Ticket.xml", FileMode.Open)
        ' Call the Deserialize method and cast to the object type.
        cc = CType(mySerializer.Deserialize(myFileStream), InfoTicket)
        myFileStream.Close()
        Return cc
    End Function

End Class
