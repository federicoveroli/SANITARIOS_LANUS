Imports Modelo
Imports LibPrintTicket
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6


Public Class Impresora
    Public Shared Sub imprimir(ByVal vta As Comprobante)

        'Ticket ticket = new Ticket();

        '    ticket.AddHeaderLine("ChafiTienda");
        '    ticket.AddHeaderLine("EXPEDIDO EN:");
        '    ticket.AddHeaderLine("CALLE CONOCIDA");
        '    ticket.AddHeaderLine("PUEBLA, PUEBLA");
        '    ticket.AddHeaderLine("RFC: CSI-020226-MV4");

        '    ticket.AddSubHeaderLine("Ticket # 1");
        '    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

        '    ticket.AddItem("Cantidad", "Nombre producto", "Total");

        '    ticket.AddTotal("SUBTOTAL", "12.00");
        '    ticket.AddTotal("IVA", "0");
        '    ticket.AddTotal("TOTAL", "24");
        '    ticket.AddTotal("", "");
        '    ticket.AddTotal("RECIBIDO", "0");
        '    ticket.AddTotal("CAMBIO", "0");
        '    ticket.AddTotal("", "");

        '    ticket.AddFooterLine("VUELVA PRONTO");

        ''    ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
        'Dim ticket As New Ticket
        'ticket.MaxChar = 30
        'ticket.AddHeaderLine("PERFUMERIAS LITI")
        'ticket.AddHeaderLine("siempre más barato...")
        'ticket.AddHeaderLine(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString())
        'ticket.AddSubHeaderLine(".: sistema saturn :.")



        'For Each r As RenglonComprobante In vta.Renglones
        '    If r.Descripcion.Length > 18 Then
        '        r.Descripcion = r.Descripcion.Substring(0, 18)
        '    End If
        '    ticket.AddItem(FixAnchor(r.Cantidad.ToString(), 2), FixAnchor(r.Descripcion, 18), FixAnchor(Math.Round(r.SubTotal, 2).ToString(), 4))
        'Next
        'If TypeOf vta Is Venta Then
        '    ticket.AddTotal("DESCUENTO", Math.Round(CType(vta, Venta).Descuento, 2))
        'End If

        'ticket.AddTotal("TOTAL", Math.Round(vta.Total, 2))
        'ticket.AddTotal("", "")
        ''ticket.AddTotal("RECIBIDO", "0")
        ''ticket.AddTotal("CAMBIO", "0")
        ''ticket.AddTotal("", "")

        'ticket.AddFooterLine("Ticket no válido como factura")
        'ticket.AddFooterLine("Gracias por su compra!")

        'ticket.PrintTicket("IMPRESORA_PREDETERMINADA") ' //Nombre de la impresora de tickets

    End Sub

    Public Shared Sub imprimirTicket(ByVal vta As Comprobante)
        'Dim imp As New Printer
        'Dim ft As New Fachada.FachadaInfoTicket
        'Dim infoT As InfoTicket
        'Dim fuente As New Font("Courier New", 12)
        'imp.Font = fuente
        'imp.DrawStyle = 2
        'imp.PrintQuality = vbPRPQDraft
        'infoT = ft.TraerInfoTicket()
        'If infoT.Encabezado1.Length > 0 Then imp.Print(infoT.Encabezado1)
        'If infoT.Encabezado2.Length > 0 Then imp.Print(infoT.Encabezado2)
        'If infoT.Encabezado3.Length > 0 Then imp.Print(infoT.Encabezado3)
        'If infoT.Encabezado4.Length > 0 Then imp.Print(infoT.Encabezado4)
        'If infoT.Encabezado5.Length > 0 Then imp.Print(infoT.Encabezado5)
        ''imp.Print("PERFUMERIAS LITI")
        ''imp.Print("siempre más barato...")
        'imp.Print(DateTime.Now.ToShortDateString() & "  " & DateTime.Now.ToShortTimeString())
        'imp.Print(".: sistema saturn :.")
        'imp.Print("================================")

        'imp.Print("CANT  DESCRIPCION            IMP")
        'imp.Print("--------------------------------")

        'For Each r As RenglonComprobante In vta.Renglones
        '    imp.Print(FixAnchor(r.Cantidad, 2) & "    " & FixAnchor(r.Descripcion.Substring(0, 16), 16) & FixAnchor(Math.Round(r.SubTotal, 2), 10))
        'Next
        'imp.Print("================================")
        ''imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(Math.Round(vta.Total, 2), 12))
        'Dim v As Venta
        'v = CType(vta, Venta)
        'If v.Descuento > 0 Then
        '    imp.Print(FixAnchor("DESCUENTO", 20) & FixAnchor(FormatCurrency(v.Descuento, 2, , , TriState.True), 8))
        'End If
        'If v.Total < 0 Then
        '    imp.Print(FixAnchor("CREDITO", 20) & FixAnchor(FormatCurrency(v.Total * -1, 2, , , TriState.True), 12))
        'End If
        'imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(FormatCurrency(vta.Total, 2, , , TriState.True), 12))
        'If infoT.Pie1.Length > 0 Then imp.Print(infoT.Pie1)
        'If infoT.Pie2.Length > 0 Then imp.Print(infoT.Pie2)
        'If infoT.Pie3.Length > 0 Then imp.Print(infoT.Pie3)
        'If infoT.Pie4.Length > 0 Then imp.Print(infoT.Pie4)
        'If infoT.Pie5.Length > 0 Then imp.Print(infoT.Pie5)
        'imp.Print("")
        'imp.Print(".")
        'imp.Print(".")
        'imp.Print(".")
        'imp.Print(".")
        'imp.Print(".")
        'imp.Print(".")
        ''imp.Print(Chr(26) + Chr(27) + "J" + Chr(250) + Chr(29) + "V" + Chr(1))
        ''imp.Print(Chr(27) + Chr(64) + Chr(27) + Chr(105))
        ''imp.Print(Chr(27) + Chr(64))
        ''imp.Print("Ticket no válido como factura")
        ''imp.Print("Gracias por su compra!")
        ''public void CortaTicket()
        ''{
        ''string corte = "\x1B" + "m"; // caracteres de corte
        ''string avance = "\x1B" + "d" + "\x09"; // avanza 9 renglones
        ''RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
        ''RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
        ''}


        'imp.EndDoc()

    End Sub

    Private Shared Function FixAnchor(ByVal obj As Object, ByVal len As Integer) As String

        Dim result As String, i As Integer
        result = ""
        For i = obj.ToString.Length To len - 1
            result = " " + result
        Next

        If IsNumeric(obj) Then
            result = result + obj.ToString()
            
        Else
            result = obj + result
        End If

        Return result

    End Function

    'Private Function AddZeros(ByVal valor As Object) As String
    '    Dim moneda As String
    '    moneda = Format(valor, "###,##")
    'End Function

    Public Shared Sub imprimirTicketMovimiento(ByVal vta As Comprobante)
        Dim imp As New Printer
        Dim ft As New Fachada.FachadaInfoTicket
        Dim infoT As InfoTicket
        Dim fuente As New Font("Courier New", 12)
        imp.Font = fuente
        imp.DrawStyle = 2
        imp.PrintQuality = vbPRPQDraft
        infoT = ft.TraerInfoTicket()
        If infoT.Encabezado1.Length > 0 Then imp.Print(infoT.Encabezado1)
        If infoT.Encabezado2.Length > 0 Then imp.Print(infoT.Encabezado2)
        If infoT.Encabezado3.Length > 0 Then imp.Print(infoT.Encabezado3)
        If infoT.Encabezado4.Length > 0 Then imp.Print(infoT.Encabezado4)
        If infoT.Encabezado5.Length > 0 Then imp.Print(infoT.Encabezado5)
        'imp.Print("PERFUMERIAS LITI")
        'imp.Print("siempre más barato...")
        imp.Print(DateTime.Now.ToShortDateString() & "  " & DateTime.Now.ToShortTimeString())
        imp.Print(".: sistema saturn :.")
        imp.Print("================================")

        imp.Print("CANT  DESCRIPCION            IMP")
        imp.Print("--------------------------------")

        For Each r As RenglonComprobante In vta.Renglones
            imp.Print(FixAnchor(r.Cantidad, 2) & "    " & FixAnchor(r.Descripcion.Substring(0, 16), 16) & FixAnchor(Math.Round(r.SubTotal, 2), 10))
        Next
        imp.Print("================================")
        'imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(Math.Round(vta.Total, 2), 12))
        Dim v As Venta
        v = CType(vta, Venta)
        If v.Descuento > 0 Then
            imp.Print(FixAnchor("DESCUENTO", 20) & FixAnchor(FormatCurrency(v.Descuento, 2, , , TriState.True), 8))
        End If
        imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(FormatCurrency(vta.Total, 2, , , TriState.True), 12))
        imp.Print(FixAnchor("** CODIGO ACK **  ", 18) & CType(vta, Venta).CalcularCodigoMovimiento)
        If infoT.Pie1.Length > 0 Then imp.Print(infoT.Pie1)
        If infoT.Pie2.Length > 0 Then imp.Print(infoT.Pie2)
        If infoT.Pie3.Length > 0 Then imp.Print(infoT.Pie3)
        If infoT.Pie4.Length > 0 Then imp.Print(infoT.Pie4)
        If infoT.Pie5.Length > 0 Then imp.Print(infoT.Pie5)
        imp.Print("")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(Chr(26) + Chr(27) + "J" + Chr(250) + Chr(29) + "V" + Chr(1))
        imp.Print(Chr(27) + Chr(64) + Chr(27) + Chr(105))
        imp.Print(Chr(27) + Chr(64))
        'imp.Print("Ticket no válido como factura")
        'imp.Print("Gracias por su compra!")
        'public void CortaTicket()
        '{
        'string corte = "\x1B" + "m"; // caracteres de corte
        'string avance = "\x1B" + "d" + "\x09"; // avanza 9 renglones
        'RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
        'RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
        '}


        imp.EndDoc()

    End Sub


    Public Shared Sub imprimirTicketRecepcion(ByVal vta As Comprobante)
        Dim imp As New Printer
        Dim ft As New Fachada.FachadaInfoTicket
        Dim infoT As InfoTicket
        Dim fuente As New Font("Courier New", 12)
        imp.Font = fuente
        imp.DrawStyle = 2
        imp.PrintQuality = vbPRPQDraft
        infoT = ft.TraerInfoTicket()
        If infoT.Encabezado1.Length > 0 Then imp.Print(infoT.Encabezado1)
        If infoT.Encabezado2.Length > 0 Then imp.Print(infoT.Encabezado2)
        If infoT.Encabezado3.Length > 0 Then imp.Print(infoT.Encabezado3)
        If infoT.Encabezado4.Length > 0 Then imp.Print(infoT.Encabezado4)
        If infoT.Encabezado5.Length > 0 Then imp.Print(infoT.Encabezado5)
        'imp.Print("PERFUMERIAS LITI")
        'imp.Print("siempre más barato...")
        imp.Print(DateTime.Now.ToShortDateString() & "  " & DateTime.Now.ToShortTimeString())
        imp.Print(".: sistema saturn :.")
        imp.Print("================================")

        imp.Print("CANT  DESCRIPCION            IMP")
        imp.Print("--------------------------------")

        For Each r As RenglonComprobante In vta.Renglones
            imp.Print(FixAnchor(r.Cantidad, 2) & "    " & FixAnchor(r.Descripcion.Substring(0, 16), 16) & FixAnchor(Math.Round(r.SubTotal, 2), 10))
        Next
        imp.Print("================================")
        'imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(Math.Round(vta.Total, 2), 12))
        Dim v As Venta
        v = CType(vta, Venta)
        If v.Descuento > 0 Then
            imp.Print(FixAnchor("DESCUENTO", 20) & FixAnchor(FormatCurrency(v.Descuento, 2, , , TriState.True), 8))
        End If
        imp.Print(FixAnchor("TOTAL", 20) & FixAnchor(FormatCurrency(vta.Total, 2, , , TriState.True), 12))
        imp.Print(FixAnchor("** CODIGO ACK **  ", 18) & CType(vta, Venta).CalcularCodigoRecepcion)
        If infoT.Pie1.Length > 0 Then imp.Print(infoT.Pie1)
        If infoT.Pie2.Length > 0 Then imp.Print(infoT.Pie2)
        If infoT.Pie3.Length > 0 Then imp.Print(infoT.Pie3)
        If infoT.Pie4.Length > 0 Then imp.Print(infoT.Pie4)
        If infoT.Pie5.Length > 0 Then imp.Print(infoT.Pie5)
        imp.Print("")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(".")
        imp.Print(Chr(26) + Chr(27) + "J" + Chr(250) + Chr(29) + "V" + Chr(1))
        imp.Print(Chr(27) + Chr(64) + Chr(27) + Chr(105))
        imp.Print(Chr(27) + Chr(64))
        'imp.Print("Ticket no válido como factura")
        'imp.Print("Gracias por su compra!")
        'public void CortaTicket()
        '{
        'string corte = "\x1B" + "m"; // caracteres de corte
        'string avance = "\x1B" + "d" + "\x09"; // avanza 9 renglones
        'RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
        'RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
        '}


        imp.EndDoc()

    End Sub

End Class
