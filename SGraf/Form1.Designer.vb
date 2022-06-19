<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriProgettoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaProgettoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AumentaMiniatureCtrlScrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiminuisciMiniatureCtrlScrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrumentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraFascicoloFotograficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SvuotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialogProject = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogProject = New System.Windows.Forms.OpenFileDialog()
        Me.PreferenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AllowDrop = True
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1100, 437)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image files |*.bmp;*.jpg; *.tif|All files (*.*)|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.VisualizzazioneToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1100, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriToolStripMenuItem, Me.ApriProgettoToolStripMenuItem, Me.SalvaProgettoToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ApriToolStripMenuItem
        '
        Me.ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        Me.ApriToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ApriToolStripMenuItem.Text = "Apri immagini..."
        '
        'ApriProgettoToolStripMenuItem
        '
        Me.ApriProgettoToolStripMenuItem.Name = "ApriProgettoToolStripMenuItem"
        Me.ApriProgettoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ApriProgettoToolStripMenuItem.Text = "Apri progetto..."
        '
        'SalvaProgettoToolStripMenuItem
        '
        Me.SalvaProgettoToolStripMenuItem.Name = "SalvaProgettoToolStripMenuItem"
        Me.SalvaProgettoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SalvaProgettoToolStripMenuItem.Text = "Salva progetto..."
        '
        'VisualizzazioneToolStripMenuItem
        '
        Me.VisualizzazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AumentaMiniatureCtrlScrollToolStripMenuItem, Me.DiminuisciMiniatureCtrlScrollToolStripMenuItem})
        Me.VisualizzazioneToolStripMenuItem.Name = "VisualizzazioneToolStripMenuItem"
        Me.VisualizzazioneToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.VisualizzazioneToolStripMenuItem.Text = "Visualizzazione"
        '
        'AumentaMiniatureCtrlScrollToolStripMenuItem
        '
        Me.AumentaMiniatureCtrlScrollToolStripMenuItem.Name = "AumentaMiniatureCtrlScrollToolStripMenuItem"
        Me.AumentaMiniatureCtrlScrollToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.AumentaMiniatureCtrlScrollToolStripMenuItem.Text = "Aumenta miniature [Ctrl + scroll]"
        '
        'DiminuisciMiniatureCtrlScrollToolStripMenuItem
        '
        Me.DiminuisciMiniatureCtrlScrollToolStripMenuItem.Name = "DiminuisciMiniatureCtrlScrollToolStripMenuItem"
        Me.DiminuisciMiniatureCtrlScrollToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.DiminuisciMiniatureCtrlScrollToolStripMenuItem.Text = "Diminuisci miniature [Ctrl + scroll]"
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneraFascicoloFotograficoToolStripMenuItem, Me.OpzioniToolStripMenuItem, Me.PreferenzeToolStripMenuItem, Me.SvuotaToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        Me.StrumentiToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.StrumentiToolStripMenuItem.Text = "Strumenti"
        '
        'GeneraFascicoloFotograficoToolStripMenuItem
        '
        Me.GeneraFascicoloFotograficoToolStripMenuItem.Name = "GeneraFascicoloFotograficoToolStripMenuItem"
        Me.GeneraFascicoloFotograficoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.GeneraFascicoloFotograficoToolStripMenuItem.Text = "Genera fascicolo fotografico"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.OpzioniToolStripMenuItem.Text = "Setup..."
        '
        'SvuotaToolStripMenuItem
        '
        Me.SvuotaToolStripMenuItem.Name = "SvuotaToolStripMenuItem"
        Me.SvuotaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.SvuotaToolStripMenuItem.Text = "Svuota"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'SaveFileDialogProject
        '
        Me.SaveFileDialogProject.DefaultExt = "sgraf"
        Me.SaveFileDialogProject.FileName = "project"
        Me.SaveFileDialogProject.Filter = "SGRAF projects (*.sgraf)|*.sgraf"
        Me.SaveFileDialogProject.RestoreDirectory = True
        Me.SaveFileDialogProject.Title = "Salva progetto"
        '
        'OpenFileDialogProject
        '
        Me.OpenFileDialogProject.DefaultExt = "sgraf"
        Me.OpenFileDialogProject.FileName = "project"
        Me.OpenFileDialogProject.Filter = "SGRAF projects (*.sgraf)|*.sgraf"
        '
        'PreferenzeToolStripMenuItem
        '
        Me.PreferenzeToolStripMenuItem.Name = "PreferenzeToolStripMenuItem"
        Me.PreferenzeToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.PreferenzeToolStripMenuItem.Text = "Preferenze..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 461)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SGraf - Generatore fascicoli fotografici"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrumentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SvuotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraFascicoloFotograficoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriProgettoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvaProgettoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogProject As SaveFileDialog
    Friend WithEvents OpenFileDialogProject As OpenFileDialog
    Friend WithEvents VisualizzazioneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AumentaMiniatureCtrlScrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiminuisciMiniatureCtrlScrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreferenzeToolStripMenuItem As ToolStripMenuItem
End Class
