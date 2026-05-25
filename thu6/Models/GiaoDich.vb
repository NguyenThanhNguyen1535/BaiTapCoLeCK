Public Class GiaoDich

    ' Thuoc tinh tuong ung voi cac cot trong bang GiaoDich cua CSDL
    Public Property MaGD As String          ' Ma dinh danh duy nhat cua Giao Dich (Khoa chinh)
    Public Property MaKH As String          ' Ma Khach Hang thuc hien giao dich (Khoa ngoai -> KhachHang)
    Public Property MaLoai As String        ' Ma Loai The duoc mua trong giao dich (Khoa ngoai -> LoaiThe)
    Public Property NgayGD As DateTime      ' Ngay va gio thuc hien giao dich
    Public Property TongTien As Decimal     ' Tong tien cua giao dich (bang MenhGia cua the duoc mua)

    ' Constructor mac dinh — Tao mot doi tuong GiaoDich trong
    Public Sub New()
        NgayGD = DateTime.Now ' Mac dinh ngay giao dich la thoi diem hien tai
    End Sub

    ' Constructor day du tham so — Tao doi tuong GiaoDich voi toan bo thong tin
    Public Sub New(maGD As String, maKH As String, maLoai As String, tongTien As Decimal)
        Me.MaGD = maGD
        Me.MaKH = maKH
        Me.MaLoai = maLoai
        Me.TongTien = tongTien
        Me.NgayGD = DateTime.Now
    End Sub

End Class
