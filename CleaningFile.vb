Imports System.IO

Public Class CleaningFile
    Private labels As New List(Of Label)()

    Private Sub CleaningFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        labels.Add(Label4)
        labels.Add(Label5)
        labels.Add(Label6)
        labels.Add(Label7)
        '  labels.Add(Label8)


        For Each lbl As Label In labels
            AddHandler lbl.MouseMove, AddressOf Label_MouseMove
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
        Next

        ListView1.View = View.Details
        ListView1.Columns.Add("القرص", 60)
        ListView1.Columns.Add("المساحة", 75)
        ListView1.Columns.Add("المتبقي ", 70)

        UpdateListView()

    End Sub

    Private Sub Label_MouseMove(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        تنظيفtemp2()
        تنظيف_temp()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        تنظيف_السله()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        حذف_التنزيلات()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        حذف_الكويكز()
        حذف_الكويكز2()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        حذف_محفوظات_التحديثات()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        UpdateListView()
    End Sub

    Private Sub UpdateListView()
        ListView1.Items.Clear()

        For Each drive As DriveInfo In DriveInfo.GetDrives()
            Dim item As New ListViewItem(drive.Name)
            item.SubItems.Add((drive.TotalSize / 1024 / 1024 / 1024).ToString("0.00"))
            item.SubItems.Add((drive.TotalFreeSpace / 1024 / 1024 / 1024).ToString("0.00"))
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        تنظيف_ملفات_المتصفحات("chrome")
        تنظيف_ملفات_المتصفحات("edge")
        تنظيف_ملفات_المتصفحات("opera")
        تنظيف_ملفات_المتصفحات("firefox")

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        تنظيف_الريجستري()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        تنظيف_ملفات_البرامج_المؤقته
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim CheckBox1 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim11 = CheckBox1.Checked
        My.Settings.Save()

        If CheckBox1.Checked Then
            تنظيفtemp2()
            تنظيف_temp()
        Else

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim CheckBox2 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim12 = CheckBox2.Checked
        My.Settings.Save()

        If CheckBox2.Checked Then
            تنظيف_السله()

        Else

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Dim CheckBox3 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim13 = CheckBox3.Checked
        My.Settings.Save()

        If CheckBox3.Checked Then
            حذف_التنزيلات()

        Else

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Dim CheckBox4 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim14 = CheckBox4.Checked
        My.Settings.Save()

        If CheckBox4.Checked Then
            حذف_الكويكز()
            حذف_الكويكز2()
        Else

        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Dim CheckBox7 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim15 = CheckBox7.Checked
        My.Settings.Save()

        If CheckBox7.Checked Then
            حذف_محفوظات_التحديثات()

        Else

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Dim CheckBox6 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim16 = CheckBox6.Checked
        My.Settings.Save()

        If CheckBox6.Checked Then
            تنظيف_ملفات_المتصفحات("chrome")
            تنظيف_ملفات_المتصفحات("edge")
            تنظيف_ملفات_المتصفحات("opera")
            تنظيف_ملفات_المتصفحات("firefox")
        Else

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Dim CheckBox5 As CheckBox = DirectCast(sender, CheckBox)

        My.Settings.Halim17 = CheckBox5.Checked
        My.Settings.Save()

        If CheckBox5.Checked Then
            تنظيف_الريجستري()

        Else

        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs)
        Dim CheckBox8 = DirectCast(sender, CheckBox)

        My.Settings.Halim18 = CheckBox8.Checked
        My.Settings.Save

        If CheckBox8.Checked Then

        Else

        End If
    End Sub
End Class