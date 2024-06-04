
Public Class Taskbar


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Green
            الساعه
        Else
            Label1.ForeColor = Color.Black
            ازاله_الساعه
        End If

        My.Settings.Halim27 = Label1.ForeColor = Color.Green
        My.Settings.Save
    End Sub

    Private Sub Taskbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Halim27 Then
            Label1.ForeColor = Color.Green
        Else
            Label1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.ForeColor = Color.Black Then
            Label2.ForeColor = Color.Green
            تاسك_اخفاء()
        Else
            Label2.ForeColor = Color.Black
            تاسك_اظهار()
        End If

        My.Settings.Halim1 = Label2.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.ForeColor = Color.Black Then
            Label3.ForeColor = Color.Green
            تاسك_شفاف()
        Else
            Label3.ForeColor = Color.Black
        End If

        My.Settings.Halim2 = Label3.ForeColor = Color.Green
        My.Settings.Save()
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Label4.ForeColor = Color.Black Then
            Label4.ForeColor = Color.Green
            تاسك_ضباب()
        Else
            Label4.ForeColor = Color.Black

        End If

        My.Settings.Halim3 = Label4.ForeColor = Color.Green
        My.Settings.Save()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label5.ForeColor = Color.Black Then
            Label5.ForeColor = Color.Green
            اتبع_لون_الخلفيه()
        Else
            Label5.ForeColor = Color.Black
        End If

        My.Settings.Halim4 = Label5.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Label6.ForeColor = Color.Black Then
            Label6.ForeColor = Color.Green
            اخفاء_ايقونات_النظام()

        Else
            Label6.ForeColor = Color.Black

        End If

        My.Settings.Halim5 = Label6.ForeColor = Color.Green
        My.Settings.Save()
    End Sub


End Class