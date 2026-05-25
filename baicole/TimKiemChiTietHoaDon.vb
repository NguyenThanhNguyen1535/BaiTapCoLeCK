Imports baicole.Models
Imports baicole.Repositories

Public Class TimKiemChiTietHoaDon

    Private ctRepo As New ChiTietHoaDonRepository()
    Private hdRepo As New HoaDonRepository()

    ' 1. Sự kiện LOAD của Form
    Private Sub TimKiemChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nạp dữ liệu vào 3 ô ComboBox khi mở Form
        LoadAllComboBoxes()

        ' Mặc định ban đầu hiển thị tất cả chi tiết hóa đơn
        HienThiVaLocDuLieu()
    End Sub

    ' Hàm nạp dữ liệu cho 3 ComboBox (cboMaCTHD, cboSoHoaDon, cboMaHang)
    Private Sub LoadAllComboBoxes()
        Try
            ' 1. Nạp ComboBox Mã chi tiết hóa đơn
            Dim dtMaCT = ctRepo.GetDistinct("MaChiTietHD")
            cboMaCTHD.DataSource = dtMaCT
            cboMaCTHD.DisplayMember = "MaChiTietHD"
            cboMaCTHD.ValueMember = "MaChiTietHD"
            cboMaCTHD.SelectedIndex = -1 ' Mặc định để trống

            ' 2. Nạp ComboBox Số hóa đơn
            Dim dtSoHD = hdRepo.GetDistinct("SoHoaDon")
            cboSoHoaDon.DataSource = dtSoHD
            cboSoHoaDon.DisplayMember = "SoHoaDon"
            cboSoHoaDon.ValueMember = "SoHoaDon"
            cboSoHoaDon.SelectedIndex = -1

            ' 3. Nạp ComboBox Mã hàng
            Dim dtMaHang = ctRepo.GetDistinct("MaHang")
            cboMaHang.DataSource = dtMaHang
            cboMaHang.DisplayMember = "MaHang"
            cboMaHang.ValueMember = "MaHang"
            cboMaHang.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải danh sách bộ lọc: " & ex.Message)
        End Try
    End Sub

    ' 2. HÀM LỌC TỔNG HỢP MULTI-FILTER (Kết hợp cả 2 bảng HoaDon và ChiTietHoaDon)
    Private Sub HienThiVaLocDuLieu()
        Try
            Dim maCTHD As String = ""
            Dim soHoaDon As String = ""
            Dim maHang As String = ""

            If cboMaCTHD.SelectedIndex <> -1 AndAlso cboMaCTHD.SelectedValue IsNot Nothing Then
                maCTHD = cboMaCTHD.SelectedValue.ToString()
            End If

            If cboSoHoaDon.SelectedIndex <> -1 AndAlso cboSoHoaDon.SelectedValue IsNot Nothing Then
                soHoaDon = cboSoHoaDon.SelectedValue.ToString()
            End If

            If cboMaHang.SelectedIndex <> -1 AndAlso cboMaHang.SelectedValue IsNot Nothing Then
                maHang = cboMaHang.SelectedValue.ToString()
            End If

            Dim dt = ctRepo.GetByFilterWithHoaDon(maCTHD, soHoaDon, maHang)
            dgv1.DataSource = dt

            ' Đổi tên tiêu đề các cột hiển thị trên lưới cho chuyên nghiệp
            If dgv1.Columns.Count > 0 Then
                dgv1.Columns("MaChiTietHD").HeaderText = "Mã Chi Tiết"
                dgv1.Columns("SoHoaDon").HeaderText = "Số Hóa Đơn"
                dgv1.Columns("NgayBan").HeaderText = "Ngày Bán"
                dgv1.Columns("MaKhachHang").HeaderText = "Mã Khách Hàng"
                dgv1.Columns("MaHang").HeaderText = "Mã Hàng"
                dgv1.Columns("SoLuong").HeaderText = "Số Lượng"
                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi hệ thống khi lọc dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' 3. GẮN HÀM LỌC VÀO CÁC SỰ KIỆN CỦA BẠN
    Private Sub cboMaCTHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaCTHD.SelectedIndexChanged
        ' Thuộc tính .Focused giúp đảm bảo chỉ lọc khi người dùng thực sự click chọn (tránh lỗi chạy lúc khởi tạo form)
        If cboMaCTHD.Focused Then HienThiVaLocDuLieu()
    End Sub

    Private Sub cboSoHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSoHoaDon.SelectedIndexChanged
        If cboSoHoaDon.Focused Then HienThiVaLocDuLieu()
    End Sub

    Private Sub cboMaHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaHang.SelectedIndexChanged
        If cboMaHang.Focused Then HienThiVaLocDuLieu()
    End Sub

    ' 4. SỰ KIỆN NÚT "XEM HẾT" (Bạn nhấp đúp vào nút Xem hết trên giao diện rồi đặt tên hàm là btnXemHet_Click)
    Private Sub btnXemHet_Click(sender As Object, e As EventArgs) Handles btnXemHet.Click
        ' Reset cả 3 ô ComboBox về trạng thái ban đầu (chưa chọn gì)
        cboMaCTHD.SelectedIndex = -1
        cboSoHoaDon.SelectedIndex = -1
        cboMaHang.SelectedIndex = -1

        ' Gọi lại hàm hiển thị (Sẽ lấy ra toàn bộ dữ liệu do không bị vướng điều kiện WHERE nào)
        HienThiVaLocDuLieu()
    End Sub

End Class