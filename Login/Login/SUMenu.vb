Public Class SUMenu
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim nilaitest As New NilaiTest
        nilaitest.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Dim mahasiwa As New Mahasiswa
        mahasiwa.Show()
        Me.Close()
    End Sub

    Private Sub SUMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click

        Dim sekolah As New Sekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click

        Dim beasiswa As New Beasiswa
        beasiswa.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton6_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click

        Dim tagihan As New tagihan
        tagihan.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click

        Dim user As New User
        user.Show()
        Me.Close()
    End Sub
End Class