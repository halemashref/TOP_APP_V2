Imports System.IO

Public Class Base64


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim openFileDialog1 As New OpenFileDialog With {
           .Title = "اختر صورة",
           .Filter = "ملفات الصور (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp",
           .Multiselect = False
       }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If PictureBox1.Image IsNot Nothing Then

            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim imageBytes As Byte() = ms.ToArray()


            Dim base64String As String = Convert.ToBase64String(imageBytes)
            RichTextBox1.Text = base64String
        Else
            Halimm.Show()
            Halimm.Label2.Text = "لا يوجد صورة في البيكتشر بوكس"

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Not String.IsNullOrEmpty(RichTextBox1.Text) Then
            Try

                Dim base64String As String = RichTextBox1.Text
                Dim imageBytes As Byte() = Convert.FromBase64String(base64String)


                Using ms As New MemoryStream(imageBytes)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            Catch ex As Exception
                Halimm.Show()
                Halimm.Label2.Text = "حدث خطأ أثناء فك تشفير الصورة."
            End Try
        Else
            Halimm.Show()
            Halimm.Label2.Text = "لا يوجد نص في التكست بوكس"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Not String.IsNullOrEmpty(RichTextBox1.Text) Then

            Clipboard.SetText(RichTextBox1.Text)
            Halimm.Show()
            Halimm.Label2.Text = "تم نسخ النص بنجاح إلى الحافظة."
        Else
            Halimm.Show()
            Halimm.Label2.Text = "لا يوجد نص في التكست بوكس ليتم نسخه."
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If PictureBox1.Image IsNot Nothing Then
            Try

                Dim randomFileName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetRandomFileName() & ".jpg")


                PictureBox1.Image.Save(randomFileName, System.Drawing.Imaging.ImageFormat.Jpeg)

                Halimm.Show()
                Halimm.Label2.Text = $"تم حفظ الصورة على سطح المكتب باسم: {Path.GetFileName(randomFileName)}"
            Catch ex As Exception
                Halimm.Show()
                Halimm.Label2.Text = "حدث خطأ أثناء حفظ الصورة."
            End Try
        Else
            Halimm.Show()
            Halimm.Label2.Text = "لا يوجد صورة في البيكتشر بوكس."
        End If
    End Sub

    Private Sub Base64_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class