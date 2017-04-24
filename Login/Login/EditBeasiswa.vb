Public Class EditBeasiswa
    Dim dal As New DAL
    Private Sub EditBeasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataSet
        data = dal.getbeasiswa(id)
        nama.Text = data.Tables(0).Rows(0).Item("beasiswa_nama")
        bpp.Text = data.Tables(0).Rows(0).Item("beasiswa_bpp")
        sks.Text = data.Tables(0).Rows(0).Item("beasiswa_sks")
    End Sub

    Public id As String

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.updatebeasiwa(id, nama.Text, bpp.Text, sks.Text))
        Dim beasiswa As New Beasiswa
        beasiswa.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim beasiswa As New Beasiswa
        beasiswa.Show()
        Me.Close()
    End Sub
End Class