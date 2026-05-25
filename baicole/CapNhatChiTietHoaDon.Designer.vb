<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapNhatChiTietHoaDon
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
        txtMaHang = New TextBox()
        txtMaCTHD = New TextBox()
        dvg1 = New DataGridView()
        btnLuu = New Button()
        btnXoa = New Button()
        btnSua = New Button()
        btnThem = New Button()
        cboSoHoaDon = New ComboBox()
        txtSoLuong = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnLuiLai = New Button()
        btnTienToi = New Button()
        btnVeDau = New Button()
        btnToiCuoi = New Button()
        btnHuy = New Button()
        CType(dvg1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtMaHang
        ' 
        txtMaHang.Location = New Point(332, 447)
        txtMaHang.Name = "txtMaHang"
        txtMaHang.Size = New Size(150, 31)
        txtMaHang.TabIndex = 14
        ' 
        ' txtMaCTHD
        ' 
        txtMaCTHD.Location = New Point(332, 308)
        txtMaCTHD.Name = "txtMaCTHD"
        txtMaCTHD.Size = New Size(150, 31)
        txtMaCTHD.TabIndex = 12
        ' 
        ' dvg1
        ' 
        dvg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvg1.Location = New Point(597, 302)
        dvg1.Name = "dvg1"
        dvg1.RowHeadersWidth = 62
        dvg1.Size = New Size(449, 348)
        dvg1.TabIndex = 11
        ' 
        ' btnLuu
        ' 
        btnLuu.Location = New Point(753, 165)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(112, 34)
        btnLuu.TabIndex = 7
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(597, 165)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(112, 34)
        btnXoa.TabIndex = 8
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(452, 165)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(112, 34)
        btnSua.TabIndex = 9
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(306, 165)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(112, 34)
        btnThem.TabIndex = 10
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' cboSoHoaDon
        ' 
        cboSoHoaDon.FormattingEnabled = True
        cboSoHoaDon.Location = New Point(332, 373)
        cboSoHoaDon.Name = "cboSoHoaDon"
        cboSoHoaDon.Size = New Size(150, 33)
        cboSoHoaDon.TabIndex = 16
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(332, 519)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(150, 31)
        txtSoLuong.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 311)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 25)
        Label1.TabIndex = 18
        Label1.Text = "Mã chi tiết hóa đơn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 378)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 18
        Label2.Text = "Mã hóa đơn"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 450)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 18
        Label3.Text = "Mã hàng"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(119, 525)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 18
        Label4.Text = "Số lượng"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(410, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(365, 36)
        Label5.TabIndex = 19
        Label5.Text = "Cập nhật chi tiết hóa đơn"
        ' 
        ' btnLuiLai
        ' 
        btnLuiLai.Location = New Point(791, 656)
        btnLuiLai.Name = "btnLuiLai"
        btnLuiLai.Size = New Size(52, 34)
        btnLuiLai.TabIndex = 21
        btnLuiLai.Text = "<"
        btnLuiLai.UseVisualStyleBackColor = True
        ' 
        ' btnTienToi
        ' 
        btnTienToi.Location = New Point(864, 656)
        btnTienToi.Name = "btnTienToi"
        btnTienToi.Size = New Size(52, 34)
        btnTienToi.TabIndex = 22
        btnTienToi.Text = ">"
        btnTienToi.UseVisualStyleBackColor = True
        ' 
        ' btnVeDau
        ' 
        btnVeDau.Location = New Point(733, 656)
        btnVeDau.Name = "btnVeDau"
        btnVeDau.Size = New Size(52, 34)
        btnVeDau.TabIndex = 23
        btnVeDau.Text = "<<"
        btnVeDau.UseVisualStyleBackColor = True
        ' 
        ' btnToiCuoi
        ' 
        btnToiCuoi.Location = New Point(922, 657)
        btnToiCuoi.Name = "btnToiCuoi"
        btnToiCuoi.Size = New Size(52, 34)
        btnToiCuoi.TabIndex = 24
        btnToiCuoi.Text = ">>"
        btnToiCuoi.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(901, 165)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(112, 34)
        btnHuy.TabIndex = 31
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' CapNhatChiTietHoaDon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1070, 700)
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
        Controls.Add(txtSoLuong)
        Controls.Add(cboSoHoaDon)
        Controls.Add(txtMaHang)
        Controls.Add(txtMaCTHD)
        Controls.Add(dvg1)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Name = "CapNhatChiTietHoaDon"
        Text = "NguyenThanhNguyen_31"
        CType(dvg1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMaHang As TextBox
    Friend WithEvents txtMaCTHD As TextBox
    Friend WithEvents dvg1 As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cboSoHoaDon As ComboBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLuiLai As Button
    Friend WithEvents btnTienToi As Button
    Friend WithEvents btnVeDau As Button
    Friend WithEvents btnToiCuoi As Button
    Friend WithEvents btnHuy As Button
End Class
