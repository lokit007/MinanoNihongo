<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnChao = New System.Windows.Forms.Button()
        Me.btnSoDem = New System.Windows.Forms.Button()
        Me.btnChuCai = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnBaiThi = New System.Windows.Forms.Button()
        Me.btnKanji = New System.Windows.Forms.Button()
        Me.btnTuVung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChao
        '
        Me.btnChao.BackColor = System.Drawing.Color.Green
        Me.btnChao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnChao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChao.Location = New System.Drawing.Point(398, 58)
        Me.btnChao.Name = "btnChao"
        Me.btnChao.Size = New System.Drawing.Size(156, 36)
        Me.btnChao.TabIndex = 10
        Me.btnChao.Text = "Câu Chào Hỏi"
        Me.btnChao.UseVisualStyleBackColor = False
        '
        'btnSoDem
        '
        Me.btnSoDem.BackColor = System.Drawing.Color.Green
        Me.btnSoDem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSoDem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSoDem.Location = New System.Drawing.Point(207, 58)
        Me.btnSoDem.Name = "btnSoDem"
        Me.btnSoDem.Size = New System.Drawing.Size(156, 36)
        Me.btnSoDem.TabIndex = 11
        Me.btnSoDem.Text = "Số Đếm, Ngày, ..."
        Me.btnSoDem.UseVisualStyleBackColor = False
        '
        'btnChuCai
        '
        Me.btnChuCai.BackColor = System.Drawing.Color.Green
        Me.btnChuCai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnChuCai.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChuCai.Location = New System.Drawing.Point(12, 58)
        Me.btnChuCai.Name = "btnChuCai"
        Me.btnChuCai.Size = New System.Drawing.Size(156, 36)
        Me.btnChuCai.TabIndex = 12
        Me.btnChuCai.Text = "Chữ Cái"
        Me.btnChuCai.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("MS Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.ForeColor = System.Drawing.Color.DarkRed
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(543, 46)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Cùng học tiếng nhật Lokit007"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Tomato
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(398, 250)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(157, 120)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnBaiThi
        '
        Me.btnBaiThi.BackColor = System.Drawing.Color.Tomato
        Me.btnBaiThi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBaiThi.Location = New System.Drawing.Point(207, 250)
        Me.btnBaiThi.Name = "btnBaiThi"
        Me.btnBaiThi.Size = New System.Drawing.Size(157, 120)
        Me.btnBaiThi.TabIndex = 4
        Me.btnBaiThi.Text = "Bài Thi"
        Me.btnBaiThi.UseVisualStyleBackColor = False
        '
        'btnKanji
        '
        Me.btnKanji.BackColor = System.Drawing.Color.Tomato
        Me.btnKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnKanji.Location = New System.Drawing.Point(12, 250)
        Me.btnKanji.Name = "btnKanji"
        Me.btnKanji.Size = New System.Drawing.Size(157, 120)
        Me.btnKanji.TabIndex = 5
        Me.btnKanji.Text = "Kanji"
        Me.btnKanji.UseVisualStyleBackColor = False
        '
        'btnTuVung
        '
        Me.btnTuVung.BackColor = System.Drawing.Color.Firebrick
        Me.btnTuVung.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTuVung.ForeColor = System.Drawing.Color.White
        Me.btnTuVung.Location = New System.Drawing.Point(12, 108)
        Me.btnTuVung.Name = "btnTuVung"
        Me.btnTuVung.Size = New System.Drawing.Size(542, 120)
        Me.btnTuVung.TabIndex = 8
        Me.btnTuVung.Text = "Giáo trình Minano Nihongo"
        Me.btnTuVung.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 382)
        Me.Controls.Add(Me.btnChao)
        Me.Controls.Add(Me.btnSoDem)
        Me.Controls.Add(Me.btnChuCai)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBaiThi)
        Me.Controls.Add(Me.btnKanji)
        Me.Controls.Add(Me.btnTuVung)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minano Nihongo cùng lokit007"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnChao As System.Windows.Forms.Button
    Private WithEvents btnSoDem As System.Windows.Forms.Button
    Private WithEvents btnChuCai As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnBaiThi As System.Windows.Forms.Button
    Private WithEvents btnKanji As System.Windows.Forms.Button
    Private WithEvents btnTuVung As System.Windows.Forms.Button

End Class
