Public Class Validar
    Public Shared Function EsNumero(ByVal Avalidar As String) As Boolean 'Function porque quiero que devuelva un booleano
        If IsNumeric(Avalidar) Or Asc(Avalidar) = 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function EsLetra(ByVal avalidar As String) As Boolean
        If (Not IsNumeric(avalidar) Or Asc(avalidar) = 8 Or Asc(avalidar) = 32) And Asc(avalidar) <> 39 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function EsFlotante(ByRef Avalidar As String) As Boolean 'Function porque quiero que devuelva un booleano


        If IsNumeric(Avalidar) Or Asc(Avalidar) = 8 Or Asc(Avalidar) = 44 Or Asc(Avalidar) = 46 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
