Public Class ThamSoDTO

    Public Sub New()
        _SoLuongNhapToiThieu = 150
        _SoLuongTonToiDaTruocKhiNhap = 300
        _SoTienNoToiDa = 20000
        _SoLuongTonToiThieuSauKhiBan = 20
        _SuDungQuyDinh4 = True
    End Sub

    Dim _SoLuongNhapToiThieu As Integer
    Dim _SoLuongTonToiDaTruocKhiNhap As Integer
    Dim _SoTienNoToiDa As Decimal
    Dim _SoLuongTonToiThieuSauKhiBan As Integer
    Dim _SuDungQuyDinh4 As Boolean

    Public Property SoLuongNhapToiThieu As Integer
        Get
            Return _SoLuongNhapToiThieu
        End Get
        Set(value As Integer)
            _SoLuongNhapToiThieu = value
        End Set
    End Property

    Public Property SoLuongTonToiDaTruocKhiNhap As Integer
        Get
            Return _SoLuongTonToiDaTruocKhiNhap
        End Get
        Set(value As Integer)
            _SoLuongTonToiDaTruocKhiNhap = value
        End Set
    End Property

    Public Property SoTienNoToiDa As Decimal
        Get
            Return _SoTienNoToiDa
        End Get
        Set(value As Decimal)
            _SoTienNoToiDa = value
        End Set
    End Property

    Public Property SoLuongTonToiThieuSauKhiBan As Integer
        Get
            Return _SoLuongTonToiThieuSauKhiBan
        End Get
        Set(value As Integer)
            _SoLuongTonToiThieuSauKhiBan = value
        End Set
    End Property

    Public Property SuDungQuyDinh4 As Boolean
        Get
            Return _SuDungQuyDinh4
        End Get
        Set(value As Boolean)
            _SuDungQuyDinh4 = value
        End Set
    End Property
End Class
