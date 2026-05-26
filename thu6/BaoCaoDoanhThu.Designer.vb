<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoDoanhThu
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
        dgvGiaoDich = New DataGridView()
        dtpTuNgay = New DateTimePicker()
        dtpDenNgay = New DateTimePicker()
        cboNhaMang = New ComboBox()
        btnLoc = New Button()
        btnIn = New Button()
        btnXemTatCa = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblDoanhThu = New Label()
        btnThoat = New Button()
        Label5 = New Label()
        CType(dgvGiaoDich, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGiaoDich
        ' 
        dgvGiaoDich.Anchor = AnchorStyles.Top
        dgvGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGiaoDich.Location = New Point(58, 533)
        dgvGiaoDich.Name = "dgvGiaoDich"
        dgvGiaoDich.ReadOnly = True
        dgvGiaoDich.RowHeadersWidth = 62
        dgvGiaoDich.Size = New Size(1074, 225)
        dgvGiaoDich.TabIndex = 0
        ' 
        ' dtpTuNgay
        ' 
        dtpTuNgay.Anchor = AnchorStyles.Top
        dtpTuNgay.Location = New Point(300, 159)
        dtpTuNgay.Name = "dtpTuNgay"
        dtpTuNgay.Size = New Size(300, 31)
        dtpTuNgay.TabIndex = 1
        ' 
        ' dtpDenNgay
        ' 
        dtpDenNgay.Anchor = AnchorStyles.Top
        dtpDenNgay.Location = New Point(300, 233)
        dtpDenNgay.Name = "dtpDenNgay"
        dtpDenNgay.Size = New Size(300, 31)
        dtpDenNgay.TabIndex = 2
        ' 
        ' cboNhaMang
        ' 
        cboNhaMang.Anchor = AnchorStyles.Top
        cboNhaMang.FormattingEnabled = True
        cboNhaMang.Location = New Point(300, 297)
        cboNhaMang.Name = "cboNhaMang"
        cboNhaMang.Size = New Size(182, 33)
        cboNhaMang.TabIndex = 3
        ' 
        ' btnLoc
        ' 
        btnLoc.Anchor = AnchorStyles.Top
        btnLoc.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnLoc.Location = New Point(721, 156)
        btnLoc.Name = "btnLoc"
        btnLoc.Size = New Size(149, 34)
        btnLoc.TabIndex = 4
        btnLoc.Text = "Lọc"
        btnLoc.UseVisualStyleBackColor = True
        ' 
        ' btnIn
        ' 
        btnIn.Anchor = AnchorStyles.Top
        btnIn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnIn.Location = New Point(721, 230)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(149, 34)
        btnIn.TabIndex = 5
        btnIn.Text = "In báo cáo"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' btnXemTatCa
        ' 
        btnXemTatCa.Anchor = AnchorStyles.Top
        btnXemTatCa.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnXemTatCa.Location = New Point(904, 156)
        btnXemTatCa.Name = "btnXemTatCa"
        btnXemTatCa.Size = New Size(149, 34)
        btnXemTatCa.TabIndex = 6
        btnXemTatCa.Text = "Xem tất cả"
        btnXemTatCa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(173, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 26)
        Label1.TabIndex = 7
        Label1.Text = "Từ ngày"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(173, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 26)
        Label2.TabIndex = 7
        Label2.Text = "Đến ngày"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(173, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 26)
        Label3.TabIndex = 7
        Label3.Text = "Nhà mạng"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(490, 480)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 26)
        Label4.TabIndex = 8
        Label4.Text = "Tổng doanh thu:"
        ' 
        ' lblDoanhThu
        ' 
        lblDoanhThu.Anchor = AnchorStyles.Top
        lblDoanhThu.AutoSize = True
        lblDoanhThu.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        lblDoanhThu.Location = New Point(686, 480)
        lblDoanhThu.Name = "lblDoanhThu"
        lblDoanhThu.Size = New Size(96, 26)
        lblDoanhThu.TabIndex = 9
        lblDoanhThu.Text = ".............."
        ' 
        ' btnThoat
        ' 
        btnThoat.Anchor = AnchorStyles.Top
        btnThoat.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnThoat.Location = New Point(721, 297)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(149, 34)
        btnThoat.TabIndex = 10
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(408, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(462, 36)
        Label5.TabIndex = 11
        Label5.Text = "BÁO CÁO VÀ IN DOANH THU"
        ' 
        ' BaoCaoDoanhThu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.anhmain2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1171, 788)
        Controls.Add(Label5)
        Controls.Add(btnThoat)
        Controls.Add(lblDoanhThu)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnXemTatCa)
        Controls.Add(btnIn)
        Controls.Add(btnLoc)
        Controls.Add(cboNhaMang)
        Controls.Add(dtpDenNgay)
        Controls.Add(dtpTuNgay)
        Controls.Add(dgvGiaoDich)
        Name = "BaoCaoDoanhThu"
        Text = "NguyenThanhNguyen_31_Nhom11"
        CType(dgvGiaoDich, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvGiaoDich As DataGridView
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents cboNhaMang As ComboBox
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents btnXemTatCa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDoanhThu As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label5 As Label
End Class
