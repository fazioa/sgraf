Imports System.Runtime.InteropServices
'Classe che definisce le azioni da effettuare in seguito ad un comando dato da uno dei form

Imports SGraf
Imports System.Security.AccessControl
Imports System.Xml.Serialization
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Office.Interop.Word




Class XOrseLog
    '  Public Shared LogForm As New FXOrseLog
    Public Sub New()

    End Sub

    Public Sub hide()
        ' LogForm.Hide()
    End Sub
    Public Sub show()
        '   LogForm.Show()
    End Sub

    Public Sub xlogWriteEntry(ByVal sMsg As String, ByVal livello As System.Diagnostics.TraceEventType)
#If DEBUG Then
        Dim sMessaggio As String = Now.ToLocalTime + " " + sMsg
        Try
            My.Application.Log.WriteEntry(sMessaggio, livello)
        Catch ex As Exception

        End Try
        '  LogForm.add(sMessaggio)
#End If
    End Sub
    Public Sub xlogWriteException(ByVal ex As Exception, ByVal livello As System.Diagnostics.TraceEventType, ByVal addInfo As String)
#If DEBUG Then
        Dim sMessaggio As String = "Gestione errore: " & addInfo & " - livello: " & livello.ToString & " - messaggio sistema: " & ex.ToString
        Try
            My.Application.Log.WriteException(ex, livello, addInfo)
        Catch exc As Exception

        End Try

        ' LogForm.add(sMessaggio)
#End If
    End Sub
End Class


