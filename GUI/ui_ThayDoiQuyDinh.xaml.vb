Imports BUS
Imports DTO
Public Class ui_ThayDoiQuyDinh
    Private Sub btnCapNhap_Click(sender As Object, e As RoutedEventArgs) Handles btnCapNhap.Click
        Dim QuyDinhMoi As ThamSoDTO = New ThamSoDTO()
        Try
            QuyDinhMoi.SoLuongNhapToiThieu = Integer.Parse(txbSoLuongNhapToiThieu.Text)
        Catch ex As Exception
            MessageBox.Show("Định dạng không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End Try

        Try
            QuyDinhMoi.SoLuongTonToiDaTruocKhiNhap = Integer.Parse(txbSoLuongTonTruocKhiNhap.Text)
        Catch ex As Exception
            MessageBox.Show("Định dạng không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End Try

        Try
            QuyDinhMoi.SoLuongTonToiThieuSauKhiBan = Integer.Parse(txbLuongTonToiThieuSauKhiBan.Text)
        Catch ex As Exception
            MessageBox.Show("Định dạng không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End Try

        Try
            QuyDinhMoi.SoTienNoToiDa = Integer.Parse(txbTienNoToiDa.Text)
        Catch ex As Exception
            MessageBox.Show("Định dạng không hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End Try

        If (ThayDoiQuyDinhBLL.ThayDoiQuyDinh(QuyDinhMoi) = True) Then
            MessageBox.Show("Cập nhập thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        Else
            MessageBox.Show("Cập nhập không thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information)
        End If
    End Sub
End Class
