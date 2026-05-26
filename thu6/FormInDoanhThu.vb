Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class FormInDoanhThu
    ' 1. Khai báo thuộc tính nhận bảng dữ liệu truyền từ Form Tìm Kiếm sang
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DuLieuIn As DataTable
    ' 2. Khai báo bộ hiển thị báo cáo ReportViewer
    Private WithEvents rvDoanhThu As ReportViewer
    Private Sub FormInDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 3. Khởi tạo và cấu hình hiển thị ReportViewer tràn màn hình Form
            rvDoanhThu = New ReportViewer()
            rvDoanhThu.Dock = DockStyle.Fill
            Me.Controls.Add(rvDoanhThu)
            ' 4. Chỉ định chính xác tệp thiết kế RDLC doanh thu bạn đã vẽ
            ' Cấu trúc: Tên_Dự_Án.Tên_File_Báo_Cáo.rdlc
            rvDoanhThu.LocalReport.ReportEmbeddedResource = "thu6.ReportDoanhThu.rdlc"
            ' 5. Làm sạch và nạp nguồn dữ liệu doanh thu vào khung máy chiếu
            rvDoanhThu.LocalReport.DataSources.Clear()
            ' Tên "DataSetDoanhThu" phải trùng khớp 100% với tên Dataset bạn chọn lúc vẽ file .rdlc
            Dim rds As New ReportDataSource("DataSetDoanhThu", DuLieuIn)
            rvDoanhThu.LocalReport.DataSources.Add(rds)
            ' 6. Kích hoạt vẽ và hiển thị báo cáo doanh thu lên màn hình
            rvDoanhThu.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Lỗi hiển thị báo cáo doanh thu: " & ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class