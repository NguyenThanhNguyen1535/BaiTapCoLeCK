Imports System.Data
Imports Microsoft.Data.SqlClient
Imports baicole.Models
Imports baicole.Database

Namespace Repositories
    Public Class ChiTietHoaDonRepository
        Private ReadOnly strConn As String = DbConfig.ConnectionString

        Public Function GetAll() As DataTable
            Dim dt As New DataTable()
            Dim query As String = "SELECT MaChiTietHD, SoHoaDon, MaHang, SoLuong FROM ChiTietHoaDon"
            Using conn As New SqlConnection(strConn)
                Using adapter As New SqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using
            Return dt
        End Function

        Public Sub Add(ct As ChiTietHoaDon)
            Dim query As String = "INSERT INTO ChiTietHoaDon (MaChiTietHD, SoHoaDon, MaHang, SoLuong) VALUES (@MaChiTietHD, @SoHoaDon, @MaHang, @SoLuong)"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaChiTietHD", ct.MaChiTietHD)
                    cmd.Parameters.AddWithValue("@SoHoaDon", ct.SoHoaDon)
                    cmd.Parameters.AddWithValue("@MaHang", ct.MaHang)
                    cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(ct As ChiTietHoaDon)
            Dim query As String = "UPDATE ChiTietHoaDon SET SoHoaDon = @SoHoaDon, MaHang = @MaHang, SoLuong = @SoLuong WHERE MaChiTietHD = @MaChiTietHD"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaChiTietHD", ct.MaChiTietHD)
                    cmd.Parameters.AddWithValue("@SoHoaDon", ct.SoHoaDon)
                    cmd.Parameters.AddWithValue("@MaHang", ct.MaHang)
                    cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(maCTHD As String)
            Dim query As String = "DELETE FROM ChiTietHoaDon WHERE MaChiTietHD = @MaChiTietHD"
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaChiTietHD", maCTHD)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function GetDistinct(columnName As String) As DataTable
            Dim dt As New DataTable()
            If columnName <> "MaChiTietHD" AndAlso columnName <> "MaHang" Then
                Throw New ArgumentException("Invalid column name")
            End If
            Dim query As String = $"SELECT DISTINCT {columnName} FROM ChiTietHoaDon"
            Using conn As New SqlConnection(strConn)
                Using adapter As New SqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using
            Return dt
        End Function

        Public Function GetByFilterWithHoaDon(maCTHD As String, soHoaDon As String, maHang As String) As DataTable
            Dim dt As New DataTable()
            Dim query As String = "SELECT CT.MaChiTietHD, CT.SoHoaDon, HD.NgayBan, HD.MaKhachHang, CT.MaHang, CT.SoLuong " &
                                  "FROM ChiTietHoaDon CT " &
                                  "INNER JOIN HoaDon HD ON CT.SoHoaDon = HD.SoHoaDon " &
                                  "WHERE 1=1"
            
            Using conn As New SqlConnection(strConn)
                Using cmd As New SqlCommand()
                    If Not String.IsNullOrEmpty(maCTHD) Then
                        query &= " AND CT.MaChiTietHD = @MaChiTietHD"
                        cmd.Parameters.AddWithValue("@MaChiTietHD", maCTHD)
                    End If
                    If Not String.IsNullOrEmpty(soHoaDon) Then
                        query &= " AND CT.SoHoaDon = @SoHoaDon"
                        cmd.Parameters.AddWithValue("@SoHoaDon", soHoaDon)
                    End If
                    If Not String.IsNullOrEmpty(maHang) Then
                        query &= " AND CT.MaHang = @MaHang"
                        cmd.Parameters.AddWithValue("@MaHang", maHang)
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
    End Class
End Namespace
