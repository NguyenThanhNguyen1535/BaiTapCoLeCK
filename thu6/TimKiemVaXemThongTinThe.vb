Imports System.Data

Public Class TimKiemVaXemThongTinThe
    Private _loaiTheRepo As New LoaiTheRepository()
    Private _isBinding As Boolean = False
    Private Sub TimKiemVaXemThongTinThe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLoaiThe.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False
        dgvLoaiThe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        _isBinding = True
        cboNhaMang.Items.Clear()
        cboNhaMang.Items.Add("Tất cả")
        Try
            Dim dsNhaMang As List(Of String) = _loaiTheRepo.GetNhaMangList()
            For Each nhaMang As String In dsNhaMang
                cboNhaMang.Items.Add(nhaMang)
            Next
        Catch ex As Exception
        End Try
        cboNhaMang.SelectedIndex = 0
        cboMenhGia.Items.Clear()
        cboMenhGia.Items.Add("Tất cả")
        Try
            Dim dsMenhGia As List(Of Decimal) = _loaiTheRepo.GetAllMenhGia()
            For Each menhGia As Decimal In dsMenhGia
                cboMenhGia.Items.Add(menhGia.ToString("G0"))
            Next
        Catch ex As Exception
        End Try
        cboMenhGia.SelectedIndex = 0
        cboTrangThai.Items.Clear()
        cboTrangThai.Items.Add("Tất cả")
        cboTrangThai.Items.Add("Đang hoạt động")
        cboTrangThai.Items.Add("Đã ẩn")
        cboTrangThai.SelectedIndex = 0

        _isBinding = False
        ThucHienLocDuLieu()
    End Sub
    Private Sub ThucHienLocDuLieu()
        If _isBinding Then Return
        Dim maLoai As String = txtMaLoai.Text.Trim()
        Dim tenNhaMang As String = ""
        If cboNhaMang.SelectedIndex > 0 Then
            tenNhaMang = cboNhaMang.SelectedItem.ToString()
        End If
        Dim menhGia As Decimal? = Nothing
        If cboMenhGia.SelectedIndex > 0 Then
            Dim giaTriParse As Decimal
            If Decimal.TryParse(cboMenhGia.SelectedItem.ToString(), giaTriParse) Then
                menhGia = giaTriParse
            End If
        End If
        Dim trangThai As Integer? = Nothing
        If cboTrangThai.SelectedIndex = 1 Then
            trangThai = 1
        ElseIf cboTrangThai.SelectedIndex = 2 Then
            trangThai = 0
        End If
        Try
            Dim bangKetQua As DataTable = _loaiTheRepo.AdvancedSearch(maLoai, tenNhaMang, menhGia, trangThai)
            dgvLoaiThe.DataSource = bangKetQua
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lọc dữ liệu: " & ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtMaLoai_TextChanged(sender As Object, e As EventArgs) Handles txtMaLoai.TextChanged
        ThucHienLocDuLieu()
    End Sub

    Private Sub cboNhaMang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNhaMang.SelectedIndexChanged
        ThucHienLocDuLieu()
    End Sub

    Private Sub cboMenhGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenhGia.SelectedIndexChanged
        ThucHienLocDuLieu()
    End Sub

    Private Sub cboTrangThai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrangThai.SelectedIndexChanged
        ThucHienLocDuLieu()
    End Sub
    Private Sub dgvLoaiThe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiThe.CellContentClick
        If e.RowIndex >= 0 Then
            _isBinding = True

            Dim dongDuLieu As DataGridViewRow = dgvLoaiThe.Rows(e.RowIndex)
            txtMaLoai.Text = dongDuLieu.Cells("Mã loại").Value.ToString()
            Dim nhaMangDuLieu As String = dongDuLieu.Cells("Nhà mạng").Value.ToString()
            If cboNhaMang.Items.Contains(nhaMangDuLieu) Then
                cboNhaMang.SelectedItem = nhaMangDuLieu
            Else
                cboNhaMang.SelectedIndex = 0
            End If
            Dim menhGiaDuLieu As String = Convert.ToDecimal(dongDuLieu.Cells("Mệnh giá").Value).ToString("G0")
            If cboMenhGia.Items.Contains(menhGiaDuLieu) Then
                cboMenhGia.SelectedItem = menhGiaDuLieu
            Else
                cboMenhGia.SelectedIndex = 0
            End If
            Dim trangThaiText As String = dongDuLieu.Cells("Trạng thái").Value.ToString()
            If trangThaiText = "Hoạt động" Then
                cboTrangThai.SelectedIndex = 1
            Else
                cboTrangThai.SelectedIndex = 2
            End If

            _isBinding = False
        End If
    End Sub
    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        _isBinding = True
        txtMaLoai.Clear()
        cboNhaMang.SelectedIndex = 0
        cboMenhGia.SelectedIndex = 0
        cboTrangThai.SelectedIndex = 0
        _isBinding = False
        ThucHienLocDuLieu()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If dgvLoaiThe.DataSource Is Nothing Then
            MessageBox.Show("Danh sách loại thẻ đang trống. Vui lòng bấm tìm kiếm để lấy dữ liệu trước khi in!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim dtKetQua As DataTable = CType(dgvLoaiThe.DataSource, DataTable)
        If dtKetQua.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy kết quả loại thẻ nào hợp lệ để in báo cáo!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Using fIn As New FormInThongTinLoaiThe()
            fIn.DuLieuInLoaiThe = dtKetQua
            fIn.ShowDialog()
        End Using
    End Sub
End Class