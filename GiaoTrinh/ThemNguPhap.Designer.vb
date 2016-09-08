<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemNguPhap
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemNguPhap))
        Me.cbBaiHoc = New System.Windows.Forms.ComboBox()
        Me.rtbCauTruc = New System.Windows.Forms.RichTextBox()
        Me.rtbNguNghia = New System.Windows.Forms.RichTextBox()
        Me.rtbCachDung = New System.Windows.Forms.RichTextBox()
        Me.lbViDu = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbViDu = New System.Windows.Forms.TextBox()
        Me.tbNguNghia = New System.Windows.Forms.TextBox()
        Me.btnThemViDu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLamTrong = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Label()
        Me.tbAmDoc = New System.Windows.Forms.TextBox()
        Me.btnNgheLai = New System.Windows.Forms.Button()
        Me.btnLuuDung = New System.Windows.Forms.Button()
        Me.btnGhiAm = New System.Windows.Forms.Button()
        Me.btnThemNguPhap = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbBaiHoc
        '
        Me.cbBaiHoc.FormattingEnabled = True
        Me.cbBaiHoc.Location = New System.Drawing.Point(17, 22)
        Me.cbBaiHoc.Name = "cbBaiHoc"
        Me.cbBaiHoc.Size = New System.Drawing.Size(413, 23)
        Me.cbBaiHoc.TabIndex = 0
        Me.cbBaiHoc.Text = "----- Thêm vào bài học -----"
        Me.ToolTip1.SetToolTip(Me.cbBaiHoc, "Chọn bài học cần thêm")
        '
        'rtbCauTruc
        '
        Me.rtbCauTruc.Font = New System.Drawing.Font("Times New Roman", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCauTruc.Location = New System.Drawing.Point(17, 63)
        Me.rtbCauTruc.Name = "rtbCauTruc"
        Me.rtbCauTruc.Size = New System.Drawing.Size(413, 110)
        Me.rtbCauTruc.TabIndex = 1
        Me.rtbCauTruc.Text = "Cấu trúc ..."
        Me.ToolTip1.SetToolTip(Me.rtbCauTruc, "Cấu trúc ngữ pháp")
        '
        'rtbNguNghia
        '
        Me.rtbNguNghia.Location = New System.Drawing.Point(17, 181)
        Me.rtbNguNghia.Name = "rtbNguNghia"
        Me.rtbNguNghia.Size = New System.Drawing.Size(413, 105)
        Me.rtbNguNghia.TabIndex = 1
        Me.rtbNguNghia.Text = "Ngữ nghĩa ..."
        Me.ToolTip1.SetToolTip(Me.rtbNguNghia, "Ngữ nghĩa")
        '
        'rtbCachDung
        '
        Me.rtbCachDung.Location = New System.Drawing.Point(14, 299)
        Me.rtbCachDung.Name = "rtbCachDung"
        Me.rtbCachDung.Size = New System.Drawing.Size(413, 192)
        Me.rtbCachDung.TabIndex = 1
        Me.rtbCachDung.Text = "Cách dùng ..."
        Me.ToolTip1.SetToolTip(Me.rtbCachDung, "Trường hợp sử dụng")
        '
        'lbViDu
        '
        Me.lbViDu.Font = New System.Drawing.Font("Times New Roman", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbViDu.FormattingEnabled = True
        Me.lbViDu.ItemHeight = 20
        Me.lbViDu.Location = New System.Drawing.Point(458, 22)
        Me.lbViDu.Name = "lbViDu"
        Me.lbViDu.ScrollAlwaysVisible = True
        Me.lbViDu.Size = New System.Drawing.Size(397, 264)
        Me.lbViDu.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lbViDu, "Ví dụ minh họa")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOpenFile)
        Me.GroupBox1.Controls.Add(Me.tbAmDoc)
        Me.GroupBox1.Controls.Add(Me.btnNgheLai)
        Me.GroupBox1.Controls.Add(Me.btnLuuDung)
        Me.GroupBox1.Controls.Add(Me.btnGhiAm)
        Me.GroupBox1.Controls.Add(Me.btnLamTrong)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnThemViDu)
        Me.GroupBox1.Controls.Add(Me.tbNguNghia)
        Me.GroupBox1.Controls.Add(Me.tbViDu)
        Me.GroupBox1.Location = New System.Drawing.Point(457, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 233)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ví dụ minh họa"
        '
        'tbViDu
        '
        Me.tbViDu.Font = New System.Drawing.Font("Times New Roman", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbViDu.Location = New System.Drawing.Point(10, 22)
        Me.tbViDu.Multiline = True
        Me.tbViDu.Name = "tbViDu"
        Me.tbViDu.Size = New System.Drawing.Size(376, 51)
        Me.tbViDu.TabIndex = 0
        Me.tbViDu.Text = "Ví dụ ..."
        Me.ToolTip1.SetToolTip(Me.tbViDu, "Nhập ví dụ minh họa")
        '
        'tbNguNghia
        '
        Me.tbNguNghia.Location = New System.Drawing.Point(10, 112)
        Me.tbNguNghia.Multiline = True
        Me.tbNguNghia.Name = "tbNguNghia"
        Me.tbNguNghia.Size = New System.Drawing.Size(376, 80)
        Me.tbNguNghia.TabIndex = 0
        Me.tbNguNghia.Text = "Ngữ nghĩa ví dụ ..."
        Me.ToolTip1.SetToolTip(Me.tbNguNghia, "Ngữ nghĩa của ví dụ")
        '
        'btnThemViDu
        '
        Me.btnThemViDu.Location = New System.Drawing.Point(299, 198)
        Me.btnThemViDu.Name = "btnThemViDu"
        Me.btnThemViDu.Size = New System.Drawing.Size(87, 27)
        Me.btnThemViDu.TabIndex = 1
        Me.btnThemViDu.Text = "Thêm mới"
        Me.ToolTip1.SetToolTip(Me.btnThemViDu, "Thêm ví dụ mới")
        Me.btnThemViDu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(204, 198)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(87, 27)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa VD"
        Me.ToolTip1.SetToolTip(Me.btnXoa, "Xóa ví dụ được chọn")
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLamTrong
        '
        Me.btnLamTrong.Location = New System.Drawing.Point(111, 198)
        Me.btnLamTrong.Name = "btnLamTrong"
        Me.btnLamTrong.Size = New System.Drawing.Size(87, 27)
        Me.btnLamTrong.TabIndex = 1
        Me.btnLamTrong.Text = "Làm trống"
        Me.ToolTip1.SetToolTip(Me.btnLamTrong, "Làm trống các trường dữ liệu")
        Me.btnLamTrong.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Image)
        Me.btnOpenFile.Location = New System.Drawing.Point(258, 82)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(19, 18)
        Me.btnOpenFile.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnOpenFile, "Mở file âm thanh đọc ví dụ")
        '
        'tbAmDoc
        '
        Me.tbAmDoc.Location = New System.Drawing.Point(10, 81)
        Me.tbAmDoc.Name = "tbAmDoc"
        Me.tbAmDoc.ReadOnly = True
        Me.tbAmDoc.Size = New System.Drawing.Size(271, 22)
        Me.tbAmDoc.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.tbAmDoc, "File âm thanh đọc ví dụ")
        '
        'btnNgheLai
        '
        Me.btnNgheLai.Image = CType(resources.GetObject("btnNgheLai.Image"), System.Drawing.Image)
        Me.btnNgheLai.Location = New System.Drawing.Point(358, 78)
        Me.btnNgheLai.Name = "btnNgheLai"
        Me.btnNgheLai.Size = New System.Drawing.Size(29, 28)
        Me.btnNgheLai.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnNgheLai, "Nghe lại")
        Me.btnNgheLai.UseVisualStyleBackColor = True
        '
        'btnLuuDung
        '
        Me.btnLuuDung.Enabled = False
        Me.btnLuuDung.Image = CType(resources.GetObject("btnLuuDung.Image"), System.Drawing.Image)
        Me.btnLuuDung.Location = New System.Drawing.Point(325, 78)
        Me.btnLuuDung.Name = "btnLuuDung"
        Me.btnLuuDung.Size = New System.Drawing.Size(29, 28)
        Me.btnLuuDung.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnLuuDung, "Dừng và lưu file ghi âm")
        Me.btnLuuDung.UseVisualStyleBackColor = True
        '
        'btnGhiAm
        '
        Me.btnGhiAm.AutoSize = True
        Me.btnGhiAm.Image = CType(resources.GetObject("btnGhiAm.Image"), System.Drawing.Image)
        Me.btnGhiAm.Location = New System.Drawing.Point(289, 78)
        Me.btnGhiAm.Name = "btnGhiAm"
        Me.btnGhiAm.Size = New System.Drawing.Size(29, 28)
        Me.btnGhiAm.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnGhiAm, "Ghi âm ví dụ này")
        Me.btnGhiAm.UseVisualStyleBackColor = True
        '
        'btnThemNguPhap
        '
        Me.btnThemNguPhap.BackColor = System.Drawing.Color.LimeGreen
        Me.btnThemNguPhap.Font = New System.Drawing.Font("Times New Roman", 13.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnThemNguPhap.ForeColor = System.Drawing.Color.DarkRed
        Me.btnThemNguPhap.Location = New System.Drawing.Point(14, 498)
        Me.btnThemNguPhap.Name = "btnThemNguPhap"
        Me.btnThemNguPhap.Size = New System.Drawing.Size(414, 33)
        Me.btnThemNguPhap.TabIndex = 12
        Me.btnThemNguPhap.Text = "Thêm ngữ pháp mới"
        Me.ToolTip1.SetToolTip(Me.btnThemNguPhap, "Thêm ngữ pháp mới")
        Me.btnThemNguPhap.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ThemNguPhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 539)
        Me.Controls.Add(Me.btnThemNguPhap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbViDu)
        Me.Controls.Add(Me.rtbCachDung)
        Me.Controls.Add(Me.rtbNguNghia)
        Me.Controls.Add(Me.rtbCauTruc)
        Me.Controls.Add(Me.cbBaiHoc)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ThemNguPhap"
        Me.Text = "Thêm ngữ pháp mới"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbBaiHoc As ComboBox
    Friend WithEvents rtbCauTruc As RichTextBox
    Friend WithEvents rtbNguNghia As RichTextBox
    Friend WithEvents rtbCachDung As RichTextBox
    Friend WithEvents lbViDu As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLamTrong As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThemViDu As Button
    Friend WithEvents tbNguNghia As TextBox
    Friend WithEvents tbViDu As TextBox
    Friend WithEvents btnOpenFile As Label
    Friend WithEvents tbAmDoc As TextBox
    Friend WithEvents btnNgheLai As Button
    Friend WithEvents btnLuuDung As Button
    Friend WithEvents btnGhiAm As Button
    Friend WithEvents btnThemNguPhap As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
