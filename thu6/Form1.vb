Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '==-----------------------------------------------------------------------==
        ' Chỉnh Form1 hiển thị giữa màn hình
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Tạm thời ẩn Form1 đi khi chưa đăng nhập
        Me.Opacity = 0
        Me.ShowInTaskbar = False

        ' Gọi Form Đăng nhập lên
        Dim frmLogin As New DangNhap() ' Thay đúng tên Form Đăng nhập của bạn
        frmLogin.StartPosition = FormStartPosition.CenterScreen

        ' Nếu đăng nhập thành công
        If frmLogin.ShowDialog() = DialogResult.OK Then
            ' Hiện lại Form1 rõ ràng và cho xuất hiện dưới thanh Taskbar
            Me.Opacity = 1
            Me.ShowInTaskbar = True
        Else
            ' Nếu tắt Form đăng nhập hoặc đăng nhập sai thì thoát hẳn chương trình
            Application.Exit()
        End If
        '==-----------------------------------------------------------------------==



        ' Chỉnh Form1 hiển thị giữa màn hình khi vừa mở phần mềm
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        Dim frmKhachHang As New Quanlikhachhang()
        frmKhachHang.StartPosition = FormStartPosition.CenterScreen
        frmKhachHang.ShowDialog()
    End Sub
    Private Sub QuảnLíLoạiThẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíLoạiThẻToolStripMenuItem.Click
        Dim frmLoaiThe As New Quanliloaithe()
        frmLoaiThe.StartPosition = FormStartPosition.CenterScreen
        frmLoaiThe.ShowDialog()
    End Sub
    Private Sub QuảnLíGiaoDịchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíGiaoDịchToolStripMenuItem.Click
        Dim frmGiaoDich As New Quanligiaodich()
        frmGiaoDich.StartPosition = FormStartPosition.CenterScreen
        frmGiaoDich.ShowDialog()
    End Sub
    Private Sub TìmKiếmGiaoDịchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmGiaoDịchToolStripMenuItem.Click
        Dim frmTimKiem As New TimKiem()
        frmTimKiem.StartPosition = FormStartPosition.CenterScreen
        frmTimKiem.ShowDialog()
    End Sub

    Private Sub InẤnBáoCáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InẤnBáoCáoToolStripMenuItem.Click
        Dim BaoCaoDoanhThu As New BaoCaoDoanhThu()
        BaoCaoDoanhThu.StartPosition = FormStartPosition.CenterScreen
        BaoCaoDoanhThu.ShowDialog()
    End Sub
    Private Sub btnQuanLiKhachHang_Click(sender As Object, e As EventArgs) Handles btnQuanLiKhachHang.Click
        Dim frm As New Quanlikhachhang()
        frm.Show()
    End Sub
    Private Sub btnQuanLiLoaiThe_Click(sender As Object, e As EventArgs) Handles btnQuanLiLoaiThe.Click
        Dim frm As New Quanliloaithe()
        frm.Show()
    End Sub
    Private Sub btnQuanLiGiaoDich_Click(sender As Object, e As EventArgs) Handles btnQuanLiGiaoDich.Click
        Dim frm As New Quanligiaodich()
        frm.Show()
    End Sub
    Private Sub btnTimKiemInAnLichSu_Click(sender As Object, e As EventArgs) Handles btnTimKiemInAnLichSu.Click
        Dim frm As New TimKiem()
        frm.Show()
    End Sub
    Private Sub btnBaoCaoDoanhThu_Click(sender As Object, e As EventArgs) Handles btnBaoCaoDoanhThu.Click
        Dim frm As New BaoCaoDoanhThu()
        frm.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class