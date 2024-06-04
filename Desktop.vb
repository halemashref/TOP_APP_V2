Public Class Desktop


    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Halim21 Then
            Label1.ForeColor = Color.Green
        Else
            Label1.ForeColor = Color.Black
        End If
        If My.Settings.Halim22 Then
            Label2.ForeColor = Color.Green
        Else
            Label2.ForeColor = Color.Black
        End If
        If My.Settings.Halim23 Then
            Label3.ForeColor = Color.Green
        Else
            Label3.ForeColor = Color.Black
        End If
        If My.Settings.Halim24 Then
            Label4.ForeColor = Color.Green
        Else
            Label4.ForeColor = Color.Black
        End If
        If My.Settings.Halim25 Then
            Label5.ForeColor = Color.Green
        Else
            Label5.ForeColor = Color.Black
        End If
        If My.Settings.Halim26 Then
            Label6.ForeColor = Color.Green
        Else
            Label6.ForeColor = Color.Black
        End If

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Green
            ازاله_سهم_الاختصارات()
        Else
            Label1.ForeColor = Color.Black
            الغاء_ازاله_سهم_الاختصارات()
        End If

        My.Settings.Halim21 = Label1.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.ForeColor = Color.Black Then
            Label2.ForeColor = Color.Green
            عرض_القوائم_اسرع()
        Else
            Label2.ForeColor = Color.Black
            الغاء_عرض_القوائم_اسرع()
        End If

        My.Settings.Halim22 = Label2.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.ForeColor = Color.Black Then
            Label3.ForeColor = Color.Green
            غلق_الويندوز_اسرع()
        Else
            Label3.ForeColor = Color.Black
            الغاء_غلق_الويندوز_اسرع()
        End If

        My.Settings.Halim23 = Label3.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Label4.ForeColor = Color.Black Then
            Label4.ForeColor = Color.Green
            تشغيل_الويندوز_اسرع()
        Else
            Label4.ForeColor = Color.Black
            الغاء_تشغيل_الويندوز_اسرع()
        End If

        My.Settings.Halim24 = Label4.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label5.ForeColor = Color.Black Then
            Label5.ForeColor = Color.Green
            ازاله_شاشه_الترحيب()
        Else
            Label5.ForeColor = Color.Black
            الغاء_ازاله_شاشه_الترحيب()
        End If

        My.Settings.Halim25 = Label5.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Label6.ForeColor = Color.Black Then
            Label6.ForeColor = Color.Green
            اخفاء_تطبيقات_سطح_المكتب()
        Else
            Label6.ForeColor = Color.Black
            الغاء_اخفاء_تطبيقات_سطح_المكتب()
        End If

        My.Settings.Halim26 = Label6.ForeColor = Color.Green
        My.Settings.Save()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        تطبيق_الاعدادات()
    End Sub
End Class