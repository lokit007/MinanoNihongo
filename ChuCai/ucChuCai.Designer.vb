<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChuCai
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
        Me.btnChuCai = New System.Windows.Forms.Button()
        Me.lblChuCai = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChuCai
        '
        Me.btnChuCai.BackColor = System.Drawing.Color.MistyRose
        Me.btnChuCai.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChuCai.Location = New System.Drawing.Point(7, 3)
        Me.btnChuCai.Name = "btnChuCai"
        Me.btnChuCai.Size = New System.Drawing.Size(80, 68)
        Me.btnChuCai.TabIndex = 0
        Me.btnChuCai.Text = "キャ"
        Me.btnChuCai.UseVisualStyleBackColor = False
        '
        'lblChuCai
        '
        Me.lblChuCai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChuCai.Location = New System.Drawing.Point(7, 70)
        Me.lblChuCai.Name = "lblChuCai"
        Me.lblChuCai.Size = New System.Drawing.Size(80, 23)
        Me.lblChuCai.TabIndex = 1
        Me.lblChuCai.Text = "lama"
        Me.lblChuCai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucChuCai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblChuCai)
        Me.Controls.Add(Me.btnChuCai)
        Me.Name = "ucChuCai"
        Me.Size = New System.Drawing.Size(95, 95)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnChuCai As Button
    Friend WithEvents lblChuCai As Label
End Class
