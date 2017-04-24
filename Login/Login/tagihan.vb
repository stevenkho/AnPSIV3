Public Class tagihan
    Dim dal As New DAL
    Private Sub tagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
    End Sub
    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getalltagihan
        MaterialLabel5.Text = data.Tables(0).Rows(0).Item("spp")
        MaterialLabel6.Text = data.Tables(0).Rows(0).Item("bpp")
        MaterialLabel7.Text = data.Tables(0).Rows(0).Item("sks")
        MaterialLabel8.Text = data.Tables(0).Rows(0).Item("biaya_lain")
        Dim data1 As New DataSet
        data1 = dal.gettagihanmahasiswa()
        DataGridView1.DataSource = data1.Tables(0)
        Dim data2 As New DataSet
        data2 = dal.getalljurusan
        data2.Tables(0).Rows.Add("0", " ")
        ComboBox1.DataSource = data2.Tables(0)
        ComboBox1.ValueMember = "jurusan_id"
        ComboBox1.DisplayMember = "nama"
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs)
        MaterialTabControl1.SelectedIndex = 1
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)
        MaterialTabControl1.SelectedIndex = 0
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Dim edit As New edittagihan
        edit.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        MaterialTabControl1.SelectedIndex = 0
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Dim menu As New SUMenu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        If namajurusan.Text = "" And ComboBox1.SelectedValue = 0 Then
            isidgv()
        Else
            Dim data As New DataSet
            data = dal.searchtagihan(namajurusan.Text, ComboBox1.SelectedValue)
            DataGridView1.DataSource = data.Tables(0)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class