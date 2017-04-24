Imports MySql.Data.MySqlClient
Module connection
    Dim koneksi As New MySqlConnection
    Public Function openconnection()
        koneksi.ConnectionString = "Server=localhost;Database=anpsi_db;Uid=root;Pwd="
        koneksi.Open()
        Return koneksi
    End Function

    Public Function closeconnection()
        koneksi.Close()
        Return koneksi
    End Function

End Module
