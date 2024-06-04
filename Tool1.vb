
Public Class Tool1
    Private labels As New List(Of Label)()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        فورم_كبير(Info)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label5.Click
        فورم_كبير(Ran)

    End Sub



    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        Label1.ForeColor = Color.Gray

    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        Label1.ForeColor = Color.White

    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs)
        Label5.ForeColor = Color.Gray

    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        Label5.ForeColor = Color.White

    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        Label4.ForeColor = Color.Gray

    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        Label4.ForeColor = Color.White

    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        Label3.ForeColor = Color.Gray

    End Sub

    Private Sub Label3_MouseUp(sender As Object, e As MouseEventArgs) Handles Label3.MouseUp
        Label3.ForeColor = Color.White

    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        Label2.ForeColor = Color.Gray

    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        Label2.ForeColor = Color.White

    End Sub

    Private Sub Tool1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labels.Add(Label1)
        labels.Add(Label2)
        labels.Add(Label3)
        labels.Add(Label4)
        labels.Add(Label5)
        labels.Add(Label6)

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



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        فورم_كبير(Taskbar)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ادمين
        فورم_كبير(BlockApp)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        فورم_كبير(Desktop)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        فورم_كبير(Win10)
    End Sub
End Class