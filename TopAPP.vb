Imports System.Formats
Imports System.Runtime.InteropServices

Public Class TopAPP
    Dim drag As Boolean
    Dim x As Integer
    Dim y As Integer
    Private originalIcon As String

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Hide()
        Halimm.Show()
        Halimm.Label2.Text = "مازال التطبيق يعمل في الخلفيه"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        اخفاء_الفورم

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ادمين()
        فورم_صغير(Tool1)
    End Sub
    Private Const SWP_NOSIZE As Integer = &H1
    Private Const SWP_NOZORDER As Integer = &H4
    Private Const HWND_TOPMOST As Integer = -1

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowPos(hWnd As IntPtr, hWndInsertAfter As IntPtr, X As Integer, Y As Integer, cx As Integer, cy As Integer, uFlags As UInteger) As Boolean
    End Function
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)


    End Sub
    Private labels As New List(Of Label)()
    Sub الوان()
        labels.Add(Tool3.Label1)
        labels.Add(Tool3.Label2)
        labels.Add(Tool3.Label3)
        labels.Add(Nasods.Label1)
        labels.Add(Nasods.Label2)
        labels.Add(Nasods.Label3)
        labels.Add(Nasods.Label4)
        labels.Add(Nasods.Label5)
        labels.Add(Nasods.Label6)
        labels.Add(Nasods.Label7)
        labels.Add(Nasods.Label8)
        labels.Add(Base64.Label1)
        labels.Add(Base64.Label2)
        labels.Add(Base64.Label3)
        labels.Add(Base64.Label4)
        labels.Add(Base64.Label5)
        ' labels.Add(Win10.Label1)
        '  labels.Add(Win10.Label50)
        labels.Add(Win10.Label51)
        labels.Add(Win10.Label11)
        labels.Add(Appwin.Label1)
        labels.Add(Appwin.Label6)
        labels.Add(Appwin.Label7)
        labels.Add(Appwin.Label8)

        labels.Add(Appwin.Label2)
        labels.Add(Appwin.Label3)
        labels.Add(Tool4.Label1)
        labels.Add(Tool4.Label2)
        labels.Add(Tool5.Label1)


        labels.Add(Nasos.Label1)
        labels.Add(Nasos.Label2)
        For Each lbl As Label In labels
            AddHandler lbl.MouseMove, AddressOf Label_MouseMove
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
        Next
    End Sub
    Private Sub Label_MouseMove(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub

    Private Sub TopAPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        الوان()
        Label1.Text = System.Environment.UserName & "  مرحبا"
        ' NotifyIcon1.Visible = True
        '  المتصفحات()
        '  المحفوظات()
        '  Me.FormBorderStyle = FormBorderStyle.None
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))

        Timer1.Interval = 1000 ' 
        Timer1.Enabled = True  ' 


        NotifyIcon1.Visible = True
        If Not IsAppAlreadyOpen() Then
            Me.Show()
        Else
            Me.Close()
        End If


    End Sub

    Private Function IsAppAlreadyOpen() As Boolean
        Dim procName As String = Process.GetCurrentProcess().ProcessName
        Dim processes() As Process = Process.GetProcessesByName(procName)

        If processes.Length > 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        فورم_صغير(Tool2)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        فورم_صغير(Tool3)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        فورم_صغير(Tool4)



    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        فورم_كبير(Settning)
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TopAPP_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

    End Sub

    Private Sub TopAPP_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag = True Then
            Me.Top = Cursor.Position.Y - y
            Me.Left = Cursor.Position.X - x
        End If
    End Sub

    Private Sub TopAPP_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False

    End Sub

    Private Sub TopAPP_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        x = Cursor.Position.X - Me.Left
        y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.ForeColor = Color.Green

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.ForeColor = Color.White

    End Sub




    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim url As String = "https://t.me/halem_as"

        If Not String.IsNullOrEmpty(url) Then
            Try
                Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
            Catch ex As Exception

            End Try
        Else

        End If

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        Dim url As String = "https://www.tiktok.com/@halem_as"

        If Not String.IsNullOrEmpty(url) Then
            Try
                Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim url As String = "https://twitter.com/Halem_as"

        If Not String.IsNullOrEmpty(url) Then
            Try
                Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Me.BackColor = Color.White
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        تطبيق_الاعدادات()
        PictureBox4.Visible = False
        Label7.Visible = False
    End Sub



    Private Sub PictureBox87_Click(sender As Object, e As EventArgs) Handles PictureBox87.Click
        فورم_كبير(Settning)

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        تطبيق_الاعدادات()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        فورم_صغير(Tool5)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        المحفوظات()

    End Sub
End Class
