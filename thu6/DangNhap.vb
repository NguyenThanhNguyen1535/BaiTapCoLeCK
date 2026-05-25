Public Class DangNhap
    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnDangNhap
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtTaiKhoan.Text.Trim() = "" AndAlso txtMatKhau.Text = "" Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class