Public Class Quanlikhachhang
    Private _repo As New KhachHangRepository()
    Private trangThaiHanhDong As String = ""

    ' -------------------------------------------------------------------------
    ' LOAD FORM & TAI DU LIEU
    ' -------------------------------------------------------------------------
    Private Sub Quanlikhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Cho phép tên cột hiển thị trên 1 hàng duy nhất
        dgvKhachHang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

        ' 2. Tự động điều chỉnh độ rộng cột để vừa khít với bảng
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        btnLuu.Enabled = False
        KhoaONhapLieu(False)
        TaiDanhSachKhachHang()
    End Sub

    Private Sub TaiDanhSachKhachHang()
        Try
            dgvKhachHang.DataSource = _repo.GetAll()
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT THEM
    ' -------------------------------------------------------------------------
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        btnLuu.Enabled = True
        trangThaiHanhDong = "THEM"
        XoaTrangTextBox()
        KhoaONhapLieu(True)
        txtMaKhachHang.Enabled = True
        txtMaKhachHang.Focus()
        btnSua.Enabled = False
        btnXoa.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT SUA
    ' -------------------------------------------------------------------------
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If String.IsNullOrWhiteSpace(txtMaKhachHang.Text) Then
            MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách trước khi Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        btnLuu.Enabled = True
        trangThaiHanhDong = "SUA"
        KhoaONhapLieu(True)
        txtMaKhachHang.Enabled = False
        txtSDT.Enabled = False
        txtTenKhachHang.Focus()
        btnThem.Enabled = False
        btnXoa.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT LUU — Tao doi tuong KhachHang va goi Repository
    ' -------------------------------------------------------------------------
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If trangThaiHanhDong = "" Then
            MessageBox.Show("Vui lòng bấm nút THÊM hoặc SỬA truớc khi thực hiện Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtMaKhachHang.Text) OrElse
       String.IsNullOrWhiteSpace(txtTenKhachHang.Text) OrElse
       String.IsNullOrWhiteSpace(txtSDT.Text) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin (Mã, Tên, SĐT)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sdtNhanh As String = txtSDT.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(sdtNhanh, "^0[0-9]{9,10}$") Then
            MessageBox.Show("Số điện thoại không hợp lệ! Phải bắt đầu bằng số 0 và có 10-11 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSDT.Focus()
            Exit Sub
        End If

        If trangThaiHanhDong = "THEM" Then
            If _repo.KiemTraTrungSDT(sdtNhanh) Then
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSDT.Focus()
                Exit Sub
            End If
        End If
        Dim soDu As Decimal = 0

        If Not Decimal.TryParse(txtSoDu.Text.Trim(), soDu) Then
            MessageBox.Show("Số dư phải là một số hợp lệ (không chứa chữ hoặc ký tự đặc biệt)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoDu.Focus()
            Exit Sub
        End If

        If soDu < 0 Then
            MessageBox.Show("Số dư tài khoản không được phép nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoDu.Focus()
            Exit Sub
        End If

        Dim khachHang As New KhachHang(txtMaKhachHang.Text.Trim(), txtTenKhachHang.Text.Trim(), sdtNhanh, soDu)

        Try
            Dim ketQua As Integer = 0
            If trangThaiHanhDong = "THEM" Then
                ketQua = _repo.Insert(khachHang)
                If ketQua > 0 Then MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf trangThaiHanhDong = "SUA" Then
                ketQua = _repo.Update(khachHang)
                If ketQua > 0 Then MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        trangThaiHanhDong = ""
        txtMaKhachHang.Enabled = True
        XoaTrangTextBox()
        TaiDanhSachKhachHang()
        btnLuu.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT XOA THONG MINH — Goi Repository.Delete()
    ' -------------------------------------------------------------------------
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrWhiteSpace(txtMaKhachHang.Text) Then
            MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim ketQua As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ketQua = DialogResult.No Then Exit Sub

        Try

            Dim soHangAnh As Integer = _repo.Delete(txtMaKhachHang.Text.Trim())
            If soHangAnh > 0 Then

                If _repo.KiemTraCoGiaoDich(txtMaKhachHang.Text.Trim()) Then
                    MessageBox.Show("Khách hàng đã phát sinh giao dịch. Hệ thống đã tiến hành " & vbCrLf &
                                    "'Xóa mềm' (ẩn đi) để bảo lưu lịch sử kế toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                trangThaiHanhDong = ""
                XoaTrangTextBox()
                TaiDanhSachKhachHang()
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' CAC HAM PHU TRO
    ' -------------------------------------------------------------------------
    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 AndAlso trangThaiHanhDong <> "THEM" Then
            Dim dong As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            txtMaKhachHang.Text = dong.Cells(0).Value.ToString()
            txtTenKhachHang.Text = dong.Cells(1).Value.ToString()
            txtSDT.Text = dong.Cells(2).Value.ToString()
            txtSoDu.Text = dong.Cells(3).Value.ToString()
            trangThaiHanhDong = ""
            KhoaONhapLieu(False)
        End If
    End Sub

    Private Sub ThuyenThiTimKiem()
        Try

            dgvKhachHang.DataSource = _repo.Search(txtTimKiem.Text.Trim())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        ThuyenThiTimKiem()
    End Sub

    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        trangThaiHanhDong = ""
        txtMaKhachHang.Enabled = True
        XoaTrangTextBox()
        txtTimKiem.Clear()
        TaiDanhSachKhachHang()
    End Sub

    ' 1. Sửa lại nút Hủy
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        trangThaiHanhDong = ""
        XoaTrangTextBox()
        KhoaONhapLieu(False)
        btnLuu.Enabled = False
        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
    End Sub

    ' 2. Chỉnh lại hàm XoaTrangTextBox để đảm bảo các điều khiển được mở khóa
    Private Sub XoaTrangTextBox()
        txtMaKhachHang.Clear()
        txtTenKhachHang.Clear()
        txtSDT.Clear()
        txtSoDu.Clear()
        txtMaKhachHang.Enabled = True
        txtSDT.Enabled = True
        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
    End Sub
    Private Sub KhoaONhapLieu(ByVal choPhepSua As Boolean)
        txtMaKhachHang.Enabled = choPhepSua
        txtTenKhachHang.Enabled = choPhepSua
        txtSDT.Enabled = choPhepSua
        txtSoDu.Enabled = choPhepSua
    End Sub
    Private Sub dgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellContentClick
    End Sub
    Private Sub txtMaKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtMaKhachHang.TextChanged
    End Sub
    Private Sub txtTenKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtTenKhachHang.TextChanged
    End Sub
    Private Sub txtSDT_TextChanged(sender As Object, e As EventArgs) Handles txtSDT.TextChanged
    End Sub
    Private Sub txtSoDu_TextChanged(sender As Object, e As EventArgs) Handles txtSoDu.TextChanged
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class