Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Dim log As New XOrseLog
    Private Sub PopolaImmagini(arrayFileNames As String())
        '   lvwImmagini.Items.Clear()
        Dim i As Integer = 0
        Dim dir As DirectoryInfo = New DirectoryInfo("E:\Nuova cartella\tt")
        Dim sFile As String
        Dim log As New XOrseLog

        ' lvwImmagini.LargeImageList = imageList
        For Each sFile In arrayFileNames
            'ImageList.Images.Add(Bitmap.FromFile(file.FullName))
            Try
                Dim imageItem As New userControlImg(Bitmap.FromFile(sFile), sFile, My.Settings.fotoLarghezzaTumb, My.Settings.fotoAltezzaTumb)
                FlowLayoutPanel1.Controls.Add(imageItem)
            Catch ex As Exception
                log.xlogWriteEntry("Inserimento immagine fallito - " & ex.Message, TraceEventType.Critical)
            End Try
            i = i + 1
        Next
        For Each child As userControlImg In Me.FlowLayoutPanel1.Controls
            RemoveHandler child.PictureBox1.MouseDown, AddressOf childs_MouseDown
            AddHandler child.PictureBox1.MouseDown, AddressOf childs_MouseDown
            child.LabelNumeroFoto.Text = FlowLayoutPanel1.Controls.GetChildIndex(child) + 1
        Next
    End Sub

    Private Sub FlowLayoutPanel1_GiveFeedback(sender As System.Object, e As System.Windows.Forms.GiveFeedbackEventArgs) Handles FlowLayoutPanel1.GiveFeedback

        ' Set the custom cursor based upon the effect.
        ' e.UseDefaultCursors = False
        '  If ((e.Effect And DragDropEffects.Move) = DragDropEffects.Move) Then
        '  Cursor.Current = Me.dragcursor
        '   End If


    End Sub


    Dim dragcursor As Cursor
    Dim dragtype As Type
    Dim X As Integer = 0
    Dim Y As Integer = 0
    Dim xyMetrics As Integer = 30

    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub childs_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'occorre distinguere tra drag&drop e click
        Dim source As userControlImg = CType(sender.parent, userControlImg)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.dragtype = source.GetType
            Me.DoDragDrop(source, DragDropEffects.Move)
        Else

        End If
    End Sub


    Private Sub FlowLayoutPanel1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FlowLayoutPanel1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'AGGIUNGE IMMAGINE
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            log.xlogWriteEntry("Popola immagini", TraceEventType.Information)
            PopolaImmagini(filePaths)
        Else
            Dim source As userControlImg = CType(e.Data.GetData(dragtype), userControlImg)
            Dim target As userControlImg = Me.FlowLayoutPanel1.GetChildAtPoint(Me.FlowLayoutPanel1.PointToClient(New Point(e.X, e.Y)))

            'se l'index del source è uguale all'index del target allora si tratta di un click e non di un drag&drop
            If (Me.FlowLayoutPanel1.Controls.GetChildIndex(target) <> Me.FlowLayoutPanel1.Controls.GetChildIndex(source)) Then
                log.xlogWriteEntry("Drag start", TraceEventType.Information)

                'MUOVE IMMAGINE
                If target IsNot Nothing Then
                    Dim ix As Integer = Me.FlowLayoutPanel1.Controls.GetChildIndex(target)
                    Me.FlowLayoutPanel1.Controls.SetChildIndex(source, ix)
                    renumber()
                    log.xlogWriteEntry("Drop - target index " & ix, TraceEventType.Information)
                End If
            Else
                'Si tratta di un click
                source.selected = Not source.selected
                ' Me.Refresh()
            End If
        End If
    End Sub

    Private Sub FlowLayoutPanel1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FlowLayoutPanel1.DragEnter
        ' Non capisco perchè al click entri diverse volte qui dentro

        If e.AllowedEffect = DragDropEffects.Move AndAlso e.Data.GetDataPresent(dragtype) Then
            e.Effect = DragDropEffects.Move
            log.xlogWriteEntry("Drag Enter - Move", TraceEventType.Information)
        ElseIf e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            log.xlogWriteEntry("Drag Enter - FileDrop", TraceEventType.Information)
        Else
            e.Effect = DragDropEffects.None
            log.xlogWriteEntry("Drag Enter - DragDropEffects None", TraceEventType.Information)
        End If
    End Sub

    Private Sub renumber()
        For Each child As userControlImg In Me.FlowLayoutPanel1.Controls
            child.LabelNumeroFoto.Text = FlowLayoutPanel1.Controls.GetChildIndex(child) + 1
        Next
    End Sub
    Private Sub clearSelected()
        For Each child As userControlImg In Me.FlowLayoutPanel1.Controls
            child.selected = False
        Next
    End Sub

    Private Sub ApriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApriToolStripMenuItem.Click
        Dim result = OpenFileDialog1.ShowDialog()
        PopolaImmagini(OpenFileDialog1.FileNames)
    End Sub

    Private Sub SvuotaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SvuotaToolStripMenuItem.Click
        FlowLayoutPanel1.Controls.Clear()
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        Dim form As New FPreferenze
        form.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'My.Settings.newVersion is set to True in the IDE
        If My.Settings.newVersion Then
            'new version 
            My.Settings.Upgrade()
            'yes, reload previous settings 
            My.Settings.newVersion = False
            'set new version to false
            My.Settings.Save() 'save the settings
        End If
    End Sub

    Private Sub ResetMySettings()
        'called when/if the settings need to be reset
        My.Settings.Reset() 'reset the settings
        My.Settings.newVersion = False 'set new version to false
        My.Settings.Save() 'save the settingsEndSub
    End Sub

    Private Sub GeneraFascicoloFotograficoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GeneraFascicoloFotograficoToolStripMenuItem.Click
        Dim feActions As New ActionsLibrary
        Dim t As New System.Threading.Thread(AddressOf feActions.wordInizializzaEcompila)

        t.SetApartmentState(System.Threading.ApartmentState.STA)
        t.Start(FlowLayoutPanel1.Controls)

        '  Dim feActions As New ActionsLibrary
        '  feActions.wordInizializzaEcompila(FlowLayoutPanel1.Controls)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim form As New FAboutBox1
        form.ShowDialog()
    End Sub

    Private Sub FlowLayoutPanel1_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles FlowLayoutPanel1.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            Dim index As Integer
            Dim usrCtrl As userControlImg

            For index = Me.FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
                usrCtrl = FlowLayoutPanel1.Controls.Item(index)
                If usrCtrl.selected Then
                    Me.FlowLayoutPanel1.Controls.Remove(usrCtrl)
                End If
            Next
            renumber()
        End If
    End Sub


    Private Sub FlowLayoutPanel1_Click(sender As System.Object, e As System.EventArgs) Handles FlowLayoutPanel1.Click
        clearSelected()
    End Sub

    Private Sub SalvaProgettoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaProgettoToolStripMenuItem.Click
        Dim progetto As New ImagesProjectClass

        'leggo le preferenze
        progetto.sOggetto = My.Settings.oggetto
        progetto.sTitoloFoto = My.Settings.titoloFoto
        progetto.sDettagliocontenuto = My.Settings.contenutoDettaglio
        progetto.sTipoFascicolo = My.Settings.tipoFascicolo

        progetto.iColonne = My.Settings.disposizioneColonne
        progetto.iRighe = My.Settings.disposizioneRighe

        progetto.ifotoAltezzaCM = My.Settings.fotoAltezzaCM
        progetto.ifotoLarghezzaCM = My.Settings.fotoLarghezzaCM

        progetto.iDimensioneCarattere = My.Settings.carattereDimensioneBase
        progetto.iDimensioneDidascalia = My.Settings.carattereDimensioneDidascalia
        progetto.iDimensioneTitolo = My.Settings.carattereDimensioneTitoloFoto

        progetto.sFileNames = New List(Of String)()
        For Each child As userControlImg In FlowLayoutPanel1.Controls
            progetto.sFileNames.Add(child.sNomeFile)
        Next

        'serializza
        Dim jsonTxt As String = JsonConvert.SerializeObject(progetto, Formatting.Indented)
        Dim result As DialogResult = SaveFileDialogProject.ShowDialog()

        If result = DialogResult.OK Then
            'salva file testo
            ActionsLibrary.salvaTxtFile(SaveFileDialogProject.FileName, jsonTxt)
        End If

    End Sub

    Private Sub ApriProgettoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriProgettoToolStripMenuItem.Click
        Dim result As DialogResult = OpenFileDialogProject.ShowDialog()
        If result = DialogResult.OK Then

            'dialog apertura file
            Dim sTxtResult = ActionsLibrary.openTxtFile(OpenFileDialogProject.FileName)
            'procede solo se il file non è vuoto
            If sTxtResult.Length <= 0 Then
                MsgBox("File vuoto", MsgBoxStyle.DefaultButton1, "Apertura progetto")
                log.xlogWriteEntry("File non valido: " & OpenFileDialogProject.FileName, TraceEventType.Information)
            Else
                Dim progetto As New ImagesProjectClass

                Try
                    'deserializza
                    progetto = JsonConvert.DeserializeObject(Of ImagesProjectClass)(sTxtResult)

                    'leggo le preferenze
                    My.Settings.oggetto = progetto.sOggetto
                    My.Settings.titoloFoto = progetto.sTitoloFoto
                    My.Settings.contenutoDettaglio = progetto.sDettagliocontenuto
                    My.Settings.tipoFascicolo = progetto.sTipoFascicolo

                    My.Settings.disposizioneColonne = progetto.iColonne
                    My.Settings.disposizioneRighe = progetto.iRighe

                    My.Settings.fotoAltezzaCM = progetto.ifotoAltezzaCM
                    My.Settings.fotoLarghezzaCM = progetto.ifotoLarghezzaCM

                    My.Settings.carattereDimensioneBase = progetto.iDimensioneCarattere
                    My.Settings.carattereDimensioneDidascalia = progetto.iDimensioneDidascalia
                    My.Settings.carattereDimensioneTitoloFoto = progetto.iDimensioneTitolo


                    'elimina tutte le immagini presenti
                    FlowLayoutPanel1.Controls.Clear()

                    'ripopola la lista immagini
                    PopolaImmagini(progetto.sFileNames.ToArray)
                Catch ex As Exception
                    MsgBox("File non valido - " & ex.Message, MsgBoxStyle.DefaultButton1, "Apertura progetto")
                    log.xlogWriteException(ex, TraceEventType.Error, "Errore di apertura file")
                End Try

            End If
        End If





    End Sub
End Class

