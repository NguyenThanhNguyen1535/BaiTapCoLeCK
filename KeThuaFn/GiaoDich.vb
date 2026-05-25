Public MustInherit Class GiaoDich
    ' 1. Dùng Protected Field để lớp con có thể xài trực tiếp
    Protected _maGD As String
    Protected _ngayGD As DateTime
    Protected _khach As KhachHang
    Protected _nhanVien As NhanVien

    ' 2. Dùng Public Property để Form1 có thể lấy dữ liệu hiện lên ListView
    Public ReadOnly Property MaGD As String
        Get
            Return _maGD
        End Get
    End Property

    Public ReadOnly Property NgayGD As DateTime
        Get
            Return _ngayGD
        End Get
    End Property

    ' Constructor
    Sub New(ma As String, kh As KhachHang, nv As NhanVien)
        Me._maGD = ma
        Me._ngayGD = DateTime.Now
        Me._khach = kh
        Me._nhanVien = nv
    End Sub
    ' 3. Phương thức kiểm tra số dư (Dùng chung cho mọi loại giao dịch)
    Public Function KiemTraHopLe() As Boolean
        Dim phaiTra As Decimal = TinhTienKhachPhaiTra()
        ' Kiểm tra xem tiền phải trả có vượt quá số dư ví của khách không
        Return phaiTra <= _khach.TaiKhoanGoc
    End Function

    Public MustOverride Function TinhTienKhachPhaiTra() As Decimal
    Public MustOverride Sub XuLyGiaoDich()

End Class