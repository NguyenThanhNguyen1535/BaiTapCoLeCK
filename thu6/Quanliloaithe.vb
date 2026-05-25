Public Class Quanliloaithe
    Private _repo As New LoaiTheRepository()
    Private trangThaiHanhDong As String = ""

    ' -------------------------------------------------------------------------
    ' LOAD FORM & TAI DU LIEU
    ' -------------------------------------------------------------------------
    Private Sub Quanliloaithe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLuu.Enabled = False
        If cboNhaMang.Items.Count = 0 Then
            cboNhaMang.Items.AddRange(New String() {"Viettel", "Vinaphone", "Mobifone", "Vietnamobile"})
        End If
        If cboMenhGia.Items.Count = 0 Then
            cboMenhGia.Items.AddRange(New String() {"10000", "20000", "50000", "100000", "200000", "500000"})
        End If
        KhoaControl(False)
        TaiDanhSachLoaiThe()
    End Sub

    Private Sub TaiDanhSachLoaiThe()
        Try
            dgvLoaiThe.DataSource = _repo.GetAll()
            dgvLoaiThe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh mục loại thẻ: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' CLICK DONG TREN LUOI
    ' -------------------------------------------------------------------------
    Private Sub dgvLoaiThe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiThe.CellClick
        If e.RowIndex >= 0 AndAlso trangThaiHanhDong <> "THEM" Then
            Dim dong As DataGridViewRow = dgvLoaiThe.Rows(e.RowIndex)
            txMaLoai.Text = dong.Cells(0).Value.ToString()
            cboNhaMang.Text = dong.Cells(1).Value.ToString()
            cboMenhGia.Text = Convert.ToDecimal(dong.Cells(2).Value).ToString("F0")
            trangThaiHanhDong = ""
            KhoaControl(False)
            btnLuu.Enabled = False
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT THEM
    ' -------------------------------------------------------------------------
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        btnLuu.Enabled = True
        trangThaiHanhDong = "THEM"
        XoaTrangControl()
        KhoaControl(True)
        txMaLoai.Enabled = True
        txMaLoai.Focus()
        btnSua.Enabled = False
        btnXoa.Enabled = False

    End Sub

    ' -------------------------------------------------------------------------
    ' NUT SUA
    ' -------------------------------------------------------------------------
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If String.IsNullOrWhiteSpace(txMaLoai.Text) Then
            MessageBox.Show("Vui lòng chọn một loại thẻ từ danh sách trước khi Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        btnLuu.Enabled = True
        trangThaiHanhDong = "SUA"
        KhoaControl(True)
        txMaLoai.Enabled = False
        cboNhaMang.Focus()
        btnThem.Enabled = False
        btnXoa.Enabled = False
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT LUU — Tao doi tuong LoaiThe va goi Repository
    ' -------------------------------------------------------------------------
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If trangThaiHanhDong = "" Then
            MessageBox.Show("Vui lòng bấm nút THÊM hoặc SỬA trước khi bấm Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txMaLoai.Text) OrElse cboNhaMang.SelectedIndex = -1 OrElse cboMenhGia.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng điền đầy đủ Mã loại, Chọn Nhà mạng và Mệnh giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim menhGia As Decimal = 0
        Decimal.TryParse(cboMenhGia.Text, menhGia)

        If _repo.IsDuplicate(cboNhaMang.Text.Trim(), menhGia, txMaLoai.Text.Trim()) Then
            MessageBox.Show("Loại thẻ với Nhà mạng và Mệnh giá này đã tồn tại và đang hoạt động!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim loaiThe As New LoaiThe(txMaLoai.Text.Trim(), cboNhaMang.Text.Trim(), menhGia)

        Try
            Dim ketQua As Integer = 0
            If trangThaiHanhDong = "THEM" Then
                ketQua = _repo.Insert(loaiThe)
                If ketQua > 0 Then MessageBox.Show("Thêm mới loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf trangThaiHanhDong = "SUA" Then
                ketQua = _repo.Update(loaiThe)
                If ketQua > 0 Then MessageBox.Show("Cập nhật thông tin loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu dữ liệu: " & ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        btnLuu.Enabled = False
        trangThaiHanhDong = ""
        KhoaControl(False)
        txMaLoai.Enabled = True
        XoaTrangControl()
        TaiDanhSachLoaiThe()
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT XOA THONG MINH — Goi Repository.Delete()
    ' -------------------------------------------------------------------------
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrWhiteSpace(txMaLoai.Text) Then
            MessageBox.Show("Vui lòng chọn một loại thẻ từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim ketQua As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại thẻ này khỏi danh mục?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ketQua = DialogResult.No Then Exit Sub

        Try

            Dim coGiaoDich As Boolean = _repo.KiemTraCoGiaoDich(txMaLoai.Text.Trim())
            Dim soHangAnh As Integer = _repo.Delete(txMaLoai.Text.Trim())
            If soHangAnh > 0 Then
                If coGiaoDich Then
                    MessageBox.Show("Loại thẻ này đã được giao dịch. Hệ thống tiến hành " & vbCrLf &
                                    "'Xóa mềm' (ẩn đi) để bảo vệ dữ liệu doanh thu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                trangThaiHanhDong = ""
                XoaTrangControl()
                TaiDanhSachLoaiThe()
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện xóa: " & ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' TIM KIEM & LAM MOI
    ' -------------------------------------------------------------------------
    Private Sub ThucHienTimKiem()
        Try
            dgvLoaiThe.DataSource = _repo.Search(txtTimKiem.Text.Trim())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        ThucHienTimKiem()
    End Sub


    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        trangThaiHanhDong = ""
        txMaLoai.Enabled = True
        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
        XoaTrangControl()
        txtTimKiem.Clear()
        TaiDanhSachLoaiThe()
    End Sub

    Private Sub XoaTrangControl()
        txMaLoai.Clear()
        cboNhaMang.SelectedIndex = -1
        cboMenhGia.SelectedIndex = -1
        txMaLoai.Enabled = True
        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
    End Sub
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        trangThaiHanhDong = ""
        XoaTrangControl()
        KhoaControl(False)
        btnLuu.Enabled = False
        btnThem.Enabled = True
        btnSua.Enabled = True
        btnXoa.Enabled = True
        txMaLoai.Enabled = True
    End Sub
    Private Sub KhoaControl(ByVal choPhepNhap As Boolean)
        txMaLoai.Enabled = choPhepNhap
        cboNhaMang.Enabled = choPhepNhap
        cboMenhGia.Enabled = choPhepNhap
    End Sub
    Private Sub dgvLoaiThe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiThe.CellContentClick
    End Sub
    Private Sub txMaLoai_TextChanged(sender As Object, e As EventArgs) Handles txMaLoai.TextChanged
    End Sub
    Private Sub cboNhaMang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNhaMang.SelectedIndexChanged
    End Sub
    Private Sub cboMenhGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenhGia.SelectedIndexChanged
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class