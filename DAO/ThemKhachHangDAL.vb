Imports MySql.Data.MySqlClient
Imports DTO
Imports System.Windows
Public Class ThemKhachHangDAL

    Public Shared Function ThemKhachHang(ByVal lblMaKH As String, ByVal txbTenKH As String, ByVal txbDiaChi As String, ByVal txbDienThoai As String, ByVal txbEmail As String, ByRef ThemThanhCong As Boolean) As KhachHangDTO
        Dim KhachHang As KhachHangDTO = New KhachHangDTO()
        KhachHang.MaKhachHang = lblMaKH
        KhachHang.HoTenKhachHang = txbTenKH
        KhachHang.DiaChi = txbDiaChi
        KhachHang.DienThoai = txbDienThoai
        KhachHang.Email = txbEmail
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Try
                con.Open()
                Dim query As String = String.Empty
                query &= "insert into khachhang (MaKhachHang, HoTenKhachHang, DiaChi, DienThoai, Email, SoTienNo)"
                query &= "values (@MaKH, @TenKH, @DiaChi, @DienThoai, @Email, 0)"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MaKH", lblMaKH)
                cmd.Parameters.AddWithValue("@TenKH", txbTenKH)
                cmd.Parameters.AddWithValue("@DiaChi", txbDiaChi)
                cmd.Parameters.AddWithValue("@DienThoai", txbDienThoai)
                cmd.Parameters.AddWithValue("@Email", txbEmail)
                Dim count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    ThemThanhCong = True
                Else
                    ThemThanhCong = False
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Return KhachHang
        End Using
    End Function

    Public Shared Function GetMaKH() As Integer
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Dim SoKH_hHienTai = 0
            Try
                con.Open()
                Dim query = "select * from khachhang"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    SoKH_hHienTai = SoKH_hHienTai + 1
                End While
                con.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Return SoKH_hHienTai + 1
        End Using
    End Function
End Class
