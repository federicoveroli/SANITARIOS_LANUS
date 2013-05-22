Imports System.Security.Cryptography
Imports System.Text
Public Class Checksum
    Public Function GenerarCheckSum(ByVal aHashear As String) As String
        Dim md5 As New MD5CryptoServiceProvider
        Dim stream As Byte() = Nothing
        Dim encoding As New ASCIIEncoding
        stream = md5.ComputeHash(encoding.GetBytes(aHashear))
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 0 To stream.Length - 1
            sb.AppendFormat(stream(i).ToString("X2"))
        Next
        Return sb.ToString()
    End Function
End Class
