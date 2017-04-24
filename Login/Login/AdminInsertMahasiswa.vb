Imports System.Text.RegularExpressions

Public Class adminInsertMahasiswa
    Dim dal As New DAL
    Private Sub InsertMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidata()
        Dim button As New DataGridViewButtonColumn
        button.UseColumnTextForButtonValue = True
        button.Text = "Pilih"
        button.Name = ""
        DataGridView1.Columns.Add(button)
        DataGridView1.Columns.Item("sekolah_id").Visible = False
        DataGridView2.Columns.Item("wali_id").Visible = False
        Dim button1 As New DataGridViewButtonColumn
        button1.UseColumnTextForButtonValue = True
        button1.Text = "Pilih"
        button1.Name = ""
        DataGridView2.Columns.Add(button1)
    End Sub

    Private Sub isidata()
        Dim data As DataSet
        Dim data1 As DataSet
        Dim data2 As DataSet
        data = dal.getalljurusan
        data1 = dal.getallsekolah
        data2 = dal.getallwali
        ComboBox1.DataSource = data.Tables(0)
        ComboBox1.ValueMember = "jurusan_id"
        ComboBox1.DisplayMember = "nama"
        DataGridView1.DataSource = data1.Tables(0)
        DataGridView2.DataSource = data2.Tables(0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            namasekolah.Enabled = True
            alamatsekolah.Enabled = True
            DataGridView1.Enabled = False
        Else
            namasekolah.Enabled = False
            alamatsekolah.Enabled = False
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "" Then
            'MaterialTabControl1.SelectedIndex = 3
            Dim data As New DataSet
            data = dal.getsekolah(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("sekolah_id").Value.ToString)
            namasekolah.Text = data.Tables(0).Rows(0).Item("Nama Sekolah")
            alamatsekolah.Text = data.Tables(0).Rows(0).Item("Alamat Sekolah")

        End If
    End Sub

    Private Sub walicheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles walicheckbox.CheckedChanged
        If walicheckbox.Checked = True Then
            namayah.Enabled = False
            tempatlahirayah.Enabled = False
            tanggallahirayah.Enabled = False
            pekerjaanayah.Enabled = False
            alamatayah.Enabled = False
            nohpayah.Enabled = False
            namaibu.Enabled = False
            tempatlahiribu.Enabled = False
            tanggallahiribu.Enabled = False
            pekerjaanibu.Enabled = False
            alamatibu.Enabled = False
            nohpibu.Enabled = False
            namawali.Enabled = False
            tempatlahirwali.Enabled = False
            tanggallahirwali.Enabled = False
            pekerjaanwali.Enabled = False
            alamatwali.Enabled = False
            nohpwali.Enabled = False
            DataGridView2.Enabled = True
        ElseIf walicheckbox.Checked = False Then
            namayah.Enabled = True
            tempatlahirayah.Enabled = True
            tanggallahirayah.Enabled = True
            pekerjaanayah.Enabled = True
            alamatayah.Enabled = True
            nohpayah.Enabled = True
            namaibu.Enabled = True
            tempatlahiribu.Enabled = True
            tanggallahiribu.Enabled = True
            pekerjaanibu.Enabled = True
            alamatibu.Enabled = True
            nohpibu.Enabled = True
            namawali.Enabled = True
            tempatlahirwali.Enabled = True
            tanggallahirwali.Enabled = True
            pekerjaanwali.Enabled = True
            alamatwali.Enabled = True
            nohpwali.Enabled = True
            DataGridView2.Enabled = False
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim mahasiswa, nilai As New DataSet
        Dim wali
        Dim sekolah

        If namamahasiswa.Text = "" Or tempatlahirmahasiswa.Text = "" Or alamatmahasiswa.Text = "" Or nohpmahasiwa.Text = "" Or emailmahasiswa.Text = "" Or namasekolah.Text = "" Or alamatsekolah.Text = "" Or namayah.Text = "" Or tempatlahirayah.Text = "" Or pekerjaanayah.Text = "" Or alamatayah.Text = "" Or nohpayah.Text = "" Or namaibu.Text = "" Or tempatlahiribu.Text = "" Or pekerjaanibu.Text = "" Or alamatibu.Text = "" Or nohpibu.Text = "" Or namawali.Text = "" Or tempatlahirwali.Text = "" Or pekerjaanwali.Text = "" Or alamatwali.Text = "" Or nohpwali.Text = "" Or nilaibahasaindo.Text = "" Or nilaiinggris.Text = "" Or nilaimatematika.Text = "" Or nilaijurusan.Text = "" Then
            MessageBox.Show("Silahkan isi data dengan lengkap")
        Else
            If IsNumeric(nohpmahasiwa.Text) = False Or IsNumeric(nohpwali.Text) = False Or IsNumeric(nohpibu.Text) = False Or IsNumeric(nohpayah.Text) = False Or IsNumeric(nilaiinggris.Text) = False Or IsNumeric(nilaibahasaindo.Text) = False Or IsNumeric(nilaimatematika.Text) = False Or IsNumeric(nilaijurusan.Text) = False Then
                MessageBox.Show("No HP dan Nilai tidak boleh berisi huruf")
            Else
                If (CDbl(nilaibahasaindo.Text) < 0 Or CDbl(nilaibahasaindo.Text) > 100) Or (CDbl(nilaiinggris.Text) < 0 Or CDbl(nilaiinggris.Text) > 100) Or (CDbl(nilaimatematika.Text) < 0 Or CDbl(nilaimatematika.Text) > 100) Or (CDbl(nilaijurusan.Text) < 0 Or CDbl(nilaijurusan.Text) > 100) Then
                    MessageBox.Show("Data nilai ada yang salah")
                Else
                    mahasiswa = dal.getmahasiswa("")
                    If mahasiswa.Tables(0).Rows.Count = 0 Then
                        mahasiswa.Tables(0).Rows.Add()
                        With mahasiswa.Tables(0).Rows(0)
                            .Item("mahasiswa_nama") = namamahasiswa.Text
                            .Item("mahasiswa_tempatlahir") = tempatlahirmahasiswa.Text
                            .Item("mahasiswa_tanggallahir") = tanggallahirmahasiswa.Text
                            .Item("mahasiswa_jeniskelamin") = IIf(Pria.Checked = True, "Laki", "Perempuan")
                            .Item("mahasiswa_alamat") = alamatmahasiswa.Text
                            .Item("mahasiswa_nohp") = nohpmahasiwa.Text
                            .Item("mahasiswa_email") = emailmahasiswa.Text
                        End With
                    End If

                    If CheckBox1.Checked = False Then

                        sekolah = dal.getsekolah("")
                        If sekolah.Tables(0).Rows.Count = 0 Then
                            sekolah.Tables(0).Rows.Add()
                            With sekolah.Tables(0).Rows(0)
                                .Item("Nama Sekolah") = namasekolah.Text
                                .Item("Alamat Sekolah") = alamatsekolah.Text
                            End With
                        End If
                    ElseIf CheckBox1.Checked = True Then

                        sekolah = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("sekolah_id").Value.ToString
                    End If

                    If walicheckbox.Checked = False Then
                        wali = dal.getwali("")
                        If wali.Tables(0).Rows.Count = 0 Then
                            wali.Tables(0).Rows.Add()
                            With wali.Tables(0).Rows(0)
                                .Item("ayah_nama") = namayah.Text
                                .Item("ayah_tempatlahir") = tempatlahirayah.Text
                                .Item("ayah_tanggallahir") = tanggallahirayah.Text
                                .Item("ayah_pekerjaan") = pekerjaanayah.Text
                                .Item("ayah_alamat") = alamatayah.Text
                                .Item("ayah_nohp") = nohpayah.Text
                                .Item("ibu_nama") = namaibu.Text
                                .Item("ibu_tempatlahir") = tempatlahiribu.Text
                                .Item("ibu_tanggallahir") = tanggallahiribu.Text
                                .Item("ibu_pekerjaan") = pekerjaanibu.Text
                                .Item("ibu_alamat") = alamatibu.Text
                                .Item("ibu_nohp") = nohpibu.Text
                                .Item("wali_nama") = namawali.Text
                                .Item("wali_tempatlahir") = tempatlahirwali.Text
                                .Item("wali_tanggallahir") = tanggallahirwali.Text
                                .Item("wali_pekerjaan") = pekerjaanwali.Text
                                .Item("wali_alamat") = alamatwali.Text
                                .Item("wali_nohp") = nohpwali.Text
                            End With
                        End If
                    ElseIf walicheckbox.Checked = True Then
                        wali = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells.Item("wali_id").Value.ToString
                    End If

                    nilai = dal.getnilai("")
                    If nilai.Tables(0).Rows.Count = 0 Then
                        nilai.Tables(0).Rows.Add()
                        With nilai.Tables(0).Rows(0)
                            .Item("nilai_mtk") = nilaimatematika.Text
                            .Item("nilai_bind") = nilaibahasaindo.Text
                            .Item("nilai_bing") = nilaiinggris.Text
                            .Item("nilai_jurusan") = nilaijurusan.Text
                        End With
                    End If
                    MessageBox.Show(dal.insertmahasiswa(mahasiswa, wali, sekolah, nilai, ComboBox1.SelectedValue))
                    Dim gomahasiswa As New Mahasiswa
                    gomahasiswa.Show()
                    Me.Close()
                End If
            End If
        End If

        Dim adminmaha As New adminMahasiswa
        adminmaha.Show()
        Me.Close()
    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        MaterialTabControl1.SelectedIndex = 1
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton10.Click
        MaterialTabControl1.SelectedIndex = 3
    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim maha As New adminMahasiswa
        maha.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        MaterialTabControl1.SelectedIndex = 0
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        MaterialTabControl1.SelectedIndex = 2
    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        MaterialTabControl1.SelectedIndex = 1
    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click
        MaterialTabControl1.SelectedIndex = 3
    End Sub

    Private Sub MaterialRaisedButton9_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton9.Click
        MaterialTabControl1.SelectedIndex = 2
    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        MaterialTabControl1.SelectedIndex = 4
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub walicheckbox_CheckedChanged_1(sender As Object, e As EventArgs) Handles walicheckbox.CheckedChanged

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "" Then
            Dim data As New DataSet
            data = dal.getwali(DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells.Item("wali_id").Value.ToString)
            namayah.Text = data.Tables(0).Rows(0).Item("ayah_nama")
            tempatlahirayah.Text = data.Tables(0).Rows(0).Item("ayah_tempatlahir")
            tanggallahirayah.Value = data.Tables(0).Rows(0).Item("ayah_tanggallahir")
            pekerjaanayah.Text = data.Tables(0).Rows(0).Item("ayah_pekerjaan")
            alamatayah.Text = data.Tables(0).Rows(0).Item("ayah_alamat")
            nohpayah.Text = data.Tables(0).Rows(0).Item("ayah_nohp")

            namaibu.Text = data.Tables(0).Rows(0).Item("ibu_nama")
            tempatlahiribu.Text = data.Tables(0).Rows(0).Item("ibu_tempatlahir")
            tanggallahiribu.Value = data.Tables(0).Rows(0).Item("ibu_tanggallahir")
            pekerjaanibu.Text = data.Tables(0).Rows(0).Item("ibu_pekerjaan")
            alamatibu.Text = data.Tables(0).Rows(0).Item("ibu_alamat")
            nohpibu.Text = data.Tables(0).Rows(0).Item("ibu_nohp")

            namawali.Text = data.Tables(0).Rows(0).Item("wali_nama")
            tempatlahirwali.Text = data.Tables(0).Rows(0).Item("wali_tempatlahir")
            tanggallahirwali.Value = data.Tables(0).Rows(0).Item("wali_tanggallahir")
            pekerjaanwali.Text = data.Tables(0).Rows(0).Item("wali_pekerjaan")
            alamatwali.Text = data.Tables(0).Rows(0).Item("wali_alamat")
            nohpwali.Text = data.Tables(0).Rows(0).Item("wali_nohp")


        End If
    End Sub

End Class