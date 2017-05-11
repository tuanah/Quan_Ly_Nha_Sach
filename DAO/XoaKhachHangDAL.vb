Imports MySql.Data.MySqlClient
Imports DTO
Imports System.Windows
Public Class XoaKhachHangDAL
    Public Shared Function XoaKhachHang(ByRef MaKhachHang As String) As Boolean
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Try
                con.Open()
                Dim query = "delete from khachhang where MaKhachHang = @MaKhachHang"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang)
                Dim count = 0
                count = cmd.ExecuteNonQuery()
                If (count > 0) Then
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function
End Class
