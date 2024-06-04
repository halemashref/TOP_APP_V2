Imports System.Security.AccessControl
Imports System.IO

Module Blockfilee
    Public Sub اخترملف()
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog() = DialogResult.OK Then
            Startup.Label1.Text = fbd.SelectedPath & "\"
            Dim dir As New DirectoryInfo(fbd.SelectedPath)
            If dir.Exists Then
                For Each file As FileInfo In dir.GetFiles()
                    Startup.ListBox1.Items.Add(file.Name)
                Next
            Else
                Halimm.Show()
                Halimm.Label2.Text = "المجلد غير موجود"
            End If
        End If
    End Sub

    Public Sub قفل()
        If Not Directory.Exists(Startup.Label1.Text) Then
            Halimm.Show()
            Halimm.Label2.Text = "المجلد غير موجود"
            Exit Sub
        End If

        Dim dirInfo As New DirectoryInfo(Startup.Label1.Text)
        Dim dirSecurity As DirectorySecurity = dirInfo.GetAccessControl()
        dirSecurity.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        dirInfo.SetAccessControl(dirSecurity)

        Halimm.Show()
        Halimm.Label2.Text = "تم قفل الملف"
    End Sub

    Public Sub فتح()
        If Not Directory.Exists(Startup.Label1.Text) Then
            Halimm.Show()
            Halimm.Label2.Text = "المجلد غير موجود"
            Exit Sub
        End If

        Dim dirInfo As New DirectoryInfo(Startup.Label1.Text)
        Dim dirSecurity As DirectorySecurity = dirInfo.GetAccessControl()
        dirSecurity.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        dirInfo.SetAccessControl(dirSecurity)

        Halimm.Show()
        Halimm.Label2.Text = "تم الغاء قفل الملف بنجاح"
    End Sub

    Private Sub FileSystemWatcher1_Created()
        Startup.ListBox1.Items.Add("تم انشاء:" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم انشاء " & e.FullPath


    End Sub

    Private Sub FileSystemWatcher1_Deleted()
        Startup.ListBox1.Items.Add("تم حذف:" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم حذف ملف " & e.FullPath

    End Sub

    Private Sub FileSystemWatcher1_Disposed()

    End Sub

    Private Sub FileSystemWatcher1_Error()

    End Sub

    Private Sub FileSystemWatcher1_Renamed()
        Startup.ListBox1.Items.Add("تم اعاده تسميه :" & e.FullPath)
        Halimm.Show()
        Halimm.Label2.Text = "تم اعاده تسميه " & e.FullPath

    End Sub

    Dim Setting As New My.MySettings
    Private e As Object

    Public Sub Renametext()

    End Sub
    Public Sub Changedtext()

    End Sub
    Public Sub Delete()

    End Sub
    Public Sub Create()

    End Sub


    Public Sub Filew()
        Dim drivePaths() As String = {"C:\"}

        For Each drivePath As String In drivePaths
            Startup.FileSystemWatcher1.Path = drivePath

            Dim fsw As New FileSystemWatcher With {
            .Path = drivePath,
            .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.FileName,
            .Filter = "*.*"
        }

            AddHandler fsw.Changed, New FileSystemEventHandler(AddressOf Changedtext)
            AddHandler fsw.Renamed, New RenamedEventHandler(AddressOf Renametext)
            AddHandler fsw.Deleted, New FileSystemEventHandler(AddressOf Delete)
            AddHandler fsw.Created, New FileSystemEventHandler(AddressOf Create)

            ' تمكين رفع الأحداث
            fsw.EnableRaisingEvents = True
        Next
    End Sub

    Public Sub Desktop1()
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Startup.FileSystemWatcher1.Path = desktopPath
        ' APPS.TextBox1.Text = desktopPath

        Dim fsw As New FileSystemWatcher With {
        .Path = desktopPath,
        .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.FileName,
        .Filter = "*.txt"
    }

        AddHandler fsw.Changed, New FileSystemEventHandler(AddressOf Changedtext)
        AddHandler fsw.Renamed, New RenamedEventHandler(AddressOf Renametext)
        AddHandler fsw.Deleted, New FileSystemEventHandler(AddressOf Delete)
        AddHandler fsw.Created, New FileSystemEventHandler(AddressOf Create)

        fsw.EnableRaisingEvents = True
    End Sub
    'تعطيل
    Public Sub Filew1()
        Dim drivePath As String = "C:\"

        Startup.FileSystemWatcher1.Path = drivePath
        ' APPS.TextBox1.Text = drivePath

        Dim fsw As New FileSystemWatcher With {
        .Path = drivePath,
        .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.FileName,
        .Filter = "*.txt"
    }

        AddHandler fsw.Changed, New FileSystemEventHandler(AddressOf Changedtext)
        AddHandler fsw.Renamed, New RenamedEventHandler(AddressOf Renametext)
        AddHandler fsw.Deleted, New FileSystemEventHandler(AddressOf Delete)
        AddHandler fsw.Created, New FileSystemEventHandler(AddressOf Create)



        AddHandler fsw.Changed, New FileSystemEventHandler(AddressOf Changedtext)
        AddHandler fsw.Renamed, New RenamedEventHandler(AddressOf Renametext)
        AddHandler fsw.Deleted, New FileSystemEventHandler(AddressOf Delete)
        AddHandler fsw.Created, New FileSystemEventHandler(AddressOf Create)


        fsw.EnableRaisingEvents = False
    End Sub

    Public Sub Desktop2()
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Startup.FileSystemWatcher1.Path = desktopPath
        ' APPS.TextBox1.Text = desktopPath

        Dim fsw As New FileSystemWatcher With {
        .Path = desktopPath,
        .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.FileName,
        .Filter = "*.txt"
    }

        AddHandler fsw.Changed, New FileSystemEventHandler(AddressOf Changedtext)
        AddHandler fsw.Renamed, New RenamedEventHandler(AddressOf Renametext)
        AddHandler fsw.Deleted, New FileSystemEventHandler(AddressOf Delete)
        AddHandler fsw.Created, New FileSystemEventHandler(AddressOf Create)

        fsw.EnableRaisingEvents = False
    End Sub



    Public Sub Usp()


        My.Computer.Registry.LocalMachine.CreateSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub
    Public Sub Usp1()


        My.Computer.Registry.LocalMachine.CreateSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord)
        TopAPP.PictureBox4.Visible = True
        TopAPP.Label7.Visible = True
    End Sub

End Module