Public Class ActionsLibrary



    Dim log As New XOrseLog
    'indica lo stato dell'applicazione. In caso di cancellazione del DB indica all'applicaizone di uscire dall'ordine di servizio corrente
    Public appStateLogin As Boolean = True


    Public Sub New()

    End Sub
    'restituisce una stringa costituita da anno mese giorno ora minuti secondi
    Public Shared Function getTimeStamp() As String
        Dim d As Date = DateTime.Now
        getTimeStamp = d.Year & Format(d.Month, "d2") & Format(d.Day, "d2") & Format(d.Hour, "d2") & Format(d.Minute, "d2") & Format(d.Second, "d2")
    End Function

    Public Sub wordScriviSegnalibro(ByVal oWord As Microsoft.Office.Interop.Word.Application, ByVal nome As String, ByVal valore As String, ByVal dPtCarattere As Double)
        If Not oWord Is Nothing Then
            With oWord
                .Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:=nome)
                log.xlogWriteEntry("Word - scrive su segnalibro """ & nome & """:" & valore, TraceEventType.Critical)
                oWord.ActiveWindow.Selection.Font.Size = dPtCarattere
                .Selection.TypeText(Text:=valore)
            End With
        Else
            log.xlogWriteEntry("Word - oggetto oWord vuoto", TraceEventType.Critical)
        End If
    End Sub

    Public Sub wordScrivi(ByVal oWord As Microsoft.Office.Interop.Word.Application, ByVal valore As String, ByVal dPtCarattere As Double)
        oWord.ActiveWindow.Selection.Font.Size = dPtCarattere
        oWord.Selection.TypeText(Text:=valore)
    End Sub

    Public Sub wordScriviEnter(ByVal oWord As Microsoft.Office.Interop.Word.Application)
        log.xlogWriteEntry("Word - scrive ENTER", TraceEventType.Critical)
        oWord.Selection.TypeParagraph()
    End Sub

    Private Function wordInizializzaDocumento()
        Try
            log.xlogWriteEntry("Word - Inizializza verbale ", TraceEventType.Critical)

            Dim oWord As Microsoft.Office.Interop.Word.Application = CreateObject("Word.Application")
            '  Dim oDoc As Microsoft.Office.Interop.Word.Application
            Dim strDocumentName As String = ""
            oWord.Visible = True

            Dim sPath As String = AppDomain.CurrentDomain.BaseDirectory & "\modello\"

            ' strDocumentName = "verbaleSopralluogo.doc"
            Try
                'If Dir(sPath & strDocumentName) = "" Then
                'Dim n As String = sPath & strDocumentName
                'log.xlogWriteEntry("Word - Utilizza modello .dot - Scrive file word" & n, TraceEventType.Critical)

                'oWord.Documents.Add(sPath & "verbaleSopralluogo.dot").SaveAs(FileName:=n)

                'Else
                'Se il file esiste allora fare qualcosa, magari aprire la maschera per la scelta del percorso
                'oWord.Documents.Add(sPath & "op85.dot").SaveAs(FileName:=sPath & strDocumentName)

                oWord.Documents.Add(sPath & "fascicolo fotografico.dot")
                oWord.Caption = "Fascicolo fotografico"


                '    End If
            Catch ex As Exception
                log.xlogWriteEntry("Word - Errore:" & ex.Message, TraceEventType.Critical)
            End Try

            ' oDoc = Nothing
            Return oWord
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Word - Inizializza documento - Errore")
            Return Nothing
        End Try


    End Function


    Public Sub wordInizializzaEcompila(controlCollection As System.Windows.Forms.Control.ControlCollection)
        Try
            Dim oWord As Microsoft.Office.Interop.Word.Application = wordInizializzaDocumento()
            oWord.Visible = False
            wordScriviSegnalibro(oWord, "intestazione1", My.Settings.intestazione1, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "intestazione2", My.Settings.intestazione2, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "intestazione3", My.Settings.intestazione3, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "oggetto", My.Settings.oggetto, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "contenutoDettaglio", My.Settings.contenutoDettaglio, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "autore", My.Settings.autore, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "luogoData", My.Settings.luogo, My.Settings.carattereDimensioneBase)
            wordScrivi(oWord, ", " & Date.Now().ToShortDateString, My.Settings.carattereDimensioneBase)
            wordScriviSegnalibro(oWord, "gradoCognomeNome", My.Settings.gradoCognomeNome, My.Settings.carattereDimensioneBase)

            'posiziona il cursone sul punto di inizio
            '   wordScriviSegnalibro(oWord, "nuovaPagina", "", My.Settings.carattereDimensioneBase)

            wordscriviPagineFoto(oWord, controlCollection)
       

        ' wordAttivaDocumento(oWord)
        oWord.Visible = True
        oWord.Activate()
            oWord = Nothing
        Catch ex As COMException
            MsgBox("La copia Microsoft Office potrebbe non essere registrato ed attiva", MsgBoxStyle.Critical, "Errore")
        End Try

    End Sub

    Public Sub wordAttivaDocumento(ByVal oWord As Microsoft.Office.Interop.Word.Application)
        log.xlogWriteEntry("Word - attiva documento", TraceEventType.Critical)
        'oWord.ActiveDocument.PrintPreview()
        'oWord.ActiveDocument.Saved = False
        oWord.Activate()
        oWord = Nothing
    End Sub

    Shared Function troncaStringa(ByVal s As String, ByVal l As Integer) As String
        If (s.Length > l) Then
            Return s.Substring(0, l) & "..."
        End If
        Return s
    End Function

    Public Sub wordscriviPagineFoto(oWord As Microsoft.Office.Interop.Word.Application, controlCollection As System.Windows.Forms.Control.ControlCollection)
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oDoc As Microsoft.Office.Interop.Word.Document = oWord.ActiveDocument
        Dim oRng As Microsoft.Office.Interop.Word.Range

        If My.Settings.disposizioneColonne = 0 Then My.Settings.disposizioneColonne = 1
        If My.Settings.disposizioneRighe = 0 Then My.Settings.disposizioneRighe = 1

        'immagine
        Dim myShape As InlineShape
        Dim inrColonne = My.Settings.disposizioneColonne

        If (My.Settings.disposizioneColonne > 1 Or My.Settings.disposizioneRighe > 1) Then

            'CREAZIONE E RIEMPIMENTO TABELLA
            'posiziono il puntatore a fine documento
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            'inserisco un'interruzione di pagina
            oRng.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak)
            'posiziono il puntatore a fine documento
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            'vado a fine documento
            oWord.Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:="\endofdoc")
            'centra
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter

            'crea tabella
            oTable = inserisciTabella(oDoc, oWord)
            Dim iCountCella, iRig, iCol As Integer
            iRig = 1
            iCol = 1
            iCountCella = 0
            For Each element As userControlImg In controlCollection
                If iCountCella < My.Settings.disposizioneRighe * My.Settings.disposizioneColonne Then
                    inserisciImmagineInCella(oTable, element, iRig, iCol)
                    'oTable.Cell(iRig, iCol).Range.Text = iRig & " - " & iCol & ", " & element.LabelNumeroFoto.Text
                    iCountCella = iCountCella + 1
                    iCol = iCol + 1
                    If iCountCella Mod inrColonne = 0 Then
                        'se il modulo del contatore è 0 vuol dire che stiamo oltrepassando l'ultima colonna, allora incremento la riga e pongo la colonna a 1 (la prima)
                        iRig = iRig + 1
                        iCol = 1
                    End If
                Else
                    'posiziono il puntatore a fine documento
                    oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                    'inserisco un'interruzione di pagina
                    oRng.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak)
                    'posiziono il puntatore a fine documento
                    oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                    'vado a fine documento
                    oWord.Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:="\endofdoc")
                    'centra
                    oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                    'crea tabella
                    oTable = inserisciTabella(oDoc, oWord)

                    'visto che in questo ciclo l'element è già stato estratto dalla lista, allora devo gestirlo, così lo inserisco nella prima cella, e faccio partire l'indice colonna e count da 2

                    myShape = inserisciImmagineInCella(oTable, element, 1, 1)

                    iCol = 2
                    iRig = 1
                    iCountCella = 1
                    If iCountCella Mod inrColonne = 0 Then
                        'se il modulo del contatore è 0 vuol dire che stiamo oltrepassando l'ultima colonna, allora incremento la riga e pongo la colonna a 1 (la prima)
                        iCol = 1
                        iRig = iRig + 1
                    End If
                End If
            Next
        Else
            'INSERISCE FOTO IMPILANDOLE, SENZA TABELLA
            For Each element As userControlImg In controlCollection
                'posiziono il puntatore a fine documento
                oRng = oDoc.Bookmarks.Item("\endofdoc").Range

                'inserisco un'interruzione di pagina
                oRng.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak)

                'posiziono il puntatore a fine documento
                oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                'vado a fine documento
                oWord.Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:="\endofdoc")

                'centra
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter

                wordScrivi(oWord, My.Settings.titoloFoto & element.LabelNumeroFoto.Text, My.Settings.carattereDimensioneTitoloFoto)

                'inserisci un ritorno a capo
                wordScriviEnter(oWord)
                wordScriviEnter(oWord)
                'posiziono il puntatore a fine documento
                oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                'INCORPORA IMMAGINE

                myShape = inserisciImmagine(oWord, element)
                scalaImmagine(myShape, element, My.Settings.fotoLarghezzaCM, My.Settings.fotoAltezzaCM)

                'solo se il fascicolo è descrittivo
                If My.Settings.tipoFascicolo = "Descrittivo" Then
                    'DESCRIZIONE
                    ' wordScriviEnter(oDoc.Application)
                    wordScrivi(oDoc.Application, element.TextBoxTag.Text, My.Settings.carattereDimensioneDidascalia)
                End If
            Next
        End If

        'se si tratta di un fascicolo per l'identificazione aggiungo la legenda all'ultima pagina
        If My.Settings.tipoFascicolo = "Identificazione" Then

            'posiziono il puntatore a fine documento
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            'inserisco un'INTERRUZIONE di pagina
            oRng.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak)
            'posiziono il puntatore a fine documento
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            'vado a fine documento
            oWord.Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:="\endofdoc")

            wordScrivi(oDoc.Application, "Legenda", My.Settings.carattereDimensioneTitoloFoto)
            wordScriviEnter(oDoc.Application)
            'centra
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
            For Each element As userControlImg In controlCollection
                'DESCRIZIONE
                wordScriviEnter(oDoc.Application)
                wordScrivi(oDoc.Application, My.Settings.titoloFoto & " " & element.LabelNumeroFoto.Text & ": " & element.TextBoxTag.Text, My.Settings.carattereDimensioneDidascalia)

            Next
        End If
    End Sub

    Private Function inserisciTabella(oDoc As Microsoft.Office.Interop.Word.Document, oWord As Microsoft.Office.Interop.Word.Application)
        Return oDoc.Tables.Add(oWord.Selection.Range, My.Settings.disposizioneRighe, My.Settings.disposizioneColonne)
    End Function

    Private Function inserisciImmagine(oWord As Application, element As userControlImg) As InlineShape
        Return oWord.Selection.InlineShapes.AddPicture(element.sNomeFile, My.Settings.bIncorporaImmagini)
    End Function

    Dim sEXIF As String = ""
    Dim bFlag As Boolean = False
    Dim sNomeFile As String = ""
    Private Function inserisciImmagineInCella(oTable As Table, element As userControlImg, iRig As Integer, iCol As Integer) As InlineShape
        oTable.Cell(iRig, iCol).Range.Text = iRig & " - " & iCol & ", " & element.LabelNumeroFoto.Text
        Dim Shad As Shading
        Shad = oTable.Cell(iRig, iCol).Shading
        oTable.Cell(iRig, iCol).Select()

        'TITOLO
        wordScrivi(oTable.Application, My.Settings.titoloFoto & " " & element.LabelNumeroFoto.Text, My.Settings.carattereDimensioneTitoloFoto)
        wordScriviEnter(oTable.Application)
        Dim _shape As InlineShape = oTable.Application.Selection.InlineShapes.AddPicture(element.sNomeFile, My.Settings.bIncorporaImmagini)
        scalaImmagine(_shape, element, My.Settings.fotoLarghezzaCM, My.Settings.fotoAltezzaCM)

        'solo se il fascicolo è descrittivo
        If My.Settings.tipoFascicolo = "Descrittivo" Then
            'DESCRIZIONE
            wordScriviEnter(oTable.Application)
            wordScrivi(oTable.Application, element.TextBoxTag.Text, My.Settings.carattereDimensioneDidascalia)
            sEXIF = ""
            bFlag = False
            If My.Settings.bEXIFMarca Then
                sEXIF += Trim(element.marca)
                bFlag = True
            End If
            If My.Settings.bEXIFModello Then
                If sEXIF <> "" And element.modello IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.modello)
                bFlag = True
            End If
            If My.Settings.bEXIFDataOra Then
                If sEXIF <> "" And element.dataScatto IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.dataScatto)
                bFlag = True
            End If
            If My.Settings.bEXIFEsposizione Then
                If sEXIF <> "" And element.esposizione IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.esposizione)
                bFlag = True
            End If
            If My.Settings.bEXIFDiaframma Then
                If sEXIF <> "" And element.diaframma IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.diaframma)
                bFlag = True
            End If
            If My.Settings.bEXIFISO Then
                If sEXIF <> "" And element.ISO IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.ISO)
                bFlag = True
            End If
            If My.Settings.bEXIFFlash Then
                If sEXIF <> "" And element.flash IsNot Nothing Then sEXIF += ", "
                sEXIF += Trim(element.flash)
                bFlag = True
            End If

            sNomeFile = Path.GetFileName(element.sNomeFile)

            If (My.Settings.bNomeFile) Then
                wordScriviEnter(oTable.Application)
                wordScrivi(oTable.Application, sNomeFile, My.Settings.carattereDimensioneDidascalia)
            End If
            If bFlag = True Then
                wordScriviEnter(oTable.Application)
                wordScrivi(oTable.Application, sEXIF, My.Settings.carattereDimensioneDidascalia)
            End If
        End If

        wordScriviEnter(oTable.Application)
        Return _shape
    End Function

    Private Sub scalaImmagine(myShape As InlineShape, element As userControlImg, larghezzaCM As Single, altezzaCM As Single)
        Dim dRapporto As Double = element.imageTmbWidth / element.imagTmbHeight
        Dim _alt, _larg As Double

        '       If dRapporto < 1 Then
        If (myShape.Application.PointsToCentimeters(element.PictureBox1.Image.Width) > larghezzaCM) Then
            myShape.Width = myShape.Application.CentimetersToPoints(larghezzaCM)
            _alt = larghezzaCM / dRapporto
            myShape.Height = myShape.Application.CentimetersToPoints(_alt)
        End If

        If (myShape.Application.PointsToCentimeters(myShape.Height) > altezzaCM) Then
            myShape.Height = myShape.Application.CentimetersToPoints(altezzaCM)
            _larg = altezzaCM * dRapporto
            myShape.Width = myShape.Application.CentimetersToPoints(_larg)
        End If
    End Sub
End Class



