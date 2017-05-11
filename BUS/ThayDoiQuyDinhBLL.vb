Imports DTO
Imports DAO
Public Class ThayDoiQuyDinhBLL
    Public Shared Function ThayDoiQuyDinh(ByVal QuyDinh As ThamSoDTO) As Boolean
        Return ThayDoiQuyDinhDAL.ThayDoiQuyDinh(QuyDinh)
    End Function
End Class
