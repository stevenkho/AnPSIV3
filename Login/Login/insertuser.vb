Public Class insertuser
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If namauser.Text = "" Or katasandi.Text = "" Then
            MessageBox.Show("Silahkan isi data")
        Else
            MessageBox.Show(dal.insertuser(namauser.Text, katasandi.Text))
            Dim user As New User
            user.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs) Handles katasandi.Click

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim user As New User
        user.Show()
        Me.Close()
    End Sub
End Class