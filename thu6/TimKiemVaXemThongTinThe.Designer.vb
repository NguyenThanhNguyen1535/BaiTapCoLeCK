<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiemVaXemThongTinThe
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
        Label3 = New Label()
        Label2 = New Label()
        btnXemTatCa = New Button()
        btnIn = New Button()
        dgvLoaiThe = New DataGridView()
        cboMenhGia = New ComboBox()
        cboNhaMang = New ComboBox()
        txtMaLoai = New TextBox()
        Label1 = New Label()
        cboTrangThai = New ComboBox()
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(220, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(810, 36)
        Label7.TabIndex = 85
        Label7.Text = "TÌM KIẾM/ XEM THÔNG TIN VÀ IN THÔNG TIN THẺ" & vbCrLf
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnThoat.Location = New Point(902, 224)
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
        Label4.Location = New Point(472, 175)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 26)
        Label4.TabIndex = 80
        Label4.Text = "Trạng thái" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(472, 237)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 26)
        Label3.TabIndex = 79
        Label3.Text = "Mệnh giá"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(51, 236)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 26)
        Label2.TabIndex = 78
        Label2.Text = "Nhà mạng"
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXemTatCa.Location = New Point(902, 162)
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
        btnIn.Location = New Point(491, 381)
        btnIn.Margin = New Padding(5, 3, 5, 3)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(156, 35)
        btnIn.TabIndex = 76
        btnIn.Text = "In kết quả"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' dgvLoaiThe
        ' 
        dgvLoaiThe.Anchor = AnchorStyles.Top
        dgvLoaiThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiThe.Location = New Point(-160, 422)
        dgvLoaiThe.Margin = New Padding(5, 3, 5, 3)
        dgvLoaiThe.Name = "dgvLoaiThe"
        dgvLoaiThe.ReadOnly = True
        dgvLoaiThe.RowHeadersWidth = 62
        dgvLoaiThe.Size = New Size(1577, 366)
        dgvLoaiThe.TabIndex = 75
        ' 
        ' cboMenhGia
        ' 
        cboMenhGia.Anchor = AnchorStyles.Top
        cboMenhGia.FormattingEnabled = True
        cboMenhGia.Location = New Point(601, 230)
        cboMenhGia.Margin = New Padding(5, 3, 5, 3)
        cboMenhGia.Name = "cboMenhGia"
        cboMenhGia.Size = New Size(208, 33)
        cboMenhGia.TabIndex = 72
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.Anchor = AnchorStyles.Top
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(183, 229)
        cboNhaMang.Margin = New Padding(5, 3, 5, 3)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(208, 33)
        cboNhaMang.TabIndex = 71
        ' 
        ' txtMaLoai
        ' 
        txtMaLoai.Anchor = AnchorStyles.Top
        txtMaLoai.Location = New Point(182, 170)
        txtMaLoai.Margin = New Padding(5, 3, 5, 3)
        txtMaLoai.Name = "txtMaLoai"
        txtMaLoai.Size = New Size(208, 31)
        txtMaLoai.TabIndex = 69
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(51, 175)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 26)
        Label1.TabIndex = 81
        Label1.Text = "Mã loại"
        ' 
        ' cboTrangThai
        ' 
        cboTrangThai.Anchor = AnchorStyles.Top
        cboTrangThai.FormattingEnabled = True
        cboTrangThai.Location = New Point(601, 168)
        cboTrangThai.Name = "cboTrangThai"
        cboTrangThai.Size = New Size(208, 33)
        cboTrangThai.TabIndex = 86
        ' 
        ' TimKiemVaXemThongTinThe
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 798)
        Controls.Add(cboTrangThai)
        Controls.Add(Label7)
        Controls.Add(btnThoat)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnXemTatCa)
        Controls.Add(btnIn)
        Controls.Add(dgvLoaiThe)
        Controls.Add(cboMenhGia)
        Controls.Add(cboNhaMang)
        Controls.Add(txtMaLoai)
        Name = "TimKiemVaXemThongTinThe"
        Text = "NguyenThanhNguyen_31_Nhom11"
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents dgvLoaiThe As DataGridView
    Friend WithEvents cboMenhGia As ComboBox
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTrangThai As ComboBox
End Class
