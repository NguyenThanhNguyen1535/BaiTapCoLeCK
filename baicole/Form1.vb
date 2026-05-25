Public Class Form1
    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        ' 1. Khởi tạo một đối tượng mới từ Form CapNhatHoaDon
        Dim frm As New CapNhatHoaDon()

        ' 2. Hiển thị Form lên màn hình
        frm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        Dim frm As New CapNhatChiTietHoaDon()

        ' 2. Hiển thị Form lên màn hình
        frm.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem1.Click
        Dim frm As New TimKiemHoaDon()

        ' 2. Hiển thị Form lên màn hình
        frm.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem1.Click
        Dim frm As New TimKiemChiTietHoaDon()

        ' 2. Hiển thị Form lên màn hình
        frm.Show()
    End Sub
End Class