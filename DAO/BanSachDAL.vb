Imports MySql.Data.MySqlClient
Imports System.Windows
Imports DTO
Public Class BanSachDAL
    Shared con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
    Public Shared Function getTen_No(ByVal MaKH As String) As List(Of String)
        Dim Ten_No As New List(Of String)
        Try
            con.Open()
            Dim query = "select HoTenKhachHang, SoTienNo from khachhang where MaKhachHang = @MaKhachHang"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaKhachHang", MaKH)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                Ten_No.Add(reader.GetString("HoTenKhachHang"))
                Ten_No.Add(reader.GetString("SoTienNo"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return Ten_No
    End Function

    Public Shared Function XoaSachVuaBan(ByVal MaSach As String, ByVal SoLuongTonBanDau As Integer) As Boolean
        Try
            con.Open()
            Dim query = "update sach set SoLuongTon = @SoLuongTonBanDau where MaSach = @MaSach"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@SoLuongTonBanDau", SoLuongTonBanDau)
            cmd.Parameters.AddWithValue("@MaSach", MaSach)
            Dim count = 0
            count = cmd.ExecuteNonQuery
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

    Public Shared Function BanSach(ByVal MaSach As String, ByVal SoLuongTonSauKhiBan As Integer) As Boolean
        Try
            con.Open()
            Dim query = "update sach set SoLuongTon = @SoLuongTonSauKhiBan where MaSach = @MaSach"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@SoLuongTonSauKhiBan", SoLuongTonSauKhiBan)
            cmd.Parameters.AddWithValue("@MaSach", MaSach)
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

    Public Shared Function GetMaHD() As Boolean
        Try
            con.Open()
            Dim reader As MySqlDataReader = New MySqlCommand("select * from hoadon", con).ExecuteReader
            While reader.Read
                Return True
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return False
    End Function
    Public Shared Function GetMaCTHD() As Boolean
        Try
            con.Open()
            Dim reader As MySqlDataReader = New MySqlCommand("select * from chitiethoadon", con).ExecuteReader
            While reader.Read
                Return True
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            con.Close()
        End Try
        Return False
    End Function

    Public Shared Function ThemHD(ByVal HoaDon As HoaDonDTO) As Boolean
        Try
            con.Open()
            Dim query = "insert into hoadon values(@MaHoaDon, @MaKhachHang, @NgayLapHoaDon, @TongTien)"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaHoaDon", HoaDon.MaHoaDon)
            cmd.Parameters.AddWithValue("@MaKhachHang", HoaDon.MaKhachHang)
            cmd.Parameters.AddWithValue("@NgayLapHoaDon", HoaDon.NgayLapHoaDon)
            cmd.Parameters.AddWithValue("@TongTien", HoaDon.TongTien)
            Dim count = 0
            count = cmd.ExecuteNonQuery
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

    Public Shared Function ThemCTHD(ByVal CTHD As ChiTietHoaDonDTO) As Boolean
        Try
            con.Open()
            Dim query = "insert into chitiethoadon values(@MaChiTietHoaDon, @MaHoaDon, @MaSach, @SoLuongBan, @ThanhTien)"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaChiTietHoaDon", CTHD.MaChiTietHoaDon)
            cmd.Parameters.AddWithValue("@MaHoaDon", CTHD.MaHoaDon)
            cmd.Parameters.AddWithValue("@MaSach", CTHD.MaSach)
            cmd.Parameters.AddWithValue("@SoLuongBan", CTHD.SoLuongBan)
            cmd.Parameters.AddWithValue("@ThanhTien", CTHD.ThanhTien)
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
        Return False
    End Function
End Class
