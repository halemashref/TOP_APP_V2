<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tool3
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Wolfram_Alpha
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(25, 24)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 18)
        Label1.TabIndex = 3
        Label1.Text = "Base64 تشفير الصور"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Base_641
        PictureBox2.Location = New Point(0, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.ImageAlign = ContentAlignment.MiddleRight
        Label2.Location = New Point(25, 0)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 18)
        Label2.TabIndex = 5
        Label2.Text = "تشفير النصوص"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Profile
        PictureBox3.Location = New Point(0, 48)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(25, 48)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 18)
        Label3.TabIndex = 7
        Label3.Text = "زخرفه النصوص"
        ' 
        ' Tool3
        ' 
        AutoScaleDimensions = New SizeF(12F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(205, 336)
        Controls.Add(PictureBox3)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("MingLiU_HKSCS-ExtB", 15.75F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Tool3"
        Text = "Tool3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
End Class
