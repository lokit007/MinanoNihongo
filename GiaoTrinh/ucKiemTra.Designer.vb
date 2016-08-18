<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucKiemTra
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucKiemTra))
        Me.btnTraLoi1 = New System.Windows.Forms.Button()
        Me.btnTraLoi3 = New System.Windows.Forms.Button()
        Me.btnTraLoi2 = New System.Windows.Forms.Button()
        Me.btnTraLoi4 = New System.Windows.Forms.Button()
        Me.lbCauHoi = New System.Windows.Forms.Label()
        Me.audioCauHoi = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBoQua = New System.Windows.Forms.Button()
        Me.lbSoCauDung = New System.Windows.Forms.Label()
        Me.lbTongCau = New System.Windows.Forms.Label()
        Me.lbThoiGian = New System.Windows.Forms.Label()
        Me.cbShowThoiGian = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.audioCauHoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTraLoi1
        '
        Me.btnTraLoi1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLoi1.Location = New System.Drawing.Point(8, 220)
        Me.btnTraLoi1.Name = "btnTraLoi1"
        Me.btnTraLoi1.Size = New System.Drawing.Size(261, 85)
        Me.btnTraLoi1.TabIndex = 1
        Me.btnTraLoi1.Text = "Phấn đấu"
        Me.btnTraLoi1.UseVisualStyleBackColor = True
        '
        'btnTraLoi3
        '
        Me.btnTraLoi3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLoi3.Location = New System.Drawing.Point(10, 311)
        Me.btnTraLoi3.Name = "btnTraLoi3"
        Me.btnTraLoi3.Size = New System.Drawing.Size(259, 85)
        Me.btnTraLoi3.TabIndex = 1
        Me.btnTraLoi3.Text = "Thật Cao"
        Me.btnTraLoi3.UseVisualStyleBackColor = True
        '
        'btnTraLoi2
        '
        Me.btnTraLoi2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLoi2.Location = New System.Drawing.Point(279, 220)
        Me.btnTraLoi2.Name = "btnTraLoi2"
        Me.btnTraLoi2.Size = New System.Drawing.Size(261, 85)
        Me.btnTraLoi2.TabIndex = 1
        Me.btnTraLoi2.Text = "Kết quả"
        Me.btnTraLoi2.UseVisualStyleBackColor = True
        '
        'btnTraLoi4
        '
        Me.btnTraLoi4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLoi4.Location = New System.Drawing.Point(279, 311)
        Me.btnTraLoi4.Name = "btnTraLoi4"
        Me.btnTraLoi4.Size = New System.Drawing.Size(261, 85)
        Me.btnTraLoi4.TabIndex = 1
        Me.btnTraLoi4.Text = "Nhé <3 <3"
        Me.btnTraLoi4.UseVisualStyleBackColor = True
        '
        'lbCauHoi
        '
        Me.lbCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCauHoi.Font = New System.Drawing.Font("Times New Roman", 17.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCauHoi.Location = New System.Drawing.Point(10, 72)
        Me.lbCauHoi.Name = "lbCauHoi"
        Me.lbCauHoi.Size = New System.Drawing.Size(530, 99)
        Me.lbCauHoi.TabIndex = 2
        Me.lbCauHoi.Text = "Click để bắt đầu kiểm tra nào :D :D"
        Me.lbCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'audioCauHoi
        '
        Me.audioCauHoi.Enabled = True
        Me.audioCauHoi.Location = New System.Drawing.Point(10, 179)
        Me.audioCauHoi.Name = "audioCauHoi"
        Me.audioCauHoi.OcxState = CType(resources.GetObject("audioCauHoi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.audioCauHoi.Size = New System.Drawing.Size(417, 33)
        Me.audioCauHoi.TabIndex = 3
        Me.audioCauHoi.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbShowThoiGian)
        Me.GroupBox1.Controls.Add(Me.lbThoiGian)
        Me.GroupBox1.Controls.Add(Me.lbTongCau)
        Me.GroupBox1.Controls.Add(Me.lbSoCauDung)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thống kê"
        Me.GroupBox1.Visible = False
        '
        'btnBoQua
        '
        Me.btnBoQua.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoQua.Location = New System.Drawing.Point(433, 179)
        Me.btnBoQua.Name = "btnBoQua"
        Me.btnBoQua.Size = New System.Drawing.Size(106, 33)
        Me.btnBoQua.TabIndex = 5
        Me.btnBoQua.Text = "BỎ QUA"
        Me.btnBoQua.UseVisualStyleBackColor = True
        Me.btnBoQua.Visible = False
        '
        'lbSoCauDung
        '
        Me.lbSoCauDung.AutoSize = True
        Me.lbSoCauDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSoCauDung.Location = New System.Drawing.Point(41, 19)
        Me.lbSoCauDung.Name = "lbSoCauDung"
        Me.lbSoCauDung.Size = New System.Drawing.Size(135, 13)
        Me.lbSoCauDung.TabIndex = 0
        Me.lbSoCauDung.Text = "Số câu trả lời đúng : 0"
        '
        'lbTongCau
        '
        Me.lbTongCau.AutoSize = True
        Me.lbTongCau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTongCau.Location = New System.Drawing.Point(41, 42)
        Me.lbTongCau.Name = "lbTongCau"
        Me.lbTongCau.Size = New System.Drawing.Size(161, 13)
        Me.lbTongCau.TabIndex = 0
        Me.lbTongCau.Text = "Tổng sô câu cần học : 100"
        '
        'lbThoiGian
        '
        Me.lbThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbThoiGian.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThoiGian.Location = New System.Drawing.Point(289, 19)
        Me.lbThoiGian.Name = "lbThoiGian"
        Me.lbThoiGian.Size = New System.Drawing.Size(221, 36)
        Me.lbThoiGian.TabIndex = 1
        Me.lbThoiGian.Text = "01:00"
        Me.lbThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbShowThoiGian
        '
        Me.cbShowThoiGian.Checked = True
        Me.cbShowThoiGian.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowThoiGian.Location = New System.Drawing.Point(263, 21)
        Me.cbShowThoiGian.Name = "cbShowThoiGian"
        Me.cbShowThoiGian.Size = New System.Drawing.Size(24, 34)
        Me.cbShowThoiGian.TabIndex = 2
        Me.cbShowThoiGian.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ucKiemTra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBoQua)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.audioCauHoi)
        Me.Controls.Add(Me.lbCauHoi)
        Me.Controls.Add(Me.btnTraLoi4)
        Me.Controls.Add(Me.btnTraLoi3)
        Me.Controls.Add(Me.btnTraLoi2)
        Me.Controls.Add(Me.btnTraLoi1)
        Me.Name = "ucKiemTra"
        Me.Size = New System.Drawing.Size(550, 400)
        CType(Me.audioCauHoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTraLoi1 As Button
    Friend WithEvents btnTraLoi3 As Button
    Friend WithEvents btnTraLoi2 As Button
    Friend WithEvents btnTraLoi4 As Button
    Friend WithEvents lbCauHoi As Label
    Friend WithEvents audioCauHoi As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBoQua As Button
    Friend WithEvents cbShowThoiGian As CheckBox
    Friend WithEvents lbThoiGian As Label
    Friend WithEvents lbTongCau As Label
    Friend WithEvents lbSoCauDung As Label
    Friend WithEvents Timer1 As Timer
End Class
