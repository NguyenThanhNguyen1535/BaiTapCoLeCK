<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanliloaithe
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txMaLoai = New TextBox()
        btnXemTatCa = New Button()
        txtTimKiem = New TextBox()
        dgvLoaiThe = New DataGridView()
        btnLuu = New Button()
        btnXoa = New Button()
        btnSua = New Button()
        btnThem = New Button()
        cboMenhGia = New ComboBox()
        cboNhaMang = New ComboBox()
        Label4 = New Label()
        btnHuy = New Button()
        Label6 = New Label()
        btnThoat = New Button()
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(69, 362)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 26)
        Label3.TabIndex = 26
        Label3.Text = "Mệnh giá"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(69, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 26)
        Label2.TabIndex = 27
        Label2.Text = "Nhà mạng"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(69, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 26)
        Label1.TabIndex = 28
        Label1.Text = "Mã loại thẻ"
        ' 
        ' txMaLoai
        ' 
        txMaLoai.Anchor = AnchorStyles.Top
        txMaLoai.Location = New Point(221, 186)
        txMaLoai.Name = "txMaLoai"
        txMaLoai.Size = New Size(150, 31)
        txMaLoai.TabIndex = 22
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnXemTatCa.Location = New Point(1060, 138)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(109, 34)
        btnXemTatCa.TabIndex = 20
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' txtTimKiem
        ' 
        txtTimKiem.Anchor = AnchorStyles.Top
        txtTimKiem.Location = New Point(613, 141)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.PlaceholderText = "Nhập mã loại thẻ hoặc tên nhà mạng hoặc mệnh giá"
        txtTimKiem.Size = New Size(428, 31)
        txtTimKiem.TabIndex = 19
        ' 
        ' dgvLoaiThe
        ' 
        dgvLoaiThe.Anchor = AnchorStyles.Top
        dgvLoaiThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiThe.Location = New Point(517, 186)
        dgvLoaiThe.Name = "dgvLoaiThe"
        dgvLoaiThe.ReadOnly = True
        dgvLoaiThe.RowHeadersWidth = 62
        dgvLoaiThe.Size = New Size(652, 437)
        dgvLoaiThe.TabIndex = 17
        ' 
        ' btnLuu
        ' 
        btnLuu.Anchor = AnchorStyles.Top
        btnLuu.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnLuu.Location = New Point(221, 589)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(112, 34)
        btnLuu.TabIndex = 16
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Anchor = AnchorStyles.Top
        btnXoa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXoa.Location = New Point(357, 519)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(112, 34)
        btnXoa.TabIndex = 15
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Anchor = AnchorStyles.Top
        btnSua.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnSua.Location = New Point(222, 519)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(112, 34)
        btnSua.TabIndex = 14
        btnSua.Text = "Sửa "
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Anchor = AnchorStyles.Top
        btnThem.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThem.Location = New Point(78, 519)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(112, 34)
        btnThem.TabIndex = 13
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' cboMenhGia
        ' 
        cboMenhGia.Anchor = AnchorStyles.Top
        cboMenhGia.FormattingEnabled = True
        cboMenhGia.Location = New Point(221, 354)
        cboMenhGia.Name = "cboMenhGia"
        cboMenhGia.Size = New Size(150, 33)
        cboMenhGia.TabIndex = 29
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.Anchor = AnchorStyles.Top
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(222, 268)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(150, 33)
        cboNhaMang.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(405, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(311, 36)
        Label4.TabIndex = 31
        Label4.Text = "QUẢN LÍ LOẠI THẺ" & vbCrLf
        ' 
        ' btnHuy
        ' 
        btnHuy.Anchor = AnchorStyles.Top
        btnHuy.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnHuy.Location = New Point(357, 589)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 32
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(517, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 23)
        Label6.TabIndex = 64
        Label6.Text = "Tìm kiếm"
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(78, 589)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(112, 34)
        btnThoat.TabIndex = 67
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Quanliloaithe
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1181, 699)
        Controls.Add(btnThoat)
        Controls.Add(Label6)
        Controls.Add(btnHuy)
        Controls.Add(Label4)
        Controls.Add(cboNhaMang)
        Controls.Add(cboMenhGia)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txMaLoai)
        Controls.Add(btnXemTatCa)
        Controls.Add(txtTimKiem)
        Controls.Add(dgvLoaiThe)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Name = "Quanliloaithe"
        Text = "NguyenThanhNguyen"
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txMaLoai As TextBox
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dgvLoaiThe As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cboMenhGia As ComboBox
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnThoat As Button
End Class
