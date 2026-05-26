Imports System.Data

Public Class TimKiemVaXemThongTinKhachHang

    ' Khởi tạo đối tượng Repository để gọi hàm xử lý dữ liệu
    Private _khachHangRepo As New KhachHangRepository()
    Private Sub TimKiemVaXemThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKhachHang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

        ' 2. Tự động điều chỉnh độ rộng cột để vừa khít với bảng
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' Nạp danh sách lựa chọn cho ComboBox Trạng thái nếu trong thiết kế chưa nhập
        cboTrangThai.Items.Clear()
        cboTrangThai.Items.Add("Tất cả")
        cboTrangThai.Items.Add("Đang hoạt động")
        cboTrangThai.Items.Add("Đã ẩn")
        cboTrangThai.SelectedIndex = 0
        ThucHienTimKiem()
    End Sub
    Private Sub ThucHienTimKiem()
        Dim maKH As String = txtMaKhachHang.Text
        Dim tenKH As String = txtTenKhachHang.Text
        Dim sdt As String = txtSDT.Text
        Dim trangThai As Integer? = Nothing
        If cboTrangThai.SelectedIndex = 1 Then
            trangThai = 1
        ElseIf cboTrangThai.SelectedIndex = 2 Then
            trangThai = 0
        End If

        Try
            Dim dtResult As DataTable = _khachHangRepo.AdvancedSearch(maKH, tenKH, sdt, trangThai)
            dgvKhachHang.DataSource = dtResult

        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " & ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrangThai.SelectedIndexChanged
        ThucHienTimKiem()
    End Sub
    Private Sub txtMaKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtMaKhachHang.TextChanged
        ThucHienTimKiem()
    End Sub

    Private Sub txtTenKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtTenKhachHang.TextChanged
        ThucHienTimKiem()
    End Sub
    Private Sub txtSDT_TextChanged(sender As Object, e As EventArgs) Handles txtSDT.TextChanged
        ThucHienTimKiem()
    End Sub
    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        txtMaKhachHang.Clear()
        txtTenKhachHang.Clear()
        txtSDT.Clear()
        cboTrangThai.SelectedIndex = 0
        ThucHienTimKiem()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        If dgvKhachHang.DataSource Is Nothing Then
            MessageBox.Show("Danh sách khách hàng đang trống. Vui lòng bấm tìm kiếm để lấy dữ liệu trước khi in!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dtKetQua As DataTable = CType(dgvKhachHang.DataSource, DataTable)

        If dtKetQua.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy kết quả khách hàng nào hợp lệ để in báo cáo!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Using fIn As New FormInThongTinKhachHang()
            fIn.DuLieuInKhachHang = dtKetQua
            fIn.ShowDialog()
        End Using
    End Sub
End Class