Imports baicole.Models
Imports baicole.Repositories

Public Class TimKiemHoaDon

    Private hdRepo As New HoaDonRepository()

    ' 1. Sự kiện LOAD của Form
    Private Sub TimKiemHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nạp dữ liệu vào 3 ô ComboBox khi mở Form
        LoadAllComboBoxes()

        ' Mặc định ban đầu hiển thị tất cả hóa đơn
        HienThiVaLocDuLieu()
    End Sub

    ' Hàm nạp dữ liệu cho cả 3 ComboBox
    Private Sub LoadAllComboBoxes()
        Try
            ' Nạp ComboBox Số hóa đơn
            Dim dtSoHD = hdRepo.GetDistinct("SoHoaDon")
            cboSoHoaDon.DataSource = dtSoHD
            cboSoHoaDon.DisplayMember = "SoHoaDon"
            cboSoHoaDon.ValueMember = "SoHoaDon"
            cboSoHoaDon.SelectedIndex = -1 ' Để trống ban đầu

            ' Nạp ComboBox Mã khách hàng
            Dim dtMaKH = hdRepo.GetDistinct("MaKhachHang")
            cboMaKhachHang.DataSource = dtMaKH
            cboMaKhachHang.DisplayMember = "MaKhachHang"
            cboMaKhachHang.ValueMember = "MaKhachHang"
            cboMaKhachHang.SelectedIndex = -1

            ' Nạp ComboBox Mã nhân viên
            Dim dtMaNV = hdRepo.GetDistinct("MaNhanVien")
            cboMaNhanVien.DataSource = dtMaNV
            cboMaNhanVien.DisplayMember = "MaNhanVien"
            cboMaNhanVien.ValueMember = "MaNhanVien"
            cboMaNhanVien.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải danh sách bộ lọc: " & ex.Message)
        End Try
    End Sub

    ' 2. HÀM LỌC TỔNG HỢP (Chìa khóa xử lý tìm kiếm theo nhiều điều kiện)
    Private Sub HienThiVaLocDuLieu()
        Try
            Dim soHoaDon As String = ""
            Dim maKhachHang As String = ""
            Dim maNhanVien As String = ""

            If cboSoHoaDon.SelectedIndex <> -1 AndAlso cboSoHoaDon.SelectedValue IsNot Nothing Then
                soHoaDon = cboSoHoaDon.SelectedValue.ToString()
            End If

            If cboMaKhachHang.SelectedIndex <> -1 AndAlso cboMaKhachHang.SelectedValue IsNot Nothing Then
                maKhachHang = cboMaKhachHang.SelectedValue.ToString()
            End If

            If cboMaNhanVien.SelectedIndex <> -1 AndAlso cboMaNhanVien.SelectedValue IsNot Nothing Then
                maNhanVien = cboMaNhanVien.SelectedValue.ToString()
            End If

            Dim dt = hdRepo.GetByFilter(soHoaDon, maKhachHang, maNhanVien)
            dgv1.DataSource = dt

            ' Đổi tiêu đề tiếng Việt cho dễ đọc
            If dgv1.Columns.Count > 0 Then
                dgv1.Columns("SoHoaDon").HeaderText = "Số Hóa Đơn"
                dgv1.Columns("NgayBan").HeaderText = "Ngày Bán"
                dgv1.Columns("MaKhachHang").HeaderText = "Mã Khách Hàng"
                dgv1.Columns("MaNhanVien").HeaderText = "Mã Nhân Viên"
                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi lọc dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' 3. CÁC SỰ KIỆN THAY ĐỔI TRÊN COMBOBOX (Chọn cái nào là lưới tự động lọc luôn)
    Private Sub cboSoHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSoHoaDon.SelectedIndexChanged
        ' Gọi hàm lọc dữ liệu (Chỉ chạy khi Form đã Load xong dữ liệu vào Combo)
        If cboSoHoaDon.Focused Then HienThiVaLocDuLieu()
    End Sub

    Private Sub cboMaKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaKhachHang.SelectedIndexChanged
        If cboMaKhachHang.Focused Then HienThiVaLocDuLieu()
    End Sub

    Private Sub cboMaNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaNhanVien.SelectedIndexChanged
        If cboMaNhanVien.Focused Then HienThiVaLocDuLieu()
    End Sub

    ' 4. SỰ KIỆN NÚT "XEM HẾT" (Xóa hết lựa chọn, hiển thị lại toàn bộ)
    Private Sub btnXemHet_Click(sender As Object, e As EventArgs) Handles btnXemHet.Click
        ' Đưa các ComboBox về trạng thái ban đầu chưa chọn gì
        cboSoHoaDon.SelectedIndex = -1
        cboMaKhachHang.SelectedIndex = -1
        cboMaNhanVien.SelectedIndex = -1

        ' Chạy lại hàm hiển thị (Vì không vướng điều kiện WHERE nào nên nó sẽ hiển thị tất cả)
        HienThiVaLocDuLieu()
    End Sub

End Class