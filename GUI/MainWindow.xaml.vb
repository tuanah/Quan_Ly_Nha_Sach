Imports System.Data
Imports MySql.Data.MySqlClient
'Imports MySql.Data.MySqlClient
Imports MahApps.Metro.Controls
Imports BUS
Class MainWindow

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        bansach.dtgBanSach.CanUserAddRows = True
        bansach.dtgBanSach.IsReadOnly = False

        Dim listMaKH As New List(Of String)
        listMaKH = LoadDataBLL.LoadMaKH()
        Dim i = 0
        While i < listMaKH.Count
            bansach.cbbMaKH.Items.Add(listMaKH.Item(i))
            i = i + 1
        End While

        Dim listMaSach As New List(Of String)
        listMaSach = LoadDataBLL.LoadMaSach()
        i = 0
        While i < listMaSach.Count
            bansach.cbbMaSachBan.Items.Add(listMaSach.Item(i))
            ui_nhapsach.cmbMaSach.Items.Add(listMaSach.Item(i))
            i = i + 1
        End While


    End Sub

End Class
