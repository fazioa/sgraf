Imports System.IO

Public Class userControlImg

    Private _imageTmb As Image

    Sub New(image As Image, p2 As String)
        InitializeComponent()
        Dim widthImage As Integer = image.Width()
        Dim heightImage As Integer = image.Height()


        Dim ratio As Single = 0
        If widthImage < heightImage Then
            ratio = CSng(widthImage) / CSng(heightImage)
            widthImage = My.Settings.fotoLarghezzaTumb
            heightImage = Convert.ToInt32(Math.Round(CSng(widthImage) / ratio))
        Else
            ratio = CSng(heightImage) / CSng(widthImage)
            heightImage = My.Settings.fotoAltezzaTumb
            widthImage = Convert.ToInt32(Math.Round(CSng(heightImage) / ratio))
        End If



        _imageTmb = image.GetThumbnailImage(widthImage, heightImage, Nothing, IntPtr.Zero)
        sNomeFile = p2

        PictureBox1.Image = _imageTmb
        LinkLabelNomeFile.Text = Path.GetFileName(p2)
        ToolTip1.SetToolTip(PictureBox1, image.PhysicalDimension.ToString)
        ToolTip1.SetToolTip(LinkLabelNomeFile, p2)
        imageTmbWidth = image.PhysicalDimension.Width
        imagTmbHeight = image.PhysicalDimension.Height

        'LETTURA DATI EXIF

        Dim propItems As Imaging.PropertyItem() = image.PropertyItems()
        propItems.GET
        pic_time = image.GetPropertyItem(DateTime)


        leggiContenuto(LinkLabelNomeFile.Text, TextBoxTag)

    End Sub

    Public Property imageTmbWidth As Single

    Public Property imagTmbHeight As Single

    Public Property sNomeFile As String






    Private Sub TextBoxTag_Leave(sender As System.Object, e As System.EventArgs) Handles TextBoxTag.Leave

        Dim tb As TextBox = sender
        'memorizza la didascalia solo se la relativa opzione è abilitata e se la casella non è vuota
        If My.Settings.bMemorizzaDidascalia And Not tb.Text = "" Then salvaContenuto(sNomeFile, tb.Text)
    End Sub


    Private Sub salvaContenuto(sNomeFile As String, sValore As String)
        Dim file As New StreamWriter(sNomeFile & ".txt")
        file.Write(sValore)
        file.Flush()
        file.Close()
    End Sub

    Private Sub leggiContenuto(sNomeFile As String, textBox As TextBox)
        Try
            Dim file As New StreamReader(sNomeFile & ".txt")
        textBox.Text = file.ReadToEnd
        file.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LinkLabelNomeFile_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelNomeFile.LinkClicked
        clickFoto(sNomeFile)
    End Sub



    Private Sub clickFoto(sLink As String)
        Process.Start(sLink)
    End Sub

End Class
