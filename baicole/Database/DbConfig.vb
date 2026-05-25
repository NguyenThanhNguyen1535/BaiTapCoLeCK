Imports System.IO

Namespace Database
    Public Class DbConfig
        Public Shared ReadOnly Property ConnectionString As String
            Get
                Return "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyBanHang2.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True"
            End Get
        End Property
    End Class
End Namespace
