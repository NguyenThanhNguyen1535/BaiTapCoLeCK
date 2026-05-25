<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapNhatHoaDon
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
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        btnLuu = New Button()
        dvg1 = New DataGridView()
        txtSoHoaDon = New TextBox()
        txtMaKhachHang = New TextBox()
        txtMaNhanVien = New TextBox()
        dtpNgayBan = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnToiCuoi = New Button()
        btnVeDau = New Button()
        btnTienToi = New Button()
        btnLuiLai = New Button()
        btnHuy = New Button()
        CType(dvg1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(260, 139)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(112, 34)
        btnThem.TabIndex = 0
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(405, 139)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(112, 34)
        btnSua.TabIndex = 0
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(559, 139)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(112, 34)
        btnXoa.TabIndex = 0
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnLuu
        ' 
        btnLuu.Location = New Point(710, 139)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(112, 34)
        btnLuu.TabIndex = 0
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' dvg1
        ' 
        dvg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvg1.Location = New Point(586, 210)
        dvg1.Name = "dvg1"
        dvg1.RowHeadersWidth = 62
        dvg1.Size = New Size(449, 348)
        dvg1.TabIndex = 1
        ' 
        ' txtSoHoaDon
        ' 
        txtSoHoaDon.Location = New Point(260, 210)
        txtSoHoaDon.Name = "txtSoHoaDon"
        txtSoHoaDon.Size = New Size(150, 31)
        txtSoHoaDon.TabIndex = 2
        ' 
        ' txtMaKhachHang
        ' 
        txtMaKhachHang.Location = New Point(260, 278)
        txtMaKhachHang.Name = "txtMaKhachHang"
        txtMaKhachHang.Size = New Size(150, 31)
        txtMaKhachHang.TabIndex = 3
        ' 
        ' txtMaNhanVien
        ' 
        txtMaNhanVien.Location = New Point(257, 355)
        txtMaNhanVien.Name = "txtMaNhanVien"
        txtMaNhanVien.Size = New Size(150, 31)
        txtMaNhanVien.TabIndex = 4
        ' 
        ' dtpNgayBan
        ' 
        dtpNgayBan.Location = New Point(257, 421)
        dtpNgayBan.Name = "dtpNgayBan"
        dtpNgayBan.Size = New Size(219, 31)
        dtpNgayBan.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 7
        Label1.Text = "Số hóa đơn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(108, 281)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 25)
        Label2.TabIndex = 7
        Label2.Text = "Mã khách hàng"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(108, 361)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 25)
        Label3.TabIndex = 7
        Label3.Text = "Mã nhân viên"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(108, 426)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 25)
        Label4.TabIndex = 7
        Label4.Text = "Ngày bán"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(409, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(263, 36)
        Label5.TabIndex = 8
        Label5.Text = "Cập nhật hóa đơn"
        ' 
        ' btnToiCuoi
        ' 
        btnToiCuoi.Location = New Point(899, 600)
        btnToiCuoi.Name = "btnToiCuoi"
        btnToiCuoi.Size = New Size(52, 34)
        btnToiCuoi.TabIndex = 29
        btnToiCuoi.Text = ">>"
        btnToiCuoi.UseVisualStyleBackColor = True
        ' 
        ' btnVeDau
        ' 
        btnVeDau.Location = New Point(710, 599)
        btnVeDau.Name = "btnVeDau"
        btnVeDau.Size = New Size(52, 34)
        btnVeDau.TabIndex = 28
        btnVeDau.Text = "<<"
        btnVeDau.UseVisualStyleBackColor = True
        ' 
        ' btnTienToi
        ' 
        btnTienToi.Location = New Point(841, 599)
        btnTienToi.Name = "btnTienToi"
        btnTienToi.Size = New Size(52, 34)
        btnTienToi.TabIndex = 27
        btnTienToi.Text = ">"
        btnTienToi.UseVisualStyleBackColor = True
        ' 
        ' btnLuiLai
        ' 
        btnLuiLai.Location = New Point(768, 599)
        btnLuiLai.Name = "btnLuiLai"
        btnLuiLai.Size = New Size(52, 34)
        btnLuiLai.TabIndex = 26
        btnLuiLai.Text = "<"
        btnLuiLai.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(865, 139)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 30
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' CapNhatHoaDon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1076, 657)
        Controls.Add(btnHuy)
        Controls.Add(btnToiCuoi)
        Controls.Add(btnVeDau)
        Controls.Add(btnTienToi)
        Controls.Add(btnLuiLai)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpNgayBan)
        Controls.Add(txtMaNhanVien)
        Controls.Add(txtMaKhachHang)
        Controls.Add(txtSoHoaDon)
        Controls.Add(dvg1)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Name = "CapNhatHoaDon"
        Text = "NguyenThanhNguyen_31"
        CType(dvg1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents dvg1 As DataGridView
    Friend WithEvents txtSoHoaDon As TextBox
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents txtMaNhanVien As TextBox
    Friend WithEvents dtpNgayBan As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnToiCuoi As Button
    Friend WithEvents btnVeDau As Button
    Friend WithEvents btnTienToi As Button
    Friend WithEvents btnLuiLai As Button
    Friend WithEvents btnHuy As Button
End Class
