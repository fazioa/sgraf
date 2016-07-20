Imports System.IO


Public Class Form1

    Private Sub PopolaImmagini(arrayFileNames As String())
        '   lvwImmagini.Items.Clear()
        Dim i As Integer = 0
        Dim dir As DirectoryInfo = New DirectoryInfo("E:\Nuova cartella\tt")
        Dim sFile As String

        ' lvwImmagini.LargeImageList = imageList
        For Each sFile In arrayFileNames
            'ImageList.Images.Add(Bitmap.FromFile(file.FullName))
            Try
                Dim imageItem As New userControlImg(Bitmap.FromFile(sFile), sFile)
                FlowLayoutPanel1.Controls.Add(imageItem)
            Catch ex As Exception

            End Try
            i = i + 1
        Next
        For Each child As userControlImg In Me.FlowLayoutPanel1.Controls
            AddHandler child.PictureBox1.MouseDown, AddressOf childs_MouseDown

            child.LabelNumeroFoto.Text = FlowLayoutPanel1.Controls.GetChildIndex(child) + 1
        Next
    End Sub

    Private Sub FlowLayoutPanel1_GiveFeedback(sender As System.Object, e As System.Windows.Forms.GiveFeedbackEventArgs) Handles FlowLayoutPanel1.GiveFeedback

        ' Set the custom cursor based upon the effect.
        e.UseDefaultCursors = False
        If ((e.Effect And DragDropEffects.Move) = DragDropEffects.Move) Then
            Cursor.Current = Me.dragcursor
        End If


    End Sub


    Dim dragcursor As Cursor
    Dim dragtype As Type

    Private Sub childs_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Clicks = 1 Then
            Dim source As userControlImg = CType(sender.parent, userControlImg)
            source.selected = Not source.selected
            Me.Refresh()
        End If


        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim source As userControlImg = CType(sender.parent, userControlImg)
            Using bmp As New Bitmap(source.Width, source.Height)
                source.DrawToBitmap(bmp, New Rectangle(Point.Empty, source.Size))
                Me.dragcursor = New Cursor(bmp.GetHicon)
            End Using

            Me.dragtype = source.GetType
            Me.DoDragDrop(source, DragDropEffects.Move)
            Me.dragcursor.Dispose()
        End If
    End Sub

    Private Sub FlowLayoutPanel1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FlowLayoutPanel1.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            'AGGIUNGE IMMAGINE
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            ' For Each filePath As String In filePaths
            PopolaImmagini(filePaths)
            'Next
        Else

            'MUOVE IMMAGINE
            Dim source As userControlImg = CType(e.Data.GetData(dragtype), userControlImg)
            Dim target As userControlImg = Me.FlowLayoutPanel1.GetChildAtPoint(Me.FlowLayoutPanel1.PointToClient(New Point(e.X, e.Y)))
            If target IsNot Nothing Then
                Dim ix As Integer = Me.FlowLayoutPanel1.Controls.GetChildIndex(target)
                Me.FlowLayoutPanel1.Controls.SetChildIndex(source, ix)
            End If

        End If

        renumber()

    End Sub

    Private Sub FlowLayoutPanel1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FlowLayoutPanel1.DragEnter
        If e.AllowedEffect = DragDropEffects.Move AndAlso e.Data.GetDataPresent(dragtype) Then
            e.Effect = DragDropEffects.Move
        ElseIf e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub renumber()
        For Each child As userControlImg In Me.FlowLayoutPanel1.Controls
            child.LabelNumeroFoto.Text = FlowLayoutPanel1.Controls.GetChildIndex(child) + 1
        Next
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As System.Object, e As System.EventArgs) Handles FlowLayoutPanel1.Click
        sender.focus()
    End Sub

    Private Sub ApriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApriToolStripMenuItem.Click
        ' Dim result = FolderBrowserDialog1.ShowDialog()
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

End Class
