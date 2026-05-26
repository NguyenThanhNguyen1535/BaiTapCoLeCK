Imports Microsoft.Reporting.WinForms
Imports System.Data
Public Class FormInThongTinLoaiThe
    ' 1. Khai báo thuộc tính nhận bảng dữ liệu loại thẻ từ Form chính truyền sang
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DuLieuInLoaiThe As DataTable

    ' 2. Khai báo bộ hiển thị báo cáo ReportViewer bằng code
    Private WithEvents rvLoaiThe As ReportViewer
    Private Sub FormInThongTinLoaiThe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rvLoaiThe = New ReportViewer()
            rvLoaiThe.Dock = DockStyle.Fill
            Me.Controls.Add(rvLoaiThe)
            rvLoaiThe.LocalReport.ReportEmbeddedResource = "thu6.ReportLoaiThe.rdlc"
            rvLoaiThe.LocalReport.DataSources.Clear()
            Dim rds As New ReportDataSource("DataSetLoaiThe", DuLieuInLoaiThe)
            rvLoaiThe.LocalReport.DataSources.Add(rds)
            rvLoaiThe.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Lỗi hiển thị báo cáo loại thẻ: " & ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class