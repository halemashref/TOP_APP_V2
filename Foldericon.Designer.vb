<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foldericon
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
        Label2 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        TextBox1 = New TextBox()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(37, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 18)
        Label1.TabIndex = 1
        Label1.Text = "C:\"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(441, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 18)
        Label2.TabIndex = 2
        Label2.Text = "اختر ملف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(362, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 18)
        Label3.TabIndex = 3
        Label3.Text = "اختر صوره"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(146, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 18)
        Label4.TabIndex = 4
        Label4.Text = "اعاده ضبط المجلد"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Folder1
        PictureBox1.Location = New Point(2, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(252, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 18)
        Label5.TabIndex = 6
        Label5.Text = "تغير ثيم الملف"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(63, 178)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(350, 25)
        TextBox1.TabIndex = 7
        TextBox1.Text = "https://dl.dropbox.com/scl/fi/hwbgussh7j7ge715t7rdb/Icons.zip?rlkey=rrf7po1ptpg58php9x62iw5su&dl=0"
        TextBox1.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(24, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 18)
        Label6.TabIndex = 8
        Label6.Text = "تحميل الايقونات"
        ' 
        ' Foldericon
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(504, 336)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.WhiteSmoke
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Foldericon"
        Text = "Foldericon"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
End Class
