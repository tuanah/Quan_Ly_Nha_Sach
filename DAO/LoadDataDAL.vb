Imports MySql.Data.MySqlClient
Public Class LoadDataDAL
    Shared con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
    Public Shared Function LoadMaKH() As List(Of String)
        Dim listMaKH As New List(Of String)
        Try
            con.Open()
            Dim query = "select * from khachhang"
            Dim reader As MySqlDataReader = New MySqlCommand(query, con).ExecuteReader
            While (reader.Read)
                listMaKH.Add(reader.GetString("MaKhachHang"))
            End While
        Catch ex As Exception
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return listMaKH
    End Function

    Public Shared Function LoadMaSach() As List(Of String)
        Dim listMaSach As New List(Of String)
        Try
            con.Open()
            Dim query = "select * from sach"
            Dim reader As MySqlDataReader = New MySqlCommand(query, con).ExecuteReader
            While (reader.Read)
                listMaSach.Add(reader.GetString("MaSach"))
            End While
        Catch ex As Exception
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return listMaSach
    End Function
End Class
