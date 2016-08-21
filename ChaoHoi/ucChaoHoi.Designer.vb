<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChaoHoi
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
        Me.lblCau = New System.Windows.Forms.Label()
        Me.lblNghia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCau
        '
        Me.lblCau.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCau.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCau.Location = New System.Drawing.Point(3, 1)
        Me.lblCau.Name = "lblCau"
        Me.lblCau.Size = New System.Drawing.Size(565, 38)
        Me.lblCau.TabIndex = 0
        Me.lblCau.Text = "Label1"
        Me.lblCau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNghia
        '
        Me.lblNghia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNghia.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNghia.Location = New System.Drawing.Point(3, 39)
        Me.lblNghia.Name = "lblNghia"
        Me.lblNghia.Size = New System.Drawing.Size(565, 31)
        Me.lblNghia.TabIndex = 0
        Me.lblNghia.Text = "Label1"
        Me.lblNghia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucChaoHoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.lblNghia)
        Me.Controls.Add(Me.lblCau)
        Me.Name = "ucChaoHoi"
        Me.Size = New System.Drawing.Size(548, 66)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCau As Label
    Friend WithEvents lblNghia As Label
End Class
