Public Class insertjurusan
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If namajurusan.Text = "" Or kodejurusan.Text = "" Then
            MessageBox.Show("Silahkan isi data")
        Else
            MessageBox.Show(dal.insertjurusan(namajurusan.Text, kodejurusan.Text))
            Dim jurusan As New Jurusan
            jurusan.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()
    End Sub
End Class