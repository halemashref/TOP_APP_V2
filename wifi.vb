Imports System.Text
Imports System.Windows.Forms

Module wifi
    Sub اختيار()
        If Supervision.ListBox1.SelectedIndex <> -1 Then
            Dim selectedNetwork As String = Supervision.ListBox1.SelectedItem.ToString().Trim()
            Dim password As String = احضار_الباسورد(selectedNetwork)
            Supervision.TextBox1.Text = password
        End If
    End Sub

    Function احضار_الباسورد(networkName As String) As String
        Dim process As New Process()
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "netsh",
            .Arguments = $"wlan show profile name=""{networkName}"" key=clear",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        process.StartInfo = startInfo
        process.Start()

        Dim password As New StringBuilder()

        While Not process.StandardOutput.EndOfStream
            Dim line As String = process.StandardOutput.ReadLine()
            If line.Contains("Key Content") Then
                password.Append(line.Split(":")(1).Trim())
            End If
        End While

        process.WaitForExit()

        Return password.ToString()
    End Function

    Function عرض_الشبكات() As String()
        Dim wifiNetworks As New List(Of String)()

        Dim process As New Process()
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "netsh",
            .Arguments = "wlan show networks mode=SSID",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        process.StartInfo = startInfo
        process.Start()

        While Not process.StandardOutput.EndOfStream
            Dim line As String = process.StandardOutput.ReadLine()
            If line.Contains("SSID") Then
                Dim networkName As String = line.Split(":")(1).Trim()
                wifiNetworks.Add(networkName)
            End If
        End While

        process.WaitForExit()

        Return wifiNetworks.ToArray()
    End Function

    Sub تحديث()
        Try
            Supervision.ListBox1.Items.Clear()

            Dim wifiNetworks As String() = عرض_الشبكات()

            For Each network As String In wifiNetworks
                Supervision.ListBox1.Items.Add($" {network}")
            Next
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub

End Module
