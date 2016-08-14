<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiaoTrinh_Parent
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
        Me.clstBaiHoc = New System.Windows.Forms.CheckedListBox()
        Me.btnTuVung = New System.Windows.Forms.Button()
        Me.btnNguPhap = New System.Windows.Forms.Button()
        Me.btnHoiThoai = New System.Windows.Forms.Button()
        Me.btnKiemTra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'clstBaiHoc
        '
        Me.clstBaiHoc.CheckOnClick = True
        Me.clstBaiHoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clstBaiHoc.FormattingEnabled = True
        Me.clstBaiHoc.Items.AddRange(New Object() {"Bài 1", "Bài 2", "Bài 3"})
        Me.clstBaiHoc.Location = New System.Drawing.Point(9, 57)
        Me.clstBaiHoc.Name = "clstBaiHoc"
        Me.clstBaiHoc.ScrollAlwaysVisible = True
        Me.clstBaiHoc.Size = New System.Drawing.Size(189, 400)
        Me.clstBaiHoc.TabIndex = 0
        '
        'btnTuVung
        '
        Me.btnTuVung.BackColor = System.Drawing.Color.Brown
        Me.btnTuVung.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuVung.ForeColor = System.Drawing.Color.White
        Me.btnTuVung.Location = New System.Drawing.Point(216, 9)
        Me.btnTuVung.Name = "btnTuVung"
        Me.btnTuVung.Size = New System.Drawing.Size(125, 40)
        Me.btnTuVung.TabIndex = 1
        Me.btnTuVung.Text = "Từ vựng"
        Me.btnTuVung.UseVisualStyleBackColor = False
        '
        'btnNguPhap
        '
        Me.btnNguPhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNguPhap.Location = New System.Drawing.Point(357, 9)
        Me.btnNguPhap.Name = "btnNguPhap"
        Me.btnNguPhap.Size = New System.Drawing.Size(125, 40)
        Me.btnNguPhap.TabIndex = 1
        Me.btnNguPhap.Text = "Ngữ Pháp"
        Me.btnNguPhap.UseVisualStyleBackColor = True
        '
        'btnHoiThoai
        '
        Me.btnHoiThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoiThoai.Location = New System.Drawing.Point(497, 9)
        Me.btnHoiThoai.Name = "btnHoiThoai"
        Me.btnHoiThoai.Size = New System.Drawing.Size(125, 40)
        Me.btnHoiThoai.TabIndex = 1
        Me.btnHoiThoai.Text = "Hội thoại"
        Me.btnHoiThoai.UseVisualStyleBackColor = True
        '
        'btnKiemTra
        '
        Me.btnKiemTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKiemTra.Location = New System.Drawing.Point(642, 9)
        Me.btnKiemTra.Name = "btnKiemTra"
        Me.btnKiemTra.Size = New System.Drawing.Size(125, 40)
        Me.btnKiemTra.TabIndex = 1
        Me.btnKiemTra.Text = "Kiểm tra"
        Me.btnKiemTra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BÀI HỌC"
        '
        'pnMain
        '
        Me.pnMain.Location = New System.Drawing.Point(217, 60)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(550, 400)
        Me.pnMain.TabIndex = 3
        '
        'GiaoTrinh_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 471)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKiemTra)
        Me.Controls.Add(Me.btnHoiThoai)
        Me.Controls.Add(Me.btnNguPhap)
        Me.Controls.Add(Me.btnTuVung)
        Me.Controls.Add(Me.clstBaiHoc)
        Me.Name = "GiaoTrinh_Parent"
        Me.Text = "Giáo trình Minano Nihongo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clstBaiHoc As CheckedListBox
    Friend WithEvents btnTuVung As Button
    Friend WithEvents btnNguPhap As Button
    Friend WithEvents btnHoiThoai As Button
    Friend WithEvents btnKiemTra As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnMain As Panel
End Class
