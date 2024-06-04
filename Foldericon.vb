
Imports System.IO

Public Class Foldericon
    Private labels As New List(Of Label)()

    Private iconPath As String
    Private folderPath As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        OpenFileDialog1.Filter = "Icon Files|*.ico|All Files|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            iconPath = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(iconPath)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            folderPath = FolderBrowserDialog1.SelectedPath
            Label1.Text = folderPath
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        If Not String.IsNullOrEmpty(folderPath) Then
            If Not String.IsNullOrEmpty(iconPath) Then
                Try
                    Dim desktopIniPath As String = Path.Combine(folderPath, "desktop.ini")

                    If Not File.Exists(desktopIniPath) Then

                        File.WriteAllText(desktopIniPath, "[.ShellClassInfo]" & vbCrLf & "IconResource=" & iconPath & ",0")
                        File.SetAttributes(desktopIniPath, File.GetAttributes(desktopIniPath) Or FileAttributes.Hidden Or FileAttributes.System)
                        File.SetAttributes(folderPath, File.GetAttributes(folderPath) Or FileAttributes.ReadOnly)
                    Else

                        Dim iniLines As List(Of String) = File.ReadAllLines(desktopIniPath).ToList()
                        Dim iconResourceLineIndex As Integer = -1

                        For i As Integer = 0 To iniLines.Count - 1
                            If iniLines(i).StartsWith("IconResource=") Then
                                iconResourceLineIndex = i
                                Exit For
                            End If
                        Next

                        If iconResourceLineIndex <> -1 Then
                            iniLines(iconResourceLineIndex) = "IconResource=" & iconPath & ",0"
                        Else
                            iniLines.Add("[.ShellClassInfo]")
                            iniLines.Add("IconResource=" & iconPath & ",0")
                        End If

                        File.WriteAllLines(desktopIniPath, iniLines)
                        File.SetAttributes(desktopIniPath, File.GetAttributes(desktopIniPath) Or FileAttributes.Hidden Or FileAttributes.System)
                        File.SetAttributes(folderPath, File.GetAttributes(folderPath) Or FileAttributes.ReadOnly)
                    End If

                    Halimm.Show()
                    Halimm.Label2.Text = "تم تغيير أيقونة المجلد بنجاح"
                Catch ex As Exception
                    Halimm.Show()
                    Halimm.Label2.Text = "حدث خطأ: " & ex.Message
                End Try
            Else
                Halimm.Show()
                Halimm.Label2.Text = "الرجاء اختيار أيقونة"
            End If
        Else
            Halimm.Show()
            Halimm.Label2.Text = "الرجاء تحديد مجلد"
        End If
        Try
            Dim processesByName As Process() = Process.GetProcessesByName("explorer")
            For Each proc As Process In processesByName
                proc.Kill()
            Next
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            Dim desktopIniPath = Path.Combine(folderPath, "desktop.ini")

            If File.Exists(desktopIniPath) Then

                File.Delete(desktopIniPath)

                File.SetAttributes(folderPath, FileAttributes.Normal)

                Halimm.Show()
                Halimm.Label2.Text = "تم استعادة الأيقونة الأصلية للمجلد"
            Else
                Halimm.Show()
                Halimm.Label2.Text = "لا يوجد ملف desktop.ini. ربما الأيقونة الأصلية غير موجودة"
            End If
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ: " & ex.Message
        End Try
        Try
            Dim processesByName = Process.GetProcessesByName("explorer")
            For Each proc In processesByName
                proc.Kill()
            Next
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try




    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim url As String = TextBox1.Text.Trim()

        If Not String.IsNullOrEmpty(url) Then
            Try
                Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
            Catch ex As Exception
                Halimm.Show()
                Halimm.Label2.Text = "حدث خطأ: " & ex.Message
            End Try
        Else
            Halimm.Show()
            Halimm.Label2.Text = "الرجاء إدخال رابط صالح."
        End If

    End Sub

    Private Sub Foldericon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        labels.Add(Label4)
        labels.Add(Label5)
        labels.Add(Label6)


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


End Class
