

Public Class Ran
    Private labels As New List(Of Label)()

    Private Sub Ran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ادمين()

        ' labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        labels.Add(Label4)
        labels.Add(Label5)
        labels.Add(Label6)
        labels.Add(Label7)
        labels.Add(Label8)
        labels.Add(Label9)
        labels.Add(Label10)
        labels.Add(Label11)
        labels.Add(Label12)
        labels.Add(Label13)
        labels.Add(Label14)
        labels.Add(Label15)
        labels.Add(Label16)
        labels.Add(Label17)

        For Each lbl As Label In labels
            AddHandler lbl.MouseMove, AddressOf Label_MouseMove
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
            AddHandler lbl.MouseDown, AddressOf Label_MouseDown
            AddHandler lbl.MouseUp, AddressOf Label_MouseUp



        Next
    End Sub
    Private Sub Label_MouseUp(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gray
    End Sub

    Private Sub Label_MouseDown(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub

    Private Sub Label_MouseMove(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        مفتاح_الويندوز

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        فحص_النظام()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ترتيب_الملفات()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        اصلاح_صوره_النظام()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        فحص_اخطاء_القرص()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        اصلاح_مشاكل_بدء_التشغيل()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        اعاده_بناء_فهرس_الخدمه()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        اعاده_تعيين_خيارات_الطاقه()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        تحديث_التراخيص_والاذونات()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        اصلاح_مشاكل_النظام_في_وضع_الامان()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        اعاده_تسجيل_الخدمات()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        اعاده_بناء_فهرس_البحث()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        اصلاح_ملفات_DLL()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        اصلاح_مشاكل_الصوت()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        اصلاح_مشاكل_الشبكه()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        اصلاح_خدمه_WindowsUpdate()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        الخروج_من_وضع_الامان()
    End Sub
End Class