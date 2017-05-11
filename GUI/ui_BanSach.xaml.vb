Imports System.Data
Imports BUS
Imports DTO

Public Class ui_BanSach
    Dim NgayLapHoaDon As String
    Dim BanThanhCong As Boolean = False

    Private Sub cbbMaKH_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cbbMaKH.SelectionChanged
        getTen_No()
    End Sub
    Private Sub getTen_No()
        Dim Ten_No As New List(Of String)
        Dim MaKH As String = cbbMaKH.SelectedValue

        Ten_No = BanSachBLL.getTen_No(MaKH)
        txbTenKH.Text = Ten_No.Item(0)
        txbTienNo.Text = Ten_No.Item(1)
    End Sub



    Dim ListBanSach As New List(Of BanSach)
    Dim STT = 1
    Dim check As Boolean
    Private Sub btnXacNhan_Click(sender As Object, e As RoutedEventArgs) Handles btnXacNhan.Click
        Dim SoLuongBan As Integer
        If (txbNgayLapHoaDon.Text = String.Empty) Then
            NgayLapHoaDon = DateTime.Now.ToShortDateString()
        Else
            Try
                NgayLapHoaDon = DateTime.Parse(txbNgayLapHoaDon.Text).ToShortDateString
            Catch ex As Exception
                MessageBox.Show("Ngày nhập không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
                Return
            End Try
        End If
        If (cbbMaKH.SelectedValue = String.Empty) Then
            MessageBox.Show("Đề nghị chọn mã khách hàng", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If
        If (cbbMaSachBan.SelectedValue = String.Empty) Then
            MessageBox.Show("Đề nghị chọn mã sách", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If
        If (txbSoLuongBan.Text = String.Empty) Then
            MessageBox.Show("Đề nghị nhập số lượng bán", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        Else
            Try
                SoLuongBan = Integer.Parse(txbSoLuongBan.Text)
            Catch ex As Exception
                MessageBox.Show("Số lượng bán không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            End Try
        End If

        Dim MaSach = cbbMaSachBan.SelectedValue
        Dim BanSach As BanSach = New BanSach()
        Dim checkFound As Boolean = False
        Dim Sach As SachDTO = NhapSachBLL.TimSach(MaSach, checkFound)
        BanSach.STT = STT
        BanSach.TenSach = Sach.TenSach
        BanSach.MaSach = Sach.MaSach
        BanSach.SoLuongBan = txbSoLuongBan.Text
        BanSach.SoLuongTonSauKhiBan = Sach.SoLuong - SoLuongBan
        BanSach.DonGia = Sach.DonGia
        BanSach.ThanhTien = Sach.DonGia * SoLuongBan
        STT = STT + 1
        If (BanSach.SoLuongTonSauKhiBan < 20) Then
            MessageBox.Show("Số lượng sách còn lại nhỏ hơn 20. Không thể bán!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If
        If (Integer.Parse(txbTienNo.Text) > 20000) Then
            MessageBox.Show("Khách hàng nợ quá nhiều. Không thể bán!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If
        check = BanSachBLL.BanSach(cbbMaSachBan.SelectedValue, BanSach.SoLuongTonSauKhiBan)
        If (check = True) Then
            Dim TongTien As String = lblTongTien.Content
            TongTien = TongTien.Remove(TongTien.Length - 2, 2)
            lblTongTien.Content = (Double.Parse(TongTien) + BanSach.DonGia * BanSach.SoLuongBan).ToString() + " đ"
            ListBanSach.Add(BanSach)
            dtgBanSach.ItemsSource = Nothing
            dtgBanSach.Items.Clear()
            dtgBanSach.ItemsSource = ListBanSach
            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            BanThanhCong = True
        Else
            MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End If
    End Sub

    Private Sub btnXoaSachVuaBan_Click(sender As Object, e As RoutedEventArgs)
        If ListBanSach.Count > 0 Then
            Dim check As Boolean
            Dim sachBan As BanSach = ListBanSach.Item(ListBanSach.Count - 1)
            check = BanSachBLL.XoaSachVuaBan(sachBan.MaSach, sachBan.SoLuongTonSauKhiBan + sachBan.SoLuongBan)
            If (check = True) Then
                ListBanSach.RemoveAt(ListBanSach.Count - 1)
                dtgBanSach.ItemsSource = Nothing
                dtgBanSach.Items.Clear()
                dtgBanSach.ItemsSource = ListBanSach
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Else
                MessageBox.Show("Xóa không thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            End If
        End If
    End Sub

    Private Sub btnHoanThanh_Click(sender As Object, e As RoutedEventArgs) Handles btnHoanThanh.Click
        If BanThanhCong = True Then
            Try
                Dim HoaDon As HoaDonDTO = New HoaDonDTO()
                HoaDon.MaHoaDon = GetMaHD()
                HoaDon.MaKhachHang = cbbMaKH.SelectedValue
                HoaDon.NgayLapHoaDon = NgayLapHoaDon
                Dim TongTien As String = lblTongTien.Content
                TongTien = TongTien.Remove(TongTien.Length - 2, 2)
                HoaDon.TongTien = TongTien
                If BanSachBLL.ThemHD(HoaDon) = True Then
                    Dim i = 0
                    While i < ListBanSach.Count
                        Dim CTHD As ChiTietHoaDonDTO = New ChiTietHoaDonDTO()
                        CTHD.MaChiTietHoaDon = GetMaCTHD()
                        CTHD.MaHoaDon = HoaDon.MaHoaDon
                        CTHD.MaSach = ListBanSach.Item(i).MaSach
                        CTHD.SoLuongBan = ListBanSach.Item(i).SoLuongBan
                        CTHD.ThanhTien = ListBanSach.Item(i).ThanhTien
                        BanSachBLL.ThemCTHD(CTHD)
                        i = i + 1
                    End While
                End If
                ListBanSach.Clear()
                lblTongTien.Content = "0 đ"
                MessageBox.Show("Hoàn thành", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Function GetMaHD() As String
        If (BanSachBLL.GetMaHD() = True) Then
            Dim temp = HoaDonDTO.MaMoiNhat.Remove(0, 2)
            temp = (Integer.Parse(temp) + 1).ToString()
            Dim MaHD As String = "HD"
            For index = 0 To 3 - temp.Length
                MaHD += "0"
            Next
            MaHD += temp
            HoaDonDTO.MaMoiNhat = MaHD
            Return MaHD
        Else
            HoaDonDTO.MaMoiNhat = "HD0000"
            Return "HD0000"
        End If
    End Function
    Private Function GetMaCTHD() As String
        If (BanSachBLL.GetMaCTHD() = True) Then
            Dim temp = ChiTietHoaDonDTO.MaMoiNhat.Remove(0, 2)
            temp = (Integer.Parse(temp) + 1).ToString()
            Dim MaCTHD As String = "CTHD"
            For index = 0 To 3 - temp.Length
                MaCTHD += "0"
            Next
            MaCTHD += temp
            ChiTietHoaDonDTO.MaMoiNhat = MaCTHD
            Return MaCTHD
        Else
            ChiTietHoaDonDTO.MaMoiNhat = "CTHD0000"
            Return "CTHD0000"
        End If
    End Function
End Class

Public Class BanSach
    Dim _STT As String
    Dim _MaSach As String
    Dim _TenSach As String
    Dim _SoLuongBan As Integer
    Dim _SoLuongTonSauKhiBan As Integer
    Dim _DonGia As Double
    Dim _ThanhTien As Double

    Public Property STT As String
        Get
            Return _STT
        End Get
        Set(value As String)
            _STT = value
        End Set
    End Property

    Public Property MaSach As String
        Get
            Return _MaSach
        End Get
        Set(value As String)
            _MaSach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return _TenSach
        End Get
        Set(value As String)
            _TenSach = value
        End Set
    End Property

    Public Property SoLuongBan As Integer
        Get
            Return _SoLuongBan
        End Get
        Set(value As Integer)
            _SoLuongBan = value
        End Set
    End Property

    Public Property SoLuongTonSauKhiBan As Integer
        Get
            Return _SoLuongTonSauKhiBan
        End Get
        Set(value As Integer)
            _SoLuongTonSauKhiBan = value
        End Set
    End Property

    Public Property DonGia As Single
        Get
            Return _DonGia
        End Get
        Set(value As Single)
            _DonGia = value
        End Set
    End Property

    Public Property ThanhTien As Double
        Get
            Return _ThanhTien
        End Get
        Set(value As Double)
            _ThanhTien = value
        End Set
    End Property
End Class