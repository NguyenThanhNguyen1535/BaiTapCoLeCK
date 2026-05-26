Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class FormInThongTinKhachHang

    ' 1. Khai báo thuộc tính nhận bảng dữ liệu khách hàng truyền từ Form Tìm Kiếm sang
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DuLieuInKhachHang As DataTable

    ' 2. Khai báo bộ hiển thị báo cáo ReportViewer bằng code kèm sự kiện (WithEvents)
    Private WithEvents rvKhachHang As ReportViewer

    Private Sub FormInThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rvKhachHang = New ReportViewer()
            rvKhachHang.Dock = DockStyle.Fill
            Me.Controls.Add(rvKhachHang)
            rvKhachHang.LocalReport.ReportEmbeddedResource = "thu6.ReportKhachHang.rdlc"
            rvKhachHang.LocalReport.DataSources.Clear()
            Dim rds As New ReportDataSource("DataSetKhachHang", DuLieuInKhachHang)
            rvKhachHang.LocalReport.DataSources.Add(rds)
            rvKhachHang.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Lỗi hiển thị báo cáo khách hàng: " & ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class