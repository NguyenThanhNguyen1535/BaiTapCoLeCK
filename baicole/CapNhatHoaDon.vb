Imports baicole.Models
Imports baicole.Repositories

Public Class CapNhatHoaDon

    Private WithEvents danh_sach As BindingManagerBase

    Private hdRepo As New HoaDonRepository()
    Private isAdding As Boolean = False


    Private isBindingData As Boolean = False


    Private Sub CapNhatHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuHoaDon()

        txtSoHoaDon.ReadOnly = True
        KichHoatChucNang("XEM")
    End Sub
    Private Sub KichHoatChucNang(ByVal status As String)
        Select Case status
            Case "XEM"
                btnThem.Enabled = True
                btnXoa.Enabled = True
                btnLuu.Enabled = False
                btnHuy.Enabled = False
                dvg1.Enabled = True
                btnVeDau.Enabled = True
                btnLuiLai.Enabled = True
                btnTienToi.Enabled = True
                btnToiCuoi.Enabled = True

            Case "THEM"

                btnThem.Enabled = False
                btnXoa.Enabled = False
                btnLuu.Enabled = True
                btnHuy.Enabled = True
                dvg1.Enabled = False
                btnVeDau.Enabled = False
                btnLuiLai.Enabled = False
                btnTienToi.Enabled = False
                btnToiCuoi.Enabled = False

            Case "SUA"

                btnThem.Enabled = False
                btnXoa.Enabled = False
                btnLuu.Enabled = True
                btnHuy.Enabled = True

                dvg1.Enabled = False
                btnVeDau.Enabled = False
                btnLuiLai.Enabled = False
                btnTienToi.Enabled = False
                btnToiCuoi.Enabled = False
        End Select
    End Sub

    Private Sub TaiDuLieuHoaDon()
        Try
            Dim dt = hdRepo.GetAll()
            dvg1.DataSource = dt
            If Me.DesignMode = False Then
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                    danh_sach = Me.BindingContext(dt)

                    HienThiDongHienTai()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub HienThiDongHienTai()
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then

            isBindingData = True

            txtSoHoaDon.ReadOnly = True

            Dim rowView As DataRowView = CType(danh_sach.Current, DataRowView)
            Dim row As DataRow = rowView.Row

            txtSoHoaDon.Text = row("SoHoaDon").ToString()
            txtMaKhachHang.Text = row("MaKhachHang").ToString()
            txtMaNhanVien.Text = row("MaNhanVien").ToString()

            If row("NgayBan") IsNot DBNull.Value Then
                dtpNgayBan.Value = Convert.ToDateTime(row("NgayBan"))
            Else
                dtpNgayBan.Value = DateTime.Now
            End If


            dvg1.ClearSelection()
            dvg1.Rows(danh_sach.Position).Selected = True


            isBindingData = False
        End If
    End Sub


    Private Sub dvg1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg1.CellClick
        If e.RowIndex >= 0 AndAlso danh_sach IsNot Nothing Then
            isAdding = False
            danh_sach.Position = e.RowIndex
            HienThiDongHienTai()


            KichHoatChucNang("XEM")
        End If
    End Sub


    Private Sub btnThemMoi_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        isAdding = True
        isBindingData = True

        txtSoHoaDon.ReadOnly = False


        txtSoHoaDon.Clear()
        txtMaKhachHang.Clear()
        txtMaNhanVien.Clear()
        dtpNgayBan.Value = DateTime.Now

        txtSoHoaDon.Focus()
        isBindingData = False
        KichHoatChucNang("THEM")
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(txtSoHoaDon.Text.Trim()) Then
            MessageBox.Show("Vui lòng điền Số hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hd As New HoaDon() With {
            .SoHoaDon = txtSoHoaDon.Text.Trim(),
            .NgayBan = dtpNgayBan.Value.Date,
            .MaKhachHang = txtMaKhachHang.Text.Trim(),
            .MaNhanVien = txtMaNhanVien.Text.Trim()
        }

        Try
            If isAdding Then
                hdRepo.Add(hd)
            Else
                hdRepo.Update(hd)
            End If

            MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TaiDuLieuHoaDon()
            txtSoHoaDon.ReadOnly = True
            isAdding = False

            KichHoatChucNang("XEM")

        Catch ex As Exception
            MessageBox.Show("Không thể lưu dữ liệu. Lỗi: " & ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrEmpty(txtSoHoaDon.Text.Trim()) Then
            MessageBox.Show("Vui lòng chọn một hóa đơn từ danh sách trước khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim xacNhan As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn số: " & txtSoHoaDon.Text & " không?" & vbCrLf &
                                                      "Lưu ý: Tất cả chi tiết thuộc hóa đơn này cũng sẽ bị xóa theo!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If xacNhan = DialogResult.Yes Then
            Try
                Dim rowsAffected As Integer = hdRepo.Delete(txtSoHoaDon.Text.Trim())

                If rowsAffected > 0 Then
                    MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TaiDuLieuHoaDon()
                    KichHoatChucNang("XEM")
                Else
                    MessageBox.Show("Không tìm thấy hóa đơn này trong hệ thống để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa dữ liệu: " & ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnVeDau_Click(sender As Object, e As EventArgs) Handles btnVeDau.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position = 0 Then
                MessageBox.Show("Bạn đang ở hóa đơn đầu tiên rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                danh_sach.Position = 0
                HienThiDongHienTai()
                KichHoatChucNang("XEM")
            End If
        End If
    End Sub

    Private Sub btnLuiLai_Click(sender As Object, e As EventArgs) Handles btnLuiLai.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position > 0 Then
                danh_sach.Position -= 1
                HienThiDongHienTai()
                KichHoatChucNang("XEM")
            Else
                MessageBox.Show("Bạn đang ở hóa đơn đầu tiên rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnTienToi_Click(sender As Object, e As EventArgs) Handles btnTienToi.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position < danh_sach.Count - 1 Then
                danh_sach.Position += 1
                HienThiDongHienTai()
                KichHoatChucNang("XEM")
            Else
                MessageBox.Show("Bạn đang ở hóa đơn cuối cùng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnToiCuoi_Click(sender As Object, e As EventArgs) Handles btnToiCuoi.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position = danh_sach.Count - 1 Then
                MessageBox.Show("Bạn đang ở hóa đơn cuối cùng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                danh_sach.Position = danh_sach.Count - 1
                HienThiDongHienTai()
                KichHoatChucNang("XEM")
            End If
        End If
    End Sub


    Private Sub NguoiDungBatDauSua()

        If Not isBindingData AndAlso Not isAdding Then
            KichHoatChucNang("SUA")
        End If
    End Sub

    Private Sub txtMaKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtMaKhachHang.TextChanged
        NguoiDungBatDauSua()
    End Sub

    Private Sub txtMaNhanVien_TextChanged(sender As Object, e As EventArgs) Handles txtMaNhanVien.TextChanged
        NguoiDungBatDauSua()
    End Sub

    Private Sub dtpNgayBan_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayBan.ValueChanged
        NguoiDungBatDauSua()
    End Sub


    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        isAdding = False
        txtSoHoaDon.ReadOnly = True


        HienThiDongHienTai()

        KichHoatChucNang("XEM")
    End Sub
End Class