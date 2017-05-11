Imports System.Windows
Imports MySql.Data.MySqlClient
Imports DTO
Public Class ThemSachDAL
    Public Shared Function ThemSach(ByVal tblMaSach As String, ByVal txbTenSach As String, ByVal txbTheLoai As String, ByVal txbTacGia As String, ByVal DonGia As Single, ByRef ThemThanhCong As Boolean) As ThemSachDTO
        Dim Sach As ThemSachDTO = New ThemSachDTO()
        Sach.MaSach = tblMaSach
        Sach.TenSach = txbTenSach
        Sach.TheLoai = txbTheLoai
        Sach.TacGia = txbTacGia
        Sach.DonGia = Single.Parse(DonGia)
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Try
                con.Open()
                Dim query As String = String.Empty
                query &= "insert into sach (MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia)"
                query &= "values (@MaSach, @TenSach, @TheLoai, @TacGia, '0', @DonGia)"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MaSach", tblMaSach)
                cmd.Parameters.AddWithValue("@TenSach", txbTenSach)
                cmd.Parameters.AddWithValue("@TheLoai", txbTheLoai)
                cmd.Parameters.AddWithValue("@TacGia", txbTacGia)
                cmd.Parameters.AddWithValue("DonGia", DonGia.ToString())
                Dim count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    ThemThanhCong = True
                Else
                    ThemThanhCong = False
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Return Sach
        End Using
    End Function

    Public Shared Function getMaSach() As Integer
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Dim SoLuongSachHienTai = 0
            Try
                con.Open()
                Dim query = "select * from sach"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    SoLuongSachHienTai = SoLuongSachHienTai + 1
                End While
                con.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Return SoLuongSachHienTai + 1
        End Using
    End Function
End Class
