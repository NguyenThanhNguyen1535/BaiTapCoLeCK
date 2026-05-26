<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanligiaodich
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
        txtMaGiaoDich = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        cboMenhGia = New ComboBox()
        cboNhaMang = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTenKhachHang = New TextBox()
        txtMaKhachHang = New TextBox()
        btnXemTatCa = New Button()
        txtTimKiem = New TextBox()
        dgvGiaoDich = New DataGridView()
        btnLuu = New Button()
        btnXoa = New Button()
        btnSua = New Button()
        btnThem = New Button()
        Label7 = New Label()
        txtSoDu = New TextBox()
        btnHuy = New Button()
        Label8 = New Label()
        btnThoat = New Button()
        CType(dgvGiaoDich, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(595, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(330, 36)
        Label5.TabIndex = 30
        Label5.Text = "QUẢN LÍ GIAO DỊCH" & vbCrLf
        ' 
        ' txtMaGiaoDich
        ' 
        txtMaGiaoDich.Anchor = AnchorStyles.Top
        txtMaGiaoDich.Location = New Point(277, 179)
        txtMaGiaoDich.Name = "txtMaGiaoDich"
        txtMaGiaoDich.Size = New Size(182, 31)
        txtMaGiaoDich.TabIndex = 48
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label6.Location = New Point(93, 184)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 26)
        Label6.TabIndex = 47
        Label6.Text = "Mã giao dịch"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(94, 504)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 26)
        Label4.TabIndex = 46
        Label4.Text = "Mệnh giá"
        ' 
        ' cboMenhGia
        ' 
        cboMenhGia.Anchor = AnchorStyles.Top
        cboMenhGia.FormattingEnabled = True
        cboMenhGia.Location = New Point(277, 497)
        cboMenhGia.Name = "cboMenhGia"
        cboMenhGia.Size = New Size(182, 33)
        cboMenhGia.TabIndex = 45
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.Anchor = AnchorStyles.Top
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(277, 413)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(182, 33)
        cboNhaMang.TabIndex = 44
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(94, 420)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 26)
        Label3.TabIndex = 43
        Label3.Text = "Nhà mạng"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(94, 334)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 26)
        Label2.TabIndex = 41
        Label2.Text = "Tên khách hàng"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(94, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 26)
        Label1.TabIndex = 42
        Label1.Text = "Số điện thoai"
        ' 
        ' txtTenKhachHang
        ' 
        txtTenKhachHang.Anchor = AnchorStyles.Top
        txtTenKhachHang.Location = New Point(277, 328)
        txtTenKhachHang.Name = "txtTenKhachHang"
        txtTenKhachHang.Size = New Size(182, 31)
        txtTenKhachHang.TabIndex = 40
        ' 
        ' txtMaKhachHang
        ' 
        txtMaKhachHang.Anchor = AnchorStyles.Top
        txtMaKhachHang.Location = New Point(277, 248)
        txtMaKhachHang.Name = "txtMaKhachHang"
        txtMaKhachHang.Size = New Size(182, 31)
        txtMaKhachHang.TabIndex = 39
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnXemTatCa.Location = New Point(1060, 139)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(107, 34)
        btnXemTatCa.TabIndex = 38
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' txtTimKiem
        ' 
        txtTimKiem.Anchor = AnchorStyles.Top
        txtTimKiem.Location = New Point(671, 139)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.PlaceholderText = "Nhập mã giao dịch hoặc tên hoặc số điện thoại"
        txtTimKiem.Size = New Size(383, 31)
        txtTimKiem.TabIndex = 37
        ' 
        ' dgvGiaoDich
        ' 
        dgvGiaoDich.Anchor = AnchorStyles.Top
        dgvGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGiaoDich.Location = New Point(549, 179)
        dgvGiaoDich.Name = "dgvGiaoDich"
        dgvGiaoDich.ReadOnly = True
        dgvGiaoDich.RowHeadersWidth = 62
        dgvGiaoDich.Size = New Size(1088, 437)
        dgvGiaoDich.TabIndex = 35
        ' 
        ' btnLuu
        ' 
        btnLuu.Anchor = AnchorStyles.Top
        btnLuu.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnLuu.Location = New Point(240, 714)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(112, 34)
        btnLuu.TabIndex = 34
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Anchor = AnchorStyles.Top
        btnXoa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXoa.Location = New Point(368, 648)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(112, 34)
        btnXoa.TabIndex = 33
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Anchor = AnchorStyles.Top
        btnSua.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnSua.Location = New Point(240, 648)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(112, 34)
        btnSua.TabIndex = 32
        btnSua.Text = "Sửa "
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Anchor = AnchorStyles.Top
        btnThem.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThem.Location = New Point(103, 648)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(112, 34)
        btnThem.TabIndex = 31
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label7.Location = New Point(94, 583)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 26)
        Label7.TabIndex = 49
        Label7.Text = "Số dư"
        ' 
        ' txtSoDu
        ' 
        txtSoDu.Anchor = AnchorStyles.Top
        txtSoDu.Location = New Point(277, 578)
        txtSoDu.Name = "txtSoDu"
        txtSoDu.Size = New Size(182, 31)
        txtSoDu.TabIndex = 50
        ' 
        ' btnHuy
        ' 
        btnHuy.Anchor = AnchorStyles.Top
        btnHuy.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnHuy.Location = New Point(368, 714)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 51
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(575, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 23)
        Label8.TabIndex = 65
        Label8.Text = "Tìm kiếm"
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(103, 714)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(112, 34)
        btnThoat.TabIndex = 66
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Quanligiaodich
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1649, 764)
        Controls.Add(btnThoat)
        Controls.Add(Label8)
        Controls.Add(btnHuy)
        Controls.Add(txtSoDu)
        Controls.Add(Label7)
        Controls.Add(txtMaGiaoDich)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(cboMenhGia)
        Controls.Add(cboNhaMang)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTenKhachHang)
        Controls.Add(txtMaKhachHang)
        Controls.Add(btnXemTatCa)
        Controls.Add(txtTimKiem)
        Controls.Add(dgvGiaoDich)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(Label5)
        Name = "Quanligiaodich"
        Text = "NguyenThanhNguyen_31_Nhom11"
        CType(dgvGiaoDich, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaGiaoDich As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMenhGia As ComboBox
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dgvGiaoDich As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoDu As TextBox
    Friend WithEvents btnHuy As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnThoat As Button
End Class
