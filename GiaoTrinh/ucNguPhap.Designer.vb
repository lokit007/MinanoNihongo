<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNguPhap
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
        Me.tbViDu = New System.Windows.Forms.TextBox()
        Me.tbNguNghia = New System.Windows.Forms.TextBox()
        Me.tbCauTruc = New System.Windows.Forms.TextBox()
        Me.tbCachDung = New System.Windows.Forms.TextBox()
        Me.btnThuoc = New System.Windows.Forms.Button()
        Me.btnTiep = New System.Windows.Forms.Button()
        Me.lblTrangThai = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbViDu
        '
        Me.tbViDu.Font = New System.Drawing.Font("MS Gothic", 16.15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbViDu.Location = New System.Drawing.Point(8, 213)
        Me.tbViDu.Multiline = True
        Me.tbViDu.Name = "tbViDu"
        Me.tbViDu.ReadOnly = True
        Me.tbViDu.Size = New System.Drawing.Size(533, 145)
        Me.tbViDu.TabIndex = 4
        Me.tbViDu.Text = "ありがとう"
        '
        'tbNguNghia
        '
        Me.tbNguNghia.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNguNghia.Location = New System.Drawing.Point(8, 65)
        Me.tbNguNghia.Multiline = True
        Me.tbNguNghia.Name = "tbNguNghia"
        Me.tbNguNghia.ReadOnly = True
        Me.tbNguNghia.Size = New System.Drawing.Size(533, 68)
        Me.tbNguNghia.TabIndex = 5
        Me.tbNguNghia.Text = "Cam on nhieu"
        '
        'tbCauTruc
        '
        Me.tbCauTruc.Font = New System.Drawing.Font("MS Gothic", 16.15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbCauTruc.Location = New System.Drawing.Point(8, 9)
        Me.tbCauTruc.Multiline = True
        Me.tbCauTruc.Name = "tbCauTruc"
        Me.tbCauTruc.ReadOnly = True
        Me.tbCauTruc.Size = New System.Drawing.Size(533, 50)
        Me.tbCauTruc.TabIndex = 6
        Me.tbCauTruc.Text = "ありがとう"
        '
        'tbCachDung
        '
        Me.tbCachDung.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCachDung.Location = New System.Drawing.Point(8, 139)
        Me.tbCachDung.Multiline = True
        Me.tbCachDung.Name = "tbCachDung"
        Me.tbCachDung.ReadOnly = True
        Me.tbCachDung.Size = New System.Drawing.Size(533, 68)
        Me.tbCachDung.TabIndex = 5
        Me.tbCachDung.Text = "Cam on nhieu"
        '
        'btnThuoc
        '
        Me.btnThuoc.Location = New System.Drawing.Point(385, 364)
        Me.btnThuoc.Name = "btnThuoc"
        Me.btnThuoc.Size = New System.Drawing.Size(75, 33)
        Me.btnThuoc.TabIndex = 7
        Me.btnThuoc.Text = "Thuộc"
        Me.btnThuoc.UseVisualStyleBackColor = True
        '
        'btnTiep
        '
        Me.btnTiep.Location = New System.Drawing.Point(466, 364)
        Me.btnTiep.Name = "btnTiep"
        Me.btnTiep.Size = New System.Drawing.Size(75, 33)
        Me.btnTiep.TabIndex = 8
        Me.btnTiep.Text = "Tiếp"
        Me.btnTiep.UseVisualStyleBackColor = True
        '
        'lblTrangThai
        '
        Me.lblTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrangThai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrangThai.Location = New System.Drawing.Point(8, 364)
        Me.lblTrangThai.Name = "lblTrangThai"
        Me.lblTrangThai.Size = New System.Drawing.Size(371, 33)
        Me.lblTrangThai.TabIndex = 9
        Me.lblTrangThai.Text = "Label1"
        Me.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucNguPhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTrangThai)
        Me.Controls.Add(Me.btnThuoc)
        Me.Controls.Add(Me.btnTiep)
        Me.Controls.Add(Me.tbViDu)
        Me.Controls.Add(Me.tbCachDung)
        Me.Controls.Add(Me.tbNguNghia)
        Me.Controls.Add(Me.tbCauTruc)
        Me.Name = "ucNguPhap"
        Me.Size = New System.Drawing.Size(550, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbViDu As System.Windows.Forms.TextBox
    Friend WithEvents tbNguNghia As System.Windows.Forms.TextBox
    Friend WithEvents tbCauTruc As System.Windows.Forms.TextBox
    Friend WithEvents tbCachDung As System.Windows.Forms.TextBox
    Friend WithEvents btnThuoc As System.Windows.Forms.Button
    Friend WithEvents btnTiep As System.Windows.Forms.Button
    Friend WithEvents lblTrangThai As System.Windows.Forms.Label

End Class
