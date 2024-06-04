<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nasos
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Goldenrod
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(1, 2)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(507, 310)
        TextBox1.TabIndex = 0
        TextBox1.Text = "اكتب النص هنا "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(1, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 18)
        Label1.TabIndex = 3
        Label1.Text = "XOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(48, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 18)
        Label2.TabIndex = 4
        Label2.Text = "ASCII"
        ' 
        ' Nasos
        ' 
        AutoScaleDimensions = New SizeF(12F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(510, 336)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Font = New Font("Arial", 14.25F, FontStyle.Bold)
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "Nasos"
        Text = "Nasos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
