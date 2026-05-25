Imports System.Data
Imports Microsoft.Data.SqlClient
Imports baicole.Models
Imports baicole.Database

Namespace Repositories
    Public Class HoaDonRepository
        Private ReadOnly strConn As String = DbConfig.ConnectionString

        Public Function GetAll() As DataTable
            Dim dt As New DataTable()
            Dim query As String = "SELECT SoHoaDon, NgayBan, MaKhachHang, MaNhanVien FROM HoaDon"
            Using conn As New SqlConnection(strConn)
                Using adapter As New SqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using
            Return dt
        End Function

        Public Function GetByFilter(soHoaDon As String, maKH As String, maNV As String) As DataTable
            Dim dt As New DataTable()
            Dim query As String = "SELECT SoHoaDon, NgayBan, MaKhachHang, MaNhanVien FROM HoaDon WHERE 1=1"
            
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand()
                    If Not String.IsNullOrEmpty(soHoaDon) Then
                        query &= " AND SoHoaDon = @SoHoaDon"
                        cmd.Parameters.AddWithValue("@SoHoaDon", soHoaDon)
                    End If
                    If Not String.IsNullOrEmpty(maKH) Then
                        query &= " AND MaKhachHang = @MaKhachHang"
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKH)
                    End If
                    If Not String.IsNullOrEmpty(maNV) Then
                        query &= " AND MaNhanVien = @MaNhanVien"
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNV)
                    End If
                    
                    cmd.CommandText = query
                    cmd.Connection = conn
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        Public Sub Add(hd As HoaDon)
            Dim query As String = "INSERT INTO HoaDon (SoHoaDon, NgayBan, MaKhachHang, MaNhanVien) VALUES (@SoHoaDon, @NgayBan, @MaKhachHang, @MaNhanVien)"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SoHoaDon", hd.SoHoaDon)
                    cmd.Parameters.AddWithValue("@NgayBan", hd.NgayBan)
                    cmd.Parameters.AddWithValue("@MaKhachHang", hd.MaKhachHang)
                    cmd.Parameters.AddWithValue("@MaNhanVien", hd.MaNhanVien)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(hd As HoaDon)
            Dim query As String = "UPDATE HoaDon SET NgayBan = @NgayBan, MaKhachHang = @MaKhachHang, MaNhanVien = @MaNhanVien WHERE SoHoaDon = @SoHoaDon"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SoHoaDon", hd.SoHoaDon)
                    cmd.Parameters.AddWithValue("@NgayBan", hd.NgayBan)
                    cmd.Parameters.AddWithValue("@MaKhachHang", hd.MaKhachHang)
                    cmd.Parameters.AddWithValue("@MaNhanVien", hd.MaNhanVien)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function Delete(soHoaDon As String) As Integer
            Dim query As String = "DELETE FROM HoaDon WHERE SoHoaDon = @SoHoaDon"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SoHoaDon", soHoaDon)
                    conn.Open()
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        End Function

        Public Function GetDistinct(columnName As String) As DataTable
            Dim dt As New DataTable()
            ' Ensure columnName is one of the allowed columns to prevent SQL injection
            If columnName <> "SoHoaDon" AndAlso columnName <> "MaKhachHang" AndAlso columnName <> "MaNhanVien" Then
                Throw New ArgumentException("Invalid column name")
            End If
            Dim query As String = $"SELECT DISTINCT {columnName} FROM HoaDon"
            Using conn As New SqlConnection(strConn)
                Using adapter As New SqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using
            Return dt
        End Function
    End Class
End Namespace
