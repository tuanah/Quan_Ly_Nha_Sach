Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class SuaSachDAL
    Public Shared Function SuaSach(ByVal MaSach As String, ByVal TenSach As String, ByVal TheLoai As String, ByVal TacGia As String, ByVal DonGia As String) As Boolean
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Try
                con.Open()
                Dim query = "update Sach set TenSach = @TenSach, TheLoai = @TheLoai, TacGia = @TacGia, DonGia = @DonGia where MaSach = @MaSach"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@TenSach", TenSach)
                cmd.Parameters.AddWithValue("@TheLoai", TheLoai)
                cmd.Parameters.AddWithValue("@TacGia", TacGia)
                cmd.Parameters.AddWithValue("@DonGia", DonGia)
                cmd.Parameters.AddWithValue("@MaSach", MaSach)
                Dim count = 0
                count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Dispose()
                con.Close()
            End Try
        End Using
        Return False
    End Function
End Class
