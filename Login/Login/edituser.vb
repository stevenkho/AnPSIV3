Public Class edituser
    Dim dal As New DAL
    Private Sub edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getuser(id)
        username.Text = data.Tables(0).Rows(0).Item("user_name")
        password.Text = data.Tables(0).Rows(0).Item("user_pass")
    End Sub
    Public id As String

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.updateuser(id, username.Text, password.Text))
        Dim user As New User
        user.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim user As New User
        user.Show()
        Me.Close()
    End Sub
End Class