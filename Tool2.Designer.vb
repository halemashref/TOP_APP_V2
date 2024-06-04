<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tool2
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(26, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 18)
        Label1.TabIndex = 0
        Label1.Text = "تغير ايقونة المجلدات"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Documents_Folder1
        PictureBox1.Location = New Point(-1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Housekeeping1
        PictureBox2.Location = New Point(-1, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(26, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 2
        Label2.Text = "تنظيف الهارد"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Lock_File
        PictureBox3.Location = New Point(-1, 50)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(21, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(26, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 18)
        Label3.TabIndex = 4
        Label3.Text = "تأمين الملفات"
        ' 
        ' Tool2
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
        Font = New Font("MingLiU_HKSCS-ExtB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Tool2"
        Text = "Tool2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
End Class
