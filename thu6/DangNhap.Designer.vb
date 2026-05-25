<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtTaiKhoan = New TextBox()
        txtMatKhau = New TextBox()
        btnDangNhap = New Button()
        btnHuy = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(293, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 36)
        Label1.TabIndex = 0
        Label1.Text = "ĐĂNG NHẬP"
        ' 
        ' txtTaiKhoan
        ' 
        txtTaiKhoan.Location = New Point(372, 114)
        txtTaiKhoan.Name = "txtTaiKhoan"
        txtTaiKhoan.Size = New Size(150, 31)
        txtTaiKhoan.TabIndex = 1
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(372, 177)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(150, 31)
        txtMatKhau.TabIndex = 1
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnDangNhap.Location = New Point(255, 322)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(139, 34)
        btnDangNhap.TabIndex = 2
        btnDangNhap.Text = "Đăng nhập"
        btnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnHuy.Location = New Point(443, 322)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 3
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Label2.Location = New Point(236, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 23)
        Label2.TabIndex = 0
        Label2.Text = "Tài khoản"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Label3.Location = New Point(236, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 23)
        Label3.TabIndex = 0
        Label3.Text = "Mật khẩu"
        ' 
        ' DangNhap
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHuy)
        Controls.Add(btnDangNhap)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTaiKhoan)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DangNhap"
        Text = "DangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
