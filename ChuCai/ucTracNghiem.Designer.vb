<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTracNghiem
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbAllChuCai = New System.Windows.Forms.RadioButton()
        Me.rdbKatakana = New System.Windows.Forms.RadioButton()
        Me.rdbHinagana = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSoTuSai = New System.Windows.Forms.Label()
        Me.lblSoTuDung = New System.Windows.Forms.Label()
        Me.lblTong = New System.Windows.Forms.Label()
        Me.lblCauHoi = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTraLoi4 = New System.Windows.Forms.Button()
        Me.btnTraLoi3 = New System.Windows.Forms.Button()
        Me.btnTraLoi2 = New System.Windows.Forms.Button()
        Me.btnTraLoi1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbAllChuCai)
        Me.GroupBox1.Controls.Add(Me.rdbKatakana)
        Me.GroupBox1.Controls.Add(Me.rdbHinagana)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn bảng chữ cái mong muốn"
        '
        'rdbAllChuCai
        '
        Me.rdbAllChuCai.AutoSize = True
        Me.rdbAllChuCai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbAllChuCai.Location = New System.Drawing.Point(18, 91)
        Me.rdbAllChuCai.Name = "rdbAllChuCai"
        Me.rdbAllChuCai.Size = New System.Drawing.Size(152, 19)
        Me.rdbAllChuCai.TabIndex = 1
        Me.rdbAllChuCai.Text = "Cả hai bảng chữ cái"
        Me.rdbAllChuCai.UseVisualStyleBackColor = True
        '
        'rdbKatakana
        '
        Me.rdbKatakana.AutoSize = True
        Me.rdbKatakana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbKatakana.Location = New System.Drawing.Point(18, 66)
        Me.rdbKatakana.Name = "rdbKatakana"
        Me.rdbKatakana.Size = New System.Drawing.Size(122, 19)
        Me.rdbKatakana.TabIndex = 1
        Me.rdbKatakana.Text = "Bảng Katakana"
        Me.rdbKatakana.UseVisualStyleBackColor = True
        '
        'rdbHinagana
        '
        Me.rdbHinagana.AutoSize = True
        Me.rdbHinagana.Checked = True
        Me.rdbHinagana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbHinagana.Location = New System.Drawing.Point(18, 41)
        Me.rdbHinagana.Name = "rdbHinagana"
        Me.rdbHinagana.Size = New System.Drawing.Size(124, 19)
        Me.rdbHinagana.TabIndex = 0
        Me.rdbHinagana.TabStop = True
        Me.rdbHinagana.Text = "Bảng Hinagana"
        Me.rdbHinagana.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSoTuSai)
        Me.GroupBox2.Controls.Add(Me.lblSoTuDung)
        Me.GroupBox2.Controls.Add(Me.lblTong)
        Me.GroupBox2.Controls.Add(Me.lblCauHoi)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Câu hỏi và quá trình học"
        '
        'lblSoTuSai
        '
        Me.lblSoTuSai.AutoSize = True
        Me.lblSoTuSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(128, Byte))
        Me.lblSoTuSai.ForeColor = System.Drawing.Color.Red
        Me.lblSoTuSai.Location = New System.Drawing.Point(172, 89)
        Me.lblSoTuSai.Name = "lblSoTuSai"
        Me.lblSoTuSai.Size = New System.Drawing.Size(108, 18)
        Me.lblSoTuSai.TabIndex = 1
        Me.lblSoTuSai.Text = "Số từ sai : 10"
        '
        'lblSoTuDung
        '
        Me.lblSoTuDung.AutoSize = True
        Me.lblSoTuDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(128, Byte))
        Me.lblSoTuDung.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblSoTuDung.Location = New System.Drawing.Point(172, 58)
        Me.lblSoTuDung.Name = "lblSoTuDung"
        Me.lblSoTuDung.Size = New System.Drawing.Size(122, 18)
        Me.lblSoTuDung.TabIndex = 1
        Me.lblSoTuDung.Text = "Số từ đúng : 90"
        '
        'lblTong
        '
        Me.lblTong.AutoSize = True
        Me.lblTong.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(128, Byte))
        Me.lblTong.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTong.Location = New System.Drawing.Point(172, 28)
        Me.lblTong.Name = "lblTong"
        Me.lblTong.Size = New System.Drawing.Size(131, 18)
        Me.lblTong.TabIndex = 1
        Me.lblTong.Text = "Tổng số từ : 100"
        '
        'lblCauHoi
        '
        Me.lblCauHoi.BackColor = System.Drawing.Color.Lime
        Me.lblCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCauHoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCauHoi.Location = New System.Drawing.Point(11, 21)
        Me.lblCauHoi.Name = "lblCauHoi"
        Me.lblCauHoi.Padding = New System.Windows.Forms.Padding(5, 13, 0, 0)
        Me.lblCauHoi.Size = New System.Drawing.Size(155, 101)
        Me.lblCauHoi.TabIndex = 0
        Me.lblCauHoi.Text = "wa"
        Me.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTraLoi4)
        Me.GroupBox3.Controls.Add(Me.btnTraLoi3)
        Me.GroupBox3.Controls.Add(Me.btnTraLoi2)
        Me.GroupBox3.Controls.Add(Me.btnTraLoi1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 169)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chọn đáp án [Click vào đáp án]"
        '
        'btnTraLoi4
        '
        Me.btnTraLoi4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTraLoi4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTraLoi4.Location = New System.Drawing.Point(411, 32)
        Me.btnTraLoi4.Name = "btnTraLoi4"
        Me.btnTraLoi4.Size = New System.Drawing.Size(123, 115)
        Me.btnTraLoi4.TabIndex = 0
        Me.btnTraLoi4.Text = "ひゃ"
        Me.btnTraLoi4.UseVisualStyleBackColor = False
        '
        'btnTraLoi3
        '
        Me.btnTraLoi3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTraLoi3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTraLoi3.Location = New System.Drawing.Point(282, 32)
        Me.btnTraLoi3.Name = "btnTraLoi3"
        Me.btnTraLoi3.Size = New System.Drawing.Size(123, 115)
        Me.btnTraLoi3.TabIndex = 0
        Me.btnTraLoi3.Text = "ひゃ"
        Me.btnTraLoi3.UseVisualStyleBackColor = False
        '
        'btnTraLoi2
        '
        Me.btnTraLoi2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTraLoi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTraLoi2.Location = New System.Drawing.Point(153, 32)
        Me.btnTraLoi2.Name = "btnTraLoi2"
        Me.btnTraLoi2.Size = New System.Drawing.Size(123, 115)
        Me.btnTraLoi2.TabIndex = 0
        Me.btnTraLoi2.Text = "ひゃ"
        Me.btnTraLoi2.UseVisualStyleBackColor = False
        '
        'btnTraLoi1
        '
        Me.btnTraLoi1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTraLoi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTraLoi1.Location = New System.Drawing.Point(24, 32)
        Me.btnTraLoi1.Name = "btnTraLoi1"
        Me.btnTraLoi1.Size = New System.Drawing.Size(123, 115)
        Me.btnTraLoi1.TabIndex = 0
        Me.btnTraLoi1.Text = "ひゃ"
        Me.btnTraLoi1.UseVisualStyleBackColor = False
        '
        'ucTracNghiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucTracNghiem"
        Me.Size = New System.Drawing.Size(574, 337)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbKatakana As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHinagana As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAllChuCai As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSoTuSai As System.Windows.Forms.Label
    Friend WithEvents lblSoTuDung As System.Windows.Forms.Label
    Friend WithEvents lblTong As System.Windows.Forms.Label
    Friend WithEvents lblCauHoi As System.Windows.Forms.Label
    Friend WithEvents btnTraLoi4 As System.Windows.Forms.Button
    Friend WithEvents btnTraLoi3 As System.Windows.Forms.Button
    Friend WithEvents btnTraLoi2 As System.Windows.Forms.Button
    Friend WithEvents btnTraLoi1 As System.Windows.Forms.Button

End Class
