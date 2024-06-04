Imports System.IO
Imports System.Security.Claims
Imports Microsoft.Win32

Public Class Win10


    Private Sub Win10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        نوع_النظام()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click




    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

        Panel1.Visible = Not Panel1.Visible




    End Sub



    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        ازاله_الاشعار()
        Label11.Text = "تم ازاله الاشعار الرجاء اعادة تشغيل الجهاز"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class