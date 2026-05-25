Imports Microsoft.Data.SqlClient

Public Class GiaoDichRepository

    ' -------------------------------------------------------------------------
    ' 1. LAY DANH SACH
    ' -------------------------------------------------------------------------
    Public Function GetAll() As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.SoDienThoai AS [Số điện thoại], " &
                              "KH.HoTen AS [Tên khách hàng], LT.TenNhaMang AS [Nhà mạng], " &
                              "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền] " &
                              "FROM GiaoDich GD " &
                              "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                              "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai"
        Return DatabaseConnection.GetData(query)
    End Function

    Public Function GetActiveTransactions() As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.SoDienThoai AS [Số điện thoại], " &
                          "KH.HoTen AS [Tên khách hàng], LT.TenNhaMang AS [Nhà mạng], " &
                          "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền] " &
                          "FROM GiaoDich GD " &
                          "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                          "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai " &
                          "WHERE KH.TrangThai = 1 AND LT.TrangThai = 1"

        Return DatabaseConnection.GetData(query)
    End Function
    Public Function Search(tuKhoa As String) As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.SoDienThoai AS [Số điện thoại], " &
                          "KH.HoTen AS [Tên khách hàng], LT.TenNhaMang AS [Nhà mạng], " &
                          "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền] " &
                          "FROM GiaoDich GD " &
                          "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                          "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai " &
                          "WHERE KH.TrangThai = 1 AND LT.TrangThai = 1 " &
                          "AND (GD.MaGD LIKE @TimKiem OR KH.SoDienThoai LIKE @TimKiem OR KH.HoTen LIKE @TimKiem)"
        Dim params As SqlParameter() = {New SqlParameter("@TimKiem", "%" & tuKhoa & "%")}
        Return DatabaseConnection.GetData(query, params)
    End Function
    Public Function SearchWithFilter(tenKhachHang As String, soDienThoai As String,
                                     nhaMang As String, menhGia As String,
                                     tuNgay As DateTime, denNgay As DateTime) As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.HoTen AS [Tên khách hàng], " &
                              "KH.SoDienThoai AS [Số điện thoại], LT.TenNhaMang AS [Nhà mạng], " &
                              "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền] " &
                              "FROM GiaoDich GD " &
                              "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                              "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai " &
                              "WHERE 1=1 "

        Dim danhSachParams As New List(Of SqlParameter)()

        If Not String.IsNullOrWhiteSpace(tenKhachHang) Then
            query &= " AND KH.HoTen LIKE @HoTen"
            danhSachParams.Add(New SqlParameter("@HoTen", "%" & tenKhachHang.Trim() & "%"))
        End If

        If Not String.IsNullOrWhiteSpace(soDienThoai) Then
            query &= " AND KH.SoDienThoai LIKE @SDT"
            danhSachParams.Add(New SqlParameter("@SDT", "%" & soDienThoai.Trim() & "%"))
        End If

        If Not String.IsNullOrWhiteSpace(nhaMang) Then
            query &= " AND LT.TenNhaMang = @TenNhaMang"
            danhSachParams.Add(New SqlParameter("@TenNhaMang", nhaMang))
        End If

        If Not String.IsNullOrWhiteSpace(menhGia) Then
            Dim soMenhGia As Decimal = 0
            If Decimal.TryParse(menhGia, soMenhGia) Then
                query &= " AND LT.MenhGia = @MenhGia"
                danhSachParams.Add(New SqlParameter("@MenhGia", soMenhGia))
            End If
        End If
        query &= " AND GD.NgayGD BETWEEN @TuNgay AND @DenNgay"
        danhSachParams.Add(New SqlParameter("@TuNgay", tuNgay.Date))
        danhSachParams.Add(New SqlParameter("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1)))

        query &= " ORDER BY GD.NgayGD DESC"

        Return DatabaseConnection.GetData(query, danhSachParams.ToArray())
    End Function
    Public Function GetByMaGD(maGD As String) As GiaoDich
        Dim query As String = "SELECT MaGD, MaKH, MaLoai, NgayGD, TongTien FROM GiaoDich WHERE MaGD = @MaGD"
        Dim params As SqlParameter() = {New SqlParameter("@MaGD", maGD)}
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)

        If bangDuLieu.Rows.Count = 0 Then Return Nothing

        Dim dong As DataRow = bangDuLieu.Rows(0)
        Dim giaoDich As New GiaoDich()
        giaoDich.MaGD = dong("MaGD").ToString()
        giaoDich.MaKH = dong("MaKH").ToString()
        giaoDich.MaLoai = dong("MaLoai").ToString()
        giaoDich.NgayGD = Convert.ToDateTime(dong("NgayGD"))
        giaoDich.TongTien = Convert.ToDecimal(dong("TongTien"))
        Return giaoDich
    End Function

    ' -------------------------------------------------------------------------
    ' 2. THEM GIAO DICH (Co kiem tra so du + Transaction)
    ' -------------------------------------------------------------------------
    Public Function Insert(giaoDich As GiaoDich, soDuHienTai As Decimal) As Boolean
        If soDuHienTai < giaoDich.TongTien Then
            Throw New Exception("So du trong vi cua khach hang khong du de mua the!")
        End If

        Dim query As String =
            "INSERT INTO GiaoDich (MaGD, MaKH, MaLoai, NgayGD, TongTien) " &
            "VALUES (@MaGD, @MaKH, @MaLoai, GETDATE(), @TongTien); " &
            "UPDATE KhachHang SET SoDu = SoDu - @TongTien WHERE MaKH = @MaKH;"

        Dim params As SqlParameter() = {
            New SqlParameter("@MaGD", giaoDich.MaGD),
            New SqlParameter("@MaKH", giaoDich.MaKH),
            New SqlParameter("@MaLoai", giaoDich.MaLoai),
            New SqlParameter("@TongTien", giaoDich.TongTien)
        }

        Dim soHangAnh As Integer = DatabaseConnection.ExecuteQuery(query, params)
        Return soHangAnh > 0
    End Function

    ' -------------------------------------------------------------------------
    ' 3. XOA / HUY GIAO DICH (Co hoan tien + Transaction)
    ' -------------------------------------------------------------------------
    Public Function Delete(maGD As String) As Boolean
        Dim giaoDichCanXoa As GiaoDich = GetByMaGD(maGD)
        If giaoDichCanXoa Is Nothing Then
            Throw New Exception("Khong tim thay giao dich tren he thong!")
        End If

        Dim query As String =
            "UPDATE KhachHang SET SoDu = SoDu + @TongTien WHERE MaKH = @MaKH; " &
            "DELETE FROM GiaoDich WHERE MaGD = @MaGD;"

        Dim params As SqlParameter() = {
            New SqlParameter("@MaGD", giaoDichCanXoa.MaGD),
            New SqlParameter("@MaKH", giaoDichCanXoa.MaKH),
            New SqlParameter("@TongTien", giaoDichCanXoa.TongTien)
        }

        Dim soHangAnh As Integer = DatabaseConnection.ExecuteQuery(query, params)
        Return soHangAnh > 0
    End Function
    Public Function GetTransactionReportWithFilter(tenKhachHang As String, soDienThoai As String,
                                                   nhaMang As String, menhGia As String,
                                                   tuNgay As DateTime, denNgay As DateTime) As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.HoTen AS [Tên khách hàng], " &
                              "KH.SoDienThoai AS [Số điện thoại], LT.TenNhaMang AS [Nhà mạng], " &
                              "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền], " &
                              "KH.TrangThai AS [Trạng thái KH], LT.TrangThai AS [Trạng thái LT] " &
                              "FROM GiaoDich GD " &
                              "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                              "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai " &
                              "WHERE 1=1 "

        Dim danhSachParams As New List(Of SqlParameter)()

        If Not String.IsNullOrWhiteSpace(tenKhachHang) Then
            query &= " AND KH.HoTen LIKE @HoTen"
            danhSachParams.Add(New SqlParameter("@HoTen", "%" & tenKhachHang.Trim() & "%"))
        End If

        If Not String.IsNullOrWhiteSpace(soDienThoai) Then
            query &= " AND KH.SoDienThoai LIKE @SDT"
            danhSachParams.Add(New SqlParameter("@SDT", "%" & soDienThoai.Trim() & "%"))
        End If

        If Not String.IsNullOrWhiteSpace(nhaMang) Then
            query &= " AND LT.TenNhaMang = @TenNhaMang"
            danhSachParams.Add(New SqlParameter("@TenNhaMang", nhaMang))
        End If

        If Not String.IsNullOrWhiteSpace(menhGia) Then
            Dim soMenhGia As Decimal = 0
            If Decimal.TryParse(menhGia, soMenhGia) Then
                query &= " AND LT.MenhGia = @MenhGia"
                danhSachParams.Add(New SqlParameter("@MenhGia", soMenhGia))
            End If
        End If

        query &= " AND GD.NgayGD BETWEEN @TuNgay AND @DenNgay"
        danhSachParams.Add(New SqlParameter("@TuNgay", tuNgay.Date))
        danhSachParams.Add(New SqlParameter("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1)))

        query &= " ORDER BY GD.NgayGD DESC"

        Return DatabaseConnection.GetData(query, danhSachParams.ToArray())
    End Function
    Public Function GetDoanhThuReport(tuNgay As DateTime?, denNgay As DateTime?, nhaMang As String) As DataTable
        Dim query As String = "SELECT GD.MaGD AS [Mã giao dịch], KH.SoDienThoai AS [Số điện thoại], " &
                              "KH.HoTen AS [Tên khách hàng], LT.TenNhaMang AS [Nhà mạng], " &
                              "LT.MenhGia AS [Mệnh giá], GD.NgayGD AS [Ngày giao dịch], GD.TongTien AS [Tổng tiền] " &
                              "FROM GiaoDich GD " &
                              "INNER JOIN KhachHang KH ON GD.MaKH = KH.MaKH " &
                              "INNER JOIN LoaiThe LT ON GD.MaLoai = LT.MaLoai " &
                              "WHERE 1=1 "

        Dim danhSachParams As New List(Of SqlParameter)()

        If tuNgay.HasValue AndAlso denNgay.HasValue Then
            query &= " AND GD.NgayGD BETWEEN @TuNgay AND @DenNgay"
            danhSachParams.Add(New SqlParameter("@TuNgay", tuNgay.Value.Date))
            danhSachParams.Add(New SqlParameter("@DenNgay", denNgay.Value.Date.AddDays(1).AddSeconds(-1)))
        End If

        If Not String.IsNullOrWhiteSpace(nhaMang) Then
            query &= " AND LT.TenNhaMang = @TenNhaMang"
            danhSachParams.Add(New SqlParameter("@TenNhaMang", nhaMang))
        End If

        query &= " ORDER BY GD.NgayGD ASC"

        Return DatabaseConnection.GetData(query, danhSachParams.ToArray())
    End Function
End Class
