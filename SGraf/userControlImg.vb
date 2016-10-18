Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Net.Mime.MediaTypeNames.Image

Public Enum ExifProperty
    Title = &H9C9B              ' 40091
    Comments = &H9C9C           ' 40092
    Author = &H9C9D             ' 40093
    Keywords = &H9C9E           ' 40094
    Gps_Ver = &H0
    Gps_LatitudeRef = &H1
    Gps_Latitude = &H2
    Gps_LongitudeRef = &H3
    Gps_Longitude = &H4
    Gps_AltitudeRef = &H5
    Gps_Altitude = &H6
    Gps_GpsTime = &H7
    Gps_GpsSatellites = &H8
    Gps_GpsStatus = &H9
    Gps_GpsMeasureMode = &HA
    Gps_GpsDop = &HB
    Gps_SpeedRef = &HC
    Gps_Speed = &HD
    Gps_TrackRef = &HE
    Gps_Track = &HF
    Gps_ImgDirRef = &H10
    Gps_ImgDir = &H11
    Gps_MapDatum = &H12
    Gps_DestLatRef = &H13
    Gps_DestLat = &H14
    Gps_DestLongRef = &H15
    Gps_DestLong = &H16
    Gps_DestBearRef = &H17
    Gps_DestBear = &H18
    Gps_DestDistRef = &H19
    Gps_DestDist = &H1A
    New_Subfile_Type = &HFE
    Subfile_Type = &HFF
    Image_Width = &H100
    Image_Height = &H101
    Bits_Per_Sample = &H102
    Compression = &H103
    Photometric_Interp = &H106
    Thresh_Holding = &H107
    Cell_Width = &H108
    Cell_Height = &H109
    Fill_Order = &H10A
    Document_Name = &H10D
    Image_Description = &H10E
    Equip_Make = &H10F
    Equip_Model = &H110
    Strip_Offsets = &H111
    Orientation = &H112
    Samples_PerPixel = &H115
    Rows_Per_Strip = &H116
    Strip_Bytes_Count = &H117
    Min_Sample_Value = &H118
    Max_Sample_Value = &H119
    X_Resolution = &H11A
    Y_Resolution = &H11B
    Planar_Config = &H11C
    Page_Name = &H11D
    X_Position = &H11E
    Y_Position = &H11F
    Free_Offset = &H120
    Free_Byte_Counts = &H121
    Gray_Response_Unit = &H122
    Gray_Response_Curve = &H123
    T4_Option = &H124
    T6_Option = &H125
    Resolution_Unit = &H128
    Page_Number = &H129
    Transfer_Function = &H12D
    Software_Used = &H131
    Date_Time = &H132
    Artist = &H13B
    Host_Computer = &H13C
    Predictor = &H13D
    White_Point = &H13E
    Primary_Chromaticities = &H13F
    ColorMap = &H140
    Halftone_Hints = &H141
    Tile_Width = &H142
    Tile_Length = &H143
    Tile_Offset = &H144
    Tile_ByteCounts = &H145
    InkSet = &H14C
    Ink_Names = &H14D
    Number_Of_Inks = &H14E
    Dot_Range = &H150
    Target_Printer = &H151
    Extra_Samples = &H152
    Sample_Format = &H153
    S_Min_Sample_Value = &H154
    S_Max_Sample_Value = &H155
    Transfer_Range = &H156
    JPEG_Proc = &H200
    JPEG_InterFormat = &H201
    JPEG_InterLength = &H202
    JPEG_RestartInterval = &H203
    JPEG_LosslessPredictors = &H205
    JPEG_PointTransforms = &H206
    JPEG_QTables = &H207
    JPEG_DCTables = &H208
    JPEG_ACTables = &H209
    YCbCr_Coefficients = &H211
    YCbCr_Subsampling = &H212
    YCbCr_Positioning = &H213
    REF_Black_White = &H214
    Gamma = &H301
    ICC_Profile_Descriptor = &H302
    SRGB_RenderingIntent = &H303
    Image_Title = &H320
    Thumbnail_ImageHeight = &H502
    Resolution_X_Unit = &H5001
    Resolution_Y_Unit = &H5002
    Resolution_X_LengthUnit = &H5003
    Resolution_Y_LengthUnit = &H5004
    Print_Flags = &H5005
    Print_Flags_Version = &H5006
    Print_Flags_Crop = &H5007
    Print_Flags_Bleed_Width = &H5008
    Print_Flags_Bleed_Width_Scale = &H5009
    Halftone_LPI = &H500A
    Halftone_LPIUnit = &H500B
    Halftone_Degree = &H500C
    Halftone_Shape = &H500D
    Halftone_Misc = &H500E
    Halftone_Screen = &H500F
    JPEG_Quality = &H5010
    Grid_Size = &H5011
    Thumbnail_Format = &H5012
    Thumbnail_Width = &H5013
    Thumbnail_Height = &H5014
    Thumbnail_ColorDepth = &H5015
    Thumbnail_Planes = &H5016
    Thumbnail_RawBytes = &H5017
    Thumbnail_Size = &H5018
    Thumbnail_CompressedSize = &H5019
    Color_Transfer_Function = &H501A
    Thumbnail_Data = &H501B
    Thumbnail_ImageWidth = &H5020
    Thumbnail_BitsPerSample = &H5022
    Thumbnail_Compression = &H5023
    Thumbnail_PhotometricInterp = &H5024
    Thumbnail_ImageDescription = &H5025
    Thumbnail_EquipMake = &H5026
    Thumbnail_EquipModel = &H5027
    Thumbnail_StripOffsets = &H5028
    Thumbnail_Orientation = &H5029
    Thumbnail_SamplesPerPixel = &H502A
    Thumbnail_RowsPerStrip = &H502B
    Thumbnail_StripBytesCount = &H502C
    Thumbnail_ResolutionX = &H502D
    Thumbnail_ResolutionY = &H502E
    Thumbnail_PlanarConfig = &H502F
    Thumbnail_ResolutionUnit = &H5030
    Thumbnail_TransferFunction = &H5031
    Thumbnail_SoftwareUsed = &H5032
    Thumbnail_DateTime = &H5033
    Thumbnail_Artist = &H5034
    Thumbnail_WhitePoint = &H5035
    Thumbnail_PrimaryChromaticities = &H5036
    Thumbnail_YCbCrCoefficients = &H5037
    Thumbnail_YCbCrSubsampling = &H5038
    Thumbnail_YCbCrPositioning = &H5039
    Thumbnail_RefBlackWhite = &H503A
    Thumbnail_CopyRight = &H503B
    Luminance_Table = &H5090
    Chrominance_Table = &H5091
    Frame_Delay = &H5100
    Loop_Count = &H5101
    Pixel_Unit = &H5110
    Pixel_PerUnit_X = &H5111
    Pixel_PerUnit_Y = &H5112
    Palette_Histogram = &H5113
    Copyright = &H8298
    Exposure_Time = &H829A
    F_Number = &H829D
    Exif_IFD = &H8769
    ICC_Profile = &H8773
    Exposure_Prog = &H8822
    Spectral_Sense = &H8824
    Gps_IFD = &H8825
    ISO_Speed = &H8827
    OECF = &H8828
    Ver = &H9000
    DTOrig = &H9003
    DTDigitized = &H9004
    CompConfig = &H9101
    CompBPP = &H9102
    Shutter_Speed = &H9201
    Aperture = &H9202
    Brightness = &H9203
    Exposure_Bias = &H9204
    MaxAperture = &H9205
    SubjectDist = &H9206
    Metering_Mode = &H9207
    LightSource = &H9208
    Flash = &H9209
    FocalLength = &H920A
    Maker_Note = &H927C
    User_Comment = &H9286
    DTSubsec = &H9290
    DTOrigSS = &H9291
    DTDigSS = &H9292
    FPXVer = &HA000
    ColorSpace = &HA001
    PixXDim = &HA002
    PixYDim = &HA003
    RelatedWav = &HA004
    Interop = &HA005
    FlashEnergy = &HA20B
    SpatialFR = &HA20C
    FocalXRes = &HA20E
    FocalYRes = &HA20F
    FocalResUnit = &HA210
    Subject_Loc = &HA214
    Exposure_Index = &HA215
    Sensing_Method = &HA217
    FileSource = &HA300
    SceneType = &HA301
    CfaPattern = &HA302
