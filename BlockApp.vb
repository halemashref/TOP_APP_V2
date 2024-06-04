Imports Microsoft.Win32

Public Class BlockApp
    Private labels As New List(Of Label)()
    Public Shared Property Computer As Object

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        حظر()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        فك_الحظر()
    End Sub
    Private Sub LoadRegistryValuesIntoListBox()

        ListBox1.Items.Clear()


        Dim subKeyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"


        Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(subKeyPath)
            If registryKey IsNot Nothing Then

                Dim valueNames As String() = registryKey.GetValueNames()


                For Each valueName As String In valueNames
                    ListBox1.Items.Add(valueName)
                Next
            End If
        End Using


    End Sub
    Private Sub BlockApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ادمين()

        عرض_المحظور()


        labels.Add(Label1)
        labels.Add(Label2)


        For Each lbl As Label In labels
            AddHandler lbl.MouseMove, AddressOf Label_MouseMove
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
        Next
    End Sub

    Private Sub Label_MouseMove(sender As Object, e As MouseEventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Black
    End Sub


End Class