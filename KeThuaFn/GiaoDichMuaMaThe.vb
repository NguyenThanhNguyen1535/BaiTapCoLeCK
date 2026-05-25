Public Class GiaoDichMuaMaThe
    Inherits GiaoDich

    ' Biến Private cho riêng lớp con
    Private _theDT As TheDienThoai
    Private _soLuong As Integer
    Private _phanTramCK As Double

    ' Property Public để bên ngoài có thể truy cập
    Public Property TheDT As TheDienThoai
        Get
            Return _theDT
        End Get
        Set(value As TheDienThoai)
            _theDT = value
        End Set
    End Property

    Public Property SoLuong As Integer
        Get
            Return _soLuong
        End Get
        Set(value As Integer)
            _soLuong = value
        End Set
    End Property

    Sub New(ma As String, kh As KhachHang, nv As NhanVien, the As TheDienThoai, sl As Integer, pctCK As Double)
        ' Gửi dữ liệu về lớp cha xử lý vào các biến Private của cha
        MyBase.New(ma, kh, nv)
        Me._theDT = the
        Me._soLuong = sl
        Me._phanTramCK = pctCK
    End Sub

    Public Overrides Function TinhTienKhachPhaiTra() As Decimal
        Dim tongGoc As Decimal = _theDT.MenhGia * _soLuong
        Dim tienGiam As Decimal = tongGoc * Convert.ToDecimal(_phanTramCK / 100)
        Return tongGoc - tienGiam
    End Function

    Public Overrides Sub XuLyGiaoDich()
        ' Vì _khach ở cha là Private, ta dùng Property Public "Khach" để lấy tên
        ' Ví dụ: Console.WriteLine("Xử lý cho khách: " & Me.Khach.TenKH)
    End Sub
End Class