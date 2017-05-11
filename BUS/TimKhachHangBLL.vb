Imports DTO
Imports DAO
Public Class TimKhachHangBLL
    Public Shared Function TimKhachHang(ByVal txbMaKhachHang As String, ByVal txbTenKhachHang As String, ByVal txbDiaChi As String, ByVal txbSDT As String, ByVal txbEmail As String, ByVal txbTienNo As String) As List(Of KhachHangDTO)
        Return TimKhachHangDAL.TimKhachHang(txbMaKhachHang, txbTenKhachHang, txbDiaChi, txbSDT, txbEmail, txbTienNo)
    End Function
End Class
