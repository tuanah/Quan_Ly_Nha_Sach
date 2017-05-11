Imports MySql.Data.MySqlClient
Imports System.Windows
Public Class XoaSachDAL
    Public Shared Function XoaSach(ByVal MaSach As String) As Boolean
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=root;database=quanlynhasach")
            Try
                con.Open()
                Dim query = "delete from Sach where MaSach = @MaSach"
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MaSach", MaSach)
                Dim count = 0
                count = cmd.ExecuteNonQuery()
                If (count > 0) Then
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function
End Class
