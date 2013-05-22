Imports Modelo
Imports Datos
Imports System.Windows.Forms

Public Class FachadaDomicilio
    Public Sub CargarGrilla(ByVal objEnte As Ente, ByVal grilla As DataGridView)

        Dim colDomicilios As New List(Of Domicilio)
        Dim regDomicilio As New RegistroDomicilio
        colDomicilios = regDomicilio.colDomiciliosEnte(objEnte.IdEnte)


        For Each objDomicilio As Domicilio In colDomicilios
            objEnte.AddDomicilio(objDomicilio)
            CargarDomicilioEnGrilla(objDomicilio, grilla)
        Next

    End Sub
    Public Function TraerLocalidades() As DataTable
        Dim regDomicilio As New RegistroDomicilio
        Return regDomicilio.traerLocalidades
    End Function
    Public Function TraerPartidos() As DataTable
        Dim regDomicilio As New RegistroDomicilio
        Return regDomicilio.traerPartidos
    End Function
    Public Sub GenerarColumnasGrilla(ByVal grilla As DataGridView)
        grilla.Columns.Clear()
        grilla.Columns.Add("calle", "Calle")
        grilla.Columns.Add("altura", "Altura")
        grilla.Columns.Add("piso", "Piso")
        grilla.Columns.Add("depto", "Depto.")
        grilla.Columns.Add("localidad", "Localidad")
        grilla.Columns.Add("partido", "Partido")
        grilla.Columns.Add("codigoPostal", "Codigo Postal")
    End Sub
    Public Sub CargarDomicilioEnGrilla(ByVal objDomicilio As Domicilio, ByVal grilla As DataGridView)

   
        grilla.Rows.Add(objDomicilio.Calle, objDomicilio.Altura, objDomicilio.Piso, objDomicilio.Depto, objDomicilio.Localidad, objDomicilio.Partido, objDomicilio.CodigoPostal)
        grilla.Rows(grilla.NewRowIndex).Tag = objDomicilio
        grilla.AutoResizeColumns()
        grilla.AutoResizeRows()
    End Sub

    Public Function colDomiciliosEnte(ByVal idEnte As Integer) As List(Of Domicilio)
        Dim regDomicilio As New RegistroDomicilio
        'If regDomicilio.descipcionDisponible(apDomicilio.descripcion) = True Then
        Return regDomicilio.colDomiciliosEnte(idEnte)
    End Function
    Public Sub altaDomicilio(ByVal apDomicilio As Domicilio)
        Dim regDomicilio As New RegistroDomicilio
        'If regDomicilio.descipcionDisponible(apDomicilio.descripcion) = True Then
        regDomicilio.altaDomicilio(apDomicilio)
        'Else
        'Throw New DomicilioNoDisponibleException  'lanzo mi excepcion
        'End If

    End Sub
    Public Sub modificarDomicilio(ByVal mpDomicilio As Domicilio, ByVal mpDescripcionAnterior As String)
        Dim regDomicilio As New RegistroDomicilio
        'If mpDescripcionAnterior <> mpDomicilio.descripcion Then
        '    'si cambia el nick verifico la disponibilidad del nuevo
        '    If regDomicilio.descipcionDisponible(mpDomicilio.descripcion) = False Then Throw New DomicilioNoDisponibleException()
        'End If
        regDomicilio.modificarDomicilio(mpDomicilio)
    End Sub
    Public Sub eliminarDomicilio(ByVal mpDomicilio As Domicilio)
        Dim regDomicilio As New RegistroDomicilio
        regDomicilio.eliminarDomicilio(mpDomicilio)
    End Sub
End Class
