Imports System.IO

Imports System.Security.Principal


Public Class Startup
    Private labels As New List(Of Label)()

    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ادمين()

        labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        labels.Add(Label4)
        labels.Add(Label5)
        '  labels.Add(Label6)

        For Each lbl As Label In labels
            AddHandler lbl.MouseMove, AddressOf Label_MouseMove
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
        Next
        If My.Settings.Halim20 Then
            Label6.ForeColor = Color.Green
        Else
            Label6.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_MouseMove(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub



    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        ListBox1.Items.Add("تم انشاء:" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم انشاء " & e.FullPath


    End Sub

    Private Sub FileSystemWatcher1_Deleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        ListBox1.Items.Add("تم حذف:" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم حذف ملف " & e.FullPath

    End Sub

    Private Sub FileSystemWatcher1_Disposed(sender As Object, e As EventArgs) Handles FileSystemWatcher1.Disposed

    End Sub

    Private Sub FileSystemWatcher1_Error(sender As Object, e As ErrorEventArgs) Handles FileSystemWatcher1.[Error]

    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        ListBox1.Items.Add("تم اعاده تسميه :" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم اعاده تسميه " & e.FullPath

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        قفل
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        فتح
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Blockfilee.اخترملف
    End Sub





    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Blockfilee.قفل()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Blockfilee.اخترملف()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Blockfilee.فتح()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        If Label6.ForeColor = Color.Black Then
            Label6.ForeColor = Color.Green
            Usp()
        Else
            Label6.ForeColor = Color.Black
            Usp1()
        End If

        My.Settings.Halim20 = Label6.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click



        If Label7.ForeColor = Color.Black Then
            Label7.ForeColor = Color.Green
            Filew()
        Else
            Label7.ForeColor = Color.Black
            Filew1()
        End If

        My.Settings.Halim18 = Label7.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click




        If Label8.ForeColor = Color.Black Then
            Label8.ForeColor = Color.Green
            Desktop1()
        Else
            Label8.ForeColor = Color.Black
        End If

        My.Settings.Halim19 = Label8.ForeColor = Color.Green
        My.Settings.Save()
    End Sub
End Class
