Imports DAO
Public Class LoadDataBLL
    Public Shared Function LoadMaKH() As List(Of String)
        Return LoadDataDAL.LoadMaKH()
    End Function

    Public Shared Function LoadMaSach() As List(Of String)
        Return LoadDataDAL.LoadMaSach()
    End Function
End Class
