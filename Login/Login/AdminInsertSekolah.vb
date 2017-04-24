Public Class adminInsertSekolah
    Dim dal As New DAL
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim sekolah As New adminSekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If namasekolah.Text = "" Or alamatsekolah.Text = "" Then
            MessageBox.Show("Silahkan isi data")
        Else
            MessageBox.Show(dal.insertsekolah(namasekolah.Text, alamatsekolah.Text))
            Dim sekolah As New adminSekolah
            sekolah.Show()
            Me.Close()
        End If


    End Sub

    Private Sub InsertSekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class