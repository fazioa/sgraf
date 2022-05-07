<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userControlImg
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userControlImg))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxTag = New System.Windows.Forms.TextBox()
        Me.LabelNumeroFoto = New System.Windows.Forms.Label()
        Me.LinkLabelNomeFile = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelEXIF = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBoxTick = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBoxTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxTag
        '
        Me.TextBoxTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTag.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTag.Location = New System.Drawing.Point(3, 191)
        Me.TextBoxTag.Multiline = True
        Me.TextBoxTag.Name = "TextBoxTag"
        Me.TextBoxTag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxTag.Size = New System.Drawing.Size(221, 60)
        Me.TextBoxTag.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBoxTag, "DIDASCALIA")
        '
        'LabelNumeroFoto
        '
        Me.LabelNumeroFoto.AutoSize = True
        Me.LabelNumeroFoto.BackColor = System.Drawing.Color.Yellow
        Me.LabelNumeroFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelNumeroFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroFoto.Location = New System.Drawing.Point(2, 5)
        Me.LabelNumeroFoto.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNumeroFoto.Name = "LabelNumeroFoto"
        Me.LabelNumeroFoto.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.LabelNumeroFoto.Size = New System.Drawing.Size(45, 28)
        Me.LabelNumeroFoto.TabIndex = 3
        Me.LabelNumeroFoto.Text = "Nr"
        Me.LabelNumeroFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabelNomeFile
        '
        Me.LinkLabelNomeFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.LabelEXIF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEXIF.AutoSize = True
        Me.LabelEXIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEXIF.Location = New System.Drawing.Point(3, 14)
        Me.LabelEXIF.Margin = New System.Windows.Forms.Padding(3, 1, 3, 0)
        Me.LabelEXIF.Name = "LabelEXIF"
        Me.LabelEXIF.Size = New System.Drawing.Size(97, 12)
        Me.LabelEXIF.TabIndex = 7
        Me.LabelEXIF.Text = "LabelEXIF"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkLabelNomeFile)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelEXIF)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 138)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(221, 47)
        Me.FlowLayoutPanel1.TabIndex = 8
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'PictureBoxTick
        '
        Me.PictureBoxTick.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxTick.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBoxTick.Image = CType(resources.GetObject("PictureBoxTick.Image"), System.Drawing.Image)
        Me.PictureBoxTick.Location = New System.Drawing.Point(161, 7)
        Me.PictureBoxTick.Name = "PictureBoxTick"
        Me.PictureBoxTick.Size = New System.Drawing.Size(52, 48)
        Me.PictureBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxTick.TabIndex = 9
        Me.PictureBoxTick.TabStop = False
        Me.PictureBoxTick.Visible = False
        '
        'userControlImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.PictureBoxTick)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TextBoxTag)
        Me.Controls.Add(Me.LabelNumeroFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "userControlImg"
        Me.Size = New System.Drawing.Size(227, 254)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBoxTick, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBoxTick As System.Windows.Forms.PictureBox
End Class
