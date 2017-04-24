Public Class AMenu
    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Dim tagihan As New admintagihan
        tagihan.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        Dim bea As New adminBeasiswa
        bea.Show()
        Me.Close()

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        Dim sekolah As New adminSekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Dim maha As New AdminMahasiswa
        maha.Show()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim input As New adminNilaiTest
        input.Show()
        Me.Close()
    End Sub
End Class