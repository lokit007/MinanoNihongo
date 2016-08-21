<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChuCai_Parent
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
        Me.btnHinagana = New System.Windows.Forms.Button()
        Me.btnKatakana = New System.Windows.Forms.Button()
        Me.btnTracNghiem = New System.Windows.Forms.Button()
        Me.btnVietTheo = New System.Windows.Forms.Button()
        Me.pnMainControl = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblThongBao = New System.Windows.Forms.Label()
        Me.cbShowLama = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHinagana
        '
        Me.btnHinagana.BackColor = System.Drawing.Color.Lime
        Me.btnHinagana.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHinagana.Location = New System.Drawing.Point(20, 14)
        Me.btnHinagana.Name = "btnHinagana"
        Me.btnHinagana.Size = New System.Drawing.Size(131, 35)
        Me.btnHinagana.TabIndex = 0
        Me.btnHinagana.Text = "Hiragana"
        Me.btnHinagana.UseVisualStyleBackColor = False
        '
        'btnKatakana
        '
        Me.btnKatakana.BackColor = System.Drawing.Color.Lime
        Me.btnKatakana.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnKatakana.Location = New System.Drawing.Point(169, 14)
        Me.btnKatakana.Name = "btnKatakana"
        Me.btnKatakana.Size = New System.Drawing.Size(131, 35)
        Me.btnKatakana.TabIndex = 0
        Me.btnKatakana.Text = "Katakana"
        Me.btnKatakana.UseVisualStyleBackColor = False
        '
        'btnTracNghiem
        '
        Me.btnTracNghiem.BackColor = System.Drawing.Color.Lime
        Me.btnTracNghiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTracNghiem.Location = New System.Drawing.Point(318, 14)
        Me.btnTracNghiem.Name = "btnTracNghiem"
        Me.btnTracNghiem.Size = New System.Drawing.Size(131, 35)
        Me.btnTracNghiem.TabIndex = 0
        Me.btnTracNghiem.Text = "Trắc Nghiệm"
        Me.btnTracNghiem.UseVisualStyleBackColor = False
        '
        'btnVietTheo
        '
        Me.btnVietTheo.BackColor = System.Drawing.Color.Lime
        Me.btnVietTheo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnVietTheo.Location = New System.Drawing.Point(465, 14)
        Me.btnVietTheo.Name = "btnVietTheo"
        Me.btnVietTheo.Size = New System.Drawing.Size(131, 35)
        Me.btnVietTheo.TabIndex = 0
        Me.btnVietTheo.Text = "Viết Theo"
        Me.btnVietTheo.UseVisualStyleBackColor = False
        '
        'pnMainControl
        '
        Me.pnMainControl.AutoScroll = True
        Me.pnMainControl.Location = New System.Drawing.Point(21, 134)
        Me.pnMainControl.Name = "pnMainControl"
        Me.pnMainControl.Size = New System.Drawing.Size(574, 337)
        Me.pnMainControl.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblThongBao)
        Me.Panel2.Controls.Add(Me.cbShowLama)
        Me.Panel2.Location = New System.Drawing.Point(20, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 70)
        Me.Panel2.TabIndex = 2
        '
        'lblThongBao
        '
        Me.lblThongBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblThongBao.ForeColor = System.Drawing.Color.Maroon
        Me.lblThongBao.Location = New System.Drawing.Point(152, 0)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lblThongBao.Size = New System.Drawing.Size(422, 70)
        Me.lblThongBao.TabIndex = 1
        '
        'cbShowLama
        '
        Me.cbShowLama.AutoSize = True
        Me.cbShowLama.Location = New System.Drawing.Point(17, 17)
        Me.cbShowLama.Name = "cbShowLama"
        Me.cbShowLama.Size = New System.Drawing.Size(82, 17)
        Me.cbShowLama.TabIndex = 0
        Me.cbShowLama.Text = "Show Lama"
        Me.cbShowLama.UseVisualStyleBackColor = True
        '
        'ChuCai_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 483)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnMainControl)
        Me.Controls.Add(Me.btnVietTheo)
        Me.Controls.Add(Me.btnTracNghiem)
        Me.Controls.Add(Me.btnKatakana)
        Me.Controls.Add(Me.btnHinagana)
        Me.MaximizeBox = False
        Me.Name = "ChuCai_Parent"
        Me.Text = "Khởi động cùng bản chữ cái nào"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHinagana As System.Windows.Forms.Button
    Friend WithEvents btnKatakana As System.Windows.Forms.Button
    Friend WithEvents btnTracNghiem As System.Windows.Forms.Button
    Friend WithEvents btnVietTheo As System.Windows.Forms.Button
    Friend WithEvents pnMainControl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbShowLama As CheckBox
    Friend WithEvents lblThongBao As System.Windows.Forms.Label
End Class
