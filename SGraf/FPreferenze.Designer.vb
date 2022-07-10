<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPreferenze
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPreferenze))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxISO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFlash = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDiaframma = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEsposizione = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDataOra = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModello = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMarca = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxNomeFile = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMemorizzaDidascalia = New System.Windows.Forms.CheckBox()
        Me.ComboBoxTipoFascicolo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Dimensione standard caratteri"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 98)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disposizione"
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "disposizioneRighe", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox14.Location = New System.Drawing.Point(60, 45)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(28, 20)
        Me.TextBox14.TabIndex = 1
        Me.TextBox14.Text = Global.SGraf.My.MySettings.Default.disposizioneRighe
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Righe"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "disposizioneColonne", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox13.Location = New System.Drawing.Point(60, 19)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(28, 20)
        Me.TextBox13.TabIndex = 0
        Me.TextBox13.Text = Global.SGraf.My.MySettings.Default.disposizioneColonne
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Colonne"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 98)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dimensione carattere"
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "carattereDimensioneDidascalia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox15.Location = New System.Drawing.Point(168, 71)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(31, 20)
        Me.TextBox15.TabIndex = 2
        Me.TextBox15.Text = Global.SGraf.My.MySettings.Default.carattereDimensioneDidascalia
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(157, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Dimensione carattere didascalia"
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "carattereDimensioneTitoloFoto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox11.Location = New System.Drawing.Point(168, 45)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(31, 20)
        Me.TextBox11.TabIndex = 1
        Me.TextBox11.Text = Global.SGraf.My.MySettings.Default.carattereDimensioneTitoloFoto
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Dimensione carattere titolo foto"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "carattereDimensioneBase", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.TextBox9.Location = New System.Drawing.Point(162, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(37, 20)
        Me.TextBox9.TabIndex = 0
        Me.TextBox9.Text = Global.SGraf.My.MySettings.Default.carattereDimensioneBase
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox16)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBox17)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(152, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 98)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimensioni massime"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "fotoLarghezzaCM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox16.Location = New System.Drawing.Point(68, 45)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(28, 20)
        Me.TextBox16.TabIndex = 1
        Me.TextBox16.Text = Global.SGraf.My.MySettings.Default.fotoLarghezzaCM
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Larghezza"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "fotoAltezzaCM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox17.Location = New System.Drawing.Point(68, 19)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(28, 20)
        Me.TextBox17.TabIndex = 0
        Me.TextBox17.Text = Global.SGraf.My.MySettings.Default.fotoAltezzaCM
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Altezza"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Tipo fascicolo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBoxISO)
        Me.GroupBox5.Controls.Add(Me.CheckBoxFlash)
        Me.GroupBox5.Controls.Add(Me.CheckBoxDiaframma)
        Me.GroupBox5.Controls.Add(Me.CheckBoxEsposizione)
        Me.GroupBox5.Controls.Add(Me.CheckBoxDataOra)
        Me.GroupBox5.Controls.Add(Me.CheckBoxModello)
        Me.GroupBox5.Controls.Add(Me.CheckBoxMarca)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(349, 74)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "EXIF"
        '
        'CheckBoxISO
        '
        Me.CheckBoxISO.AutoSize = True
        Me.CheckBoxISO.Checked = Global.SGraf.My.MySettings.Default.bEXIFISO
        Me.CheckBoxISO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxISO.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFISO", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxISO.Location = New System.Drawing.Point(99, 42)
        Me.CheckBoxISO.Name = "CheckBoxISO"
        Me.CheckBoxISO.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxISO.TabIndex = 43
        Me.CheckBoxISO.Text = "ISO"
        Me.CheckBoxISO.UseVisualStyleBackColor = True
        '
        'CheckBoxFlash
        '
        Me.CheckBoxFlash.AutoSize = True
        Me.CheckBoxFlash.Checked = Global.SGraf.My.MySettings.Default.bEXIFFlash
        Me.CheckBoxFlash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxFlash.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFFlash", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxFlash.Location = New System.Drawing.Point(270, 20)
        Me.CheckBoxFlash.Name = "CheckBoxFlash"
        Me.CheckBoxFlash.Size = New System.Drawing.Size(51, 17)
        Me.CheckBoxFlash.TabIndex = 42
        Me.CheckBoxFlash.Text = "Flash"
        Me.CheckBoxFlash.UseVisualStyleBackColor = True
        '
        'CheckBoxDiaframma
        '
        Me.CheckBoxDiaframma.AutoSize = True
        Me.CheckBoxDiaframma.Checked = Global.SGraf.My.MySettings.Default.bEXIFDiaframma
        Me.CheckBoxDiaframma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDiaframma.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFDiaframma", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxDiaframma.Location = New System.Drawing.Point(182, 19)
        Me.CheckBoxDiaframma.Name = "CheckBoxDiaframma"
        Me.CheckBoxDiaframma.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxDiaframma.TabIndex = 41
        Me.CheckBoxDiaframma.Text = "Diaframma"
        Me.CheckBoxDiaframma.UseVisualStyleBackColor = True
        '
        'CheckBoxEsposizione
        '
        Me.CheckBoxEsposizione.AutoSize = True
        Me.CheckBoxEsposizione.Checked = Global.SGraf.My.MySettings.Default.bEXIFEsposizione
        Me.CheckBoxEsposizione.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxEsposizione.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFEsposizione", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxEsposizione.Location = New System.Drawing.Point(182, 42)
        Me.CheckBoxEsposizione.Name = "CheckBoxEsposizione"
        Me.CheckBoxEsposizione.Size = New System.Drawing.Size(82, 17)
        Me.CheckBoxEsposizione.TabIndex = 40
        Me.CheckBoxEsposizione.Text = "Esposizione"
        Me.CheckBoxEsposizione.UseVisualStyleBackColor = True
        '
        'CheckBoxDataOra
        '
        Me.CheckBoxDataOra.AutoSize = True
        Me.CheckBoxDataOra.Checked = Global.SGraf.My.MySettings.Default.bEXIFDataOra
        Me.CheckBoxDataOra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDataOra.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFDataOra", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxDataOra.Location = New System.Drawing.Point(99, 19)
        Me.CheckBoxDataOra.Name = "CheckBoxDataOra"
        Me.CheckBoxDataOra.Size = New System.Drawing.Size(77, 17)
        Me.CheckBoxDataOra.TabIndex = 39
        Me.CheckBoxDataOra.Text = "Data / Ora"
        Me.CheckBoxDataOra.UseVisualStyleBackColor = True
        '
        'CheckBoxModello
        '
        Me.CheckBoxModello.AutoSize = True
        Me.CheckBoxModello.Checked = Global.SGraf.My.MySettings.Default.bEXIFModello
        Me.CheckBoxModello.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxModello.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFModello", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxModello.Location = New System.Drawing.Point(6, 43)
        Me.CheckBoxModello.Name = "CheckBoxModello"
        Me.CheckBoxModello.Size = New System.Drawing.Size(63, 17)
        Me.CheckBoxModello.TabIndex = 38
        Me.CheckBoxModello.Text = "Modello"
        Me.CheckBoxModello.UseVisualStyleBackColor = True
        '
        'CheckBoxMarca
        '
        Me.CheckBoxMarca.AutoSize = True
        Me.CheckBoxMarca.Checked = Global.SGraf.My.MySettings.Default.bEXIFMarca
        Me.CheckBoxMarca.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMarca.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bEXIFMarca", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxMarca.Location = New System.Drawing.Point(6, 20)
        Me.CheckBoxMarca.Name = "CheckBoxMarca"
        Me.CheckBoxMarca.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxMarca.TabIndex = 37
        Me.CheckBoxMarca.Text = "Marca"
        Me.CheckBoxMarca.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.CheckBoxNomeFile)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(361, 126)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dati da inserire nel fascicolo"
        '
        'CheckBoxNomeFile
        '
        Me.CheckBoxNomeFile.AutoSize = True
        Me.CheckBoxNomeFile.Checked = Global.SGraf.My.MySettings.Default.bNomeFile
        Me.CheckBoxNomeFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNomeFile.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bNomeFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxNomeFile.Location = New System.Drawing.Point(12, 23)
        Me.CheckBoxNomeFile.Name = "CheckBoxNomeFile"
        Me.CheckBoxNomeFile.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxNomeFile.TabIndex = 39
        Me.CheckBoxNomeFile.Text = "Nome File"
        Me.CheckBoxNomeFile.UseVisualStyleBackColor = True
        '
        'CheckBoxMemorizzaDidascalia
        '
        Me.CheckBoxMemorizzaDidascalia.AutoSize = True
        Me.CheckBoxMemorizzaDidascalia.Checked = Global.SGraf.My.MySettings.Default.bMemorizzaDidascalia
        Me.CheckBoxMemorizzaDidascalia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMemorizzaDidascalia.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SGraf.My.MySettings.Default, "bMemorizzaDidascalia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxMemorizzaDidascalia.Location = New System.Drawing.Point(245, 19)
        Me.CheckBoxMemorizzaDidascalia.Name = "CheckBoxMemorizzaDidascalia"
        Me.CheckBoxMemorizzaDidascalia.Size = New System.Drawing.Size(173, 17)
        Me.CheckBoxMemorizzaDidascalia.TabIndex = 36
        Me.CheckBoxMemorizzaDidascalia.Text = "Memorizza didascalia immagine"
        Me.CheckBoxMemorizzaDidascalia.UseVisualStyleBackColor = True
        '
        'ComboBoxTipoFascicolo
        '
        Me.ComboBoxTipoFascicolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SGraf.My.MySettings.Default, "tipoFascicolo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxTipoFascicolo.FormattingEnabled = True
        Me.ComboBoxTipoFascicolo.Items.AddRange(New Object() {"Descrittivo", "Identificazione"})
        Me.ComboBoxTipoFascicolo.Location = New System.Drawing.Point(92, 17)
        Me.ComboBoxTipoFascicolo.Name = "ComboBoxTipoFascicolo"
        Me.ComboBoxTipoFascicolo.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxTipoFascicolo.TabIndex = 13
        Me.ComboBoxTipoFascicolo.Text = Global.SGraf.My.MySettings.Default.tipoFascicolo
        '
        'FPreferenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 291)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.CheckBoxMemorizzaDidascalia)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.ComboBoxTipoFascicolo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPreferenze"
        Me.Text = "FPreferenze"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipoFascicolo As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxMemorizzaDidascalia As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxFlash As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDiaframma As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEsposizione As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDataOra As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxModello As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMarca As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxISO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxNomeFile As System.Windows.Forms.CheckBox
End Class
