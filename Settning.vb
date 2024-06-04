

Public Class Settning
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Green
            اعاده_تشغيل_التطبيق()

        Else
            Label1.ForeColor = Color.Black
            الغاء_تشغيل_التطبيق()
        End If

        My.Settings.Halim9 = Label1.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        If Label2.ForeColor = Color.Black Then
            Label2.ForeColor = Color.Green
            تثبيت_التطبيق_علي_سطح_المكتب()

        Else
            Label2.ForeColor = Color.Black

            ازاله_التطبيق_علي_سطح_المكتب()
        End If

        My.Settings.تثبيت = Label2.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.ForeColor = Color.Black Then
            Label3.ForeColor = Color.Green
            شفاف()
        Else
            Label3.ForeColor = Color.Black
            الغاء_شفاف()

        End If

        My.Settings.Halim8 = Label3.ForeColor = Color.Green
        My.Settings.Save()


    End Sub

    Private Sub Settning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Halim9 Then
            Label1.ForeColor = Color.Green
        Else
            Label1.ForeColor = Color.Black
        End If
        If My.Settings.تثبيت Then
            Label2.ForeColor = Color.Green
        Else
            Label2.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        End
    End Sub
End Class