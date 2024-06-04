Imports System.Runtime.InteropServices

Module Gamee
    Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer

    Private Declare Function WriteProcessMemory1 Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function WriteProcessMemory2 Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Single, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Single
    Private Declare Function WriteProcessMemory3 Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Long

    Private Declare Function ReadProcessMemory1 Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemory2 Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Single, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Single
    Private Declare Function ReadProcessMemory3 Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Long

    Const PROCESS_ALL_ACCESS = &H1F0FF


    Sub حليم(ByVal ProcessName As String, ByVal Address As Integer, ByVal Value As Long, Optional ByVal nsize As Integer = 4)
        If ProcessName.EndsWith(".exe") Then
            ProcessName = ProcessName.Replace(".exe", "")
        End If
        Dim MyP As Process() = Process.GetProcessesByName(ProcessName)
        If MyP.Length = 0 Then
            Halimm.Show()
            Halimm.Label2.Text = "التطبيق ليس مفتوح" & ProcessName & "!"

            Exit Sub
        End If
        Dim hProcess As IntPtr = OpenProcess(PROCESS_ALL_ACCESS, 0, MyP(0).Id)
        If hProcess = IntPtr.Zero Then
            Halimm.Show()
            Halimm.Label2.Text = "التطبيق ليس مفتوح" & ProcessName & "!"

            Exit Sub
        End If

        Dim hAddress As Integer
        Dim vBuffer As Long

        hAddress = Address
        vBuffer = Value
        WriteProcessMemory3(hProcess, hAddress, vBuffer, nsize, 0)
    End Sub

    Private Declare Function WriteProcessMemoryLong Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Long, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemoryLong Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Long, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Sub WriteProcessMemoryLongAddress(ByVal hProcess As Integer, ByVal lpBaseAddress As Long, ByVal Value As Long, Optional ByVal nSize As Integer = 4)
        Dim lpNumberOfBytesWritten As Integer
        WriteProcessMemoryLong(hProcess, lpBaseAddress, Value, nSize, lpNumberOfBytesWritten)
    End Sub

    Sub ReadProcessMemoryLongAddress(ByVal hProcess As Integer, ByVal lpBaseAddress As Long, ByRef lpBuffer As Long, ByVal nSize As Integer)
        Dim lpNumberOfBytesRead As Integer
        ReadProcessMemoryLong(hProcess, lpBaseAddress, lpBuffer, nSize, lpNumberOfBytesRead)
    End Sub

    Sub حليم2(ByVal ProcessName As String, ByVal Address As Long, ByVal Value As Long, Optional ByVal nsize As Integer = 4)
        If ProcessName.EndsWith(".exe") Then
            ProcessName = ProcessName.Replace(".exe", "")
        End If
        Dim MyP As Process() = Process.GetProcessesByName(ProcessName)
        If MyP.Length = 0 Then
            Halimm.Show()
            Halimm.Label2.Text = "التطبيق ليس مفتوح" & ProcessName & "!"

            Exit Sub
        End If
        Dim hProcess As IntPtr = OpenProcess(PROCESS_ALL_ACCESS, 0, MyP(0).Id)
        If hProcess = IntPtr.Zero Then
            Halimm.Show()
            Halimm.Label2.Text = "التطبيق ليس مفتوح" & ProcessName & "!"

            Exit Sub
        End If

        WriteProcessMemoryLongAddress(hProcess, Address, Value, nsize)
    End Sub


    Private Const AW_HOR_POSITIVE As Integer = &H1
    Private Const AW_HIDE As Integer = &H10000
    Private Const AW_SLIDE As Integer = &H40000
    Private Const AW_VER_NEGATIVE As Integer = &H8
    Private Const AW_VER_POSITIVE As Integer = &H4

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function AnimateWindow(ByVal hWnd As IntPtr, ByVal dwTime As Integer, ByVal dwFlags As Integer) As Boolean
    End Function
End Module
