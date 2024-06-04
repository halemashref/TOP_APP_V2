
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Security.Principal

Public Class Appwin
#Disable Warning SYSLIB0014
    Private WithEvents webClient As New WebClient()
#Enable Warning SYSLIB0014

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim address As String = "https://2h.ae/SvZN"
        Dim path1 As String = "C:\Program Files\Adobe\Adobe After Effects 2023\Support Files"

        AddHandler WebClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data As Byte() = WebClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry As ZipArchiveEntry In zipArchive.Entries
                    Dim str As String = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream As Stream = entry.Open()
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm()
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm()
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            WebClient.Dispose()
        End Try
    End Sub
    Private Sub WebClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ' Update Label4 with the download progress percentage
        Me.Invoke(Sub()
                      Label4.Text = e.ProgressPercentage.ToString() & "%"
                  End Sub)
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Me.Label1.Text = "لا تغلق التطبيق الا حين ظهور رساله تخبرك بنجاح العمليه"
        Dim address As String = "https://2h.ae/dnDc"
        Dim path1 As String = "C:\Program Files\Adobe\Adobe Photoshop 2023"
        AddHandler webClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data As Byte() = webClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry As ZipArchiveEntry In zipArchive.Entries
                    Dim str As String = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream As Stream = entry.Open()
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm()
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm()
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            webClient.Dispose()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Me.Label1.Text = "لا تغلق التطبيق الا حين ظهور رساله تخبرك بنجاح العمليه"
        Dim address = "https://2h.ae/xhjm"
        Dim path1 = "C:\Program Files\Adobe\Adobe Illustrator 2023\Support Files\Contents\Windows"
        AddHandler webClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data = webClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry In zipArchive.Entries
                    Dim str = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream = entry.Open
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            webClient.Dispose()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim address = "https://2h.ae/FCCv"
        Dim path1 = "C:\Program Files\TechSmith\Camtasia 2022"
        AddHandler webClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data = webClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry In zipArchive.Entries
                    Dim str = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream = entry.Open
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            webClient.Dispose()
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim address = "https://2h.ae/mPKO"
        Dim path1 = "C:\Program Files (x86)\IObit\Driver Booster\11.1.0"
        AddHandler webClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data = webClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry In zipArchive.Entries
                    Dim str = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream = entry.Open
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            webClient.Dispose()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim address As String = "https://2h.ae/lJEE"
        Dim path1 As String = "C:\Program Files (x86)\IObit\Advanced SystemCare"
        AddHandler webClient.DownloadProgressChanged, AddressOf WebClient_DownloadProgressChanged

        Try
            Dim data = webClient.DownloadData(address)
            Using zipArchive As New ZipArchive(New MemoryStream(data))
                For Each entry In zipArchive.Entries
                    Dim str = Path.Combine(path1, entry.FullName)
                    Directory.CreateDirectory(Path.GetDirectoryName(str))
                    Using stream = entry.Open
                        Using fileStream As New FileStream(str, FileMode.Create)
                            stream.CopyTo(fileStream)
                        End Using
                    End Using
                Next
            End Using
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = "تم تفعيل التطبيق بنجاح "
            frmNotify.ShowDialog()
        Catch ex As Exception
            Dim frmNotify As New Halimm
            frmNotify.Label2.Text = String.Format("حدث خطأ: {0}", ex.Message)
            frmNotify.ShowDialog()
        Finally
            webClient.Dispose()
        End Try
    End Sub
End Class