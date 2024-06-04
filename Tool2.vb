Imports System.Security.Claims
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Tool2
    Private labels As New List(Of Label)()

    Private Sub Tool2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        'labels.Add(Label4)


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




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        فورم_كبير(Foldericon)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        فورم_كبير(CleaningFile)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        فورم_كبير(Startup)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        فورم_كبير(Supervision)

    End Sub
End Class