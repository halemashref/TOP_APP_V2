<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tool5
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 18)
        Label1.TabIndex = 0
        Label1.Text = "باسورد الواي فاي المحفوظ"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Wi_Fi1
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Tool5
        ' 
        AutoScaleDimensions = New SizeF(12F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(205, 336)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("MingLiU_HKSCS-ExtB", 15.75F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Tool5"
        Text = "Tool5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
