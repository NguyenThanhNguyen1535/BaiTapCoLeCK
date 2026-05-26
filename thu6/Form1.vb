Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.Transparent
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

    Private Sub btnTimKiemInThongTinKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemInThongTinKhachHang.Click
        Dim frm As New TimKiemVaXemThongTinKhachHang
        frm.Show()
    End Sub

    Private Sub btnTimKiemInThongTinLoaiThe_Click(sender As Object, e As EventArgs) Handles btnTimKiemInThongTinLoaiThe.Click
        Dim frm As New TimKiemVaXemThongTinThe
        frm.Show()
    End Sub
    Private Sub btnBaoCaoDoanhThu_Click(sender As Object, e As EventArgs) Handles btnBaoCaoDoanhThu.Click
        Dim frm As New BaoCaoDoanhThu
        frm.Show()
    End Sub



    Private Sub TìmKiếmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmKháchHàngToolStripMenuItem.Click
        Dim frm As New TimKiemVaXemThongTinKhachHang()
        frm.Show()
    End Sub

    Private Sub TìmKiếmThẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmThẻToolStripMenuItem.Click
        Dim frm As New TimKiemVaXemThongTinThe()
        frm.Show()
    End Sub


End Class