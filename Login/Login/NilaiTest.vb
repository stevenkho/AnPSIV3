Public Class NilaiTest
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim insert As New InsertNilaiTest
        insert.Show()
        Me.Close()
    End Sub

    Private Sub NilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        Dim button As New DataGridViewButtonColumn()
        Dim button1 As New DataGridViewButtonColumn()
        button.UseColumnTextForButtonValue = True
        button1.UseColumnTextForButtonValue = True
        button1.Text = "Delete"
        button1.Name = " "
        button.Text = "Edit"
        button.Name = ""
        DataGridView2.Columns.Add(button)
        DataGridView2.Columns.Add(button1)
        DataGridView2.Columns.Item("Mahasiswa ID").Visible = False
    End Sub
    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getalltest()
        DataGridView2.DataSource = data.Tables(0)
        Dim data2 As New DataSet
        data2 = dal.getalljurusan
        data2.Tables(0).Rows.Add("0", " ")
        ComboBox1.DataSource = data2.Tables(0)
        ComboBox1.ValueMember = "jurusan_id"
        ComboBox1.DisplayMember = "nama"
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "" Then
            Dim edit As New EditNilaiTest
            edit.id = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells.Item("Mahasiswa ID").Value
            edit.Show()
            Me.Close()
        Else
            MessageBox.Show(dal.deletetestnilai(DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells.Item("Mahasiswa ID").Value))
            isidgv()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        If namajurusan.Text = "" And ComboBox1.SelectedValue = 0 Then
            isidgv()
        Else
            Dim data As New DataSet
            data = dal.searchtest(namajurusan.Text, ComboBox1.SelectedValue, "")
            DataGridView2.DataSource = data.Tables(0)
        End If
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Dim menu As New SUMenu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub


End Class