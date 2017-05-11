Public Class PhieuNhapDTO
    Shared _MaMoiNhat As String
    Dim _MaPhieuNhap As String
    Dim _NgayNhap As DateTime

    Public Shared Property MaMoiNhat As String
        Get
            Return _MaMoiNhat
        End Get
        Set(value As String)
            _MaMoiNhat = value
        End Set
    End Property

    Public Property MaPhieuNhap As String
        Get
            Return _MaPhieuNhap
        End Get
        Set(value As String)
            _MaPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return _NgayNhap
        End Get
        Set(value As Date)
            _NgayNhap = value
        End Set
    End Property
End Class
