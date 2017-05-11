Imports MySql.Data.MySqlClient
Imports DAO
Imports DTO
Public Class TimSachBLL
    Public Shared Function TimSach(ByVal txbMaSach As String, ByVal txbTenSach As String, ByVal txbTheLoai As String, txbTacGia As String) As List(Of SachDTO)
        Return DAO.TimSachDAL.TimSach(txbMaSach, txbTenSach, txbTheLoai, txbTacGia)
    End Function
End Class
