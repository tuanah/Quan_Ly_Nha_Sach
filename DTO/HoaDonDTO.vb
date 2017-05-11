Public Class HoaDonDTO
    Shared _MaMoiNhat As String
    Dim _MaHoaDon As String
    Dim _MaKhachHang As String
    Dim _NgayLapHoaDon As String
    Dim _TongTien As Double

    Public Shared Property MaMoiNhat As String
        Get
            Return _MaMoiNhat
        End Get
        Set(value As String)
            _MaMoiNhat = value
        End Set
    End Property

    Public Property MaHoaDon As String
        Get
            Return _MaHoaDon
        End Get
        Set(value As String)
            _MaHoaDon = value
        End Set
    End Property

    Public Property MaKhachHang As String
        Get
            Return _MaKhachHang
        End Get
        Set(value As String)
            _MaKhachHang = value
        End Set
    End Property

    Public Property NgayLapHoaDon As String
        Get
            Return _NgayLapHoaDon
        End Get
        Set(value As String)
            _NgayLapHoaDon = value
        End Set
    End Property

    Public Property TongTien As Double
        Get
            Return _TongTien
        End Get
        Set(value As Double)
            _TongTien = value
        End Set
    End Property
End Class
