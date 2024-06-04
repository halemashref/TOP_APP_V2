<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        ListBox1 = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Goldenrod
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Dock = DockStyle.Fill
        ListBox1.ForeColor = Color.Black
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(504, 336)
        ListBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.BackgroundImage = My.Resources.Resources.Page_Down_Button
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(474, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 23)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Info
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(504, 336)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Info"
        Text = "Info"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