End Enum

Public Class userControlImg

    Private _imageTmb As Image

    Private isSelected As Boolean = False

    Private sTitolo As String
    Private sMarca As String
    Private sModello As String
    Private sDataScatto As String
    Private sISO As String
    Private sEsposizione As String
    Private sDiaframma As String
    Private sFlash As String

    Public Property titolo As String
        Get
            Return sTitolo
        End Get
        Set(value As String)
            sTitolo = value
        End Set
    End Property

    Public Property marca As String
        Get
            Return sMarca
        End Get
        Set(value As String)
            sMarca = value
        End Set
    End Property

    Public Property modello As String
        Get
            Return sModello
        End Get
        Set(value As String)
            sModello = value
        End Set
    End Property

    Public Property ISO As String
        Get
            Return sISO
        End Get
        Set(value As String)
            sISO = value
        End Set
    End Property
    Public Property esposizione As String
        Get
            Return sEsposizione
        End Get
        Set(value As String)
            sEsposizione = value
        End Set
    End Property
    Public Property diaframma As String
        Get
            Return sDiaframma
        End Get
        Set(value As String)
            sDiaframma = value
        End Set
    End Property

    Public Property dataScatto As String
        Get
            Return sDataScatto
        End Get
        Set(value As String)
            sDataScatto = value
        End Set
    End Property

    Public Property flash As String
        Get
            Return sFlash
        End Get
        Set(value As String)
            sFlash = value
        End Set
    End Property

    Public Property selected() As Boolean
        Get
            Return isSelected
        End Get
        Set(ByVal value As Boolean)
            isSelected = value
            If isSelected Then
                PictureBoxTick.Parent = PictureBox1
                PictureBoxTick.Top = PictureBox1.Location.Y
                PictureBoxTick.Left = PictureBox1.Location.X + PictureBox1.Width - PictureBoxTick.Width - 25

                PictureBoxTick.Visible = True
                Form1.FlowLayoutPanel1.Focus()
            Else
                PictureBoxTick.Visible = False
            End If
        End Set
    End Property

    Dim pixelColor As Color
    Dim r, g, b As Byte

    

    Public Function IngAC_IMMAGINE_LUMINOSITA(ByVal Immagine As Bitmap, ByVal Luminosita As Single) As Bitmap
        'luminosità range [-1,+1]=>[0,100]
        If Luminosita < 0 Then Luminosita = 0
        If Luminosita > 100 Then Luminosita = 100
        Dim br As Single = 2 * Luminosita / 100 - 1 '-1, +1
        ' Si crea la Brightness_Matrix
        Dim Brightness_Matrix As Single()() = {
         New Single() {1, 0, 0, 0, 0},
         New Single() {0, 1, 0, 0, 0},
         New Single() {0, 0, 1, 0, 0},
         New Single() {0, 0, 0, 1, 0},
         New Single() {br, br, br, 0, 1}}
        ' Si crea una copia dell'immagine di partenza 
        Dim bmp As New Bitmap(Immagine)
        Dim imgattr As New ImageAttributes()
        Dim rc As New Rectangle(0, 0, Immagine.Width, Immagine.Height)
        Dim g As Graphics = Graphics.FromImage(Immagine)
        Dim cm As New ColorMatrix(Brightness_Matrix)
        '  Si associa la Brightness_Matrix con una ImageAttributes
        imgattr.SetColorMatrix(cm)
        ' Si applica la color_matrix all'immagine
        g.DrawImage(bmp, rc, 0, 0, Immagine.Width, Immagine.Height,
                                  GraphicsUnit.Pixel, imgattr)
        ' Reset
        g.Dispose()
        Return Immagine ' Restituisce l'immagine modificata
    End Function

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
        'Get the PropertyItems property from image
        Dim count As Integer = 0
        Dim propItems As Imaging.PropertyItem() = image.PropertyItems()

        Dim encoding As New System.Text.ASCIIEncoding()

        Dim pic_data As PropertyItem
        Try
            pic_data = image.GetPropertyItem(ExifProperty.Equip_Make)
            sMarca = System.Text.Encoding.ASCII.GetString(pic_data.Value, 0, pic_data.Len - 1)
            sMarca = sMarca.Trim()

        Catch ex As Exception
        End Try

        Try
            pic_data = image.GetPropertyItem(ExifProperty.Equip_Model)
            sModello = System.Text.Encoding.ASCII.GetString(pic_data.Value, 0, pic_data.Len - 1)
            sModello = sModello.Trim
        Catch ex As Exception
        End Try
        Try
            pic_data = image.GetPropertyItem(ExifProperty.Date_Time)
            sDataScatto = System.Text.Encoding.ASCII.GetString(pic_data.Value, 0, pic_data.Len - 1)
            Dim time As DateTime
            Dim sData As String = sDataScatto.Substring(0, 10)
            Dim sArrayData As String() = sData.Split(":")
            Dim sOra As String = sDataScatto.Substring(11, 8)
            Dim sArrayOra As String() = sOra.Split(":")
            time = New DateTime(CType(sArrayData(0), Integer), CType(sArrayData(1), Integer), CType(sArrayData(2), Integer), CType(sArrayOra(0), Integer), CType(sArrayOra(1), Integer), CType(sArrayOra(2), Integer))
            Dim format As String = "dd/MMM/yyyy ore HH:mm"
            sDataScatto = time.ToString(format)
        Catch ex As Exception
        End Try

        Dim a, b As UShort
        Try
            pic_data = image.GetPropertyItem(ExifProperty.Exposure_Time)

            a = BitConverter.ToUInt16(pic_data.Value, 0)
            b = BitConverter.ToUInt16(pic_data.Value, 4)
            sEsposizione = "1/" & 1 / (a / b) & " sec"
        Catch ex As Exception
        End Try

        Try
            pic_data = image.GetPropertyItem(ExifProperty.F_Number)
            a = BitConverter.ToUInt16(pic_data.Value, 0)
            b = BitConverter.ToUInt16(pic_data.Value, 4)
            sDiaframma = "f/" & a / b
        Catch ex As Exception
        End Try

        Try
            pic_data = image.GetPropertyItem(ExifProperty.ISO_Speed)
            a = BitConverter.ToUInt16(pic_data.Value, 0)
            sISO = "ISO " & a
        Catch ex As Exception
        End Try

        Try
            pic_data = image.GetPropertyItem(ExifProperty.Flash)
            a = BitConverter.ToUInt16(pic_data.Value, 0)
            Dim ba As New BitArray({a})
            If (ba.Get(0)) Then
                sFlash = "Flash on"
            Else
                sFlash = "Flash off"
            End If

        Catch ex As Exception
        End Try
        LabelEXIF.Text = ""
        If My.Settings.bEXIFMarca Then
            LabelEXIF.Text = LabelEXIF.Text & Trim(sMarca)
        End If
        If My.Settings.bEXIFModello Then
            If LabelEXIF.Text <> "" And sModello IsNot Nothing Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sModello)
        End If
        If My.Settings.bEXIFDataOra Then
            If LabelEXIF.Text <> "" And sDataScatto IsNot Nothing Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sDataScatto)
        End If
        If My.Settings.bEXIFEsposizione And sEsposizione IsNot Nothing Then
            If LabelEXIF.Text <> "" Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sEsposizione)
        End If
        If My.Settings.bEXIFDiaframma And sDiaframma IsNot Nothing Then
            If LabelEXIF.Text <> "" Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sDiaframma)
        End If
        If My.Settings.bEXIFISO And sISO IsNot Nothing Then
            If LabelEXIF.Text <> "" Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sISO)
        End If
        If My.Settings.bEXIFFlash And sFlash IsNot Nothing Then
            If LabelEXIF.Text <> "" Then LabelEXIF.Text += ", "
            LabelEXIF.Text = LabelEXIF.Text & Trim(sFlash)
        End If
        leggiContenuto(LinkLabelNomeFile.Text, TextBoxTag)
        ToolTip1.SetToolTip(LabelEXIF, LabelEXIF.Text)

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




    Private Sub userControlImg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'For Each ctrl As Control In Me.Controls
        '    AddHandler ctrl.Click, AddressOf Me.Me_Click
        'Next ctrl

        'AddHandler Me.MouseDown, AddressOf Me.Me_Click
    End Sub

    '  Private Sub Me_Click(sender As Object, e As EventArgs)
    '
    ' End Sub



End Class
