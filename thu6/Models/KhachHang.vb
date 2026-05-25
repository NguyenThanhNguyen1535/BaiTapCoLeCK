Public Class KhachHang

    ' Thuoc tinh tuong ung voi cac cot trong bang KhachHang cua CSDL
    Public Property MaKH As String          ' Ma dinh danh duy nhat (Khoa chinh)
    Public Property HoTen As String         ' Ho va Ten day du cua Khach Hang
    Public Property SoDienThoai As String   ' So Dien Thoai (dung de tra cuu khi giao dich)
    Public Property SoDu As Decimal         ' So du hien tai trong vi dien tu
    Public Property TrangThai As Integer    ' 1 = Dang hoat dong, 0 = Da bi an (Xoa mem)

    ' Constructor mac dinh — Tao mot doi tuong KhachHang trong
    Public Sub New()
        TrangThai = 1 ' Mac dinh khi tao moi la dang hoat dong
    End Sub

    ' Constructor day du tham so — Tao doi tuong KhachHang voi toan bo thong tin
    Public Sub New(maKH As String, hoTen As String, soDienThoai As String, soDu As Decimal)
        Me.MaKH = maKH
        Me.HoTen = hoTen
        Me.SoDienThoai = soDienThoai
        Me.SoDu = soDu
        Me.TrangThai = 1
    End Sub

End Class
