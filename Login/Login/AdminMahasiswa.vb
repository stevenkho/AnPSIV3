Public Class adminMahasiswa
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        DataGridView1.Columns(0).Visible = False
        Dim button As New DataGridViewButtonColumn
        Dim button1 As New DataGridViewButtonColumn
        button.UseColumnTextForButtonValue = True
        button1.UseColumnTextForButtonValue = True
        button.Name = ""
        button.Text = "Edit"
        button1.Name = " "
        button1.Text = "Delete"
        DataGridView1.Columns.Add(button)
        DataGridView1.Columns.Add(button1)
    End Sub

    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getallmahasiswa
        DataGridView1.DataSource = data.Tables(0)
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "" Then
            Dim edit As New admineditmahasiswa
            edit.id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value
            edit.Show()
            Me.Close()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = " " Then
            MessageBox.Show(dal.deletemahasiswa(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value))
            isidgv()
        End If
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim insert As New adminInsertMahasiswa
        insert.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Dim su As New AMenu
        su.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class