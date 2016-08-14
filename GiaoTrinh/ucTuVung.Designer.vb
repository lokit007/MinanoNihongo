<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTuVung
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
        Me.pcbAnhMinhHoa = New System.Windows.Forms.PictureBox()
        Me.rbtnShowAll = New System.Windows.Forms.RadioButton()
        Me.rbtnNhapTuVung = New System.Windows.Forms.RadioButton()
        Me.rbtnDichNghia = New System.Windows.Forms.RadioButton()
        Me.tbTuVung = New System.Windows.Forms.TextBox()
        Me.tbHanTu = New System.Windows.Forms.TextBox()
        Me.tbNguNghia = New System.Windows.Forms.TextBox()
        Me.tbViDu = New System.Windows.Forms.TextBox()
        Me.btnTiep = New System.Windows.Forms.Button()
        Me.btnThuoc = New System.Windows.Forms.Button()
        Me.btnKiemTra = New System.Windows.Forms.Button()
        Me.btnNgheLai = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbAnhMinhHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbAnhMinhHoa
        '
        Me.pcbAnhMinhHoa.Location = New System.Drawing.Point(6, 8)
        Me.pcbAnhMinhHoa.Name = "pcbAnhMinhHoa"
        Me.pcbAnhMinhHoa.Size = New System.Drawing.Size(208, 246)
        Me.pcbAnhMinhHoa.TabIndex = 0
        Me.pcbAnhMinhHoa.TabStop = False
        '
        'rbtnShowAll
        '
        Me.rbtnShowAll.AutoSize = True
        Me.rbtnShowAll.Checked = True
        Me.rbtnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShowAll.Location = New System.Drawing.Point(6, 260)
        Me.rbtnShowAll.Name = "rbtnShowAll"
        Me.rbtnShowAll.Size = New System.Drawing.Size(86, 22)
        Me.rbtnShowAll.TabIndex = 1
        Me.rbtnShowAll.TabStop = True
        Me.rbtnShowAll.Text = "ShowAll"
        Me.rbtnShowAll.UseVisualStyleBackColor = True
        '
        'rbtnNhapTuVung
        '
        Me.rbtnNhapTuVung.AutoSize = True
        Me.rbtnNhapTuVung.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNhapTuVung.Location = New System.Drawing.Point(6, 288)
        Me.rbtnNhapTuVung.Name = "rbtnNhapTuVung"
        Me.rbtnNhapTuVung.Size = New System.Drawing.Size(131, 22)
        Me.rbtnNhapTuVung.TabIndex = 2
        Me.rbtnNhapTuVung.Text = "Nhập Từ Vựng"
        Me.rbtnNhapTuVung.UseVisualStyleBackColor = True
        '
        'rbtnDichNghia
        '
        Me.rbtnDichNghia.AutoSize = True
        Me.rbtnDichNghia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDichNghia.Location = New System.Drawing.Point(6, 316)
        Me.rbtnDichNghia.Name = "rbtnDichNghia"
        Me.rbtnDichNghia.Size = New System.Drawing.Size(132, 22)
        Me.rbtnDichNghia.TabIndex = 2
        Me.rbtnDichNghia.Text = "Dịch Nghĩa Từ"
        Me.rbtnDichNghia.UseVisualStyleBackColor = True
        '
        'tbTuVung
        '
        Me.tbTuVung.Location = New System.Drawing.Point(223, 9)
        Me.tbTuVung.Multiline = True
        Me.tbTuVung.Name = "tbTuVung"
        Me.tbTuVung.ReadOnly = True
        Me.tbTuVung.Size = New System.Drawing.Size(318, 50)
        Me.tbTuVung.TabIndex = 3
        '
        'tbHanTu
        '
        Me.tbHanTu.Location = New System.Drawing.Point(223, 65)
        Me.tbHanTu.Multiline = True
        Me.tbHanTu.Name = "tbHanTu"
        Me.tbHanTu.ReadOnly = True
        Me.tbHanTu.Size = New System.Drawing.Size(318, 50)
        Me.tbHanTu.TabIndex = 3
        '
        'tbNguNghia
        '
        Me.tbNguNghia.Location = New System.Drawing.Point(223, 121)
        Me.tbNguNghia.Multiline = True
        Me.tbNguNghia.Name = "tbNguNghia"
        Me.tbNguNghia.ReadOnly = True
        Me.tbNguNghia.Size = New System.Drawing.Size(318, 88)
        Me.tbNguNghia.TabIndex = 3
        '
        'tbViDu
        '
        Me.tbViDu.Location = New System.Drawing.Point(223, 215)
        Me.tbViDu.Multiline = True
        Me.tbViDu.Name = "tbViDu"
        Me.tbViDu.ReadOnly = True
        Me.tbViDu.Size = New System.Drawing.Size(318, 134)
        Me.tbViDu.TabIndex = 3
        '
        'btnTiep
        '
        Me.btnTiep.Location = New System.Drawing.Point(466, 355)
        Me.btnTiep.Name = "btnTiep"
        Me.btnTiep.Size = New System.Drawing.Size(75, 33)
        Me.btnTiep.TabIndex = 4
        Me.btnTiep.Text = "Tiếp"
        Me.btnTiep.UseVisualStyleBackColor = True
        '
        'btnThuoc
        '
        Me.btnThuoc.Location = New System.Drawing.Point(385, 355)
        Me.btnThuoc.Name = "btnThuoc"
        Me.btnThuoc.Size = New System.Drawing.Size(75, 33)
        Me.btnThuoc.TabIndex = 4
        Me.btnThuoc.Text = "Thuộc"
        Me.btnThuoc.UseVisualStyleBackColor = True
        '
        'btnKiemTra
        '
        Me.btnKiemTra.Location = New System.Drawing.Point(304, 355)
        Me.btnKiemTra.Name = "btnKiemTra"
        Me.btnKiemTra.Size = New System.Drawing.Size(75, 33)
        Me.btnKiemTra.TabIndex = 4
        Me.btnKiemTra.Text = "Kiểm Tra"
        Me.btnKiemTra.UseVisualStyleBackColor = True
        '
        'btnNgheLai
        '
        Me.btnNgheLai.Location = New System.Drawing.Point(223, 355)
        Me.btnNgheLai.Name = "btnNgheLai"
        Me.btnNgheLai.Size = New System.Drawing.Size(75, 33)
        Me.btnNgheLai.TabIndex = 4
        Me.btnNgheLai.Text = "Nghe lại"
        Me.btnNgheLai.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucTuVung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNgheLai)
        Me.Controls.Add(Me.btnKiemTra)
        Me.Controls.Add(Me.btnThuoc)
        Me.Controls.Add(Me.btnTiep)
        Me.Controls.Add(Me.tbViDu)
        Me.Controls.Add(Me.tbNguNghia)
        Me.Controls.Add(Me.tbHanTu)
        Me.Controls.Add(Me.tbTuVung)
        Me.Controls.Add(Me.rbtnDichNghia)
        Me.Controls.Add(Me.rbtnNhapTuVung)
        Me.Controls.Add(Me.rbtnShowAll)
        Me.Controls.Add(Me.pcbAnhMinhHoa)
        Me.Name = "ucTuVung"
        Me.Size = New System.Drawing.Size(550, 400)
        CType(Me.pcbAnhMinhHoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbAnhMinhHoa As PictureBox
    Friend WithEvents rbtnShowAll As RadioButton
    Friend WithEvents rbtnNhapTuVung As RadioButton
    Friend WithEvents rbtnDichNghia As RadioButton
    Friend WithEvents tbTuVung As TextBox
    Friend WithEvents tbHanTu As TextBox
    Friend WithEvents tbNguNghia As TextBox
    Friend WithEvents tbViDu As TextBox
    Friend WithEvents btnTiep As Button
    Friend WithEvents btnThuoc As Button
    Friend WithEvents btnKiemTra As Button
    Friend WithEvents btnNgheLai As Button
    Friend WithEvents Label1 As Label
End Class
