<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supervision
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
        ListBox1 = New ListBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Goldenrod
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Dock = DockStyle.Top
        ListBox1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(504, 306)
        ListBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.Reboot2
        PictureBox1.Location = New Point(0, 311)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkGoldenrod
        TextBox1.Location = New Point(36, 310)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(171, 25)
        TextBox1.TabIndex = 2
        ' 
        ' Supervision
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(504, 336)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(ListBox1)
        Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "Supervision"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox

End Class
