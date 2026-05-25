<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtTenKhachHang = New TextBox()
        cboKhachHang = New ComboBox()
        cboNhanVien = New ComboBox()
        GroupBox1 = New GroupBox()
        radNapTien = New RadioButton()
        radMuaThe = New RadioButton()
        GroupBox2 = New GroupBox()
        lblNhaMang = New Label()
        cboNhaMang = New ComboBox()
        lblSoTien = New Label()
        txtSoTien = New TextBox()
        txtTiLe = New TextBox()
        Label3 = New Label()
        txtSoLuong = New TextBox()
        lblKM_CK = New Label()
        btnThanhToan = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtSDTKhach = New TextBox()
        lvLichSu = New ListView()
        colMaGD = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtTenKhachHang
        ' 
        txtTenKhachHang.Location = New Point(198, 81)
        txtTenKhachHang.Name = "txtTenKhachHang"
        txtTenKhachHang.Size = New Size(182, 31)
        txtTenKhachHang.TabIndex = 0
        ' 
        ' cboKhachHang
        ' 
        cboKhachHang.FormattingEnabled = True
        cboKhachHang.Location = New Point(198, 28)
        cboKhachHang.Name = "cboKhachHang"
        cboKhachHang.Size = New Size(182, 33)
        cboKhachHang.TabIndex = 1
        ' 
        ' cboNhanVien
        ' 
        cboNhanVien.FormattingEnabled = True
        cboNhanVien.Location = New Point(198, 168)
        cboNhanVien.Name = "cboNhanVien"
        cboNhanVien.Size = New Size(182, 33)
        cboNhanVien.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radNapTien)
        GroupBox1.Controls.Add(radMuaThe)
        GroupBox1.Location = New Point(515, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Chọn loại giao dịch"
        ' 
        ' radNapTien
        ' 
        radNapTien.AutoSize = True
        radNapTien.Location = New Point(36, 46)
        radNapTien.Name = "radNapTien"
        radNapTien.Size = New Size(187, 29)
        radNapTien.TabIndex = 4
        radNapTien.TabStop = True
        radNapTien.Text = "Mua thẻ trực tuyến"
        radNapTien.UseVisualStyleBackColor = True
        ' 
        ' radMuaThe
        ' 
        radMuaThe.AutoSize = True
        radMuaThe.Location = New Point(36, 92)
        radMuaThe.Name = "radMuaThe"
        radMuaThe.Size = New Size(165, 29)
        radMuaThe.TabIndex = 5
        radMuaThe.TabStop = True
        radMuaThe.Text = "Mua mã thẻ cào"
        radMuaThe.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblNhaMang)
        GroupBox2.Controls.Add(cboNhaMang)
        GroupBox2.Controls.Add(lblSoTien)
        GroupBox2.Controls.Add(txtSoTien)
        GroupBox2.Controls.Add(txtTiLe)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtSoLuong)
        GroupBox2.Controls.Add(lblKM_CK)
        GroupBox2.Location = New Point(30, 239)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(417, 303)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Chi tiết"
        ' 
        ' lblNhaMang
        ' 
        lblNhaMang.AutoSize = True
        lblNhaMang.Location = New Point(19, 43)
        lblNhaMang.Name = "lblNhaMang"
        lblNhaMang.Size = New Size(95, 25)
        lblNhaMang.TabIndex = 10
        lblNhaMang.Text = "Nhà mạng"
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.DropDownStyle = ComboBoxStyle.DropDownList
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(229, 35)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(148, 33)
        cboNhaMang.TabIndex = 9
        ' 
        ' lblSoTien
        ' 
        lblSoTien.AutoSize = True
        lblSoTien.Location = New Point(19, 95)
        lblSoTien.Name = "lblSoTien"
        lblSoTien.Size = New Size(102, 25)
        lblSoTien.TabIndex = 6
        lblSoTien.Text = "Số tiền nạp"
        ' 
        ' txtSoTien
        ' 
        txtSoTien.Location = New Point(227, 89)
        txtSoTien.Name = "txtSoTien"
        txtSoTien.Size = New Size(150, 31)
        txtSoTien.TabIndex = 0
        ' 
        ' txtTiLe
        ' 
        txtTiLe.Location = New Point(227, 153)
        txtTiLe.Name = "txtTiLe"
        txtTiLe.Size = New Size(150, 31)
        txtTiLe.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 8
        Label3.Text = "Số lượng"
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(227, 223)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(150, 31)
        txtSoLuong.TabIndex = 0
        txtSoLuong.TabStop = False
        ' 
        ' lblKM_CK
        ' 
        lblKM_CK.AutoSize = True
        lblKM_CK.Location = New Point(19, 159)
        lblKM_CK.Name = "lblKM_CK"
        lblKM_CK.Size = New Size(189, 25)
        lblKM_CK.TabIndex = 7
        lblKM_CK.Text = "Phần trăm khuyến mãi"
        ' 
        ' btnThanhToan
        ' 
        btnThanhToan.Location = New Point(158, 588)
        btnThanhToan.Name = "btnThanhToan"
        btnThanhToan.Size = New Size(112, 34)
        btnThanhToan.TabIndex = 9
        btnThanhToan.Text = "Thanh toán"
        btnThanhToan.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 6
        Label4.Text = "Khách hàng"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 25)
        Label5.TabIndex = 6
        Label5.Text = "Nhân viên"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 25)
        Label6.TabIndex = 6
        Label6.Text = "Mã khách hàng"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 25)
        Label7.TabIndex = 6
        Label7.Text = "Số điện thoại"
        ' 
        ' txtSDTKhach
        ' 
        txtSDTKhach.Location = New Point(198, 118)
        txtSDTKhach.Name = "txtSDTKhach"
        txtSDTKhach.ReadOnly = True
        txtSDTKhach.Size = New Size(182, 31)
        txtSDTKhach.TabIndex = 11
        ' 
        ' lvLichSu
        ' 
        lvLichSu.Columns.AddRange(New ColumnHeader() {colMaGD, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        lvLichSu.FullRowSelect = True
        lvLichSu.Location = New Point(515, 220)
        lvLichSu.Name = "lvLichSu"
        lvLichSu.Size = New Size(1017, 322)
        lvLichSu.TabIndex = 12
        lvLichSu.UseCompatibleStateImageBehavior = False
        lvLichSu.View = View.Details
        ' 
        ' colMaGD
        ' 
        colMaGD.Text = "Mã GD"
        colMaGD.Width = 150
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Thời gian"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Loại & Nhà mạng"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Tên Khách hàng"
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Số điện thoại"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Mã NV"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Tổng trả"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Width = 150
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1593, 690)
        Controls.Add(lvLichSu)
        Controls.Add(txtSDTKhach)
        Controls.Add(btnThanhToan)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(cboNhanVien)
        Controls.Add(cboKhachHang)
        Controls.Add(txtTenKhachHang)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents cboKhachHang As ComboBox
    Friend WithEvents cboNhanVien As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNapTien As RadioButton
    Friend WithEvents radMuaThe As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSoTien As Label
    Friend WithEvents lblKM_CK As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSoTien As TextBox
    Friend WithEvents txtTiLe As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSDTKhach As TextBox
    Friend WithEvents lblNhaMang As Label
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents lvLichSu As ListView
    Friend WithEvents colMaGD As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader

End Class
