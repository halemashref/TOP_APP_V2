Imports System.Reflection.Emit
Imports Windows.Win32.System

Module Rig
    Dim regKey As Microsoft.Win32.RegistryKey

    Sub ازاله_سهم_الاختصارات()
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icon", True)
        My.Computer.Registry.ClassesRoot.CreateSubKey("Explorer")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", "29", "")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_ازاله_سهم_الاختصارات()
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icon", True)

        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", True).DeleteValue("29")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub عرض_القوائم_اسرع()
        My.Computer.Registry.CurrentUser.CreateSubKey("Control Panel\Desktop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "MenuShowDelay", "100")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_عرض_القوائم_اسرع()
        My.Computer.Registry.CurrentUser.CreateSubKey("Control Panel\Desktop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "MenuShowDelay", "400")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub غلق_الويندوز_اسرع()
        My.Computer.Registry.CurrentUser.CreateSubKey("Control Panel\Desktop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "WaitToKillAppTimeout", "2000 ")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control", "WaitToKillServiceTimeout", "5000 ")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_غلق_الويندوز_اسرع()
        My.Computer.Registry.CurrentUser.CreateSubKey("Control Panel\Desktop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "WaitToKillAppTimeout", "20000 ")
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub تشغيل_الويندوز_اسرع()
        My.Computer.Registry.CurrentUser.CreateSubKey("Serialize")


        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Serialize ", "StartupDelayInMSec  ", 0, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_تشغيل_الويندوز_اسرع()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Serialize ", "StartupDelayInMSec  ", 1, Microsoft.Win32.RegistryValueKind.DWord)

        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub ازاله_شاشه_الترحيب()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Windows")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization", " NoLockScreen", 1, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_ازاله_شاشه_الترحيب()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Windows")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen", 0, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub اخفاء_تطبيقات_سطح_المكتب()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Explorer\Advanced")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideIcons", 1, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub الغاء_اخفاء_تطبيقات_سطح_المكتب()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Explorer\Advanced")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideIcons", 0, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub تطبيق_الاعدادات()
        Try
            Dim processesByName As Process() = Process.GetProcessesByName("explorer")
            For Each proc As Process In processesByName
                proc.Kill()
            Next
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub
    Sub الساعه()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Advanced")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", 1, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Sub ازاله_الساعه()
        My.Computer.Registry.ClassesRoot.CreateSubKey("Advanced")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", 0, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
End Module
