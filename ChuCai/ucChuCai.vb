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
        Dim pathAmThanh As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") &
            "\Resources\AudioFiles\ChuCai_" & lblChuCai.Text & ".wav"
        If System.IO.File.Exists(pathAmThanh) Then
            My.Computer.Audio.Play(pathAmThanh, AudioPlayMode.Background)
        End If
    End Sub
End Class
