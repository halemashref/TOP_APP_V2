Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Management
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports Windows.Win32.System

Module win10peta
    Sub ازاله_الاشعار()


        Try
            Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", True)
            If regKey IsNot Nothing Then
                regKey.SetValue("Manual", 1, RegistryValueKind.DWord)
                regKey.Close()
            End If



        Catch ex As Exception
        End Try



    End Sub
    Sub نوع_النظام()
        Dim productName As String = GetWindowsProductName()
        Win10.TextBox2.Text = productName
        Win10.TextBox1.Text = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "BackupProductKeyDefault", "")

    End Sub

    Private Function GetWindowsProductKey() As String
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM SoftwareLicensingService")
            For Each queryObj As ManagementObject In searcher.Get()
                Return queryObj("OA3xOriginalProductKey").ToString()
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while querying WMI: " & ex.Message)
        End Try
        Return String.Empty
    End Function


    Private Function GetWindowsProductName() As String
        Dim keyPath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
        Dim valueName As String = "ProductName"
        Dim defaultValue As String = "Windows"

        Try
            Dim productName As Object = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" & keyPath, valueName, defaultValue)

            If productName IsNot Nothing Then
                Return productName.ToString()
            Else
                Return defaultValue
            End If
        Catch ex As Exception
            Return defaultValue
        End Try
    End Function

    Sub ويندوز10برو()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "BackupProductKeyDefault", "VK7JG-NPHTM-C97JM-9MPGT-3V66T")
    End Sub
    Sub كراك()
        Dim downloadsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

        Dim filePath As String = Path.Combine(downloadsPath, "Halim.bat")

        Dim batchContent As String = "@echo off" & Environment.NewLine &
                                     "title Activate Windows 10 (ALL versions) for FREE - MSGuides.com" & Environment.NewLine &
                                     "cls" & Environment.NewLine &
                                     "echo =====================================================================================" & Environment.NewLine &
                                     "echo #Project: Activating Microsoft software products for FREE without additional software" & Environment.NewLine &
                                     "echo =====================================================================================" & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo #Supported products:" & Environment.NewLine &
                                     "echo - Windows 10 Home" & Environment.NewLine &
                                     "echo - Windows 10 Professional" & Environment.NewLine &
                                     "echo - Windows 10 Education" & Environment.NewLine &
                                     "echo - Windows 10 Enterprise" & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "echo Activating your Windows..." & Environment.NewLine &
                                     "cscript //nologo slmgr.vbs /ckms >nul" & Environment.NewLine &
                                     "cscript //nologo slmgr.vbs /upk >nul" & Environment.NewLine &
                                     "cscript //nologo slmgr.vbs /cpky >nul" & Environment.NewLine &
                                     "set i=1" & Environment.NewLine &
                                     "wmic os | findstr /I ""enterprise"" >nul" & Environment.NewLine &
                                     "if %errorlevel% EQU 0 (cscript //nologo slmgr.vbs /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43 >nul||cscript //nologo slmgr.vbs /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 >nul||cscript //nologo slmgr.vbs /ipk YYVX9-NTFWV-6MDM3-9PT4T-4M68B >nul||cscript //nologo slmgr.vbs /ipk 44RPN-FTY23-9VTTB-MP9BX-T84FV >nul||cscript //nologo slmgr.vbs /ipk WNMTR-4C88C-JK8YV-HQ7T2-76DF9 >nul||cscript //nologo slmgr.vbs /ipk 2F77B-TNFGY-69QQF-B8YKP-D69TJ >nul||cscript //nologo slmgr.vbs /ipk DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ >nul||cscript //nologo slmgr.vbs /ipk QFFDN-GRT3P-VKWWX-X7T3R-8B639 >nul||cscript //nologo slmgr.vbs /ipk M7XTQ-FN8P6-TTKYV-9D4CC-J462D >nul||cscript //nologo slmgr.vbs /ipk 92NFX-8DJQP-P6BBQ-THF9C-7CG2H >nul&goto skms) else wmic os | findstr /I ""home"" >nul" & Environment.NewLine &
                                     "if %errorlevel% EQU 0 (cscript //nologo slmgr.vbs /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 >nul||cscript //nologo slmgr.vbs /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM >nul||cscript //nologo slmgr.vbs /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH >nul||cscript //nologo slmgr.vbs /ipk PVMJN-6DFY6-9CCP6-7BKTT-D3WVR >nul&goto skms) else wmic os | findstr /I ""education"" >nul" & Environment.NewLine &
                                     "if %errorlevel% EQU 0 (cscript //nologo slmgr.vbs /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 >nul||cscript //nologo slmgr.vbs /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ >nul&goto skms) else wmic os | findstr /I ""10 pro"" >nul" & Environment.NewLine &
                                     "if %errorlevel% EQU 0 (cscript //nologo slmgr.vbs /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX >nul||cscript //nologo slmgr.vbs /ipk MH37W-N47XK-V7XM9-C7227-GCQG9 >nul||cscript //nologo slmgr.vbs /ipk NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J >nul||cscript //nologo slmgr.vbs /ipk 9FNHH-K3HBT-3W4TD-6383H-6XYWF >nul||cscript //nologo slmgr.vbs /ipk 6TP4R-GNPTD-KYYHQ-7B7DP-J447Y >nul||cscript //nologo slmgr.vbs /ipk YVWGF-BXNMC-HTQYQ-CPQ99-66QFC >nul&goto skms) else (goto notsupported)" & Environment.NewLine &
                                     ":skms" & Environment.NewLine &
                                     "if %i% GTR 10 goto busy" & Environment.NewLine &
                                     "if %i% EQU 1 set KMS=kms7.MSGuides.com" & Environment.NewLine &
                                     "if %i% EQU 2 set KMS=s8.now.im" & Environment.NewLine &
                                     "if %i% EQU 3 set KMS=s9.now.im" & Environment.NewLine &
                                     "if %i% GTR 3 goto ato" & Environment.NewLine &
                                     "cscript //nologo slmgr.vbs /skms %KMS%:1688 >nul" & Environment.NewLine &
                                     ":ato" & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "cscript //nologo slmgr.vbs /ato | find /i ""successfully"" && (echo." & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo #My official blog: MSGuides.com" & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo #How it works: bit.ly/kms-server" & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo #Please feel free to contact me at msguides.com@gmail.com if you have any questions or concerns." & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo #Please consider supporting this project: donate.msguides.com" & Environment.NewLine &
                                     "echo #Your support is helping me keep my servers running 24/7!" & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "choice /n /c YN /m ""Would you like to visit my blog [Y,N]?"" & if errorlevel 2 exit) || (echo The connection to my KMS server failed! Trying to connect to another one... & echo Please wait... & echo. & echo. & set /a i+=1 & goto skms)" & Environment.NewLine &
                                     "explorer ""http://MSGuides.com""&goto halt" & Environment.NewLine &
                                     ":notsupported" & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo Sorry, your version is not supported." & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "goto halt" & Environment.NewLine &
                                     ":busy" & Environment.NewLine &
                                     "echo ============================================================================ " & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     "echo Sorry, the server is busy and can't respond to your request. Please try again." & Environment.NewLine &
                                     "echo." & Environment.NewLine &
                                     ":halt" & Environment.NewLine &
                                     "pause >nul"

        Try
            File.WriteAllText(filePath, batchContent)

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Module
