Public Class Quanligiaodich
    Private _gdRepo As New GiaoDichRepository()
    Private _khRepo As New KhachHangRepository()
    Private _ltRepo As New LoaiTheRepository()
    Private trangThaiHanhDong As String = ""

    ' -------------------------------------------------------------------------
    ' LOAD FORM
    ' -------------------------------------------------------------------------
    Private Sub Quanligiaodich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGiaoDich.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

        ' 2. Tự động điều chỉnh độ rộng cột để vừa khít với bảng
        dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        btnLuu.Enabled = False
        cboNhaMang.Items.Clear()
        cboNhaMang.Text = ""
        cboMenhGia.Items.Clear()
        cboMenhGia.Text = ""
        MoKhoaOChitTiet(False)

        Try
            For Each nhaMang As String In _ltRepo.GetNhaMangList()
                cboNhaMang.Items.Add(nhaMang)
            Next
            TaiDanhSachGiaoDich()
        Catch ex As Exception
            MessageBox.Show("Lỗi khởi tạo danh mục nhà mạng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaiDanhSachGiaoDich()
        Try
            dgvGiaoDich.DataSource = _gdRepo.GetActiveTransactions()
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách giao dịch: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' HÀM PHỤ TRỢ: MỞ/KHÓA CÁC Ô NHẬP LIỆU (CHỈ XEM HOẶC CHO GÕ)
    ' -------------------------------------------------------------------------
    Private Sub MoKhoaOChitTiet(ByVal choPhepNhap As Boolean)
        txtMaGiaoDich.Enabled = choPhepNhap
        txtMaKhachHang.Enabled = choPhepNhap
        txtTenKhachHang.Enabled = False
        txtSoDu.Enabled = False
        cboNhaMang.Enabled = choPhepNhap
        cboMenhGia.Enabled = choPhepNhap
    End Sub

    ' -------------------------------------------------------------------------
    ' LAY MENH GIA KHI CHON NHA MANG
    ' -------------------------------------------------------------------------
    Private Sub cboNhaMang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNhaMang.SelectedIndexChanged
        If cboNhaMang.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboNhaMang.Text) Then
            cboMenhGia.Items.Clear()
            cboMenhGia.Text = ""
            Exit Sub
        End If

        Try
            cboMenhGia.Items.Clear()
            cboMenhGia.Text = ""
            For Each gia As Decimal In _ltRepo.GetMenhGiaByNhaMang(cboNhaMang.Text.Trim())
                cboMenhGia.Items.Add(gia.ToString("F0"))
            Next
            If cboMenhGia.Items.Count > 0 Then cboMenhGia.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Lỗi lấy danh sách mệnh giá: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' TU DONG TIM KHACH HANG KHI GO SDT
    ' -------------------------------------------------------------------------
    Private Sub txtMaKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtMaKhachHang.TextChanged
        Dim sdt As String = txtMaKhachHang.Text.Trim()
        If sdt.Length = 0 Then
            txtTenKhachHang.Text = ""
            txtSoDu.Text = ""
            Exit Sub
        End If

        Try
            Dim khachHang As KhachHang = _khRepo.GetBySoDienThoai(sdt)
            If khachHang IsNot Nothing Then
                txtTenKhachHang.Text = khachHang.HoTen
                txtSoDu.Text = khachHang.SoDu.ToString("F0")
            Else
                txtTenKhachHang.Text = "Khách hàng không tồn tại"
                txtSoDu.Text = "0"
            End If
        Catch ex As Exception
            txtTenKhachHang.Text = "Lỗi hệ thống"
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' CLICK DÒNG TRÊN LƯỚI - CHỈ XEM CHỨ KHÔNG LÀM GÌ ĐƯỢC
    ' -------------------------------------------------------------------------
    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiaoDich.CellClick
        If e.RowIndex >= 0 AndAlso trangThaiHanhDong <> "THEM" Then
            Dim dong As DataGridViewRow = dgvGiaoDich.Rows(e.RowIndex)
            txtMaGiaoDich.Text = dong.Cells("Mã giao dịch").Value.ToString()
            txtMaKhachHang.Text = dong.Cells("Số điện thoại").Value.ToString()
            txtTenKhachHang.Text = dong.Cells("Tên khách hàng").Value.ToString()
            cboNhaMang.Text = dong.Cells("Nhà mạng").Value.ToString()

            If dong.Cells("Mệnh giá").Value IsNot Nothing AndAlso Not IsDBNull(dong.Cells("Mệnh giá").Value) Then
                cboMenhGia.Text = Convert.ToDecimal(dong.Cells("Mệnh giá").Value).ToString("#,##0")
            Else
                cboMenhGia.Text = ""
            End If
            MoKhoaOChitTiet(False)
            btnLuu.Enabled = False
            btnThem.Enabled = True
            btnSua.Enabled = True
            btnXoa.Enabled = True
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT THEM - MỞ KHÓA ĐỂ ĐIỀN THÔNG TIN
    ' -------------------------------------------------------------------------
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        trangThaiHanhDong = "THEM"
        XoaTrangControl()
        MoKhoaOChitTiet(True)
        txtMaGiaoDich.Focus()
        btnLuu.Enabled = True
        btnThem.Enabled = False
        btnSua.Enabled = False
        btnXoa.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT SUA (Chặn sửa giao dịch tài chính)
    ' -------------------------------------------------------------------------
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        MessageBox.Show("Vì lý do an toàn bảo mật, giao dịch tài chính đã lưu KHÔNG THỂ CHỈNH SỬA!" & vbCrLf & "Nếu nạp nhầm hoặc sai sót, vui lòng bấm XÓA để hủy giao dịch hoàn tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT LUU
    ' -------------------------------------------------------------------------
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If trangThaiHanhDong <> "THEM" Then Exit Sub

        If String.IsNullOrWhiteSpace(txtMaGiaoDich.Text) OrElse String.IsNullOrWhiteSpace(txtMaKhachHang.Text) OrElse
           cboNhaMang.SelectedIndex = -1 OrElse cboMenhGia.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng nhập và chọn đầy đủ thông tin giao dịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtTenKhachHang.Text = "Khách hàng không tồn tại" OrElse String.IsNullOrEmpty(txtTenKhachHang.Text) Then
            MessageBox.Show("Số điện thoại không hợp lệ, không thể thực hiện giao dịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim menhGia As Decimal = 0
        Decimal.TryParse(cboMenhGia.Text, menhGia)

        Try
            Dim khachHang As KhachHang = _khRepo.GetBySoDienThoai(txtMaKhachHang.Text.Trim())
            If khachHang Is Nothing Then
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim maLoai As String = _ltRepo.GetMaLoai(cboNhaMang.Text.Trim(), menhGia)
            If String.IsNullOrEmpty(maLoai) Then
                MessageBox.Show("Loại thẻ này hiện không tồn tại hoặc đã bị khóa trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim soDuHienTai As Decimal = khachHang.SoDu

            If soDuHienTai < menhGia Then
                Dim soTienThieu As Decimal = menhGia - soDuHienTai
                Dim dialogResult As DialogResult = MessageBox.Show($"Số dư tài khoản không đủ! (Thiếu {soTienThieu:N0} VND)." & vbCrLf & "Bạn có muốn nạp thêm tiền không?", "Xác nhận nạp tiền", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dialogResult = DialogResult.Yes Then
                    Dim inputAmount As String = InputBox($"Nhập số tiền muốn nạp (Tối thiểu: {soTienThieu:N0}):", "Nạp tiền", soTienThieu.ToString())
                    Dim soTienNap As Decimal = 0
                    If Decimal.TryParse(inputAmount, soTienNap) AndAlso soTienNap >= soTienThieu Then
                        Dim soDuMoi As Decimal = soDuHienTai + soTienNap
                        Dim capNhatVi As Boolean = _khRepo.UpdateSoDu(khachHang.MaKH, soDuMoi)
                        If capNhatVi Then
                            MessageBox.Show($"Nạp tiền thành công! Số dư hiện tại: {soDuMoi:N0} VND.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            khachHang.SoDu = soDuMoi
                        Else
                            MessageBox.Show("Lỗi nạp tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Số tiền không hợp lệ! Hủy giao dịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If

            Dim giaoDich As New GiaoDich(txtMaGiaoDich.Text.Trim(), khachHang.MaKH, maLoai, menhGia)
            Dim thanhCong As Boolean = _gdRepo.Insert(giaoDich, khachHang.SoDu)

            If thanhCong Then
                MessageBox.Show("Giao dịch mua thẻ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                trangThaiHanhDong = ""
                XoaTrangControl()
                MoKhoaOChitTiet(False)
                TaiDanhSachGiaoDich()
                btnLuu.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi xử lý giao dịch: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT XOA (Hủy giao dịch hoàn tiền)
    ' -------------------------------------------------------------------------
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrWhiteSpace(txtMaGiaoDich.Text) Then
            MessageBox.Show("Vui lòng chọn một giao dịch từ danh sách để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim ketQua As DialogResult = MessageBox.Show("Bạn chắc chắn muốn HỦY giao dịch " & txtMaGiaoDich.Text & "?" & vbCrLf & "Hệ thống sẽ tự động HOÀN TIỀN vào ví khách hàng!", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ketQua = DialogResult.No Then Exit Sub

        Try
            Dim thanhCong As Boolean = _gdRepo.Delete(txtMaGiaoDich.Text.Trim())
            If thanhCong Then
                MessageBox.Show("Đã hủy giao dịch thành công và hoàn tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                trangThaiHanhDong = ""
                XoaTrangControl()
                MoKhoaOChitTiet(False)
                TaiDanhSachGiaoDich()
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi hủy giao dịch: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT HUY - QUAY VỀ TRẠNG THÁI CHỈ XEM MẶC ĐỊNH
    ' -------------------------------------------------------------------------
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        trangThaiHanhDong = ""
        XoaTrangControl()
        MoKhoaOChitTiet(False)
        btnLuu.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' TIM KIEM & LAM MOI
    ' -------------------------------------------------------------------------
    Private Sub ThucHienTimKiem()
        Try
            dgvGiaoDich.DataSource = _gdRepo.Search(txtTimKiem.Text.Trim())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        ThucHienTimKiem()
    End Sub


    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        trangThaiHanhDong = ""
        XoaTrangControl()
        MoKhoaOChitTiet(False)
        txtTimKiem.Clear()
        TaiDanhSachGiaoDich()
    End Sub

    Private Sub XoaTrangControl()
        txtMaGiaoDich.Clear()
        txtMaKhachHang.Clear()
        txtTenKhachHang.Clear()
        txtSoDu.Clear()
        cboNhaMang.SelectedIndex = -1
        cboMenhGia.Items.Clear()
        cboMenhGia.Text = ""

        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
    End Sub

    Private Sub txtMaGiaoDich_TextChanged(sender As Object, e As EventArgs) Handles txtMaGiaoDich.TextChanged
    End Sub
    Private Sub txtTenKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtTenKhachHang.TextChanged
    End Sub
    Private Sub cboMenhGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenhGia.SelectedIndexChanged
    End Sub
    Private Sub txtSoDu_TextChanged(sender As Object, e As EventArgs) Handles txtSoDu.TextChanged
    End Sub
    Private Sub dgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiaoDich.CellContentClick
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class