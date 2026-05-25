Imports baicole.Models
Imports baicole.Repositories

Public Class CapNhatChiTietHoaDon
    Private WithEvents danh_sach As BindingManagerBase

    Private ctRepo As New ChiTietHoaDonRepository()
    Private hdRepo As New HoaDonRepository()
    Private isAdding As Boolean = False
    Private isBindingData As Boolean = False


    Private Sub CapNhatChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxSoHoaDon()
        TaiDuLieuChiTiet()
        txtMaCTHD.ReadOnly = True
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
    Private Sub LoadComboBoxSoHoaDon()
        Try
            Dim dt = hdRepo.GetDistinct("SoHoaDon")
            cboSoHoaDon.DataSource = dt
            cboSoHoaDon.DisplayMember = "SoHoaDon"
            cboSoHoaDon.ValueMember = "SoHoaDon"
            cboSoHoaDon.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách Số hóa đơn: " & ex.Message)
        End Try
    End Sub
    Private Sub TaiDuLieuChiTiet()
        Try
            Dim dt = ctRepo.GetAll()
            dvg1.DataSource = dt
            If dvg1.Columns.Count > 0 Then
                dvg1.Columns("MaChiTietHD").HeaderText = "Mã Chi Tiết"
                dvg1.Columns("SoHoaDon").HeaderText = "Số Hóa Đơn"
                dvg1.Columns("MaHang").HeaderText = "Mã Hàng"
                dvg1.Columns("SoLuong").HeaderText = "Số Lượng"
                dvg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            If Me.DesignMode = False Then
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                    danh_sach = Me.BindingContext(dt)
                    HienThiDongHienTai()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi tải chi tiết hóa đơn: " & ex.Message)
        End Try
    End Sub

    Private Sub HienThiDongHienTai()
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            isBindingData = True
            txtMaCTHD.ReadOnly = True

            Dim rowView As DataRowView = CType(danh_sach.Current, DataRowView)
            Dim row As DataRow = rowView.Row

            txtMaCTHD.Text = row("MaChiTietHD").ToString()
            cboSoHoaDon.SelectedValue = row("SoHoaDon").ToString()
            txtMaHang.Text = row("MaHang").ToString()
            txtSoLuong.Text = row("SoLuong").ToString()

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

        txtMaCTHD.ReadOnly = False

        txtMaCTHD.Clear()
        cboSoHoaDon.SelectedIndex = -1
        txtMaHang.Clear()
        txtSoLuong.Clear()

        txtMaCTHD.Focus()
        isBindingData = False

        KichHoatChucNang("THEM")
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(txtMaCTHD.Text.Trim()) OrElse
           cboSoHoaDon.SelectedIndex = -1 OrElse
           String.IsNullOrEmpty(txtMaHang.Text.Trim()) Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã chi tiết, số hóa đơn và mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim soLuong As Integer
        If Not Integer.TryParse(txtSoLuong.Text.Trim(), soLuong) Then
            MessageBox.Show("Số lượng phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ct As New ChiTietHoaDon() With {
            .MaChiTietHD = txtMaCTHD.Text.Trim(),
            .SoHoaDon = cboSoHoaDon.SelectedValue.ToString(),
            .MaHang = txtMaHang.Text.Trim(),
            .SoLuong = soLuong
        }

        Try
            If isAdding Then
                ctRepo.Add(ct)
            Else
                ctRepo.Update(ct)
            End If

            MessageBox.Show("Đã lưu chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TaiDuLieuChiTiet()
            txtMaCTHD.ReadOnly = True
            isAdding = False

            KichHoatChucNang("XEM")
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu dữ liệu: " & ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrEmpty(txtMaCTHD.Text.Trim()) Then
            MessageBox.Show("Vui lòng chọn dòng chi tiết hóa đơn cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim xacNhan As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mã chi tiết: " & txtMaCTHD.Text & " không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question)

        If xacNhan = DialogResult.Yes Then
            Try
                ctRepo.Delete(txtMaCTHD.Text.Trim())

                MessageBox.Show("Đã xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtMaCTHD.Clear()
                cboSoHoaDon.SelectedIndex = -1
                txtMaHang.Clear()
                txtSoLuong.Clear()

                TaiDuLieuChiTiet()

                KichHoatChucNang("XEM")
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thực hiện xóa: " & ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnVeDau_Click(sender As Object, e As EventArgs) Handles btnVeDau.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position = 0 Then
                MessageBox.Show("Bạn đang ở dòng đầu tiên rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MessageBox.Show("Bạn đang ở dòng đầu tiên rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MessageBox.Show("Bạn đang ở dòng cuối cùng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnToiCuoi_Click(sender As Object, e As EventArgs) Handles btnToiCuoi.Click
        If danh_sach IsNot Nothing AndAlso danh_sach.Count > 0 Then
            If danh_sach.Position = danh_sach.Count - 1 Then
                MessageBox.Show("Bạn đang ở dòng cuối cùng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub cboSoHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSoHoaDon.SelectedIndexChanged
        NguoiDungBatDauSua()
    End Sub

    Private Sub txtMaHang_TextChanged(sender As Object, e As EventArgs) Handles txtMaHang.TextChanged
        NguoiDungBatDauSua()
    End Sub

    Private Sub txtSoLuong_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuong.TextChanged
        NguoiDungBatDauSua()
    End Sub

    Private Sub txtMaCTHD_TextChanged(sender As Object, e As EventArgs) Handles txtMaCTHD.TextChanged
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        isAdding = False
        txtMaCTHD.ReadOnly = True
        HienThiDongHienTai()
        KichHoatChucNang("XEM")
    End Sub

End Class