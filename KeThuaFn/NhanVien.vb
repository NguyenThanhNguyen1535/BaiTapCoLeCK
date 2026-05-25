Public Class NhanVien
    ' 1. Khai báo các biến Private (Fields)
    Private _maNV As String
    Private _tenNV As String

    ' 2. Khai báo các Property Public để bên ngoài (như Form1) có thể đọc dữ liệu
    Public Property MaNV As String
        Get
            Return _maNV
        End Get
        Set(value As String)
            _maNV = value
        End Set
    End Property

    Public Property TenNV As String
        Get
            Return _tenNV
        End Get
        Set(value As String)
            _tenNV = value
        End Set
    End Property

    ' Constructor (Hàm khởi tạo)
    Sub New(ma As String, ten As String)
        Me._maNV = ma
        Me._tenNV = ten
    End Sub
End Class