<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base64
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
        RichTextBox1 = New RichTextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.AutoWordSelection = True
        RichTextBox1.BackColor = Color.Goldenrod
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Location = New Point(227, -1)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(282, 317)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = "ضع نص التشفير هنا"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 317)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(445, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 18)
        Label1.TabIndex = 9
        Label1.Text = "اختر صورة"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(379, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 18)
        Label2.TabIndex = 10
        Label2.Text = "Base64"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(264, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 18)
        Label3.TabIndex = 11
        Label3.Text = "Base64 فك تشفير"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(193, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 12
        Label4.Text = "نسخ النص "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(116, 319)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 18)
        Label5.TabIndex = 13
        Label5.Text = "حفظ الصورة"
        ' 
        ' Base64
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(510, 336)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Arial", 12F, FontStyle.Bold)
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Base64"
        Text = "Base64"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
