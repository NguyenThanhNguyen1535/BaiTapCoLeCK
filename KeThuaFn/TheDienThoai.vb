Public Class TheDienThoai
    ' 1. Khai báo các biến Private (Fields)
    Private _nhaMang As String
    Private _menhGia As Decimal

    ' 2. Khai báo các Property Public
    Public Property NhaMang As String
        Get
            Return _nhaMang
        End Get
        Set(value As String)
            _nhaMang = value
        End Set
    End Property

    Public Property MenhGia As Decimal
        Get
            Return _menhGia
        End Get
        Set(value As Decimal)
            ' Kiểm tra mệnh giá không được âm
            If value >= 0 Then
                _menhGia = value
            End If
        End Set
    End Property

    ' Constructor
    Sub New(nhaMang As String, menhGia As Decimal)
        Me._nhaMang = nhaMang
        Me._menhGia = menhGia
    End Sub
End Class