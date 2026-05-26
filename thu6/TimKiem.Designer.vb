<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimKiem))
        txtTenKhachHang = New TextBox()
        txtSDT = New TextBox()
        cboNhaMang = New ComboBox()
        cboMenhGia = New ComboBox()
        dtpDenNgay = New DateTimePicker()
        dtpTuNgay = New DateTimePicker()
        dgvLichSu = New DataGridView()
        btnIn = New Button()
        btnXemTatCa = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnThoat = New Button()
        Label7 = New Label()
        CType(dgvLichSu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTenKhachHang
        ' 
        txtTenKhachHang.Anchor = AnchorStyles.Top
        txtTenKhachHang.Location = New Point(295, 164)
        txtTenKhachHang.Margin = New Padding(5, 3, 5, 3)
        txtTenKhachHang.Name = "txtTenKhachHang"
        txtTenKhachHang.Size = New Size(208, 35)
        txtTenKhachHang.TabIndex = 0
        ' 
        ' txtSDT
        ' 
        txtSDT.Anchor = AnchorStyles.Top
        txtSDT.Location = New Point(771, 162)
        txtSDT.Margin = New Padding(5, 3, 5, 3)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(208, 35)
        txtSDT.TabIndex = 1
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.Anchor = AnchorStyles.Top
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(296, 223)
        cboNhaMang.Margin = New Padding(5, 3, 5, 3)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(208, 34)
        cboNhaMang.TabIndex = 2
        ' 
        ' cboMenhGia
        ' 
        cboMenhGia.Anchor = AnchorStyles.Top
        cboMenhGia.FormattingEnabled = True
        cboMenhGia.Location = New Point(771, 223)
        cboMenhGia.Margin = New Padding(5, 3, 5, 3)
        cboMenhGia.Name = "cboMenhGia"
        cboMenhGia.Size = New Size(208, 34)
        cboMenhGia.TabIndex = 3
        ' 
        ' dtpDenNgay
        ' 
        dtpDenNgay.Anchor = AnchorStyles.Top
        dtpDenNgay.Location = New Point(771, 289)
        dtpDenNgay.Margin = New Padding(5, 3, 5, 3)
        dtpDenNgay.Name = "dtpDenNgay"
        dtpDenNgay.Size = New Size(208, 35)
        dtpDenNgay.TabIndex = 4
        ' 
        ' dtpTuNgay
        ' 
        dtpTuNgay.Anchor = AnchorStyles.Top
        dtpTuNgay.Location = New Point(296, 291)
        dtpTuNgay.Margin = New Padding(5, 3, 5, 3)
        dtpTuNgay.Name = "dtpTuNgay"
        dtpTuNgay.Size = New Size(208, 35)
        dtpTuNgay.TabIndex = 4
        ' 
        ' dgvLichSu
        ' 
        dgvLichSu.Anchor = AnchorStyles.Top
        dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLichSu.Location = New Point(36, 421)
        dgvLichSu.Margin = New Padding(5, 3, 5, 3)
        dgvLichSu.Name = "dgvLichSu"
        dgvLichSu.ReadOnly = True
        dgvLichSu.RowHeadersWidth = 62
        dgvLichSu.Size = New Size(1577, 366)
        dgvLichSu.TabIndex = 5
        ' 
        ' btnIn
        ' 
        btnIn.Anchor = AnchorStyles.Top
        btnIn.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIn.Location = New Point(631, 379)
        btnIn.Margin = New Padding(5, 3, 5, 3)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(156, 35)
        btnIn.TabIndex = 7
        btnIn.Text = "In kết quả"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXemTatCa.Location = New Point(1098, 161)
        btnXemTatCa.Margin = New Padding(5, 3, 5, 3)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(156, 35)
        btnXemTatCa.TabIndex = 8
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(99, 171)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 26)
        Label1.TabIndex = 9
        Label1.Text = "Tên khách hàng"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(99, 231)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 26)
        Label2.TabIndex = 9
        Label2.Text = "Nhà mạng"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(600, 231)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 26)
        Label3.TabIndex = 9
        Label3.Text = "Mệnh giá"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(596, 171)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 26)
        Label4.TabIndex = 9
        Label4.Text = "Số điện thoại"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label5.Location = New Point(596, 295)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 26)
        Label5.TabIndex = 10
        Label5.Text = "Đến ngày"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label6.Location = New Point(99, 296)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 26)
        Label6.TabIndex = 11
        Label6.Text = "Từ ngày"
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(1098, 223)
        btnThoat.Margin = New Padding(5, 3, 5, 3)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(156, 35)
        btnThoat.TabIndex = 67
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(385, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(869, 36)
        Label7.TabIndex = 68
        Label7.Text = "TÌM KIẾM/ XEM THÔNG TIN VÀ IN LỊCH SỬ GIAO DỊCH"
        ' 
        ' TimKiem
        ' 
        AutoScaleDimensions = New SizeF(14F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1666, 783)
        Controls.Add(Label7)
        Controls.Add(btnThoat)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnXemTatCa)
        Controls.Add(btnIn)
        Controls.Add(dgvLichSu)
        Controls.Add(dtpTuNgay)
        Controls.Add(dtpDenNgay)
        Controls.Add(cboMenhGia)
        Controls.Add(cboNhaMang)
        Controls.Add(txtSDT)
        Controls.Add(txtTenKhachHang)
        Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Margin = New Padding(5, 3, 5, 3)
        Name = "TimKiem"
        Text = "NguyenThanhNguyen_31_Nhom11"
        CType(dgvLichSu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents cboMenhGia As ComboBox
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dgvLichSu As DataGridView
    Friend WithEvents btnIn As Button
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label7 As Label
End Class
