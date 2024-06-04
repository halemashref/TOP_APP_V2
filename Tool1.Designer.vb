<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tool1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(24, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 18)
        Label1.TabIndex = 0
        Label1.Text = "معلومات الجهاز"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(24, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 18)
        Label2.TabIndex = 1
        Label2.Text = "حظر التطبيقات"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(24, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 18)
        Label3.TabIndex = 2
        Label3.Text = "شريط المهام"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(24, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 18)
        Label4.TabIndex = 3
        Label4.Text = "سطح المكتب"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(24, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 18)
        Label5.TabIndex = 4
        Label5.Text = "اصلاحات الويندوز"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Information
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(22, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Tools1
        PictureBox2.Location = New Point(-1, 23)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(22, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Monitor
        PictureBox3.Location = New Point(-1, 47)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(22, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Show_Bottom_Panel1
        PictureBox4.Location = New Point(-1, 71)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(22, 18)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Unavailable1
        PictureBox5.Location = New Point(-1, 95)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(22, 18)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.Doorbell
        PictureBox6.Location = New Point(-1, 119)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(22, 18)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(24, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 18)
        Label6.TabIndex = 10
        Label6.Text = "تفعيل الويندوز"
        ' 
        ' Tool1
        ' 
        AutoScaleDimensions = New SizeF(12F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(205, 336)
        Controls.Add(PictureBox6)
        Controls.Add(Label6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("MingLiU_HKSCS-ExtB", 15.75F, FontStyle.Bold)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Tool1"
        Text = resources.GetString("$this.Text")
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label6 As Label
End Class
