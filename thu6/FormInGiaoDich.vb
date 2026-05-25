Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class FormInGiaoDich

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DuLieuIn As DataTable

    Private WithEvents rvGiaoDich As ReportViewer

    Private Sub FormInGiaoDich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Khởi tạo giao diện hiển thị ReportViewer
            rvGiaoDich = New ReportViewer()
            rvGiaoDich.Dock = DockStyle.Fill
            Me.Controls.Add(rvGiaoDich)

            ' 2. Khai báo chính xác đường dẫn tệp đã nhúng vào hệ thống dự án thu6
            rvGiaoDich.LocalReport.ReportEmbeddedResource = "thu6.ReportGiaoDich.rdlc"

            ' 3. Đổ dữ liệu đã lọc sang cấu trúc Dataset của báo cáo
            rvGiaoDich.LocalReport.DataSources.Clear()
            Dim rds As New ReportDataSource("DataSetGiaoDich", DuLieuIn)
            rvGiaoDich.LocalReport.DataSources.Add(rds)

            ' 4. Kích hoạt vẽ và hiển thị dữ liệu lên màn hình
            rvGiaoDich.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Lỗi xử lý kết xuất báo cáo: " & ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class