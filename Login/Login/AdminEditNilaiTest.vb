Public Class AdminEditNilaiTest
    Dim dal As New DAL
    Private Sub EditNilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.searchtest("", 1, id)
        nama.Text = data.Tables(0).Rows(0).Item("Nama")
        test.Text = data.Tables(0).Rows(0).Item("Nilai")
    End Sub
    Public id As String

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles test.Click

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.EditNilaiTest(id, test.Text))
        Dim nilai As New adminNilaiTest
        nilai.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim nilai As New adminNilaiTest
        nilai.Show()
        Me.Close()
    End Sub
End Class