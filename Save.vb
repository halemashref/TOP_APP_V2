

Imports System.Reflection.Emit

Module Save
    Sub المحفوظات()







        If My.Settings.Halim18 Then
            Startup.Label7.ForeColor = Color.Green
        Else
            Startup.Label7.ForeColor = Color.Black
        End If
        If My.Settings.Halim19 Then
            Startup.Label8.ForeColor = Color.Green
        Else
            Startup.Label8.ForeColor = Color.Black
        End If


        If My.Settings.Halim1 Then
            Taskbar.Label2.ForeColor = Color.Green
            تاسك_اخفاء()

        Else
            Taskbar.ForeColor = Color.Black
            تاسك_اظهار()

        End If
        If My.Settings.Halim2 Then
            Taskbar.Label3.ForeColor = Color.Green
            تاسك_شفاف()

        Else
            Taskbar.ForeColor = Color.Black
        End If
        If My.Settings.Halim3 Then
            Taskbar.Label4.ForeColor = Color.Green
            تاسك_ضباب()

        Else
            Taskbar.ForeColor = Color.Black
        End If
        If My.Settings.Halim4 Then
            Taskbar.Label5.ForeColor = Color.Green
            اتبع_لون_الخلفيه()

        Else
            Taskbar.ForeColor = Color.Black
        End If
        If My.Settings.Halim5 Then
            Taskbar.Label6.ForeColor = Color.Green
            اخفاء_ايقونات_النظام()

        Else
            Taskbar.ForeColor = Color.Black
        End If
        If My.Settings.حليممم Then
            Settning.Label5.ForeColor = Color.Green

        Else
            Settning.Label5.ForeColor = Color.Black
        End If
        If My.Settings.Halim8 Then
            Settning.Label3.ForeColor = Color.Green
            شفاف()
        Else
            Settning.Label3.ForeColor = Color.Black
            الغاء_شفاف()
        End If
    End Sub
    Sub المتصفحات()
        CleaningFile.CheckBox1.Checked = My.Settings.Halim11

        If CleaningFile.CheckBox1.Checked Then


        Else


        End If
        CleaningFile.CheckBox2.Checked = My.Settings.Halim12

        If CleaningFile.CheckBox2.Checked Then


        Else


        End If
        CleaningFile.CheckBox3.Checked = My.Settings.Halim13

        If CleaningFile.CheckBox3.Checked Then


        Else


        End If
        CleaningFile.CheckBox4.Checked = My.Settings.Halim14

        If CleaningFile.CheckBox4.Checked Then


        Else


        End If
        CleaningFile.CheckBox5.Checked = My.Settings.Halim15

        If CleaningFile.CheckBox5.Checked Then


        Else


        End If
        CleaningFile.CheckBox6.Checked = My.Settings.Halim16

        If CleaningFile.CheckBox6.Checked Then


        Else


        End If
        CleaningFile.CheckBox7.Checked = My.Settings.Halim17

        If CleaningFile.CheckBox7.Checked Then


        Else


        End If

    End Sub
End Module
