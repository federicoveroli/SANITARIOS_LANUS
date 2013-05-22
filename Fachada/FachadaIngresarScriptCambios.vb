Imports Datos

Public Class FachadaIngresarScriptCambios
    Public Sub IngresarScriptCambios(ByVal ScriptCambios As String)
        AccesoDatos.Instancia.EjecutarConsulta(ScriptCambios)
    End Sub
End Class
