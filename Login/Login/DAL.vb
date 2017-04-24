Imports MySql.Data.MySqlClient
Public Class DAL

    Public Function login(ByVal user As String, ByVal pass As String) As String
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select user_akses from user where user_name = '" & user & "' and user_pass='" & pass & "'"
        Dim akses As String
        akses = command.ExecuteScalar
        closeconnection()
        Return akses
    End Function

    Public Function insertjurusan(ByVal nama As String, ByVal kode As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into jurusan values('','" & nama & "','" & kode & "')"
        Try
            If command.ExecuteNonQuery > 0 Then
                closeconnection()
                Return "Sukses Insert"
            Else
                closeconnection()
                Return "Gagal Insert"
            End If
        Catch ex As MySqlException
            closeconnection()
            Return "Gagal Insert"
        End Try

    End Function

    Public Function updatejurusan(ByVal id As String, ByVal nama As String, ByVal kode As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update jurusan set jurusan_nama='" & nama & "', jurusan_kode = '" & kode & "' where jurusan_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Update"
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function deletejurusan(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from jurusan where jurusan_id='" & id & "' "
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Hapus"
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function

    Public Function getjurusan(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from jurusan where jurusan_id ='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getalljurusan()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select jurusan_id ,jurusan_nama as Nama , jurusan_kode as Kode from jurusan"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getalluser()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select user_id, user_name as NamaPengguna, user_pass as Password, user_akses as Akses from user"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getuser(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from user where user_id ='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function
    Public Function updateuser(ByVal id As String, ByVal username As String, ByVal password As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update user set user_name='" & username & "', user_pass = '" & password & "' where user_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Update"
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function deleteuser(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from user where user_id='" & id & "' "
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Hapus"
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function

    Public Function insertuser(ByVal username As String, ByVal password As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into user values('','" & username & "','" & password & "', 'admin')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Insert"
        Else
            closeconnection()
            Return "Gagal Insert"
        End If
    End Function


    Public Function getallbeasiswa()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select beasiswa_id , beasiswa_nama as 'Nama Beasiswa' , beasiswa_bpp as 'BPP',beasiswa_sks as 'SKS' from beasiswa where beasiswa_nama not in ('none') "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function insertbeasiswa(ByVal nama As String, ByVal bpp As String, ByVal sks As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()

        command.CommandText = "insert into beasiswa values('','" & nama & "','" & bpp & "','" & sks & "')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Insert"
        Else
            closeconnection()
            Return "Gagal Insert"
        End If
    End Function

    Public Function getbeasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from beasiswa where beasiswa_id ='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function updatebeasiwa(ByVal id As String, ByVal nama As String, ByVal bpp As String, ByVal sks As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()

        command.CommandText = "update beasiswa set beasiswa_nama='" & nama & "', beasiswa_bpp='" & bpp & "', beasiswa_sks = '" & sks & "' where beasiswa_id = '" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Update"
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function deletebeasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from beasiswa where beasiswa_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Hapus"
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function


    Public Function getallsekolah()
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select sekolah_id, sekolah_nama as 'Nama Sekolah', sekolah_alamat as 'Alamat Sekolah' from sekolah"
        Dim adp As New MySqlDataAdapter(command)
        Dim data As New DataSet
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getsekolah(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select sekolah_id, sekolah_nama as 'Nama Sekolah', sekolah_alamat as 'Alamat Sekolah' from sekolah where sekolah_id = '" & id & "'"
        Dim adp As New MySqlDataAdapter(command)
        Dim data As New DataSet
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getallwali()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select wali_id, ayah_nama as 'Nama Ayah',ibu_nama as 'Nama Ibu' , wali_nama as 'Nama Wali' from wali "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getwali(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from wali where wali_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from mahasiswa where mahasiswa_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getnilaitest(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "SELECT a.mahasiswa_nama , a.mahasiswa_status , b.beasiswa_nama , c.test_nilai FROM mahasiswa a , beasiswa b , test c where a.mahasiswa_id = c.mahasiswa_id and a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id =" & id
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getnilai(id)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from nilai where mahasiswa_id = '" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function insertmahasiswa(mahasiswa, wali, asalsekolah, nilai, jurusan)
        Dim idsekolah, idwali, idmahasiswa As String
        Dim data As New DataSet
        Dim command As New MySqlCommand
        If asalsekolah.GetType() Is GetType(DataSet) Then
            data = asalsekolah
            command.Connection = openconnection()
            command.CommandText = "insert into sekolah values('','" & data.Tables(0).Rows(0).Item("Nama Sekolah") & "','" & data.Tables(0).Rows(0).Item("Alamat Sekolah") & "');select last_insert_id()"
            idsekolah = command.ExecuteScalar()
            closeconnection()
        Else
            idsekolah = asalsekolah
        End If



        If wali.GetType() Is GetType(DataSet) Then
            data = wali
            command.Connection = openconnection()
            command.CommandText = "insert into wali values('','" & data.Tables(0).Rows(0).Item("ayah_nama") & "','" & data.Tables(0).Rows(0).Item("ayah_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("ayah_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("ayah_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("ayah_alamat") & "','" & data.Tables(0).Rows(0).Item("ayah_nohp") & "','" & data.Tables(0).Rows(0).Item("ibu_nama") & "','" & data.Tables(0).Rows(0).Item("ibu_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("ibu_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("ibu_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("ibu_alamat") & "','" & data.Tables(0).Rows(0).Item("ibu_nohp") & "','" & data.Tables(0).Rows(0).Item("wali_nama") & "','" & data.Tables(0).Rows(0).Item("wali_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("wali_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("wali_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("wali_alamat") & "','" & data.Tables(0).Rows(0).Item("wali_nohp") & "');select last_insert_id()"
            idwali = command.ExecuteScalar
            closeconnection()
        Else
            idwali = wali
        End If


        If idsekolah IsNot Nothing And idwali IsNot Nothing Then
            data = mahasiswa
            command.Connection = openconnection()
            command.CommandText = "insert into mahasiswa values('','" & data.Tables(0).Rows(0).Item("mahasiswa_nama") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("mahasiswa_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_jeniskelamin") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_alamat") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_nohp") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_email") & "','" & idwali & "','" & idsekolah & "','" & jurusan & "','','" & Format(DateTime.Now, "yyyy/MM/dd") & "','Daftar');select last_insert_id()"
            idmahasiswa = command.ExecuteScalar
            closeconnection()
            If idmahasiswa IsNot Nothing Then
                data = nilai
                command.Connection = openconnection()
                command.CommandText = "insert into nilai values('" & idmahasiswa & "','" & data.Tables(0).Rows(0).Item("nilai_mtk") & "','" & data.Tables(0).Rows(0).Item("nilai_bind") & "','" & data.Tables(0).Rows(0).Item("nilai_bing") & "','" & data.Tables(0).Rows(0).Item("nilai_jurusan") & "')"

                If command.ExecuteNonQuery() > 0 Then
                    closeconnection()
                    Return "Sukses Insert"
                Else
                    Return "Gagal Insert"
                End If
            Else
                Return "Gagal Insert Mahasiswa"
            End If
        Else
            Return "Gagal Insert Wali Sekolah"
        End If
    End Function

    Public Function updatemahasiswa(mahasiswa, wali, asalsekolah, nilai, jurusan)
        Dim idsekolah, idwali, idmahasiswa As String
        Dim data As New DataSet
        Dim command As New MySqlCommand

        idsekolah = asalsekolah

        If wali.GetType() Is GetType(DataSet) Then
            data = wali
            command.Connection = openconnection()
            command.CommandText = "update wali set ayah_nama = '" & data.Tables(0).Rows(0).Item("ayah_nama") & "', ayah_tempatlahir = '" & data.Tables(0).Rows(0).Item("ayah_tempatlahir") & "', ayah_tanggallahir = '" & Format(data.Tables(0).Rows(0).Item("ayah_tanggallahir"), "yyyy/MM/dd") & "', ayah_pekerjaan = '" & data.Tables(0).Rows(0).Item("ayah_pekerjaan") & "', ayah_alamat = '" & data.Tables(0).Rows(0).Item("ayah_alamat") & "', ayah_nohp = '" & data.Tables(0).Rows(0).Item("ayah_nohp") & "', ibu_nama = '" & data.Tables(0).Rows(0).Item("ibu_nama") & "', ibu_tempatlahir = '" & data.Tables(0).Rows(0).Item("ibu_tempatlahir") & "', ibu_tanggallahir = '" & Format(data.Tables(0).Rows(0).Item("ibu_tanggallahir"), "yyyy/MM/dd") & "', ibu_pekerjaan = '" & data.Tables(0).Rows(0).Item("ibu_pekerjaan") & "', ibu_alamat = '" & data.Tables(0).Rows(0).Item("ibu_alamat") & "', ibu_nohp = '" & data.Tables(0).Rows(0).Item("ibu_nohp") & "', wali_nama = '" & data.Tables(0).Rows(0).Item("wali_nama") & "', wali_tempatlahir = '" & data.Tables(0).Rows(0).Item("wali_tempatlahir") & "', wali_tanggallahir = '" & Format(data.Tables(0).Rows(0).Item("wali_tanggallahir"), "yyyy/MM/dd") & "', wali_pekerjaan = '" & data.Tables(0).Rows(0).Item("wali_pekerjaan") & "', wali_alamat = '" & data.Tables(0).Rows(0).Item("wali_alamat") & "', wali_nohp = '" & data.Tables(0).Rows(0).Item("wali_nohp") & "' where wali_id = '" & data.Tables(0).Rows(0).Item("wali_id") & "'"
            command.ExecuteScalar()
            idwali = data.Tables(0).Rows(0).Item("wali_id")
            closeconnection()
        Else
            idwali = wali
        End If



        If idsekolah IsNot Nothing And idwali IsNot Nothing Then
            data = mahasiswa
            command.Connection = openconnection()
            command.CommandText = "update mahasiswa set mahasiswa_nama = '" & data.Tables(0).Rows(0).Item("mahasiswa_nama") & "', mahasiswa_tempatlahir = '" & data.Tables(0).Rows(0).Item("mahasiswa_tempatlahir") & "', mahasiswa_tanggallahir = '" & Format(data.Tables(0).Rows(0).Item("mahasiswa_tanggallahir"), "yyyy/MM/dd") & "', mahasiswa_jeniskelamin = '" & data.Tables(0).Rows(0).Item("mahasiswa_jeniskelamin") & "', mahasiswa_alamat = '" & data.Tables(0).Rows(0).Item("mahasiswa_alamat") & "', mahasiswa_nohp = '" & data.Tables(0).Rows(0).Item("mahasiswa_nohp") & "', mahasiswa_email = '" & data.Tables(0).Rows(0).Item("mahasiswa_email") & "', wali_id = '" & idwali & "', sekolah_id = '" & idsekolah & "', jurusan_id = '" & jurusan & "',beasiswa_id = null, tgl_daftar = '" & Format(DateTime.Now, "yyyy/MM/dd") & "', mahasiswa_status = 'Daftar' where mahasiswa_id = '" & data.Tables(0).Rows(0).Item("mahasiswa_id") & "'"
            command.ExecuteScalar()
            idmahasiswa = data.Tables(0).Rows(0).Item("mahasiswa_id")
            closeconnection()
            If idmahasiswa IsNot Nothing Then
                data = nilai
                command.Connection = openconnection()
                command.CommandText = "update nilai set nilai_mtk = '" & data.Tables(0).Rows(0).Item("nilai_mtk") & "', nilai_bind = '" & data.Tables(0).Rows(0).Item("nilai_bind") & "', nilai_bing = '" & data.Tables(0).Rows(0).Item("nilai_bing") & "', nilai_jurusan = '" & data.Tables(0).Rows(0).Item("nilai_jurusan") & "' where mahasiswa_id = '" & idmahasiswa & "'"

                If command.ExecuteNonQuery() > 0 Then
                    closeconnection()
                    Return "Sukses Update"
                Else
                    Return "Gagal update Nilai"
                End If
            Else
                Return "Gagal Update Mahasiswa"
            End If
        Else
            Return "Gagal Update Wali Sekolah"
        End If
    End Function

    Public Function deletemahasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from mahasiswa where mahasiswa_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Hapus"
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function

    Public Function getallmahasiswa()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_id , a.mahasiswa_nama as 'Nama Mahasiswa' , a.mahasiswa_jeniskelamin as 'Jenis Kelamin',b.ayah_nama as 'Nama Ayah',b.ibu_nama as 'Nama Ibu',b.wali_nama as 'Nama Wali',a.tgl_daftar as 'Tanggal Daftar',a.mahasiswa_status as 'Status' from mahasiswa a join wali b on a.wali_id = b.wali_id "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswaaftertest(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_nama,a.mahasiswa_status,b.beasiswa_nama,b.beasiswa_bpp,b.beasiswa_sks,c.test_nilai from mahasiswa a,beasiswa b, test c where a.mahasiswa_id = c.mahasiswa_id and a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswanotest()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_id , a.mahasiswa_nama as 'Nama',b.jurusan_nama as Jurusan , a.tgl_daftar as 'Tanggal Daftar' from mahasiswa a , jurusan b where a.jurusan_id = b.jurusan_id and mahasiswa_status = 'Daftar'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function


    Public Function insertnilaitest(ByVal id As String, ByVal nilai As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into test values('" & id & "','" & nilai & "')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Dim status As String
            Dim idbeasiswa As String
            If nilai > 70 Then
                status = "Lolos"
                If nilai > 70 And nilai < 81 Then
                    idbeasiswa = "13"
                ElseIf nilai > 80 And nilai < 91 Then
                    idbeasiswa = "12"
                ElseIf nilai > 90 Then
                    idbeasiswa = "11"
                Else
                    idbeasiswa = "14"
                End If
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id='" & id & "'"
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    command.Connection = openconnection()


                    command.CommandText = "insert into tagihan_mahasiswa(mahasiswa_id,spp,bpp,sks,biaya_lain)select a. mahasiswa_id , c.spp as SPP ,c.bpp-((c.bpp*b.beasiswa_bpp)/100) as BPP, ((c.sks*22)-(((c.sks*22)*b.beasiswa_sks)/100)) as SKS,c.biaya_lain as 'Biaya Lain' from mahasiswa a ,beasiswa b , tagihan c where a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id =" & id
                    If command.ExecuteNonQuery > 0 Then
                        closeconnection()
                        Return "Sukses Insert"
                    Else
                        closeconnection()
                        Return "Gagal Insert"
                    End If

                Else
                    closeconnection()
                    Return "Gagal Insert"
                End If
            Else
                status = "Gagal"
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=14 where mahasiswa_id='" & id & "'"
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "Sukses Insert"
                Else
                    closeconnection()
                    Return "Gagal Insert"
                End If

            End If
        Else
            closeconnection()
            Return "gagal"
        End If
    End Function


    Public Function getalltest()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_id AS 'Mahasiswa ID' ,a.mahasiswa_nama AS Nama,c.beasiswa_nama as Jurusan,b.test_nilai AS Nilai from mahasiswa a join test b on a.mahasiswa_id = b.mahasiswa_id,beasiswa c where a.beasiswa_id = c.beasiswa_id"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function


    Public Function searchtest(nama, jurusan, id)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        If jurusan = 0 Then
            jurusan = ""

        End If
        Dim a As String = "select a.mahasiswa_id AS 'Mahasiswa ID' ,a.mahasiswa_nama AS Nama,c.beasiswa_nama as Jurusan,b.test_nilai AS Nilai from mahasiswa a join test b on a.mahasiswa_id = b.mahasiswa_id,beasiswa c where a.beasiswa_id = c.beasiswa_id and a.mahasiswa_nama like '" & nama & "%' and a.jurusan_id like '" & jurusan & "%'"
        If id = "" Then
        Else
            a = "select a.mahasiswa_id AS 'Mahasiswa ID' ,a.mahasiswa_nama AS Nama,c.beasiswa_nama as Jurusan,b.test_nilai AS Nilai from mahasiswa a join test b on a.mahasiswa_id = b.mahasiswa_id,beasiswa c where a.beasiswa_id = c.beasiswa_id and a.mahasiswa_id = '" & id & "'"
        End If
        command.Connection = openconnection()
        command.CommandText = a
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function EditNilaiTest(ByVal id As String, ByVal nilai As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update test set test_nilai = '" & nilai & "' where mahasiswa_id=" & id
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Dim status As String
            Dim idbeasiswa As String
            If nilai > 70 Then
                status = "Lolos"
                If nilai > 70 And nilai < 81 Then
                    idbeasiswa = "13"
                ElseIf nilai > 80 And nilai < 91 Then
                    idbeasiswa = "12"
                ElseIf nilai > 90 Then
                    idbeasiswa = "11"
                Else
                    idbeasiswa = "14"
                End If

                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id=" & id
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    command.Connection = openconnection()
                    command.CommandText = "update tagihan_mahasiswa a , (select a. mahasiswa_id , c.spp  ,c.bpp-((c.bpp*b.beasiswa_bpp)/100) as bpp, ((c.sks*22)-(((c.sks*22)*b.beasiswa_sks)/100)) as sks ,c.biaya_lain  from mahasiswa a ,beasiswa b , tagihan c where a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id = " & id & ") b set a.spp = b.spp , a.bpp = b.bpp , a.sks = b.sks , a.biaya_lain = b.biaya_lain where a.mahasiswa_id = '" & id & "'"
                    If command.ExecuteNonQuery > 0 Then
                        closeconnection()
                        Return "Sukses Update"
                    Else
                        closeconnection()
                        command.Connection = openconnection()
                        command.CommandText = "insert into tagihan_mahasiswa(mahasiswa_id,spp,bpp,sks,biaya_lain)select a. mahasiswa_id , c.spp as SPP ,c.bpp-((c.bpp*b.beasiswa_bpp)/100) as BPP, ((c.sks*22)-(((c.sks*22)*b.beasiswa_sks)/100)) as SKS,c.biaya_lain as 'Biaya Lain' from mahasiswa a ,beasiswa b , tagihan c where a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id =" & id
                        If command.ExecuteNonQuery > 0 Then
                            closeconnection()
                            Return "Sukses Update"
                        Else
                            Return "Gagal Update"
                        End If
                    End If
                Else
                    closeconnection()
                    Return "Gagal Update"
                End If
            Else
                status = "Gagal"
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=14 where mahasiswa_id=" & id
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    command.Connection = openconnection()
                    'command.CommandText = "update tagihan_mahasiswa a , (select a. mahasiswa_id , c.spp  ,c.bpp-((c.bpp*b.beasiswa_bpp)/100) as bpp, ((c.sks*22)-(((c.sks*22)*b.beasiswa_sks)/100)) as sks ,c.biaya_lain  from mahasiswa a ,beasiswa b , tagihan c where a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id = " & id & ") b set a.spp = b.spp , a.bpp = b.bpp , a.sks = b.sks , a.biaya_lain = b.biaya_lain"
                    command.CommandText = "delete from tagihan_mahasiswa where mahasiswa_id = " & id
                    If command.ExecuteNonQuery > 0 Then
                        closeconnection()
                        Return "Sukses Update"
                    Else
                        closeconnection()
                        Return "Gagal Update"
                    End If
                Else
                    closeconnection()
                    Return "Gagal Update"
                End If
            End If
            'command.Connection = openconnection()
            'command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id=" & id
            'If command.ExecuteNonQuery > 0 Then
            '    closeconnection()
            '    Return "sukses"
            'Else
            '    closeconnection()
            '    Return "gagal"
            'End If
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function deletetestnilai(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from test where mahasiswa_id =" & id
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            command.Connection = openconnection()
            command.CommandText = "update mahasiswa set beasiswa_id=null ,mahasiswa_status ='Daftar' where mahasiswa_id='" & id & "'"
            If command.ExecuteNonQuery > 0 Then
                closeconnection()
                command.Connection = openconnection()
                command.CommandText = "delete from tagihan_mahasiswa where mahasiswa_id = " & id
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "Sukses Hapus"
                Else
                    closeconnection()
                    Return "Sukses Hapus"
                End If

            Else
                closeconnection()
                Return "Gagal Hapus"
            End If
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function
    Public Function insertsekolah(ByVal nama As String, ByVal alamat As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into sekolah values('','" & nama & "','" & alamat & "')"

        Try
            If command.ExecuteNonQuery > 0 Then
                closeconnection()
                Return "Sukses Insert"
            Else
                closeconnection()
                Return "Gagal Insert"
            End If
        Catch ex As MySqlException

            closeconnection()
            Return "Sukses Insert"

        End Try

    End Function

    Public Function updatesekolah(ByVal id As String, ByVal nama As String, ByVal alamat As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update sekolah set sekolah_nama='" & nama & "', sekolah_alamat = '" & alamat & "' where sekolah_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Update"
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function deletesekolah(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from sekolah where sekolah_id='" & id & "' "
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Hapus"
        Else
            closeconnection()
            Return "Gagal Hapus"
        End If
    End Function

    Public Function getalltagihan()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from tagihan"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function
    Public Function gettagihanmahasiswa()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        'command.CommandText = "select a.mahasiswa_nama as 'Nama Mahasiswa' , c.spp as SPP ,c.spp-((c.bpp*b.beasiswa_bpp)/100) as BPP, ((c.sks*22)-(((c.sks*22)*b.beasiswa_sks)/100)) as SKS,c.biaya_lain as SPP from mahasiswa a ,beasiswa b , tagihan c where a.beasiswa_id = b.beasiswa_id "
        command.CommandText = "select a.mahasiswa_nama as 'Nama Mahasiswa' , c.jurusan_nama as Jurusan , b.spp as SPP,b.bpp as BPP, b.sks as SKS ,b.biaya_lain as 'Biaya Lain' from mahasiswa a , tagihan_mahasiswa b, jurusan c where a.mahasiswa_id = b.mahasiswa_id and a.jurusan_id = c.jurusan_id"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function updatetagihan(spp, bpp, sks, biaya)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update tagihan set spp='" & spp & "' , bpp='" & bpp & "',sks='" & sks & "', biaya_lain = '" & biaya & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses Update"
        Else
            closeconnection()
            Return "Gagal Update"
        End If
    End Function

    Public Function searchsekolah(ByVal crit As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select sekolah_id, sekolah_nama as 'Nama Sekolah' , sekolah_alamat as 'Alamat Sekolah' from sekolah where sekolah_nama like '" & crit & "%'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function searchtagihan(nama, jurusan)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        If jurusan = 0 Then
            jurusan = ""
        End If
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_nama as 'Nama Mahasiswa' , c.jurusan_nama as Jurusan , b.spp as SPP,b.bpp as BPP, b.sks as SKS ,b.biaya_lain as 'Biaya Lain' from mahasiswa a , tagihan_mahasiswa b , jurusan c where a.mahasiswa_id = b.mahasiswa_id and a.jurusan_id = c.jurusan_id and a.mahasiswa_nama like '" & nama & "%' and a.jurusan_id like '" & jurusan & "%'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function searchbeasiswa(ByVal nama As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select beasiswa_id , beasiswa_nama as 'Nama Beasiswa' , beasiswa_bpp as 'BPP',beasiswa_sks as 'SKS' from beasiswa where beasiswa_nama like '" & nama & "%' and  beasiswa_nama not in ('none') "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function searchjurusan(ByVal nama As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select jurusan_id ,jurusan_nama as Nama , jurusan_kode as Kode from jurusan where jurusan_nama like '" & nama & "%' or jurusan_kode like '" & nama & "%'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

End Class


