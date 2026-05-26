Imports Microsoft.Data.SqlClient

Public Class KhachHangRepository

    ' -------------------------------------------------------------------------
    ' 1. LAY DANH SACH
    ' -------------------------------------------------------------------------
    Public Function KiemTraCoGiaoDich(maKH As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM GiaoDich WHERE MaKH = @MaKH"
        Dim params As SqlParameter() = {New SqlParameter("@MaKH", maKH)}
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)
        Return Convert.ToInt32(bangDuLieu.Rows(0)(0)) > 0
    End Function

    ' Lay toan bo khach hang dang hoat dong (TrangThai = 1)
    Public Function GetAll() As DataTable
        Dim query As String = "SELECT MaKH AS [Mã khách hàng], HoTen AS [Họ và tên], " &
                              "SoDienThoai AS [Số điện thoại], SoDu AS [Số dư] " &
                              "FROM KhachHang WHERE TrangThai = 1"
        Return DatabaseConnection.GetData(query)
    End Function

    ' Tim kiem khach hang theo Ten hoac So dien thoai (gan dung)
    Public Function Search(tuKhoa As String) As DataTable
        Dim query As String = "SELECT MaKH AS [Mã khách hàng], HoTen AS [Họ và tên], " &
                          "SoDienThoai AS [Số điện thoại], SoDu AS [Số dư] " &
                          "FROM KhachHang WHERE TrangThai = 1 " &
                          "AND (HoTen LIKE @TimKiem " &
                          "OR SoDienThoai LIKE @TimKiem " &
                          "OR MaKH LIKE @TimKiem)"

        Dim params As SqlParameter() = {New SqlParameter("@TimKiem", "%" & tuKhoa.Trim() & "%")}
        Return DatabaseConnection.GetData(query, params)
    End Function
    ' -------------------------------------------------------------------------
    ' 2. TIM MOT DOI TUONG
    ' -------------------------------------------------------------------------
    Public Function GetBySoDienThoai(soDienThoai As String) As KhachHang
        Dim query As String = "SELECT MaKH, HoTen, SoDienThoai, SoDu, TrangThai " &
                              "FROM KhachHang WHERE SoDienThoai = @SDT AND TrangThai = 1"
        Dim params As SqlParameter() = {New SqlParameter("@SDT", soDienThoai)}
        Dim bangDuLieu As DataTable = DatabaseConnection.GetData(query, params)

        If bangDuLieu.Rows.Count = 0 Then Return Nothing

        Dim dong As DataRow = bangDuLieu.Rows(0)
        Dim khachHang As New KhachHang()
        khachHang.MaKH = dong("MaKH").ToString()
        khachHang.HoTen = dong("HoTen").ToString()
        khachHang.SoDienThoai = dong("SoDienThoai").ToString()
        khachHang.SoDu = Convert.ToDecimal(dong("SoDu"))
        khachHang.TrangThai = Convert.ToInt32(dong("TrangThai"))
        Return khachHang
    End Function

    ' -------------------------------------------------------------------------
    ' 3. THEM / SUA / XOA
    ' -------------------------------------------------------------------------

    ' Them moi mot Khach Hang vao CSDL
    Public Function Insert(khachHang As KhachHang) As Integer
        Dim query As String = "INSERT INTO KhachHang (MaKH, HoTen, SoDienThoai, SoDu, TrangThai) " &
                              "VALUES (@MaKH, @HoTen, @SDT, @SoDu, 1)"
        Dim params As SqlParameter() = {
            New SqlParameter("@MaKH", khachHang.MaKH),
            New SqlParameter("@HoTen", khachHang.HoTen),
            New SqlParameter("@SDT", khachHang.SoDienThoai),
            New SqlParameter("@SoDu", khachHang.SoDu)
        }
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

    ' Cap nhat thong tin mot Khach Hang da co trong CSDL
    Public Function Update(khachHang As KhachHang) As Integer
        Dim query As String = "UPDATE KhachHang SET HoTen = @HoTen, " &
                              "SoDienThoai = @SDT, SoDu = @SoDu WHERE MaKH = @MaKH"
        Dim params As SqlParameter() = {
            New SqlParameter("@MaKH", khachHang.MaKH),
            New SqlParameter("@HoTen", khachHang.HoTen),
            New SqlParameter("@SDT", khachHang.SoDienThoai),
            New SqlParameter("@SoDu", khachHang.SoDu)
        }
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

    ' Xoa thong minh:
    Public Function Delete(maKH As String) As Integer
        Dim query As String = "IF EXISTS (SELECT 1 FROM GiaoDich WHERE MaKH = @MaKH) " &
                              "   UPDATE KhachHang SET TrangThai = 0 WHERE MaKH = @MaKH; " &
                              "ELSE " &
                              "   DELETE FROM KhachHang WHERE MaKH = @MaKH;"
        Dim params As SqlParameter() = {New SqlParameter("@MaKH", maKH)}
        Return DatabaseConnection.ExecuteQuery(query, params)
    End Function

    Public Function KiemTraTrungSDT(sdt As String) As Boolean
        Dim query As String = "SELECT * FROM KhachHang WHERE SoDienThoai = '" & sdt.Trim() & "'"
        Dim dt As DataTable = DatabaseConnection.GetData(query)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function
    Public Function UpdateSoDu(maKH As String, soDuMoi As Decimal) As Boolean
        Dim query As String = "UPDATE KhachHang SET SoDu = @SoDuMoi WHERE MaKH = @MaKH"
        Dim parameters As SqlParameter() = {
        New SqlParameter("@SoDuMoi", soDuMoi),
        New SqlParameter("@MaKH", maKH.Trim())
    }

        Try
            Dim rowsAffected As Integer = DatabaseConnection.ExecuteQuery(query, parameters)
            Return rowsAffected > 0
        Catch ex As Exception
            Return False
        End Try
    End Function
    'Tìm kiếm kết hợp nhiều điều kiện khách hàng
    Public Function AdvancedSearch(maKH As String, hoTen As String, soDienThoai As String, trangThai As Integer?) As DataTable
        Dim query As String = "SELECT MaKH, HoTen, SoDienThoai, SoDu, " &
                              "CASE WHEN TrangThai = 1 THEN N'Hoạt động' ELSE N'Bị khóa' END AS TrangThai " &
                              "FROM KhachHang WHERE 1=1 "

        Dim danhSachThamSo As New List(Of SqlParameter)()
        If Not String.IsNullOrEmpty(maKH) Then
            query &= "AND MaKH LIKE @MaKH "
            danhSachThamSo.Add(New SqlParameter("@MaKH", "%" & maKH.Trim() & "%"))
        End If
        If Not String.IsNullOrEmpty(hoTen) Then
            query &= "AND HoTen LIKE @HoTen "
            danhSachThamSo.Add(New SqlParameter("@HoTen", "%" & hoTen.Trim() & "%"))
        End If
        If Not String.IsNullOrEmpty(soDienThoai) Then
            query &= "AND SoDienThoai LIKE @SoDienThoai "
            danhSachThamSo.Add(New SqlParameter("@SoDienThoai", "%" & soDienThoai.Trim() & "%"))
        End If
        If trangThai.HasValue Then
            query &= "AND TrangThai = @TrangThai "
            danhSachThamSo.Add(New SqlParameter("@TrangThai", trangThai.Value))
        End If
        Return DatabaseConnection.GetData(query, danhSachThamSo.ToArray())
    End Function
End Class
