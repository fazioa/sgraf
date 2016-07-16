<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userControlImg
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxTag = New System.Windows.Forms.TextBox()
        Me.LabelNumeroFoto = New System.Windows.Forms.Label()
        Me.LinkLabelNomeFile = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelEXIF = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(32, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxTag
        '
        Me.TextBoxTag.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTag.Location = New System.Drawing.Point(32, 170)
        Me.TextBoxTag.Multiline = True
        Me.TextBoxTag.Name = "TextBoxTag"
        Me.TextBoxTag.Size = New System.Drawing.Size(171, 54)
        Me.TextBoxTag.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBoxTag, "DIDASCALIA")
        '
        'LabelNumeroFoto
        '
        Me.LabelNumeroFoto.AutoSize = True
        Me.LabelNumeroFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroFoto.Location = New System.Drawing.Point(-1, 3)
        Me.LabelNumeroFoto.Name = "LabelNumeroFoto"
        Me.LabelNumeroFoto.Size = New System.Drawing.Size(30, 24)
        Me.LabelNumeroFoto.TabIndex = 3
        Me.LabelNumeroFoto.Text = "Nr"
        '
        'LinkLabelNomeFile
        '
        Me.LinkLabelNomeFile.AutoSize = True
        Me.LinkLabelNomeFile.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabelNomeFile.Name = "LinkLabelNomeFile"
        Me.LinkLabelNomeFile.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabelNomeFile.TabIndex = 6
        Me.LinkLabelNomeFile.TabStop = True
        Me.LinkLabelNomeFile.Text = "LinkLabelNomeFile"
        '
        'LabelEXIF
        '
        Me.LabelEXIF.AutoSize = True
        Me.LabelEXIF.Location = New System.Drawing.Point(3, 13)
        Me.LabelEXIF.Name = "LabelEXIF"
        Me.LabelEXIF.Size = New System.Drawing.Size(56, 13)
        Me.LabelEXIF.TabIndex = 7
        Me.LabelEXIF.Text = "LabelEXIF"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkLabelNomeFile)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelEXIF)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(32, 138)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(171, 32)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'userControlImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TextBoxTag)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelNumeroFoto)
        Me.Name = "userControlImg"
        Me.Size = New System.Drawing.Size(216, 224)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxTag As System.Windows.Forms.TextBox
    Friend WithEvents LabelNumeroFoto As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LinkLabelNomeFile As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelEXIF As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
