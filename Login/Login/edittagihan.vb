Public Class edittagihan
    Dim dal As New DAL
    Private Sub edittagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataSet
        data = dal.getalltagihan
        MaterialSingleLineTextField1.Text = data.Tables(0).Rows(0).Item("spp").ToString
        MaterialSingleLineTextField2.Text = data.Tables(0).Rows(0).Item("bpp").ToString
        MaterialSingleLineTextField3.Text = data.Tables(0).Rows(0).Item("sks").ToString
        MaterialSingleLineTextField4.Text = data.Tables(0).Rows(0).Item("biaya_lain").ToString
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.updatetagihan(MaterialSingleLineTextField1.Text, MaterialSingleLineTextField2.Text, MaterialSingleLineTextField3.Text, MaterialSingleLineTextField4.Text))
        Dim tagihan As New tagihan
        tagihan.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim tagihan As New tagihan
        tagihan.Show()
        Me.Close()
    End Sub
End Class