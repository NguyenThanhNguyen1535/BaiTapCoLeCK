<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiemChiTietHoaDon
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
        cboMaHang = New ComboBox()
        cboSoHoaDon = New ComboBox()
        cboMaCTHD = New ComboBox()
        btnXemHet = New Button()
        Label1 = New Label()
        dgv1 = New DataGridView()
        CType(dgv1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboMaHang
        ' 
        cboMaHang.FormattingEnabled = True
        cboMaHang.Location = New Point(349, 151)
        cboMaHang.Name = "cboMaHang"
        cboMaHang.Size = New Size(109, 33)
        cboMaHang.TabIndex = 14
        ' 
        ' cboSoHoaDon
        ' 
        cboSoHoaDon.FormattingEnabled = True
        cboSoHoaDon.Location = New Point(212, 151)
        cboSoHoaDon.Name = "cboSoHoaDon"
        cboSoHoaDon.Size = New Size(109, 33)
        cboSoHoaDon.TabIndex = 15
        ' 
        ' cboMaCTHD
        ' 
        cboMaCTHD.FormattingEnabled = True
        cboMaCTHD.Location = New Point(73, 151)
        cboMaCTHD.Name = "cboMaCTHD"
        cboMaCTHD.Size = New Size(103, 33)
        cboMaCTHD.TabIndex = 16
        ' 
        ' btnXemHet
        ' 
        btnXemHet.Location = New Point(511, 151)
        btnXemHet.Name = "btnXemHet"
        btnXemHet.Size = New Size(112, 34)
        btnXemHet.TabIndex = 13
        btnXemHet.Text = "Xem hết"
        btnXemHet.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(240, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(369, 36)
        Label1.TabIndex = 12
        Label1.Text = "Tìm kiếm chi tiết hóa đơn"
        ' 
        ' dgv1
        ' 
        dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv1.Location = New Point(-20, 229)
        dgv1.Name = "dgv1"
        dgv1.RowHeadersWidth = 62
        dgv1.Size = New Size(841, 225)
        dgv1.TabIndex = 11
        ' 
        ' TimKiemChiTietHoaDon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboMaHang)
        Controls.Add(cboSoHoaDon)
        Controls.Add(cboMaCTHD)
        Controls.Add(btnXemHet)
        Controls.Add(Label1)
        Controls.Add(dgv1)
        Name = "TimKiemChiTietHoaDon"
        Text = "NguyenThanhNguyen_31"
        CType(dgv1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboMaHang As ComboBox
    Friend WithEvents cboSoHoaDon As ComboBox
    Friend WithEvents cboMaCTHD As ComboBox
    Friend WithEvents btnXemHet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv1 As DataGridView
End Class
