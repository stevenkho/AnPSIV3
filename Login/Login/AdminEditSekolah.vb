Public Class adminEditSekolah
    Dim dal As New DAL
    Private Sub EditSekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getsekolah(id)
        nama.Text = data.Tables(0).Rows(0).Item("Nama Sekolah")
        alamat.Text = data.Tables(0).Rows(0).Item("Alamat Sekolah")
    End Sub

    Public id As String

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim sekolah As New adminSekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If nama.Text = "" Or alamat.Text = "" Then
            MessageBox.Show("Silahkan isi data")
        Else
            MessageBox.Show(dal.updatesekolah(id, nama.Text, alamat.Text))
            Dim sekolah As New adminSekolah
            sekolah.Show()
            Me.Close()
        End If


    End Sub
End Class