<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kanji_Parent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblKanji = New System.Windows.Forms.Label()
        Me.lblAmHan = New System.Windows.Forms.Label()
        Me.lblNghia = New System.Windows.Forms.Label()
        Me.btnTiep = New System.Windows.Forms.Button()
        Me.btnTruoc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(774, 333)
        Me.DataGridView1.TabIndex = 0
        '
        'lblKanji
        '
        Me.lblKanji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanji.Font = New System.Drawing.Font("Times New Roman", 70.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKanji.Location = New System.Drawing.Point(6, 345)
        Me.lblKanji.Name = "lblKanji"
        Me.lblKanji.Size = New System.Drawing.Size(220, 117)
        Me.lblKanji.TabIndex = 1
        Me.lblKanji.Text = "Lab"
        Me.lblKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmHan
        '
        Me.lblAmHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmHan.Font = New System.Drawing.Font("Times New Roman", 25.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmHan.Location = New System.Drawing.Point(232, 345)
        Me.lblAmHan.Name = "lblAmHan"
        Me.lblAmHan.Size = New System.Drawing.Size(409, 44)
        Me.lblAmHan.TabIndex = 1
        Me.lblAmHan.Text = "Lab"
        Me.lblAmHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNghia
        '
        Me.lblNghia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNghia.Font = New System.Drawing.Font("Times New Roman", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNghia.Location = New System.Drawing.Point(232, 401)
        Me.lblNghia.Name = "lblNghia"
        Me.lblNghia.Size = New System.Drawing.Size(409, 61)
        Me.lblNghia.TabIndex = 1
        Me.lblNghia.Text = "Lab"
        '
        'btnTiep
        '
        Me.btnTiep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiep.Location = New System.Drawing.Point(647, 347)
        Me.btnTiep.Name = "btnTiep"
        Me.btnTiep.Size = New System.Drawing.Size(129, 23)
        Me.btnTiep.TabIndex = 2
        Me.btnTiep.Text = "Chữ Sau"
        Me.btnTiep.UseVisualStyleBackColor = True
        '
        'btnTruoc
        '
        Me.btnTruoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruoc.Location = New System.Drawing.Point(647, 376)
        Me.btnTruoc.Name = "btnTruoc"
        Me.btnTruoc.Size = New System.Drawing.Size(129, 23)
        Me.btnTruoc.TabIndex = 2
        Me.btnTruoc.Text = "Chữ Trước"
        Me.btnTruoc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(647, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Trở về trang chủ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Kanji_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 471)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTruoc)
        Me.Controls.Add(Me.btnTiep)
        Me.Controls.Add(Me.lblNghia)
        Me.Controls.Add(Me.lblAmHan)
        Me.Controls.Add(Me.lblKanji)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Kanji_Parent"
        Me.Text = "Kanji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblKanji As Label
    Friend WithEvents lblAmHan As Label
    Friend WithEvents lblNghia As Label
    Friend WithEvents btnTiep As Button
    Friend WithEvents btnTruoc As Button
    Friend WithEvents btnClose As Button
End Class
