Public Class LoaiThe

    ' Thuoc tinh tuong ung voi cac cot trong bang LoaiThe cua CSDL
    Public Property MaLoai As String        ' Ma dinh danh duy nhat cua Loai The (Khoa chinh)
    Public Property TenNhaMang As String    ' Ten Nha Mang (Viettel, Vinaphone, Mobifone, ...)
    Public Property MenhGia As Decimal      ' Menh gia cua the (10000, 20000, 50000, ...)
    Public Property TrangThai As Integer    ' 1 = Dang hoat dong, 0 = Da bi an (Xoa mem)

    ' Constructor mac dinh — Tao mot doi tuong LoaiThe trong
    Public Sub New()
        TrangThai = 1 ' Mac dinh khi tao moi la dang hoat dong
    End Sub

    ' Constructor day du tham so — Tao doi tuong LoaiThe voi toan bo thong tin
    Public Sub New(maLoai As String, tenNhaMang As String, menhGia As Decimal)
        Me.MaLoai = maLoai
        Me.TenNhaMang = tenNhaMang
        Me.MenhGia = menhGia
        Me.TrangThai = 1
    End Sub

End Class
