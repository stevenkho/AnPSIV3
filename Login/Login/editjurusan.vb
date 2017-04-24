Public Class editjurusan
    Dim dal As New DAL
    Private Sub editjurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getjurusan(id)
        nama.Text = data.Tables(0).Rows(0).Item("jurusan_nama")
        kode.Text = data.Tables(0).Rows(0).Item("jurusan_kode")
    End Sub
    Public id As String

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If nama.Text = "" Or kode.Text = "" Then
            MessageBox.Show("Silahkan isi data")
        Else
            Dim cekhasil As String
            cekhasil = dal.updatejurusan(id, nama.Text, kode.Text)
            MessageBox.Show(cekhasil)
            If cekhasil = "sukses insert" Then
                Dim jurusan As New Jurusan
                jurusan.Show()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()
    End Sub
End Class