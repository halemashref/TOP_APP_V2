Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Security.Principal
Imports Microsoft.Win32
Imports IWshRuntimeLibrary

Module Halim_Dev
    Dim halim As Boolean
    Private strEncryptedText As Object
    Private st1 As String
    Private as1 As Integer
    Private ch1 As Char
    Private st As Object
    'تشفير النصوص
    Sub تشفير1()
        Dim all As String = Nasos.TextBox1.Text
        Nasos.TextBox1.Clear()
        If halim = False Then
            Dim t As String = ""
            For Each h As String In all
                t &= Convert.ToInt32(Convert.ToChar(h)) & "|"
            Next
            Nasos.TextBox1.Text = t
            halim = True
        ElseIf halim = True Then
            Dim t As String = ""
            For Each h As String In all.Split("|")
                If Trim(h.Trim).ToString.Trim <> "" Then
                    Dim c As Char = Convert.ToChar(Convert.ToInt32(h))
                    t &= c
                End If
            Next
            Nasos.TextBox1.Text = t
            halim = False
        End If
    End Sub
    Sub تشفير2()


        Dim text As String = Nasos.TextBox1.Text

        If Nasos.Label1.Text = "XOR" Then
            Nasos.TextBox1.Text = Encrypt(text)
        Else
            Nasos.TextBox1.Text = Decrypt(text)
        End If
    End Sub

    Private Function Encrypt(text As String) As String
        Dim str1 As String = ""
        For Each ch As Char In text
            str1 &= ChrW(AscW(ch) Xor 5)
        Next
        Return str1
    End Function

    Private Function Decrypt(text As String) As String
        Return Encrypt(text)
    End Function
    'تنقل الفورم
    Public Sub فورم_صغير(ByRef frm As Form)
        TopAPP.Panel2.Controls.Clear()
        frm.TopLevel = False
        TopAPP.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub
    Public Sub فورم_كبير(ByRef frm As Form)
        TopAPP.Panel1.Controls.Clear()
        frm.TopLevel = False
        TopAPP.Panel1.Controls.Add(frm)
        frm.Show()
    End Sub
    'فتح التطبيق مع اعاده التشغيل
    Sub اعاده_تشغيل_التطبيق()
        ' Dim taskService As New TaskService()
        ' Dim applicationPath As String = Application.ExecutablePath
        ' Dim taskDefinition As TaskDefinition = taskService.NewTask()
        ' TaskDefinition.RegistrationInfo.Description = "TOPAPP"
        ' TaskDefinition.Triggers.Add(New LogonTrigger())
        ' TaskDefinition.Principal.RunLevel = TaskRunLevel.Highest
        ' TaskDefinition.Actions.Add(New ExecAction(applicationPath))
        ' TaskService.RootFolder.RegisterTaskDefinition("TOPAPP", taskDefinition)
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        For Each item In regKey.GetValueNames
            If item = "TOP APP" Then
                Halimm.Show()
                Halimm.Label2.Text = " البرنامج موجود بالفعل ضمن برامج بدء التشغيل التلقائي للنظام"

                regKey.Close()
                Exit Sub
            End If
        Next
        regKey.SetValue("TOP APP", Application.ExecutablePath)
        regKey.Close()
        Halimm.Show()
        Halimm.Label2.Text = " تم إضافة البرنامج إلى برامج بدء التشغيل التلقائي للنظام"

    End Sub
    Sub الغاء_تشغيل_التطبيق()
        ' Dim taskService As New TaskService()
        ' TaskService.RootFolder.DeleteTask("TOP APP", False)


        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

        For Each item In regKey.GetValueNames
            If item = "TOP APP" Then
                regKey.DeleteValue("TOP APP")
                Halimm.Show()
                Halimm.Label2.Text = "تم إزالة البرنامج من برامج بدء التشغيل التلقائي للنظام"
                regKey.Close()
                Exit Sub
            End If
        Next

        Halimm.Show()
        Halimm.Label2.Text = "البرنامج غير موجود في برامج بدء التشغيل التلقائي للنظام"
        regKey.Close()



    End Sub
    'علي سطح المكتب TOP APP تثبت
    Sub تثبيت_التطبيق_علي_سطح_المكتب()
        Dim appPath As String = Application.ExecutablePath

        CreateShortcut(appPath, "TOP APP")
    End Sub


    Sub ازاله_التطبيق_علي_سطح_المكتب()
        DeleteShortcut("TOP APP")

    End Sub
    Private Sub CreateShortcut(targetPath As String, shortcutName As String)
        Try
            Dim shell As New WshShell()
            Dim shortcut As IWshShortcut = DirectCast(shell.CreateShortcut(
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\{shortcutName}.lnk"), IWshShortcut)
            shortcut.TargetPath = targetPath
            shortcut.Save()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DeleteShortcut(shortcutName As String)
        Try
            Dim shortcutPath As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\{shortcutName}.lnk"

            If IO.File.Exists(shortcutPath) Then
                IO.File.Delete(shortcutPath)
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub
    'جعل التطبيق شفاف
    Sub شفاف()
        TopAPP.Opacity = 0.7

    End Sub
    Sub الغاء_شفاف()
        TopAPP.Opacity = 100.15

    End Sub
    'معلومات الجهاز
    Sub معلومات_الجهاز()
        Try
            Info.ListBox1.Items.Add("اسم المستخدم: " & Environment.UserName)
            Info.ListBox1.Items.Add("اسم الجهاز: " & GetComputerManufacturer())
            Info.ListBox1.Items.Add("المعالج: " & GetProcessorName())
            Info.ListBox1.Items.Add("نوع النظام: " & My.Computer.Info.OSFullName)
            Info.ListBox1.Items.Add("تاريخ التثبيت: " & GetSystemInstallDate())

            Info.ListBox1.Items.Add("إصدار الويندوز: " & My.Computer.Info.OSVersion)

            DisplayRAMSize()
            DisplayHardDriveInfo()
            DisplayRAMSize()
            DisplayBatteryInformation()
            DisplayScreenInformation()

        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ: " & ex.Message)
        End Try
    End Sub
    Private Sub DisplayBatteryInformation()
        Try
            If System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Offline Then
                Dim batteryPercent As Integer = CInt(System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100)
                Dim batteryState As BatteryChargeStatus = System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus

                Info.ListBox1.Items.Add("حالة البطارية: " & batteryState.ToString())
                Info.ListBox1.Items.Add("نسبة الشحن: " & batteryPercent.ToString() & "%")
            Else
                Info.ListBox1.Items.Add("الجهاز متصل بالكهرباء.")
            End If
        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ في عرض معلومات البطارية: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayScreenInformation()
        Try
            Dim primaryScreen As Screen = Screen.PrimaryScreen
            Info.ListBox1.Items.Add("دقة الشاشة الأساسية: " & primaryScreen.Bounds.Width.ToString() & "x" & primaryScreen.Bounds.Height.ToString())
            Info.ListBox1.Items.Add("اسم الشاشة الأساسية: " & primaryScreen.DeviceName)
        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ في عرض معلومات الشاشة: " & ex.Message)
        End Try
    End Sub

    Private Function GetComputerManufacturer() As String
        Dim manufacturer As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
            For Each queryObj As ManagementObject In searcher.Get()
                manufacturer = queryObj("Manufacturer").ToString()
            Next
        Catch ex As ManagementException
            manufacturer = "غير متوفر"
        End Try
        Return manufacturer
    End Function


    Private Sub DisplayHardDriveInfo()
        Try
            Dim drives As DriveInfo() = DriveInfo.GetDrives()
            For Each drive As DriveInfo In drives
                If drive.IsReady Then
                    Info.ListBox1.Items.Add("نوع الهارد " & drive.Name & ": " & drive.DriveFormat)
                    Info.ListBox1.Items.Add("مساحة الهارد " & drive.Name & ": " & FormatBytes(drive.TotalSize))
                End If
            Next
        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ في عرض معلومات الهارد ديسك: " & ex.Message)
        End Try
    End Sub

    Private Function GetProcessorName() As String
        Dim result As String

        Try
            result = My.Computer.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString").ToString()
            If String.IsNullOrEmpty(result) Then
                result = "غير متوفر"
            End If
        Catch ex As Exception
            result = "غير متوفر"
        End Try

        Return result
    End Function

    Private Function FormatBytes(bytes As Long) As String
        Dim sizes() As String = {"B", "KB", "MB", "GB", "TB"}
        Dim sizeIndex As Integer = 0

        While bytes > 1024 And sizeIndex < sizes.Length - 1
            bytes /= 1024
            sizeIndex += 1
        End While

        If sizes(sizeIndex) = "GB" Then
            Return bytes.ToString("F2") & " " & sizes(sizeIndex)
        Else
            Return (bytes / 1024).ToString("F2") & " " & sizes(sizeIndex + 1)
        End If
    End Function

    Private Function GetSystemInstallDate() As String
        Dim installDate As String = "غير متوفر"

        Try
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim rawInstallDate As String = queryObj("InstallDate").ToString()
                If rawInstallDate.Length >= 14 Then
                    Dim year As Integer = Convert.ToInt32(rawInstallDate.Substring(0, 4))
                    Dim month As Integer = Convert.ToInt32(rawInstallDate.Substring(4, 2))
                    Dim day As Integer = Convert.ToInt32(rawInstallDate.Substring(6, 2))
                    Dim hour As Integer = Convert.ToInt32(rawInstallDate.Substring(8, 2))
                    Dim minute As Integer = Convert.ToInt32(rawInstallDate.Substring(10, 2))
                    Dim second As Integer = Convert.ToInt32(rawInstallDate.Substring(12, 2))

                    Dim installDateTime As New DateTime(year, month, day, hour, minute, second, DateTimeKind.Local)
                    installDate = installDateTime.ToString("dd/MM/yyyy HH:mm:ss")
                End If
            Next
        Catch ex As Exception
            installDate = "غير متوفر"
        End Try

        Return installDate
    End Function



    Private Sub DisplaySystemUptime()
        Try
            Dim uptime As TimeSpan = TimeSpan.FromMilliseconds(Environment.TickCount)
            Info.ListBox1.Items.Add("مدة تشغيل الجهاز: " & FormatTimeSpan(uptime))
        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ في عرض مدة تشغيل الجهاز: " & ex.Message)
        End Try
    End Sub

    Private Function FormatTimeSpan(timeSpan As TimeSpan) As String
        Dim formattedTime As String = $"{timeSpan.Days} يوم، {timeSpan.Hours} ساعة، {timeSpan.Minutes} دقيقة، {timeSpan.Seconds} ثانية"
        Return formattedTime
    End Function

    Private Sub DisplayRAMSize()
        Try
            Dim RAMSizeInBytes As Long = My.Computer.Info.TotalPhysicalMemory
            Dim RAMSizeInGB As Double = RAMSizeInBytes / (1024 ^ 3)

            Info.ListBox1.Items.Add("حجم الذاكرة العشوائية (RAM): " & RAMSizeInGB.ToString("0.##") & " جيجابايت")
        Catch ex As Exception
            Info.ListBox1.Items.Add("حدث خطأ: " & ex.Message)
        End Try
    End Sub
    Sub حفظ_معلومات_الجهاز()
        Try
            Dim saveFileDialog As New SaveFileDialog With {
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                .Filter = "ملفات نصية (*.txt)|*.txt",
                .FileName = System.Environment.UserName & "_info.txt"
            }

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    For Each item As Object In Info.ListBox1.Items
                        writer.WriteLine(item.ToString())
                    Next
                End Using
                Halimm.Show()
                Halimm.Label2.Text = "تم حفظ المعلومات بنجاح"

            End If
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء حفظ الملف: " & ex.Message
        End Try
    End Sub

    Private Const AW_HOR_POSITIVE As Integer = &H1
    Private Const AW_HIDE As Integer = &H10000
    Private Const AW_SLIDE As Integer = &H40000
    Private Const AW_VER_NEGATIVE As Integer = &H8
    Private Const AW_VER_POSITIVE As Integer = &H4

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function AnimateWindow(ByVal hWnd As IntPtr, ByVal dwTime As Integer, ByVal dwFlags As Integer) As Boolean
    End Function

    Sub اخفاء_الفورم()
        Dim time As Integer = 200
        Dim flags As Integer = AW_SLIDE Or AW_VER_NEGATIVE Or AW_HIDE
        AnimateWindow(TopAPP.Handle, time, flags)
        TopAPP.WindowState = FormWindowState.Minimized
    End Sub
    Sub ادمين()
        Dim Identity = WindowsIdentity.GetCurrent
        Dim Principal = New WindowsPrincipal(Identity)
        Dim isElevated As Boolean =
            Principal.IsInRole(WindowsBuiltInRole.Administrator)
        If Not isElevated Then
            Dim StartInfo As New ProcessStartInfo With {
                .UseShellExecute = True,
                .WorkingDirectory = Environment.CurrentDirectory,
                .FileName = Application.ExecutablePath,
                .Verb = "runas"
            }
            Try
                Dim p As Process = Process.Start(StartInfo)
            Catch ex As Exception
                Return
            End Try
            Application.Exit()
        End If
    End Sub
    'اختصارات اوامر
    Sub مفتاح_الويندوز()
        Halimm.Show()
        Halimm.Label2.Text = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "BackupProductKeyDefault", "")
    End Sub
    Sub فحص_النظام()
        Shell("cmd.exe /c sfc /scannow")
    End Sub

    Sub ترتيب_الملفات()
        Shell("cmd.exe /c defrag ")

    End Sub
    Sub اصلاح_صوره_النظام()
        Shell("cmd.exe /c dism /online /cleanup-image /restorehealth ")

    End Sub
    Sub فحص_اخطاء_القرص()
        Shell("cmd.exe /c chkdsk /f")

    End Sub
    Sub اصلاح_مشاكل_بدء_التشغيل()
        Shell("cmd.exe /c bootrec /rebuildbcd & bootrec /fixmbr & bootrec /fixboot ")

    End Sub
    Sub اعاده_بناء_فهرس_الخدمه()
        Shell("cmd.exe /c netsh winsock reset")

    End Sub
    Sub اعاده_تعيين_خيارات_الطاقه()
        Shell("cmd.exe /c powercfg -restoredefaultschemes")

    End Sub
    Sub تحديث_التراخيص_والاذونات()
        Shell("cmd.exe /c icacls ""C:\path\to\folder"" /reset /t /c /q")

    End Sub
    Sub اصلاح_مشاكل_النظام_في_وضع_الامان()
        Shell("cmd.exe /c bcdedit /set {default} safeboot minimal")

    End Sub
    Sub اعاده_تسجيل_الخدمات()
        Shell("cmd.exe /c netsh winsock reset catalog")

    End Sub
    Sub اعاده_بناء_فهرس_البحث()
        Shell("cmd.exe /c esentutl /k %windir%\System32\catroot2\{F750E6C3-38EE-11D1-85E5-00C04FC295EE}\catdb")

    End Sub
    Sub اصلاح_ملفات_DLL()
        Shell("cmd.exe /c for %1 in (%windir%\system32\*.dll) do regsvr32.exe /s %1")

    End Sub
    Sub اصلاح_مشاكل_الصوت()
        Shell("cmd.exe /c net stop AudioSrv & net stop AudioEndpointBuilder & net start AudioSrv & net start AudioEndpointBuilder")

    End Sub
    Sub اصلاح_مشاكل_الشبكه()
        Shell("cmd.exe /c ipconfig /release & ipconfig /renew")

    End Sub
    Sub اصلاح_خدمه_WindowsUpdate()
        Shell("cmd.exe /c net stop wuauserv & net stop cryptSvc & net stop bits & net stop msiserver & Ren C:\Windows\SoftwareDistribution SoftwareDistribution.old & Ren C:\Windows\System32\catroot2 catroot2.old & net start wuauserv & net start cryptSvc & net start bits & net start msiserver ")

    End Sub
    Sub الخروج_من_وضع_الامان()
        Shell("cmd.exe /c start shell:AppsFolder\\40210ChrisAndriessen.FalconX_y1dazs5f5wq00!TaskbarXGUI")

    End Sub

    'تسك بار
    Friend Structure WindowCompositionAttributeData
        Public Attribute As WindowCompositionAttribute
        Public Data As IntPtr
        Public SizeOfData As Integer
    End Structure

    Friend Enum WindowCompositionAttribute
        WCA_ACCENT_POLICY = 19
    End Enum

    Friend Enum AccentState
        ACCENT_DISABLED = 0
        ACCENT_ENABLE_GRADIENT = 1
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2
        ACCENT_ENABLE_BLURBEHIND = 3
        ACCENT_ENABLE_TRANSPARANT = 6
        ACCENT_ENABLE_ACRYLICBLURBEHIND = 4
    End Enum

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure AccentPolicy
        Public AccentState As AccentState
        Public AccentFlags As Integer
        Public GradientColor As Integer
        Public AnimationId As Integer
    End Structure

    Friend Declare Function SetWindowCompositionAttribute Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef data As WindowCompositionAttributeData) As Integer
    Private Declare Auto Function FindWindow Lib "user32.dll" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr



    Sub تاسك_ضباب()
        Dim tskBarClassName As String = "Shell_TrayWnd"
        Dim tskBarHwnd As IntPtr = FindWindow(tskBarClassName, Nothing)
        Dim accent = New AccentPolicy()
        Dim accentStructSize = Marshal.SizeOf(accent)
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND



        Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)
        Dim data = New WindowCompositionAttributeData()
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
        data.SizeOfData = accentStructSize
        data.Data = accentPtr
        SetWindowCompositionAttribute(tskBarHwnd, data)
        Marshal.FreeHGlobal(accentPtr)
    End Sub
    Sub تاسك_شفاف()
        Dim tskBarClassName As String = "Shell_TrayWnd"
        Dim tskBarHwnd As IntPtr = FindWindow(tskBarClassName, Nothing)
        Dim accent = New AccentPolicy()
        Dim accentStructSize = Marshal.SizeOf(accent)

        accent.AccentState = AccentState.ACCENT_ENABLE_TRANSPARANT

        Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)
        Dim data = New WindowCompositionAttributeData()
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
        data.SizeOfData = accentStructSize
        data.Data = accentPtr
        SetWindowCompositionAttribute(tskBarHwnd, data)
        Marshal.FreeHGlobal(accentPtr)
    End Sub
    Sub اتبع_لون_الخلفيه()
        Dim tskBarClassName As String = "Shell_TrayWnd"
        Dim tskBarHwnd As IntPtr = FindWindow(tskBarClassName, Nothing)
        Dim accent = New AccentPolicy()
        Dim accentStructSize = Marshal.SizeOf(accent)


        accent.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND

        Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)
        Dim data = New WindowCompositionAttributeData()
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
        data.SizeOfData = accentStructSize
        data.Data = accentPtr
        SetWindowCompositionAttribute(tskBarHwnd, data)
        Marshal.FreeHGlobal(accentPtr)


    End Sub

    Private Declare Function FindWindow1 Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    Private Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Declare Function ShowWindow Lib "user32" (ByVal hWnd As Long, ByVal nCmdShow As Long) As Long
    Private Const SWP_NOSIZE = &H1
    Private Const SWP_NOMOVE = &H2
    Private Const SWP_NOZORDER = &H4
    Private Const SWP_FRAMECHANGED = &H20
    Private Const SWP_SHOWWINDOW = &H40
    Private Const SWP_HIDEWINDOW = &H80
    '

    Public Sub تاسك_اخفاء()
        Dim TaskBarhWnd As Long
        Dim StartButtonhWnd As Long
        Dim l As Long
        '
        TaskBarhWnd = FindWindow1("Shell_TrayWnd", "")
        l = SetWindowPos(TaskBarhWnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW)
        l = ShowWindow(TaskBarhWnd, SWP_HIDEWINDOW)
        StartButtonhWnd = FindWindow1(vbNullString, "Start")
        l = SetWindowPos(StartButtonhWnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW)
        l = ShowWindow(StartButtonhWnd, SWP_HIDEWINDOW)
    End Sub

    Public Sub تاسك_اظهار()
        Dim TaskBarhWnd As Long
        Dim StartButtonhWnd As Long
        Dim l As Long
        '
        TaskBarhWnd = FindWindow1("Shell_TrayWnd", "")
        l = SetWindowPos(TaskBarhWnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW)
        l = ShowWindow(TaskBarhWnd, SWP_SHOWWINDOW)
        l = SetWindowPos(TaskBarhWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED)
        StartButtonhWnd = FindWindow1(vbNullString, "Start")
        l = SetWindowPos(StartButtonhWnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW)
        l = ShowWindow(StartButtonhWnd, SWP_SHOWWINDOW)
        l = SetWindowPos(StartButtonhWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED)
    End Sub

    Declare Function FindWindowEx1 Lib "user32.dll" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Declare Function SetWindowPos1 Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Boolean

    Const SWP_NOZORDER1 As Integer = &H4
    Const SWP_NOSIZE1 As Integer = &H1
    Sub اخفاء_ايقونات_النظام()
        Dim taskbarHandle As IntPtr
        Dim trayHandle As IntPtr

        taskbarHandle = FindWindowEx1(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", vbNullString)

        trayHandle = FindWindowEx1(taskbarHandle, IntPtr.Zero, "TrayNotifyWnd", vbNullString)

        If Not trayHandle.Equals(IntPtr.Zero) Then
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim trayWidth As Integer = Screen.FromHandle(trayHandle).Bounds.Width
            Dim newLeft As Integer = (screenWidth - trayWidth) \ 2

            SetWindowPos(trayHandle, IntPtr.Zero, newLeft, 0, 0, 0, SWP_NOZORDER1 Or SWP_NOSIZE1)
        Else
            MessageBox.Show("لم يتم العثور على شريط الأيقونات.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Sub الغاء_اخفاء_ايقونات_النظام()
        Dim trayHandle As IntPtr = FindWindowEx1(FindWindowEx1(0, 0, "Shell_TrayWnd", vbNullString), 0, "TrayNotifyWnd", vbNullString)

        If Not trayHandle.Equals(IntPtr.Zero) Then
            ' Reset the position to the default
            SetWindowPos(trayHandle, 0, 0, 0, 0, 0, SWP_NOZORDER1 Or SWP_NOSIZE1)
        Else
            MessageBox.Show("لم يتم العثور على شريط الأيقونات.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub






    'النصووص
    Sub اخترملف()

    End Sub
    'حظر التطبيقات
    Private Sub LoadRegistryValuesIntoListBox()

        BlockApp.ListBox1.Items.Clear()


        Dim subKeyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"


        Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(subKeyPath)
            If registryKey IsNot Nothing Then

                Dim valueNames As String() = registryKey.GetValueNames()


                For Each valueName As String In valueNames
                    BlockApp.ListBox1.Items.Add(valueName)
                Next
            End If
        End Using
    End Sub


    Sub حظر()
        Dim str As String = BlockApp.TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(str) Then
            Try
                Dim subKeyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"
                Registry.SetValue("HKEY_CURRENT_USER\" & subKeyPath, str, str, RegistryValueKind.String)

                Halimm.Show()
                Halimm.Label2.Text = "تم حظر '" & str & "' بنجاح"



                LoadRegistryValuesIntoListBox()

            Catch ex As Exception

                Halimm.Show()
                Halimm.Label2.Text = "حدث خطأ: " & ex.Message
            End Try
        Else
            Halimm.Show()
            Halimm.Label2.Text = "الرجاء إدخال قيمة صحيحة في مربع النص"
        End If
    End Sub

    Sub فك_الحظر()
        If BlockApp.ListBox1.SelectedIndex >= 0 Then

            Dim selectedValue As String = BlockApp.ListBox1.SelectedItem.ToString()


            Try
                Dim subKeyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"
                Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(subKeyPath, True)
                    If registryKey IsNot Nothing Then
                        registryKey.DeleteValue(selectedValue)
                        Halimm.Show()
                        Halimm.Label2.Text = "تم فك الحظر  '" & selectedValue & "' بنجاح"

                        LoadRegistryValuesIntoListBox()
                    End If
                End Using
            Catch ex As Exception
                Halimm.Show()
                Halimm.Label2.Text = "حدث خطأ: " & ex.Message
            End Try
        Else
            Halimm.Show()
            Halimm.Label2.Text = "الرجاء اختيار التطبيق "
        End If
    End Sub
    Sub عرض_المحظور()
        My.Computer.Registry.CurrentUser.CreateSubKey("Advanced")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "DisallowRun", CObj(1), Microsoft.Win32.RegistryValueKind.DWord)

        LoadRegistryValuesIntoListBox()
    End Sub

    'تغير ايقونه المجلدات
    Private iconPath As String
    Private folderPath As String
    Sub اختر_مجلد_الايقونه()

        If Foldericon.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            folderPath = Foldericon.FolderBrowserDialog1.SelectedPath
            Foldericon.Label1.Text = folderPath
        End If
    End Sub




    'تنظيف الهارد
    Sub تنظيف_temp()

        Dim userName As String = Environment.UserName
        Dim tempFolderPath As String = Path.Combine("C:\Users", userName, "AppData\Local\Temp")

        Try

            For Each filePath As String In Directory.GetFiles(tempFolderPath)
                Try
                    IO.File.Delete(filePath)
                Catch exFile As Exception

                End Try
            Next


            For Each folderPath As String In Directory.GetDirectories(tempFolderPath)
                Try
                    Directory.Delete(folderPath, True)
                Catch exFolder As Exception

                End Try
            Next
            Halimm.Show()
            Halimm.Label2.Text = "تم حذف الملفات والمجلدات بنجاح من مجلد Temp"

        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف الملفات والمجلدات: " & ex.Message
        End Try

    End Sub
    Sub تنظيفtemp2()

        Try
            For Each filePath As String In Directory.GetFiles(folderPath)
                Try
                    Dim file As New FileInfo(filePath)
                    If file.Exists AndAlso Not IsFileLocked(filePath) Then
                        file.Delete()
                    End If
                Catch exFile As Exception
                End Try
            Next

            Halimm.Show()
            Halimm.Label2.Text = "تم حذف الملفات بنجاح من مجلد Temp!"
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف الملفات: " & ex.Message
        End Try

    End Sub


    Private Function IsFileLocked(filePath As String) As Boolean
        Dim fileStream As FileStream = Nothing
        Try
            fileStream = IO.File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
        Catch generatedExceptionName As IOException
            Return True
        Finally
            fileStream?.Close()
        End Try
        Return False
    End Function
    Public Sub تنظيف_ملفات_المتصفحات(browserName As String)
        If String.IsNullOrEmpty(browserName) Then
            Console.WriteLine("الاسم يجب ألا يكون فارغًا.")
            Return
        End If

        Dim cachePath As String = Nothing
        Dim cookiesPath As String = Nothing
        Dim historyPath As String = Nothing
        Dim sessionsPath As String = Nothing
        Dim searchHistoryPath As String = Nothing

        Select Case browserName.ToLower()
            Case "chrome"
                Dim basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\Chrome\User Data\Default")
                cachePath = Path.Combine(basePath, "Cache")
                cookiesPath = Path.Combine(basePath, "Cookies")
                historyPath = Path.Combine(basePath, "History")
                sessionsPath = Path.Combine(basePath, "Sessions")
                searchHistoryPath = historyPath

            Case "edge"
                Dim basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\Edge\User Data\Default")
                cachePath = Path.Combine(basePath, "Cache")
                cookiesPath = Path.Combine(basePath, "Cookies")
                historyPath = Path.Combine(basePath, "History")
                sessionsPath = Path.Combine(basePath, "Sessions")
                searchHistoryPath = historyPath

            Case "opera"
                Dim basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Opera Software\Opera Stable")
                cachePath = Path.Combine(basePath, "Cache")
                cookiesPath = Path.Combine(basePath, "Cookies")
                historyPath = Path.Combine(basePath, "History")
                sessionsPath = Path.Combine(basePath, "Sessions")
                searchHistoryPath = historyPath

            Case "firefox"
                Dim profilePath = GetFirefoxProfilePath()
                If Not String.IsNullOrEmpty(profilePath) Then
                    cachePath = Path.Combine(profilePath, "cache2\entries")
                    cookiesPath = Path.Combine(profilePath, "cookies.sqlite")
                    historyPath = Path.Combine(profilePath, "places.sqlite")
                    sessionsPath = Path.Combine(profilePath, "sessionstore.jsonlz4")
                    searchHistoryPath = Path.Combine(profilePath, "places.sqlite")
                End If

            Case "tor"
                Dim torPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tor Browser\Browser")
                cachePath = Path.Combine(torPath, "Cache")
                cookiesPath = Path.Combine(torPath, "Cookies")
                historyPath = Path.Combine(torPath, "History")
                sessionsPath = Path.Combine(torPath, "Sessions")
                searchHistoryPath = Path.Combine(torPath, "History")

            Case Else
                Console.WriteLine("متصفح غير معروف.")
                Return
        End Select

        Dim pathsToDelete As New List(Of String) From {cachePath, cookiesPath, historyPath, sessionsPath, searchHistoryPath}

        For Each path In pathsToDelete
            Try
                If Not String.IsNullOrEmpty(path) Then
                    DeleteDataAtPath(path)
                End If
            Catch ex As Exception
                Console.WriteLine($"Error deleting data at {path}: {ex.Message}")
            End Try
        Next
    End Sub

    Private Function GetFirefoxProfilePath() As String
        Dim profilesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\Firefox\Profiles")
        If Directory.Exists(profilesPath) Then
            Dim profiles = Directory.GetDirectories(profilesPath)
            If profiles.Length > 0 Then
                Return profiles(0)
            End If
        End If
        Return Nothing
    End Function

    Private Sub DeleteDataAtPath(path As String)
        If Not String.IsNullOrEmpty(path) Then
            If Directory.Exists(path) Then
                For Each file In Directory.GetFiles(path)
                    IO.File.Delete(file)
                Next
                For Each directoryPath In Directory.GetDirectories(path)
                    Try
                        Directory.Delete(directoryPath, True)
                    Catch ex As Exception
                        Console.WriteLine($"خطأ أثناء حذف المجلد: {ex.Message}")
                    End Try
                Next

            ElseIf IO.File.Exists(path) Then
                IO.File.Delete(path)
            End If
        End If
        Halimm.Show()
        Halimm.Label2.Text = "تم تنظيف المتصفحات من الكويكز والبيانات"
    End Sub


    Sub تنظيف_الريجستري()
        Dim reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Run", True)

        If reg IsNot Nothing Then
            Dim valueNames As String() = reg.GetValueNames()

            For Each valueName As String In valueNames
                reg.DeleteValue(valueName)
            Next
        End If

        reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", True)

        If reg IsNot Nothing Then
            Dim valueNames As String() = reg.GetValueNames()

            For Each valueName As String In valueNames
                reg.DeleteValue(valueName)
            Next
            Halimm.Show()
            Halimm.Label2.Text = "تم تنظيف الريجستري"
        End If
    End Sub
    Sub تنظيف_ملفات_البرامج_المؤقته()
        Dim tempPath As String = System.IO.Path.GetTempPath()
        Dim folders As String() = System.IO.Directory.GetDirectories(tempPath, "*.*", System.IO.SearchOption.TopDirectoryOnly)

        For Each folder As String In folders
            If Not folder.Contains("System Volume Information") Then
                System.IO.Directory.Delete(folder, True)
            End If
        Next
    End Sub
    Private Function IsFileLocked(file As FileInfo) As Boolean
        Try
            Using stream As FileStream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)

                stream.Close()
            End Using
            Return False
        Catch

            Return True
        End Try
    End Function
    <DllImport("shell32.dll")>
    Private Function SHEmptyRecycleBin(ByVal hwnd As IntPtr, ByVal pszRootPath As String, ByVal dwFlags As Integer) As Integer

    End Function
    Sub تنظيف_السله()
        Try

            Dim result As Integer = SHEmptyRecycleBin(IntPtr.Zero, Nothing, &H1)

            If result = 0 Then
                Halimm.Show()
                Halimm.Label2.Text = "تم حذف سلة المهملات بنجاح!"
            Else
                Halimm.Show()
                Halimm.Label2.Text = "فشل في حذف سلة المهملات"
            End If
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء حذف سلة المهملات: " & ex.Message
        End Try
    End Sub

    Sub حذف_التنزيلات()
        Try
            Dim downloadsFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

            If Directory.Exists(downloadsFolderPath) Then
                For Each filePath As String In Directory.GetFiles(downloadsFolderPath)
                    IO.File.Delete(filePath)
                Next

                For Each folderPath As String In Directory.GetDirectories(downloadsFolderPath)
                    Directory.Delete(folderPath, True)
                Next

                Halimm.Show()
                Halimm.Label2.Text = "تم حذف محتويات مجلد التنزيلات بنجاح!"
            Else
                Halimm.Show()
                Halimm.Label2.Text = "لا يوجد مجلد التنزيلات."
            End If
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف محتويات مجلد التنزيلات: " & ex.Message
        End Try
    End Sub

    Sub حذف_الكويكز()
        Try
            Dim cookiesFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Cookies)

            If Directory.Exists(cookiesFolderPath) Then
                For Each filePath As String In Directory.GetFiles(cookiesFolderPath)
                    IO.File.Delete(filePath)
                Next

                Halimm.Show()
                Halimm.Label2.Text = "تم حذف جميع ملفات الكوكيز بنجاح!"
            Else
                Halimm.Show()
                Halimm.Label2.Text = "لا يوجد مجلد الكوكيز."
            End If
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف ملفات الكوكيز: " & ex.Message
        End Try
    End Sub
    Sub حذف_الكويكز2()
        Dim browsersDataPaths As New Dictionary(Of String, String) From {
           {"Chrome", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\Chrome\User Data")},
           {"Edge", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\Edge\User Data")},
           {"Firefox", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\Firefox\Profiles")},
           {"Opera", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\Opera Stable")}
       }


        Try

            Dim cookiesFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Cookies)
            If Directory.Exists(cookiesFolderPath) Then
                For Each cookieFile As String In Directory.GetFiles(cookiesFolderPath)
                    IO.File.Delete(cookieFile)
                Next
            End If


            For Each browser In browsersDataPaths
                Dim browserName As String = browser.Key
                Dim browserPath As String = browser.Value

                If Directory.Exists(browserPath) Then
                    For Each profilePath As String In Directory.GetDirectories(browserPath)
                        Dim cacheFolderPath As String = Path.Combine(profilePath, "Cache")

                        If Directory.Exists(cacheFolderPath) Then
                            For Each browserFile As String In Directory.GetFiles(cacheFolderPath)
                                IO.File.Delete(browserFile)
                            Next
                        End If
                    Next
                End If
            Next

            Halimm.Show()
            Halimm.Label2.Text = "تم حذف ملفات الكوكيز وبيانات المتصفحات بنجاح!"
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف ملفات الكوكيز وبيانات المتصفحات: " & ex.Message
        End Try
    End Sub
    Sub حذف_محفوظات_التحديثات()
        Try
            Dim processStartInfo As New ProcessStartInfo With {
                .FileName = "cleanmgr.exe",
                .Arguments = "/sagerun:1"
            }
            Process.Start(processStartInfo).WaitForExit()

            Halimm.Show()
            Halimm.Label2.Text = "تم حذف محفوظات التحديثات بنجاح!"
        Catch ex As Exception
            Halimm.Show()
            Halimm.Label2.Text = "حدث خطأ أثناء محاولة حذف محفوظات التحديثات: " & ex.Message
        End Try
    End Sub
    Sub عرض_معلومات_الهارد()

    End Sub

    'تامين الملفات

End Module
