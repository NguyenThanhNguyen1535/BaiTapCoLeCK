Imports Microsoft.Data.SqlClient

Public Class LoaiTheRepository

    ' -------------------------------------------------------------------------
    ' 1. LAY DANH SACH
    ' -------------------------------------------------------------------------
    Public Function KiemTraCoGiaoDich(maLoai As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM GiaoDich WHERE MaLoai = @MaLoai"
        Dim params As SqlParameter() = {New SqlParameter("@MaLoai", maLoai)}
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)
        Return Convert.ToInt32(bangDuLieu.Rows(0)(0)) > 0
    End Function

    ' Lay toan bo Loai The dang hoat dong (TrangThai = 1)
    Public Function GetAll() As DataTable
        Dim query As String = "SELECT MaLoai AS [Mã loại], TenNhaMang AS [Nhà mạng], MenhGia AS [Mệnh giá] " &
                              "FROM LoaiThe WHERE TrangThai = 1"
        Return DatabaseConnection.GetData(query)
    End Function

    ' Lay danh sach ten Nha Mang duy nhat dang hoat dong
    Public Function GetNhaMangList() As List(Of String)
        Dim query As String = "SELECT DISTINCT TenNhaMang FROM LoaiThe WHERE TrangThai = 1"
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query)
        Dim danhSach As New List(Of String)()
        For Each dong As DataRow In bangDuLieu.Rows
            danhSach.Add(dong("TenNhaMang").ToString())
        Next
        Return danhSach
    End Function

    ' Lay danh sach Menh Gia cua mot Nha Mang cu the dang hoat dong
    Public Function GetMenhGiaByNhaMang(nhaMang As String) As List(Of Decimal)
        Dim query As String = "SELECT DISTINCT MenhGia FROM LoaiThe " &
                              "WHERE TenNhaMang = @NhaMang AND TrangThai = 1"
        Dim params As SqlParameter() = {New SqlParameter("@NhaMang", nhaMang)}
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)
        Dim danhSach As New List(Of Decimal)()
        For Each dong As DataRow In bangDuLieu.Rows
            danhSach.Add(Convert.ToDecimal(dong("MenhGia")))
        Next
        Return danhSach
    End Function

    ' Lay toan bo Menh Gia duy nhat dang hoat dong (dung cho form Tim Kiem)
    Public Function GetAllMenhGia() As List(Of Decimal)
        Dim query As String = "SELECT DISTINCT MenhGia FROM LoaiThe WHERE TrangThai = 1 ORDER BY MenhGia"
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query)
        Dim danhSach As New List(Of Decimal)()
        For Each dong As DataRow In bangDuLieu.Rows
            danhSach.Add(Convert.ToDecimal(dong("MenhGia")))
        Next
        Return danhSach
    End Function

    ' Lay MaLoai dua vao Ten Nha Mang va Menh Gia
    ' Tra ve chuoi rong neu khong tim thay
    Public Function GetMaLoai(nhaMang As String, menhGia As Decimal) As String
        Dim query As String = "SELECT MaLoai FROM LoaiThe " &
                              "WHERE TenNhaMang = @NhaMang AND MenhGia = @MenhGia AND TrangThai = 1"
        Dim params As SqlParameter() = {
            New SqlParameter("@NhaMang", nhaMang),
            New SqlParameter("@MenhGia", menhGia)
        }
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)
        If bangDuLieu.Rows.Count = 0 Then Return String.Empty
        Return bangDuLieu.Rows(0)("MaLoai").ToString()
    End Function

    ' Tim kiem Loai The theo Ten Nha Mang hoac Ma Loai (gan dung)
    Public Function Search(tuKhoa As String) As DataTable
        Dim query As String = "SELECT MaLoai AS [Mã loại], TenNhaMang AS [Nhà mạng], MenhGia AS [Mệnh giá] " &
                          "FROM LoaiThe " &
                          "WHERE TrangThai = 1 " &
                          "AND (TenNhaMang LIKE @TimKiem " &
                          "OR MaLoai LIKE @TimKiem " &
                          "OR CAST(CAST(MenhGia AS BIGINT) AS NVARCHAR) LIKE @TimKiem)"

        Dim params As SqlParameter() = {New SqlParameter("@TimKiem", "%" & tuKhoa.Trim() & "%")}
        Return DatabaseConnection.GetData(query, params)
    End Function

    ' -------------------------------------------------------------------------
    ' 2. KIEM TRA TRUNG LAP
    ' -------------------------------------------------------------------------
    Public Function IsDuplicate(nhaMang As String, menhGia As Decimal, excludeMaLoai As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM LoaiThe " &
                              "WHERE TenNhaMang = @NhaMang AND MenhGia = @MenhGia " &
                              "AND TrangThai = 1 AND MaLoai <> @MaLoai"
        Dim params As SqlParameter() = {
            New SqlParameter("@NhaMang", nhaMang),
            New SqlParameter("@MenhGia", menhGia),
            New SqlParameter("@MaLoai", excludeMaLoai)
        }
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)
        Return Convert.ToInt32(bangDuLieu.Rows(0)(0)) > 0
    End Function

    ' -------------------------------------------------------------------------
    ' 3. THEM / SUA / XOA
    ' -------------------------------------------------------------------------

    ' Them moi Loai The thong minh:
    ' Neu MaLoai da ton tai (bi an) -> Kich hoat lai va cap nhat thong tin
    ' Neu chua ton tai -> INSERT moi
    Public Function Insert(loaiThe As LoaiThe) As Integer
        Dim query As String = "IF EXISTS (SELECT 1 FROM LoaiThe WHERE MaLoai = @MaLoai) " &
                              "   UPDATE LoaiThe SET TenNhaMang = @TenNhaMang, MenhGia = @MenhGia, TrangThai = 1 WHERE MaLoai = @MaLoai; " &
                              "ELSE " &
                              "   INSERT INTO LoaiThe (MaLoai, TenNhaMang, MenhGia, TrangThai) VALUES (@MaLoai, @TenNhaMang, @MenhGia, 1);"
        Dim params As SqlParameter() = {
            New SqlParameter("@MaLoai", loaiThe.MaLoai),
            New SqlParameter("@TenNhaMang", loaiThe.TenNhaMang),
            New SqlParameter("@MenhGia", loaiThe.MenhGia)
        }
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

    ' Cap nhat thong tin mot Loai The da co trong CSDL
    Public Function Update(loaiThe As LoaiThe) As Integer
        Dim query As String = "UPDATE LoaiThe SET TenNhaMang = @TenNhaMang, MenhGia = @MenhGia WHERE MaLoai = @MaLoai"
        Dim params As SqlParameter() = {
            New SqlParameter("@MaLoai", loaiThe.MaLoai),
            New SqlParameter("@TenNhaMang", loaiThe.TenNhaMang),
            New SqlParameter("@MenhGia", loaiThe.MenhGia)
        }
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

    ' Xoa thong minh:
    ' Neu Loai The co giao dich -> Xoa mem (TrangThai = 0)
    ' Neu chua co giao dich nao -> Xoa cung (DELETE)
    Public Function Delete(maLoai As String) As Integer
        Dim query As String = "IF EXISTS (SELECT 1 FROM GiaoDich WHERE MaLoai = @MaLoai) " &
                              "   UPDATE LoaiThe SET TrangThai = 0 WHERE MaLoai = @MaLoai; " &
                              "ELSE " &
                              "   DELETE FROM LoaiThe WHERE MaLoai = @MaLoai;"
        Dim params As SqlParameter() = {New SqlParameter("@MaLoai", maLoai)}
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

End Class
