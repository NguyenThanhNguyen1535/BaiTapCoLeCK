Public Class Form1
    ' Danh sách dữ liệu giả lập
    Private danhSachKH As New List(Of KhachHang)()
    Private danhSachNV As New List(Of NhanVien)()
    ' Khai báo danh sách nhà mạng (Đúng ý bạn: Khởi tạo xong đổ vào CBO)
    Private danhSachNhaMang As New List(Of String) From {"Viettel", "Mobifone", "Vinaphone"}

    ' 1. SỰ KIỆN LOAD FORM
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nạp Khách hàng
        danhSachKH.Add(New KhachHang("KH01", "Nguyễn Thanh Nguyễn", "0901234567", 50000))
        danhSachKH.Add(New KhachHang("KH02", "Trần Văn Hoàng", "0918888999", 120000))

        cboKhachHang.Items.Clear()
        For Each kh In danhSachKH
            cboKhachHang.Items.Add(kh.MaKH)
        Next
        cboKhachHang.SelectedIndex = 0

        ' Nạp Nhân viên
        danhSachNV.Add(New NhanVien("NV01", "Lê Thu Ngân"))
        cboNhanVien.Items.Clear()
        cboNhanVien.Items.Add(danhSachNV(0).TenNV)
        cboNhanVien.SelectedIndex = 0

        ' 2. ĐỔ DỮ LIỆU NHÀ MẠNG VÀO COMBOBOX
        cboNhaMang.Items.Clear()
        For Each nm In danhSachNhaMang
            cboNhaMang.Items.Add(nm)
        Next
        If cboNhaMang.Items.Count > 0 Then cboNhaMang.SelectedIndex = 0

        radNapTien.Checked = True
        CapNhatGiaoDien()
    End Sub

    ' Tự động nhảy thông tin khi chọn Mã KH
    Private Sub cboKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKhachHang.SelectedIndexChanged
        Dim kh As KhachHang = danhSachKH(cboKhachHang.SelectedIndex)
        txtTenKhachHang.Text = kh.TenKH
        txtSDTKhach.Text = kh.SoDienThoai
    End Sub

    Private Sub radType_CheckedChanged(sender As Object, e As EventArgs) Handles radNapTien.CheckedChanged, radMuaThe.CheckedChanged
        CapNhatGiaoDien()
    End Sub

    Private Sub CapNhatGiaoDien()
        ' Cho phép chọn nhà mạng trong mọi trường hợp
        cboNhaMang.Enabled = True

        If radNapTien.Checked Then
            lblSoTien.Text = "Số tiền nạp:"
            lblKM_CK.Text = "Khuyến mãi (%):"
            txtSoLuong.Enabled = False
            txtSoLuong.Text = "1"
        Else
            lblSoTien.Text = "Mệnh giá thẻ:"
            lblKM_CK.Text = "Chiết khấu (%):"
            txtSoLuong.Enabled = True
        End If
    End Sub

    ' 4. NÚT THANH TOÁN (ĐÃ CHỈNH LẠI LOGIC KHỞI TẠO)
    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        ' --- 1. KIỂM TRA NHẬP LIỆU (FIX FORMATEXCEPTION) ---
        Dim soTienInput As Decimal = 0
        If Not Decimal.TryParse(txtSoTien.Text, soTienInput) Then
            MessageBox.Show("Vui lòng nhập số tiền hợp lệ!")
            txtSoTien.Focus()
            Exit Sub
        End If

        Dim tiLe As Double = 0
        Double.TryParse(txtTiLe.Text, tiLe)

        ' --- 2. KHỞI TẠO THÔNG TIN ---
        Dim strMaGD As String = "GD" & DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim khachHangChon As KhachHang = danhSachKH(cboKhachHang.SelectedIndex)
        Dim nhanVienChon As NhanVien = danhSachNV(cboNhanVien.SelectedIndex)
        Dim nhaMangDuocChon As String = cboNhaMang.SelectedItem.ToString()

        Dim gdHienTai As GiaoDich = Nothing

        If radNapTien.Checked Then
            gdHienTai = New GiaoDichNapDienThoai(strMaGD, khachHangChon, nhanVienChon, soTienInput, tiLe)
        Else
            Dim the As New TheDienThoai(nhaMangDuocChon, soTienInput)
            Dim sl As Integer = 1
            Integer.TryParse(txtSoLuong.Text, sl)
            gdHienTai = New GiaoDichMuaMaThe(strMaGD, khachHangChon, nhanVienChon, the, sl, tiLe)
        End If

        ' --- 3. XỬ LÝ LOGIC (CHẶN NẠP VƯỢT MỨC) ---

        ' Bước A: Tính số tiền thực tế khách phải bỏ ra
        Dim phaiTra As Decimal = gdHienTai.TinhTienKhachPhaiTra()

        ' Bước B: Gọi hàm kiểm tra số dư từ Class cha
        If Not gdHienTai.KiemTraHopLe() Then
            MessageBox.Show($"Giao dịch thất bại! Số dư tài khoản không đủ." & vbCrLf &
                            $"Cần thanh toán: {phaiTra:N0}đ" & vbCrLf &
                            $"Hiện có: {khachHangChon.TaiKhoanGoc:N0}đ",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Thoát hàm, không thực hiện nạp tiền và không hiện lên ListView
        End If

        ' Bước C: Nếu đủ tiền thì mới trừ tiền trong "Ví" của khách
        khachHangChon.TaiKhoanGoc -= phaiTra

        ' Bước D: Thực hiện cộng tiền vào SIM (Nếu là nạp tiền) hoặc xử lý khác
        gdHienTai.XuLyGiaoDich()

        ' --- 4. HIỂN THỊ VÀO LISTVIEW (Dưới đây giữ nguyên) ---
        Dim nhaMang As String = cboNhaMang.SelectedItem.ToString()
        Dim loaiGD As String = If(radNapTien.Checked, "Nạp tiền", "Mua thẻ")
        ' ... tiếp tục phần ListView của bạn ...

        ' 1. Tạo dòng mới với cột đầu tiên là Mã GD
        Dim item As New ListViewItem(gdHienTai.MaGD)

        ' 2. Thêm các cột (SubItems) theo đúng thứ tự bạn đã sắp xếp trong Designer
        item.SubItems.Add(gdHienTai.NgayGD.ToString("HH:mm:ss")) ' Cột Thời gian
        item.SubItems.Add(loaiGD & " " & nhaMang)                ' Cột Loại & Nhà mạng
        item.SubItems.Add(khachHangChon.TenKH)                   ' Cột Tên Khách hàng
        item.SubItems.Add(khachHangChon.SoDienThoai)            ' <--- THÊM DÒNG NÀY (Cột SĐT)
        item.SubItems.Add(nhanVienChon.MaNV)                     ' Cột Mã NV
        item.SubItems.Add(String.Format("{0:N0}đ", phaiTra))     ' Cột Tổng tiền

        ' 3. Đưa dòng dữ liệu vào ListView
        lvLichSu.Items.Add(item)

        ' Cuộn xuống dòng mới nhất
        item.EnsureVisible()
    End Sub
    Private Sub LamSachForm()
        txtSoTien.Clear()
        txtSoTien.Focus()
    End Sub
End Class