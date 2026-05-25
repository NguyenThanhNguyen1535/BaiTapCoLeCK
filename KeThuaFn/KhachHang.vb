Public Class KhachHang
    ' 1. Các biến Private (Fields) - Chỉ nội bộ lớp này truy cập trực tiếp
    Private _maKH As String
    Private _tenKH As String
    Private _soDienThoai As String
    Private _taiKhoanGoc As Decimal

    ' 2. Các Property Public - Để bên ngoài đọc dữ liệu
    Public Property MaKH As String
        Get
            Return _maKH
        End Get
        Set(value As String)
            _maKH = value
        End Set
    End Property

    Public Property TenKH As String
        Get
            Return _tenKH
        End Get
        Set(value As String)
            _tenKH = value
        End Set
    End Property

    Public Property SoDienThoai As String
        Get
            Return _soDienThoai
        End Get
        Set(value As String)
            _soDienThoai = value
        End Set
    End Property

    ' Tài khoản gốc nên có Set để lớp GiaoDich có thể cộng/trừ tiền
    Public Property TaiKhoanGoc As Decimal
        Get
            Return _taiKhoanGoc
        End Get
        Set(value As Decimal)
            ' Bạn có thể thêm logic kiểm tra ở đây, ví dụ: không cho số dư âm
            If value >= 0 Then
                _taiKhoanGoc = value
            End If
        End Set
    End Property

    ' Constructor
    Sub New(ma As String, ten As String, sdt As String, soDuBanDau As Decimal)
        Me._maKH = ma
        Me._tenKH = ten
        Me._soDienThoai = sdt
        Me._taiKhoanGoc = soDuBanDau
    End Sub
End Class