Public Class Info
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        معلومات_الجهاز()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        حفظ_معلومات_الجهاز()
    End Sub
End Class