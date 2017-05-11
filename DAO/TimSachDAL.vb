Imports MySql.Data.MySqlClient
Imports DTO
Public Class TimSachDAL
    Shared con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
    Public Shared Function TimSach(ByVal txbMaSach As String, ByVal txbTenSach As String, ByVal txbTheLoai As String, txbTacGia As String) As List(Of SachDTO)
        Dim listSach As List(Of SachDTO) = New List(Of SachDTO)
        Dim query = "select * from Sach where MaSach like @MaSach and TenSach like @TenSach and TheLoai like @TheLoai and TacGia like @TacGia"
        Dim reader As MySqlDataReader
        Try
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaSach", "%" + txbMaSach + "%")
            cmd.Parameters.AddWithValue("@TenSach", "%" + txbTenSach + "%")
            cmd.Parameters.AddWithValue("@TheLoai", "%" + txbTheLoai + "%")
            cmd.Parameters.AddWithValue("@TacGia", "%" + txbTacGia + "%")
            reader = cmd.ExecuteReader
            While reader.Read
                Dim temp As SachDTO = New SachDTO(reader.GetString("MaSach"), reader.GetString("TenSach"), reader.GetString("TheLoai"), reader.GetString("TacGia"), reader.GetString("SoLuongTon"), reader.GetString("DonGia"))
                listSach.Add(temp)
            End While
        Catch ex As Exception

        Finally
            con.Close()
            con.Dispose()
        End Try

        Return listSach

    End Function
End Class
