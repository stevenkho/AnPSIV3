Public Class Sekolah
    Dim dal As New DAL

    Private Sub Sekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        Dim Button As New DataGridViewButtonColumn()
        Dim Button1 As New DataGridViewButtonColumn()
        Button1.UseColumnTextForButtonValue = True
        Button1.Text = "Delete"
        Button1.Name = "  "
        Button.UseColumnTextForButtonValue = True
        Button.Text = "Edit"
        Button.Name = " "
        DataGridView1.Columns.Add(Button)
        DataGridView1.Columns.Add(Button1)
        DataGridView1.Columns.Item("sekolah_id").Visible = False
    End Sub

    Public Sub isidgv()
        Dim data As DataSet
        data = dal.getallsekolah()
        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Dim insert As New InsertSekolah
        insert.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = " " Then
            Dim edit As New editsekolah
            edit.id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("sekolah_id").Value
            edit.Show()
            Me.Close()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "  " Then
            MessageBox.Show(dal.deletesekolah(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("sekolah_id").Value))
            isidgv()
        End If
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim su As New SUMenu
        su.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If namajurusan.Text = "" Then
            isidgv()
        Else
            Dim data As New DataSet
            data = dal.searchsekolah(namajurusan.Text)
            DataGridView1.DataSource = data.Tables(0)
        End If
    End Sub
End Class