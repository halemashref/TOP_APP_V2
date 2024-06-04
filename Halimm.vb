Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Security.Principal

Public Class Halimm
    <DllImport("Shell32.dll")>
    Private Shared Function SHChangeNotify(wEventId As Integer, uFlags As Integer, dwItem1 As IntPtr, dwItem2 As IntPtr) As Integer
    End Function
    Dim notificationIcon As New NotifyIcon()
    Dim notificationForm As New Form()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Close()

        Timer1.Stop()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
        Dim goldColor = Color.Gold
        '  Dim diameter = Math.Min(PictureBox1.Width, PictureBox1.Height) - 10
        Dim pen As New Pen(goldColor, 4)

        ' Dim centerX = PictureBox1.Width \ 29
        ' Dim centerY = PictureBox1.Height \ 20

        ' Dim rect As New Rectangle(centerX - diameter / 30, centerY - diameter / 21, diameter, diameter)
        ' e.Graphics.DrawEllipse(pen, rect)

        Try
            ' Dim image As Image = My.Resources.CapHLbm4_400x400

            Dim clipPath As New GraphicsPath
            ' clipPath.AddEllipse(rect)
            e.Graphics.SetClip(clipPath)

            ' e.Graphics.DrawImage(image, rect)
        Catch ex As Exception
            MessageBox.Show("Error loading the image: " & ex.Message)
        End Try
    End Sub
    Private Sub Halimm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True


        '  PictureBox1.BorderStyle = BorderStyle.None
        'PictureBox1.BackColor = Color.Transparent




        Dim unused = SHChangeNotify(&H8000000, &H1000, IntPtr.Zero, IntPtr.Zero)
        Timer1.Start()

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Clipboard.Clear()
        Label2.Text = "تم النسخ"

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '    Label1.ForeColor = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)

    End Sub



    Private Sub Halimm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Timer1.Interval = 2000000
    End Sub

    Private Sub Halimm_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Timer1.Interval = 1000
    End Sub



    Private Sub FlowLayoutPanel1_MouseLeave(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.MouseLeave
        Timer1.Interval = 1000

    End Sub

    Private Sub FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseMove
        Timer1.Interval = 2000000

    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        Timer1.Interval = 2000000

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Timer1.Interval = 1000

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        Timer1.Interval = 2000000

    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Timer1.Interval = 1000

    End Sub
End Class

