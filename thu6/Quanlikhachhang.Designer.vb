<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlikhachhang
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtSoDu = New TextBox()
        txtSDT = New TextBox()
        txtTenKhachHang = New TextBox()
        txtMaKhachHang = New TextBox()
        btnXemTatCa = New Button()
        txtTimKiem = New TextBox()
        dgvKhachHang = New DataGridView()
        btnLuu = New Button()
        btnXoa = New Button()
        btnSua = New Button()
        btnThem = New Button()
        btnHuy = New Button()
        Label6 = New Label()
        btnThoat = New Button()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(461, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(382, 36)
        Label5.TabIndex = 13
        Label5.Text = "QUẢN LÍ KHÁCH HÀNG" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(101, 415)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 26)
        Label4.TabIndex = 61
        Label4.Text = "Số tiền nạp"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(101, 335)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 26)
        Label3.TabIndex = 60
        Label3.Text = "Số điện thoại"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(101, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 26)
        Label2.TabIndex = 59
        Label2.Text = "Tên khách hàng"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(102, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 26)
        Label1.TabIndex = 58
        Label1.Text = "Mã khách hàng"
        ' 
        ' txtSoDu
        ' 
        txtSoDu.Anchor = AnchorStyles.Top
        txtSoDu.Location = New Point(320, 409)
        txtSoDu.Name = "txtSoDu"
        txtSoDu.Size = New Size(150, 31)
        txtSoDu.TabIndex = 57
        ' 
        ' txtSDT
        ' 
        txtSDT.Anchor = AnchorStyles.Top
        txtSDT.Location = New Point(320, 329)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(150, 31)
        txtSDT.TabIndex = 56
        ' 
        ' txtTenKhachHang
        ' 
        txtTenKhachHang.Anchor = AnchorStyles.Top
        txtTenKhachHang.Location = New Point(320, 260)
        txtTenKhachHang.Name = "txtTenKhachHang"
        txtTenKhachHang.Size = New Size(150, 31)
        txtTenKhachHang.TabIndex = 55
        ' 
        ' txtMaKhachHang
        ' 
        txtMaKhachHang.Anchor = AnchorStyles.Top
        txtMaKhachHang.Location = New Point(320, 193)
        txtMaKhachHang.Name = "txtMaKhachHang"
        txtMaKhachHang.Size = New Size(150, 31)
        txtMaKhachHang.TabIndex = 54
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnXemTatCa.Location = New Point(1132, 142)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(116, 34)
        btnXemTatCa.TabIndex = 53
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' txtTimKiem
        ' 
        txtTimKiem.Anchor = AnchorStyles.Top
        txtTimKiem.Location = New Point(720, 145)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.PlaceholderText = "Nhập mã khách hàng hoặc tên hoặc số điện thoại"
        txtTimKiem.Size = New Size(406, 31)
        txtTimKiem.TabIndex = 52
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.Anchor = AnchorStyles.Top
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(612, 193)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.ReadOnly = True
        dgvKhachHang.RowHeadersWidth = 62
        dgvKhachHang.Size = New Size(653, 437)
        dgvKhachHang.TabIndex = 50
        ' 
        ' btnLuu
        ' 
        btnLuu.Anchor = AnchorStyles.Top
        btnLuu.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnLuu.Location = New Point(226, 586)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(112, 34)
        btnLuu.TabIndex = 49
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Anchor = AnchorStyles.Top
        btnXoa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXoa.Location = New Point(358, 515)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(112, 34)
        btnXoa.TabIndex = 48
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Anchor = AnchorStyles.Top
        btnSua.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnSua.Location = New Point(226, 515)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(112, 34)
        btnSua.TabIndex = 47
        btnSua.Text = "Sửa "
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Anchor = AnchorStyles.Top
        btnThem.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThem.Location = New Point(99, 515)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(112, 34)
        btnThem.TabIndex = 46
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Anchor = AnchorStyles.Top
        btnHuy.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnHuy.Location = New Point(358, 586)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 62
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(612, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 23)
        Label6.TabIndex = 63
        Label6.Text = "Tìm kiếm"
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(99, 586)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(112, 34)
        btnThoat.TabIndex = 67
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Quanlikhachhang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1309, 657)
        Controls.Add(btnThoat)
        Controls.Add(Label6)
        Controls.Add(btnHuy)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSoDu)
        Controls.Add(txtSDT)
        Controls.Add(txtTenKhachHang)
        Controls.Add(txtMaKhachHang)
        Controls.Add(btnXemTatCa)
        Controls.Add(txtTimKiem)
        Controls.Add(dgvKhachHang)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(Label5)
        Name = "Quanlikhachhang"
        Text = "NguyenThanhNguyen"
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoDu As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnThoat As Button
End Class
