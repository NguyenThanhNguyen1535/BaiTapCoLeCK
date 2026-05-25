Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class DatabaseConnection
    'Private Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & AppDomain.CurrentDomain.BaseDirectory & "Quanlitiendienthoai3.mdf;Integrated Security=True"


    Private Shared connectionString As String = "Data Source=localhost;Initial Catalog=Quanlitiendienthoai3;Integrated Security=True;TrustServerCertificate=True"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Public Shared Function GetData(query As String, Optional parameters As SqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Using adapter As New SqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Lỗi truy vấn dữ liệu: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function ExecuteQuery(query As String, Optional parameters As SqlParameter() = Nothing) As Integer
        Dim rowsAffected As Integer = 0
        Using conn As SqlConnection = GetConnection()
            conn.Open()
            Using transaction As SqlTransaction = conn.BeginTransaction()
                Using cmd As New SqlCommand(query, conn, transaction)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    Try
                        rowsAffected = cmd.ExecuteNonQuery()
                        transaction.Commit()
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw New Exception("Lỗi thực thi dữ liệu: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return rowsAffected
    End Function
End Class
