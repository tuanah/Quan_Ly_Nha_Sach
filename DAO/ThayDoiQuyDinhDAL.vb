Imports MySql.Data.MySqlClient
Imports DTO
Imports System.Windows
Public Class ThayDoiQuyDinhDAL
    Shared con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
    Public Shared Function ThayDoiQuyDinh(ByVal QuyDinh As ThamSoDTO) As Boolean
        Try
            con.Open()
            Dim query = "update thamso set SoLuongNhapToiThieu = @NhapMin, SoLuongTonToiDaDuocPhepNhap = @TonMax, SoLuongTonToiThieuSauKhiBan = @TonMinSauKhiBan, SoTienNoToiDa = @NoMax, SuDungQuyDinh4 = @QuyDinh4"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@NhapMin", QuyDinh.SoLuongNhapToiThieu)
            cmd.Parameters.AddWithValue("@TonMax", QuyDinh.SoLuongTonToiDaTruocKhiNhap)
            cmd.Parameters.AddWithValue("@TonMinSauKhiBan", QuyDinh.SoLuongTonToiThieuSauKhiBan)
            cmd.Parameters.AddWithValue("@NoMax", QuyDinh.SoTienNoToiDa)
            cmd.Parameters.AddWithValue("@QuyDinh4", QuyDinh.SuDungQuyDinh4)
            Dim count = 0
            count = cmd.ExecuteNonQuery()
            If count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
End Class
