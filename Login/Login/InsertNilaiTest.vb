Public Class InsertNilaiTest
    Dim dal As New DAL
    Dim idmahasiswa As String
    Private Sub InsertNilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        DataGridView1.Columns.Item("mahasiswa_id").Visible = False
        Dim button As New DataGridViewButtonColumn
        button.UseColumnTextForButtonValue = True
        button.Text = "Pilih"
        button.Name = ""
        DataGridView1.Columns.Add(button)
    End Sub

    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getmahasiswanotest
        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "" Then
            MaterialTabControl1.SelectedIndex = 1
            idmahasiswa = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = " " Then
            MessageBox.Show(dal.deletetestnilai(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value))
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.insertnilaitest(idmahasiswa, nilai.Text))
        MaterialTabControl1.SelectedIndex = 2
        Dim data As DataSet
        data = dal.getnilaitest(idmahasiswa)
        nama.Text = data.Tables(0).Rows(0).Item("mahasiswa_nama")
        status.Text = data.Tables(0).Rows(0).Item("mahasiswa_status")
        testnilai.Text = data.Tables(0).Rows(0).Item("test_nilai")
        If data.Tables(0).Rows(0).Item("beasiswa_nama") = "none" Then
            keterangan.Text = ""
        Else
            keterangan.Text = data.Tables(0).Rows(0).Item("beasiswa_nama")
        End If


    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        NilaiTest.Show()
        Me.Close()
    End Sub

    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub nilai_Click(sender As Object, e As EventArgs) Handles nilai.Click

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub keterangan_Click(sender As Object, e As EventArgs) Handles keterangan.Click

    End Sub

    Private Sub testnilai_Click(sender As Object, e As EventArgs) Handles testnilai.Click

    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    End Sub

    Private Sub status_Click(sender As Object, e As EventArgs) Handles status.Click

    End Sub

    Private Sub nama_Click(sender As Object, e As EventArgs) Handles nama.Click

    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        MaterialTabControl1.SelectedIndex = 0
    End Sub
End Class