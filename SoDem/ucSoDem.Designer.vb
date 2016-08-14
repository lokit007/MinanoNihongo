<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSoDem
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
        Me.cbRanDom = New System.Windows.Forms.CheckBox()
        Me.cbShowKanji = New System.Windows.Forms.CheckBox()
        Me.cbShowNguNghia = New System.Windows.Forms.CheckBox()
        Me.cbShowLama = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChinh = New System.Windows.Forms.Button()
        Me.btnTiep = New System.Windows.Forms.Button()
        Me.btnTruoc = New System.Windows.Forms.Button()
        Me.lblThongTin = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbRanDom)
        Me.GroupBox1.Controls.Add(Me.cbShowKanji)
        Me.GroupBox1.Controls.Add(Me.cbShowNguNghia)
        Me.GroupBox1.Controls.Add(Me.cbShowLama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tùy chọn học số đếm"
        '
        'cbRanDom
        '
        Me.cbRanDom.AutoSize = True
        Me.cbRanDom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbRanDom.Location = New System.Drawing.Point(459, 63)
        Me.cbRanDom.Name = "cbRanDom"
        Me.cbRanDom.Size = New System.Drawing.Size(86, 21)
        Me.cbRanDom.TabIndex = 2
        Me.cbRanDom.Text = "Random"
        Me.cbRanDom.UseVisualStyleBackColor = True
        '
        'cbShowKanji
        '
        Me.cbShowKanji.AutoSize = True
        Me.cbShowKanji.Checked = True
        Me.cbShowKanji.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbShowKanji.Location = New System.Drawing.Point(329, 63)
        Me.cbShowKanji.Name = "cbShowKanji"
        Me.cbShowKanji.Size = New System.Drawing.Size(124, 21)
        Me.cbShowKanji.TabIndex = 2
        Me.cbShowKanji.Text = "Hiển thị Kanji"
        Me.cbShowKanji.UseVisualStyleBackColor = True
        '
        'cbShowNguNghia
        '
        Me.cbShowNguNghia.AutoSize = True
        Me.cbShowNguNghia.Checked = True
        Me.cbShowNguNghia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowNguNghia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbShowNguNghia.Location = New System.Drawing.Point(159, 63)
        Me.cbShowNguNghia.Name = "cbShowNguNghia"
        Me.cbShowNguNghia.Size = New System.Drawing.Size(160, 21)
        Me.cbShowNguNghia.TabIndex = 2
        Me.cbShowNguNghia.Text = "Hiển thị ngữ nghĩa"
        Me.cbShowNguNghia.UseVisualStyleBackColor = True
        '
        'cbShowLama
        '
        Me.cbShowLama.AutoSize = True
        Me.cbShowLama.Checked = True
        Me.cbShowLama.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowLama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbShowLama.Location = New System.Drawing.Point(24, 63)
        Me.cbShowLama.Name = "cbShowLama"
        Me.cbShowLama.Size = New System.Drawing.Size(127, 21)
        Me.cbShowLama.TabIndex = 2
        Me.cbShowLama.Text = "Hiển thị Lama"
        Me.cbShowLama.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(547, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số đếm trong tiếng nhật"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChinh
        '
        Me.btnChinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnChinh.ForeColor = System.Drawing.Color.Sienna
        Me.btnChinh.Location = New System.Drawing.Point(8, 105)
        Me.btnChinh.Name = "btnChinh"
        Me.btnChinh.Size = New System.Drawing.Size(559, 249)
        Me.btnChinh.TabIndex = 1
        Me.btnChinh.Text = "ひゃくまん [八百]"
        Me.btnChinh.UseVisualStyleBackColor = True
        '
        'btnTiep
        '
        Me.btnTiep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTiep.Location = New System.Drawing.Point(489, 360)
        Me.btnTiep.Name = "btnTiep"
        Me.btnTiep.Size = New System.Drawing.Size(75, 45)
        Me.btnTiep.TabIndex = 2
        Me.btnTiep.Text = "Số tiếp"
        Me.btnTiep.UseVisualStyleBackColor = True
        '
        'btnTruoc
        '
        Me.btnTruoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTruoc.Location = New System.Drawing.Point(8, 360)
        Me.btnTruoc.Name = "btnTruoc"
        Me.btnTruoc.Size = New System.Drawing.Size(75, 45)
        Me.btnTruoc.TabIndex = 3
        Me.btnTruoc.Text = "Số trước"
        Me.btnTruoc.UseVisualStyleBackColor = True
        '
        'lblThongTin
        '
        Me.lblThongTin.BackColor = System.Drawing.Color.Yellow
        Me.lblThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblThongTin.ForeColor = System.Drawing.Color.Maroon
        Me.lblThongTin.Location = New System.Drawing.Point(91, 363)
        Me.lblThongTin.Name = "lblThongTin"
        Me.lblThongTin.Size = New System.Drawing.Size(392, 42)
        Me.lblThongTin.TabIndex = 4
        Me.lblThongTin.Text = "1 [ichi]"
        Me.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucSoDem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblThongTin)
        Me.Controls.Add(Me.btnTruoc)
        Me.Controls.Add(Me.btnTiep)
        Me.Controls.Add(Me.btnChinh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucSoDem"
        Me.Size = New System.Drawing.Size(575, 415)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbShowKanji As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowNguNghia As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowLama As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChinh As System.Windows.Forms.Button
    Friend WithEvents btnTiep As System.Windows.Forms.Button
    Friend WithEvents btnTruoc As System.Windows.Forms.Button
    Friend WithEvents lblThongTin As System.Windows.Forms.Label
    Friend WithEvents cbRanDom As System.Windows.Forms.CheckBox

End Class
