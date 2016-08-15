<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHoiThoai
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucHoiThoai))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.rbResult = New System.Windows.Forms.RichTextBox()
        Me.btnNoiDung = New System.Windows.Forms.Button()
        Me.btnHanTu = New System.Windows.Forms.Button()
        Me.btnDichBai = New System.Windows.Forms.Button()
        Me.lbHoiThoai = New System.Windows.Forms.ListBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(7, 6)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(230, 224)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'rbResult
        '
        Me.rbResult.Location = New System.Drawing.Point(243, 28)
        Me.rbResult.Name = "rbResult"
        Me.rbResult.ReadOnly = True
        Me.rbResult.Size = New System.Drawing.Size(300, 375)
        Me.rbResult.TabIndex = 1
        Me.rbResult.Text = ""
        '
        'btnNoiDung
        '
        Me.btnNoiDung.Location = New System.Drawing.Point(243, 6)
        Me.btnNoiDung.Name = "btnNoiDung"
        Me.btnNoiDung.Size = New System.Drawing.Size(75, 23)
        Me.btnNoiDung.TabIndex = 2
        Me.btnNoiDung.Text = "Nội dung"
        Me.btnNoiDung.UseVisualStyleBackColor = True
        '
        'btnHanTu
        '
        Me.btnHanTu.Location = New System.Drawing.Point(324, 6)
        Me.btnHanTu.Name = "btnHanTu"
        Me.btnHanTu.Size = New System.Drawing.Size(75, 23)
        Me.btnHanTu.TabIndex = 2
        Me.btnHanTu.Text = "Hán tự"
        Me.btnHanTu.UseVisualStyleBackColor = True
        '
        'btnDichBai
        '
        Me.btnDichBai.Location = New System.Drawing.Point(405, 6)
        Me.btnDichBai.Name = "btnDichBai"
        Me.btnDichBai.Size = New System.Drawing.Size(75, 23)
        Me.btnDichBai.TabIndex = 2
        Me.btnDichBai.Text = "Dịch bài"
        Me.btnDichBai.UseVisualStyleBackColor = True
        '
        'lbHoiThoai
        '
        Me.lbHoiThoai.FormattingEnabled = True
        Me.lbHoiThoai.Location = New System.Drawing.Point(8, 243)
        Me.lbHoiThoai.Name = "lbHoiThoai"
        Me.lbHoiThoai.ScrollAlwaysVisible = True
        Me.lbHoiThoai.Size = New System.Drawing.Size(228, 160)
        Me.lbHoiThoai.TabIndex = 3
        '
        'ucHoiThoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbHoiThoai)
        Me.Controls.Add(Me.btnDichBai)
        Me.Controls.Add(Me.btnHanTu)
        Me.Controls.Add(Me.btnNoiDung)
        Me.Controls.Add(Me.rbResult)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "ucHoiThoai"
        Me.Size = New System.Drawing.Size(550, 400)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents rbResult As RichTextBox
    Friend WithEvents btnNoiDung As Button
    Friend WithEvents btnHanTu As Button
    Friend WithEvents btnDichBai As Button
    Friend WithEvents lbHoiThoai As ListBox
End Class
