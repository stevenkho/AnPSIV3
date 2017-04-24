﻿Public Class AdminBeasiswa
    Dim dal As New DAL
    Private Sub Beasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        DataGridView1.Columns(0).Visible = False
    End Sub
    Private Sub isidgv()
        Dim data As DataSet
        data = dal.getallbeasiswa
        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        '  MessageBox.Show(dal.insertbeasiswa(nama.Text, bpp.Text, sks.Text))
        ' isidgv()

        If nama.Text = "" Then
            isidgv()
        Else
            Dim data As New DataSet
            data = dal.searchbeasiswa(nama.Text)
            DataGridView1.DataSource = data.Tables(0)
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = " " Then
            Dim edit As New EditBeasiswa
            edit.id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("beasiswa_id").Value
            edit.Show()
            Me.Close()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "  " Then
            MessageBox.Show(dal.deletebeasiswa(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("beasiswa_id").Value))
            isidgv()
        End If
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim SUMenu As New AMenu
        SUMenu.Show()
        Me.Close()
    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)

    End Sub
End Class