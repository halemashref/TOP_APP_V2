<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        ImageList1 = New ImageList(components)
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label2 = New Label()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Location = New Point(3, 67)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(172, 201)
        FlowLayoutPanel1.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(10, 14)
        Label1.TabIndex = 32
        Label1.Text = "."
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Unavailable2
        PictureBox4.Location = New Point(3, 21)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 15)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 28
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.USB_Connector
        PictureBox3.Location = New Point(484, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 38
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Desktop2
        PictureBox2.Location = New Point(484, 48)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 37
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.HDD2
        PictureBox1.Location = New Point(484, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Goldenrod
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Corbel Light", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ListBox1.ForeColor = Color.Black
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 13
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(326, 338)
        ListBox1.TabIndex = 33
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 18)
        Label2.TabIndex = 33
        Label2.Text = "امنع المتطفلين من فتح الملفات"
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.BackColor = Color.Transparent
        FlowLayoutPanel5.Controls.Add(Label2)
        FlowLayoutPanel5.Controls.Add(PictureBox4)
        FlowLayoutPanel5.Controls.Add(Panel2)
        FlowLayoutPanel5.Controls.Add(FlowLayoutPanel1)
        FlowLayoutPanel5.ForeColor = Color.Black
        FlowLayoutPanel5.Location = New Point(328, 24)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(176, 314)
        FlowLayoutPanel5.TabIndex = 45
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(3, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(172, 19)
        Panel2.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Cursor = Cursors.Hand
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 18)
        Label5.TabIndex = 48
        Label5.Text = "فك القفل"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(121, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 18)
        Label3.TabIndex = 46
        Label3.Text = "اخترملف"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(75, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 18)
        Label4.TabIndex = 47
        Label4.Text = "قفل"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(338, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 18)
        Label6.TabIndex = 46
        Label6.Text = "USBمنع نقل الملفات من "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Cursor = Cursors.Hand
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(393, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 18)
        Label7.TabIndex = 47
        Label7.Text = "مراقبه الاقراص"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Cursor = Cursors.Hand
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(373, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 18)
        Label8.TabIndex = 48
        Label8.Text = "مراقبه سطح المكتب"
        Label8.Visible = False
        ' 
        ' Startup
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(504, 336)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(FlowLayoutPanel5)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ListBox1)
        Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Startup"
        Text = "Startup"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
