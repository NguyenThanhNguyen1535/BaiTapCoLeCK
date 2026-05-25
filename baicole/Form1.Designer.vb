<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        CậpNhậtToolStripMenuItem = New ToolStripMenuItem()
        HóaĐơnToolStripMenuItem = New ToolStripMenuItem()
        ChiTiếtHóaĐơnToolStripMenuItem = New ToolStripMenuItem()
        TìmKiếmToolStripMenuItem = New ToolStripMenuItem()
        HóaĐơnToolStripMenuItem1 = New ToolStripMenuItem()
        ChiTiếtHóaĐơnToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CậpNhậtToolStripMenuItem, TìmKiếmToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CậpNhậtToolStripMenuItem
        ' 
        CậpNhậtToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HóaĐơnToolStripMenuItem, ChiTiếtHóaĐơnToolStripMenuItem})
        CậpNhậtToolStripMenuItem.Name = "CậpNhậtToolStripMenuItem"
        CậpNhậtToolStripMenuItem.Size = New Size(99, 29)
        CậpNhậtToolStripMenuItem.Text = "Cập nhật"
        ' 
        ' HóaĐơnToolStripMenuItem
        ' 
        HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        HóaĐơnToolStripMenuItem.Size = New Size(270, 34)
        HóaĐơnToolStripMenuItem.Text = "Hóa đơn"
        ' 
        ' ChiTiếtHóaĐơnToolStripMenuItem
        ' 
        ChiTiếtHóaĐơnToolStripMenuItem.Name = "ChiTiếtHóaĐơnToolStripMenuItem"
        ChiTiếtHóaĐơnToolStripMenuItem.Size = New Size(270, 34)
        ChiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn"
        ' 
        ' TìmKiếmToolStripMenuItem
        ' 
        TìmKiếmToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HóaĐơnToolStripMenuItem1, ChiTiếtHóaĐơnToolStripMenuItem1})
        TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        TìmKiếmToolStripMenuItem.Size = New Size(100, 29)
        TìmKiếmToolStripMenuItem.Text = "Tìm kiếm"
        ' 
        ' HóaĐơnToolStripMenuItem1
        ' 
        HóaĐơnToolStripMenuItem1.Name = "HóaĐơnToolStripMenuItem1"
        HóaĐơnToolStripMenuItem1.Size = New Size(270, 34)
        HóaĐơnToolStripMenuItem1.Text = "Hóa đơn"
        ' 
        ' ChiTiếtHóaĐơnToolStripMenuItem1
        ' 
        ChiTiếtHóaĐơnToolStripMenuItem1.Name = "ChiTiếtHóaĐơnToolStripMenuItem1"
        ChiTiếtHóaĐơnToolStripMenuItem1.Size = New Size(270, 34)
        ChiTiếtHóaĐơnToolStripMenuItem1.Text = "Chi tiết hóa đơn"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CậpNhậtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem1 As ToolStripMenuItem

End Class
