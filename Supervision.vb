
Public Class Supervision
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        اختيار()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        تحديث()
    End Sub

    Private Sub Supervision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        عرض_الشبكات()
        تحديث()
    End Sub
End Class
