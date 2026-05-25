Imports Microsoft.Data.SqlClient

Public Class BaoCaoDoanhThu
    Private _gdRepo As New GiaoDichRepository()
    Private _ltRepo As New LoaiTheRepository()
    ' -------------------------------------------------------------------------
    ' LOAD FORM
    ' -------------------------------------------------------------------------
    Private Sub BaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGiaoDich.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

        ' 2. Tự động điều chỉnh độ rộng cột để vừa khít với bảng
        dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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

        ThucHienLocDoanhThu()
    End Sub

    ' -------------------------------------------------------------------------
    ' HAM LOC DOANH THU
    ' -------------------------------------------------------------------------
    Private Sub ThucHienLocDoanhThu()
        Try
            Dim nhaMang As String = If(cboNhaMang.SelectedIndex <> -1, cboNhaMang.Text, "")
            Dim bangDuLieu As DataTable = _gdRepo.SearchWithFilter(
                "",
                "",
                nhaMang,
                "",
                dtpTuNgay.Value,
                dtpDenNgay.Value
            )

            dgvGiaoDich.DataSource = bangDuLieu
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            TinhTongDoanhThu()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải báo cáo doanh thu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' TINH TONG DOANH THU TU LUOI (ĐÃ SỬA TÊN CỘT)
    ' -------------------------------------------------------------------------
    Private Sub TinhTongDoanhThu()
        Dim tongTien As Decimal = 0
        For Each dong As DataGridViewRow In dgvGiaoDich.Rows
            If dong.Cells("Tổng tiền").Value IsNot Nothing AndAlso Not IsDBNull(dong.Cells("Tổng tiền").Value) Then
                tongTien += Convert.ToDecimal(dong.Cells("Tổng tiền").Value)
            End If
        Next
        lblDoanhThu.Text = tongTien.ToString("#,##0") & " VND"
    End Sub

    ' -------------------------------------------------------------------------
    ' NUT LOC & XEM TAT CA
    ' -------------------------------------------------------------------------
    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        ThucHienLocDoanhThu()
    End Sub

    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        cboNhaMang.SelectedIndex = -1
        cboNhaMang.Text = ""
        Try
            Dim dtAll As DataTable = _gdRepo.GetDoanhThuReport(Nothing, Nothing, "")
            dgvGiaoDich.DataSource = dtAll
            Dim tongTienTatCa As Decimal = 0
            If dtAll IsNot Nothing Then
                For Each row As DataRow In dtAll.Rows
                    tongTienTatCa += Convert.ToDecimal(row("Tổng tiền"))
                Next
            End If
            lblDoanhThu.Text = tongTienTatCa.ToString("#,##0") & " VND"
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải toàn bộ dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' NÚT IN BÁO CÁO (ĐÃ SỬA TÊN CỘT TRƯỚC KHI ĐỔI)
    ' -------------------------------------------------------------------------
    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Try
            Dim nhaMangSelected As String = If(cboNhaMang.SelectedIndex <> -1, cboNhaMang.Text, "")
            Dim dtDoanhThu As DataTable = _gdRepo.GetDoanhThuReport(dtpTuNgay.Value, dtpDenNgay.Value, nhaMangSelected)

            If dtDoanhThu Is Nothing OrElse dtDoanhThu.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu để xuất bản in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dtDoanhThu.Columns.Contains("Mã giao dịch") Then dtDoanhThu.Columns("Mã giao dịch").ColumnName = "MaGD"
            If dtDoanhThu.Columns.Contains("Số điện thoại") Then dtDoanhThu.Columns("Số điện thoại").ColumnName = "SoDienThoai"
            If dtDoanhThu.Columns.Contains("Tên khách hàng") Then dtDoanhThu.Columns("Tên khách hàng").ColumnName = "HoTen"
            If dtDoanhThu.Columns.Contains("Nhà mạng") Then dtDoanhThu.Columns("Nhà mạng").ColumnName = "TenNhaMang"
            If dtDoanhThu.Columns.Contains("Mệnh giá") Then dtDoanhThu.Columns("Mệnh giá").ColumnName = "MenhGia"
            If dtDoanhThu.Columns.Contains("Ngày giao dịch") Then dtDoanhThu.Columns("Ngày giao dịch").ColumnName = "NgayGD"
            If dtDoanhThu.Columns.Contains("Tổng tiền") Then dtDoanhThu.Columns("Tổng tiền").ColumnName = "TongTien"

            Dim frmDoanhThu As New FormInDoanhThu()
            frmDoanhThu.DuLieuIn = dtDoanhThu

            frmDoanhThu.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Lỗi kết xuất báo cáo: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpTuNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtpTuNgay.ValueChanged
    End Sub
    Private Sub dtpDenNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtpDenNgay.ValueChanged
    End Sub
    Private Sub cboNhaMang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNhaMang.SelectedIndexChanged
    End Sub
    Private Sub lblDoanhThu_Click(sender As Object, e As EventArgs) Handles lblDoanhThu.Click
    End Sub
    Private Sub dgvGiaoDich_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiaoDich.CellContentClick
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class