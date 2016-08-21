<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemTuVung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemTuVung))
        Me.ptbAnhMinhHoa = New System.Windows.Forms.PictureBox()
        Me.cbBaiHoc = New System.Windows.Forms.ComboBox()
        Me.tbTuVung = New System.Windows.Forms.TextBox()
        Me.tbHanTu = New System.Windows.Forms.TextBox()
        Me.tbNguNghia = New System.Windows.Forms.TextBox()
        Me.lbViDu = New System.Windows.Forms.ListBox()
        Me.btnGhiAm = New System.Windows.Forms.Button()
        Me.btnLuuDung = New System.Windows.Forms.Button()
        Me.btnNgheLai = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbAmDieu = New System.Windows.Forms.TextBox()
        Me.lbDinhKem = New System.Windows.Forms.Label()
        Me.tbViDu = New System.Windows.Forms.TextBox()
        Me.tbDichNghia = New System.Windows.Forms.TextBox()
        Me.btnThemViDu = New System.Windows.Forms.Button()
        Me.btnXoaTrong = New System.Windows.Forms.Button()
        Me.btnXoaViDu = New System.Windows.Forms.Button()
        Me.btnThemTuVung = New System.Windows.Forms.Button()
        CType(Me.ptbAnhMinhHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbAnhMinhHoa
        '
        Me.ptbAnhMinhHoa.BackgroundImage = CType(resources.GetObject("ptbAnhMinhHoa.BackgroundImage"), System.Drawing.Image)
        Me.ptbAnhMinhHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbAnhMinhHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbAnhMinhHoa.Location = New System.Drawing.Point(10, 42)
        Me.ptbAnhMinhHoa.Name = "ptbAnhMinhHoa"
        Me.ptbAnhMinhHoa.Size = New System.Drawing.Size(215, 226)
        Me.ptbAnhMinhHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAnhMinhHoa.TabIndex = 0
        Me.ptbAnhMinhHoa.TabStop = False
        '
        'cbBaiHoc
        '
        Me.cbBaiHoc.FormattingEnabled = True
        Me.cbBaiHoc.Location = New System.Drawing.Point(10, 15)
        Me.cbBaiHoc.Name = "cbBaiHoc"
        Me.cbBaiHoc.Size = New System.Drawing.Size(215, 21)
        Me.cbBaiHoc.TabIndex = 1
        Me.cbBaiHoc.Text = "Thêm vào bài"
        '
        'tbTuVung
        '
        Me.tbTuVung.Location = New System.Drawing.Point(231, 15)
        Me.tbTuVung.Multiline = True
        Me.tbTuVung.Name = "tbTuVung"
        Me.tbTuVung.Size = New System.Drawing.Size(297, 60)
        Me.tbTuVung.TabIndex = 2
        Me.tbTuVung.Text = "Từ vựng"
        '
        'tbHanTu
        '
        Me.tbHanTu.Location = New System.Drawing.Point(231, 81)
        Me.tbHanTu.Multiline = True
        Me.tbHanTu.Name = "tbHanTu"
        Me.tbHanTu.Size = New System.Drawing.Size(297, 60)
        Me.tbHanTu.TabIndex = 2
        Me.tbHanTu.Text = "Hán tự"
        '
        'tbNguNghia
        '
        Me.tbNguNghia.Location = New System.Drawing.Point(231, 147)
        Me.tbNguNghia.Multiline = True
        Me.tbNguNghia.Name = "tbNguNghia"
        Me.tbNguNghia.Size = New System.Drawing.Size(297, 60)
        Me.tbNguNghia.TabIndex = 2
        Me.tbNguNghia.Text = "Ngữ nghĩa"
        '
        'lbViDu
        '
        Me.lbViDu.FormattingEnabled = True
        Me.lbViDu.Location = New System.Drawing.Point(8, 274)
        Me.lbViDu.Name = "lbViDu"
        Me.lbViDu.ScrollAlwaysVisible = True
        Me.lbViDu.Size = New System.Drawing.Size(519, 121)
        Me.lbViDu.TabIndex = 4
        '
        'btnGhiAm
        '
        Me.btnGhiAm.AutoSize = True
        Me.btnGhiAm.Image = CType(resources.GetObject("btnGhiAm.Image"), System.Drawing.Image)
        Me.btnGhiAm.Location = New System.Drawing.Point(443, 209)
        Me.btnGhiAm.Name = "btnGhiAm"
        Me.btnGhiAm.Size = New System.Drawing.Size(25, 24)
        Me.btnGhiAm.TabIndex = 5
        Me.btnGhiAm.UseVisualStyleBackColor = True
        '
        'btnLuuDung
        '
        Me.btnLuuDung.Image = CType(resources.GetObject("btnLuuDung.Image"), System.Drawing.Image)
        Me.btnLuuDung.Location = New System.Drawing.Point(474, 209)
        Me.btnLuuDung.Name = "btnLuuDung"
        Me.btnLuuDung.Size = New System.Drawing.Size(25, 24)
        Me.btnLuuDung.TabIndex = 5
        Me.btnLuuDung.UseVisualStyleBackColor = True
        '
        'btnNgheLai
        '
        Me.btnNgheLai.Image = CType(resources.GetObject("btnNgheLai.Image"), System.Drawing.Image)
        Me.btnNgheLai.Location = New System.Drawing.Point(502, 209)
        Me.btnNgheLai.Name = "btnNgheLai"
        Me.btnNgheLai.Size = New System.Drawing.Size(25, 24)
        Me.btnNgheLai.TabIndex = 5
        Me.btnNgheLai.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tbAmDieu
        '
        Me.tbAmDieu.Location = New System.Drawing.Point(231, 213)
        Me.tbAmDieu.Name = "tbAmDieu"
        Me.tbAmDieu.ReadOnly = True
        Me.tbAmDieu.Size = New System.Drawing.Size(206, 20)
        Me.tbAmDieu.TabIndex = 6
        '
        'lbDinhKem
        '
        Me.lbDinhKem.Image = CType(resources.GetObject("lbDinhKem.Image"), System.Drawing.Image)
        Me.lbDinhKem.Location = New System.Drawing.Point(416, 214)
        Me.lbDinhKem.Name = "lbDinhKem"
        Me.lbDinhKem.Size = New System.Drawing.Size(16, 16)
        Me.lbDinhKem.TabIndex = 7
        '
        'tbViDu
        '
        Me.tbViDu.Location = New System.Drawing.Point(8, 408)
        Me.tbViDu.Multiline = True
        Me.tbViDu.Name = "tbViDu"
        Me.tbViDu.Size = New System.Drawing.Size(519, 38)
        Me.tbViDu.TabIndex = 9
        Me.tbViDu.Text = "Ví dụ minh họa ..."
        '
        'tbDichNghia
        '
        Me.tbDichNghia.Location = New System.Drawing.Point(8, 452)
        Me.tbDichNghia.Multiline = True
        Me.tbDichNghia.Name = "tbDichNghia"
        Me.tbDichNghia.Size = New System.Drawing.Size(519, 38)
        Me.tbDichNghia.TabIndex = 9
        Me.tbDichNghia.Text = "Dịch nghĩa câu ví dụ ..."
        '
        'btnThemViDu
        '
        Me.btnThemViDu.Location = New System.Drawing.Point(453, 496)
        Me.btnThemViDu.Name = "btnThemViDu"
        Me.btnThemViDu.Size = New System.Drawing.Size(75, 23)
        Me.btnThemViDu.TabIndex = 10
        Me.btnThemViDu.Text = "Thêm ví dụ"
        Me.btnThemViDu.UseVisualStyleBackColor = True
        '
        'btnXoaTrong
        '
        Me.btnXoaTrong.Location = New System.Drawing.Point(372, 496)
        Me.btnXoaTrong.Name = "btnXoaTrong"
        Me.btnXoaTrong.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaTrong.TabIndex = 10
        Me.btnXoaTrong.Text = "Xóa trống"
        Me.btnXoaTrong.UseVisualStyleBackColor = True
        '
        'btnXoaViDu
        '
        Me.btnXoaViDu.Location = New System.Drawing.Point(291, 496)
        Me.btnXoaViDu.Name = "btnXoaViDu"
        Me.btnXoaViDu.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaViDu.TabIndex = 10
        Me.btnXoaViDu.Text = "Xóa ví dụ"
        Me.btnXoaViDu.UseVisualStyleBackColor = True
        '
        'btnThemTuVung
        '
        Me.btnThemTuVung.BackColor = System.Drawing.Color.LimeGreen
        Me.btnThemTuVung.Font = New System.Drawing.Font("Times New Roman", 13.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnThemTuVung.ForeColor = System.Drawing.Color.DarkRed
        Me.btnThemTuVung.Location = New System.Drawing.Point(231, 239)
        Me.btnThemTuVung.Name = "btnThemTuVung"
        Me.btnThemTuVung.Size = New System.Drawing.Size(296, 29)
        Me.btnThemTuVung.TabIndex = 11
        Me.btnThemTuVung.Text = "Thêm từ vựng mới"
        Me.btnThemTuVung.UseVisualStyleBackColor = False
        '
        'ThemTuVung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 525)
        Me.Controls.Add(Me.btnThemTuVung)
        Me.Controls.Add(Me.btnXoaViDu)
        Me.Controls.Add(Me.btnXoaTrong)
        Me.Controls.Add(Me.btnThemViDu)
        Me.Controls.Add(Me.tbDichNghia)
        Me.Controls.Add(Me.tbViDu)
        Me.Controls.Add(Me.lbDinhKem)
        Me.Controls.Add(Me.tbAmDieu)
        Me.Controls.Add(Me.btnNgheLai)
        Me.Controls.Add(Me.btnLuuDung)
        Me.Controls.Add(Me.btnGhiAm)
        Me.Controls.Add(Me.lbViDu)
        Me.Controls.Add(Me.tbNguNghia)
        Me.Controls.Add(Me.tbHanTu)
        Me.Controls.Add(Me.tbTuVung)
        Me.Controls.Add(Me.cbBaiHoc)
        Me.Controls.Add(Me.ptbAnhMinhHoa)
        Me.MaximizeBox = False
        Me.Name = "ThemTuVung"
        Me.Text = "Thêm từ vựng mới"
        CType(Me.ptbAnhMinhHoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbAnhMinhHoa As PictureBox
    Friend WithEvents cbBaiHoc As ComboBox
    Friend WithEvents tbTuVung As TextBox
    Friend WithEvents tbHanTu As TextBox
    Friend WithEvents tbNguNghia As TextBox
    Friend WithEvents lbViDu As ListBox
    Friend WithEvents btnGhiAm As Button
    Friend WithEvents btnLuuDung As Button
    Friend WithEvents btnNgheLai As Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tbAmDieu As System.Windows.Forms.TextBox
    Friend WithEvents lbDinhKem As System.Windows.Forms.Label
    Friend WithEvents tbViDu As System.Windows.Forms.TextBox
    Friend WithEvents tbDichNghia As System.Windows.Forms.TextBox
    Friend WithEvents btnThemViDu As System.Windows.Forms.Button
    Friend WithEvents btnXoaTrong As System.Windows.Forms.Button
    Friend WithEvents btnXoaViDu As System.Windows.Forms.Button
    Friend WithEvents btnThemTuVung As System.Windows.Forms.Button
End Class
