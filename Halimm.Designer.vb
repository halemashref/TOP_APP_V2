<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halimm
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
        components = New ComponentModel.Container()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label2 = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        NotifyIcon1 = New NotifyIcon(components)
        Timer2 = New Timer(components)
        Button1 = New Button()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Goldenrod
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.ForeColor = Color.Black
        FlowLayoutPanel1.Location = New Point(1, 24)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(337, 64)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 18)
        Label2.TabIndex = 0
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arabic Typesetting", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(1, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 19)
        Label1.TabIndex = 3
        Label1.Text = "TOP APP v1.0"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 50
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGoldenrod
        Button1.BackgroundImage = My.Resources.Resources.X
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.DarkGoldenrod
        Button1.Location = New Point(314, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 22)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Halimm
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGoldenrod
        ClientSize = New Size(340, 89)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Button1)
        Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Halimm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Halimm"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer2 As Timer
End Class
