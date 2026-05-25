<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiemHoaDon
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
        cboMaNhanVien = New ComboBox()
        cboMaKhachHang = New ComboBox()
        cboSoHoaDon = New ComboBox()
        btnXemHet = New Button()
        Label1 = New Label()
        dgv1 = New DataGridView()
        CType(dgv1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboMaNhanVien
        ' 
        cboMaNhanVien.FormattingEnabled = True
        cboMaNhanVien.Location = New Point(411, 163)
        cboMaNhanVien.Name = "cboMaNhanVien"
        cboMaNhanVien.Size = New Size(109, 33)
        cboMaNhanVien.TabIndex = 8
        ' 
        ' cboMaKhachHang
        ' 
        cboMaKhachHang.FormattingEnabled = True
        cboMaKhachHang.Location = New Point(274, 163)
        cboMaKhachHang.Name = "cboMaKhachHang"
        cboMaKhachHang.Size = New Size(109, 33)
        cboMaKhachHang.TabIndex = 9
        ' 
        ' cboSoHoaDon
        ' 
        cboSoHoaDon.FormattingEnabled = True
        cboSoHoaDon.Location = New Point(135, 163)
        cboSoHoaDon.Name = "cboSoHoaDon"
        cboSoHoaDon.Size = New Size(103, 33)
        cboSoHoaDon.TabIndex = 10
        ' 
        ' btnXemHet
        ' 
        btnXemHet.Location = New Point(573, 163)
        btnXemHet.Name = "btnXemHet"
        btnXemHet.Size = New Size(112, 34)
        btnXemHet.TabIndex = 7
        btnXemHet.Text = "Xem hết"
        btnXemHet.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(392, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 36)
        Label1.TabIndex = 6
        Label1.Text = "Tìm kiếm hóa đơn"
        ' 
        ' dgv1
        ' 
        dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv1.Location = New Point(42, 241)
        dgv1.Name = "dgv1"
        dgv1.RowHeadersWidth = 62
        dgv1.Size = New Size(841, 225)
        dgv1.TabIndex = 5
        ' 
        ' TimKiemHoaDon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 536)
        Controls.Add(cboMaNhanVien)
        Controls.Add(cboMaKhachHang)
        Controls.Add(cboSoHoaDon)
        Controls.Add(btnXemHet)
        Controls.Add(Label1)
        Controls.Add(dgv1)
        Name = "TimKiemHoaDon"
        Text = "NguyenThanhNguyen_31"
        CType(dgv1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboMaNhanVien As ComboBox
    Friend WithEvents cboMaKhachHang As ComboBox
    Friend WithEvents cboSoHoaDon As ComboBox
    Friend WithEvents btnXemHet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv1 As DataGridView
End Class
