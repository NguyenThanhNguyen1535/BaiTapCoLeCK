Public Class GiaoDichNapDienThoai
    Inherits GiaoDich ' Kế thừa từ lớp cha GiaoDich

    ' 1. Khai báo biến Private (Field)
    Private _soTienNap As Decimal
    Private _phanTramKhuyenMai As Double

    ' 2. Khai báo Property Public để bên ngoài có thể đọc/ghi nếu cần
    Public Property SoTienNap As Decimal
        Get
            Return _soTienNap
        End Get
        Set(value As Decimal)
            _soTienNap = value
        End Set
    End Property

    Public Property PhanTramKhuyenMai As Double
        Get
            Return _phanTramKhuyenMai
        End Get
        Set(value As Double)
            _phanTramKhuyenMai = value
        End Set
    End Property

    Sub New(ma As String, kh As KhachHang, nv As NhanVien, tienNap As Decimal, pctKM As Double)
        ' Gọi lại hàm khởi tạo của lớp cha để nạp vào các biến Private của cha
        MyBase.New(ma, kh, nv)
        Me._soTienNap = tienNap
        Me._phanTramKhuyenMai = pctKM
    End Sub

    Public Overrides Function TinhTienKhachPhaiTra() As Decimal
        ' Khách nạp bao nhiêu trả bấy nhiêu (Khuyến mãi cộng vào SIM)
        Return _soTienNap
    End Function

    Public Overrides Sub XuLyGiaoDich()
        ' Tính tiền khuyến mãi
        Dim tienKM As Decimal = _soTienNap * Convert.ToDecimal(_phanTramKhuyenMai / 100)

        ' Vì biến _khach bên lớp cha là Private, ta dùng Property Public "Khach" để truy cập
        ' Sau đó thực hiện cộng tiền vào tài khoản gốc của khách hàng
        Me._khach.TaiKhoanGoc += (_soTienNap + tienKM)
    End Sub
End Class