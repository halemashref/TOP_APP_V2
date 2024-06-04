<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockApp
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
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(450, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 19)
        Label1.TabIndex = 0
        Label1.Text = "حظر"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(340, 316)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 19)
        Label2.TabIndex = 1
        Label2.Text = "فك الحظر"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Goldenrod
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(0, 316)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(334, 18)
        TextBox1.TabIndex = 2
        TextBox1.Text = "اسم التطبيق.exe"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Goldenrod
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Dock = DockStyle.Top
        ListBox1.ForeColor = Color.Black
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(504, 306)
        ListBox1.TabIndex = 3
        ' 
        ' BlockApp
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(504, 336)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "BlockApp"
        Text = "BlockApp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
