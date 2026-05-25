Public Class TimKiem
    Private _gdRepo As New GiaoDichRepository()
    Private _ltRepo As New LoaiTheRepository()
    ' -------------------------------------------------------------------------
    ' LOAD FORM
    ' -------------------------------------------------------------------------
    Private Sub TimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLichSu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

        ' 2. Tự động điều chỉnh độ rộng cột để vừa khít với bảng
        dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim ngayHienTai As DateTime = DateTime.Now
        dtpTuNgay.Value = New DateTime(ngayHienTai.Year, ngayHienTai.Month, 1)
        dtpDenNgay.Value = ngayHienTai
        Try
            cboNhaMang.Items.Clear()
            cboNhaMang.Text = ""
            For Each nhaMang As String In _ltRepo.GetNhaMangList()
                cboNhaMang.Items.Add(nhaMang)
            Next
        Catch ex As Exception
        End Try
        Try
            cboMenhGia.Items.Clear()
            cboMenhGia.Text = ""
            For Each menhGia As Decimal In _ltRepo.GetAllMenhGia()
                cboMenhGia.Items.Add(menhGia.ToString("F0"))
            Next
        Catch ex As Exception
        End Try

        ThucHienBoLocTimKiem()
    End Sub

    ' -------------------------------------------------------------------------
    ' HAM TIM KIEM DA DIEU KIEN — Goi Repository.SearchWithFilter()
    ' -------------------------------------------------------------------------
    Private Sub ThucHienBoLocTimKiem()
        Try
            Dim nhaMang As String = If(cboNhaMang.SelectedIndex <> -1, cboNhaMang.Text, "")
            Dim menhGia As String = If(cboMenhGia.SelectedIndex <> -1, cboMenhGia.Text, "")
            Dim bangDuLieu As DataTable = _gdRepo.SearchWithFilter(
                txtTenKhachHang.Text,
                txtSDT.Text,
                nhaMang,
                menhGia,
                dtpTuNgay.Value,
                dtpDenNgay.Value
            )

            dgvLichSu.DataSource = bangDuLieu
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Lỗi thực hiện tìm kiếm: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT TIM KIEM
    ' -------------------------------------------------------------------------
    'Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
    '    ThucHienBoLocTimKiem()
    'End Sub

    ' -------------------------------------------------------------------------
    ' NUT XEM TAT CA (Reset bo loc)
    ' -------------------------------------------------------------------------
    Private Sub btnLoadLai_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        txtTenKhachHang.Clear()
        txtSDT.Clear()
        cboNhaMang.SelectedIndex = -1
        cboNhaMang.Text = ""
        cboMenhGia.SelectedIndex = -1
        cboMenhGia.Text = ""
        Dim ngayHienTai As DateTime = DateTime.Now
        dtpTuNgay.Value = New DateTime(ngayHienTai.Year, ngayHienTai.Month, 1)
        dtpDenNgay.Value = ngayHienTai
        ThucHienBoLocTimKiem()
    End Sub

    ' -------------------------------------------------------------------------
    ' SU KIEN REAL-TIME (Go den dau loc den do)
    ' -------------------------------------------------------------------------
    Private Sub txtTenKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtTenKhachHang.TextChanged
        ThucHienBoLocTimKiem()
    End Sub

    Private Sub txtSDT_TextChanged(sender As Object, e As EventArgs) Handles txtSDT.TextChanged
        ThucHienBoLocTimKiem()
    End Sub

    Private Sub cboNhaMang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNhaMang.SelectedIndexChanged
        ThucHienBoLocTimKiem()
    End Sub

    Private Sub cboMenhGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenhGia.SelectedIndexChanged
        ThucHienBoLocTimKiem()
    End Sub
    Private Sub dtpTuNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtpTuNgay.ValueChanged
    End Sub
    Private Sub dtpDenNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtpDenNgay.ValueChanged
    End Sub
    Private Sub dgvLichSu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLichSu.CellContentClick
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Try
            Dim nhaMang As String = If(cboNhaMang.SelectedIndex <> -1, cboNhaMang.Text, "")
            Dim menhGia As String = If(cboMenhGia.SelectedIndex <> -1, cboMenhGia.Text, "")
            Dim dtKetQua As DataTable = _gdRepo.GetTransactionReportWithFilter(
                txtTenKhachHang.Text,
                txtSDT.Text,
                nhaMang,
                menhGia,
                dtpTuNgay.Value,
                dtpDenNgay.Value
            )

            If dtKetQua Is Nothing OrElse dtKetQua.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu phù hợp để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            For Each row As DataRow In dtKetQua.Rows
                If Convert.ToInt32(row("Trạng thái KH")) = 0 Then
                    row("Tên khách hàng") = row("Tên khách hàng").ToString() & " (Tài khoản khóa)"
                End If
                If Convert.ToInt32(row("Trạng thái LT")) = 0 Then
                    row("Nhà mạng") = row("Nhà mạng").ToString() & " (Ngừng bán)"
                End If
            Next
            If dtKetQua.Columns.Contains("Mã giao dịch") Then dtKetQua.Columns("Mã giao dịch").ColumnName = "MaGD"
            If dtKetQua.Columns.Contains("Số điện thoại") Then dtKetQua.Columns("Số điện thoại").ColumnName = "SoDienThoai"
            If dtKetQua.Columns.Contains("Tên khách hàng") Then dtKetQua.Columns("Tên khách hàng").ColumnName = "HoTen"
            If dtKetQua.Columns.Contains("Nhà mạng") Then dtKetQua.Columns("Nhà mạng").ColumnName = "TenNhaMang"
            If dtKetQua.Columns.Contains("Mệnh giá") Then dtKetQua.Columns("Mệnh giá").ColumnName = "MenhGia"
            If dtKetQua.Columns.Contains("Ngày giao dịch") Then dtKetQua.Columns("Ngày giao dịch").ColumnName = "NgayGD"
            If dtKetQua.Columns.Contains("Tổng tiền") Then dtKetQua.Columns("Tổng tiền").ColumnName = "TongTien"
            Dim frmReport As New FormInGiaoDich()
            frmReport.DuLieuIn = dtKetQua
            frmReport.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Lỗi in báo cáo: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class