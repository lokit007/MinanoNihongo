<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoDem_Parent
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
        Me.btnTienTe = New System.Windows.Forms.Button()
        Me.btnNgayThang = New System.Windows.Forms.Button()
        Me.btnSoDem = New System.Windows.Forms.Button()
        Me.pnMainContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnTienTe
        '
        Me.btnTienTe.BackColor = System.Drawing.Color.Lime
        Me.btnTienTe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTienTe.Location = New System.Drawing.Point(419, 12)
        Me.btnTienTe.Name = "btnTienTe"
        Me.btnTienTe.Size = New System.Drawing.Size(177, 35)
        Me.btnTienTe.TabIndex = 1
        Me.btnTienTe.Text = "Tiền Tệ"
        Me.btnTienTe.UseVisualStyleBackColor = False
        '
        'btnNgayThang
        '
        Me.btnNgayThang.BackColor = System.Drawing.Color.Lime
        Me.btnNgayThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNgayThang.Location = New System.Drawing.Point(220, 12)
        Me.btnNgayThang.Name = "btnNgayThang"
        Me.btnNgayThang.Size = New System.Drawing.Size(177, 35)
        Me.btnNgayThang.TabIndex = 2
        Me.btnNgayThang.Text = "Ngày Tháng"
        Me.btnNgayThang.UseVisualStyleBackColor = False
        '
        'btnSoDem
        '
        Me.btnSoDem.BackColor = System.Drawing.Color.Lime
        Me.btnSoDem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSoDem.Location = New System.Drawing.Point(21, 12)
        Me.btnSoDem.Name = "btnSoDem"
        Me.btnSoDem.Size = New System.Drawing.Size(177, 35)
        Me.btnSoDem.TabIndex = 4
        Me.btnSoDem.Text = "Số Đếm"
        Me.btnSoDem.UseVisualStyleBackColor = False
        '
        'pnMainContent
        '
        Me.pnMainContent.Location = New System.Drawing.Point(21, 56)
        Me.pnMainContent.Name = "pnMainContent"
        Me.pnMainContent.Size = New System.Drawing.Size(575, 415)
        Me.pnMainContent.TabIndex = 5
        '
        'SoDem_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 483)
        Me.Controls.Add(Me.pnMainContent)
        Me.Controls.Add(Me.btnTienTe)
        Me.Controls.Add(Me.btnNgayThang)
        Me.Controls.Add(Me.btnSoDem)
        Me.Name = "SoDem_Parent"
        Me.Text = "Số đếm, số thứ tự, ngày tháng, tiền ..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTienTe As System.Windows.Forms.Button
    Friend WithEvents btnNgayThang As System.Windows.Forms.Button
    Friend WithEvents btnSoDem As System.Windows.Forms.Button
    Friend WithEvents pnMainContent As System.Windows.Forms.Panel
End Class
