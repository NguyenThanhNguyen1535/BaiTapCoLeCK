<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiemVaXemThongTinKhachHang
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
        Label7 = New Label()
        btnThoat = New Button()
        Label4 = New Label()
        Label1 = New Label()
        btnXemTatCa = New Button()
        btnIn = New Button()
        dgvKhachHang = New DataGridView()
        txtSDT = New TextBox()
        txtTenKhachHang = New TextBox()
        Label2 = New Label()
        txtMaKhachHang = New TextBox()
        Label3 = New Label()
        cboTrangThai = New ComboBox()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(186, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(969, 36)
        Label7.TabIndex = 85
        Label7.Text = "TÌM KIẾM/ XEM THÔNG TIN VÀ IN THÔNG TIN KHÁCH HÀNG"
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(824, 343)
        btnThoat.Margin = New Padding(5, 3, 5, 3)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(156, 35)
        btnThoat.TabIndex = 84
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(752, 148)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 26)
        Label4.TabIndex = 80
        Label4.Text = "Số điện thoại"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(130, 229)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 26)
        Label1.TabIndex = 81
        Label1.Text = "Tên khách hàng"
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXemTatCa.Location = New Point(568, 343)
        btnXemTatCa.Margin = New Padding(5, 3, 5, 3)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(156, 35)
        btnXemTatCa.TabIndex = 77
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' btnIn
        ' 
        btnIn.Anchor = AnchorStyles.Top
        btnIn.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIn.Location = New Point(568, 413)
        btnIn.Margin = New Padding(5, 3, 5, 3)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(156, 35)
        btnIn.TabIndex = 76
        btnIn.Text = "In kết quả"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.Anchor = AnchorStyles.Top
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(14, 487)
        dgvKhachHang.Margin = New Padding(5, 3, 5, 3)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.ReadOnly = True
        dgvKhachHang.RowHeadersWidth = 62
        dgvKhachHang.Size = New Size(1185, 203)
        dgvKhachHang.TabIndex = 75
        ' 
        ' txtSDT
        ' 
        txtSDT.Anchor = AnchorStyles.Top
        txtSDT.Location = New Point(930, 143)
        txtSDT.Margin = New Padding(5, 3, 5, 3)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(208, 31)
        txtSDT.TabIndex = 70
        ' 
        ' txtTenKhachHang
        ' 
        txtTenKhachHang.Anchor = AnchorStyles.Top
        txtTenKhachHang.Location = New Point(349, 224)
        txtTenKhachHang.Margin = New Padding(5, 3, 5, 3)
        txtTenKhachHang.Name = "txtTenKhachHang"
        txtTenKhachHang.Size = New Size(208, 31)
        txtTenKhachHang.TabIndex = 69
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(130, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 26)
        Label2.TabIndex = 86
        Label2.Text = "Mã khách hàng"
        ' 
        ' txtMaKhachHang
        ' 
        txtMaKhachHang.Anchor = AnchorStyles.Top
        txtMaKhachHang.Location = New Point(349, 148)
        txtMaKhachHang.Name = "txtMaKhachHang"
        txtMaKhachHang.Size = New Size(208, 31)
        txtMaKhachHang.TabIndex = 87
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(752, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 26)
        Label3.TabIndex = 86
        Label3.Text = "Trạng thái"
        ' 
        ' cboTrangThai
        ' 
        cboTrangThai.Anchor = AnchorStyles.Top
        cboTrangThai.FormattingEnabled = True
        cboTrangThai.Location = New Point(930, 217)
        cboTrangThai.Name = "cboTrangThai"
        cboTrangThai.Size = New Size(208, 33)
        cboTrangThai.TabIndex = 88
        ' 
        ' TimKiemVaXemThongTinKhachHang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1247, 692)
        Controls.Add(cboTrangThai)
        Controls.Add(txtMaKhachHang)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(btnThoat)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(btnXemTatCa)
        Controls.Add(btnIn)
        Controls.Add(dgvKhachHang)
        Controls.Add(txtSDT)
        Controls.Add(txtTenKhachHang)
        Name = "TimKiemVaXemThongTinKhachHang"
        Text = "NguyenThanhNguyen_31_Nhom11"
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTrangThai As ComboBox
End Class
