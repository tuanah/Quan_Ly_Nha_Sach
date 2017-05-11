Imports MySql.Data.MySqlClient
Imports System.Windows
Public Class SuaKhachHangDAL
    Shared con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
    Public Shared Function SuaKhachHang(ByVal MaKH As String, ByVal TenKH As String, ByVal DienThoai As String, ByVal DiaChi As String, ByVal Email As String, ByVal SoTienNo As Single) As Boolean
        Try
            con.Open()
            Dim query = "update khachhang set HoTenKhachHang = @TenKH, DienThoai = @DienThoai, DiaChi = @DiaChi, Email = @Email, SoTienNo = @SoTienNo where MaKhachHang = @MaKhachHang"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@TenKH", TenKH)
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai)
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi)
            cmd.Parameters.AddWithValue("@Email", Email)
            cmd.Parameters.AddWithValue("@SoTienNo", SoTienNo)
            cmd.Parameters.AddWithValue("@MaKhachHang", MaKH)
            Dim count = 0
            count = cmd.ExecuteNonQuery()
            If (count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return False
    End Function
End Class
