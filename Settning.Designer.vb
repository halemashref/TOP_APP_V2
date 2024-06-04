<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settning
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
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.My_Computer
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(23, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Monitor2
        PictureBox2.Location = New Point(0, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(23, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Opacity1
        PictureBox3.Location = New Point(0, 49)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Shutdown1
        PictureBox4.Location = New Point(0, 73)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(23, 18)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(29, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 18)
        Label1.TabIndex = 10
        Label1.Text = "مع بدء تشغيل الجهازTOP APPبدء تشغيل"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(29, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 18)
        Label2.TabIndex = 11
        Label2.Text = "علي سطح المكتب TOP APP تثبت"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(29, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 18)
        Label3.TabIndex = 12
        Label3.Text = "شفاف TOP APP جعل"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(29, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 18)
        Label5.TabIndex = 14
        Label5.Text = "انهاء التطبيق"
        ' 
        ' Settning
        ' 
        AutoScaleDimensions = New SizeF(12F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(510, 336)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("MingLiU_HKSCS-ExtB", 15.75F, FontStyle.Bold)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Settning"
        Text = "Settning"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
