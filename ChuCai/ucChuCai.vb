Public Class ucChuCai

    Public Sub initValue(ByVal chu As String, ByVal lama As String, ByVal isShowLama As Boolean)
        btnChuCai.Text = chu
        lblChuCai.Text = lama
        lblChuCai.Visible = isShowLama
    End Sub

    Public Sub ShowLama(ByVal isShowLama As Boolean)
        lblChuCai.Visible = isShowLama
    End Sub

    Private Sub btnChuCai_Click(sender As Object, e As EventArgs) Handles btnChuCai.Click
        'Phát âm thanh đọc
    End Sub
End Class
