Imports BUS
Imports DTO
Public Class ui_NhapSach
    Dim listSach As New List(Of SachDTO)
    Dim listNhapSach As New List(Of NhapSachDTO)
    Dim STT As Integer = 0
    Dim nhapThanhCong As Boolean = False
    Dim NgayNhap As Date

    Private Sub btnNhap_Click(sender As Object, e As RoutedEventArgs) Handles btnNhap.Click
        If (cmbMaSach.SelectedValue = String.Empty) Then
            MessageBox.Show("Đề nghị chọn mã sách", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If

        If (txbSoLuongNhap.Text = String.Empty) Then
            MessageBox.Show("Đề nghị chọn mã sách", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End If

        Try
            NgayNhap = Date.Parse(txbNgayNhap.Text)
        Catch ex As Exception
            MessageBox.Show("Ngày nhập không hợp lệ!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
            Return
        End Try
        Dim tsDTO As ThamSoDTO = New ThamSoDTO()
        Dim checkFound As Boolean
        Dim Sach As SachDTO = New DTO.SachDTO
        Dim nhapsachDTO As NhapSachDTO = New NhapSachDTO
        Dim sln As Integer
        Try
            sln = Integer.Parse(txbSoLuongNhap.Text)
            Sach = BUS.NhapSachBLL.TimSach(cmbMaSach.SelectedValue, checkFound)
            If checkFound = True Then
                If (Sach.SoLuong >= tsDTO.SoLuongTonToiDaTruocKhiNhap) Then
                    MessageBox.Show("Số lượng tồn lớn hơn " + tsDTO.SoLuongTonToiDaTruocKhiNhap + ". Xin kiểm tra lại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error)
                ElseIf sln < tsDTO.SoLuongNhapToiThieu Then
                    MessageBox.Show("Số lượng nhập nhỏ hơn " + tsDTO.SoLuongNhapToiThieu + ". Xin kiểm tra lại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error)
                Else
                    listSach.Add(Sach)
                    STT = STT + 1
                    nhapsachDTO.STT = STT
                    nhapsachDTO.MaSach = Sach.MaSach
                    nhapsachDTO.TenSach = Sach.TenSach
                    nhapsachDTO.TacGia = Sach.TacGia
                    nhapsachDTO.SoLuongTonCu = Sach.SoLuong
                    nhapsachDTO.SoLuongNhap = sln
                    nhapsachDTO.SoLuongTonMoi = nhapsachDTO.SoLuongTonCu + nhapsachDTO.SoLuongNhap
                    If (BUS.NhapSachBLL.NhapSach(nhapsachDTO, nhapsachDTO.SoLuongTonCu) = True) Then
                        listNhapSach.Add(nhapsachDTO)
                        dtgNhapSach.Items.Add(nhapsachDTO)
                        MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information)
                        nhapThanhCong = True
                    Else
                        MessageBox.Show("Nhập không thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Số lượng nhập không hợp lệ. Xin kiểm tra lại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub

    Private Sub btnHoanThanh_Click(sender As Object, e As RoutedEventArgs) Handles btnHoanThanh.Click
        If (nhapThanhCong = True) Then
            Dim PhieuNhap As PhieuNhapDTO = New PhieuNhapDTO()
            PhieuNhap.MaPhieuNhap = GetMaPN()
            PhieuNhap.NgayNhap = NgayNhap
            If NhapSachBLL.ThemPhieuNhap(PhieuNhap) = True Then
                Dim i = 0
                While i < listNhapSach.Count
                    Dim CTPN As ChiTietPhieuNhapDTO = New ChiTietPhieuNhapDTO()
                    CTPN.MaChiTietPhieuNhap = GetMaCTPN()
                    CTPN.MaPhieuNhap = PhieuNhap.MaPhieuNhap
                    CTPN.MaSach = listNhapSach.Item(i).MaSach
                    CTPN.SoLuongNhap = listNhapSach.Item(i).SoLuongNhap
                    NhapSachBLL.ThemChiTietPhieuNhap(CTPN)
                    i = i + 1
                End While
            End If
        End If
    End Sub

    Private Function GetMaPN() As String
        If (NhapSachBLL.GetMaPN() = True) Then
            Dim temp = PhieuNhapDTO.MaMoiNhat.Remove(0, 2)
            temp = (Integer.Parse(temp) + 1).ToString()
            Dim MaPN As String = "PN"
            For index = 0 To 3 - temp.Length
                MaPN += "0"
            Next
            MaPN += temp
            HoaDonDTO.MaMoiNhat = MaPN
            Return MaPN
        Else
            PhieuNhapDTO.MaMoiNhat = "PN0000"
            Return "PN0000"
        End If
    End Function

    Private Function GetMaCTPN() As String
        If (NhapSachBLL.GetMaCTPN() = True) Then
            Dim temp = ChiTietPhieuNhapDTO.MaMoiNhat.Remove(0, 2)
            temp = (Integer.Parse(temp) + 1).ToString()
            Dim MaCTPN As String = "CTPN"
            For index = 0 To 3 - temp.Length
                MaCTPN += "0"
            Next
            MaCTPN += temp
            ChiTietHoaDonDTO.MaMoiNhat = MaCTPN
            Return MaCTPN
        Else
            ChiTietPhieuNhapDTO.MaMoiNhat = "CTPN0000"
            Return "CTPN0000"
        End If
    End Function
End Class
